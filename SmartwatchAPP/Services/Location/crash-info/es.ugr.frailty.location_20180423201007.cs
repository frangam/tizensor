S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7366
Date: 2018-04-23 20:10:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76aa52d, r5   = 0xf7f0df98
r6   = 0xfff2d260, r7   = 0xfff2d110
r8   = 0xf7f0ac18, r9   = 0x00000000
r10  = 0xfff2d1ec, fp   = 0xfff2d260
ip   = 0x00000001, sp   = 0xfff2d0e8
lr   = 0xf76aa539, pc   = 0xf7713228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    107340 KB
Buffers:     40528 KB
Cached:     186928 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11988 KB
VmRSS:       11988 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7366 TID = 7366
7366 7369 

Maps Information
f4575000 f4d74000 rw-p [stack:7369]
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
f7eda000 f7f4b000 rw-p [heap]
fff0e000 fff2f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7366)
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
27: main + 0xda (0xf77134f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
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
( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:54.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:54.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:54.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:54.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:54.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:54.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.139+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:54.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:54.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:54.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:54.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:54.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:54.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:54.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d1c70
04-23 20:09:54.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f165c0]
04-23 20:09:54.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:54.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:54.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:54.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:54.309+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:54.309+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.339+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.339+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:54.339+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:54.339+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.339+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:54.339+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:54.339+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:54.339+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:54.339+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:54.339+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:54.349+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:54.359+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:54.359+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:54.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:54.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:54.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:54.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:54.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f165c0
04-23 20:09:54.569+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:09:54.569+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:09:54.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:54.569+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:54.579+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7318
04-23 20:09:54.579+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:09:54.629+0200 E/CAPI_APPFW_APPLICATION( 7318): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:54.629+0200 E/CAPI_APPFW_APPLICATION( 7318): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:54.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7318
04-23 20:09:54.629+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7318) type(svcapp) bg(0)
04-23 20:09:54.629+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7318) was created
04-23 20:09:54.639+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7318]
04-23 20:09:54.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:54.659+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7318
04-23 20:09:54.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:54.669+0200 W/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:09:54.669+0200 E/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:09:54.669+0200 E/PKGMGR_INFO( 7318): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:09:54.669+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.679+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7318)
04-23 20:09:54.679+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:09:54.679+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:54.689+0200 I/LOCATION( 7318): location.c: location_new(269) > method: 0
04-23 20:09:54.689+0200 W/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:54.689+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.699+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:54.699+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:54.699+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:54.709+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:54.709+0200 W/LOCATION( 7318): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:54.709+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:54.709+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:54.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:54.729+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7318
04-23 20:09:54.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:54.739+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:54.739+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:54.739+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (wps) open success
04-23 20:09:54.749+0200 W/LOCATION( 7318): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:09:54.749+0200 W/LOCATION( 7318): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:09:54.749+0200 W/LOCATION( 7318): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:54.749+0200 W/LOCATION( 7318): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:54.769+0200 W/LOCATION( 7318): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:09:54.769+0200 I/LOCATION( 7318): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf722ec18
04-23 20:09:54.769+0200 I/LOCATION( 7318): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:09:54.769+0200 I/LOCATION( 7318): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf722ec18
04-23 20:09:54.769+0200 I/LOCATION( 7318): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:09:54.779+0200 I/location( 7318): es.ugr.frailty.location: creado servicio de localización
04-23 20:09:54.819+0200 I/LOCATION( 7318): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:09:54.859+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:54.859+0200 W/LOCATION( 7318): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:54.859+0200 I/LOCATION( 7318): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:54.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:09:54.929+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:09:54.929+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:09:54.929+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:54.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:09:54.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:09:54.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:09:54.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:09:54.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:09:54.929+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:09:54.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:09:54.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:09:54.979+0200 W/LOCATION( 7318): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:54.979+0200 W/LOCATION( 7318): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:55.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d12b8]
04-23 20:09:55.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:55.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:55.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:55.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:55.109+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:55.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:55.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.129+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:55.129+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:55.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:55.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:55.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:55.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:55.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:55.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:55.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:55.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.139+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:55.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:09:55.169+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(1070437), time2(1067378)
04-23 20:09:55.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:09:55.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:09:55.169+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:09:55.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:09:55.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.229+0200 W/LOCATION( 7318): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:55.229+0200 I/LOCATION( 7318): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:55.229+0200 I/LOCATION( 7318): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:55.229+0200 I/location( 7318): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:09:55.339+0200 I/LOCATION( 7318): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:55.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:55.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:55.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:55.409+0200 E/location( 7318): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:09:55.409+0200 W/AUL     ( 7318): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:55.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:55.409+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7318
04-23 20:09:55.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:55.419+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:55.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:55.429+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.429+0200 I/utils   ( 5532): specific action
04-23 20:09:55.429+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.429+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.429+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.429+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:55.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:55.439+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:55.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:55.459+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:55.459+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:09:55.459+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.469+0200 I/utils   ( 5538): specific action
04-23 20:09:55.469+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.469+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.469+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.469+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:55.469+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:09:55.469+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:55.479+0200 W/AUL     ( 7318): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:55.479+0200 I/location( 7318): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:55.479+0200 I/location( 7318): stopping es.ugr.frailty.location service
04-23 20:09:55.479+0200 E/CAPI_APPFW_APP_CONTROL( 7318): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:09:55.479+0200 E/location( 7318): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:09:55.479+0200 I/CAPI_APPFW_APPLICATION( 7318): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:09:55.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:09:55.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:09:55.489+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:55.489+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:55.489+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:55.519+0200 W/LOCATION( 7318): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:55.519+0200 I/LOCATION( 7318): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:09:55.519+0200 I/LOCATION( 7318): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:09:55.589+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:09:55.589+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:09:55.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:09:55.589+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:09:55.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d12b8
04-23 20:09:55.839+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1dc00]
04-23 20:09:55.839+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:55.839+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:55.839+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:55.839+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:55.839+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:55.839+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:55.869+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.879+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.879+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:55.879+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:55.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:55.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:55.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:55.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:55.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:55.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:55.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:55.879+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.889+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:55.889+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:55.889+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.939+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:55.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:55.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:55.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:55.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1dc00
04-23 20:09:56.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f02e90]
04-23 20:09:56.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:56.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:56.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:56.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:56.049+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:56.049+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:56.059+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:56.069+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:56.069+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:56.069+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:56.069+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:56.069+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:56.069+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:56.069+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:56.069+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:56.069+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:56.069+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:56.079+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:56.079+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:56.079+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:56.089+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:56.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:56.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:56.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:56.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:56.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f02e90
04-23 20:09:56.339+0200 W/AUL     ( 7330): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:09:56.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:56.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:56.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7294
04-23 20:09:56.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:56.339+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7294
04-23 20:09:56.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7294)
04-23 20:09:57.479+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:10:04.689+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:10:04.689+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:04.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:04.699+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:04.709+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:04.709+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7366
04-23 20:10:04.759+0200 E/CAPI_APPFW_APPLICATION( 7366): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:04.759+0200 E/CAPI_APPFW_APPLICATION( 7366): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:04.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7366
04-23 20:10:04.759+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7366) type(svcapp) bg(0)
04-23 20:10:04.759+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7366) was created
04-23 20:10:04.759+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7366)
04-23 20:10:04.759+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:10:04.759+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:04.759+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7366]
04-23 20:10:04.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:04.789+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7366
04-23 20:10:04.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:04.809+0200 W/LOCATION( 7366): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:04.809+0200 E/LOCATION( 7366): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:04.809+0200 E/PKGMGR_INFO( 7366): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:04.809+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:04.829+0200 I/LOCATION( 7366): location.c: location_new(269) > method: 0
04-23 20:10:04.829+0200 W/LOCATION( 7366): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:04.829+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:04.829+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:04.839+0200 W/LOCATION( 7366): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:04.839+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:04.839+0200 W/LOCATION( 7366): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:04.839+0200 W/LOCATION( 7366): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:04.839+0200 W/LOCATION( 7366): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:04.839+0200 W/LOCATION( 7366): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:04.859+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:04.869+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:04.869+0200 W/LOCATION( 7366): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:04.869+0200 W/LOCATION( 7366): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:04.879+0200 W/LOCATION( 7366): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:04.879+0200 W/LOCATION( 7366): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:04.879+0200 W/LOCATION( 7366): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:04.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:04.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7366
04-23 20:10:04.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:04.909+0200 W/LOCATION( 7366): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:04.909+0200 I/LOCATION( 7366): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7f0ac18
04-23 20:10:04.909+0200 I/LOCATION( 7366): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:04.909+0200 I/LOCATION( 7366): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7f0ac18
04-23 20:10:04.909+0200 I/LOCATION( 7366): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:04.909+0200 I/location( 7366): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:04.959+0200 I/LOCATION( 7366): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:04.989+0200 W/LOCATION( 7366): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:04.989+0200 W/LOCATION( 7366): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:04.989+0200 I/LOCATION( 7366): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:05.059+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:05.059+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:05.069+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:05.069+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:05.069+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:05.069+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:05.069+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:05.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:05.069+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:05.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:05.069+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:05.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:05.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:05.119+0200 W/LOCATION( 7366): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:05.119+0200 W/LOCATION( 7366): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:05.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:05.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1dce0]
04-23 20:10:05.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:05.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:05.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:05.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:05.239+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:05.239+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:05.249+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:05.259+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:05.259+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:05.259+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:05.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:05.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:05.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:05.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:05.259+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:05.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:05.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:05.269+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:05.279+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:05.279+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:05.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:05.309+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:05.309+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1080576), time2(1067378)
04-23 20:10:05.309+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:10:05.309+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:05.309+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:05.309+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:05.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:05.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:05.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:05.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:05.379+0200 W/LOCATION( 7366): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:05.379+0200 I/LOCATION( 7366): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:05.379+0200 I/LOCATION( 7366): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:05.379+0200 I/location( 7366): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:05.469+0200 I/LOCATION( 7366): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:05.509+0200 E/location( 7366): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:05.509+0200 W/AUL     ( 7366): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:05.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:05.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7366
04-23 20:10:05.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:05.529+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.529+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:05.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:05.529+0200 W/AUL     ( 7366): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:05.529+0200 I/location( 7366): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:05.529+0200 W/CAPI_APPFW_APP_CONTROL( 7366): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.529+0200 I/utils   ( 7366): specific action
04-23 20:10:05.529+0200 I/utils   ( 5532): specific action
04-23 20:10:05.529+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.529+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.529+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.529+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:05.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:05.539+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:05.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:05.549+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:05.549+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:05.549+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.549+0200 I/utils   ( 5538): specific action
04-23 20:10:05.549+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.549+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.549+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.549+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:05.549+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:05.549+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:05.549+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:05.549+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:05.549+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:06.319+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:10:06.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:06.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:06.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:07.019+0200 W/LOCATION( 7366): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:10:07.199+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11073666c6f63152450700
