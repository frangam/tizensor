S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22796
Date: 2018-04-23 16:01:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf773a52d, r5   = 0xf7a77f98
r6   = 0xfff0bf58, r7   = 0xfff0be08
r8   = 0xf7a74c18, r9   = 0x00000000
r10  = 0xfff0bee4, fp   = 0xfff0bf58
ip   = 0x00000001, sp   = 0xfff0ac88
lr   = 0xf773a539, pc   = 0xf77a32b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13660 KB
Buffers:     60528 KB
Cached:     223436 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12088 KB
VmRSS:       12088 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22796 TID = 22796
22796 22803 

Maps Information
f4605000 f4e04000 rw-p [stack:22803]
f4e0b000 f4e0d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e15000 f4e19000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e22000 f4e24000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e2c000 f4e2f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e3e000 f4e43000 r-xp /usr/lib/libsystem.so.0.0.0
f4e4e000 f4e51000 r-xp /lib/libattr.so.1.1.0
f4e59000 f4e69000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e71000 f4e7a000 r-xp /usr/lib/libedbus.so.1.7.99
f4e82000 f4e83000 r-xp /usr/lib/libresponse.so.0.2.96
f4e8c000 f4e91000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6733000 f6839000 r-xp /usr/lib/libicuuc.so.57.1
f684f000 f69d7000 r-xp /usr/lib/libicui18n.so.57.1
f69e7000 f69f4000 r-xp /usr/lib/libail.so.0.1.0
f69fd000 f6a04000 r-xp /usr/lib/libminizip.so.1.0.0
f6a0d000 f6bb6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bd6000 f6c1d000 r-xp /usr/lib/libssl.so.1.0.0
f6c29000 f6c2b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c33000 f6c3a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c43000 f6c4a000 r-xp /lib/libcrypt-2.13.so
f6c7b000 f6c7e000 r-xp /lib/libcap.so.2.21
f6c86000 f6c88000 r-xp /usr/lib/libiri.so
f6c90000 f6cd9000 r-xp /usr/lib/libmdm.so.1.2.69
f6ce1000 f6ce7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cef000 f6d12000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d1c000 f6d1e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d26000 f6d43000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d4c000 f6d50000 r-xp /usr/lib/libsmack.so.1.0.0
f6d59000 f6d72000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d7b000 f6d83000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d8b000 f6d91000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d9a000 f6d9c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6da5000 f6db5000 r-xp /lib/libresolv-2.13.so
f6db9000 f6dd1000 r-xp /usr/lib/liblzma.so.5.0.3
f6dda000 f6ddc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6de4000 f6dfe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e06000 f6e35000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e3e000 f6e4d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e57000 f6e61000 r-xp /usr/lib/libsensord-shared.so
f6e6a000 f6f3d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f48000 f6f5e000 r-xp /lib/libz.so.1.2.5
f6f66000 f6f6b000 r-xp /usr/lib/libffi.so.5.0.10
f6f73000 f6f74000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f7c000 f6f8c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f94000 f6fad000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fb5000 f6fb7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fbf000 f7034000 r-xp /usr/lib/libsqlite3.so.0.8.6
f703e000 f7044000 r-xp /lib/librt-2.13.so
f704d000 f706b000 r-xp /usr/lib/libsystemd.so.0.4.0
f7075000 f7076000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f707e000 f70a1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70a9000 f70ae000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70b6000 f70e0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70e9000 f7100000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7108000 f7171000 r-xp /lib/libm-2.13.so
f717a000 f720e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7221000 f7226000 r-xp /usr/lib/libctx-client.so.0.8.3
f722e000 f7235000 r-xp /usr/lib/libctx-shared.so.0.8.3
f723d000 f7267000 r-xp /usr/lib/libsensor.so.1.9.6
f7270000 f733c000 r-xp /usr/lib/libxml2.so.2.7.8
f7349000 f734b000 r-xp /usr/lib/libiniparser.so.0
f7354000 f735a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7363000 f7433000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7434000 f7468000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7471000 f74ad000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74b5000 f74b8000 r-xp /usr/lib/libbundle.so.0.1.22
f74c0000 f74c6000 r-xp /usr/lib/libappsvc.so.0.1.0
f74ce000 f750f000 r-xp /usr/lib/libeina.so.1.7.99
f7518000 f752f000 r-xp /usr/lib/libecore.so.1.7.99
f7546000 f754f000 r-xp /usr/lib/libvconf.so.0.2.45
f7557000 f756b000 r-xp /lib/libpthread-2.13.so
f7576000 f7583000 r-xp /usr/lib/libaul.so.0.1.0
f758d000 f758f000 r-xp /lib/libdl-2.13.so
f7598000 f75a3000 r-xp /lib/libunwind.so.8.0.1
f75d0000 f75d8000 r-xp /lib/libgcc_s-4.6.so.1
f75d9000 f76fd000 r-xp /lib/libc-2.13.so
f770b000 f770d000 r-xp /usr/lib/libdlog.so.0.0.0
f7715000 f7721000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f772a000 f772f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7737000 f7746000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f774e000 f7752000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f775b000 f775e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7766000 f7768000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7770000 f7774000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f777c000 f7799000 r-xp /lib/ld-2.13.so
f77a2000 f77a5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77a5000 f77a9000 r-xp /usr/lib/libsys-assert.so
f7a44000 f7ad2000 rw-p [heap]
ffeed000 fff0e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22796)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf77a32b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf773a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74413f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf743fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf744be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7451be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7451dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf748675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74811f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf743fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf744be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7451be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7451dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7483e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7484017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74888d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf77720bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4e16171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ee9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7396fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73987a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7528ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7523b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75245a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7524879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf775c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf775c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77a36a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf75f085c) [/lib/libc.so.6] + 0x1785c
29: (0xf77a2fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ON(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:53.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:53.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:53.851+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:53.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:53.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:53.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:53.861+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:53.861+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:53.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:53.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:53.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:53.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:53.861+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:53.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:53.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:53.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:53.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:53.881+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:53.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:53.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:53.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:53.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:53.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:53.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73764f8
04-23 16:01:54.091+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:54.091+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:54.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:54.091+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:54.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22717
04-23 16:01:54.101+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22717)
04-23 16:01:54.101+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:54.101+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:54.151+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:01:54.151+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:54.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22717), cmd(0)
04-23 16:01:54.161+0200 W/AUL     (22760): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:54.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:54.161+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:54.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22663
04-23 16:01:54.161+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:54.171+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22663
04-23 16:01:54.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22663)
04-23 16:01:54.531+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:54.621+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:55.311+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:56.121+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:01:56.121+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:56.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:56.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:56.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22763
04-23 16:01:56.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:56.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22763
04-23 16:01:56.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22763) type(svcapp) bg(0)
04-23 16:01:56.191+0200 E/CAPI_APPFW_APPLICATION(22763): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:56.191+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22763)
04-23 16:01:56.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22763]
04-23 16:01:56.201+0200 E/CAPI_APPFW_APPLICATION(22763): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:56.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:56.211+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:01:56.211+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:56.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22763
04-23 16:01:56.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:56.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22763
04-23 16:01:56.221+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22763) was created
04-23 16:01:56.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:56.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:56.231+0200 W/LOCATION(22763): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:56.231+0200 E/LOCATION(22763): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:56.231+0200 E/PKGMGR_INFO(22763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:56.241+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:56.251+0200 I/LOCATION(22763): location.c: location_new(269) > method: 0
04-23 16:01:56.251+0200 W/LOCATION(22763): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:56.261+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:56.261+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:56.271+0200 W/LOCATION(22763): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:56.271+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:56.271+0200 W/LOCATION(22763): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:56.271+0200 W/LOCATION(22763): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:56.271+0200 W/LOCATION(22763): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:56.271+0200 W/LOCATION(22763): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:56.291+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:56.301+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:56.301+0200 W/LOCATION(22763): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:56.301+0200 W/LOCATION(22763): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:56.311+0200 W/LOCATION(22763): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:56.311+0200 W/LOCATION(22763): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:56.311+0200 W/LOCATION(22763): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:56.381+0200 W/LOCATION(22763): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:56.381+0200 I/LOCATION(22763): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73cfc18
04-23 16:01:56.381+0200 I/LOCATION(22763): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:56.381+0200 I/LOCATION(22763): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73cfc18
04-23 16:01:56.381+0200 I/LOCATION(22763): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:56.391+0200 I/location(22763): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:56.431+0200 I/LOCATION(22763): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:56.471+0200 W/LOCATION(22763): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:56.471+0200 W/LOCATION(22763): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:56.471+0200 I/LOCATION(22763): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:56.551+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:56.551+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:56.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:56.551+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:56.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:56.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:56.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:56.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:56.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:56.551+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:56.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:56.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:56.611+0200 W/LOCATION(22763): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:56.611+0200 W/LOCATION(22763): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:56.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:56.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e22f28]
04-23 16:01:56.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:56.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:56.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:56.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:56.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:56.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:56.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:56.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:56.741+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:56.741+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:56.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:56.741+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:56.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:56.741+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:56.741+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:56.741+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:56.741+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:56.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:56.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:56.751+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:56.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:56.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:56.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:56.811+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6012475), time2(6008699)
04-23 16:01:56.811+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:56.811+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:56.811+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:56.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:56.831+0200 W/LOCATION(22763): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:56.831+0200 I/LOCATION(22763): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:56.831+0200 I/LOCATION(22763): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:56.831+0200 I/location(22763): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:56.941+0200 I/LOCATION(22763): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:57.011+0200 W/AUL     (22763): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:57.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:57.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22763
04-23 16:01:57.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:57.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.021+0200 I/utils   (19708): specific action
04-23 16:01:57.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.031+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:57.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:57.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:57.031+0200 W/AUL     (22763): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:57.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:57.031+0200 I/location(22763): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:57.031+0200 I/location(22763): stopping es.ugr.frailty.location service
04-23 16:01:57.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:57.031+0200 E/CAPI_APPFW_APP_CONTROL(22763): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:57.031+0200 E/location(22763): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:57.031+0200 I/CAPI_APPFW_APPLICATION(22763): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:57.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:01:57.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:57.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:57.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:57.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:01:57.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.041+0200 I/utils   (22624): specific action
04-23 16:01:57.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:57.041+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:57.041+0200 I/recorder(22624): guardando datos en local
04-23 16:01:57.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:01:57.041+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:57.041+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:57.081+0200 W/LOCATION(22763): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:57.081+0200 I/LOCATION(22763): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:57.081+0200 I/LOCATION(22763): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:01:57.151+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:57.151+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:57.151+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:57.151+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:57.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:57.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:57.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:57.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e22f28
04-23 16:01:57.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734b270]
04-23 16:01:57.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:57.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:57.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:57.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:57.391+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:57.391+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:57.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.401+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:57.401+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:57.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:57.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:57.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:57.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:57.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:57.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:57.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:57.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.411+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:57.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:57.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:57.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:57.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734b270
04-23 16:01:57.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e11388]
04-23 16:01:57.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:57.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:57.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:57.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:57.591+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:57.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:57.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:57.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:57.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:57.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:57.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:57.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:57.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:57.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:57.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:57.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:57.671+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:57.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:57.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:57.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:57.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:57.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e11388
04-23 16:01:57.931+0200 W/AUL     (22795): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:57.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:57.941+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:57.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22717
04-23 16:01:57.941+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:57.951+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22717
04-23 16:01:57.951+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22717)
04-23 16:01:58.211+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:58.211+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:58.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:58.241+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22796
04-23 16:01:58.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:58.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22796
04-23 16:01:58.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22796) type(svcapp) bg(0)
04-23 16:01:58.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22796)
04-23 16:01:58.291+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:58.291+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:58.321+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22796]
04-23 16:01:58.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:58.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22796
04-23 16:01:58.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22796
04-23 16:01:58.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:58.451+0200 E/CAPI_APPFW_APPLICATION(22796): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:58.451+0200 E/CAPI_APPFW_APPLICATION(22796): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:58.451+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22796) was created
04-23 16:01:58.481+0200 W/LOCATION(22796): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:58.481+0200 E/LOCATION(22796): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:58.481+0200 E/PKGMGR_INFO(22796): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:58.491+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:58.511+0200 I/LOCATION(22796): location.c: location_new(269) > method: 0
04-23 16:01:58.511+0200 W/LOCATION(22796): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:58.511+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:58.521+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:58.521+0200 W/LOCATION(22796): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:58.531+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:58.531+0200 W/LOCATION(22796): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:58.531+0200 W/LOCATION(22796): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:58.531+0200 W/LOCATION(22796): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:58.531+0200 W/LOCATION(22796): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:58.551+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:58.561+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:58.561+0200 W/LOCATION(22796): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:58.561+0200 W/LOCATION(22796): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:58.571+0200 W/LOCATION(22796): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:58.571+0200 W/LOCATION(22796): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:58.571+0200 W/LOCATION(22796): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:58.591+0200 W/LOCATION(22796): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:58.591+0200 I/LOCATION(22796): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a74c18
04-23 16:01:58.591+0200 I/LOCATION(22796): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:58.591+0200 I/LOCATION(22796): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a74c18
04-23 16:01:58.591+0200 I/LOCATION(22796): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:58.591+0200 I/location(22796): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:58.641+0200 I/LOCATION(22796): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:58.681+0200 W/LOCATION(22796): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:58.681+0200 W/LOCATION(22796): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:58.681+0200 I/LOCATION(22796): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:58.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:58.741+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:58.741+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:58.741+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:58.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:58.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:58.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:58.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:58.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:58.741+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:58.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:58.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:58.781+0200 W/LOCATION(22796): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:58.781+0200 W/LOCATION(22796): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:58.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:58.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e239b8]
04-23 16:01:58.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:58.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:58.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:58.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:58.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:58.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:58.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:58.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:58.921+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:58.921+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:58.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:58.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:58.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:58.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:58.921+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:58.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:58.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:58.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:58.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:58.931+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:58.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:58.981+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:58.981+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6014647), time2(6008699)
04-23 16:01:58.981+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:58.981+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:58.981+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:58.981+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:58.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:59.011+0200 W/LOCATION(22796): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:59.011+0200 I/LOCATION(22796): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:59.011+0200 I/LOCATION(22796): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:59.011+0200 I/location(22796): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:59.041+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:59.101+0200 I/LOCATION(22796): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:59.151+0200 W/AUL     (22796): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:59.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:59.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22796
04-23 16:01:59.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:59.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.161+0200 I/utils   (19708): specific action
04-23 16:01:59.161+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:59.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:59.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.161+0200 W/AUL     (22796): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:59.161+0200 I/location(22796): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:59.161+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.161+0200 W/CAPI_APPFW_APP_CONTROL(22796): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.161+0200 I/utils   (22796): specific action
04-23 16:01:59.161+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:59.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:59.171+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:59.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:01:59.171+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.181+0200 I/utils   (22624): specific action
04-23 16:01:59.181+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.181+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.181+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.181+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:59.181+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:59.181+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:59.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:01:59.181+0200 I/recorder(22624): guardando datos en local
04-23 16:01:59.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:01:59.181+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:59.181+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:59.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:59.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:59.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:59.431+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:59.431+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:59.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:59.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:59.461+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:59.461+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:59.461+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:59.501+0200 I/LOCATION(22796): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:59.621+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11227966c6f63152449211
