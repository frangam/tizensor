S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16792
Date: 2018-06-07 17:09:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf776452d, r5   = 0xf7e6ef98
r6   = 0xffd1b760, r7   = 0xffd1b610
r8   = 0xf7e6bc18, r9   = 0x00000000
r10  = 0xffd1b6ec, fp   = 0xffd1b760
ip   = 0x00000001, sp   = 0xffd1b5e8
lr   = 0xf7764539, pc   = 0xf77cd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    105364 KB
Buffers:      9996 KB
Cached:      58772 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11344 KB
VmRSS:       11344 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16792 TID = 16792
16792 16797 

Maps Information
f462f000 f4e2e000 rw-p [stack:16797]
f4e35000 f4e37000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e3f000 f4e43000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e4c000 f4e4e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e56000 f4e59000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e68000 f4e6d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e78000 f4e7b000 r-xp /lib/libattr.so.1.1.0
f4e83000 f4e93000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e9b000 f4ea4000 r-xp /usr/lib/libedbus.so.1.7.99
f4eac000 f4ead000 r-xp /usr/lib/libresponse.so.0.2.96
f4eb6000 f4ebb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f675d000 f6863000 r-xp /usr/lib/libicuuc.so.57.1
f6879000 f6a01000 r-xp /usr/lib/libicui18n.so.57.1
f6a11000 f6a1e000 r-xp /usr/lib/libail.so.0.1.0
f6a27000 f6a2e000 r-xp /usr/lib/libminizip.so.1.0.0
f6a37000 f6be0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6c00000 f6c47000 r-xp /usr/lib/libssl.so.1.0.0
f6c53000 f6c55000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c5d000 f6c64000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c6d000 f6c74000 r-xp /lib/libcrypt-2.13.so
f6ca5000 f6ca8000 r-xp /lib/libcap.so.2.21
f6cb0000 f6cb2000 r-xp /usr/lib/libiri.so
f6cba000 f6d03000 r-xp /usr/lib/libmdm.so.1.2.69
f6d0b000 f6d11000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d19000 f6d3c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d46000 f6d48000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d50000 f6d6d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d76000 f6d7a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d83000 f6d9c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6da5000 f6dad000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6db5000 f6dbb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dc4000 f6dc6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6dcf000 f6ddf000 r-xp /lib/libresolv-2.13.so
f6de3000 f6dfb000 r-xp /usr/lib/liblzma.so.5.0.3
f6e04000 f6e06000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e0e000 f6e28000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e30000 f6e5f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e68000 f6e77000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e81000 f6e8b000 r-xp /usr/lib/libsensord-shared.so
f6e94000 f6f67000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f72000 f6f88000 r-xp /lib/libz.so.1.2.5
f6f90000 f6f95000 r-xp /usr/lib/libffi.so.5.0.10
f6f9d000 f6f9e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fa6000 f6fb6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fbe000 f6fd7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fdf000 f6fe1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fe9000 f705e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7068000 f706e000 r-xp /lib/librt-2.13.so
f7077000 f7095000 r-xp /usr/lib/libsystemd.so.0.4.0
f709f000 f70a0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70a8000 f70cb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70d3000 f70d8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e0000 f710a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7113000 f712a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7132000 f719b000 r-xp /lib/libm-2.13.so
f71a4000 f7238000 r-xp /usr/lib/libstdc++.so.6.0.16
f724b000 f7250000 r-xp /usr/lib/libctx-client.so.0.8.3
f7258000 f725f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7267000 f7291000 r-xp /usr/lib/libsensor.so.1.9.6
f729a000 f7366000 r-xp /usr/lib/libxml2.so.2.7.8
f7373000 f7375000 r-xp /usr/lib/libiniparser.so.0
f737e000 f7384000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f738d000 f745d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f745e000 f7492000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f749b000 f74d7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74df000 f74e2000 r-xp /usr/lib/libbundle.so.0.1.22
f74ea000 f74f0000 r-xp /usr/lib/libappsvc.so.0.1.0
f74f8000 f7539000 r-xp /usr/lib/libeina.so.1.7.99
f7542000 f7559000 r-xp /usr/lib/libecore.so.1.7.99
f7570000 f7579000 r-xp /usr/lib/libvconf.so.0.2.45
f7581000 f7595000 r-xp /lib/libpthread-2.13.so
f75a0000 f75ad000 r-xp /usr/lib/libaul.so.0.1.0
f75b7000 f75b9000 r-xp /lib/libdl-2.13.so
f75c2000 f75cd000 r-xp /lib/libunwind.so.8.0.1
f75fa000 f7602000 r-xp /lib/libgcc_s-4.6.so.1
f7603000 f7727000 r-xp /lib/libc-2.13.so
f7735000 f7737000 r-xp /usr/lib/libdlog.so.0.0.0
f773f000 f774b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7754000 f7759000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7761000 f7770000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7778000 f777c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7785000 f7788000 r-xp /usr/lib/libappcore-agent.so.1.1
f7790000 f7792000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f779a000 f779e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77a6000 f77c3000 r-xp /lib/ld-2.13.so
f77cc000 f77cf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77cf000 f77d3000 r-xp /usr/lib/libsys-assert.so
f7e3b000 f7eac000 rw-p [heap]
ffcfc000 ffd1d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16792)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77cd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7764539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf746b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7469c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7475e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf747bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf747bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74b075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74ab1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7469c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7475e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf747bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf747bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74ade5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74ae017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74b5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e4d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e40171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f13663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73c0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73c27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7552ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf754db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf754e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf754e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7786183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77867fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77cd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf761a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77ccf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
018,17:09:18:929,-0.334476,-1.346601,9.707995
06-07 17:09:18.971+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:18.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(16604) cmd(0)
06-07 17:09:18.991+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:18.991+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:18.991+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:18:996,601.000000
06-07 17:09:19.001+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:18:975,-0.005228,0.021102,0.042007
06-07 17:09:19.011+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:18:999,-0.325424,-1.282553,9.683753
06-07 17:09:19.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:18:978,0.070000,0.420000,0.140000
06-07 17:09:19.011+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.021+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:0,-0.331120,-1.348398,9.707861
06-07 17:09:19.021+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:19.031+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:19:32,81
06-07 17:09:19.031+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.031+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(16633) cmd(0)
06-07 17:09:19.061+0200 W/LOCATION(16792): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:09:19.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:09:19.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:09:19.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:09:19.071+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:45,-0.331565,-1.350061,9.707615
06-07 17:09:19.071+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.081+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:78,-0.334944,-1.353659,9.706998
06-07 17:09:19.081+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.081+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:27,-0.021152,0.087926,0.059121
06-07 17:09:19.081+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:86,-0.336415,-1.351468,9.707253
06-07 17:09:19.081+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.081+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:45,-0.560000,0.490000,0.140000
06-07 17:09:19.081+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:91,-0.331612,-1.353802,9.707092
06-07 17:09:19.091+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.091+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:96,-0.328467,-1.354620,9.707085
06-07 17:09:19.091+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.091+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:101,-0.324504,-1.357973,9.706750
06-07 17:09:19.101+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.101+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:45,-0.361316,-1.366302,9.659825
06-07 17:09:19.101+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.101+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.101+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:106,-0.324305,-1.363434,9.705991
06-07 17:09:19.101+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.101+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:110,-0.324172,-1.362475,9.706130
06-07 17:09:19.101+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.111+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:115,-0.324188,-1.353533,9.707380
06-07 17:09:19.111+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.111+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.111+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:119,-0.325116,-1.363064,9.706016
06-07 17:09:19.111+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.121+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:125,-0.324662,-1.367591,9.705394
06-07 17:09:19.121+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.121+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:124,-0.700000,-0.280000,-0.070000
06-07 17:09:19.121+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:129,-0.322908,-1.378254,9.703944
06-07 17:09:19.121+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.121+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:110,-0.311067,-1.440479,9.810574
06-07 17:09:19.131+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:115,0.020938,0.064452,0.013068
06-07 17:09:19.131+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.131+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:133,-0.320339,-1.389491,9.702427
06-07 17:09:19.131+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.131+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.131+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:138,-0.318835,-1.417869,9.698370
06-07 17:09:19.131+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.141+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:143,-0.317009,-1.466971,9.691124
06-07 17:09:19.141+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.141+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:148,-0.316268,-1.530512,9.681316
06-07 17:09:19.141+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.151+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:153,-0.314737,-1.589752,9.671816
06-07 17:09:19.151+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.151+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.151+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:157,-0.299295,-1.643568,9.663306
06-07 17:09:19.151+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.151+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:139,-0.277567,-1.418944,9.884750
06-07 17:09:19.151+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.161+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:163,-0.281845,-1.615973,9.668484
06-07 17:09:19.161+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.161+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:148,0.060384,0.068417,0.053219
06-07 17:09:19.161+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:168,-0.276169,-1.624092,9.667287
06-07 17:09:19.161+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.161+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:158,-0.280000,0.210000,-0.070000
06-07 17:09:19.171+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.171+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:174,-0.275228,-1.694409,9.655237
06-07 17:09:19.171+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.171+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.171+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:19.181+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:19:183,567.000000
06-07 17:09:19.181+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:179,-0.289058,-1.781107,9.639216
06-07 17:09:19.181+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.181+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:168,-0.327817,-1.335195,9.762716
06-07 17:09:19.181+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:191,-0.288512,-1.817561,9.632425
06-07 17:09:19.191+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.191+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:196,-0.276065,-1.824241,9.631527
06-07 17:09:19.191+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.191+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.201+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:200,-0.265591,-1.837822,9.629240
06-07 17:09:19.201+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.201+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:208,-0.260604,-1.856946,9.625707
06-07 17:09:19.201+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.211+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:213,-0.259718,-1.876126,9.622010
06-07 17:09:19.211+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:185,-0.028628,0.043219,0.083668
06-07 17:09:19.211+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.211+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.211+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:217,-0.253066,-1.875674,9.622275
06-07 17:09:19.211+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.211+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:193,-1.050000,0.700000,-0.070000
06-07 17:09:19.221+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:207,-0.380459,-1.385444,9.777073
06-07 17:09:19.221+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:19.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.221+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:19:229,81
06-07 17:09:19.231+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.231+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:226,0.024095,0.111023,0.028496
06-07 17:09:19.231+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:223,-0.245946,-1.873657,9.622853
06-07 17:09:19.231+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.231+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:236,-0.394816,-1.354338,9.650253
06-07 17:09:19.241+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.241+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:240,-0.241437,-1.886612,9.620436
06-07 17:09:19.241+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:234,-1.400000,0.560000,0.210000
06-07 17:09:19.251+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:249,-0.256032,-1.440479,9.769895
06-07 17:09:19.251+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.251+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:252,-0.228887,-1.880596,9.621921
06-07 17:09:19.251+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.251+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.261+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:261,-0.277567,-1.392623,9.808180
06-07 17:09:19.261+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.261+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:265,-0.218999,-1.879057,9.622451
06-07 17:09:19.261+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.271+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:258,0.080070,0.080933,0.015565
06-07 17:09:19.271+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:274,-0.213227,-1.871366,9.624080
06-07 17:09:19.271+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:273,-0.248854,-1.399801,9.803394
06-07 17:09:19.271+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.271+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.281+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:268,-1.400000,0.280000,0.140000
06-07 17:09:19.281+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.281+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:285,-0.306281,-1.423729,9.777073
06-07 17:09:19.281+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:288,-0.217134,-1.888065,9.620730
06-07 17:09:19.291+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.291+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.301+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.301+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:306,-0.334995,-1.349552,9.767502
06-07 17:09:19.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:294,0.031821,0.067760,-0.028590
06-07 17:09:19.301+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:302,-0.910000,0.490000,0.070000
06-07 17:09:19.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.301+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.311+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.311+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:307,-0.213613,-1.897164,9.619019
06-07 17:09:19.321+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.321+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:321,-0.980000,0.630000,0.070000
06-07 17:09:19.321+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:315,0.051010,0.074778,0.032806
06-07 17:09:19.321+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:319,-0.358923,-1.222732,9.712467
06-07 17:09:19.321+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.321+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.331+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:335,-0.363709,-1.476372,9.659825
06-07 17:09:19.341+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:330,-0.206234,-1.888491,9.620887
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:19.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391359351,000000, pattern:[H:mm][0;m
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:19.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:19.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:09:19.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:09][0;m
06-07 17:09:19.341+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.351+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:338,-0.032049,0.046015,0.049134
06-07 17:09:19.351+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.351+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.361+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:352,-0.198174,-1.887511,9.621248
06-07 17:09:19.361+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:341,-1.260000,0.490000,0.210000
06-07 17:09:19.361+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.371+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.371+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:364,-0.323031,-1.330409,9.667004
06-07 17:09:19.371+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:370,-0.000151,0.077246,0.092347
06-07 17:09:19.371+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:19.381+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:377,-0.194632,-1.893158,9.620211
06-07 17:09:19.381+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:19:384,566.000000
06-07 17:09:19.381+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.381+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.381+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:375,-1.330000,0.700000,0.210000
06-07 17:09:19.391+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.391+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:395,0.030213,0.016501,0.053202
06-07 17:09:19.391+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:390,-0.284746,-1.380659,9.748360
06-07 17:09:19.391+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.401+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:404,-0.181409,-1.880400,9.622971
06-07 17:09:19.401+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.411+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:405,-2.030000,0.070000,-0.070000
06-07 17:09:19.411+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.411+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:410,-0.275175,-1.265803,9.738789
06-07 17:09:19.411+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.421+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:19.421+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:19:429,80
06-07 17:09:19.421+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:418,-0.172217,-1.874563,9.624279
06-07 17:09:19.431+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.431+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:436,-0.289532,-1.282553,9.772287
06-07 17:09:19.431+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:436,-0.174131,-1.897409,9.619766
06-07 17:09:19.431+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:418,0.045406,-0.000946,0.033896
06-07 17:09:19.431+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.431+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:425,-1.120000,0.420000,0.210000
06-07 17:09:19.441+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.441+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.441+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:444,-0.012075,0.022445,-0.006954
06-07 17:09:19.451+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.461+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:456,-0.265603,-1.414158,9.868000
06-07 17:09:19.461+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.461+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:457,-0.560000,0.280000,-0.140000
06-07 17:09:19.461+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.471+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.481+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:461,-0.171754,-1.907534,9.617806
06-07 17:09:19.481+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.481+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:483,-0.420000,0.280000,0.350000
06-07 17:09:19.481+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:473,0.054760,0.042858,0.059528
06-07 17:09:19.491+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:478,-0.277567,-1.701297,9.717253
06-07 17:09:19.491+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.491+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.501+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:492,-0.171614,-1.922261,9.614877
06-07 17:09:19.501+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.501+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.511+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:504,-0.053574,0.062686,0.032498
06-07 17:09:19.511+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:504,-0.303888,-1.844866,9.556933
06-07 17:09:19.511+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.521+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.521+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:513,-1.050000,0.070000,0.280000
06-07 17:09:19.521+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:517,-0.173431,-1.938008,9.611682
06-07 17:09:19.521+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.531+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:527,0.082990,0.048785,0.051116
06-07 17:09:19.531+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:524,0.009571,-2.292324,9.521042
06-07 17:09:19.531+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.531+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:538,-0.770000,0.140000,0.350000
06-07 17:09:19.541+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.541+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.541+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:546,-0.119641,-1.517050,9.786645
06-07 17:09:19.551+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:544,-0.171097,-1.948661,9.609570
06-07 17:09:19.551+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.551+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.551+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.561+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:562,-1.120000,0.490000,0.140000
06-07 17:09:19.561+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:555,-0.013408,-0.010294,0.004519
06-07 17:09:19.561+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.571+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:564,-0.172005,-1.966052,9.606010
06-07 17:09:19.571+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.571+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:570,-0.191426,-1.531406,9.659825
06-07 17:09:19.571+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.571+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:19.581+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:19:584,565.000000
06-07 17:09:19.581+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.591+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:575,-0.004305,-0.038374,0.028955
06-07 17:09:19.591+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:592,-1.330000,0.560000,0.280000
06-07 17:09:19.601+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.601+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:582,-0.168569,-1.979587,9.603292
06-07 17:09:19.601+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.601+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:595,-0.325424,-2.323431,10.076177
06-07 17:09:19.601+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:609,-0.168077,-1.994648,9.600183
06-07 17:09:19.611+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.611+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.621+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:609,0.053406,0.043554,0.110404
06-07 17:09:19.621+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:19.621+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.621+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:19:630,80
06-07 17:09:19.631+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.631+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:616,-0.476172,-2.275574,9.805787
06-07 17:09:19.631+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:617,-1.400000,0.420000,0.140000
06-07 17:09:19.641+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.641+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:634,-0.165650,-2.002718,9.598545
06-07 17:09:19.641+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.641+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.651+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:641,-0.056433,0.085640,0.049583
06-07 17:09:19.661+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.661+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:652,-0.442672,-2.273181,9.504292
06-07 17:09:19.661+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:668,-0.009883,0.080821,-0.003614
06-07 17:09:19.661+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.671+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:675,0.056368,0.029371,0.014647
06-07 17:09:19.671+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.671+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.681+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:683,-0.016270,-0.031844,0.028345
06-07 17:09:19.681+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:655,-0.980000,0.210000,0.140000
06-07 17:09:19.681+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.681+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:655,-0.167542,-2.018836,9.595135
06-07 17:09:19.691+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.691+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:690,0.026973,-0.056452,0.021846
06-07 17:09:19.691+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.691+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.701+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:698,-0.165554,-2.024544,9.593966
06-07 17:09:19.701+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:709,0.030299,-0.016261,0.101025
06-07 17:09:19.701+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:682,-0.203390,-2.239682,9.332008
06-07 17:09:19.701+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.701+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:699,-0.700000,0.630000,-0.070000
06-07 17:09:19.711+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:715,-0.122034,-2.280360,9.308081
06-07 17:09:19.711+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.711+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.711+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.721+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:725,-0.016282,0.031871,0.050773
06-07 17:09:19.721+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:729,-0.560000,0.840000,-0.140000
06-07 17:09:19.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.731+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:737,-0.179462,-2.380858,9.588040
06-07 17:09:19.731+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:722,-0.162091,-2.031110,9.592638
06-07 17:09:19.731+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.731+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.741+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.741+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:744,-0.160071,-2.042907,9.590166
06-07 17:09:19.751+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:744,0.029191,0.012823,0.045321
06-07 17:09:19.751+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.751+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.751+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.761+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:756,-1.120000,0.630000,0.210000
06-07 17:09:19.761+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:762,-0.029736,0.082481,-0.017249
06-07 17:09:19.761+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:759,-0.248854,-2.474179,9.628718
06-07 17:09:19.761+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.771+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.771+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.771+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:765,-0.156905,-2.055517,9.587523
06-07 17:09:19.781+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:19.781+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.781+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:780,-0.177069,-2.474179,9.724431
06-07 17:09:19.791+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:19:789,568.000000
06-07 17:09:19.791+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:780,-1.260000,0.210000,0.210000
06-07 17:09:19.791+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.791+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.801+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:790,-0.157280,-2.070096,9.584380
06-07 17:09:19.801+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.811+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:813,-0.560000,0.700000,0.210000
06-07 17:09:19.821+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.821+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:830,-0.630000,0.210000,-0.210000
06-07 17:09:19.831+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:19.831+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:837,-0.350000,0.210000,-0.210000
06-07 17:09:19.831+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.841+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:843,0.210000,0.700000,-0.210000
06-07 17:09:19.841+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:19:842,80
06-07 17:09:19.841+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.841+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:780,0.014002,0.045086,0.003425
06-07 17:09:19.851+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:850,-0.420000,0.350000,0.070000
06-07 17:09:19.851+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:801,-0.129212,-2.294717,9.652647
06-07 17:09:19.851+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.851+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.851+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.851+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:814,-0.155150,-2.068833,9.584688
06-07 17:09:19.851+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:858,-1.120000,-0.140000,0.420000
06-07 17:09:19.861+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.861+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:866,-1.190000,-0.140000,0.280000
06-07 17:09:19.861+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.861+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:873,-0.980000,0.490000,0.140000
06-07 17:09:19.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:880,-0.910000,0.560000,0.070000
06-07 17:09:19.881+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.881+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:887,-0.420000,0.560000,0.210000
06-07 17:09:19.881+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.881+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:868,0.012550,-0.030936,0.041059
06-07 17:09:19.881+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:865,-0.165105,-2.507678,9.485149
06-07 17:09:19.891+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.891+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:893,-0.630000,0.490000,0.280000
06-07 17:09:19.891+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:880,-0.155360,-2.073155,9.583751
06-07 17:09:19.891+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.901+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:900,-1.190000,0.350000,0.350000
06-07 17:09:19.901+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.901+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.901+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:907,-0.910000,0.140000,0.140000
06-07 17:09:19.901+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:19.901+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.911+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:914,-0.980000,-0.210000,0.140000
06-07 17:09:19.911+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:921,-2.030000,-0.210000,-0.350000
06-07 17:09:19.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.921+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:19:905,-0.112463,-2.545963,9.561719
06-07 17:09:19.921+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:19:917,0.029442,-0.081048,0.034243
06-07 17:09:19.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:929,-0.840000,0.980000,-0.070000
06-07 17:09:19.921+0200 I/accelerometer(16778): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:19.921+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.931+0200 I/gravity (16808): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:19:909,-0.155402,-2.074673,9.583422
06-07 17:09:19.931+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:935,-0.770000,-0.140000,0.070000
06-07 17:09:19.931+0200 I/gravity (16808): es.ugr.frailty.gravity - capturing data
06-07 17:09:19.931+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.941+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:942,-1.680000,0.070000,0.070000
06-07 17:09:19.941+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.941+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:09:19.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:09:19.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:19.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:19.951+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:949,-1.610000,0.630000,0.350000
06-07 17:09:19.951+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:19.951+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:19:960,-1.890000,0.140000,0.070000
06-07 17:09:19.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16778
06-07 17:09:19.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16778)
06-07 17:09:19.961+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:09:19.961+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:19.961+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:09:19.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:09:19.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:19.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:19.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16604
06-07 17:09:19.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16604)
06-07 17:09:19.981+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:09:19.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:19.981+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:09:19.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:09:19.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:19.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:19.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:09:19.991+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:20.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:20.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(15106), cmd(0)
06-07 17:09:20.001+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:20.001+0200 I/utils   (15106): specific action
06-07 17:09:20.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:09:20.001+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:09:20.001+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:20:3,570.000000
06-07 17:09:20.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:20.001+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:09:20.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:09:20.001+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:20.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:20.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:20.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:20:12,-0.560000,0.420000,0.070000
06-07 17:09:20.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:20.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:20:18,-0.980000,0.280000,-0.490000
06-07 17:09:20.011+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:20.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16792
06-07 17:09:20.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16792)
06-07 17:09:20.021+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:20.021+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:09:20.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:20.021+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:09:20.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:09:20.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:20.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:20.021+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:09:20:30,80
06-07 17:09:20.031+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:20:25,-0.980000,0.770000,-0.210000
06-07 17:09:20.031+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11167926c6f63152838415
