S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10710
Date: 2018-04-23 20:35:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf704652d, r5   = 0xf7402f98
r6   = 0xfff73f80, r7   = 0xfff73e30
r8   = 0xf73ffc18, r9   = 0x00000000
r10  = 0xfff73f0c, fp   = 0xfff73f80
ip   = 0x00000001, sp   = 0xfff73e08
lr   = 0xf7046539, pc   = 0xf70af228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    140184 KB
Buffers:     37484 KB
Cached:     157048 KB
VmPeak:      53460 KB
VmSize:      53400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11900 KB
VmRSS:       11896 KB
VmData:      11128 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10710 TID = 10710
10710 10713 

Maps Information
f3f11000 f4710000 rw-p [stack:10713]
f4717000 f4719000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4721000 f4725000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f472e000 f4730000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4738000 f473b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f474a000 f474f000 r-xp /usr/lib/libsystem.so.0.0.0
f475a000 f475d000 r-xp /lib/libattr.so.1.1.0
f4765000 f4775000 r-xp /usr/lib/libmdm-common.so.1.1.24
f477d000 f4786000 r-xp /usr/lib/libedbus.so.1.7.99
f478e000 f478f000 r-xp /usr/lib/libresponse.so.0.2.96
f4798000 f479d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f603f000 f6145000 r-xp /usr/lib/libicuuc.so.57.1
f615b000 f62e3000 r-xp /usr/lib/libicui18n.so.57.1
f62f3000 f6300000 r-xp /usr/lib/libail.so.0.1.0
f6309000 f6310000 r-xp /usr/lib/libminizip.so.1.0.0
f6319000 f64c2000 r-xp /usr/lib/libcrypto.so.1.0.0
f64e2000 f6529000 r-xp /usr/lib/libssl.so.1.0.0
f6535000 f6537000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f653f000 f6546000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f654f000 f6556000 r-xp /lib/libcrypt-2.13.so
f6587000 f658a000 r-xp /lib/libcap.so.2.21
f6592000 f6594000 r-xp /usr/lib/libiri.so
f659c000 f65e5000 r-xp /usr/lib/libmdm.so.1.2.69
f65ed000 f65f3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65fb000 f661e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6628000 f662a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6632000 f664f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6658000 f665c000 r-xp /usr/lib/libsmack.so.1.0.0
f6665000 f667e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6687000 f668f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6697000 f669d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66a6000 f66a8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66b1000 f66c1000 r-xp /lib/libresolv-2.13.so
f66c5000 f66dd000 r-xp /usr/lib/liblzma.so.5.0.3
f66e6000 f66e8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66f0000 f670a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6712000 f6741000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f674a000 f6759000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6763000 f676d000 r-xp /usr/lib/libsensord-shared.so
f6776000 f6849000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6854000 f686a000 r-xp /lib/libz.so.1.2.5
f6872000 f6877000 r-xp /usr/lib/libffi.so.5.0.10
f687f000 f6880000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6888000 f6898000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68a0000 f68b9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68c1000 f68c3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68cb000 f6940000 r-xp /usr/lib/libsqlite3.so.0.8.6
f694a000 f6950000 r-xp /lib/librt-2.13.so
f6959000 f6977000 r-xp /usr/lib/libsystemd.so.0.4.0
f6981000 f6982000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f698a000 f69ad000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69b5000 f69ba000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69c2000 f69ec000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69f5000 f6a0c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a14000 f6a7d000 r-xp /lib/libm-2.13.so
f6a86000 f6b1a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b2d000 f6b32000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b3a000 f6b41000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b49000 f6b73000 r-xp /usr/lib/libsensor.so.1.9.6
f6b7c000 f6c48000 r-xp /usr/lib/libxml2.so.2.7.8
f6c55000 f6c57000 r-xp /usr/lib/libiniparser.so.0
f6c60000 f6c66000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c6f000 f6d3f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d40000 f6d74000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d7d000 f6db9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dc1000 f6dc4000 r-xp /usr/lib/libbundle.so.0.1.22
f6dcc000 f6dd2000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dda000 f6e1b000 r-xp /usr/lib/libeina.so.1.7.99
f6e24000 f6e3b000 r-xp /usr/lib/libecore.so.1.7.99
f6e52000 f6e5b000 r-xp /usr/lib/libvconf.so.0.2.45
f6e63000 f6e77000 r-xp /lib/libpthread-2.13.so
f6e82000 f6e8f000 r-xp /usr/lib/libaul.so.0.1.0
f6e99000 f6e9b000 r-xp /lib/libdl-2.13.so
f6ea4000 f6eaf000 r-xp /lib/libunwind.so.8.0.1
f6edc000 f6ee4000 r-xp /lib/libgcc_s-4.6.so.1
f6ee5000 f7009000 r-xp /lib/libc-2.13.so
f7017000 f7019000 r-xp /usr/lib/libdlog.so.0.0.0
f7021000 f702d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7036000 f703b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7043000 f7052000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f705a000 f705e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7067000 f706a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7072000 f7074000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f707c000 f7080000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7088000 f70a5000 r-xp /lib/ld-2.13.so
f70ae000 f70b1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70b1000 f70b5000 r-xp /usr/lib/libsys-assert.so
f73cf000 f7432000 rw-p [heap]
fff55000 fff76000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10710)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70af228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7046539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d4d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d4bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d57e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d5dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d5ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d9275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d8d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d4bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d57e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d5dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d5ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d8fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d90017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d97f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf472f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4722171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67f5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ca2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ca47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e34ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e2fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e305a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e30879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7068183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70687fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70af53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf6efc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70aef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 open success
04-23 20:35:14.179+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:14.179+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:14.179+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:14.179+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:14.179+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:14.179+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.189+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.189+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:14.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:14.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:14.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:14.289+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:14.289+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:14.289+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:14.289+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c25d00
04-23 20:35:14.339+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1c2c0]
04-23 20:35:14.339+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:14.339+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:14.339+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:14.339+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:14.349+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:14.349+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:14.349+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.359+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.359+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:14.359+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:14.359+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:14.359+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:14.359+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:14.359+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:14.359+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:14.359+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:14.359+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:14.369+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.379+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:14.379+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:14.379+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:14.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:14.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:14.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:14.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:14.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1c2c0
04-23 20:35:14.559+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:35:14.559+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:14.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:14.559+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:14.579+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10662
04-23 20:35:14.579+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:14.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10662
04-23 20:35:14.629+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10662) type(svcapp) bg(0)
04-23 20:35:14.629+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10662)
04-23 20:35:14.639+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10662]
04-23 20:35:14.639+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:35:14.639+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:14.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:14.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10662
04-23 20:35:14.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:14.689+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10662
04-23 20:35:14.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:14.689+0200 E/CAPI_APPFW_APPLICATION(10662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:14.689+0200 E/CAPI_APPFW_APPLICATION(10662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:14.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:14.689+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10662) was created
04-23 20:35:14.719+0200 W/LOCATION(10662): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:14.719+0200 E/LOCATION(10662): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:14.719+0200 E/PKGMGR_INFO(10662): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:14.729+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:14.749+0200 I/LOCATION(10662): location.c: location_new(269) > method: 0
04-23 20:35:14.749+0200 W/LOCATION(10662): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:14.749+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:14.759+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:14.759+0200 W/LOCATION(10662): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:14.769+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:14.769+0200 W/LOCATION(10662): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:14.769+0200 W/LOCATION(10662): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:14.769+0200 W/LOCATION(10662): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:14.769+0200 W/LOCATION(10662): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:14.799+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:14.799+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:14.809+0200 W/LOCATION(10662): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:14.809+0200 W/LOCATION(10662): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:14.809+0200 W/LOCATION(10662): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:14.819+0200 W/LOCATION(10662): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:14.819+0200 W/LOCATION(10662): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:14.839+0200 W/LOCATION(10662): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:14.839+0200 I/LOCATION(10662): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf764dc18
04-23 20:35:14.839+0200 I/LOCATION(10662): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:14.839+0200 I/LOCATION(10662): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf764dc18
04-23 20:35:14.839+0200 I/LOCATION(10662): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:14.839+0200 I/location(10662): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:14.879+0200 I/LOCATION(10662): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:14.919+0200 W/LOCATION(10662): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:14.919+0200 W/LOCATION(10662): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:14.919+0200 I/LOCATION(10662): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:14.989+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:14.989+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:14.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:14.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:14.989+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:14.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:14.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:14.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:14.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:14.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:14.999+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:14.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:14.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:15.049+0200 W/LOCATION(10662): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:15.049+0200 W/LOCATION(10662): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:15.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:15.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:15.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:15.159+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c24a38]
04-23 20:35:15.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:15.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:15.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:15.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:15.199+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.199+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.209+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.219+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.219+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:15.219+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:15.219+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.219+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:15.219+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:15.219+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:15.219+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.219+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:15.219+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:15.229+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.229+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:15.229+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2590493), time2(2587328)
04-23 20:35:15.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:35:15.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:15.229+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:15.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:15.239+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.239+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:15.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.299+0200 W/LOCATION(10662): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:15.299+0200 I/LOCATION(10662): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:15.299+0200 I/LOCATION(10662): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:15.299+0200 I/location(10662): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:15.389+0200 I/LOCATION(10662): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:15.429+0200 W/AUL     (10662): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:15.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:15.439+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10662
04-23 20:35:15.439+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:15.449+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:15.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:15.449+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.449+0200 I/utils   (10115): specific action
04-23 20:35:15.449+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.449+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.449+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.449+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:15.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:15.449+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:15.459+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:15.459+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:15.459+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:15.459+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:15.459+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.459+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:15.459+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:15.459+0200 I/utils   (10120): specific action
04-23 20:35:15.459+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.459+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.459+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.459+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:15.459+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:15.459+0200 I/recorder(10120): guardando datos en local
04-23 20:35:15.459+0200 W/AUL     (10662): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:15.459+0200 I/location(10662): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:15.459+0200 I/location(10662): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:15:437,nan,37.171550,-3.593163,0.000000,0,0.000000,100.000000,-1.000000
04-23 20:35:15.459+0200 I/location(10662): stopping es.ugr.frailty.location service
04-23 20:35:15.459+0200 E/CAPI_APPFW_APP_CONTROL(10662): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:35:15.459+0200 E/location(10662): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:35:15.459+0200 I/CAPI_APPFW_APPLICATION(10662): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:35:15.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:35:15.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:35:15.509+0200 W/LOCATION(10662): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:15.509+0200 I/LOCATION(10662): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:15.509+0200 I/LOCATION(10662): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:35:15.579+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:35:15.579+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:35:15.579+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:35:15.579+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:35:15.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.719+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:15.719+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:15.719+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:15.719+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c24a38
04-23 20:35:15.779+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c16060]
04-23 20:35:15.779+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:15.779+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:15.779+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:15.779+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:15.789+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.789+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.799+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.799+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.799+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:15.809+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:15.809+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.809+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:15.809+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:15.809+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:15.809+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.809+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:15.809+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:15.809+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.819+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.819+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:15.819+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:15.919+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:15.919+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:15.919+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:15.919+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c16060
04-23 20:35:15.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1c2a0]
04-23 20:35:15.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:15.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:15.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:15.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:15.979+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.979+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.989+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.989+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:15.989+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:15.989+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:15.989+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:15.989+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:15.989+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:15.989+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:15.989+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:15.989+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:15.989+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:15.999+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:16.009+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:16.009+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:16.009+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:16.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:16.059+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:16.059+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:16.059+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:16.059+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1c2a0
04-23 20:35:16.259+0200 W/AUL     (10674): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:35:16.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:35:16.259+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:35:16.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10638
04-23 20:35:16.259+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:35:16.269+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10638
04-23 20:35:16.269+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10638)
04-23 20:35:17.459+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:35:24.649+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:35:24.649+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:24.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:24.659+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:24.679+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10710
04-23 20:35:24.689+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:24.729+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10710
04-23 20:35:24.729+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10710) type(svcapp) bg(0)
04-23 20:35:24.739+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10710]
04-23 20:35:24.759+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10710)
04-23 20:35:24.759+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:35:24.759+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:24.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:24.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10710
04-23 20:35:24.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:24.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:24.789+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10710
04-23 20:35:24.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:24.799+0200 E/CAPI_APPFW_APPLICATION(10710): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:24.799+0200 E/CAPI_APPFW_APPLICATION(10710): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:24.799+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10710) was created
04-23 20:35:24.819+0200 W/LOCATION(10710): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:24.819+0200 E/LOCATION(10710): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:24.819+0200 E/PKGMGR_INFO(10710): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:24.829+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:24.849+0200 I/LOCATION(10710): location.c: location_new(269) > method: 0
04-23 20:35:24.849+0200 W/LOCATION(10710): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:24.849+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:24.859+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:24.859+0200 W/LOCATION(10710): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:24.869+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:24.869+0200 W/LOCATION(10710): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:24.869+0200 W/LOCATION(10710): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:24.869+0200 W/LOCATION(10710): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:24.869+0200 W/LOCATION(10710): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:24.889+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:24.899+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:24.899+0200 W/LOCATION(10710): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:24.899+0200 W/LOCATION(10710): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:24.909+0200 W/LOCATION(10710): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:24.909+0200 W/LOCATION(10710): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:24.909+0200 W/LOCATION(10710): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:24.919+0200 W/LOCATION(10710): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:24.919+0200 I/LOCATION(10710): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73ffc18
04-23 20:35:24.919+0200 I/LOCATION(10710): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:24.919+0200 I/LOCATION(10710): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73ffc18
04-23 20:35:24.919+0200 I/LOCATION(10710): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:24.929+0200 I/location(10710): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:24.969+0200 I/LOCATION(10710): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:25.009+0200 W/LOCATION(10710): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:25.009+0200 W/LOCATION(10710): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:25.009+0200 I/LOCATION(10710): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:25.069+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:25.069+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:25.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:25.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:25.079+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:25.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:25.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:25.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:25.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:25.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:25.079+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:25.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:25.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:25.129+0200 W/LOCATION(10710): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:25.129+0200 W/LOCATION(10710): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:25.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:25.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf730a8b0]
04-23 20:35:25.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:25.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:25.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:25.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:25.239+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:25.239+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:25.249+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:25.249+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:25.249+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:25.249+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:25.249+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:25.249+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:25.249+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:25.249+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:25.249+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:25.249+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:25.249+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:25.259+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:25.269+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:25.269+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:25.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:25.309+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:25.319+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:25.319+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2600583), time2(2587328)
04-23 20:35:25.319+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:35:25.319+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:25.319+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:25.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:25.329+0200 W/LOCATION(10710): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:25.329+0200 I/LOCATION(10710): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:25.339+0200 I/LOCATION(10710): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:25.339+0200 I/location(10710): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:25.419+0200 I/LOCATION(10710): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:25.469+0200 W/AUL     (10710): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:25.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:25.469+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10710
04-23 20:35:25.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:25.479+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.479+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:25.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:25.479+0200 I/utils   (10115): specific action
04-23 20:35:25.479+0200 W/AUL     (10710): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:25.479+0200 I/location(10710): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:25.479+0200 I/location(10710): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:25:472,nan,37.171550,-3.593163,0.000000,0,0.000000,100.000000,-1.000000
04-23 20:35:25.479+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.479+0200 W/CAPI_APPFW_APP_CONTROL(10710): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.479+0200 I/utils   (10710): specific action
04-23 20:35:25.479+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.479+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.479+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:25.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:25.479+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:25.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:25.489+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.489+0200 I/utils   (10120): specific action
04-23 20:35:25.489+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:25.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:25.489+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:25.489+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:25.489+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:25.489+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.489+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.489+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.489+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:25.489+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:25.489+0200 I/recorder(10120): guardando datos en local
04-23 20:35:26.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:26.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:26.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:26.349+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:35:27.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:27.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:27.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:27.089+0200 W/LOCATION(10710): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:35:27.289+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11107106c6f63152450852
