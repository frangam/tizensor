S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13179
Date: 2018-04-23 20:43:33+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf729e52d, r5   = 0xf75dbf98
r6   = 0xfff75090, r7   = 0xfff74f40
r8   = 0xf75d8c18, r9   = 0x00000000
r10  = 0xfff7501c, fp   = 0xfff75090
ip   = 0x00000001, sp   = 0xfff74f18
lr   = 0xf729e539, pc   = 0xf7307228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    132380 KB
Buffers:     41312 KB
Cached:     158136 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11900 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13179 TID = 13179
13179 13182 

Maps Information
f4169000 f4968000 rw-p [stack:13182]
f496f000 f4971000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4979000 f497d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4986000 f4988000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4990000 f4993000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49a2000 f49a7000 r-xp /usr/lib/libsystem.so.0.0.0
f49b2000 f49b5000 r-xp /lib/libattr.so.1.1.0
f49bd000 f49cd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49d5000 f49de000 r-xp /usr/lib/libedbus.so.1.7.99
f49e6000 f49e7000 r-xp /usr/lib/libresponse.so.0.2.96
f49f0000 f49f5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6297000 f639d000 r-xp /usr/lib/libicuuc.so.57.1
f63b3000 f653b000 r-xp /usr/lib/libicui18n.so.57.1
f654b000 f6558000 r-xp /usr/lib/libail.so.0.1.0
f6561000 f6568000 r-xp /usr/lib/libminizip.so.1.0.0
f6571000 f671a000 r-xp /usr/lib/libcrypto.so.1.0.0
f673a000 f6781000 r-xp /usr/lib/libssl.so.1.0.0
f678d000 f678f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6797000 f679e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67a7000 f67ae000 r-xp /lib/libcrypt-2.13.so
f67df000 f67e2000 r-xp /lib/libcap.so.2.21
f67ea000 f67ec000 r-xp /usr/lib/libiri.so
f67f4000 f683d000 r-xp /usr/lib/libmdm.so.1.2.69
f6845000 f684b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6853000 f6876000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6880000 f6882000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f688a000 f68a7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68b0000 f68b4000 r-xp /usr/lib/libsmack.so.1.0.0
f68bd000 f68d6000 r-xp /usr/lib/libnetwork.so.0.0.0
f68df000 f68e7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68ef000 f68f5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68fe000 f6900000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6909000 f6919000 r-xp /lib/libresolv-2.13.so
f691d000 f6935000 r-xp /usr/lib/liblzma.so.5.0.3
f693e000 f6940000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6948000 f6962000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f696a000 f6999000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69a2000 f69b1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69bb000 f69c5000 r-xp /usr/lib/libsensord-shared.so
f69ce000 f6aa1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aac000 f6ac2000 r-xp /lib/libz.so.1.2.5
f6aca000 f6acf000 r-xp /usr/lib/libffi.so.5.0.10
f6ad7000 f6ad8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ae0000 f6af0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6af8000 f6b11000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b19000 f6b1b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b23000 f6b98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ba2000 f6ba8000 r-xp /lib/librt-2.13.so
f6bb1000 f6bcf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bd9000 f6bda000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6be2000 f6c05000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c0d000 f6c12000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c1a000 f6c44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c4d000 f6c64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c6c000 f6cd5000 r-xp /lib/libm-2.13.so
f6cde000 f6d72000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d85000 f6d8a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d92000 f6d99000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6da1000 f6dcb000 r-xp /usr/lib/libsensor.so.1.9.6
f6dd4000 f6ea0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ead000 f6eaf000 r-xp /usr/lib/libiniparser.so.0
f6eb8000 f6ebe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ec7000 f6f97000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f98000 f6fcc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fd5000 f7011000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7019000 f701c000 r-xp /usr/lib/libbundle.so.0.1.22
f7024000 f702a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7032000 f7073000 r-xp /usr/lib/libeina.so.1.7.99
f707c000 f7093000 r-xp /usr/lib/libecore.so.1.7.99
f70aa000 f70b3000 r-xp /usr/lib/libvconf.so.0.2.45
f70bb000 f70cf000 r-xp /lib/libpthread-2.13.so
f70da000 f70e7000 r-xp /usr/lib/libaul.so.0.1.0
f70f1000 f70f3000 r-xp /lib/libdl-2.13.so
f70fc000 f7107000 r-xp /lib/libunwind.so.8.0.1
f7134000 f713c000 r-xp /lib/libgcc_s-4.6.so.1
f713d000 f7261000 r-xp /lib/libc-2.13.so
f726f000 f7271000 r-xp /usr/lib/libdlog.so.0.0.0
f7279000 f7285000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f728e000 f7293000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f729b000 f72aa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72b2000 f72b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72bf000 f72c2000 r-xp /usr/lib/libappcore-agent.so.1.1
f72ca000 f72cc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72d4000 f72d8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72e0000 f72fd000 r-xp /lib/ld-2.13.so
f7306000 f7309000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7309000 f730d000 r-xp /usr/lib/libsys-assert.so
f75a8000 f7616000 rw-p [heap]
fff56000 fff77000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13179)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7307228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf729e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fa53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fa3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fafe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fb5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fb5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fea75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fe51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fa3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fafe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fb5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fb5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fe7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fe8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6feff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49871fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf497a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a4d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6efafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6efc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf708cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7087b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70885a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7088879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72c0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72c07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73075c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf715485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7306f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:30.329+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.594534] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:43:30.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13179
04-23 20:43:30.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:30.359+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.628234] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:30.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:30.399+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.661932] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.409+0200 E/CAPI_APPFW_APPLICATION(13179): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:30.409+0200 E/CAPI_APPFW_APPLICATION(13179): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:30.409+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (13179) was created
04-23 20:43:30.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.693520] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.449+0200 W/LOCATION(13179): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:43:30.449+0200 E/LOCATION(13179): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:43:30.449+0200 E/PKGMGR_INFO(13179): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:43:30.459+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.725863] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.459+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:30.489+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.758864] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.499+0200 I/LOCATION(13179): location.c: location_new(269) > method: 0
04-23 20:43:30.499+0200 W/LOCATION(13179): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:30.509+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:30.509+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:30.519+0200 W/LOCATION(13179): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:30.519+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:30.529+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.794536] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.539+0200 W/LOCATION(13179): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:30.539+0200 W/LOCATION(13179): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:30.539+0200 W/LOCATION(13179): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:30.539+0200 W/LOCATION(13179): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:30.559+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.826614] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.569+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:30.579+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:30.579+0200 W/LOCATION(13179): module-internal.c: module_new(311) > module (wps) open success
04-23 20:43:30.579+0200 W/LOCATION(13179): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:43:30.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:30.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:30.599+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.860678] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.599+0200 W/LOCATION(13179): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:43:30.599+0200 W/LOCATION(13179): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:30.599+0200 W/LOCATION(13179): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:30.629+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.894690] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.639+0200 W/LOCATION(13179): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:43:30.639+0200 I/LOCATION(13179): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75d8c18
04-23 20:43:30.639+0200 I/LOCATION(13179): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:43:30.639+0200 I/LOCATION(13179): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75d8c18
04-23 20:43:30.639+0200 I/LOCATION(13179): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:43:30.639+0200 I/location(13179): es.ugr.frailty.location: creado servicio de localización
04-23 20:43:30.659+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.926593] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.699+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.964495] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.729+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3085.995277] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.759+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.027932] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.769+0200 I/LOCATION(13179): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:43:30.789+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:30.789+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:30.799+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.063123] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.829+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.095032] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.849+0200 W/LOCATION(13179): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:30.849+0200 W/LOCATION(13179): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:30.849+0200 I/LOCATION(13179): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:30.859+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.129202] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.889+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.159796] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.929+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.194732] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.959+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.227428] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:43:30.989+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:43:30.989+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:30.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:30.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:43:30.989+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:43:30.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:43:30.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:43:30.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:43:30.989+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:30.989+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:30.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:43:30.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:43:30.999+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:43:30.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:43:30.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:43:31.009+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.273131] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.029+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.297171] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.059+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.327606] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.099+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.360428] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.109+0200 W/LOCATION(13179): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:31.109+0200 W/LOCATION(13179): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:31.119+0200 W/AUL_AMD ( 2481): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-23 20:43:31.119+0200 W/AUL_AMD ( 2481): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-23 20:43:31.129+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.397327] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.159+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.427702] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.189+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:31.189+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:31.199+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.463144] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.229+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.494764] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.229+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:43:31.229+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3086497), time2(3072846)
04-23 20:43:31.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:43:31.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:43:31.229+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:43:31.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:43:31.259+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.527816] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:31.309+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.569992] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.329+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.596689] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.359+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.628088] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.379+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4204228]
04-23 20:43:31.379+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:43:31.379+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:43:31.379+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:43:31.379+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:43:31.379+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:31.379+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:31.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:31.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:31.399+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.662718] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.409+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:31.419+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:31.419+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:43:31.419+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:43:31.419+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:31.419+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:31.419+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:31.419+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:31.419+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:31.419+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:31.419+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:31.429+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:31.429+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:31.429+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:43:31.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.699738] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:31.459+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.728058] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:31.499+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.762336] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.499+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][4][1][b][0][0][0][0][0][0][0][0][0][0]
04-23 20:43:31.529+0200 W/LOCATION(13179): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:43:31.529+0200 I/LOCATION(13179): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:31.529+0200 I/LOCATION(13179): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:31.529+0200 I/location(13179): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:43:31.529+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.796301] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.559+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.828794] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:31.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:31.599+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.861528] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.629+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.898711] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.639+0200 I/LOCATION(13179): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:31.659+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.929462] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.689+0200 I/location(13179): es.ugr.frailty.location: waiting for rigth values
04-23 20:43:31.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:31.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:31.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:31.699+0200 W/CAPI_APPFW_APP_CONTROL(13179): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:43:31.699+0200 I/utils   (13179): specific action
04-23 20:43:31.699+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.967246] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.729+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3086.995157] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.769+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.031490] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.799+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.062709] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.799+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:31.799+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:31.829+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.096202] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.869+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.131337] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.899+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.163143] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.929+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.196817] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.969+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.230888] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.999+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.263007] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:31.999+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:31.999+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.029+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.296500] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.069+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.333562] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.099+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.365394] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.129+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.396830] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.169+0200 E/WMS     ( 2467): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
04-23 20:43:32.169+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.435859] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.179+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x1e00003
04-23 20:43:32.179+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1600002
04-23 20:43:32.179+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
04-23 20:43:32.179+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
04-23 20:43:32.179+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
04-23 20:43:32.179+0200 E/STARTER ( 2705): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
04-23 20:43:32.179+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
04-23 20:43:32.179+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
04-23 20:43:32.179+0200 E/EFL     ( 2750): ecore_x<2750> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3087432
04-23 20:43:32.179+0200 W/W_HOME  ( 2750): main.c: _direct_home_key_cb(1447) > was_win_on_top:0
04-23 20:43:32.199+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.463748] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.199+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.199+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.229+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.496785] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.269+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.531987] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.299+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.569453] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.329+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.597348] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.369+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.632769] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.389+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1600002
04-23 20:43:32.389+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00003
04-23 20:43:32.389+0200 W/STARTER ( 2705): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
04-23 20:43:32.389+0200 E/EFL     ( 2750): ecore_x<2750> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3087654
04-23 20:43:32.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.399+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.665558] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.696940] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.439+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:43:32.469+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.731015] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.479+0200 W/W_INDICATOR( 2710): windicator_moment_view.c: windicator_moment_view_battery_disp_timer_cb(737) > [windicator_moment_view_battery_disp_timer_cb:737] [CHARGING_UI] windicator_moment_view_battery_disp_timer_cb
04-23 20:43:32.499+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.761249] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.509+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.771978] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.519+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.788870] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.539+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.806401] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.559+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.822234] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.569+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.838855] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.589+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.855677] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.589+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.589+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.609+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.872418] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.619+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.889021] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.639+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.905760] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.649+0200 W/STARTER ( 2705): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
04-23 20:43:32.649+0200 W/STARTER ( 2705): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
04-23 20:43:32.649+0200 E/STARTER ( 2705): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
04-23 20:43:32.649+0200 W/AUL     ( 2705): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-23 20:43:32.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:43:32.649+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 2705
04-23 20:43:32.659+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.922450] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.659+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2750) type(uiapp) bg(0)
04-23 20:43:32.659+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2750
04-23 20:43:32.659+0200 I/APP_CORE( 2750): appcore-efl.c: __do_app(453) > [APP 2750] Event: RESET State: RUNNING
04-23 20:43:32.659+0200 I/CAPI_APPFW_APPLICATION( 2750): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-23 20:43:32.659+0200 W/CAPI_APPFW_APP_CONTROL( 2750): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:43:32.659+0200 W/W_HOME  ( 2750): main.c: _app_control_progress(1571) > Service value : powerkey
04-23 20:43:32.659+0200 W/wnotib  ( 2750): w-notification-board-broker-main.c: _wnb_handle_view_event(1289) > Home view event: 0x40001
04-23 20:43:32.659+0200 E/wnotib  ( 2750): w-notification-board-action.c: wnb_action_is_popup_shown(4767) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-23 20:43:32.659+0200 E/wnotib  ( 2750): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-23 20:43:32.659+0200 W/wnotib  ( 2750): w-notification-board-broker-main.c: wnb_dismiss_confirmation_popup(1405) > 
04-23 20:43:32.659+0200 W/W_HOME  ( 2750): noti_broker.c: _noti_broker_home_cb(786) > continue the home key execution
04-23 20:43:32.659+0200 E/W_HOME  ( 2750): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
04-23 20:43:32.659+0200 W/W_HOME  ( 2750): main.c: _home_key_cb(1469) > Home Key operation tutorial:0 window:0 clock:1 apps:0 is_app_resumed:1
04-23 20:43:32.659+0200 E/W_HOME  ( 2750): move.c: move_back_to_home_no_anim(270) > home is already on position
04-23 20:43:32.659+0200 I/APP_CORE( 2750): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-23 20:43:32.659+0200 W/W_HOME  ( 2750): dbus_util.c: home_dbus_home_raise_signal_send(298) > Sending HOME RAISE signal, result:0
04-23 20:43:32.659+0200 W/W_HOME  ( 2750): main.c: _resume_cb(444) > resumed already
04-23 20:43:32.659+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(2750), cmd(0)
04-23 20:43:32.669+0200 W/AUL     ( 2705): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2750)
04-23 20:43:32.669+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [2750]
04-23 20:43:32.669+0200 E/AUL     ( 2481): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-23 20:43:32.669+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.939140] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:32.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:32.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:32.689+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.956082] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.709+0200 E/AUL     ( 2705): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-23 20:43:32.709+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.972508] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.719+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3087.989625] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.739+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.006046] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.769+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.031192] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.789+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.789+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.799+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.065523] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.799+0200 W/W_INDICATOR( 2710): windicator_moment_view.c: _charging_ui_fade_out_end_cb(246) > [_charging_ui_fade_out_end_cb:246] Fade out end. Call moment_view_hide
04-23 20:43:32.809+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.077470] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.819+0200 E/W_INDICATOR( 2710): windicator_moment_view.c: windicator_moment_view_hide(1050) > [windicator_moment_view_hide:1050] Hide Moment View , Type(1)
04-23 20:43:32.819+0200 W/PROCESSMGR( 2311): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-23 20:43:32.829+0200 W/WATCH_CORE( 2851): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-23 20:43:32.829+0200 I/WATCH_CORE( 2851): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-23 20:43:32.829+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.829+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.829+0200 W/W_HOME  ( 2750): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-23 20:43:32.829+0200 W/W_HOME  ( 2750): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 20:43:32.829+0200 W/W_HOME  ( 2750): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 20:43:32.829+0200 W/W_HOME  ( 2750): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 20:43:32.829+0200 W/W_HOME  ( 2750): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-23 20:43:32.829+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.099900] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.839+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.109615] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.869+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.132527] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(23), length(2)
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 23%
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 23, isCharging: 1
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_charging_level_25
04-23 20:43:32.879+0200 W/W_INDICATOR( 2710): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 20:43:32.879+0200 I/APP_CORE( 2710): appcore-efl.c: __do_app(453) > [APP 2710] Event: PAUSE State: RUNNING
04-23 20:43:32.879+0200 I/CAPI_APPFW_APPLICATION( 2710): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 20:43:32.899+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.164542] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.909+0200 W/W_INDICATOR( 2710): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 20:43:32.929+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.197454] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.969+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.230382] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:32.989+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:32.989+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:32.999+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.265791] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.029+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.297253] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.069+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.331624] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.099+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.364554] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.129+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.397393] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.169+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.432557] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.199+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:33.199+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:33.209+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.474639] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.209+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x1e00003
04-23 20:43:33.209+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1600002
04-23 20:43:33.219+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
04-23 20:43:33.219+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
04-23 20:43:33.219+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
04-23 20:43:33.219+0200 W/LOCATION(13179): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:43:33.219+0200 E/STARTER ( 2705): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
04-23 20:43:33.219+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
04-23 20:43:33.219+0200 W/STARTER ( 2705): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
04-23 20:43:33.219+0200 E/EFL     ( 2750): ecore_x<2750> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3088478
04-23 20:43:33.219+0200 W/W_HOME  ( 2750): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
04-23 20:43:33.229+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.499732] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.269+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.532600] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.299+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.565256] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.329+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.597638] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.339+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:43:33.339+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:43:33.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:43:33.349+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:43:33.349+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13179
04-23 20:43:33.359+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13179)
04-23 20:43:33.359+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:43:33.359+0200 I/servicemanager(12059): App control destroyed.
04-23 20:43:33.369+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.632931] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.389+0200 I/CAPI_WATCH_APPLICATION( 2851): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 20:43:33.389+0200 E/watchface-loader( 2851): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 20:43:33.399+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.665854] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.399+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1600002
04-23 20:43:33.399+0200 W/KEYROUTER( 2311): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00003
04-23 20:43:33.409+0200 W/STARTER ( 2705): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
04-23 20:43:33.409+0200 E/EFL     ( 2750): ecore_x<2750> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3088667
04-23 20:43:33.429+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.698390] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.469+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.733921] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.509+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.773962] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.529+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.798301] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.569+0200 I/TDM     ( 1952): tdm_pp.c: tdm_pp_set_info(322) > [3088.833123] pp(0x3ef1b0) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 20:43:33.579+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11131796c6f63152450901
