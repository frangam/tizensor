S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23126
Date: 2018-04-23 16:02:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf743e52d, r5   = 0xf7761f98
r6   = 0xffdb7558, r7   = 0xffdb7408
r8   = 0xf775ec18, r9   = 0x00000000
r10  = 0xffdb74e4, fp   = 0xffdb7558
ip   = 0x00000001, sp   = 0xffdb6288
lr   = 0xf743e539, pc   = 0xf74a72b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9996 KB
Buffers:     60824 KB
Cached:     225932 KB
VmPeak:      53484 KB
VmSize:      53420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12184 KB
VmRSS:       12184 KB
VmData:      11148 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23126 TID = 23126
23126 23130 

Maps Information
f4309000 f4b08000 rw-p [stack:23130]
f4b0f000 f4b11000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b19000 f4b1d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b26000 f4b28000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b30000 f4b33000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b42000 f4b47000 r-xp /usr/lib/libsystem.so.0.0.0
f4b52000 f4b55000 r-xp /lib/libattr.so.1.1.0
f4b5d000 f4b6d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b75000 f4b7e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b86000 f4b87000 r-xp /usr/lib/libresponse.so.0.2.96
f4b90000 f4b95000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6437000 f653d000 r-xp /usr/lib/libicuuc.so.57.1
f6553000 f66db000 r-xp /usr/lib/libicui18n.so.57.1
f66eb000 f66f8000 r-xp /usr/lib/libail.so.0.1.0
f6701000 f6708000 r-xp /usr/lib/libminizip.so.1.0.0
f6711000 f68ba000 r-xp /usr/lib/libcrypto.so.1.0.0
f68da000 f6921000 r-xp /usr/lib/libssl.so.1.0.0
f692d000 f692f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6937000 f693e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6947000 f694e000 r-xp /lib/libcrypt-2.13.so
f697f000 f6982000 r-xp /lib/libcap.so.2.21
f698a000 f698c000 r-xp /usr/lib/libiri.so
f6994000 f69dd000 r-xp /usr/lib/libmdm.so.1.2.69
f69e5000 f69eb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69f3000 f6a16000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a20000 f6a22000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a2a000 f6a47000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a50000 f6a54000 r-xp /usr/lib/libsmack.so.1.0.0
f6a5d000 f6a76000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a7f000 f6a87000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a8f000 f6a95000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a9e000 f6aa0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aa9000 f6ab9000 r-xp /lib/libresolv-2.13.so
f6abd000 f6ad5000 r-xp /usr/lib/liblzma.so.5.0.3
f6ade000 f6ae0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ae8000 f6b02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b0a000 f6b39000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b42000 f6b51000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b5b000 f6b65000 r-xp /usr/lib/libsensord-shared.so
f6b6e000 f6c41000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c4c000 f6c62000 r-xp /lib/libz.so.1.2.5
f6c6a000 f6c6f000 r-xp /usr/lib/libffi.so.5.0.10
f6c77000 f6c78000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c80000 f6c90000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c98000 f6cb1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cb9000 f6cbb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cc3000 f6d38000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d42000 f6d48000 r-xp /lib/librt-2.13.so
f6d51000 f6d6f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d79000 f6d7a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d82000 f6da5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dad000 f6db2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dba000 f6de4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ded000 f6e04000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e0c000 f6e75000 r-xp /lib/libm-2.13.so
f6e7e000 f6f12000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f25000 f6f2a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f32000 f6f39000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f41000 f6f6b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f74000 f7040000 r-xp /usr/lib/libxml2.so.2.7.8
f704d000 f704f000 r-xp /usr/lib/libiniparser.so.0
f7058000 f705e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7067000 f7137000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7138000 f716c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7175000 f71b1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71b9000 f71bc000 r-xp /usr/lib/libbundle.so.0.1.22
f71c4000 f71ca000 r-xp /usr/lib/libappsvc.so.0.1.0
f71d2000 f7213000 r-xp /usr/lib/libeina.so.1.7.99
f721c000 f7233000 r-xp /usr/lib/libecore.so.1.7.99
f724a000 f7253000 r-xp /usr/lib/libvconf.so.0.2.45
f725b000 f726f000 r-xp /lib/libpthread-2.13.so
f727a000 f7287000 r-xp /usr/lib/libaul.so.0.1.0
f7291000 f7293000 r-xp /lib/libdl-2.13.so
f729c000 f72a7000 r-xp /lib/libunwind.so.8.0.1
f72d4000 f72dc000 r-xp /lib/libgcc_s-4.6.so.1
f72dd000 f7401000 r-xp /lib/libc-2.13.so
f740f000 f7411000 r-xp /usr/lib/libdlog.so.0.0.0
f7419000 f7425000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f742e000 f7433000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f743b000 f744a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7452000 f7456000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f745f000 f7462000 r-xp /usr/lib/libappcore-agent.so.1.1
f746a000 f746c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7474000 f7478000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7480000 f749d000 r-xp /lib/ld-2.13.so
f74a6000 f74a9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74a9000 f74ad000 r-xp /usr/lib/libsys-assert.so
f772e000 f7796000 rw-p [heap]
ffd98000 ffdb9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23126)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74a72b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf743e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71453f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7143c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf714fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7155be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7155dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf718a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71851f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7143c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf714fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7155be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7155dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7187e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7188017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf718c8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74760bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b1a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bed663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf709afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf709c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf722cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7227b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72285a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7228879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7460183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74607fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74a76a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf72f485c) [/lib/libc.so.6] + 0x1785c
29: (0xf74a6fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:26.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:26.501+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:26.501+0200 I/recorder(22624): guardando datos en local
04-23 16:02:26.511+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:26.511+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:26.511+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:26.531+0200 I/LOCATION(23187): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:26.671+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:26.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:26.691+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:26.691+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:26.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:26.701+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:26.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:26.721+0200 W/AUL     (23197): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:26.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:26.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:26.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23126
04-23 16:02:26.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:26.721+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23126
04-23 16:02:26.721+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23126)
04-23 16:02:26.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:26.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:26.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:26.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7376530
04-23 16:02:26.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01740]
04-23 16:02:26.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:26.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:26.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:26.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:26.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:26.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:26.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:26.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:26.851+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:26.851+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:26.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:26.851+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:26.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:26.851+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:26.851+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:26.851+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:26.851+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:26.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:26.861+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:26.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:26.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:26.871+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:26.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:26.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:26.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:26.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:26.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:26.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:26.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01740
04-23 16:02:27.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e24630]
04-23 16:02:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:27.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:27.081+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:27.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:27.091+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:27.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:27.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:27.111+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:27.111+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:27.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:27.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:27.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:27.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:27.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:27.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:27.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:27.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:27.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:27.131+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:27.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:27.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:27.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:27.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:27.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:27.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e24630
04-23 16:02:27.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:27.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:27.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:27.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:27.501+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:02:27.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:27.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:27.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:27.521+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23203
04-23 16:02:27.521+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:27.571+0200 E/CAPI_APPFW_APPLICATION(23203): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:27.571+0200 E/CAPI_APPFW_APPLICATION(23203): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:27.591+0200 W/LOCATION(23203): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:27.591+0200 E/LOCATION(23203): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:27.591+0200 E/PKGMGR_INFO(23203): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:27.601+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:27.611+0200 I/LOCATION(23203): location.c: location_new(269) > method: 0
04-23 16:02:27.611+0200 W/LOCATION(23203): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:27.621+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:27.621+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:27.621+0200 W/LOCATION(23203): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:27.631+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23203
04-23 16:02:27.631+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23203) type(svcapp) bg(0)
04-23 16:02:27.631+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:27.631+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23203) was created
04-23 16:02:27.631+0200 W/LOCATION(23203): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:27.631+0200 W/LOCATION(23203): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:27.631+0200 W/LOCATION(23203): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:27.631+0200 W/LOCATION(23203): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:27.651+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:27.661+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23203)
04-23 16:02:27.661+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:02:27.661+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:27.661+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23203]
04-23 16:02:27.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:27.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:27.671+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:27.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:27.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23203
04-23 16:02:27.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:27.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23203
04-23 16:02:27.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:27.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:27.701+0200 W/LOCATION(23203): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:27.701+0200 W/LOCATION(23203): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:27.721+0200 W/LOCATION(23203): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:27.721+0200 W/LOCATION(23203): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:27.721+0200 W/LOCATION(23203): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:27.731+0200 W/LOCATION(23203): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:27.731+0200 I/LOCATION(23203): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77dac18
04-23 16:02:27.731+0200 I/LOCATION(23203): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:27.731+0200 I/LOCATION(23203): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77dac18
04-23 16:02:27.731+0200 I/LOCATION(23203): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:27.741+0200 I/location(23203): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:27.811+0200 I/LOCATION(23203): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:27.851+0200 W/LOCATION(23203): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:27.851+0200 W/LOCATION(23203): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:27.851+0200 I/LOCATION(23203): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:27.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:27.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:27.941+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:27.941+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:27.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:27.941+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:27.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:27.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:27.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:27.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:27.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:27.941+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:27.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:28.031+0200 W/LOCATION(23203): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:28.031+0200 W/LOCATION(23203): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:28.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:28.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:28.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:28.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18cc0]
04-23 16:02:28.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:28.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:28.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:28.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:28.201+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:28.201+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:28.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.221+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:28.221+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:28.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:28.221+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:28.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:28.221+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:28.221+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:28.221+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:28.221+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:28.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.231+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:28.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:28.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:28.261+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:28.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:28.271+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6043935), time2(6029254)
04-23 16:02:28.271+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:02:28.271+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:28.271+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:28.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:28.291+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:28.341+0200 W/LOCATION(23203): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:28.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:28.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:28.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:28.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:28.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:28.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:28.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:28.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:28.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:28.411+0200 I/LOCATION(23203): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:28.411+0200 I/LOCATION(23203): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:28.411+0200 I/location(23203): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:28.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:28.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:28.511+0200 I/LOCATION(23203): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:28.551+0200 W/AUL     (23203): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:28.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:28.551+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23203
04-23 16:02:28.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:28.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:28.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:28.571+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.571+0200 I/utils   (19708): specific action
04-23 16:02:28.571+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.571+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.571+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:28.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:28.571+0200 W/AUL     (23203): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:28.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:28.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:28.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:28.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:28.581+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.581+0200 I/utils   (22624): specific action
04-23 16:02:28.581+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.581+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.581+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.581+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:28.581+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:28.581+0200 I/recorder(22624): guardando datos en local
04-23 16:02:28.581+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:28.581+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:28.581+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:28.581+0200 I/location(23203): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:28.581+0200 I/location(23203): stopping es.ugr.frailty.location service
04-23 16:02:28.581+0200 E/CAPI_APPFW_APP_CONTROL(23203): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:28.581+0200 E/location(23203): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:28.581+0200 I/CAPI_APPFW_APPLICATION(23203): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:28.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:28.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:28.651+0200 W/LOCATION(23203): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:28.651+0200 I/LOCATION(23203): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:28.651+0200 I/LOCATION(23203): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:28.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:28.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:28.751+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:28.751+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:28.751+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:28.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:28.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:28.881+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:28.881+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:28.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:28.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:28.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:28.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18cc0
04-23 16:02:28.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733aeb0]
04-23 16:02:28.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:28.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:28.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:28.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:28.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:28.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.011+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:29.011+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:29.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:29.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:29.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:29.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:29.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:29.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:29.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.031+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:29.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:29.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:29.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:29.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:29.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:29.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:29.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:29.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:29.171+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733aeb0
04-23 16:02:29.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18c00]
04-23 16:02:29.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:29.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:29.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:29.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:29.201+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:29.201+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.221+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:29.221+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:29.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.221+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:29.231+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:29.231+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:29.231+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:29.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:29.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:29.241+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.241+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:29.251+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:29.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:29.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:29.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:29.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:29.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:29.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:29.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:29.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18c00
04-23 16:02:29.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:29.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:29.551+0200 W/AUL     (23216): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:29.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:29.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:29.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23187
04-23 16:02:29.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:29.561+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23187
04-23 16:02:29.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23187)
04-23 16:02:29.671+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:29.671+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:29.671+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:29.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:29.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:29.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:29.681+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23217
04-23 16:02:29.681+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:29.731+0200 E/CAPI_APPFW_APPLICATION(23217): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:29.731+0200 E/CAPI_APPFW_APPLICATION(23217): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:29.751+0200 W/LOCATION(23217): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:29.751+0200 E/LOCATION(23217): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:29.751+0200 E/PKGMGR_INFO(23217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:29.751+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23217
04-23 16:02:29.751+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23217) type(svcapp) bg(0)
04-23 16:02:29.751+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23217) was created
04-23 16:02:29.761+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23217]
04-23 16:02:29.761+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23217)
04-23 16:02:29.761+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:29.761+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:29.761+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:29.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23217
04-23 16:02:29.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:29.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:29.801+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23217
04-23 16:02:29.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:29.801+0200 I/LOCATION(23217): location.c: location_new(269) > method: 0
04-23 16:02:29.811+0200 W/LOCATION(23217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:29.821+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.841+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:29.851+0200 W/LOCATION(23217): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:29.851+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:29.861+0200 W/LOCATION(23217): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:29.861+0200 W/LOCATION(23217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:29.861+0200 W/LOCATION(23217): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:29.861+0200 W/LOCATION(23217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:29.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:29.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:29.901+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:29.911+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:29.911+0200 W/LOCATION(23217): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:29.921+0200 W/LOCATION(23217): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:29.921+0200 W/LOCATION(23217): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:29.921+0200 W/LOCATION(23217): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:29.921+0200 W/LOCATION(23217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:29.941+0200 W/LOCATION(23217): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:29.941+0200 I/LOCATION(23217): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7657c18
04-23 16:02:29.941+0200 I/LOCATION(23217): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:29.941+0200 I/LOCATION(23217): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7657c18
04-23 16:02:29.941+0200 I/LOCATION(23217): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:29.941+0200 I/location(23217): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:29.991+0200 I/LOCATION(23217): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:30.031+0200 W/LOCATION(23217): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:30.031+0200 W/LOCATION(23217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:30.031+0200 I/LOCATION(23217): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:30.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:30.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:30.121+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:30.121+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:30.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:30.121+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:30.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:30.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:30.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:30.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:30.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:30.121+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:30.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:30.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:30.191+0200 W/LOCATION(23217): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:30.191+0200 W/LOCATION(23217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:30.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:30.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:30.271+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:30.351+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11231266c6f63152449214
