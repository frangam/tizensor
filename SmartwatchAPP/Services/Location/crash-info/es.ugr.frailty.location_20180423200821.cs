S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6769
Date: 2018-04-23 20:08:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71c052d, r5   = 0xf796bf98
r6   = 0xffe9b4b0, r7   = 0xffe9b360
r8   = 0xf7968c18, r9   = 0x00000000
r10  = 0xffe9b43c, fp   = 0xffe9b4b0
ip   = 0x00000001, sp   = 0xffe9b338
lr   = 0xf71c0539, pc   = 0xf7229228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111228 KB
Buffers:     38960 KB
Cached:     184944 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11868 KB
VmRSS:       11868 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6769 TID = 6769
6769 6772 

Maps Information
f408b000 f488a000 rw-p [stack:6772]
f4891000 f4893000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f489b000 f489f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48a8000 f48aa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48b2000 f48b5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48c4000 f48c9000 r-xp /usr/lib/libsystem.so.0.0.0
f48d4000 f48d7000 r-xp /lib/libattr.so.1.1.0
f48df000 f48ef000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48f7000 f4900000 r-xp /usr/lib/libedbus.so.1.7.99
f4908000 f4909000 r-xp /usr/lib/libresponse.so.0.2.96
f4912000 f4917000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61b9000 f62bf000 r-xp /usr/lib/libicuuc.so.57.1
f62d5000 f645d000 r-xp /usr/lib/libicui18n.so.57.1
f646d000 f647a000 r-xp /usr/lib/libail.so.0.1.0
f6483000 f648a000 r-xp /usr/lib/libminizip.so.1.0.0
f6493000 f663c000 r-xp /usr/lib/libcrypto.so.1.0.0
f665c000 f66a3000 r-xp /usr/lib/libssl.so.1.0.0
f66af000 f66b1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66b9000 f66c0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66c9000 f66d0000 r-xp /lib/libcrypt-2.13.so
f6701000 f6704000 r-xp /lib/libcap.so.2.21
f670c000 f670e000 r-xp /usr/lib/libiri.so
f6716000 f675f000 r-xp /usr/lib/libmdm.so.1.2.69
f6767000 f676d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6775000 f6798000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67a2000 f67a4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67ac000 f67c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67d2000 f67d6000 r-xp /usr/lib/libsmack.so.1.0.0
f67df000 f67f8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6801000 f6809000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6811000 f6817000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6820000 f6822000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f682b000 f683b000 r-xp /lib/libresolv-2.13.so
f683f000 f6857000 r-xp /usr/lib/liblzma.so.5.0.3
f6860000 f6862000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f686a000 f6884000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f688c000 f68bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68c4000 f68d3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68dd000 f68e7000 r-xp /usr/lib/libsensord-shared.so
f68f0000 f69c3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69ce000 f69e4000 r-xp /lib/libz.so.1.2.5
f69ec000 f69f1000 r-xp /usr/lib/libffi.so.5.0.10
f69f9000 f69fa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a02000 f6a12000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a1a000 f6a33000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a3b000 f6a3d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a45000 f6aba000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ac4000 f6aca000 r-xp /lib/librt-2.13.so
f6ad3000 f6af1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6afb000 f6afc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b04000 f6b27000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b2f000 f6b34000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b3c000 f6b66000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b6f000 f6b86000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b8e000 f6bf7000 r-xp /lib/libm-2.13.so
f6c00000 f6c94000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ca7000 f6cac000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cb4000 f6cbb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cc3000 f6ced000 r-xp /usr/lib/libsensor.so.1.9.6
f6cf6000 f6dc2000 r-xp /usr/lib/libxml2.so.2.7.8
f6dcf000 f6dd1000 r-xp /usr/lib/libiniparser.so.0
f6dda000 f6de0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6de9000 f6eb9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eba000 f6eee000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ef7000 f6f33000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f3b000 f6f3e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f46000 f6f4c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f54000 f6f95000 r-xp /usr/lib/libeina.so.1.7.99
f6f9e000 f6fb5000 r-xp /usr/lib/libecore.so.1.7.99
f6fcc000 f6fd5000 r-xp /usr/lib/libvconf.so.0.2.45
f6fdd000 f6ff1000 r-xp /lib/libpthread-2.13.so
f6ffc000 f7009000 r-xp /usr/lib/libaul.so.0.1.0
f7013000 f7015000 r-xp /lib/libdl-2.13.so
f701e000 f7029000 r-xp /lib/libunwind.so.8.0.1
f7056000 f705e000 r-xp /lib/libgcc_s-4.6.so.1
f705f000 f7183000 r-xp /lib/libc-2.13.so
f7191000 f7193000 r-xp /usr/lib/libdlog.so.0.0.0
f719b000 f71a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71b0000 f71b5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71bd000 f71cc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71d4000 f71d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71e1000 f71e4000 r-xp /usr/lib/libappcore-agent.so.1.1
f71ec000 f71ee000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71f6000 f71fa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7202000 f721f000 r-xp /lib/ld-2.13.so
f7228000 f722b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f722b000 f722f000 r-xp /usr/lib/libsys-assert.so
f7938000 f79a9000 rw-p [heap]
ffe7c000 ffe9d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6769)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7229228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71c0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ec73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ec5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ed1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ed7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ed7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f0c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f071f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ec5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ed1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ed7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ed7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f09e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f0a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f11f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48a91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf489c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf696f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e1cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e1e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6faeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fa9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6faa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6faa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71e2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71e27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72294f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf707685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7228f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
TION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:08.799+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:08.799+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:08.799+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:08.799+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:08.799+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:08.799+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:08.809+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:08.809+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:08.809+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:08.819+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:08.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:08.879+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:08.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:08.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:08.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:08.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f34760
04-23 20:08:08.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1d838]
04-23 20:08:08.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:08.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:08.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:08.989+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:08.989+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:08.989+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:08.999+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.009+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.009+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:09.009+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:09.009+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.009+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:09.009+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:09.009+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:09.009+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:09.009+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:09.009+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:09.019+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.029+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.029+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:09.029+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:09.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:09.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:09.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:09.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:09.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1d838
04-23 20:08:09.179+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:08:09.179+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:09.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:09.179+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:09.189+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6719
04-23 20:08:09.199+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:09.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6719
04-23 20:08:09.249+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6719) type(svcapp) bg(0)
04-23 20:08:09.249+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6719)
04-23 20:08:09.249+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:08:09.249+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:09.249+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6719]
04-23 20:08:09.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:09.269+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6719
04-23 20:08:09.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:09.279+0200 E/CAPI_APPFW_APPLICATION( 6719): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:09.289+0200 E/CAPI_APPFW_APPLICATION( 6719): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:09.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:09.299+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6719
04-23 20:08:09.299+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6719) was created
04-23 20:08:09.299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:09.319+0200 W/LOCATION( 6719): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:09.319+0200 E/LOCATION( 6719): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:09.319+0200 E/PKGMGR_INFO( 6719): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:09.339+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.369+0200 I/LOCATION( 6719): location.c: location_new(269) > method: 0
04-23 20:08:09.369+0200 W/LOCATION( 6719): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:09.379+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.379+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.389+0200 W/LOCATION( 6719): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:09.389+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:09.399+0200 W/LOCATION( 6719): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:09.399+0200 W/LOCATION( 6719): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:09.399+0200 W/LOCATION( 6719): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:09.399+0200 W/LOCATION( 6719): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:09.429+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:09.429+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:09.439+0200 W/LOCATION( 6719): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:09.439+0200 W/LOCATION( 6719): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:09.439+0200 W/LOCATION( 6719): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:09.439+0200 W/LOCATION( 6719): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:09.439+0200 W/LOCATION( 6719): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:09.469+0200 W/LOCATION( 6719): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:09.469+0200 I/LOCATION( 6719): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7704c18
04-23 20:08:09.469+0200 I/LOCATION( 6719): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:09.469+0200 I/LOCATION( 6719): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7704c18
04-23 20:08:09.469+0200 I/LOCATION( 6719): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:09.469+0200 I/location( 6719): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:09.529+0200 I/LOCATION( 6719): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:09.579+0200 W/LOCATION( 6719): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:09.579+0200 W/LOCATION( 6719): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:09.579+0200 I/LOCATION( 6719): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:09.669+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:09.669+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:09.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:09.669+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:09.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:09.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:09.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:09.669+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:09.669+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:09.669+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:09.669+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:09.669+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:09.739+0200 W/LOCATION( 6719): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:09.749+0200 W/LOCATION( 6719): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:09.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:09.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d4198]
04-23 20:08:09.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:09.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:09.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:09.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:09.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:09.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.889+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.899+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:09.899+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:09.899+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:09.899+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:09.899+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:09.899+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:09.899+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:09.899+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:09.899+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:09.909+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.919+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:09.919+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:09.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:09.959+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:09.959+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(965226), time2(961977)
04-23 20:08:09.959+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:08:09.959+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:09.959+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:09.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:09.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:10.009+0200 W/LOCATION( 6719): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:10.009+0200 I/LOCATION( 6719): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:10.009+0200 I/LOCATION( 6719): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:10.009+0200 I/location( 6719): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:10.119+0200 I/LOCATION( 6719): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:10.179+0200 E/location( 6719): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:10.179+0200 W/AUL     ( 6719): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:10.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:10.179+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6719
04-23 20:08:10.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:10.189+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:10.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:10.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.189+0200 I/utils   ( 5532): specific action
04-23 20:08:10.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.189+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:10.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:10.209+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:10.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:10.219+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:10.219+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:10.219+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:10.219+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.219+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:10.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:10.219+0200 I/utils   ( 5538): specific action
04-23 20:08:10.219+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.219+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.219+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.219+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:10.219+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:10.219+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:10.229+0200 W/AUL     ( 6719): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:10.229+0200 I/location( 6719): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:10.229+0200 I/location( 6719): stopping es.ugr.frailty.location service
04-23 20:08:10.229+0200 E/CAPI_APPFW_APP_CONTROL( 6719): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:08:10.229+0200 E/location( 6719): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:08:10.229+0200 I/CAPI_APPFW_APPLICATION( 6719): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:08:10.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:08:10.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:08:10.299+0200 W/LOCATION( 6719): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:10.309+0200 I/LOCATION( 6719): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:10.309+0200 I/LOCATION( 6719): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:10.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:10.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:10.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:08:10.589+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:08:10.589+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:08:10.589+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:08:10.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:08:10.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:10.749+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:10.749+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:10.749+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:10.749+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d4198
04-23 20:08:10.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a00e98]
04-23 20:08:10.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:10.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:10.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:10.849+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:10.859+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:10.859+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:10.869+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:10.879+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:10.879+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:10.879+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:10.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:10.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:10.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:10.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:10.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:10.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:10.889+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:10.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:10.909+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:10.909+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:10.909+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:10.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:10.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:11.019+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:11.019+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:11.019+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:11.019+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a00e98
04-23 20:08:11.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8d18]
04-23 20:08:11.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:11.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:11.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:11.079+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:11.089+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:11.089+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:11.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:11.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:11.109+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:11.109+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:11.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:11.109+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:11.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:11.109+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:11.109+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:11.109+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:11.109+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:11.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:11.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:11.119+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:11.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:11.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:11.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:11.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:11.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:11.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d8d18
04-23 20:08:11.389+0200 W/AUL     ( 6733): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:08:11.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:08:11.399+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:08:11.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6695
04-23 20:08:11.399+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:08:11.399+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6695
04-23 20:08:11.399+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6695)
04-23 20:08:12.239+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:08:19.259+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:08:19.259+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:19.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:19.259+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:19.269+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6769
04-23 20:08:19.269+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:19.319+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6769
04-23 20:08:19.319+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6769) type(svcapp) bg(0)
04-23 20:08:19.319+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6769)
04-23 20:08:19.319+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:08:19.319+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:19.319+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6769]
04-23 20:08:19.339+0200 E/CAPI_APPFW_APPLICATION( 6769): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:19.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:19.359+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6769
04-23 20:08:19.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:19.359+0200 E/CAPI_APPFW_APPLICATION( 6769): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:19.359+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6769) was created
04-23 20:08:19.389+0200 W/LOCATION( 6769): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:19.389+0200 E/LOCATION( 6769): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:19.389+0200 E/PKGMGR_INFO( 6769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:19.399+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:19.409+0200 I/LOCATION( 6769): location.c: location_new(269) > method: 0
04-23 20:08:19.409+0200 W/LOCATION( 6769): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:19.419+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:19.419+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:19.429+0200 W/LOCATION( 6769): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:19.429+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:19.429+0200 W/LOCATION( 6769): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:19.429+0200 W/LOCATION( 6769): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:19.429+0200 W/LOCATION( 6769): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:19.429+0200 W/LOCATION( 6769): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:19.449+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:19.459+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:19.459+0200 W/LOCATION( 6769): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:19.459+0200 W/LOCATION( 6769): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:19.459+0200 W/LOCATION( 6769): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:19.459+0200 W/LOCATION( 6769): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:19.459+0200 W/LOCATION( 6769): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:19.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:19.479+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6769
04-23 20:08:19.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:19.489+0200 W/LOCATION( 6769): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:19.489+0200 I/LOCATION( 6769): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7968c18
04-23 20:08:19.489+0200 I/LOCATION( 6769): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:19.489+0200 I/LOCATION( 6769): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7968c18
04-23 20:08:19.489+0200 I/LOCATION( 6769): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:19.499+0200 I/location( 6769): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:19.549+0200 I/LOCATION( 6769): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:19.589+0200 W/LOCATION( 6769): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:19.589+0200 W/LOCATION( 6769): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:19.589+0200 I/LOCATION( 6769): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:19.649+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:19.649+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:19.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:19.659+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:19.659+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:19.659+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:19.659+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:19.659+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:19.659+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:19.659+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:19.659+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:19.659+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:19.659+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:19.709+0200 W/LOCATION( 6769): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:19.709+0200 W/LOCATION( 6769): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:19.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:19.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a10df8]
04-23 20:08:19.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:19.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:19.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:19.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:19.829+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:19.829+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:19.839+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:19.839+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:19.839+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:19.839+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:19.839+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:19.839+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:19.839+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:19.839+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:19.839+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:19.839+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:19.839+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:19.849+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:19.859+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:19.859+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:19.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:19.899+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:19.909+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:19.909+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(975178), time2(961977)
04-23 20:08:19.909+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:08:19.909+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:19.909+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:19.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:19.939+0200 W/LOCATION( 6769): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:19.939+0200 I/LOCATION( 6769): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:19.939+0200 I/LOCATION( 6769): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:19.939+0200 I/location( 6769): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:20.019+0200 I/LOCATION( 6769): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:20.069+0200 E/location( 6769): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:20.069+0200 W/AUL     ( 6769): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:20.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:20.069+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6769
04-23 20:08:20.079+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:20.079+0200 W/AUL     ( 6769): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:20.079+0200 I/location( 6769): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:20.079+0200 W/CAPI_APPFW_APP_CONTROL( 6769): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.079+0200 I/utils   ( 6769): specific action
04-23 20:08:20.079+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:20.079+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:20.079+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.079+0200 I/utils   ( 5532): specific action
04-23 20:08:20.079+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.079+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.079+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.079+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:20.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:20.089+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:20.089+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:20.099+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:20.099+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:20.099+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.099+0200 I/utils   ( 5538): specific action
04-23 20:08:20.099+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.099+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.099+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.099+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:20.099+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:20.099+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:20.099+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:20.099+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:20.099+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:20.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:20.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:20.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:20.839+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:08:21.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:21.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:21.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:21.499+0200 W/LOCATION( 6769): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:08:21.659+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11067696c6f63152450690
