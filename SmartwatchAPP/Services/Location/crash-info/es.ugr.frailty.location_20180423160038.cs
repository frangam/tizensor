S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21766
Date: 2018-04-23 16:00:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf763452d, r5   = 0xf7a37f98
r6   = 0xfff36e78, r7   = 0xfff36d28
r8   = 0xf7a34c18, r9   = 0x00000000
r10  = 0xfff36e04, fp   = 0xfff36e78
ip   = 0x00000001, sp   = 0xfff35ba8
lr   = 0xf7634539, pc   = 0xf769d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13100 KB
Buffers:     59636 KB
Cached:     230340 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11664 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21766 TID = 21766
21766 21771 

Maps Information
f44ff000 f4cfe000 rw-p [stack:21771]
f4d05000 f4d07000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d0f000 f4d13000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d1c000 f4d1e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d26000 f4d29000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d38000 f4d3d000 r-xp /usr/lib/libsystem.so.0.0.0
f4d48000 f4d4b000 r-xp /lib/libattr.so.1.1.0
f4d53000 f4d63000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d6b000 f4d74000 r-xp /usr/lib/libedbus.so.1.7.99
f4d7c000 f4d7d000 r-xp /usr/lib/libresponse.so.0.2.96
f4d86000 f4d8b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f662d000 f6733000 r-xp /usr/lib/libicuuc.so.57.1
f6749000 f68d1000 r-xp /usr/lib/libicui18n.so.57.1
f68e1000 f68ee000 r-xp /usr/lib/libail.so.0.1.0
f68f7000 f68fe000 r-xp /usr/lib/libminizip.so.1.0.0
f6907000 f6ab0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ad0000 f6b17000 r-xp /usr/lib/libssl.so.1.0.0
f6b23000 f6b25000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b2d000 f6b34000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b3d000 f6b44000 r-xp /lib/libcrypt-2.13.so
f6b75000 f6b78000 r-xp /lib/libcap.so.2.21
f6b80000 f6b82000 r-xp /usr/lib/libiri.so
f6b8a000 f6bd3000 r-xp /usr/lib/libmdm.so.1.2.69
f6bdb000 f6be1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6be9000 f6c0c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c16000 f6c18000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c20000 f6c3d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c46000 f6c4a000 r-xp /usr/lib/libsmack.so.1.0.0
f6c53000 f6c6c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c75000 f6c7d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c85000 f6c8b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c94000 f6c96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c9f000 f6caf000 r-xp /lib/libresolv-2.13.so
f6cb3000 f6ccb000 r-xp /usr/lib/liblzma.so.5.0.3
f6cd4000 f6cd6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cde000 f6cf8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d00000 f6d2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d38000 f6d47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d51000 f6d5b000 r-xp /usr/lib/libsensord-shared.so
f6d64000 f6e37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e42000 f6e58000 r-xp /lib/libz.so.1.2.5
f6e60000 f6e65000 r-xp /usr/lib/libffi.so.5.0.10
f6e6d000 f6e6e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e76000 f6e86000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e8e000 f6ea7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eaf000 f6eb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eb9000 f6f2e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f38000 f6f3e000 r-xp /lib/librt-2.13.so
f6f47000 f6f65000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f6f000 f6f70000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f78000 f6f9b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fa3000 f6fa8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fb0000 f6fda000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fe3000 f6ffa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7002000 f706b000 r-xp /lib/libm-2.13.so
f7074000 f7108000 r-xp /usr/lib/libstdc++.so.6.0.16
f711b000 f7120000 r-xp /usr/lib/libctx-client.so.0.8.3
f7128000 f712f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7137000 f7161000 r-xp /usr/lib/libsensor.so.1.9.6
f716a000 f7236000 r-xp /usr/lib/libxml2.so.2.7.8
f7243000 f7245000 r-xp /usr/lib/libiniparser.so.0
f724e000 f7254000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f725d000 f732d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f732e000 f7362000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f736b000 f73a7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73af000 f73b2000 r-xp /usr/lib/libbundle.so.0.1.22
f73ba000 f73c0000 r-xp /usr/lib/libappsvc.so.0.1.0
f73c8000 f7409000 r-xp /usr/lib/libeina.so.1.7.99
f7412000 f7429000 r-xp /usr/lib/libecore.so.1.7.99
f7440000 f7449000 r-xp /usr/lib/libvconf.so.0.2.45
f7451000 f7465000 r-xp /lib/libpthread-2.13.so
f7470000 f747d000 r-xp /usr/lib/libaul.so.0.1.0
f7487000 f7489000 r-xp /lib/libdl-2.13.so
f7492000 f749d000 r-xp /lib/libunwind.so.8.0.1
f74ca000 f74d2000 r-xp /lib/libgcc_s-4.6.so.1
f74d3000 f75f7000 r-xp /lib/libc-2.13.so
f7605000 f7607000 r-xp /usr/lib/libdlog.so.0.0.0
f760f000 f761b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7624000 f7629000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7631000 f7640000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7648000 f764c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7655000 f7658000 r-xp /usr/lib/libappcore-agent.so.1.1
f7660000 f7662000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f766a000 f766e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7676000 f7693000 r-xp /lib/ld-2.13.so
f769c000 f769f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f769f000 f76a3000 r-xp /usr/lib/libsys-assert.so
f7a04000 f7a8e000 rw-p [heap]
fff18000 fff39000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21766)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf769d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7634539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf733b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7339c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7345e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf734bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf734bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf738075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf737b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7339c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7345e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf734bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf734bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf737de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf737e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73828d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf766c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4d10171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6de3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7290fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72927a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7422ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf741db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf741e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf741e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7656183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76567fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf769d6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf74ea85c) [/lib/libc.so.6] + 0x1785c
29: (0xf769cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
est_handler(1032) > pkg_status: installed, dead pid: 21679
04-23 16:00:34.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:34.831+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21679
04-23 16:00:34.831+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21679)
04-23 16:00:35.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:35.021+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:35:13,74
04-23 16:00:35.181+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:35.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:35.221+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:35:213,73
04-23 16:00:35.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:35.421+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:35:413,73
04-23 16:00:35.501+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:00:35.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:35.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:35.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:35.511+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21724
04-23 16:00:35.521+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:35.571+0200 E/CAPI_APPFW_APPLICATION(21724): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:35.571+0200 E/CAPI_APPFW_APPLICATION(21724): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:35.591+0200 W/LOCATION(21724): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:35.591+0200 E/LOCATION(21724): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:35.591+0200 E/PKGMGR_INFO(21724): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:35.591+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:35.611+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21724
04-23 16:00:35.611+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21724) type(svcapp) bg(0)
04-23 16:00:35.611+0200 I/LOCATION(21724): location.c: location_new(269) > method: 0
04-23 16:00:35.611+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21724) was created
04-23 16:00:35.611+0200 W/LOCATION(21724): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:35.611+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:35.621+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:35.621+0200 W/LOCATION(21724): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:35.621+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:35.631+0200 W/LOCATION(21724): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:35.631+0200 W/LOCATION(21724): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:35.631+0200 W/LOCATION(21724): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:35.631+0200 W/LOCATION(21724): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:35.641+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:35.651+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:35.651+0200 W/LOCATION(21724): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:35.651+0200 W/LOCATION(21724): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:35.661+0200 W/LOCATION(21724): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:35.661+0200 W/LOCATION(21724): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:35.661+0200 W/LOCATION(21724): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:35.671+0200 W/LOCATION(21724): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:35.671+0200 I/LOCATION(21724): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf70e1c18
04-23 16:00:35.671+0200 I/LOCATION(21724): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:35.671+0200 I/LOCATION(21724): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf70e1c18
04-23 16:00:35.671+0200 I/LOCATION(21724): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:35.681+0200 I/location(21724): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:35.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21724)
04-23 16:00:35.681+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:00:35.681+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:35.721+0200 I/LOCATION(21724): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:35.761+0200 W/LOCATION(21724): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:35.761+0200 W/LOCATION(21724): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:35.761+0200 I/LOCATION(21724): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:35.771+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21724]
04-23 16:00:35.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:35.791+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21724
04-23 16:00:35.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:35.821+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:35.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:35.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21724
04-23 16:00:35.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:35.841+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:35:827,73
04-23 16:00:35.851+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:35.851+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:35:857,73
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:35.891+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:35.891+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:35.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:35.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:35.901+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:35.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:35.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:35.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:35.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:35.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:35.901+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:35.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:35.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:35.971+0200 W/LOCATION(21724): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:35.981+0200 W/LOCATION(21724): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:36.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:36.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:36:14,73
04-23 16:00:36.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e02360]
04-23 16:00:36.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:36.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:36.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:36.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:36.141+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5931802), time2(5921477)
04-23 16:00:36.141+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:00:36.141+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:36.141+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:36.141+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:36.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:36.151+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:36.151+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:36.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:36.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:36.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:36.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:36.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:36.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:36.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:36.171+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:36.171+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:36.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.181+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:36.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:36.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.251+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:36:214,73
04-23 16:00:36.261+0200 W/LOCATION(21724): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:36.261+0200 I/LOCATION(21724): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:36.261+0200 I/LOCATION(21724): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:36.261+0200 I/location(21724): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:36.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:36.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:36.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:36.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:36.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:36.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:36.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:36.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:36.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:36.411+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:36:413,73
04-23 16:00:36.431+0200 I/LOCATION(21724): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:36.471+0200 W/AUL     (21724): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:36.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:36.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21724
04-23 16:00:36.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:36.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:36.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:36.481+0200 I/utils   (19708): specific action
04-23 16:00:36.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:36.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:36.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:36.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:36.501+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:36.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:36.501+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.501+0200 I/utils   (21185): specific action
04-23 16:00:36.501+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.501+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.501+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.501+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:36.501+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:36.501+0200 I/recorder(21185): guardando datos en local
04-23 16:00:36.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:36.501+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:36.501+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:36.501+0200 W/AUL     (21724): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:36.501+0200 I/location(21724): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:36.501+0200 I/location(21724): stopping es.ugr.frailty.location service
04-23 16:00:36.501+0200 E/CAPI_APPFW_APP_CONTROL(21724): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:36.501+0200 E/location(21724): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:36.501+0200 I/CAPI_APPFW_APPLICATION(21724): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:36.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:36.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:36.541+0200 W/LOCATION(21724): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:36.541+0200 I/LOCATION(21724): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:36.541+0200 I/LOCATION(21724): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:36.611+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:36.611+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:36:615,73
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:00:36.621+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:36.621+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:36.621+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:36.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:36.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:36.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:36.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:36.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e02360
04-23 16:00:36.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:36.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03730]
04-23 16:00:36.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:36.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:36.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:36.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:36.841+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:36.841+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:36.841+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:36:814,73
04-23 16:00:36.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.861+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:36.861+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:36.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:36.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:36.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:36.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:36.861+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:36.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:36.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:36.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:36.871+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:36.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:36.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:36.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:36.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:36.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03730
04-23 16:00:37.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:37.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:37:14,73
04-23 16:00:37.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e37d00]
04-23 16:00:37.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:37.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:37.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:37.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:37.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:37.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:37.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:37.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:37.081+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:37.081+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:37.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:37.081+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:37.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:37.081+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:37.081+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:37.081+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:37.081+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:37.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:37.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:37.091+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:37.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:37.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:37.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:37.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:37.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:37.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e37d00
04-23 16:00:37.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:37.221+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:37:214,74
04-23 16:00:37.381+0200 W/AUL     (21760): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:37.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:37.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:37.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21701
04-23 16:00:37.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:37.381+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21701
04-23 16:00:37.381+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21701)
04-23 16:00:37.411+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:37.411+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:37:415,75
04-23 16:00:37.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:37.611+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:37:615,75
04-23 16:00:37.681+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:37.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:37.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:37.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:37.691+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21766
04-23 16:00:37.701+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:37.751+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21766
04-23 16:00:37.751+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21766) type(svcapp) bg(0)
04-23 16:00:37.751+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21766]
04-23 16:00:37.761+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21766)
04-23 16:00:37.771+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:37.771+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:37.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:37.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21766
04-23 16:00:37.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:37.841+0200 E/CAPI_APPFW_APPLICATION(21766): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:37.851+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:37.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:37.851+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:37:855,75
04-23 16:00:37.861+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21766
04-23 16:00:37.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:37.861+0200 E/CAPI_APPFW_APPLICATION(21766): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:37.861+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21766) was created
04-23 16:00:37.891+0200 W/LOCATION(21766): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:37.891+0200 E/LOCATION(21766): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:37.891+0200 E/PKGMGR_INFO(21766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:37.891+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:37.911+0200 I/LOCATION(21766): location.c: location_new(269) > method: 0
04-23 16:00:37.911+0200 W/LOCATION(21766): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:37.921+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:37.921+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:37.931+0200 W/LOCATION(21766): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:37.931+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:37.931+0200 W/LOCATION(21766): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:37.931+0200 W/LOCATION(21766): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:37.931+0200 W/LOCATION(21766): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:37.931+0200 W/LOCATION(21766): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:37.961+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:37.961+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:37.961+0200 W/LOCATION(21766): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:37.971+0200 W/LOCATION(21766): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:37.971+0200 W/LOCATION(21766): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:37.971+0200 W/LOCATION(21766): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:37.971+0200 W/LOCATION(21766): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:38.001+0200 W/LOCATION(21766): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:38.001+0200 I/LOCATION(21766): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a34c18
04-23 16:00:38.001+0200 I/LOCATION(21766): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:38.001+0200 I/LOCATION(21766): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a34c18
04-23 16:00:38.001+0200 I/LOCATION(21766): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:38.011+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:38.011+0200 I/location(21766): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:38.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:38:16,76
04-23 16:00:38.061+0200 I/LOCATION(21766): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:38.101+0200 W/LOCATION(21766): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:38.101+0200 W/LOCATION(21766): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:38.101+0200 I/LOCATION(21766): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:38.181+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:38.181+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:38.181+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:38.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:38.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:38.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:38.181+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:38.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:38.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:38.211+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:38.211+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:38:215,76
04-23 16:00:38.241+0200 W/LOCATION(21766): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:38.241+0200 W/LOCATION(21766): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:38.341+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:38.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:38.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:38.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:38.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:38.411+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:38.411+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:38:415,76
04-23 16:00:38.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7341a38]
04-23 16:00:38.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:38.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:38.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:38.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:38.431+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:38.431+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5934096), time2(5931802)
04-23 16:00:38.431+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:38.431+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:38.431+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:38.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:38.441+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:38.441+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:38.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.451+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:38.451+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:38.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:38.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:38.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:38.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:38.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:38.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:38.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:38.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.471+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.471+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:38.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:38.501+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:38.521+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:38.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:38.541+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:38.541+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:38.541+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:38.561+0200 W/LOCATION(21766): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:38.561+0200 I/LOCATION(21766): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:38.561+0200 I/LOCATION(21766): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:38.561+0200 I/location(21766): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:38.611+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:38.611+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:38:615,76
04-23 16:00:38.651+0200 I/LOCATION(21766): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:38.691+0200 W/AUL     (21766): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:38.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:38.701+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21766
04-23 16:00:38.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:38.711+0200 W/AUL     (21766): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:38.711+0200 I/location(21766): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:38.711+0200 W/CAPI_APPFW_APP_CONTROL(21766): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.711+0200 I/utils   (21766): specific action
04-23 16:00:38.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.711+0200 I/utils   (19708): specific action
04-23 16:00:38.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:38.711+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:38.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:38.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:38.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:38.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:38.721+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.721+0200 I/utils   (21185): specific action
04-23 16:00:38.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:38.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:38.721+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.721+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.721+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.721+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:38.721+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:38.721+0200 I/recorder(21185): guardando datos en local
04-23 16:00:38.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:38.721+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:38.721+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:38.761+0200 I/LOCATION(21766): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:38.811+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:38.811+0200 I/heartrate(21513): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:00:38:815,76
04-23 16:00:38.871+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11217666c6f63152449203
