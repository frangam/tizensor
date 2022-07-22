S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20895
Date: 2018-04-23 15:58:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf704a52d, r5   = 0xf74ebf98
r6   = 0xfff20a38, r7   = 0xfff208e8
r8   = 0xf74e8c18, r9   = 0x00000000
r10  = 0xfff209c4, fp   = 0xfff20a38
ip   = 0x00000001, sp   = 0xfff1f768
lr   = 0xf704a539, pc   = 0xf70b32b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7928 KB
Buffers:     58784 KB
Cached:     234628 KB
VmPeak:      53460 KB
VmSize:      53428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12060 KB
VmRSS:       12060 KB
VmData:      11156 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20895 TID = 20895
20895 20898 

Maps Information
f3f15000 f4714000 rw-p [stack:20898]
f471b000 f471d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4725000 f4729000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4732000 f4734000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f473c000 f473f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f474e000 f4753000 r-xp /usr/lib/libsystem.so.0.0.0
f475e000 f4761000 r-xp /lib/libattr.so.1.1.0
f4769000 f4779000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4781000 f478a000 r-xp /usr/lib/libedbus.so.1.7.99
f4792000 f4793000 r-xp /usr/lib/libresponse.so.0.2.96
f479c000 f47a1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6043000 f6149000 r-xp /usr/lib/libicuuc.so.57.1
f615f000 f62e7000 r-xp /usr/lib/libicui18n.so.57.1
f62f7000 f6304000 r-xp /usr/lib/libail.so.0.1.0
f630d000 f6314000 r-xp /usr/lib/libminizip.so.1.0.0
f631d000 f64c6000 r-xp /usr/lib/libcrypto.so.1.0.0
f64e6000 f652d000 r-xp /usr/lib/libssl.so.1.0.0
f6539000 f653b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6543000 f654a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6553000 f655a000 r-xp /lib/libcrypt-2.13.so
f658b000 f658e000 r-xp /lib/libcap.so.2.21
f6596000 f6598000 r-xp /usr/lib/libiri.so
f65a0000 f65e9000 r-xp /usr/lib/libmdm.so.1.2.69
f65f1000 f65f7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65ff000 f6622000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f662c000 f662e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6636000 f6653000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f665c000 f6660000 r-xp /usr/lib/libsmack.so.1.0.0
f6669000 f6682000 r-xp /usr/lib/libnetwork.so.0.0.0
f668b000 f6693000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f669b000 f66a1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66aa000 f66ac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66b5000 f66c5000 r-xp /lib/libresolv-2.13.so
f66c9000 f66e1000 r-xp /usr/lib/liblzma.so.5.0.3
f66ea000 f66ec000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66f4000 f670e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6716000 f6745000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f674e000 f675d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6767000 f6771000 r-xp /usr/lib/libsensord-shared.so
f677a000 f684d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6858000 f686e000 r-xp /lib/libz.so.1.2.5
f6876000 f687b000 r-xp /usr/lib/libffi.so.5.0.10
f6883000 f6884000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f688c000 f689c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68a4000 f68bd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68c5000 f68c7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68cf000 f6944000 r-xp /usr/lib/libsqlite3.so.0.8.6
f694e000 f6954000 r-xp /lib/librt-2.13.so
f695d000 f697b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6985000 f6986000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f698e000 f69b1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69b9000 f69be000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69c6000 f69f0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69f9000 f6a10000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a18000 f6a81000 r-xp /lib/libm-2.13.so
f6a8a000 f6b1e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b31000 f6b36000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b3e000 f6b45000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b4d000 f6b77000 r-xp /usr/lib/libsensor.so.1.9.6
f6b80000 f6c4c000 r-xp /usr/lib/libxml2.so.2.7.8
f6c59000 f6c5b000 r-xp /usr/lib/libiniparser.so.0
f6c64000 f6c6a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c73000 f6d43000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d44000 f6d78000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d81000 f6dbd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dc5000 f6dc8000 r-xp /usr/lib/libbundle.so.0.1.22
f6dd0000 f6dd6000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dde000 f6e1f000 r-xp /usr/lib/libeina.so.1.7.99
f6e28000 f6e3f000 r-xp /usr/lib/libecore.so.1.7.99
f6e56000 f6e5f000 r-xp /usr/lib/libvconf.so.0.2.45
f6e67000 f6e7b000 r-xp /lib/libpthread-2.13.so
f6e86000 f6e93000 r-xp /usr/lib/libaul.so.0.1.0
f6e9d000 f6e9f000 r-xp /lib/libdl-2.13.so
f6ea8000 f6eb3000 r-xp /lib/libunwind.so.8.0.1
f6ee0000 f6ee8000 r-xp /lib/libgcc_s-4.6.so.1
f6ee9000 f700d000 r-xp /lib/libc-2.13.so
f701b000 f701d000 r-xp /usr/lib/libdlog.so.0.0.0
f7025000 f7031000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f703a000 f703f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7047000 f7056000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f705e000 f7062000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f706b000 f706e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7076000 f7078000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7080000 f7084000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f708c000 f70a9000 r-xp /lib/ld-2.13.so
f70b2000 f70b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70b5000 f70b9000 r-xp /usr/lib/libsys-assert.so
f74b8000 f7524000 rw-p [heap]
fff02000 fff23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20895)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf70b32b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf704a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d513f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d9675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d911f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d93e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d94017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d988d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf70820bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4726171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67f9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ca6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ca87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e38ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e33b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e345a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e34879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf706c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf706c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70b36a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6f0085c) [/lib/libc.so.6] + 0x1785c
29: (0xf70b2fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
location_new(269) > method: 1
04-23 15:59:06.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:06.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:06.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:06.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:06.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:06.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:06.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:06.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:06.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:06.851+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:06.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:06.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:06.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:06.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:06.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:06.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:06.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01ef0
04-23 15:59:06.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73441b0]
04-23 15:59:06.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:06.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:06.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:06.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:06.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:06.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:07.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:07.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:07.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:07.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:07.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:07.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:07.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:07.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:07.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:07.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:07.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:07.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:07.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:07.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:07.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:07.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:07.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:07.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:07.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:07.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73441b0
04-23 15:59:07.151+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-23 15:59:07.151+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 15:59:07.151+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.151+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.151+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 15:59:07.151+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-23 15:59:07.151+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 15:59:07.151+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [5842.818641] dpms[3 -> 0]sync[0]
04-23 15:59:07.151+0200 I/TDM     ( 1785): 
04-23 15:59:07.151+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [5842.818761] dpms[0 -> 0]done
04-23 15:59:07.151+0200 I/TDM     ( 1785): 
04-23 15:59:07.151+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -136540160[0;m
04-23 15:59:07.151+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-23 15:59:07.151+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 15:59:07.151+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 15:59:07.161+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 15:59:07.171+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 15:59:07.171+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-23 15:59:07.171+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-23 15:59:07.171+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.171+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.171+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 15:59:07.171+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): gesture.c: _apps_status_get(128) > apps status:0
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:1 info->offtime:73267
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:07.171+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [73267]ms
04-23 15:59:07.171+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-23 15:59:07.171+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: RESUME State: PAUSED
04-23 15:59:07.171+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): main.c: _appcore_resume_cb(479) > appcore resume
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:07.171+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): main.c: home_resume(531) > clock/widget resumed
04-23 15:59:07.171+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 15:59:07.181+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 15:59:07.181+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 15:59:07.181+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 15:59:07.181+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 15:59:07.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 15:59:07.181+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 15:59:07.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -145282292[0;m
04-23 15:59:07.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 15:59:07.181+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 15:59:07.181+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 15:59:07.181+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 15:59:07.191+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 15:59:07.191+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 15:59:07.191+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 15:59:07.191+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(fg) type(watchapp)
04-23 15:59:07.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppResume(560) > 
04-23 15:59:07.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.191+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 15:59:07.191+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 15:59:07.201+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 15:59:07.201+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 15:59:07.201+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 15:59:07.201+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(57), length(2)
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 57%
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 57, isCharging: 0
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_60
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 15:59:07.201+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [5842.880824] layer(0x5ac2c0) not usable
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [5842.880872] layer(0x5ac2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5842.880901] layer[0x5abe10]zpos[1]
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [5842.880961] layer(0x5ac250) not usable
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [5842.880977] layer(0x5ac250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5842.880992] layer[0x5abcf0]zpos[0]
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [5842.881017] layer(0x5ac310) not usable
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [5842.881032] layer(0x5ac310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 15:59:07.221+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5842.881047] layer[0x5abf30]zpos[2]
04-23 15:59:07.281+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 15:59:07.321+0200 W/AUL     (21078): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:59:07.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:07.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:07.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21043
04-23 15:59:07.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:07.341+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21043
04-23 15:59:07.341+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21043)
04-23 15:59:07.371+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 15:59:07.371+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 0
04-23 15:59:07.371+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 15:59:07.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.421+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 15:59:07.421+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 15:59:07.441+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 15:59:07.441+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 15:59:07.451+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 15:59:07.461+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 15:59:07.471+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 15:59:07.481+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 15:59:07.481+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 15:59:07.491+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-23 15:59:07.501+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-23 15:59:07.501+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_period error
04-23 15:59:07.501+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
04-23 15:59:07.501+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
04-23 15:59:07.501+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : inactive_test_mode_on error
04-23 15:59:07.501+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:59:07.511+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:59:07.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:59:07.511+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:59:07.521+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21079
04-23 15:59:07.521+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:59:07.541+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 15:59:07.551+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 15:59:07.571+0200 W/SHealthCommon( 3091): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 15:59:07.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21079
04-23 15:59:07.571+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21079) type(svcapp) bg(0)
04-23 15:59:07.571+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21079]
04-23 15:59:07.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:07.591+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21079)
04-23 15:59:07.591+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:59:07.591+0200 I/servicemanager(19708): App control destroyed.
04-23 15:59:07.601+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.601+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.601+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21079
04-23 15:59:07.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:07.611+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 15:59:07.621+0200 E/CAPI_APPFW_APPLICATION(21079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:07.621+0200 E/CAPI_APPFW_APPLICATION(21079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:07.621+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21079) was created
04-23 15:59:07.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:07.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21079
04-23 15:59:07.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:07.661+0200 W/LOCATION(21079): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:59:07.661+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 15:59:07.671+0200 E/LOCATION(21079): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:59:07.671+0200 E/PKGMGR_INFO(21079): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:59:07.681+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:07.681+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 15:59:07.711+0200 I/LOCATION(21079): location.c: location_new(269) > method: 0
04-23 15:59:07.711+0200 W/LOCATION(21079): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:07.721+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:07.731+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:07.741+0200 W/LOCATION(21079): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:07.751+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:07.751+0200 W/LOCATION(21079): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:07.751+0200 W/LOCATION(21079): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:07.751+0200 W/LOCATION(21079): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:07.751+0200 W/LOCATION(21079): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:07.781+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:07.791+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:07.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:07.791+0200 W/LOCATION(21079): module-internal.c: module_new(311) > module (wps) open success
04-23 15:59:07.811+0200 W/LOCATION(21079): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:59:07.811+0200 W/LOCATION(21079): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:59:07.811+0200 W/LOCATION(21079): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:07.811+0200 W/LOCATION(21079): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:07.851+0200 W/LOCATION(21079): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:59:07.851+0200 I/LOCATION(21079): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75c3c18
04-23 15:59:07.851+0200 I/LOCATION(21079): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:59:07.851+0200 I/LOCATION(21079): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75c3c18
04-23 15:59:07.851+0200 I/LOCATION(21079): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:59:07.861+0200 I/location(21079): es.ugr.frailty.location: creado servicio de localización
04-23 15:59:07.941+0200 I/LOCATION(21079): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:59:07.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:07.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:08.011+0200 W/LOCATION(21079): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:08.011+0200 W/LOCATION(21079): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:08.011+0200 I/LOCATION(21079): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:59:08.091+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:59:08.091+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:08.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:08.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:59:08.091+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:59:08.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:59:08.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:59:08.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:59:08.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:59:08.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:59:08.101+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:59:08.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:59:08.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:59:08.151+0200 W/LOCATION(21079): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:08.151+0200 W/LOCATION(21079): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:08.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.171+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.171+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:59:08.181+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.181+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 15:59:08.181+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 15:59:08.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:08.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 15:59:08.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:08.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:08.201+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 15:59:08.201+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 15:59:08.211+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 15:59:08.211+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 15:59:08.211+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 15:59:08.211+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:59:08.211+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.211+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 15:59:08.211+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 15:59:08.211+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 15:59:08.221+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 15:59:08.221+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 15:59:08.221+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 15:59:08.221+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:59:08.221+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.221+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 15:59:08.221+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 15:59:08.231+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 15:59:08.231+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.231+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:59:08.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:59:08.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:08.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7346018]
04-23 15:59:08.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:08.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:08.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:08.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:08.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:08.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:08.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:08.321+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:08.321+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:08.321+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:08.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:08.321+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:08.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:08.321+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:08.321+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:08.321+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:08.321+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:08.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:08.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:08.341+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:08.351+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:08.371+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:08.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:59:08.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:59:08.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:59:08.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:59:08.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:08.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:08.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:59:08.401+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5844065), time2(5841739)
04-23 15:59:08.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:59:08.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:59:08.401+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:59:08.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:59:08.431+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11208956c6f63152449193
