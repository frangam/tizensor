S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20831
Date: 2018-04-23 15:58:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74be52d, r5   = 0xf7b37f98
r6   = 0xffbf17a8, r7   = 0xffbf1658
r8   = 0xf7b34c18, r9   = 0x00000000
r10  = 0xffbf1734, fp   = 0xffbf17a8
ip   = 0x00000001, sp   = 0xffbf04d8
lr   = 0xf74be539, pc   = 0xf75272b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11588 KB
Buffers:     58780 KB
Cached:     230988 KB
VmPeak:      53604 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12024 KB
VmRSS:       12024 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20831 TID = 20831
20831 20834 

Maps Information
f4389000 f4b88000 rw-p [stack:20834]
f4b8f000 f4b91000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b99000 f4b9d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ba6000 f4ba8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bb0000 f4bb3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bc2000 f4bc7000 r-xp /usr/lib/libsystem.so.0.0.0
f4bd2000 f4bd5000 r-xp /lib/libattr.so.1.1.0
f4bdd000 f4bed000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bf5000 f4bfe000 r-xp /usr/lib/libedbus.so.1.7.99
f4c06000 f4c07000 r-xp /usr/lib/libresponse.so.0.2.96
f4c10000 f4c15000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64b7000 f65bd000 r-xp /usr/lib/libicuuc.so.57.1
f65d3000 f675b000 r-xp /usr/lib/libicui18n.so.57.1
f676b000 f6778000 r-xp /usr/lib/libail.so.0.1.0
f6781000 f6788000 r-xp /usr/lib/libminizip.so.1.0.0
f6791000 f693a000 r-xp /usr/lib/libcrypto.so.1.0.0
f695a000 f69a1000 r-xp /usr/lib/libssl.so.1.0.0
f69ad000 f69af000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69b7000 f69be000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69c7000 f69ce000 r-xp /lib/libcrypt-2.13.so
f69ff000 f6a02000 r-xp /lib/libcap.so.2.21
f6a0a000 f6a0c000 r-xp /usr/lib/libiri.so
f6a14000 f6a5d000 r-xp /usr/lib/libmdm.so.1.2.69
f6a65000 f6a6b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a73000 f6a96000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aa0000 f6aa2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aaa000 f6ac7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ad0000 f6ad4000 r-xp /usr/lib/libsmack.so.1.0.0
f6add000 f6af6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aff000 f6b07000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b0f000 f6b15000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b1e000 f6b20000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b29000 f6b39000 r-xp /lib/libresolv-2.13.so
f6b3d000 f6b55000 r-xp /usr/lib/liblzma.so.5.0.3
f6b5e000 f6b60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b68000 f6b82000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b8a000 f6bb9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bc2000 f6bd1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bdb000 f6be5000 r-xp /usr/lib/libsensord-shared.so
f6bee000 f6cc1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ccc000 f6ce2000 r-xp /lib/libz.so.1.2.5
f6cea000 f6cef000 r-xp /usr/lib/libffi.so.5.0.10
f6cf7000 f6cf8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d00000 f6d10000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d18000 f6d31000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d39000 f6d3b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d43000 f6db8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dc2000 f6dc8000 r-xp /lib/librt-2.13.so
f6dd1000 f6def000 r-xp /usr/lib/libsystemd.so.0.4.0
f6df9000 f6dfa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e02000 f6e25000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e2d000 f6e32000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e3a000 f6e64000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e6d000 f6e84000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e8c000 f6ef5000 r-xp /lib/libm-2.13.so
f6efe000 f6f92000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fa5000 f6faa000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fb2000 f6fb9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fc1000 f6feb000 r-xp /usr/lib/libsensor.so.1.9.6
f6ff4000 f70c0000 r-xp /usr/lib/libxml2.so.2.7.8
f70cd000 f70cf000 r-xp /usr/lib/libiniparser.so.0
f70d8000 f70de000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70e7000 f71b7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71b8000 f71ec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71f5000 f7231000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7239000 f723c000 r-xp /usr/lib/libbundle.so.0.1.22
f7244000 f724a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7252000 f7293000 r-xp /usr/lib/libeina.so.1.7.99
f729c000 f72b3000 r-xp /usr/lib/libecore.so.1.7.99
f72ca000 f72d3000 r-xp /usr/lib/libvconf.so.0.2.45
f72db000 f72ef000 r-xp /lib/libpthread-2.13.so
f72fa000 f7307000 r-xp /usr/lib/libaul.so.0.1.0
f7311000 f7313000 r-xp /lib/libdl-2.13.so
f731c000 f7327000 r-xp /lib/libunwind.so.8.0.1
f7354000 f735c000 r-xp /lib/libgcc_s-4.6.so.1
f735d000 f7481000 r-xp /lib/libc-2.13.so
f748f000 f7491000 r-xp /usr/lib/libdlog.so.0.0.0
f7499000 f74a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74ae000 f74b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74bb000 f74ca000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74d2000 f74d6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74df000 f74e2000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ea000 f74ec000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74f4000 f74f8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7500000 f751d000 r-xp /lib/ld-2.13.so
f7526000 f7529000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7529000 f752d000 r-xp /usr/lib/libsys-assert.so
f7b04000 f7b8d000 rw-p [heap]
ffbd2000 ffbf3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20831)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75272b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74be539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71c53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71c3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71cfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71d5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71d5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf720a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72051f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71c3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71cfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71d5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71d5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7207e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7208017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf720c8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74f60bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b9a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c6d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf711afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf711c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72acca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72a7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72a85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72a8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74e0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74e07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75276a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf737485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7526fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
 15:58:55.591+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:55.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:55.591+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:55.591+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:55.591+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:55.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:55.591+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:55.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:55.591+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:55.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:55.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:55.591+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:55.591+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:55.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:55.601+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:55.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:55.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:55.681+0200 W/LOCATION(20925): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:55.681+0200 W/LOCATION(20925): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:55.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:55.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7341b08]
