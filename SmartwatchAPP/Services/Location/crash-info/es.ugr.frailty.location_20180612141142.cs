S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10966
Date: 2018-06-12 14:11:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76aa52d, r5   = 0xf7787150
r6   = 0xfff7c440, r7   = 0xfff7c2f0
r8   = 0xf7799c18, r9   = 0x00000000
r10  = 0xfff7c3cc, fp   = 0xfff7c440
ip   = 0x00000001, sp   = 0xfff7c2c8
lr   = 0xf76aa539, pc   = 0xf7713228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    170632 KB
Buffers:     31784 KB
Cached:     142344 KB
VmPeak:      53476 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11856 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10966 TID = 10966
10966 10969 

Maps Information
f4575000 f4d74000 rw-p [stack:10969]
f4d7b000 f4d7d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d85000 f4d89000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d92000 f4d94000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d9c000 f4d9f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dae000 f4db3000 r-xp /usr/lib/libsystem.so.0.0.0
f4dbe000 f4dc1000 r-xp /lib/libattr.so.1.1.0
f4dc9000 f4dd9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4de1000 f4dea000 r-xp /usr/lib/libedbus.so.1.7.99
f4df2000 f4df3000 r-xp /usr/lib/libresponse.so.0.2.96
f4dfc000 f4e01000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66a3000 f67a9000 r-xp /usr/lib/libicuuc.so.57.1
f67bf000 f6947000 r-xp /usr/lib/libicui18n.so.57.1
f6957000 f6964000 r-xp /usr/lib/libail.so.0.1.0
f696d000 f6974000 r-xp /usr/lib/libminizip.so.1.0.0
f697d000 f6b26000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b46000 f6b8d000 r-xp /usr/lib/libssl.so.1.0.0
f6b99000 f6b9b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ba3000 f6baa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bb3000 f6bba000 r-xp /lib/libcrypt-2.13.so
f6beb000 f6bee000 r-xp /lib/libcap.so.2.21
f6bf6000 f6bf8000 r-xp /usr/lib/libiri.so
f6c00000 f6c49000 r-xp /usr/lib/libmdm.so.1.2.69
f6c51000 f6c57000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c5f000 f6c82000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c8c000 f6c8e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c96000 f6cb3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cbc000 f6cc0000 r-xp /usr/lib/libsmack.so.1.0.0
f6cc9000 f6ce2000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ceb000 f6cf3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cfb000 f6d01000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d0a000 f6d0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d15000 f6d25000 r-xp /lib/libresolv-2.13.so
f6d29000 f6d41000 r-xp /usr/lib/liblzma.so.5.0.3
f6d4a000 f6d4c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d54000 f6d6e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d76000 f6da5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dae000 f6dbd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6dc7000 f6dd1000 r-xp /usr/lib/libsensord-shared.so
f6dda000 f6ead000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6eb8000 f6ece000 r-xp /lib/libz.so.1.2.5
f6ed6000 f6edb000 r-xp /usr/lib/libffi.so.5.0.10
f6ee3000 f6ee4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eec000 f6efc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f04000 f6f1d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f25000 f6f27000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f2f000 f6fa4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fae000 f6fb4000 r-xp /lib/librt-2.13.so
f6fbd000 f6fdb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fe5000 f6fe6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fee000 f7011000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7019000 f701e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7026000 f7050000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7059000 f7070000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7078000 f70e1000 r-xp /lib/libm-2.13.so
f70ea000 f717e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7191000 f7196000 r-xp /usr/lib/libctx-client.so.0.8.3
f719e000 f71a5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ad000 f71d7000 r-xp /usr/lib/libsensor.so.1.9.6
f71e0000 f72ac000 r-xp /usr/lib/libxml2.so.2.7.8
f72b9000 f72bb000 r-xp /usr/lib/libiniparser.so.0
f72c4000 f72ca000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72d3000 f73a3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73a4000 f73d8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73e1000 f741d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7425000 f7428000 r-xp /usr/lib/libbundle.so.0.1.22
f7430000 f7436000 r-xp /usr/lib/libappsvc.so.0.1.0
f743e000 f747f000 r-xp /usr/lib/libeina.so.1.7.99
f7488000 f749f000 r-xp /usr/lib/libecore.so.1.7.99
f74b6000 f74bf000 r-xp /usr/lib/libvconf.so.0.2.45
f74c7000 f74db000 r-xp /lib/libpthread-2.13.so
f74e6000 f74f3000 r-xp /usr/lib/libaul.so.0.1.0
f74fd000 f74ff000 r-xp /lib/libdl-2.13.so
f7508000 f7513000 r-xp /lib/libunwind.so.8.0.1
f7540000 f7548000 r-xp /lib/libgcc_s-4.6.so.1
f7549000 f766d000 r-xp /lib/libc-2.13.so
f767b000 f767d000 r-xp /usr/lib/libdlog.so.0.0.0
f7685000 f7691000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f769a000 f769f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76a7000 f76b6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76be000 f76c2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76cb000 f76ce000 r-xp /usr/lib/libappcore-agent.so.1.1
f76d6000 f76d8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76e0000 f76e4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76ec000 f7709000 r-xp /lib/ld-2.13.so
f7712000 f7715000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7715000 f7719000 r-xp /usr/lib/libsys-assert.so
f7769000 f77d7000 rw-p [heap]
fff5d000 fff7e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10966)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7713228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76aa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73b13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73afc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73bbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73c1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73c1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73f675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73f11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73afc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73bbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73c1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73c1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73f3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73f4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73fbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d931fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d86171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e59663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7306fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73087a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7498ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7493b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74945a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7494879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76cc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76cc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77135c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf756085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7712f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:11:40.921+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:40.921+0200 I/AUL     ( 9545): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:11:40.921+0200 E/LOCATION( 9545): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 14:11:40.931+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:11:40.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:40.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:40.941+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:40:911,0.144399,0.014265,9.805576
06-12 14:11:40.941+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:40.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:40.961+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:40.961+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:40.961+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:40.961+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:40.961+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:40.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:40.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:40.981+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:11:40.991+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:40.991+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10971
06-12 14:11:40.991+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:40:970,-0.027092,0.084444,-0.159318
06-12 14:11:40.991+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.021+0200 W/LOCATION(10966): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 14:11:41.021+0200 I/LOCATION(10966): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 14:11:41.021+0200 I/LOCATION(10966): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 14:11:41.021+0200 I/location(10966): es.ugr.frailty.location:iniciado servicio de localización
06-12 14:11:41.041+0200 E/CAPI_APPFW_APPLICATION(10971): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:41.041+0200 E/CAPI_APPFW_APPLICATION(10971): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:41.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10971
06-12 14:11:41.041+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(10971) type(svcapp) bg(0)
06-12 14:11:41.041+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10971]
06-12 14:11:41.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.061+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10971)
06-12 14:11:41.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.061+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pressure
06-12 14:11:41.061+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:41.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:41.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.081+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:41.081+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:41.081+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.081+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.081+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:41.081+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:41:88,-0.140000,-0.280000,-0.070000
06-12 14:11:41.081+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.091+0200 I/servicemanager( 9467): es.ugr.frailty.light alive timeout
06-12 14:11:41.091+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 14:11:41.091+0200 I/utils   (10971): trying to start service: es.ugr.frailty.pressure
06-12 14:11:41.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:41.111+0200 I/utils   (10971): es.ugr.frailty.pressure sensor supported
06-12 14:11:41.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.121+0200 I/utils   (10971): es.ugr.frailty.pressure listener started
06-12 14:11:41.131+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.141+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:11:41.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:11:41.141+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:11:41.141+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:41.141+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:41:147,0.090927,0.026321,9.896714
06-12 14:11:41.151+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9474) cmd(0)
06-12 14:11:41.151+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10971) was created
06-12 14:11:41.161+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:41.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.181+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.181+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.181+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:41.191+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:41:192,0.151912,0.018322,9.805456
06-12 14:11:41.191+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.191+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:41.221+0200 I/LOCATION(10966): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:11:41.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.241+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.241+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.241+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:41.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:41.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10971
06-12 14:11:41.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.271+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:41:252,0.024520,0.025282,0.075163
06-12 14:11:41.271+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.281+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:41.281+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:41.281+0200 I/location(10966): es.ugr.frailty.location: waiting for rigth values
06-12 14:11:41.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:41.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10971
06-12 14:11:41.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:41.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.341+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.341+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.341+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:41.341+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:41:348,-0.140000,-0.280000,-0.070000
06-12 14:11:41.341+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.361+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:41.371+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:41.371+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10985
06-12 14:11:41.421+0200 E/CAPI_APPFW_APPLICATION(10985): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:41.421+0200 E/CAPI_APPFW_APPLICATION(10985): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:41.421+0200 I/utils   (10985): trying to start service: es.ugr.frailty.light
06-12 14:11:41.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10985
06-12 14:11:41.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(10985) type(svcapp) bg(0)
06-12 14:11:41.421+0200 I/utils   (10985): es.ugr.frailty.light sensor supported
06-12 14:11:41.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.431+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10985)
06-12 14:11:41.431+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.light
06-12 14:11:41.431+0200 I/servicemanager( 9467): es.ugr.frailty.accelerometer sleep timeout
06-12 14:11:41.431+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-12 14:11:41.431+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10985]
06-12 14:11:41.441+0200 I/utils   (10985): es.ugr.frailty.light listener started
06-12 14:11:41.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:41.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9477) cmd(0)
06-12 14:11:41.501+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.501+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:41.501+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10985) was created
06-12 14:11:41.501+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.501+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:41.501+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:41.501+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:41:509,0.119641,0.117248,9.853643
06-12 14:11:41.511+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:41.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.531+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.531+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.531+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:41.541+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.541+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:41:541,0.155905,0.019985,9.805390
06-12 14:11:41.541+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:41.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:41.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.591+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.591+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.591+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:41.591+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:41:599,0.008070,0.002448,-0.085112
06-12 14:11:41.601+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.601+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:41.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:41.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.651+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.651+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.651+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:41.661+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:41:662,0.070000,-0.140000,-0.070000
06-12 14:11:41.661+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:41.671+0200 I/light   (10985): es.ugr.frailty.light - capturing data
06-12 14:11:41.681+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:41.681+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:41.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9474
06-12 14:11:41.681+0200 I/light   (10985): es.ugr.frailty.light: SM-R760,12/06/2018,14:11:41:680,56.000000
06-12 14:11:41.681+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.691+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9474)
06-12 14:11:41.691+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.accelerometer
06-12 14:11:41.691+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:41.691+0200 I/servicemanager( 9467): es.ugr.frailty.pedometer alive timeout
06-12 14:11:41.691+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:11:41.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:41.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.731+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.731+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.731+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:41.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:41.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.791+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.791+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:41:736,0.141177,0.114855,9.700503
06-12 14:11:41.791+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.791+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.791+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:41.801+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:41:799,0.158837,0.021035,9.805341
06-12 14:11:41.801+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.801+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:41.831+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10985
06-12 14:11:41.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:41.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:41.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10985
06-12 14:11:41.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9514) cmd(0)
06-12 14:11:41.901+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.901+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.901+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:41.901+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:41.901+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:41.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:41.931+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:11:41.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.941+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:41:912,-0.031660,-0.000251,-0.006119
06-12 14:11:41.941+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.951+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.951+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.951+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:41.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.951+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:41:955,0.070000,-0.280000,-0.070000
06-12 14:11:41.951+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:41.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:41.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10985
06-12 14:11:41.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:41.991+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:41.991+0200 I/light   (10985): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:41.991+0200 I/light   (10985): es.ugr.frailty.light - capturing data
06-12 14:11:41.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:41.991+0200 I/light   (10985): es.ugr.frailty.light: SM-R760,12/06/2018,14:11:41:996,56.000000
06-12 14:11:41.991+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:42.031+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:42.031+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11001
06-12 14:11:42.081+0200 E/CAPI_APPFW_APPLICATION(11001): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:42.081+0200 E/CAPI_APPFW_APPLICATION(11001): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:42.081+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:42.081+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:42.081+0200 I/utils   (11001): trying to start service: es.ugr.frailty.pedometer
06-12 14:11:42.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11001
06-12 14:11:42.081+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(11001) type(svcapp) bg(0)
06-12 14:11:42.081+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11001)
06-12 14:11:42.081+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:11:42.081+0200 I/servicemanager( 9467): es.ugr.frailty.gyroscope sleep timeout
06-12 14:11:42.081+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-12 14:11:42.081+0200 I/utils   (11001): es.ugr.frailty.pedometer sensor supported
06-12 14:11:42.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.091+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11001]
06-12 14:11:42.101+0200 I/utils   (11001): es.ugr.frailty.pedometer listener started
06-12 14:11:42.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:42.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:11:42.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:11:42.141+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:11:42.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.171+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.171+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.171+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:42.181+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:42:180,0.164534,0.029034,9.805226
06-12 14:11:42.181+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.181+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11001) was created
06-12 14:11:42.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:42.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.221+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.221+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.221+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:42.231+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:42:233,0.179462,0.002393,9.920642
06-12 14:11:42.231+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:42.251+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:42.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.291+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:42.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:42.291+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:42.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.311+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.311+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.311+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:42.331+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:42:319,-0.136367,-0.057872,0.065655
06-12 14:11:42.331+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:42.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.351+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.351+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.351+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:42.361+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:42:362,0.070000,-0.280000,-0.070000
06-12 14:11:42.361+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(10554) cmd(0)
06-12 14:11:42.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10985
06-12 14:11:42.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.401+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.401+0200 I/light   (10985): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.401+0200 I/light   (10985): es.ugr.frailty.light - capturing data
06-12 14:11:42.401+0200 I/light   (10985): es.ugr.frailty.light: SM-R760,12/06/2018,14:11:42:409,56.000000
06-12 14:11:42.401+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:42.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9477
06-12 14:11:42.451+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9477)
06-12 14:11:42.451+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gyroscope
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.451+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.461+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.461+0200 I/utils   ( 9467): specific action
06-12 14:11:42.461+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.461+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:11:42.461+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:11:42.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:42.481+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:42.481+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:42.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.491+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.491+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.491+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:42.501+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.501+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:42:504,0.164196,0.029888,9.805230
06-12 14:11:42.501+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:42.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.541+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.541+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.541+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:42.551+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:42:552,0.114855,-0.014357,9.865608
06-12 14:11:42.551+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:42.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11001
06-12 14:11:42.571+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:42.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.621+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.621+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.621+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:42.621+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.631+0200 W/LOCATION(10966): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:11:42.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:42.651+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:42:631,-0.008102,-0.018050,0.044222
06-12 14:11:42.651+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.651+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11001
06-12 14:11:42.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:42.681+0200 I/heartrate(10953): es.ugr.frailty.heartrate - capturing data
06-12 14:11:42.681+0200 I/heartrate(10953): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:42.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.701+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.701+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.701+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:42.701+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:42:708,-0.070000,-0.210000,-0.070000
06-12 14:11:42.701+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10985
06-12 14:11:42.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.741+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.741+0200 W/AUL     (10985): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.741+0200 I/light   (10985): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.741+0200 I/light   (10985): es.ugr.frailty.light - capturing data
06-12 14:11:42.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:42.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:11:42.771+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.771+0200 I/utils   ( 9470): specific action
06-12 14:11:42.771+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.771+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.771+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:11:42.771+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:11:42.781+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:11:42.781+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:11:42.781+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:11:42.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:42.781+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.781+0200 I/utils   ( 9467): specific action
06-12 14:11:42.781+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.781+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.781+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.781+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:42.781+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:11:42.781+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:11:42.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:42.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.821+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:42.821+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:42.831+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:42.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:42.831+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:11:42.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(83) , send fd(15), pid(9470), cmd(0)
06-12 14:11:42.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:42.851+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:42:834,0.165242,0.029851,9.805212
06-12 14:11:42.851+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:42.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:42.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:42.861+0200 W/CRASH_MANAGER(10805): worker.c: worker_job(1205) > 11109666c6f63152880550
