S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11371
Date: 2018-04-23 20:37:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75cc52d, r5   = 0xf7b5cf98
r6   = 0xffa6c320, r7   = 0xffa6c1d0
r8   = 0xf7b59c18, r9   = 0x00000000
r10  = 0xffa6c2ac, fp   = 0xffa6c320
ip   = 0x00000001, sp   = 0xffa6c1a8
lr   = 0xf75cc539, pc   = 0xf7635228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    136612 KB
Buffers:     38664 KB
Cached:     159248 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12008 KB
VmRSS:       12008 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11371 TID = 11371
11371 11374 

Maps Information
f4497000 f4c96000 rw-p [stack:11374]
f4c9d000 f4c9f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ca7000 f4cab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cb4000 f4cb6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cbe000 f4cc1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cd0000 f4cd5000 r-xp /usr/lib/libsystem.so.0.0.0
f4ce0000 f4ce3000 r-xp /lib/libattr.so.1.1.0
f4ceb000 f4cfb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d03000 f4d0c000 r-xp /usr/lib/libedbus.so.1.7.99
f4d14000 f4d15000 r-xp /usr/lib/libresponse.so.0.2.96
f4d1e000 f4d23000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65c5000 f66cb000 r-xp /usr/lib/libicuuc.so.57.1
f66e1000 f6869000 r-xp /usr/lib/libicui18n.so.57.1
f6879000 f6886000 r-xp /usr/lib/libail.so.0.1.0
f688f000 f6896000 r-xp /usr/lib/libminizip.so.1.0.0
f689f000 f6a48000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a68000 f6aaf000 r-xp /usr/lib/libssl.so.1.0.0
f6abb000 f6abd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ac5000 f6acc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ad5000 f6adc000 r-xp /lib/libcrypt-2.13.so
f6b0d000 f6b10000 r-xp /lib/libcap.so.2.21
f6b18000 f6b1a000 r-xp /usr/lib/libiri.so
f6b22000 f6b6b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b73000 f6b79000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b81000 f6ba4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bae000 f6bb0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bb8000 f6bd5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bde000 f6be2000 r-xp /usr/lib/libsmack.so.1.0.0
f6beb000 f6c04000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c0d000 f6c15000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c1d000 f6c23000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c2c000 f6c2e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c37000 f6c47000 r-xp /lib/libresolv-2.13.so
f6c4b000 f6c63000 r-xp /usr/lib/liblzma.so.5.0.3
f6c6c000 f6c6e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c76000 f6c90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c98000 f6cc7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cd0000 f6cdf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ce9000 f6cf3000 r-xp /usr/lib/libsensord-shared.so
f6cfc000 f6dcf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dda000 f6df0000 r-xp /lib/libz.so.1.2.5
f6df8000 f6dfd000 r-xp /usr/lib/libffi.so.5.0.10
f6e05000 f6e06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e0e000 f6e1e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e26000 f6e3f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e47000 f6e49000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e51000 f6ec6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ed0000 f6ed6000 r-xp /lib/librt-2.13.so
f6edf000 f6efd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f07000 f6f08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f10000 f6f33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3b000 f6f40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f48000 f6f72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7b000 f6f92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9a000 f7003000 r-xp /lib/libm-2.13.so
f700c000 f70a0000 r-xp /usr/lib/libstdc++.so.6.0.16
f70b3000 f70b8000 r-xp /usr/lib/libctx-client.so.0.8.3
f70c0000 f70c7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70cf000 f70f9000 r-xp /usr/lib/libsensor.so.1.9.6
f7102000 f71ce000 r-xp /usr/lib/libxml2.so.2.7.8
f71db000 f71dd000 r-xp /usr/lib/libiniparser.so.0
f71e6000 f71ec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71f5000 f72c5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72c6000 f72fa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7303000 f733f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7347000 f734a000 r-xp /usr/lib/libbundle.so.0.1.22
f7352000 f7358000 r-xp /usr/lib/libappsvc.so.0.1.0
f7360000 f73a1000 r-xp /usr/lib/libeina.so.1.7.99
f73aa000 f73c1000 r-xp /usr/lib/libecore.so.1.7.99
f73d8000 f73e1000 r-xp /usr/lib/libvconf.so.0.2.45
f73e9000 f73fd000 r-xp /lib/libpthread-2.13.so
f7408000 f7415000 r-xp /usr/lib/libaul.so.0.1.0
f741f000 f7421000 r-xp /lib/libdl-2.13.so
f742a000 f7435000 r-xp /lib/libunwind.so.8.0.1
f7462000 f746a000 r-xp /lib/libgcc_s-4.6.so.1
f746b000 f758f000 r-xp /lib/libc-2.13.so
f759d000 f759f000 r-xp /usr/lib/libdlog.so.0.0.0
f75a7000 f75b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75bc000 f75c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75c9000 f75d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75e0000 f75e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ed000 f75f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f75f8000 f75fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7602000 f7606000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f760e000 f762b000 r-xp /lib/ld-2.13.so
f7634000 f7637000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7637000 f763b000 r-xp /usr/lib/libsys-assert.so
f7b29000 f7bac000 rw-p [heap]
ffa4d000 ffa6e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11371)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7635228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72d33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7315e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7316017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf731df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cb51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ca8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d7b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7228fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf722a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73baca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73b5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73b65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73b6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf763553f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf748285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7634f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0:37:13.319+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:13.319+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.319+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:13.319+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:13.319+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:13.319+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:13.319+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:13.319+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:13.329+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.329+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.329+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:13.339+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:13.379+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:13.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:13.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:13.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:13.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:13.429+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf730af28
04-23 20:37:13.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf7328028]
04-23 20:37:13.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:13.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:13.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:13.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:13.489+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:13.489+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.499+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.509+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.509+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:13.509+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:13.509+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.509+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:13.509+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:13.509+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:13.509+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:13.509+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:13.509+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:13.519+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.519+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:13.519+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:13.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:13.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:13.579+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:13.579+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:13.579+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:13.579+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf7328028
04-23 20:37:13.619+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:37:13.619+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:13.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:13.619+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:13.639+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:13.639+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11324
04-23 20:37:13.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11324
04-23 20:37:13.689+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11324) type(svcapp) bg(0)
04-23 20:37:13.689+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11324)
04-23 20:37:13.689+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:37:13.689+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:13.699+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11324]
04-23 20:37:13.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:13.739+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11324
04-23 20:37:13.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:13.749+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11324
04-23 20:37:13.749+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:13.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:13.759+0200 E/CAPI_APPFW_APPLICATION(11324): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:13.759+0200 E/CAPI_APPFW_APPLICATION(11324): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:13.769+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11324) was created
04-23 20:37:13.799+0200 W/LOCATION(11324): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:13.799+0200 E/LOCATION(11324): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:13.799+0200 E/PKGMGR_INFO(11324): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:13.799+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.829+0200 I/LOCATION(11324): location.c: location_new(269) > method: 0
04-23 20:37:13.829+0200 W/LOCATION(11324): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:13.829+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.839+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:13.839+0200 W/LOCATION(11324): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:13.849+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:13.849+0200 W/LOCATION(11324): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:13.849+0200 W/LOCATION(11324): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:13.849+0200 W/LOCATION(11324): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:13.849+0200 W/LOCATION(11324): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:13.879+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:13.879+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:13.879+0200 W/LOCATION(11324): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:13.889+0200 W/LOCATION(11324): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:13.889+0200 W/LOCATION(11324): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:13.889+0200 W/LOCATION(11324): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:13.889+0200 W/LOCATION(11324): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:13.909+0200 W/LOCATION(11324): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:13.909+0200 I/LOCATION(11324): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73f1c18
04-23 20:37:13.909+0200 I/LOCATION(11324): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:13.909+0200 I/LOCATION(11324): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73f1c18
04-23 20:37:13.909+0200 I/LOCATION(11324): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:13.919+0200 I/location(11324): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:13.969+0200 I/LOCATION(11324): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:14.009+0200 W/LOCATION(11324): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:14.009+0200 W/LOCATION(11324): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:14.009+0200 I/LOCATION(11324): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:14.079+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:14.079+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:14.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:14.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:14.079+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:14.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:14.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:14.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:14.079+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:14.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:14.089+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:14.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:14.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:14.139+0200 W/LOCATION(11324): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:14.139+0200 W/LOCATION(11324): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:14.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.259+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf7314158]
04-23 20:37:14.259+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:14.259+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:14.259+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:14.259+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:14.269+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:14.269+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:14.279+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.279+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.279+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:14.279+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:14.279+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:14.279+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:14.279+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:14.279+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:14.279+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:14.279+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:14.279+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:14.289+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.299+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.299+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:14.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:14.329+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2709594), time2(2706420)
04-23 20:37:14.329+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:37:14.329+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:14.329+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:14.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:14.339+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.379+0200 W/LOCATION(11324): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:14.379+0200 I/LOCATION(11324): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:14.379+0200 I/LOCATION(11324): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:14.379+0200 I/location(11324): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:14.469+0200 I/LOCATION(11324): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:14.519+0200 W/AUL     (11324): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:14.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:14.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11324
04-23 20:37:14.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:14.529+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:14.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:14.529+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.529+0200 I/utils   (10115): specific action
04-23 20:37:14.529+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.529+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.529+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.529+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:14.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:14.529+0200 W/AUL     (11324): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:14.529+0200 I/location(11324): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:14.529+0200 I/location(11324): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:14:524,nan,37.171662,-3.594189,0.000000,0,0.000000,43.000000,-1.000000
04-23 20:37:14.529+0200 I/location(11324): stopping es.ugr.frailty.location service
04-23 20:37:14.529+0200 E/CAPI_APPFW_APP_CONTROL(11324): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:37:14.529+0200 E/location(11324): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:37:14.529+0200 I/CAPI_APPFW_APPLICATION(11324): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:37:14.529+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:14.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:14.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:37:14.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:37:14.539+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:14.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:14.549+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:14.549+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:14.549+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:14.549+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.549+0200 I/utils   (10120): specific action
04-23 20:37:14.549+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.549+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.549+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.549+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:14.549+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:14.549+0200 I/recorder(10120): guardando datos en local
04-23 20:37:14.579+0200 W/LOCATION(11324): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:14.579+0200 I/LOCATION(11324): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:14.579+0200 I/LOCATION(11324): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:37:14.649+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:37:14.649+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:37:14.649+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:37:14.649+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:37:14.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.789+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:14.789+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:14.789+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:14.789+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf7314158
04-23 20:37:14.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72e2228]
04-23 20:37:14.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:14.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:14.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:14.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:14.849+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:14.849+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:14.859+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.869+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.869+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:14.869+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:14.869+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:14.869+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:14.869+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:14.869+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:14.869+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:14.869+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:14.869+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:14.879+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.879+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:14.879+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:14.889+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.939+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:14.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:14.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:14.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:14.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72e2228
04-23 20:37:15.029+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72e0630]
04-23 20:37:15.029+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:15.029+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:15.029+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:15.029+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:15.039+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:15.039+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:15.049+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:15.059+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:15.059+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:15.059+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:15.059+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:15.059+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:15.059+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:15.059+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:15.059+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:15.059+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:15.059+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:15.069+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:15.069+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:15.069+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:15.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:15.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:15.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:15.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:15.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:15.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72e0630
04-23 20:37:15.329+0200 W/AUL     (11335): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:37:15.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:37:15.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:37:15.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11299
04-23 20:37:15.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:37:15.339+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11299
04-23 20:37:15.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11299)
04-23 20:37:16.539+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:37:23.699+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:37:23.699+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:23.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:23.699+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:23.729+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11371
04-23 20:37:23.729+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:23.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11371
04-23 20:37:23.779+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11371) type(svcapp) bg(0)
04-23 20:37:23.789+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11371]
04-23 20:37:23.799+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11371)
04-23 20:37:23.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:23.819+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11371
04-23 20:37:23.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:23.819+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:37:23.819+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:23.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:23.839+0200 E/CAPI_APPFW_APPLICATION(11371): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:23.839+0200 E/CAPI_APPFW_APPLICATION(11371): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:23.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11371
04-23 20:37:23.849+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11371) was created
04-23 20:37:23.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:23.869+0200 W/LOCATION(11371): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:23.869+0200 E/LOCATION(11371): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:23.869+0200 E/PKGMGR_INFO(11371): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:23.869+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:23.889+0200 I/LOCATION(11371): location.c: location_new(269) > method: 0
04-23 20:37:23.889+0200 W/LOCATION(11371): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:23.899+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:23.899+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:23.909+0200 W/LOCATION(11371): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:23.909+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:23.909+0200 W/LOCATION(11371): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:23.909+0200 W/LOCATION(11371): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:23.909+0200 W/LOCATION(11371): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:23.909+0200 W/LOCATION(11371): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:23.929+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:23.939+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:23.939+0200 W/LOCATION(11371): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:23.939+0200 W/LOCATION(11371): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:23.949+0200 W/LOCATION(11371): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:23.949+0200 W/LOCATION(11371): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:23.949+0200 W/LOCATION(11371): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:23.959+0200 W/LOCATION(11371): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:23.959+0200 I/LOCATION(11371): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b59c18
04-23 20:37:23.959+0200 I/LOCATION(11371): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:23.959+0200 I/LOCATION(11371): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b59c18
04-23 20:37:23.959+0200 I/LOCATION(11371): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:23.969+0200 I/location(11371): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:24.009+0200 I/LOCATION(11371): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:24.069+0200 W/LOCATION(11371): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:24.069+0200 W/LOCATION(11371): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:24.069+0200 I/LOCATION(11371): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:24.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:24.159+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:24.159+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:24.159+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:24.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:24.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:24.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:24.159+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:24.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:24.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:24.169+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:24.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:24.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:24.219+0200 W/LOCATION(11371): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:24.219+0200 W/LOCATION(11371): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:24.309+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:24.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72d1110]
04-23 20:37:24.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:24.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:24.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:24.359+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:24.369+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:24.369+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:24.379+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:24.389+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:24.389+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:24.389+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:24.389+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:24.389+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:24.389+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:24.389+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:24.389+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:24.389+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:24.389+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:24.399+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:24.419+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:24.419+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:24.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:24.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:24.479+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2719744), time2(2706420)
04-23 20:37:24.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:37:24.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:24.479+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:24.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:24.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:24.499+0200 W/LOCATION(11371): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:24.499+0200 I/LOCATION(11371): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:24.499+0200 I/LOCATION(11371): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:24.499+0200 I/location(11371): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:24.599+0200 I/LOCATION(11371): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:24.659+0200 W/AUL     (11371): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:24.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:24.659+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11371
04-23 20:37:24.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:24.669+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.669+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:24.669+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:24.669+0200 W/AUL     (11371): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:24.669+0200 I/location(11371): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:24.669+0200 I/location(11371): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:24:658,nan,37.171662,-3.594189,0.000000,0,0.000000,43.000000,-1.000000
04-23 20:37:24.669+0200 W/CAPI_APPFW_APP_CONTROL(11371): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.669+0200 I/utils   (11371): specific action
04-23 20:37:24.669+0200 I/utils   (10115): specific action
04-23 20:37:24.669+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.669+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.669+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.669+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:24.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:24.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:24.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:24.679+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.679+0200 I/utils   (10120): specific action
04-23 20:37:24.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:24.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:24.679+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.679+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.679+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:24.679+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.679+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:24.679+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:24.679+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:24.679+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:24.679+0200 I/recorder(10120): guardando datos en local
04-23 20:37:25.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:25.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:25.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:25.499+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:37:26.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:26.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:26.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:26.259+0200 W/LOCATION(11371): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:37:26.469+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11113716c6f63152450864
