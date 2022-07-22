S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9592
Date: 2018-04-23 20:31:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf746452d, r5   = 0xf7ad8f98
r6   = 0xfff41690, r7   = 0xfff41540
r8   = 0xf7ad5c18, r9   = 0x00000000
r10  = 0xfff4161c, fp   = 0xfff41690
ip   = 0x00000001, sp   = 0xfff41518
lr   = 0xf7464539, pc   = 0xf74cd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146444 KB
Buffers:     35356 KB
Cached:     153864 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11560 KB
VmRSS:       11560 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9592 TID = 9592
9592 9595 

Maps Information
f432f000 f4b2e000 rw-p [stack:9595]
f4b35000 f4b37000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b3f000 f4b43000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b4c000 f4b4e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b56000 f4b59000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b68000 f4b6d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b78000 f4b7b000 r-xp /lib/libattr.so.1.1.0
f4b83000 f4b93000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b9b000 f4ba4000 r-xp /usr/lib/libedbus.so.1.7.99
f4bac000 f4bad000 r-xp /usr/lib/libresponse.so.0.2.96
f4bb6000 f4bbb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f645d000 f6563000 r-xp /usr/lib/libicuuc.so.57.1
f6579000 f6701000 r-xp /usr/lib/libicui18n.so.57.1
f6711000 f671e000 r-xp /usr/lib/libail.so.0.1.0
f6727000 f672e000 r-xp /usr/lib/libminizip.so.1.0.0
f6737000 f68e0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6900000 f6947000 r-xp /usr/lib/libssl.so.1.0.0
f6953000 f6955000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f695d000 f6964000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f696d000 f6974000 r-xp /lib/libcrypt-2.13.so
f69a5000 f69a8000 r-xp /lib/libcap.so.2.21
f69b0000 f69b2000 r-xp /usr/lib/libiri.so
f69ba000 f6a03000 r-xp /usr/lib/libmdm.so.1.2.69
f6a0b000 f6a11000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a19000 f6a3c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a46000 f6a48000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a50000 f6a6d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a76000 f6a7a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a83000 f6a9c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aa5000 f6aad000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ab5000 f6abb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ac4000 f6ac6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6acf000 f6adf000 r-xp /lib/libresolv-2.13.so
f6ae3000 f6afb000 r-xp /usr/lib/liblzma.so.5.0.3
f6b04000 f6b06000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b0e000 f6b28000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b30000 f6b5f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b68000 f6b77000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b81000 f6b8b000 r-xp /usr/lib/libsensord-shared.so
f6b94000 f6c67000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c72000 f6c88000 r-xp /lib/libz.so.1.2.5
f6c90000 f6c95000 r-xp /usr/lib/libffi.so.5.0.10
f6c9d000 f6c9e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ca6000 f6cb6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cbe000 f6cd7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cdf000 f6ce1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ce9000 f6d5e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d68000 f6d6e000 r-xp /lib/librt-2.13.so
f6d77000 f6d95000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d9f000 f6da0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6da8000 f6dcb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dd3000 f6dd8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6de0000 f6e0a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e13000 f6e2a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e32000 f6e9b000 r-xp /lib/libm-2.13.so
f6ea4000 f6f38000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f4b000 f6f50000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f58000 f6f5f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f67000 f6f91000 r-xp /usr/lib/libsensor.so.1.9.6
f6f9a000 f7066000 r-xp /usr/lib/libxml2.so.2.7.8
f7073000 f7075000 r-xp /usr/lib/libiniparser.so.0
f707e000 f7084000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f708d000 f715d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f715e000 f7192000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f719b000 f71d7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71df000 f71e2000 r-xp /usr/lib/libbundle.so.0.1.22
f71ea000 f71f0000 r-xp /usr/lib/libappsvc.so.0.1.0
f71f8000 f7239000 r-xp /usr/lib/libeina.so.1.7.99
f7242000 f7259000 r-xp /usr/lib/libecore.so.1.7.99
f7270000 f7279000 r-xp /usr/lib/libvconf.so.0.2.45
f7281000 f7295000 r-xp /lib/libpthread-2.13.so
f72a0000 f72ad000 r-xp /usr/lib/libaul.so.0.1.0
f72b7000 f72b9000 r-xp /lib/libdl-2.13.so
f72c2000 f72cd000 r-xp /lib/libunwind.so.8.0.1
f72fa000 f7302000 r-xp /lib/libgcc_s-4.6.so.1
f7303000 f7427000 r-xp /lib/libc-2.13.so
f7435000 f7437000 r-xp /usr/lib/libdlog.so.0.0.0
f743f000 f744b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7454000 f7459000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7461000 f7470000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7478000 f747c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7485000 f7488000 r-xp /usr/lib/libappcore-agent.so.1.1
f7490000 f7492000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f749a000 f749e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74a6000 f74c3000 r-xp /lib/ld-2.13.so
f74cc000 f74cf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74cf000 f74d3000 r-xp /usr/lib/libsys-assert.so
f7aa5000 f7b16000 rw-p [heap]
fff22000 fff43000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9592)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74cd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7464539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf716b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7169c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7175e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf717bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf717bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71b075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71ab1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7169c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7175e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf717bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf717bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71ade5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71ae017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71b5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b4d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b40171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c13663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70c0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70c27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7252ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf724db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf724e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf724e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7486183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74867fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74cd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf731a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74ccf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3 20:30:55.699+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:55.699+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:55.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:55.699+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:55.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:55.699+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:55.699+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:55.699+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:55.699+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:55.699+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.709+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.709+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:55.709+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:55.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:55.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:55.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:55.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:55.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:55.809+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4000ac8
04-23 20:30:55.869+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf402f2a8]
04-23 20:30:55.869+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:55.869+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:55.869+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:55.869+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:55.869+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:55.879+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:55.889+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.899+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.899+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:55.899+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:55.899+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:55.899+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:55.899+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:55.899+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:55.899+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:55.899+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:55.899+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:55.909+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.909+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:55.909+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:55.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:55.969+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:55.969+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:55.969+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:55.969+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:55.969+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf402f2a8
04-23 20:30:56.089+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:30:56.089+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:56.089+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:56.089+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:56.109+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9545
04-23 20:30:56.109+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:56.159+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9545
04-23 20:30:56.159+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9545) type(svcapp) bg(0)
04-23 20:30:56.169+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9545]
04-23 20:30:56.189+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9545)
04-23 20:30:56.189+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:30:56.189+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:56.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:56.199+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9545
04-23 20:30:56.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:56.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:56.219+0200 E/CAPI_APPFW_APPLICATION( 9545): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:56.219+0200 E/CAPI_APPFW_APPLICATION( 9545): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:56.219+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9545
04-23 20:30:56.229+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9545) was created
04-23 20:30:56.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:56.249+0200 W/LOCATION( 9545): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:56.249+0200 E/LOCATION( 9545): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:56.249+0200 E/PKGMGR_INFO( 9545): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:56.259+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:56.289+0200 I/LOCATION( 9545): location.c: location_new(269) > method: 0
04-23 20:30:56.289+0200 W/LOCATION( 9545): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:56.299+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:56.309+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:56.319+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:56.319+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:56.329+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:56.329+0200 W/LOCATION( 9545): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:56.329+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:56.329+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:56.349+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:56.359+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:56.359+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:56.359+0200 W/LOCATION( 9545): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:56.369+0200 W/LOCATION( 9545): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:56.369+0200 W/LOCATION( 9545): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:56.369+0200 W/LOCATION( 9545): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:56.389+0200 W/LOCATION( 9545): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:56.389+0200 I/LOCATION( 9545): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf763fc18
04-23 20:30:56.389+0200 I/LOCATION( 9545): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:56.389+0200 I/LOCATION( 9545): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf763fc18
04-23 20:30:56.389+0200 I/LOCATION( 9545): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:56.389+0200 I/location( 9545): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:56.429+0200 I/LOCATION( 9545): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:56.469+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:56.469+0200 W/LOCATION( 9545): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:56.469+0200 I/LOCATION( 9545): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:56.539+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:56.539+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:56.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:56.539+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:56.539+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:56.539+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:56.539+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:56.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:56.549+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:56.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:56.549+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:56.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:56.549+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:56.599+0200 W/LOCATION( 9545): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:56.599+0200 W/LOCATION( 9545): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:56.669+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:56.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76ffb68]
04-23 20:30:56.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:56.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:56.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:56.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:56.719+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:56.719+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:56.729+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:56.739+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:56.739+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:56.739+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:56.739+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:56.739+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:56.739+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:56.739+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:56.739+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:56.739+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:56.739+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:56.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:56.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:56.749+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:56.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:56.799+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:56.809+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:56.809+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2332072), time2(2328907)
04-23 20:30:56.809+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:30:56.809+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:56.809+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:56.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:56.829+0200 W/LOCATION( 9545): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:56.829+0200 I/LOCATION( 9545): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:56.829+0200 I/LOCATION( 9545): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:56.829+0200 I/location( 9545): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:56.919+0200 I/LOCATION( 9545): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:56.959+0200 E/location( 9545): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:56.959+0200 W/AUL     ( 9545): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:56.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:56.969+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9545
04-23 20:30:56.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:56.979+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.979+0200 I/utils   ( 8242): specific action
04-23 20:30:56.979+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.979+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.979+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:56.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:56.979+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:56.979+0200 W/AUL     ( 9545): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:56.979+0200 I/location( 9545): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:56.979+0200 I/location( 9545): stopping es.ugr.frailty.location service
04-23 20:30:56.979+0200 E/CAPI_APPFW_APP_CONTROL( 9545): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:30:56.979+0200 E/location( 9545): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:30:56.979+0200 I/CAPI_APPFW_APPLICATION( 9545): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:56.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:56.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:56.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:56.989+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:56.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:56.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.989+0200 I/utils   ( 8247): specific action
04-23 20:30:56.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:56.989+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:56.989+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:56.989+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:56.989+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:56.989+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:57.029+0200 W/LOCATION( 9545): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:57.029+0200 I/LOCATION( 9545): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:57.029+0200 I/LOCATION( 9545): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:30:57.099+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:30:57.099+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:30:57.099+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:30:57.099+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:30:57.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:57.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:57.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:57.239+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76ffb68
04-23 20:30:57.309+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf402f1f8]
04-23 20:30:57.309+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:57.309+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:57.309+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:57.309+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:57.319+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:57.319+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:57.329+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.339+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.339+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:57.339+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:57.339+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:57.339+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:57.339+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:57.339+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:57.339+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:57.339+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:57.339+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:57.349+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.359+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.359+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:57.359+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:57.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:57.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:57.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf402f1f8
04-23 20:30:57.519+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4016270]
04-23 20:30:57.519+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:57.519+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:57.519+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:57.519+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:57.529+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:57.529+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:57.539+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.549+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:57.549+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:57.549+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:57.549+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:57.549+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:57.549+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:57.549+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:57.549+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:57.549+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:57.559+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.559+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:57.559+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:57.559+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:57.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:57.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:57.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:57.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4016270
04-23 20:30:57.809+0200 W/AUL     ( 9556): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:30:57.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:57.809+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:57.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9521
04-23 20:30:57.809+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:57.809+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9521
04-23 20:30:57.809+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9521)
04-23 20:30:58.989+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:31:06.199+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:31:06.199+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:31:06.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:06.199+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:06.209+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:31:06.209+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9592
04-23 20:31:06.259+0200 E/CAPI_APPFW_APPLICATION( 9592): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:06.259+0200 E/CAPI_APPFW_APPLICATION( 9592): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:06.269+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9592
04-23 20:31:06.269+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9592) type(svcapp) bg(0)
04-23 20:31:06.269+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9592) was created
04-23 20:31:06.269+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9592]
04-23 20:31:06.279+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9592)
04-23 20:31:06.279+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:31:06.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:06.299+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9592
04-23 20:31:06.299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:06.299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:06.309+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9592
04-23 20:31:06.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:06.309+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:31:06.319+0200 W/LOCATION( 9592): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:31:06.319+0200 E/LOCATION( 9592): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:31:06.319+0200 E/PKGMGR_INFO( 9592): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:31:06.329+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:06.339+0200 I/LOCATION( 9592): location.c: location_new(269) > method: 0
04-23 20:31:06.349+0200 W/LOCATION( 9592): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:06.349+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:06.359+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:06.359+0200 W/LOCATION( 9592): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:06.359+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:06.369+0200 W/LOCATION( 9592): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:06.369+0200 W/LOCATION( 9592): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:06.369+0200 W/LOCATION( 9592): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:06.369+0200 W/LOCATION( 9592): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:06.389+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:06.389+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:06.399+0200 W/LOCATION( 9592): module-internal.c: module_new(311) > module (wps) open success
04-23 20:31:06.399+0200 W/LOCATION( 9592): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:31:06.399+0200 W/LOCATION( 9592): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:31:06.399+0200 W/LOCATION( 9592): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:06.399+0200 W/LOCATION( 9592): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:06.419+0200 W/LOCATION( 9592): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:31:06.419+0200 I/LOCATION( 9592): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7ad5c18
04-23 20:31:06.419+0200 I/LOCATION( 9592): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:31:06.419+0200 I/LOCATION( 9592): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7ad5c18
04-23 20:31:06.419+0200 I/LOCATION( 9592): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:31:06.429+0200 I/location( 9592): es.ugr.frailty.location: creado servicio de localización
04-23 20:31:06.469+0200 I/LOCATION( 9592): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:31:06.519+0200 W/LOCATION( 9592): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:06.519+0200 W/LOCATION( 9592): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:06.519+0200 I/LOCATION( 9592): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:31:06.589+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:31:06.589+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:06.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:06.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:31:06.589+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:31:06.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:31:06.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:31:06.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:31:06.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:31:06.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:31:06.599+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:31:06.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:31:06.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:31:06.649+0200 W/LOCATION( 9592): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:06.649+0200 W/LOCATION( 9592): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:06.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:06.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4015148]
04-23 20:31:06.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:31:06.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:31:06.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:31:06.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:31:06.769+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:06.769+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:06.779+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:06.789+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:06.789+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:31:06.789+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:31:06.789+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:06.789+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:06.789+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:06.789+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:06.789+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:06.789+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:06.789+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:06.799+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:06.809+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:06.809+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:06.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:06.839+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:31:06.839+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2342107), time2(2328907)
04-23 20:31:06.839+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:31:06.839+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:31:06.839+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:31:06.839+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:31:06.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:06.879+0200 W/LOCATION( 9592): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:31:06.879+0200 I/LOCATION( 9592): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:06.879+0200 I/LOCATION( 9592): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:06.879+0200 I/location( 9592): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:31:06.979+0200 I/LOCATION( 9592): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:07.019+0200 E/location( 9592): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:31:07.019+0200 W/AUL     ( 9592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:31:07.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:07.019+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9592
04-23 20:31:07.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:31:07.029+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:07.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:31:07.029+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.039+0200 I/utils   ( 8242): specific action
04-23 20:31:07.039+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.039+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.039+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.039+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:31:07.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:07.039+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:07.049+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:31:07.049+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:07.049+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 I/utils   ( 8247): specific action
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:31:07.049+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:31:07.049+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:31:07.049+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:31:07.049+0200 I/recorder( 8247): guardando datos en local
04-23 20:31:07.049+0200 W/AUL     ( 9592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:31:07.049+0200 I/location( 9592): request sent to service es.ugr.frailty.servicemanager
04-23 20:31:07.049+0200 W/CAPI_APPFW_APP_CONTROL( 9592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:07.049+0200 I/utils   ( 9592): specific action
04-23 20:31:07.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:07.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:07.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:07.929+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:31:08.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:08.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:08.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:08.669+0200 W/LOCATION( 9592): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:31:08.849+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11095926c6f63152450826
