S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24334
Date: 2018-04-23 16:03:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723252d, r5   = 0xf7591f98
r6   = 0xff8fe508, r7   = 0xff8fe3b8
r8   = 0xf758ec18, r9   = 0x00000000
r10  = 0xff8fe494, fp   = 0xff8fe508
ip   = 0x00000001, sp   = 0xff8fd238
lr   = 0xf7232539, pc   = 0xf729b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4788 KB
Buffers:     61816 KB
Cached:     228528 KB
VmPeak:      53560 KB
VmSize:      53556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12136 KB
VmRSS:       12136 KB
VmData:      11284 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24334 TID = 24334
24334 24337 

Maps Information
f40fd000 f48fc000 rw-p [stack:24337]
f4903000 f4905000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f490d000 f4911000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f491a000 f491c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4924000 f4927000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4936000 f493b000 r-xp /usr/lib/libsystem.so.0.0.0
f4946000 f4949000 r-xp /lib/libattr.so.1.1.0
f4951000 f4961000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4969000 f4972000 r-xp /usr/lib/libedbus.so.1.7.99
f497a000 f497b000 r-xp /usr/lib/libresponse.so.0.2.96
f4984000 f4989000 r-xp /usr/lib/libproc-stat.so.0.2.96
f622b000 f6331000 r-xp /usr/lib/libicuuc.so.57.1
f6347000 f64cf000 r-xp /usr/lib/libicui18n.so.57.1
f64df000 f64ec000 r-xp /usr/lib/libail.so.0.1.0
f64f5000 f64fc000 r-xp /usr/lib/libminizip.so.1.0.0
f6505000 f66ae000 r-xp /usr/lib/libcrypto.so.1.0.0
f66ce000 f6715000 r-xp /usr/lib/libssl.so.1.0.0
f6721000 f6723000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f672b000 f6732000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f673b000 f6742000 r-xp /lib/libcrypt-2.13.so
f6773000 f6776000 r-xp /lib/libcap.so.2.21
f677e000 f6780000 r-xp /usr/lib/libiri.so
f6788000 f67d1000 r-xp /usr/lib/libmdm.so.1.2.69
f67d9000 f67df000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67e7000 f680a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6814000 f6816000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f681e000 f683b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6844000 f6848000 r-xp /usr/lib/libsmack.so.1.0.0
f6851000 f686a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6873000 f687b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6883000 f6889000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6892000 f6894000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f689d000 f68ad000 r-xp /lib/libresolv-2.13.so
f68b1000 f68c9000 r-xp /usr/lib/liblzma.so.5.0.3
f68d2000 f68d4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68dc000 f68f6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68fe000 f692d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6936000 f6945000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f694f000 f6959000 r-xp /usr/lib/libsensord-shared.so
f6962000 f6a35000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a40000 f6a56000 r-xp /lib/libz.so.1.2.5
f6a5e000 f6a63000 r-xp /usr/lib/libffi.so.5.0.10
f6a6b000 f6a6c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a74000 f6a84000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a8c000 f6aa5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6aad000 f6aaf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ab7000 f6b2c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b36000 f6b3c000 r-xp /lib/librt-2.13.so
f6b45000 f6b63000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b6d000 f6b6e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b76000 f6b99000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ba1000 f6ba6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bae000 f6bd8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6be1000 f6bf8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c00000 f6c69000 r-xp /lib/libm-2.13.so
f6c72000 f6d06000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d19000 f6d1e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d26000 f6d2d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d35000 f6d5f000 r-xp /usr/lib/libsensor.so.1.9.6
f6d68000 f6e34000 r-xp /usr/lib/libxml2.so.2.7.8
f6e41000 f6e43000 r-xp /usr/lib/libiniparser.so.0
f6e4c000 f6e52000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e5b000 f6f2b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f2c000 f6f60000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f69000 f6fa5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fad000 f6fb0000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb8000 f6fbe000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fc6000 f7007000 r-xp /usr/lib/libeina.so.1.7.99
f7010000 f7027000 r-xp /usr/lib/libecore.so.1.7.99
f703e000 f7047000 r-xp /usr/lib/libvconf.so.0.2.45
f704f000 f7063000 r-xp /lib/libpthread-2.13.so
f706e000 f707b000 r-xp /usr/lib/libaul.so.0.1.0
f7085000 f7087000 r-xp /lib/libdl-2.13.so
f7090000 f709b000 r-xp /lib/libunwind.so.8.0.1
f70c8000 f70d0000 r-xp /lib/libgcc_s-4.6.so.1
f70d1000 f71f5000 r-xp /lib/libc-2.13.so
f7203000 f7205000 r-xp /usr/lib/libdlog.so.0.0.0
f720d000 f7219000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7222000 f7227000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f722f000 f723e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7246000 f724a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7253000 f7256000 r-xp /usr/lib/libappcore-agent.so.1.1
f725e000 f7260000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7268000 f726c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7274000 f7291000 r-xp /lib/ld-2.13.so
f729a000 f729d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f729d000 f72a1000 r-xp /usr/lib/libsys-assert.so
f755e000 f75ea000 rw-p [heap]
ff8df000 ff900000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24334)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf729b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7232539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f393f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f37c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f43e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f49be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f49dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f7e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f791f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f37c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f43e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f49be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f49dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f7be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f7c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f808d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf726a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf490e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69e1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e8efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e907a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7020ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf701bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf701c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf701c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7254183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72547fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf729b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf70e885c) [/lib/libc.so.6] + 0x1785c
29: (0xf729afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:04.811+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:04.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:04.811+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:04.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:04.811+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:04.811+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:04.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:04.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:04.821+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:04.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:04.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:04.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:04.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:04.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:04.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:04.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733ae88
04-23 16:04:04.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332cc8]
04-23 16:04:04.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:04.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:04.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:04.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:05.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.011+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:04:05.011+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:04:05.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:05.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:04:05.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:05.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:05.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:05.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:05.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:05.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:05.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:05.021+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24503
04-23 16:04:05.021+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:04:05.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:05.081+0200 E/CAPI_APPFW_APPLICATION(24503): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:05.081+0200 E/CAPI_APPFW_APPLICATION(24503): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:05.101+0200 W/LOCATION(24503): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:04:05.101+0200 E/LOCATION(24503): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:04:05.101+0200 E/PKGMGR_INFO(24503): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:04:05.101+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.121+0200 I/LOCATION(24503): location.c: location_new(269) > method: 0
04-23 16:04:05.121+0200 W/LOCATION(24503): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.121+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.131+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.131+0200 W/LOCATION(24503): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:05.141+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:05.141+0200 W/LOCATION(24503): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:05.141+0200 W/LOCATION(24503): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.141+0200 W/LOCATION(24503): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:05.141+0200 W/LOCATION(24503): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:05.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24503
04-23 16:04:05.151+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24503) type(svcapp) bg(0)
04-23 16:04:05.151+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24503) was created
04-23 16:04:05.151+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24503]
04-23 16:04:05.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:05.171+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24503)
04-23 16:04:05.171+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:04:05.171+0200 I/servicemanager(19708): App control destroyed.
04-23 16:04:05.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:05.181+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24503
04-23 16:04:05.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:05.201+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:05.201+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:05.211+0200 W/LOCATION(24503): module-internal.c: module_new(311) > module (wps) open success
04-23 16:04:05.211+0200 W/LOCATION(24503): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:04:05.221+0200 W/LOCATION(24503): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:04:05.221+0200 W/LOCATION(24503): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:05.221+0200 W/LOCATION(24503): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:05.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:05.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:05.241+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24503
04-23 16:04:05.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:05.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:05.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:05.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:05.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332cc8
04-23 16:04:05.281+0200 W/LOCATION(24503): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:04:05.281+0200 I/LOCATION(24503): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf771dc18
04-23 16:04:05.281+0200 I/LOCATION(24503): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:04:05.291+0200 I/LOCATION(24503): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf771dc18
04-23 16:04:05.291+0200 I/LOCATION(24503): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:04:05.301+0200 I/location(24503): es.ugr.frailty.location: creado servicio de localización
04-23 16:04:05.411+0200 I/LOCATION(24503): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:04:05.471+0200 W/LOCATION(24503): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:05.471+0200 W/LOCATION(24503): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:05.471+0200 I/LOCATION(24503): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:04:05.571+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:04:05.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:04:05.571+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:04:05.571+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:05.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:04:05.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:04:05.571+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:04:05.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:04:05.571+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:04:05.571+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:04:05.571+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:04:05.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:04:05.631+0200 W/LOCATION(24503): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:05.631+0200 W/LOCATION(24503): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:05.711+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:05.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734c698]
04-23 16:04:05.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:05.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:05.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:05.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:05.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.781+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:05.781+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:05.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:05.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:05.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:05.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:05.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:05.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:05.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:05.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:05.801+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:05.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:05.821+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:04:05.821+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6141482), time2(6135181)
04-23 16:04:05.821+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:04:05.821+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:04:05.821+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:04:05.821+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:04:05.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:05.871+0200 W/LOCATION(24503): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:04:05.871+0200 I/LOCATION(24503): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:05.871+0200 I/LOCATION(24503): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:05.871+0200 I/location(24503): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:04:05.971+0200 I/LOCATION(24503): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:06.021+0200 W/AUL     (24503): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:04:06.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:06.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24503
04-23 16:04:06.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:04:06.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:04:06.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:04:06.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.031+0200 I/utils   (19708): specific action
04-23 16:04:06.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:04:06.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:06.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:04:06.051+0200 W/AUL     (24503): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:04:06.051+0200 I/location(24503): request sent to service es.ugr.frailty.servicemanager
04-23 16:04:06.051+0200 I/location(24503): stopping es.ugr.frailty.location service
04-23 16:04:06.051+0200 E/CAPI_APPFW_APP_CONTROL(24503): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:04:06.051+0200 E/location(24503): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:04:06.051+0200 I/CAPI_APPFW_APPLICATION(24503): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:04:06.051+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:04:06.051+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:04:06.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:04:06.051+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:04:06.051+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:04:06.051+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:04:06.051+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:04:06.051+0200 I/servicemanager(19708): requesting to save local data
04-23 16:04:06.051+0200 I/utils   (22624): specific action
04-23 16:04:06.051+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.051+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.051+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.051+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:06.051+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:04:06.051+0200 I/recorder(22624): guardando datos en local
04-23 16:04:06.091+0200 W/LOCATION(24503): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:04:06.091+0200 I/LOCATION(24503): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:04:06.091+0200 I/LOCATION(24503): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:04:06.221+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:04:06.221+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:04:06.221+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:04:06.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:04:06.431+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:06.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:06.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:06.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734c698
04-23 16:04:06.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7349af0]
04-23 16:04:06.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:06.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:06.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:06.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:06.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:06.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:06.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.561+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:06.561+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:06.561+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:06.571+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:06.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:06.571+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:06.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:06.571+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:06.571+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:06.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.581+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:06.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:06.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:06.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:06.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7349af0
04-23 16:04:06.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e0fb80]
04-23 16:04:06.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:06.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:06.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:06.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:06.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:06.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:06.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.751+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:06.751+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:06.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:06.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:06.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:06.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:06.751+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:06.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:06.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:06.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:06.771+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:06.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:06.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:06.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:06.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:06.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e0fb80
04-23 16:04:07.031+0200 W/AUL     (24516): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:04:07.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:07.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:07.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24468
04-23 16:04:07.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:07.031+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24468
04-23 16:04:07.031+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24468)
04-23 16:04:07.181+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:04:07.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:04:07.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:07.181+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:04:07.191+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24519
04-23 16:04:07.191+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:04:07.241+0200 E/CAPI_APPFW_APPLICATION(24519): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:07.241+0200 E/CAPI_APPFW_APPLICATION(24519): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:07.261+0200 W/LOCATION(24519): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:04:07.261+0200 E/LOCATION(24519): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:04:07.261+0200 E/PKGMGR_INFO(24519): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:04:07.271+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:07.281+0200 I/LOCATION(24519): location.c: location_new(269) > method: 0
04-23 16:04:07.281+0200 W/LOCATION(24519): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:07.291+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:07.291+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:07.291+0200 W/LOCATION(24519): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:07.301+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:07.301+0200 W/LOCATION(24519): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:07.301+0200 W/LOCATION(24519): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:07.301+0200 W/LOCATION(24519): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:07.301+0200 W/LOCATION(24519): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:07.321+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:07.321+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:07.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24519
04-23 16:04:07.331+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24519) type(svcapp) bg(0)
04-23 16:04:07.331+0200 W/LOCATION(24519): module-internal.c: module_new(311) > module (wps) open success
04-23 16:04:07.331+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24519) was created
04-23 16:04:07.331+0200 W/LOCATION(24519): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:04:07.331+0200 W/LOCATION(24519): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:04:07.331+0200 W/LOCATION(24519): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:07.331+0200 W/LOCATION(24519): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:07.341+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24519]
04-23 16:04:07.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:07.361+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24519
04-23 16:04:07.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:07.381+0200 W/LOCATION(24519): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:04:07.381+0200 I/LOCATION(24519): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7913c18
04-23 16:04:07.381+0200 I/LOCATION(24519): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:04:07.381+0200 I/LOCATION(24519): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7913c18
04-23 16:04:07.381+0200 I/LOCATION(24519): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:04:07.391+0200 I/location(24519): es.ugr.frailty.location: creado servicio de localización
04-23 16:04:07.451+0200 I/LOCATION(24519): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:04:07.501+0200 W/LOCATION(24519): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:07.501+0200 W/LOCATION(24519): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:07.501+0200 I/LOCATION(24519): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:07.511+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24519)
04-23 16:04:07.511+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:04:07.511+0200 I/servicemanager(19708): App control destroyed.
04-23 16:04:07.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:07.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24519
04-23 16:04:07.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:04:07.591+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:04:07.591+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:07.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:07.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:04:07.591+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:04:07.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:04:07.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:04:07.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:04:07.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:04:07.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:04:07.601+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:04:07.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:04:07.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:04:07.691+0200 W/LOCATION(24519): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:07.691+0200 W/LOCATION(24519): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:07.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:07.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7386460]
04-23 16:04:07.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:07.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:07.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:07.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:07.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:07.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:07.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:07.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:07.831+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:07.831+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:07.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:07.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:07.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:07.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:07.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:07.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:07.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:07.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:04:07.841+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6143501), time2(6135181)
04-23 16:04:07.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:04:07.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:04:07.841+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:04:07.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:04:07.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:07.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:07.851+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:07.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:07.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:07.921+0200 W/LOCATION(24519): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:04:07.921+0200 I/LOCATION(24519): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:07.921+0200 I/LOCATION(24519): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:07.921+0200 I/location(24519): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:04:07.951+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11242786c6f631524492227
04-23 16:04:08.051+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:04:08.101+0200 I/LOCATION(24519): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:08.141+0200 W/AUL     (24519): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:04:08.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:08.141+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24519
04-23 16:04:08.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:04:08.161+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:04:08.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:04:08.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.161+0200 I/utils   (19708): specific action
04-23 16:04:08.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.161+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:04:08.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:08.161+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:04:08.171+0200 W/AUL     (24519): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:04:08.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:04:08.171+0200 I/location(24519): request sent to service es.ugr.frailty.servicemanager
04-23 16:04:08.171+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:04:08.171+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:04:08.171+0200 I/servicemanager(19708): requesting to save local data
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(24519): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 I/utils   (24519): specific action
04-23 16:04:08.171+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:04:08.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 I/utils   (22624): specific action
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:08.171+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:04:08.171+0200 I/recorder(22624): guardando datos en local
04-23 16:04:08.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:04:08.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:04:08.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:04:08.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:04:08.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:04:08.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:08.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:08.431+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:04:08.431+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:04:08.431+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:08.451+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11243346c6f63152449223