04-23 15:58:55.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:55.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:55.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:55.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:55.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:55.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:55.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:55.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:55.831+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:55.831+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:55.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:55.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:55.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:55.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:55.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:55.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:55.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:55.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:55.841+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5831501), time2(5820709)
04-23 15:58:55.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:58:55.841+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:55.841+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:55.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:55.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:55.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:55.841+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:55.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:55.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:55.911+0200 W/LOCATION(20925): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:55.911+0200 I/LOCATION(20925): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:55.911+0200 I/LOCATION(20925): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:55.911+0200 I/location(20925): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:56.011+0200 I/LOCATION(20925): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:56.051+0200 W/AUL     (20925): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:56.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:56.061+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20925
04-23 15:58:56.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:56.071+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:56.071+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:56.071+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:56.071+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.071+0200 I/utils   (19708): specific action
04-23 15:58:56.071+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.071+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.071+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.071+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:56.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:56.071+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:56.081+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:56.081+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:56.081+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 I/utils   (19713): specific action
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:56.081+0200 I/recorder(19713): guardando datos en local
04-23 15:58:56.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:56.081+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:56.081+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:56.081+0200 W/AUL     (20925): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:56.081+0200 I/location(20925): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:56.081+0200 W/CAPI_APPFW_APP_CONTROL(20925): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:56.081+0200 I/utils   (20925): specific action
04-23 15:58:56.091+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11207356c6f631524491923
04-23 15:58:56.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:56.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:56.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:56.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:56.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:56.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:56.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:56.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:56.441+0200 I/LOCATION(20925): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:56.611+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:56.611+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:56.611+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:56.611+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:56.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:56.631+0200 W/AUL     (20955): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20910
04-23 15:58:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:56.641+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20910
04-23 15:58:56.641+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20910)
04-23 15:58:56.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:56.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:56.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:56.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7341b08
04-23 15:58:56.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734bbe8]
04-23 15:58:56.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:56.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:56.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:56.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:56.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:56.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:56.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.831+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:56.831+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:56.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:56.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:56.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:56.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:56.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:56.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:56.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:56.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:56.851+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:56.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:56.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:56.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:56.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:56.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:56.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:56.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734bbe8
04-23 15:58:57.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e05b78]
04-23 15:58:57.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:57.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:57.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:57.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:57.051+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:57.051+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:57.051+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:57.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:57.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:57.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:57.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:57.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:57.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:57.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:57.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:57.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:57.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:57.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:57.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:57.091+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:57.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:57.121+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:57.121+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:57.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:57.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:57.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20972
04-23 15:58:57.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:57.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20972
04-23 15:58:57.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20972) type(svcapp) bg(0)
04-23 15:58:57.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20972)
04-23 15:58:57.181+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:57.181+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:57.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20972]
04-23 15:58:57.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:57.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:57.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:57.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:57.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e05b78
04-23 15:58:57.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:57.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20972
04-23 15:58:57.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:57.241+0200 E/CAPI_APPFW_APPLICATION(20972): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:57.241+0200 E/CAPI_APPFW_APPLICATION(20972): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:57.241+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20972) was created
04-23 15:58:57.271+0200 W/LOCATION(20972): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:57.271+0200 E/LOCATION(20972): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:57.271+0200 E/PKGMGR_INFO(20972): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:57.281+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:57.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:57.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20972
04-23 15:58:57.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:57.341+0200 I/LOCATION(20972): location.c: location_new(269) > method: 0
04-23 15:58:57.341+0200 W/LOCATION(20972): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:57.381+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:57.391+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:57.391+0200 W/LOCATION(20972): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:57.401+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:57.401+0200 W/LOCATION(20972): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:57.401+0200 W/LOCATION(20972): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:57.401+0200 W/LOCATION(20972): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:57.401+0200 W/LOCATION(20972): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:57.421+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:57.421+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:57.431+0200 W/LOCATION(20972): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:57.431+0200 W/LOCATION(20972): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:57.431+0200 W/LOCATION(20972): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:57.431+0200 W/LOCATION(20972): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:57.431+0200 W/LOCATION(20972): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:57.591+0200 W/LOCATION(20972): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:57.591+0200 I/LOCATION(20972): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7ba9c18
04-23 15:58:57.591+0200 I/LOCATION(20972): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:57.591+0200 I/LOCATION(20972): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7ba9c18
04-23 15:58:57.591+0200 I/LOCATION(20972): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:57.591+0200 I/location(20972): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:57.641+0200 I/LOCATION(20972): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:57.681+0200 W/LOCATION(20972): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:57.681+0200 W/LOCATION(20972): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:57.681+0200 I/LOCATION(20972): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:57.781+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:57.781+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:57.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:57.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:57.781+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:57.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:57.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:57.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:57.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:57.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:57.781+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:57.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:57.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:57.851+0200 W/LOCATION(20972): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:57.851+0200 W/LOCATION(20972): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:57.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:57.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e234d0]
04-23 15:58:57.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:57.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:57.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:57.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:57.981+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:57.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:58.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.001+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:58.001+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:58.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:58.001+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:58.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:58.001+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:58.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:58.001+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:58.001+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:58.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.021+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:58.021+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5833682), time2(5831501)
04-23 15:58:58.021+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:58.021+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:58.021+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:58.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:58.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:58.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:58.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:58.111+0200 W/LOCATION(20972): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:58.111+0200 I/LOCATION(20972): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:58.111+0200 I/LOCATION(20972): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:58.111+0200 I/location(20972): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:58.211+0200 I/LOCATION(20972): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:58.271+0200 W/AUL     (20972): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:58.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:58.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20972
04-23 15:58:58.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:58.281+0200 W/AUL     (20972): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:58.281+0200 I/location(20972): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:58.281+0200 I/location(20972): stopping es.ugr.frailty.location service
04-23 15:58:58.281+0200 E/CAPI_APPFW_APP_CONTROL(20972): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:58.281+0200 E/location(20972): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:58.281+0200 I/CAPI_APPFW_APPLICATION(20972): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:58.291+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:58.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:58.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.291+0200 I/utils   (19708): specific action
04-23 15:58:58.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:58.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:58.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:58.301+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.301+0200 I/utils   (19713): specific action
04-23 15:58:58.301+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.301+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.301+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.301+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:58.301+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:58.301+0200 I/recorder(19713): guardando datos en local
04-23 15:58:58.301+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:58.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:58.301+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:58.301+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:58.301+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:58.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:58.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:58.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:58.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:58.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:58.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:58.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:58.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:58.421+0200 W/LOCATION(20972): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:58.421+0200 I/LOCATION(20972): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:58.421+0200 I/LOCATION(20972): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:58.501+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:58.501+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:58.501+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:58.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:58.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:58.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:58.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:58.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:58.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e234d0
04-23 15:58:58.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733f9f8]
04-23 15:58:58.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:58.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:58.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:58.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:58.801+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:58.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:58.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.821+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:58.821+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:58.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:58.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:58.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:58.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:58.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:58.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:58.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:58.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:58.831+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:58.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:58.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:58.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:59.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:59.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:59.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:59.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733f9f8
04-23 15:58:59.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73758e8]
04-23 15:58:59.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:59.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:59.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:59.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:59.091+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:59.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:59.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:59.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:59.111+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:59.111+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:59.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:59.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:59.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:59.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:59.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:59.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:59.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:59.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:59.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:59.131+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:59.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:59.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:59.191+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:59.191+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:59.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:59.191+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:59.201+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20972
04-23 15:58:59.201+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20972)
04-23 15:58:59.201+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:59.201+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:59.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:59.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:59.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:59.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73758e8
04-23 15:58:59.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:58:59.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:59.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20972), cmd(0)
04-23 15:58:59.411+0200 W/AUL     (20990): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:59.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:59.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:59.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20925
04-23 15:58:59.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:59.421+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20925
04-23 15:58:59.421+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20925)
04-23 15:59:00.101+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11208316c6f63152449192
