S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12629
Date: 2018-04-23 20:41:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71ba52d, r5   = 0xf72b2f98
r6   = 0xffadeb00, r7   = 0xffade9b0
r8   = 0xf72afc18, r9   = 0x00000000
r10  = 0xffadea8c, fp   = 0xffadeb00
ip   = 0x00000001, sp   = 0xffade988
lr   = 0xf71ba539, pc   = 0xf7223228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    131824 KB
Buffers:     40472 KB
Cached:     161372 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11936 KB
VmRSS:       11936 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12629 TID = 12629
12629 12632 

Maps Information
f4085000 f4884000 rw-p [stack:12632]
f488b000 f488d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4895000 f4899000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48a2000 f48a4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48ac000 f48af000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48be000 f48c3000 r-xp /usr/lib/libsystem.so.0.0.0
f48ce000 f48d1000 r-xp /lib/libattr.so.1.1.0
f48d9000 f48e9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48f1000 f48fa000 r-xp /usr/lib/libedbus.so.1.7.99
f4902000 f4903000 r-xp /usr/lib/libresponse.so.0.2.96
f490c000 f4911000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61b3000 f62b9000 r-xp /usr/lib/libicuuc.so.57.1
f62cf000 f6457000 r-xp /usr/lib/libicui18n.so.57.1
f6467000 f6474000 r-xp /usr/lib/libail.so.0.1.0
f647d000 f6484000 r-xp /usr/lib/libminizip.so.1.0.0
f648d000 f6636000 r-xp /usr/lib/libcrypto.so.1.0.0
f6656000 f669d000 r-xp /usr/lib/libssl.so.1.0.0
f66a9000 f66ab000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66b3000 f66ba000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66c3000 f66ca000 r-xp /lib/libcrypt-2.13.so
f66fb000 f66fe000 r-xp /lib/libcap.so.2.21
f6706000 f6708000 r-xp /usr/lib/libiri.so
f6710000 f6759000 r-xp /usr/lib/libmdm.so.1.2.69
f6761000 f6767000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f676f000 f6792000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f679c000 f679e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67a6000 f67c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67cc000 f67d0000 r-xp /usr/lib/libsmack.so.1.0.0
f67d9000 f67f2000 r-xp /usr/lib/libnetwork.so.0.0.0
f67fb000 f6803000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f680b000 f6811000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f681a000 f681c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6825000 f6835000 r-xp /lib/libresolv-2.13.so
f6839000 f6851000 r-xp /usr/lib/liblzma.so.5.0.3
f685a000 f685c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6864000 f687e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6886000 f68b5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68be000 f68cd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68d7000 f68e1000 r-xp /usr/lib/libsensord-shared.so
f68ea000 f69bd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69c8000 f69de000 r-xp /lib/libz.so.1.2.5
f69e6000 f69eb000 r-xp /usr/lib/libffi.so.5.0.10
f69f3000 f69f4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69fc000 f6a0c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a14000 f6a2d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a35000 f6a37000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a3f000 f6ab4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6abe000 f6ac4000 r-xp /lib/librt-2.13.so
f6acd000 f6aeb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6af5000 f6af6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6afe000 f6b21000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b29000 f6b2e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b36000 f6b60000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b69000 f6b80000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b88000 f6bf1000 r-xp /lib/libm-2.13.so
f6bfa000 f6c8e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ca1000 f6ca6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cae000 f6cb5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cbd000 f6ce7000 r-xp /usr/lib/libsensor.so.1.9.6
f6cf0000 f6dbc000 r-xp /usr/lib/libxml2.so.2.7.8
f6dc9000 f6dcb000 r-xp /usr/lib/libiniparser.so.0
f6dd4000 f6dda000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6de3000 f6eb3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eb4000 f6ee8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ef1000 f6f2d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f35000 f6f38000 r-xp /usr/lib/libbundle.so.0.1.22
f6f40000 f6f46000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f4e000 f6f8f000 r-xp /usr/lib/libeina.so.1.7.99
f6f98000 f6faf000 r-xp /usr/lib/libecore.so.1.7.99
f6fc6000 f6fcf000 r-xp /usr/lib/libvconf.so.0.2.45
f6fd7000 f6feb000 r-xp /lib/libpthread-2.13.so
f6ff6000 f7003000 r-xp /usr/lib/libaul.so.0.1.0
f700d000 f700f000 r-xp /lib/libdl-2.13.so
f7018000 f7023000 r-xp /lib/libunwind.so.8.0.1
f7050000 f7058000 r-xp /lib/libgcc_s-4.6.so.1
f7059000 f717d000 r-xp /lib/libc-2.13.so
f718b000 f718d000 r-xp /usr/lib/libdlog.so.0.0.0
f7195000 f71a1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71aa000 f71af000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71b7000 f71c6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71ce000 f71d2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71db000 f71de000 r-xp /usr/lib/libappcore-agent.so.1.1
f71e6000 f71e8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71f0000 f71f4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71fc000 f7219000 r-xp /lib/ld-2.13.so
f7222000 f7225000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7225000 f7229000 r-xp /usr/lib/libsys-assert.so
f727f000 f72f0000 rw-p [heap]
ffac0000 ffae1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12629)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7223228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71ba539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ec13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ebfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ecbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ed1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ed1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f0675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f011f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ebfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ecbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ed1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ed1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f03e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f04017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f0bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48a31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4896171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6969663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e16fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e187a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fa8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fa3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fa45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fa4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71dc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71dc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72235c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf707085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7222f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:43.529+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:43.539+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:43.549+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:43.549+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:43.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:43.569+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:43.569+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2978834), time2(2965547)
04-23 20:41:43.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:41:43.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:43.569+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:43.569+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:43.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:43.639+0200 W/LOCATION(12557): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:43.639+0200 I/LOCATION(12557): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:43.639+0200 I/LOCATION(12557): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:43.639+0200 I/location(12557): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:43.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:43.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:43.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:43.739+0200 I/LOCATION(12557): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:43.789+0200 I/location(12557): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:43.789+0200 W/CAPI_APPFW_APP_CONTROL(12557): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:43.789+0200 I/utils   (12557): specific action
04-23 20:41:44.549+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:44.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:44.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:44.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:45.129+0200 W/LOCATION(12557): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:45.279+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11125576c6f631524508905
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:41:45.299+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:41:45.299+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:41:45.309+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:41:45.309+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:41:45.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.339+0200 W/AUL     (12571): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:41:45.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:45.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:45.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12501
04-23 20:41:45.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:45.339+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12501
04-23 20:41:45.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12501)
04-23 20:41:45.389+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:45.389+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:45.389+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:45.389+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf795c8c0
04-23 20:41:45.449+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf795c898]
04-23 20:41:45.449+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:45.449+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:45.449+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:45.449+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:45.459+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:45.459+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:45.469+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.479+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.479+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:45.479+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:45.479+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:45.479+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:45.479+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:45.479+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:45.479+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:45.479+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:45.479+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:45.489+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.499+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.499+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:45.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:45.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:45.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:45.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf795c898
04-23 20:41:45.669+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf798aec8]
04-23 20:41:45.669+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:45.669+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:45.669+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:45.669+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:45.679+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:45.679+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:45.689+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.699+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.699+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:45.699+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:45.699+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:45.699+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:45.699+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:45.699+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:45.699+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:45.699+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:45.699+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:45.709+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.719+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:45.719+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:45.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:45.769+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:45.769+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:45.769+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:45.779+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf798aec8
04-23 20:41:46.059+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:41:46.059+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:46.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:46.059+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:46.069+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12581
04-23 20:41:46.079+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:46.119+0200 E/CAPI_APPFW_APPLICATION(12581): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:46.119+0200 E/CAPI_APPFW_APPLICATION(12581): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:46.129+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12581
04-23 20:41:46.129+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12581) type(svcapp) bg(0)
04-23 20:41:46.129+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12581) was created
04-23 20:41:46.129+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12581)
04-23 20:41:46.129+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:41:46.129+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:46.129+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12581]
04-23 20:41:46.149+0200 W/LOCATION(12581): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:46.149+0200 E/LOCATION(12581): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:46.149+0200 E/PKGMGR_INFO(12581): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:46.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:46.159+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:46.159+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12581
04-23 20:41:46.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:46.179+0200 I/LOCATION(12581): location.c: location_new(269) > method: 0
04-23 20:41:46.179+0200 W/LOCATION(12581): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:46.179+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:46.189+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:46.189+0200 W/LOCATION(12581): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:46.199+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:46.199+0200 W/LOCATION(12581): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:46.199+0200 W/LOCATION(12581): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:46.199+0200 W/LOCATION(12581): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:46.199+0200 W/LOCATION(12581): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:46.219+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:46.229+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:46.229+0200 W/LOCATION(12581): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:46.239+0200 W/LOCATION(12581): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:46.239+0200 W/LOCATION(12581): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:46.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:46.249+0200 W/LOCATION(12581): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:46.249+0200 W/LOCATION(12581): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:46.259+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12581
04-23 20:41:46.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:46.269+0200 W/LOCATION(12581): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:46.269+0200 I/LOCATION(12581): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf78edc18
04-23 20:41:46.269+0200 I/LOCATION(12581): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:46.269+0200 I/LOCATION(12581): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf78edc18
04-23 20:41:46.269+0200 I/LOCATION(12581): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:46.269+0200 I/location(12581): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:46.319+0200 I/LOCATION(12581): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:46.359+0200 W/LOCATION(12581): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:46.359+0200 W/LOCATION(12581): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:46.359+0200 I/LOCATION(12581): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:46.429+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:46.429+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:46.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:46.429+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:46.429+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:46.429+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:46.429+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:46.429+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:46.429+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:46.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:46.439+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:46.439+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:46.439+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:46.489+0200 W/LOCATION(12581): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:46.489+0200 W/LOCATION(12581): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:46.559+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:46.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf42006a8]
04-23 20:41:46.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:46.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:46.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:46.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:46.619+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:46.619+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:46.629+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:46.639+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:46.639+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:46.639+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:46.639+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:46.639+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:46.639+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:46.639+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:46.639+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:46.639+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:46.639+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:46.649+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:46.659+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:46.659+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:46.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:46.669+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:46.669+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2981936), time2(2978834)
04-23 20:41:46.669+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:41:46.669+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:46.669+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:46.669+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:46.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:46.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:46.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:46.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:46.759+0200 W/LOCATION(12581): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:46.759+0200 I/LOCATION(12581): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:46.759+0200 I/LOCATION(12581): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:46.759+0200 I/location(12581): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:46.889+0200 I/LOCATION(12581): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:46.959+0200 I/location(12581): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:46.959+0200 I/location(12581): stopping es.ugr.frailty.location service
04-23 20:41:46.959+0200 E/CAPI_APPFW_APP_CONTROL(12581): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:41:46.959+0200 E/location(12581): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:41:46.959+0200 I/CAPI_APPFW_APPLICATION(12581): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:46.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:46.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:47.019+0200 W/LOCATION(12581): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:47.019+0200 I/LOCATION(12581): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:41:47.019+0200 I/LOCATION(12581): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:41:47.109+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:41:47.109+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:41:47.109+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:41:47.109+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:41:47.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:47.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:47.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:47.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf42006a8
04-23 20:41:47.349+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf794fe08]
04-23 20:41:47.349+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:47.349+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:47.349+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:47.349+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:47.359+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:47.359+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:47.369+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.379+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.379+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:47.379+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:47.379+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:47.379+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:47.379+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:47.379+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:47.379+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:47.379+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:47.379+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:47.389+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.389+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.389+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:47.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.489+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:47.489+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:47.489+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:47.489+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf794fe08
04-23 20:41:47.579+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf7981488]
04-23 20:41:47.579+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:47.579+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:47.579+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:47.579+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:47.589+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:47.589+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:47.599+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.609+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.609+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:47.609+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:47.609+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:47.609+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:47.609+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:47.609+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:47.609+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:47.609+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:47.609+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:47.619+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.629+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:47.629+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:47.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:47.699+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:47.699+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:47.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:47.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf7981488
04-23 20:41:47.909+0200 W/AUL     (12593): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:41:47.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:47.909+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:47.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12557
04-23 20:41:47.909+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:47.909+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12557
04-23 20:41:47.909+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12557)
04-23 20:41:48.959+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:56.209+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:41:56.209+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:56.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:56.209+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:56.219+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:56.219+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12629
04-23 20:41:56.269+0200 E/CAPI_APPFW_APPLICATION(12629): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:56.269+0200 E/CAPI_APPFW_APPLICATION(12629): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:56.279+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12629
04-23 20:41:56.279+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12629) type(svcapp) bg(0)
04-23 20:41:56.279+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12629) was created
04-23 20:41:56.279+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12629]
04-23 20:41:56.279+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12629)
04-23 20:41:56.289+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:41:56.289+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:56.299+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:56.309+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12629
04-23 20:41:56.309+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:56.319+0200 W/LOCATION(12629): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:56.319+0200 E/LOCATION(12629): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:56.319+0200 E/PKGMGR_INFO(12629): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:56.329+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:56.339+0200 I/LOCATION(12629): location.c: location_new(269) > method: 0
04-23 20:41:56.339+0200 W/LOCATION(12629): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:56.349+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:56.349+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:56.359+0200 W/LOCATION(12629): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:56.359+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:56.359+0200 W/LOCATION(12629): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:56.359+0200 W/LOCATION(12629): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:56.359+0200 W/LOCATION(12629): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:56.359+0200 W/LOCATION(12629): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:56.379+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:56.389+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:56.389+0200 W/LOCATION(12629): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:56.399+0200 W/LOCATION(12629): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:56.399+0200 W/LOCATION(12629): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:56.399+0200 W/LOCATION(12629): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:56.399+0200 W/LOCATION(12629): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:56.419+0200 W/LOCATION(12629): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:56.419+0200 I/LOCATION(12629): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72afc18
04-23 20:41:56.419+0200 I/LOCATION(12629): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:56.419+0200 I/LOCATION(12629): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72afc18
04-23 20:41:56.419+0200 I/LOCATION(12629): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:56.419+0200 I/location(12629): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:56.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:56.459+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12629
04-23 20:41:56.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:56.479+0200 I/LOCATION(12629): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:56.519+0200 W/LOCATION(12629): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:56.519+0200 W/LOCATION(12629): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:56.519+0200 I/LOCATION(12629): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:56.589+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:56.589+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:56.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:56.589+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:56.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:56.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:56.589+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:56.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:56.589+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:56.589+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:56.589+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:56.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:56.639+0200 W/LOCATION(12629): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:56.639+0200 W/LOCATION(12629): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:56.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:56.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:56.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:56.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:56.759+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4200e60]
04-23 20:41:56.759+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:56.759+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:56.759+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:56.759+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:56.769+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:56.769+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:56.779+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:56.789+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:56.789+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:56.789+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:56.789+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:56.789+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:56.789+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:56.789+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:56.789+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:56.789+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:56.789+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:56.799+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:56.809+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:56.809+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:56.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:56.829+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:56.829+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2992097), time2(2978834)
04-23 20:41:56.829+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:41:56.829+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:56.829+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:56.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:56.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:56.879+0200 W/LOCATION(12629): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:56.879+0200 I/LOCATION(12629): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:56.889+0200 I/LOCATION(12629): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:56.889+0200 I/location(12629): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:56.969+0200 I/LOCATION(12629): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:57.019+0200 I/location(12629): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:57.019+0200 W/CAPI_APPFW_APP_CONTROL(12629): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:57.019+0200 I/utils   (12629): specific action
04-23 20:41:57.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:57.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:57.819+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:58.459+0200 W/LOCATION(12629): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:58.609+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11126296c6f63152450891
