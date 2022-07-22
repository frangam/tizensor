S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10783
Date: 2018-04-23 20:35:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf740652d, r5   = 0xf7b40f98
r6   = 0xfffddca0, r7   = 0xfffddb50
r8   = 0xf7b3dc18, r9   = 0x00000000
r10  = 0xfffddc2c, fp   = 0xfffddca0
ip   = 0x00000001, sp   = 0xfffddb28
lr   = 0xf7406539, pc   = 0xf746f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    139804 KB
Buffers:     37600 KB
Cached:     157264 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11944 KB
VmRSS:       11940 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10783 TID = 10783
10783 10786 

Maps Information
f42d1000 f4ad0000 rw-p [stack:10786]
f4ad7000 f4ad9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ae1000 f4ae5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4aee000 f4af0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4af8000 f4afb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b0a000 f4b0f000 r-xp /usr/lib/libsystem.so.0.0.0
f4b1a000 f4b1d000 r-xp /lib/libattr.so.1.1.0
f4b25000 f4b35000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b3d000 f4b46000 r-xp /usr/lib/libedbus.so.1.7.99
f4b4e000 f4b4f000 r-xp /usr/lib/libresponse.so.0.2.96
f4b58000 f4b5d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63ff000 f6505000 r-xp /usr/lib/libicuuc.so.57.1
f651b000 f66a3000 r-xp /usr/lib/libicui18n.so.57.1
f66b3000 f66c0000 r-xp /usr/lib/libail.so.0.1.0
f66c9000 f66d0000 r-xp /usr/lib/libminizip.so.1.0.0
f66d9000 f6882000 r-xp /usr/lib/libcrypto.so.1.0.0
f68a2000 f68e9000 r-xp /usr/lib/libssl.so.1.0.0
f68f5000 f68f7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68ff000 f6906000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f690f000 f6916000 r-xp /lib/libcrypt-2.13.so
f6947000 f694a000 r-xp /lib/libcap.so.2.21
f6952000 f6954000 r-xp /usr/lib/libiri.so
f695c000 f69a5000 r-xp /usr/lib/libmdm.so.1.2.69
f69ad000 f69b3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69bb000 f69de000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69e8000 f69ea000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69f2000 f6a0f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a18000 f6a1c000 r-xp /usr/lib/libsmack.so.1.0.0
f6a25000 f6a3e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a47000 f6a4f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a57000 f6a5d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a66000 f6a68000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a71000 f6a81000 r-xp /lib/libresolv-2.13.so
f6a85000 f6a9d000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa6000 f6aa8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ab0000 f6aca000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ad2000 f6b01000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b0a000 f6b19000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b23000 f6b2d000 r-xp /usr/lib/libsensord-shared.so
f6b36000 f6c09000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c14000 f6c2a000 r-xp /lib/libz.so.1.2.5
f6c32000 f6c37000 r-xp /usr/lib/libffi.so.5.0.10
f6c3f000 f6c40000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c48000 f6c58000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c60000 f6c79000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c81000 f6c83000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c8b000 f6d00000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d0a000 f6d10000 r-xp /lib/librt-2.13.so
f6d19000 f6d37000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d41000 f6d42000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d4a000 f6d6d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d75000 f6d7a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d82000 f6dac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6db5000 f6dcc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dd4000 f6e3d000 r-xp /lib/libm-2.13.so
f6e46000 f6eda000 r-xp /usr/lib/libstdc++.so.6.0.16
f6eed000 f6ef2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6efa000 f6f01000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f09000 f6f33000 r-xp /usr/lib/libsensor.so.1.9.6
f6f3c000 f7008000 r-xp /usr/lib/libxml2.so.2.7.8
f7015000 f7017000 r-xp /usr/lib/libiniparser.so.0
f7020000 f7026000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f702f000 f70ff000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7100000 f7134000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f713d000 f7179000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7181000 f7184000 r-xp /usr/lib/libbundle.so.0.1.22
f718c000 f7192000 r-xp /usr/lib/libappsvc.so.0.1.0
f719a000 f71db000 r-xp /usr/lib/libeina.so.1.7.99
f71e4000 f71fb000 r-xp /usr/lib/libecore.so.1.7.99
f7212000 f721b000 r-xp /usr/lib/libvconf.so.0.2.45
f7223000 f7237000 r-xp /lib/libpthread-2.13.so
f7242000 f724f000 r-xp /usr/lib/libaul.so.0.1.0
f7259000 f725b000 r-xp /lib/libdl-2.13.so
f7264000 f726f000 r-xp /lib/libunwind.so.8.0.1
f729c000 f72a4000 r-xp /lib/libgcc_s-4.6.so.1
f72a5000 f73c9000 r-xp /lib/libc-2.13.so
f73d7000 f73d9000 r-xp /usr/lib/libdlog.so.0.0.0
f73e1000 f73ed000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73f6000 f73fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7403000 f7412000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f741a000 f741e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7427000 f742a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7432000 f7434000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f743c000 f7440000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7448000 f7465000 r-xp /lib/ld-2.13.so
f746e000 f7471000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7471000 f7475000 r-xp /usr/lib/libsys-assert.so
f7b0d000 f7b6f000 rw-p [heap]
fffbf000 fffe0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10783)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf746f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7406539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf710d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf710bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7117e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf711dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf711ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf715275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf714d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf710bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7117e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf711dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf711ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf714fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7150017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7157f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4aef1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ae2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bb5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7062fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70647a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71f4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71efb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71f05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71f0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7428183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74287fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf746f53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf72bc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf746ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0:35:27.469+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:27.469+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.469+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:27.469+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:27.469+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:27.469+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:27.469+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:27.469+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:27.479+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.489+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.489+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:27.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:27.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:27.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:27.589+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:27.589+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:27.589+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:27.589+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72e4638
04-23 20:35:27.639+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72e62c8]
04-23 20:35:27.639+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:27.639+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:27.639+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:27.639+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:27.649+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:27.649+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.659+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.669+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.669+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:27.669+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:27.669+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.669+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:27.669+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:27.669+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:27.669+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:27.669+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:27.669+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:27.679+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.679+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:27.679+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:27.689+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:27.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:27.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:27.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:27.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:27.739+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf72e62c8
04-23 20:35:27.759+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:35:27.759+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:27.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:27.759+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:27.769+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10736
04-23 20:35:27.769+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:27.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10736
04-23 20:35:27.819+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10736) type(svcapp) bg(0)
04-23 20:35:27.829+0200 E/CAPI_APPFW_APPLICATION(10736): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:27.829+0200 E/CAPI_APPFW_APPLICATION(10736): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:27.829+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10736) was created
04-23 20:35:27.829+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10736]
04-23 20:35:27.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:27.849+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10736)
04-23 20:35:27.849+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:35:27.849+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:27.859+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10736
04-23 20:35:27.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:27.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:27.869+0200 W/LOCATION(10736): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:27.869+0200 E/LOCATION(10736): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:27.869+0200 E/PKGMGR_INFO(10736): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:27.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10736
04-23 20:35:27.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:27.879+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.889+0200 I/LOCATION(10736): location.c: location_new(269) > method: 0
04-23 20:35:27.889+0200 W/LOCATION(10736): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:27.899+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.899+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:27.909+0200 W/LOCATION(10736): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:27.909+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:27.909+0200 W/LOCATION(10736): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:27.909+0200 W/LOCATION(10736): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:27.909+0200 W/LOCATION(10736): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:27.909+0200 W/LOCATION(10736): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:27.929+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:27.939+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:27.939+0200 W/LOCATION(10736): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:27.939+0200 W/LOCATION(10736): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:27.949+0200 W/LOCATION(10736): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:27.949+0200 W/LOCATION(10736): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:27.949+0200 W/LOCATION(10736): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:27.959+0200 W/LOCATION(10736): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:27.959+0200 I/LOCATION(10736): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75f7c18
04-23 20:35:27.959+0200 I/LOCATION(10736): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:27.959+0200 I/LOCATION(10736): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75f7c18
04-23 20:35:27.959+0200 I/LOCATION(10736): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:27.969+0200 I/location(10736): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:28.009+0200 I/LOCATION(10736): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:28.049+0200 W/LOCATION(10736): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:28.049+0200 W/LOCATION(10736): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:28.049+0200 I/LOCATION(10736): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:28.139+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:28.139+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:28.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:28.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:28.139+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:28.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:28.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:28.139+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:28.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:28.149+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:28.149+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:28.149+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:28.149+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:28.189+0200 W/LOCATION(10736): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:28.189+0200 W/LOCATION(10736): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:28.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c00588]
04-23 20:35:28.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:28.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:28.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:28.309+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:28.319+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:28.319+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:28.329+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.329+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.329+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:28.329+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:28.329+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:28.329+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:28.329+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:28.329+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:28.329+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:28.329+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:28.329+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:28.339+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.349+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.349+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:28.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.369+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:28.369+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2603637), time2(2600583)
04-23 20:35:28.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:35:28.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:28.369+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:28.369+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:28.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.419+0200 W/LOCATION(10736): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:28.419+0200 I/LOCATION(10736): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:28.419+0200 I/LOCATION(10736): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:28.419+0200 I/location(10736): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:28.499+0200 I/LOCATION(10736): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:28.549+0200 W/AUL     (10736): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:28.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:28.549+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10736
04-23 20:35:28.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:28.559+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:28.559+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:28.559+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.559+0200 I/utils   (10115): specific action
04-23 20:35:28.559+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.559+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.559+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.559+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:28.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:28.559+0200 W/AUL     (10736): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:28.559+0200 I/location(10736): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:28.559+0200 I/location(10736): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:28:552,nan,37.171667,-3.594158,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:35:28.559+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:28.559+0200 I/location(10736): stopping es.ugr.frailty.location service
04-23 20:35:28.559+0200 E/CAPI_APPFW_APP_CONTROL(10736): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:35:28.559+0200 E/location(10736): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:35:28.559+0200 I/CAPI_APPFW_APPLICATION(10736): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:35:28.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:28.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:35:28.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:35:28.569+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:28.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:28.579+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:28.579+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:28.579+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:28.579+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.579+0200 I/utils   (10120): specific action
04-23 20:35:28.579+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.579+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.579+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.579+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:28.579+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:28.579+0200 I/recorder(10120): guardando datos en local
04-23 20:35:28.609+0200 W/LOCATION(10736): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:28.609+0200 I/LOCATION(10736): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:28.609+0200 I/LOCATION(10736): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:35:28.679+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:35:28.679+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:35:28.679+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:35:28.679+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:35:28.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.809+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:28.809+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:28.809+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:28.809+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c00588
04-23 20:35:28.869+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1c180]
04-23 20:35:28.869+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:28.869+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:28.869+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:28.869+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:28.869+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:28.869+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:28.879+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.889+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.889+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:28.889+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:28.889+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:28.889+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:28.889+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:28.889+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:28.889+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:28.889+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:28.889+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:28.899+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.899+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:28.899+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:28.899+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.939+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.949+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:28.999+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:28.999+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:28.999+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:28.999+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1c180
04-23 20:35:29.049+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf7326588]
04-23 20:35:29.049+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:29.049+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:29.049+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:29.049+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:29.059+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:29.059+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:29.079+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:29.089+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:29.089+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:29.089+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:29.089+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:29.089+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:29.089+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:29.089+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:29.089+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:29.089+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:29.089+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:29.099+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:29.099+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:29.099+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:29.109+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:29.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:29.149+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:29.149+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:29.149+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:29.149+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf7326588
04-23 20:35:29.309+0200 W/AUL     (10747): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:35:29.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:35:29.309+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:35:29.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10710
04-23 20:35:29.309+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:35:29.309+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10710
04-23 20:35:29.309+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10710)
04-23 20:35:30.569+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:35:37.859+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:35:37.859+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:37.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:37.859+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:37.879+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10783
04-23 20:35:37.879+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:37.929+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10783
04-23 20:35:37.929+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10783) type(svcapp) bg(0)
04-23 20:35:37.939+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10783]
04-23 20:35:37.949+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10783)
04-23 20:35:37.959+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:35:37.959+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:37.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:37.969+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10783
04-23 20:35:37.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:37.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:37.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10783
04-23 20:35:37.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:37.999+0200 E/CAPI_APPFW_APPLICATION(10783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:37.999+0200 E/CAPI_APPFW_APPLICATION(10783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:37.999+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10783) was created
04-23 20:35:38.029+0200 W/LOCATION(10783): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:38.029+0200 E/LOCATION(10783): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:38.029+0200 E/PKGMGR_INFO(10783): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:38.039+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:38.049+0200 I/LOCATION(10783): location.c: location_new(269) > method: 0
04-23 20:35:38.049+0200 W/LOCATION(10783): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:38.059+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:38.059+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:38.069+0200 W/LOCATION(10783): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:38.069+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:38.079+0200 W/LOCATION(10783): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:38.079+0200 W/LOCATION(10783): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:38.079+0200 W/LOCATION(10783): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:38.079+0200 W/LOCATION(10783): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:38.099+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:38.099+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:38.099+0200 W/LOCATION(10783): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:38.109+0200 W/LOCATION(10783): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:38.109+0200 W/LOCATION(10783): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:38.109+0200 W/LOCATION(10783): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:38.109+0200 W/LOCATION(10783): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:38.129+0200 W/LOCATION(10783): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:38.129+0200 I/LOCATION(10783): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b3dc18
04-23 20:35:38.129+0200 I/LOCATION(10783): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:38.129+0200 I/LOCATION(10783): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b3dc18
04-23 20:35:38.129+0200 I/LOCATION(10783): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:38.129+0200 I/location(10783): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:38.169+0200 I/LOCATION(10783): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:38.209+0200 W/LOCATION(10783): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:38.209+0200 W/LOCATION(10783): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:38.209+0200 I/LOCATION(10783): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:38.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:38.279+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:38.279+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:38.279+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:38.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:38.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:38.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:38.279+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:38.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:38.279+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:38.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:38.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:38.339+0200 W/LOCATION(10783): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:38.339+0200 W/LOCATION(10783): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:38.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:38.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1bb88]
04-23 20:35:38.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:38.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:38.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:38.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:38.479+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:38.479+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:38.489+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:38.509+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:38.509+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:38.509+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:38.509+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:38.509+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:38.509+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:38.509+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:38.509+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:38.509+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:38.509+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:38.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:38.509+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2613772), time2(2600583)
04-23 20:35:38.509+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:35:38.509+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:38.509+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:38.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:38.519+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:38.529+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:38.529+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:38.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:38.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:38.609+0200 W/LOCATION(10783): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:38.609+0200 I/LOCATION(10783): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:38.609+0200 I/LOCATION(10783): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:38.609+0200 I/location(10783): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:38.749+0200 I/LOCATION(10783): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:38.809+0200 W/AUL     (10783): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:38.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:38.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10783
04-23 20:35:38.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:38.819+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.819+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:38.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:38.819+0200 W/AUL     (10783): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:38.819+0200 I/location(10783): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:38.819+0200 I/location(10783): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:38:812,nan,37.171667,-3.594158,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:35:38.819+0200 W/CAPI_APPFW_APP_CONTROL(10783): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.819+0200 I/utils   (10783): specific action
04-23 20:35:38.819+0200 I/utils   (10115): specific action
04-23 20:35:38.819+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.819+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.819+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.819+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:38.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:38.829+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:38.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:38.839+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.839+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:38.839+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:38.839+0200 I/utils   (10120): specific action
04-23 20:35:38.839+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.839+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.839+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.839+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:38.839+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:38.839+0200 I/recorder(10120): guardando datos en local
04-23 20:35:38.839+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:38.839+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:38.839+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:39.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:39.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:39.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:39.639+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:35:40.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:40.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:40.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:40.489+0200 W/LOCATION(10783): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:35:40.719+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11107836c6f63152450854
