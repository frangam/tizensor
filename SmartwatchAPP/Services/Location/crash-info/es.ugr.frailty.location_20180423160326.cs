S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24000
Date: 2018-04-23 16:03:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf734452d, r5   = 0xf7553f98
r6   = 0xffaca798, r7   = 0xffaca648
r8   = 0xf7550c18, r9   = 0x00000000
r10  = 0xffaca724, fp   = 0xffaca798
ip   = 0x00000001, sp   = 0xffac94c8
lr   = 0xf7344539, pc   = 0xf73ad2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      6516 KB
Buffers:     61524 KB
Cached:     229512 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11584 KB
VmRSS:       11584 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24000 TID = 24000
24000 24003 

Maps Information
f420f000 f4a0e000 rw-p [stack:24003]
f4a15000 f4a17000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a1f000 f4a23000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a2c000 f4a2e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a36000 f4a39000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a48000 f4a4d000 r-xp /usr/lib/libsystem.so.0.0.0
f4a58000 f4a5b000 r-xp /lib/libattr.so.1.1.0
f4a63000 f4a73000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a7b000 f4a84000 r-xp /usr/lib/libedbus.so.1.7.99
f4a8c000 f4a8d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a96000 f4a9b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f633d000 f6443000 r-xp /usr/lib/libicuuc.so.57.1
f6459000 f65e1000 r-xp /usr/lib/libicui18n.so.57.1
f65f1000 f65fe000 r-xp /usr/lib/libail.so.0.1.0
f6607000 f660e000 r-xp /usr/lib/libminizip.so.1.0.0
f6617000 f67c0000 r-xp /usr/lib/libcrypto.so.1.0.0
f67e0000 f6827000 r-xp /usr/lib/libssl.so.1.0.0
f6833000 f6835000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f683d000 f6844000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f684d000 f6854000 r-xp /lib/libcrypt-2.13.so
f6885000 f6888000 r-xp /lib/libcap.so.2.21
f6890000 f6892000 r-xp /usr/lib/libiri.so
f689a000 f68e3000 r-xp /usr/lib/libmdm.so.1.2.69
f68eb000 f68f1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68f9000 f691c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6926000 f6928000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6930000 f694d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6956000 f695a000 r-xp /usr/lib/libsmack.so.1.0.0
f6963000 f697c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6985000 f698d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6995000 f699b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69a4000 f69a6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69af000 f69bf000 r-xp /lib/libresolv-2.13.so
f69c3000 f69db000 r-xp /usr/lib/liblzma.so.5.0.3
f69e4000 f69e6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69ee000 f6a08000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a10000 f6a3f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a48000 f6a57000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a61000 f6a6b000 r-xp /usr/lib/libsensord-shared.so
f6a74000 f6b47000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b52000 f6b68000 r-xp /lib/libz.so.1.2.5
f6b70000 f6b75000 r-xp /usr/lib/libffi.so.5.0.10
f6b7d000 f6b7e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b86000 f6b96000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b9e000 f6bb7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bbf000 f6bc1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bc9000 f6c3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c48000 f6c4e000 r-xp /lib/librt-2.13.so
f6c57000 f6c75000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c7f000 f6c80000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c88000 f6cab000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cb3000 f6cb8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cc0000 f6cea000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cf3000 f6d0a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d12000 f6d7b000 r-xp /lib/libm-2.13.so
f6d84000 f6e18000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e2b000 f6e30000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e38000 f6e3f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e47000 f6e71000 r-xp /usr/lib/libsensor.so.1.9.6
f6e7a000 f6f46000 r-xp /usr/lib/libxml2.so.2.7.8
f6f53000 f6f55000 r-xp /usr/lib/libiniparser.so.0
f6f5e000 f6f64000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f6d000 f703d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f703e000 f7072000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f707b000 f70b7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70bf000 f70c2000 r-xp /usr/lib/libbundle.so.0.1.22
f70ca000 f70d0000 r-xp /usr/lib/libappsvc.so.0.1.0
f70d8000 f7119000 r-xp /usr/lib/libeina.so.1.7.99
f7122000 f7139000 r-xp /usr/lib/libecore.so.1.7.99
f7150000 f7159000 r-xp /usr/lib/libvconf.so.0.2.45
f7161000 f7175000 r-xp /lib/libpthread-2.13.so
f7180000 f718d000 r-xp /usr/lib/libaul.so.0.1.0
f7197000 f7199000 r-xp /lib/libdl-2.13.so
f71a2000 f71ad000 r-xp /lib/libunwind.so.8.0.1
f71da000 f71e2000 r-xp /lib/libgcc_s-4.6.so.1
f71e3000 f7307000 r-xp /lib/libc-2.13.so
f7315000 f7317000 r-xp /usr/lib/libdlog.so.0.0.0
f731f000 f732b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7334000 f7339000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7341000 f7350000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7358000 f735c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7365000 f7368000 r-xp /usr/lib/libappcore-agent.so.1.1
f7370000 f7372000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f737a000 f737e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7386000 f73a3000 r-xp /lib/ld-2.13.so
f73ac000 f73af000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73af000 f73b3000 r-xp /usr/lib/libsys-assert.so
f7520000 f7591000 rw-p [heap]
ffaab000 ffacc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24000)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf73ad2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7344539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf704b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7049c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7055e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf705bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf705bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf709075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf708b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7049c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7055e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf705bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf705bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf708de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf708e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70928d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf737c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4a20171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6af3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fa0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fa27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7132ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf712db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf712e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf712e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7366183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73667fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73ad6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf71fa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf73acfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
to get app_id. Err[-1]
04-23 16:03:37.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:37.431+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:37:329,75
04-23 16:03:37.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:37.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:37.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:37.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:37.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e0f608
04-23 16:03:37.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:37.531+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:37:531,74
04-23 16:03:37.651+0200 W/AUL     (24149): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:37.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:37.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:37.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24117
04-23 16:03:37.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:37.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24117
04-23 16:03:37.661+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24117)
04-23 16:03:37.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:37.721+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:37:731,74
04-23 16:03:37.771+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:37.771+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:37.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:37.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:37.791+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24150
04-23 16:03:37.791+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:37.841+0200 E/CAPI_APPFW_APPLICATION(24150): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:37.841+0200 E/CAPI_APPFW_APPLICATION(24150): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:37.861+0200 W/LOCATION(24150): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:37.861+0200 E/LOCATION(24150): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:37.861+0200 E/PKGMGR_INFO(24150): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:37.861+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:37.881+0200 I/LOCATION(24150): location.c: location_new(269) > method: 0
04-23 16:03:37.881+0200 W/LOCATION(24150): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:37.891+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:37.891+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:37.891+0200 W/LOCATION(24150): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:37.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24150
04-23 16:03:37.901+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24150) type(svcapp) bg(0)
04-23 16:03:37.901+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24150)
04-23 16:03:37.901+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:37.901+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:37.901+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24150) was created
04-23 16:03:37.901+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:37.901+0200 W/LOCATION(24150): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:37.901+0200 W/LOCATION(24150): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:37.901+0200 W/LOCATION(24150): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:37.901+0200 W/LOCATION(24150): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:37.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:37.921+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:37.931+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:37.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:37:930,74
04-23 16:03:37.931+0200 W/LOCATION(24150): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:37.931+0200 W/LOCATION(24150): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:37.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24150]
04-23 16:03:37.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:37.951+0200 W/LOCATION(24150): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:37.951+0200 W/LOCATION(24150): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:37.951+0200 W/LOCATION(24150): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:37.961+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24150
04-23 16:03:37.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:37.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24150
04-23 16:03:37.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:37.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:37.981+0200 W/LOCATION(24150): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:37.981+0200 I/LOCATION(24150): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7675c18
04-23 16:03:37.981+0200 I/LOCATION(24150): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:37.981+0200 I/LOCATION(24150): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7675c18
04-23 16:03:37.981+0200 I/LOCATION(24150): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:37.991+0200 I/location(24150): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:38.041+0200 I/LOCATION(24150): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:38.081+0200 W/LOCATION(24150): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:38.081+0200 W/LOCATION(24150): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:38.081+0200 I/LOCATION(24150): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:38.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:38.131+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:38:130,74
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:38.181+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:38.181+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:38.181+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:38.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:38.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:38.191+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:38.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:38.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:38.251+0200 W/LOCATION(24150): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:38.251+0200 W/LOCATION(24150): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:38.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:38.331+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:38:330,74
04-23 16:03:38.351+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:38.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:38.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:38.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:38.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:38.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01438]
04-23 16:03:38.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:38.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:38.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:38.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:38.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:38.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:38.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.431+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:38.431+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:38.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:38.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:38.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:38.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:38.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:38.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:38.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:38.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.441+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:38.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:38.491+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:38.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.511+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:38.511+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:38.511+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:38.511+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:38.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:38.531+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:38.531+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6114191), time2(6112138)
04-23 16:03:38.531+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:38.531+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:38.531+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:38.531+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:38.531+0200 W/LOCATION(24150): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:38.541+0200 I/LOCATION(24150): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:38.541+0200 I/LOCATION(24150): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:38.541+0200 I/location(24150): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:38.541+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:38:532,75
04-23 16:03:38.621+0200 I/LOCATION(24150): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:38.661+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:38.671+0200 W/AUL     (24150): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:38.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:38.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24150
04-23 16:03:38.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:38.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.681+0200 I/utils   (19708): specific action
04-23 16:03:38.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:38.681+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:38.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:38.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:38.681+0200 W/AUL     (24150): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:38.681+0200 I/location(24150): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:38.681+0200 W/CAPI_APPFW_APP_CONTROL(24150): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.681+0200 I/utils   (24150): specific action
04-23 16:03:38.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:38.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:38.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:38.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:38.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.701+0200 I/utils   (22624): specific action
04-23 16:03:38.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:38.711+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:38.711+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:38.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:38.711+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:38.711+0200 I/recorder(22624): guardando datos en local
04-23 16:03:38.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:38.731+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:38:732,75
04-23 16:03:38.781+0200 I/LOCATION(24150): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:38.931+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:38.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:38:935,75
04-23 16:03:38.951+0200 W/AUL     (24161): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:38.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:38.951+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:38.951+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24134
04-23 16:03:38.951+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:38.951+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24134
04-23 16:03:38.951+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24134)
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:39.081+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:39.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:39.081+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:39.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:39.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:39.131+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:39:131,75
04-23 16:03:39.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:39.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:39.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:39.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01438
04-23 16:03:39.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03428]
04-23 16:03:39.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:39.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:39.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:39.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:39.221+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:39.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:39.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.241+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.241+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:39.241+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:39.241+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:39.241+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:39.241+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:39.241+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:39.241+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:39.241+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:39.241+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:39.251+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.261+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.261+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:39.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.321+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.341+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:39.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:39.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:39.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:39.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03428
04-23 16:03:39.381+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:39:332,74
04-23 16:03:39.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e05378]
04-23 16:03:39.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:39.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:39.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:39.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:39.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:39.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:39.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.451+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:39.451+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:39.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:39.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:39.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:39.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:39.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:39.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:39.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:39.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.471+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:39.471+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:39.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:39.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:39.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:39.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:39.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e05378
04-23 16:03:39.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:39.541+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:39:533,75
04-23 16:03:39.731+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:39.731+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:39:735,74
04-23 16:03:39.901+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:03:39.901+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:39.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:39.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:39.911+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24168
04-23 16:03:39.911+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:39.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:39.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:39:931,74
04-23 16:03:39.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24168
04-23 16:03:39.961+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24168) type(svcapp) bg(0)
04-23 16:03:39.971+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24168)
04-23 16:03:39.971+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:39.971+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:39.971+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24168]
04-23 16:03:39.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:39.991+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24168
04-23 16:03:39.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:40.001+0200 E/CAPI_APPFW_APPLICATION(24168): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:40.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:40.011+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24168
04-23 16:03:40.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:40.011+0200 E/CAPI_APPFW_APPLICATION(24168): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:40.011+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24168) was created
04-23 16:03:40.041+0200 W/LOCATION(24168): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:40.051+0200 E/LOCATION(24168): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:40.051+0200 E/PKGMGR_INFO(24168): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:40.051+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.081+0200 I/LOCATION(24168): location.c: location_new(269) > method: 0
04-23 16:03:40.081+0200 W/LOCATION(24168): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.091+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.091+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.101+0200 W/LOCATION(24168): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:40.101+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:40.101+0200 W/LOCATION(24168): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:40.101+0200 W/LOCATION(24168): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.101+0200 W/LOCATION(24168): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:40.101+0200 W/LOCATION(24168): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:40.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.131+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:132,74
04-23 16:03:40.131+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:40.141+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:40.151+0200 W/LOCATION(24168): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:40.151+0200 W/LOCATION(24168): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:40.151+0200 W/LOCATION(24168): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:40.151+0200 W/LOCATION(24168): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:40.151+0200 W/LOCATION(24168): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:40.171+0200 W/LOCATION(24168): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:40.181+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7630c18
04-23 16:03:40.181+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:40.181+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7630c18
04-23 16:03:40.181+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:40.181+0200 I/location(24168): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:40.251+0200 I/LOCATION(24168): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:40.311+0200 W/LOCATION(24168): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:40.311+0200 W/LOCATION(24168): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:40.311+0200 I/LOCATION(24168): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:40.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.381+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:331,74
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:40.401+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:40.401+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:40.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:40.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:40.401+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:40.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:40.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:40.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:40.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:40.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:40.411+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:40.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:40.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:40.491+0200 W/LOCATION(24168): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:40.491+0200 W/LOCATION(24168): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:40.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.531+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:532,74
04-23 16:03:40.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d528]
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:40.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.641+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:40.641+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:40.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:40.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:40.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.661+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:40.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.731+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:734,74
04-23 16:03:40.731+0200 W/LOCATION(24168): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:40.731+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:40.731+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:40.731+0200 I/location(24168): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:40.851+0200 I/LOCATION(24168): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:40.901+0200 W/AUL     (24168): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:40.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:40.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24168
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:40.911+0200 W/AUL     (24168): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:40.911+0200 I/location(24168): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:40.911+0200 I/location(24168): stopping es.ugr.frailty.location service
04-23 16:03:40.911+0200 E/CAPI_APPFW_APP_CONTROL(24168): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:40.911+0200 E/location(24168): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:40.911+0200 I/CAPI_APPFW_APPLICATION(24168): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 I/utils   (19708): specific action
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:40.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:40.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:40.931+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:40.931+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:40.931+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:40.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:40.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 I/utils   (22624): specific action
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:40.931+0200 I/recorder(22624): guardando datos en local
04-23 16:03:40.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:932,75
04-23 16:03:40.981+0200 W/LOCATION(24168): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:40.981+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:40.981+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:03:41.081+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:41.081+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:41.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:41.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.131+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:133,75
04-23 16:03:41.131+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11240006c6f63152449220
