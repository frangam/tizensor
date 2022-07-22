S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14453
Date: 2018-06-07 17:01:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf759e52d, r5   = 0xf7a15f98
r6   = 0xffa1f040, r7   = 0xffa1eef0
r8   = 0xf7a12c18, r9   = 0x00000000
r10  = 0xffa1efcc, fp   = 0xffa1f040
ip   = 0x00000001, sp   = 0xffa1eec8
lr   = 0xf759e539, pc   = 0xf7607228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     71288 KB
Buffers:      7740 KB
Cached:      49796 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11632 KB
VmRSS:       11628 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14453 TID = 14453
14453 14457 

Maps Information
f4469000 f4c68000 rw-p [stack:14457]
f4c6f000 f4c71000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c79000 f4c7d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c86000 f4c88000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c90000 f4c93000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ca2000 f4ca7000 r-xp /usr/lib/libsystem.so.0.0.0
f4cb2000 f4cb5000 r-xp /lib/libattr.so.1.1.0
f4cbd000 f4ccd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cd5000 f4cde000 r-xp /usr/lib/libedbus.so.1.7.99
f4ce6000 f4ce7000 r-xp /usr/lib/libresponse.so.0.2.96
f4cf0000 f4cf5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6597000 f669d000 r-xp /usr/lib/libicuuc.so.57.1
f66b3000 f683b000 r-xp /usr/lib/libicui18n.so.57.1
f684b000 f6858000 r-xp /usr/lib/libail.so.0.1.0
f6861000 f6868000 r-xp /usr/lib/libminizip.so.1.0.0
f6871000 f6a1a000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a3a000 f6a81000 r-xp /usr/lib/libssl.so.1.0.0
f6a8d000 f6a8f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a97000 f6a9e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6aa7000 f6aae000 r-xp /lib/libcrypt-2.13.so
f6adf000 f6ae2000 r-xp /lib/libcap.so.2.21
f6aea000 f6aec000 r-xp /usr/lib/libiri.so
f6af4000 f6b3d000 r-xp /usr/lib/libmdm.so.1.2.69
f6b45000 f6b4b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b53000 f6b76000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b80000 f6b82000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b8a000 f6ba7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb0000 f6bb4000 r-xp /usr/lib/libsmack.so.1.0.0
f6bbd000 f6bd6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bdf000 f6be7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bef000 f6bf5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bfe000 f6c00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c09000 f6c19000 r-xp /lib/libresolv-2.13.so
f6c1d000 f6c35000 r-xp /usr/lib/liblzma.so.5.0.3
f6c3e000 f6c40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c48000 f6c62000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c6a000 f6c99000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ca2000 f6cb1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cbb000 f6cc5000 r-xp /usr/lib/libsensord-shared.so
f6cce000 f6da1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dac000 f6dc2000 r-xp /lib/libz.so.1.2.5
f6dca000 f6dcf000 r-xp /usr/lib/libffi.so.5.0.10
f6dd7000 f6dd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6de0000 f6df0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6df8000 f6e11000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e19000 f6e1b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e23000 f6e98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ea2000 f6ea8000 r-xp /lib/librt-2.13.so
f6eb1000 f6ecf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ed9000 f6eda000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ee2000 f6f05000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f0d000 f6f12000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f1a000 f6f44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f4d000 f6f64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f6c000 f6fd5000 r-xp /lib/libm-2.13.so
f6fde000 f7072000 r-xp /usr/lib/libstdc++.so.6.0.16
f7085000 f708a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7092000 f7099000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70a1000 f70cb000 r-xp /usr/lib/libsensor.so.1.9.6
f70d4000 f71a0000 r-xp /usr/lib/libxml2.so.2.7.8
f71ad000 f71af000 r-xp /usr/lib/libiniparser.so.0
f71b8000 f71be000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71c7000 f7297000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7298000 f72cc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72d5000 f7311000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7319000 f731c000 r-xp /usr/lib/libbundle.so.0.1.22
f7324000 f732a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7332000 f7373000 r-xp /usr/lib/libeina.so.1.7.99
f737c000 f7393000 r-xp /usr/lib/libecore.so.1.7.99
f73aa000 f73b3000 r-xp /usr/lib/libvconf.so.0.2.45
f73bb000 f73cf000 r-xp /lib/libpthread-2.13.so
f73da000 f73e7000 r-xp /usr/lib/libaul.so.0.1.0
f73f1000 f73f3000 r-xp /lib/libdl-2.13.so
f73fc000 f7407000 r-xp /lib/libunwind.so.8.0.1
f7434000 f743c000 r-xp /lib/libgcc_s-4.6.so.1
f743d000 f7561000 r-xp /lib/libc-2.13.so
f756f000 f7571000 r-xp /usr/lib/libdlog.so.0.0.0
f7579000 f7585000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f758e000 f7593000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f759b000 f75aa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75b2000 f75b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75bf000 f75c2000 r-xp /usr/lib/libappcore-agent.so.1.1
f75ca000 f75cc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75d4000 f75d8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75e0000 f75fd000 r-xp /lib/ld-2.13.so
f7606000 f7609000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7609000 f760d000 r-xp /usr/lib/libsys-assert.so
f79e2000 f7a70000 rw-p [heap]
ffa00000 ffa21000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14453)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7607228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf759e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72a53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72ea75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72e51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72e7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72e8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72eff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c871fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c7a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d4d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71fafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71fc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf738cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7387b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73885a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7388879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75c0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75c07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76075c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf745485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7606f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
acceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.571+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:575,2.024940,-2.453078,9.276444
06-07 17:01:18.571+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:569,2.184647,-2.100898,9.260223
06-07 17:01:18.571+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.571+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.581+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:585,2.022732,-2.402155,9.290241
06-07 17:01:18.581+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:584,2.294717,-1.464408,9.250652
06-07 17:01:18.581+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.591+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.591+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:597,2.032325,-2.359128,9.299170
06-07 17:01:18.591+0200 W/LOCATION(14453): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:01:18.591+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:600,2.213361,-2.069792,9.652647
06-07 17:01:18.601+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.601+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.611+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.611+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:607,2.041176,-2.363048,9.296235
06-07 17:01:18.611+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.611+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:608,2.007578,-2.227718,9.925428
06-07 17:01:18.611+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.621+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:620,2.048191,-2.368104,9.293406
06-07 17:01:18.621+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.621+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:621,1.966900,-2.495714,9.501899
06-07 17:01:18.621+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.631+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:576,-0.051395,-0.661777,-0.124608
06-07 17:01:18.631+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.631+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:629,2.058948,-2.387772,9.285993
06-07 17:01:18.631+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:18.641+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:18:643,81
06-07 17:01:18.641+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:616,-15.050000,0.910000,-2.590000
06-07 17:01:18.641+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.641+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.641+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:635,1.914258,-2.868994,9.396614
06-07 17:01:18.641+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:639,-0.323412,-0.948076,0.070721
06-07 17:01:18.641+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.641+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.651+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:649,2.063759,-2.417786,9.277154
06-07 17:01:18.651+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:654,1.962115,-3.136991,9.399008
06-07 17:01:18.651+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:18.661+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:18:662,715.000000
06-07 17:01:18.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:650,-8.750000,3.920000,0.210000
06-07 17:01:18.661+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.661+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.661+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:654,-0.160788,0.099903,0.207607
06-07 17:01:18.671+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.671+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:669,2.070172,-2.454518,9.266073
06-07 17:01:18.671+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.671+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:670,-7.420000,0.980000,-0.560000
06-07 17:01:18.671+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:673,2.143969,-2.450250,8.863015
06-07 17:01:18.681+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.681+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:680,0.146038,1.141044,-0.125491
06-07 17:01:18.681+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:681,2.048725,-2.447262,9.272757
06-07 17:01:18.681+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.681+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.691+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:686,2.275574,-1.952543,8.882158
06-07 17:01:18.691+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:691,2.019467,-2.368562,9.299573
06-07 17:01:18.691+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:694,-2.800000,-4.200000,1.540000
06-07 17:01:18.691+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.691+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.691+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.691+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.701+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:699,2.268396,-2.191825,9.643075
06-07 17:01:18.701+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.701+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:703,2.029440,-2.287085,9.317779
06-07 17:01:18.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:703,0.542844,1.081102,-0.012092
06-07 17:01:18.701+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.701+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:707,2.179861,-1.964507,9.628718
06-07 17:01:18.711+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:712,2.075848,-2.266901,9.312486
06-07 17:01:18.711+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.711+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.711+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:700,19.530001,-7.000000,0.770000
06-07 17:01:18.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:713,0.161441,0.278466,-0.004405
06-07 17:01:18.721+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:720,2.139183,-2.120041,9.753145
06-07 17:01:18.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.721+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:724,2.104380,-2.304697,9.296792
06-07 17:01:18.721+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:728,-0.185337,-0.408764,0.231428
06-07 17:01:18.721+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.731+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:730,2.062613,-2.533999,9.865608
06-07 17:01:18.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:736,30.590000,-5.600000,0.070000
06-07 17:01:18.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.731+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:741,13.720000,-1.890000,0.770000
06-07 17:01:18.731+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:732,2.120511,-2.384671,9.272926
06-07 17:01:18.741+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.741+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:746,2.144689,-2.476080,9.243361
06-07 17:01:18.741+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:742,2.012364,-3.079563,9.152546
06-07 17:01:18.741+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.751+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.751+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:732,-0.038756,-0.984423,0.250507
06-07 17:01:18.751+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.751+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:756,2.149602,-2.514894,9.231733
06-07 17:01:18.751+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:752,1.746760,-3.402594,9.336794
06-07 17:01:18.751+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.751+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:760,-9.310000,2.800000,0.420000
06-07 17:01:18.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.761+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:765,2.128990,-2.482492,9.245270
06-07 17:01:18.761+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:764,1.887937,-2.347359,9.480364
06-07 17:01:18.761+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:758,-0.058147,-0.701588,0.091041
06-07 17:01:18.761+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.761+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.771+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.771+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:773,2.165504,-1.227518,9.174082
06-07 17:01:18.771+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:776,2.128261,-2.468949,9.249063
06-07 17:01:18.771+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.781+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:765,-16.100000,4.830000,0.700000
06-07 17:01:18.781+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:784,2.572284,-1.205983,9.305687
06-07 17:01:18.781+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.791+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.791+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:796,2.153996,-2.516975,9.230143
06-07 17:01:18.801+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:790,2.237289,-1.988436,9.308081
06-07 17:01:18.801+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:772,-0.177916,0.179499,0.497483
06-07 17:01:18.801+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.801+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.801+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.801+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:810,-0.186018,0.369630,-0.018545
06-07 17:01:18.811+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.811+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.811+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:816,2.171520,-2.556411,9.215186
06-07 17:01:18.821+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:820,0.034850,-0.325868,-0.098909
06-07 17:01:18.821+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:810,-18.969999,2.310000,0.420000
06-07 17:01:18.821+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:812,1.919044,-2.713461,9.528220
06-07 17:01:18.821+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.831+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.831+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:837,2.173422,-2.547553,9.217191
06-07 17:01:18.831+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:18.841+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:833,0.152685,-0.706157,-0.170916
06-07 17:01:18.841+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:18:843,81
06-07 17:01:18.841+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.841+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.841+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.851+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:18.861+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:18:861,689.000000
06-07 17:01:18.861+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.871+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:868,2.165285,-2.516628,9.227595
06-07 17:01:18.871+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.871+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:853,0.228481,-0.496831,-0.172709
06-07 17:01:18.871+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:854,2.081756,-3.369094,9.523434
06-07 17:01:18.881+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.881+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:855,-14.560000,0.280000,1.330000
06-07 17:01:18.891+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.891+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:897,0.202651,-0.414762,-0.201035
06-07 17:01:18.891+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.901+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:888,2.086541,-3.177669,9.334401
06-07 17:01:18.901+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.901+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.901+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:902,-1.960000,-3.150000,-0.420000
06-07 17:01:18.911+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:913,1.971686,-2.335395,9.729217
06-07 17:01:18.911+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.921+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:920,0.158146,-0.385866,-0.082227
06-07 17:01:18.931+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.931+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:924,25.969999,-6.510000,-0.840000
06-07 17:01:18.931+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.941+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.941+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:939,1.942972,-2.112862,9.226725
06-07 17:01:18.951+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:879,2.151491,-2.476819,9.241582
06-07 17:01:18.951+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.961+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.961+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:949,0.112120,-0.246213,-0.050750
06-07 17:01:18.961+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:955,37.099998,-3.360000,-2.240000
06-07 17:01:18.961+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:962,2.133013,-2.428019,9.258799
06-07 17:01:18.971+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:18.971+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:971,2.163112,-2.794817,9.150154
06-07 17:01:18.971+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:18.981+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.981+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:988,13.090000,-3.080000,-0.980000
06-07 17:01:18.981+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:18.981+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.991+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:18:993,-14.770000,-3.500000,0.770000
06-07 17:01:18.991+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:18.991+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:18:986,2.107756,-2.370681,9.279419
06-07 17:01:18.991+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:0,-24.010000,-1.050000,3.150000
06-07 17:01:18.991+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:18:982,0.003777,-0.132301,0.154565
06-07 17:01:19.001+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.001+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.001+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:6,-29.400000,-2.590000,4.200000
06-07 17:01:19.001+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.001+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:13,-23.450001,-5.600000,2.240000
06-07 17:01:19.011+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:18:997,2.306681,-3.223132,9.059227
06-07 17:01:19.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.011+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.011+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:14,2.080047,-2.293538,9.305024
06-07 17:01:19.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:18,-2.030000,-4.550000,3.080000
06-07 17:01:19.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.021+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:24,12.460000,-1.890000,5.740000
06-07 17:01:19.021+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.021+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:16,0.000321,0.087929,0.318192
06-07 17:01:19.021+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:29,1.540000,-4.340000,2.240000
06-07 17:01:19.021+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.031+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.031+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:34,-11.760000,-7.770000,1.470000
06-07 17:01:19.031+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:22,2.400001,-3.053242,9.042477
06-07 17:01:19.031+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.031+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:19.031+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:40,-2.730000,-3.290000,-2.240000
06-07 17:01:19.041+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.041+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:19:43,81
06-07 17:01:19.041+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:33,2.052593,-2.189409,9.336152
06-07 17:01:19.041+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:47,14.630000,0.210000,-4.410000
06-07 17:01:19.041+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.051+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:53,22.260000,2.520000,-6.720000
06-07 17:01:19.051+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.051+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:19.061+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:19:62,741.000000
06-07 17:01:19.061+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.061+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:49,2.376073,-2.962314,9.016156
06-07 17:01:19.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:41,0.063922,0.407994,0.283016
06-07 17:01:19.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:01:19.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:01:19.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:01:19.071+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:60,24.290001,3.360000,-8.750000
06-07 17:01:19.071+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.071+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.071+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.071+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:80,23.870001,5.250000,-11.410000
06-07 17:01:19.081+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.081+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:70,2.033672,-2.097569,9.361344
06-07 17:01:19.081+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:86,23.590000,5.810000,-13.930000
06-07 17:01:19.081+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.081+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.081+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:83,2.323431,-2.902494,9.145369
06-07 17:01:19.081+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:91,27.790001,4.830000,-15.470000
06-07 17:01:19.091+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.091+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:94,2.034729,-2.021547,9.377826
06-07 17:01:19.091+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:97,34.090000,3.850000,-16.030001
06-07 17:01:19.091+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.101+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:102,30.520000,0.980000,-16.170000
06-07 17:01:19.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:87,0.105732,0.349328,0.347601
06-07 17:01:19.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:107,23.660000,-2.800000,-15.260000
06-07 17:01:19.101+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.101+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.101+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:113,14.770000,-4.970000,-13.580000
06-07 17:01:19.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.111+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:113,0.287366,0.398664,0.324801
06-07 17:01:19.111+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:119,10.990000,-6.020000,-12.740000
06-07 17:01:19.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:108,2.263610,-2.723032,9.190832
06-07 17:01:19.121+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.121+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.121+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:126,15.680000,-5.460000,-10.150000
06-07 17:01:19.121+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.121+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:117,2.046526,-1.971310,9.385950
06-07 17:01:19.121+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:133,17.780001,-4.270000,-8.540000
06-07 17:01:19.131+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.131+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:139,14.490000,-0.770000,-5.600000
06-07 17:01:19.141+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.141+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:146,12.880000,-0.700000,-3.360000
06-07 17:01:19.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:131,2.136791,-2.560320,9.413363
06-07 17:01:19.141+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.141+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:139,2.059349,-1.931763,9.391366
06-07 17:01:19.141+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.151+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:141,0.264774,0.322643,0.217393
06-07 17:01:19.151+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:152,11.130000,1.190000,-0.910000
06-07 17:01:19.151+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.151+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:155,2.108077,-2.282753,9.597611
06-07 17:01:19.151+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:160,4.900000,0.980000,1.260000
06-07 17:01:19.151+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.161+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:166,2.143969,-1.885544,9.588040
06-07 17:01:19.161+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.161+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:171,2.158326,-1.840081,9.683753
06-07 17:01:19.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.171+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:175,-0.210000,1.470000,2.380000
06-07 17:01:19.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:176,2.321038,-1.698904,9.686146
06-07 17:01:19.171+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.181+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:164,2.069377,-1.882329,9.399197
06-07 17:01:19.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:182,2.299503,-1.698904,9.595219
06-07 17:01:19.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.181+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:171,0.142907,0.315477,0.084842
06-07 17:01:19.181+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:187,2.189433,-1.655833,9.470792
06-07 17:01:19.181+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.181+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.191+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.191+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:192,2.287539,-1.586441,9.399008
06-07 17:01:19.191+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.191+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:196,0.280000,3.780000,3.360000
06-07 17:01:19.201+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:202,0.228189,0.345321,0.007642
06-07 17:01:19.201+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:189,2.080031,-1.819614,9.409190
06-07 17:01:19.201+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:199,2.419144,-1.351945,9.281759
06-07 17:01:19.201+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.201+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.201+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.201+0200 E/RESOURCED( 2560): cgroup.c: cgroup_get_pids(425) > Failed to open '/sys/fs/cgroup/freezer/frozen/cgroup.procs': Not a directory
06-07 17:01:19.201+0200 E/RESOURCED( 2560): freezer-process.c: freezer_check_all_suspend_process(251) > Failed to get cgroup pids: Not a directory
06-07 17:01:19.211+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.211+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:219,0.910000,5.180000,3.430000
06-07 17:01:19.211+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:01:19.221+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:209,2.421536,-1.160519,9.193225
06-07 17:01:19.221+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:212,0.349766,0.530384,-0.117437
06-07 17:01:19.221+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.221+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:210,2.085624,-1.756000,9.420033
06-07 17:01:19.221+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.231+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.231+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.231+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:19.231+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:230,0.341505,0.659095,-0.215965
06-07 17:01:19.241+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:236,2.395216,-1.057628,9.509077
06-07 17:01:19.241+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.241+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:19:244,81
06-07 17:01:19.251+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.251+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:231,2.086987,-1.692222,9.431397
06-07 17:01:19.251+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:255,0.309591,0.698372,0.089045
06-07 17:01:19.251+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:19.261+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:249,2.325824,-0.899701,9.518648
06-07 17:01:19.261+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.261+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:19:263,758.000000
06-07 17:01:19.261+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.261+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:238,-2.170000,3.780000,3.010000
06-07 17:01:19.271+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:271,0.238836,0.792520,0.087251
06-07 17:01:19.271+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.271+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:267,2.273181,-0.859023,9.480364
06-07 17:01:19.271+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.281+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.281+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:281,0.190972,0.767402,0.036343
06-07 17:01:19.281+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.291+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.291+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:290,0.176695,0.496939,-0.051167
06-07 17:01:19.291+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.291+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:299,0.218176,0.371530,-0.092694
06-07 17:01:19.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.301+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:291,-1.890000,3.360000,2.100000
06-07 17:01:19.301+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:286,2.082209,-1.626426,9.444021
06-07 17:01:19.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:306,0.218040,0.298447,0.167216
06-07 17:01:19.301+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.301+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:310,2.082130,-1.576102,9.452567
06-07 17:01:19.301+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:311,0.243245,0.019310,0.164946
06-07 17:01:19.311+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.311+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.311+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:318,0.128864,-0.107332,0.079254
06-07 17:01:19.311+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:300,2.258825,-1.079163,9.401401
06-07 17:01:19.311+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.311+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.321+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:323,0.101043,0.016224,-0.032396
06-07 17:01:19.321+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.321+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.321+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:330,0.119257,0.128055,-0.023577
06-07 17:01:19.331+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.331+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:337,0.180101,0.131391,0.049073
06-07 17:01:19.331+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:325,2.304288,-1.179662,9.363115
06-07 17:01:19.331+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.331+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:324,2.030000,4.690000,1.960000
06-07 17:01:19.341+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:342,0.238664,-0.055161,0.084499
06-07 17:01:19.341+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.341+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:336,2.086112,-1.551191,9.455810
06-07 17:01:19.341+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:19.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390879359,000000, pattern:[H:mm][0;m
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:01:19.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:01:19.351+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:01:19.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:01][0;m
06-07 17:01:19.361+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.371+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:355,2.086249,-1.530751,9.459109
06-07 17:01:19.371+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.371+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:378,2.080185,-1.510039,9.463773
06-07 17:01:19.371+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.381+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:384,2.082104,-1.510216,9.463323
06-07 17:01:19.391+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.391+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:396,2.081211,-1.516524,9.462510
06-07 17:01:19.391+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:369,0.103258,-0.214372,0.126349
06-07 17:01:19.391+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.391+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.401+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:401,2.072568,-1.508714,9.465655
06-07 17:01:19.401+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.401+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.401+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:407,2.064367,-1.495299,9.469575
06-07 17:01:19.401+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.401+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:352,2.304288,-1.232304,9.626326
06-07 17:01:19.401+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:401,1.680000,5.250000,0.840000
06-07 17:01:19.411+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:414,2.065624,-1.490603,9.470041
06-07 17:01:19.411+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:407,0.091377,-0.138142,0.088794
06-07 17:01:19.411+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.411+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.411+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.411+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:420,2.074211,-1.501282,9.466476
06-07 17:01:19.411+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.421+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:421,2.323431,-1.490728,9.628718
06-07 17:01:19.421+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:426,2.076520,-1.517691,9.463354
06-07 17:01:19.421+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.421+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.431+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:431,2.069414,-1.517660,9.464915
06-07 17:01:19.431+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.431+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:437,2.056951,-1.507418,9.469268
06-07 17:01:19.431+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:421,-0.006801,0.022146,0.089625
06-07 17:01:19.431+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer - capturing data
06-07 17:01:19.431+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.431+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:01:19.441+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:443,2.050905,-1.501734,9.471481
06-07 17:01:19.441+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:01:19:443,81
06-07 17:01:19.441+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.451+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:451,2.050437,-1.499223,9.471981
06-07 17:01:19.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:01:19:431,-2.380000,4.060000,1.050000
06-07 17:01:19.451+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:01:19.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:01:19.451+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:01:19.451+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.461+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:01:19:462,764.000000
06-07 17:01:19.461+0200 I/gravity (14489): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:01:19:462,2.048321,-1.490254,9.473854
06-07 17:01:19.461+0200 I/accelerometer(14468): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:01:19:442,2.210968,-1.617548,9.542577
06-07 17:01:19.471+0200 I/gravity (14489): es.ugr.frailty.gravity - capturing data
06-07 17:01:19.471+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:01:19:460,0.029590,-0.016810,0.180985
06-07 17:01:19.471+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11144536c6f63152838367
