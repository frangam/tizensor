S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13268
Date: 2018-06-07 16:57:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf749e52d, r5   = 0xf7761f98
r6   = 0xffa7a030, r7   = 0xffa79ee0
r8   = 0xf775ec18, r9   = 0x00000000
r10  = 0xffa79fbc, fp   = 0xffa7a030
ip   = 0x00000001, sp   = 0xffa79eb8
lr   = 0xf749e539, pc   = 0xf7507228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    266756 KB
Buffers:      6084 KB
Cached:      57556 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11580 KB
VmRSS:       11576 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13268 TID = 13268
13268 13272 

Maps Information
f4369000 f4b68000 rw-p [stack:13272]
f4b6f000 f4b71000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b79000 f4b7d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b86000 f4b88000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b90000 f4b93000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ba2000 f4ba7000 r-xp /usr/lib/libsystem.so.0.0.0
f4bb2000 f4bb5000 r-xp /lib/libattr.so.1.1.0
f4bbd000 f4bcd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bd5000 f4bde000 r-xp /usr/lib/libedbus.so.1.7.99
f4be6000 f4be7000 r-xp /usr/lib/libresponse.so.0.2.96
f4bf0000 f4bf5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6497000 f659d000 r-xp /usr/lib/libicuuc.so.57.1
f65b3000 f673b000 r-xp /usr/lib/libicui18n.so.57.1
f674b000 f6758000 r-xp /usr/lib/libail.so.0.1.0
f6761000 f6768000 r-xp /usr/lib/libminizip.so.1.0.0
f6771000 f691a000 r-xp /usr/lib/libcrypto.so.1.0.0
f693a000 f6981000 r-xp /usr/lib/libssl.so.1.0.0
f698d000 f698f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6997000 f699e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69a7000 f69ae000 r-xp /lib/libcrypt-2.13.so
f69df000 f69e2000 r-xp /lib/libcap.so.2.21
f69ea000 f69ec000 r-xp /usr/lib/libiri.so
f69f4000 f6a3d000 r-xp /usr/lib/libmdm.so.1.2.69
f6a45000 f6a4b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a53000 f6a76000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a80000 f6a82000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a8a000 f6aa7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ab0000 f6ab4000 r-xp /usr/lib/libsmack.so.1.0.0
f6abd000 f6ad6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6adf000 f6ae7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aef000 f6af5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6afe000 f6b00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b09000 f6b19000 r-xp /lib/libresolv-2.13.so
f6b1d000 f6b35000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3e000 f6b40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b48000 f6b62000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b6a000 f6b99000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ba2000 f6bb1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bbb000 f6bc5000 r-xp /usr/lib/libsensord-shared.so
f6bce000 f6ca1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cac000 f6cc2000 r-xp /lib/libz.so.1.2.5
f6cca000 f6ccf000 r-xp /usr/lib/libffi.so.5.0.10
f6cd7000 f6cd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ce0000 f6cf0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cf8000 f6d11000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d19000 f6d1b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d23000 f6d98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6da2000 f6da8000 r-xp /lib/librt-2.13.so
f6db1000 f6dcf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dd9000 f6dda000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6de2000 f6e05000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e0d000 f6e12000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e1a000 f6e44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e4d000 f6e64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e6c000 f6ed5000 r-xp /lib/libm-2.13.so
f6ede000 f6f72000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f85000 f6f8a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f92000 f6f99000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fa1000 f6fcb000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd4000 f70a0000 r-xp /usr/lib/libxml2.so.2.7.8
f70ad000 f70af000 r-xp /usr/lib/libiniparser.so.0
f70b8000 f70be000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70c7000 f7197000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7198000 f71cc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71d5000 f7211000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7219000 f721c000 r-xp /usr/lib/libbundle.so.0.1.22
f7224000 f722a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7232000 f7273000 r-xp /usr/lib/libeina.so.1.7.99
f727c000 f7293000 r-xp /usr/lib/libecore.so.1.7.99
f72aa000 f72b3000 r-xp /usr/lib/libvconf.so.0.2.45
f72bb000 f72cf000 r-xp /lib/libpthread-2.13.so
f72da000 f72e7000 r-xp /usr/lib/libaul.so.0.1.0
f72f1000 f72f3000 r-xp /lib/libdl-2.13.so
f72fc000 f7307000 r-xp /lib/libunwind.so.8.0.1
f7334000 f733c000 r-xp /lib/libgcc_s-4.6.so.1
f733d000 f7461000 r-xp /lib/libc-2.13.so
f746f000 f7471000 r-xp /usr/lib/libdlog.so.0.0.0
f7479000 f7485000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f748e000 f7493000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f749b000 f74aa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74b2000 f74b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74bf000 f74c2000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ca000 f74cc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74d4000 f74d8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74e0000 f74fd000 r-xp /lib/ld-2.13.so
f7506000 f7509000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7509000 f750d000 r-xp /usr/lib/libsys-assert.so
f772e000 f779f000 rw-p [heap]
ffa5b000 ffa7c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13268)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7507228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf749e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71a53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71ea75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71e51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71e7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71e8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71eff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b871fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b7a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c4d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70fafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70fc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf728cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7287b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72885a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7288879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74c0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74c07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75075c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf735485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7506f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
14): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.541+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:545,1.820000,-0.560000,-0.280000
06-07 16:57:17.541+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:544,2.620141,-0.294317,9.466006
06-07 16:57:17.541+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:542,2.484021,-0.341310,9.480693
06-07 16:57:17.541+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.541+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.551+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:553,0.084584,0.019476,0.033808
06-07 16:57:17.551+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:553,2.562713,-0.315853,9.516255
06-07 16:57:17.551+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.551+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.551+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:558,2.478130,-0.335329,9.482448
06-07 16:57:17.551+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:558,1.470000,-0.490000,-0.350000
06-07 16:57:17.551+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.561+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:564,2.472202,-0.331263,9.484138
06-07 16:57:17.561+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.561+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.571+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:572,0.174260,0.072838,0.044083
06-07 16:57:17.571+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:573,2.646462,-0.258425,9.528220
06-07 16:57:17.571+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.571+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.571+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:577,-0.770000,-0.630000,-0.210000
06-07 16:57:17.571+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:578,2.484844,-0.329300,9.480902
06-07 16:57:17.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.591+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.591+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:600,2.646462,-0.351745,9.535398
06-07 16:57:17.591+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:600,0.161618,-0.022445,0.054497
06-07 16:57:17.591+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.591+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.601+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:605,-2.170000,-1.050000,-0.350000
06-07 16:57:17.601+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:605,2.509468,-0.334684,9.474225
06-07 16:57:17.601+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.601+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.611+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:612,2.608176,-0.296710,9.580862
06-07 16:57:17.611+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:613,0.098709,0.037974,0.106637
06-07 16:57:17.611+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.611+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:617,-0.350000,-1.050000,0.140000
06-07 16:57:17.611+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.621+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:622,2.516407,-0.333582,9.472424
06-07 16:57:17.621+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.621+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.631+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:633,2.593820,-0.267996,9.547362
06-07 16:57:17.631+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:633,0.077413,0.065586,0.074939
06-07 16:57:17.631+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.631+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.641+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:640,2.240000,-0.910000,0.280000
06-07 16:57:17.641+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:641,2.503253,-0.325961,9.476173
06-07 16:57:17.641+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.641+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.651+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:654,2.579463,-0.191426,9.511470
06-07 16:57:17.651+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:654,0.076210,0.134535,0.035296
06-07 16:57:17.651+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.661+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.661+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:666,2.497133,-0.317357,9.478080
06-07 16:57:17.661+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.661+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.671+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:663,1.190000,-1.190000,0.560000
06-07 16:57:17.671+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:17.681+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.681+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:17:683,80
06-07 16:57:17.681+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.681+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:675,0.132579,0.142681,0.002284
06-07 16:57:17.691+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:17.691+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:674,2.629712,-0.174676,9.480364
06-07 16:57:17.691+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.701+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:17:698,822.000000
06-07 16:57:17.701+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:700,2.679961,-0.323031,9.489935
06-07 16:57:17.711+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:692,2.521565,-0.315833,9.471660
06-07 16:57:17.711+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.711+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.711+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.721+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:691,-2.380000,-1.960000,0.630000
06-07 16:57:17.721+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.721+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:722,2.670390,-0.382852,9.499505
06-07 16:57:17.721+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:717,2.549337,-0.321689,9.464025
06-07 16:57:17.731+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.731+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:736,2.553673,-0.324438,9.462763
06-07 16:57:17.731+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:717,0.158396,-0.007198,0.018275
06-07 16:57:17.731+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.731+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.741+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.741+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:732,-2.520000,-1.750000,0.770000
06-07 16:57:17.741+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:745,2.672783,-0.342174,9.466006
06-07 16:57:17.741+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.751+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:742,2.554463,-0.324605,9.462543
06-07 16:57:17.751+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:744,0.121053,-0.061163,0.035480
06-07 16:57:17.751+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.751+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.751+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:757,2.568816,-0.325626,9.458622
06-07 16:57:17.751+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.761+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:763,2.713461,-0.284746,9.442079
06-07 16:57:17.761+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:754,0.140000,-0.560000,0.560000
06-07 16:57:17.761+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.761+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.771+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:773,2.706282,-0.315853,9.470792
06-07 16:57:17.771+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:773,0.420000,-0.070000,0.700000
06-07 16:57:17.771+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.771+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:763,0.119110,-0.017736,0.003243
06-07 16:57:17.771+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.781+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.781+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:781,-1.260000,-0.210000,1.050000
06-07 16:57:17.781+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.781+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:786,2.575568,-0.326915,9.456741
06-07 16:57:17.781+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:782,0.158998,0.039859,-0.020465
06-07 16:57:17.781+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:788,-0.700000,0.560000,1.470000
06-07 16:57:17.781+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.791+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.791+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.791+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:797,2.656033,-0.253639,9.437292
06-07 16:57:17.791+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:798,1.750000,1.890000,2.170000
06-07 16:57:17.791+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.801+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:794,0.137467,0.009773,0.012170
06-07 16:57:17.801+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.801+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:803,2.556997,-0.320322,9.462006
06-07 16:57:17.801+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.801+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.811+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:813,2.608176,-0.224925,9.477970
06-07 16:57:17.811+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:813,0.210000,2.170000,2.310000
06-07 16:57:17.811+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.811+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:808,0.080465,0.073276,-0.019449
06-07 16:57:17.811+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.811+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:818,2.547437,-0.315751,9.464737
06-07 16:57:17.821+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:822,0.051179,0.095397,0.015965
06-07 16:57:17.821+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.821+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.831+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.831+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:834,-3.220000,1.190000,2.240000
06-07 16:57:17.831+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.831+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:835,2.565715,-0.322694,9.459564
06-07 16:57:17.831+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:834,2.586641,-0.315853,9.556933
06-07 16:57:17.831+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:840,0.039204,-0.000101,0.092196
06-07 16:57:17.841+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.841+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.851+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.851+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:854,-2.730000,0.840000,2.380000
06-07 16:57:17.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.851+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:856,2.581414,-0.334477,9.454883
06-07 16:57:17.851+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:854,2.632105,-0.447458,9.602397
06-07 16:57:17.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:860,0.066390,-0.124764,0.142833
06-07 16:57:17.861+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:17.861+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.871+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.871+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:17:874,0.770000,0.840000,2.730000
06-07 16:57:17.871+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:17.881+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:17.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:57:17.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:57:17.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:17.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:17.891+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:17.901+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:17:886,80
06-07 16:57:17.901+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:17:900,816.000000
06-07 16:57:17.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13214
06-07 16:57:17.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13214)
06-07 16:57:17.911+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:57:17.911+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:17.911+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:57:17.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:57:17.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:17.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:17.921+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:17:881,0.031549,-0.093838,0.157086
06-07 16:57:17.921+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:875,2.568233,-0.337810,9.458353
06-07 16:57:17.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:874,2.612962,-0.428315,9.611969
06-07 16:57:17.931+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13279
06-07 16:57:17.931+0200 W/CAPI_APPFW_APP_CONTROL(13214): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:17.931+0200 I/utils   (13214): specific action
06-07 16:57:17.931+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13279)
06-07 16:57:17.931+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:57:17.931+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:17.931+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:57:17.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:57:17.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:17.931+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:17.941+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:938,2.549776,-0.334977,9.463447
06-07 16:57:17.941+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:941,2.593820,-0.344566,9.413363
06-07 16:57:17.941+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.951+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:17.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:57:17.951+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:17.951+0200 I/utils   (12595): specific action
06-07 16:57:17.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:57:17.951+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:57:17.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:17.951+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:57:17.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:57:17.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:17.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13214), cmd(0)
06-07 16:57:17.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:17.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:17.951+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:954,2.551224,-0.337354,9.462972
06-07 16:57:17.951+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:17.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13268
06-07 16:57:17.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:17.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:57:17.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:17.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13268), cmd(0)
06-07 16:57:17.991+0200 W/CAPI_APPFW_APP_CONTROL(13268): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:17.991+0200 I/utils   (13268): specific action
06-07 16:57:17.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13268)
06-07 16:57:17.991+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:57:17.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:17.991+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:57:17.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:57:17.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:17.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:17.991+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.001+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:5,0.025586,-0.006757,-0.044990
06-07 16:57:18.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13292
06-07 16:57:18.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13292)
06-07 16:57:18.011+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:57:18.011+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:18.011+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:57:18.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:57:18.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:18.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:18.011+0200 W/CAPI_APPFW_APP_CONTROL(13279): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.011+0200 I/utils   (13279): specific action
06-07 16:57:18.011+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.021+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.021+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:17:956,2.641676,-0.363709,9.516255
06-07 16:57:18.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13307
06-07 16:57:18.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13279), cmd(0)
06-07 16:57:18.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13307)
06-07 16:57:18.031+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:57:18.031+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:18.031+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:57:18.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:57:18.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:18.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:18.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:57:18.051+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.051+0200 I/utils   (12603): specific action
06-07 16:57:18.051+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:57:18.051+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:57:18.051+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:18.051+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:57:18.051+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:57:18.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:18.061+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:18.061+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:23,1.960000,0.350000,2.590000
06-07 16:57:18.071+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:18.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:57:18.071+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.071+0200 I/utils   (12614): specific action
06-07 16:57:18.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:57:18.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12603), cmd(0)
06-07 16:57:18.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12614), cmd(0)
06-07 16:57:18.081+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:57:18.081+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:18.081+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:57:18.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:57:18.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:18.081+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:18.081+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:18:82,80
06-07 16:57:18.081+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:26,0.091900,-0.028732,0.052809
06-07 16:57:18.091+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:18.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:57:18.091+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.091+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 16:57:18.091+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:57:18.091+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:57:18.091+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:18.091+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:57:18.091+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:57:18.091+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:57:18.101+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.101+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:18:99,811.000000
06-07 16:57:18.101+0200 I/utils   (12618): specific action
06-07 16:57:18.101+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.101+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.101+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.111+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:109,-0.210000,-0.280000,2.170000
06-07 16:57:18.111+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:112,0.059345,-0.117282,0.091569
06-07 16:57:18.111+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:17:964,2.568192,-0.347839,9.458001
06-07 16:57:18.111+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:113,2.610569,-0.454636,9.554541
06-07 16:57:18.121+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.121+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.121+0200 W/CAPI_APPFW_APP_CONTROL(13307): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.121+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(13307), cmd(0)
06-07 16:57:18.121+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:126,-0.000693,-0.171403,0.165932
06-07 16:57:18.121+0200 I/utils   (13307): specific action
06-07 16:57:18.121+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.121+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.121+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.131+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:131,-0.030947,-0.084419,0.098709
06-07 16:57:18.131+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:129,-2.310000,-0.350000,1.260000
06-07 16:57:18.141+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.141+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.141+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:132,2.557768,-0.353468,9.460617
06-07 16:57:18.141+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:135,2.567499,-0.519243,9.623933
06-07 16:57:18.141+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.141+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:146,0.115429,0.137213,-0.030883
06-07 16:57:18.151+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.151+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:18.151+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13292), cmd(0)
06-07 16:57:18.151+0200 W/CAPI_APPFW_APP_CONTROL(13292): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:18.151+0200 I/utils   (13292): specific action
06-07 16:57:18.151+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.151+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:157,0.167900,0.149579,-0.128606
06-07 16:57:18.151+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.161+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:156,2.526821,-0.437887,9.559326
06-07 16:57:18.161+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:150,1.190000,-0.350000,0.630000
06-07 16:57:18.161+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:151,2.521462,-0.347781,9.470569
06-07 16:57:18.161+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.171+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.171+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.171+0200 W/LOCATION(13268): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:57:18.181+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:183,2.497705,-0.333826,9.477364
06-07 16:57:18.181+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:177,4.830000,-0.350000,0.700000
06-07 16:57:18.181+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:187,2.636890,-0.210568,9.439686
06-07 16:57:18.191+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.191+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:164,0.120286,-0.005978,0.106427
06-07 16:57:18.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:199,0.044736,-0.064897,0.071661
06-07 16:57:18.191+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.191+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.201+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:205,2.665605,-0.184247,9.348758
06-07 16:57:18.201+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:197,3.710000,0.210000,0.490000
06-07 16:57:18.201+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.201+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:199,2.509426,-0.329017,9.474435
06-07 16:57:18.201+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:203,0.036799,-0.004560,0.011770
06-07 16:57:18.201+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.201+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.211+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:215,2.539513,-0.337097,9.466130
06-07 16:57:18.211+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:214,0.104015,0.062655,0.009448
06-07 16:57:18.211+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.211+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.221+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:214,-0.980000,0.210000,0.630000
06-07 16:57:18.221+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:223,2.629712,-0.334995,9.580862
06-07 16:57:18.221+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.221+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.221+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.231+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:223,0.162141,-0.012905,-0.067049
06-07 16:57:18.231+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.231+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:236,0.104014,-0.070155,0.085420
06-07 16:57:18.231+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.231+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:230,-3.850000,0.210000,0.630000
06-07 16:57:18.231+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.241+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:232,2.547449,-0.342399,9.463807
06-07 16:57:18.241+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.241+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:241,0.023917,-0.059199,0.168499
06-07 16:57:18.241+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.241+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:239,2.584249,-0.401994,9.537791
06-07 16:57:18.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:248,-1.120000,0.350000,0.420000
06-07 16:57:18.251+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:249,2.530483,-0.337829,9.468522
06-07 16:57:18.251+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.251+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:249,0.027919,-0.036853,0.127885
06-07 16:57:18.261+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.261+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.261+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:261,2.584249,-0.346959,9.475577
06-07 16:57:18.261+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:266,0.034692,-0.014742,0.102806
06-07 16:57:18.261+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.261+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.271+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:18.271+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:271,0.042227,-0.006989,0.078803
06-07 16:57:18.271+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.271+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:18:280,80
06-07 16:57:18.281+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:268,2.522606,-0.331661,9.470841
06-07 16:57:18.281+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:281,0.033464,-0.082608,0.093617
06-07 16:57:18.281+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.281+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:265,2.310000,0.770000,0.140000
06-07 16:57:18.281+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:278,2.634498,-0.275175,9.477970
06-07 16:57:18.281+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.291+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:18.291+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.291+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:18:298,810.000000
06-07 16:57:18.291+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.301+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:298,2.537662,-0.334232,9.466728
06-07 16:57:18.301+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:290,0.097955,-0.029977,0.066389
06-07 16:57:18.301+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.301+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:296,1.470000,0.630000,-0.210000
06-07 16:57:18.301+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:309,0.116482,-0.006851,0.043708
06-07 16:57:18.311+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:318,0.046223,-0.038018,-0.051135
06-07 16:57:18.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.311+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:307,2.684747,-0.344566,9.403792
06-07 16:57:18.311+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.321+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:315,-1.050000,0.630000,-0.490000
06-07 16:57:18.321+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:327,2.641676,-0.404387,9.552148
06-07 16:57:18.321+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:318,2.543581,-0.338010,9.465005
06-07 16:57:18.321+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.321+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.331+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:335,2.534795,-0.338820,9.467334
06-07 16:57:18.331+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:322,0.080030,-0.024102,0.021280
06-07 16:57:18.331+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:334,-0.490000,1.260000,-0.560000
06-07 16:57:18.331+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.331+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:341,0.075888,0.022304,0.083997
06-07 16:57:18.341+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.341+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:344,2.567499,-0.397209,9.633504
06-07 16:57:18.341+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:18.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390638352,000000, pattern:[H:mm][0;m
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:18.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:18.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:57:18.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:57][0;m
06-07 16:57:18.341+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.351+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:354,0.084946,0.024372,0.037289
06-07 16:57:18.351+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:358,0.700000,1.610000,-0.210000
06-07 16:57:18.361+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.361+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:351,2.530414,-0.339396,9.468485
06-07 16:57:18.361+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:368,2.562713,-0.375673,9.595219
06-07 16:57:18.361+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.361+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.371+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:373,0.091267,0.009795,0.087032
06-07 16:57:18.371+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.371+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:380,0.490000,0.140000,0.210000
06-07 16:57:18.381+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.381+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:379,2.530058,-0.339970,9.468559
06-07 16:57:18.381+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:390,2.565106,-0.354138,9.571291
06-07 16:57:18.381+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.391+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.391+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.391+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:398,0.055990,-0.096878,0.096919
06-07 16:57:18.401+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:403,2.531642,-0.340921,9.468102
06-07 16:57:18.401+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:18:402,0.070000,-0.350000,0.490000
06-07 16:57:18.401+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:18.401+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:18.411+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:18:414,0.060963,-0.011240,0.059968
06-07 16:57:18.411+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:18.411+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:18.421+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:18:417,2.572284,-0.346959,9.547362
06-07 16:57:18.421+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:18:421,2.536543,-0.345696,9.466617
06-07 16:57:18.441+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11132686c6f63152838343
