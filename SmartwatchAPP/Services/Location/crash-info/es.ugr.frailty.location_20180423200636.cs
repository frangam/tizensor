S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6170
Date: 2018-04-23 20:06:36+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fec52d, r5   = 0xf71cdf98
r6   = 0xffd030c0, r7   = 0xffd02f70
r8   = 0xf71cac18, r9   = 0x00000000
r10  = 0xffd0304c, fp   = 0xffd030c0
ip   = 0x00000001, sp   = 0xffd02f48
lr   = 0xf6fec539, pc   = 0xf7055228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111544 KB
Buffers:     37352 KB
Cached:     182900 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11896 KB
VmRSS:       11896 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6170 TID = 6170
6170 6173 

Maps Information
f3eb7000 f46b6000 rw-p [stack:6173]
f46bd000 f46bf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46c7000 f46cb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46d4000 f46d6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46de000 f46e1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46f0000 f46f5000 r-xp /usr/lib/libsystem.so.0.0.0
f4700000 f4703000 r-xp /lib/libattr.so.1.1.0
f470b000 f471b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4723000 f472c000 r-xp /usr/lib/libedbus.so.1.7.99
f4734000 f4735000 r-xp /usr/lib/libresponse.so.0.2.96
f473e000 f4743000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fe5000 f60eb000 r-xp /usr/lib/libicuuc.so.57.1
f6101000 f6289000 r-xp /usr/lib/libicui18n.so.57.1
f6299000 f62a6000 r-xp /usr/lib/libail.so.0.1.0
f62af000 f62b6000 r-xp /usr/lib/libminizip.so.1.0.0
f62bf000 f6468000 r-xp /usr/lib/libcrypto.so.1.0.0
f6488000 f64cf000 r-xp /usr/lib/libssl.so.1.0.0
f64db000 f64dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64e5000 f64ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64f5000 f64fc000 r-xp /lib/libcrypt-2.13.so
f652d000 f6530000 r-xp /lib/libcap.so.2.21
f6538000 f653a000 r-xp /usr/lib/libiri.so
f6542000 f658b000 r-xp /usr/lib/libmdm.so.1.2.69
f6593000 f6599000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65a1000 f65c4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65ce000 f65d0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65d8000 f65f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65fe000 f6602000 r-xp /usr/lib/libsmack.so.1.0.0
f660b000 f6624000 r-xp /usr/lib/libnetwork.so.0.0.0
f662d000 f6635000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f663d000 f6643000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f664c000 f664e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6657000 f6667000 r-xp /lib/libresolv-2.13.so
f666b000 f6683000 r-xp /usr/lib/liblzma.so.5.0.3
f668c000 f668e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6696000 f66b0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66b8000 f66e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66f0000 f66ff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6709000 f6713000 r-xp /usr/lib/libsensord-shared.so
f671c000 f67ef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67fa000 f6810000 r-xp /lib/libz.so.1.2.5
f6818000 f681d000 r-xp /usr/lib/libffi.so.5.0.10
f6825000 f6826000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f682e000 f683e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6846000 f685f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6867000 f6869000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6871000 f68e6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68f0000 f68f6000 r-xp /lib/librt-2.13.so
f68ff000 f691d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6927000 f6928000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6930000 f6953000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f695b000 f6960000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6968000 f6992000 r-xp /usr/lib/libdbus-1.so.3.8.12
f699b000 f69b2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69ba000 f6a23000 r-xp /lib/libm-2.13.so
f6a2c000 f6ac0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ad3000 f6ad8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ae0000 f6ae7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6aef000 f6b19000 r-xp /usr/lib/libsensor.so.1.9.6
f6b22000 f6bee000 r-xp /usr/lib/libxml2.so.2.7.8
f6bfb000 f6bfd000 r-xp /usr/lib/libiniparser.so.0
f6c06000 f6c0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c15000 f6ce5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ce6000 f6d1a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d23000 f6d5f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d67000 f6d6a000 r-xp /usr/lib/libbundle.so.0.1.22
f6d72000 f6d78000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d80000 f6dc1000 r-xp /usr/lib/libeina.so.1.7.99
f6dca000 f6de1000 r-xp /usr/lib/libecore.so.1.7.99
f6df8000 f6e01000 r-xp /usr/lib/libvconf.so.0.2.45
f6e09000 f6e1d000 r-xp /lib/libpthread-2.13.so
f6e28000 f6e35000 r-xp /usr/lib/libaul.so.0.1.0
f6e3f000 f6e41000 r-xp /lib/libdl-2.13.so
f6e4a000 f6e55000 r-xp /lib/libunwind.so.8.0.1
f6e82000 f6e8a000 r-xp /lib/libgcc_s-4.6.so.1
f6e8b000 f6faf000 r-xp /lib/libc-2.13.so
f6fbd000 f6fbf000 r-xp /usr/lib/libdlog.so.0.0.0
f6fc7000 f6fd3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fdc000 f6fe1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fe9000 f6ff8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7000000 f7004000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f700d000 f7010000 r-xp /usr/lib/libappcore-agent.so.1.1
f7018000 f701a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7022000 f7026000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f702e000 f704b000 r-xp /lib/ld-2.13.so
f7054000 f7057000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7057000 f705b000 r-xp /usr/lib/libsys-assert.so
f719a000 f720b000 rw-p [heap]
ffce4000 ffd05000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6170)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7055228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cf33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cf1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d3875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cf1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d35e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d36017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d3df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46d51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46c8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf679b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c48fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c4a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ddaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dd5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dd65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dd6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf700e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf700e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70554f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6ea285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7054f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 20:06:23.309+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:23.309+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:23.309+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:23.309+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:23.309+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:23.309+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:23.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.329+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.329+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:23.339+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:23.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:23.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:23.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:23.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:23.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:23.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e4530
04-23 20:06:23.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f2fce8]
04-23 20:06:23.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:23.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:23.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:23.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:23.509+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:23.509+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:23.529+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.539+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:23.539+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:23.539+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:23.539+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:23.539+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:23.539+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:23.539+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:23.539+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:23.539+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:23.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.549+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:23.549+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:23.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:23.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:23.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:23.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:23.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:23.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f2fce8
04-23 20:06:23.729+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:06:23.729+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:23.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:23.729+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:23.739+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6122
04-23 20:06:23.749+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:23.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6122
04-23 20:06:23.789+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6122) type(svcapp) bg(0)
04-23 20:06:23.799+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6122)
04-23 20:06:23.799+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:06:23.799+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:23.799+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6122]
04-23 20:06:23.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:23.819+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6122
04-23 20:06:23.829+0200 E/CAPI_APPFW_APPLICATION( 6122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:23.829+0200 E/CAPI_APPFW_APPLICATION( 6122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:23.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6122
04-23 20:06:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:23.839+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6122) was created
04-23 20:06:23.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:23.859+0200 W/LOCATION( 6122): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:23.859+0200 E/LOCATION( 6122): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:23.859+0200 E/PKGMGR_INFO( 6122): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:23.869+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:23.879+0200 I/LOCATION( 6122): location.c: location_new(269) > method: 0
04-23 20:06:23.879+0200 W/LOCATION( 6122): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:23.889+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:23.889+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:23.899+0200 W/LOCATION( 6122): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:23.899+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:23.909+0200 W/LOCATION( 6122): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:23.909+0200 W/LOCATION( 6122): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:23.909+0200 W/LOCATION( 6122): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:23.909+0200 W/LOCATION( 6122): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:23.929+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:23.929+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:23.939+0200 W/LOCATION( 6122): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:23.939+0200 W/LOCATION( 6122): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:23.949+0200 W/LOCATION( 6122): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:23.949+0200 W/LOCATION( 6122): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:23.949+0200 W/LOCATION( 6122): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:23.959+0200 W/LOCATION( 6122): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:23.959+0200 I/LOCATION( 6122): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7616c18
04-23 20:06:23.969+0200 I/LOCATION( 6122): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:23.969+0200 I/LOCATION( 6122): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7616c18
04-23 20:06:23.969+0200 I/LOCATION( 6122): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:23.969+0200 I/location( 6122): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:24.009+0200 I/LOCATION( 6122): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:24.049+0200 W/LOCATION( 6122): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:24.049+0200 W/LOCATION( 6122): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:24.049+0200 I/LOCATION( 6122): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:24.119+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:24.119+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:24.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:24.129+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:24.129+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:24.129+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:24.129+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:24.129+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:24.129+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:24.129+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:24.129+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:24.129+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:24.129+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:24.179+0200 W/LOCATION( 6122): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:24.179+0200 W/LOCATION( 6122): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:24.259+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:24.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f011b8]
04-23 20:06:24.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:24.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:24.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:24.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:24.309+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:24.309+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:24.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:24.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:24.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:24.339+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:24.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:24.359+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:24.359+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:24.359+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:24.359+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:24.359+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:24.359+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:24.359+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:24.359+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:24.359+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:24.369+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:24.369+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:24.369+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(859633), time2(856517)
04-23 20:06:24.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:06:24.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:24.369+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:24.369+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:24.379+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:24.379+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:24.379+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:24.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:24.459+0200 W/LOCATION( 6122): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:24.459+0200 I/LOCATION( 6122): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:24.459+0200 I/LOCATION( 6122): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:24.459+0200 I/location( 6122): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:24.589+0200 I/LOCATION( 6122): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:24.669+0200 E/location( 6122): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:24.669+0200 W/AUL     ( 6122): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:24.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:24.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6122
04-23 20:06:24.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:24.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:24.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:24.679+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.689+0200 I/utils   ( 5532): specific action
04-23 20:06:24.689+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.689+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.689+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.689+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:24.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:24.689+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:24.699+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:24.699+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.699+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:24.699+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:06:24.699+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:24.699+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:24.699+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:24.699+0200 W/AUL     ( 6122): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:24.699+0200 I/location( 6122): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:24.699+0200 I/location( 6122): stopping es.ugr.frailty.location service
04-23 20:06:24.699+0200 E/CAPI_APPFW_APP_CONTROL( 6122): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:06:24.699+0200 E/location( 6122): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:06:24.699+0200 I/CAPI_APPFW_APPLICATION( 6122): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:06:24.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:06:24.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:06:24.719+0200 I/utils   ( 5538): specific action
04-23 20:06:24.719+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.719+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.719+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.719+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:24.719+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:24.719+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:24.769+0200 W/LOCATION( 6122): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:24.769+0200 I/LOCATION( 6122): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:24.769+0200 I/LOCATION( 6122): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:06:24.869+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:06:24.869+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:06:24.869+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:06:24.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:06:24.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:25.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:25.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:25.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f011b8
04-23 20:06:25.109+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f10fd0]
04-23 20:06:25.109+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:25.109+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:25.109+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:25.109+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:25.109+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:25.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:25.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.129+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:25.129+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:25.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:25.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:25.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:25.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:25.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:25.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:25.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:25.149+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.159+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.159+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:25.159+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:25.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:25.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:25.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f10fd0
04-23 20:06:25.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f25ed8]
04-23 20:06:25.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:25.339+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:25.339+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:25.339+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:25.349+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:25.349+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:25.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.369+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.369+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:25.369+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:25.369+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:25.369+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:25.369+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:25.369+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:25.369+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:25.369+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:25.369+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:25.379+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.379+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:25.379+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:25.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:25.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:25.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:25.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:25.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f25ed8
04-23 20:06:25.649+0200 W/AUL     ( 6134): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:06:25.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:06:25.649+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:06:25.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6100
04-23 20:06:25.649+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:06:25.649+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6100
04-23 20:06:25.649+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6100)
04-23 20:06:26.699+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:06:33.809+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:06:33.809+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:33.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:33.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:33.819+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6170
04-23 20:06:33.819+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:33.869+0200 E/CAPI_APPFW_APPLICATION( 6170): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:33.869+0200 E/CAPI_APPFW_APPLICATION( 6170): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:33.869+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6170
04-23 20:06:33.869+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6170) type(svcapp) bg(0)
04-23 20:06:33.869+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6170) was created
04-23 20:06:33.869+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6170)
04-23 20:06:33.869+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:06:33.869+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:33.879+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6170]
04-23 20:06:33.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:33.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6170
04-23 20:06:33.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:33.909+0200 W/LOCATION( 6170): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:33.909+0200 E/LOCATION( 6170): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:33.909+0200 E/PKGMGR_INFO( 6170): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:33.909+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:33.929+0200 I/LOCATION( 6170): location.c: location_new(269) > method: 0
04-23 20:06:33.929+0200 W/LOCATION( 6170): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:33.939+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:33.939+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:33.939+0200 W/LOCATION( 6170): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:33.949+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:33.949+0200 W/LOCATION( 6170): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:33.949+0200 W/LOCATION( 6170): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:33.949+0200 W/LOCATION( 6170): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:33.949+0200 W/LOCATION( 6170): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:33.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:33.969+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6170
04-23 20:06:33.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:33.979+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:33.979+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:33.979+0200 W/LOCATION( 6170): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:33.989+0200 W/LOCATION( 6170): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:33.989+0200 W/LOCATION( 6170): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:33.989+0200 W/LOCATION( 6170): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:33.989+0200 W/LOCATION( 6170): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:34.009+0200 W/LOCATION( 6170): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:34.009+0200 I/LOCATION( 6170): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf71cac18
04-23 20:06:34.009+0200 I/LOCATION( 6170): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:34.009+0200 I/LOCATION( 6170): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf71cac18
04-23 20:06:34.009+0200 I/LOCATION( 6170): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:34.019+0200 I/location( 6170): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:34.059+0200 I/LOCATION( 6170): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:34.099+0200 W/LOCATION( 6170): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:34.099+0200 W/LOCATION( 6170): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:34.099+0200 I/LOCATION( 6170): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:34.169+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:34.169+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:34.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:34.169+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:34.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:34.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:34.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:34.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:34.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:34.169+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:34.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:34.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:34.229+0200 W/LOCATION( 6170): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:34.229+0200 W/LOCATION( 6170): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:34.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:34.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:34.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:34.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f2fac0]
04-23 20:06:34.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:34.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:34.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:34.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:34.369+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:34.369+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:34.379+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:34.389+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:34.389+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:34.389+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:34.389+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:34.389+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:34.389+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:34.389+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:34.389+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:34.389+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:34.389+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:34.399+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:34.399+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:34.399+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:34.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:34.449+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:34.469+0200 W/LOCATION( 6170): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:34.469+0200 I/LOCATION( 6170): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:34.469+0200 I/LOCATION( 6170): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:34.469+0200 I/location( 6170): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:34.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:34.469+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(869738), time2(856517)
04-23 20:06:34.469+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:06:34.469+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:34.469+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:34.469+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:34.569+0200 I/LOCATION( 6170): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:34.619+0200 E/location( 6170): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:34.619+0200 W/AUL     ( 6170): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:34.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:34.619+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6170
04-23 20:06:34.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:34.629+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.629+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:34.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:34.629+0200 W/AUL     ( 6170): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:34.629+0200 I/location( 6170): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:34.629+0200 W/CAPI_APPFW_APP_CONTROL( 6170): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.629+0200 I/utils   ( 6170): specific action
04-23 20:06:34.639+0200 I/utils   ( 5532): specific action
04-23 20:06:34.639+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.639+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.639+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.639+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:34.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:34.639+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:34.649+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:34.649+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:34.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.649+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:34.649+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:06:34.649+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:34.649+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:34.649+0200 I/utils   ( 5538): specific action
04-23 20:06:34.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:34.649+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:34.659+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:35.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:35.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:35.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:35.409+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:06:36.049+0200 W/LOCATION( 6170): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:06:36.209+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11061706c6f63152450679
