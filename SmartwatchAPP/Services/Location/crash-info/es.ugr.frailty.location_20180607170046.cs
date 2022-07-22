S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14289
Date: 2018-06-07 17:00:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf725652d, r5   = 0xf7afcf98
r6   = 0xffb956b0, r7   = 0xffb95560
r8   = 0xf7af9c18, r9   = 0x00000000
r10  = 0xffb9563c, fp   = 0xffb956b0
ip   = 0x00000001, sp   = 0xffb95538
lr   = 0xf7256539, pc   = 0xf72bf228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    221884 KB
Buffers:      7788 KB
Cached:      43588 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11496 KB
VmRSS:       11496 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14289 TID = 14289
14289 14300 

Maps Information
f4121000 f4920000 rw-p [stack:14300]
f4927000 f4929000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4931000 f4935000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f493e000 f4940000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4948000 f494b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f495a000 f495f000 r-xp /usr/lib/libsystem.so.0.0.0
f496a000 f496d000 r-xp /lib/libattr.so.1.1.0
f4975000 f4985000 r-xp /usr/lib/libmdm-common.so.1.1.24
f498d000 f4996000 r-xp /usr/lib/libedbus.so.1.7.99
f499e000 f499f000 r-xp /usr/lib/libresponse.so.0.2.96
f49a8000 f49ad000 r-xp /usr/lib/libproc-stat.so.0.2.96
f624f000 f6355000 r-xp /usr/lib/libicuuc.so.57.1
f636b000 f64f3000 r-xp /usr/lib/libicui18n.so.57.1
f6503000 f6510000 r-xp /usr/lib/libail.so.0.1.0
f6519000 f6520000 r-xp /usr/lib/libminizip.so.1.0.0
f6529000 f66d2000 r-xp /usr/lib/libcrypto.so.1.0.0
f66f2000 f6739000 r-xp /usr/lib/libssl.so.1.0.0
f6745000 f6747000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f674f000 f6756000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f675f000 f6766000 r-xp /lib/libcrypt-2.13.so
f6797000 f679a000 r-xp /lib/libcap.so.2.21
f67a2000 f67a4000 r-xp /usr/lib/libiri.so
f67ac000 f67f5000 r-xp /usr/lib/libmdm.so.1.2.69
f67fd000 f6803000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f680b000 f682e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6838000 f683a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6842000 f685f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6868000 f686c000 r-xp /usr/lib/libsmack.so.1.0.0
f6875000 f688e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6897000 f689f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68a7000 f68ad000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68b6000 f68b8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68c1000 f68d1000 r-xp /lib/libresolv-2.13.so
f68d5000 f68ed000 r-xp /usr/lib/liblzma.so.5.0.3
f68f6000 f68f8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6900000 f691a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6922000 f6951000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f695a000 f6969000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6973000 f697d000 r-xp /usr/lib/libsensord-shared.so
f6986000 f6a59000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a64000 f6a7a000 r-xp /lib/libz.so.1.2.5
f6a82000 f6a87000 r-xp /usr/lib/libffi.so.5.0.10
f6a8f000 f6a90000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a98000 f6aa8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ab0000 f6ac9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ad1000 f6ad3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6adb000 f6b50000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b5a000 f6b60000 r-xp /lib/librt-2.13.so
f6b69000 f6b87000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b91000 f6b92000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b9a000 f6bbd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bc5000 f6bca000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bd2000 f6bfc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c05000 f6c1c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c24000 f6c8d000 r-xp /lib/libm-2.13.so
f6c96000 f6d2a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d3d000 f6d42000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d4a000 f6d51000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d59000 f6d83000 r-xp /usr/lib/libsensor.so.1.9.6
f6d8c000 f6e58000 r-xp /usr/lib/libxml2.so.2.7.8
f6e65000 f6e67000 r-xp /usr/lib/libiniparser.so.0
f6e70000 f6e76000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e7f000 f6f4f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f50000 f6f84000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f8d000 f6fc9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fd1000 f6fd4000 r-xp /usr/lib/libbundle.so.0.1.22
f6fdc000 f6fe2000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fea000 f702b000 r-xp /usr/lib/libeina.so.1.7.99
f7034000 f704b000 r-xp /usr/lib/libecore.so.1.7.99
f7062000 f706b000 r-xp /usr/lib/libvconf.so.0.2.45
f7073000 f7087000 r-xp /lib/libpthread-2.13.so
f7092000 f709f000 r-xp /usr/lib/libaul.so.0.1.0
f70a9000 f70ab000 r-xp /lib/libdl-2.13.so
f70b4000 f70bf000 r-xp /lib/libunwind.so.8.0.1
f70ec000 f70f4000 r-xp /lib/libgcc_s-4.6.so.1
f70f5000 f7219000 r-xp /lib/libc-2.13.so
f7227000 f7229000 r-xp /usr/lib/libdlog.so.0.0.0
f7231000 f723d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7246000 f724b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7253000 f7262000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f726a000 f726e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7277000 f727a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7282000 f7284000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f728c000 f7290000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7298000 f72b5000 r-xp /lib/ld-2.13.so
f72be000 f72c1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72c1000 f72c5000 r-xp /usr/lib/libsys-assert.so
f7ac9000 f7b57000 rw-p [heap]
ffb76000 ffb97000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14289)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72bf228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7256539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f5d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f5bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f67e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f6dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f6ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fa275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f9d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f5bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f67e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f6dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f6ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f9fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fa0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fa7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf493f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4932171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a05663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6eb2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6eb47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7044ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf703fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70405a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7040879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7278183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72787fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72bf5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf710c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72bef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
start_process(606) > child process: 14354
06-07 17:00:46.121+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:00:46.141+0200 E/CAPI_APPFW_APPLICATION(14345): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:00:46.151+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.151+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:157,2.335340,-0.530883,9.509718
06-07 17:00:46.151+0200 E/CAPI_APPFW_APPLICATION(14345): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:00:46.161+0200 I/utils   (14345): trying to start service: es.ugr.frailty.gyroscope
06-07 17:00:46.161+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.171+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14354
06-07 17:00:46.171+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.linearacceleration) pid(14354) type(svcapp) bg(0)
06-07 17:00:46.181+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:46.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14289), cmd(0)
06-07 17:00:46.181+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (14345) was created
06-07 17:00:46.181+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14354)
06-07 17:00:46.181+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:00:46.181+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:46.181+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:00:46.181+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:00:46.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:46.181+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:46.181+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14354]
06-07 17:00:46.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14311
06-07 17:00:46.191+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14311)
06-07 17:00:46.191+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:00:46.191+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:46.191+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:00:46.191+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:00:46.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:46.201+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:46.211+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:00:46.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:00:46.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:46.221+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14354
06-07 17:00:46.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:00:46.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:46:227,84
06-07 17:00:46.231+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14354
06-07 17:00:46.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:00:46.241+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14354
06-07 17:00:46.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:00:46.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:00:46.251+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.251+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:46.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:00:46.251+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:46.251+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12603), cmd(0)
06-07 17:00:46.251+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:00:46.251+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:00:46.251+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:46.251+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:00:46.251+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:00:46.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:46.251+0200 I/utils   (12603): specific action
06-07 17:00:46.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:46.251+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:46:257,785.000000
06-07 17:00:46.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 17:00:46.261+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.261+0200 I/utils   (12614): specific action
06-07 17:00:46.261+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:46.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12614), cmd(0)
06-07 17:00:46.261+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 17:00:46.261+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:00:46.261+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:46.261+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:00:46.261+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:00:46.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:00:46.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:00:46.271+0200 I/utils   (14345): es.ugr.frailty.gyroscope sensor supported
06-07 17:00:46.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:00:46.271+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.271+0200 I/utils   (12618): specific action
06-07 17:00:46.271+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:46.271+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12618), cmd(0)
06-07 17:00:46.281+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:00:46.281+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:00:46.281+0200 I/servicemanager(12566): App control destroyed.
06-07 17:00:46.281+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:172,2.421536,-0.502493,9.564112
06-07 17:00:46.281+0200 I/utils   (14345): es.ugr.frailty.gyroscope listener started
06-07 17:00:46.281+0200 W/CAPI_APPFW_APP_CONTROL(14345): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.281+0200 I/utils   (14345): specific action
06-07 17:00:46.281+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.291+0200 E/CAPI_APPFW_APPLICATION(14354): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:00:46.291+0200 E/CAPI_APPFW_APPLICATION(14354): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:00:46.291+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (14354) was created
06-07 17:00:46.291+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:185,2.337427,-0.529624,9.509275
06-07 17:00:46.291+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.291+0200 I/utils   (14354): trying to start service: es.ugr.frailty.linearacceleration
06-07 17:00:46.291+0200 I/utils   (14354): es.ugr.frailty.linearacceleration sensor supported
06-07 17:00:46.301+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:305,2.337372,-0.527162,9.509426
06-07 17:00:46.301+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.311+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:312,0.490000,0.560000,0.210000
06-07 17:00:46.311+0200 I/utils   (14354): es.ugr.frailty.linearacceleration listener started
06-07 17:00:46.311+0200 W/CAPI_APPFW_APP_CONTROL(14354): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.311+0200 I/utils   (14354): specific action
06-07 17:00:46.311+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.321+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:325,2.337617,-0.529172,9.509254
06-07 17:00:46.321+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.321+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:330,2.339334,-0.530460,9.508759
06-07 17:00:46.331+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.331+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.331+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:46.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390846342,000000, pattern:[H:mm][0;m
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:00:46.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:00:46.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:00][0;m
06-07 17:00:46.341+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:341,0.074888,0.015556,0.070986
06-07 17:00:46.341+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:338,0.700000,-0.490000,-0.140000
06-07 17:00:46.341+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.341+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.371+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:353,0.037028,0.006092,0.060606
06-07 17:00:46.371+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.381+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:353,0.770000,-0.280000,-0.350000
06-07 17:00:46.381+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:297,2.366502,-0.492921,9.566505
06-07 17:00:46.381+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.381+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:335,2.338216,-0.531502,9.508977
06-07 17:00:46.391+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:380,0.007413,0.025548,0.012269
06-07 17:00:46.391+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.391+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.401+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:391,2.407180,-0.514457,9.578469
06-07 17:00:46.401+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.401+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:405,0.023295,0.011122,0.035691
06-07 17:00:46.401+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.401+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.411+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:413,0.560000,-0.210000,-0.350000
06-07 17:00:46.411+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.411+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:415,0.056980,0.013245,0.050574
06-07 17:00:46.411+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:46.411+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:402,2.335147,-0.530718,9.509774
06-07 17:00:46.411+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.411+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:408,2.395216,-0.500100,9.564112
06-07 17:00:46.421+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:46:421,84
06-07 17:00:46.421+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:417,-0.210000,-0.140000,-0.350000
06-07 17:00:46.421+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.421+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:427,0.210000,0.070000,-0.070000
06-07 17:00:46.421+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.421+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:432,2.356930,-0.579063,9.571291
06-07 17:00:46.431+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:422,2.332525,-0.527260,9.510611
06-07 17:00:46.431+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.431+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:46.431+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.431+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:46:438,785.000000
06-07 17:00:46.431+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:439,0.084810,-0.021502,0.100974
06-07 17:00:46.441+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:437,2.332505,-0.524389,9.510774
06-07 17:00:46.441+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:00:46.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14311), cmd(0)
06-07 17:00:46.441+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.441+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.451+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:453,0.150265,0.037536,-0.040454
06-07 17:00:46.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:457,0.700000,0.210000,-0.070000
06-07 17:00:46.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.451+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:460,-0.210000,0.210000,0.140000
06-07 17:00:46.451+0200 W/CAPI_APPFW_APP_CONTROL(14311): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:00:46.451+0200 I/utils   (14311): specific action
06-07 17:00:46.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:449,2.390430,-0.571885,9.578469
06-07 17:00:46.461+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:466,2.347359,-0.569492,9.585647
06-07 17:00:46.461+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.461+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.471+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:466,2.333765,-0.526208,9.510365
06-07 17:00:46.471+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.481+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:473,0.085734,-0.052299,0.085649
06-07 17:00:46.481+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.481+0200 W/LOCATION(14289): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:00:46.481+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:470,2.364109,-0.559920,9.540184
06-07 17:00:46.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:498,2.378466,-0.509671,9.600004
06-07 17:00:46.491+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.491+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:484,2.332948,-0.525562,9.510601
06-07 17:00:46.491+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.511+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:489,-0.350000,-0.490000,0.070000
06-07 17:00:46.511+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.511+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:504,2.332565,-0.524177,9.510771
06-07 17:00:46.511+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:493,0.020444,-0.075572,0.048876
06-07 17:00:46.511+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.511+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.521+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:524,2.330360,-0.520204,9.511530
06-07 17:00:46.521+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:523,-0.004781,-0.002172,0.062460
06-07 17:00:46.521+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:521,0.910000,-0.070000,0.070000
06-07 17:00:46.521+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.521+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.531+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.531+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:534,2.328104,-0.516931,9.512260
06-07 17:00:46.531+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.541+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:538,0.068620,0.055863,0.027877
06-07 17:00:46.541+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:534,0.910000,-0.490000,0.070000
06-07 17:00:46.541+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.541+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:502,2.395216,-0.488136,9.607183
06-07 17:00:46.541+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.541+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:546,2.332993,-0.517498,9.511031
06-07 17:00:46.551+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.551+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.561+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:562,2.336205,-0.520016,9.510106
06-07 17:00:46.561+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.561+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:570,2.333788,-0.518930,9.510758
06-07 17:00:46.571+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.581+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:582,2.334260,-0.518156,9.510685
06-07 17:00:46.581+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.591+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:549,0.140000,-0.280000,0.140000
06-07 17:00:46.591+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:594,2.332767,-0.516077,9.511165
06-07 17:00:46.591+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.591+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:555,2.390430,-0.586242,9.588040
06-07 17:00:46.591+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:555,0.044760,0.019429,0.064184
06-07 17:00:46.601+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.601+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.611+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:605,-0.140000,0.140000,0.280000
06-07 17:00:46.611+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.611+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:46.611+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:46:621,84
06-07 17:00:46.621+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:612,2.331242,-0.513615,9.511671
06-07 17:00:46.631+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:609,0.069863,0.004310,0.040514
06-07 17:00:46.631+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.631+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:46.631+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:46:639,785.000000
06-07 17:00:46.641+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.641+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.641+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:619,2.359323,-0.535992,9.528220
06-07 17:00:46.651+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:655,2.333449,-0.513345,9.511145
06-07 17:00:46.651+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:654,0.038232,0.008466,0.047788
06-07 17:00:46.651+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:645,0.140000,0.490000,0.350000
06-07 17:00:46.661+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.671+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.671+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:672,-0.280000,0.280000,0.560000
06-07 17:00:46.671+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.671+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:680,0.075355,-0.020110,0.050474
06-07 17:00:46.671+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:664,2.380858,-0.524028,9.609575
06-07 17:00:46.681+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.681+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.691+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:700,-0.700000,-0.070000,0.630000
06-07 17:00:46.691+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.691+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:685,2.334334,-0.512097,9.510995
06-07 17:00:46.701+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:691,2.407180,-0.492921,9.573684
06-07 17:00:46.701+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:708,0.086732,-0.055975,0.078251
06-07 17:00:46.701+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.711+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.711+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:715,0.042093,0.032100,0.028494
06-07 17:00:46.711+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.711+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:719,0.009021,0.053004,0.101811
06-07 17:00:46.711+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.711+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.721+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:712,2.333485,-0.511315,9.511246
06-07 17:00:46.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:724,0.078534,0.099249,0.007657
06-07 17:00:46.721+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.721+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:717,2.380858,-0.492921,9.566505
06-07 17:00:46.721+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:729,0.025158,0.156273,0.060205
06-07 17:00:46.721+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:724,0.280000,-0.070000,0.350000
06-07 17:00:46.721+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.731+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.731+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:733,2.340588,-0.510014,9.509570
06-07 17:00:46.731+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.731+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:738,0.035155,0.124251,-0.006606
06-07 17:00:46.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:735,0.700000,0.350000,0.350000
06-07 17:00:46.731+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.741+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:745,0.560000,-0.140000,-0.420000
06-07 17:00:46.741+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.741+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.741+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.741+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:742,2.368894,-0.507278,9.494720
06-07 17:00:46.751+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.751+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:753,0.079970,-0.140984,0.173012
06-07 17:00:46.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:750,0.140000,0.770000,0.070000
06-07 17:00:46.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.751+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:751,2.346057,-0.513063,9.508058
06-07 17:00:46.751+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:761,-0.910000,0.840000,0.700000
06-07 17:00:46.761+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.761+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.761+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:765,-2.940000,1.330000,1.890000
06-07 17:00:46.761+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.761+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.761+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:759,2.402394,-0.576670,9.504292
06-07 17:00:46.771+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.771+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:774,-0.036111,-0.426775,0.209092
06-07 17:00:46.771+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:770,-6.580000,1.050000,3.990000
06-07 17:00:46.771+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.771+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:769,2.342568,-0.514678,9.508831
06-07 17:00:46.771+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:780,-7.980000,-0.280000,2.520000
06-07 17:00:46.781+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.781+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:778,2.380858,-0.524028,9.583255
06-07 17:00:46.781+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.781+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:788,2.404787,-0.535992,9.580862
06-07 17:00:46.781+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.781+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.791+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:794,-2.590000,-0.420000,2.520000
06-07 17:00:46.791+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:793,0.028794,-0.335475,0.043633
06-07 17:00:46.791+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.791+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:787,2.338559,-0.512892,9.509914
06-07 17:00:46.791+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:798,2.371287,-0.512064,9.571291
06-07 17:00:46.791+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.801+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.801+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:802,2.340181,-0.490529,9.523434
06-07 17:00:46.801+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.801+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:806,2.340884,-0.509958,9.509500
06-07 17:00:46.801+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:806,2.354537,-0.502493,9.547362
06-07 17:00:46.801+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.801+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.801+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.811+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:813,-0.112263,-0.151276,0.032958
06-07 17:00:46.811+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:813,2.450000,0.560000,-1.680000
06-07 17:00:46.811+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.811+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:810,2.390430,-0.500100,9.561719
06-07 17:00:46.811+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.811+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:46.811+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:820,2.419144,-0.533599,9.611969
06-07 17:00:46.811+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.811+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:46:821,84
06-07 17:00:46.821+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:824,2.483750,-0.473779,9.470792
06-07 17:00:46.821+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.821+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:829,2.426322,-0.562313,9.595219
06-07 17:00:46.821+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.821+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:819,2.342103,-0.509196,9.509241
06-07 17:00:46.821+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.831+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:833,2.366502,-0.588634,9.556933
06-07 17:00:46.831+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.831+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.831+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.831+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 17:00:46.831+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:839,-0.216100,-0.054000,0.048175
06-07 17:00:46.841+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:837,2.337788,-0.516850,9.571291
06-07 17:00:46.841+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.841+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:839,3.570000,0.560000,-1.820000
06-07 17:00:46.841+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,17:00:46:840,780.000000
06-07 17:00:46.841+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:847,2.407180,-0.457029,9.537791
06-07 17:00:46.841+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.841+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.851+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:853,2.800000,-1.120000,-1.960000
06-07 17:00:46.851+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:853,-0.011603,0.002967,0.113332
06-07 17:00:46.851+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.851+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:835,2.342626,-0.508566,9.509146
06-07 17:00:46.851+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:858,2.385644,-0.490529,9.573684
06-07 17:00:46.851+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.851+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.851+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:862,2.411965,-0.504886,9.549755
06-07 17:00:46.861+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.861+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:866,2.380858,-0.500100,9.556933
06-07 17:00:46.861+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:866,2.343788,-0.508703,9.508852
06-07 17:00:46.861+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.861+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.861+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.871+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:873,0.159997,0.116144,0.084402
06-07 17:00:46.871+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:873,2.660000,-0.560000,-2.170000
06-07 17:00:46.871+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.871+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:870,2.419144,-0.528814,9.559326
06-07 17:00:46.871+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.871+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:880,2.349161,-0.511124,9.507396
06-07 17:00:46.871+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:880,2.435893,-0.567099,9.585647
06-07 17:00:46.871+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.881+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:884,2.392823,-0.480957,9.535398
06-07 17:00:46.881+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.881+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.881+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:888,2.356930,-0.457029,9.609575
06-07 17:00:46.881+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.881+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.881+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.891+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:894,0.051619,0.109305,0.040226
06-07 17:00:46.891+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:894,2.520000,-0.280000,-1.960000
06-07 17:00:46.891+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:893,2.423929,-0.406780,9.516255
06-07 17:00:46.891+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.901+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:893,2.350729,-0.513057,9.506905
06-07 17:00:46.901+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:902,2.371287,-0.344566,9.568897
06-07 17:00:46.901+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.901+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.901+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:907,2.383251,-0.370888,9.501899
06-07 17:00:46.901+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.901+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.901+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.911+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:913,-0.061887,0.174919,-0.074395
06-07 17:00:46.911+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:913,0.770000,0.630000,-1.050000
06-07 17:00:46.911+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:907,2.347909,-0.510033,9.507764
06-07 17:00:46.911+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:911,2.438286,-0.636491,9.678967
06-07 17:00:46.911+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.911+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.921+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:922,2.345395,-0.506029,9.508598
06-07 17:00:46.921+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.921+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:928,2.346129,-0.500840,9.508692
06-07 17:00:46.921+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.931+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:921,2.347359,-0.942772,9.707682
06-07 17:00:46.931+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.931+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.931+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.941+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:938,0.280000,0.070000,-0.630000
06-07 17:00:46.941+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:940,-0.059199,0.021088,0.045797
06-07 17:00:46.941+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:936,2.440679,-0.887737,9.533006
06-07 17:00:46.941+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.941+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:933,2.348097,-0.495138,9.508505
06-07 17:00:46.941+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.941+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.941+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.951+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:949,2.309074,-0.725025,9.518648
06-07 17:00:46.951+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.951+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:954,0.037905,0.004879,0.130898
06-07 17:00:46.951+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:955,0.630000,0.350000,-0.490000
06-07 17:00:46.961+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:951,2.358317,-0.495507,9.505956
06-07 17:00:46.961+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.961+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:958,2.189433,-0.629312,9.537791
06-07 17:00:46.961+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.961+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:968,2.383470,-0.515997,9.498590
06-07 17:00:46.961+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.961+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.971+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:975,-0.070000,0.490000,-0.280000
06-07 17:00:46.971+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:974,0.098041,0.007581,0.029613
06-07 17:00:46.971+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.981+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:983,2.411885,-0.552262,9.489373
06-07 17:00:46.981+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.981+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:971,2.368894,-0.567099,9.609575
06-07 17:00:46.981+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.981+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:989,2.421337,-0.573749,9.485690
06-07 17:00:46.981+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:990,2.531606,-0.447458,9.583255
06-07 17:00:46.981+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:46.981+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:46.991+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:46.991+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:46.991+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:46:996,-1.120000,1.050000,0.140000
06-07 17:00:47.001+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:46:994,2.421536,-0.442672,9.540184
06-07 17:00:47.011+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:46:994,2.405533,-0.575312,9.489616
06-07 17:00:47.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope - capturing data
06-07 17:00:47.011+0200 I/gyroscope(14345): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:00:47:17,-1.470000,1.260000,0.560000
06-07 17:00:47.011+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:00:47.011+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:00:47:21,84
06-07 17:00:47.021+0200 I/gravity (14311): es.ugr.frailty.gravity - capturing data
06-07 17:00:47.021+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer - capturing data
06-07 17:00:47.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:00:46:996,0.156675,-0.045584,-0.058064
06-07 17:00:47.021+0200 I/linearacceleration(14354): es.ugr.frailty.linearacceleration - capturing data
06-07 17:00:47.031+0200 I/gravity (14311): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:00:47:35,2.380497,-0.570066,9.496243
06-07 17:00:47.031+0200 I/accelerometer(14280): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:00:47:39,2.301895,-0.366102,9.427721
06-07 17:00:47.041+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11142896c6f63152838364
