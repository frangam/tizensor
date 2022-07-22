S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27372
Date: 2018-04-23 16:23:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745252d, r5   = 0xf7947f98
r6   = 0xffeb5140, r7   = 0xffeb4ff0
r8   = 0xf7944c18, r9   = 0x00000000
r10  = 0xffeb50cc, fp   = 0xffeb5140
ip   = 0x00000001, sp   = 0xffeb3e70
lr   = 0xf7452539, pc   = 0xf74bb2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     20740 KB
Buffers:     63912 KB
Cached:     219576 KB
VmPeak:      53564 KB
VmSize:      53560 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12012 KB
VmRSS:       12012 KB
VmData:      11288 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27372 TID = 27372
27372 27375 

Maps Information
f431d000 f4b1c000 rw-p [stack:27375]
f4b23000 f4b25000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b2d000 f4b31000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b3a000 f4b3c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b44000 f4b47000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b56000 f4b5b000 r-xp /usr/lib/libsystem.so.0.0.0
f4b66000 f4b69000 r-xp /lib/libattr.so.1.1.0
f4b71000 f4b81000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b89000 f4b92000 r-xp /usr/lib/libedbus.so.1.7.99
f4b9a000 f4b9b000 r-xp /usr/lib/libresponse.so.0.2.96
f4ba4000 f4ba9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f644b000 f6551000 r-xp /usr/lib/libicuuc.so.57.1
f6567000 f66ef000 r-xp /usr/lib/libicui18n.so.57.1
f66ff000 f670c000 r-xp /usr/lib/libail.so.0.1.0
f6715000 f671c000 r-xp /usr/lib/libminizip.so.1.0.0
f6725000 f68ce000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ee000 f6935000 r-xp /usr/lib/libssl.so.1.0.0
f6941000 f6943000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f694b000 f6952000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f695b000 f6962000 r-xp /lib/libcrypt-2.13.so
f6993000 f6996000 r-xp /lib/libcap.so.2.21
f699e000 f69a0000 r-xp /usr/lib/libiri.so
f69a8000 f69f1000 r-xp /usr/lib/libmdm.so.1.2.69
f69f9000 f69ff000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a07000 f6a2a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a34000 f6a36000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a3e000 f6a5b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a64000 f6a68000 r-xp /usr/lib/libsmack.so.1.0.0
f6a71000 f6a8a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a93000 f6a9b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aa3000 f6aa9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ab2000 f6ab4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6abd000 f6acd000 r-xp /lib/libresolv-2.13.so
f6ad1000 f6ae9000 r-xp /usr/lib/liblzma.so.5.0.3
f6af2000 f6af4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6afc000 f6b16000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b1e000 f6b4d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b56000 f6b65000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b6f000 f6b79000 r-xp /usr/lib/libsensord-shared.so
f6b82000 f6c55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c60000 f6c76000 r-xp /lib/libz.so.1.2.5
f6c7e000 f6c83000 r-xp /usr/lib/libffi.so.5.0.10
f6c8b000 f6c8c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c94000 f6ca4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cac000 f6cc5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ccd000 f6ccf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cd7000 f6d4c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d56000 f6d5c000 r-xp /lib/librt-2.13.so
f6d65000 f6d83000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d8d000 f6d8e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d96000 f6db9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dc1000 f6dc6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dce000 f6df8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e01000 f6e18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e20000 f6e89000 r-xp /lib/libm-2.13.so
f6e92000 f6f26000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f39000 f6f3e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f46000 f6f4d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f55000 f6f7f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f88000 f7054000 r-xp /usr/lib/libxml2.so.2.7.8
f7061000 f7063000 r-xp /usr/lib/libiniparser.so.0
f706c000 f7072000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f707b000 f714b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f714c000 f7180000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7189000 f71c5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71cd000 f71d0000 r-xp /usr/lib/libbundle.so.0.1.22
f71d8000 f71de000 r-xp /usr/lib/libappsvc.so.0.1.0
f71e6000 f7227000 r-xp /usr/lib/libeina.so.1.7.99
f7230000 f7247000 r-xp /usr/lib/libecore.so.1.7.99
f725e000 f7267000 r-xp /usr/lib/libvconf.so.0.2.45
f726f000 f7283000 r-xp /lib/libpthread-2.13.so
f728e000 f729b000 r-xp /usr/lib/libaul.so.0.1.0
f72a5000 f72a7000 r-xp /lib/libdl-2.13.so
f72b0000 f72bb000 r-xp /lib/libunwind.so.8.0.1
f72e8000 f72f0000 r-xp /lib/libgcc_s-4.6.so.1
f72f1000 f7415000 r-xp /lib/libc-2.13.so
f7423000 f7425000 r-xp /usr/lib/libdlog.so.0.0.0
f742d000 f7439000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7442000 f7447000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f744f000 f745e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7466000 f746a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7473000 f7476000 r-xp /usr/lib/libappcore-agent.so.1.1
f747e000 f7480000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7488000 f748c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7494000 f74b1000 r-xp /lib/ld-2.13.so
f74ba000 f74bd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74bd000 f74c1000 r-xp /usr/lib/libsys-assert.so
f7914000 f79a1000 rw-p [heap]
ffe96000 ffeb7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27372)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74bb2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7452539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71593f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7157c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7163e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7169be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7169dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71991f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7157c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7163e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7169be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7169dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf719be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf719c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71a3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b3b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b2e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c01663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70aefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70b07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7240ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf723bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf723c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf723c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7474183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74747fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74bb6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf730885c) [/lib/libc.so.6] + 0x1785c
29: (0xf74bafa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:22:09.081+0200 E/CAPI_APPFW_APPLICATION(27315): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:22:09.081+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27315) was created
04-23 16:22:09.121+0200 W/LOCATION(27315): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:22:09.121+0200 E/LOCATION(27315): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:22:09.121+0200 E/PKGMGR_INFO(27315): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:22:09.131+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e350f8]
04-23 16:22:09.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:22:09.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:22:09.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:22:09.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:22:09.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.151+0200 I/LOCATION(27315): location.c: location_new(269) > method: 0
04-23 16:22:09.151+0200 W/LOCATION(27315): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:22:09.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:22:09.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:09.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:09.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:09.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:09.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:09.161+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.171+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.171+0200 W/LOCATION(27315): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:09.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.171+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:22:09.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:09.181+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:09.181+0200 W/LOCATION(27315): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:09.181+0200 W/LOCATION(27315): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.181+0200 W/LOCATION(27315): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:09.181+0200 W/LOCATION(27315): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:09.201+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:22:09.211+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:22:09.211+0200 W/LOCATION(27315): module-internal.c: module_new(311) > module (wps) open success
04-23 16:22:09.211+0200 W/LOCATION(27315): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:22:09.221+0200 W/LOCATION(27315): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:22:09.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:09.221+0200 W/LOCATION(27315): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:22:09.221+0200 W/LOCATION(27315): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:22:09.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:22:09.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:22:09.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:22:09.221+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e350f8
04-23 16:22:09.251+0200 W/LOCATION(27315): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:22:09.251+0200 I/LOCATION(27315): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b63c18
04-23 16:22:09.251+0200 I/LOCATION(27315): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:22:09.251+0200 I/LOCATION(27315): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b63c18
04-23 16:22:09.251+0200 I/LOCATION(27315): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:22:09.251+0200 I/location(27315): es.ugr.frailty.location: creado servicio de localización
04-23 16:22:09.311+0200 I/LOCATION(27315): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:22:09.351+0200 W/LOCATION(27315): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:09.351+0200 W/LOCATION(27315): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:09.351+0200 I/LOCATION(27315): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:22:09.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:22:09.411+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:22:09.411+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:22:09.411+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:09.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:22:09.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:22:09.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:22:09.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:22:09.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:22:09.411+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:22:09.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:22:09.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:22:09.461+0200 W/LOCATION(27315): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:22:09.461+0200 W/LOCATION(27315): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:22:09.531+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:09.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2c3b8]
04-23 16:22:09.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:22:09.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:22:09.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:22:09.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:22:09.581+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.591+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:22:09.591+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:22:09.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:09.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:09.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:09.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:09.591+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:09.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:09.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:09.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:09.611+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:22:09.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:09.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:09.691+0200 W/LOCATION(27315): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:22:09.691+0200 I/LOCATION(27315): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:22:09.691+0200 I/LOCATION(27315): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:22:09.691+0200 I/location(27315): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:22:09.781+0200 I/LOCATION(27315): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:22:09.821+0200 E/location(27315): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:22:09.821+0200 W/AUL     (27315): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:22:09.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:22:09.831+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27315
04-23 16:22:09.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:22:09.841+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:22:09.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:22:09.841+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.841+0200 I/utils   (26979): specific action
04-23 16:22:09.841+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.841+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.841+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.841+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:22:09.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:22:09.851+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:22:09.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:22:09.861+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:22:09.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:22:09.861+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.861+0200 I/utils   (26984): specific action
04-23 16:22:09.861+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.861+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.861+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.861+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:22:09.861+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:22:09.861+0200 I/recorder(26984): guardando datos en local
04-23 16:22:09.861+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:22:09.861+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:22:09.861+0200 I/servicemanager(26979): requesting to save local data
04-23 16:22:09.861+0200 W/AUL     (27315): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:22:09.861+0200 I/location(27315): request sent to service es.ugr.frailty.servicemanager
04-23 16:22:09.861+0200 I/location(27315): stopping es.ugr.frailty.location service
04-23 16:22:09.861+0200 E/CAPI_APPFW_APP_CONTROL(27315): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:22:09.861+0200 E/location(27315): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:22:09.861+0200 I/CAPI_APPFW_APPLICATION(27315): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:22:09.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:22:09.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:22:09.911+0200 W/LOCATION(27315): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:22:09.911+0200 I/LOCATION(27315): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:22:09.911+0200 I/LOCATION(27315): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:22:09.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:22:09.971+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:22:09.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:22:09.971+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:22:09.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:22:09.981+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:22:09.981+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:22:09.981+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:22:09.981+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:22:10.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:22:10.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:22:10.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:22:10.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2c3b8
04-23 16:22:10.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01ef0]
04-23 16:22:10.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:22:10.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:22:10.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:22:10.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:22:10.171+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:10.171+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:10.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.191+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:22:10.191+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:22:10.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:10.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:10.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:10.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:10.191+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:10.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:10.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:10.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.201+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:22:10.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:22:10.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:22:10.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:22:10.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01ef0
04-23 16:22:10.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e37f38]
04-23 16:22:10.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:22:10.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:22:10.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:22:10.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:22:10.391+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:10.391+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:10.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.411+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:22:10.411+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:22:10.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:22:10.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:22:10.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:22:10.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:22:10.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:22:10.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:22:10.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:22:10.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:22:10.421+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:22:10.431+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:22:10.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:22:10.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:22:10.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:22:10.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e37f38
04-23 16:22:10.711+0200 W/AUL     (27330): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:22:10.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:22:10.711+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:22:10.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27235
04-23 16:22:10.711+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:22:10.721+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27235
04-23 16:22:10.721+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27235)
04-23 16:22:11.861+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:22:31.441+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 7246999 to 7247101) (logOverhead=0,0,0,0,0,0,0), start: 16:22:31.344
04-23 16:22:31.441+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 7246999 to 7247101) (logOverhead=0,0,0,0,0,0,0), start: 16:22:31.344
04-23 16:22:31.441+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:22:31.451+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:22:31.461+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 16:22:31.471+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 9D 43 03 00 87 E0 01 E0 B9 03 A5 68)
04-23 16:22:31.471+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:23:08.981+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 16:23:08.981+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:23:08.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:23:08.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:23:09.011+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 27372
04-23 16:23:09.011+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:23:09.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27372
04-23 16:23:09.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(27372) type(svcapp) bg(0)
04-23 16:23:09.061+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27372]
04-23 16:23:09.091+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27372)
04-23 16:23:09.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:23:09.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27372
04-23 16:23:09.101+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 16:23:09.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:23:09.111+0200 I/servicemanager(26979): App control destroyed.
04-23 16:23:09.111+0200 E/CAPI_APPFW_APPLICATION(27372): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:23:09.111+0200 E/CAPI_APPFW_APPLICATION(27372): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:23:09.121+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27372) was created
04-23 16:23:09.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:23:09.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27372
04-23 16:23:09.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:23:09.151+0200 W/LOCATION(27372): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:23:09.151+0200 E/LOCATION(27372): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:23:09.151+0200 E/PKGMGR_INFO(27372): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:23:09.151+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:23:09.171+0200 I/LOCATION(27372): location.c: location_new(269) > method: 0
04-23 16:23:09.171+0200 W/LOCATION(27372): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:23:09.181+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:23:09.181+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:23:09.191+0200 W/LOCATION(27372): module-internal.c: module_new(311) > module (gps) open success
04-23 16:23:09.191+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:23:09.191+0200 W/LOCATION(27372): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:23:09.191+0200 W/LOCATION(27372): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:23:09.191+0200 W/LOCATION(27372): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:23:09.191+0200 W/LOCATION(27372): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:23:09.221+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:23:09.221+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:23:09.221+0200 W/LOCATION(27372): module-internal.c: module_new(311) > module (wps) open success
04-23 16:23:09.231+0200 W/LOCATION(27372): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:23:09.231+0200 W/LOCATION(27372): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:23:09.231+0200 W/LOCATION(27372): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:23:09.231+0200 W/LOCATION(27372): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:23:09.251+0200 W/LOCATION(27372): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:23:09.251+0200 I/LOCATION(27372): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7944c18
04-23 16:23:09.251+0200 I/LOCATION(27372): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:23:09.251+0200 I/LOCATION(27372): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7944c18
04-23 16:23:09.251+0200 I/LOCATION(27372): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:23:09.251+0200 I/location(27372): es.ugr.frailty.location: creado servicio de localización
04-23 16:23:09.291+0200 I/LOCATION(27372): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:23:09.331+0200 W/LOCATION(27372): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:23:09.331+0200 W/LOCATION(27372): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:23:09.331+0200 I/LOCATION(27372): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:23:09.391+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:23:09.391+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:23:09.391+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:23:09.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:23:09.391+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:23:09.391+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:23:09.391+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:23:09.391+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:23:09.401+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:23:09.411+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:23:09.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:23:09.421+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:23:09.421+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:23:09.421+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:23:09.421+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:23:09.431+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:23:09.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:23:09.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:23:09.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:23:09.451+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:23:09.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:23:09.451+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 16:23:09.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:23:09.451+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:23:09.451+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:23:09.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:23:09.471+0200 W/LOCATION(27372): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:23:09.471+0200 W/LOCATION(27372): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:23:09.541+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:23:09.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73756b8]
04-23 16:23:09.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:23:09.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:23:09.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:23:09.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:23:09.591+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:23:09.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:23:09.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:23:09.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:23:09.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:23:09.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:23:09.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:23:09.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:23:09.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:23:09.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:23:09.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:23:09.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:23:09.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:23:09.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:23:09.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:23:09.641+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:23:09.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:23:09.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:23:09.721+0200 W/LOCATION(27372): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:23:09.721+0200 I/LOCATION(27372): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:23:09.721+0200 I/LOCATION(27372): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:23:09.721+0200 I/location(27372): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:23:09.751+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 7285112 to 7285413) (logOverhead=0,0,0,0,0,0,0), start: 16:23:09.457
04-23 16:23:09.751+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 306 ms (from 7285110 to 7285416) (logOverhead=0,0,0,0,0,0,0), start: 16:23:09.455
04-23 16:23:09.751+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 7285110 to 7285416) (logOverhead=0,0,0,0,0,0,0), start: 16:23:09.455
04-23 16:23:09.811+0200 I/LOCATION(27372): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:23:09.861+0200 E/location(27372): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:23:09.861+0200 W/AUL     (27372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:23:09.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:23:09.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27372
04-23 16:23:09.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:23:09.871+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.871+0200 I/utils   (26979): specific action
04-23 16:23:09.871+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.871+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.871+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.871+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:23:09.871+0200 W/AUL     (27372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:23:09.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:23:09.881+0200 I/location(27372): request sent to service es.ugr.frailty.servicemanager
04-23 16:23:09.881+0200 W/CAPI_APPFW_APP_CONTROL(27372): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:23:09.881+0200 I/utils   (27372): specific action
04-23 16:23:09.881+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:23:09.881+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.881+0200 I/utils   (26984): specific action
04-23 16:23:09.881+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.891+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.891+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.891+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:23:09.891+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:23:09.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:23:09.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:23:09.891+0200 I/recorder(26984): guardando datos en local
04-23 16:23:09.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:23:09.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(26984), cmd(0)
04-23 16:23:09.891+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:23:09.891+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:23:09.891+0200 I/servicemanager(26979): requesting to save local data
04-23 16:23:10.301+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:23:10.301+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(7285966), time2(7222494)
04-23 16:23:10.301+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:23:10.301+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:23:10.301+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:23:10.301+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:23:10.571+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 147 ms (from 7286085 to 7286232) (logOverhead=0,0,0,0,0,0,0), start: 16:23:10.431
04-23 16:23:10.571+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 148 ms (from 7286085 to 7286233) (logOverhead=0,0,0,0,0,0,0), start: 16:23:10.430
04-23 16:23:10.611+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:23:10.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:23:10.621+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:23:10.731+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:23:11.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:23:11.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:23:11.441+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:23:11.491+0200 W/LOCATION(27372): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 16:23:11.701+0200 W/AUL     (27383): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:23:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:23:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:23:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27288
04-23 16:23:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:23:11.701+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:23:11.701+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:23:11.701+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:23:11.701+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:23:11.711+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27288
04-23 16:23:11.711+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27288)
04-23 16:23:11.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:23:11.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:23:11.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:23:11.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:23:11.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73756b8
04-23 16:23:11.801+0200 W/CRASH_MANAGER(27385): worker.c: worker_job(1205) > 11273726c6f63152449339
