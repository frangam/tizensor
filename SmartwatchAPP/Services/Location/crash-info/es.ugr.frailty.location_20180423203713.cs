S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11299
Date: 2018-04-23 20:37:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf736052d, r5   = 0xf75abf98
r6   = 0xffa332d0, r7   = 0xffa33180
r8   = 0xf75a8c18, r9   = 0x00000000
r10  = 0xffa3325c, fp   = 0xffa332d0
ip   = 0x00000001, sp   = 0xffa33158
lr   = 0xf7360539, pc   = 0xf73c9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    136828 KB
Buffers:     38520 KB
Cached:     159028 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11996 KB
VmRSS:       11996 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11299 TID = 11299
11299 11302 

Maps Information
f422b000 f4a2a000 rw-p [stack:11302]
f4a31000 f4a33000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a3b000 f4a3f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a48000 f4a4a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a52000 f4a55000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a64000 f4a69000 r-xp /usr/lib/libsystem.so.0.0.0
f4a74000 f4a77000 r-xp /lib/libattr.so.1.1.0
f4a7f000 f4a8f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a97000 f4aa0000 r-xp /usr/lib/libedbus.so.1.7.99
f4aa8000 f4aa9000 r-xp /usr/lib/libresponse.so.0.2.96
f4ab2000 f4ab7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6359000 f645f000 r-xp /usr/lib/libicuuc.so.57.1
f6475000 f65fd000 r-xp /usr/lib/libicui18n.so.57.1
f660d000 f661a000 r-xp /usr/lib/libail.so.0.1.0
f6623000 f662a000 r-xp /usr/lib/libminizip.so.1.0.0
f6633000 f67dc000 r-xp /usr/lib/libcrypto.so.1.0.0
f67fc000 f6843000 r-xp /usr/lib/libssl.so.1.0.0
f684f000 f6851000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6859000 f6860000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6869000 f6870000 r-xp /lib/libcrypt-2.13.so
f68a1000 f68a4000 r-xp /lib/libcap.so.2.21
f68ac000 f68ae000 r-xp /usr/lib/libiri.so
f68b6000 f68ff000 r-xp /usr/lib/libmdm.so.1.2.69
f6907000 f690d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6915000 f6938000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6942000 f6944000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f694c000 f6969000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6972000 f6976000 r-xp /usr/lib/libsmack.so.1.0.0
f697f000 f6998000 r-xp /usr/lib/libnetwork.so.0.0.0
f69a1000 f69a9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69b1000 f69b7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69c0000 f69c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69cb000 f69db000 r-xp /lib/libresolv-2.13.so
f69df000 f69f7000 r-xp /usr/lib/liblzma.so.5.0.3
f6a00000 f6a02000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a0a000 f6a24000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a2c000 f6a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a64000 f6a73000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a7d000 f6a87000 r-xp /usr/lib/libsensord-shared.so
f6a90000 f6b63000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b6e000 f6b84000 r-xp /lib/libz.so.1.2.5
f6b8c000 f6b91000 r-xp /usr/lib/libffi.so.5.0.10
f6b99000 f6b9a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ba2000 f6bb2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bba000 f6bd3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bdb000 f6bdd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6be5000 f6c5a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c64000 f6c6a000 r-xp /lib/librt-2.13.so
f6c73000 f6c91000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c9b000 f6c9c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ca4000 f6cc7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ccf000 f6cd4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cdc000 f6d06000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d0f000 f6d26000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d2e000 f6d97000 r-xp /lib/libm-2.13.so
f6da0000 f6e34000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e47000 f6e4c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e54000 f6e5b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e63000 f6e8d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e96000 f6f62000 r-xp /usr/lib/libxml2.so.2.7.8
f6f6f000 f6f71000 r-xp /usr/lib/libiniparser.so.0
f6f7a000 f6f80000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f89000 f7059000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f705a000 f708e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7097000 f70d3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70db000 f70de000 r-xp /usr/lib/libbundle.so.0.1.22
f70e6000 f70ec000 r-xp /usr/lib/libappsvc.so.0.1.0
f70f4000 f7135000 r-xp /usr/lib/libeina.so.1.7.99
f713e000 f7155000 r-xp /usr/lib/libecore.so.1.7.99
f716c000 f7175000 r-xp /usr/lib/libvconf.so.0.2.45
f717d000 f7191000 r-xp /lib/libpthread-2.13.so
f719c000 f71a9000 r-xp /usr/lib/libaul.so.0.1.0
f71b3000 f71b5000 r-xp /lib/libdl-2.13.so
f71be000 f71c9000 r-xp /lib/libunwind.so.8.0.1
f71f6000 f71fe000 r-xp /lib/libgcc_s-4.6.so.1
f71ff000 f7323000 r-xp /lib/libc-2.13.so
f7331000 f7333000 r-xp /usr/lib/libdlog.so.0.0.0
f733b000 f7347000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7350000 f7355000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f735d000 f736c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7374000 f7378000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7381000 f7384000 r-xp /usr/lib/libappcore-agent.so.1.1
f738c000 f738e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7396000 f739a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73a2000 f73bf000 r-xp /lib/ld-2.13.so
f73c8000 f73cb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73cb000 f73cf000 r-xp /usr/lib/libsys-assert.so
f7578000 f7601000 rw-p [heap]
ffa14000 ffa35000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11299)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73c9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7360539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70673f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7065c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7071e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7077be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7077dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ac75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70a71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7065c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7071e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7077be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7077dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70a9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70aa017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70b1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a491fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a3c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b0f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fbcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fbe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf714eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7149b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf714a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf714a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7382183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73827fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73c953f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf721685c) [/lib/libc.so.6] + 0x1785c
29: (0xf73c8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ON(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.199+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:00.199+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:00.199+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.209+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.209+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:00.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.259+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:00.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:00.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:00.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c01a28
04-23 20:37:00.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c23bb0]
04-23 20:37:00.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:00.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:00.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:00.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:00.359+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.359+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.369+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.369+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:37:00.369+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:00.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:00.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:00.379+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.379+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:00.379+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:00.379+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.379+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:00.379+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:00.379+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:00.379+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.379+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:00.379+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:00.379+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11250
04-23 20:37:00.389+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:00.389+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.399+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.399+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:00.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.429+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11250
04-23 20:37:00.429+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11250) type(svcapp) bg(0)
04-23 20:37:00.439+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11250]
04-23 20:37:00.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.439+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11250)
04-23 20:37:00.449+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:00.449+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:00.449+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:00.449+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c23bb0
04-23 20:37:00.449+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:37:00.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:00.469+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:00.479+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11250
04-23 20:37:00.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:00.479+0200 E/CAPI_APPFW_APPLICATION(11250): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:00.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:00.479+0200 E/CAPI_APPFW_APPLICATION(11250): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:00.489+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11250
04-23 20:37:00.489+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11250) was created
04-23 20:37:00.489+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:00.509+0200 W/LOCATION(11250): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:00.509+0200 E/LOCATION(11250): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:00.509+0200 E/PKGMGR_INFO(11250): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:00.509+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.529+0200 I/LOCATION(11250): location.c: location_new(269) > method: 0
04-23 20:37:00.529+0200 W/LOCATION(11250): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.539+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.539+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.539+0200 W/LOCATION(11250): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:00.549+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:00.549+0200 W/LOCATION(11250): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:00.549+0200 W/LOCATION(11250): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.549+0200 W/LOCATION(11250): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:00.549+0200 W/LOCATION(11250): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:00.569+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:00.569+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:00.579+0200 W/LOCATION(11250): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:00.579+0200 W/LOCATION(11250): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:00.579+0200 W/LOCATION(11250): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:00.579+0200 W/LOCATION(11250): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:00.579+0200 W/LOCATION(11250): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:00.599+0200 W/LOCATION(11250): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:00.599+0200 I/LOCATION(11250): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7659c18
04-23 20:37:00.599+0200 I/LOCATION(11250): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:00.599+0200 I/LOCATION(11250): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7659c18
04-23 20:37:00.599+0200 I/LOCATION(11250): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:00.599+0200 I/location(11250): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:00.649+0200 I/LOCATION(11250): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:00.689+0200 W/LOCATION(11250): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:00.689+0200 W/LOCATION(11250): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:00.689+0200 I/LOCATION(11250): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:00.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:00.749+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:00.749+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:00.749+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:00.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:00.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:00.749+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:00.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:00.749+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:00.749+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:00.749+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:00.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:00.799+0200 W/LOCATION(11250): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:00.799+0200 W/LOCATION(11250): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:00.879+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.929+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c23b80]
04-23 20:37:00.929+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:00.929+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:00.929+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:00.929+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:00.929+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.929+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.939+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.949+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.949+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:00.949+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:00.949+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:00.949+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:00.949+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:00.949+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:00.949+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:00.949+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:00.949+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:00.959+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.969+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:00.969+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:00.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:00.979+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:00.979+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2696242), time2(2693195)
04-23 20:37:00.979+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:37:00.979+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:00.979+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:00.979+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:01.009+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.039+0200 W/LOCATION(11250): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:01.039+0200 I/LOCATION(11250): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:01.039+0200 I/LOCATION(11250): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:01.039+0200 I/location(11250): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:01.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:01.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:01.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:01.139+0200 I/LOCATION(11250): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:01.199+0200 W/AUL     (11250): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:01.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:01.199+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11250
04-23 20:37:01.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:01.209+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:01.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:01.209+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.209+0200 I/utils   (10115): specific action
04-23 20:37:01.209+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.209+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.209+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.209+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:01.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:01.209+0200 W/AUL     (11250): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:01.209+0200 I/location(11250): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:01.209+0200 I/location(11250): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:01:199,nan,37.171720,-3.592987,0.000000,0,0.000000,62.000000,-1.000000
04-23 20:37:01.209+0200 I/location(11250): stopping es.ugr.frailty.location service
04-23 20:37:01.209+0200 E/CAPI_APPFW_APP_CONTROL(11250): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:37:01.209+0200 E/location(11250): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:37:01.209+0200 I/CAPI_APPFW_APPLICATION(11250): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:37:01.209+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:01.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:37:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:37:01.219+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:01.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:01.219+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:01.219+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:01.219+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:01.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.219+0200 I/utils   (10120): specific action
04-23 20:37:01.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:01.219+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:01.219+0200 I/recorder(10120): guardando datos en local
04-23 20:37:01.259+0200 W/LOCATION(11250): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:01.259+0200 I/LOCATION(11250): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:01.259+0200 I/LOCATION(11250): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:37:01.339+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:37:01.339+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:37:01.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:37:01.339+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:37:01.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.489+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:01.489+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:01.489+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:01.489+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c23b80
04-23 20:37:01.549+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72dae60]
04-23 20:37:01.549+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:01.549+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:01.549+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:01.549+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:01.559+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:01.559+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:01.569+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.579+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.579+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:01.579+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:01.579+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:01.579+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:01.579+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:01.579+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:01.579+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:01.579+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:01.579+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:01.579+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.589+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.589+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:01.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.699+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:01.699+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:01.699+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:01.699+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72dae60
04-23 20:37:01.749+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1b2f8]
04-23 20:37:01.749+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:01.749+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:01.749+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:01.749+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:01.759+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:01.759+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:01.759+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.769+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.769+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:01.769+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:01.769+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:01.769+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:01.769+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:01.769+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:01.769+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:01.769+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:01.769+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:01.779+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.789+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:01.789+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:01.789+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:01.879+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:01.879+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:01.879+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:01.879+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1b2f8
04-23 20:37:02.039+0200 W/AUL     (11263): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:37:02.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:37:02.039+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:37:02.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11227
04-23 20:37:02.039+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:37:02.039+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11227
04-23 20:37:02.039+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11227)
04-23 20:37:03.219+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:37:10.479+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:37:10.479+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:10.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:10.479+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:10.509+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11299
04-23 20:37:10.509+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:10.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11299
04-23 20:37:10.559+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11299) type(svcapp) bg(0)
04-23 20:37:10.569+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11299]
04-23 20:37:10.589+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11299)
04-23 20:37:10.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:10.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11299
04-23 20:37:10.609+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:37:10.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:10.609+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:10.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:10.639+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11299
04-23 20:37:10.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:10.649+0200 E/CAPI_APPFW_APPLICATION(11299): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:10.649+0200 E/CAPI_APPFW_APPLICATION(11299): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:10.649+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11299) was created
04-23 20:37:10.669+0200 W/LOCATION(11299): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:10.669+0200 E/LOCATION(11299): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:10.669+0200 E/PKGMGR_INFO(11299): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:10.679+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:10.699+0200 I/LOCATION(11299): location.c: location_new(269) > method: 0
04-23 20:37:10.699+0200 W/LOCATION(11299): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:10.699+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:10.709+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:10.709+0200 W/LOCATION(11299): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:10.709+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:10.719+0200 W/LOCATION(11299): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:10.719+0200 W/LOCATION(11299): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:10.719+0200 W/LOCATION(11299): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:10.719+0200 W/LOCATION(11299): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:10.739+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:10.739+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:10.739+0200 W/LOCATION(11299): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:10.749+0200 W/LOCATION(11299): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:10.749+0200 W/LOCATION(11299): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:10.749+0200 W/LOCATION(11299): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:10.749+0200 W/LOCATION(11299): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:10.769+0200 W/LOCATION(11299): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:10.769+0200 I/LOCATION(11299): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75a8c18
04-23 20:37:10.769+0200 I/LOCATION(11299): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:10.769+0200 I/LOCATION(11299): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75a8c18
04-23 20:37:10.769+0200 I/LOCATION(11299): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:10.769+0200 I/location(11299): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:10.819+0200 I/LOCATION(11299): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:10.849+0200 W/LOCATION(11299): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:10.849+0200 W/LOCATION(11299): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:10.849+0200 I/LOCATION(11299): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:10.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:10.919+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:10.919+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:10.919+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:10.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:10.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:10.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:10.919+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:10.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:10.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:10.929+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:10.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:10.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:10.979+0200 W/LOCATION(11299): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:10.979+0200 W/LOCATION(11299): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:11.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:11.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:11.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:11.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:11.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1adb8]
04-23 20:37:11.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:11.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:11.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:11.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:11.119+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:11.119+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:11.139+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:11.139+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:11.139+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:11.139+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:11.139+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:11.139+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:11.139+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:11.139+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:11.139+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:11.139+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:11.139+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:11.159+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:11.159+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:11.159+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2706420), time2(2693195)
04-23 20:37:11.159+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:37:11.159+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:11.159+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:11.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:11.159+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:11.159+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:11.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:11.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:11.239+0200 W/LOCATION(11299): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:11.239+0200 I/LOCATION(11299): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:11.239+0200 I/LOCATION(11299): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:11.239+0200 I/location(11299): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:11.329+0200 I/LOCATION(11299): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:11.389+0200 W/AUL     (11299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:11.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:11.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11299
04-23 20:37:11.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:11.409+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.409+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:11.409+0200 W/AUL     (11299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:11.409+0200 I/utils   (10115): specific action
04-23 20:37:11.409+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.409+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.409+0200 I/location(11299): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:11.409+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.409+0200 I/location(11299): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:11:396,nan,37.171720,-3.592987,0.000000,0,0.000000,62.000000,-1.000000
04-23 20:37:11.409+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:11.409+0200 W/CAPI_APPFW_APP_CONTROL(11299): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.409+0200 I/utils   (11299): specific action
04-23 20:37:11.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:11.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:11.409+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:11.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:11.419+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.419+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:11.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:11.419+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:11.419+0200 I/utils   (10120): specific action
04-23 20:37:11.419+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:11.419+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:11.419+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.419+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.419+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.419+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:11.419+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:11.419+0200 I/recorder(10120): guardando datos en local
04-23 20:37:12.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:12.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:12.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:12.239+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:37:12.959+0200 W/LOCATION(11299): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:37:13.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:13.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:13.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:13.139+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11112996c6f63152450863
