S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20155
Date: 2018-06-07 17:20:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73a652d, r5   = 0xf761af98
r6   = 0xffe9e260, r7   = 0xffe9e110
r8   = 0xf7617c18, r9   = 0x00000000
r10  = 0xffe9e1ec, fp   = 0xffe9e260
ip   = 0x00000001, sp   = 0xffe9e0e8
lr   = 0xf73a6539, pc   = 0xf740f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    179836 KB
Buffers:      5340 KB
Cached:      59432 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11700 KB
VmRSS:       11700 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20155 TID = 20155
20155 20160 

Maps Information
f4271000 f4a70000 rw-p [stack:20160]
f4a77000 f4a79000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a81000 f4a85000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a8e000 f4a90000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a98000 f4a9b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aaa000 f4aaf000 r-xp /usr/lib/libsystem.so.0.0.0
f4aba000 f4abd000 r-xp /lib/libattr.so.1.1.0
f4ac5000 f4ad5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4add000 f4ae6000 r-xp /usr/lib/libedbus.so.1.7.99
f4aee000 f4aef000 r-xp /usr/lib/libresponse.so.0.2.96
f4af8000 f4afd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f639f000 f64a5000 r-xp /usr/lib/libicuuc.so.57.1
f64bb000 f6643000 r-xp /usr/lib/libicui18n.so.57.1
f6653000 f6660000 r-xp /usr/lib/libail.so.0.1.0
f6669000 f6670000 r-xp /usr/lib/libminizip.so.1.0.0
f6679000 f6822000 r-xp /usr/lib/libcrypto.so.1.0.0
f6842000 f6889000 r-xp /usr/lib/libssl.so.1.0.0
f6895000 f6897000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f689f000 f68a6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68af000 f68b6000 r-xp /lib/libcrypt-2.13.so
f68e7000 f68ea000 r-xp /lib/libcap.so.2.21
f68f2000 f68f4000 r-xp /usr/lib/libiri.so
f68fc000 f6945000 r-xp /usr/lib/libmdm.so.1.2.69
f694d000 f6953000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f695b000 f697e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6988000 f698a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6992000 f69af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69b8000 f69bc000 r-xp /usr/lib/libsmack.so.1.0.0
f69c5000 f69de000 r-xp /usr/lib/libnetwork.so.0.0.0
f69e7000 f69ef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69f7000 f69fd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a06000 f6a08000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a11000 f6a21000 r-xp /lib/libresolv-2.13.so
f6a25000 f6a3d000 r-xp /usr/lib/liblzma.so.5.0.3
f6a46000 f6a48000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a50000 f6a6a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a72000 f6aa1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aaa000 f6ab9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ac3000 f6acd000 r-xp /usr/lib/libsensord-shared.so
f6ad6000 f6ba9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bb4000 f6bca000 r-xp /lib/libz.so.1.2.5
f6bd2000 f6bd7000 r-xp /usr/lib/libffi.so.5.0.10
f6bdf000 f6be0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be8000 f6bf8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c00000 f6c19000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c21000 f6c23000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c2b000 f6ca0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6caa000 f6cb0000 r-xp /lib/librt-2.13.so
f6cb9000 f6cd7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ce1000 f6ce2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cea000 f6d0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d15000 f6d1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d22000 f6d4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d55000 f6d6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d74000 f6ddd000 r-xp /lib/libm-2.13.so
f6de6000 f6e7a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e8d000 f6e92000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e9a000 f6ea1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ea9000 f6ed3000 r-xp /usr/lib/libsensor.so.1.9.6
f6edc000 f6fa8000 r-xp /usr/lib/libxml2.so.2.7.8
f6fb5000 f6fb7000 r-xp /usr/lib/libiniparser.so.0
f6fc0000 f6fc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fcf000 f709f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70a0000 f70d4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70dd000 f7119000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7121000 f7124000 r-xp /usr/lib/libbundle.so.0.1.22
f712c000 f7132000 r-xp /usr/lib/libappsvc.so.0.1.0
f713a000 f717b000 r-xp /usr/lib/libeina.so.1.7.99
f7184000 f719b000 r-xp /usr/lib/libecore.so.1.7.99
f71b2000 f71bb000 r-xp /usr/lib/libvconf.so.0.2.45
f71c3000 f71d7000 r-xp /lib/libpthread-2.13.so
f71e2000 f71ef000 r-xp /usr/lib/libaul.so.0.1.0
f71f9000 f71fb000 r-xp /lib/libdl-2.13.so
f7204000 f720f000 r-xp /lib/libunwind.so.8.0.1
f723c000 f7244000 r-xp /lib/libgcc_s-4.6.so.1
f7245000 f7369000 r-xp /lib/libc-2.13.so
f7377000 f7379000 r-xp /usr/lib/libdlog.so.0.0.0
f7381000 f738d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7396000 f739b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73a3000 f73b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73ba000 f73be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73c7000 f73ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f73d2000 f73d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73dc000 f73e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73e8000 f7405000 r-xp /lib/ld-2.13.so
f740e000 f7411000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7411000 f7415000 r-xp /usr/lib/libsys-assert.so
f75e7000 f7675000 rw-p [heap]
ffe7f000 ffea0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20155)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf740f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70ad3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70f275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70ed1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70efe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70f0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70f7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a8f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a82171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b55663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7002fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7194ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf718fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7190879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf740f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf725c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf740ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
1+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:451,0.366102,-0.102891,9.872787
06-07 17:20:49.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:49.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:49.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:20:49.491+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:49.491+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:49.491+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:49.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(19621), cmd(0)
06-07 17:20:49.501+0200 I/utils   (19621): specific action
06-07 17:20:49.501+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:49:502,744.000000
06-07 17:20:49.511+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:475,0.030535,-0.003909,-0.026669
06-07 17:20:49.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:20:49.531+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:20:49.531+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.531+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:20:49.531+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:20:49.531+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:479,0.070000,0.140000,0.070000
06-07 17:20:49.531+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.531+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.541+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:483,0.309315,-0.093849,9.801321
06-07 17:20:49.541+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.561+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:534,0.296710,-0.083749,9.832108
06-07 17:20:49.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20194
06-07 17:20:49.561+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:549,-0.006423,-0.008662,-0.007491
06-07 17:20:49.571+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:556,-0.070000,0.140000,0.070000
06-07 17:20:49.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.581+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:557,0.307632,-0.093202,9.801380
06-07 17:20:49.581+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:588,0.318245,-0.095713,9.841680
06-07 17:20:49.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:49.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(20194), cmd(0)
06-07 17:20:49.591+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:606,0.022971,0.106440,-0.052974
06-07 17:20:49.601+0200 W/CAPI_APPFW_APP_CONTROL(20194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:49.601+0200 I/utils   (20194): specific action
06-07 17:20:49.601+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.621+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20194)
06-07 17:20:49.621+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:20:49.621+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.621+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:20:49.621+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:20:49.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.621+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.621+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19983
06-07 17:20:49.631+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.651+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19983)
06-07 17:20:49.651+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:20:49.651+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.651+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:20:49.651+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:20:49.661+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:628,0.307108,-0.092092,9.801408
06-07 17:20:49.671+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:615,-0.070000,-0.070000,0.070000
06-07 17:20:49.681+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:49.681+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:49.681+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.691+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:645,0.342174,-0.093320,9.844072
06-07 17:20:49.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.711+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.691+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.691+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:49.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19995
06-07 17:20:49.721+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19995)
06-07 17:20:49.721+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:20:49.721+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.721+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:20:49.721+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:20:49.721+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:731,-0.070000,-0.070000,0.070000
06-07 17:20:49.691+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:683,-0.003830,0.062932,0.016381
06-07 17:20:49.731+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:49:727,745.000000
06-07 17:20:49.731+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.691+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:697,0.302734,-0.092605,9.801538
06-07 17:20:49.731+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.741+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.741+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:745,0.015340,0.045638,-0.048253
06-07 17:20:49.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.751+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:717,0.320638,-0.102891,9.832108
06-07 17:20:49.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:20:49.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:49.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19663), cmd(0)
06-07 17:20:49.761+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:20:49.761+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:20:49.761+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.761+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:20:49.761+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:49.761+0200 I/utils   (19663): specific action
06-07 17:20:49.771+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:20:49.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.771+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:20:49.781+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:20:49.781+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:20:49.781+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.781+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:20:49.781+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:20:49.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:49.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:49.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:20:49.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:49.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19682), cmd(0)
06-07 17:20:49.801+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:49.801+0200 I/utils   (19682): specific action
06-07 17:20:49.801+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:20:49.801+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:20:49.801+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:49.801+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:764,0.311452,-0.097042,9.801223
06-07 17:20:49.801+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.811+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:812,0.306095,-0.091102,9.801449
06-07 17:20:49.811+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.811+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:817,0.300889,-0.098838,9.801535
06-07 17:20:49.811+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.821+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:822,0.308126,-0.118374,9.801093
06-07 17:20:49.821+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.821+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:828,0.307916,-0.120566,9.801073
06-07 17:20:49.821+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.831+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:833,0.315585,-0.126520,9.800755
06-07 17:20:49.831+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.831+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:839,0.309958,-0.112897,9.801100
06-07 17:20:49.831+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.841+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:49.841+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:49.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(15), pid(19670), cmd(0)
06-07 17:20:49.841+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:844,0.324098,-0.121114,9.800545
06-07 17:20:49.841+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.851+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:852,0.314072,-0.116641,9.800925
06-07 17:20:49.851+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.851+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:857,0.328204,-0.121145,9.800407
06-07 17:20:49.851+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.861+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:863,0.320656,-0.113119,9.800754
06-07 17:20:49.861+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.861+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:868,0.329361,-0.118685,9.800399
06-07 17:20:49.861+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.871+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:874,0.326907,-0.118407,9.800485
06-07 17:20:49.871+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.871+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:880,0.321582,-0.114644,9.800705
06-07 17:20:49.881+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.881+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:886,0.312917,-0.105325,9.801090
06-07 17:20:49.881+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.881+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:891,0.300540,-0.108956,9.801438
06-07 17:20:49.891+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.891+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:896,0.301698,-0.094497,9.801553
06-07 17:20:49.891+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.901+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:49.901+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:49.901+0200 I/utils   (19670): specific action
06-07 17:20:49.901+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:49.901+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:49:909,744.000000
06-07 17:20:49.911+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:758,-0.070000,-0.070000,0.070000
06-07 17:20:49.921+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:902,0.297669,-0.089596,9.801722
06-07 17:20:49.931+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.931+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.941+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:940,0.315853,-0.076570,9.851252
06-07 17:20:49.961+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:49.961+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:949,0.035782,-0.054448,0.078582
06-07 17:20:49.961+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:942,0.299452,-0.094041,9.801626
06-07 17:20:49.971+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:49.971+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:49.981+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:961,-0.070000,0.070000,0.070000
06-07 17:20:49.981+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:49.991+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:49:993,-0.004801,-0.073345,-0.081639
06-07 17:20:50.001+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:49:986,0.301304,-0.100674,9.801503
06-07 17:20:50.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:49:982,0.265603,-0.088534,9.839286
06-07 17:20:50.001+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.001+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:49:995,-0.070000,0.070000,0.070000
06-07 17:20:50.001+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.011+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.021+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:26,0.302716,-0.102055,9.801445
06-07 17:20:50.021+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.041+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:35,0.016608,-0.031701,0.047608
06-07 17:20:50.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:17,0.323031,-0.078963,9.796216
06-07 17:20:50.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.041+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.041+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:37,-0.070000,0.070000,0.070000
06-07 17:20:50.051+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.061+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.061+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:61,0.325424,-0.074178,9.856036
06-07 17:20:50.081+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:62,0.303634,-0.102006,9.801417
06-07 17:20:50.081+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:50.081+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:50.081+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.081+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:75,-0.010425,-0.004046,0.057216
06-07 17:20:50.081+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.081+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:84,-0.070000,0.070000,0.140000
06-07 17:20:50.081+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.091+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:95,0.304316,-0.101275,9.801404
06-07 17:20:50.101+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:50.101+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:50:107,742.000000
06-07 17:20:50.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:20:50.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:50.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:20:50.121+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.131+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:135,0.007008,0.048640,0.028480
06-07 17:20:50.141+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:95,0.313460,-0.119641,9.863215
06-07 17:20:50.141+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.141+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.151+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:136,-0.070000,0.070000,0.070000
06-07 17:20:50.151+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.151+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.161+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:165,-0.005872,0.010734,0.076345
06-07 17:20:50.171+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:158,0.305146,-0.101521,9.801375
06-07 17:20:50.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:161,0.323031,-0.071785,9.844072
06-07 17:20:50.181+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.181+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.181+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:180,-0.070000,0.070000,0.070000
06-07 17:20:50.201+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.211+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:204,0.002108,-0.021090,-0.038542
06-07 17:20:50.211+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:197,0.315853,-0.124427,9.858429
06-07 17:20:50.221+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:195,0.304960,-0.100364,9.801394
06-07 17:20:50.221+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.221+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.231+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.231+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:218,-0.070000,0.070000,0.070000
06-07 17:20:50.241+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:245,0.344566,-0.124427,9.824929
06-07 17:20:50.251+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.271+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:257,-0.004856,0.018045,0.169635
06-07 17:20:50.271+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:238,0.304844,-0.100749,9.801393
06-07 17:20:50.271+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.271+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.281+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.281+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:50.281+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:50.281+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:261,-0.140000,-0.070000,0.140000
06-07 17:20:50.281+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:287,0.305257,-0.101333,9.801374
06-07 17:20:50.291+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.291+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:50.291+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:50:301,744.000000
06-07 17:20:50.311+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:315,-0.070000,0.070000,0.070000
06-07 17:20:50.311+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:295,0.351745,-0.124427,9.856036
06-07 17:20:50.311+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.321+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:299,0.039086,0.009760,0.023635
06-07 17:20:50.321+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.321+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.331+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.341+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:334,0.305982,-0.101827,9.801347
06-07 17:20:50.341+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:348,-0.070000,0.070000,0.070000
06-07 17:20:50.341+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:340,0.018660,0.001964,0.064348
06-07 17:20:50.351+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.361+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:337,0.346959,-0.076570,9.877571
06-07 17:20:50.361+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.361+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.361+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:369,0.305843,-0.101125,9.801358
06-07 17:20:50.361+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.371+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:375,0.033187,-0.003414,0.040409
06-07 17:20:50.401+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.401+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:386,0.301496,-0.110070,9.863215
06-07 17:20:50.401+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:409,0.305107,-0.101241,9.801380
06-07 17:20:50.411+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.411+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:390,-0.070000,0.070000,0.070000
06-07 17:20:50.411+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.421+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.431+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:435,-0.070000,-0.070000,0.070000
06-07 17:20:50.441+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.451+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:421,-0.031966,-0.001344,-0.000255
06-07 17:20:50.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:430,0.366102,-0.098106,9.868000
06-07 17:20:50.451+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.461+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.471+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.471+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:477,0.318245,-0.086142,9.911072
06-07 17:20:50.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:50.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:50.491+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:457,0.307176,-0.101561,9.801311
06-07 17:20:50.491+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:50.501+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:50:504,743.000000
06-07 17:20:50.501+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.501+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:471,0.008300,-0.020575,0.073859
06-07 17:20:50.501+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.511+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.521+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:487,-0.070000,-0.070000,0.070000
06-07 17:20:50.521+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:519,0.307181,-0.100850,9.801319
06-07 17:20:50.521+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.551+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.561+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:531,-0.010511,-0.031929,0.042747
06-07 17:20:50.561+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:553,-0.070000,-0.070000,0.070000
06-07 17:20:50.561+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:537,0.282353,-0.088534,9.829715
06-07 17:20:50.571+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.571+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.581+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.591+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:568,0.306593,-0.099628,9.801350
06-07 17:20:50.591+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:582,-0.021545,-0.023419,0.052302
06-07 17:20:50.601+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.601+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.611+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:586,0.294317,-0.119641,9.894321
06-07 17:20:50.611+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.611+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:588,-0.070000,-0.070000,0.070000
06-07 17:20:50.621+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:609,0.309606,-0.102214,9.801229
06-07 17:20:50.621+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.631+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.641+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19935) cmd(0)
06-07 17:20:50.651+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:638,-0.070000,0.140000,0.070000
06-07 17:20:50.651+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:621,0.035018,-0.022479,-0.012342
06-07 17:20:50.651+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:635,0.294317,-0.105284,9.868000
06-07 17:20:50.661+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.661+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20019) cmd(0)
06-07 17:20:50.671+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.671+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:655,0.310469,-0.103993,9.801183
06-07 17:20:50.681+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:50.681+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:50.681+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.691+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.691+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:50.701+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:50:702,741.000000
06-07 17:20:50.711+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:679,0.007348,0.014300,0.059493
06-07 17:20:50.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:684,0.306281,-0.122034,9.863215
06-07 17:20:50.721+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.721+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:695,-0.070000,0.070000,0.070000
06-07 17:20:50.731+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.741+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.741+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:718,0.308790,-0.104578,9.801229
06-07 17:20:50.741+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19983) cmd(0)
06-07 17:20:50.751+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.751+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:736,-0.014322,0.046965,0.047524
06-07 17:20:50.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19995) cmd(0)
06-07 17:20:50.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:741,0.358923,-0.124427,9.827322
06-07 17:20:50.771+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:754,-0.070000,0.070000,0.070000
06-07 17:20:50.771+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.771+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.781+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:765,0.307570,-0.102312,9.801291
06-07 17:20:50.781+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.801+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.801+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:787,0.058494,0.046865,0.028325
06-07 17:20:50.811+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:795,0.301496,-0.088534,9.820145
06-07 17:20:50.821+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.821+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:805,-0.070000,0.070000,0.070000
06-07 17:20:50.821+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:814,0.308221,-0.098319,9.801312
06-07 17:20:50.821+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.831+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.841+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:833,-0.000742,0.008677,0.006825
06-07 17:20:50.861+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.871+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.881+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:50.881+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:50.891+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:50.901+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:50:900,741.000000
06-07 17:20:50.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:841,0.299103,-0.088534,9.856036
06-07 17:20:50.921+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:50.921+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:850,-0.070000,0.070000,0.070000
06-07 17:20:50.941+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:50.961+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:869,0.309286,-0.097412,9.801288
06-07 17:20:50.961+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:50:966,-0.070000,0.070000,0.070000
06-07 17:20:50.971+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:50.971+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:50:934,0.009562,0.031862,0.023545
06-07 17:20:50.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:50:949,0.287139,-0.126820,9.882358
06-07 17:20:50.981+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:50.981+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.001+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:6,-0.011632,-0.060918,0.004375
06-07 17:20:51.011+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.021+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:50:981,0.310422,-0.097721,9.801249
06-07 17:20:51.031+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.041+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:25,0.251246,-0.090927,9.834501
06-07 17:20:51.051+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.051+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:31,-0.070000,0.070000,0.070000
06-07 17:20:51.071+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.071+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.081+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:51.081+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:51.081+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:41,0.310996,-0.100261,9.801205
06-07 17:20:51.091+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.091+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:51.101+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:51:104,749.000000
06-07 17:20:51.101+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:77,0.277567,-0.098106,9.839286
06-07 17:20:51.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:20:51.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:20:51.131+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:20:51.131+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:62,0.010726,-0.058191,0.040267
06-07 17:20:51.141+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:86,-0.070000,0.070000,0.070000
06-07 17:20:51.151+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.161+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:165,-0.119210,-0.122561,-0.100937
06-07 17:20:51.171+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.171+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:118,0.311038,-0.101327,9.801192
06-07 17:20:51.171+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.181+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:176,0.332602,-0.112463,9.844072
06-07 17:20:51.191+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.201+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.201+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:178,-0.070000,0.070000,0.070000
06-07 17:20:51.211+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.221+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.221+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:201,0.311532,-0.100974,9.801180
06-07 17:20:51.241+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.251+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:213,0.009137,-0.029980,-0.002963
06-07 17:20:51.261+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:257,0.311477,-0.099135,9.801201
06-07 17:20:51.271+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.281+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:51.281+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:51.291+0200 W/LOCATION(20194): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:20:51.291+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:51.311+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:20:51:302,746.000000
06-07 17:20:51.321+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:235,0.070000,0.070000,0.140000
06-07 17:20:51.321+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:235,0.349352,-0.129212,9.848858
06-07 17:20:51.331+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.331+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.351+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.361+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:332,0.008901,0.014235,-0.038836
06-07 17:20:51.371+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.381+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:363,0.323031,-0.114855,9.851252
06-07 17:20:51.381+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:355,0.070000,0.070000,0.070000
06-07 17:20:51.381+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.391+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.391+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:368,0.310607,-0.098645,9.801233
06-07 17:20:51.401+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.411+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:406,0.070000,0.070000,0.070000
06-07 17:20:51.421+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:389,0.037269,-0.036798,0.044914
06-07 17:20:51.431+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.441+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope - capturing data
06-07 17:20:51.441+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:414,0.330210,-0.093320,9.839286
06-07 17:20:51.441+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer - capturing data
06-07 17:20:51.451+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:20:51:445,0.038186,0.017356,0.040190
06-07 17:20:51.451+0200 I/gravity (19995): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:20:51:433,0.308964,-0.097736,9.801294
06-07 17:20:51.461+0200 I/gravity (19995): es.ugr.frailty.gravity - capturing data
06-07 17:20:51.461+0200 I/accelerometer(19935): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:20:51:469,0.306281,-0.086142,9.827322
06-07 17:20:51.481+0200 I/linearacceleration(19983): es.ugr.frailty.linearacceleration - capturing data
06-07 17:20:51.481+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:20:51.491+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:20:51.491+0200 I/gyroscope(20019): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:20:51:463,0.070000,0.070000,0.070000
06-07 17:20:51.491+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:20:51.511+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:20:51.511+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:20:51.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:51.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:51.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19935
06-07 17:20:51.541+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19935)
06-07 17:20:51.541+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:20:51.541+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:51.541+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:20:51.541+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:20:51.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:51.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:51.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20019
06-07 17:20:51.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20019)
06-07 17:20:51.561+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:20:51.561+0200 I/servicemanager(19582): App control destroyed.
06-07 17:20:51.561+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:20:51.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:20:51.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:20:51.561+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:20:51.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:20:51.581+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:20:51.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(19621), cmd(0)
06-07 17:20:51.581+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:20:51.591+0200 I/utils   (19621): specific action
06-07 17:20:51.591+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:20:51.591+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11201556c6f63152838481
