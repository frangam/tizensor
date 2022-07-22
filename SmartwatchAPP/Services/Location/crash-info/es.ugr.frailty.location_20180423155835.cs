S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20651
Date: 2018-04-23 15:58:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf733452d, r5   = 0xf7a69f98
r6   = 0xffbd7708, r7   = 0xffbd75b8
r8   = 0xf7a66c18, r9   = 0x00000000
r10  = 0xffbd7694, fp   = 0xffbd7708
ip   = 0x00000001, sp   = 0xffbd6438
lr   = 0xf7334539, pc   = 0xf739d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11868 KB
Buffers:     58648 KB
Cached:     230056 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11640 KB
VmRSS:       11640 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20651 TID = 20651
20651 20654 

Maps Information
f41ff000 f49fe000 rw-p [stack:20654]
f4a05000 f4a07000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a0f000 f4a13000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a1c000 f4a1e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a26000 f4a29000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a38000 f4a3d000 r-xp /usr/lib/libsystem.so.0.0.0
f4a48000 f4a4b000 r-xp /lib/libattr.so.1.1.0
f4a53000 f4a63000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a6b000 f4a74000 r-xp /usr/lib/libedbus.so.1.7.99
f4a7c000 f4a7d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a86000 f4a8b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f632d000 f6433000 r-xp /usr/lib/libicuuc.so.57.1
f6449000 f65d1000 r-xp /usr/lib/libicui18n.so.57.1
f65e1000 f65ee000 r-xp /usr/lib/libail.so.0.1.0
f65f7000 f65fe000 r-xp /usr/lib/libminizip.so.1.0.0
f6607000 f67b0000 r-xp /usr/lib/libcrypto.so.1.0.0
f67d0000 f6817000 r-xp /usr/lib/libssl.so.1.0.0
f6823000 f6825000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f682d000 f6834000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f683d000 f6844000 r-xp /lib/libcrypt-2.13.so
f6875000 f6878000 r-xp /lib/libcap.so.2.21
f6880000 f6882000 r-xp /usr/lib/libiri.so
f688a000 f68d3000 r-xp /usr/lib/libmdm.so.1.2.69
f68db000 f68e1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68e9000 f690c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6916000 f6918000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6920000 f693d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6946000 f694a000 r-xp /usr/lib/libsmack.so.1.0.0
f6953000 f696c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6975000 f697d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6985000 f698b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6994000 f6996000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f699f000 f69af000 r-xp /lib/libresolv-2.13.so
f69b3000 f69cb000 r-xp /usr/lib/liblzma.so.5.0.3
f69d4000 f69d6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69de000 f69f8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a00000 f6a2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a38000 f6a47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a51000 f6a5b000 r-xp /usr/lib/libsensord-shared.so
f6a64000 f6b37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b42000 f6b58000 r-xp /lib/libz.so.1.2.5
f6b60000 f6b65000 r-xp /usr/lib/libffi.so.5.0.10
f6b6d000 f6b6e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b76000 f6b86000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b8e000 f6ba7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6baf000 f6bb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bb9000 f6c2e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c38000 f6c3e000 r-xp /lib/librt-2.13.so
f6c47000 f6c65000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c6f000 f6c70000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c78000 f6c9b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ca3000 f6ca8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cb0000 f6cda000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ce3000 f6cfa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d02000 f6d6b000 r-xp /lib/libm-2.13.so
f6d74000 f6e08000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e1b000 f6e20000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e28000 f6e2f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e37000 f6e61000 r-xp /usr/lib/libsensor.so.1.9.6
f6e6a000 f6f36000 r-xp /usr/lib/libxml2.so.2.7.8
f6f43000 f6f45000 r-xp /usr/lib/libiniparser.so.0
f6f4e000 f6f54000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f5d000 f702d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f702e000 f7062000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f706b000 f70a7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70af000 f70b2000 r-xp /usr/lib/libbundle.so.0.1.22
f70ba000 f70c0000 r-xp /usr/lib/libappsvc.so.0.1.0
f70c8000 f7109000 r-xp /usr/lib/libeina.so.1.7.99
f7112000 f7129000 r-xp /usr/lib/libecore.so.1.7.99
f7140000 f7149000 r-xp /usr/lib/libvconf.so.0.2.45
f7151000 f7165000 r-xp /lib/libpthread-2.13.so
f7170000 f717d000 r-xp /usr/lib/libaul.so.0.1.0
f7187000 f7189000 r-xp /lib/libdl-2.13.so
f7192000 f719d000 r-xp /lib/libunwind.so.8.0.1
f71ca000 f71d2000 r-xp /lib/libgcc_s-4.6.so.1
f71d3000 f72f7000 r-xp /lib/libc-2.13.so
f7305000 f7307000 r-xp /usr/lib/libdlog.so.0.0.0
f730f000 f731b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7324000 f7329000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7331000 f7340000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7348000 f734c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7355000 f7358000 r-xp /usr/lib/libappcore-agent.so.1.1
f7360000 f7362000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f736a000 f736e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7376000 f7393000 r-xp /lib/ld-2.13.so
f739c000 f739f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f739f000 f73a3000 r-xp /usr/lib/libsys-assert.so
f7a36000 f7abf000 rw-p [heap]
ffbb8000 ffbd9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20651)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf739d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7334539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf703b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7039c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7045e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf704bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf704bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf708075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf707b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7039c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7045e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf704bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf704bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf707de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf707e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70828d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf736c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4a10171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ae3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f90fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f927a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7122ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf711db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf711e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf711e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7356183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73567fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf739d6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf71ea85c) [/lib/libc.so.6] + 0x1785c
29: (0xf739cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
FO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:58:42.941+0200 I/heartrate(20378): es.ugr.frailty.heartrate listener destroyed
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:43.011+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:43.011+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:43.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:43.011+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:43.011+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:43.011+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:43.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:43.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:43.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:43.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:43.021+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:43.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:43.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:43.081+0200 W/AUL     (20771): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 15:58:43.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:43.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:43.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20378
04-23 15:58:43.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:43.091+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20378
04-23 15:58:43.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20378)
04-23 15:58:43.131+0200 W/LOCATION(20735): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:43.131+0200 W/LOCATION(20735): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:43.151+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:43.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:43.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73763e0]
04-23 15:58:43.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:43.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:43.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:43.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:43.271+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:43.271+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:43.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.291+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.291+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:43.291+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:43.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:43.291+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:43.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:43.291+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:43.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:43.291+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:43.291+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:43.301+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:43.301+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5818961), time2(5810320)
04-23 15:58:43.301+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:43.301+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:43.301+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:43.301+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:43.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.311+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:43.311+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:43.361+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:43.401+0200 W/LOCATION(20735): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:43.401+0200 I/LOCATION(20735): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:43.401+0200 I/LOCATION(20735): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:43.401+0200 I/location(20735): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:43.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:43.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:43.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:43.411+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:43.411+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:43.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:43.431+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:43.431+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:43.431+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:43.511+0200 I/LOCATION(20735): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:43.561+0200 W/AUL     (20735): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:43.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:43.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20735
04-23 15:58:43.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:43.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:43.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:43.581+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.581+0200 I/utils   (19708): specific action
04-23 15:58:43.581+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.581+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.581+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.581+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:43.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:43.581+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:43.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:43.591+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:43.591+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:43.591+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:43.601+0200 W/AUL     (20735): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 I/utils   (19713): specific action
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:43.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:43.601+0200 I/recorder(19713): guardando datos en local
04-23 15:58:43.601+0200 I/location(20735): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:43.601+0200 W/CAPI_APPFW_APP_CONTROL(20735): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:43.601+0200 I/utils   (20735): specific action
04-23 15:58:43.651+0200 I/LOCATION(20735): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:43.831+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:43.831+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:43.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:43.841+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:43.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:43.881+0200 W/AUL     (20784): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:43.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:43.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:43.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20721
04-23 15:58:43.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:43.881+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20721
04-23 15:58:43.881+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20721)
04-23 15:58:43.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:43.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:43.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:43.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73763e0
04-23 15:58:43.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a610]
04-23 15:58:43.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:43.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:43.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:43.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:43.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:43.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.011+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:44.011+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:44.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:44.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:44.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:44.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:44.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:44.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:44.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:44.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:44.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:44.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:44.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a610
04-23 15:58:44.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a610]
04-23 15:58:44.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:44.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:44.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:44.211+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:44.221+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:44.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.231+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:44.231+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:44.231+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.231+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:44.231+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:44.231+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:44.231+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:44.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:44.231+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:44.241+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.251+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:44.251+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:44.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.311+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:44.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:44.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:44.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a610
04-23 15:58:44.451+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:44.451+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:44.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:44.451+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:44.461+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:44.461+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20791
04-23 15:58:44.511+0200 E/CAPI_APPFW_APPLICATION(20791): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:44.511+0200 E/CAPI_APPFW_APPLICATION(20791): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:44.531+0200 W/LOCATION(20791): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:44.531+0200 E/LOCATION(20791): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:44.531+0200 E/PKGMGR_INFO(20791): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:44.531+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.551+0200 I/LOCATION(20791): location.c: location_new(269) > method: 0
04-23 15:58:44.551+0200 W/LOCATION(20791): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:44.551+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20791
04-23 15:58:44.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20791) type(svcapp) bg(0)
04-23 15:58:44.561+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20791) was created
04-23 15:58:44.561+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20791)
04-23 15:58:44.561+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:44.561+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:44.561+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:44.561+0200 W/LOCATION(20791): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:44.571+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:44.571+0200 W/LOCATION(20791): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:44.571+0200 W/LOCATION(20791): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:44.571+0200 W/LOCATION(20791): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:44.571+0200 W/LOCATION(20791): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:44.591+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:44.591+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:44.591+0200 W/LOCATION(20791): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:44.601+0200 W/LOCATION(20791): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:44.601+0200 W/LOCATION(20791): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:44.601+0200 W/LOCATION(20791): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:44.601+0200 W/LOCATION(20791): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:44.621+0200 W/LOCATION(20791): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:44.621+0200 I/LOCATION(20791): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf763fc18
04-23 15:58:44.621+0200 I/LOCATION(20791): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:44.621+0200 I/LOCATION(20791): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf763fc18
04-23 15:58:44.621+0200 I/LOCATION(20791): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:44.621+0200 I/location(20791): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:44.631+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20791]
04-23 15:58:44.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:44.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20791
04-23 15:58:44.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:44.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:44.681+0200 I/LOCATION(20791): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:44.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20791
04-23 15:58:44.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:44.721+0200 W/LOCATION(20791): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:44.721+0200 W/LOCATION(20791): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:44.721+0200 I/LOCATION(20791): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:44.801+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:44.801+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:44.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:44.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:44.801+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:44.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:44.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:44.801+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:44.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:44.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:44.811+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:44.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:44.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:44.841+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:44.881+0200 W/LOCATION(20791): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:44.881+0200 W/LOCATION(20791): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:44.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:44.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73763e0]
04-23 15:58:44.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:44.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:44.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:44.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:45.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:45.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:45.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:45.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:45.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:45.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:45.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:45.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:45.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:45.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:45.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:45.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.031+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:45.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.041+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:45.041+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5820709), time2(5810320)
04-23 15:58:45.041+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:58:45.041+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:45.041+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:45.041+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:45.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.121+0200 W/LOCATION(20791): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:45.121+0200 I/LOCATION(20791): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:45.121+0200 I/LOCATION(20791): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:45.121+0200 I/location(20791): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:45.211+0200 I/LOCATION(20791): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:45.261+0200 W/AUL     (20791): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:45.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:45.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20791
04-23 15:58:45.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:45.271+0200 W/AUL     (20791): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:45.271+0200 I/location(20791): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:45.271+0200 I/location(20791): stopping es.ugr.frailty.location service
04-23 15:58:45.271+0200 E/CAPI_APPFW_APP_CONTROL(20791): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:45.271+0200 E/location(20791): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:45.271+0200 I/CAPI_APPFW_APPLICATION(20791): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:45.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.271+0200 I/utils   (19708): specific action
04-23 15:58:45.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:45.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:45.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:45.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:45.281+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:45.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:45.291+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.291+0200 I/utils   (19713): specific action
04-23 15:58:45.291+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.291+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.291+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.291+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:45.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:45.291+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:45.291+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:45.291+0200 I/recorder(19713): guardando datos en local
04-23 15:58:45.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:45.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:45.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:45.291+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:45.291+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:45.371+0200 W/LOCATION(20791): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:45.371+0200 I/LOCATION(20791): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:45.371+0200 I/LOCATION(20791): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:45.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:45.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:45.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:45.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:45.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:45.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:45.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:45.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:45.481+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:45.481+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:45.481+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:45.481+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:45.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:45.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:45.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:45.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73763e0
04-23 15:58:45.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73493b8]
04-23 15:58:45.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:45.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:45.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:45.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:45.721+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:45.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:45.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.741+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:45.741+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:45.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:45.741+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:45.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:45.741+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:45.741+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:45.741+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:45.741+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:45.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:45.761+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:45.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:45.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:45.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:45.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:45.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73493b8
04-23 15:58:45.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73618f8]
04-23 15:58:45.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:45.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:45.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:45.961+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:45.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:45.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:45.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:46.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:46.001+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:46.001+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:46.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:46.001+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:46.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:46.001+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:46.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:46.001+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:46.001+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:46.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:46.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:46.011+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:46.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:46.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:46.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:46.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:46.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:46.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73618f8
04-23 15:58:46.261+0200 W/AUL     (20801): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:46.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:46.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:46.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20735
04-23 15:58:46.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:46.261+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20735
04-23 15:58:46.261+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20735)
04-23 15:58:46.281+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11206516c6f63152449191
