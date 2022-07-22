S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20530
Date: 2018-06-07 17:22:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf717052d, r5   = 0xf74def98
r6   = 0xffe47a80, r7   = 0xffe47930
r8   = 0xf74dbc18, r9   = 0x00000000
r10  = 0xffe47a0c, fp   = 0xffe47a80
ip   = 0x00000001, sp   = 0xffe47908
lr   = 0xf7170539, pc   = 0xf71d9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     98584 KB
Buffers:     10600 KB
Cached:      53496 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11828 KB
VmRSS:       11828 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20530 TID = 20530
20530 20535 

Maps Information
f403b000 f483a000 rw-p [stack:20535]
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
f74ab000 f7539000 rw-p [heap]
ffe29000 ffe4a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20530)
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
cceleration: SM-R760,07/06/2018,17:24:34:518,-0.021111,-0.014359,0.100292
06-07 17:24:34.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.561+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21023
06-07 17:24:34.561+0200 W/CAPI_APPFW_APP_CONTROL(21023): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:34.561+0200 I/utils   (21023): specific action
06-07 17:24:34.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:34.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(21023), cmd(0)
06-07 17:24:34.561+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:538,0.306672,-0.086852,9.801469
06-07 17:24:34.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21023)
06-07 17:24:34.571+0200 I/servicemanager(20992): es.ugr.frailty.heartrate launch request sent!
06-07 17:24:34.571+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.571+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:24:34.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:24:34.571+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.581+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.581+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:578,0.003927,0.007964,0.021301
06-07 17:24:34.581+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:547,0.282353,-0.102891,9.844072
06-07 17:24:34.591+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:34.601+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:34:599,651.000000
06-07 17:24:34.601+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.601+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:584,-0.070000,-0.070000,0.070000
06-07 17:24:34.611+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.621+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.621+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:591,0.306618,-0.086386,9.801475
06-07 17:24:34.621+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.621+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21238
06-07 17:24:34.631+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:34.631+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(21238), cmd(0)
06-07 17:24:34.641+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:645,0.306643,-0.087116,9.801468
06-07 17:24:34.651+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:616,0.289532,-0.095713,9.846465
06-07 17:24:34.651+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.661+0200 W/CAPI_APPFW_APP_CONTROL(21238): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:34.661+0200 I/utils   (21238): specific action
06-07 17:24:34.661+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:643,-0.070000,-0.070000,0.070000
06-07 17:24:34.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:631,0.010867,0.029242,0.050020
06-07 17:24:34.671+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:672,0.327817,-0.098106,9.865608
06-07 17:24:34.681+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.681+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:691,0.140000,0.070000,0.070000
06-07 17:24:34.691+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21238)
06-07 17:24:34.691+0200 I/servicemanager(20992): es.ugr.frailty.location launch request sent!
06-07 17:24:34.691+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.691+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:24:34.691+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:24:34.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.701+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:34.701+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:34.701+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:707,0.307019,-0.086784,9.801458
06-07 17:24:34.711+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21036
06-07 17:24:34.711+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21036)
06-07 17:24:34.711+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:24:34.711+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.711+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:24:34.711+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:24:34.721+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.731+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.731+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:703,-0.001607,0.023180,0.052417
06-07 17:24:34.731+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.731+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.751+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:742,0.140000,0.070000,0.070000
06-07 17:24:34.761+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.761+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.761+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:729,0.299103,-0.110070,9.841680
06-07 17:24:34.761+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.771+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:743,-0.003967,0.000644,0.038049
06-07 17:24:34.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21049
06-07 17:24:34.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.781+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21049)
06-07 17:24:34.781+0200 I/servicemanager(20992): es.ugr.frailty.gravity launch request sent!
06-07 17:24:34.781+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.781+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:753,0.305281,-0.087651,9.801505
06-07 17:24:34.781+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.791+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:34.801+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:34:803,680.000000
06-07 17:24:34.811+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:24:34.811+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:781,0.318245,-0.095713,9.808180
06-07 17:24:34.811+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:24:34.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.831+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:793,0.140000,0.070000,0.140000
06-07 17:24:34.831+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:814,-0.017659,0.005210,0.071526
06-07 17:24:34.841+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:815,0.305481,-0.087332,9.801502
06-07 17:24:34.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21054
06-07 17:24:34.851+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.851+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.861+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.871+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:34.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21054), cmd(0)
06-07 17:24:34.881+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:878,0.305567,-0.089321,9.801481
06-07 17:24:34.881+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:851,0.315853,-0.052642,9.846465
06-07 17:24:34.881+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:875,0.009506,0.009850,0.035604
06-07 17:24:34.891+0200 W/CAPI_APPFW_APP_CONTROL(21054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:34.891+0200 I/utils   (21054): specific action
06-07 17:24:34.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:867,0.140000,0.070000,0.070000
06-07 17:24:34.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:34.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:34.901+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21054)
06-07 17:24:34.901+0200 I/servicemanager(20992): es.ugr.frailty.pressure launch request sent!
06-07 17:24:34.901+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.901+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:24:34.901+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:24:34.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:34.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:34.911+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.911+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21071
06-07 17:24:34.911+0200 W/CAPI_APPFW_APP_CONTROL(21071): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:34.911+0200 I/utils   (21071): specific action
06-07 17:24:34.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:34.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21071), cmd(0)
06-07 17:24:34.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.931+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:935,0.018289,0.007154,0.049985
06-07 17:24:34.941+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:895,0.337388,-0.090927,9.827322
06-07 17:24:34.941+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:34.961+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:926,0.140000,0.070000,0.070000
06-07 17:24:34.961+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:938,0.305598,-0.088825,9.801485
06-07 17:24:34.961+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:34.961+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21071)
06-07 17:24:34.961+0200 I/servicemanager(20992): es.ugr.frailty.light launch request sent!
06-07 17:24:34.961+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:34.961+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:24:34.961+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:24:34.971+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:34.971+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:34.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:34:980,0.140000,0.070000,0.070000
06-07 17:24:34.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:34:958,0.327817,-0.110070,9.839286
06-07 17:24:34.991+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:34.991+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:34:999,675.000000
06-07 17:24:35.001+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:34:979,0.000371,-0.012166,0.059591
06-07 17:24:35.021+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:34:992,0.306872,-0.089648,9.801437
06-07 17:24:35.021+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.021+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.021+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.041+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:24:35.041+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:24:35.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:24:35.041+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:24:35.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:24:35.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21084
06-07 17:24:35.061+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21084)
06-07 17:24:35.061+0200 I/servicemanager(20992): es.ugr.frailty.pedometer launch request sent!
06-07 17:24:35.061+0200 I/servicemanager(20992): App control destroyed.
06-07 17:24:35.071+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:24:35.071+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21084), cmd(0)
06-07 17:24:35.071+0200 W/CAPI_APPFW_APP_CONTROL(21084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:24:35.071+0200 I/utils   (21084): specific action
06-07 17:24:35.071+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:33,0.140000,0.070000,0.070000
06-07 17:24:35.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:87,0.140000,0.070000,0.070000
06-07 17:24:35.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.081+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:19,0.346959,-0.088534,9.865608
06-07 17:24:35.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:91,0.070000,0.070000,0.070000
06-07 17:24:35.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:99,-0.070000,0.070000,0.140000
06-07 17:24:35.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:105,-0.070000,0.070000,0.070000
06-07 17:24:35.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:111,-0.070000,0.070000,0.070000
06-07 17:24:35.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:119,-0.070000,0.070000,0.070000
06-07 17:24:35.111+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.121+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:125,-0.140000,0.070000,0.070000
06-07 17:24:35.121+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:131,-0.140000,0.070000,0.140000
06-07 17:24:35.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:139,0.140000,0.070000,0.070000
06-07 17:24:35.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:145,-0.070000,0.070000,0.070000
06-07 17:24:35.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.141+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:150,0.070000,0.070000,0.070000
06-07 17:24:35.151+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.151+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:157,-0.140000,0.070000,0.070000
06-07 17:24:35.151+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:35.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:35.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:163,-0.070000,-0.070000,0.140000
06-07 17:24:35.161+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:35,0.033536,0.014881,0.064395
06-07 17:24:35.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:169,0.070000,-0.070000,0.070000
06-07 17:24:35.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.171+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:174,0.070000,-0.070000,0.070000
06-07 17:24:35.171+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:181,0.070000,-0.070000,0.070000
06-07 17:24:35.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:187,0.070000,0.070000,0.070000
06-07 17:24:35.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:193,0.070000,0.070000,0.070000
06-07 17:24:35.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:201,0.140000,0.070000,0.070000
06-07 17:24:35.201+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.201+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:207,0.070000,0.070000,0.070000
06-07 17:24:35.201+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.211+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:35.221+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:35:218,672.000000
06-07 17:24:35.221+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.221+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.241+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:39,0.305812,-0.091373,9.801455
06-07 17:24:35.241+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:213,0.070000,0.070000,0.070000
06-07 17:24:35.241+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.241+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.251+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:239,0.330210,-0.069392,9.870394
06-07 17:24:35.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:235,-0.011334,-0.026326,0.047697
06-07 17:24:35.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:261,-0.070000,0.070000,0.070000
06-07 17:24:35.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.271+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.291+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:256,0.304893,-0.092069,9.801476
06-07 17:24:35.291+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.291+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:285,0.024785,-0.044058,0.040524
06-07 17:24:35.311+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:291,0.320638,-0.074178,9.851252
06-07 17:24:35.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:304,0.305675,-0.089825,9.801474
06-07 17:24:35.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.321+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:35.331+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:35.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:304,-0.070000,0.070000,0.070000
06-07 17:24:35.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:328,0.016982,-0.004081,0.023810
06-07 17:24:35.341+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:329,0.342174,-0.088534,9.868000
06-07 17:24:35.351+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.361+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.361+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:358,0.304250,-0.088760,9.801527
06-07 17:24:35.371+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:351,-0.070000,-0.070000,0.070000
06-07 17:24:35.381+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:371,0.014493,0.002957,0.059706
06-07 17:24:35.381+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21012) cmd(0)
06-07 17:24:35.391+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:35.401+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:35:402,669.000000
06-07 17:24:35.401+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21017) cmd(0)
06-07 17:24:35.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:414,-0.070000,-0.070000,0.070000
06-07 17:24:35.421+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:376,0.284746,-0.110070,9.827322
06-07 17:24:35.421+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.441+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.441+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:415,0.303888,-0.089020,9.801537
06-07 17:24:35.441+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.451+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.461+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:462,-0.070000,-0.070000,0.070000
06-07 17:24:35.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:447,-0.023692,0.009650,0.050127
06-07 17:24:35.471+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:444,0.306281,-0.098106,9.908678
06-07 17:24:35.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.471+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.481+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:465,0.302982,-0.088701,9.801567
06-07 17:24:35.491+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.501+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:486,0.265603,-0.112463,9.824929
06-07 17:24:35.501+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:485,-0.021831,-0.024657,0.047666
06-07 17:24:35.511+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.511+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:506,0.304998,-0.089183,9.801500
06-07 17:24:35.521+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.531+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:507,-0.070000,0.070000,0.070000
06-07 17:24:35.531+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.531+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.541+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:35.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:35.551+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:529,0.003925,0.000117,0.011723
06-07 17:24:35.551+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:530,0.334995,-0.110070,9.865608
06-07 17:24:35.551+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:545,0.305635,-0.088452,9.801487
06-07 17:24:35.561+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.561+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.571+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:547,-0.070000,0.070000,0.070000
06-07 17:24:35.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.581+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:572,-0.000362,0.002175,0.023667
06-07 17:24:35.581+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.581+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:591,0.305669,-0.087109,9.801498
06-07 17:24:35.591+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:35.601+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:35:602,667.000000
06-07 17:24:35.601+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:610,-0.070000,0.070000,0.070000
06-07 17:24:35.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:581,0.296710,-0.126820,9.875179
06-07 17:24:35.611+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.621+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:625,-0.023569,0.006522,0.014070
06-07 17:24:35.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21036) cmd(0)
06-07 17:24:35.631+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.641+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.651+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:634,0.289532,-0.083749,9.877571
06-07 17:24:35.651+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.661+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.661+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:648,0.305074,-0.087287,9.801515
06-07 17:24:35.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:650,-0.070000,0.070000,0.070000
06-07 17:24:35.681+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.681+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.681+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:672,0.282353,-0.069392,9.848858
06-07 17:24:35.691+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21049) cmd(0)
06-07 17:24:35.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:671,0.006952,-0.018047,0.006828
06-07 17:24:35.701+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.701+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:692,0.303973,-0.087702,9.801545
06-07 17:24:35.701+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.711+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:35.711+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:35.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:692,-0.070000,-0.070000,0.070000
06-07 17:24:35.721+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.731+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:736,0.303004,-0.086478,9.801586
06-07 17:24:35.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:712,0.014182,0.013737,0.078617
06-07 17:24:35.741+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:726,0.349352,-0.083749,9.793823
06-07 17:24:35.751+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.761+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.761+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.761+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:737,-0.070000,-0.070000,0.070000
06-07 17:24:35.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:759,-0.000775,0.029940,0.061882
06-07 17:24:35.781+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:778,0.303773,-0.086151,9.801565
06-07 17:24:35.791+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.791+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:35.791+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:35:799,669.000000
06-07 17:24:35.801+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:767,0.325424,-0.088534,9.839286
06-07 17:24:35.801+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:789,-0.070000,-0.070000,0.070000
06-07 17:24:35.811+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:815,-0.017518,-0.026426,-0.012308
06-07 17:24:35.811+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.821+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:827,0.346959,-0.102891,9.841680
06-07 17:24:35.831+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.841+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.841+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:831,0.302651,-0.085036,9.801610
06-07 17:24:35.841+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.851+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:855,0.277567,-0.090927,9.846465
06-07 17:24:35.861+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:850,0.002367,0.006093,0.021181
06-07 17:24:35.861+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:842,-0.070000,-0.070000,0.070000
06-07 17:24:35.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.881+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.891+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:872,0.302921,-0.086250,9.801591
06-07 17:24:35.891+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.901+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:905,0.337388,-0.148355,9.875179
06-07 17:24:35.901+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:35.901+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:35.901+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:881,0.070000,0.070000,0.070000
06-07 17:24:35.911+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:892,-0.024124,0.005926,0.025970
06-07 17:24:35.921+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.921+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:917,0.304844,-0.087282,9.801522
06-07 17:24:35.931+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.941+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.941+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:925,0.070000,0.070000,0.070000
06-07 17:24:35.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:935,-0.025676,-0.010832,0.042693
06-07 17:24:35.961+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:35.961+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:945,0.318245,-0.081356,9.858429
06-07 17:24:35.981+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:35:973,0.140000,0.070000,0.070000
06-07 17:24:35.981+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:35.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:35.981+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:35:961,0.304618,-0.087400,9.801528
06-07 17:24:35.991+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:35.991+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:36.001+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:36:5,669.000000
06-07 17:24:36.011+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.041+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:24:36.041+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:24:36.041+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:24:36.041+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:31,-0.070000,0.070000,0.070000
06-07 17:24:36.061+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:35:989,-0.017485,-0.002851,0.045062
06-07 17:24:36.061+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:35:997,0.320638,-0.081356,9.844072
06-07 17:24:36.061+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.071+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:16,0.305242,-0.088391,9.801499
06-07 17:24:36.071+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.071+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.081+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:85,0.315853,-0.133998,9.863215
06-07 17:24:36.091+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.101+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:36.101+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:36.101+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:93,0.306667,-0.088895,9.801451
06-07 17:24:36.111+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:75,0.022380,-0.005446,0.064154
06-07 17:24:36.111+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.111+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.121+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.121+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:101,0.070000,0.070000,0.070000
06-07 17:24:36.131+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.141+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:123,-0.007383,-0.017048,0.040261
06-07 17:24:36.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.161+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:130,0.307588,-0.088267,9.801428
06-07 17:24:36.161+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:145,-0.070000,0.070000,0.070000
06-07 17:24:36.161+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:128,0.327817,-0.090927,9.824929
06-07 17:24:36.161+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:170,0.012586,-0.002070,0.006742
06-07 17:24:36.171+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.171+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.181+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.191+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:36.201+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:36:199,669.000000
06-07 17:24:36.211+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.221+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:184,0.307392,-0.088541,9.801432
06-07 17:24:36.231+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:185,0.306281,-0.078963,9.824929
06-07 17:24:36.231+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:196,-0.070000,0.070000,0.070000
06-07 17:24:36.231+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.241+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:224,0.009273,0.041380,0.045059
06-07 17:24:36.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.261+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:249,0.310030,-0.090210,9.801333
06-07 17:24:36.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:274,-0.070000,0.070000,0.070000
06-07 17:24:36.271+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:281,0.030029,0.001289,0.025924
06-07 17:24:36.281+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:253,0.313460,-0.090927,9.884750
06-07 17:24:36.281+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.311+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:36.311+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:36.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:325,0.019222,-0.018042,0.037925
06-07 17:24:36.321+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:298,0.310308,-0.090124,9.801325
06-07 17:24:36.321+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:305,0.320638,-0.083749,9.827322
06-07 17:24:36.331+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:316,0.070000,0.070000,0.070000
06-07 17:24:36.341+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.361+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.361+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:351,0.323031,-0.055035,9.836893
06-07 17:24:36.371+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:343,0.310060,-0.091109,9.801324
06-07 17:24:36.371+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:355,0.070000,0.070000,0.070000
06-07 17:24:36.381+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.391+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.391+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:24:36.401+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:24:36:401,673.000000
06-07 17:24:36.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:375,0.037579,0.004194,0.064279
06-07 17:24:36.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.411+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:392,0.312062,-0.090735,9.801264
06-07 17:24:36.431+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:408,0.315853,-0.114855,9.829715
06-07 17:24:36.441+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.441+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:451,0.312393,-0.091028,9.801250
06-07 17:24:36.451+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:416,-0.070000,-0.070000,0.140000
06-07 17:24:36.451+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.451+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.461+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:427,0.019333,0.023003,0.069108
06-07 17:24:36.461+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:466,0.308674,-0.131605,9.846465
06-07 17:24:36.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.481+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.481+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:24:36:471,-0.140000,-0.070000,0.070000
06-07 17:24:36.481+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:24:36.491+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:24:36.491+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:24:36.501+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:24:36.531+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:24:36:481,0.009425,0.016939,0.049965
06-07 17:24:36.531+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:24:36.541+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:24:36:488,0.313580,-0.093117,9.801193
06-07 17:24:36.551+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:24:36:499,0.308674,-0.141177,9.853643
06-07 17:24:36.551+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:24:36.561+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11205306c6f63152838495
