S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8710
Date: 2018-04-23 20:28:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf751a52d, r5   = 0xf7705f98
r6   = 0xffbedcf0, r7   = 0xffbedba0
r8   = 0xf7702c18, r9   = 0x00000000
r10  = 0xffbedc7c, fp   = 0xffbedcf0
ip   = 0x00000001, sp   = 0xffbedb78
lr   = 0xf751a539, pc   = 0xf7583228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    149432 KB
Buffers:     33248 KB
Cached:     152076 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12072 KB
VmRSS:       12068 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8710 TID = 8710
8710 8713 

Maps Information
f43e5000 f4be4000 rw-p [stack:8713]
f4beb000 f4bed000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bf5000 f4bf9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c02000 f4c04000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c0c000 f4c0f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c1e000 f4c23000 r-xp /usr/lib/libsystem.so.0.0.0
f4c2e000 f4c31000 r-xp /lib/libattr.so.1.1.0
f4c39000 f4c49000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c51000 f4c5a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c62000 f4c63000 r-xp /usr/lib/libresponse.so.0.2.96
f4c6c000 f4c71000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6513000 f6619000 r-xp /usr/lib/libicuuc.so.57.1
f662f000 f67b7000 r-xp /usr/lib/libicui18n.so.57.1
f67c7000 f67d4000 r-xp /usr/lib/libail.so.0.1.0
f67dd000 f67e4000 r-xp /usr/lib/libminizip.so.1.0.0
f67ed000 f6996000 r-xp /usr/lib/libcrypto.so.1.0.0
f69b6000 f69fd000 r-xp /usr/lib/libssl.so.1.0.0
f6a09000 f6a0b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a13000 f6a1a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a23000 f6a2a000 r-xp /lib/libcrypt-2.13.so
f6a5b000 f6a5e000 r-xp /lib/libcap.so.2.21
f6a66000 f6a68000 r-xp /usr/lib/libiri.so
f6a70000 f6ab9000 r-xp /usr/lib/libmdm.so.1.2.69
f6ac1000 f6ac7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6acf000 f6af2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6afc000 f6afe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b06000 f6b23000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b2c000 f6b30000 r-xp /usr/lib/libsmack.so.1.0.0
f6b39000 f6b52000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b5b000 f6b63000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b6b000 f6b71000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b7a000 f6b7c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b85000 f6b95000 r-xp /lib/libresolv-2.13.so
f6b99000 f6bb1000 r-xp /usr/lib/liblzma.so.5.0.3
f6bba000 f6bbc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bc4000 f6bde000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6be6000 f6c15000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c1e000 f6c2d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c37000 f6c41000 r-xp /usr/lib/libsensord-shared.so
f6c4a000 f6d1d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d28000 f6d3e000 r-xp /lib/libz.so.1.2.5
f6d46000 f6d4b000 r-xp /usr/lib/libffi.so.5.0.10
f6d53000 f6d54000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d5c000 f6d6c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d74000 f6d8d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d95000 f6d97000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d9f000 f6e14000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e1e000 f6e24000 r-xp /lib/librt-2.13.so
f6e2d000 f6e4b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e55000 f6e56000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e5e000 f6e81000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e89000 f6e8e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e96000 f6ec0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ec9000 f6ee0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ee8000 f6f51000 r-xp /lib/libm-2.13.so
f6f5a000 f6fee000 r-xp /usr/lib/libstdc++.so.6.0.16
f7001000 f7006000 r-xp /usr/lib/libctx-client.so.0.8.3
f700e000 f7015000 r-xp /usr/lib/libctx-shared.so.0.8.3
f701d000 f7047000 r-xp /usr/lib/libsensor.so.1.9.6
f7050000 f711c000 r-xp /usr/lib/libxml2.so.2.7.8
f7129000 f712b000 r-xp /usr/lib/libiniparser.so.0
f7134000 f713a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7143000 f7213000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7214000 f7248000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7251000 f728d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7295000 f7298000 r-xp /usr/lib/libbundle.so.0.1.22
f72a0000 f72a6000 r-xp /usr/lib/libappsvc.so.0.1.0
f72ae000 f72ef000 r-xp /usr/lib/libeina.so.1.7.99
f72f8000 f730f000 r-xp /usr/lib/libecore.so.1.7.99
f7326000 f732f000 r-xp /usr/lib/libvconf.so.0.2.45
f7337000 f734b000 r-xp /lib/libpthread-2.13.so
f7356000 f7363000 r-xp /usr/lib/libaul.so.0.1.0
f736d000 f736f000 r-xp /lib/libdl-2.13.so
f7378000 f7383000 r-xp /lib/libunwind.so.8.0.1
f73b0000 f73b8000 r-xp /lib/libgcc_s-4.6.so.1
f73b9000 f74dd000 r-xp /lib/libc-2.13.so
f74eb000 f74ed000 r-xp /usr/lib/libdlog.so.0.0.0
f74f5000 f7501000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f750a000 f750f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7517000 f7526000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f752e000 f7532000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f753b000 f753e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7546000 f7548000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7550000 f7554000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f755c000 f7579000 r-xp /lib/ld-2.13.so
f7582000 f7585000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7585000 f7589000 r-xp /usr/lib/libsys-assert.so
f76d2000 f7760000 rw-p [heap]
ffbcf000 ffbf0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8710)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7583228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf751a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72213f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf721fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf722be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7231be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7231dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf726675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72611f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf721fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf722be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7231be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7231dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7263e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7264017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf726bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c031fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bf6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cc9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7176fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71787a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7308ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7303b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73045a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7304879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf753c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf753c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75834f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf73d085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7582f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
39+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:17.439+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:17.439+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:17.439+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:17.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.449+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:17.459+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:17.509+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:17.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:17.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:17.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:17.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:17.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76bc640
04-23 20:28:17.639+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76cc430]
04-23 20:28:17.639+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:17.639+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:17.639+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:17.639+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:17.639+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:17.639+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:17.659+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.669+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.669+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:17.669+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:17.669+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:17.669+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:17.669+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:17.669+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:17.669+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:17.669+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:17.669+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:17.679+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.689+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:17.689+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:17.689+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:17.729+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:28:17.729+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:17.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:17.729+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:17.739+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:28:17.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:17.749+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:17.749+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:17.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:17.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76cc430
04-23 20:28:17.779+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8660
04-23 20:28:17.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8660
04-23 20:28:17.829+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8660) type(svcapp) bg(0)
04-23 20:28:17.829+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8660]
04-23 20:28:17.829+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8660)
04-23 20:28:17.829+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:28:17.829+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:17.849+0200 E/CAPI_APPFW_APPLICATION( 8660): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:17.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:17.859+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8660
04-23 20:28:17.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:17.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8660
04-23 20:28:17.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:17.869+0200 E/CAPI_APPFW_APPLICATION( 8660): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:17.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:17.879+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8660) was created
04-23 20:28:17.909+0200 W/LOCATION( 8660): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:28:17.909+0200 E/LOCATION( 8660): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:28:17.909+0200 E/PKGMGR_INFO( 8660): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:28:17.919+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:17.929+0200 I/LOCATION( 8660): location.c: location_new(269) > method: 0
04-23 20:28:17.939+0200 W/LOCATION( 8660): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:17.949+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:17.949+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:17.959+0200 W/LOCATION( 8660): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:17.959+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:17.969+0200 W/LOCATION( 8660): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:17.969+0200 W/LOCATION( 8660): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:17.969+0200 W/LOCATION( 8660): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:17.969+0200 W/LOCATION( 8660): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:17.999+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:17.999+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:18.009+0200 W/LOCATION( 8660): module-internal.c: module_new(311) > module (wps) open success
04-23 20:28:18.009+0200 W/LOCATION( 8660): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:28:18.009+0200 W/LOCATION( 8660): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:28:18.009+0200 W/LOCATION( 8660): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:18.009+0200 W/LOCATION( 8660): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:18.039+0200 W/LOCATION( 8660): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:28:18.039+0200 I/LOCATION( 8660): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf79f4c18
04-23 20:28:18.039+0200 I/LOCATION( 8660): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:28:18.039+0200 I/LOCATION( 8660): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf79f4c18
04-23 20:28:18.039+0200 I/LOCATION( 8660): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:28:18.039+0200 I/location( 8660): es.ugr.frailty.location: creado servicio de localización
04-23 20:28:18.099+0200 I/LOCATION( 8660): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:28:18.149+0200 W/LOCATION( 8660): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:18.149+0200 W/LOCATION( 8660): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:18.149+0200 I/LOCATION( 8660): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:28:18.229+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:28:18.229+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:18.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:18.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:28:18.229+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:28:18.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:28:18.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:28:18.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:28:18.239+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:28:18.239+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:28:18.239+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:28:18.239+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:28:18.239+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:28:18.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:18.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:18.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:18.339+0200 W/LOCATION( 8660): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:18.339+0200 W/LOCATION( 8660): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:18.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:18.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76cc430]
04-23 20:28:18.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:18.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:18.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:18.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:18.469+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:18.469+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:18.479+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:18.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:18.479+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2173749), time2(2170544)
04-23 20:28:18.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:28:18.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:18.479+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:18.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:18.489+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:18.489+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:18.489+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:18.489+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:18.489+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:18.489+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:18.489+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:18.489+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:18.489+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:18.489+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:18.489+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:18.499+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:18.499+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:18.509+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:18.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:18.589+0200 W/LOCATION( 8660): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:18.589+0200 I/LOCATION( 8660): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:18.589+0200 I/LOCATION( 8660): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:18.589+0200 I/location( 8660): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:18.679+0200 I/LOCATION( 8660): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:18.729+0200 E/location( 8660): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:18.729+0200 W/AUL     ( 8660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:18.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:18.729+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8660
04-23 20:28:18.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:18.739+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:18.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:18.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.739+0200 I/utils   ( 8242): specific action
04-23 20:28:18.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.739+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:18.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:18.739+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:18.749+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:18.749+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:18.749+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:18.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.749+0200 I/utils   ( 8247): specific action
04-23 20:28:18.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:18.749+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:18.749+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:18.749+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:18.749+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:18.749+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:18.759+0200 W/AUL     ( 8660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:18.759+0200 I/location( 8660): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:18.759+0200 I/location( 8660): stopping es.ugr.frailty.location service
04-23 20:28:18.759+0200 E/CAPI_APPFW_APP_CONTROL( 8660): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:28:18.759+0200 E/location( 8660): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:28:18.759+0200 I/CAPI_APPFW_APPLICATION( 8660): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:18.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:18.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:18.799+0200 W/LOCATION( 8660): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:18.799+0200 I/LOCATION( 8660): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:18.799+0200 I/LOCATION( 8660): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:28:18.879+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:28:18.879+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:28:18.889+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:28:18.889+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:28:18.999+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.039+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:19.039+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:19.039+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:19.039+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76cc430
04-23 20:28:19.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40094a8]
04-23 20:28:19.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:19.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:19.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:19.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:19.109+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:19.109+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:19.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.129+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.129+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:19.129+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:19.129+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:19.129+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:19.129+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:19.129+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:19.129+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:19.129+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:19.129+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:19.139+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.139+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.139+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:19.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:19.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:19.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:19.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf40094a8
04-23 20:28:19.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4007c08]
04-23 20:28:19.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:19.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:19.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:19.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:19.329+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:19.329+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:19.339+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.369+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.369+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:19.369+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:19.369+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:19.369+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:19.369+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:19.369+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:19.379+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:19.379+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:19.379+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:19.389+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:19.399+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:19.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:19.449+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:19.449+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:19.449+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:19.449+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4007c08
04-23 20:28:19.669+0200 W/AUL     ( 8673): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:28:19.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:19.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:19.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8625
04-23 20:28:19.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:19.669+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8625
04-23 20:28:19.669+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8625)
04-23 20:28:20.759+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:27.839+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:28:27.839+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:27.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:27.849+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:27.859+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8710
04-23 20:28:27.859+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:28:27.899+0200 E/CAPI_APPFW_APPLICATION( 8710): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:27.899+0200 E/CAPI_APPFW_APPLICATION( 8710): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:27.929+0200 W/LOCATION( 8710): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:28:27.929+0200 E/LOCATION( 8710): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:28:27.929+0200 E/PKGMGR_INFO( 8710): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:28:27.929+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:27.949+0200 I/LOCATION( 8710): location.c: location_new(269) > method: 0
04-23 20:28:27.949+0200 W/LOCATION( 8710): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:27.949+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:27.949+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:27.959+0200 W/LOCATION( 8710): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:27.959+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:27.959+0200 W/LOCATION( 8710): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:27.959+0200 W/LOCATION( 8710): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:27.959+0200 W/LOCATION( 8710): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:27.959+0200 W/LOCATION( 8710): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:27.979+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:27.989+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:27.989+0200 W/LOCATION( 8710): module-internal.c: module_new(311) > module (wps) open success
04-23 20:28:27.989+0200 W/LOCATION( 8710): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:28:27.989+0200 W/LOCATION( 8710): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:28:27.999+0200 W/LOCATION( 8710): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:27.999+0200 W/LOCATION( 8710): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:28.009+0200 W/LOCATION( 8710): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:28:28.009+0200 I/LOCATION( 8710): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7702c18
04-23 20:28:28.009+0200 I/LOCATION( 8710): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:28:28.009+0200 I/LOCATION( 8710): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7702c18
04-23 20:28:28.009+0200 I/LOCATION( 8710): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:28:28.009+0200 I/location( 8710): es.ugr.frailty.location: creado servicio de localización
04-23 20:28:28.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8710
04-23 20:28:28.029+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8710) type(svcapp) bg(0)
04-23 20:28:28.029+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8710) was created
04-23 20:28:28.029+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8710]
04-23 20:28:28.029+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8710)
04-23 20:28:28.029+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:28:28.029+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:28.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:28.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8710
04-23 20:28:28.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:28.059+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8710
04-23 20:28:28.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:28.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:28.099+0200 I/LOCATION( 8710): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:28:28.139+0200 W/LOCATION( 8710): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:28.139+0200 W/LOCATION( 8710): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:28.139+0200 I/LOCATION( 8710): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:28:28.209+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:28:28.209+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:28.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:28.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:28:28.209+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:28:28.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:28:28.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:28:28.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:28:28.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:28:28.219+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:28:28.219+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:28:28.219+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:28:28.219+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:28:28.269+0200 W/LOCATION( 8710): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:28.269+0200 W/LOCATION( 8710): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:28.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:28.309+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:28.309+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:28.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:28.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40098f8]
04-23 20:28:28.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:28.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:28.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:28.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:28.439+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:28.439+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:28.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:28.439+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2183707), time2(2170544)
04-23 20:28:28.439+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:28:28.439+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:28.439+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:28.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:28.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:28.459+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:28.459+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:28.459+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:28.459+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:28.459+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:28.459+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:28.459+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:28.459+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:28.459+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:28.459+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:28.469+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:28.479+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:28.479+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:28.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:28.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:28.569+0200 W/LOCATION( 8710): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:28.569+0200 I/LOCATION( 8710): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:28.569+0200 I/LOCATION( 8710): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:28.569+0200 I/location( 8710): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:28.659+0200 I/LOCATION( 8710): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:28.699+0200 E/location( 8710): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:28.699+0200 W/AUL     ( 8710): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:28.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:28.709+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8710
04-23 20:28:28.709+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:28.719+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:28.719+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:28.719+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.719+0200 I/utils   ( 8242): specific action
04-23 20:28:28.719+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.719+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.719+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.719+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:28.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:28.719+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:28.729+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:28.729+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:28.729+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 I/utils   ( 8247): specific action
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:28.729+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:28.729+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:28.729+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:28.729+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:28.729+0200 W/AUL     ( 8710): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:28.729+0200 I/location( 8710): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:28.729+0200 W/CAPI_APPFW_APP_CONTROL( 8710): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:28.729+0200 I/utils   ( 8710): specific action
04-23 20:28:29.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:29.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:29.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:29.479+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:28:30.179+0200 W/LOCATION( 8710): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:28:30.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:30.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:30.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:30.379+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11087106c6f63152450811
