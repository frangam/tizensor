S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27288
Date: 2018-04-23 16:22:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d252d, r5   = 0xf7282f98
r6   = 0xffec5d80, r7   = 0xffec5c30
r8   = 0xf727fc18, r9   = 0x00000000
r10  = 0xffec5d0c, fp   = 0xffec5d80
ip   = 0x00000001, sp   = 0xffec4ab0
lr   = 0xf70d2539, pc   = 0xf713b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     20820 KB
Buffers:     63840 KB
Cached:     219380 KB
VmPeak:      53560 KB
VmSize:      53556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11884 KB
VmRSS:       11884 KB
VmData:      11284 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27288 TID = 27288
27288 27291 

Maps Information
f3f9d000 f479c000 rw-p [stack:27291]
f47a3000 f47a5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47ad000 f47b1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47ba000 f47bc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47c4000 f47c7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47d6000 f47db000 r-xp /usr/lib/libsystem.so.0.0.0
f47e6000 f47e9000 r-xp /lib/libattr.so.1.1.0
f47f1000 f4801000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4809000 f4812000 r-xp /usr/lib/libedbus.so.1.7.99
f481a000 f481b000 r-xp /usr/lib/libresponse.so.0.2.96
f4824000 f4829000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60cb000 f61d1000 r-xp /usr/lib/libicuuc.so.57.1
f61e7000 f636f000 r-xp /usr/lib/libicui18n.so.57.1
f637f000 f638c000 r-xp /usr/lib/libail.so.0.1.0
f6395000 f639c000 r-xp /usr/lib/libminizip.so.1.0.0
f63a5000 f654e000 r-xp /usr/lib/libcrypto.so.1.0.0
f656e000 f65b5000 r-xp /usr/lib/libssl.so.1.0.0
f65c1000 f65c3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65cb000 f65d2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65db000 f65e2000 r-xp /lib/libcrypt-2.13.so
f6613000 f6616000 r-xp /lib/libcap.so.2.21
f661e000 f6620000 r-xp /usr/lib/libiri.so
f6628000 f6671000 r-xp /usr/lib/libmdm.so.1.2.69
f6679000 f667f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6687000 f66aa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66b4000 f66b6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66be000 f66db000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66e4000 f66e8000 r-xp /usr/lib/libsmack.so.1.0.0
f66f1000 f670a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6713000 f671b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6723000 f6729000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6732000 f6734000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f673d000 f674d000 r-xp /lib/libresolv-2.13.so
f6751000 f6769000 r-xp /usr/lib/liblzma.so.5.0.3
f6772000 f6774000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f677c000 f6796000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f679e000 f67cd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d6000 f67e5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67ef000 f67f9000 r-xp /usr/lib/libsensord-shared.so
f6802000 f68d5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e0000 f68f6000 r-xp /lib/libz.so.1.2.5
f68fe000 f6903000 r-xp /usr/lib/libffi.so.5.0.10
f690b000 f690c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6914000 f6924000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f692c000 f6945000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f694d000 f694f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6957000 f69cc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d6000 f69dc000 r-xp /lib/librt-2.13.so
f69e5000 f6a03000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a0d000 f6a0e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a16000 f6a39000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a41000 f6a46000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4e000 f6a78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a81000 f6a98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aa0000 f6b09000 r-xp /lib/libm-2.13.so
f6b12000 f6ba6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bb9000 f6bbe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bc6000 f6bcd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bd5000 f6bff000 r-xp /usr/lib/libsensor.so.1.9.6
f6c08000 f6cd4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ce1000 f6ce3000 r-xp /usr/lib/libiniparser.so.0
f6cec000 f6cf2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cfb000 f6dcb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dcc000 f6e00000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e09000 f6e45000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e4d000 f6e50000 r-xp /usr/lib/libbundle.so.0.1.22
f6e58000 f6e5e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e66000 f6ea7000 r-xp /usr/lib/libeina.so.1.7.99
f6eb0000 f6ec7000 r-xp /usr/lib/libecore.so.1.7.99
f6ede000 f6ee7000 r-xp /usr/lib/libvconf.so.0.2.45
f6eef000 f6f03000 r-xp /lib/libpthread-2.13.so
f6f0e000 f6f1b000 r-xp /usr/lib/libaul.so.0.1.0
f6f25000 f6f27000 r-xp /lib/libdl-2.13.so
f6f30000 f6f3b000 r-xp /lib/libunwind.so.8.0.1
f6f68000 f6f70000 r-xp /lib/libgcc_s-4.6.so.1
f6f71000 f7095000 r-xp /lib/libc-2.13.so
f70a3000 f70a5000 r-xp /usr/lib/libdlog.so.0.0.0
f70ad000 f70b9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c2000 f70c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70cf000 f70de000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70e6000 f70ea000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f3000 f70f6000 r-xp /usr/lib/libappcore-agent.so.1.1
f70fe000 f7100000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7108000 f710c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7114000 f7131000 r-xp /lib/ld-2.13.so
f713a000 f713d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f713d000 f7141000 r-xp /usr/lib/libsys-assert.so
f724f000 f72db000 rw-p [heap]
ffea7000 ffec8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27288)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf713b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70d2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dd93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6de9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6de9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e1e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e191f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dd7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6de9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6de9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e1be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e1c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e23f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47bb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47ae171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6881663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d2efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d307a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ec0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ebbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ebc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ebc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70f4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70f47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf713b6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf6f8885c) [/lib/libc.so.6] + 0x1785c
29: (0xf713afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
04-23 16:21:05.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:05.751+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:21:05.751+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:21:05.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:05.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:05.751+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:05.751+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:05.751+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:05.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:05.751+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:05.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:21:05.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:05.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27235
04-23 16:21:05.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:05.761+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:21:05.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:05.771+0200 E/CAPI_APPFW_APPLICATION(27235): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:21:05.771+0200 E/CAPI_APPFW_APPLICATION(27235): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:21:05.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:21:05.781+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27235) was created
04-23 16:21:05.801+0200 W/LOCATION(27235): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:21:05.801+0200 E/LOCATION(27235): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:21:05.801+0200 E/PKGMGR_INFO(27235): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:21:05.811+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:05.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:05.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:21:05.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:21:05.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:21:05.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73b0b48
04-23 16:21:05.831+0200 I/LOCATION(27235): location.c: location_new(269) > method: 0
04-23 16:21:05.831+0200 W/LOCATION(27235): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:05.831+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:05.841+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:05.841+0200 W/LOCATION(27235): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:05.851+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:05.851+0200 W/LOCATION(27235): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:05.851+0200 W/LOCATION(27235): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:05.851+0200 W/LOCATION(27235): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:05.851+0200 W/LOCATION(27235): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:05.871+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:21:05.871+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:21:05.881+0200 W/LOCATION(27235): module-internal.c: module_new(311) > module (wps) open success
04-23 16:21:05.881+0200 W/LOCATION(27235): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:21:05.881+0200 W/LOCATION(27235): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:21:05.881+0200 W/LOCATION(27235): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:21:05.881+0200 W/LOCATION(27235): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:21:05.901+0200 W/LOCATION(27235): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:21:05.901+0200 I/LOCATION(27235): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7dc1c18
04-23 16:21:05.901+0200 I/LOCATION(27235): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:21:05.901+0200 I/LOCATION(27235): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7dc1c18
04-23 16:21:05.901+0200 I/LOCATION(27235): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:21:05.901+0200 I/location(27235): es.ugr.frailty.location: creado servicio de localización
04-23 16:21:05.951+0200 I/LOCATION(27235): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:21:06.021+0200 W/LOCATION(27235): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:06.021+0200 W/LOCATION(27235): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:06.021+0200 I/LOCATION(27235): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:21:06.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:21:06.081+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:21:06.081+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:21:06.081+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:06.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:06.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:21:06.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:21:06.091+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:21:06.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:21:06.091+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:21:06.091+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:21:06.091+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:21:06.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:21:06.151+0200 W/LOCATION(27235): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:21:06.151+0200 W/LOCATION(27235): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:21:06.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7376260]
04-23 16:21:06.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:21:06.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:21:06.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:21:06.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:21:06.281+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:06.281+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:06.291+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.311+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:21:06.311+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:21:06.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:06.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:06.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:06.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:06.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:06.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:06.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:06.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.321+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.321+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:21:06.331+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:21:06.361+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(7162023), time2(7159217)
04-23 16:21:06.361+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:21:06.361+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:21:06.361+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:21:06.361+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:21:06.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.401+0200 W/LOCATION(27235): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:21:06.401+0200 I/LOCATION(27235): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:21:06.401+0200 I/LOCATION(27235): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:21:06.401+0200 I/location(27235): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:21:06.491+0200 I/LOCATION(27235): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:21:06.531+0200 E/location(27235): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:21:06.531+0200 W/AUL     (27235): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:21:06.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:21:06.531+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27235
04-23 16:21:06.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:21:06.551+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:21:06.551+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:21:06.551+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.551+0200 I/utils   (26979): specific action
04-23 16:21:06.551+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.551+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.551+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.551+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:21:06.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:21:06.551+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:21:06.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:21:06.561+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:21:06.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:21:06.571+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.571+0200 I/utils   (26984): specific action
04-23 16:21:06.571+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.571+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.571+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.571+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:06.571+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:21:06.571+0200 I/recorder(26984): guardando datos en local
04-23 16:21:06.571+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:21:06.571+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:21:06.571+0200 I/servicemanager(26979): requesting to save local data
04-23 16:21:06.571+0200 W/AUL     (27235): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:21:06.571+0200 I/location(27235): request sent to service es.ugr.frailty.servicemanager
04-23 16:21:06.571+0200 I/location(27235): stopping es.ugr.frailty.location service
04-23 16:21:06.571+0200 E/CAPI_APPFW_APP_CONTROL(27235): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:21:06.571+0200 E/location(27235): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:21:06.571+0200 I/CAPI_APPFW_APPLICATION(27235): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:21:06.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:21:06.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:21:06.611+0200 W/LOCATION(27235): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:21:06.611+0200 I/LOCATION(27235): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:21:06.611+0200 I/LOCATION(27235): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:21:06.681+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:21:06.681+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:21:06.681+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:21:06.681+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:21:06.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:21:06.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:21:06.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:21:06.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7376260
04-23 16:21:06.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01a60]
04-23 16:21:06.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:21:06.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:21:06.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:21:06.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:21:06.871+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:06.871+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:06.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.891+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:21:06.891+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:21:06.891+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:06.891+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:06.891+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:06.891+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:06.891+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:06.891+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:06.891+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:06.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:06.911+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:21:06.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:06.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:07.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:21:07.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:21:07.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:21:07.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01a60
04-23 16:21:07.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7376038]
04-23 16:21:07.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:21:07.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:21:07.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:21:07.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:21:07.091+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:07.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:07.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:07.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:07.111+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:21:07.111+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:21:07.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:07.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:07.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:07.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:07.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:07.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:07.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:07.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:07.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:07.131+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:21:07.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:07.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:07.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:21:07.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:21:07.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:21:07.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7376038
04-23 16:21:07.391+0200 W/AUL     (27249): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:21:07.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:21:07.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:21:07.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27140
04-23 16:21:07.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:21:07.401+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27140
04-23 16:21:07.401+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27140)
04-23 16:21:08.571+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:21:10.771+0200 E/wnoti-ancs( 3002): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][0][1][d][0][0][0][0][0][0][0][0][0][0]
04-23 16:21:13.191+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 188 ms (from 7168670 to 7168858) (logOverhead=0,0,0,0,0,0,0), start: 16:21:13.015
04-23 16:21:13.191+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 188 ms (from 7168670 to 7168858) (logOverhead=0,0,0,0,0,0,0), start: 16:21:13.015
04-23 16:21:16.511+0200 E/wnoti-ancs( 3002): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][0][2][e][0][0][0][0][0][0][0][0][0][0]
04-23 16:21:28.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 7183993 to 7184094) (logOverhead=0,0,0,0,0,0,0), start: 16:21:28.338
04-23 16:21:28.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 7183993 to 7184094) (logOverhead=0,0,0,0,0,0,0), start: 16:21:28.338
04-23 16:21:28.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:21:28.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:21:28.461+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 16:21:28.461+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 2C 4B 03 00 E3 E0 01 E0 AC 03 A5 68)
04-23 16:21:28.461+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:22:05.771+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 16:22:05.771+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:22:05.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:22:05.771+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:22:05.791+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 27288
04-23 16:22:05.791+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:22:05.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27288
04-23 16:22:05.841+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(27288) type(svcapp) bg(0)
04-23 16:22:05.851+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27288)
04-23 16:22:05.861+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27288]
04-23 16:22:05.871+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 16:22:05.881+0200 I/servicemanager(26979): App control destroyed.
04-23 16:22:05.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:22:05.891+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27288
04-23 16:22:05.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:22:05.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:22:05.911+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27288
04-23 16:22:05.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:22:05.931+0200 E/CAPI_APPFW_APPLICATION(27288): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:22:05.931+0200 E/CAPI_APPFW_APPLICATION(27288): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:22:05.931+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27288) was created
04-23 16:22:05.951+0200 W/LOCATION(27288): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:22:05.951+0200 E/LOCATION(27288): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:22:05.951+0200 E/PKGMGR_INFO(27288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:22:05.961+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:05.981+0200 I/LOCATION(27288): location.c: location_new(269) > method: 0
04-23 16:22:05.981+0200 W/LOCATION(27288): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:05.981+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:05.991+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:05.991+0200 W/LOCATION(27288): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:06.001+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:06.001+0200 W/LOCATION(27288): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:06.001+0200 W/LOCATION(27288): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:06.001+0200 W/LOCATION(27288): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:06.001+0200 W/LOCATION(27288): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:06.021+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:22:06.021+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:22:06.031+0200 W/LOCATION(27288): module-internal.c: module_new(311) > module (wps) open success
04-23 16:22:06.031+0200 W/LOCATION(27288): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:22:06.031+0200 W/LOCATION(27288): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:22:06.031+0200 W/LOCATION(27288): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:22:06.031+0200 W/LOCATION(27288): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:22:06.051+0200 W/LOCATION(27288): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:22:06.051+0200 I/LOCATION(27288): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf727fc18
04-23 16:22:06.051+0200 I/LOCATION(27288): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:22:06.051+0200 I/LOCATION(27288): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf727fc18
04-23 16:22:06.051+0200 I/LOCATION(27288): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:22:06.061+0200 I/location(27288): es.ugr.frailty.location: creado servicio de localización
04-23 16:22:06.101+0200 I/LOCATION(27288): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:22:06.141+0200 W/LOCATION(27288): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:06.141+0200 W/LOCATION(27288): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:06.141+0200 I/LOCATION(27288): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:22:06.201+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:22:06.201+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:22:06.201+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:06.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:06.201+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:22:06.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:22:06.201+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:22:06.201+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:22:06.221+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:22:06.231+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:22:06.231+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:22:06.231+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:22:06.231+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:22:06.231+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:22:06.241+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:22:06.251+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:22:06.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:22:06.251+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:22:06.261+0200 W/LOCATION(27288): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:22:06.261+0200 W/LOCATION(27288): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:22:06.261+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:22:06.271+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:22:06.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:22:06.271+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 16:22:06.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:22:06.271+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:22:06.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:22:06.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:22:06.341+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:06.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e23320]
04-23 16:22:06.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:22:06.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:22:06.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:22:06.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:22:06.381+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:06.381+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:06.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:06.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:06.391+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:22:06.391+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:22:06.391+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:06.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:06.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:06.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:06.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:06.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:06.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:06.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:06.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:06.411+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:22:06.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:06.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:06.491+0200 W/LOCATION(27288): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:22:06.491+0200 I/LOCATION(27288): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:22:06.491+0200 I/LOCATION(27288): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:22:06.491+0200 I/location(27288): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:22:06.571+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 7221938 to 7222239) (logOverhead=0,0,0,0,0,0,0), start: 16:22:06.283
04-23 16:22:06.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 308 ms (from 7221935 to 7222243) (logOverhead=0,0,0,0,0,0,0), start: 16:22:06.280
04-23 16:22:06.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 308 ms (from 7221935 to 7222243) (logOverhead=0,0,0,0,0,0,0), start: 16:22:06.280
04-23 16:22:06.611+0200 I/LOCATION(27288): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:22:06.671+0200 E/location(27288): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:22:06.671+0200 W/AUL     (27288): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:22:06.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:22:06.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27288
04-23 16:22:06.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:22:06.691+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.691+0200 I/utils   (26979): specific action
04-23 16:22:06.691+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.691+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.691+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.691+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:22:06.691+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:22:06.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:22:06.691+0200 W/AUL     (27288): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:22:06.691+0200 I/location(27288): request sent to service es.ugr.frailty.servicemanager
04-23 16:22:06.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:22:06.691+0200 W/CAPI_APPFW_APP_CONTROL(27288): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.691+0200 I/utils   (27288): specific action
04-23 16:22:06.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:22:06.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:22:06.701+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.701+0200 I/utils   (26984): specific action
04-23 16:22:06.701+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.701+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.701+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:22:06.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:22:06.711+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:06.711+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:22:06.711+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:22:06.711+0200 I/servicemanager(26979): requesting to save local data
04-23 16:22:06.711+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:22:06.711+0200 I/recorder(26984): guardando datos en local
04-23 16:22:06.831+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:22:06.831+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(7222493), time2(7159217)
04-23 16:22:06.831+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:22:06.831+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:22:06.831+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:22:06.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:22:07.391+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 139 ms (from 7222914 to 7223053) (logOverhead=0,0,0,0,0,0,0), start: 16:22:07.259
04-23 16:22:07.391+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 139 ms (from 7222914 to 7223053) (logOverhead=0,0,0,0,0,0,0), start: 16:22:07.259
04-23 16:22:07.431+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:22:07.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:07.431+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:22:07.551+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:22:08.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:22:08.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:08.281+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:22:08.511+0200 W/LOCATION(27288): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:22:08.761+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:22:08.761+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:22:08.761+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:22:08.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:22:08.781+0200 W/AUL     (27305): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:22:08.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:22:08.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:22:08.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27207
04-23 16:22:08.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:22:08.791+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27207
04-23 16:22:08.791+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27207)
04-23 16:22:08.801+0200 W/CRASH_MANAGER(27301): worker.c: worker_job(1205) > 11272886c6f63152449332
