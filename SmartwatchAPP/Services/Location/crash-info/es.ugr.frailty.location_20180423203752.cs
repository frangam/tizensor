S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11513
Date: 2018-04-23 20:37:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf728852d, r5   = 0xf7b04f98
r6   = 0xffb92220, r7   = 0xffb920d0
r8   = 0xf7b01c18, r9   = 0x00000000
r10  = 0xffb921ac, fp   = 0xffb92220
ip   = 0x00000001, sp   = 0xffb920a8
lr   = 0xf7288539, pc   = 0xf72f1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    134352 KB
Buffers:     38944 KB
Cached:     159688 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12080 KB
VmRSS:       12080 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11513 TID = 11513
11513 11516 

Maps Information
f4153000 f4952000 rw-p [stack:11516]
f4959000 f495b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4963000 f4967000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4970000 f4972000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f497a000 f497d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f498c000 f4991000 r-xp /usr/lib/libsystem.so.0.0.0
f499c000 f499f000 r-xp /lib/libattr.so.1.1.0
f49a7000 f49b7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49bf000 f49c8000 r-xp /usr/lib/libedbus.so.1.7.99
f49d0000 f49d1000 r-xp /usr/lib/libresponse.so.0.2.96
f49da000 f49df000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6281000 f6387000 r-xp /usr/lib/libicuuc.so.57.1
f639d000 f6525000 r-xp /usr/lib/libicui18n.so.57.1
f6535000 f6542000 r-xp /usr/lib/libail.so.0.1.0
f654b000 f6552000 r-xp /usr/lib/libminizip.so.1.0.0
f655b000 f6704000 r-xp /usr/lib/libcrypto.so.1.0.0
f6724000 f676b000 r-xp /usr/lib/libssl.so.1.0.0
f6777000 f6779000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6781000 f6788000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6791000 f6798000 r-xp /lib/libcrypt-2.13.so
f67c9000 f67cc000 r-xp /lib/libcap.so.2.21
f67d4000 f67d6000 r-xp /usr/lib/libiri.so
f67de000 f6827000 r-xp /usr/lib/libmdm.so.1.2.69
f682f000 f6835000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f683d000 f6860000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f686a000 f686c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6874000 f6891000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f689a000 f689e000 r-xp /usr/lib/libsmack.so.1.0.0
f68a7000 f68c0000 r-xp /usr/lib/libnetwork.so.0.0.0
f68c9000 f68d1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68d9000 f68df000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68e8000 f68ea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68f3000 f6903000 r-xp /lib/libresolv-2.13.so
f6907000 f691f000 r-xp /usr/lib/liblzma.so.5.0.3
f6928000 f692a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6932000 f694c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6954000 f6983000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f698c000 f699b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69a5000 f69af000 r-xp /usr/lib/libsensord-shared.so
f69b8000 f6a8b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a96000 f6aac000 r-xp /lib/libz.so.1.2.5
f6ab4000 f6ab9000 r-xp /usr/lib/libffi.so.5.0.10
f6ac1000 f6ac2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aca000 f6ada000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ae2000 f6afb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b03000 f6b05000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b0d000 f6b82000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b8c000 f6b92000 r-xp /lib/librt-2.13.so
f6b9b000 f6bb9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bc3000 f6bc4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bcc000 f6bef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bf7000 f6bfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c04000 f6c2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c37000 f6c4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c56000 f6cbf000 r-xp /lib/libm-2.13.so
f6cc8000 f6d5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d6f000 f6d74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d7c000 f6d83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d8b000 f6db5000 r-xp /usr/lib/libsensor.so.1.9.6
f6dbe000 f6e8a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e97000 f6e99000 r-xp /usr/lib/libiniparser.so.0
f6ea2000 f6ea8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6eb1000 f6f81000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f82000 f6fb6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fbf000 f6ffb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7003000 f7006000 r-xp /usr/lib/libbundle.so.0.1.22
f700e000 f7014000 r-xp /usr/lib/libappsvc.so.0.1.0
f701c000 f705d000 r-xp /usr/lib/libeina.so.1.7.99
f7066000 f707d000 r-xp /usr/lib/libecore.so.1.7.99
f7094000 f709d000 r-xp /usr/lib/libvconf.so.0.2.45
f70a5000 f70b9000 r-xp /lib/libpthread-2.13.so
f70c4000 f70d1000 r-xp /usr/lib/libaul.so.0.1.0
f70db000 f70dd000 r-xp /lib/libdl-2.13.so
f70e6000 f70f1000 r-xp /lib/libunwind.so.8.0.1
f711e000 f7126000 r-xp /lib/libgcc_s-4.6.so.1
f7127000 f724b000 r-xp /lib/libc-2.13.so
f7259000 f725b000 r-xp /usr/lib/libdlog.so.0.0.0
f7263000 f726f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7278000 f727d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7285000 f7294000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f729c000 f72a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72a9000 f72ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f72b4000 f72b6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72be000 f72c2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72ca000 f72e7000 r-xp /lib/ld-2.13.so
f72f0000 f72f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72f3000 f72f7000 r-xp /usr/lib/libsys-assert.so
f7ad1000 f7b33000 rw-p [heap]
ffb73000 ffb94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11513)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72f1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7288539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f8f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fd475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fcf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fd1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fd2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fd9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49711fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4964171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a37663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ee4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ee67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7076ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7071b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70725a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7072879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72aa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72aa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72f153f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf713e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72f0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0
04-23 20:37:40.019+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:40.019+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:40.019+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.019+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:40.019+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:40.019+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:40.019+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:40.019+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:40.019+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:40.029+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.039+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.039+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:40.039+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:37:40.039+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:40.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:40.039+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:40.039+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:40.069+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:40.069+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11463
04-23 20:37:40.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:40.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:40.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:40.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:40.109+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c0b170
04-23 20:37:40.119+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11463
04-23 20:37:40.119+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11463) type(svcapp) bg(0)
04-23 20:37:40.119+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11463)
04-23 20:37:40.119+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:37:40.119+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:40.129+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11463]
04-23 20:37:40.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:40.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11463
04-23 20:37:40.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:40.169+0200 E/CAPI_APPFW_APPLICATION(11463): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:40.169+0200 E/CAPI_APPFW_APPLICATION(11463): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:40.179+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11463
04-23 20:37:40.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:40.179+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11463) was created
04-23 20:37:40.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:40.199+0200 W/LOCATION(11463): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:40.199+0200 E/LOCATION(11463): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:40.199+0200 E/PKGMGR_INFO(11463): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:40.199+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.219+0200 I/LOCATION(11463): location.c: location_new(269) > method: 0
04-23 20:37:40.219+0200 W/LOCATION(11463): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:40.219+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.229+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.229+0200 W/LOCATION(11463): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:40.229+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:40.239+0200 W/LOCATION(11463): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:40.239+0200 W/LOCATION(11463): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:40.239+0200 W/LOCATION(11463): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:40.239+0200 W/LOCATION(11463): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:40.259+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:40.259+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:40.259+0200 W/LOCATION(11463): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:40.269+0200 W/LOCATION(11463): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:40.269+0200 W/LOCATION(11463): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:40.269+0200 W/LOCATION(11463): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:40.269+0200 W/LOCATION(11463): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:40.289+0200 W/LOCATION(11463): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:40.289+0200 I/LOCATION(11463): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf767cc18
04-23 20:37:40.289+0200 I/LOCATION(11463): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:40.289+0200 I/LOCATION(11463): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf767cc18
04-23 20:37:40.289+0200 I/LOCATION(11463): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:40.289+0200 I/location(11463): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:40.329+0200 I/LOCATION(11463): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:40.369+0200 W/LOCATION(11463): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:40.369+0200 W/LOCATION(11463): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:40.369+0200 I/LOCATION(11463): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:40.439+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:40.439+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:40.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:40.439+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:40.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:40.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:40.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:40.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:40.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:40.439+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:40.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:40.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:40.499+0200 W/LOCATION(11463): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:40.499+0200 W/LOCATION(11463): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:40.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:40.609+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72dea68]
04-23 20:37:40.609+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:40.609+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:40.609+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:40.609+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:40.619+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:40.619+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.629+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.639+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.639+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:40.639+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:40.639+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:40.639+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:40.639+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:40.639+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:40.639+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:40.639+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:40.639+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:40.639+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.649+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:40.649+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:40.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:40.689+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:40.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:40.699+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2735965), time2(2732840)
04-23 20:37:40.699+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:37:40.699+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:40.699+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:40.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:40.719+0200 W/LOCATION(11463): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:40.719+0200 I/LOCATION(11463): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:40.719+0200 I/LOCATION(11463): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:40.719+0200 I/location(11463): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:40.799+0200 I/LOCATION(11463): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:40.849+0200 W/AUL     (11463): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:40.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:40.849+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11463
04-23 20:37:40.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:40.859+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:40.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:40.859+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.859+0200 I/utils   (10115): specific action
04-23 20:37:40.859+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.859+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.859+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.859+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:40.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:40.859+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:40.869+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:40.869+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:40.869+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:40.869+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.869+0200 I/utils   (10120): specific action
04-23 20:37:40.869+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.869+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.869+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.869+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:40.869+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:40.869+0200 I/recorder(10120): guardando datos en local
04-23 20:37:40.869+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:40.869+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:40.869+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:40.869+0200 W/AUL     (11463): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:40.869+0200 I/location(11463): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:40.869+0200 I/location(11463): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:40:849,nan,37.171445,-3.595179,0.000000,0,0.000000,53.000000,-1.000000
04-23 20:37:40.869+0200 I/location(11463): stopping es.ugr.frailty.location service
04-23 20:37:40.869+0200 E/CAPI_APPFW_APP_CONTROL(11463): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:37:40.869+0200 E/location(11463): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:37:40.869+0200 I/CAPI_APPFW_APPLICATION(11463): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:37:40.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:37:40.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:37:40.919+0200 W/LOCATION(11463): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:40.919+0200 I/LOCATION(11463): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:40.919+0200 I/LOCATION(11463): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:37:40.989+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:37:40.989+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:37:40.989+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:37:40.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:37:41.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:41.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:41.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:41.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72dea68
04-23 20:37:41.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72ceba0]
04-23 20:37:41.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:41.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:41.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:41.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:41.199+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:41.199+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:41.209+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.219+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.219+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:41.219+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:41.219+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:41.219+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:41.219+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:41.219+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:41.219+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:41.219+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:41.219+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:41.229+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.229+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.229+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:41.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.289+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:41.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:41.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:41.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72ceba0
04-23 20:37:41.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72d3388]
04-23 20:37:41.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:41.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:41.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:41.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:41.399+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:41.399+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:41.409+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.419+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.419+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:41.419+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:41.419+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:41.419+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:41.419+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:41.419+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:41.419+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:41.419+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:41.419+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:41.419+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.429+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:41.429+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:41.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:41.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:37:41.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:37:41.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:37:41.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72d3388
04-23 20:37:41.669+0200 W/AUL     (11477): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:37:41.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:37:41.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:37:41.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11440
04-23 20:37:41.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:37:41.679+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11440
04-23 20:37:41.679+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11440)
04-23 20:37:42.879+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:37:50.139+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:37:50.139+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:37:50.139+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:50.139+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:50.159+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11513
04-23 20:37:50.169+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:50.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11513
04-23 20:37:50.209+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11513) type(svcapp) bg(0)
04-23 20:37:50.219+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11513]
04-23 20:37:50.239+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11513)
04-23 20:37:50.239+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:37:50.239+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:50.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:50.259+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11513
04-23 20:37:50.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:50.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:50.269+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11513
04-23 20:37:50.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:50.289+0200 E/CAPI_APPFW_APPLICATION(11513): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:50.289+0200 E/CAPI_APPFW_APPLICATION(11513): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:50.289+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11513) was created
04-23 20:37:50.319+0200 W/LOCATION(11513): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:37:50.319+0200 E/LOCATION(11513): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:37:50.319+0200 E/PKGMGR_INFO(11513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:37:50.319+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:50.339+0200 I/LOCATION(11513): location.c: location_new(269) > method: 0
04-23 20:37:50.339+0200 W/LOCATION(11513): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:50.349+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:50.349+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:50.359+0200 W/LOCATION(11513): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:50.359+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:50.369+0200 W/LOCATION(11513): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:50.369+0200 W/LOCATION(11513): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:50.369+0200 W/LOCATION(11513): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:50.369+0200 W/LOCATION(11513): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:50.389+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:50.389+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:37:50.399+0200 W/LOCATION(11513): module-internal.c: module_new(311) > module (wps) open success
04-23 20:37:50.399+0200 W/LOCATION(11513): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:37:50.399+0200 W/LOCATION(11513): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:37:50.399+0200 W/LOCATION(11513): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:50.399+0200 W/LOCATION(11513): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:50.419+0200 W/LOCATION(11513): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:37:50.419+0200 I/LOCATION(11513): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b01c18
04-23 20:37:50.419+0200 I/LOCATION(11513): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:37:50.419+0200 I/LOCATION(11513): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b01c18
04-23 20:37:50.419+0200 I/LOCATION(11513): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:37:50.429+0200 I/location(11513): es.ugr.frailty.location: creado servicio de localización
04-23 20:37:50.469+0200 I/LOCATION(11513): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:37:50.509+0200 W/LOCATION(11513): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:50.509+0200 W/LOCATION(11513): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:50.509+0200 I/LOCATION(11513): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:50.569+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:37:50.569+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:37:50.569+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:37:50.569+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:50.569+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:50.579+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:37:50.579+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:37:50.579+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:37:50.579+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:37:50.579+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:37:50.579+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:37:50.579+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:37:50.579+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:37:50.629+0200 W/LOCATION(11513): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:37:50.629+0200 W/LOCATION(11513): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:37:50.709+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:50.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72cecd0]
04-23 20:37:50.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:37:50.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:37:50.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:37:50.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:37:50.749+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:50.749+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:50.759+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:50.769+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:50.769+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:37:50.769+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:37:50.769+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:37:50.769+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:37:50.769+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:37:50.769+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:37:50.769+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:37:50.769+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:37:50.769+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:37:50.769+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:50.779+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:37:50.779+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:37:50.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:50.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:37:50.819+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2746080), time2(2732840)
04-23 20:37:50.819+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:37:50.819+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:37:50.819+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:37:50.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:37:50.819+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:37:50.839+0200 W/LOCATION(11513): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:37:50.839+0200 I/LOCATION(11513): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:50.839+0200 I/LOCATION(11513): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:37:50.839+0200 I/location(11513): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:37:50.929+0200 I/LOCATION(11513): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:37:50.979+0200 W/AUL     (11513): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:37:50.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:50.979+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11513
04-23 20:37:50.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:37:50.989+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.989+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:50.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:37:50.989+0200 W/AUL     (11513): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:37:50.989+0200 I/utils   (10115): specific action
04-23 20:37:50.989+0200 I/location(11513): request sent to service es.ugr.frailty.servicemanager
04-23 20:37:50.989+0200 I/location(11513): es.ugr.frailty.location: SM-R760,23/04/2018,20:37:50:979,nan,37.171445,-3.595179,0.000000,0,0.000000,53.000000,-1.000000
04-23 20:37:50.989+0200 W/CAPI_APPFW_APP_CONTROL(11513): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.989+0200 I/utils   (11513): specific action
04-23 20:37:50.989+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.989+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.989+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.989+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:37:50.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:50.989+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:50.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:37:50.999+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.999+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:37:50.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:37:50.999+0200 I/utils   (10120): specific action
04-23 20:37:50.999+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:37:50.999+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:37:50.999+0200 I/servicemanager(10115): requesting to save local data
04-23 20:37:50.999+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.999+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.999+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.999+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:50.999+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:37:50.999+0200 I/recorder(10120): guardando datos en local
04-23 20:37:51.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:51.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:51.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:51.829+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:37:52.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:37:52.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:37:52.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:37:52.619+0200 W/LOCATION(11513): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:37:52.739+0200 I/servicemanager(10115): es.ugr.frailty.gravity alive timeout
04-23 20:37:52.739+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:37:52.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:37:52.739+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:37:52.759+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11522
04-23 20:37:52.759+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:37:52.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11522
04-23 20:37:52.809+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(11522) type(svcapp) bg(0)
04-23 20:37:52.819+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11522]
04-23 20:37:52.819+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11522)
04-23 20:37:52.819+0200 I/servicemanager(10115): es.ugr.frailty.gravity launch request sent!
04-23 20:37:52.819+0200 I/servicemanager(10115): App control destroyed.
04-23 20:37:52.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:52.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11522
04-23 20:37:52.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:52.839+0200 E/CAPI_APPFW_APPLICATION(11522): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:52.839+0200 E/CAPI_APPFW_APPLICATION(11522): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:37:52.839+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11522) was created
04-23 20:37:52.849+0200 I/utils   (11522): trying to start service: es.ugr.frailty.gravity
04-23 20:37:52.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:37:52.849+0200 I/utils   (11522): es.ugr.frailty.gravity sensor supported
04-23 20:37:52.859+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11522
04-23 20:37:52.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:37:52.859+0200 I/utils   (11522): es.ugr.frailty.gravity listener started
04-23 20:37:52.859+0200 W/CAPI_APPFW_APP_CONTROL(11522): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:37:52.859+0200 I/utils   (11522): specific action
04-23 20:37:52.869+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:52.879+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:52:875,9.774874,-0.033435,0.788104
04-23 20:37:52.899+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:52.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:52:903,9.774716,-0.034327,0.790011
04-23 20:37:52.929+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11115136c6f63152450867
