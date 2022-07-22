S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14696
Date: 2018-06-07 17:02:06+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf767252d, r5   = 0xf7cb1f98
r6   = 0xffc29d80, r7   = 0xffc29c30
r8   = 0xf7caec18, r9   = 0x00000000
r10  = 0xffc29d0c, fp   = 0xffc29d80
ip   = 0x00000001, sp   = 0xffc29c08
lr   = 0xf7672539, pc   = 0xf76db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     57888 KB
Buffers:      8548 KB
Cached:      50084 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11564 KB
VmRSS:       11560 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14696 TID = 14696
14696 14706 

Maps Information
f453d000 f4d3c000 rw-p [stack:14706]
f4d43000 f4d45000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d4d000 f4d51000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d5a000 f4d5c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d64000 f4d67000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d76000 f4d7b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d86000 f4d89000 r-xp /lib/libattr.so.1.1.0
f4d91000 f4da1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4da9000 f4db2000 r-xp /usr/lib/libedbus.so.1.7.99
f4dba000 f4dbb000 r-xp /usr/lib/libresponse.so.0.2.96
f4dc4000 f4dc9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f666b000 f6771000 r-xp /usr/lib/libicuuc.so.57.1
f6787000 f690f000 r-xp /usr/lib/libicui18n.so.57.1
f691f000 f692c000 r-xp /usr/lib/libail.so.0.1.0
f6935000 f693c000 r-xp /usr/lib/libminizip.so.1.0.0
f6945000 f6aee000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b0e000 f6b55000 r-xp /usr/lib/libssl.so.1.0.0
f6b61000 f6b63000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b6b000 f6b72000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b7b000 f6b82000 r-xp /lib/libcrypt-2.13.so
f6bb3000 f6bb6000 r-xp /lib/libcap.so.2.21
f6bbe000 f6bc0000 r-xp /usr/lib/libiri.so
f6bc8000 f6c11000 r-xp /usr/lib/libmdm.so.1.2.69
f6c19000 f6c1f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c27000 f6c4a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c54000 f6c56000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c5e000 f6c7b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c84000 f6c88000 r-xp /usr/lib/libsmack.so.1.0.0
f6c91000 f6caa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cb3000 f6cbb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cc3000 f6cc9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cd2000 f6cd4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cdd000 f6ced000 r-xp /lib/libresolv-2.13.so
f6cf1000 f6d09000 r-xp /usr/lib/liblzma.so.5.0.3
f6d12000 f6d14000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d1c000 f6d36000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d3e000 f6d6d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d76000 f6d85000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d8f000 f6d99000 r-xp /usr/lib/libsensord-shared.so
f6da2000 f6e75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e80000 f6e96000 r-xp /lib/libz.so.1.2.5
f6e9e000 f6ea3000 r-xp /usr/lib/libffi.so.5.0.10
f6eab000 f6eac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eb4000 f6ec4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ecc000 f6ee5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eed000 f6eef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ef7000 f6f6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f76000 f6f7c000 r-xp /lib/librt-2.13.so
f6f85000 f6fa3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fad000 f6fae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fb6000 f6fd9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fe1000 f6fe6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fee000 f7018000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7021000 f7038000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7040000 f70a9000 r-xp /lib/libm-2.13.so
f70b2000 f7146000 r-xp /usr/lib/libstdc++.so.6.0.16
f7159000 f715e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7166000 f716d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7175000 f719f000 r-xp /usr/lib/libsensor.so.1.9.6
f71a8000 f7274000 r-xp /usr/lib/libxml2.so.2.7.8
f7281000 f7283000 r-xp /usr/lib/libiniparser.so.0
f728c000 f7292000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f729b000 f736b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f736c000 f73a0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73a9000 f73e5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73ed000 f73f0000 r-xp /usr/lib/libbundle.so.0.1.22
f73f8000 f73fe000 r-xp /usr/lib/libappsvc.so.0.1.0
f7406000 f7447000 r-xp /usr/lib/libeina.so.1.7.99
f7450000 f7467000 r-xp /usr/lib/libecore.so.1.7.99
f747e000 f7487000 r-xp /usr/lib/libvconf.so.0.2.45
f748f000 f74a3000 r-xp /lib/libpthread-2.13.so
f74ae000 f74bb000 r-xp /usr/lib/libaul.so.0.1.0
f74c5000 f74c7000 r-xp /lib/libdl-2.13.so
f74d0000 f74db000 r-xp /lib/libunwind.so.8.0.1
f7508000 f7510000 r-xp /lib/libgcc_s-4.6.so.1
f7511000 f7635000 r-xp /lib/libc-2.13.so
f7643000 f7645000 r-xp /usr/lib/libdlog.so.0.0.0
f764d000 f7659000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7662000 f7667000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f766f000 f767e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7686000 f768a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7693000 f7696000 r-xp /usr/lib/libappcore-agent.so.1.1
f769e000 f76a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76a8000 f76ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76b4000 f76d1000 r-xp /lib/ld-2.13.so
f76da000 f76dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76dd000 f76e1000 r-xp /usr/lib/libsys-assert.so
f7c7e000 f7d0c000 rw-p [heap]
ffc0b000 ffc2c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14696)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7672539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7377c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7383e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7389be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7389dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73be75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73b91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7377c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7383e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7389be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7389dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73bbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73bc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73c3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d5b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d4e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e21663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72cefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72d07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7460ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf745bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf745c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf745c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7694183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76db5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf752885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
oscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:05.971+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:05:974,2.520000,-0.140000,-0.210000
06-07 17:02:05.971+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:05.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14648
06-07 17:02:05.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:02:05.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(14648), cmd(0)
06-07 17:02:05.971+0200 W/CAPI_APPFW_APP_CONTROL(14648): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:02:05.971+0200 I/utils   (14648): specific action
06-07 17:02:05.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14648)
06-07 17:02:05.971+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:02:05.971+0200 I/servicemanager(12566): App control destroyed.
06-07 17:02:05.971+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:02:05.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:02:05.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:02:05.971+0200 W/CAPI_APPFW_APP_CONTROL(14569): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:02:05.971+0200 I/utils   (14569): specific action
06-07 17:02:05.971+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:02:05.981+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:05:894,9.073512,3.471578,1.337872
06-07 17:02:05.981+0200 W/CAPI_APPFW_APP_CONTROL(14730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:02:05.981+0200 I/utils   (14730): specific action
06-07 17:02:05.981+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:02:05.981+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:02:05.981+0200 I/utils   (12618): specific action
06-07 17:02:05.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:02:05.981+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:02:05.981+0200 I/servicemanager(12566): App control destroyed.
06-07 17:02:05.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:02:05.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(14569), cmd(0)
06-07 17:02:05.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:02:05.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14730), cmd(0)
06-07 17:02:05.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:02:05.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 17:02:05.991+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:05:985,-0.020481,-0.029435,-0.040884
06-07 17:02:05.991+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:05.991+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:05:981,9.107083,3.510271,1.299303
06-07 17:02:05.991+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:05.991+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:05.991+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:05:999,0.039622,-0.104067,0.029212
06-07 17:02:05.991+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.001+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:05:992,9.074923,3.467921,1.337794
06-07 17:02:06.001+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.001+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:3,9.095119,3.550949,1.301696
06-07 17:02:06.001+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:2,1.610000,0.490000,-0.350000
06-07 17:02:06.001+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.001+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:9,9.077032,3.463590,1.334697
06-07 17:02:06.001+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.001+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.011+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:14,9.044869,3.510271,1.318445
06-07 17:02:06.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:4,0.028765,0.050576,-0.036750
06-07 17:02:06.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.011+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:18,-0.910000,0.070000,0.070000
06-07 17:02:06.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:21,0.017979,0.086847,-0.030935
06-07 17:02:06.021+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:13,9.078319,3.459694,1.336053
06-07 17:02:06.021+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.021+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.021+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:29,9.085547,3.404987,1.373480
06-07 17:02:06.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:29,-1.400000,-0.210000,0.210000
06-07 17:02:06.021+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:27,9.077141,3.464102,1.332631
06-07 17:02:06.031+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.031+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:35,-0.029884,0.039353,-0.012705
06-07 17:02:06.031+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:37,9.074754,3.470918,1.331150
06-07 17:02:06.031+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:41,9.074284,3.472128,1.331202
06-07 17:02:06.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:41,0.011264,-0.067141,0.042278
06-07 17:02:06.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.041+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.041+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:47,9.087940,3.337988,1.438086
06-07 17:02:06.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:47,1.050000,-0.210000,-0.210000
06-07 17:02:06.041+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.051+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:54,0.011916,-0.128704,0.104590
06-07 17:02:06.051+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:52,9.076024,3.466692,1.333497
06-07 17:02:06.051+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:02:06.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:02:06.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:02:06.061+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.061+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.061+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.061+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:67,9.085547,3.517449,1.354338
06-07 17:02:06.061+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:67,2.450000,0.560000,-0.280000
06-07 17:02:06.061+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:06.071+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:67,0.008285,0.055669,0.016521
06-07 17:02:06.071+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:06:74,86
06-07 17:02:06.071+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:64,9.077263,3.461781,1.337817
06-07 17:02:06.071+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.081+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:83,9.074715,3.468244,1.338365
06-07 17:02:06.081+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:06.081+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.081+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.081+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:06:91,420.000000
06-07 17:02:06.091+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.091+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:96,9.025726,3.543770,1.296910
06-07 17:02:06.091+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:92,-0.048988,0.075526,-0.041455
06-07 17:02:06.091+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:95,-0.070000,-0.910000,-0.140000
06-07 17:02:06.091+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.101+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.101+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.101+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.101+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:107,9.073583,3.538985,1.280160
06-07 17:02:06.101+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:106,-0.000819,0.068595,-0.054760
06-07 17:02:06.101+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:111,-1.330000,-0.910000,0.210000
06-07 17:02:06.111+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:105,9.074402,3.470389,1.334921
06-07 17:02:06.111+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.111+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:120,9.075298,3.469519,1.331084
06-07 17:02:06.121+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.121+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.121+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:127,0.000678,0.009645,-0.010246
06-07 17:02:06.121+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:127,9.075976,3.479164,1.320838
06-07 17:02:06.121+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.121+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.131+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:132,-0.770000,0.210000,0.420000
06-07 17:02:06.131+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:133,9.075563,3.468775,1.331216
06-07 17:02:06.141+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.141+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.141+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:146,-0.028301,-0.047039,-0.015164
06-07 17:02:06.141+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.141+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:147,9.047262,3.421736,1.316052
06-07 17:02:06.141+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.151+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:153,0.840000,0.420000,0.420000
06-07 17:02:06.161+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.161+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.161+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:166,9.075976,3.503092,1.332802
06-07 17:02:06.161+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:166,0.000185,0.034843,0.001772
06-07 17:02:06.161+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:155,9.075791,3.468250,1.331030
06-07 17:02:06.161+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.171+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:172,9.075288,3.469870,1.330238
06-07 17:02:06.171+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.171+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:177,0.770000,-0.210000,0.070000
06-07 17:02:06.181+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.181+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.181+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:191,9.083155,3.546163,1.253839
06-07 17:02:06.181+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:191,0.007867,0.076293,-0.076399
06-07 17:02:06.191+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.191+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:196,9.075125,3.471950,1.325920
06-07 17:02:06.191+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.201+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:201,0.070000,-0.210000,0.350000
06-07 17:02:06.201+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.201+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.201+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:206,9.075543,3.471851,1.323312
06-07 17:02:06.201+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:207,9.114261,3.512664,1.246661
06-07 17:02:06.201+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.201+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.211+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:212,0.039136,0.040714,-0.079259
06-07 17:02:06.211+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:215,-1.190000,0.560000,0.700000
06-07 17:02:06.221+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.221+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.221+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:228,9.076313,3.469953,1.323012
06-07 17:02:06.221+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:228,9.097511,3.460021,1.296910
06-07 17:02:06.221+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.231+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.231+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:234,-0.560000,0.560000,0.910000
06-07 17:02:06.231+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:235,0.021968,-0.011829,-0.026402
06-07 17:02:06.241+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.241+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:246,9.068797,3.527020,1.287339
06-07 17:02:06.241+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.241+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.241+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:251,9.074775,3.473906,1.323184
06-07 17:02:06.241+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.251+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:251,-0.007516,0.057068,-0.035673
06-07 17:02:06.251+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:255,0.350000,1.260000,0.910000
06-07 17:02:06.261+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.261+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.261+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:266,9.040084,3.543770,1.284946
06-07 17:02:06.261+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:267,9.073285,3.477526,1.323896
06-07 17:02:06.261+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.261+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:06.261+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:271,-0.280000,1.470000,1.470000
06-07 17:02:06.271+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.271+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:06:274,85
06-07 17:02:06.281+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:06.291+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.301+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:298,9.073897,3.476443,1.322539
06-07 17:02:06.301+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.301+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.301+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:06:291,420.000000
06-07 17:02:06.311+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.321+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:324,9.032906,3.507878,1.237089
06-07 17:02:06.331+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:311,9.077003,3.469625,1.319128
06-07 17:02:06.331+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:277,-0.034691,0.069864,-0.038238
06-07 17:02:06.331+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:06.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390926349,000000, pattern:[H:mm][0;m
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:06.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:02:06.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:02][0;m
06-07 17:02:06.341+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.351+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:312,-1.890000,1.190000,1.960000
06-07 17:02:06.351+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.351+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:355,9.097511,3.450450,1.253839
06-07 17:02:06.351+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.351+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:359,9.099905,3.529413,1.162912
06-07 17:02:06.351+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.361+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:364,9.142976,3.763910,1.043271
06-07 17:02:06.361+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.361+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.371+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:340,-0.040380,0.030352,-0.086807
06-07 17:02:06.381+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:369,9.066404,3.912265,0.870987
06-07 17:02:06.381+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:372,-0.700000,0.210000,2.660000
06-07 17:02:06.381+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:372,9.076466,3.473445,1.312760
06-07 17:02:06.391+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.391+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.391+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:406,9.011370,3.404987,0.650848
06-07 17:02:06.401+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.401+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:403,9.070101,3.492667,1.305732
06-07 17:02:06.411+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:411,9.217153,3.488736,0.500100
06-07 17:02:06.411+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.411+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:409,0.023614,-0.025993,-0.068700
06-07 17:02:06.411+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:418,9.064240,3.511063,1.297058
06-07 17:02:06.411+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.421+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:423,9.074016,3.494562,1.273052
06-07 17:02:06.421+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.421+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.421+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:411,2.240000,1.610000,2.380000
06-07 17:02:06.421+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:429,9.334401,3.751946,0.263210
06-07 17:02:06.431+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.431+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:428,9.076823,3.494415,1.253289
06-07 17:02:06.431+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.431+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.431+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:439,9.061707,3.538502,1.238888
06-07 17:02:06.441+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.441+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:447,9.250652,3.881158,0.200997
06-07 17:02:06.441+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.451+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:443,3.430000,4.760000,3.290000
06-07 17:02:06.451+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:440,0.022902,0.059788,-0.156217
06-07 17:02:06.451+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.451+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:452,9.039874,3.591922,1.244653
06-07 17:02:06.451+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.461+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.471+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.471+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:476,9.026012,3.623322,1.254205
06-07 17:02:06.471+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:459,0.066510,0.290465,-0.269489
06-07 17:02:06.481+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:473,8.970692,3.761517,-0.066999
06-07 17:02:06.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:06.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:06:487,85
06-07 17:02:06.481+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.491+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:06.491+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:06:496,424.000000
06-07 17:02:06.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:493,-0.003696,0.419598,-0.434744
06-07 17:02:06.491+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.491+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.501+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.501+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:503,-0.052871,-0.106076,-0.646211
06-07 17:02:06.501+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.511+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:515,0.143137,-0.005826,-0.772952
06-07 17:02:06.511+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.521+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:522,0.257578,0.257531,-0.990079
06-07 17:02:06.521+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.531+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:504,9.078369,3.565305,-0.007178
06-07 17:02:06.531+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:532,0.188945,0.342656,-1.037891
06-07 17:02:06.531+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.541+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:542,-0.069182,0.169595,-1.311653
06-07 17:02:06.541+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:550,0.052357,-0.058016,-1.261383
06-07 17:02:06.551+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.561+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.561+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:530,-2.660000,6.580000,5.670000
06-07 17:02:06.561+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:560,0.133646,-0.317974,0.354692
06-07 17:02:06.561+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.571+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:573,-0.112550,-0.595204,0.338779
06-07 17:02:06.571+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.581+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:579,0.222873,-0.624911,0.653675
06-07 17:02:06.581+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:508,9.014115,3.643997,1.279606
06-07 17:02:06.581+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.581+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.581+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.581+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:589,-0.007112,-0.584702,0.387823
06-07 17:02:06.591+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.591+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:601,-0.424852,-0.600733,1.330422
06-07 17:02:06.601+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:588,8.985136,3.669981,1.403196
06-07 17:02:06.601+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.611+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.611+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:613,8.951209,3.699688,1.535758
06-07 17:02:06.611+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:565,9.147761,3.326023,1.634298
06-07 17:02:06.621+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.621+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.631+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:595,-7.420000,2.800000,7.490000
06-07 17:02:06.631+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.641+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:626,-0.556074,-0.905898,1.451808
06-07 17:02:06.641+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:644,-7.420000,8.610000,7.420000
06-07 17:02:06.641+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:629,8.872586,3.074777,1.741975
06-07 17:02:06.641+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.641+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.651+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:633,8.932340,3.688194,1.667611
06-07 17:02:06.651+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.651+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.671+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:06.671+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:06:676,85
06-07 17:02:06.671+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:662,9.174082,3.074777,2.189433
06-07 17:02:06.671+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:665,-0.279445,-0.918556,1.692564
06-07 17:02:06.671+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:651,2.590000,19.670000,9.730000
06-07 17:02:06.671+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:665,8.921766,3.656367,1.789818
06-07 17:02:06.671+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.671+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.671+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.681+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.691+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:06.701+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:684,-8.050000,29.260000,13.650000
06-07 17:02:06.701+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.711+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:06:702,462.000000
06-07 17:02:06.711+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:686,8.895061,3.631323,1.965142
06-07 17:02:06.711+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.711+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:685,8.925228,3.103491,2.055435
06-07 17:02:06.711+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.711+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:708,-0.166759,-1.248506,1.678801
06-07 17:02:06.721+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:713,-27.860001,33.599998,17.920000
06-07 17:02:06.721+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.731+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:720,8.496914,3.055635,3.120241
06-07 17:02:06.731+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.731+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:717,8.857714,3.617660,2.150310
06-07 17:02:06.731+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.741+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.741+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:737,8.338986,2.725425,3.416951
06-07 17:02:06.741+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:734,-0.232808,-1.610446,2.098474
06-07 17:02:06.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.751+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:761,-0.477814,-1.687644,1.900317
06-07 17:02:06.761+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:744,8.826385,3.591079,2.317212
06-07 17:02:06.761+0200 W/LOCATION(14696): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:02:06.761+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:748,-36.330002,39.689999,21.210001
06-07 17:02:06.761+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.771+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.771+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:776,8.806292,3.531883,2.478995
06-07 17:02:06.771+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.771+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:780,8.783301,3.465512,2.648439
06-07 17:02:06.771+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.781+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:752,8.578269,2.699104,3.842873
06-07 17:02:06.781+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.781+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.791+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:790,8.659625,2.342573,3.996014
06-07 17:02:06.791+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.791+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:790,-27.370001,54.950001,22.610001
06-07 17:02:06.801+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.801+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:794,-0.565623,-1.104118,1.290960
06-07 17:02:06.811+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.811+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:784,8.753862,3.417977,2.803160
06-07 17:02:06.811+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.811+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:806,-16.450001,62.790001,25.900000
06-07 17:02:06.821+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:802,8.573483,1.921437,4.577469
06-07 17:02:06.821+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.821+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.821+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:816,-0.355858,-0.918233,0.962810
06-07 17:02:06.831+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:835,8.305488,1.777867,4.548756
06-07 17:02:06.831+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:821,8.716380,3.409161,2.927920
06-07 17:02:06.841+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.841+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.841+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:836,-15.330000,57.959999,30.870001
06-07 17:02:06.851+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.851+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.851+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:849,8.683636,3.395067,3.039469
06-07 17:02:06.851+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:858,8.188239,2.313859,4.094120
06-07 17:02:06.861+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.861+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:849,-0.373363,-1.255884,2.260634
06-07 17:02:06.861+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:06.871+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.871+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.871+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:06:875,85
06-07 17:02:06.871+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:866,-21.350000,58.029999,37.240002
06-07 17:02:06.871+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:880,8.360522,2.490928,3.890730
06-07 17:02:06.881+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.881+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:872,8.637597,3.368063,3.196630
06-07 17:02:06.881+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.881+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:06.881+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:878,-0.671891,-1.070954,2.218328
06-07 17:02:06.891+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:06:891,489.000000
06-07 17:02:06.891+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.891+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:890,-20.440001,65.800003,36.330002
06-07 17:02:06.891+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.901+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:893,8.577448,3.376910,3.345780
06-07 17:02:06.901+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.911+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.911+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:904,-0.903666,-0.204027,2.179247
06-07 17:02:06.911+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:904,8.310273,2.139183,5.300103
06-07 17:02:06.911+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:914,8.485852,3.447553,3.503581
06-07 17:02:06.911+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.921+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.921+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:920,-4.690000,72.239998,32.830002
06-07 17:02:06.931+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.931+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.931+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:928,7.965706,2.297110,5.414958
06-07 17:02:06.941+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.941+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:933,-1.343277,-0.566595,2.035803
06-07 17:02:06.941+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:937,8.375541,3.512015,3.699519
06-07 17:02:06.951+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:06.951+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:06.951+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:06:945,9.450000,65.519997,35.840000
06-07 17:02:06.961+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:948,7.673782,3.172883,5.525027
06-07 17:02:06.961+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:06.961+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:06:957,8.267442,3.543453,3.906883
06-07 17:02:06.961+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:06.981+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:06:958,-1.934062,-0.918196,1.949934
06-07 17:02:07.001+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:07.001+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:06:973,7.142576,2.880959,5.539384
06-07 17:02:07.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:07.011+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:07:21,-2.510310,-1.260700,1.314256
06-07 17:02:07.021+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:07.021+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:07:5,8.750000,64.330002,37.310001
06-07 17:02:07.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:07:14,8.178642,3.554696,4.079747
06-07 17:02:07.031+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:07.031+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:07.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:07:39,8.097208,3.534811,4.255668
06-07 17:02:07.041+0200 I/linearacceleration(14569): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:07.041+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:07:32,6.441479,2.593820,5.649454
06-07 17:02:07.041+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:07:45,19.389999,65.169998,35.980000
06-07 17:02:07.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:02:07.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:02:07.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:02:07.061+0200 I/accelerometer(14709): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:07.071+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:07.071+0200 I/gyroscope(14556): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:07.071+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:07:81,7.990831,3.536887,4.450554
06-07 17:02:07.081+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11146966c6f63152838372
