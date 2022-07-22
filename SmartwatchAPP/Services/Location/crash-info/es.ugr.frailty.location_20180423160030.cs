S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21679
Date: 2018-04-23 16:00:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf750252d, r5   = 0xf7a4ef98
r6   = 0xffd8c9e8, r7   = 0xffd8c898
r8   = 0xf7a4bc18, r9   = 0x00000000
r10  = 0xffd8c974, fp   = 0xffd8c9e8
ip   = 0x00000001, sp   = 0xffd8b718
lr   = 0xf7502539, pc   = 0xf756b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8864 KB
Buffers:     59576 KB
Cached:     234748 KB
VmPeak:      52516 KB
VmSize:      52512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11856 KB
VmData:      10240 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21679 TID = 21679
21679 21684 

Maps Information
f43cd000 f4bcc000 rw-p [stack:21684]
f4bd3000 f4bd5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bdd000 f4be1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bea000 f4bec000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bf4000 f4bf7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c06000 f4c0b000 r-xp /usr/lib/libsystem.so.0.0.0
f4c16000 f4c19000 r-xp /lib/libattr.so.1.1.0
f4c21000 f4c31000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c39000 f4c42000 r-xp /usr/lib/libedbus.so.1.7.99
f4c4a000 f4c4b000 r-xp /usr/lib/libresponse.so.0.2.96
f4c54000 f4c59000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64fb000 f6601000 r-xp /usr/lib/libicuuc.so.57.1
f6617000 f679f000 r-xp /usr/lib/libicui18n.so.57.1
f67af000 f67bc000 r-xp /usr/lib/libail.so.0.1.0
f67c5000 f67cc000 r-xp /usr/lib/libminizip.so.1.0.0
f67d5000 f697e000 r-xp /usr/lib/libcrypto.so.1.0.0
f699e000 f69e5000 r-xp /usr/lib/libssl.so.1.0.0
f69f1000 f69f3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69fb000 f6a02000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a0b000 f6a12000 r-xp /lib/libcrypt-2.13.so
f6a43000 f6a46000 r-xp /lib/libcap.so.2.21
f6a4e000 f6a50000 r-xp /usr/lib/libiri.so
f6a58000 f6aa1000 r-xp /usr/lib/libmdm.so.1.2.69
f6aa9000 f6aaf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ab7000 f6ada000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ae4000 f6ae6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aee000 f6b0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b14000 f6b18000 r-xp /usr/lib/libsmack.so.1.0.0
f6b21000 f6b3a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b43000 f6b4b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b53000 f6b59000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b62000 f6b64000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b6d000 f6b7d000 r-xp /lib/libresolv-2.13.so
f6b81000 f6b99000 r-xp /usr/lib/liblzma.so.5.0.3
f6ba2000 f6ba4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bac000 f6bc6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bce000 f6bfd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c06000 f6c15000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c1f000 f6c29000 r-xp /usr/lib/libsensord-shared.so
f6c32000 f6d05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d10000 f6d26000 r-xp /lib/libz.so.1.2.5
f6d2e000 f6d33000 r-xp /usr/lib/libffi.so.5.0.10
f6d3b000 f6d3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d44000 f6d54000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d5c000 f6d75000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d7d000 f6d7f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d87000 f6dfc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e06000 f6e0c000 r-xp /lib/librt-2.13.so
f6e15000 f6e33000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e3d000 f6e3e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e46000 f6e69000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e71000 f6e76000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e7e000 f6ea8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6eb1000 f6ec8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ed0000 f6f39000 r-xp /lib/libm-2.13.so
f6f42000 f6fd6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fe9000 f6fee000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ff6000 f6ffd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7005000 f702f000 r-xp /usr/lib/libsensor.so.1.9.6
f7038000 f7104000 r-xp /usr/lib/libxml2.so.2.7.8
f7111000 f7113000 r-xp /usr/lib/libiniparser.so.0
f711c000 f7122000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f712b000 f71fb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71fc000 f7230000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7239000 f7275000 r-xp /usr/lib/libSLP-location.so.0.9.24
f727d000 f7280000 r-xp /usr/lib/libbundle.so.0.1.22
f7288000 f728e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7296000 f72d7000 r-xp /usr/lib/libeina.so.1.7.99
f72e0000 f72f7000 r-xp /usr/lib/libecore.so.1.7.99
f730e000 f7317000 r-xp /usr/lib/libvconf.so.0.2.45
f731f000 f7333000 r-xp /lib/libpthread-2.13.so
f733e000 f734b000 r-xp /usr/lib/libaul.so.0.1.0
f7355000 f7357000 r-xp /lib/libdl-2.13.so
f7360000 f736b000 r-xp /lib/libunwind.so.8.0.1
f7398000 f73a0000 r-xp /lib/libgcc_s-4.6.so.1
f73a1000 f74c5000 r-xp /lib/libc-2.13.so
f74d3000 f74d5000 r-xp /usr/lib/libdlog.so.0.0.0
f74dd000 f74e9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74f2000 f74f7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74ff000 f750e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7516000 f751a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7523000 f7526000 r-xp /usr/lib/libappcore-agent.so.1.1
f752e000 f7530000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7538000 f753c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7544000 f7561000 r-xp /lib/ld-2.13.so
f756a000 f756d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f756d000 f7571000 r-xp /usr/lib/libsys-assert.so
f7a1b000 f7aa6000 rw-p [heap]
ffd6e000 ffd8f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21679)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf756b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7502539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72093f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7207c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7213e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7219be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7219dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72491f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7207c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7213e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7219be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7219dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf724be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf724c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72508d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf753a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4bde171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cb1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf715efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71607a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72f0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72ebb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72ec5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72ec879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7524183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75247fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf756b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf73b885c) [/lib/libc.so.6] + 0x1785c
29: (0xf756afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0:27.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:27.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:27.151+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:27.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:27.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:27.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:27.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:27.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:27.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:27.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:27.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18a58
04-23 16:00:27.221+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:00:27.221+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:27.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:27.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:27.241+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21662
04-23 16:00:27.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:27.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21662
04-23 16:00:27.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21662) type(svcapp) bg(0)
04-23 16:00:27.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21662)
04-23 16:00:27.291+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:00:27.291+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:27.291+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21662]
04-23 16:00:27.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:27.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21662
04-23 16:00:27.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:27.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:27.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21662
04-23 16:00:27.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:27.351+0200 E/CAPI_APPFW_APPLICATION(21662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:27.351+0200 E/CAPI_APPFW_APPLICATION(21662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:27.351+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21662) was created
04-23 16:00:27.391+0200 W/LOCATION(21662): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:27.391+0200 E/LOCATION(21662): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:27.391+0200 E/PKGMGR_INFO(21662): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:27.401+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:27.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:27.411+0200 I/LOCATION(21662): location.c: location_new(269) > method: 0
04-23 16:00:27.411+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:27.411+0200 W/LOCATION(21662): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:27.421+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:27.421+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:27.431+0200 W/LOCATION(21662): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:27.431+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:27.431+0200 W/LOCATION(21662): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:27.431+0200 W/LOCATION(21662): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:27.431+0200 W/LOCATION(21662): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:27.431+0200 W/LOCATION(21662): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:27.451+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:27.461+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:27.461+0200 W/LOCATION(21662): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:27.471+0200 W/LOCATION(21662): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:27.471+0200 W/LOCATION(21662): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:27.471+0200 W/LOCATION(21662): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:27.471+0200 W/LOCATION(21662): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:27.491+0200 W/LOCATION(21662): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:27.491+0200 I/LOCATION(21662): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf759fc18
04-23 16:00:27.491+0200 I/LOCATION(21662): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:27.491+0200 I/LOCATION(21662): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf759fc18
04-23 16:00:27.491+0200 I/LOCATION(21662): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:27.491+0200 I/location(21662): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:27.541+0200 I/LOCATION(21662): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:27.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:27.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:27.621+0200 W/LOCATION(21662): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:27.621+0200 W/LOCATION(21662): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:27.621+0200 I/LOCATION(21662): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:27.691+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:27.691+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:27.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:27.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:27.691+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:27.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:27.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:27.691+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:27.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:27.701+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:27.701+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:27.701+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:27.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:27.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:27.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:27.871+0200 W/LOCATION(21662): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:27.871+0200 W/LOCATION(21662): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:27.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:27.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:27.991+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5923653), time2(5921477)
04-23 16:00:27.991+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:27.991+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:27.991+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:27.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:27.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03ee0]
04-23 16:00:27.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:27.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:27.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:27.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:28.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:28.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:28.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:28.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:28.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:28.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:28.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:28.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:28.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:28.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.031+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:28.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.111+0200 W/LOCATION(21662): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:28.111+0200 I/LOCATION(21662): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:28.111+0200 I/LOCATION(21662): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:28.121+0200 I/location(21662): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:28.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:28.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:28.211+0200 I/LOCATION(21662): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:28.261+0200 W/AUL     (21662): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:28.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:28.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21662
04-23 16:00:28.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:28.281+0200 W/AUL     (21662): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:28.281+0200 I/location(21662): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:28.281+0200 I/location(21662): stopping es.ugr.frailty.location service
04-23 16:00:28.281+0200 E/CAPI_APPFW_APP_CONTROL(21662): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:28.281+0200 E/location(21662): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:28.281+0200 I/CAPI_APPFW_APPLICATION(21662): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:28.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:28.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:28.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.291+0200 I/utils   (19708): specific action
04-23 16:00:28.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:28.291+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:28.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:28.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:28.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:28.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:28.301+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:28.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:28.301+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:28.301+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:28.301+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:28.301+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.301+0200 I/utils   (21185): specific action
04-23 16:00:28.301+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.301+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.301+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.301+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:28.301+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:28.301+0200 I/recorder(21185): guardando datos en local
04-23 16:00:28.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:28.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:28.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:28.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:28.371+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:28.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.391+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:28.391+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:28.391+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:28.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:28.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:28.421+0200 W/LOCATION(21662): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:28.421+0200 I/LOCATION(21662): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:28.421+0200 I/LOCATION(21662): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:00:28.501+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:28.501+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:28.501+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:28.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:28.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:28.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:28.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:28.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:28.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:28.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03ee0
04-23 16:00:28.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733de60]
04-23 16:00:28.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:28.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:28.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:28.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:28.711+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.731+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:28.731+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:28.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:28.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:28.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:28.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:28.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:28.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.751+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:28.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:28.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:28.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733de60
04-23 16:00:28.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d658]
04-23 16:00:28.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:28.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:28.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:28.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:28.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:28.991+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:28.991+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:28.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:28.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:28.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:28.991+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:28.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:28.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:28.991+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:29.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:29.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:29.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:29.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:29.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:29.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:29.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:29.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:29.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d658
04-23 16:00:29.101+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:29.101+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:29.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:29.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:29.281+0200 W/AUL     (21678): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:29.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:29.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:29.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21617
04-23 16:00:29.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:29.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21617
04-23 16:00:29.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21617)
04-23 16:00:29.291+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:29.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:29.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:29.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:29.311+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21679
04-23 16:00:29.321+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:29.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21679
04-23 16:00:29.361+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21679) type(svcapp) bg(0)
04-23 16:00:29.361+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21679)
04-23 16:00:29.361+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:29.361+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:29.371+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21679]
04-23 16:00:29.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:29.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21679
04-23 16:00:29.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:29.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21679
04-23 16:00:29.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:29.421+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:29.421+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:29.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:29.441+0200 E/CAPI_APPFW_APPLICATION(21679): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:29.441+0200 E/CAPI_APPFW_APPLICATION(21679): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:29.441+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21679) was created
04-23 16:00:29.461+0200 W/LOCATION(21679): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:29.461+0200 E/LOCATION(21679): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:29.461+0200 E/PKGMGR_INFO(21679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:29.471+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:29.491+0200 I/LOCATION(21679): location.c: location_new(269) > method: 0
04-23 16:00:29.491+0200 W/LOCATION(21679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:29.491+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:29.501+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:29.501+0200 W/LOCATION(21679): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:29.501+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:29.511+0200 W/LOCATION(21679): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:29.511+0200 W/LOCATION(21679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:29.511+0200 W/LOCATION(21679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:29.511+0200 W/LOCATION(21679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:29.531+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:29.531+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:29.531+0200 W/LOCATION(21679): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:29.541+0200 W/LOCATION(21679): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:29.541+0200 W/LOCATION(21679): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:29.541+0200 W/LOCATION(21679): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:29.541+0200 W/LOCATION(21679): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:29.561+0200 W/LOCATION(21679): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:29.561+0200 I/LOCATION(21679): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a4bc18
04-23 16:00:29.561+0200 I/LOCATION(21679): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:29.561+0200 I/LOCATION(21679): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a4bc18
04-23 16:00:29.561+0200 I/LOCATION(21679): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:29.561+0200 I/location(21679): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:29.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:29.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:29.611+0200 I/LOCATION(21679): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:29.661+0200 W/LOCATION(21679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:29.661+0200 W/LOCATION(21679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:29.661+0200 I/LOCATION(21679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:29.731+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:29.731+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:29.731+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:29.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:29.731+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:29.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:29.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:29.731+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:29.731+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:29.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:29.741+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:29.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:29.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:29.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:29.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:29.801+0200 W/LOCATION(21679): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:29.801+0200 W/LOCATION(21679): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:29.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:29.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:29.971+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5925634), time2(5921477)
04-23 16:00:29.971+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:29.971+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:29.971+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:29.971+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:29.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e110d0]
04-23 16:00:29.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:29.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:29.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:29.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:30.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:30.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:30.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:30.001+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:30.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:30.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:30.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:30.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:30.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:30.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:30.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:30.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:30.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:30.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:30.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:30.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:30.121+0200 W/LOCATION(21679): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:30.121+0200 I/LOCATION(21679): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:30.121+0200 I/LOCATION(21679): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:30.121+0200 I/location(21679): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:30.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:30.201+0200 I/LOCATION(21679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:30.211+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:30.251+0200 W/AUL     (21679): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:30.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:30.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21679
04-23 16:00:30.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:30.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:30.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:30.271+0200 W/AUL     (21679): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:30.271+0200 I/location(21679): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:30.271+0200 W/CAPI_APPFW_APP_CONTROL(21679): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.271+0200 I/utils   (21679): specific action
04-23 16:00:30.271+0200 I/utils   (19708): specific action
04-23 16:00:30.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:30.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:30.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:30.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:30.281+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:30.281+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:30.281+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:30.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:30.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.281+0200 I/utils   (21185): specific action
04-23 16:00:30.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:30.281+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:30.281+0200 I/recorder(21185): guardando datos en local
04-23 16:00:30.281+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:30.281+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:30.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:30.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:30.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:30.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:30.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:30.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:30.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:30.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:30.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:30.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:30.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:30.441+0200 I/LOCATION(21679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:30.541+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11216796c6f63152449203
