S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9521
Date: 2018-04-23 20:30:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70c052d, r5   = 0xf73c7958
r6   = 0xff9cc2d0, r7   = 0xff9cc180
r8   = 0xf73dac18, r9   = 0x00000000
r10  = 0xff9cc25c, fp   = 0xff9cc2d0
ip   = 0x00000001, sp   = 0xff9cc158
lr   = 0xf70c0539, pc   = 0xf7129228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146848 KB
Buffers:     35220 KB
Cached:     153616 KB
VmPeak:      52532 KB
VmSize:      52528 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11948 KB
VmRSS:       11948 KB
VmData:      10256 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9521 TID = 9521
9521 9524 

Maps Information
f3f8b000 f478a000 rw-p [stack:9524]
f4791000 f4793000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f479b000 f479f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47a8000 f47aa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47b2000 f47b5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47c4000 f47c9000 r-xp /usr/lib/libsystem.so.0.0.0
f47d4000 f47d7000 r-xp /lib/libattr.so.1.1.0
f47df000 f47ef000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47f7000 f4800000 r-xp /usr/lib/libedbus.so.1.7.99
f4808000 f4809000 r-xp /usr/lib/libresponse.so.0.2.96
f4812000 f4817000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60b9000 f61bf000 r-xp /usr/lib/libicuuc.so.57.1
f61d5000 f635d000 r-xp /usr/lib/libicui18n.so.57.1
f636d000 f637a000 r-xp /usr/lib/libail.so.0.1.0
f6383000 f638a000 r-xp /usr/lib/libminizip.so.1.0.0
f6393000 f653c000 r-xp /usr/lib/libcrypto.so.1.0.0
f655c000 f65a3000 r-xp /usr/lib/libssl.so.1.0.0
f65af000 f65b1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65b9000 f65c0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65c9000 f65d0000 r-xp /lib/libcrypt-2.13.so
f6601000 f6604000 r-xp /lib/libcap.so.2.21
f660c000 f660e000 r-xp /usr/lib/libiri.so
f6616000 f665f000 r-xp /usr/lib/libmdm.so.1.2.69
f6667000 f666d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6675000 f6698000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66a2000 f66a4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66ac000 f66c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66d2000 f66d6000 r-xp /usr/lib/libsmack.so.1.0.0
f66df000 f66f8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6701000 f6709000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6711000 f6717000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6720000 f6722000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f672b000 f673b000 r-xp /lib/libresolv-2.13.so
f673f000 f6757000 r-xp /usr/lib/liblzma.so.5.0.3
f6760000 f6762000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f676a000 f6784000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f678c000 f67bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67c4000 f67d3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67dd000 f67e7000 r-xp /usr/lib/libsensord-shared.so
f67f0000 f68c3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ce000 f68e4000 r-xp /lib/libz.so.1.2.5
f68ec000 f68f1000 r-xp /usr/lib/libffi.so.5.0.10
f68f9000 f68fa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6902000 f6912000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f691a000 f6933000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f693b000 f693d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6945000 f69ba000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69c4000 f69ca000 r-xp /lib/librt-2.13.so
f69d3000 f69f1000 r-xp /usr/lib/libsystemd.so.0.4.0
f69fb000 f69fc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a04000 f6a27000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a2f000 f6a34000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a3c000 f6a66000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a6f000 f6a86000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a8e000 f6af7000 r-xp /lib/libm-2.13.so
f6b00000 f6b94000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ba7000 f6bac000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bb4000 f6bbb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bc3000 f6bed000 r-xp /usr/lib/libsensor.so.1.9.6
f6bf6000 f6cc2000 r-xp /usr/lib/libxml2.so.2.7.8
f6ccf000 f6cd1000 r-xp /usr/lib/libiniparser.so.0
f6cda000 f6ce0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ce9000 f6db9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dba000 f6dee000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6df7000 f6e33000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e3b000 f6e3e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e46000 f6e4c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e54000 f6e95000 r-xp /usr/lib/libeina.so.1.7.99
f6e9e000 f6eb5000 r-xp /usr/lib/libecore.so.1.7.99
f6ecc000 f6ed5000 r-xp /usr/lib/libvconf.so.0.2.45
f6edd000 f6ef1000 r-xp /lib/libpthread-2.13.so
f6efc000 f6f09000 r-xp /usr/lib/libaul.so.0.1.0
f6f13000 f6f15000 r-xp /lib/libdl-2.13.so
f6f1e000 f6f29000 r-xp /lib/libunwind.so.8.0.1
f6f56000 f6f5e000 r-xp /lib/libgcc_s-4.6.so.1
f6f5f000 f7083000 r-xp /lib/libc-2.13.so
f7091000 f7093000 r-xp /usr/lib/libdlog.so.0.0.0
f709b000 f70a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70b0000 f70b5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70bd000 f70cc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70d4000 f70d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70e1000 f70e4000 r-xp /usr/lib/libappcore-agent.so.1.1
f70ec000 f70ee000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70f6000 f70fa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7102000 f711f000 r-xp /lib/ld-2.13.so
f7128000 f712b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f712b000 f712f000 r-xp /usr/lib/libsys-assert.so
f73aa000 f7439000 rw-p [heap]
ff9ad000 ff9ce000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9521)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7129228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70c0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dc73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dc5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dd1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dd7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dd7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e0c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e071f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dc5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dd1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dd7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dd7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e09e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e0a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e11f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47a91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf479c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf686f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d1cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d1e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eaeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ea9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eaa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eaa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70e2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70e27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71294f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f7685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7128f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3 20:30:42.509+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:42.509+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:42.509+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:42.509+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:42.509+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:42.509+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:42.509+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:42.509+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:42.509+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:42.519+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.529+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.529+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:42.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:42.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:42.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:42.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:42.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:42.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:42.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4003100
04-23 20:30:42.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40032b8]
04-23 20:30:42.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:42.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:42.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:42.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:42.719+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:42.719+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:42.729+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.739+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.739+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:42.739+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:42.739+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:42.739+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:42.739+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:42.739+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:42.739+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:42.739+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:42.739+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:42.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:42.749+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:42.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:42.799+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:42.799+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:42.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:42.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:42.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf40032b8
04-23 20:30:42.939+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:30:42.939+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:42.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:42.939+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:42.949+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9474
04-23 20:30:42.949+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:42.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9474
04-23 20:30:42.999+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9474) type(svcapp) bg(0)
04-23 20:30:42.999+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9474]
04-23 20:30:42.999+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9474)
04-23 20:30:42.999+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:30:42.999+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:43.009+0200 E/CAPI_APPFW_APPLICATION( 9474): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:43.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:43.029+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9474
04-23 20:30:43.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:43.029+0200 E/CAPI_APPFW_APPLICATION( 9474): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:43.029+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9474) was created
04-23 20:30:43.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:43.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9474
04-23 20:30:43.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:43.069+0200 W/LOCATION( 9474): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:43.079+0200 E/LOCATION( 9474): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:43.079+0200 E/PKGMGR_INFO( 9474): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:43.079+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:43.099+0200 I/LOCATION( 9474): location.c: location_new(269) > method: 0
04-23 20:30:43.099+0200 W/LOCATION( 9474): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:43.109+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:43.109+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:43.109+0200 W/LOCATION( 9474): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:43.119+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:43.119+0200 W/LOCATION( 9474): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:43.119+0200 W/LOCATION( 9474): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:43.119+0200 W/LOCATION( 9474): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:43.119+0200 W/LOCATION( 9474): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:43.139+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:43.149+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:43.149+0200 W/LOCATION( 9474): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:43.149+0200 W/LOCATION( 9474): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:43.159+0200 W/LOCATION( 9474): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:43.159+0200 W/LOCATION( 9474): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:43.159+0200 W/LOCATION( 9474): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:43.169+0200 W/LOCATION( 9474): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:43.169+0200 I/LOCATION( 9474): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf79fdc18
04-23 20:30:43.169+0200 I/LOCATION( 9474): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:43.169+0200 I/LOCATION( 9474): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf79fdc18
04-23 20:30:43.169+0200 I/LOCATION( 9474): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:43.179+0200 I/location( 9474): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:43.219+0200 I/LOCATION( 9474): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:43.259+0200 W/LOCATION( 9474): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:43.259+0200 W/LOCATION( 9474): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:43.259+0200 I/LOCATION( 9474): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:43.359+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:43.359+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:43.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:43.359+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:43.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:43.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:43.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:43.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:43.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:43.359+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:43.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:43.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:43.409+0200 W/LOCATION( 9474): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:43.409+0200 W/LOCATION( 9474): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:43.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:43.529+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4016340]
04-23 20:30:43.529+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:43.529+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:43.529+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:43.529+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:43.539+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:43.539+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:43.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:43.559+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:43.559+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:43.559+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:43.559+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:43.559+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:43.559+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:43.559+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:43.559+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:43.559+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:43.559+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:43.559+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:43.569+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:43.569+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:43.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:43.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:43.599+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2318862), time2(2315727)
04-23 20:30:43.599+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:30:43.599+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:43.599+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:43.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:43.619+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:43.659+0200 W/LOCATION( 9474): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:43.659+0200 I/LOCATION( 9474): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:43.659+0200 I/LOCATION( 9474): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:43.659+0200 I/location( 9474): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:43.769+0200 I/LOCATION( 9474): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:43.839+0200 E/location( 9474): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:43.839+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:43.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:43.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9474
04-23 20:30:43.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:43.849+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:43.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:43.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.849+0200 I/utils   ( 8242): specific action
04-23 20:30:43.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.849+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:43.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:43.849+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:43.859+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:43.859+0200 I/location( 9474): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:43.859+0200 I/location( 9474): stopping es.ugr.frailty.location service
04-23 20:30:43.859+0200 E/CAPI_APPFW_APP_CONTROL( 9474): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:30:43.859+0200 E/location( 9474): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:30:43.859+0200 I/CAPI_APPFW_APPLICATION( 9474): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:43.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:43.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:43.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:43.859+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:43.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:43.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.859+0200 I/utils   ( 8247): specific action
04-23 20:30:43.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:43.859+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:43.859+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:43.859+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:43.859+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:43.859+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:44.039+0200 W/LOCATION( 9474): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:44.039+0200 I/LOCATION( 9474): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:44.039+0200 I/LOCATION( 9474): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:30:44.119+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:30:44.119+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:30:44.119+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:30:44.119+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:30:44.239+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.299+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:44.299+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:44.299+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:44.299+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4016340
04-23 20:30:44.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4000550]
04-23 20:30:44.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:44.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:44.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:44.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:44.379+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:44.379+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:44.379+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.399+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:44.399+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:44.399+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:44.399+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:44.399+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:44.399+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:44.399+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:44.399+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:44.399+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:44.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.409+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.409+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:44.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:44.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:44.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:44.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4000550
04-23 20:30:44.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4006560]
04-23 20:30:44.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:44.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:44.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:44.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:44.699+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:44.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:44.699+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.709+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.709+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:44.709+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:44.709+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:44.709+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:44.709+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:44.709+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:44.709+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:44.709+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:44.709+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:44.719+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.729+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:44.729+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:44.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:44.779+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:44.779+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:44.779+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:44.779+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4006560
04-23 20:30:44.989+0200 W/AUL     ( 9485): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:30:44.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:44.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:44.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9448
04-23 20:30:44.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:44.989+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9448
04-23 20:30:44.989+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9448)
04-23 20:30:45.859+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:30:53.009+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:30:53.009+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:53.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:53.009+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:53.019+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:53.029+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9521
04-23 20:30:53.069+0200 E/CAPI_APPFW_APPLICATION( 9521): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:53.069+0200 E/CAPI_APPFW_APPLICATION( 9521): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:53.079+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9521
04-23 20:30:53.079+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9521) type(svcapp) bg(0)
04-23 20:30:53.079+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9521]
04-23 20:30:53.079+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9521)
04-23 20:30:53.079+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:30:53.079+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:53.079+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9521) was created
04-23 20:30:53.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:53.109+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9521
04-23 20:30:53.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:53.119+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9521
04-23 20:30:53.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:53.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:53.139+0200 W/LOCATION( 9521): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:53.139+0200 E/LOCATION( 9521): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:53.149+0200 E/PKGMGR_INFO( 9521): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:53.149+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:53.169+0200 I/LOCATION( 9521): location.c: location_new(269) > method: 0
04-23 20:30:53.169+0200 W/LOCATION( 9521): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:53.169+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:53.179+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:53.179+0200 W/LOCATION( 9521): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:53.179+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:53.189+0200 W/LOCATION( 9521): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:53.189+0200 W/LOCATION( 9521): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:53.189+0200 W/LOCATION( 9521): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:53.189+0200 W/LOCATION( 9521): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:53.209+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:53.209+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:53.209+0200 W/LOCATION( 9521): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:53.219+0200 W/LOCATION( 9521): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:53.219+0200 W/LOCATION( 9521): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:53.219+0200 W/LOCATION( 9521): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:53.219+0200 W/LOCATION( 9521): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:53.239+0200 W/LOCATION( 9521): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:53.239+0200 I/LOCATION( 9521): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73dac18
04-23 20:30:53.239+0200 I/LOCATION( 9521): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:53.239+0200 I/LOCATION( 9521): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73dac18
04-23 20:30:53.239+0200 I/LOCATION( 9521): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:53.239+0200 I/location( 9521): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:53.299+0200 I/LOCATION( 9521): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:53.339+0200 W/LOCATION( 9521): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:53.339+0200 W/LOCATION( 9521): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:53.339+0200 I/LOCATION( 9521): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:53.409+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:53.409+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:53.409+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:53.409+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:53.409+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:53.419+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:53.419+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:53.419+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:53.419+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:53.419+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:53.419+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:53.419+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:53.419+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:53.479+0200 W/LOCATION( 9521): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:53.479+0200 W/LOCATION( 9521): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:53.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:53.589+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40052c8]
04-23 20:30:53.589+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:53.589+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:53.589+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:53.589+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:53.599+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:53.599+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:53.609+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:53.619+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:53.619+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:53.619+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:53.619+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:53.619+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:53.619+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:53.619+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:53.619+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:53.619+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:53.619+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:53.629+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:53.629+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:53.629+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:53.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:53.639+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:53.639+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2328907), time2(2315727)
04-23 20:30:53.639+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:30:53.639+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:53.639+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:53.639+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:53.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:53.719+0200 W/LOCATION( 9521): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:53.719+0200 I/LOCATION( 9521): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:53.719+0200 I/LOCATION( 9521): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:53.719+0200 I/location( 9521): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:53.799+0200 I/LOCATION( 9521): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:53.849+0200 E/location( 9521): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:53.849+0200 W/AUL     ( 9521): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:53.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:53.849+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9521
04-23 20:30:53.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:53.859+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:53.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:53.859+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.859+0200 I/utils   ( 8242): specific action
04-23 20:30:53.859+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.859+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.859+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.859+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:53.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:53.859+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:53.869+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:53.869+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:53.869+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:53.869+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.869+0200 I/utils   ( 8247): specific action
04-23 20:30:53.869+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.869+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.869+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.869+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.869+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:53.869+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:53.869+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:53.879+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:53.879+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:53.879+0200 W/AUL     ( 9521): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:53.879+0200 I/location( 9521): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:53.879+0200 W/CAPI_APPFW_APP_CONTROL( 9521): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:53.879+0200 I/utils   ( 9521): specific action
04-23 20:30:54.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:54.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:54.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:54.649+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:30:55.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:55.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:55.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:55.339+0200 W/LOCATION( 9521): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:30:55.529+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11095216c6f63152450825
