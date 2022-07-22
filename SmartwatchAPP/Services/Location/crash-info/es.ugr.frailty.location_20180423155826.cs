S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20551
Date: 2018-04-23 15:58:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73d052d, r5   = 0xf7bf9f98
r6   = 0xffe568b8, r7   = 0xffe56768
r8   = 0xf7bf6c18, r9   = 0x00000000
r10  = 0xffe56844, fp   = 0xffe568b8
ip   = 0x00000001, sp   = 0xffe555e8
lr   = 0xf73d0539, pc   = 0xf74392b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9560 KB
Buffers:     58520 KB
Cached:     233072 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11956 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20551 TID = 20551
20551 20555 

Maps Information
f429b000 f4a9a000 rw-p [stack:20555]
f4aa1000 f4aa3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4aab000 f4aaf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ab8000 f4aba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ac2000 f4ac5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ad4000 f4ad9000 r-xp /usr/lib/libsystem.so.0.0.0
f4ae4000 f4ae7000 r-xp /lib/libattr.so.1.1.0
f4aef000 f4aff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b07000 f4b10000 r-xp /usr/lib/libedbus.so.1.7.99
f4b18000 f4b19000 r-xp /usr/lib/libresponse.so.0.2.96
f4b22000 f4b27000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63c9000 f64cf000 r-xp /usr/lib/libicuuc.so.57.1
f64e5000 f666d000 r-xp /usr/lib/libicui18n.so.57.1
f667d000 f668a000 r-xp /usr/lib/libail.so.0.1.0
f6693000 f669a000 r-xp /usr/lib/libminizip.so.1.0.0
f66a3000 f684c000 r-xp /usr/lib/libcrypto.so.1.0.0
f686c000 f68b3000 r-xp /usr/lib/libssl.so.1.0.0
f68bf000 f68c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68c9000 f68d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68d9000 f68e0000 r-xp /lib/libcrypt-2.13.so
f6911000 f6914000 r-xp /lib/libcap.so.2.21
f691c000 f691e000 r-xp /usr/lib/libiri.so
f6926000 f696f000 r-xp /usr/lib/libmdm.so.1.2.69
f6977000 f697d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6985000 f69a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69b2000 f69b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69bc000 f69d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69e2000 f69e6000 r-xp /usr/lib/libsmack.so.1.0.0
f69ef000 f6a08000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a11000 f6a19000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a21000 f6a27000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a30000 f6a32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a3b000 f6a4b000 r-xp /lib/libresolv-2.13.so
f6a4f000 f6a67000 r-xp /usr/lib/liblzma.so.5.0.3
f6a70000 f6a72000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a7a000 f6a94000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a9c000 f6acb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ad4000 f6ae3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6aed000 f6af7000 r-xp /usr/lib/libsensord-shared.so
f6b00000 f6bd3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bde000 f6bf4000 r-xp /lib/libz.so.1.2.5
f6bfc000 f6c01000 r-xp /usr/lib/libffi.so.5.0.10
f6c09000 f6c0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c12000 f6c22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c2a000 f6c43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c4b000 f6c4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c55000 f6cca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cd4000 f6cda000 r-xp /lib/librt-2.13.so
f6ce3000 f6d01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d0b000 f6d0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d14000 f6d37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d3f000 f6d44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d4c000 f6d76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d7f000 f6d96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d9e000 f6e07000 r-xp /lib/libm-2.13.so
f6e10000 f6ea4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6eb7000 f6ebc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ec4000 f6ecb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ed3000 f6efd000 r-xp /usr/lib/libsensor.so.1.9.6
f6f06000 f6fd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6fdf000 f6fe1000 r-xp /usr/lib/libiniparser.so.0
f6fea000 f6ff0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ff9000 f70c9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70ca000 f70fe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7107000 f7143000 r-xp /usr/lib/libSLP-location.so.0.9.24
f714b000 f714e000 r-xp /usr/lib/libbundle.so.0.1.22
f7156000 f715c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7164000 f71a5000 r-xp /usr/lib/libeina.so.1.7.99
f71ae000 f71c5000 r-xp /usr/lib/libecore.so.1.7.99
f71dc000 f71e5000 r-xp /usr/lib/libvconf.so.0.2.45
f71ed000 f7201000 r-xp /lib/libpthread-2.13.so
f720c000 f7219000 r-xp /usr/lib/libaul.so.0.1.0
f7223000 f7225000 r-xp /lib/libdl-2.13.so
f722e000 f7239000 r-xp /lib/libunwind.so.8.0.1
f7266000 f726e000 r-xp /lib/libgcc_s-4.6.so.1
f726f000 f7393000 r-xp /lib/libc-2.13.so
f73a1000 f73a3000 r-xp /usr/lib/libdlog.so.0.0.0
f73ab000 f73b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73c0000 f73c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73cd000 f73dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73e4000 f73e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73f1000 f73f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f73fc000 f73fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7406000 f740a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7412000 f742f000 r-xp /lib/ld-2.13.so
f7438000 f743b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f743b000 f743f000 r-xp /usr/lib/libsys-assert.so
f7bc6000 f7c50000 rw-p [heap]
ffe38000 ffe59000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20551)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74392b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf73d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70d73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf711c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7119e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf711a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf711e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74080bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4aac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b7f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf702cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf702e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71beca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71b9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71ba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71ba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74396a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf728685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7438fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:31.581+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:31.581+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:31.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:31.581+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:31.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:31.581+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:31.581+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:31.581+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:31.581+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:31.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:31.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:31.611+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:31.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:31.651+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:31:563,77
04-23 15:58:31.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:31.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:31.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:31.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:31.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7370b80
04-23 15:58:31.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:31.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:31:756,77
04-23 15:58:31.811+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:31.811+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:31.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:31.811+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:31.821+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20632
04-23 15:58:31.821+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:31.871+0200 E/CAPI_APPFW_APPLICATION(20632): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:31.871+0200 E/CAPI_APPFW_APPLICATION(20632): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:31.901+0200 W/LOCATION(20632): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:31.901+0200 E/LOCATION(20632): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:31.901+0200 E/PKGMGR_INFO(20632): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:31.901+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:31.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20632
04-23 15:58:31.911+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20632) type(svcapp) bg(0)
04-23 15:58:31.911+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20632) was created
04-23 15:58:31.911+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20632)
04-23 15:58:31.911+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:31.911+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:31.921+0200 I/LOCATION(20632): location.c: location_new(269) > method: 0
04-23 15:58:31.921+0200 W/LOCATION(20632): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:31.921+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:31.931+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:31.931+0200 W/LOCATION(20632): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:31.931+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:31.941+0200 W/LOCATION(20632): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:31.941+0200 W/LOCATION(20632): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:31.941+0200 W/LOCATION(20632): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:31.941+0200 W/LOCATION(20632): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:31.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20632]
04-23 15:58:31.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:31.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:31.971+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:31.971+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:31.971+0200 W/LOCATION(20632): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:31.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20632
04-23 15:58:31.981+0200 W/LOCATION(20632): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:31.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:31.981+0200 W/LOCATION(20632): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:31.981+0200 W/LOCATION(20632): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:31.981+0200 W/LOCATION(20632): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:31.991+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:31:955,77
04-23 15:58:32.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:32.001+0200 W/LOCATION(20632): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:32.001+0200 I/LOCATION(20632): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7cf3c18
04-23 15:58:32.001+0200 I/LOCATION(20632): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:32.001+0200 I/LOCATION(20632): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7cf3c18
04-23 15:58:32.001+0200 I/LOCATION(20632): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:32.001+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20632
04-23 15:58:32.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:32.011+0200 I/location(20632): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:32.081+0200 I/LOCATION(20632): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:32.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:32.161+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:32:157,77
04-23 15:58:32.161+0200 W/LOCATION(20632): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:32.161+0200 W/LOCATION(20632): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:32.161+0200 I/LOCATION(20632): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:32.261+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:32.261+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:32.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:32.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:32.261+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:32.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:32.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:32.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:32.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:32.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:32.271+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:32.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:32.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:32.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:32.351+0200 W/LOCATION(20632): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:32.351+0200 W/LOCATION(20632): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:32.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:32.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:32.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:32.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:32.391+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:32:354,77
04-23 15:58:32.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:32.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d5c0]
04-23 15:58:32.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:32.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:32.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:32.491+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:32.491+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:32.491+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:32.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.511+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.511+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:32.511+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:32.511+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:32.511+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:32.511+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:32.511+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:32.511+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:32.511+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:32.511+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:32.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:32.521+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5808184), time2(5799802)
04-23 15:58:32.521+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:32.521+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:32.521+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:32.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:32.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.531+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:32.531+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:32.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:32.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:32:557,77
04-23 15:58:32.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:32.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:32.601+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:32.601+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:32.601+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:32.631+0200 W/LOCATION(20632): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:32.631+0200 I/LOCATION(20632): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:32.631+0200 I/LOCATION(20632): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:32.631+0200 I/location(20632): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:32.711+0200 I/LOCATION(20632): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:32.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:32.761+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:32:758,76
04-23 15:58:32.771+0200 W/AUL     (20632): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:32.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:32.771+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20632
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:32.781+0200 W/AUL     (20632): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:32.781+0200 I/location(20632): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:32.781+0200 I/location(20632): stopping es.ugr.frailty.location service
04-23 15:58:32.781+0200 E/CAPI_APPFW_APP_CONTROL(20632): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:32.781+0200 E/location(20632): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:32.781+0200 I/CAPI_APPFW_APPLICATION(20632): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:32.781+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:32.781+0200 I/utils   (19708): specific action
04-23 15:58:32.781+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:32.781+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.781+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.781+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:32.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:32.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:32.791+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:32.791+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:32.791+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:32.801+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:32.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:32.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.801+0200 I/utils   (19713): specific action
04-23 15:58:32.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:32.801+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:32.801+0200 I/recorder(19713): guardando datos en local
04-23 15:58:32.841+0200 W/LOCATION(20632): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:32.841+0200 I/LOCATION(20632): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:32.841+0200 I/LOCATION(20632): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:32.911+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:32.911+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:32.911+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:32.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:32.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:32.961+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:32:957,77
04-23 15:58:33.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:33.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:33.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:33.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d5c0
04-23 15:58:33.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18cb0]
04-23 15:58:33.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:33.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:33.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:33.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:33.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:33.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:33.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.131+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:33.131+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:33.131+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:33.131+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:33.131+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:33.131+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:33.131+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:33.131+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:33.131+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:33.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.141+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:33.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:33.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:33:157,77
04-23 15:58:33.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18cb0
04-23 15:58:33.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d740]
04-23 15:58:33.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:33.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:33.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:33.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:33.301+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:33.301+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:33.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.321+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.321+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:33.321+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:33.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:33.321+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:33.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:33.321+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:33.321+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:33.321+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:33.321+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:33.331+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:33.341+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:33.351+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:33.351+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:33:356,77
04-23 15:58:33.381+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:33.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:33.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:33.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:33.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d740
04-23 15:58:33.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:33.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:33:557,77
04-23 15:58:33.651+0200 W/AUL     (20650): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:33.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:33.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:33.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20588
04-23 15:58:33.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:33.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20588
04-23 15:58:33.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20588)
04-23 15:58:33.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:33.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:33:756,77
04-23 15:58:33.921+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:33.921+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:33.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:33.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:33.931+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20651
04-23 15:58:33.931+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:33.981+0200 E/CAPI_APPFW_APPLICATION(20651): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:33.981+0200 E/CAPI_APPFW_APPLICATION(20651): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:34.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20651
04-23 15:58:34.001+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20651) type(svcapp) bg(0)
04-23 15:58:34.001+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20651) was created
04-23 15:58:34.001+0200 W/LOCATION(20651): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:34.001+0200 E/LOCATION(20651): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:34.001+0200 E/PKGMGR_INFO(20651): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:34.001+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20651]
04-23 15:58:34.011+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:34.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:34.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20651
04-23 15:58:34.031+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20651)
04-23 15:58:34.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:34.041+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:34.041+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:34.041+0200 I/LOCATION(20651): location.c: location_new(269) > method: 0
04-23 15:58:34.041+0200 W/LOCATION(20651): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:34.041+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.041+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:34.051+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:34.051+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:49,77
04-23 15:58:34.051+0200 W/LOCATION(20651): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:34.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:34.061+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:34.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20651
04-23 15:58:34.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:34.071+0200 W/LOCATION(20651): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:34.071+0200 W/LOCATION(20651): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:34.071+0200 W/LOCATION(20651): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:34.071+0200 W/LOCATION(20651): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:34.101+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:34.111+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:34.121+0200 W/LOCATION(20651): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:34.121+0200 W/LOCATION(20651): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:34.131+0200 W/LOCATION(20651): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:34.131+0200 W/LOCATION(20651): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:34.141+0200 W/LOCATION(20651): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:34.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.161+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:157,77
04-23 15:58:34.171+0200 W/LOCATION(20651): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:34.171+0200 I/LOCATION(20651): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a66c18
04-23 15:58:34.171+0200 I/LOCATION(20651): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:34.171+0200 I/LOCATION(20651): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a66c18
04-23 15:58:34.171+0200 I/LOCATION(20651): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:34.171+0200 I/location(20651): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:34.241+0200 I/LOCATION(20651): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:34.281+0200 W/LOCATION(20651): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:34.281+0200 W/LOCATION(20651): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:34.281+0200 I/LOCATION(20651): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:34.351+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.351+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:356,77
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:34.391+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:34.391+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:34.391+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:34.391+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:34.391+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:34.391+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:34.391+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:34.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:34.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:34.391+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:34.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:34.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:34.461+0200 W/LOCATION(20651): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:34.461+0200 W/LOCATION(20651): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:34.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:557,77
04-23 15:58:34.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e05930]
04-23 15:58:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:34.611+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:34.611+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:34.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:34.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:34.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:34.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:34.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:34.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:34.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:34.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:34.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:34.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:34.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:34.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:34.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:34.641+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:34.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:34.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:34.661+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5810319), time2(5799802)
04-23 15:58:34.661+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:58:34.661+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:34.661+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:34.661+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:34.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:34.711+0200 W/LOCATION(20651): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:34.711+0200 I/LOCATION(20651): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:34.711+0200 I/LOCATION(20651): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:34.711+0200 I/location(20651): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:34.761+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.761+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:765,77
04-23 15:58:34.781+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:34.801+0200 I/LOCATION(20651): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:34.851+0200 W/AUL     (20651): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:34.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:34.851+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20651
04-23 15:58:34.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:34.861+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:34.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:34.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.861+0200 I/utils   (19708): specific action
04-23 15:58:34.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.861+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.861+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:34.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:34.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:34.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:34.871+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:34.871+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:34.871+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:34.871+0200 W/AUL     (20651): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:34.871+0200 I/location(20651): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(20651): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 I/utils   (20651): specific action
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 I/utils   (19713): specific action
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:34.871+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:34.871+0200 I/recorder(19713): guardando datos en local
04-23 15:58:34.961+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:34.961+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:34:965,77
04-23 15:58:34.971+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11205516c6f63152449190
