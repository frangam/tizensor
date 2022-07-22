S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30925
Date: 2018-04-23 17:34:31+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf706e52d, r5   = 0xf72a3f98
r6   = 0xffc3e090, r7   = 0xffc3df40
r8   = 0xf72a0c18, r9   = 0x00000000
r10  = 0xffc3e01c, fp   = 0xffc3e090
ip   = 0x00000001, sp   = 0xffc3cdc0
lr   = 0xf706e539, pc   = 0xf70d72b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     21504 KB
Buffers:     66712 KB
Cached:     213812 KB
VmPeak:      53460 KB
VmSize:      53428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12212 KB
VmRSS:       12212 KB
VmData:      11156 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30925 TID = 30925
30925 30928 

Maps Information
f3f39000 f4738000 rw-p [stack:30928]
f473f000 f4741000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4749000 f474d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4756000 f4758000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4760000 f4763000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4772000 f4777000 r-xp /usr/lib/libsystem.so.0.0.0
f4782000 f4785000 r-xp /lib/libattr.so.1.1.0
f478d000 f479d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47a5000 f47ae000 r-xp /usr/lib/libedbus.so.1.7.99
f47b6000 f47b7000 r-xp /usr/lib/libresponse.so.0.2.96
f47c0000 f47c5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6067000 f616d000 r-xp /usr/lib/libicuuc.so.57.1
f6183000 f630b000 r-xp /usr/lib/libicui18n.so.57.1
f631b000 f6328000 r-xp /usr/lib/libail.so.0.1.0
f6331000 f6338000 r-xp /usr/lib/libminizip.so.1.0.0
f6341000 f64ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f650a000 f6551000 r-xp /usr/lib/libssl.so.1.0.0
f655d000 f655f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6567000 f656e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6577000 f657e000 r-xp /lib/libcrypt-2.13.so
f65af000 f65b2000 r-xp /lib/libcap.so.2.21
f65ba000 f65bc000 r-xp /usr/lib/libiri.so
f65c4000 f660d000 r-xp /usr/lib/libmdm.so.1.2.69
f6615000 f661b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6623000 f6646000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6650000 f6652000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f665a000 f6677000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6680000 f6684000 r-xp /usr/lib/libsmack.so.1.0.0
f668d000 f66a6000 r-xp /usr/lib/libnetwork.so.0.0.0
f66af000 f66b7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66bf000 f66c5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66ce000 f66d0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66d9000 f66e9000 r-xp /lib/libresolv-2.13.so
f66ed000 f6705000 r-xp /usr/lib/liblzma.so.5.0.3
f670e000 f6710000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6718000 f6732000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f673a000 f6769000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6772000 f6781000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f678b000 f6795000 r-xp /usr/lib/libsensord-shared.so
f679e000 f6871000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f687c000 f6892000 r-xp /lib/libz.so.1.2.5
f689a000 f689f000 r-xp /usr/lib/libffi.so.5.0.10
f68a7000 f68a8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68b0000 f68c0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68c8000 f68e1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68e9000 f68eb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68f3000 f6968000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6972000 f6978000 r-xp /lib/librt-2.13.so
f6981000 f699f000 r-xp /usr/lib/libsystemd.so.0.4.0
f69a9000 f69aa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69b2000 f69d5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69dd000 f69e2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69ea000 f6a14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a1d000 f6a34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a3c000 f6aa5000 r-xp /lib/libm-2.13.so
f6aae000 f6b42000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b55000 f6b5a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b62000 f6b69000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b71000 f6b9b000 r-xp /usr/lib/libsensor.so.1.9.6
f6ba4000 f6c70000 r-xp /usr/lib/libxml2.so.2.7.8
f6c7d000 f6c7f000 r-xp /usr/lib/libiniparser.so.0
f6c88000 f6c8e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c97000 f6d67000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d68000 f6d9c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6da5000 f6de1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6de9000 f6dec000 r-xp /usr/lib/libbundle.so.0.1.22
f6df4000 f6dfa000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e02000 f6e43000 r-xp /usr/lib/libeina.so.1.7.99
f6e4c000 f6e63000 r-xp /usr/lib/libecore.so.1.7.99
f6e7a000 f6e83000 r-xp /usr/lib/libvconf.so.0.2.45
f6e8b000 f6e9f000 r-xp /lib/libpthread-2.13.so
f6eaa000 f6eb7000 r-xp /usr/lib/libaul.so.0.1.0
f6ec1000 f6ec3000 r-xp /lib/libdl-2.13.so
f6ecc000 f6ed7000 r-xp /lib/libunwind.so.8.0.1
f6f04000 f6f0c000 r-xp /lib/libgcc_s-4.6.so.1
f6f0d000 f7031000 r-xp /lib/libc-2.13.so
f703f000 f7041000 r-xp /usr/lib/libdlog.so.0.0.0
f7049000 f7055000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f705e000 f7063000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f706b000 f707a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7082000 f7086000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f708f000 f7092000 r-xp /usr/lib/libappcore-agent.so.1.1
f709a000 f709c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70a4000 f70a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70b0000 f70cd000 r-xp /lib/ld-2.13.so
f70d6000 f70d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70d9000 f70dd000 r-xp /usr/lib/libsys-assert.so
f7270000 f72da000 rw-p [heap]
ffc1f000 ffc40000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30925)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf70d72b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf706e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6db51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d73c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d7fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d85be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d85dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6db7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6db8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dbff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf474a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf681d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ccafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ccc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e5cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e57b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e58879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7090183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70d76c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf6f2485c) [/lib/libc.so.6] + 0x1785c
29: (0xf70d6fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
38) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:33:32.511+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30877
04-23 17:33:32.511+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(30877) type(svcapp) bg(0)
04-23 17:33:32.511+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30877)
04-23 17:33:32.511+0200 I/servicemanager(30105): es.ugr.frailty.location stop request sent!
04-23 17:33:32.511+0200 I/servicemanager(30105): App control destroyed.
04-23 17:33:32.511+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30877]
04-23 17:33:32.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:33:32.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30877
04-23 17:33:32.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:33:32.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:33:32.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30877
04-23 17:33:32.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:33:32.611+0200 E/CAPI_APPFW_APPLICATION(30877): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:33:32.611+0200 E/CAPI_APPFW_APPLICATION(30877): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:33:32.611+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (30877) was created
04-23 17:33:32.631+0200 W/LOCATION(30877): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:33:32.631+0200 E/LOCATION(30877): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:33:32.641+0200 E/PKGMGR_INFO(30877): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:33:32.641+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:32.661+0200 I/LOCATION(30877): location.c: location_new(269) > method: 0
04-23 17:33:32.661+0200 W/LOCATION(30877): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:32.671+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:32.671+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:32.671+0200 W/LOCATION(30877): module-internal.c: module_new(311) > module (gps) open success
04-23 17:33:32.681+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:33:32.681+0200 W/LOCATION(30877): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:33:32.681+0200 W/LOCATION(30877): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:32.681+0200 W/LOCATION(30877): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:33:32.681+0200 W/LOCATION(30877): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:33:32.701+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:33:32.711+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:33:32.711+0200 W/LOCATION(30877): module-internal.c: module_new(311) > module (wps) open success
04-23 17:33:32.711+0200 W/LOCATION(30877): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:33:32.721+0200 W/LOCATION(30877): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:33:32.721+0200 W/LOCATION(30877): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:33:32.721+0200 W/LOCATION(30877): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:33:32.741+0200 W/LOCATION(30877): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:33:32.741+0200 I/LOCATION(30877): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf769dc18
04-23 17:33:32.741+0200 I/LOCATION(30877): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:33:32.741+0200 I/LOCATION(30877): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf769dc18
04-23 17:33:32.741+0200 I/LOCATION(30877): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:33:32.741+0200 I/location(30877): es.ugr.frailty.location: creado servicio de localización
04-23 17:33:32.791+0200 I/LOCATION(30877): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:33:32.851+0200 W/LOCATION(30877): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:33:32.851+0200 W/LOCATION(30877): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:33:32.851+0200 I/LOCATION(30877): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:33:32.941+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:33:32.941+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:33:32.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:33:32.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:33:32.941+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:33:32.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:33:32.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:33:32.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:33:32.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:33:32.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:33:32.951+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:33:32.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:33:32.951+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:33:33.001+0200 W/LOCATION(30877): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:33:33.001+0200 W/LOCATION(30877): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:33:33.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:33.131+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e912c8]
04-23 17:33:33.131+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:33:33.131+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:33:33.131+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:33:33.131+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:33:33.131+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:33.131+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:33.141+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.151+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.151+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:33:33.151+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:33:33.151+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:33.151+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:33:33.151+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:33:33.151+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:33:33.151+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:33.151+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:33:33.151+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:33:33.161+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.171+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.171+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:33:33.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:33.191+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:33:33.191+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(11508853), time2(11505578)
04-23 17:33:33.191+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 17:33:33.191+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:33:33.191+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:33:33.191+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:33:33.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:33.251+0200 W/LOCATION(30877): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:33:33.251+0200 I/LOCATION(30877): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:33:33.251+0200 I/LOCATION(30877): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:33:33.251+0200 I/location(30877): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:33:33.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:33:33.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 17:33:33.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 17:33:33.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:33:33.391+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:33:33.401+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.401+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.401+0200 E/LOCATION(30823): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 17:33:33.401+0200 I/LOCATION(30823): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 17:33:33.401+0200 I/LOCATION(30823): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:33:33.421+0200 I/LOCATION(30877): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:33:33.481+0200 E/location(30877): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:33:33.481+0200 W/AUL     (30877): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:33:33.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:33:33.481+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30877
04-23 17:33:33.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:33:33.501+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:33:33.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:33:33.501+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.501+0200 I/utils   (30105): specific action
04-23 17:33:33.501+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.501+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.501+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.501+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:33:33.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:33:33.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:33:33.511+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:33:33.511+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:33:33.511+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:33:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.511+0200 I/utils   (30110): specific action
04-23 17:33:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:33:33.511+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:33:33.511+0200 I/recorder(30110): guardando datos en local
04-23 17:33:33.511+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:33:33.511+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:33:33.511+0200 I/servicemanager(30105): requesting to save local data
04-23 17:33:33.521+0200 W/AUL     (30877): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:33:33.521+0200 I/location(30877): request sent to service es.ugr.frailty.servicemanager
04-23 17:33:33.521+0200 I/location(30877): stopping es.ugr.frailty.location service
04-23 17:33:33.521+0200 E/CAPI_APPFW_APP_CONTROL(30877): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:33:33.521+0200 E/location(30877): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:33:33.521+0200 I/CAPI_APPFW_APPLICATION(30877): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:33:33.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:33:33.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:33:33.561+0200 W/LOCATION(30877): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:33:33.561+0200 I/LOCATION(30877): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:33:33.561+0200 I/LOCATION(30877): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 17:33:33.641+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:33:33.641+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:33:33.641+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:33:33.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:33:33.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:33.831+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:33:33.831+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:33:33.831+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:33:33.831+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e912c8
04-23 17:33:33.891+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e8cab0]
04-23 17:33:33.891+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:33:33.891+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:33:33.891+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:33:33.891+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:33:33.891+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:33.891+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:33.901+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.911+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.911+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:33:33.911+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:33:33.911+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:33.911+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:33:33.911+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:33:33.911+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:33:33.911+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:33.911+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:33:33.911+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:33:33.921+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.931+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:33.931+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:33:33.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:33.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:34.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:34.071+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:33:34.071+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:33:34.071+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:33:34.071+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e8cab0
04-23 17:33:34.091+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e79cc8]
04-23 17:33:34.091+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:33:34.091+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:33:34.091+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:33:34.091+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:33:34.101+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:34.101+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:34.111+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:34.121+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:34.121+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:33:34.121+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:33:34.121+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:33:34.121+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:33:34.121+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:33:34.121+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:33:34.121+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:33:34.121+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:33:34.121+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:33:34.141+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:34.141+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:33:34.141+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:33:34.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:34.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:33:34.191+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:33:34.191+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:33:34.201+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:33:34.201+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e79cc8
04-23 17:33:34.391+0200 W/AUL     (30891): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:33:34.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:33:34.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:33:34.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30832
04-23 17:33:34.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:33:34.391+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30832
04-23 17:33:34.391+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30832)
04-23 17:33:35.521+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:33:55.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 11530990 to 11531091) (logOverhead=0,0,0,0,0,0,0), start: 17:33:55.335
04-23 17:33:55.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 11530990 to 11531091) (logOverhead=0,0,0,0,0,0,0), start: 17:33:55.336
04-23 17:33:55.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:33:55.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:33:55.461+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:33:55.461+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 1F B1 03 00 CD E0 01 E0 EF 03 A5 68)
04-23 17:33:55.461+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:29.381+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:34:29.381+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:34:29.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:34:29.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:34:29.411+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 30925
04-23 17:34:29.411+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:34:29.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30925
04-23 17:34:29.461+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(30925) type(svcapp) bg(0)
04-23 17:34:29.471+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30925]
04-23 17:34:29.481+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30925)
04-23 17:34:29.481+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:34:29.481+0200 I/servicemanager(30105): App control destroyed.
04-23 17:34:29.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:34:29.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30925
04-23 17:34:29.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:34:29.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30925
04-23 17:34:29.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:34:29.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:34:29.531+0200 E/CAPI_APPFW_APPLICATION(30925): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:34:29.531+0200 E/CAPI_APPFW_APPLICATION(30925): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:34:29.531+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (30925) was created
04-23 17:34:29.561+0200 W/LOCATION(30925): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:34:29.561+0200 E/LOCATION(30925): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:34:29.561+0200 E/PKGMGR_INFO(30925): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:34:29.561+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:29.581+0200 I/LOCATION(30925): location.c: location_new(269) > method: 0
04-23 17:34:29.581+0200 W/LOCATION(30925): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:29.581+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:29.591+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:29.591+0200 W/LOCATION(30925): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:29.601+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:29.601+0200 W/LOCATION(30925): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:29.601+0200 W/LOCATION(30925): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:29.601+0200 W/LOCATION(30925): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:29.601+0200 W/LOCATION(30925): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:29.621+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:34:29.631+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:34:29.631+0200 W/LOCATION(30925): module-internal.c: module_new(311) > module (wps) open success
04-23 17:34:29.631+0200 W/LOCATION(30925): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:34:29.641+0200 W/LOCATION(30925): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:34:29.641+0200 W/LOCATION(30925): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:34:29.641+0200 W/LOCATION(30925): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:34:29.651+0200 W/LOCATION(30925): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:34:29.651+0200 I/LOCATION(30925): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72a0c18
04-23 17:34:29.651+0200 I/LOCATION(30925): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:34:29.651+0200 I/LOCATION(30925): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72a0c18
04-23 17:34:29.651+0200 I/LOCATION(30925): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:34:29.661+0200 I/location(30925): es.ugr.frailty.location: creado servicio de localización
04-23 17:34:29.701+0200 I/LOCATION(30925): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:34:29.741+0200 W/LOCATION(30925): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:29.741+0200 W/LOCATION(30925): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:29.741+0200 I/LOCATION(30925): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:34:29.791+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:34:29.791+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:34:29.791+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:29.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:29.801+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:34:29.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:34:29.801+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:34:29.801+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:29.811+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:34:29.811+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:34:29.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:34:29.811+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:29.811+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:34:29.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:34:29.821+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:34:29.831+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:34:29.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:34:29.831+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:29.831+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:34:29.841+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:34:29.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:34:29.841+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:34:29.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:34:29.841+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:34:29.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:34:29.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:34:29.871+0200 W/LOCATION(30925): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:34:29.871+0200 W/LOCATION(30925): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:34:29.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:29.971+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e912c8]
04-23 17:34:29.971+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:34:29.971+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:34:29.971+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:34:29.971+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:34:29.981+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:29.981+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:29.991+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:29.991+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:29.991+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:34:29.991+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:34:29.991+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:29.991+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:29.991+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:29.991+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:29.991+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:30.001+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:30.001+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:30.001+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:30.011+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:30.011+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:34:30.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:30.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:30.071+0200 W/LOCATION(30925): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:34:30.071+0200 I/LOCATION(30925): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:34:30.071+0200 I/LOCATION(30925): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:34:30.071+0200 I/location(30925): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:34:30.141+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 302 ms (from 11565507 to 11565809) (logOverhead=0,0,0,0,0,0,0), start: 17:34:29.852
04-23 17:34:30.151+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 306 ms (from 11565506 to 11565812) (logOverhead=0,0,0,0,0,0,0), start: 17:34:29.851
04-23 17:34:30.151+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 11565506 to 11565812) (logOverhead=0,0,0,0,0,0,0), start: 17:34:29.851
04-23 17:34:30.161+0200 I/LOCATION(30925): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:34:30.201+0200 E/location(30925): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:34:30.201+0200 W/AUL     (30925): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:34:30.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:34:30.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30925
04-23 17:34:30.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:34:30.211+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.211+0200 I/utils   (30105): specific action
04-23 17:34:30.211+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.211+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.211+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.211+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:34:30.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:34:30.221+0200 W/AUL     (30925): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:34:30.221+0200 I/location(30925): request sent to service es.ugr.frailty.servicemanager
04-23 17:34:30.221+0200 W/CAPI_APPFW_APP_CONTROL(30925): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.221+0200 I/utils   (30925): specific action
04-23 17:34:30.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:34:30.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:34:30.231+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.231+0200 I/utils   (30110): specific action
04-23 17:34:30.231+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.231+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.231+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.231+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:30.231+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:34:30.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:34:30.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:34:30.231+0200 I/recorder(30110): guardando datos en local
04-23 17:34:30.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:34:30.231+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:34:30.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(30110), cmd(0)
04-23 17:34:30.231+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:34:30.231+0200 I/servicemanager(30105): requesting to save local data
04-23 17:34:30.421+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:34:30.421+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11566086), time2(11505578)
04-23 17:34:30.421+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:34:30.421+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:34:30.421+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:34:30.421+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:34:30.971+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 143 ms (from 11566489 to 11566632) (logOverhead=0,0,0,0,0,0,0), start: 17:34:30.834
04-23 17:34:30.971+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 143 ms (from 11566489 to 11566632) (logOverhead=0,0,0,0,0,0,0), start: 17:34:30.834
04-23 17:34:31.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:34:31.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:31.021+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:34:31.121+0200 E/CAPI_TELEPHONY(30823): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:34:31.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:34:31.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:31.841+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:34:31.911+0200 W/LOCATION(30925): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:34:32.141+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:34:32.141+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:34:32.141+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:34:32.141+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:34:32.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:32.161+0200 W/AUL     (30939): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:34:32.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:34:32.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:34:32.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30861
04-23 17:34:32.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:34:32.171+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30861
04-23 17:34:32.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30861)
04-23 17:34:32.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:34:32.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:34:32.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:34:32.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e912c8
04-23 17:34:32.251+0200 W/CRASH_MANAGER(30937): worker.c: worker_job(1205) > 11309256c6f63152449767
