S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28664
Date: 2018-04-23 17:01:06+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73fa52d, r5   = 0xf7ab8f98
r6   = 0xff8029b0, r7   = 0xff802860
r8   = 0xf7ab5c18, r9   = 0x00000000
r10  = 0xff80293c, fp   = 0xff8029b0
ip   = 0x00000001, sp   = 0xff8016e0
lr   = 0xf73fa539, pc   = 0xf74632b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16400 KB
Buffers:     64896 KB
Cached:     221876 KB
VmPeak:      53460 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12028 KB
VmRSS:       12028 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28664 TID = 28664
28664 28667 

Maps Information
f42c5000 f4ac4000 rw-p [stack:28667]
f4acb000 f4acd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad5000 f4ad9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ae2000 f4ae4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4aec000 f4aef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4afe000 f4b03000 r-xp /usr/lib/libsystem.so.0.0.0
f4b0e000 f4b11000 r-xp /lib/libattr.so.1.1.0
f4b19000 f4b29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b31000 f4b3a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b42000 f4b43000 r-xp /usr/lib/libresponse.so.0.2.96
f4b4c000 f4b51000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63f3000 f64f9000 r-xp /usr/lib/libicuuc.so.57.1
f650f000 f6697000 r-xp /usr/lib/libicui18n.so.57.1
f66a7000 f66b4000 r-xp /usr/lib/libail.so.0.1.0
f66bd000 f66c4000 r-xp /usr/lib/libminizip.so.1.0.0
f66cd000 f6876000 r-xp /usr/lib/libcrypto.so.1.0.0
f6896000 f68dd000 r-xp /usr/lib/libssl.so.1.0.0
f68e9000 f68eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68f3000 f68fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6903000 f690a000 r-xp /lib/libcrypt-2.13.so
f693b000 f693e000 r-xp /lib/libcap.so.2.21
f6946000 f6948000 r-xp /usr/lib/libiri.so
f6950000 f6999000 r-xp /usr/lib/libmdm.so.1.2.69
f69a1000 f69a7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69af000 f69d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69dc000 f69de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e6000 f6a03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a0c000 f6a10000 r-xp /usr/lib/libsmack.so.1.0.0
f6a19000 f6a32000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a3b000 f6a43000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a4b000 f6a51000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a5a000 f6a5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a65000 f6a75000 r-xp /lib/libresolv-2.13.so
f6a79000 f6a91000 r-xp /usr/lib/liblzma.so.5.0.3
f6a9a000 f6a9c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa4000 f6abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac6000 f6af5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6afe000 f6b0d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b17000 f6b21000 r-xp /usr/lib/libsensord-shared.so
f6b2a000 f6bfd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c08000 f6c1e000 r-xp /lib/libz.so.1.2.5
f6c26000 f6c2b000 r-xp /usr/lib/libffi.so.5.0.10
f6c33000 f6c34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c3c000 f6c4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c54000 f6c6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c75000 f6c77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c7f000 f6cf4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfe000 f6d04000 r-xp /lib/librt-2.13.so
f6d0d000 f6d2b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d35000 f6d36000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3e000 f6d61000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d69000 f6d6e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d76000 f6da0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da9000 f6dc0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc8000 f6e31000 r-xp /lib/libm-2.13.so
f6e3a000 f6ece000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ee1000 f6ee6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eee000 f6ef5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6efd000 f6f27000 r-xp /usr/lib/libsensor.so.1.9.6
f6f30000 f6ffc000 r-xp /usr/lib/libxml2.so.2.7.8
f7009000 f700b000 r-xp /usr/lib/libiniparser.so.0
f7014000 f701a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7023000 f70f3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f4000 f7128000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7131000 f716d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7175000 f7178000 r-xp /usr/lib/libbundle.so.0.1.22
f7180000 f7186000 r-xp /usr/lib/libappsvc.so.0.1.0
f718e000 f71cf000 r-xp /usr/lib/libeina.so.1.7.99
f71d8000 f71ef000 r-xp /usr/lib/libecore.so.1.7.99
f7206000 f720f000 r-xp /usr/lib/libvconf.so.0.2.45
f7217000 f722b000 r-xp /lib/libpthread-2.13.so
f7236000 f7243000 r-xp /usr/lib/libaul.so.0.1.0
f724d000 f724f000 r-xp /lib/libdl-2.13.so
f7258000 f7263000 r-xp /lib/libunwind.so.8.0.1
f7290000 f7298000 r-xp /lib/libgcc_s-4.6.so.1
f7299000 f73bd000 r-xp /lib/libc-2.13.so
f73cb000 f73cd000 r-xp /usr/lib/libdlog.so.0.0.0
f73d5000 f73e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ea000 f73ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f7000 f7406000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f740e000 f7412000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f741b000 f741e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7426000 f7428000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7430000 f7434000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f743c000 f7459000 r-xp /lib/ld-2.13.so
f7462000 f7465000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7465000 f7469000 r-xp /usr/lib/libsys-assert.so
f7a85000 f7af3000 rw-p [heap]
ff7e4000 ff805000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28664)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74632b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf73fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf710be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7111be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7111dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7143e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7144017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf714bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ae31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ad6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ba9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7056fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71e8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71e3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf741c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf741c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74636c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf72b085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7462fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
NECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:00:03.571+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28609
04-23 17:00:03.571+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:03.571+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:03.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:00:03.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:00:03.591+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:03.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28609
04-23 17:00:03.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:00:03.601+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:03.601+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:00:03.601+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:00:03.601+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:03.601+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:03.601+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:03.601+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:03.601+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:03.601+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:03.601+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:03.611+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:03.611+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:03.611+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:00:03.611+0200 W/LOCATION(28609): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:00:03.611+0200 E/LOCATION(28609): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:00:03.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:03.621+0200 E/PKGMGR_INFO(28609): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:00:03.621+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:03.641+0200 I/LOCATION(28609): location.c: location_new(269) > method: 0
04-23 17:00:03.641+0200 W/LOCATION(28609): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:03.641+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:03.651+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:03.651+0200 W/LOCATION(28609): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:03.651+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:03.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:03.661+0200 W/LOCATION(28609): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:03.661+0200 W/LOCATION(28609): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:03.661+0200 W/LOCATION(28609): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:03.661+0200 W/LOCATION(28609): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:03.661+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:00:03.661+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:00:03.661+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:00:03.661+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4200f20
04-23 17:00:03.681+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:00:03.691+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:00:03.701+0200 W/LOCATION(28609): module-internal.c: module_new(311) > module (wps) open success
04-23 17:00:03.701+0200 W/LOCATION(28609): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:00:03.701+0200 W/LOCATION(28609): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:00:03.701+0200 W/LOCATION(28609): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:00:03.701+0200 W/LOCATION(28609): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:00:03.721+0200 W/LOCATION(28609): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:00:03.721+0200 I/LOCATION(28609): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b16c18
04-23 17:00:03.721+0200 I/LOCATION(28609): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:00:03.721+0200 I/LOCATION(28609): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b16c18
04-23 17:00:03.721+0200 I/LOCATION(28609): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:00:03.721+0200 I/location(28609): es.ugr.frailty.location: creado servicio de localización
04-23 17:00:03.761+0200 I/LOCATION(28609): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:00:03.801+0200 W/LOCATION(28609): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:03.801+0200 W/LOCATION(28609): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:03.801+0200 I/LOCATION(28609): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:00:03.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:00:03.881+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:00:03.881+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:00:03.881+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:03.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:03.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:00:03.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:00:03.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:00:03.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:00:03.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:00:03.891+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:00:03.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:00:03.891+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:00:03.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:00:03.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:03.941+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:00:03.961+0200 W/LOCATION(28609): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:00:03.961+0200 W/LOCATION(28609): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:00:04.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.111+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4201600]
04-23 17:00:04.111+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:00:04.111+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:00:04.111+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:00:04.111+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:00:04.121+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.121+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.131+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.141+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.141+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:00:04.141+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:00:04.141+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.141+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:04.141+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:04.141+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:04.141+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.141+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:04.141+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:04.151+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.161+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.161+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:00:04.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:00:04.181+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(9499846), time2(9497201)
04-23 17:00:04.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 17:00:04.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:00:04.181+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:00:04.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:00:04.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.231+0200 W/LOCATION(28609): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:00:04.231+0200 I/LOCATION(28609): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:00:04.231+0200 I/LOCATION(28609): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:00:04.231+0200 I/location(28609): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:00:04.321+0200 I/LOCATION(28609): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:00:04.371+0200 E/location(28609): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:00:04.371+0200 W/AUL     (28609): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:00:04.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:00:04.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 28609
04-23 17:00:04.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:00:04.381+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:00:04.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:00:04.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.391+0200 I/utils   (26979): specific action
04-23 17:00:04.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.391+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:00:04.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:00:04.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:00:04.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 28352
04-23 17:00:04.401+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:00:04.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(28352), cmd(0)
04-23 17:00:04.401+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.401+0200 I/utils   (28352): specific action
04-23 17:00:04.401+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.401+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.401+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.401+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:04.401+0200 I/recorder(28352): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:00:04.401+0200 I/recorder(28352): guardando datos en local
04-23 17:00:04.401+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28352)
04-23 17:00:04.401+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:00:04.401+0200 I/servicemanager(26979): requesting to save local data
04-23 17:00:04.401+0200 W/AUL     (28609): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:00:04.401+0200 I/location(28609): request sent to service es.ugr.frailty.servicemanager
04-23 17:00:04.401+0200 I/location(28609): stopping es.ugr.frailty.location service
04-23 17:00:04.401+0200 E/CAPI_APPFW_APP_CONTROL(28609): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:00:04.401+0200 E/location(28609): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:00:04.401+0200 I/CAPI_APPFW_APPLICATION(28609): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:00:04.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:00:04.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:00:04.451+0200 W/LOCATION(28609): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:00:04.451+0200 I/LOCATION(28609): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:00:04.451+0200 I/LOCATION(28609): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:00:04.521+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:00:04.521+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:00:04.521+0200 E/CAPI_LOCATION_MANAGER(28530): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:00:04.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:00:04.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.671+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:00:04.671+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:00:04.671+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:00:04.671+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4201600
04-23 17:00:04.721+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4201510]
04-23 17:00:04.721+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:00:04.721+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:00:04.721+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:00:04.721+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:00:04.731+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.731+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.741+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.741+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.741+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:00:04.741+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:00:04.741+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.741+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:04.741+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:04.741+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:04.741+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.741+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:04.741+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:04.751+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.761+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.761+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:00:04.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:04.861+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:00:04.861+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:00:04.861+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:00:04.861+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4201510
04-23 17:00:04.941+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4229670]
04-23 17:00:04.941+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:00:04.941+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:00:04.941+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:00:04.941+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:00:04.951+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.951+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.961+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.971+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.971+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:00:04.971+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:00:04.971+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:04.971+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:04.971+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:04.971+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:04.971+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:04.971+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:04.971+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:04.981+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.991+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:04.991+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:00:04.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:05.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:05.071+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:00:05.071+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:00:05.071+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:00:05.071+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4229670
04-23 17:00:05.261+0200 W/AUL     (28623): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:00:05.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:00:05.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:00:05.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28540
04-23 17:00:05.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:00:05.271+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28540
04-23 17:00:05.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28540)
04-23 17:00:06.411+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:00:26.041+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 9521601 to 9521703) (logOverhead=0,0,0,0,0,0,0), start: 17:00:25.946
04-23 17:00:26.041+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 9521601 to 9521703) (logOverhead=0,0,0,0,0,0,0), start: 17:00:25.946
04-23 17:00:26.041+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:00:26.051+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:00:26.061+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:00:26.061+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 52 3A 03 00 7F E0 01 01 7E 02 A5 68)
04-23 17:00:26.071+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:01:03.571+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 17:01:03.571+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:01:03.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:01:03.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:01:03.591+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 28664
04-23 17:01:03.601+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:01:03.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 28664
04-23 17:01:03.641+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(28664) type(svcapp) bg(0)
04-23 17:01:03.651+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [28664]
04-23 17:01:03.681+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28664)
04-23 17:01:03.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:01:03.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28664
04-23 17:01:03.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:01:03.701+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 17:01:03.701+0200 I/servicemanager(26979): App control destroyed.
04-23 17:01:03.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:01:03.731+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28664
04-23 17:01:03.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:01:03.731+0200 E/CAPI_APPFW_APPLICATION(28664): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:01:03.731+0200 E/CAPI_APPFW_APPLICATION(28664): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:01:03.731+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (28664) was created
04-23 17:01:03.761+0200 W/LOCATION(28664): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:01:03.761+0200 E/LOCATION(28664): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:01:03.761+0200 E/PKGMGR_INFO(28664): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:01:03.761+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:01:03.781+0200 I/LOCATION(28664): location.c: location_new(269) > method: 0
04-23 17:01:03.781+0200 W/LOCATION(28664): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:01:03.791+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:01:03.791+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:01:03.801+0200 W/LOCATION(28664): module-internal.c: module_new(311) > module (gps) open success
04-23 17:01:03.801+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:01:03.801+0200 W/LOCATION(28664): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:01:03.801+0200 W/LOCATION(28664): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:01:03.801+0200 W/LOCATION(28664): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:01:03.801+0200 W/LOCATION(28664): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:01:03.831+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:01:03.831+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:01:03.831+0200 W/LOCATION(28664): module-internal.c: module_new(311) > module (wps) open success
04-23 17:01:03.841+0200 W/LOCATION(28664): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:01:03.841+0200 W/LOCATION(28664): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:01:03.841+0200 W/LOCATION(28664): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:01:03.841+0200 W/LOCATION(28664): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:01:03.861+0200 W/LOCATION(28664): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:01:03.861+0200 I/LOCATION(28664): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7ab5c18
04-23 17:01:03.861+0200 I/LOCATION(28664): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:01:03.861+0200 I/LOCATION(28664): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7ab5c18
04-23 17:01:03.861+0200 I/LOCATION(28664): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:01:03.861+0200 I/location(28664): es.ugr.frailty.location: creado servicio de localización
04-23 17:01:03.901+0200 I/LOCATION(28664): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:01:03.941+0200 W/LOCATION(28664): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:01:03.941+0200 W/LOCATION(28664): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:01:03.941+0200 I/LOCATION(28664): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:01:04.011+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:01:04.011+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:01:04.011+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:01:04.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:01:04.021+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:01:04.021+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:01:04.021+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:01:04.021+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:01:04.031+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:01:04.041+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:01:04.041+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:01:04.041+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:01:04.041+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:01:04.041+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:01:04.051+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:01:04.051+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:01:04.051+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:01:04.051+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:01:04.061+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:01:04.071+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:01:04.071+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:01:04.071+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:01:04.071+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:01:04.071+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:01:04.071+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:01:04.071+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:01:04.101+0200 W/LOCATION(28664): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:01:04.101+0200 W/LOCATION(28664): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:01:04.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:01:04.231+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4235e20]
04-23 17:01:04.231+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:01:04.231+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:01:04.231+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:01:04.231+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:01:04.251+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:01:04.251+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:01:04.261+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:01:04.271+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:01:04.271+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:01:04.271+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:01:04.271+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:01:04.271+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:01:04.271+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:01:04.271+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:01:04.271+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:01:04.271+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:01:04.271+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:01:04.281+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:01:04.291+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:01:04.291+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:01:04.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:01:04.351+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:01:04.371+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 9559737 to 9560038) (logOverhead=0,0,0,0,0,0,0), start: 17:01:04.083
04-23 17:01:04.381+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 307 ms (from 9559735 to 9560042) (logOverhead=0,0,0,0,0,0,0), start: 17:01:04.080
04-23 17:01:04.381+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 307 ms (from 9559735 to 9560042) (logOverhead=0,0,0,0,0,0,0), start: 17:01:04.080
04-23 17:01:04.391+0200 W/LOCATION(28664): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:01:04.391+0200 I/LOCATION(28664): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:01:04.391+0200 I/LOCATION(28664): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:01:04.391+0200 I/location(28664): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:01:04.521+0200 I/LOCATION(28664): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:01:04.571+0200 E/location(28664): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:01:04.571+0200 W/AUL     (28664): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:01:04.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:01:04.581+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 28664
04-23 17:01:04.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:01:04.591+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.591+0200 I/utils   (26979): specific action
04-23 17:01:04.591+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.591+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.591+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.591+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:01:04.591+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:01:04.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:01:04.591+0200 W/AUL     (28664): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:01:04.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:01:04.591+0200 I/location(28664): request sent to service es.ugr.frailty.servicemanager
04-23 17:01:04.591+0200 W/CAPI_APPFW_APP_CONTROL(28664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.591+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:01:04.591+0200 I/utils   (28664): specific action
04-23 17:01:04.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 28352
04-23 17:01:04.601+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.601+0200 I/utils   (28352): specific action
04-23 17:01:04.601+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.601+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.601+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.601+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:01:04.601+0200 I/recorder(28352): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:01:04.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:01:04.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(28352), cmd(0)
04-23 17:01:04.601+0200 I/recorder(28352): guardando datos en local
04-23 17:01:04.601+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28352)
04-23 17:01:04.601+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:01:04.601+0200 I/servicemanager(26979): requesting to save local data
04-23 17:01:04.731+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:01:04.731+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(9560396), time2(9497201)
04-23 17:01:04.731+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:01:04.731+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:01:04.731+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:01:04.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:01:05.191+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 155 ms (from 9560697 to 9560852) (logOverhead=0,0,0,0,0,0,0), start: 17:01:05.043
04-23 17:01:05.191+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 156 ms (from 9560697 to 9560853) (logOverhead=0,0,0,0,0,0,0), start: 17:01:05.042
04-23 17:01:05.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:01:05.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:01:05.261+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:01:05.371+0200 E/CAPI_TELEPHONY(28530): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:01:06.041+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:01:06.041+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:01:06.041+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:01:06.291+0200 W/LOCATION(28664): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:01:06.531+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:01:06.531+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:01:06.531+0200 E/CAPI_LOCATION_MANAGER(28530): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:01:06.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:01:06.541+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:01:06.561+0200 W/AUL     (28676): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:01:06.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:01:06.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:01:06.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28580
04-23 17:01:06.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:01:06.561+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28580
04-23 17:01:06.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28580)
04-23 17:01:06.621+0200 W/CRASH_MANAGER(28674): worker.c: worker_job(1205) > 11286646c6f63152449566
