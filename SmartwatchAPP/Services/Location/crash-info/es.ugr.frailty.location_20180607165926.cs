S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13894
Date: 2018-06-07 16:59:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71f852d, r5   = 0xf77faf98
r6   = 0xffbac7e0, r7   = 0xffbac690
r8   = 0xf77f7c18, r9   = 0x00000000
r10  = 0xffbac76c, fp   = 0xffbac7e0
ip   = 0x00000001, sp   = 0xffbac668
lr   = 0xf71f8539, pc   = 0xf7261228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    242812 KB
Buffers:      7132 KB
Cached:      47860 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11628 KB
VmRSS:       11628 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13894 TID = 13894
13894 13900 

Maps Information
f40c3000 f48c2000 rw-p [stack:13900]
f48c9000 f48cb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48d3000 f48d7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48e0000 f48e2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48ea000 f48ed000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48fc000 f4901000 r-xp /usr/lib/libsystem.so.0.0.0
f490c000 f490f000 r-xp /lib/libattr.so.1.1.0
f4917000 f4927000 r-xp /usr/lib/libmdm-common.so.1.1.24
f492f000 f4938000 r-xp /usr/lib/libedbus.so.1.7.99
f4940000 f4941000 r-xp /usr/lib/libresponse.so.0.2.96
f494a000 f494f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61f1000 f62f7000 r-xp /usr/lib/libicuuc.so.57.1
f630d000 f6495000 r-xp /usr/lib/libicui18n.so.57.1
f64a5000 f64b2000 r-xp /usr/lib/libail.so.0.1.0
f64bb000 f64c2000 r-xp /usr/lib/libminizip.so.1.0.0
f64cb000 f6674000 r-xp /usr/lib/libcrypto.so.1.0.0
f6694000 f66db000 r-xp /usr/lib/libssl.so.1.0.0
f66e7000 f66e9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66f1000 f66f8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6701000 f6708000 r-xp /lib/libcrypt-2.13.so
f6739000 f673c000 r-xp /lib/libcap.so.2.21
f6744000 f6746000 r-xp /usr/lib/libiri.so
f674e000 f6797000 r-xp /usr/lib/libmdm.so.1.2.69
f679f000 f67a5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67ad000 f67d0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67da000 f67dc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67e4000 f6801000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f680a000 f680e000 r-xp /usr/lib/libsmack.so.1.0.0
f6817000 f6830000 r-xp /usr/lib/libnetwork.so.0.0.0
f6839000 f6841000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6849000 f684f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6858000 f685a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6863000 f6873000 r-xp /lib/libresolv-2.13.so
f6877000 f688f000 r-xp /usr/lib/liblzma.so.5.0.3
f6898000 f689a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68a2000 f68bc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68c4000 f68f3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68fc000 f690b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6915000 f691f000 r-xp /usr/lib/libsensord-shared.so
f6928000 f69fb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a06000 f6a1c000 r-xp /lib/libz.so.1.2.5
f6a24000 f6a29000 r-xp /usr/lib/libffi.so.5.0.10
f6a31000 f6a32000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a3a000 f6a4a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a52000 f6a6b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a73000 f6a75000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a7d000 f6af2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6afc000 f6b02000 r-xp /lib/librt-2.13.so
f6b0b000 f6b29000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b33000 f6b34000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b3c000 f6b5f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b67000 f6b6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b74000 f6b9e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ba7000 f6bbe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bc6000 f6c2f000 r-xp /lib/libm-2.13.so
f6c38000 f6ccc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cdf000 f6ce4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cec000 f6cf3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cfb000 f6d25000 r-xp /usr/lib/libsensor.so.1.9.6
f6d2e000 f6dfa000 r-xp /usr/lib/libxml2.so.2.7.8
f6e07000 f6e09000 r-xp /usr/lib/libiniparser.so.0
f6e12000 f6e18000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e21000 f6ef1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ef2000 f6f26000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f2f000 f6f6b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f73000 f6f76000 r-xp /usr/lib/libbundle.so.0.1.22
f6f7e000 f6f84000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f8c000 f6fcd000 r-xp /usr/lib/libeina.so.1.7.99
f6fd6000 f6fed000 r-xp /usr/lib/libecore.so.1.7.99
f7004000 f700d000 r-xp /usr/lib/libvconf.so.0.2.45
f7015000 f7029000 r-xp /lib/libpthread-2.13.so
f7034000 f7041000 r-xp /usr/lib/libaul.so.0.1.0
f704b000 f704d000 r-xp /lib/libdl-2.13.so
f7056000 f7061000 r-xp /lib/libunwind.so.8.0.1
f708e000 f7096000 r-xp /lib/libgcc_s-4.6.so.1
f7097000 f71bb000 r-xp /lib/libc-2.13.so
f71c9000 f71cb000 r-xp /usr/lib/libdlog.so.0.0.0
f71d3000 f71df000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71e8000 f71ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71f5000 f7204000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f720c000 f7210000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7219000 f721c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7224000 f7226000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f722e000 f7232000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f723a000 f7257000 r-xp /lib/ld-2.13.so
f7260000 f7263000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7263000 f7267000 r-xp /usr/lib/libsys-assert.so
f77c7000 f7855000 rw-p [heap]
ffb8d000 ffbae000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13894)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7261228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71f8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6eff3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6efdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f09e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f0fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f0fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f4475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f3f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6efdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f09e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f0fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f0fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f41e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f42017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f49f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48e11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48d4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69a7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e54fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e567a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fe6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fe1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fe25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fe2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf721a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf721a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72615c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70ae85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7260f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
y.gyroscope: SM-R760,07/06/2018,16:59:25:787,-1.190000,4.550000,-2.310000
06-07 16:59:25.781+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:786,2.287791,-1.251692,9.453553
06-07 16:59:25.781+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.781+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:25.781+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.791+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.791+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:25:793,774.000000
06-07 16:59:25.791+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.801+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:802,2.282370,-1.250977,9.454958
06-07 16:59:25.801+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:800,-1.750000,4.200000,-2.170000
06-07 16:59:25.801+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:794,-0.090500,-0.114024,0.086421
06-07 16:59:25.801+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:795,2.208575,-1.361516,9.537791
06-07 16:59:25.811+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.811+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.821+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:820,2.272071,-1.248457,9.457771
06-07 16:59:25.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:812,0.002140,0.014603,0.120131
06-07 16:59:25.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.821+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:820,-0.490000,4.200000,-2.240000
06-07 16:59:25.821+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:816,2.289931,-1.237089,9.573684
06-07 16:59:25.821+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:828,-0.071402,0.009102,0.046941
06-07 16:59:25.831+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:832,2.210968,-1.241875,9.501899
06-07 16:59:25.831+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.831+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.841+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:841,2.260436,-1.253822,9.459849
06-07 16:59:25.841+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:841,0.700000,3.220000,-2.660000
06-07 16:59:25.841+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.841+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.841+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:848,-0.058710,-0.230307,0.197268
06-07 16:59:25.841+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:848,2.213361,-1.478764,9.655040
06-07 16:59:25.851+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:860,3.990000,1.890000,-1.960000
06-07 16:59:25.851+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:860,2.247620,-1.251395,9.463223
06-07 16:59:25.861+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.861+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.861+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:59:25.861+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:59:25.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.861+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:867,2.263610,-1.450050,9.712467
06-07 16:59:25.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.871+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:867,0.003174,-0.196228,0.252618
06-07 16:59:25.871+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.881+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:887,2.590000,1.400000,-0.840000
06-07 16:59:25.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13850
06-07 16:59:25.881+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13850)
06-07 16:59:25.881+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:59:25.881+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.891+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:59:25.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:59:25.891+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.891+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.891+0200 W/CAPI_APPFW_APP_CONTROL(13850): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:25.891+0200 I/utils   (13850): specific action
06-07 16:59:25.891+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.901+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:898,2.277967,-1.174876,9.571291
06-07 16:59:25.901+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.901+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:896,2.240981,-1.240883,9.466182
06-07 16:59:25.911+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13929
06-07 16:59:25.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:25.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13850), cmd(0)
06-07 16:59:25.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13929)
06-07 16:59:25.911+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:59:25.911+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.911+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:59:25.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:59:25.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.921+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:917,2.234501,-1.238847,9.467980
06-07 16:59:25.921+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.921+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:911,2.160719,-1.249053,9.544970
06-07 16:59:25.921+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:59:25.931+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:928,2.227985,-1.234050,9.470141
06-07 16:59:25.931+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:932,2.201397,-1.225125,9.497113
06-07 16:59:25.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:25.931+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12595), cmd(0)
06-07 16:59:25.941+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:25.941+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.941+0200 I/utils   (12595): specific action
06-07 16:59:25.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:59:25.941+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:59:25.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.941+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:59:25.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:59:25.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.941+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:944,2.184647,-1.256232,9.513863
06-07 16:59:25.941+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:945,2.219445,-1.229694,9.472713
06-07 16:59:25.951+0200 W/CAPI_APPFW_APP_CONTROL(13929): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:25.951+0200 I/utils   (13929): specific action
06-07 16:59:25.951+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:25.951+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:25.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13894
06-07 16:59:25.951+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:25.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:25.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13929), cmd(0)
06-07 16:59:25.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:25.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13894), cmd(0)
06-07 16:59:25.951+0200 W/CAPI_APPFW_APP_CONTROL(13894): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:25.951+0200 I/utils   (13894): specific action
06-07 16:59:25.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13894)
06-07 16:59:25.961+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:59:25.961+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.961+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:59:25.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:59:25.961+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:25.961+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:25:960,2.212162,-1.226295,9.474857
06-07 16:59:25.961+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:25:967,83
06-07 16:59:25.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.971+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:897,0.030347,0.076519,0.108068
06-07 16:59:25.971+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.971+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:977,-0.080262,-0.008170,0.078788
06-07 16:59:25.971+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13943
06-07 16:59:25.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13943)
06-07 16:59:25.981+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:59:25.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.981+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:59:25.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:59:25.981+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:25.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.981+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:25:986,779.000000
06-07 16:59:25.981+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:982,-0.033104,0.013722,0.029133
06-07 16:59:25.981+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:25.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13909
06-07 16:59:25.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13909)
06-07 16:59:25.991+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:59:25.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:25.991+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:59:25.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:59:25.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:25.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:25.991+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:25:995,-0.043338,-0.022182,0.043721
06-07 16:59:26.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:6,-0.030012,-0.031323,0.098577
06-07 16:59:26.001+0200 W/CAPI_APPFW_APP_CONTROL(13943): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:26.001+0200 I/utils   (13943): specific action
06-07 16:59:26.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:59:26.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:59:26.001+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:59:26.001+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:26.001+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:59:26.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:26.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13943), cmd(0)
06-07 16:59:26.011+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:59:26.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:26.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:26.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:12,0.034698,-0.037115,0.122754
06-07 16:59:26.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:20,0.029554,-0.110897,0.087655
06-07 16:59:26.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:59:26.021+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:26.021+0200 I/utils   (12614): specific action
06-07 16:59:26.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:59:26.021+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:59:26.021+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:26.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:26.021+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:59:26.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:59:26.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:59:26.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:26.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:26.021+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:25,-0.003746,-0.029477,0.061403
06-07 16:59:26.021+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:26.021+0200 I/utils   (12603): specific action
06-07 16:59:26.031+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:59:26.031+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:26.031+0200 I/utils   (12618): specific action
06-07 16:59:26.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:59:26.031+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:59:26.031+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:26.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:26.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 16:59:26.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:26.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:59:26.031+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:26.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13909), cmd(0)
06-07 16:59:26.031+0200 W/CAPI_APPFW_APP_CONTROL(13909): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:26.031+0200 I/utils   (13909): specific action
06-07 16:59:26.041+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.041+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:25:963,2.189433,-1.261017,9.571291
06-07 16:59:26.041+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:25:959,0.840000,0.350000,-0.560000
06-07 16:59:26.041+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:45,2.207735,-1.221905,9.476457
06-07 16:59:26.041+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.041+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.041+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:50,2.200357,-1.217183,9.478781
06-07 16:59:26.041+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.051+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:54,2.189896,-1.205875,9.482648
06-07 16:59:26.051+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.051+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:59,2.185609,-1.191969,9.485394
06-07 16:59:26.061+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:59:26.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:59:26.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:59:26.061+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.061+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:41,0.112000,0.030999,0.091036
06-07 16:59:26.061+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.081+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:50,1.680000,0.910000,-0.350000
06-07 16:59:26.081+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.081+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:73,0.106715,-0.011621,0.102646
06-07 16:59:26.091+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:69,2.246860,-1.263410,9.597611
06-07 16:59:26.091+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.101+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.101+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:110,-0.038341,0.090784,0.094995
06-07 16:59:26.101+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:97,2.030000,1.400000,-0.910000
06-07 16:59:26.111+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.111+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:105,2.237289,-1.332802,9.564112
06-07 16:59:26.111+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.121+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.121+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:116,1.680000,1.120000,-0.910000
06-07 16:59:26.131+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:69,2.179918,-1.179519,9.488260
06-07 16:59:26.131+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.131+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.141+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:126,2.196611,-1.246661,9.540184
06-07 16:59:26.141+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:130,0.001777,0.144313,0.095209
06-07 16:59:26.151+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:139,2.168513,-1.163655,9.492831
06-07 16:59:26.151+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.161+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:26.161+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:165,2.162586,-1.147410,9.496161
06-07 16:59:26.161+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.161+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:26:167,83
06-07 16:59:26.161+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.161+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:170,2.154455,-1.133030,9.499734
06-07 16:59:26.161+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.161+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.171+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:146,2.450000,0.280000,-0.560000
06-07 16:59:26.171+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:175,2.144647,-1.115819,9.503990
06-07 16:59:26.171+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.171+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:175,2.301895,-1.174876,9.573684
06-07 16:59:26.171+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:180,2.137589,-1.099655,9.507463
06-07 16:59:26.181+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.181+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.181+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:26.181+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:187,2.133016,-1.084196,9.510265
06-07 16:59:26.181+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:26:187,790.000000
06-07 16:59:26.181+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:186,2.292324,-1.203590,9.588040
06-07 16:59:26.191+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.191+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.191+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:178,0.022061,0.051498,0.120593
06-07 16:59:26.201+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:197,4.410000,0.070000,-0.630000
06-07 16:59:26.201+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.201+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:200,2.127053,-1.068619,9.513364
06-07 16:59:26.201+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:196,2.141576,-1.088734,9.583255
06-07 16:59:26.201+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.211+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.211+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:209,6.160000,-0.630000,-0.140000
06-07 16:59:26.211+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:211,2.170290,-1.019342,9.588040
06-07 16:59:26.211+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.211+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.211+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:216,0.049334,0.039510,0.030878
06-07 16:59:26.211+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.221+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:221,2.121956,-1.045496,9.517070
06-07 16:59:26.221+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.221+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:221,2.184647,-1.095913,9.616754
06-07 16:59:26.221+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.221+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:225,0.097428,0.039049,0.093621
06-07 16:59:26.221+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.231+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:230,2.203789,-1.093520,9.530612
06-07 16:59:26.231+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.231+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:234,0.145163,0.030064,0.118862
06-07 16:59:26.231+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.231+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.241+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:241,2.119474,-1.030750,9.519232
06-07 16:59:26.241+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:227,5.950000,-0.980000,-0.490000
06-07 16:59:26.241+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.241+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:241,0.147344,-0.002146,0.101704
06-07 16:59:26.241+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.241+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:243,2.242075,-1.076770,9.597611
06-07 16:59:26.241+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.251+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:249,0.191592,0.144990,0.053142
06-07 16:59:26.251+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:249,5.880000,-0.280000,-1.190000
06-07 16:59:26.251+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:254,2.282753,-1.069592,9.626326
06-07 16:59:26.251+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.261+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:261,2.118070,-1.014000,9.521343
06-07 16:59:26.261+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:259,0.167975,0.040510,0.097292
06-07 16:59:26.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:269,0.148922,0.133442,-0.000584
06-07 16:59:26.261+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:262,2.280360,-1.086342,9.611969
06-07 16:59:26.261+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.271+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:271,5.390000,-0.280000,-0.560000
06-07 16:59:26.271+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:275,2.318645,-0.923629,9.566505
06-07 16:59:26.271+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.271+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.271+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:280,2.289931,-1.004985,9.614362
06-07 16:59:26.271+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.281+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.281+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.281+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:286,0.083327,0.150191,-0.009873
06-07 16:59:26.281+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:286,2.115547,-1.000891,9.523291
06-07 16:59:26.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:285,2.268396,-0.897308,9.518648
06-07 16:59:26.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.291+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:280,4.480000,-1.190000,-0.840000
06-07 16:59:26.291+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:294,2.201397,-0.863809,9.511470
06-07 16:59:26.291+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.291+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.291+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:300,5.740000,-1.190000,-0.280000
06-07 16:59:26.291+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:305,7.560000,-1.050000,-0.280000
06-07 16:59:26.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.301+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:301,0.076278,0.089225,0.059964
06-07 16:59:26.301+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:304,2.116542,-0.994644,9.523724
06-07 16:59:26.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:310,7.000000,-1.330000,0.070000
06-07 16:59:26.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.301+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:314,6.860000,-1.610000,0.070000
06-07 16:59:26.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.311+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:319,7.560000,-1.400000,-0.350000
06-07 16:59:26.311+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.311+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.321+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:323,7.910000,-1.260000,-0.350000
06-07 16:59:26.321+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.321+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:321,0.139889,0.042300,0.083460
06-07 16:59:26.321+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:327,6.090000,-1.400000,-0.910000
06-07 16:59:26.321+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:331,5.040000,-1.050000,-0.840000
06-07 16:59:26.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.331+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:315,2.191825,-0.911665,9.583255
06-07 16:59:26.341+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.341+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:323,2.118999,-0.990329,9.523627
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:26.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390766349,000000, pattern:[H:mm][0;m
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:26.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:26.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:59:26.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:59][0;m
06-07 16:59:26.341+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:340,2.590000,0.420000,-0.630000
06-07 16:59:26.341+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.341+0200 W/LOCATION(13894): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:352,0.560000,0.280000,-0.770000
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:356,0.630000,0.630000,-0.420000
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:361,0.490000,0.210000,-0.560000
06-07 16:59:26.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.361+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.361+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:26.361+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:365,0.980000,-0.210000,-0.630000
06-07 16:59:26.361+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:26:367,83
06-07 16:59:26.371+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.371+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:376,2.122864,-0.985946,9.523221
06-07 16:59:26.371+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:346,0.147004,0.052343,0.095520
06-07 16:59:26.371+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.381+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:26.381+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.381+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:388,1.540000,-0.210000,-0.700000
06-07 16:59:26.381+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:26:388,797.000000
06-07 16:59:26.381+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:380,2.256432,-0.952343,9.607183
06-07 16:59:26.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.391+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.391+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.391+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:400,1.890000,0.140000,-0.560000
06-07 16:59:26.401+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:384,0.171853,0.047959,0.098319
06-07 16:59:26.401+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.401+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:400,2.127661,-0.980930,9.522669
06-07 16:59:26.411+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:403,2.266003,-0.937986,9.619147
06-07 16:59:26.411+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.411+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.411+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.411+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:421,1.260000,0.560000,-0.210000
06-07 16:59:26.421+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:414,0.112020,0.033372,0.094085
06-07 16:59:26.421+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.421+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:422,2.128924,-0.975470,9.522947
06-07 16:59:26.421+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:424,2.294717,-0.937986,9.621540
06-07 16:59:26.431+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.431+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:441,-0.490000,0.840000,-0.140000
06-07 16:59:26.441+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:433,0.101187,-0.015158,0.022022
06-07 16:59:26.441+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.441+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:439,2.129016,-0.971810,9.523301
06-07 16:59:26.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:445,2.239682,-0.947558,9.616754
06-07 16:59:26.451+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.451+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.451+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:460,0.070000,0.210000,-0.420000
06-07 16:59:26.451+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:451,0.170487,0.074502,-0.014224
06-07 16:59:26.461+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.461+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:458,2.132382,-0.965252,9.523214
06-07 16:59:26.461+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:469,0.047479,0.051194,0.000219
06-07 16:59:26.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:459,2.230111,-0.990629,9.544970
06-07 16:59:26.461+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.471+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.471+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.471+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.481+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:485,1.260000,0.210000,-0.420000
06-07 16:59:26.481+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:481,2.299503,-0.897308,9.509077
06-07 16:59:26.481+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:477,2.133572,-0.963283,9.523148
06-07 16:59:26.481+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.491+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:486,0.125252,0.065975,0.107964
06-07 16:59:26.491+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:500,0.910000,-0.350000,-0.280000
06-07 16:59:26.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.501+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:496,2.137263,-0.959168,9.522736
06-07 16:59:26.501+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:501,2.179861,-0.914058,9.523434
06-07 16:59:26.501+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.501+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:505,0.138312,0.054681,0.096412
06-07 16:59:26.501+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.511+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.511+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.511+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:521,0.210000,-0.840000,-0.140000
06-07 16:59:26.521+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:513,2.139096,-0.953179,9.522925
06-07 16:59:26.521+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.521+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:516,2.258825,-0.897308,9.631111
06-07 16:59:26.521+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.521+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:521,0.107765,0.046300,0.022044
06-07 16:59:26.521+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.531+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.541+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:26:542,0.490000,-0.770000,-0.140000
06-07 16:59:26.541+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:531,2.142257,-0.948959,9.522636
06-07 16:59:26.541+0200 I/gravity (13909): es.ugr.frailty.gravity - capturing data
06-07 16:59:26.541+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:26:539,0.106997,0.013366,0.079761
06-07 16:59:26.541+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:26:534,2.275574,-0.904487,9.619147
06-07 16:59:26.541+0200 I/gravity (13909): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:26:550,2.147335,-0.947762,9.521611
06-07 16:59:26.551+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:26.551+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:26.551+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:26.561+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11138946c6f63152838356
