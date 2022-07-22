S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13367
Date: 2018-06-07 16:57:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745052d, r5   = 0xf7a1af98
r6   = 0xfffe9150, r7   = 0xfffe9000
r8   = 0xf7a17c18, r9   = 0x00000000
r10  = 0xfffe90dc, fp   = 0xfffe9150
ip   = 0x00000001, sp   = 0xfffe8fd8
lr   = 0xf7450539, pc   = 0xf74b9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    139232 KB
Buffers:      6852 KB
Cached:      58252 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11612 KB
VmRSS:       11612 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13367 TID = 13367
13367 13371 

Maps Information
f431b000 f4b1a000 rw-p [stack:13371]
f4b21000 f4b23000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b2b000 f4b2f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b38000 f4b3a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b42000 f4b45000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b54000 f4b59000 r-xp /usr/lib/libsystem.so.0.0.0
f4b64000 f4b67000 r-xp /lib/libattr.so.1.1.0
f4b6f000 f4b7f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b87000 f4b90000 r-xp /usr/lib/libedbus.so.1.7.99
f4b98000 f4b99000 r-xp /usr/lib/libresponse.so.0.2.96
f4ba2000 f4ba7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6449000 f654f000 r-xp /usr/lib/libicuuc.so.57.1
f6565000 f66ed000 r-xp /usr/lib/libicui18n.so.57.1
f66fd000 f670a000 r-xp /usr/lib/libail.so.0.1.0
f6713000 f671a000 r-xp /usr/lib/libminizip.so.1.0.0
f6723000 f68cc000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ec000 f6933000 r-xp /usr/lib/libssl.so.1.0.0
f693f000 f6941000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6949000 f6950000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6959000 f6960000 r-xp /lib/libcrypt-2.13.so
f6991000 f6994000 r-xp /lib/libcap.so.2.21
f699c000 f699e000 r-xp /usr/lib/libiri.so
f69a6000 f69ef000 r-xp /usr/lib/libmdm.so.1.2.69
f69f7000 f69fd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a05000 f6a28000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a32000 f6a34000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a3c000 f6a59000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a62000 f6a66000 r-xp /usr/lib/libsmack.so.1.0.0
f6a6f000 f6a88000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a91000 f6a99000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aa1000 f6aa7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ab0000 f6ab2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6abb000 f6acb000 r-xp /lib/libresolv-2.13.so
f6acf000 f6ae7000 r-xp /usr/lib/liblzma.so.5.0.3
f6af0000 f6af2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6afa000 f6b14000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b1c000 f6b4b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b54000 f6b63000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b6d000 f6b77000 r-xp /usr/lib/libsensord-shared.so
f6b80000 f6c53000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c5e000 f6c74000 r-xp /lib/libz.so.1.2.5
f6c7c000 f6c81000 r-xp /usr/lib/libffi.so.5.0.10
f6c89000 f6c8a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c92000 f6ca2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6caa000 f6cc3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ccb000 f6ccd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cd5000 f6d4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d54000 f6d5a000 r-xp /lib/librt-2.13.so
f6d63000 f6d81000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d8b000 f6d8c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d94000 f6db7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dbf000 f6dc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dcc000 f6df6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dff000 f6e16000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e1e000 f6e87000 r-xp /lib/libm-2.13.so
f6e90000 f6f24000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f37000 f6f3c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f44000 f6f4b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f53000 f6f7d000 r-xp /usr/lib/libsensor.so.1.9.6
f6f86000 f7052000 r-xp /usr/lib/libxml2.so.2.7.8
f705f000 f7061000 r-xp /usr/lib/libiniparser.so.0
f706a000 f7070000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7079000 f7149000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f714a000 f717e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7187000 f71c3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71cb000 f71ce000 r-xp /usr/lib/libbundle.so.0.1.22
f71d6000 f71dc000 r-xp /usr/lib/libappsvc.so.0.1.0
f71e4000 f7225000 r-xp /usr/lib/libeina.so.1.7.99
f722e000 f7245000 r-xp /usr/lib/libecore.so.1.7.99
f725c000 f7265000 r-xp /usr/lib/libvconf.so.0.2.45
f726d000 f7281000 r-xp /lib/libpthread-2.13.so
f728c000 f7299000 r-xp /usr/lib/libaul.so.0.1.0
f72a3000 f72a5000 r-xp /lib/libdl-2.13.so
f72ae000 f72b9000 r-xp /lib/libunwind.so.8.0.1
f72e6000 f72ee000 r-xp /lib/libgcc_s-4.6.so.1
f72ef000 f7413000 r-xp /lib/libc-2.13.so
f7421000 f7423000 r-xp /usr/lib/libdlog.so.0.0.0
f742b000 f7437000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7440000 f7445000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f744d000 f745c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7464000 f7468000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7471000 f7474000 r-xp /usr/lib/libappcore-agent.so.1.1
f747c000 f747e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7486000 f748a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7492000 f74af000 r-xp /lib/ld-2.13.so
f74b8000 f74bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74bb000 f74bf000 r-xp /usr/lib/libsys-assert.so
f79e7000 f7a75000 rw-p [heap]
fffca000 fffeb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13367)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74b9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7450539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71573f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7155c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7161e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7167be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7167dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71971f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7155c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7161e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7167be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7167dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7199e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf719a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71a1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b391fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b2c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bff663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70acfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70ae7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf723eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7239b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf723a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf723a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7472183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74727fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74b95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf730685c) [/lib/libc.so.6] + 0x1785c
29: (0xf74b8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:57:34.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:57:34.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:57:34.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:57:34.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:57:34.061+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:57:34.061+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:34.061+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:57:34.061+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:57:34.091+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:34.091+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:34.091+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:36,0.307811,-0.271013,0.462923
06-07 16:57:34.091+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:57:34.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:34.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(12618), cmd(0)
06-07 16:57:34.101+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:34.101+0200 I/utils   (12618): specific action
06-07 16:57:34.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:34.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12595), cmd(0)
06-07 16:57:34.111+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:57:34.111+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:34.111+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:57:34.111+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:34.111+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:57:34.111+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(12614), cmd(0)
06-07 16:57:34.111+0200 I/utils   (12595): specific action
06-07 16:57:34.121+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:34.121+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:57:34.121+0200 I/utils   (12614): specific action
06-07 16:57:34.121+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:34.131+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:33:880,1.400000,-9.030000,-1.540000
06-07 16:57:34.151+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.151+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:34:138,871.000000
06-07 16:57:34.161+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:34:133,80
06-07 16:57:34.161+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:33:897,0.614955,-4.201797,8.824730
06-07 16:57:34.171+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:147,5.431438,-0.979285,8.106224
06-07 16:57:34.181+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.181+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:160,-1.750000,-9.450000,1.610000
06-07 16:57:34.181+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.191+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.201+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:188,0.418744,-3.929015,8.288737
06-07 16:57:34.211+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.211+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:205,-9.590000,-7.070000,2.240000
06-07 16:57:34.211+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:193,6.228465,-0.842364,7.527750
06-07 16:57:34.221+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.231+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.241+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:233,6.896620,-0.743406,6.932126
06-07 16:57:34.241+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:249,-2.800000,-2.310000,3.710000
06-07 16:57:34.251+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:232,0.425922,-3.986443,8.054241
06-07 16:57:34.251+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:103,0.118689,-0.593255,1.209382
06-07 16:57:34.261+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.261+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.271+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:275,7.319831,-0.675481,6.491085
06-07 16:57:34.281+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:34.281+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:34:291,80
06-07 16:57:34.291+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.291+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.301+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:34.311+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:34:312,870.000000
06-07 16:57:34.321+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:275,0.428315,-4.443472,8.063812
06-07 16:57:34.321+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:305,2.660000,0.140000,4.760000
06-07 16:57:34.331+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.331+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.341+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:338,7.611957,-0.548978,6.158500
06-07 16:57:34.351+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:342,0.413958,-4.271189,8.930015
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:34.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390654359,000000, pattern:[H:mm][0;m
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:34.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:34.351+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:57:34.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:57][0;m
06-07 16:57:34.361+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:308,0.004036,-0.968341,0.889712
06-07 16:57:34.361+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.371+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:351,-13.790000,-7.420000,4.760000
06-07 16:57:34.381+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.381+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.381+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.381+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:390,0.208397,-0.552377,0.487223
06-07 16:57:34.381+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.391+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:387,0.380459,-4.144369,9.621540
06-07 16:57:34.411+0200 W/LOCATION(13367): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:57:34.431+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:394,-22.049999,-11.760000,-0.980000
06-07 16:57:34.431+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:384,7.709677,-0.504950,6.039560
06-07 16:57:34.441+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.441+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.451+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.461+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:394,0.426879,-0.651968,0.345649
06-07 16:57:34.461+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.471+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:464,-21.070000,-9.310000,-3.710000
06-07 16:57:34.481+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:461,0.088534,-4.433900,9.590433
06-07 16:57:34.481+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:454,7.807580,-0.395021,5.920814
06-07 16:57:34.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:34.491+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:34:492,80
06-07 16:57:34.491+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:475,0.486940,-0.773672,0.452336
06-07 16:57:34.491+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.501+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.501+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:34.511+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:34:512,871.000000
06-07 16:57:34.511+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.521+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.521+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:524,0.177069,-4.508078,9.284152
06-07 16:57:34.541+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:505,7.874456,-0.276934,5.838376
06-07 16:57:34.541+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:527,-15.540000,-4.550000,-6.300000
06-07 16:57:34.541+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.551+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.561+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.571+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:558,7.932731,-0.104615,5.764653
06-07 16:57:34.571+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:516,0.342547,-0.934467,0.515784
06-07 16:57:34.581+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.581+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:573,-10.640000,-3.010000,-7.910000
06-07 16:57:34.581+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:567,0.301496,-4.823930,8.628519
06-07 16:57:34.591+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:599,7.977376,0.056386,5.703392
06-07 16:57:34.601+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.601+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.611+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:608,0.258425,-4.809574,8.800802
06-07 16:57:34.621+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.631+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:612,-10.080000,0.070000,-9.310000
06-07 16:57:34.631+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.631+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.641+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.651+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:659,-10.360000,1.890000,-10.010000
06-07 16:57:34.661+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:634,7.981516,0.135347,5.696267
06-07 16:57:34.661+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.671+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:646,0.331856,-1.112662,0.918603
06-07 16:57:34.671+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:652,0.241675,-4.654040,8.738588
06-07 16:57:34.671+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.671+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:678,-0.038507,-1.742889,0.369838
06-07 16:57:34.681+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.681+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.681+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:34.681+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:34:691,80
06-07 16:57:34.691+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:690,-10.990000,2.940000,-10.360000
06-07 16:57:34.701+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:34.711+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:34:715,871.000000
06-07 16:57:34.721+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.721+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:678,7.964998,0.172876,5.718330
06-07 16:57:34.721+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.731+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.731+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:700,0.287139,-4.481757,8.743374
06-07 16:57:34.731+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.741+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:745,-10.920000,1.400000,-11.060000
06-07 16:57:34.751+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:731,7.875161,0.093585,5.843242
06-07 16:57:34.821+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.821+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:752,0.358923,-4.565506,8.461020
06-07 16:57:34.831+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:729,-0.193719,-1.865925,0.302361
06-07 16:57:34.881+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.881+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.881+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:34.891+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:34:892,80
06-07 16:57:34.891+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.891+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:897,0.289532,-4.582255,8.700303
06-07 16:57:34.891+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:836,7.774611,0.037617,5.976988
06-07 16:57:34.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:888,0.082709,-1.448364,0.286069
06-07 16:57:34.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.891+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.901+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:886,-12.180000,-5.390000,-12.390000
06-07 16:57:34.901+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:34.901+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:34:911,869.000000
06-07 16:57:34.911+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.951+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:904,7.716215,0.097309,6.051524
06-07 16:57:34.951+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.961+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:961,0.227318,-4.661219,9.238688
06-07 16:57:34.961+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:34.961+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:956,-4.620000,-9.170000,-12.110000
06-07 16:57:34.971+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:34:972,7.644614,0.242489,6.137708
06-07 16:57:34.971+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:34.971+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:904,0.456493,-1.292997,0.591444
06-07 16:57:34.971+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:34.971+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:34.981+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:34:990,0.468993,-4.644469,9.420543
06-07 16:57:34.991+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.021+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:34:982,0.687014,-1.045712,0.499216
06-07 16:57:35.021+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.041+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:34:982,1.260000,-7.980000,-11.620000
06-07 16:57:35.051+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:57:35.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:57:35.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:57:35.061+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.061+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:52,7.435524,0.356712,6.384052
06-07 16:57:35.071+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.071+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:72,0.495314,-4.563113,8.815158
06-07 16:57:35.071+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:63,-0.070000,-7.070000,-11.480000
06-07 16:57:35.081+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.081+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:35.091+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:35:92,80
06-07 16:57:35.111+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:35.111+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:35:120,870.000000
06-07 16:57:35.111+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:31,0.558436,-1.313503,0.129863
06-07 16:57:35.121+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:80,7.219108,0.401392,6.625236
06-07 16:57:35.131+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.131+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:87,-2.240000,-5.740000,-13.510000
06-07 16:57:35.131+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.141+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.141+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:137,0.327817,-4.572684,8.449057
06-07 16:57:35.151+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.161+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:145,7.158721,0.354030,6.693112
06-07 16:57:35.161+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.181+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.191+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:154,-3.570000,-5.740000,-18.410000
06-07 16:57:35.191+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.211+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:208,10.290000,-11.340000,-22.610001
06-07 16:57:35.211+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:170,0.445065,-4.776074,8.824730
06-07 16:57:35.221+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:195,7.178730,0.266827,6.675704
06-07 16:57:35.221+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.221+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.241+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.241+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:239,0.744168,-5.182854,8.939585
06-07 16:57:35.251+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.251+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:240,7.165025,0.226985,6.691882
06-07 16:57:35.251+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.251+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:251,28.210001,-14.140000,-27.650000
06-07 16:57:35.261+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:263,0.586242,-5.477170,9.700503
06-07 16:57:35.261+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.271+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:265,7.111371,0.168046,6.750596
06-07 16:57:35.281+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.281+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.281+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:275,32.549999,-13.300000,-31.780001
06-07 16:57:35.281+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:35.291+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:35:292,80
06-07 16:57:35.301+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.301+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:35.301+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:174,0.657141,-1.406383,-0.382996
06-07 16:57:35.301+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:314,0.978494,-1.386223,-0.498300
06-07 16:57:35.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.311+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:319,1.070690,-1.167334,-0.232948
06-07 16:57:35.321+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.321+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:326,0.820174,-1.098749,-0.431392
06-07 16:57:35.321+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.331+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:334,0.485229,-0.911729,-1.056900
06-07 16:57:35.331+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.331+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:35:312,871.000000
06-07 16:57:35.341+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:290,7.053912,0.090071,6.812092
06-07 16:57:35.341+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:290,0.495314,-5.809773,9.403792
06-07 16:57:35.341+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:35.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390655354,000000, pattern:[H:mm][0;m
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:57:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:57:35.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:57:35.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:57][0;m
06-07 16:57:35.351+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.381+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:346,30.730000,-12.600000,-37.099998
06-07 16:57:35.381+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.381+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:364,0.732204,-5.359922,9.018548
06-07 16:57:35.391+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:360,6.977000,-0.017067,6.891413
06-07 16:57:35.391+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.411+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.411+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:396,31.360001,-12.180000,-43.330002
06-07 16:57:35.431+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.441+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:408,6.831308,-0.155161,7.034170
06-07 16:57:35.441+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:416,0.997807,-5.393422,8.910872
06-07 16:57:35.451+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.461+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.461+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:436,37.099998,-14.630000,-49.560001
06-07 16:57:35.461+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:339,0.415972,-0.987506,-0.742874
06-07 16:57:35.471+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.471+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.481+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:486,44.029999,-19.320000,-60.200001
06-07 16:57:35.481+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:35.491+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:35:494,81
06-07 16:57:35.511+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:35.511+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:35:518,872.000000
06-07 16:57:35.511+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:457,6.640125,-0.279917,7.211155
06-07 16:57:35.521+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:466,1.115055,-5.431707,9.059227
06-07 16:57:35.521+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.521+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.541+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.551+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:543,1.031307,-5.501099,9.166903
06-07 16:57:35.551+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:539,6.437875,-0.391372,7.387218
06-07 16:57:35.571+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.571+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:551,42.349998,-20.230000,-76.160004
06-07 16:57:35.581+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.601+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.601+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:479,0.391889,-0.723405,-0.455925
06-07 16:57:35.691+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:35.711+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:35.721+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:35:723,872.000000
06-07 16:57:35.731+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.731+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:736,1.076770,-5.580062,9.616754
06-07 16:57:35.751+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:741,34.160000,-21.770000,-89.599998
06-07 16:57:35.751+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:594,6.202928,-0.507034,7.578720
06-07 16:57:35.751+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.751+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:35:703,81
06-07 16:57:35.761+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:740,0.185790,-0.285361,-0.663861
06-07 16:57:35.761+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.761+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.761+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:769,5.965906,-0.578553,7.761677
06-07 16:57:35.771+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.771+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:779,24.010000,-24.080000,-102.550003
06-07 16:57:35.781+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:774,0.763310,-6.089733,9.123833
06-07 16:57:35.781+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:775,-0.357405,0.095248,-1.446915
06-07 16:57:35.781+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.781+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.791+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.791+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.811+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7280.583085] layer(0x86a2c0) now usable
06-07 16:57:35.811+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7280.583117] layer[0x869e10]zpos[1]
06-07 16:57:35.811+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7280.583143] layer(0x86a310) now usable
06-07 16:57:35.811+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7280.583154] layer[0x869f30]zpos[2]
06-07 16:57:35.811+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [7280.583251] dpms[0 -> 3]sync[1]
06-07 16:57:35.811+0200 I/TDM     ( 1956): 
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_enable(138) > 1
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): event_manager.c: _lcd_off_cb(729) > lcd state: 0
06-07 16:57:35.821+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-07 16:57:35.821+0200 W/WATCH_CORE( 2865): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
06-07 16:57:35.821+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
06-07 16:57:35.821+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
06-07 16:57:35.821+0200 E/STARTER ( 2696): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
06-07 16:57:35.821+0200 E/STARTER ( 2696): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
06-07 16:57:35.821+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 1
06-07 16:57:35.821+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 1
06-07 16:57:35.821+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] reserved app is running now. raise it.
06-07 16:57:35.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:57:35.831+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147895540[0;m
06-07 16:57:35.831+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
06-07 16:57:35.831+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-07 16:57:35.831+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
06-07 16:57:35.831+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
06-07 16:57:35.831+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
06-07 16:57:35.831+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-07 16:57:35.841+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:846,-0.612576,1.588865,-2.062981
06-07 16:57:35.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11356
06-07 16:57:35.841+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:798,5.626345,-0.643020,8.006320
06-07 16:57:35.851+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1449) > [_pre_lcd_off:1449] [com.samsung.shealth.alert] is now running & will raise when lcd on.
06-07 16:57:35.851+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-07 16:57:35.851+0200 W/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-07 16:57:35.851+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-07 16:57:35.851+0200 I/HIGEAR  ( 3285): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-07 16:57:35.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:857,-0.684888,2.087969,-2.062849
06-07 16:57:35.851+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.851+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:806,10.780000,-28.000000,-113.820000
06-07 16:57:35.861+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:861,-1.304102,3.937160,-1.841061
06-07 16:57:35.861+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.861+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:803,0.669990,-6.096912,9.107083
06-07 16:57:35.861+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.861+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.861+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:867,-1.489758,4.089233,-1.491243
06-07 16:57:35.861+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.861+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.861+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:871,-1.200266,4.385130,-2.007317
06-07 16:57:35.871+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.871+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:876,-0.877727,4.973451,-2.550433
06-07 16:57:35.871+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.881+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:881,-1.097419,5.103372,-1.722990
06-07 16:57:35.881+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.881+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:871,5.373389,-0.660288,8.176863
06-07 16:57:35.881+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:875,1.014557,-5.548956,9.145369
06-07 16:57:35.881+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:887,-1.725545,4.761440,-1.236608
06-07 16:57:35.881+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:57:35.891+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:57:35:892,81
06-07 16:57:35.891+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:873,-4.340000,-34.790001,-123.970001
06-07 16:57:35.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.891+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.891+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.891+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.891+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:57:35:897,-2.170021,4.884372,-1.411106
06-07 16:57:35.901+0200 I/linearacceleration(13292): es.ugr.frailty.linearacceleration - capturing data
06-07 16:57:35.901+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:903,5.260385,-0.690588,8.247534
06-07 16:57:35.911+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:913,1.471586,-5.292924,9.487542
06-07 16:57:35.911+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:911,-11.200000,-36.330002,-133.559998
06-07 16:57:35.921+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.921+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.921+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.931+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 16:57:35.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:57:35.931+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:57:35.931+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:929,5.081922,-0.779723,8.350838
06-07 16:57:35.931+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:57:35:940,867.000000
06-07 16:57:35.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:35.931+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:931,0.280000,-33.040001,-143.080002
06-07 16:57:35.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:35.941+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:935,1.806581,-4.938786,9.430114
06-07 16:57:35.941+0200 I/gravity (13307): es.ugr.frailty.gravity - capturing data
06-07 16:57:35.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13214
06-07 16:57:35.951+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope - capturing data
06-07 16:57:35.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13214)
06-07 16:57:35.951+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:57:35.951+0200 I/servicemanager(12566): App control destroyed.
06-07 16:57:35.951+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:57:35.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:57:35.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:57:35.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:57:35.951+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer - capturing data
06-07 16:57:35.951+0200 I/accelerometer(13214): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:57:35:960,1.804188,-5.132604,9.075976
06-07 16:57:35.961+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [7280.730999] dpms[3 -> 3]done
06-07 16:57:35.961+0200 I/TDM     ( 1956): 
06-07 16:57:35.971+0200 W/SHealthCommon( 2909): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 16:57:35.971+0200 I/watchface-viewer( 2865): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-07 16:57:35.971+0200 W/SHealthCommon( 3178): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 16:57:35.971+0200 W/SHealthService( 3178): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
06-07 16:57:35.981+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
06-07 16:57:35.981+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[com.samsung.shealth.alert] alpm mode[0]
06-07 16:57:35.981+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 1
06-07 16:57:35.981+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1525) > [_post_lcd_off:1525] raise [com.samsung.shealth.alert] when lcd off after 20 sec.
06-07 16:57:35.981+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-6-2018, 16:57:56), repeat(1), interval(20), type(-1073741822)
06-07 16:57:35.981+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 16:57:35.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13279
06-07 16:57:35.981+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 16:57:35.981+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 16:57:35.981+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 16:57:35.981+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 16:57:35.991+0200 I/gravity (13307): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:57:35:956,4.993551,-0.852635,8.396894
06-07 16:57:35.991+0200 I/gyroscope(13279): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:57:35:958,11.620000,-26.530001,-152.389999
06-07 16:57:35.991+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11133676c6f63152838345
