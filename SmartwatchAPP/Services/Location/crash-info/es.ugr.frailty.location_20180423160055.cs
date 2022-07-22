S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21978
Date: 2018-04-23 16:00:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf707452d, r5   = 0xf73e5f98
r6   = 0xffae7f78, r7   = 0xffae7e28
r8   = 0xf73e2c18, r9   = 0x00000000
r10  = 0xffae7f04, fp   = 0xffae7f78
ip   = 0x00000001, sp   = 0xffae6ca8
lr   = 0xf7074539, pc   = 0xf70dd2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11432 KB
Buffers:     59800 KB
Cached:     232264 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11648 KB
VmRSS:       11648 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21978 TID = 21978
21978 21982 

Maps Information
f3f3f000 f473e000 rw-p [stack:21982]
f4745000 f4747000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f474f000 f4753000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f475c000 f475e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4766000 f4769000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4778000 f477d000 r-xp /usr/lib/libsystem.so.0.0.0
f4788000 f478b000 r-xp /lib/libattr.so.1.1.0
f4793000 f47a3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47ab000 f47b4000 r-xp /usr/lib/libedbus.so.1.7.99
f47bc000 f47bd000 r-xp /usr/lib/libresponse.so.0.2.96
f47c6000 f47cb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f606d000 f6173000 r-xp /usr/lib/libicuuc.so.57.1
f6189000 f6311000 r-xp /usr/lib/libicui18n.so.57.1
f6321000 f632e000 r-xp /usr/lib/libail.so.0.1.0
f6337000 f633e000 r-xp /usr/lib/libminizip.so.1.0.0
f6347000 f64f0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6510000 f6557000 r-xp /usr/lib/libssl.so.1.0.0
f6563000 f6565000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f656d000 f6574000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f657d000 f6584000 r-xp /lib/libcrypt-2.13.so
f65b5000 f65b8000 r-xp /lib/libcap.so.2.21
f65c0000 f65c2000 r-xp /usr/lib/libiri.so
f65ca000 f6613000 r-xp /usr/lib/libmdm.so.1.2.69
f661b000 f6621000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6629000 f664c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6656000 f6658000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6660000 f667d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6686000 f668a000 r-xp /usr/lib/libsmack.so.1.0.0
f6693000 f66ac000 r-xp /usr/lib/libnetwork.so.0.0.0
f66b5000 f66bd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66c5000 f66cb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66d4000 f66d6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66df000 f66ef000 r-xp /lib/libresolv-2.13.so
f66f3000 f670b000 r-xp /usr/lib/liblzma.so.5.0.3
f6714000 f6716000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f671e000 f6738000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6740000 f676f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6778000 f6787000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6791000 f679b000 r-xp /usr/lib/libsensord-shared.so
f67a4000 f6877000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6882000 f6898000 r-xp /lib/libz.so.1.2.5
f68a0000 f68a5000 r-xp /usr/lib/libffi.so.5.0.10
f68ad000 f68ae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68b6000 f68c6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68ce000 f68e7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68ef000 f68f1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68f9000 f696e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6978000 f697e000 r-xp /lib/librt-2.13.so
f6987000 f69a5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69af000 f69b0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69b8000 f69db000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69e3000 f69e8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69f0000 f6a1a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a23000 f6a3a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a42000 f6aab000 r-xp /lib/libm-2.13.so
f6ab4000 f6b48000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b5b000 f6b60000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b68000 f6b6f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b77000 f6ba1000 r-xp /usr/lib/libsensor.so.1.9.6
f6baa000 f6c76000 r-xp /usr/lib/libxml2.so.2.7.8
f6c83000 f6c85000 r-xp /usr/lib/libiniparser.so.0
f6c8e000 f6c94000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c9d000 f6d6d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d6e000 f6da2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dab000 f6de7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6def000 f6df2000 r-xp /usr/lib/libbundle.so.0.1.22
f6dfa000 f6e00000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e08000 f6e49000 r-xp /usr/lib/libeina.so.1.7.99
f6e52000 f6e69000 r-xp /usr/lib/libecore.so.1.7.99
f6e80000 f6e89000 r-xp /usr/lib/libvconf.so.0.2.45
f6e91000 f6ea5000 r-xp /lib/libpthread-2.13.so
f6eb0000 f6ebd000 r-xp /usr/lib/libaul.so.0.1.0
f6ec7000 f6ec9000 r-xp /lib/libdl-2.13.so
f6ed2000 f6edd000 r-xp /lib/libunwind.so.8.0.1
f6f0a000 f6f12000 r-xp /lib/libgcc_s-4.6.so.1
f6f13000 f7037000 r-xp /lib/libc-2.13.so
f7045000 f7047000 r-xp /usr/lib/libdlog.so.0.0.0
f704f000 f705b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7064000 f7069000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7071000 f7080000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7088000 f708c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7095000 f7098000 r-xp /usr/lib/libappcore-agent.so.1.1
f70a0000 f70a2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70aa000 f70ae000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70b6000 f70d3000 r-xp /lib/ld-2.13.so
f70dc000 f70df000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70df000 f70e3000 r-xp /usr/lib/libsys-assert.so
f73b2000 f7440000 rw-p [heap]
ffac9000 ffaea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21978)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf70dd2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7074539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d7b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dc075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dbb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d79c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d85e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d8bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d8bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dbde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dbe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dc28d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf70ac0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4750171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6823663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cd0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cd27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e62ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e5db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e5e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e5e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7096183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70967fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70dd6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6f2a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70dcfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:54.121+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:54.121+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:54.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:54.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:54.141+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:54.141+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:54.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:54.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:54.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:54.161+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:54.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:54.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:54.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:54.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:54.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:54.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e05ce0
04-23 16:00:54.421+0200 W/AUL     (21977): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:54.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:54.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:54.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21938
04-23 16:00:54.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:54.421+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21938
04-23 16:00:54.421+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21938)
04-23 16:00:54.441+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:54.441+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:54.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:54.441+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:54.451+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21978
04-23 16:00:54.461+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:54.501+0200 E/CAPI_APPFW_APPLICATION(21978): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:54.501+0200 E/CAPI_APPFW_APPLICATION(21978): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:54.531+0200 W/LOCATION(21978): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:54.531+0200 E/LOCATION(21978): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:54.531+0200 E/PKGMGR_INFO(21978): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:54.531+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21978
04-23 16:00:54.531+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21978) type(svcapp) bg(0)
04-23 16:00:54.531+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:54.531+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21978) was created
04-23 16:00:54.531+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21978)
04-23 16:00:54.531+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:54.531+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:54.541+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21978]
04-23 16:00:54.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:54.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21978
04-23 16:00:54.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:54.561+0200 I/LOCATION(21978): location.c: location_new(269) > method: 0
04-23 16:00:54.561+0200 W/LOCATION(21978): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:54.571+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:54.571+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:54.581+0200 W/LOCATION(21978): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:54.581+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:54.591+0200 W/LOCATION(21978): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:54.591+0200 W/LOCATION(21978): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:54.591+0200 W/LOCATION(21978): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:54.591+0200 W/LOCATION(21978): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:54.621+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:54.631+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:54.631+0200 W/LOCATION(21978): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:54.631+0200 W/LOCATION(21978): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:54.641+0200 W/LOCATION(21978): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:54.641+0200 W/LOCATION(21978): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:54.641+0200 W/LOCATION(21978): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:54.651+0200 W/LOCATION(21978): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:54.661+0200 I/LOCATION(21978): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73e2c18
04-23 16:00:54.661+0200 I/LOCATION(21978): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:54.661+0200 I/LOCATION(21978): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73e2c18
04-23 16:00:54.661+0200 I/LOCATION(21978): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:54.661+0200 I/location(21978): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:54.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:54.721+0200 I/LOCATION(21978): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:54.731+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21978
04-23 16:00:54.731+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:54.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:54.761+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:54.791+0200 W/LOCATION(21978): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:54.791+0200 W/LOCATION(21978): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:54.791+0200 I/LOCATION(21978): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:54.881+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:54.881+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:54.881+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:54.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:54.881+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:54.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:54.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:54.981+0200 W/LOCATION(21978): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:54.981+0200 W/LOCATION(21978): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:55.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:55.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:55.131+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5950792), time2(5942254)
04-23 16:00:55.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:55.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:55.131+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:55.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:55.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332be8]
04-23 16:00:55.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:55.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:55.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:55.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:55.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:55.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:55.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.181+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:55.181+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:55.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:55.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:55.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:55.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:55.181+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:55.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:55.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:55.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.191+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:55.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:55.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:55.261+0200 W/LOCATION(21978): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:55.261+0200 I/LOCATION(21978): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:55.261+0200 I/LOCATION(21978): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:55.261+0200 I/location(21978): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:55.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:55.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:55.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:55.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:55.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:55.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:55.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:55.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:55.451+0200 I/LOCATION(21978): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:55.531+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:55.541+0200 W/AUL     (21978): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:55.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:55.541+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21978
04-23 16:00:55.551+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:55.551+0200 W/AUL     (21978): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:55.551+0200 I/location(21978): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:55.551+0200 W/CAPI_APPFW_APP_CONTROL(21978): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.551+0200 I/utils   (21978): specific action
04-23 16:00:55.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.551+0200 I/utils   (19708): specific action
04-23 16:00:55.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.551+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:55.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:55.551+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:55.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:55.561+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:55.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:55.561+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:55.561+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:55.561+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:55.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:55.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(21185), cmd(0)
04-23 16:00:55.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.571+0200 I/utils   (21185): specific action
04-23 16:00:55.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:55.571+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:55.571+0200 I/recorder(21185): guardando datos en local
04-23 16:00:55.631+0200 I/LOCATION(21978): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:55.781+0200 W/AUL     (21988): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:55.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:55.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:55.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21961
04-23 16:00:55.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:00:55.781+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:55.781+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:55.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:55.781+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:55.781+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21961
04-23 16:00:55.781+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21961)
04-23 16:00:55.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:55.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:55.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:55.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:55.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332be8
04-23 16:00:55.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7370aa8]
04-23 16:00:55.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:55.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:55.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:55.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:55.911+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:55.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:55.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.931+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:55.931+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:55.931+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:55.931+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:55.931+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:55.931+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:55.931+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:55.931+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:55.931+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:55.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.951+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:55.951+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:55.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:56.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:56.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:56.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:56.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:56.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:56.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7370aa8
04-23 16:00:56.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73474c0]
04-23 16:00:56.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:56.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:56.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:56.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:56.121+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:56.121+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:56.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:56.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:56.141+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:56.141+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:56.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:56.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:56.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:56.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:56.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:56.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:56.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:56.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:56.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:56.161+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:56.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:56.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:56.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:56.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:56.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:56.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73474c0
04-23 16:00:56.541+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:00:56.541+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:56.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:56.541+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:56.551+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21993
04-23 16:00:56.551+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:56.601+0200 E/CAPI_APPFW_APPLICATION(21993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:56.601+0200 E/CAPI_APPFW_APPLICATION(21993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:56.621+0200 W/LOCATION(21993): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:56.621+0200 E/LOCATION(21993): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:56.621+0200 E/PKGMGR_INFO(21993): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:56.631+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:56.641+0200 I/LOCATION(21993): location.c: location_new(269) > method: 0
04-23 16:00:56.651+0200 W/LOCATION(21993): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:56.651+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:56.651+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:56.661+0200 W/LOCATION(21993): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:56.661+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:56.661+0200 W/LOCATION(21993): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:56.661+0200 W/LOCATION(21993): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:56.661+0200 W/LOCATION(21993): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:56.661+0200 W/LOCATION(21993): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:56.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21993
04-23 16:00:56.671+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21993) type(svcapp) bg(0)
04-23 16:00:56.671+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21993) was created
04-23 16:00:56.681+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:56.681+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21993]
04-23 16:00:56.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21993)
04-23 16:00:56.691+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:56.691+0200 W/LOCATION(21993): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:56.701+0200 W/LOCATION(21993): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:56.701+0200 W/LOCATION(21993): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:56.701+0200 W/LOCATION(21993): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:56.701+0200 W/LOCATION(21993): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:56.701+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:00:56.701+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:56.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:56.711+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21993
04-23 16:00:56.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:56.721+0200 W/LOCATION(21993): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:56.721+0200 I/LOCATION(21993): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7637c18
04-23 16:00:56.721+0200 I/LOCATION(21993): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:56.721+0200 I/LOCATION(21993): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7637c18
04-23 16:00:56.721+0200 I/LOCATION(21993): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:56.721+0200 I/location(21993): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:56.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:56.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21993
04-23 16:00:56.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:56.771+0200 I/LOCATION(21993): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:56.821+0200 W/LOCATION(21993): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:56.821+0200 W/LOCATION(21993): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:56.821+0200 I/LOCATION(21993): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:56.931+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:56.931+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:56.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:56.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:56.931+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:56.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:56.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:56.931+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:56.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:56.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:56.941+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:56.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:56.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:57.011+0200 W/LOCATION(21993): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:57.011+0200 W/LOCATION(21993): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:57.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:57.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361e28]
04-23 16:00:57.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:57.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:57.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:57.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:57.171+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:57.171+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:57.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:57.181+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5952849), time2(5942254)
04-23 16:00:57.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:00:57.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:57.181+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:57.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:57.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.191+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:57.191+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:57.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:57.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:57.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:57.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:57.191+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:57.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:57.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:57.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.211+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:57.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:57.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:57.281+0200 W/LOCATION(21993): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:57.281+0200 I/LOCATION(21993): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:57.281+0200 I/LOCATION(21993): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:57.281+0200 I/location(21993): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:57.381+0200 I/LOCATION(21993): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:57.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:57.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:57.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:57.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:57.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:57.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:57.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:57.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:57.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:57.451+0200 W/AUL     (21993): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:57.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:57.451+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21993
04-23 16:00:57.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:57.461+0200 W/AUL     (21993): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:57.461+0200 I/location(21993): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:57.461+0200 I/location(21993): stopping es.ugr.frailty.location service
04-23 16:00:57.461+0200 E/CAPI_APPFW_APP_CONTROL(21993): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:57.461+0200 E/location(21993): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:57.461+0200 I/CAPI_APPFW_APPLICATION(21993): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:57.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.461+0200 I/utils   (19708): specific action
04-23 16:00:57.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:57.461+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:57.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:57.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:57.461+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:57.471+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:57.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:57.481+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:57.481+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:57.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:57.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:57.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.491+0200 I/utils   (21185): specific action
04-23 16:00:57.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:57.491+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:57.491+0200 I/recorder(21185): guardando datos en local
04-23 16:00:57.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:57.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:57.551+0200 W/LOCATION(21993): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:57.551+0200 I/LOCATION(21993): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:57.551+0200 I/LOCATION(21993): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:57.601+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11219786c6f63152449205
