S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6839
Date: 2018-04-23 20:08:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74b652d, r5   = 0xf7cf0f98
r6   = 0xff931d90, r7   = 0xff931c40
r8   = 0xf7cedc18, r9   = 0x00000000
r10  = 0xff931d1c, fp   = 0xff931d90
ip   = 0x00000001, sp   = 0xff931c18
lr   = 0xf74b6539, pc   = 0xf751f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    110156 KB
Buffers:     39188 KB
Cached:     185212 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11680 KB
VmRSS:       11676 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6839 TID = 6839
6839 6842 

Maps Information
f4381000 f4b80000 rw-p [stack:6842]
f4b87000 f4b89000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b91000 f4b95000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b9e000 f4ba0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ba8000 f4bab000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bba000 f4bbf000 r-xp /usr/lib/libsystem.so.0.0.0
f4bca000 f4bcd000 r-xp /lib/libattr.so.1.1.0
f4bd5000 f4be5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bed000 f4bf6000 r-xp /usr/lib/libedbus.so.1.7.99
f4bfe000 f4bff000 r-xp /usr/lib/libresponse.so.0.2.96
f4c08000 f4c0d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64af000 f65b5000 r-xp /usr/lib/libicuuc.so.57.1
f65cb000 f6753000 r-xp /usr/lib/libicui18n.so.57.1
f6763000 f6770000 r-xp /usr/lib/libail.so.0.1.0
f6779000 f6780000 r-xp /usr/lib/libminizip.so.1.0.0
f6789000 f6932000 r-xp /usr/lib/libcrypto.so.1.0.0
f6952000 f6999000 r-xp /usr/lib/libssl.so.1.0.0
f69a5000 f69a7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69af000 f69b6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69bf000 f69c6000 r-xp /lib/libcrypt-2.13.so
f69f7000 f69fa000 r-xp /lib/libcap.so.2.21
f6a02000 f6a04000 r-xp /usr/lib/libiri.so
f6a0c000 f6a55000 r-xp /usr/lib/libmdm.so.1.2.69
f6a5d000 f6a63000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a6b000 f6a8e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a98000 f6a9a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aa2000 f6abf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ac8000 f6acc000 r-xp /usr/lib/libsmack.so.1.0.0
f6ad5000 f6aee000 r-xp /usr/lib/libnetwork.so.0.0.0
f6af7000 f6aff000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b07000 f6b0d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b16000 f6b18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b21000 f6b31000 r-xp /lib/libresolv-2.13.so
f6b35000 f6b4d000 r-xp /usr/lib/liblzma.so.5.0.3
f6b56000 f6b58000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b60000 f6b7a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b82000 f6bb1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bba000 f6bc9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bd3000 f6bdd000 r-xp /usr/lib/libsensord-shared.so
f6be6000 f6cb9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cc4000 f6cda000 r-xp /lib/libz.so.1.2.5
f6ce2000 f6ce7000 r-xp /usr/lib/libffi.so.5.0.10
f6cef000 f6cf0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cf8000 f6d08000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d10000 f6d29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d31000 f6d33000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d3b000 f6db0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dba000 f6dc0000 r-xp /lib/librt-2.13.so
f6dc9000 f6de7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6df1000 f6df2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dfa000 f6e1d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e25000 f6e2a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e32000 f6e5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e65000 f6e7c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e84000 f6eed000 r-xp /lib/libm-2.13.so
f6ef6000 f6f8a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f9d000 f6fa2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6faa000 f6fb1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fb9000 f6fe3000 r-xp /usr/lib/libsensor.so.1.9.6
f6fec000 f70b8000 r-xp /usr/lib/libxml2.so.2.7.8
f70c5000 f70c7000 r-xp /usr/lib/libiniparser.so.0
f70d0000 f70d6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70df000 f71af000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71b0000 f71e4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71ed000 f7229000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7231000 f7234000 r-xp /usr/lib/libbundle.so.0.1.22
f723c000 f7242000 r-xp /usr/lib/libappsvc.so.0.1.0
f724a000 f728b000 r-xp /usr/lib/libeina.so.1.7.99
f7294000 f72ab000 r-xp /usr/lib/libecore.so.1.7.99
f72c2000 f72cb000 r-xp /usr/lib/libvconf.so.0.2.45
f72d3000 f72e7000 r-xp /lib/libpthread-2.13.so
f72f2000 f72ff000 r-xp /usr/lib/libaul.so.0.1.0
f7309000 f730b000 r-xp /lib/libdl-2.13.so
f7314000 f731f000 r-xp /lib/libunwind.so.8.0.1
f734c000 f7354000 r-xp /lib/libgcc_s-4.6.so.1
f7355000 f7479000 r-xp /lib/libc-2.13.so
f7487000 f7489000 r-xp /usr/lib/libdlog.so.0.0.0
f7491000 f749d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74a6000 f74ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74b3000 f74c2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74ca000 f74ce000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74d7000 f74da000 r-xp /usr/lib/libappcore-agent.so.1.1
f74e2000 f74e4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74ec000 f74f0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74f8000 f7515000 r-xp /lib/ld-2.13.so
f751e000 f7521000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7521000 f7525000 r-xp /usr/lib/libsys-assert.so
f7cbd000 f7d2e000 rw-p [heap]
ff913000 ff934000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6839)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf751f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74b6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71bd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf720275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71fd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71ffe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7200017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7207f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b9f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b92171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c65663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7112fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71147a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72a4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf729fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72a05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72a0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74d8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74d87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf751f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf736c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf751ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 20:08:21.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:21.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:21.879+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:21.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:21.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:21.879+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:21.889+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:21.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:21.899+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:21.899+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:21.949+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:21.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:22.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:22.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:22.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:22.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d41a8
04-23 20:08:22.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a01778]
04-23 20:08:22.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:22.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:22.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:22.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:22.079+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.079+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.089+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.099+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:22.099+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:22.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:22.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:22.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:22.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:22.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:22.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.119+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:22.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:22.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:22.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:22.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:22.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:22.179+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a01778
04-23 20:08:22.319+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:08:22.319+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:22.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:22.329+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:22.339+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6791
04-23 20:08:22.339+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:22.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6791
04-23 20:08:22.389+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6791) type(svcapp) bg(0)
04-23 20:08:22.389+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6791)
04-23 20:08:22.389+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:08:22.389+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:22.389+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6791]
04-23 20:08:22.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:22.409+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6791
04-23 20:08:22.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:22.419+0200 E/CAPI_APPFW_APPLICATION( 6791): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:22.419+0200 E/CAPI_APPFW_APPLICATION( 6791): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:22.419+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6791) was created
04-23 20:08:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6791
04-23 20:08:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:22.439+0200 W/LOCATION( 6791): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:22.439+0200 E/LOCATION( 6791): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:22.439+0200 E/PKGMGR_INFO( 6791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:22.449+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.459+0200 I/LOCATION( 6791): location.c: location_new(269) > method: 0
04-23 20:08:22.459+0200 W/LOCATION( 6791): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.469+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.469+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.469+0200 W/LOCATION( 6791): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:22.479+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:22.479+0200 W/LOCATION( 6791): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:22.479+0200 W/LOCATION( 6791): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.479+0200 W/LOCATION( 6791): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:22.479+0200 W/LOCATION( 6791): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:22.499+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:22.509+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:22.509+0200 W/LOCATION( 6791): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:22.509+0200 W/LOCATION( 6791): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:22.519+0200 W/LOCATION( 6791): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:22.519+0200 W/LOCATION( 6791): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:22.519+0200 W/LOCATION( 6791): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:22.539+0200 W/LOCATION( 6791): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:22.539+0200 I/LOCATION( 6791): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf76bdc18
04-23 20:08:22.539+0200 I/LOCATION( 6791): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:22.539+0200 I/LOCATION( 6791): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf76bdc18
04-23 20:08:22.539+0200 I/LOCATION( 6791): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:22.539+0200 I/location( 6791): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:22.589+0200 I/LOCATION( 6791): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:22.629+0200 W/LOCATION( 6791): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:22.629+0200 W/LOCATION( 6791): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:22.629+0200 I/LOCATION( 6791): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:22.689+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:22.689+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:22.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:22.689+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:22.689+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:22.689+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:22.689+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:22.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:22.689+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:22.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:22.699+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:22.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:22.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:22.749+0200 W/LOCATION( 6791): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:22.749+0200 W/LOCATION( 6791): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:22.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:22.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e4308]
04-23 20:08:22.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:22.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:22.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:22.879+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:22.879+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.879+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.889+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.899+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.899+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:22.899+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:22.899+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:22.899+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:22.899+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:22.899+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:22.899+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:22.899+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:22.899+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:22.909+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.919+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:22.919+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:22.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:22.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:22.939+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(978200), time2(975178)
04-23 20:08:22.939+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:08:22.939+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:22.939+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:22.939+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:22.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:23.009+0200 W/LOCATION( 6791): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:23.009+0200 I/LOCATION( 6791): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:23.009+0200 I/LOCATION( 6791): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:23.009+0200 I/location( 6791): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:23.119+0200 I/LOCATION( 6791): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:23.199+0200 E/location( 6791): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:23.199+0200 W/AUL     ( 6791): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:23.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:23.199+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6791
04-23 20:08:23.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:23.209+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:23.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:23.209+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.219+0200 I/utils   ( 5532): specific action
04-23 20:08:23.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.219+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:23.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:23.229+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:23.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:23.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.239+0200 I/utils   ( 5538): specific action
04-23 20:08:23.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.239+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:23.239+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:23.239+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:23.239+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:23.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:23.239+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:23.239+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:23.239+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:23.239+0200 W/AUL     ( 6791): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:23.239+0200 I/location( 6791): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:23.239+0200 I/location( 6791): stopping es.ugr.frailty.location service
04-23 20:08:23.239+0200 E/CAPI_APPFW_APP_CONTROL( 6791): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:08:23.239+0200 E/location( 6791): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:08:23.239+0200 I/CAPI_APPFW_APPLICATION( 6791): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:08:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:08:23.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:08:23.329+0200 W/LOCATION( 6791): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:23.339+0200 I/LOCATION( 6791): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:23.339+0200 I/LOCATION( 6791): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:23.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:23.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:23.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:08:23.439+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:08:23.439+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:08:23.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:08:23.449+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:08:23.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:23.649+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:23.649+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:23.649+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:23.649+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e4308
04-23 20:08:23.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e4f98]
04-23 20:08:23.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:23.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:23.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:23.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:23.709+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:23.709+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:23.719+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:23.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:23.729+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:23.729+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:23.729+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:23.729+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:23.729+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:23.729+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:23.729+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:23.729+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:23.729+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:23.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:23.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:23.739+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:23.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:23.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:23.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:23.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:23.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:23.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:23.979+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e4f98
04-23 20:08:24.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f031f8]
04-23 20:08:24.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:24.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:24.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:24.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:24.069+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:24.069+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:24.079+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:24.089+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:24.089+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:24.089+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:24.089+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:24.089+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:24.089+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:24.089+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:24.089+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:24.089+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:24.089+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:24.089+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:24.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:24.099+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:24.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:24.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:24.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:24.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:24.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:24.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f031f8
04-23 20:08:24.359+0200 W/AUL     ( 6803): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:08:24.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:08:24.359+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:08:24.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6769
04-23 20:08:24.359+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:08:24.359+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6769
04-23 20:08:24.359+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6769)
04-23 20:08:25.239+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:08:32.399+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:08:32.399+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:32.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:32.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:32.409+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6839
04-23 20:08:32.409+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:32.459+0200 E/CAPI_APPFW_APPLICATION( 6839): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:32.459+0200 E/CAPI_APPFW_APPLICATION( 6839): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:32.459+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6839
04-23 20:08:32.459+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6839) type(svcapp) bg(0)
04-23 20:08:32.459+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6839) was created
04-23 20:08:32.459+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6839)
04-23 20:08:32.459+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:08:32.459+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:32.459+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6839]
04-23 20:08:32.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:32.479+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6839
04-23 20:08:32.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:32.489+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:32.499+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6839
04-23 20:08:32.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:32.499+0200 W/LOCATION( 6839): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:32.499+0200 E/LOCATION( 6839): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:32.499+0200 E/PKGMGR_INFO( 6839): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:32.509+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:32.529+0200 I/LOCATION( 6839): location.c: location_new(269) > method: 0
04-23 20:08:32.529+0200 W/LOCATION( 6839): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:32.529+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:32.539+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:32.539+0200 W/LOCATION( 6839): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:32.539+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:32.549+0200 W/LOCATION( 6839): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:32.549+0200 W/LOCATION( 6839): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:32.549+0200 W/LOCATION( 6839): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:32.549+0200 W/LOCATION( 6839): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:32.569+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:32.569+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:32.579+0200 W/LOCATION( 6839): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:32.579+0200 W/LOCATION( 6839): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:32.589+0200 W/LOCATION( 6839): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:32.589+0200 W/LOCATION( 6839): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:32.589+0200 W/LOCATION( 6839): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:32.599+0200 W/LOCATION( 6839): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:32.599+0200 I/LOCATION( 6839): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7cedc18
04-23 20:08:32.599+0200 I/LOCATION( 6839): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:32.599+0200 I/LOCATION( 6839): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7cedc18
04-23 20:08:32.599+0200 I/LOCATION( 6839): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:32.609+0200 I/location( 6839): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:32.649+0200 I/LOCATION( 6839): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:32.689+0200 W/LOCATION( 6839): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:32.689+0200 W/LOCATION( 6839): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:32.689+0200 I/LOCATION( 6839): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:32.759+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:32.759+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:32.759+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:32.759+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:32.759+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:32.759+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:32.759+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:32.759+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:32.759+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:32.759+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:32.759+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:32.759+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:32.809+0200 W/LOCATION( 6839): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:32.809+0200 W/LOCATION( 6839): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:32.889+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:32.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f256f8]
04-23 20:08:32.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:32.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:32.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:32.929+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:32.939+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:32.939+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:32.949+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:32.959+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:32.959+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:32.959+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:32.959+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:32.959+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:32.959+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:32.959+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:32.959+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:32.959+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:32.959+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:32.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:32.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:32.969+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:32.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:32.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:32.999+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(988268), time2(975178)
04-23 20:08:32.999+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:08:32.999+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:32.999+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:32.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:33.019+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:33.039+0200 W/LOCATION( 6839): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:33.039+0200 I/LOCATION( 6839): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:33.039+0200 I/LOCATION( 6839): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:33.039+0200 I/location( 6839): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:33.129+0200 I/LOCATION( 6839): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:33.179+0200 E/location( 6839): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:33.179+0200 W/AUL     ( 6839): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:33.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:33.179+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6839
04-23 20:08:33.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:33.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.189+0200 I/utils   ( 5532): specific action
04-23 20:08:33.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.189+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.189+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:33.189+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:33.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:33.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:33.189+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:33.199+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:33.199+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:33.199+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:33.199+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.199+0200 I/utils   ( 5538): specific action
04-23 20:08:33.199+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.199+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.199+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.199+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.199+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:33.199+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:33.199+0200 W/AUL     ( 6839): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:33.199+0200 I/location( 6839): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:33.209+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:33.209+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:33.209+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:33.209+0200 W/CAPI_APPFW_APP_CONTROL( 6839): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:33.209+0200 I/utils   ( 6839): specific action
04-23 20:08:33.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:33.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:33.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:34.029+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:08:34.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:34.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:34.739+0200 W/LOCATION( 6839): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:08:34.889+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11068396c6f63152450691
