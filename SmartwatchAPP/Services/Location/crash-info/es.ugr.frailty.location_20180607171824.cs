S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19780
Date: 2018-06-07 17:18:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf719652d, r5   = 0xf7408f98
r6   = 0xffaca910, r7   = 0xffaca7c0
r8   = 0xf7405c18, r9   = 0x00000000
r10  = 0xffaca89c, fp   = 0xffaca910
ip   = 0x00000001, sp   = 0xffaca798
lr   = 0xf7196539, pc   = 0xf71ff228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     78600 KB
Buffers:     12980 KB
Cached:     111992 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11632 KB
VmRSS:       11632 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19780 TID = 19780
19780 19782 

Maps Information
f4061000 f4860000 rw-p [stack:19782]
f4867000 f4869000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4871000 f4875000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f487e000 f4880000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4888000 f488b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f489a000 f489f000 r-xp /usr/lib/libsystem.so.0.0.0
f48aa000 f48ad000 r-xp /lib/libattr.so.1.1.0
f48b5000 f48c5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48cd000 f48d6000 r-xp /usr/lib/libedbus.so.1.7.99
f48de000 f48df000 r-xp /usr/lib/libresponse.so.0.2.96
f48e8000 f48ed000 r-xp /usr/lib/libproc-stat.so.0.2.96
f618f000 f6295000 r-xp /usr/lib/libicuuc.so.57.1
f62ab000 f6433000 r-xp /usr/lib/libicui18n.so.57.1
f6443000 f6450000 r-xp /usr/lib/libail.so.0.1.0
f6459000 f6460000 r-xp /usr/lib/libminizip.so.1.0.0
f6469000 f6612000 r-xp /usr/lib/libcrypto.so.1.0.0
f6632000 f6679000 r-xp /usr/lib/libssl.so.1.0.0
f6685000 f6687000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f668f000 f6696000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f669f000 f66a6000 r-xp /lib/libcrypt-2.13.so
f66d7000 f66da000 r-xp /lib/libcap.so.2.21
f66e2000 f66e4000 r-xp /usr/lib/libiri.so
f66ec000 f6735000 r-xp /usr/lib/libmdm.so.1.2.69
f673d000 f6743000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f674b000 f676e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6778000 f677a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6782000 f679f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67a8000 f67ac000 r-xp /usr/lib/libsmack.so.1.0.0
f67b5000 f67ce000 r-xp /usr/lib/libnetwork.so.0.0.0
f67d7000 f67df000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67e7000 f67ed000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67f6000 f67f8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6801000 f6811000 r-xp /lib/libresolv-2.13.so
f6815000 f682d000 r-xp /usr/lib/liblzma.so.5.0.3
f6836000 f6838000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6840000 f685a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6862000 f6891000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f689a000 f68a9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68b3000 f68bd000 r-xp /usr/lib/libsensord-shared.so
f68c6000 f6999000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69a4000 f69ba000 r-xp /lib/libz.so.1.2.5
f69c2000 f69c7000 r-xp /usr/lib/libffi.so.5.0.10
f69cf000 f69d0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69d8000 f69e8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69f0000 f6a09000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a11000 f6a13000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a1b000 f6a90000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a9a000 f6aa0000 r-xp /lib/librt-2.13.so
f6aa9000 f6ac7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ad1000 f6ad2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ada000 f6afd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b05000 f6b0a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b12000 f6b3c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b45000 f6b5c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b64000 f6bcd000 r-xp /lib/libm-2.13.so
f6bd6000 f6c6a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c7d000 f6c82000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c8a000 f6c91000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c99000 f6cc3000 r-xp /usr/lib/libsensor.so.1.9.6
f6ccc000 f6d98000 r-xp /usr/lib/libxml2.so.2.7.8
f6da5000 f6da7000 r-xp /usr/lib/libiniparser.so.0
f6db0000 f6db6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dbf000 f6e8f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e90000 f6ec4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ecd000 f6f09000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f11000 f6f14000 r-xp /usr/lib/libbundle.so.0.1.22
f6f1c000 f6f22000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f2a000 f6f6b000 r-xp /usr/lib/libeina.so.1.7.99
f6f74000 f6f8b000 r-xp /usr/lib/libecore.so.1.7.99
f6fa2000 f6fab000 r-xp /usr/lib/libvconf.so.0.2.45
f6fb3000 f6fc7000 r-xp /lib/libpthread-2.13.so
f6fd2000 f6fdf000 r-xp /usr/lib/libaul.so.0.1.0
f6fe9000 f6feb000 r-xp /lib/libdl-2.13.so
f6ff4000 f6fff000 r-xp /lib/libunwind.so.8.0.1
f702c000 f7034000 r-xp /lib/libgcc_s-4.6.so.1
f7035000 f7159000 r-xp /lib/libc-2.13.so
f7167000 f7169000 r-xp /usr/lib/libdlog.so.0.0.0
f7171000 f717d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7186000 f718b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7193000 f71a2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71aa000 f71ae000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71b7000 f71ba000 r-xp /usr/lib/libappcore-agent.so.1.1
f71c2000 f71c4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71cc000 f71d0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71d8000 f71f5000 r-xp /lib/ld-2.13.so
f71fe000 f7201000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7201000 f7205000 r-xp /usr/lib/libsys-assert.so
f73d5000 f7446000 rw-p [heap]
ffaac000 ffacd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19780)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71ff228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7196539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e9d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e9bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ea7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6eadbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6eaddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ee275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6edd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e9bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ea7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6eadbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6eaddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6edfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ee0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ee7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf487f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4872171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6945663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6df2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6df47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f84ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f7fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f805a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f80879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71b8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71b87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71ff5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf704c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71fef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
6-07 17:18:23.341+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:23.341+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:18:23.341+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:18:23.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:23.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:23.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:18:23.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:18:23.361+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:18:23.361+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:23.361+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:18:23.361+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:18:23.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:23.371+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:23.381+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:18:23.381+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:18:23.381+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:18:23.391+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:23.401+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:23.401+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:23.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19670), cmd(0)
06-07 17:18:23.401+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:23.401+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:18:23.401+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:23.401+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:18:23.401+0200 I/utils   (19670): specific action
06-07 17:18:23.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:23.401+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:23.401+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:23.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:18:23.421+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:23.421+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:23.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19663), cmd(0)
06-07 17:18:23.421+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:23.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(19682), cmd(0)
06-07 17:18:23.431+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:23.431+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:18:23.431+0200 I/utils   (19682): specific action
06-07 17:18:23.431+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:18:23.431+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:23.431+0200 I/utils   (19663): specific action
06-07 17:18:23.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.431+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:23:412,923.000000
06-07 17:18:23.431+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:298,0.311985,-0.089212,9.801280
06-07 17:18:23.441+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.441+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:447,0.311037,-0.090362,9.801300
06-07 17:18:23.441+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.451+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:452,0.310905,-0.092097,9.801288
06-07 17:18:23.451+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.451+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:457,0.310147,-0.092552,9.801308
06-07 17:18:23.461+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.461+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:466,0.310162,-0.092794,9.801305
06-07 17:18:23.461+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.471+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:473,0.309122,-0.094987,9.801316
06-07 17:18:23.471+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.481+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:479,0.308228,-0.094952,9.801345
06-07 17:18:23.481+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.481+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:488,0.308522,-0.094917,9.801336
06-07 17:18:23.481+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.491+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:494,0.309188,-0.093635,9.801328
06-07 17:18:23.491+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.501+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:503,0.309000,-0.092674,9.801343
06-07 17:18:23.501+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.501+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:508,0.310953,-0.093477,9.801273
06-07 17:18:23.501+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.511+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:513,0.310202,-0.094836,9.801284
06-07 17:18:23.511+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.511+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:518,0.310483,-0.093621,9.801287
06-07 17:18:23.511+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.521+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:525,0.310109,-0.093265,9.801302
06-07 17:18:23.521+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.521+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:530,0.311921,-0.092339,9.801253
06-07 17:18:23.531+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.531+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:536,0.312540,-0.092536,9.801231
06-07 17:18:23.531+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.541+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:543,0.312904,-0.093942,9.801207
06-07 17:18:23.541+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.541+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:548,0.311643,-0.092637,9.801259
06-07 17:18:23.541+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.551+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:553,0.310637,-0.091327,9.801304
06-07 17:18:23.551+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.561+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:559,0.310484,-0.088575,9.801333
06-07 17:18:23.561+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.561+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:568,0.310432,-0.087702,9.801343
06-07 17:18:23.561+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.571+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:573,0.310610,-0.086656,9.801347
06-07 17:18:23.571+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.571+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:578,0.312210,-0.087790,9.801286
06-07 17:18:23.571+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:442,-0.039653,0.033643,-0.002617
06-07 17:18:23.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.581+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:23.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:23.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.591+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:596,0.279960,-0.107677,9.824929
06-07 17:18:23.591+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:23.601+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:23:603,922.000000
06-07 17:18:23.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:607,-0.004374,0.024754,0.057153
06-07 17:18:23.601+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:600,0.070000,0.070000,0.070000
06-07 17:18:23.601+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:585,0.312566,-0.088135,9.801271
06-07 17:18:23.611+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.611+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:616,0.313212,-0.090285,9.801231
06-07 17:18:23.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:627,-0.012194,-0.017750,0.047509
06-07 17:18:23.621+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:626,0.315853,-0.081356,9.841680
06-07 17:18:23.631+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:631,0.070000,0.070000,0.070000
06-07 17:18:23.631+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.641+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:650,0.313460,-0.081356,9.829715
06-07 17:18:23.651+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:641,0.312703,-0.093219,9.801220
06-07 17:18:23.651+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.661+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:655,0.070000,0.070000,0.070000
06-07 17:18:23.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:654,0.031193,-0.016613,0.002024
06-07 17:18:23.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.661+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:664,0.312435,-0.093463,9.801226
06-07 17:18:23.671+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:673,0.313460,-0.136391,9.856036
06-07 17:18:23.681+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:685,0.310656,-0.094146,9.801276
06-07 17:18:23.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:675,0.070000,-0.070000,0.140000
06-07 17:18:23.681+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:678,-0.018021,-0.011107,0.047462
06-07 17:18:23.681+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:695,0.313460,-0.119641,9.827322
06-07 17:18:23.691+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:702,0.140000,0.070000,0.070000
06-07 17:18:23.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:706,0.019123,-0.027277,0.030753
06-07 17:18:23.701+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.701+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:711,0.308904,-0.092319,9.801349
06-07 17:18:23.711+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.711+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.711+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.721+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:724,0.140000,-0.070000,0.070000
06-07 17:18:23.721+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.731+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:719,0.327817,-0.098106,9.846465
06-07 17:18:23.731+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:724,0.049242,0.028079,0.025926
06-07 17:18:23.731+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.741+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.741+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:733,0.308588,-0.091064,9.801371
06-07 17:18:23.741+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:748,0.140000,-0.070000,0.070000
06-07 17:18:23.741+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:751,0.039051,-0.025880,0.030742
06-07 17:18:23.751+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.751+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:756,0.307552,-0.091784,9.801396
06-07 17:18:23.751+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:742,0.318245,-0.114855,9.829715
06-07 17:18:23.751+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.761+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.761+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:767,0.320638,-0.071785,9.832108
06-07 17:18:23.761+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.761+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:771,-0.070000,-0.070000,0.070000
06-07 17:18:23.771+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.771+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:775,0.027926,-0.034564,0.071455
06-07 17:18:23.771+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.781+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.781+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:23.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:23.781+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:780,0.308693,-0.092364,9.801355
06-07 17:18:23.791+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:23.801+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:23:802,920.000000
06-07 17:18:23.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:790,0.296710,-0.095713,9.815358
06-07 17:18:23.801+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.811+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:795,0.070000,-0.070000,0.070000
06-07 17:18:23.811+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:798,-0.022160,-0.033122,-0.040924
06-07 17:18:23.821+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:817,0.307289,-0.092685,9.801396
06-07 17:18:23.821+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:835,-0.027779,0.042389,0.064400
06-07 17:18:23.831+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.831+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:829,0.303888,-0.112463,9.786645
06-07 17:18:23.841+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:835,0.070000,-0.070000,0.070000
06-07 17:18:23.841+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:845,0.307908,-0.093761,9.801367
06-07 17:18:23.841+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.841+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:855,0.318245,-0.081356,9.846465
06-07 17:18:23.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:867,0.291924,-0.052642,9.822537
06-07 17:18:23.861+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:872,0.332602,-0.102891,9.815358
06-07 17:18:23.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:877,0.306281,-0.131605,9.815358
06-07 17:18:23.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:882,0.356531,-0.069392,9.820145
06-07 17:18:23.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:886,0.344566,-0.105284,9.853643
06-07 17:18:23.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:891,0.299103,-0.110070,9.868000
06-07 17:18:23.881+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:895,0.325424,-0.083749,9.858429
06-07 17:18:23.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:899,0.337388,-0.114855,9.832108
06-07 17:18:23.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:904,0.320638,-0.055035,9.829715
06-07 17:18:23.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:909,0.320638,-0.095713,9.836893
06-07 17:18:23.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:913,0.327817,-0.076570,9.846465
06-07 17:18:23.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:918,0.306281,-0.059821,9.777073
06-07 17:18:23.911+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:922,0.356531,-0.052642,9.817751
06-07 17:18:23.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:927,0.318245,-0.126820,9.839286
06-07 17:18:23.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.921+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:931,0.311067,-0.081356,9.815358
06-07 17:18:23.931+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.931+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:936,0.309462,-0.092256,9.801332
06-07 17:18:23.931+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.931+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:859,0.070000,-0.070000,0.070000
06-07 17:18:23.931+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:23.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:946,0.349352,-0.114855,9.786645
06-07 17:18:23.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:951,0.346959,-0.107677,9.803394
06-07 17:18:23.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:23.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:862,-0.031111,-0.011251,0.023688
06-07 17:18:23.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:958,0.006345,0.012713,0.040366
06-07 17:18:23.951+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:23:944,-0.070000,0.070000,0.070000
06-07 17:18:23.961+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:940,0.311692,-0.093698,9.801248
06-07 17:18:23.961+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.961+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:969,0.312524,-0.095031,9.801208
06-07 17:18:23.961+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:23.971+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:23.971+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:977,0.006004,0.013184,0.028341
06-07 17:18:23.971+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.021+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:24.021+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:24.031+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:24.041+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:24:35,919.000000
06-07 17:18:24.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:65,-0.070000,0.070000,0.070000
06-07 17:18:24.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.081+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:23:982,0.006253,-0.042693,0.054647
06-07 17:18:24.091+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:23:955,0.320638,-0.064606,9.865608
06-07 17:18:24.091+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:100,0.303888,-0.057428,9.848858
06-07 17:18:24.111+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:23:974,0.311071,-0.096426,9.801241
06-07 17:18:24.111+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.111+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:91,0.070000,0.070000,0.070000
06-07 17:18:24.111+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.121+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.121+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:125,0.006428,-0.026717,0.025920
06-07 17:18:24.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:24.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:24.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:24.131+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.171+0200 W/LOCATION(19780): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:18:24.181+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:24.181+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:24.221+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:24.221+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:24:226,916.000000
06-07 17:18:24.221+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:141,0.303888,-0.102891,9.824929
06-07 17:18:24.221+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:136,0.309508,-0.094069,9.801313
06-07 17:18:24.231+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.231+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:131,0.070000,0.070000,0.070000
06-07 17:18:24.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.241+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:256,0.070000,0.070000,0.070000
06-07 17:18:24.261+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:245,0.320638,-0.078963,9.791430
06-07 17:18:24.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:249,0.020813,-0.003346,0.045080
06-07 17:18:24.271+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:259,0.307455,-0.094540,9.801373
06-07 17:18:24.271+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.281+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.281+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:289,0.306281,-0.081356,9.839286
06-07 17:18:24.291+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:297,0.140000,0.070000,0.070000
06-07 17:18:24.301+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:289,0.011247,-0.019212,0.028337
06-07 17:18:24.311+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.311+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.321+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.321+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:304,0.307207,-0.093698,9.801389
06-07 17:18:24.321+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.331+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:327,0.013142,0.023784,0.030746
06-07 17:18:24.341+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:323,0.323031,-0.069392,9.844072
06-07 17:18:24.341+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.351+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:330,0.070000,0.070000,0.070000
06-07 17:18:24.351+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.351+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:339,0.307031,-0.092924,9.801402
06-07 17:18:24.351+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.361+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.371+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:375,0.307004,-0.094760,9.801385
06-07 17:18:24.381+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:24.381+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:24.381+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:360,0.318245,-0.083749,9.844072
06-07 17:18:24.381+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:369,0.140000,0.070000,0.070000
06-07 17:18:24.381+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:365,-0.011206,0.000627,0.014017
06-07 17:18:24.391+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.391+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.391+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:24.401+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:24:403,916.000000
06-07 17:18:24.401+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.431+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:400,0.318245,-0.114855,9.834501
06-07 17:18:24.431+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:414,-0.003163,-0.017619,-0.014738
06-07 17:18:24.431+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:419,0.306998,-0.095643,9.801377
06-07 17:18:24.431+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:411,0.070000,0.070000,0.070000
06-07 17:18:24.441+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.451+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.451+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:445,0.354138,-0.107677,9.805787
06-07 17:18:24.461+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:460,0.011194,0.013488,0.045082
06-07 17:18:24.461+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.461+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:453,0.070000,0.070000,0.070000
06-07 17:18:24.461+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:459,0.307496,-0.095569,9.801362
06-07 17:18:24.481+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.491+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:476,0.318245,-0.117248,9.803394
06-07 17:18:24.491+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:490,0.070000,0.070000,0.140000
06-07 17:18:24.501+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:491,-0.014626,0.042878,0.021145
06-07 17:18:24.511+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:494,0.307916,-0.096340,9.801341
06-07 17:18:24.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.511+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.521+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.521+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:527,0.070000,-0.070000,0.070000
06-07 17:18:24.521+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:531,0.308013,-0.094986,9.801352
06-07 17:18:24.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:526,0.026015,-0.008234,0.013959
06-07 17:18:24.531+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:511,0.315853,-0.112463,9.839286
06-07 17:18:24.541+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.541+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.551+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.551+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:546,0.315853,-0.078963,9.810574
06-07 17:18:24.571+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:564,0.000723,-0.039186,0.013906
06-07 17:18:24.571+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:563,0.307052,-0.094844,9.801383
06-07 17:18:24.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:559,0.070000,-0.070000,0.140000
06-07 17:18:24.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:24.581+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:24.581+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.581+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.591+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:595,0.306551,-0.095520,9.801393
06-07 17:18:24.591+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:24.601+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:24:603,915.000000
06-07 17:18:24.601+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:607,0.070000,-0.070000,0.070000
06-07 17:18:24.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:587,0.325424,-0.136391,9.863215
06-07 17:18:24.601+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19639) cmd(0)
06-07 17:18:24.611+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:600,0.050111,0.023346,0.018722
06-07 17:18:24.611+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.621+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:619,0.303888,-0.086142,9.848858
06-07 17:18:24.621+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.641+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:631,0.306587,-0.094658,9.801399
06-07 17:18:24.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:634,0.070000,0.070000,0.070000
06-07 17:18:24.651+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:635,0.038160,-0.010844,0.052237
06-07 17:18:24.651+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.661+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.661+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:653,0.315853,-0.086142,9.832108
06-07 17:18:24.671+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19651) cmd(0)
06-07 17:18:24.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:673,0.070000,-0.070000,0.070000
06-07 17:18:24.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.691+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:675,-0.009269,-0.016891,0.066643
06-07 17:18:24.701+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:669,0.305559,-0.092420,9.801453
06-07 17:18:24.701+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.721+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.721+0200 E/AUL     (19639): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:18:24.731+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:718,0.306420,-0.092737,9.801423
06-07 17:18:24.731+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:705,0.323031,-0.145962,9.810574
06-07 17:18:24.741+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.741+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:24.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(19639), cmd(0)
06-07 17:18:24.751+0200 W/CAPI_APPFW_APP_CONTROL(19639): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:24.751+0200 I/utils   (19639): specific action
06-07 17:18:24.751+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:24.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19639), cmd(0)
06-07 17:18:24.761+0200 W/CAPI_APPFW_APP_CONTROL(19639): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:24.761+0200 I/utils   (19639): specific action
06-07 17:18:24.761+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.771+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:735,0.070000,-0.070000,0.070000
06-07 17:18:24.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:24.781+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:24.791+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.791+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:770,0.323031,-0.112463,9.827322
06-07 17:18:24.791+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:768,0.015522,0.009854,0.057124
06-07 17:18:24.791+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:24.801+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:24:803,912.000000
06-07 17:18:24.801+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.821+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:821,0.339781,-0.126820,9.851252
06-07 17:18:24.821+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:782,0.306406,-0.094440,9.801407
06-07 17:18:24.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:821,0.028498,-0.020665,0.030777
06-07 17:18:24.851+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.851+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:812,0.070000,-0.070000,0.070000
06-07 17:18:24.851+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.871+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.881+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:858,0.308372,-0.093179,9.801357
06-07 17:18:24.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:883,0.011508,0.038466,0.028384
06-07 17:18:24.901+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:878,0.327817,-0.129212,9.841680
06-07 17:18:24.901+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:876,0.070000,0.070000,0.070000
06-07 17:18:24.901+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.901+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.911+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:923,0.332602,-0.107677,9.810574
06-07 17:18:24.931+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:927,0.010556,-0.001398,0.035601
06-07 17:18:24.941+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:910,0.309901,-0.093603,9.801305
06-07 17:18:24.941+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:24.941+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:921,0.070000,0.070000,0.140000
06-07 17:18:24.951+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:24.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:24.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:24.971+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:24:973,0.070000,0.070000,0.070000
06-07 17:18:24.981+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:24:962,0.301496,-0.081356,9.808180
06-07 17:18:24.991+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:24:957,0.308890,-0.094190,9.801332
06-07 17:18:25.001+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:25.001+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:24:970,0.017750,0.015684,0.045153
06-07 17:18:25.001+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:25.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:25.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:25.031+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:25.031+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:25.031+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:25.041+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:25:43,912.000000
06-07 17:18:25.051+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:25:32,0.309130,-0.093501,9.801331
06-07 17:18:25.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:25:42,0.306281,-0.100499,9.803394
06-07 17:18:25.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:25:52,0.070000,0.070000,0.070000
06-07 17:18:25.061+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:25.071+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:25.071+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:25:54,-0.003818,0.032409,-0.024240
06-07 17:18:25.071+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:25.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:25.091+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:25:78,0.310082,-0.094315,9.801292
06-07 17:18:25.101+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:25.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:25:85,0.282353,-0.093320,9.812965
06-07 17:18:25.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:25.101+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:25:111,0.310067,-0.092254,9.801312
06-07 17:18:25.101+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:25:91,0.045330,0.039009,0.016468
06-07 17:18:25.111+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11197806c6f63152838470
