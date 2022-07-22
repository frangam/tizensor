S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20453
Date: 2018-06-07 17:21:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf768052d, r5   = 0xf7837f98
r6   = 0xffb73410, r7   = 0xffb732c0
r8   = 0xf7834c18, r9   = 0x00000000
r10  = 0xffb7339c, fp   = 0xffb73410
ip   = 0x00000001, sp   = 0xffb73298
lr   = 0xf7680539, pc   = 0xf76e9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    235944 KB
Buffers:      9412 KB
Cached:      53360 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11756 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20453 TID = 20453
20453 20458 

Maps Information
f454b000 f4d4a000 rw-p [stack:20458]
f4d51000 f4d53000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d5b000 f4d5f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d68000 f4d6a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d72000 f4d75000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d84000 f4d89000 r-xp /usr/lib/libsystem.so.0.0.0
f4d94000 f4d97000 r-xp /lib/libattr.so.1.1.0
f4d9f000 f4daf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4db7000 f4dc0000 r-xp /usr/lib/libedbus.so.1.7.99
f4dc8000 f4dc9000 r-xp /usr/lib/libresponse.so.0.2.96
f4dd2000 f4dd7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6679000 f677f000 r-xp /usr/lib/libicuuc.so.57.1
f6795000 f691d000 r-xp /usr/lib/libicui18n.so.57.1
f692d000 f693a000 r-xp /usr/lib/libail.so.0.1.0
f6943000 f694a000 r-xp /usr/lib/libminizip.so.1.0.0
f6953000 f6afc000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b1c000 f6b63000 r-xp /usr/lib/libssl.so.1.0.0
f6b6f000 f6b71000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b79000 f6b80000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b89000 f6b90000 r-xp /lib/libcrypt-2.13.so
f6bc1000 f6bc4000 r-xp /lib/libcap.so.2.21
f6bcc000 f6bce000 r-xp /usr/lib/libiri.so
f6bd6000 f6c1f000 r-xp /usr/lib/libmdm.so.1.2.69
f6c27000 f6c2d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c35000 f6c58000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c62000 f6c64000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c6c000 f6c89000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c92000 f6c96000 r-xp /usr/lib/libsmack.so.1.0.0
f6c9f000 f6cb8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cc1000 f6cc9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cd1000 f6cd7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ce0000 f6ce2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ceb000 f6cfb000 r-xp /lib/libresolv-2.13.so
f6cff000 f6d17000 r-xp /usr/lib/liblzma.so.5.0.3
f6d20000 f6d22000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d2a000 f6d44000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d4c000 f6d7b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d84000 f6d93000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d9d000 f6da7000 r-xp /usr/lib/libsensord-shared.so
f6db0000 f6e83000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e8e000 f6ea4000 r-xp /lib/libz.so.1.2.5
f6eac000 f6eb1000 r-xp /usr/lib/libffi.so.5.0.10
f6eb9000 f6eba000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ec2000 f6ed2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6eda000 f6ef3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6efb000 f6efd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f05000 f6f7a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f84000 f6f8a000 r-xp /lib/librt-2.13.so
f6f93000 f6fb1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fbb000 f6fbc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fc4000 f6fe7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fef000 f6ff4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ffc000 f7026000 r-xp /usr/lib/libdbus-1.so.3.8.12
f702f000 f7046000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f704e000 f70b7000 r-xp /lib/libm-2.13.so
f70c0000 f7154000 r-xp /usr/lib/libstdc++.so.6.0.16
f7167000 f716c000 r-xp /usr/lib/libctx-client.so.0.8.3
f7174000 f717b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7183000 f71ad000 r-xp /usr/lib/libsensor.so.1.9.6
f71b6000 f7282000 r-xp /usr/lib/libxml2.so.2.7.8
f728f000 f7291000 r-xp /usr/lib/libiniparser.so.0
f729a000 f72a0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72a9000 f7379000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f737a000 f73ae000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73b7000 f73f3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73fb000 f73fe000 r-xp /usr/lib/libbundle.so.0.1.22
f7406000 f740c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7414000 f7455000 r-xp /usr/lib/libeina.so.1.7.99
f745e000 f7475000 r-xp /usr/lib/libecore.so.1.7.99
f748c000 f7495000 r-xp /usr/lib/libvconf.so.0.2.45
f749d000 f74b1000 r-xp /lib/libpthread-2.13.so
f74bc000 f74c9000 r-xp /usr/lib/libaul.so.0.1.0
f74d3000 f74d5000 r-xp /lib/libdl-2.13.so
f74de000 f74e9000 r-xp /lib/libunwind.so.8.0.1
f7516000 f751e000 r-xp /lib/libgcc_s-4.6.so.1
f751f000 f7643000 r-xp /lib/libc-2.13.so
f7651000 f7653000 r-xp /usr/lib/libdlog.so.0.0.0
f765b000 f7667000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7670000 f7675000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f767d000 f768c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7694000 f7698000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76a1000 f76a4000 r-xp /usr/lib/libappcore-agent.so.1.1
f76ac000 f76ae000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76b6000 f76ba000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76c2000 f76df000 r-xp /lib/ld-2.13.so
f76e8000 f76eb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76eb000 f76ef000 r-xp /usr/lib/libsys-assert.so
f7804000 f7875000 rw-p [heap]
ffb54000 ffb75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20453)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76e9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7680539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73873f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7385c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7391e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7397be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7397dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73cc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73c71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7385c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7391e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7397be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7397dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73c9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73ca017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73d1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d691fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d5c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e2f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72dcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72de7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf746eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7469b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf746a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf746a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76a2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76a27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76e95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf753685c) [/lib/libc.so.6] + 0x1785c
29: (0xf76e8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ity: SM-R760,07/06/2018,17:23:46:251,0.316958,-0.084889,9.801159
06-07 17:23:46.281+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:259,0.027107,0.020740,0.040408
06-07 17:23:46.281+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.291+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:260,0.311067,-0.122034,9.815358
06-07 17:23:46.301+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.301+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:306,0.330210,-0.083749,9.870394
06-07 17:23:46.311+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.311+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:303,0.038385,-0.014021,0.052382
06-07 17:23:46.311+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:295,0.317146,-0.085608,9.801147
06-07 17:23:46.321+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.321+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:327,0.315893,-0.086321,9.801181
06-07 17:23:46.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:316,0.070000,-0.070000,0.070000
06-07 17:23:46.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.341+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:346,0.342174,-0.057428,9.829715
06-07 17:23:46.341+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.351+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.351+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:360,0.316508,-0.087518,9.801150
06-07 17:23:46.361+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:46.361+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:46:367,954.000000
06-07 17:23:46.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:342,0.031978,0.031954,0.004582
06-07 17:23:46.371+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.381+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:23:46.381+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:23:46.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.381+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.391+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21012
06-07 17:23:46.401+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21012)
06-07 17:23:46.401+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer launch request sent!
06-07 17:23:46.401+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.401+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:23:46.401+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:23:46.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:355,0.070000,-0.070000,0.070000
06-07 17:23:46.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21017
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:426,0.070000,-0.070000,0.070000
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.421+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21017)
06-07 17:23:46.421+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope launch request sent!
06-07 17:23:46.421+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.421+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:23:46.421+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:23:46.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:430,0.140000,-0.070000,0.070000
06-07 17:23:46.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.431+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21023
06-07 17:23:46.441+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:46.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(21023), cmd(0)
06-07 17:23:46.451+0200 W/CAPI_APPFW_APP_CONTROL(21023): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:46.451+0200 I/utils   (21023): specific action
06-07 17:23:46.451+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21023)
06-07 17:23:46.451+0200 I/servicemanager(20992): es.ugr.frailty.heartrate launch request sent!
06-07 17:23:46.451+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.451+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:23:46.451+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:23:46.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20877
06-07 17:23:46.471+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:46.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(20877), cmd(0)
06-07 17:23:46.471+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20877)
06-07 17:23:46.471+0200 W/CAPI_APPFW_APP_CONTROL(20877): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:46.471+0200 I/utils   (20877): specific action
06-07 17:23:46.471+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:46.471+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:46.471+0200 I/servicemanager(20992): es.ugr.frailty.location launch request sent!
06-07 17:23:46.471+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.471+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:23:46.471+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:23:46.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21036
06-07 17:23:46.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21036)
06-07 17:23:46.501+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:23:46.501+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.501+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:23:46.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:23:46.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21049
06-07 17:23:46.511+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21049)
06-07 17:23:46.511+0200 I/servicemanager(20992): es.ugr.frailty.gravity launch request sent!
06-07 17:23:46.511+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.511+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:23:46.521+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:23:46.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21054
06-07 17:23:46.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:46.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21054), cmd(0)
06-07 17:23:46.541+0200 W/CAPI_APPFW_APP_CONTROL(21054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:46.541+0200 I/utils   (21054): specific action
06-07 17:23:46.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21054)
06-07 17:23:46.541+0200 I/servicemanager(20992): es.ugr.frailty.pressure launch request sent!
06-07 17:23:46.541+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.541+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:23:46.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:23:46.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21071
06-07 17:23:46.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:46.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21071), cmd(0)
06-07 17:23:46.561+0200 W/CAPI_APPFW_APP_CONTROL(21071): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:46.561+0200 I/utils   (21071): specific action
06-07 17:23:46.561+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:46.571+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:46:575,957.000000
06-07 17:23:46.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21071)
06-07 17:23:46.571+0200 I/servicemanager(20992): es.ugr.frailty.light launch request sent!
06-07 17:23:46.571+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.571+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:23:46.571+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:23:46.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:23:46.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:23:46.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21084
06-07 17:23:46.591+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:46.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(21084), cmd(0)
06-07 17:23:46.601+0200 W/CAPI_APPFW_APP_CONTROL(21084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:46.601+0200 I/utils   (21084): specific action
06-07 17:23:46.601+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21084)
06-07 17:23:46.601+0200 I/servicemanager(20992): es.ugr.frailty.pedometer launch request sent!
06-07 17:23:46.601+0200 I/servicemanager(20992): App control destroyed.
06-07 17:23:46.601+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.601+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:610,0.315637,-0.087665,9.801177
06-07 17:23:46.601+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.611+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:615,0.315682,-0.087449,9.801178
06-07 17:23:46.611+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.621+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:620,0.316461,-0.089525,9.801134
06-07 17:23:46.621+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.621+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:631,0.318139,-0.088931,9.801085
06-07 17:23:46.631+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.631+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:636,0.317211,-0.088336,9.801120
06-07 17:23:46.631+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.641+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:641,0.316387,-0.088260,9.801147
06-07 17:23:46.641+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.641+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:647,0.315680,-0.088518,9.801168
06-07 17:23:46.641+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.651+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:652,0.314826,-0.087976,9.801200
06-07 17:23:46.651+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.651+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:657,0.313987,-0.088544,9.801222
06-07 17:23:46.651+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.661+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:46.661+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:46.671+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:661,0.314481,-0.088009,9.801211
06-07 17:23:46.671+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.681+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:671,0.327817,-0.100499,9.868000
06-07 17:23:46.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:384,0.040405,0.018372,0.066818
06-07 17:23:46.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:434,0.140000,-0.070000,0.070000
06-07 17:23:46.691+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.701+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.701+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.701+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:687,0.314675,-0.087394,9.801210
06-07 17:23:46.721+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:706,0.070000,0.070000,0.070000
06-07 17:23:46.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:715,0.282353,-0.069392,9.839286
06-07 17:23:46.731+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:731,0.316114,-0.087498,9.801163
06-07 17:23:46.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:715,-0.008906,-0.013726,0.052501
06-07 17:23:46.741+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.741+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.751+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.751+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:756,0.006073,-0.018003,0.014199
06-07 17:23:46.761+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:46.761+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:46:769,959.000000
06-07 17:23:46.771+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.771+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:777,0.315522,-0.087025,9.801187
06-07 17:23:46.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:751,0.070000,0.070000,0.140000
06-07 17:23:46.781+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:761,0.332602,-0.093320,9.846465
06-07 17:23:46.781+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.791+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.801+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:801,-0.022829,-0.017284,0.014212
06-07 17:23:46.801+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.811+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:792,0.140000,0.070000,0.070000
06-07 17:23:46.811+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:803,0.275175,-0.088534,9.820145
06-07 17:23:46.821+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.821+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.831+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:815,0.315277,-0.088181,9.801184
06-07 17:23:46.831+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:836,0.279960,-0.105284,9.858429
06-07 17:23:46.831+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:821,0.140000,0.070000,0.070000
06-07 17:23:46.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:859,0.140000,0.070000,0.070000
06-07 17:23:46.851+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:833,0.014316,-0.028534,0.035712
06-07 17:23:46.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.861+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:843,0.315452,-0.089408,9.801167
06-07 17:23:46.861+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.861+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:46.861+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:46.871+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.881+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:872,-0.015013,-0.005802,0.021387
06-07 17:23:46.891+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.891+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:873,0.291924,-0.107677,9.877571
06-07 17:23:46.891+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:896,0.140000,0.070000,0.070000
06-07 17:23:46.911+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:885,0.313368,-0.090024,9.801229
06-07 17:23:46.921+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.921+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.931+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:904,0.005001,0.001524,0.035716
06-07 17:23:46.931+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:906,0.327817,-0.119641,9.882358
06-07 17:23:46.931+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.941+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.951+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:927,0.312808,-0.089031,9.801255
06-07 17:23:46.951+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:46.951+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:946,0.021706,-0.048942,0.059645
06-07 17:23:46.961+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:46.961+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:46:967,961.000000
06-07 17:23:46.961+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:947,0.325424,-0.105284,9.882358
06-07 17:23:46.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:934,0.070000,0.070000,0.070000
06-07 17:23:46.971+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:46.981+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:46.981+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:46.981+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:958,0.314431,-0.089667,9.801198
06-07 17:23:46.981+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.001+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:46:982,0.070000,0.070000,0.070000
06-07 17:23:47.001+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:46:987,0.040070,0.015347,0.081223
06-07 17:23:47.001+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:46:989,0.327817,-0.102891,9.894321
06-07 17:23:47.011+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.021+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.051+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:23:47.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:23:47.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:23:47.061+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:46:997,0.314022,-0.088826,9.801219
06-07 17:23:47.061+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:47.071+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:47.071+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:16,0.070000,-0.070000,0.070000
06-07 17:23:47.081+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.091+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:64,-0.021429,0.014753,0.028630
06-07 17:23:47.091+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:85,0.313518,-0.090005,9.801224
06-07 17:23:47.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:95,0.070000,-0.140000,0.070000
06-07 17:23:47.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:109,0.140000,0.070000,0.070000
06-07 17:23:47.081+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:66,0.323031,-0.093320,9.860823
06-07 17:23:47.101+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.131+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.131+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.131+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:139,0.337388,-0.110070,9.817751
06-07 17:23:47.141+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.141+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:143,-0.006144,-0.002592,0.069274
06-07 17:23:47.141+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.141+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.151+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:155,-0.000535,-0.012239,0.007032
06-07 17:23:47.151+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:146,0.313396,-0.090596,9.801223
06-07 17:23:47.151+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:153,0.294317,-0.066999,9.858429
06-07 17:23:47.151+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.161+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:47.171+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:47:171,961.000000
06-07 17:23:47.171+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:163,0.312686,-0.089961,9.801250
06-07 17:23:47.181+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.181+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.181+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:189,0.334995,-0.093320,9.839286
06-07 17:23:47.191+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.191+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:113,0.070000,0.070000,0.070000
06-07 17:23:47.201+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.201+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:205,0.314079,-0.089503,9.801210
06-07 17:23:47.211+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:192,-0.007005,0.007162,0.062047
06-07 17:23:47.211+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.211+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.231+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.231+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:237,0.313894,-0.090918,9.801204
06-07 17:23:47.241+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:206,0.210000,0.070000,0.070000
06-07 17:23:47.241+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.241+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:219,0.320638,-0.081356,9.839286
06-07 17:23:47.251+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:227,-0.013330,-0.014915,0.057229
06-07 17:23:47.251+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.261+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.261+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:267,0.023401,0.007188,0.076349
06-07 17:23:47.261+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:47.261+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:47.261+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:247,0.210000,0.070000,0.070000
06-07 17:23:47.271+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.271+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.281+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:271,0.315853,-0.093320,9.798609
06-07 17:23:47.281+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:280,0.314091,-0.090379,9.801202
06-07 17:23:47.281+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.291+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.301+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:283,0.070000,0.070000,0.070000
06-07 17:23:47.301+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.301+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:311,0.314753,-0.088653,9.801197
06-07 17:23:47.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:296,0.015728,0.009046,0.045254
06-07 17:23:47.321+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.321+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:303,0.315853,-0.119641,9.872787
06-07 17:23:47.331+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.331+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.331+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:321,0.070000,0.070000,0.070000
06-07 17:23:47.341+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:332,0.041855,-0.005926,0.038075
06-07 17:23:47.351+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.361+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:47.371+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:47:368,962.000000
06-07 17:23:47.371+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:337,0.346959,-0.090927,9.879964
06-07 17:23:47.371+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.381+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:346,0.314869,-0.089012,9.801189
06-07 17:23:47.381+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:386,0.323031,-0.086142,9.872787
06-07 17:23:47.391+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:362,0.070000,0.070000,0.070000
06-07 17:23:47.391+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.391+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:398,0.313430,-0.088170,9.801244
06-07 17:23:47.401+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.401+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:380,-0.002655,0.006142,0.018982
06-07 17:23:47.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.411+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:416,0.005116,-0.027831,0.083564
06-07 17:23:47.411+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.421+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:412,0.070000,0.070000,0.070000
06-07 17:23:47.421+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:428,0.315853,-0.100499,9.863215
06-07 17:23:47.421+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.431+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.431+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.441+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:438,0.313569,-0.088072,9.801240
06-07 17:23:47.441+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.461+0200 W/CAPI_APPFW_APP_CONTROL(21049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:47.461+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:47.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(21049), cmd(0)
06-07 17:23:47.461+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:47.461+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:47.461+0200 I/utils   (21049): specific action
06-07 17:23:47.461+0200 W/CAPI_APPFW_APP_CONTROL(21049): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:47.461+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:441,0.070000,0.070000,0.070000
06-07 17:23:47.461+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:47.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(21049), cmd(0)
06-07 17:23:47.471+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:446,0.005361,-0.029067,0.033318
06-07 17:23:47.471+0200 I/utils   (21049): specific action
06-07 17:23:47.471+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.471+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.481+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:486,0.070000,0.070000,0.070000
06-07 17:23:47.481+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:457,0.282353,-0.114855,9.841680
06-07 17:23:47.491+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.491+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.491+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:479,0.311284,-0.087830,9.801315
06-07 17:23:47.501+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:498,0.272782,-0.081356,9.803394
06-07 17:23:47.511+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.511+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.521+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:496,-0.033099,-0.018269,0.038118
06-07 17:23:47.521+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.531+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.531+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:539,0.313460,-0.088534,9.832108
06-07 17:23:47.541+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:520,0.070000,0.070000,0.070000
06-07 17:23:47.541+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.551+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:523,0.309538,-0.088546,9.801364
06-07 17:23:47.551+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.551+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:531,0.004878,0.011061,0.083522
06-07 17:23:47.561+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:47.561+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:47:567,963.000000
06-07 17:23:47.571+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.571+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.581+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:559,0.070000,0.070000,0.070000
06-07 17:23:47.591+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:562,0.308217,-0.089161,9.801400
06-07 17:23:47.591+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.601+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.601+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:582,0.048508,-0.023432,0.064353
06-07 17:23:47.601+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:584,0.308674,-0.033500,9.865608
06-07 17:23:47.601+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.611+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.631+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:618,-0.015328,0.020275,0.078766
06-07 17:23:47.631+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:603,0.070000,0.070000,0.070000
06-07 17:23:47.641+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:608,0.308782,-0.090270,9.801372
06-07 17:23:47.641+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.641+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.641+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:623,0.318245,-0.064606,9.832108
06-07 17:23:47.641+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.651+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.661+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:649,0.309881,-0.091118,9.801330
06-07 17:23:47.661+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:648,0.070000,-0.070000,0.070000
06-07 17:23:47.661+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:47.661+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:47.671+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.671+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.681+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:661,-0.017312,-0.021244,0.059604
06-07 17:23:47.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:660,0.289532,-0.100499,9.872787
06-07 17:23:47.691+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.691+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.711+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:698,0.330210,-0.069392,9.832108
06-07 17:23:47.711+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:689,0.310246,-0.091352,9.801315
06-07 17:23:47.711+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:679,0.070000,-0.070000,0.070000
06-07 17:23:47.721+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:701,-0.000058,-0.015279,0.023705
06-07 17:23:47.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.721+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.721+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:729,0.070000,-0.070000,0.070000
06-07 17:23:47.731+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.731+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.741+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:735,0.310386,-0.091140,9.801313
06-07 17:23:47.741+0200 W/CAPI_APPFW_APP_CONTROL(21017): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:47.741+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:47.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(21017), cmd(0)
06-07 17:23:47.751+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:739,0.313460,-0.081356,9.882358
06-07 17:23:47.751+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.751+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:743,-0.004722,0.009240,0.040457
06-07 17:23:47.751+0200 I/utils   (21017): specific action
06-07 17:23:47.751+0200 W/CAPI_APPFW_APP_CONTROL(21017): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:23:47.751+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:23:47.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(21017), cmd(0)
06-07 17:23:47.751+0200 I/utils   (21017): specific action
06-07 17:23:47.751+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.751+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.761+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:47.761+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:47:770,964.000000
06-07 17:23:47.771+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.781+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:764,0.070000,-0.070000,0.070000
06-07 17:23:47.791+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:784,0.041452,0.003820,0.045215
06-07 17:23:47.801+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:760,0.311590,-0.091898,9.801268
06-07 17:23:47.801+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.801+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.801+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:776,0.337388,-0.071785,9.832108
06-07 17:23:47.811+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.811+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.851+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:814,0.310058,-0.090334,9.801331
06-07 17:23:47.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:816,-0.070000,-0.070000,0.070000
06-07 17:23:47.851+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.851+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:817,0.344566,-0.124427,9.829715
06-07 17:23:47.851+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.851+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.861+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:860,0.361316,-0.119641,9.839286
06-07 17:23:47.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:822,-0.003012,-0.032531,0.014148
06-07 17:23:47.861+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:23:47.861+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:23:47.861+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:859,0.140000,-0.070000,0.070000
06-07 17:23:47.871+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:860,0.310468,-0.090142,9.801320
06-07 17:23:47.871+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.871+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.871+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.881+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:875,0.016316,0.007169,0.069190
06-07 17:23:47.881+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.891+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:895,0.028082,0.032952,0.028513
06-07 17:23:47.901+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:887,0.140000,-0.070000,0.070000
06-07 17:23:47.901+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:883,0.310174,-0.089384,9.801336
06-07 17:23:47.901+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:887,0.363709,-0.069392,9.844072
06-07 17:23:47.901+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.911+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.911+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.921+0200 I/gravity (21049): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:23:47:920,0.310851,-0.089750,9.801311
06-07 17:23:47.931+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration - capturing data
06-07 17:23:47.941+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:23:47:924,0.140000,-0.070000,0.070000
06-07 17:23:47.941+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:924,0.279960,-0.057428,9.851252
06-07 17:23:47.941+0200 I/gravity (21049): es.ugr.frailty.gravity - capturing data
06-07 17:23:47.941+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.941+0200 I/gyroscope(21017): es.ugr.frailty.gyroscope - capturing data
06-07 17:23:47.961+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:23:47.961+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:23:47:968,971.000000
06-07 17:23:47.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:23:47:957,0.279960,-0.122034,9.858429
06-07 17:23:47.971+0200 I/accelerometer(21012): es.ugr.frailty.accelerometer - capturing data
06-07 17:23:47.971+0200 I/linearacceleration(21036): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:23:47:944,0.013064,-0.011846,0.066803
06-07 17:23:47.981+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11204536c6f63152838491
