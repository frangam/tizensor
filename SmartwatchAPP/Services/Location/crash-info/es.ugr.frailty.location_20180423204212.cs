S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12700
Date: 2018-04-23 20:42:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf751e52d, r5   = 0xf7921f98
r6   = 0xffb889c0, r7   = 0xffb88870
r8   = 0xf791ec18, r9   = 0x00000000
r10  = 0xffb8894c, fp   = 0xffb889c0
ip   = 0x00000001, sp   = 0xffb88848
lr   = 0xf751e539, pc   = 0xf7587228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    131808 KB
Buffers:     40576 KB
Cached:     161580 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11912 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12700 TID = 12700
12700 12703 

Maps Information
f43e9000 f4be8000 rw-p [stack:12703]
f4bef000 f4bf1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bf9000 f4bfd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c06000 f4c08000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c10000 f4c13000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c22000 f4c27000 r-xp /usr/lib/libsystem.so.0.0.0
f4c32000 f4c35000 r-xp /lib/libattr.so.1.1.0
f4c3d000 f4c4d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c55000 f4c5e000 r-xp /usr/lib/libedbus.so.1.7.99
f4c66000 f4c67000 r-xp /usr/lib/libresponse.so.0.2.96
f4c70000 f4c75000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6517000 f661d000 r-xp /usr/lib/libicuuc.so.57.1
f6633000 f67bb000 r-xp /usr/lib/libicui18n.so.57.1
f67cb000 f67d8000 r-xp /usr/lib/libail.so.0.1.0
f67e1000 f67e8000 r-xp /usr/lib/libminizip.so.1.0.0
f67f1000 f699a000 r-xp /usr/lib/libcrypto.so.1.0.0
f69ba000 f6a01000 r-xp /usr/lib/libssl.so.1.0.0
f6a0d000 f6a0f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a17000 f6a1e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a27000 f6a2e000 r-xp /lib/libcrypt-2.13.so
f6a5f000 f6a62000 r-xp /lib/libcap.so.2.21
f6a6a000 f6a6c000 r-xp /usr/lib/libiri.so
f6a74000 f6abd000 r-xp /usr/lib/libmdm.so.1.2.69
f6ac5000 f6acb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ad3000 f6af6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b00000 f6b02000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b0a000 f6b27000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b30000 f6b34000 r-xp /usr/lib/libsmack.so.1.0.0
f6b3d000 f6b56000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b5f000 f6b67000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b6f000 f6b75000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b7e000 f6b80000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b89000 f6b99000 r-xp /lib/libresolv-2.13.so
f6b9d000 f6bb5000 r-xp /usr/lib/liblzma.so.5.0.3
f6bbe000 f6bc0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bc8000 f6be2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bea000 f6c19000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c22000 f6c31000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c3b000 f6c45000 r-xp /usr/lib/libsensord-shared.so
f6c4e000 f6d21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d2c000 f6d42000 r-xp /lib/libz.so.1.2.5
f6d4a000 f6d4f000 r-xp /usr/lib/libffi.so.5.0.10
f6d57000 f6d58000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d60000 f6d70000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d78000 f6d91000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d99000 f6d9b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6da3000 f6e18000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e22000 f6e28000 r-xp /lib/librt-2.13.so
f6e31000 f6e4f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e59000 f6e5a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e62000 f6e85000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e8d000 f6e92000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e9a000 f6ec4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ecd000 f6ee4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6eec000 f6f55000 r-xp /lib/libm-2.13.so
f6f5e000 f6ff2000 r-xp /usr/lib/libstdc++.so.6.0.16
f7005000 f700a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7012000 f7019000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7021000 f704b000 r-xp /usr/lib/libsensor.so.1.9.6
f7054000 f7120000 r-xp /usr/lib/libxml2.so.2.7.8
f712d000 f712f000 r-xp /usr/lib/libiniparser.so.0
f7138000 f713e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7147000 f7217000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7218000 f724c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7255000 f7291000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7299000 f729c000 r-xp /usr/lib/libbundle.so.0.1.22
f72a4000 f72aa000 r-xp /usr/lib/libappsvc.so.0.1.0
f72b2000 f72f3000 r-xp /usr/lib/libeina.so.1.7.99
f72fc000 f7313000 r-xp /usr/lib/libecore.so.1.7.99
f732a000 f7333000 r-xp /usr/lib/libvconf.so.0.2.45
f733b000 f734f000 r-xp /lib/libpthread-2.13.so
f735a000 f7367000 r-xp /usr/lib/libaul.so.0.1.0
f7371000 f7373000 r-xp /lib/libdl-2.13.so
f737c000 f7387000 r-xp /lib/libunwind.so.8.0.1
f73b4000 f73bc000 r-xp /lib/libgcc_s-4.6.so.1
f73bd000 f74e1000 r-xp /lib/libc-2.13.so
f74ef000 f74f1000 r-xp /usr/lib/libdlog.so.0.0.0
f74f9000 f7505000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f750e000 f7513000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f751b000 f752a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7532000 f7536000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f753f000 f7542000 r-xp /usr/lib/libappcore-agent.so.1.1
f754a000 f754c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7554000 f7558000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7560000 f757d000 r-xp /lib/ld-2.13.so
f7586000 f7589000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7589000 f758d000 r-xp /usr/lib/libsys-assert.so
f78ee000 f795c000 rw-p [heap]
ffb6a000 ffb8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12700)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7587228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf751e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72253f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7223c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf722fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7235be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7235dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf726a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72651f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7223c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf722fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7235be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7235dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7267e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7268017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf726ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c071fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bfa171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ccd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf717afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf717c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf730cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7307b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73085a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7308879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7540183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75407fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75875c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73d485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7586f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
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
04-23 20:41:58.609+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11126296c6f631524508918
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:41:58.639+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:41:58.639+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:41:58.639+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:41:58.639+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:41:58.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:58.719+0200 W/AUL     (12643): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:41:58.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:58.719+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:58.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12581
04-23 20:41:58.719+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:58.729+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12581
04-23 20:41:58.729+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12581)
04-23 20:41:58.739+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:58.739+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:58.739+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:58.739+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4200e60
04-23 20:41:58.789+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4200e60]
04-23 20:41:58.789+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:58.789+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:58.789+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:58.789+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:58.799+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:58.799+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:58.809+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:58.819+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:58.819+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:58.819+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:58.819+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:58.819+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:58.819+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:58.819+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:58.819+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:58.819+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:58.819+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:58.829+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:58.839+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:58.839+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:58.839+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:58.889+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:58.899+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:58.939+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:58.939+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:58.939+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:58.939+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4200e60
04-23 20:41:59.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4200ee8]
04-23 20:41:59.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:59.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:59.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:59.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:59.009+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.009+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.019+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.029+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.029+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:59.029+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:59.029+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.029+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:59.029+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:59.029+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:59.029+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.029+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:59.029+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:59.039+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.049+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.049+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:59.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:59.089+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:59.099+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:59.099+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:59.099+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:59.099+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4200ee8
04-23 20:41:59.369+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:41:59.369+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:59.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:59.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:59.379+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12653
04-23 20:41:59.379+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:59.429+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12653
04-23 20:41:59.429+0200 E/CAPI_APPFW_APPLICATION(12653): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:59.429+0200 E/CAPI_APPFW_APPLICATION(12653): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:59.429+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12653) type(svcapp) bg(0)
04-23 20:41:59.429+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12653]
04-23 20:41:59.429+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12653) was created
04-23 20:41:59.439+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12653)
04-23 20:41:59.439+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:41:59.449+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:59.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:59.459+0200 W/LOCATION(12653): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:59.459+0200 E/LOCATION(12653): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:59.459+0200 E/PKGMGR_INFO(12653): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:59.459+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12653
04-23 20:41:59.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:59.489+0200 I/LOCATION(12653): location.c: location_new(269) > method: 0
04-23 20:41:59.489+0200 W/LOCATION(12653): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.489+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.499+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.499+0200 W/LOCATION(12653): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:59.499+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:59.509+0200 W/LOCATION(12653): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:59.509+0200 W/LOCATION(12653): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.509+0200 W/LOCATION(12653): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:59.509+0200 W/LOCATION(12653): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:59.529+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:59.529+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:59.529+0200 W/LOCATION(12653): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:59.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:59.539+0200 W/LOCATION(12653): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:59.549+0200 W/LOCATION(12653): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:59.549+0200 W/LOCATION(12653): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:59.549+0200 W/LOCATION(12653): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:59.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12653
04-23 20:41:59.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:59.569+0200 W/LOCATION(12653): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:59.569+0200 I/LOCATION(12653): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7696c18
04-23 20:41:59.569+0200 I/LOCATION(12653): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:59.569+0200 I/LOCATION(12653): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7696c18
04-23 20:41:59.569+0200 I/LOCATION(12653): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:59.569+0200 I/location(12653): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:59.609+0200 I/LOCATION(12653): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:59.649+0200 W/LOCATION(12653): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:59.649+0200 W/LOCATION(12653): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:59.649+0200 I/LOCATION(12653): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:59.719+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:59.729+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:59.729+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:59.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:59.729+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:59.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:59.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:59.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:59.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:59.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:59.729+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:59.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:59.729+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:59.809+0200 W/LOCATION(12653): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:59.809+0200 W/LOCATION(12653): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:59.879+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:59.919+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79a4300]
04-23 20:41:59.919+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:59.919+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:59.919+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:59.919+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:59.919+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.919+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.929+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.939+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.939+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:59.939+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:59.939+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:59.939+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:59.939+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:59.939+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:59.939+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:59.939+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:59.939+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:59.949+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.959+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:59.959+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:59.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:59.989+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:59.989+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2995259), time2(2992098)
04-23 20:41:59.989+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:41:59.989+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:59.989+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:59.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:59.999+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:00.029+0200 W/LOCATION(12653): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:00.029+0200 I/LOCATION(12653): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:00.029+0200 I/LOCATION(12653): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:00.029+0200 I/location(12653): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:42:00.149+0200 I/LOCATION(12653): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:00.219+0200 I/location(12653): es.ugr.frailty.location: waiting for rigth values
04-23 20:42:00.229+0200 I/location(12653): stopping es.ugr.frailty.location service
04-23 20:42:00.229+0200 E/CAPI_APPFW_APP_CONTROL(12653): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:42:00.229+0200 E/location(12653): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:42:00.229+0200 I/CAPI_APPFW_APPLICATION(12653): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:42:00.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:42:00.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:42:00.289+0200 W/LOCATION(12653): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:00.289+0200 I/LOCATION(12653): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:42:00.289+0200 I/LOCATION(12653): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:42:00.379+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:42:00.379+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:42:00.379+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:42:00.379+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:42:00.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:00.549+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:00.549+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:00.559+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:00.559+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79a4300
04-23 20:42:00.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf7962330]
04-23 20:42:00.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:00.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:00.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:00.609+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:00.609+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:00.609+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:00.619+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.629+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.629+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:00.629+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:00.629+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:00.629+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:00.629+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:00.629+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:00.629+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:00.629+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:00.629+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:00.639+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.649+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.649+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:00.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:00.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:00.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:00.819+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:00.819+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:00.819+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:00.819+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf7962330
04-23 20:42:00.899+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4230da8]
04-23 20:42:00.899+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:00.899+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:00.899+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:00.899+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:00.909+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:00.909+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:00.929+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.939+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.939+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:00.939+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:00.939+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:00.939+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:00.939+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:00.939+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:00.939+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:00.939+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:00.939+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:00.939+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.949+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:00.949+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:00.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:01.009+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:01.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:01.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:01.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:01.009+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4230da8
04-23 20:42:01.219+0200 W/AUL     (12664): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:42:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:42:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:42:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12629
04-23 20:42:01.219+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:42:01.219+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12629
04-23 20:42:01.219+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12629)
04-23 20:42:02.229+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:42:09.599+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:42:09.599+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:42:09.599+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:42:09.599+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:42:09.609+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:42:09.609+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12700
04-23 20:42:09.659+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12700
04-23 20:42:09.659+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12700) type(svcapp) bg(0)
04-23 20:42:09.669+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12700]
04-23 20:42:09.669+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12700)
04-23 20:42:09.669+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:42:09.669+0200 I/servicemanager(12059): App control destroyed.
04-23 20:42:09.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:09.689+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12700
04-23 20:42:09.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:09.699+0200 E/CAPI_APPFW_APPLICATION(12700): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:09.709+0200 E/CAPI_APPFW_APPLICATION(12700): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:09.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:09.719+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12700
04-23 20:42:09.719+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12700) was created
04-23 20:42:09.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:09.749+0200 W/LOCATION(12700): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:42:09.749+0200 E/LOCATION(12700): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:42:09.749+0200 E/PKGMGR_INFO(12700): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:42:09.749+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:09.769+0200 I/LOCATION(12700): location.c: location_new(269) > method: 0
04-23 20:42:09.769+0200 W/LOCATION(12700): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:09.769+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:09.779+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:09.779+0200 W/LOCATION(12700): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:09.789+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:09.789+0200 W/LOCATION(12700): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:09.789+0200 W/LOCATION(12700): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:09.789+0200 W/LOCATION(12700): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:09.789+0200 W/LOCATION(12700): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:09.809+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:09.819+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:09.819+0200 W/LOCATION(12700): module-internal.c: module_new(311) > module (wps) open success
04-23 20:42:09.819+0200 W/LOCATION(12700): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:42:09.819+0200 W/LOCATION(12700): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:42:09.819+0200 W/LOCATION(12700): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:09.829+0200 W/LOCATION(12700): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:09.839+0200 W/LOCATION(12700): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:42:09.839+0200 I/LOCATION(12700): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf791ec18
04-23 20:42:09.839+0200 I/LOCATION(12700): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:42:09.839+0200 I/LOCATION(12700): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf791ec18
04-23 20:42:09.839+0200 I/LOCATION(12700): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:42:09.849+0200 I/location(12700): es.ugr.frailty.location: creado servicio de localización
04-23 20:42:09.889+0200 I/LOCATION(12700): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:42:09.929+0200 W/LOCATION(12700): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:09.929+0200 W/LOCATION(12700): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:09.929+0200 I/LOCATION(12700): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:42:09.999+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:42:09.999+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:09.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:09.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:42:09.999+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:42:09.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:42:09.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:42:09.999+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:42:09.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:42:10.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:42:10.009+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:42:10.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:42:10.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:42:10.049+0200 W/LOCATION(12700): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:10.049+0200 W/LOCATION(12700): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:10.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:10.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4205e40]
04-23 20:42:10.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:10.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:10.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:10.169+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:10.169+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:10.169+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:10.179+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:10.189+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:10.189+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:10.189+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:10.189+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:10.189+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:10.189+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:10.189+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:10.189+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:10.189+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:10.189+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:10.199+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:10.199+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:10.199+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:10.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:10.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:10.269+0200 W/LOCATION(12700): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:10.279+0200 I/LOCATION(12700): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:10.279+0200 I/LOCATION(12700): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:10.279+0200 I/location(12700): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:42:10.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:42:10.289+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3005550), time2(2992098)
04-23 20:42:10.289+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:42:10.289+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:42:10.289+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:42:10.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:42:10.369+0200 I/LOCATION(12700): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:10.409+0200 I/location(12700): es.ugr.frailty.location: waiting for rigth values
04-23 20:42:10.419+0200 W/CAPI_APPFW_APP_CONTROL(12700): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:42:10.419+0200 I/utils   (12700): specific action
04-23 20:42:10.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:10.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:10.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:11.229+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:42:11.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:11.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:11.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:12.519+0200 W/LOCATION(12700): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:42:12.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:12.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:12.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:12.719+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11127006c6f63152450893
