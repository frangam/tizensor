S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12557
Date: 2018-04-23 20:41:45+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf761452d, r5   = 0xf7809f98
r6   = 0xffdfb110, r7   = 0xffdfafc0
r8   = 0xf7806c18, r9   = 0x00000000
r10  = 0xffdfb09c, fp   = 0xffdfb110
ip   = 0x00000001, sp   = 0xffdfaf98
lr   = 0xf7614539, pc   = 0xf767d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    132104 KB
Buffers:     40368 KB
Cached:     161172 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11548 KB
VmRSS:       11548 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12557 TID = 12557
12557 12560 

Maps Information
f44df000 f4cde000 rw-p [stack:12560]
f4ce5000 f4ce7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cef000 f4cf3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cfc000 f4cfe000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d06000 f4d09000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d18000 f4d1d000 r-xp /usr/lib/libsystem.so.0.0.0
f4d28000 f4d2b000 r-xp /lib/libattr.so.1.1.0
f4d33000 f4d43000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d4b000 f4d54000 r-xp /usr/lib/libedbus.so.1.7.99
f4d5c000 f4d5d000 r-xp /usr/lib/libresponse.so.0.2.96
f4d66000 f4d6b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f660d000 f6713000 r-xp /usr/lib/libicuuc.so.57.1
f6729000 f68b1000 r-xp /usr/lib/libicui18n.so.57.1
f68c1000 f68ce000 r-xp /usr/lib/libail.so.0.1.0
f68d7000 f68de000 r-xp /usr/lib/libminizip.so.1.0.0
f68e7000 f6a90000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ab0000 f6af7000 r-xp /usr/lib/libssl.so.1.0.0
f6b03000 f6b05000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b0d000 f6b14000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b1d000 f6b24000 r-xp /lib/libcrypt-2.13.so
f6b55000 f6b58000 r-xp /lib/libcap.so.2.21
f6b60000 f6b62000 r-xp /usr/lib/libiri.so
f6b6a000 f6bb3000 r-xp /usr/lib/libmdm.so.1.2.69
f6bbb000 f6bc1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bc9000 f6bec000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bf6000 f6bf8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c00000 f6c1d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c26000 f6c2a000 r-xp /usr/lib/libsmack.so.1.0.0
f6c33000 f6c4c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c55000 f6c5d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c65000 f6c6b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c74000 f6c76000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c7f000 f6c8f000 r-xp /lib/libresolv-2.13.so
f6c93000 f6cab000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb4000 f6cb6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cbe000 f6cd8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ce0000 f6d0f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d18000 f6d27000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d31000 f6d3b000 r-xp /usr/lib/libsensord-shared.so
f6d44000 f6e17000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e22000 f6e38000 r-xp /lib/libz.so.1.2.5
f6e40000 f6e45000 r-xp /usr/lib/libffi.so.5.0.10
f6e4d000 f6e4e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e56000 f6e66000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e6e000 f6e87000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e8f000 f6e91000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e99000 f6f0e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f18000 f6f1e000 r-xp /lib/librt-2.13.so
f6f27000 f6f45000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f4f000 f6f50000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f58000 f6f7b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f83000 f6f88000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f90000 f6fba000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fc3000 f6fda000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fe2000 f704b000 r-xp /lib/libm-2.13.so
f7054000 f70e8000 r-xp /usr/lib/libstdc++.so.6.0.16
f70fb000 f7100000 r-xp /usr/lib/libctx-client.so.0.8.3
f7108000 f710f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7117000 f7141000 r-xp /usr/lib/libsensor.so.1.9.6
f714a000 f7216000 r-xp /usr/lib/libxml2.so.2.7.8
f7223000 f7225000 r-xp /usr/lib/libiniparser.so.0
f722e000 f7234000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f723d000 f730d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f730e000 f7342000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f734b000 f7387000 r-xp /usr/lib/libSLP-location.so.0.9.24
f738f000 f7392000 r-xp /usr/lib/libbundle.so.0.1.22
f739a000 f73a0000 r-xp /usr/lib/libappsvc.so.0.1.0
f73a8000 f73e9000 r-xp /usr/lib/libeina.so.1.7.99
f73f2000 f7409000 r-xp /usr/lib/libecore.so.1.7.99
f7420000 f7429000 r-xp /usr/lib/libvconf.so.0.2.45
f7431000 f7445000 r-xp /lib/libpthread-2.13.so
f7450000 f745d000 r-xp /usr/lib/libaul.so.0.1.0
f7467000 f7469000 r-xp /lib/libdl-2.13.so
f7472000 f747d000 r-xp /lib/libunwind.so.8.0.1
f74aa000 f74b2000 r-xp /lib/libgcc_s-4.6.so.1
f74b3000 f75d7000 r-xp /lib/libc-2.13.so
f75e5000 f75e7000 r-xp /usr/lib/libdlog.so.0.0.0
f75ef000 f75fb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7604000 f7609000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7611000 f7620000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7628000 f762c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7635000 f7638000 r-xp /usr/lib/libappcore-agent.so.1.1
f7640000 f7642000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f764a000 f764e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7656000 f7673000 r-xp /lib/ld-2.13.so
f767c000 f767f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f767f000 f7683000 r-xp /usr/lib/libsys-assert.so
f77d6000 f7844000 rw-p [heap]
ffddc000 ffdfd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12557)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf767d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7614539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf731b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7319c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7325e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf732bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf732bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf736075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf735b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7319c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7325e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf732bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf732bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf735de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf735e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7365f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cfd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cf0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dc3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7270fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72727a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7402ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73fe879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7636183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76367fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf767d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74ca85c) [/lib/libc.so.6] + 0x1785c
29: (0xf767cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.c: location_new(269) > method: 1
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:30.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:30.329+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:30.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:30.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:30.339+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.339+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:30.339+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:30.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:30.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:30.439+0200 W/LOCATION(12456): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:30.439+0200 I/LOCATION(12456): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:30.439+0200 I/LOCATION(12456): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:30.439+0200 I/location(12456): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:30.539+0200 I/LOCATION(12456): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:30.599+0200 I/location(12456): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:30.599+0200 W/CAPI_APPFW_APP_CONTROL(12456): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:41:30.599+0200 I/utils   (12456): specific action
04-23 20:41:30.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:30.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:30.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:31.349+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:31.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:31.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:31.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:32.139+0200 W/LOCATION(12456): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:32.319+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11124566c6f631524508892
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:41:32.329+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:41:32.329+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:41:32.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:41:32.329+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:41:32.339+0200 W/AUL     (12495): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:41:32.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:32.349+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:32.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12407
04-23 20:41:32.349+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:32.359+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12407
04-23 20:41:32.359+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12407)
04-23 20:41:32.419+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:32.419+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:32.419+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:32.419+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf794fe28
04-23 20:41:32.469+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79589d8]
04-23 20:41:32.469+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:32.469+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:32.469+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:32.469+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:32.479+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:32.479+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:32.489+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.499+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.499+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:32.499+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:32.499+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:32.499+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:32.499+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:32.499+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:32.499+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:32.499+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:32.499+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:32.509+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.519+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.519+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:32.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.629+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:32.629+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:32.629+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:32.629+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79589d8
04-23 20:41:32.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79ce4f0]
04-23 20:41:32.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:32.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:32.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:32.709+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:32.719+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:32.719+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:32.729+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.729+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.729+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:32.729+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:32.729+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:32.729+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:32.729+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:32.729+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:32.729+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:32.729+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:32.729+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:32.739+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.749+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:32.749+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:32.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.759+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:41:32.759+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:32.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:32.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:32.789+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12501
04-23 20:41:32.789+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:32.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:32.839+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12501
04-23 20:41:32.839+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12501) type(svcapp) bg(0)
04-23 20:41:32.839+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12501]
04-23 20:41:32.839+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12501)
04-23 20:41:32.839+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:41:32.839+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:32.849+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:32.849+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:32.849+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:32.849+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79ce4f0
04-23 20:41:32.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:32.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12501
04-23 20:41:32.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:32.919+0200 E/CAPI_APPFW_APPLICATION(12501): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:32.919+0200 E/CAPI_APPFW_APPLICATION(12501): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:32.919+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12501) was created
04-23 20:41:32.949+0200 W/LOCATION(12501): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:32.959+0200 E/LOCATION(12501): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:32.959+0200 E/PKGMGR_INFO(12501): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:32.959+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:32.989+0200 I/LOCATION(12501): location.c: location_new(269) > method: 0
04-23 20:41:32.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:32.999+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12501
04-23 20:41:32.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:33.009+0200 W/LOCATION(12501): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:33.009+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:33.019+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:33.019+0200 W/LOCATION(12501): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:33.029+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:33.029+0200 W/LOCATION(12501): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:33.029+0200 W/LOCATION(12501): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:33.029+0200 W/LOCATION(12501): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:33.029+0200 W/LOCATION(12501): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:33.069+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:33.069+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:33.079+0200 W/LOCATION(12501): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:33.079+0200 W/LOCATION(12501): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:33.089+0200 W/LOCATION(12501): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:33.089+0200 W/LOCATION(12501): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:33.089+0200 W/LOCATION(12501): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:33.109+0200 W/LOCATION(12501): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:33.119+0200 I/LOCATION(12501): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7e85c18
04-23 20:41:33.119+0200 I/LOCATION(12501): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:33.119+0200 I/LOCATION(12501): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7e85c18
04-23 20:41:33.119+0200 I/LOCATION(12501): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:33.119+0200 I/location(12501): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:33.179+0200 I/LOCATION(12501): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:33.229+0200 W/LOCATION(12501): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:33.229+0200 W/LOCATION(12501): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:33.229+0200 I/LOCATION(12501): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:33.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:33.319+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:33.319+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:33.319+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:33.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:33.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:33.319+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:33.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:33.319+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:33.319+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:33.319+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:33.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:33.379+0200 W/LOCATION(12501): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:33.379+0200 W/LOCATION(12501): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:33.449+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:33.479+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4223088]
04-23 20:41:33.479+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:33.479+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:33.479+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:33.479+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:33.489+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:33.489+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:33.499+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:33.509+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:33.509+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:33.509+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:33.509+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:33.509+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:33.509+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:33.509+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:33.509+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:33.509+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:33.509+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:33.519+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:33.519+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:33.519+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:33.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:33.559+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:41:33.559+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2968826), time2(2965547)
04-23 20:41:33.559+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:41:33.559+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:41:33.559+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:41:33.559+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:41:33.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:33.589+0200 W/LOCATION(12501): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:33.589+0200 I/LOCATION(12501): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:33.589+0200 I/LOCATION(12501): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:41:33.589+0200 I/location(12501): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:41:33.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:33.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:33.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:33.689+0200 I/LOCATION(12501): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:33.739+0200 I/location(12501): es.ugr.frailty.location: waiting for rigth values
04-23 20:41:33.739+0200 I/location(12501): stopping es.ugr.frailty.location service
04-23 20:41:33.739+0200 E/CAPI_APPFW_APP_CONTROL(12501): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:41:33.739+0200 E/location(12501): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:41:33.739+0200 I/CAPI_APPFW_APPLICATION(12501): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:41:33.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:41:33.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:41:33.789+0200 W/LOCATION(12501): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:41:33.789+0200 I/LOCATION(12501): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:41:33.789+0200 I/LOCATION(12501): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:41:33.869+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:41:33.869+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:41:33.869+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:41:33.879+0200 E/CAPI_LOCATION_MANAGER(12139): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:41:33.989+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.029+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:34.029+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:34.029+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:34.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4223088
04-23 20:41:34.089+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4223558]
04-23 20:41:34.089+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:34.089+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:34.089+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:34.099+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:34.099+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:34.099+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:34.109+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.119+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.119+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:34.119+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:34.119+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:34.119+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:34.119+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:34.119+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:34.119+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:34.119+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:34.119+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:34.129+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.139+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.139+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:34.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.239+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:34.239+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:34.239+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:34.239+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4223558
04-23 20:41:34.299+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf42230b8]
04-23 20:41:34.299+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:34.299+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:34.299+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:34.299+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:34.309+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:34.309+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:34.319+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.319+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.329+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:34.329+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:34.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:34.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:34.329+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:34.329+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:34.329+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:34.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:34.329+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:34.329+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.349+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:34.349+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:41:34.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:34.399+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:41:34.399+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:41:34.399+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:41:34.399+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf42230b8
04-23 20:41:34.599+0200 W/AUL     (12518): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:41:34.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:41:34.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:41:34.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12456
04-23 20:41:34.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:41:34.609+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12456
04-23 20:41:34.609+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12456)
04-23 20:41:35.749+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:41:42.929+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:41:42.929+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:42.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:42.929+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:42.939+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12557
04-23 20:41:42.939+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:41:42.989+0200 E/CAPI_APPFW_APPLICATION(12557): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:42.989+0200 E/CAPI_APPFW_APPLICATION(12557): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:41:42.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12557
04-23 20:41:42.989+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12557) type(svcapp) bg(0)
04-23 20:41:42.989+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12557)
04-23 20:41:42.989+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:41:42.989+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:42.989+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12557]
04-23 20:41:43.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:43.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12557
04-23 20:41:43.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:43.019+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12557) was created
04-23 20:41:43.039+0200 W/LOCATION(12557): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:41:43.039+0200 E/LOCATION(12557): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:41:43.039+0200 E/PKGMGR_INFO(12557): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:41:43.049+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:43.069+0200 I/LOCATION(12557): location.c: location_new(269) > method: 0
04-23 20:41:43.069+0200 W/LOCATION(12557): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:43.069+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:43.079+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:43.079+0200 W/LOCATION(12557): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:43.089+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:43.089+0200 W/LOCATION(12557): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:43.089+0200 W/LOCATION(12557): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:43.089+0200 W/LOCATION(12557): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:43.089+0200 W/LOCATION(12557): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:43.109+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:43.109+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:41:43.119+0200 W/LOCATION(12557): module-internal.c: module_new(311) > module (wps) open success
04-23 20:41:43.119+0200 W/LOCATION(12557): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:41:43.129+0200 W/LOCATION(12557): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:41:43.129+0200 W/LOCATION(12557): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:43.129+0200 W/LOCATION(12557): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:43.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:41:43.149+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12557
04-23 20:41:43.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:41:43.159+0200 W/LOCATION(12557): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:41:43.159+0200 I/LOCATION(12557): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7806c18
04-23 20:41:43.159+0200 I/LOCATION(12557): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:41:43.159+0200 I/LOCATION(12557): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7806c18
04-23 20:41:43.159+0200 I/LOCATION(12557): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:41:43.169+0200 I/location(12557): es.ugr.frailty.location: creado servicio de localización
04-23 20:41:43.209+0200 I/LOCATION(12557): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:41:43.249+0200 W/LOCATION(12557): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:41:43.249+0200 W/LOCATION(12557): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:41:43.249+0200 I/LOCATION(12557): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:41:43.319+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:41:43.319+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:41:43.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:41:43.329+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:41:43.329+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:41:43.329+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:41:43.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:43.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:43.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:41:43.329+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:41:43.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:41:43.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:41:43.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:41:43.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:41:43.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:41:43.329+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:41:43.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:41:43.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:41:43.389+0200 W/LOCATION(12557): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:41:43.389+0200 W/LOCATION(12557): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:41:43.459+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:41:43.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf795c8c0]
04-23 20:41:43.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:41:43.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:41:43.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:41:43.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:41:43.519+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:43.519+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:43.529+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:43.529+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:41:43.529+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:41:43.529+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:41:43.529+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:41:43.529+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:41:43.529+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:41:43.529+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:41:43.529+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:41:43.529+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
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
04-23 20:41:45.279+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11125576c6f63152450890
