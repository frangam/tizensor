S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6695
Date: 2018-04-23 20:08:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73ba52d, r5   = 0xf777af98
r6   = 0xfff404d0, r7   = 0xfff40380
r8   = 0xf7777c18, r9   = 0x00000000
r10  = 0xfff4045c, fp   = 0xfff404d0
ip   = 0x00000001, sp   = 0xfff40358
lr   = 0xf73ba539, pc   = 0xf7423228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111444 KB
Buffers:     38776 KB
Cached:     184716 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12012 KB
VmRSS:       12012 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6695 TID = 6695
6695 6698 

Maps Information
f4285000 f4a84000 rw-p [stack:6698]
f4a8b000 f4a8d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a95000 f4a99000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4aa2000 f4aa4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4aac000 f4aaf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4abe000 f4ac3000 r-xp /usr/lib/libsystem.so.0.0.0
f4ace000 f4ad1000 r-xp /lib/libattr.so.1.1.0
f4ad9000 f4ae9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4af1000 f4afa000 r-xp /usr/lib/libedbus.so.1.7.99
f4b02000 f4b03000 r-xp /usr/lib/libresponse.so.0.2.96
f4b0c000 f4b11000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63b3000 f64b9000 r-xp /usr/lib/libicuuc.so.57.1
f64cf000 f6657000 r-xp /usr/lib/libicui18n.so.57.1
f6667000 f6674000 r-xp /usr/lib/libail.so.0.1.0
f667d000 f6684000 r-xp /usr/lib/libminizip.so.1.0.0
f668d000 f6836000 r-xp /usr/lib/libcrypto.so.1.0.0
f6856000 f689d000 r-xp /usr/lib/libssl.so.1.0.0
f68a9000 f68ab000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68b3000 f68ba000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68c3000 f68ca000 r-xp /lib/libcrypt-2.13.so
f68fb000 f68fe000 r-xp /lib/libcap.so.2.21
f6906000 f6908000 r-xp /usr/lib/libiri.so
f6910000 f6959000 r-xp /usr/lib/libmdm.so.1.2.69
f6961000 f6967000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f696f000 f6992000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f699c000 f699e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69a6000 f69c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69cc000 f69d0000 r-xp /usr/lib/libsmack.so.1.0.0
f69d9000 f69f2000 r-xp /usr/lib/libnetwork.so.0.0.0
f69fb000 f6a03000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a0b000 f6a11000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a1a000 f6a1c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a25000 f6a35000 r-xp /lib/libresolv-2.13.so
f6a39000 f6a51000 r-xp /usr/lib/liblzma.so.5.0.3
f6a5a000 f6a5c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a64000 f6a7e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a86000 f6ab5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6abe000 f6acd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ad7000 f6ae1000 r-xp /usr/lib/libsensord-shared.so
f6aea000 f6bbd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bc8000 f6bde000 r-xp /lib/libz.so.1.2.5
f6be6000 f6beb000 r-xp /usr/lib/libffi.so.5.0.10
f6bf3000 f6bf4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bfc000 f6c0c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c14000 f6c2d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c35000 f6c37000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c3f000 f6cb4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cbe000 f6cc4000 r-xp /lib/librt-2.13.so
f6ccd000 f6ceb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cf5000 f6cf6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cfe000 f6d21000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d29000 f6d2e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d36000 f6d60000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d69000 f6d80000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d88000 f6df1000 r-xp /lib/libm-2.13.so
f6dfa000 f6e8e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ea1000 f6ea6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eae000 f6eb5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ebd000 f6ee7000 r-xp /usr/lib/libsensor.so.1.9.6
f6ef0000 f6fbc000 r-xp /usr/lib/libxml2.so.2.7.8
f6fc9000 f6fcb000 r-xp /usr/lib/libiniparser.so.0
f6fd4000 f6fda000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fe3000 f70b3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70b4000 f70e8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70f1000 f712d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7135000 f7138000 r-xp /usr/lib/libbundle.so.0.1.22
f7140000 f7146000 r-xp /usr/lib/libappsvc.so.0.1.0
f714e000 f718f000 r-xp /usr/lib/libeina.so.1.7.99
f7198000 f71af000 r-xp /usr/lib/libecore.so.1.7.99
f71c6000 f71cf000 r-xp /usr/lib/libvconf.so.0.2.45
f71d7000 f71eb000 r-xp /lib/libpthread-2.13.so
f71f6000 f7203000 r-xp /usr/lib/libaul.so.0.1.0
f720d000 f720f000 r-xp /lib/libdl-2.13.so
f7218000 f7223000 r-xp /lib/libunwind.so.8.0.1
f7250000 f7258000 r-xp /lib/libgcc_s-4.6.so.1
f7259000 f737d000 r-xp /lib/libc-2.13.so
f738b000 f738d000 r-xp /usr/lib/libdlog.so.0.0.0
f7395000 f73a1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73aa000 f73af000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73b7000 f73c6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73ce000 f73d2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73db000 f73de000 r-xp /usr/lib/libappcore-agent.so.1.1
f73e6000 f73e8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73f0000 f73f4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73fc000 f7419000 r-xp /lib/ld-2.13.so
f7422000 f7425000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7425000 f7429000 r-xp /usr/lib/libsys-assert.so
f7747000 f77d5000 rw-p [heap]
fff21000 fff42000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6695)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7423228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73ba539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70c13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70bfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70cbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70d1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70d1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf710675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71011f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70bfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70cbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70d1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70d1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7103e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7104017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf710bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4aa31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a96171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b69663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7016fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70187a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71a8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71a3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71a45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71a4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73dc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73dc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74234f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf727085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7422f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
39) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.619+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:55.619+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:55.619+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:55.619+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:55.619+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:55.619+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:55.619+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:55.619+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:55.619+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:55.629+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.639+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.639+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:55.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:55.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:55.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:55.749+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:55.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f277d8
04-23 20:07:55.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a0f9e8]
04-23 20:07:55.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:55.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:55.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:55.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:55.829+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:55.829+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:55.839+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.849+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.849+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:55.849+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:55.849+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:55.849+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:55.849+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:55.849+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:55.849+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:55.849+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:55.849+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:55.859+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.869+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:55.869+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:55.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:55.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:55.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:55.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:55.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:55.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a0f9e8
04-23 20:07:56.039+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:07:56.039+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:56.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:56.039+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:56.049+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6648
04-23 20:07:56.049+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:56.099+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6648
04-23 20:07:56.099+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6648) type(svcapp) bg(0)
04-23 20:07:56.109+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6648]
04-23 20:07:56.109+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6648)
04-23 20:07:56.109+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:07:56.109+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6648
04-23 20:07:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:56.139+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6648
04-23 20:07:56.139+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:56.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:56.159+0200 E/CAPI_APPFW_APPLICATION( 6648): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:56.159+0200 E/CAPI_APPFW_APPLICATION( 6648): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:56.159+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6648) was created
04-23 20:07:56.189+0200 W/LOCATION( 6648): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:56.189+0200 E/LOCATION( 6648): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:56.189+0200 E/PKGMGR_INFO( 6648): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:56.189+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:56.209+0200 I/LOCATION( 6648): location.c: location_new(269) > method: 0
04-23 20:07:56.209+0200 W/LOCATION( 6648): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:56.209+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:56.219+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:56.219+0200 W/LOCATION( 6648): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:56.229+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:56.229+0200 W/LOCATION( 6648): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:56.229+0200 W/LOCATION( 6648): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:56.229+0200 W/LOCATION( 6648): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:56.229+0200 W/LOCATION( 6648): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:56.249+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:56.259+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:56.259+0200 W/LOCATION( 6648): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:56.269+0200 W/LOCATION( 6648): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:56.269+0200 W/LOCATION( 6648): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:56.269+0200 W/LOCATION( 6648): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:56.269+0200 W/LOCATION( 6648): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:56.289+0200 W/LOCATION( 6648): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:56.289+0200 I/LOCATION( 6648): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7e93c18
04-23 20:07:56.289+0200 I/LOCATION( 6648): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:56.289+0200 I/LOCATION( 6648): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7e93c18
04-23 20:07:56.289+0200 I/LOCATION( 6648): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:56.289+0200 I/location( 6648): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:56.369+0200 I/LOCATION( 6648): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:56.409+0200 W/LOCATION( 6648): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:56.409+0200 W/LOCATION( 6648): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:56.409+0200 I/LOCATION( 6648): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:56.479+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:56.479+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:56.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:56.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:56.479+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:56.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:56.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:56.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:56.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:56.489+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:56.489+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:56.489+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:56.489+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:56.539+0200 W/LOCATION( 6648): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:56.539+0200 W/LOCATION( 6648): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:56.619+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:56.659+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1ec80]
04-23 20:07:56.659+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:56.659+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:56.659+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:56.659+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:56.669+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:56.669+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:56.679+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:56.689+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:56.689+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:56.689+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:56.689+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:56.689+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:56.689+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:56.689+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:56.689+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:56.689+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:56.689+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:56.699+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:56.699+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:56.699+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:56.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:56.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:56.729+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(951993), time2(948859)
04-23 20:07:56.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:07:56.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:56.729+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:56.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:56.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:56.789+0200 W/LOCATION( 6648): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:56.789+0200 I/LOCATION( 6648): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:56.789+0200 I/LOCATION( 6648): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:56.789+0200 I/location( 6648): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:56.899+0200 I/LOCATION( 6648): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:56.949+0200 E/location( 6648): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:56.959+0200 W/AUL     ( 6648): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:56.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:56.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6648
04-23 20:07:56.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:56.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:56.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:56.969+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.969+0200 I/utils   ( 5532): specific action
04-23 20:07:56.969+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.969+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.969+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.969+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:56.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:56.969+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:56.979+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:56.979+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:56.979+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.979+0200 I/utils   ( 5538): specific action
04-23 20:07:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:56.979+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:56.979+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:56.989+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:56.989+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:56.989+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:56.989+0200 W/AUL     ( 6648): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:56.989+0200 I/location( 6648): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:56.989+0200 I/location( 6648): stopping es.ugr.frailty.location service
04-23 20:07:56.989+0200 E/CAPI_APPFW_APP_CONTROL( 6648): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:07:56.989+0200 E/location( 6648): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:07:56.989+0200 I/CAPI_APPFW_APPLICATION( 6648): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:07:56.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:07:56.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:07:57.039+0200 W/LOCATION( 6648): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:57.039+0200 I/LOCATION( 6648): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:07:57.039+0200 I/LOCATION( 6648): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:07:57.129+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:07:57.129+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:07:57.129+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:07:57.129+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:07:57.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:57.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:57.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:57.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1ec80
04-23 20:07:57.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d6390]
04-23 20:07:57.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:57.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:57.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:57.369+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:57.379+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:57.379+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:57.389+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.399+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.399+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:57.399+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:57.399+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:57.399+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:57.399+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:57.399+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:57.399+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:57.399+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:57.399+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:57.409+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.409+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.409+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:57.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.459+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:57.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:57.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:57.509+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d6390
04-23 20:07:57.609+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79dca00]
04-23 20:07:57.609+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:57.609+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:57.609+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:57.609+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:57.619+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:57.619+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:57.629+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.639+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.639+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:57.639+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:57.639+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:57.639+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:57.639+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:57.639+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:57.639+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:57.639+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:57.639+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:57.649+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.659+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:57.659+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:57.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:57.729+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:57.729+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:57.729+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:57.729+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79dca00
04-23 20:07:57.899+0200 W/AUL     ( 6658): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:07:57.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:57.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:57.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6624
04-23 20:07:57.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:57.899+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6624
04-23 20:07:57.899+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6624)
04-23 20:07:58.989+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:08:06.119+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:08:06.119+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:06.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:06.119+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:06.129+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6695
04-23 20:08:06.129+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:06.179+0200 E/CAPI_APPFW_APPLICATION( 6695): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:06.179+0200 E/CAPI_APPFW_APPLICATION( 6695): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:06.179+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6695
04-23 20:08:06.179+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6695) type(svcapp) bg(0)
04-23 20:08:06.179+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6695) was created
04-23 20:08:06.179+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6695)
04-23 20:08:06.179+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:08:06.179+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:06.179+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6695]
04-23 20:08:06.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:06.199+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6695
04-23 20:08:06.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:06.219+0200 W/LOCATION( 6695): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:06.219+0200 E/LOCATION( 6695): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:06.219+0200 E/PKGMGR_INFO( 6695): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:06.219+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:06.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:06.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6695
04-23 20:08:06.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:06.249+0200 I/LOCATION( 6695): location.c: location_new(269) > method: 0
04-23 20:08:06.249+0200 W/LOCATION( 6695): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:06.249+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:06.249+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:06.259+0200 W/LOCATION( 6695): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:06.259+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:06.259+0200 W/LOCATION( 6695): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:06.259+0200 W/LOCATION( 6695): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:06.259+0200 W/LOCATION( 6695): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:06.259+0200 W/LOCATION( 6695): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:06.279+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:06.289+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:06.289+0200 W/LOCATION( 6695): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:06.289+0200 W/LOCATION( 6695): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:06.299+0200 W/LOCATION( 6695): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:06.299+0200 W/LOCATION( 6695): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:06.299+0200 W/LOCATION( 6695): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:06.309+0200 W/LOCATION( 6695): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:06.309+0200 I/LOCATION( 6695): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7777c18
04-23 20:08:06.309+0200 I/LOCATION( 6695): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:06.309+0200 I/LOCATION( 6695): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7777c18
04-23 20:08:06.309+0200 I/LOCATION( 6695): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:06.319+0200 I/location( 6695): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:06.359+0200 I/LOCATION( 6695): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:06.399+0200 W/LOCATION( 6695): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:06.399+0200 W/LOCATION( 6695): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:06.399+0200 I/LOCATION( 6695): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:06.469+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:06.469+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:06.469+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:06.469+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:06.469+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:06.469+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:06.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:06.469+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:06.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:06.469+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:06.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:06.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:06.529+0200 W/LOCATION( 6695): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:06.529+0200 W/LOCATION( 6695): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:06.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:06.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e4308]
04-23 20:08:06.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:06.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:06.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:06.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:06.649+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:06.649+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:06.659+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:06.659+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:06.659+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:06.659+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:06.659+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:06.659+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:06.659+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:06.659+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:06.659+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:06.659+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:06.659+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:06.669+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:06.679+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:06.679+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:06.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:06.709+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:06.709+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(961977), time2(948859)
04-23 20:08:06.709+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:08:06.709+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:06.709+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:06.709+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:06.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:06.759+0200 W/LOCATION( 6695): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:06.759+0200 I/LOCATION( 6695): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:06.759+0200 I/LOCATION( 6695): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:06.759+0200 I/location( 6695): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:06.849+0200 I/LOCATION( 6695): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:06.889+0200 E/location( 6695): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:06.889+0200 W/AUL     ( 6695): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:06.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:06.889+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6695
04-23 20:08:06.899+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:06.899+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:06.899+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:06.899+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.899+0200 I/utils   ( 5532): specific action
04-23 20:08:06.909+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.909+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.909+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.909+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:06.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:06.909+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:06.919+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:06.919+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:06.919+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 I/utils   ( 5538): specific action
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:06.919+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:06.919+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:06.919+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:06.919+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:06.919+0200 W/AUL     ( 6695): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:06.919+0200 I/location( 6695): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:06.919+0200 W/CAPI_APPFW_APP_CONTROL( 6695): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:06.919+0200 I/utils   ( 6695): specific action
04-23 20:08:07.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:07.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:07.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:07.679+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:08:08.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:08.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:08.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:08.359+0200 W/LOCATION( 6695): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:08:08.559+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11066956c6f63152450688
