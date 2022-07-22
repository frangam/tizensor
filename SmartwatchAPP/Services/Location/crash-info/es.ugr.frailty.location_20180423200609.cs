S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6026
Date: 2018-04-23 20:06:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf738252d, r5   = 0xf7582f98
r6   = 0xff9dada0, r7   = 0xff9dac50
r8   = 0xf757fc18, r9   = 0x00000000
r10  = 0xff9dad2c, fp   = 0xff9dada0
ip   = 0x00000001, sp   = 0xff9dac28
lr   = 0xf7382539, pc   = 0xf73eb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    112696 KB
Buffers:     36948 KB
Cached:     182448 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11852 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6026 TID = 6026
6026 6029 

Maps Information
f424d000 f4a4c000 rw-p [stack:6029]
f4a53000 f4a55000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a5d000 f4a61000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a6a000 f4a6c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a74000 f4a77000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a86000 f4a8b000 r-xp /usr/lib/libsystem.so.0.0.0
f4a96000 f4a99000 r-xp /lib/libattr.so.1.1.0
f4aa1000 f4ab1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ab9000 f4ac2000 r-xp /usr/lib/libedbus.so.1.7.99
f4aca000 f4acb000 r-xp /usr/lib/libresponse.so.0.2.96
f4ad4000 f4ad9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f637b000 f6481000 r-xp /usr/lib/libicuuc.so.57.1
f6497000 f661f000 r-xp /usr/lib/libicui18n.so.57.1
f662f000 f663c000 r-xp /usr/lib/libail.so.0.1.0
f6645000 f664c000 r-xp /usr/lib/libminizip.so.1.0.0
f6655000 f67fe000 r-xp /usr/lib/libcrypto.so.1.0.0
f681e000 f6865000 r-xp /usr/lib/libssl.so.1.0.0
f6871000 f6873000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f687b000 f6882000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f688b000 f6892000 r-xp /lib/libcrypt-2.13.so
f68c3000 f68c6000 r-xp /lib/libcap.so.2.21
f68ce000 f68d0000 r-xp /usr/lib/libiri.so
f68d8000 f6921000 r-xp /usr/lib/libmdm.so.1.2.69
f6929000 f692f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6937000 f695a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6964000 f6966000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f696e000 f698b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6994000 f6998000 r-xp /usr/lib/libsmack.so.1.0.0
f69a1000 f69ba000 r-xp /usr/lib/libnetwork.so.0.0.0
f69c3000 f69cb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69d3000 f69d9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69e2000 f69e4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69ed000 f69fd000 r-xp /lib/libresolv-2.13.so
f6a01000 f6a19000 r-xp /usr/lib/liblzma.so.5.0.3
f6a22000 f6a24000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a2c000 f6a46000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a4e000 f6a7d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a86000 f6a95000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a9f000 f6aa9000 r-xp /usr/lib/libsensord-shared.so
f6ab2000 f6b85000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b90000 f6ba6000 r-xp /lib/libz.so.1.2.5
f6bae000 f6bb3000 r-xp /usr/lib/libffi.so.5.0.10
f6bbb000 f6bbc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bc4000 f6bd4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bdc000 f6bf5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bfd000 f6bff000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c07000 f6c7c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c86000 f6c8c000 r-xp /lib/librt-2.13.so
f6c95000 f6cb3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cbd000 f6cbe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cc6000 f6ce9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cf1000 f6cf6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cfe000 f6d28000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d31000 f6d48000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d50000 f6db9000 r-xp /lib/libm-2.13.so
f6dc2000 f6e56000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e69000 f6e6e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e76000 f6e7d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e85000 f6eaf000 r-xp /usr/lib/libsensor.so.1.9.6
f6eb8000 f6f84000 r-xp /usr/lib/libxml2.so.2.7.8
f6f91000 f6f93000 r-xp /usr/lib/libiniparser.so.0
f6f9c000 f6fa2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fab000 f707b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f707c000 f70b0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70b9000 f70f5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70fd000 f7100000 r-xp /usr/lib/libbundle.so.0.1.22
f7108000 f710e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7116000 f7157000 r-xp /usr/lib/libeina.so.1.7.99
f7160000 f7177000 r-xp /usr/lib/libecore.so.1.7.99
f718e000 f7197000 r-xp /usr/lib/libvconf.so.0.2.45
f719f000 f71b3000 r-xp /lib/libpthread-2.13.so
f71be000 f71cb000 r-xp /usr/lib/libaul.so.0.1.0
f71d5000 f71d7000 r-xp /lib/libdl-2.13.so
f71e0000 f71eb000 r-xp /lib/libunwind.so.8.0.1
f7218000 f7220000 r-xp /lib/libgcc_s-4.6.so.1
f7221000 f7345000 r-xp /lib/libc-2.13.so
f7353000 f7355000 r-xp /usr/lib/libdlog.so.0.0.0
f735d000 f7369000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7372000 f7377000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f737f000 f738e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7396000 f739a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73a3000 f73a6000 r-xp /usr/lib/libappcore-agent.so.1.1
f73ae000 f73b0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73b8000 f73bc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73c4000 f73e1000 r-xp /lib/ld-2.13.so
f73ea000 f73ed000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73ed000 f73f1000 r-xp /usr/lib/libsys-assert.so
f754f000 f75d9000 rw-p [heap]
ff9bc000 ff9dd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6026)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73eb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7382539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70893f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7087c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7093e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7099be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7099dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ce75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70c91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7087c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7093e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7099be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7099dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70cbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70cc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70d3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a6b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a5e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b31663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fdefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fe07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7170ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf716bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf716c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf716c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73a4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73a47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73eb4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf723885c) [/lib/libc.so.6] + 0x1785c
29: (0xf73eaf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 20:05:57.109+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:57.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:57.109+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:57.109+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:57.109+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:57.109+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:57.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.129+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:57.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:57.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:57.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:57.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:05:57.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:05:57.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:05:57.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f00758
04-23 20:05:57.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f15f00]
04-23 20:05:57.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:05:57.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:05:57.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:05:57.309+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:05:57.319+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:57.319+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:57.329+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.349+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.349+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:05:57.349+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:05:57.349+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:57.349+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:57.349+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:57.349+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:57.349+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:57.349+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:57.349+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:57.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:57.359+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:57.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:57.379+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:05:57.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:05:57.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:57.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:57.389+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:05:57.389+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 5973
04-23 20:05:57.439+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5973
04-23 20:05:57.439+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(5973) type(svcapp) bg(0)
04-23 20:05:57.439+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5973]
04-23 20:05:57.439+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5973)
04-23 20:05:57.439+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:05:57.439+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:05:57.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:05:57.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5973
04-23 20:05:57.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:57.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:05:57.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:05:57.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:05:57.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:05:57.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f15f00
04-23 20:05:57.529+0200 E/CAPI_APPFW_APPLICATION( 5973): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:05:57.529+0200 E/CAPI_APPFW_APPLICATION( 5973): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:05:57.539+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (5973) was created
04-23 20:05:57.569+0200 W/LOCATION( 5973): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:05:57.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:05:57.579+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5973
04-23 20:05:57.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:05:57.579+0200 E/LOCATION( 5973): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:05:57.579+0200 E/PKGMGR_INFO( 5973): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:05:57.589+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:57.609+0200 I/LOCATION( 5973): location.c: location_new(269) > method: 0
04-23 20:05:57.619+0200 W/LOCATION( 5973): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:57.619+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:57.649+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:57.659+0200 W/LOCATION( 5973): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:57.659+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:57.669+0200 W/LOCATION( 5973): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:57.669+0200 W/LOCATION( 5973): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:57.669+0200 W/LOCATION( 5973): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:57.669+0200 W/LOCATION( 5973): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:57.709+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:05:57.709+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:05:57.719+0200 W/LOCATION( 5973): module-internal.c: module_new(311) > module (wps) open success
04-23 20:05:57.719+0200 W/LOCATION( 5973): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:05:57.729+0200 W/LOCATION( 5973): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:05:57.729+0200 W/LOCATION( 5973): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:05:57.729+0200 W/LOCATION( 5973): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:05:57.759+0200 W/LOCATION( 5973): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:05:57.759+0200 I/LOCATION( 5973): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b25c18
04-23 20:05:57.759+0200 I/LOCATION( 5973): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:05:57.759+0200 I/LOCATION( 5973): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b25c18
04-23 20:05:57.759+0200 I/LOCATION( 5973): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:05:57.769+0200 I/location( 5973): es.ugr.frailty.location: creado servicio de localización
04-23 20:05:57.839+0200 I/LOCATION( 5973): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:05:57.889+0200 W/LOCATION( 5973): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:57.889+0200 W/LOCATION( 5973): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:57.889+0200 I/LOCATION( 5973): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:05:57.949+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:05:57.949+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:57.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:57.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:05:57.959+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:05:57.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:05:57.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:05:57.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:05:57.959+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:05:57.959+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:05:57.959+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:05:57.959+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:05:57.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:05:58.009+0200 W/LOCATION( 5973): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:05:58.009+0200 W/LOCATION( 5973): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:05:58.089+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a133a8]
04-23 20:05:58.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:05:58.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:05:58.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:05:58.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:05:58.139+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:58.139+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:58.159+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.159+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.159+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:05:58.159+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:05:58.159+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:58.159+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:58.159+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:58.159+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:58.159+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:58.159+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:58.159+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:58.169+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.179+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.179+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:58.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.199+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:05:58.199+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(833463), time2(830365)
04-23 20:05:58.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:05:58.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:05:58.199+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:05:58.199+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:05:58.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.259+0200 W/LOCATION( 5973): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:05:58.259+0200 I/LOCATION( 5973): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:05:58.259+0200 I/LOCATION( 5973): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:05:58.259+0200 I/location( 5973): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:05:58.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:05:58.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:58.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:05:58.369+0200 I/LOCATION( 5973): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:05:58.429+0200 E/location( 5973): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:05:58.429+0200 W/AUL     ( 5973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:05:58.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:58.439+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5973
04-23 20:05:58.439+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:05:58.449+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.449+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:58.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:05:58.449+0200 W/AUL     ( 5973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:05:58.449+0200 I/location( 5973): request sent to service es.ugr.frailty.servicemanager
04-23 20:05:58.449+0200 I/location( 5973): stopping es.ugr.frailty.location service
04-23 20:05:58.449+0200 E/CAPI_APPFW_APP_CONTROL( 5973): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:05:58.449+0200 E/location( 5973): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:05:58.449+0200 I/CAPI_APPFW_APPLICATION( 5973): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:05:58.449+0200 I/utils   ( 5532): specific action
04-23 20:05:58.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:05:58.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:05:58.459+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.459+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.459+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.459+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:05:58.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:05:58.459+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:05:58.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:05:58.469+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:05:58.479+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:05:58.479+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:05:58.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:05:58.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.479+0200 I/utils   ( 5538): specific action
04-23 20:05:58.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:05:58.479+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:05:58.479+0200 I/recorder( 5538): guardando datos en local
04-23 20:05:58.479+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:05:58.529+0200 W/LOCATION( 5973): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:05:58.529+0200 I/LOCATION( 5973): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:05:58.529+0200 I/LOCATION( 5973): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:05:58.649+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:05:58.649+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:05:58.649+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:05:58.649+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:05:58.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:05:58.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:05:58.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:05:58.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a133a8
04-23 20:05:58.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a0e700]
04-23 20:05:58.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:05:58.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:05:58.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:05:58.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:05:58.889+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:58.889+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:58.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.909+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.909+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:05:58.909+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:05:58.909+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:58.909+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:58.909+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:58.909+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:58.909+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:58.909+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:58.909+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:58.919+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.919+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:58.919+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:58.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:58.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:59.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:05:59.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:05:59.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:05:59.039+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a0e700
04-23 20:05:59.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f275f8]
04-23 20:05:59.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:05:59.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:05:59.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:05:59.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:05:59.169+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:59.169+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:59.179+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:59.189+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:59.189+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:05:59.189+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:05:59.189+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:05:59.189+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:05:59.189+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:05:59.189+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:05:59.189+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:05:59.189+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:05:59.189+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:05:59.199+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:59.209+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:05:59.209+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:05:59.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:59.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:05:59.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:05:59.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:05:59.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:05:59.259+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f275f8
04-23 20:05:59.449+0200 W/AUL     ( 5990): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:05:59.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:05:59.449+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:05:59.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5926
04-23 20:05:59.449+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:05:59.449+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5926
04-23 20:05:59.449+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5926)
04-23 20:06:00.449+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:06:07.449+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:06:07.449+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:07.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:07.449+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:07.459+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6026
04-23 20:06:07.459+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:07.499+0200 E/CAPI_APPFW_APPLICATION( 6026): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:07.499+0200 E/CAPI_APPFW_APPLICATION( 6026): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:07.509+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6026
04-23 20:06:07.509+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6026) type(svcapp) bg(0)
04-23 20:06:07.509+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6026) was created
04-23 20:06:07.509+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6026]
04-23 20:06:07.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:07.529+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6026
04-23 20:06:07.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:07.539+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6026)
04-23 20:06:07.539+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:06:07.539+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:07.539+0200 W/LOCATION( 6026): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:07.539+0200 E/LOCATION( 6026): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:07.539+0200 E/PKGMGR_INFO( 6026): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:07.539+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:07.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:07.559+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6026
04-23 20:06:07.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:07.569+0200 I/LOCATION( 6026): location.c: location_new(269) > method: 0
04-23 20:06:07.569+0200 W/LOCATION( 6026): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:07.569+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:07.569+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:07.579+0200 W/LOCATION( 6026): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:07.579+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:07.579+0200 W/LOCATION( 6026): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:07.579+0200 W/LOCATION( 6026): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:07.579+0200 W/LOCATION( 6026): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:07.579+0200 W/LOCATION( 6026): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:07.599+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:07.609+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:07.609+0200 W/LOCATION( 6026): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:07.609+0200 W/LOCATION( 6026): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:07.619+0200 W/LOCATION( 6026): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:07.619+0200 W/LOCATION( 6026): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:07.619+0200 W/LOCATION( 6026): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:07.639+0200 W/LOCATION( 6026): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:07.639+0200 I/LOCATION( 6026): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf757fc18
04-23 20:06:07.639+0200 I/LOCATION( 6026): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:07.639+0200 I/LOCATION( 6026): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf757fc18
04-23 20:06:07.639+0200 I/LOCATION( 6026): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:07.639+0200 I/location( 6026): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:07.679+0200 I/LOCATION( 6026): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:07.719+0200 W/LOCATION( 6026): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:07.719+0200 W/LOCATION( 6026): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:07.719+0200 I/LOCATION( 6026): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:07.789+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:07.789+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:07.789+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:07.789+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:07.789+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:07.789+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:07.789+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:07.789+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:07.789+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:07.789+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:07.789+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:07.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:07.849+0200 W/LOCATION( 6026): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:07.849+0200 W/LOCATION( 6026): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:07.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:07.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f2fca0]
04-23 20:06:07.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:07.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:07.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:07.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:07.959+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:07.959+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:07.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:07.979+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:07.979+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:07.979+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:07.979+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:07.979+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:07.979+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:07.979+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:07.979+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:07.979+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:07.979+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:07.989+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:07.999+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:07.999+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:07.999+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:08.039+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:08.059+0200 W/LOCATION( 6026): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:08.059+0200 I/LOCATION( 6026): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:08.059+0200 I/LOCATION( 6026): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:08.059+0200 I/location( 6026): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:08.159+0200 I/LOCATION( 6026): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:08.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:08.169+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(843433), time2(830365)
04-23 20:06:08.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:06:08.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:08.169+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:08.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:08.209+0200 E/location( 6026): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:08.209+0200 W/AUL     ( 6026): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:08.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:08.219+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6026
04-23 20:06:08.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:08.229+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:08.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:08.229+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.229+0200 I/utils   ( 5532): specific action
04-23 20:06:08.229+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.229+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.229+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.229+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:08.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:08.229+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:08.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:08.239+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:08.239+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:08.239+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:08.239+0200 W/AUL     ( 6026): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:08.239+0200 I/location( 6026): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 6026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 I/utils   ( 6026): specific action
04-23 20:06:08.239+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:08.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 I/utils   ( 5538): specific action
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:08.239+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:08.239+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:08.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:08.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:08.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:08.989+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:06:09.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:09.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:09.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:09.739+0200 W/LOCATION( 6026): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:06:09.919+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11060266c6f63152450676
