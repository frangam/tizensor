S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20427
Date: 2018-04-23 15:58:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71d052d, r5   = 0xf79f4958
r6   = 0xffe2db18, r7   = 0xffe2d9c8
r8   = 0xf7a07c18, r9   = 0x00000000
r10  = 0xffe2daa4, fp   = 0xffe2db18
ip   = 0x00000001, sp   = 0xffe2c848
lr   = 0xf71d0539, pc   = 0xf72392b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7268 KB
Buffers:     58388 KB
Cached:     235628 KB
VmPeak:      53628 KB
VmSize:      53624 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11984 KB
VmRSS:       11984 KB
VmData:      11352 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20427 TID = 20427
20427 20430 

Maps Information
f409b000 f489a000 rw-p [stack:20430]
f48a1000 f48a3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48ab000 f48af000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48b8000 f48ba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48c2000 f48c5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48d4000 f48d9000 r-xp /usr/lib/libsystem.so.0.0.0
f48e4000 f48e7000 r-xp /lib/libattr.so.1.1.0
f48ef000 f48ff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4907000 f4910000 r-xp /usr/lib/libedbus.so.1.7.99
f4918000 f4919000 r-xp /usr/lib/libresponse.so.0.2.96
f4922000 f4927000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61c9000 f62cf000 r-xp /usr/lib/libicuuc.so.57.1
f62e5000 f646d000 r-xp /usr/lib/libicui18n.so.57.1
f647d000 f648a000 r-xp /usr/lib/libail.so.0.1.0
f6493000 f649a000 r-xp /usr/lib/libminizip.so.1.0.0
f64a3000 f664c000 r-xp /usr/lib/libcrypto.so.1.0.0
f666c000 f66b3000 r-xp /usr/lib/libssl.so.1.0.0
f66bf000 f66c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66c9000 f66d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66d9000 f66e0000 r-xp /lib/libcrypt-2.13.so
f6711000 f6714000 r-xp /lib/libcap.so.2.21
f671c000 f671e000 r-xp /usr/lib/libiri.so
f6726000 f676f000 r-xp /usr/lib/libmdm.so.1.2.69
f6777000 f677d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6785000 f67a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67b2000 f67b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67bc000 f67d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67e2000 f67e6000 r-xp /usr/lib/libsmack.so.1.0.0
f67ef000 f6808000 r-xp /usr/lib/libnetwork.so.0.0.0
f6811000 f6819000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6821000 f6827000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6830000 f6832000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f683b000 f684b000 r-xp /lib/libresolv-2.13.so
f684f000 f6867000 r-xp /usr/lib/liblzma.so.5.0.3
f6870000 f6872000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f687a000 f6894000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f689c000 f68cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68d4000 f68e3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68ed000 f68f7000 r-xp /usr/lib/libsensord-shared.so
f6900000 f69d3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69de000 f69f4000 r-xp /lib/libz.so.1.2.5
f69fc000 f6a01000 r-xp /usr/lib/libffi.so.5.0.10
f6a09000 f6a0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a12000 f6a22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a2a000 f6a43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a4b000 f6a4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a55000 f6aca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ad4000 f6ada000 r-xp /lib/librt-2.13.so
f6ae3000 f6b01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b0b000 f6b0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b14000 f6b37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b3f000 f6b44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b4c000 f6b76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b7f000 f6b96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b9e000 f6c07000 r-xp /lib/libm-2.13.so
f6c10000 f6ca4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cb7000 f6cbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cc4000 f6ccb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cd3000 f6cfd000 r-xp /usr/lib/libsensor.so.1.9.6
f6d06000 f6dd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6ddf000 f6de1000 r-xp /usr/lib/libiniparser.so.0
f6dea000 f6df0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6df9000 f6ec9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eca000 f6efe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f07000 f6f43000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f4b000 f6f4e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f56000 f6f5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f64000 f6fa5000 r-xp /usr/lib/libeina.so.1.7.99
f6fae000 f6fc5000 r-xp /usr/lib/libecore.so.1.7.99
f6fdc000 f6fe5000 r-xp /usr/lib/libvconf.so.0.2.45
f6fed000 f7001000 r-xp /lib/libpthread-2.13.so
f700c000 f7019000 r-xp /usr/lib/libaul.so.0.1.0
f7023000 f7025000 r-xp /lib/libdl-2.13.so
f702e000 f7039000 r-xp /lib/libunwind.so.8.0.1
f7066000 f706e000 r-xp /lib/libgcc_s-4.6.so.1
f706f000 f7193000 r-xp /lib/libc-2.13.so
f71a1000 f71a3000 r-xp /usr/lib/libdlog.so.0.0.0
f71ab000 f71b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71c0000 f71c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71cd000 f71dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71e4000 f71e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71f1000 f71f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f71fc000 f71fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7206000 f720a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7212000 f722f000 r-xp /lib/ld-2.13.so
f7238000 f723b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f723b000 f723f000 r-xp /usr/lib/libsys-assert.so
f79d7000 f7a74000 rw-p [heap]
ffe0f000 ffe30000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20427)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf72392b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf71d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ed73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ed5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ee1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ee7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ee7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f1c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ed5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ee1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ee7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ee7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f19e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f1a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f1e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72080bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf48ac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf697f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e2cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e2e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fbeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fb9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72396a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf708685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7238fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
> request cmd(0) result(19713)
04-23 15:58:18.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:18.351+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:18.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:18.391+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 I/utils   (19713): specific action
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:18.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:18.401+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:18.401+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:18.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:18.401+0200 I/recorder(19713): guardando datos en local
04-23 15:58:18.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:18.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:18.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:18.441+0200 I/LOCATION(20427): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:18.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.541+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:18.581+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:18.581+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:18.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:18.581+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:18.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.591+0200 W/AUL     (20442): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20413
04-23 15:58:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:18.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20413
04-23 15:58:18.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20413)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:18.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e14118
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375eb8]
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:18.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:18.701+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:18.701+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:18.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.711+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:18.711+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:18.711+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:18.711+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:18.711+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:18.711+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:18.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:18.731+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:18.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.741+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.741+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:18.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:18.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375eb8
04-23 15:58:18.841+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11203976c6f631524491894
04-23 15:58:18.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:18.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:18.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01b20]
04-23 15:58:18.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:18.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:18.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:18.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:19.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:19.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:19.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:19.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:19.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:19.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:19.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:19.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:19.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:19.111+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:19.111+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:19.121+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:19.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:19.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:19.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20466
04-23 15:58:19.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:19.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:19.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:19.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:19.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01b20
04-23 15:58:19.141+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:19.141+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:19.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20466
04-23 15:58:19.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20466) type(svcapp) bg(0)
04-23 15:58:19.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20466)
04-23 15:58:19.181+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:19.181+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:19.181+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20466]
04-23 15:58:19.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:19.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20466
04-23 15:58:19.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:19.231+0200 E/CAPI_APPFW_APPLICATION(20466): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:19.231+0200 E/CAPI_APPFW_APPLICATION(20466): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20466
04-23 15:58:19.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:19.231+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20466) was created
04-23 15:58:19.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:19.271+0200 W/LOCATION(20466): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:19.271+0200 E/LOCATION(20466): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:19.271+0200 E/PKGMGR_INFO(20466): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:19.281+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.301+0200 I/LOCATION(20466): location.c: location_new(269) > method: 0
04-23 15:58:19.301+0200 W/LOCATION(20466): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.311+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.311+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.321+0200 W/LOCATION(20466): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:19.321+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:19.321+0200 W/LOCATION(20466): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:19.321+0200 W/LOCATION(20466): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.321+0200 W/LOCATION(20466): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:19.321+0200 W/LOCATION(20466): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:19.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:19.341+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:19.361+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:19.371+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:19.371+0200 W/LOCATION(20466): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:19.381+0200 W/LOCATION(20466): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:19.381+0200 W/LOCATION(20466): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:19.381+0200 W/LOCATION(20466): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:19.381+0200 W/LOCATION(20466): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:19.411+0200 W/LOCATION(20466): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:19.411+0200 I/LOCATION(20466): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf752ec18
04-23 15:58:19.411+0200 I/LOCATION(20466): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:19.411+0200 I/LOCATION(20466): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf752ec18
04-23 15:58:19.411+0200 I/LOCATION(20466): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:19.421+0200 I/location(20466): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:19.471+0200 I/LOCATION(20466): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:19.511+0200 W/LOCATION(20466): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:19.511+0200 W/LOCATION(20466): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:19.511+0200 I/LOCATION(20466): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:19.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:19.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:19.561+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:19.591+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:19.591+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:19.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:19.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:19.591+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:19.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:19.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:19.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:19.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:19.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:19.601+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:19.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:19.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:19.681+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:19.741+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:19.741+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:19.761+0200 W/LOCATION(20466): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:19.761+0200 W/LOCATION(20466): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:19.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:19.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:19.851+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5795514), time2(5789275)
04-23 15:58:19.851+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:19.851+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:19.851+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:19.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:19.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01b20]
04-23 15:58:19.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:19.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:19.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:19.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:19.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.911+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:19.911+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:19.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:19.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:19.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:19.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:19.921+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:19.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:19.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:19.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:19.931+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:19.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:19.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:19.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:19.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.021+0200 W/LOCATION(20466): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:20.021+0200 I/LOCATION(20466): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:20.021+0200 I/LOCATION(20466): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:20.021+0200 I/location(20466): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:20.101+0200 I/LOCATION(20466): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:20.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:20.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:20.151+0200 W/AUL     (20466): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:20.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:20.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20466
04-23 15:58:20.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:20.161+0200 W/AUL     (20466): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:20.171+0200 I/location(20466): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:20.171+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.171+0200 I/utils   (19708): specific action
04-23 15:58:20.171+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:20.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:20.171+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.171+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.171+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.171+0200 I/location(20466): stopping es.ugr.frailty.location service
04-23 15:58:20.171+0200 E/CAPI_APPFW_APP_CONTROL(20466): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:20.171+0200 E/location(20466): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:20.171+0200 I/CAPI_APPFW_APPLICATION(20466): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:20.171+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:20.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:20.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:20.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:20.171+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:20.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:20.181+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.181+0200 I/utils   (19713): specific action
04-23 15:58:20.181+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.181+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:20.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:20.181+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.181+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.181+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:20.181+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:20.181+0200 I/recorder(19713): guardando datos en local
04-23 15:58:20.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:20.181+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:20.181+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:20.221+0200 W/LOCATION(20466): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:20.221+0200 I/LOCATION(20466): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:20.221+0200 I/LOCATION(20466): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:58:20.291+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:20.291+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:20.291+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:20.301+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:20.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:20.341+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:20.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:20.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:20.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:20.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01b20
04-23 15:58:20.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:20.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:20.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e17a78]
04-23 15:58:20.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:20.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:20.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:20.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:20.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:20.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:20.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.591+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:20.591+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:20.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:20.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:20.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:20.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:20.591+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:20.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:20.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:20.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.611+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:20.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:20.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:20.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:20.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e17a78
04-23 15:58:20.771+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:20.791+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:20.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7388260]
04-23 15:58:20.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:20.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:20.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:20.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:20.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:20.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:20.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.831+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:20.831+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:20.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:20.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:20.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:20.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:20.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:20.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:20.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:20.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:20.851+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:20.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:20.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:20.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:20.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:20.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7388260
04-23 15:58:20.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:20.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:21.081+0200 W/AUL     (20492): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:21.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:21.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:21.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20427
04-23 15:58:21.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:21.081+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20427
04-23 15:58:21.081+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20427)
04-23 15:58:21.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:21.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:21.191+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:21.191+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:21.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:21.191+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:21.201+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20493
04-23 15:58:21.201+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:21.241+0200 E/CAPI_APPFW_APPLICATION(20493): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:21.241+0200 E/CAPI_APPFW_APPLICATION(20493): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:21.271+0200 W/LOCATION(20493): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:21.271+0200 E/LOCATION(20493): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:21.271+0200 E/PKGMGR_INFO(20493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:21.271+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:21.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20493
04-23 15:58:21.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20493) type(svcapp) bg(0)
04-23 15:58:21.291+0200 I/LOCATION(20493): location.c: location_new(269) > method: 0
04-23 15:58:21.291+0200 W/LOCATION(20493): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:21.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20493) was created
04-23 15:58:21.291+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:21.291+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20493]
04-23 15:58:21.291+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:21.301+0200 W/LOCATION(20493): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:21.301+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:21.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:21.311+0200 W/LOCATION(20493): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:21.311+0200 W/LOCATION(20493): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:21.311+0200 W/LOCATION(20493): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:21.311+0200 W/LOCATION(20493): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:21.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20493
04-23 15:58:21.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:21.321+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20493)
04-23 15:58:21.321+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:21.321+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:21.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:21.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:21.341+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:21.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20493
04-23 15:58:21.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:21.391+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:21.401+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:21.401+0200 W/LOCATION(20493): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:21.401+0200 W/LOCATION(20493): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:21.411+0200 W/LOCATION(20493): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:21.411+0200 W/LOCATION(20493): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:21.411+0200 W/LOCATION(20493): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:21.421+0200 W/LOCATION(20493): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:21.421+0200 I/LOCATION(20493): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77d2c18
04-23 15:58:21.421+0200 I/LOCATION(20493): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:21.421+0200 I/LOCATION(20493): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77d2c18
04-23 15:58:21.421+0200 I/LOCATION(20493): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:21.431+0200 I/location(20493): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:21.471+0200 I/LOCATION(20493): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:21.511+0200 W/LOCATION(20493): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:21.511+0200 W/LOCATION(20493): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:21.511+0200 I/LOCATION(20493): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:21.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:21.541+0200 I/heartrate(20378): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:21.591+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:21.591+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:21.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:21.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:21.591+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:21.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:21.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:21.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:21.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:21.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:21.601+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:21.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:21.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:21.601+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11204276c6f63152449189
