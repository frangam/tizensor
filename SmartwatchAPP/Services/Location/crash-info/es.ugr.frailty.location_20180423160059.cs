S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22041
Date: 2018-04-23 16:00:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71d452d, r5   = 0xf763ff98
r6   = 0xffce2bd8, r7   = 0xffce2a88
r8   = 0xf763cc18, r9   = 0x00000000
r10  = 0xffce2b64, fp   = 0xffce2bd8
ip   = 0x00000001, sp   = 0xffce1908
lr   = 0xf71d4539, pc   = 0xf723d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8376 KB
Buffers:     59860 KB
Cached:     234656 KB
VmPeak:      53572 KB
VmSize:      53568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11656 KB
VmRSS:       11656 KB
VmData:      11296 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22041 TID = 22041
22041 22045 

Maps Information
f409f000 f489e000 rw-p [stack:22045]
f48a5000 f48a7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48af000 f48b3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48bc000 f48be000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48c6000 f48c9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48d8000 f48dd000 r-xp /usr/lib/libsystem.so.0.0.0
f48e8000 f48eb000 r-xp /lib/libattr.so.1.1.0
f48f3000 f4903000 r-xp /usr/lib/libmdm-common.so.1.1.24
f490b000 f4914000 r-xp /usr/lib/libedbus.so.1.7.99
f491c000 f491d000 r-xp /usr/lib/libresponse.so.0.2.96
f4926000 f492b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61cd000 f62d3000 r-xp /usr/lib/libicuuc.so.57.1
f62e9000 f6471000 r-xp /usr/lib/libicui18n.so.57.1
f6481000 f648e000 r-xp /usr/lib/libail.so.0.1.0
f6497000 f649e000 r-xp /usr/lib/libminizip.so.1.0.0
f64a7000 f6650000 r-xp /usr/lib/libcrypto.so.1.0.0
f6670000 f66b7000 r-xp /usr/lib/libssl.so.1.0.0
f66c3000 f66c5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66cd000 f66d4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66dd000 f66e4000 r-xp /lib/libcrypt-2.13.so
f6715000 f6718000 r-xp /lib/libcap.so.2.21
f6720000 f6722000 r-xp /usr/lib/libiri.so
f672a000 f6773000 r-xp /usr/lib/libmdm.so.1.2.69
f677b000 f6781000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6789000 f67ac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67b6000 f67b8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67c0000 f67dd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67e6000 f67ea000 r-xp /usr/lib/libsmack.so.1.0.0
f67f3000 f680c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6815000 f681d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6825000 f682b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6834000 f6836000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f683f000 f684f000 r-xp /lib/libresolv-2.13.so
f6853000 f686b000 r-xp /usr/lib/liblzma.so.5.0.3
f6874000 f6876000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f687e000 f6898000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68a0000 f68cf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68d8000 f68e7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68f1000 f68fb000 r-xp /usr/lib/libsensord-shared.so
f6904000 f69d7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69e2000 f69f8000 r-xp /lib/libz.so.1.2.5
f6a00000 f6a05000 r-xp /usr/lib/libffi.so.5.0.10
f6a0d000 f6a0e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a16000 f6a26000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a2e000 f6a47000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a4f000 f6a51000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a59000 f6ace000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ad8000 f6ade000 r-xp /lib/librt-2.13.so
f6ae7000 f6b05000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b0f000 f6b10000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b18000 f6b3b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b43000 f6b48000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b50000 f6b7a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b83000 f6b9a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ba2000 f6c0b000 r-xp /lib/libm-2.13.so
f6c14000 f6ca8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cbb000 f6cc0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cc8000 f6ccf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cd7000 f6d01000 r-xp /usr/lib/libsensor.so.1.9.6
f6d0a000 f6dd6000 r-xp /usr/lib/libxml2.so.2.7.8
f6de3000 f6de5000 r-xp /usr/lib/libiniparser.so.0
f6dee000 f6df4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dfd000 f6ecd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ece000 f6f02000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f0b000 f6f47000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f4f000 f6f52000 r-xp /usr/lib/libbundle.so.0.1.22
f6f5a000 f6f60000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f68000 f6fa9000 r-xp /usr/lib/libeina.so.1.7.99
f6fb2000 f6fc9000 r-xp /usr/lib/libecore.so.1.7.99
f6fe0000 f6fe9000 r-xp /usr/lib/libvconf.so.0.2.45
f6ff1000 f7005000 r-xp /lib/libpthread-2.13.so
f7010000 f701d000 r-xp /usr/lib/libaul.so.0.1.0
f7027000 f7029000 r-xp /lib/libdl-2.13.so
f7032000 f703d000 r-xp /lib/libunwind.so.8.0.1
f706a000 f7072000 r-xp /lib/libgcc_s-4.6.so.1
f7073000 f7197000 r-xp /lib/libc-2.13.so
f71a5000 f71a7000 r-xp /usr/lib/libdlog.so.0.0.0
f71af000 f71bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71c4000 f71c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71d1000 f71e0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71e8000 f71ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71f5000 f71f8000 r-xp /usr/lib/libappcore-agent.so.1.1
f7200000 f7202000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f720a000 f720e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7216000 f7233000 r-xp /lib/ld-2.13.so
f723c000 f723f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f723f000 f7243000 r-xp /usr/lib/libsys-assert.so
f760c000 f769b000 rw-p [heap]
ffcc4000 ffce5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22041)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf723d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf71d4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6edb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ed9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ee5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6eebbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6eebdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f2075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f1b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ed9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ee5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6eebbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6eebdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f1de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f1e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f228d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf720c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf48b0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6983663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e30fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e327a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fc2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fbdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fbe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fbe879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71f6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71f67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf723d6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf708a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf723cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
d, ret : 0
04-23 16:01:00.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:00.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:00.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:00.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:00.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:00.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:00.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:00.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:00.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.091+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:00.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:00.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:00.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:00.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:00.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:00.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:00.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7346578
04-23 16:01:00.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733b2a8]
04-23 16:01:00.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:00.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:00.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:00.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:00.271+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:00.271+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.281+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:00.281+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:00.281+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.281+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:00.281+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:00.281+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:00.281+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:00.281+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:00.281+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:00.291+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:00.301+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:00.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:00.341+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:00.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:00.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:00.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:00.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733b2a8
04-23 16:01:00.841+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:01:00.841+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:00.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:00.851+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:00.861+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22061
04-23 16:01:00.861+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:00.911+0200 E/CAPI_APPFW_APPLICATION(22061): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:00.911+0200 E/CAPI_APPFW_APPLICATION(22061): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:00.931+0200 W/LOCATION(22061): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:00.931+0200 E/LOCATION(22061): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:00.931+0200 E/PKGMGR_INFO(22061): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:00.941+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.951+0200 I/LOCATION(22061): location.c: location_new(269) > method: 0
04-23 16:01:00.951+0200 W/LOCATION(22061): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:00.961+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.961+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:00.971+0200 W/LOCATION(22061): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:00.971+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:00.971+0200 W/LOCATION(22061): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:00.971+0200 W/LOCATION(22061): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:00.971+0200 W/LOCATION(22061): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:00.971+0200 W/LOCATION(22061): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:00.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22061
04-23 16:01:00.981+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22061) type(svcapp) bg(0)
04-23 16:01:00.981+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22061) was created
04-23 16:01:01.001+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:01.001+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:01.001+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22061]
04-23 16:01:01.011+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22061)
04-23 16:01:01.011+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:01:01.011+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:01.011+0200 W/LOCATION(22061): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:01.011+0200 W/LOCATION(22061): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:01.011+0200 W/LOCATION(22061): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:01.011+0200 W/LOCATION(22061): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:01.011+0200 W/LOCATION(22061): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:01.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:01.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22061
04-23 16:01:01.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:01.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:01.041+0200 W/LOCATION(22061): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:01.051+0200 I/LOCATION(22061): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7328c18
04-23 16:01:01.051+0200 I/LOCATION(22061): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:01.051+0200 I/LOCATION(22061): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7328c18
04-23 16:01:01.051+0200 I/LOCATION(22061): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:01.051+0200 I/location(22061): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:01.051+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22061
04-23 16:01:01.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:01.111+0200 I/LOCATION(22061): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:01.171+0200 W/LOCATION(22061): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:01.171+0200 W/LOCATION(22061): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:01.171+0200 I/LOCATION(22061): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:01.261+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:01.261+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:01.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:01.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:01.271+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:01.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:01.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:01.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:01.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:01.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:01.271+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:01.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:01.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:01.361+0200 W/LOCATION(22061): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:01.361+0200 W/LOCATION(22061): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:01.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:01.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:01.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:01.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:01.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:01.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7335308]
04-23 16:01:01.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:01.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:01.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:01.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:01.521+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:01.521+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:01.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.541+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:01.541+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:01.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:01.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:01.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:01.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:01.541+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:01.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:01.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:01.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:01.551+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5957211), time2(5952849)
04-23 16:01:01.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:01.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:01.551+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:01.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:01.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.561+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:01.561+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:01.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:01.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:01.621+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:01.621+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:01.621+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:01.661+0200 W/LOCATION(22061): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:01.661+0200 I/LOCATION(22061): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:01.661+0200 I/LOCATION(22061): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:01.661+0200 I/location(22061): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:01.771+0200 I/LOCATION(22061): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:01.811+0200 W/AUL     (22061): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:01.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:01.821+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22061
04-23 16:01:01.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:01.831+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:01.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:01.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.831+0200 I/utils   (19708): specific action
04-23 16:01:01.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.831+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:01.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:01.831+0200 W/AUL     (22061): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:01.831+0200 I/location(22061): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:01.831+0200 I/location(22061): stopping es.ugr.frailty.location service
04-23 16:01:01.831+0200 E/CAPI_APPFW_APP_CONTROL(22061): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:01.831+0200 E/location(22061): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:01.831+0200 I/CAPI_APPFW_APPLICATION(22061): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:01.831+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:01.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:01.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.841+0200 I/utils   (21185): specific action
04-23 16:01:01.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:01.841+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:01.841+0200 I/recorder(21185): guardando datos en local
04-23 16:01:01.841+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:01.841+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:01.841+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:01.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:01.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:01.841+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:01.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:01.881+0200 W/LOCATION(22061): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:01.881+0200 I/LOCATION(22061): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:01.881+0200 I/LOCATION(22061): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:01:01.981+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:01.981+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:01.981+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:01.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:02.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:02.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:02.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:02.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7335308
04-23 16:01:02.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e198f0]
04-23 16:01:02.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:02.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:02.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:02.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:02.271+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:02.271+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:02.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.281+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:02.281+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:02.281+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:02.281+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:02.281+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:02.281+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:02.281+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:02.281+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:02.281+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:02.291+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.301+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:02.311+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:02.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:02.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:02.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e198f0
04-23 16:01:02.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7381c88]
04-23 16:01:02.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:02.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:02.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:02.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:02.521+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:02.521+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:02.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.541+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:02.541+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:02.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:02.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:02.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:02.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:02.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:02.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:02.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:02.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:02.561+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:02.561+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:02.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:02.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:02.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:02.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7381c88
04-23 16:01:02.821+0200 W/AUL     (22075): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:02.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:02.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:02.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22041
04-23 16:01:02.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:02.821+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22041
04-23 16:01:02.821+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22041)
04-23 16:01:03.021+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:03.021+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:03.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:03.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:03.031+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22076
04-23 16:01:03.031+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:03.081+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22076
04-23 16:01:03.081+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22076) type(svcapp) bg(0)
04-23 16:01:03.091+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22076]
04-23 16:01:03.091+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22076)
04-23 16:01:03.091+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:03.091+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:03.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:03.101+0200 E/CAPI_APPFW_APPLICATION(22076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:03.101+0200 E/CAPI_APPFW_APPLICATION(22076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:03.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22076
04-23 16:01:03.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:03.111+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22076
04-23 16:01:03.111+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22076) was created
04-23 16:01:03.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:03.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:03.151+0200 W/LOCATION(22076): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:03.151+0200 E/LOCATION(22076): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:03.151+0200 E/PKGMGR_INFO(22076): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:03.151+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:03.181+0200 I/LOCATION(22076): location.c: location_new(269) > method: 0
04-23 16:01:03.181+0200 W/LOCATION(22076): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:03.181+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:03.191+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:03.191+0200 W/LOCATION(22076): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:03.201+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:03.201+0200 W/LOCATION(22076): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:03.201+0200 W/LOCATION(22076): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:03.201+0200 W/LOCATION(22076): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:03.201+0200 W/LOCATION(22076): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:03.221+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:03.231+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:03.241+0200 W/LOCATION(22076): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:03.241+0200 W/LOCATION(22076): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:03.241+0200 W/LOCATION(22076): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:03.241+0200 W/LOCATION(22076): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:03.241+0200 W/LOCATION(22076): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:03.271+0200 W/LOCATION(22076): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:03.271+0200 I/LOCATION(22076): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf76bfc18
04-23 16:01:03.271+0200 I/LOCATION(22076): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:03.271+0200 I/LOCATION(22076): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf76bfc18
04-23 16:01:03.271+0200 I/LOCATION(22076): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:03.271+0200 I/location(22076): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:03.361+0200 I/LOCATION(22076): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:03.411+0200 W/LOCATION(22076): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:03.411+0200 W/LOCATION(22076): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:03.411+0200 I/LOCATION(22076): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:03.491+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:03.491+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:03.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:03.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:03.501+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:03.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:03.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:03.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:03.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:03.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:03.501+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:03.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:03.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:03.561+0200 W/LOCATION(22076): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:03.571+0200 W/LOCATION(22076): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:03.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73494f8]
04-23 16:01:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:03.721+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:03.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:03.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:03.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:03.741+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:03.741+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:03.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:03.741+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:03.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:03.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:03.751+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:03.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:03.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:03.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:03.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:03.761+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:03.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:03.771+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:03.771+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5959430), time2(5952849)
04-23 16:01:03.771+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:03.771+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:03.771+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:03.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:03.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:03.831+0200 W/LOCATION(22076): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:03.831+0200 I/LOCATION(22076): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:03.831+0200 I/LOCATION(22076): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:03.831+0200 I/location(22076): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:03.841+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:03.921+0200 I/LOCATION(22076): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:03.971+0200 W/AUL     (22076): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:03.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:03.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22076
04-23 16:01:03.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:03.981+0200 W/AUL     (22076): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:03.981+0200 I/location(22076): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:03.981+0200 W/CAPI_APPFW_APP_CONTROL(22076): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:03.981+0200 I/utils   (22076): specific action
04-23 16:01:03.991+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:03.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:03.991+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:03.991+0200 I/utils   (19708): specific action
04-23 16:01:03.991+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:03.991+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:03.991+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:03.991+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:03.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:03.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:04.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:04.001+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:04.001+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:04.001+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:04.001+0200 I/utils   (21185): specific action
04-23 16:01:04.001+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:04.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:04.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:04.001+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:04.001+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:04.001+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:04.001+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:04.001+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:04.001+0200 I/recorder(21185): guardando datos en local
04-23 16:01:04.301+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11220416c6f63152449205
