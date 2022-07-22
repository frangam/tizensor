S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11162
Date: 2018-06-12 14:12:00+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf703c52d, r5   = 0xf7407150
r6   = 0xff94f6f0, r7   = 0xff94f5a0
r8   = 0xf7419c18, r9   = 0x00000000
r10  = 0xff94f67c, fp   = 0xff94f6f0
ip   = 0x00000001, sp   = 0xff94f578
lr   = 0xf703c539, pc   = 0xf70a5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    169444 KB
Buffers:     31900 KB
Cached:     142944 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11744 KB
VmRSS:       11744 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11162 TID = 11162
11162 11165 

Maps Information
f3f07000 f4706000 rw-p [stack:11165]
f470d000 f470f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4717000 f471b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4724000 f4726000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f472e000 f4731000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4740000 f4745000 r-xp /usr/lib/libsystem.so.0.0.0
f4750000 f4753000 r-xp /lib/libattr.so.1.1.0
f475b000 f476b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4773000 f477c000 r-xp /usr/lib/libedbus.so.1.7.99
f4784000 f4785000 r-xp /usr/lib/libresponse.so.0.2.96
f478e000 f4793000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6035000 f613b000 r-xp /usr/lib/libicuuc.so.57.1
f6151000 f62d9000 r-xp /usr/lib/libicui18n.so.57.1
f62e9000 f62f6000 r-xp /usr/lib/libail.so.0.1.0
f62ff000 f6306000 r-xp /usr/lib/libminizip.so.1.0.0
f630f000 f64b8000 r-xp /usr/lib/libcrypto.so.1.0.0
f64d8000 f651f000 r-xp /usr/lib/libssl.so.1.0.0
f652b000 f652d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6535000 f653c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6545000 f654c000 r-xp /lib/libcrypt-2.13.so
f657d000 f6580000 r-xp /lib/libcap.so.2.21
f6588000 f658a000 r-xp /usr/lib/libiri.so
f6592000 f65db000 r-xp /usr/lib/libmdm.so.1.2.69
f65e3000 f65e9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65f1000 f6614000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f661e000 f6620000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6628000 f6645000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f664e000 f6652000 r-xp /usr/lib/libsmack.so.1.0.0
f665b000 f6674000 r-xp /usr/lib/libnetwork.so.0.0.0
f667d000 f6685000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f668d000 f6693000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f669c000 f669e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66a7000 f66b7000 r-xp /lib/libresolv-2.13.so
f66bb000 f66d3000 r-xp /usr/lib/liblzma.so.5.0.3
f66dc000 f66de000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66e6000 f6700000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6708000 f6737000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6740000 f674f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6759000 f6763000 r-xp /usr/lib/libsensord-shared.so
f676c000 f683f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f684a000 f6860000 r-xp /lib/libz.so.1.2.5
f6868000 f686d000 r-xp /usr/lib/libffi.so.5.0.10
f6875000 f6876000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f687e000 f688e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6896000 f68af000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68b7000 f68b9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68c1000 f6936000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6940000 f6946000 r-xp /lib/librt-2.13.so
f694f000 f696d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6977000 f6978000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6980000 f69a3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69ab000 f69b0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69b8000 f69e2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69eb000 f6a02000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a0a000 f6a73000 r-xp /lib/libm-2.13.so
f6a7c000 f6b10000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b23000 f6b28000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b30000 f6b37000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b3f000 f6b69000 r-xp /usr/lib/libsensor.so.1.9.6
f6b72000 f6c3e000 r-xp /usr/lib/libxml2.so.2.7.8
f6c4b000 f6c4d000 r-xp /usr/lib/libiniparser.so.0
f6c56000 f6c5c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c65000 f6d35000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d36000 f6d6a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d73000 f6daf000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6db7000 f6dba000 r-xp /usr/lib/libbundle.so.0.1.22
f6dc2000 f6dc8000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dd0000 f6e11000 r-xp /usr/lib/libeina.so.1.7.99
f6e1a000 f6e31000 r-xp /usr/lib/libecore.so.1.7.99
f6e48000 f6e51000 r-xp /usr/lib/libvconf.so.0.2.45
f6e59000 f6e6d000 r-xp /lib/libpthread-2.13.so
f6e78000 f6e85000 r-xp /usr/lib/libaul.so.0.1.0
f6e8f000 f6e91000 r-xp /lib/libdl-2.13.so
f6e9a000 f6ea5000 r-xp /lib/libunwind.so.8.0.1
f6ed2000 f6eda000 r-xp /lib/libgcc_s-4.6.so.1
f6edb000 f6fff000 r-xp /lib/libc-2.13.so
f700d000 f700f000 r-xp /usr/lib/libdlog.so.0.0.0
f7017000 f7023000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f702c000 f7031000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7039000 f7048000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7050000 f7054000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f705d000 f7060000 r-xp /usr/lib/libappcore-agent.so.1.1
f7068000 f706a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7072000 f7076000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f707e000 f709b000 r-xp /lib/ld-2.13.so
f70a4000 f70a7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70a7000 f70ab000 r-xp /usr/lib/libsys-assert.so
f73e9000 f7457000 rw-p [heap]
ff930000 ff951000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11162)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70a5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf703c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d433f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d41c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d4de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d53be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d53dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d8875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d831f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d41c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d4de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d53be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d53dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d85e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d86017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d8df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47251fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4718171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67eb663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c98fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c9a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e2aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e25b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e265a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e26879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf705e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf705e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70a55c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ef285c) [/lib/libc.so.6] + 0x1785c
29: (0xf70a4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
tion_privacy_initialize(165) > Fail to get app_id. Err[-1]
06-12 14:11:59.261+0200 I/LOCATION( 9545): location.c: location_new(269) > method: 1
06-12 14:11:59.261+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 14:11:59.261+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (gps) open success
06-12 14:11:59.261+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 14:11:59.261+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 14:11:59.261+0200 W/LOCATION( 9545): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 14:11:59.261+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 14:11:59.261+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 14:11:59.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.271+0200 I/AUL     ( 9545): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:11:59.281+0200 I/AUL     ( 9545): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:11:59.281+0200 E/LOCATION( 9545): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 14:11:59.281+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:11:59.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:59.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.321+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.321+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.321+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:59.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.331+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.331+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.331+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:59.341+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gravity
06-12 14:11:59.341+0200 I/servicemanager( 9467): es.ugr.frailty.accelerometer sleep timeout
06-12 14:11:59.341+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-12 14:11:59.341+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:11:59.341+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:59.341+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:11:59.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:59.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.381+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.381+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.381+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:59.391+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:59:340,0.070000,-0.140000,-0.070000
06-12 14:11:59.391+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.401+0200 W/LOCATION(11162): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 14:11:59.401+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:59:392,0.212961,-0.076570,9.966106
06-12 14:11:59.401+0200 I/LOCATION(11162): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 14:11:59.401+0200 I/LOCATION(11162): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 14:11:59.401+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.401+0200 I/location(11162): es.ugr.frailty.location:iniciado servicio de localización
06-12 14:11:59.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:59.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9474
06-12 14:11:59.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.431+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9474)
06-12 14:11:59.431+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.accelerometer
06-12 14:11:59.431+0200 I/servicemanager( 9467): es.ugr.frailty.pressure alive timeout
06-12 14:11:59.431+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-12 14:11:59.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:59.461+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:59:324,-0.049127,-0.143326,-0.025574
06-12 14:11:59.461+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:59:145,0.162512,0.018759,9.805285
06-12 14:11:59.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.461+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.461+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.471+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.471+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.471+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:59.481+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:59:481,0.070000,-0.280000,-0.070000
06-12 14:11:59.481+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:59.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.511+0200 I/LOCATION(11162): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:11:59.521+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.521+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.521+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:59.521+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:59:527,0.169890,0.074178,9.760324
06-12 14:11:59.521+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.521+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.531+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:11:59.531+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:59.551+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:59.551+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11168
06-12 14:11:59.591+0200 I/location(11162): es.ugr.frailty.location: waiting for rigth values
06-12 14:11:59.591+0200 E/CAPI_APPFW_APPLICATION(11168): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:59.591+0200 E/CAPI_APPFW_APPLICATION(11168): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:59.601+0200 I/utils   (11168): trying to start service: es.ugr.frailty.pressure
06-12 14:11:59.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11168
06-12 14:11:59.601+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(11168) type(svcapp) bg(0)
06-12 14:11:59.601+0200 I/utils   (11168): es.ugr.frailty.pressure sensor supported
06-12 14:11:59.601+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11168]
06-12 14:11:59.631+0200 I/utils   (11168): es.ugr.frailty.pressure listener started
06-12 14:11:59.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:59.631+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11168)
06-12 14:11:59.631+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pressure
06-12 14:11:59.631+0200 I/servicemanager( 9467): es.ugr.frailty.light alive timeout
06-12 14:11:59.631+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 14:11:59.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9477) cmd(0)
06-12 14:11:59.661+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.661+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.661+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:59.671+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:59:671,-0.046082,0.038187,0.125139
06-12 14:11:59.671+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.671+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11168) was created
06-12 14:11:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:59.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.711+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.711+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.711+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:59.711+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:59:716,0.163913,0.018448,9.805263
06-12 14:11:59.711+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.721+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:11:59.721+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:59.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.731+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:59.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.751+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.751+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.751+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:59.761+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.761+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:59:760,0.070000,-0.210000,-0.070000
06-12 14:11:59.761+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:59.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.791+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.791+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.791+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:59.801+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:59:803,0.131605,0.052642,9.884750
06-12 14:11:59.801+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:59.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:59.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11168
06-12 14:11:59.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:59.841+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:59.841+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11181
06-12 14:11:59.881+0200 E/CAPI_APPFW_APPLICATION(11181): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:59.881+0200 E/CAPI_APPFW_APPLICATION(11181): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:59.891+0200 I/utils   (11181): trying to start service: es.ugr.frailty.light
06-12 14:11:59.891+0200 I/utils   (11181): es.ugr.frailty.light sensor supported
06-12 14:11:59.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11181
06-12 14:11:59.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(11181) type(svcapp) bg(0)
06-12 14:11:59.901+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11181)
06-12 14:11:59.901+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.light
06-12 14:11:59.901+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:59.901+0200 I/servicemanager( 9467): es.ugr.frailty.gyroscope sleep timeout
06-12 14:11:59.901+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-12 14:11:59.901+0200 I/utils   (11181): es.ugr.frailty.light listener started
06-12 14:11:59.911+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11181]
06-12 14:11:59.921+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:11:59.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:59.931+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:59.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11168
06-12 14:11:59.931+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.951+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11181) was created
06-12 14:11:59.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:59.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:59.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:59.981+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:59.981+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:59.981+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:59.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:59.991+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:59:992,0.001536,0.026469,0.225605
06-12 14:11:59.991+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:00.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.021+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.021+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.021+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:00.021+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:00:29,0.164398,0.020265,9.805251
06-12 14:12:00.021+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:00.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.061+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.061+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.061+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:00.071+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:00:72,0.070000,-0.350000,-0.140000
06-12 14:12:00.071+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.071+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.081+0200 I/light   (11181): es.ugr.frailty.light - capturing data
06-12 14:12:00.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:00.081+0200 I/light   (11181): es.ugr.frailty.light: SM-R760,12/06/2018,14:12:00:87,56.000000
06-12 14:12:00.091+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.111+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.121+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.121+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:00.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:12:00.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:12:00.121+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:12:00.131+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:00.131+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:00.131+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:00:124,0.150748,0.055035,10.018748
06-12 14:12:00.131+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.131+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:00.161+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:00.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9477
06-12 14:12:00.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9514) cmd(0)
06-12 14:12:00.221+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:12:00.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:00.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(10554) cmd(0)
06-12 14:12:00.241+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9477)
06-12 14:12:00.241+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gyroscope
06-12 14:12:00.241+0200 I/servicemanager( 9467): es.ugr.frailty.pedometer alive timeout
06-12 14:12:00.241+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:12:00.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.261+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:00.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.291+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.291+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.291+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:00.291+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:00:294,0.024554,0.001140,0.036593
06-12 14:12:00.291+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:00.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.321+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.321+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.321+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:00.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.321+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:00.321+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:00.331+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:00:329,0.161637,0.022125,9.805293
06-12 14:12:00.331+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:00.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.371+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.371+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.371+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:00.371+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:00:375,0.070000,-0.280000,-0.070000
06-12 14:12:00.371+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11181
06-12 14:12:00.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.411+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.411+0200 I/light   (11181): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.411+0200 I/light   (11181): es.ugr.frailty.light - capturing data
06-12 14:12:00.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.421+0200 I/light   (11181): es.ugr.frailty.light: SM-R760,12/06/2018,14:12:00:422,56.000000
06-12 14:12:00.421+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:00.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.451+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.451+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.451+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:00.461+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:00:460,0.129212,0.105284,9.860823
06-12 14:12:00.461+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:00.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11181
06-12 14:12:00.491+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:00.521+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:12:00.521+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11197
06-12 14:12:00.521+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:00.521+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:00.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11197
06-12 14:12:00.571+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(11197) type(svcapp) bg(0)
06-12 14:12:00.581+0200 E/CAPI_APPFW_APPLICATION(11197): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:00.581+0200 E/CAPI_APPFW_APPLICATION(11197): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:00.581+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11197]
06-12 14:12:00.581+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11197)
06-12 14:12:00.581+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:12:00.581+0200 I/utils   (11197): trying to start service: es.ugr.frailty.pedometer
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.581+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11181
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.611+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.621+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.621+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.621+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.621+0200 I/utils   (11197): es.ugr.frailty.pedometer sensor supported
06-12 14:12:00.621+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.621+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.631+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11197) was created
06-12 14:12:00.631+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.631+0200 I/utils   ( 9467): specific action
06-12 14:12:00.631+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.631+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:12:00.631+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:12:00.641+0200 I/utils   (11197): es.ugr.frailty.pedometer listener started
06-12 14:12:00.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:00.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.691+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.691+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.691+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:00.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:00.701+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:00:698,0.020989,0.001190,-0.169168
06-12 14:12:00.701+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.721+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.721+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.721+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:00.721+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:00:728,0.161113,0.020462,9.805305
06-12 14:12:00.721+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.731+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:00.731+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:00.731+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:00.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.761+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.761+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.761+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:00.771+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:00:768,0.070000,-0.280000,-0.070000
06-12 14:12:00.771+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11181
06-12 14:12:00.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.811+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.811+0200 I/light   (11181): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.811+0200 I/light   (11181): es.ugr.frailty.light - capturing data
06-12 14:12:00.811+0200 I/light   (11181): es.ugr.frailty.light: SM-R760,12/06/2018,14:12:00:815,56.000000
06-12 14:12:00.811+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:00.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.851+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.851+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:00.851+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:00.861+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:00:860,0.165105,0.043071,9.846465
06-12 14:12:00.861+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:00.871+0200 W/LOCATION(11162): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:12:00.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:00.891+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:00.921+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:00.931+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:00.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.931+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:00.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:00.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:12:00.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.941+0200 I/utils   ( 9470): specific action
06-12 14:12:00.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.941+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.941+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:12:00.941+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:12:00.951+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:12:00.951+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:12:00.951+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:12:00.951+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.951+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.951+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:00.951+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:00.951+0200 I/utils   ( 9467): specific action
06-12 14:12:00.951+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:12:00.951+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:12:00.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:00.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:00.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:00.991+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:00.991+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:01.001+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:01.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:01.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:12:01.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(9470), cmd(0)
06-12 14:12:01.001+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:01:7,-0.071457,0.051424,0.117997
06-12 14:12:01.001+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:01.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:01.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:01.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:01.041+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:01.041+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:01.041+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:01.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:01.051+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:01:49,0.159633,0.017348,9.805335
06-12 14:12:01.051+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:01.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:01.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:01.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:01.101+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:01.101+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:01.111+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:01.111+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:01:114,0.070000,-0.210000,0.070000
06-12 14:12:01.111+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:01.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:01.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 11181
06-12 14:12:01.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:12:01.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:12:01.131+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:12:01.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:01.151+0200 I/heartrate(11149): es.ugr.frailty.heartrate - capturing data
06-12 14:12:01.151+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:01.151+0200 I/light   (11181): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:01.151+0200 I/light   (11181): es.ugr.frailty.light - capturing data
06-12 14:12:01.161+0200 I/light   (11181): es.ugr.frailty.light: SM-R760,12/06/2018,14:12:01:161,56.000000
06-12 14:12:01.161+0200 W/AUL     (11181): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:01.161+0200 I/heartrate(11149): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:01.161+0200 W/CRASH_MANAGER(10805): worker.c: worker_job(1205) > 11111626c6f63152880552
