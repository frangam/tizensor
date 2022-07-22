S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23577
Date: 2018-04-23 16:02:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a652d, r5   = 0xf76e8f98
r6   = 0xffd774f8, r7   = 0xffd773a8
r8   = 0xf76e5c18, r9   = 0x00000000
r10  = 0xffd77484, fp   = 0xffd774f8
ip   = 0x00000001, sp   = 0xffd76228
lr   = 0xf70a6539, pc   = 0xf710f2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10116 KB
Buffers:     61248 KB
Cached:     227336 KB
VmPeak:      53460 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11980 KB
VmRSS:       11980 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23577 TID = 23577
23577 23588 

Maps Information
f3f71000 f4770000 rw-p [stack:23588]
f4777000 f4779000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4781000 f4785000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f478e000 f4790000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4798000 f479b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47aa000 f47af000 r-xp /usr/lib/libsystem.so.0.0.0
f47ba000 f47bd000 r-xp /lib/libattr.so.1.1.0
f47c5000 f47d5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47dd000 f47e6000 r-xp /usr/lib/libedbus.so.1.7.99
f47ee000 f47ef000 r-xp /usr/lib/libresponse.so.0.2.96
f47f8000 f47fd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f609f000 f61a5000 r-xp /usr/lib/libicuuc.so.57.1
f61bb000 f6343000 r-xp /usr/lib/libicui18n.so.57.1
f6353000 f6360000 r-xp /usr/lib/libail.so.0.1.0
f6369000 f6370000 r-xp /usr/lib/libminizip.so.1.0.0
f6379000 f6522000 r-xp /usr/lib/libcrypto.so.1.0.0
f6542000 f6589000 r-xp /usr/lib/libssl.so.1.0.0
f6595000 f6597000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f659f000 f65a6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65af000 f65b6000 r-xp /lib/libcrypt-2.13.so
f65e7000 f65ea000 r-xp /lib/libcap.so.2.21
f65f2000 f65f4000 r-xp /usr/lib/libiri.so
f65fc000 f6645000 r-xp /usr/lib/libmdm.so.1.2.69
f664d000 f6653000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f665b000 f667e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6688000 f668a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6692000 f66af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b8000 f66bc000 r-xp /usr/lib/libsmack.so.1.0.0
f66c5000 f66de000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e7000 f66ef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f7000 f66fd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6706000 f6708000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6711000 f6721000 r-xp /lib/libresolv-2.13.so
f6725000 f673d000 r-xp /usr/lib/liblzma.so.5.0.3
f6746000 f6748000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6750000 f676a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6772000 f67a1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67aa000 f67b9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c3000 f67cd000 r-xp /usr/lib/libsensord-shared.so
f67d6000 f68a9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b4000 f68ca000 r-xp /lib/libz.so.1.2.5
f68d2000 f68d7000 r-xp /usr/lib/libffi.so.5.0.10
f68df000 f68e0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e8000 f68f8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6900000 f6919000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6921000 f6923000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f692b000 f69a0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69aa000 f69b0000 r-xp /lib/librt-2.13.so
f69b9000 f69d7000 r-xp /usr/lib/libsystemd.so.0.4.0
f69e1000 f69e2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69ea000 f6a0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a15000 f6a1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a22000 f6a4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a55000 f6a6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a74000 f6add000 r-xp /lib/libm-2.13.so
f6ae6000 f6b7a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b8d000 f6b92000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b9a000 f6ba1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba9000 f6bd3000 r-xp /usr/lib/libsensor.so.1.9.6
f6bdc000 f6ca8000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb5000 f6cb7000 r-xp /usr/lib/libiniparser.so.0
f6cc0000 f6cc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ccf000 f6d9f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6da0000 f6dd4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ddd000 f6e19000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e21000 f6e24000 r-xp /usr/lib/libbundle.so.0.1.22
f6e2c000 f6e32000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e3a000 f6e7b000 r-xp /usr/lib/libeina.so.1.7.99
f6e84000 f6e9b000 r-xp /usr/lib/libecore.so.1.7.99
f6eb2000 f6ebb000 r-xp /usr/lib/libvconf.so.0.2.45
f6ec3000 f6ed7000 r-xp /lib/libpthread-2.13.so
f6ee2000 f6eef000 r-xp /usr/lib/libaul.so.0.1.0
f6ef9000 f6efb000 r-xp /lib/libdl-2.13.so
f6f04000 f6f0f000 r-xp /lib/libunwind.so.8.0.1
f6f3c000 f6f44000 r-xp /lib/libgcc_s-4.6.so.1
f6f45000 f7069000 r-xp /lib/libc-2.13.so
f7077000 f7079000 r-xp /usr/lib/libdlog.so.0.0.0
f7081000 f708d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7096000 f709b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a3000 f70b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70ba000 f70be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c7000 f70ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d2000 f70d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70dc000 f70e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e8000 f7105000 r-xp /lib/ld-2.13.so
f710e000 f7111000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7111000 f7115000 r-xp /usr/lib/libsys-assert.so
f76b5000 f7724000 rw-p [heap]
ffd58000 ffd79000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23577)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf710f2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dad3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dbdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dbddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ded1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dbdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dbddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6defe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6df0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df48d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf70de0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4782171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6855663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d02fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e94ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e8fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e90879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf710f6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6f5c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf710efa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:04.321+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:04.321+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:04.321+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:04.321+0200 W/AUL     (23671): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:04.321+0200 I/location(23671): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:04.321+0200 W/CAPI_APPFW_APP_CONTROL(23671): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:04.321+0200 I/utils   (23671): specific action
04-23 16:03:04.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:04.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:04.381+0200 I/utils   (22624): specific action
04-23 16:03:04.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:04.381+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:04.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:04.381+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:04.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:04.381+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:04.381+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:04.381+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:04.381+0200 I/recorder(22624): guardando datos en local
04-23 16:03:04.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:04.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:04.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:04.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:04.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:04.481+0200 I/LOCATION(23671): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:04.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:04.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:04.721+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:04.721+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:04.721+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:04.721+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:04.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:04.751+0200 W/AUL     (23682): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:04.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:04.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:04.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23654
04-23 16:03:04.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:04.751+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23654
04-23 16:03:04.751+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23654)
04-23 16:03:04.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:04.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:04.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:04.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e05c30
04-23 16:03:04.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:04.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:04.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03690]
04-23 16:03:04.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:04.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:04.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:04.881+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:04.891+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:04.891+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:04.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.921+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:04.921+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:04.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:04.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:04.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:04.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:04.921+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:04.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:04.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:04.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:04.941+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:04.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:04.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:04.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:05.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:05.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:05.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:05.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:05.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:05.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03690
04-23 16:03:05.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e33388]
04-23 16:03:05.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:05.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:05.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:05.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:05.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:05.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:05.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:05.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:05.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:05.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:05.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:05.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:05.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:05.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:05.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:05.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:05.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:05.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:05.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:05.181+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:05.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:05.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:05.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:05.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:05.231+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:05.231+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:05.231+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:05.231+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e33388
04-23 16:03:05.361+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:03:05.361+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:05.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:05.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:05.381+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:05.391+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23687
04-23 16:03:05.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:05.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:05.441+0200 E/CAPI_APPFW_APPLICATION(23687): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:05.441+0200 E/CAPI_APPFW_APPLICATION(23687): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:05.461+0200 W/LOCATION(23687): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:05.461+0200 E/LOCATION(23687): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:05.461+0200 E/PKGMGR_INFO(23687): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:05.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23687
04-23 16:03:05.461+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23687) type(svcapp) bg(0)
04-23 16:03:05.471+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23687) was created
04-23 16:03:05.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23687)
04-23 16:03:05.471+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:05.471+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:05.471+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23687]
04-23 16:03:05.481+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:05.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:05.491+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23687
04-23 16:03:05.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:05.511+0200 I/LOCATION(23687): location.c: location_new(269) > method: 0
04-23 16:03:05.511+0200 W/LOCATION(23687): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:05.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:05.531+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23687
04-23 16:03:05.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:05.531+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:05.541+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:05.541+0200 W/LOCATION(23687): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:05.541+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:05.551+0200 W/LOCATION(23687): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:05.551+0200 W/LOCATION(23687): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:05.551+0200 W/LOCATION(23687): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:05.551+0200 W/LOCATION(23687): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:05.571+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:05.571+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:05.571+0200 W/LOCATION(23687): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:05.581+0200 W/LOCATION(23687): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:05.581+0200 W/LOCATION(23687): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:05.581+0200 W/LOCATION(23687): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:05.581+0200 W/LOCATION(23687): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:05.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:05.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:05.601+0200 W/LOCATION(23687): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:05.601+0200 I/LOCATION(23687): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77a0c18
04-23 16:03:05.601+0200 I/LOCATION(23687): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:05.601+0200 I/LOCATION(23687): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77a0c18
04-23 16:03:05.601+0200 I/LOCATION(23687): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:05.601+0200 I/location(23687): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:05.661+0200 I/LOCATION(23687): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:05.701+0200 W/LOCATION(23687): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:05.701+0200 W/LOCATION(23687): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:05.701+0200 I/LOCATION(23687): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:05.771+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:05.771+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:05.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:05.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:05.771+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:05.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:05.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:05.771+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:05.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:05.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:05.781+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:05.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:05.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:05.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:05.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:05.851+0200 W/LOCATION(23687): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:05.851+0200 W/LOCATION(23687): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 16:03:05.881+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:03:05.881+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 16:03:05.881+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [6081.545856] layer(0x5ac2c0) now usable
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [6081.545872] layer[0x5abe10]zpos[1]
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [6081.545895] layer(0x5ac310) now usable
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [6081.545905] layer[0x5abf30]zpos[2]
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [6081.545930] layer(0x5ac250) now usable
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [6081.545940] layer[0x5abcf0]zpos[0]
04-23 16:03:05.881+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [6081.546029] dpms[0 -> 3]sync[1]
04-23 16:03:05.881+0200 I/TDM     ( 1785): 
04-23 16:03:05.881+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 16:03:05.881+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 16:03:05.881+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 16:03:05.881+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 16:03:05.881+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 16:03:05.881+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 16:03:05.881+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 16:03:05.881+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 16:03:05.891+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:03:05.891+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:03:05.891+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:03:05.891+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 16:03:05.911+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 16:03:05.911+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:03:05.911+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 16:03:05.911+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 16:03:05.961+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:05.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:05.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:06.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18718]
04-23 16:03:06.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:06.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:06.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:06.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:06.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:06.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:06.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:06.021+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6081681), time2(6079657)
04-23 16:03:06.021+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:06.021+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:06.021+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:06.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:06.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.031+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:06.031+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:06.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:06.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:06.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:06.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:06.031+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:06.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:06.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:06.041+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [6081.700883] dpms[3 -> 3]done
04-23 16:03:06.041+0200 I/TDM     ( 1785): 
04-23 16:03:06.041+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 16:03:06.041+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 16:03:06.041+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 16:03:06.051+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 16:03:06.051+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 16:03:06.051+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 16:03:06.051+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 16:03:06.051+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 16:03:06.051+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 16:03:06.051+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:06.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:03:06.061+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:06.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.061+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:06.071+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 16:03:06.071+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 16:03:06.071+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 16:03:06.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.081+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 16:03:06.081+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 16:03:06.081+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 16:03:06.081+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 16:03:06.081+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 16:03:06.081+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 16:03:06.091+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 16:03:06.091+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 16:03:06.091+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 16:03:06.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.141+0200 W/LOCATION(23687): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:06.141+0200 I/LOCATION(23687): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:06.141+0200 I/LOCATION(23687): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:06.141+0200 I/location(23687): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:06.251+0200 I/LOCATION(23687): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:06.321+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:06.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:06.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23687
04-23 16:03:06.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:06.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:06.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:06.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:06.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:06.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:06.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:06.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:06.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:06.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:06.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:06.411+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.411+0200 I/utils   (19708): specific action
04-23 16:03:06.411+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.411+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.411+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.411+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:06.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:06.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:06.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:06.421+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.421+0200 I/utils   (22624): specific action
04-23 16:03:06.421+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.421+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.421+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.421+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:06.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:06.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:06.421+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:06.421+0200 I/recorder(22624): guardando datos en local
04-23 16:03:06.421+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:06.421+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:06.421+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:06.421+0200 W/AUL     (23687): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:06.421+0200 I/location(23687): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:06.421+0200 I/location(23687): stopping es.ugr.frailty.location service
04-23 16:03:06.421+0200 E/CAPI_APPFW_APP_CONTROL(23687): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:06.421+0200 E/location(23687): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:06.421+0200 I/CAPI_APPFW_APPLICATION(23687): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:06.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:06.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:06.471+0200 W/LOCATION(23687): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:06.471+0200 I/LOCATION(23687): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:06.471+0200 I/LOCATION(23687): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:06.541+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:06.541+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:06.541+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:06.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:06.561+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 16:03:06.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:06.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:06.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:06.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18718
04-23 16:03:06.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e23310]
04-23 16:03:06.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:06.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:06.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:06.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:06.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:06.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:06.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.781+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:06.781+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:06.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:06.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:06.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:06.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:06.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:06.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:06.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:06.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:06.801+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:06.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:06.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:06.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:06.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:06.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e23310
04-23 16:03:06.911+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11235776c6f63152449217
