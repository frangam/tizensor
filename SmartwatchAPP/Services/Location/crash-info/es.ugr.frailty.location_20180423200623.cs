S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6100
Date: 2018-04-23 20:06:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70ac52d, r5   = 0xf72b2f98
r6   = 0xff938f50, r7   = 0xff938e00
r8   = 0xf72afc18, r9   = 0x00000000
r10  = 0xff938edc, fp   = 0xff938f50
ip   = 0x00000001, sp   = 0xff938dd8
lr   = 0xf70ac539, pc   = 0xf7115228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    112588 KB
Buffers:     37144 KB
Cached:     182680 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11908 KB
VmRSS:       11904 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6100 TID = 6100
6100 6103 

Maps Information
f3f77000 f4776000 rw-p [stack:6103]
f477d000 f477f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4787000 f478b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4794000 f4796000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f479e000 f47a1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47b0000 f47b5000 r-xp /usr/lib/libsystem.so.0.0.0
f47c0000 f47c3000 r-xp /lib/libattr.so.1.1.0
f47cb000 f47db000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47e3000 f47ec000 r-xp /usr/lib/libedbus.so.1.7.99
f47f4000 f47f5000 r-xp /usr/lib/libresponse.so.0.2.96
f47fe000 f4803000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60a5000 f61ab000 r-xp /usr/lib/libicuuc.so.57.1
f61c1000 f6349000 r-xp /usr/lib/libicui18n.so.57.1
f6359000 f6366000 r-xp /usr/lib/libail.so.0.1.0
f636f000 f6376000 r-xp /usr/lib/libminizip.so.1.0.0
f637f000 f6528000 r-xp /usr/lib/libcrypto.so.1.0.0
f6548000 f658f000 r-xp /usr/lib/libssl.so.1.0.0
f659b000 f659d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65a5000 f65ac000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65b5000 f65bc000 r-xp /lib/libcrypt-2.13.so
f65ed000 f65f0000 r-xp /lib/libcap.so.2.21
f65f8000 f65fa000 r-xp /usr/lib/libiri.so
f6602000 f664b000 r-xp /usr/lib/libmdm.so.1.2.69
f6653000 f6659000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6661000 f6684000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f668e000 f6690000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6698000 f66b5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66be000 f66c2000 r-xp /usr/lib/libsmack.so.1.0.0
f66cb000 f66e4000 r-xp /usr/lib/libnetwork.so.0.0.0
f66ed000 f66f5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66fd000 f6703000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f670c000 f670e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6717000 f6727000 r-xp /lib/libresolv-2.13.so
f672b000 f6743000 r-xp /usr/lib/liblzma.so.5.0.3
f674c000 f674e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6756000 f6770000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6778000 f67a7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67b0000 f67bf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c9000 f67d3000 r-xp /usr/lib/libsensord-shared.so
f67dc000 f68af000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ba000 f68d0000 r-xp /lib/libz.so.1.2.5
f68d8000 f68dd000 r-xp /usr/lib/libffi.so.5.0.10
f68e5000 f68e6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68ee000 f68fe000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6906000 f691f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6927000 f6929000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6931000 f69a6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69b0000 f69b6000 r-xp /lib/librt-2.13.so
f69bf000 f69dd000 r-xp /usr/lib/libsystemd.so.0.4.0
f69e7000 f69e8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69f0000 f6a13000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a1b000 f6a20000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a28000 f6a52000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a5b000 f6a72000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a7a000 f6ae3000 r-xp /lib/libm-2.13.so
f6aec000 f6b80000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b93000 f6b98000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ba0000 f6ba7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6baf000 f6bd9000 r-xp /usr/lib/libsensor.so.1.9.6
f6be2000 f6cae000 r-xp /usr/lib/libxml2.so.2.7.8
f6cbb000 f6cbd000 r-xp /usr/lib/libiniparser.so.0
f6cc6000 f6ccc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cd5000 f6da5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6da6000 f6dda000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6de3000 f6e1f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e27000 f6e2a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e32000 f6e38000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e40000 f6e81000 r-xp /usr/lib/libeina.so.1.7.99
f6e8a000 f6ea1000 r-xp /usr/lib/libecore.so.1.7.99
f6eb8000 f6ec1000 r-xp /usr/lib/libvconf.so.0.2.45
f6ec9000 f6edd000 r-xp /lib/libpthread-2.13.so
f6ee8000 f6ef5000 r-xp /usr/lib/libaul.so.0.1.0
f6eff000 f6f01000 r-xp /lib/libdl-2.13.so
f6f0a000 f6f15000 r-xp /lib/libunwind.so.8.0.1
f6f42000 f6f4a000 r-xp /lib/libgcc_s-4.6.so.1
f6f4b000 f706f000 r-xp /lib/libc-2.13.so
f707d000 f707f000 r-xp /usr/lib/libdlog.so.0.0.0
f7087000 f7093000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f709c000 f70a1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a9000 f70b8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70c0000 f70c4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70cd000 f70d0000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d8000 f70da000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70e2000 f70e6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70ee000 f710b000 r-xp /lib/ld-2.13.so
f7114000 f7117000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7117000 f711b000 r-xp /usr/lib/libsys-assert.so
f727f000 f72f0000 rw-p [heap]
ff91a000 ff93b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6100)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7115228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70ac539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6db33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6db1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dbde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dc3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dc3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6df31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6db1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dbde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dc3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dc3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6df5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6df6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dfdf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47951fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4788171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf685b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d08fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d0a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e9aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e95b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e965a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e96879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70ce183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70ce7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71154f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f6285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7114f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 20:06:10.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:10.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:10.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:10.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:10.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:10.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:10.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.109+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:10.109+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:10.159+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:10.159+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:10.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:10.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:10.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:10.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f00848
04-23 20:06:10.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f27568]
04-23 20:06:10.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:10.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:10.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:10.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:10.289+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:10.289+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:10.299+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.299+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.299+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:10.299+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:10.299+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:10.299+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:10.299+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:10.309+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:10.309+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:10.309+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:10.309+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:10.309+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:10.319+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:10.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:10.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:10.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:10.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:10.379+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:10.379+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f27568
04-23 20:06:10.549+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:06:10.549+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:10.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:10.549+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:10.559+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6052
04-23 20:06:10.559+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:10.609+0200 E/CAPI_APPFW_APPLICATION( 6052): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:10.609+0200 E/CAPI_APPFW_APPLICATION( 6052): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:10.609+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6052
04-23 20:06:10.609+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6052) type(svcapp) bg(0)
04-23 20:06:10.609+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6052]
04-23 20:06:10.619+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6052)
04-23 20:06:10.619+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:06:10.619+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:10.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:10.639+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6052
04-23 20:06:10.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:10.649+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6052) was created
04-23 20:06:10.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:10.659+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6052
04-23 20:06:10.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:10.679+0200 W/LOCATION( 6052): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:10.679+0200 E/LOCATION( 6052): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:10.679+0200 E/PKGMGR_INFO( 6052): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:10.689+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:10.709+0200 I/LOCATION( 6052): location.c: location_new(269) > method: 0
04-23 20:06:10.709+0200 W/LOCATION( 6052): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:10.709+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:10.719+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:10.719+0200 W/LOCATION( 6052): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:10.719+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:10.729+0200 W/LOCATION( 6052): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:10.729+0200 W/LOCATION( 6052): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:10.729+0200 W/LOCATION( 6052): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:10.729+0200 W/LOCATION( 6052): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:10.749+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:10.759+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:10.759+0200 W/LOCATION( 6052): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:10.759+0200 W/LOCATION( 6052): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:10.769+0200 W/LOCATION( 6052): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:10.769+0200 W/LOCATION( 6052): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:10.769+0200 W/LOCATION( 6052): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:10.789+0200 W/LOCATION( 6052): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:10.789+0200 I/LOCATION( 6052): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d5fc18
04-23 20:06:10.789+0200 I/LOCATION( 6052): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:10.789+0200 I/LOCATION( 6052): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d5fc18
04-23 20:06:10.789+0200 I/LOCATION( 6052): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:10.789+0200 I/location( 6052): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:10.839+0200 I/LOCATION( 6052): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:10.879+0200 W/LOCATION( 6052): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:10.879+0200 W/LOCATION( 6052): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:10.879+0200 I/LOCATION( 6052): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:10.939+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:10.939+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:10.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:10.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:10.949+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:10.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:10.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:10.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:10.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:10.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:10.949+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:10.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:10.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:10.999+0200 W/LOCATION( 6052): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:10.999+0200 W/LOCATION( 6052): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:11.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:11.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1eed8]
04-23 20:06:11.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:11.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:11.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:11.129+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:11.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:11.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:11.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.149+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.149+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:11.149+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:11.149+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:11.149+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:11.149+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:11.149+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:11.149+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:11.149+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:11.149+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:11.159+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.169+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.169+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:11.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:11.199+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:11.199+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(846462), time2(843433)
04-23 20:06:11.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:06:11.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:11.199+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:11.199+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:11.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:11.259+0200 W/LOCATION( 6052): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:11.259+0200 I/LOCATION( 6052): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:11.259+0200 I/LOCATION( 6052): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:11.259+0200 I/location( 6052): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:11.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:11.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:11.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:11.399+0200 I/LOCATION( 6052): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:11.459+0200 E/location( 6052): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:11.459+0200 W/AUL     ( 6052): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:11.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:11.469+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6052
04-23 20:06:11.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:11.479+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:11.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:11.479+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.479+0200 I/utils   ( 5532): specific action
04-23 20:06:11.479+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.479+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.479+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.479+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:11.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:11.479+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:11.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:11.489+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:11.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:06:11.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.489+0200 I/utils   ( 5538): specific action
04-23 20:06:11.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.489+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:11.489+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:11.489+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:11.489+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:11.489+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:11.489+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:11.499+0200 W/AUL     ( 6052): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:11.499+0200 I/location( 6052): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:11.499+0200 I/location( 6052): stopping es.ugr.frailty.location service
04-23 20:06:11.499+0200 E/CAPI_APPFW_APP_CONTROL( 6052): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:06:11.499+0200 E/location( 6052): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:06:11.499+0200 I/CAPI_APPFW_APPLICATION( 6052): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:06:11.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:06:11.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:06:11.589+0200 W/LOCATION( 6052): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:11.589+0200 I/LOCATION( 6052): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:11.589+0200 I/LOCATION( 6052): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:06:11.689+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:06:11.689+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:06:11.689+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:06:11.689+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:06:11.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:11.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:11.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:11.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:11.869+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1eed8
04-23 20:06:11.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f256b0]
04-23 20:06:11.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:11.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:11.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:11.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:11.949+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:11.949+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:11.959+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.969+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:11.969+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:11.969+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:11.969+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:11.969+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:11.969+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:11.969+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:11.969+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:11.969+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:11.979+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.989+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:11.989+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:11.989+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:12.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:12.109+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:12.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:12.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:12.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:12.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f256b0
04-23 20:06:12.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a13110]
04-23 20:06:12.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:12.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:12.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:12.239+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:12.249+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:12.249+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:12.249+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:12.259+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:12.259+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:12.259+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:12.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:12.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:12.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:12.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:12.259+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:12.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:12.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:12.269+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:12.279+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:12.279+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:12.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:12.329+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:12.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:12.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:12.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:12.329+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a13110
04-23 20:06:12.549+0200 W/AUL     ( 6064): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:06:12.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:06:12.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:06:12.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6026
04-23 20:06:12.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:06:12.549+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6026
04-23 20:06:12.549+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6026)
04-23 20:06:13.499+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:06:20.629+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:06:20.629+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:20.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:20.629+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:20.639+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:20.639+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6100
04-23 20:06:20.689+0200 E/CAPI_APPFW_APPLICATION( 6100): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:20.689+0200 E/CAPI_APPFW_APPLICATION( 6100): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:20.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6100
04-23 20:06:20.689+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6100) type(svcapp) bg(0)
04-23 20:06:20.689+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6100) was created
04-23 20:06:20.699+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6100]
04-23 20:06:20.709+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6100)
04-23 20:06:20.709+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:06:20.709+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:20.719+0200 W/LOCATION( 6100): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:20.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:20.729+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6100
04-23 20:06:20.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:20.739+0200 E/LOCATION( 6100): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:20.739+0200 E/PKGMGR_INFO( 6100): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:20.739+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:20.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:20.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6100
04-23 20:06:20.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:20.779+0200 I/LOCATION( 6100): location.c: location_new(269) > method: 0
04-23 20:06:20.779+0200 W/LOCATION( 6100): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:20.779+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:20.789+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:20.789+0200 W/LOCATION( 6100): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:20.799+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:20.799+0200 W/LOCATION( 6100): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:20.799+0200 W/LOCATION( 6100): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:20.799+0200 W/LOCATION( 6100): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:20.799+0200 W/LOCATION( 6100): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:20.829+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:20.829+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:20.829+0200 W/LOCATION( 6100): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:20.839+0200 W/LOCATION( 6100): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:20.839+0200 W/LOCATION( 6100): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:20.839+0200 W/LOCATION( 6100): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:20.839+0200 W/LOCATION( 6100): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:20.859+0200 W/LOCATION( 6100): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:20.859+0200 I/LOCATION( 6100): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72afc18
04-23 20:06:20.859+0200 I/LOCATION( 6100): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:20.859+0200 I/LOCATION( 6100): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72afc18
04-23 20:06:20.859+0200 I/LOCATION( 6100): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:20.859+0200 I/location( 6100): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:20.909+0200 I/LOCATION( 6100): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:20.949+0200 W/LOCATION( 6100): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:20.949+0200 W/LOCATION( 6100): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:20.949+0200 I/LOCATION( 6100): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:21.009+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:21.009+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:21.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:21.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:21.009+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:21.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:21.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:21.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:21.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:21.019+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:21.019+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:21.019+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:21.019+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:21.069+0200 W/LOCATION( 6100): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:21.069+0200 W/LOCATION( 6100): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:21.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:21.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f25628]
04-23 20:06:21.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:21.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:21.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:21.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:21.189+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:21.189+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:21.199+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:21.209+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:21.209+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:21.209+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:21.209+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:21.209+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:21.209+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:21.209+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:21.209+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:21.209+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:21.209+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:21.219+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:21.229+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:21.229+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:21.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:21.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:21.249+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(856516), time2(843433)
04-23 20:06:21.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:06:21.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:21.249+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:21.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:21.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:21.299+0200 W/LOCATION( 6100): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:21.299+0200 I/LOCATION( 6100): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:21.299+0200 I/LOCATION( 6100): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:21.299+0200 I/location( 6100): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:21.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:21.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:21.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:21.409+0200 I/LOCATION( 6100): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:21.459+0200 E/location( 6100): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:21.459+0200 W/AUL     ( 6100): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:21.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:21.459+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6100
04-23 20:06:21.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:21.469+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:21.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:21.469+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.469+0200 I/utils   ( 5532): specific action
04-23 20:06:21.469+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.469+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.469+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.469+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:21.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:21.469+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:21.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:21.479+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:21.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 I/utils   ( 5538): specific action
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:21.479+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:21.479+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:21.479+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:21.479+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:21.479+0200 W/AUL     ( 6100): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:21.479+0200 I/location( 6100): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:21.479+0200 W/CAPI_APPFW_APP_CONTROL( 6100): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:21.479+0200 I/utils   ( 6100): specific action
04-23 20:06:22.269+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:06:22.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:22.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:22.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:22.989+0200 W/LOCATION( 6100): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:06:23.129+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11061006c6f63152450678
