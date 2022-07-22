S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22834
Date: 2018-04-23 16:02:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74f652d, r5   = 0xf7be3f98
r6   = 0xff86f6c8, r7   = 0xff86f578
r8   = 0xf7be0c18, r9   = 0x00000000
r10  = 0xff86f654, fp   = 0xff86f6c8
ip   = 0x00000001, sp   = 0xff86e3f8
lr   = 0xf74f6539, pc   = 0xf755f2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10388 KB
Buffers:     60588 KB
Cached:     225764 KB
VmPeak:      53460 KB
VmSize:      53432 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11652 KB
VmRSS:       11652 KB
VmData:      11160 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22834 TID = 22834
22834 22839 

Maps Information
f43c1000 f4bc0000 rw-p [stack:22839]
f4bc7000 f4bc9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bd1000 f4bd5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bde000 f4be0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4be8000 f4beb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bfa000 f4bff000 r-xp /usr/lib/libsystem.so.0.0.0
f4c0a000 f4c0d000 r-xp /lib/libattr.so.1.1.0
f4c15000 f4c25000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c2d000 f4c36000 r-xp /usr/lib/libedbus.so.1.7.99
f4c3e000 f4c3f000 r-xp /usr/lib/libresponse.so.0.2.96
f4c48000 f4c4d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64ef000 f65f5000 r-xp /usr/lib/libicuuc.so.57.1
f660b000 f6793000 r-xp /usr/lib/libicui18n.so.57.1
f67a3000 f67b0000 r-xp /usr/lib/libail.so.0.1.0
f67b9000 f67c0000 r-xp /usr/lib/libminizip.so.1.0.0
f67c9000 f6972000 r-xp /usr/lib/libcrypto.so.1.0.0
f6992000 f69d9000 r-xp /usr/lib/libssl.so.1.0.0
f69e5000 f69e7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69ef000 f69f6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69ff000 f6a06000 r-xp /lib/libcrypt-2.13.so
f6a37000 f6a3a000 r-xp /lib/libcap.so.2.21
f6a42000 f6a44000 r-xp /usr/lib/libiri.so
f6a4c000 f6a95000 r-xp /usr/lib/libmdm.so.1.2.69
f6a9d000 f6aa3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aab000 f6ace000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ad8000 f6ada000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae2000 f6aff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b08000 f6b0c000 r-xp /usr/lib/libsmack.so.1.0.0
f6b15000 f6b2e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b37000 f6b3f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b47000 f6b4d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b56000 f6b58000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b61000 f6b71000 r-xp /lib/libresolv-2.13.so
f6b75000 f6b8d000 r-xp /usr/lib/liblzma.so.5.0.3
f6b96000 f6b98000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ba0000 f6bba000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc2000 f6bf1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bfa000 f6c09000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c13000 f6c1d000 r-xp /usr/lib/libsensord-shared.so
f6c26000 f6cf9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d04000 f6d1a000 r-xp /lib/libz.so.1.2.5
f6d22000 f6d27000 r-xp /usr/lib/libffi.so.5.0.10
f6d2f000 f6d30000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d38000 f6d48000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d50000 f6d69000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d71000 f6d73000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d7b000 f6df0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dfa000 f6e00000 r-xp /lib/librt-2.13.so
f6e09000 f6e27000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e31000 f6e32000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e3a000 f6e5d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e65000 f6e6a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e72000 f6e9c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea5000 f6ebc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec4000 f6f2d000 r-xp /lib/libm-2.13.so
f6f36000 f6fca000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdd000 f6fe2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fea000 f6ff1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ff9000 f7023000 r-xp /usr/lib/libsensor.so.1.9.6
f702c000 f70f8000 r-xp /usr/lib/libxml2.so.2.7.8
f7105000 f7107000 r-xp /usr/lib/libiniparser.so.0
f7110000 f7116000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f711f000 f71ef000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71f0000 f7224000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f722d000 f7269000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7271000 f7274000 r-xp /usr/lib/libbundle.so.0.1.22
f727c000 f7282000 r-xp /usr/lib/libappsvc.so.0.1.0
f728a000 f72cb000 r-xp /usr/lib/libeina.so.1.7.99
f72d4000 f72eb000 r-xp /usr/lib/libecore.so.1.7.99
f7302000 f730b000 r-xp /usr/lib/libvconf.so.0.2.45
f7313000 f7327000 r-xp /lib/libpthread-2.13.so
f7332000 f733f000 r-xp /usr/lib/libaul.so.0.1.0
f7349000 f734b000 r-xp /lib/libdl-2.13.so
f7354000 f735f000 r-xp /lib/libunwind.so.8.0.1
f738c000 f7394000 r-xp /lib/libgcc_s-4.6.so.1
f7395000 f74b9000 r-xp /lib/libc-2.13.so
f74c7000 f74c9000 r-xp /usr/lib/libdlog.so.0.0.0
f74d1000 f74dd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e6000 f74eb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f3000 f7502000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f750a000 f750e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7517000 f751a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7522000 f7524000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f752c000 f7530000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7538000 f7555000 r-xp /lib/ld-2.13.so
f755e000 f7561000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7561000 f7565000 r-xp /usr/lib/libsys-assert.so
f7bb0000 f7c1d000 rw-p [heap]
ff850000 ff871000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22834)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf755f2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74f6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71fd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7207e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf720dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf720ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf723d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7207e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf720dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf720ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf723fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7240017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72448d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf752e0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4bd2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7152fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71547a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72dfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72e05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72e0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7518183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75187fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf755f6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf73ac85c) [/lib/libc.so.6] + 0x1785c
29: (0xf755efa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:59.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:59.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:59.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:59.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:59.831+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:59.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:59.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:59.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:00.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:00.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:00.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:00.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e191f0
04-23 16:02:00.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e02140]
04-23 16:02:00.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:00.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:00.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:00.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:00.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.091+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:00.091+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:00.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.091+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:00.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:00.091+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:00.091+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.091+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:00.091+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:00.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.101+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:00.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:00.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:00.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:00.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:00.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:00.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e02140
04-23 16:02:00.291+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:02:00.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:00.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:00.301+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:00.341+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22821
04-23 16:02:00.341+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:00.401+0200 E/AUL_AMD ( 2476): amd_launch.c: __check_cmdline(540) > error founded when being launched with 22821
04-23 16:02:00.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22821
04-23 16:02:00.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22821) type(svcapp) bg(0)
04-23 16:02:00.451+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22821]
04-23 16:02:00.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22821)
04-23 16:02:00.471+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:02:00.481+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:00.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:00.491+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22821
04-23 16:02:00.501+0200 E/CAPI_APPFW_APPLICATION(22821): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:00.501+0200 E/CAPI_APPFW_APPLICATION(22821): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:00.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:00.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:00.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22821
04-23 16:02:00.521+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22821) was created
04-23 16:02:00.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:00.541+0200 W/LOCATION(22821): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:00.541+0200 E/LOCATION(22821): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:00.541+0200 E/PKGMGR_INFO(22821): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:00.551+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.571+0200 I/LOCATION(22821): location.c: location_new(269) > method: 0
04-23 16:02:00.571+0200 W/LOCATION(22821): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.571+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.581+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.581+0200 W/LOCATION(22821): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:00.581+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:00.591+0200 W/LOCATION(22821): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:00.591+0200 W/LOCATION(22821): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.591+0200 W/LOCATION(22821): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:00.591+0200 W/LOCATION(22821): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:00.611+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:00.611+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:00.611+0200 W/LOCATION(22821): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:00.621+0200 W/LOCATION(22821): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:00.621+0200 W/LOCATION(22821): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:00.621+0200 W/LOCATION(22821): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:00.621+0200 W/LOCATION(22821): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:00.641+0200 W/LOCATION(22821): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:00.641+0200 I/LOCATION(22821): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77eac18
04-23 16:02:00.641+0200 I/LOCATION(22821): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:00.641+0200 I/LOCATION(22821): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77eac18
04-23 16:02:00.641+0200 I/LOCATION(22821): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:00.641+0200 I/location(22821): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:00.691+0200 I/LOCATION(22821): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:00.731+0200 W/LOCATION(22821): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:00.731+0200 W/LOCATION(22821): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:00.731+0200 I/LOCATION(22821): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:00.811+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:00.811+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:00.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:00.811+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:00.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:00.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:00.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:00.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:00.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:00.811+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:00.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:00.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:00.861+0200 W/LOCATION(22821): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:00.861+0200 W/LOCATION(22821): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:00.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:00.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7376080]
04-23 16:02:00.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:00.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:00.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:00.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:00.981+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:00.991+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:00.991+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:00.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:00.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:00.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:00.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:00.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:00.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:00.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:01.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.011+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:01.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.051+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:01.051+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6016714), time2(6008699)
04-23 16:02:01.051+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:01.051+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:01.051+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:01.051+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:01.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.081+0200 W/LOCATION(22821): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:01.081+0200 I/LOCATION(22821): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:01.081+0200 I/LOCATION(22821): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:01.081+0200 I/location(22821): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:01.171+0200 I/LOCATION(22821): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:01.211+0200 W/AUL     (22821): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:01.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:01.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22821
04-23 16:02:01.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:01.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:01.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:01.231+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.231+0200 I/utils   (19708): specific action
04-23 16:02:01.231+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.231+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.231+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.231+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:01.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:01.231+0200 W/AUL     (22821): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:01.231+0200 I/location(22821): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:01.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:01.231+0200 I/location(22821): stopping es.ugr.frailty.location service
04-23 16:02:01.231+0200 E/CAPI_APPFW_APP_CONTROL(22821): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:01.231+0200 E/location(22821): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:01.231+0200 I/CAPI_APPFW_APPLICATION(22821): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:01.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:01.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.241+0200 I/utils   (22624): specific action
04-23 16:02:01.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:01.241+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:01.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:01.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:01.241+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:01.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:01.241+0200 I/recorder(22624): guardando datos en local
04-23 16:02:01.241+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:01.241+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:01.241+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:01.281+0200 W/LOCATION(22821): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:01.281+0200 I/LOCATION(22821): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:01.281+0200 I/LOCATION(22821): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:02:01.371+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:01.371+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:01.371+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:01.381+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:01.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:01.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateIdle: e,c,g)
04-23 16:02:01.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateIdle: e,c,g)
04-23 16:02:01.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:01.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:01.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:01.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7376080
04-23 16:02:01.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e19238]
04-23 16:02:01.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:01.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:01.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:01.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:01.581+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:01.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:01.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.601+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:01.601+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:01.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:01.601+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:01.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:01.601+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:01.601+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:01.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:01.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:01.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.611+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:01.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:01.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:01.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:01.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e19238
04-23 16:02:01.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18c90]
04-23 16:02:01.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:01.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:01.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:01.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:01.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:01.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:01.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.801+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:01.801+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:01.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:01.801+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:01.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:01.801+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:01.801+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:01.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:01.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:01.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:01.811+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:01.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:01.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:01.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:01.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:01.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18c90
04-23 16:02:02.071+0200 W/AUL     (22833): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:02.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:02.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:02.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22796
04-23 16:02:02.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:02.071+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22796
04-23 16:02:02.071+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22796)
04-23 16:02:02.481+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:02.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:02.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:02.481+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:02.491+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22834
04-23 16:02:02.491+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:02.541+0200 E/CAPI_APPFW_APPLICATION(22834): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:02.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22834
04-23 16:02:02.541+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22834) type(svcapp) bg(0)
04-23 16:02:02.541+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22834]
04-23 16:02:02.541+0200 E/CAPI_APPFW_APPLICATION(22834): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:02.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:02.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22834
04-23 16:02:02.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:02.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22834)
04-23 16:02:02.571+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:02.571+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:02.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:02.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22834
04-23 16:02:02.591+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22834) was created
04-23 16:02:02.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:02.621+0200 W/LOCATION(22834): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:02.621+0200 E/LOCATION(22834): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:02.621+0200 E/PKGMGR_INFO(22834): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:02.621+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:02.641+0200 I/LOCATION(22834): location.c: location_new(269) > method: 0
04-23 16:02:02.641+0200 W/LOCATION(22834): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:02.641+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:02.651+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:02.651+0200 W/LOCATION(22834): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:02.661+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:02.661+0200 W/LOCATION(22834): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:02.661+0200 W/LOCATION(22834): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:02.661+0200 W/LOCATION(22834): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:02.661+0200 W/LOCATION(22834): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:02.681+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:02.681+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:02.691+0200 W/LOCATION(22834): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:02.691+0200 W/LOCATION(22834): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:02.691+0200 W/LOCATION(22834): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:02.691+0200 W/LOCATION(22834): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:02.691+0200 W/LOCATION(22834): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:02.711+0200 W/LOCATION(22834): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:02.711+0200 I/LOCATION(22834): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7be0c18
04-23 16:02:02.711+0200 I/LOCATION(22834): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:02.711+0200 I/LOCATION(22834): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7be0c18
04-23 16:02:02.711+0200 I/LOCATION(22834): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:02.721+0200 I/location(22834): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:02.771+0200 I/LOCATION(22834): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:02.811+0200 W/LOCATION(22834): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:02.811+0200 W/LOCATION(22834): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:02.811+0200 I/LOCATION(22834): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:02.891+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:02.891+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:02.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:02.891+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:02.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:02.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:02.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:02.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:02.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:02.891+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:02.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:02.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:02.961+0200 W/LOCATION(22834): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:02.961+0200 W/LOCATION(22834): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:03.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:03.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03838]
04-23 16:02:03.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:03.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:03.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:03.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:03.091+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:03.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:03.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.101+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:03.101+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:03.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:03.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:03.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:03.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:03.101+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:03.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:03.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:03.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.121+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:03.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:03.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:03.131+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6018794), time2(6008699)
04-23 16:02:03.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:02:03.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:03.131+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:03.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:03.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:03.191+0200 W/LOCATION(22834): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:03.191+0200 I/LOCATION(22834): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:03.191+0200 I/LOCATION(22834): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:03.191+0200 I/location(22834): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:03.241+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:03.321+0200 I/LOCATION(22834): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:03.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:03.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:03.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:03.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:03.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:03.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:03.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:03.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:03.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:03.431+0200 W/AUL     (22834): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:03.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:03.431+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22834
04-23 16:02:03.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:03.441+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:03.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:03.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.441+0200 I/utils   (19708): specific action
04-23 16:02:03.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.441+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:03.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:03.441+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:03.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:03.451+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:03.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 I/utils   (22624): specific action
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:03.461+0200 I/recorder(22624): guardando datos en local
04-23 16:02:03.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:03.461+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:03.461+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:03.461+0200 W/AUL     (22834): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:03.461+0200 I/location(22834): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:03.461+0200 W/CAPI_APPFW_APP_CONTROL(22834): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:03.461+0200 I/utils   (22834): specific action
04-23 16:02:03.501+0200 I/LOCATION(22834): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:03.621+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11228346c6f63152449212
