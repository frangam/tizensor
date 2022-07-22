S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4439
Date: 2019-02-06 16:48:15+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf761052d, r5   = 0xf7835150
r6   = 0xffc297a0, r7   = 0xffc29650
r8   = 0xf7847c18, r9   = 0x00000000
r10  = 0xffc2972c, fp   = 0xffc297a0
ip   = 0x00000001, sp   = 0xffc29628
lr   = 0xf7610539, pc   = 0xf7679270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11704 KB
Buffers:     36372 KB
Cached:     203268 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11804 KB
VmRSS:       11804 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4439 TID = 4439
4439 4515 

Maps Information
f44db000 f4cda000 rw-p [stack:4515]
f4ce1000 f4ce3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ceb000 f4cef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cf8000 f4cfa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d02000 f4d05000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d14000 f4d19000 r-xp /usr/lib/libsystem.so.0.0.0
f4d24000 f4d27000 r-xp /lib/libattr.so.1.1.0
f4d2f000 f4d3f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d47000 f4d50000 r-xp /usr/lib/libedbus.so.1.7.99
f4d58000 f4d59000 r-xp /usr/lib/libresponse.so.0.2.96
f4d62000 f4d67000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6609000 f670f000 r-xp /usr/lib/libicuuc.so.57.1
f6725000 f68ad000 r-xp /usr/lib/libicui18n.so.57.1
f68bd000 f68ca000 r-xp /usr/lib/libail.so.0.1.0
f68d3000 f68da000 r-xp /usr/lib/libminizip.so.1.0.0
f68e3000 f6a8c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6aac000 f6af3000 r-xp /usr/lib/libssl.so.1.0.0
f6aff000 f6b01000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b09000 f6b10000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b19000 f6b20000 r-xp /lib/libcrypt-2.13.so
f6b51000 f6b54000 r-xp /lib/libcap.so.2.21
f6b5c000 f6b5e000 r-xp /usr/lib/libiri.so
f6b66000 f6baf000 r-xp /usr/lib/libmdm.so.1.2.69
f6bb7000 f6bbd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bc5000 f6be8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bf2000 f6bf4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bfc000 f6c19000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c22000 f6c26000 r-xp /usr/lib/libsmack.so.1.0.0
f6c2f000 f6c48000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c51000 f6c59000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c61000 f6c67000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c70000 f6c72000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c7b000 f6c8b000 r-xp /lib/libresolv-2.13.so
f6c8f000 f6ca7000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb0000 f6cb2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cba000 f6cd4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cdc000 f6d0b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d14000 f6d23000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d2d000 f6d37000 r-xp /usr/lib/libsensord-shared.so
f6d40000 f6e13000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e1e000 f6e34000 r-xp /lib/libz.so.1.2.5
f6e3c000 f6e41000 r-xp /usr/lib/libffi.so.5.0.10
f6e49000 f6e4a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e52000 f6e62000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e6a000 f6e83000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e8b000 f6e8d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e95000 f6f0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f14000 f6f32000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f3c000 f6f3d000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f45000 f6f68000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f70000 f6f75000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f7d000 f6fa7000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fb0000 f6fc7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fcf000 f6fd5000 r-xp /lib/librt-2.13.so
f6fde000 f7047000 r-xp /lib/libm-2.13.so
f7050000 f70e4000 r-xp /usr/lib/libstdc++.so.6.0.16
f70f7000 f70fc000 r-xp /usr/lib/libctx-client.so.0.8.3
f7104000 f710b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7113000 f713d000 r-xp /usr/lib/libsensor.so.1.9.6
f7146000 f7212000 r-xp /usr/lib/libxml2.so.2.7.8
f721f000 f7221000 r-xp /usr/lib/libiniparser.so.0
f722a000 f7230000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7239000 f7309000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f730a000 f733e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7347000 f7383000 r-xp /usr/lib/libSLP-location.so.0.9.24
f738b000 f738e000 r-xp /usr/lib/libbundle.so.0.1.22
f7396000 f739c000 r-xp /usr/lib/libappsvc.so.0.1.0
f73a4000 f73e5000 r-xp /usr/lib/libeina.so.1.7.99
f73ee000 f73f7000 r-xp /usr/lib/libvconf.so.0.2.45
f73ff000 f7413000 r-xp /lib/libpthread-2.13.so
f741e000 f742b000 r-xp /usr/lib/libaul.so.0.1.0
f7435000 f7437000 r-xp /lib/libdl-2.13.so
f7440000 f744b000 r-xp /lib/libunwind.so.8.0.1
f7478000 f7480000 r-xp /lib/libgcc_s-4.6.so.1
f7481000 f75a5000 r-xp /lib/libc-2.13.so
f75b3000 f75ca000 r-xp /usr/lib/libecore.so.1.7.99
f75e1000 f75e3000 r-xp /usr/lib/libdlog.so.0.0.0
f75eb000 f75f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7600000 f7605000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f760d000 f761c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7624000 f7628000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7631000 f7634000 r-xp /usr/lib/libappcore-agent.so.1.1
f763c000 f763e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7646000 f764a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7652000 f766f000 r-xp /lib/ld-2.13.so
f7678000 f767b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f767b000 f767f000 r-xp /usr/lib/libsys-assert.so
f7817000 f7885000 rw-p [heap]
ffc0a000 ffc2b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4439)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7679270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf7610539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73173f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7315c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7321e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7327be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7327dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf735c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73571f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7315c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7321e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7327be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7327dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7359e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf735a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7361f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cf91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cec171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dbf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf726cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf726e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf75c3ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf75beb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75bf5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf75bf879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7632183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76327fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf767960b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf749885c) [/lib/libc.so.6] + 0x1785c
29: (0xf7678f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
rometer: SM-R760,06/02/2019,16:48:14.936,-11.571690,-2.270789,-0.710668
02-06 16:48:14.937+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:14.940,-9.274446,-2.938231,1.233620
02-06 16:48:14.937+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:14.937+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:14.949,-4.735530,0.404232,-2.197927
02-06 16:48:14.947+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:14.947+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:14.947+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:14.955,-14.009976,-2.533999,-0.964308
02-06 16:48:14.957+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:14.957+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:14.958,-9.262065,-3.063230,1.000582
02-06 16:48:14.957+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:14.957+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:14.968,-5.965858,0.390447,-2.144351
02-06 16:48:14.957+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:14.967+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:14.977+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:14.974,-15.227923,-2.672783,-1.143769
02-06 16:48:14.977+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:14.977+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:14.986,-5.284872,0.009491,-1.701745
02-06 16:48:14.977+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:14.977+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:14.976,-9.335274,-2.900021,0.782901
02-06 16:48:14.987+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:14.987+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:14.987+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:14.993,-14.620146,-2.890530,-0.918844
02-06 16:48:14.987+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:14.987+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.0,-9.636251,-1.691156,0.673079
02-06 16:48:14.997+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:14.997+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.8,-3.478808,-1.948327,-0.945861
02-06 16:48:14.997+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.007+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.13,-13.115060,-3.639483,-0.272782
02-06 16:48:15.007+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.007+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.17,-9.762306,0.541497,0.757985
02-06 16:48:15.017+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.017+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.27,-2.189843,-4.917970,-0.061674
02-06 16:48:15.017+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.017+0100 I/light   ( 4448): es.ugr.frailty.light: SM-R760,06/02/2019,16:48:14.971,1523.000000
02-06 16:48:15.027+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.027+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.32,-9.423180,2.544325,0.948940
02-06 16:48:15.027+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.027+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.35,-11.952149,-4.376472,0.696311
02-06 16:48:15.027+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.37,-164.360001,59.290001,174.369995
02-06 16:48:15.027+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.037+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.037+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.037+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.47,-1.945121,-7.246222,0.233115
02-06 16:48:15.037+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.037+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.48,-8.913190,3.930410,1.130179
02-06 16:48:15.047+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.42,-177.589996,53.689999,179.479996
02-06 16:48:15.047+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.047+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.53,-11.368300,-4.701896,1.182054
02-06 16:48:15.047+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.57,-199.710007,49.349998,174.580002
02-06 16:48:15.047+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.057+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.057+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.057+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.68,-8.417567,4.870700,1.261441
02-06 16:48:15.057+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.68,-2.680037,-8.426523,-0.531973
02-06 16:48:15.057+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.63,-213.149994,46.060001,161.910004
02-06 16:48:15.067+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.067+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.067+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.74,-11.593226,-4.496114,0.598206
02-06 16:48:15.067+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.74,-203.699997,41.790001,140.279999
02-06 16:48:15.067+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.067+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.79,-165.479996,43.959999,126.770004
02-06 16:48:15.067+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.077+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.83,-117.459999,43.680000,109.270004
02-06 16:48:15.077+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.077+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.077+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.88,-8.037445,5.453657,1.351846
02-06 16:48:15.077+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.087+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.88,-2.642059,-8.340293,-1.189656
02-06 16:48:15.087+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.087+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.93,-86.870003,34.090000,85.820000
02-06 16:48:15.087+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.95,-11.059627,-3.469593,0.071785
02-06 16:48:15.097+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.097+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.097+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.097+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.109,-7.744714,5.842211,1.434699
02-06 16:48:15.097+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.109,-2.526867,-8.145582,-1.796911
02-06 16:48:15.107+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.107+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.115,-10.564312,-2.691926,-0.445065
02-06 16:48:15.107+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.119,-80.430000,29.540001,62.510002
02-06 16:48:15.117+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.117+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.117+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.128,-2.408032,-8.072322,-2.121439
02-06 16:48:15.117+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.128,-7.674472,5.923413,1.478526
02-06 16:48:15.117+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.117+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.127+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.133,-10.152746,-2.230111,-0.686740
02-06 16:48:15.127+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.133,-87.290001,23.940001,42.279999
02-06 16:48:15.137+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.137+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:15.137+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.147+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.147+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.149,-104.160004,16.240000,24.500000
02-06 16:48:15.147+0100 I/light   ( 4448): es.ugr.frailty.light: SM-R760,06/02/2019,16:48:15.149,2381.000000
02-06 16:48:15.157+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.152,-7.728750,5.842567,1.516974
02-06 16:48:15.157+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.154,-1.731714,-8.141560,-2.091089
02-06 16:48:15.157+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.157+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.157+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.157+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.168,-7.882900,5.629230,1.530370
02-06 16:48:15.157+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.157+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.168,-125.720001,15.260000,9.730000
02-06 16:48:15.167+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.166,-9.406186,-2.218147,-0.612563
02-06 16:48:15.167+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.167+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.178,-8.975478,-2.455036,-0.318245
02-06 16:48:15.177+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.172,-1.246728,-8.297604,-1.835220
02-06 16:48:15.177+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.177+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.177+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.188,-8.125988,5.280216,1.502675
02-06 16:48:15.177+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.177+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.188,-137.970001,10.920000,-0.490000
02-06 16:48:15.177+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.187+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:15.187+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:15.187+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.192,-0.724083,-8.242193,-1.326980
02-06 16:48:15.187+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.193,-8.606983,-2.612962,0.203390
02-06 16:48:15.197+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.197+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.207+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.207+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.210,-145.529999,6.860000,-10.080000
02-06 16:48:15.207+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.207+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.214,0.035855,-8.101354,-0.997790
02-06 16:48:15.207+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.211,-8.274042,5.032795,1.543239
02-06 16:48:15.207+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.215,-8.090133,-2.821138,0.504886
02-06 16:48:15.217+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.217+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.217+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.227+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.228,-144.410004,8.190000,-17.570000
02-06 16:48:15.227+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.227+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.227,-8.452849,4.723172,1.552857
02-06 16:48:15.227+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.231,0.439941,-8.026217,-0.765571
02-06 16:48:15.237+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.236,-7.834101,-2.993421,0.777667
02-06 16:48:15.237+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.237+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.247+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.247+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.250,-137.899994,6.510000,-24.710001
02-06 16:48:15.247+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.247+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.251,-8.653152,4.353899,1.528698
02-06 16:48:15.257+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.258,-7.470392,-2.991028,0.775275
02-06 16:48:15.257+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.254,0.982457,-7.714200,-0.777582
02-06 16:48:15.257+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.257+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.267+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.267+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.267+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.268,-128.029999,11.410000,-28.910000
02-06 16:48:15.267+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.275,1.407684,-7.163073,-0.600282
02-06 16:48:15.267+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.269,-8.846789,3.968435,1.468411
02-06 16:48:15.277+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.277,-7.245467,-2.809174,0.928415
02-06 16:48:15.277+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.277+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.277+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.287+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.287+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.294,-7.271788,-2.519642,1.093520
02-06 16:48:15.287+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.289,-9.024949,3.580455,1.378776
02-06 16:48:15.287+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.288,-116.830002,14.560000,-31.290001
02-06 16:48:15.287+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.294,1.575002,-6.488077,-0.374891
02-06 16:48:15.297+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.297+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.307+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.307+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.310,-105.279999,21.840000,-30.940001
02-06 16:48:15.307+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.307+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.316,-7.257431,-2.352145,1.485943
02-06 16:48:15.307+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.316,1.767518,-5.932600,0.107167
02-06 16:48:15.307+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.311,-9.179794,3.209299,1.265762
02-06 16:48:15.317+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.317+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.317+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.328,-9.300928,2.889792,1.145524
02-06 16:48:15.317+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.327,-94.779999,30.240000,-27.020000
02-06 16:48:15.317+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.317+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.327+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.333,1.632832,-5.506409,0.550390
02-06 16:48:15.327+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.333,-7.546963,-2.297110,1.816152
02-06 16:48:15.337+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.337+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:15.347+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.347+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.347+0100 I/light   ( 4448): es.ugr.frailty.light: SM-R760,06/02/2019,16:48:15.350,2932.000000
02-06 16:48:15.347+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.349,-81.900002,39.340000,-20.370001
02-06 16:48:15.347+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.354,-8.047063,-2.292324,2.318645
02-06 16:48:15.347+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.357+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.354,-9.387834,2.642184,1.028510
02-06 16:48:15.357+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.357+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.357+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.363,1.253865,-5.182117,1.173121
02-06 16:48:15.367+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.367+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.367+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.374,-8.702696,-2.285146,2.785245
02-06 16:48:15.367+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.369,-67.480003,48.230000,-13.510000
02-06 16:48:15.367+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.371,-9.513332,2.233531,0.823548
02-06 16:48:15.377+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.375,0.685138,-4.927330,1.756735
02-06 16:48:15.377+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.377+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.377+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.387+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.387+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:15.387+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:15.387+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.394,0.669459,-4.329643,2.287121
02-06 16:48:15.387+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.388,-9.599145,1.898839,0.649012
02-06 16:48:15.387+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.388,-52.360001,54.670002,-8.820000
02-06 16:48:15.387+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.394,-8.843873,-2.096112,3.110669
02-06 16:48:15.397+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.397+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.407+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.407+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.407+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.410,-9.656907,1.631582,0.502469
02-06 16:48:15.407+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.410,-35.349998,62.299999,-5.250000
02-06 16:48:15.407+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.414,0.582989,-3.827454,2.952187
02-06 16:48:15.407+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.414,-9.016156,-1.928615,3.601198
02-06 16:48:15.417+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.417+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.427+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.427+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.427+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.428,-14.840000,68.389999,-4.480000
02-06 16:48:15.427+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.428,-9.795896,0.447252,0.103852
02-06 16:48:15.427+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.434,0.379933,-3.167774,3.163335
02-06 16:48:15.437+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.434,-9.276974,-1.536192,3.665804
02-06 16:48:15.437+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.437+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.447+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.447+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.447+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.455,-9.260223,-1.234696,3.850052
02-06 16:48:15.447+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.451,-9.800789,0.336681,0.039560
02-06 16:48:15.447+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.448,5.670000,69.580002,-5.740000
02-06 16:48:15.457+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.455,0.535672,-1.681948,3.746200
02-06 16:48:15.457+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.457+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.467+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.467+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.469,18.969999,71.680000,-6.860000
02-06 16:48:15.467+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.475,-9.274581,-1.071985,3.878766
02-06 16:48:15.477+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.477+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.486,0.526208,-1.408665,3.839205
02-06 16:48:15.477+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.468,-9.804206,0.217855,-0.021510
02-06 16:48:15.487+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.487+0100 W/LOCATION( 4439): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
02-06 16:48:15.487+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.496,29.120001,74.900002,-5.320000
02-06 16:48:15.487+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.487+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.497+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.487+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.497+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.509,39.759998,76.090004,-3.010000
02-06 16:48:15.507+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.503,-9.408579,-0.952343,3.919443
02-06 16:48:15.507+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.507+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.514,0.395627,-1.170199,3.940953
02-06 16:48:15.507+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.503,-9.805966,0.081657,-0.082087
02-06 16:48:15.507+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.507+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.516,-9.748360,-0.964308,4.010371
02-06 16:48:15.517+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.517+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.521,-9.805246,-0.089543,-0.139697
02-06 16:48:15.517+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.517+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.527+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.527+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.535,-9.796362,-0.378249,-0.242100
02-06 16:48:15.527+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.535,0.057607,-1.045965,4.092457
02-06 16:48:15.527+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.532,-10.049855,-1.050449,4.208975
02-06 16:48:15.527+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.527,49.770000,74.129997,-0.140000
02-06 16:48:15.537+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.537+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.537+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:15.537+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.548,56.840000,69.650002,1.400000
02-06 16:48:15.537+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.537+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.547+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.553,-9.771597,-0.759897,-0.329900
02-06 16:48:15.547+0100 I/light   ( 4448): es.ugr.frailty.light: SM-R760,06/02/2019,16:48:15.549,2974.000000
02-06 16:48:15.547+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.545,-0.244609,-0.960906,4.348671
02-06 16:48:15.547+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.553,-10.195816,-0.966700,4.192225
02-06 16:48:15.547+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.557+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.557+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.557+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.568,-9.711297,-1.305139,-0.397128
02-06 16:48:15.557+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.568,61.670002,63.980000,2.310000
02-06 16:48:15.557+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.567+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.573,-10.080962,-0.935594,4.146761
02-06 16:48:15.567+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.563,-0.399454,-0.588451,4.434325
02-06 16:48:15.567+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.577+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.581,-0.309365,-0.175697,4.476662
02-06 16:48:15.577+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.577+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.577+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.587,-9.556507,-2.157937,-0.432285
02-06 16:48:15.577+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.587,67.129997,57.540001,3.850000
02-06 16:48:15.577+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.587+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:15.587+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:15.587+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.592,-9.954143,-0.973879,4.173083
02-06 16:48:15.587+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.587+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.599,-0.242846,0.331260,4.570211
02-06 16:48:15.597+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.597+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.597+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.609,-8.912478,-4.079310,-0.312003
02-06 16:48:15.597+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.607+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.607+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.614,-9.774680,-1.088734,4.319045
02-06 16:48:15.607+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.609,73.430000,51.799999,5.390000
02-06 16:48:15.607+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.617,-0.218173,1.069203,4.751329
02-06 16:48:15.617+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.617+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.617+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.617+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.627,-8.753696,-4.419449,-0.107955
02-06 16:48:15.617+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.627+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.627,80.989998,45.150002,6.650000
02-06 16:48:15.627+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.631,-9.561719,-1.280160,4.342973
02-06 16:48:15.627+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.633,-0.649240,2.799150,4.654976
02-06 16:48:15.637+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.637+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.637+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.648,87.639999,37.170002,7.910000
02-06 16:48:15.637+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.648,-9.415445,-2.742000,-0.034797
02-06 16:48:15.637+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.647+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.647+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.655,-0.676417,3.074683,4.321715
02-06 16:48:15.647+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.652,-9.430114,-1.344766,4.213760
02-06 16:48:15.657+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.657+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.657+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.668,-9.683619,-1.548449,-0.014827
02-06 16:48:15.657+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.667+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.672,-9.320045,-1.263410,3.895515
02-06 16:48:15.667+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.669,92.260002,28.980000,8.400000
02-06 16:48:15.667+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.677+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.683,0.095401,1.478590,3.930312
02-06 16:48:15.677+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.677+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.677+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.688,-9.763582,-0.918035,-0.007154
02-06 16:48:15.677+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.687+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.687+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.689,96.040001,24.850000,13.160000
02-06 16:48:15.687+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.692,-10.052249,-1.406980,3.462414
02-06 16:48:15.687+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.696,-0.368630,0.141470,3.477241
02-06 16:48:15.697+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.697+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.709,107.309998,20.650000,23.170000
02-06 16:48:15.697+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.707+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.713,-11.394621,-1.837688,3.414558
02-06 16:48:15.717+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.717+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.717+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.728,-12.619746,-2.002793,3.376273
02-06 16:48:15.727+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.727+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.735,-1.631039,-0.919652,3.421712
02-06 16:48:15.727+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.727+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.739,-9.784613,-0.656743,-0.020863
02-06 16:48:15.737+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.731,123.760002,8.750000,38.150002
02-06 16:48:15.737+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.737+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.737+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.747+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.747+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.754,131.250000,-5.110000,48.230000
02-06 16:48:15.747+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.758,-9.802873,-0.265226,-0.061108
02-06 16:48:15.747+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.748,-2.835134,-1.346050,3.397135
02-06 16:48:15.757+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.751,-14.050655,-2.120041,3.136991
02-06 16:48:15.757+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.757+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.757+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.757+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.767+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.774,-14.802001,-2.021935,2.656033
02-06 16:48:15.767+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.777,133.979996,-28.770000,52.080002
02-06 16:48:15.777+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.781,-9.803586,0.207252,-0.130890
02-06 16:48:15.777+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.773,-4.247783,-1.854815,3.198099
02-06 16:48:15.777+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.777+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.787+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:15.787+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:15.787+0100 W/gpsd    ( 3111): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 750915 to 751017) (logOverhead=0,0,0,0,0,0,0), start: 16:48:15.699
02-06 16:48:15.787+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.787+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:15.787+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.797+0100 I/light   ( 4448): es.ugr.frailty.light: SM-R760,06/02/2019,16:48:15.802,2323.000000
02-06 16:48:15.797+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.804,-14.756538,-1.899901,2.005185
02-06 16:48:15.797+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.797+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.803,-4.998415,-2.229187,2.786923
02-06 16:48:15.797+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.809,-14.266008,-1.414158,1.160519
02-06 16:48:15.807+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.807+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.814,-4.982256,-2.663256,2.231194
02-06 16:48:15.807+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.806,-9.774282,0.763354,-0.226009
02-06 16:48:15.807+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.807+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.805,131.180008,-53.200001,49.279999
02-06 16:48:15.807+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.807+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.807+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.818,-4.462338,-1.654919,1.138674
02-06 16:48:15.817+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.823,-9.803670,0.240761,0.021845
02-06 16:48:15.817+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.817+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.817+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.827,-9.803405,0.187036,0.169269
02-06 16:48:15.817+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.817+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.827+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.828,-14.172688,-1.074377,0.552742
02-06 16:48:15.827+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.832,-9.799525,0.107722,0.357895
02-06 16:48:15.827+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.831,-4.369284,-1.261413,0.383473
02-06 16:48:15.827+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.823,122.849998,-76.930000,40.180000
02-06 16:48:15.827+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.827+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.839,104.440002,-98.349998,32.060001
02-06 16:48:15.837+0100 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf77f5638), size(2752)
02-06 16:48:15.837+0100 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
02-06 16:48:15.837+0100 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
02-06 16:48:15.847+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.847+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.847+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.847+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.854,-9.789193,-0.005331,0.584852
02-06 16:48:15.857+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.856,-14.993427,-1.062413,0.011964
02-06 16:48:15.857+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.855,-5.193902,-1.170135,-0.345931
02-06 16:48:15.857+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.877+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.877+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.870,-9.766670,-0.175662,0.866998
02-06 16:48:15.877+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.877+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.887+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.887+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.894,-15.787844,-0.504886,-1.083949
02-06 16:48:15.897+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.893,-5.998651,-0.499555,-1.668801
02-06 16:48:15.897+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.901,89.669998,-116.340004,24.010000
02-06 16:48:15.897+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.897+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.907+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.917+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.913,-15.400207,-0.339781,-2.187040
02-06 16:48:15.917+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration: SM-R760,06/02/2019,16:48:15.914,-5.633536,-0.164118,-3.054038
02-06 16:48:15.917+0100 I/linearacceleration( 4440): es.ugr.frailty.linearacceleration - capturing data
02-06 16:48:15.917+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer - capturing data
02-06 16:48:15.917+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope: SM-R760,06/02/2019,16:48:15.923,62.160000,-143.850006,13.790000
02-06 16:48:15.927+0100 I/accelerometer( 4405): es.ugr.frailty.accelerometer: SM-R760,06/02/2019,16:48:15.934,-14.773287,-0.674776,-2.818745
02-06 16:48:15.927+0100 I/gyroscope( 4418): es.ugr.frailty.gyroscope - capturing data
02-06 16:48:15.927+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.894,-9.723370,-0.432887,1.199613
02-06 16:48:15.927+0100 I/gravity ( 4442): es.ugr.frailty.gravity - capturing data
02-06 16:48:15.937+0100 I/gravity ( 4442): es.ugr.frailty.gravity: SM-R760,06/02/2019,16:48:15.941,-9.645605,-0.817797,1.569681
02-06 16:48:15.937+0100 I/light   ( 4448): es.ugr.frailty.light - capturing data
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
02-06 16:48:15.937+0100 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
02-06 16:48:15.937+0100 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
02-06 16:48:15.937+0100 E/CAPI_LOCATION_MANAGER( 4389): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
02-06 16:48:15.947+0100 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
02-06 16:48:15.957+0100 W/AUL     ( 4526): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
02-06 16:48:15.957+0100 I/SECURE_STORAGE( 2514): ss_server_ipc.c: SsServerComm(251) > write succeed
02-06 16:48:15.957+0100 W/AUL_AMD ( 2468): amd_request.c: __request_handler(669) > __request_handler: 23
02-06 16:48:15.957+0100 W/AUL_AMD ( 2468): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
02-06 16:48:15.957+0100 W/AUL_AMD ( 2468): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4439
02-06 16:48:15.957+0100 W/AUL_AMD ( 2468): amd_request.c: __send_app_termination_signal(528) > send dead signal done
02-06 16:48:15.957+0100 I/AUL_AMD ( 2468): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4439
02-06 16:48:15.957+0100 W/AUL     ( 2468): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4439)
02-06 16:48:15.997+0100 I/heartrate( 4425): es.ugr.frailty.heartrate - capturing data
02-06 16:48:15.997+0100 I/heartrate( 4425): es.ugr.frailty.heartrate: waiting for rigth values
02-06 16:48:15.997+0100 W/CRASH_MANAGER( 4525): worker.c: worker_job(1205) > 11044396c6f63154946809
