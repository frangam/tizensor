S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15416
Date: 2018-06-07 17:04:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf717052d, r5   = 0xf72aef98
r6   = 0xffbb1410, r7   = 0xffbb12c0
r8   = 0xf72abc18, r9   = 0x00000000
r10  = 0xffbb139c, fp   = 0xffbb1410
ip   = 0x00000001, sp   = 0xffbb1298
lr   = 0xf7170539, pc   = 0xf71d9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    181016 KB
Buffers:     12308 KB
Cached:      64124 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11576 KB
VmRSS:       11576 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15416 TID = 15416
15416 15421 

Maps Information
f403b000 f483a000 rw-p [stack:15421]
f4841000 f4843000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f484b000 f484f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4858000 f485a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4862000 f4865000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4874000 f4879000 r-xp /usr/lib/libsystem.so.0.0.0
f4884000 f4887000 r-xp /lib/libattr.so.1.1.0
f488f000 f489f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48a7000 f48b0000 r-xp /usr/lib/libedbus.so.1.7.99
f48b8000 f48b9000 r-xp /usr/lib/libresponse.so.0.2.96
f48c2000 f48c7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6169000 f626f000 r-xp /usr/lib/libicuuc.so.57.1
f6285000 f640d000 r-xp /usr/lib/libicui18n.so.57.1
f641d000 f642a000 r-xp /usr/lib/libail.so.0.1.0
f6433000 f643a000 r-xp /usr/lib/libminizip.so.1.0.0
f6443000 f65ec000 r-xp /usr/lib/libcrypto.so.1.0.0
f660c000 f6653000 r-xp /usr/lib/libssl.so.1.0.0
f665f000 f6661000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6669000 f6670000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6679000 f6680000 r-xp /lib/libcrypt-2.13.so
f66b1000 f66b4000 r-xp /lib/libcap.so.2.21
f66bc000 f66be000 r-xp /usr/lib/libiri.so
f66c6000 f670f000 r-xp /usr/lib/libmdm.so.1.2.69
f6717000 f671d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6725000 f6748000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6752000 f6754000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675c000 f6779000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6782000 f6786000 r-xp /usr/lib/libsmack.so.1.0.0
f678f000 f67a8000 r-xp /usr/lib/libnetwork.so.0.0.0
f67b1000 f67b9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67c1000 f67c7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67d0000 f67d2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67db000 f67eb000 r-xp /lib/libresolv-2.13.so
f67ef000 f6807000 r-xp /usr/lib/liblzma.so.5.0.3
f6810000 f6812000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f681a000 f6834000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f683c000 f686b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6874000 f6883000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f688d000 f6897000 r-xp /usr/lib/libsensord-shared.so
f68a0000 f6973000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f697e000 f6994000 r-xp /lib/libz.so.1.2.5
f699c000 f69a1000 r-xp /usr/lib/libffi.so.5.0.10
f69a9000 f69aa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b2000 f69c2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69ca000 f69e3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69eb000 f69ed000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f5000 f6a6a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a74000 f6a7a000 r-xp /lib/librt-2.13.so
f6a83000 f6aa1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aab000 f6aac000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab4000 f6ad7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6adf000 f6ae4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aec000 f6b16000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b1f000 f6b36000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b3e000 f6ba7000 r-xp /lib/libm-2.13.so
f6bb0000 f6c44000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c57000 f6c5c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c64000 f6c6b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c73000 f6c9d000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca6000 f6d72000 r-xp /usr/lib/libxml2.so.2.7.8
f6d7f000 f6d81000 r-xp /usr/lib/libiniparser.so.0
f6d8a000 f6d90000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d99000 f6e69000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e6a000 f6e9e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea7000 f6ee3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eeb000 f6eee000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef6000 f6efc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f04000 f6f45000 r-xp /usr/lib/libeina.so.1.7.99
f6f4e000 f6f65000 r-xp /usr/lib/libecore.so.1.7.99
f6f7c000 f6f85000 r-xp /usr/lib/libvconf.so.0.2.45
f6f8d000 f6fa1000 r-xp /lib/libpthread-2.13.so
f6fac000 f6fb9000 r-xp /usr/lib/libaul.so.0.1.0
f6fc3000 f6fc5000 r-xp /lib/libdl-2.13.so
f6fce000 f6fd9000 r-xp /lib/libunwind.so.8.0.1
f7006000 f700e000 r-xp /lib/libgcc_s-4.6.so.1
f700f000 f7133000 r-xp /lib/libc-2.13.so
f7141000 f7143000 r-xp /usr/lib/libdlog.so.0.0.0
f714b000 f7157000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7160000 f7165000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f716d000 f717c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7184000 f7188000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7191000 f7194000 r-xp /usr/lib/libappcore-agent.so.1.1
f719c000 f719e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71a6000 f71aa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b2000 f71cf000 r-xp /lib/ld-2.13.so
f71d8000 f71db000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71db000 f71df000 r-xp /usr/lib/libsys-assert.so
f727b000 f72ec000 rw-p [heap]
ffb92000 ffbb3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15416)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71d9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7170539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e773f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e75c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e81e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e87be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e87dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ebc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eb71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e75c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e81e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e87be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e87dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eb9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eba017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ec1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48591fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf484c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf691f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dccfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dce7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f5eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f59b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f5a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f5a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7192183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71927fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71d95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf702685c) [/lib/libc.so.6] + 0x1785c
29: (0xf71d8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
31+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:431,1.873012,-1.683189,9.477820
06-07 17:04:30.431+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:441,2.203789,-1.701297,9.219545
06-07 17:04:30.441+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.441+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:440,0.071491,0.187038,0.312148
06-07 17:04:30.441+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.441+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.441+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:450,2.282753,-1.579263,9.607183
06-07 17:04:30.441+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:454,0.074868,0.194696,-0.024220
06-07 17:04:30.451+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:448,1.855924,-1.660654,9.485155
06-07 17:04:30.451+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:422,-4.760000,-3.150000,1.050000
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:465,0.009843,-0.517700,-0.284635
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:466,0.840000,-2.590000,1.190000
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.461+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:462,1.842412,-1.634681,9.492298
06-07 17:04:30.461+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:471,8.750000,-1.050000,0.630000
06-07 17:04:30.461+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.471+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:475,-0.001217,-0.541369,-0.381242
06-07 17:04:30.471+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:474,1.852961,-1.638342,9.489614
06-07 17:04:30.471+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.481+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.481+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:455,2.213361,-1.840081,9.734003
06-07 17:04:30.481+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.481+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:489,-0.120296,-0.330344,0.212188
06-07 17:04:30.481+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:490,2.115255,-1.871187,9.489935
06-07 17:04:30.481+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:485,1.870643,-1.662130,9.482004
06-07 17:04:30.481+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.491+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.491+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:475,11.410000,0.560000,-0.560000
06-07 17:04:30.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.491+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:499,-0.202643,-0.206060,0.201762
06-07 17:04:30.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:499,6.230000,1.540000,-0.770000
06-07 17:04:30.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.501+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:497,1.878850,-1.664196,9.480019
06-07 17:04:30.501+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.501+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.511+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:509,1.868538,-1.653382,9.483949
06-07 17:04:30.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:512,-0.286569,-0.584937,0.714964
06-07 17:04:30.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:495,1.835295,-1.895115,9.226725
06-07 17:04:30.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.511+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:520,1.998007,-2.598605,9.288938
06-07 17:04:30.511+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.521+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:524,1.852284,-1.629325,9.491298
06-07 17:04:30.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:520,-0.617967,-0.018056,-0.201693
06-07 17:04:30.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.521+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:503,-0.350000,2.240000,-0.770000
06-07 17:04:30.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.531+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:535,1.854791,-1.618404,9.492676
06-07 17:04:30.531+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:532,-0.844567,0.800281,0.094562
06-07 17:04:30.531+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:538,-1.190000,2.800000,-1.050000
06-07 17:04:30.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.541+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.541+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:525,2.158326,-2.665605,9.403792
06-07 17:04:30.541+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.541+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:542,0.273161,0.499030,1.508862
06-07 17:04:30.541+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:546,1.870814,-1.620632,9.489151
06-07 17:04:30.541+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.541+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:549,2.230111,-1.942972,9.851252
06-07 17:04:30.541+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.551+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.551+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:557,1.877160,-1.630846,9.486148
06-07 17:04:30.551+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:554,0.730205,0.101922,0.153499
06-07 17:04:30.551+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:542,-1.750000,1.470000,-0.630000
06-07 17:04:30.551+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.561+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:566,-1.470000,-1.540000,-0.630000
06-07 17:04:30.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:570,-1.890000,0.630000,0.140000
06-07 17:04:30.561+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:566,0.409942,-0.227001,-1.057964
06-07 17:04:30.561+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.571+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:570,1.863630,-1.626926,9.489488
06-07 17:04:30.571+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.571+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:577,-0.580953,0.040797,-1.023738
06-07 17:04:30.571+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.581+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:30.581+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.581+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:582,1.850107,-1.603658,9.496093
06-07 17:04:30.581+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:30:586,603.000000
06-07 17:04:30.581+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.581+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:555,2.136791,-1.854438,9.678967
06-07 17:04:30.581+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.591+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:594,1.848211,-1.581877,9.500114
06-07 17:04:30.591+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:589,-1.204162,0.199877,-0.657736
06-07 17:04:30.591+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:595,2.134398,-1.835295,9.346365
06-07 17:04:30.591+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.591+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.591+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:600,2.086541,-2.565106,9.078369
06-07 17:04:30.601+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.601+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:600,-0.817542,0.690799,0.309711
06-07 17:04:30.601+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.611+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:606,1.852385,-1.568104,9.501584
06-07 17:04:30.611+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.611+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:612,0.505372,0.646473,0.944943
06-07 17:04:30.611+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:575,-0.560000,0.420000,1.260000
06-07 17:04:30.611+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.611+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.611+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:620,-0.630000,2.450000,1.050000
06-07 17:04:30.611+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.621+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.621+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:624,0.947920,0.898999,-0.107354
06-07 17:04:30.621+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:626,2.103291,-2.653640,8.961121
06-07 17:04:30.621+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:617,1.853601,-1.563897,9.502041
06-07 17:04:30.621+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.621+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:30.621+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:631,1.995614,-2.483750,9.542577
06-07 17:04:30.631+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:30:632,79
06-07 17:04:30.631+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.631+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.631+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:637,1.855213,-1.561486,9.502122
06-07 17:04:30.641+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.641+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:625,0.630000,1.890000,-0.490000
06-07 17:04:30.641+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:643,0.469231,0.615210,-0.317434
06-07 17:04:30.641+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.641+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:649,0.140000,2.030000,0.490000
06-07 17:04:30.641+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.641+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.651+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:655,0.057869,-0.146189,-0.272604
06-07 17:04:30.651+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:649,1.866602,-1.567662,9.498875
06-07 17:04:30.651+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.661+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:665,1.878366,-2.337788,9.544970
06-07 17:04:30.661+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:661,1.865336,-1.573702,9.498124
06-07 17:04:30.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.661+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.661+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:666,0.122246,-0.794814,0.138777
06-07 17:04:30.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:670,1.749153,-2.670390,10.078569
06-07 17:04:30.661+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.661+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.671+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:672,1.864628,-1.569294,9.498993
06-07 17:04:30.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:654,-3.570000,-0.700000,0.350000
06-07 17:04:30.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.671+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:675,-0.132346,-1.477056,0.572455
06-07 17:04:30.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:678,-2.520000,1.680000,0.420000
06-07 17:04:30.671+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.671+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.681+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.681+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:689,0.141175,-0.317018,0.414839
06-07 17:04:30.681+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:683,1.858349,-1.566069,9.500755
06-07 17:04:30.681+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:675,1.373480,-2.069792,9.178867
06-07 17:04:30.681+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.681+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.691+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:683,1.190000,1.540000,0.350000
06-07 17:04:30.691+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.691+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:695,1.850378,-1.563656,9.502708
06-07 17:04:30.701+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.701+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:695,1.091127,-1.203590,9.497113
06-07 17:04:30.701+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.701+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:702,0.415748,0.372261,-0.248534
06-07 17:04:30.701+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.701+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.701+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:711,2.146362,-1.428515,10.939985
06-07 17:04:30.711+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:714,1.849908,-1.562989,9.502910
06-07 17:04:30.711+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:719,0.311078,0.322269,0.212978
06-07 17:04:30.711+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:708,1.820000,1.400000,-0.770000
06-07 17:04:30.711+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.721+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:725,0.840000,4.830000,-1.820000
06-07 17:04:30.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:725,2.605784,-1.794617,9.590433
06-07 17:04:30.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.721+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.721+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.721+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:731,2.337788,-2.115255,8.370094
06-07 17:04:30.731+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:734,-0.056940,-0.094852,-0.276759
06-07 17:04:30.731+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.731+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:732,1.862489,-1.571092,9.499115
06-07 17:04:30.731+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:742,0.840000,4.130000,-0.840000
06-07 17:04:30.741+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.741+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.741+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:746,1.383051,-1.849652,8.396415
06-07 17:04:30.741+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.741+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.741+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:751,1.870779,-1.581010,9.495840
06-07 17:04:30.751+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:747,-0.129478,0.337705,-0.017806
06-07 17:04:30.751+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.751+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:751,1.960000,3.290000,-2.940000
06-07 17:04:30.771+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.771+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.781+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:759,-0.122102,0.262497,-0.097271
06-07 17:04:30.791+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.791+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:787,1.860296,-1.584993,9.497235
06-07 17:04:30.791+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:30.801+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:30:804,600.000000
06-07 17:04:30.801+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:778,7.350000,3.920000,-2.310000
06-07 17:04:30.801+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.811+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.811+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:810,0.110883,0.126337,-0.064869
06-07 17:04:30.821+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.821+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:30.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:30:833,79
06-07 17:04:30.831+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:815,10.360000,2.030000,0.280000
06-07 17:04:30.841+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:824,1.861370,-1.580625,9.497753
06-07 17:04:30.841+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.851+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.851+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:850,0.161328,0.092100,0.355124
06-07 17:04:30.861+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:863,3.080000,-0.770000,2.450000
06-07 17:04:30.871+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:888,0.013114,-0.243357,0.100998
06-07 17:04:30.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.881+0200 W/LOCATION(15416): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:04:30.891+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:852,0.698704,-1.619941,8.788837
06-07 17:04:30.891+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.901+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.901+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:876,1.851527,-1.572670,9.500997
06-07 17:04:30.911+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.911+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:898,0.952343,-1.040878,9.798609
06-07 17:04:30.911+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:908,-10.850000,-2.940000,2.730000
06-07 17:04:30.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.931+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:892,-0.035324,-0.015715,0.107826
06-07 17:04:30.931+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:916,1.838233,-1.567731,9.504394
06-07 17:04:30.931+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:923,2.187040,-0.993021,10.466206
06-07 17:04:30.941+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:955,-0.051736,0.212996,-0.043077
06-07 17:04:30.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:960,0.098167,0.177451,-0.057398
06-07 17:04:30.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:30.961+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:934,-11.480000,-3.640000,3.710000
06-07 17:04:30.961+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.961+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:941,1.832739,-1.562456,9.506324
06-07 17:04:30.971+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:948,2.634498,-0.681954,9.422935
06-07 17:04:30.971+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:972,-6.790000,-2.520000,-0.350000
06-07 17:04:30.981+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.981+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:30.981+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:987,1.814599,-1.543422,9.512911
06-07 17:04:30.981+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:30.981+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:30.991+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:30.991+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:30:990,600.000000
06-07 17:04:30.991+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:30:995,2.203789,-0.930808,9.209974
06-07 17:04:31.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:30:964,0.235974,-0.201739,0.052963
06-07 17:04:31.001+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:30:996,5.880000,3.780000,-2.030000
06-07 17:04:31.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:16,14.490000,6.020000,-2.450000
06-07 17:04:31.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.011+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.011+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:30:992,1.796741,-1.500097,9.523225
06-07 17:04:31.021+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.021+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:22,0.299647,-0.161201,0.189784
06-07 17:04:31.021+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.021+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.021+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:31.031+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:31:32,79
06-07 17:04:31.031+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:26,1.832902,-1.701297,9.245867
06-07 17:04:31.031+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:20,5.250000,1.820000,-2.100000
06-07 17:04:31.031+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.031+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:30,-0.022019,-0.120850,0.139129
06-07 17:04:31.031+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.041+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:42,-0.490000,-1.540000,-0.490000
06-07 17:04:31.041+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:37,1.796935,-1.466428,9.528431
06-07 17:04:31.051+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.051+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:47,-0.078707,0.078905,0.443872
06-07 17:04:31.051+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.061+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:59,-0.043311,0.248667,-0.058791
06-07 17:04:31.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:04:31.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:04:31.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:04:31.061+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.061+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:55,-2.310000,-0.490000,0.910000
06-07 17:04:31.061+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.061+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.071+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:71,-3.640000,-3.500000,0.980000
06-07 17:04:31.071+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.071+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:79,-3.010000,-1.540000,1.400000
06-07 17:04:31.071+0200 W/CAPI_APPFW_APP_CONTROL(15350): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:04:31.071+0200 I/utils   (15350): specific action
06-07 17:04:31.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:04:31.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(15350), cmd(0)
06-07 17:04:31.081+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:70,0.085788,0.228174,-0.041026
06-07 17:04:31.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:88,0.036265,-0.185949,-0.090143
06-07 17:04:31.081+0200 W/CAPI_APPFW_APP_CONTROL(15350): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:04:31.081+0200 I/utils   (15350): specific action
06-07 17:04:31.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:04:31.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(15350), cmd(0)
06-07 17:04:31.091+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.091+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:72,1.938186,-2.431108,9.635897
06-07 17:04:31.091+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:94,-0.149542,-0.254699,-0.123033
06-07 17:04:31.091+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.091+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:86,1.815776,-1.498862,9.519809
06-07 17:04:31.091+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:95,-2.030000,-1.050000,1.330000
06-07 17:04:31.091+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.101+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.101+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.111+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:101,-0.028335,0.002199,-0.147908
06-07 17:04:31.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:105,2.450000,-1.820000,0.560000
06-07 17:04:31.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:117,4.270000,-0.840000,0.140000
06-07 17:04:31.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.121+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:107,1.720440,-3.211168,10.045070
06-07 17:04:31.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:126,0.188578,0.139251,0.051270
06-07 17:04:31.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.121+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:115,1.842387,-1.542484,9.507720
06-07 17:04:31.131+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.131+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:121,1.400000,-0.770000,-0.700000
06-07 17:04:31.131+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.131+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.131+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:133,0.202438,0.234717,0.114247
06-07 17:04:31.131+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.141+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:144,0.169550,0.039090,0.249168
06-07 17:04:31.141+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:149,1.867523,-1.589374,9.495085
06-07 17:04:31.141+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.141+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:140,0.490000,-1.400000,-0.070000
06-07 17:04:31.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:157,-1.540000,0.140000,-0.560000
06-07 17:04:31.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.151+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:139,1.993221,-2.117648,9.875179
06-07 17:04:31.151+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.161+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:163,2.258825,-1.409373,9.217153
06-07 17:04:31.141+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.161+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:155,1.848894,-1.591054,9.498448
06-07 17:04:31.171+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.171+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.171+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:176,0.094157,0.061205,0.210426
06-07 17:04:31.171+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.171+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:31.181+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:31:186,607.000000
06-07 17:04:31.181+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:181,0.130829,-0.039312,-0.050472
06-07 17:04:31.191+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:183,1.808138,-1.550744,9.512950
06-07 17:04:31.191+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:161,-1.540000,0.070000,-1.120000
06-07 17:04:31.191+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.191+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:180,2.177469,-1.433301,9.678967
06-07 17:04:31.191+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.191+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.201+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.201+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:197,3.290000,-0.210000,-0.700000
06-07 17:04:31.211+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:207,-0.038486,-0.059457,0.029346
06-07 17:04:31.211+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:205,1.832902,-1.842474,9.186047
06-07 17:04:31.211+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.211+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:210,1.806315,-1.519192,9.518386
06-07 17:04:31.211+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.221+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.221+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.221+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:31.231+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:226,1.763510,-1.409373,9.444471
06-07 17:04:31.231+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.231+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:227,1.820549,-1.511425,9.516911
06-07 17:04:31.231+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:31:233,79
06-07 17:04:31.231+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:218,-0.039613,0.147580,-0.185258
06-07 17:04:31.241+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.241+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:228,5.530000,0.210000,-0.560000
06-07 17:04:31.241+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.251+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.251+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:243,1.756332,-1.445265,9.375079
06-07 17:04:31.251+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:246,1.819770,-1.507028,9.517756
06-07 17:04:31.251+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.251+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.261+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:249,2.240000,-0.280000,0.420000
06-07 17:04:31.261+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.261+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:265,1.827140,-1.519614,9.514342
06-07 17:04:31.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:256,-0.070011,0.090530,-0.183734
06-07 17:04:31.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:279,-0.027840,-0.053871,0.254783
06-07 17:04:31.271+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.271+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:269,-1.680000,-0.630000,0.980000
06-07 17:04:31.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:265,1.978864,-1.560120,9.413363
06-07 17:04:31.281+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.281+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.291+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.301+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:299,2.036292,-1.593620,9.832108
06-07 17:04:31.301+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:289,1.833983,-1.525168,9.512137
06-07 17:04:31.301+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:292,-3.850000,0.350000,-0.140000
06-07 17:04:31.301+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.311+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.321+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:302,0.147629,-0.073035,0.271972
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:31.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391071343,000000, pattern:[H:mm][0;m
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:31.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:04:31.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:04][0;m
06-07 17:04:31.351+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.351+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:356,1.890330,-1.923829,9.578469
06-07 17:04:31.351+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.351+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.361+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:319,-5.810000,1.120000,0.210000
06-07 17:04:31.371+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:335,1.830930,-1.539931,9.510346
06-07 17:04:31.371+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:365,0.200741,-0.035417,0.197594
06-07 17:04:31.371+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.371+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.371+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:31.381+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:31:385,604.000000
06-07 17:04:31.381+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.391+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:383,-0.910000,-1.330000,-0.560000
06-07 17:04:31.391+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.401+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:391,1.832759,-1.548943,9.508531
06-07 17:04:31.401+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.401+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:380,0.176195,-0.111063,-0.128821
06-07 17:04:31.401+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:31.401+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:361,1.837688,-1.698904,9.585647
06-07 17:04:31.411+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:31.411+0200 I/accelerometer(15282): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:31:417,1.804188,-1.447658,9.442079
06-07 17:04:31.411+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:31:411,1.837917,-1.544575,9.508245
06-07 17:04:31.411+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:31.411+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:31:401,5.740000,-0.910000,-1.120000
06-07 17:04:31.411+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:31.421+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:31:412,-0.128804,-0.153786,-0.037013
06-07 17:04:31.421+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11154166c6f63152838387
