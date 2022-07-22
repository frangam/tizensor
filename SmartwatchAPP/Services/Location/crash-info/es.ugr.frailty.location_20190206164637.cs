S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3998
Date: 2019-02-06 16:46:37+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf754a52d, r5   = 0xf7b58150
r6   = 0xff8cabd0, r7   = 0xff8caa80
r8   = 0xf7b6ac18, r9   = 0x00000000
r10  = 0xff8cab5c, fp   = 0xff8cabd0
ip   = 0x00000001, sp   = 0xff8caa58
lr   = 0xf754a539, pc   = 0xf75b3270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4608 KB
Buffers:     34936 KB
Cached:     210248 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11844 KB
VmRSS:       11840 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3998 TID = 3998
3998 4077 

Maps Information
f4415000 f4c14000 rw-p [stack:4077]
f4c1b000 f4c1d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c25000 f4c29000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c32000 f4c34000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c3c000 f4c3f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c4e000 f4c53000 r-xp /usr/lib/libsystem.so.0.0.0
f4c5e000 f4c61000 r-xp /lib/libattr.so.1.1.0
f4c69000 f4c79000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c81000 f4c8a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c92000 f4c93000 r-xp /usr/lib/libresponse.so.0.2.96
f4c9c000 f4ca1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6543000 f6649000 r-xp /usr/lib/libicuuc.so.57.1
f665f000 f67e7000 r-xp /usr/lib/libicui18n.so.57.1
f67f7000 f6804000 r-xp /usr/lib/libail.so.0.1.0
f680d000 f6814000 r-xp /usr/lib/libminizip.so.1.0.0
f681d000 f69c6000 r-xp /usr/lib/libcrypto.so.1.0.0
f69e6000 f6a2d000 r-xp /usr/lib/libssl.so.1.0.0
f6a39000 f6a3b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a43000 f6a4a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a53000 f6a5a000 r-xp /lib/libcrypt-2.13.so
f6a8b000 f6a8e000 r-xp /lib/libcap.so.2.21
f6a96000 f6a98000 r-xp /usr/lib/libiri.so
f6aa0000 f6ae9000 r-xp /usr/lib/libmdm.so.1.2.69
f6af1000 f6af7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aff000 f6b22000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b2c000 f6b2e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b36000 f6b53000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b5c000 f6b60000 r-xp /usr/lib/libsmack.so.1.0.0
f6b69000 f6b82000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b8b000 f6b93000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b9b000 f6ba1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6baa000 f6bac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bb5000 f6bc5000 r-xp /lib/libresolv-2.13.so
f6bc9000 f6be1000 r-xp /usr/lib/liblzma.so.5.0.3
f6bea000 f6bec000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bf4000 f6c0e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c16000 f6c45000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c4e000 f6c5d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c67000 f6c71000 r-xp /usr/lib/libsensord-shared.so
f6c7a000 f6d4d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d58000 f6d6e000 r-xp /lib/libz.so.1.2.5
f6d76000 f6d7b000 r-xp /usr/lib/libffi.so.5.0.10
f6d83000 f6d84000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d8c000 f6d9c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6da4000 f6dbd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dc5000 f6dc7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dcf000 f6e44000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e4e000 f6e6c000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e76000 f6e77000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e7f000 f6ea2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6eaa000 f6eaf000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6eb7000 f6ee1000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6eea000 f6f01000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f09000 f6f0f000 r-xp /lib/librt-2.13.so
f6f18000 f6f81000 r-xp /lib/libm-2.13.so
f6f8a000 f701e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7031000 f7036000 r-xp /usr/lib/libctx-client.so.0.8.3
f703e000 f7045000 r-xp /usr/lib/libctx-shared.so.0.8.3
f704d000 f7077000 r-xp /usr/lib/libsensor.so.1.9.6
f7080000 f714c000 r-xp /usr/lib/libxml2.so.2.7.8
f7159000 f715b000 r-xp /usr/lib/libiniparser.so.0
f7164000 f716a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7173000 f7243000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7244000 f7278000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7281000 f72bd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72c5000 f72c8000 r-xp /usr/lib/libbundle.so.0.1.22
f72d0000 f72d6000 r-xp /usr/lib/libappsvc.so.0.1.0
f72de000 f731f000 r-xp /usr/lib/libeina.so.1.7.99
f7328000 f7331000 r-xp /usr/lib/libvconf.so.0.2.45
f7339000 f734d000 r-xp /lib/libpthread-2.13.so
f7358000 f7365000 r-xp /usr/lib/libaul.so.0.1.0
f736f000 f7371000 r-xp /lib/libdl-2.13.so
f737a000 f7385000 r-xp /lib/libunwind.so.8.0.1
f73b2000 f73ba000 r-xp /lib/libgcc_s-4.6.so.1
f73bb000 f74df000 r-xp /lib/libc-2.13.so
f74ed000 f7504000 r-xp /usr/lib/libecore.so.1.7.99
f751b000 f751d000 r-xp /usr/lib/libdlog.so.0.0.0
f7525000 f7531000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f753a000 f753f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7547000 f7556000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f755e000 f7562000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f756b000 f756e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7576000 f7578000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7580000 f7584000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f758c000 f75a9000 r-xp /lib/ld-2.13.so
f75b2000 f75b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75b5000 f75b9000 r-xp /usr/lib/libsys-assert.so
f7b3a000 f7ba8000 rw-p [heap]
ff8ac000 ff8cd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3998)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75b3270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf754a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72513f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf724fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf725be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7261be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7261dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf729675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72911f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf724fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf725be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7261be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7261dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7293e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7294017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf729bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c331fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c26171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cf9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71a6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71a87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74f95a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74f9879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf756c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf756c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75b360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf73d285c) [/lib/libc.so.6] + 0x1785c
29: (0xf75b2f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.495,-73.919998,-98.910004,-274.540009
02-06 16:46:36.497+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.508,-2.513592,1.432437,0.760766
02-06 16:46:36.497+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.497+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.507+0100 I/light   ( 4038): es.ugr.frailty.light - capturing data
02-06 16:46:36.507+0100 I/light   ( 4038): es.ugr.frailty.light: SM-R760,06/02/2019,16:46:36.515,2430.000000
02-06 16:46:36.507+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.513,-73.709999,-102.550003,-275.380005
02-06 16:46:36.507+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.507+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.502,-1.383051,-2.057827,10.616954
02-06 16:46:36.507+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.517+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.519,1.942532,-3.252192,9.045452
02-06 16:46:36.517+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.517+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.521,-1.277767,-1.636691,9.992428
02-06 16:46:36.517+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.513,-2.038106,1.321646,0.854836
02-06 16:46:36.517+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.517+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.527+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.530,-1.561715,1.560737,0.597260
02-06 16:46:36.527+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.530,-0.600598,-1.832902,10.028319
02-06 16:46:36.527+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.527+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.527+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.537,0.117248,-1.670190,9.702895
02-06 16:46:36.527+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.537,2.222583,-3.234962,8.986964
02-06 16:46:36.527+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.527+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.537+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.542,0.698704,-1.847259,8.635696
02-06 16:46:36.537+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.526,-65.940002,-95.620003,-271.529999
02-06 16:46:36.537+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.542,-1.243828,1.404933,-0.409756
02-06 16:46:36.537+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.537+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.549,-55.020000,-85.190002,-268.029999
02-06 16:46:36.547+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.547+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.547+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.557,0.212961,-0.981057,8.707481
02-06 16:46:36.547+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.547+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.558,2.505360,-3.206872,8.922418
02-06 16:46:36.547+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.557+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.561,-2.009622,2.253904,-0.279483
02-06 16:46:36.557+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.563,-51.450001,-74.199997,-266.559998
02-06 16:46:36.567+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.567+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.567+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.578,0.643669,-0.849452,8.446664
02-06 16:46:36.567+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.578,2.829613,-3.161210,8.841404
02-06 16:46:36.567+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.567+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.577+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.582,-1.861691,2.357420,-0.475754
02-06 16:46:36.577+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.584,-51.240002,-74.760002,-263.619995
02-06 16:46:36.587+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.587+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.587+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.587+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.597,0.725025,-0.430708,8.537591
02-06 16:46:36.587+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.596,3.182555,-3.065748,8.754594
02-06 16:46:36.587+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.597+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.596,-2.104588,2.730501,-0.303813
02-06 16:46:36.597+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.603,-40.670002,-72.940002,-262.779999
02-06 16:46:36.607+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.607+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.607+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.607+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.617+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.616,3.598680,-2.769442,8.691955
02-06 16:46:36.617+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.617,-2.493423,4.767045,-0.083005
02-06 16:46:36.617+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.622,0.689133,1.701297,8.671589
02-06 16:46:36.627+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.615,-31.360001,-72.940002,-249.690002
02-06 16:46:36.627+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.627+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.627+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.627+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.637,4.090412,-2.567579,8.535013
02-06 16:46:36.627+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.637+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.637,-2.435769,5.009124,-0.396039
02-06 16:46:36.637+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.640,-29.120001,-80.080002,-240.100006
02-06 16:46:36.647+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.643,1.162912,2.239682,8.295916
02-06 16:46:36.647+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.657+0100 W/W_HOME  ( 2762): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-06 16:46:36.657+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-06 16:46:36.657+0100 I/TDM     ( 1952): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [651.883048] dpms[3 -> 0]sync[0]
02-06 16:46:36.657+0100 I/TDM     ( 1952): 
02-06 16:46:36.657+0100 I/TDM     ( 1952): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [651.883178] dpms[0 -> 0]done
02-06 16:46:36.657+0100 I/TDM     ( 1952): 
02-06 16:46:36.657+0100 W/WATCH_CORE( 2848): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
02-06 16:46:36.657+0100 I/WATCH_CORE( 2848): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
02-06 16:46:36.657+0100 I/CAPI_WATCH_APPLICATION( 2848): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-06 16:46:36.657+0100 E/watchface-app( 2848): watchface.cpp: OnAppTimeTick(834) > 
02-06 16:46:36.657+0100 I/watchface-app( 2848): watchface.cpp: OnAppTimeTick(846) > set force update!!
02-06 16:46:36.657+0100 I/watchface-viewer( 2848): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=left ']
02-06 16:46:36.657+0100 I/watchface-viewer( 2848): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 46x41
02-06 16:46:36.667+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -142970880[0;m
02-06 16:46:36.667+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
02-06 16:46:36.667+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-06 16:46:36.667+0100 I/heartrate( 3985): es.ugr.frailty.heartrate - capturing data
02-06 16:46:36.667+0100 I/heartrate( 3985): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:46:36.667+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-06 16:46:36.667+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.667+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.667+0100 I/watchface-viewer( 2848): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
02-06 16:46:36.677+0100 W/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-06 16:46:36.677+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-06 16:46:36.677+0100 W/wnotibp ( 3390): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
02-06 16:46:36.677+0100 I/wnotibp ( 3390): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
02-06 16:46:36.677+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-06 16:46:36.677+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-06 16:46:36.677+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-06 16:46:36.677+0100 W/WATCH_CORE( 2848): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
02-06 16:46:36.677+0100 I/WATCH_CORE( 2848): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
02-06 16:46:36.677+0100 I/CAPI_WATCH_APPLICATION( 2848): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-06 16:46:36.677+0100 E/watchface-app( 2848): watchface.cpp: OnAppTimeTick(834) > 
02-06 16:46:36.677+0100 I/watchface-app( 2848): watchface.cpp: OnAppTimeTick(846) > set force update!!
02-06 16:46:36.677+0100 I/WATCH_CORE( 2848): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
02-06 16:46:36.677+0100 W/STARTER ( 2690): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [1655]ms
02-06 16:46:36.677+0100 W/STARTER ( 2690): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_set(167) > timer set
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): gesture.c: _apps_status_get(128) > apps status:0
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:1 info->offtime:1655
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _lcd_on_cb(721) > lcd state: 1
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-06 16:46:36.687+0100 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: RESUME State: PAUSED
02-06 16:46:36.687+0100 I/CAPI_APPFW_APPLICATION( 2762): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): main.c: _appcore_resume_cb(479) > appcore resume
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-06 16:46:36.687+0100 W/APPS    ( 2762): apps_main.c: _time_changed_cb(308) >  date : 6->6
02-06 16:46:36.687+0100 W/APPS    ( 2762): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): rotary.c: rotary_attach(138) > rotary_attach:0xf7d073a8
02-06 16:46:36.687+0100 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7d073a8, elm_layout, _activated_obj : 0xf7c4c1e8, activated : 1
02-06 16:46:36.687+0100 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(170) > disable back gesture
02-06 16:46:36.687+0100 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(170) > disable back gesture
02-06 16:46:36.697+0100 W/W_INDICATOR( 2698): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
02-06 16:46:36.697+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2690].
02-06 16:46:36.697+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1289302993)
02-06 16:46:36.697+0100 E/ALARM_MANAGER( 2460): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
02-06 16:46:36.697+0100 E/ALARM_MANAGER( 2460): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(885027787) is OVER.
02-06 16:46:36.707+0100 W/W_INDICATOR( 2698): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
02-06 16:46:36.707+0100 W/W_INDICATOR( 2698): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
02-06 16:46:36.707+0100 W/W_INDICATOR( 2698): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
02-06 16:46:36.717+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.717+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.724,1.507478,2.608176,9.193225
02-06 16:46:36.717+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.717+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.729,1.603191,3.230310,9.296116
02-06 16:46:36.717+0100 I/light   ( 4038): es.ugr.frailty.light - capturing data
02-06 16:46:36.717+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.727+0100 W/W_HOME  ( 2762): gesture.c: _widget_updated_cb(188) > widget updated
02-06 16:46:36.727+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-06 16:46:36.727+0100 W/W_HOME  ( 2762): gesture.c: _manual_render(182) > 
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_display.c: tdm_layer_set_info(1442) > [651.952236] layer(0x3932c0) not usable
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_display.c: tdm_layer_set_info(1459) > [651.952270] layer(0x3932c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_exynos_display.c: exynos_layer_set_info(1578) > [651.952287] layer[0x392e10]zpos[1]
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_display.c: tdm_layer_set_info(1442) > [651.952359] layer(0x393310) not usable
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_display.c: tdm_layer_set_info(1459) > [651.952371] layer(0x393310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-06 16:46:36.727+0100 I/TDM     ( 1952): tdm_exynos_display.c: exynos_layer_set_info(1578) > [651.952385] layer[0x392f30]zpos[2]
02-06 16:46:36.727+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.734,2.699104,2.864209,8.539984
02-06 16:46:36.757+0100 I/light   ( 4038): es.ugr.frailty.light: SM-R760,06/02/2019,16:46:36.734,2464.000000
02-06 16:46:36.757+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.767+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.771,3.211168,2.749353,7.953743
02-06 16:46:36.777+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:36.797+0100 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf77f5638), size(2752)
02-06 16:46:36.797+0100 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
02-06 16:46:36.797+0100 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
02-06 16:46:36.807+0100 W/SHealthService( 3058): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
02-06 16:46:36.867+0100 W/W_HOME  ( 2762): gesture.c: _manual_render(182) > 
02-06 16:46:36.887+0100 W/W_HOME  ( 2762): gesture.c: _manual_render_enable(138) > 0
02-06 16:46:36.897+0100 I/heartrate( 3985): es.ugr.frailty.heartrate - capturing data
02-06 16:46:36.907+0100 I/heartrate( 3985): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:46:36.907+0100 W/LOCATION( 3998): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
02-06 16:46:36.917+0100 I/watchface-viewer( 2848): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
02-06 16:46:36.917+0100 W/SHealthCommon( 2898): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
02-06 16:46:36.697+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-06 16:46:36.917+0100 I/light   ( 4038): es.ugr.frailty.light - capturing data
02-06 16:46:36.927+0100 W/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-06 16:46:36.927+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-06 16:46:36.927+0100 I/HIGEAR  ( 3234): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-06 16:46:36.937+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -146470132[0;m
02-06 16:46:36.937+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
02-06 16:46:36.937+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-06 16:46:36.937+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-06 16:46:36.937+0100 W/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-06 16:46:36.937+0100 I/light   ( 4038): es.ugr.frailty.light: SM-R760,06/02/2019,16:46:36.934,1276.000000
02-06 16:46:36.937+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-06 16:46:36.947+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.661,4.635599,-2.182262,8.361778
02-06 16:46:36.947+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:36.947+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-06 16:46:36.947+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.681,4.620000,-84.489998,-220.360001
02-06 16:46:36.947+0100 E/WAKEUP-SERVICE( 3234): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-06 16:46:36.957+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-06 16:46:36.957+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.679,-2.582934,5.175756,0.658212
02-06 16:46:36.957+0100 I/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-06 16:46:36.957+0100 W/TIZEN_N_SOUND_MANAGER( 3234): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-06 16:46:36.957+0100 W/WAKEUP-SERVICE( 3234): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-06 16:46:36.967+0100 I/HIGEAR  ( 3234): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-06 16:46:36.967+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:36.967+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
02-06 16:46:36.967+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-06 16:46:36.967+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 6-2-2019, 21:47:43 (UTC).
02-06 16:46:36.967+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-06 16:46:36.967+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:36.977+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
02-06 16:46:36.977+0100 E/ALARM_MANAGER( 2460): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1289302993] is removed.
02-06 16:46:36.977+0100 W/SHealthService( 3058): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-06 16:46:36.977+0100 W/STARTER ( 2690): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
02-06 16:46:36.977+0100 W/STARTER ( 2690): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-06 16:46:36.987+0100 W/SHealthService( 3058): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-06 16:46:36.997+0100 W/SHealthCommon( 3058): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
02-06 16:46:36.997+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:36.791,3.318845,2.842674,6.589834
02-06 16:46:36.997+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.007+0100 W/SHealthService( 3058): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
02-06 16:46:37.007+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:36.982,-3.032408,5.412573,0.934338
02-06 16:46:37.007+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:36.962,5.251628,-1.721626,8.101036
02-06 16:46:37.017+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.017+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:36.980,37.520000,-89.879997,-196.910004
02-06 16:46:37.017+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.13,4.503292,4.622933,5.302495
02-06 16:46:37.017+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.017+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.027+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.027+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.28,5.980327,-1.215621,7.676480
02-06 16:46:37.027+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.31,5.816952,5.084748,4.295116
02-06 16:46:37.027+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.037+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.037+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.40,6.214160,4.989035,4.493721
02-06 16:46:37.037+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.037+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.37,69.510002,-91.980003,-175.699997
02-06 16:46:37.037+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.34,-2.552525,4.585835,0.438948
02-06 16:46:37.047+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.047+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.047+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.50,5.347959,4.989035,3.739982
02-06 16:46:37.047+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.057+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.46,6.845118,-0.650894,6.992216
02-06 16:46:37.057+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.067+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.63,5.075177,7.264609,3.273381
02-06 16:46:37.067+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.067+0100 I/heartrate( 3985): es.ugr.frailty.heartrate - capturing data
02-06 16:46:37.067+0100 I/heartrate( 3985): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:46:37.067+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.76,5.158926,9.008978,3.419343
02-06 16:46:37.067+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.067+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.58,-2.769159,3.964974,0.277263
02-06 16:46:37.077+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.077+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.62,112.209999,-82.529999,-150.710007
02-06 16:46:37.077+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.087+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.66,7.789543,-0.102532,5.956752
02-06 16:46:37.087+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.81,4.737789,9.346365,4.419543
02-06 16:46:37.087+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.087+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.87,-3.526273,3.493567,-0.402382
02-06 16:46:37.087+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.097+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.104,7.613958,0.390425,6.168111
02-06 16:46:37.097+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.99,3.938586,9.214760,5.620740
02-06 16:46:37.097+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.097+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.92,174.440002,-66.430000,-128.449997
02-06 16:46:37.097+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.108,3.565305,9.126225,6.362515
02-06 16:46:37.097+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.097+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.107+0100 I/light   ( 4038): es.ugr.frailty.light - capturing data
02-06 16:46:37.107+0100 I/light   ( 4038): es.ugr.frailty.light: SM-R760,06/02/2019,16:46:37.117,1210.000000
02-06 16:46:37.117+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.117+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.112,3.866802,8.740981,5.910272
02-06 16:46:37.117+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.117+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.117+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.112,-3.286251,4.725465,-0.654257
02-06 16:46:37.127+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.127+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.129,4.902342,0.867086,8.448999
02-06 16:46:37.127+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.130,4.220939,7.140182,5.706882
02-06 16:46:37.127+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.127+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.125,228.130005,-51.799999,-106.959999
02-06 16:46:37.127+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.137+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.141,4.522435,5.182854,5.462814
02-06 16:46:37.137+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.137+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.137+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.137,-1.797006,4.694323,-1.872994
02-06 16:46:37.137+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.147+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.144,219.449997,-41.930000,-103.529999
02-06 16:46:37.147+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.147+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.149,4.718646,4.709075,6.489335
02-06 16:46:37.147+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.147+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.150,5.376940,1.402458,8.080347
02-06 16:46:37.157+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.157+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.154,1.311819,4.121949,-3.955279
02-06 16:46:37.157+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.163,4.130012,4.910072,7.171289
02-06 16:46:37.157+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.159,158.339996,-5.040000,-103.459999
02-06 16:46:37.157+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.157+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.167+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.167+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.171,3.677768,4.759324,7.747960
02-06 16:46:37.167+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.167+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.166,5.457258,1.763224,7.954857
02-06 16:46:37.167+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.177+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.174,-0.028982,3.586577,-4.340365
02-06 16:46:37.177+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.179,4.137190,5.970093,8.121240
02-06 16:46:37.177+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.177+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.177+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.189,4.247260,6.685547,7.310073
02-06 16:46:37.177+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.177+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.177,113.820000,28.350000,-91.489998
02-06 16:46:37.187+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.187+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.184,5.509116,2.208997,7.806431
02-06 16:46:37.187+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.196,88.620003,43.889999,-78.400002
02-06 16:46:37.187+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.187+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.190,-0.382082,5.501385,-4.681476
02-06 16:46:37.197+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.197+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.193,4.242475,6.738188,6.283553
02-06 16:46:37.197+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.197+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.202,5.437907,2.484879,7.773347
02-06 16:46:37.197+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.207+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.207+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.205,-0.350190,6.799981,-4.387087
02-06 16:46:37.207+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.207,4.706682,6.965507,6.324231
02-06 16:46:37.207+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.207+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.217+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.224,-0.700119,6.861485,-3.353804
02-06 16:46:37.217+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.210,55.580002,52.570000,-66.360001
02-06 16:46:37.217+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.217+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.217,5.321095,2.714609,7.777354
02-06 16:46:37.217+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.221,4.259224,6.379266,6.809973
02-06 16:46:37.217+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.217+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.227+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.227+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.232,3.991228,5.797810,6.637690
02-06 16:46:37.227+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.227+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.230,39.130001,60.130001,-54.250000
02-06 16:46:37.237+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.237+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.244,44.520000,61.250000,-32.130001
02-06 16:46:37.237+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.234,5.199476,2.918331,7.785832
02-06 16:46:37.237+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.237+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.240,-1.382509,6.500151,-2.156613
02-06 16:46:37.247+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.247+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.240,4.082155,5.441278,6.673582
02-06 16:46:37.247+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.247+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.255,-1.634170,6.207895,-1.423316
02-06 16:46:37.247+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.255,3.967300,5.364708,6.549156
02-06 16:46:37.247+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.247+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.257+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.250,5.090437,3.086635,7.792978
02-06 16:46:37.257+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.257+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.265,5.004506,3.199762,7.803001
02-06 16:46:37.257+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.257+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.260,3.878766,5.532206,6.391229
02-06 16:46:37.257+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.257+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.261,38.779999,54.110001,-13.020000
02-06 16:46:37.267+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.267+0100 I/heartrate( 3985): es.ugr.frailty.heartrate - capturing data
02-06 16:46:37.267+0100 I/heartrate( 3985): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:46:37.267+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.273,4.086941,5.706882,6.412765
02-06 16:46:37.267+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.267+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.267+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.278,4.362115,5.769095,6.687939
02-06 16:46:37.267+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.277+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.269,-1.223636,5.654346,-1.882707
02-06 16:46:37.277+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.277+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.275,13.370000,47.529999,2.170000
02-06 16:46:37.277+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.281,4.908736,3.293113,7.824967
02-06 16:46:37.277+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.283,4.137190,6.003592,6.781260
02-06 16:46:37.287+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.287+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.287+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.287+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.288,-0.783567,3.940421,-2.096119
02-06 16:46:37.287+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.297+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.297,3.976871,5.931807,6.812366
02-06 16:46:37.297+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.295,-36.330002,41.020000,6.790000
02-06 16:46:37.297+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.307+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.307+0100 I/light   ( 4038): es.ugr.frailty.light - capturing data
02-06 16:46:37.317+0100 I/light   ( 4038): es.ugr.frailty.light: SM-R760,06/02/2019,16:46:37.322,1220.000000
02-06 16:46:37.327+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.306,-0.386301,1.889740,-2.362153
02-06 16:46:37.327+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.327+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.312,-60.200001,33.040001,9.520000
02-06 16:46:37.327+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.337+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.343,-43.189999,29.610001,5.180000
02-06 16:46:37.337+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.336,-0.109779,1.463194,-1.405027
02-06 16:46:37.337+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.347+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.347+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.352,-0.632715,1.664750,-0.763111
02-06 16:46:37.347+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.356,-20.230000,31.080000,-3.570000
02-06 16:46:37.347+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.357+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.357+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.318,3.940979,5.783452,6.809973
02-06 16:46:37.357+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.307+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.301,4.828425,3.245881,7.894362
02-06 16:46:37.357+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.364,-0.986285,1.473408,-0.228239
02-06 16:46:37.367+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.367+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.367+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.368,3.920000,12.600000,-8.820000
02-06 16:46:37.367+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.367+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.371,3.936193,5.761917,7.140182
02-06 16:46:37.367+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.377+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.374,-0.448024,2.609007,0.130665
02-06 16:46:37.377+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.377+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.380,20.020000,-3.080000,-8.750000
02-06 16:46:37.377+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.375,4.762727,3.245322,7.934400
02-06 16:46:37.377+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.377+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.387+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.387,-0.329016,3.236747,-0.648184
02-06 16:46:37.387+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.387+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.381,4.041477,5.699703,7.063612
02-06 16:46:37.387+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.387+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.391,3.570000,2.310000,-5.810000
02-06 16:46:37.387+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.397+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.404,-0.210000,1.190000,-2.730000
02-06 16:46:37.397+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.389,4.664054,3.285916,7.976199
02-06 16:46:37.397+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.397+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.398,-0.307616,3.165683,-1.635050
02-06 16:46:37.397+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.397+0100 I/gravity ( 4013): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:46:37.409,4.585215,3.361086,7.990575
02-06 16:46:37.397+0100 I/gravity ( 4013): es.ugr.frailty.gravity - capturing data
02-06 16:46:37.407+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope - capturing data
02-06 16:46:37.407+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.400,4.216154,5.781059,7.228717
02-06 16:46:37.407+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer - capturing data
02-06 16:46:37.407+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:46:37.411,0.156648,3.261526,-1.533765
02-06 16:46:37.407+0100 I/gyroscope( 3973): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:46:37.417,0.140000,0.980000,-2.170000
02-06 16:46:37.407+0100 I/accelerometer( 3970): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:46:37.419,3.811767,5.874380,7.759924
02-06 16:46:37.417+0100 I/linearacceleration( 4010): es.ugr.frailty.linearacceleration - capturing data
02-06 16:46:37.417+0100 W/CRASH_MANAGER( 3933): worker.c: worker_job(1205) > 11039986c6f63154946799
