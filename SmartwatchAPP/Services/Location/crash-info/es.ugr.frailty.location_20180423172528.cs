S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30334
Date: 2018-04-23 17:25:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf747c52d, r5   = 0xf7cbff98
r6   = 0xff95d6a0, r7   = 0xff95d550
r8   = 0xf7cbcc18, r9   = 0x00000000
r10  = 0xff95d62c, fp   = 0xff95d6a0
ip   = 0x00000001, sp   = 0xff95c3d0
lr   = 0xf747c539, pc   = 0xf74e52b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     15776 KB
Buffers:     66160 KB
Cached:     220160 KB
VmPeak:      53544 KB
VmSize:      53540 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11976 KB
VmRSS:       11976 KB
VmData:      11268 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30334 TID = 30334
30334 30337 

Maps Information
f4347000 f4b46000 rw-p [stack:30337]
f4b4d000 f4b4f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b57000 f4b5b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b64000 f4b66000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b6e000 f4b71000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b80000 f4b85000 r-xp /usr/lib/libsystem.so.0.0.0
f4b90000 f4b93000 r-xp /lib/libattr.so.1.1.0
f4b9b000 f4bab000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bb3000 f4bbc000 r-xp /usr/lib/libedbus.so.1.7.99
f4bc4000 f4bc5000 r-xp /usr/lib/libresponse.so.0.2.96
f4bce000 f4bd3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6475000 f657b000 r-xp /usr/lib/libicuuc.so.57.1
f6591000 f6719000 r-xp /usr/lib/libicui18n.so.57.1
f6729000 f6736000 r-xp /usr/lib/libail.so.0.1.0
f673f000 f6746000 r-xp /usr/lib/libminizip.so.1.0.0
f674f000 f68f8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6918000 f695f000 r-xp /usr/lib/libssl.so.1.0.0
f696b000 f696d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6975000 f697c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6985000 f698c000 r-xp /lib/libcrypt-2.13.so
f69bd000 f69c0000 r-xp /lib/libcap.so.2.21
f69c8000 f69ca000 r-xp /usr/lib/libiri.so
f69d2000 f6a1b000 r-xp /usr/lib/libmdm.so.1.2.69
f6a23000 f6a29000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a31000 f6a54000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a5e000 f6a60000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a68000 f6a85000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a8e000 f6a92000 r-xp /usr/lib/libsmack.so.1.0.0
f6a9b000 f6ab4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6abd000 f6ac5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6acd000 f6ad3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6adc000 f6ade000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ae7000 f6af7000 r-xp /lib/libresolv-2.13.so
f6afb000 f6b13000 r-xp /usr/lib/liblzma.so.5.0.3
f6b1c000 f6b1e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b26000 f6b40000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b48000 f6b77000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b80000 f6b8f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b99000 f6ba3000 r-xp /usr/lib/libsensord-shared.so
f6bac000 f6c7f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c8a000 f6ca0000 r-xp /lib/libz.so.1.2.5
f6ca8000 f6cad000 r-xp /usr/lib/libffi.so.5.0.10
f6cb5000 f6cb6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cbe000 f6cce000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cd6000 f6cef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cf7000 f6cf9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d01000 f6d76000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d80000 f6d86000 r-xp /lib/librt-2.13.so
f6d8f000 f6dad000 r-xp /usr/lib/libsystemd.so.0.4.0
f6db7000 f6db8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dc0000 f6de3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6deb000 f6df0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6df8000 f6e22000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e2b000 f6e42000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e4a000 f6eb3000 r-xp /lib/libm-2.13.so
f6ebc000 f6f50000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f63000 f6f68000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f70000 f6f77000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f7f000 f6fa9000 r-xp /usr/lib/libsensor.so.1.9.6
f6fb2000 f707e000 r-xp /usr/lib/libxml2.so.2.7.8
f708b000 f708d000 r-xp /usr/lib/libiniparser.so.0
f7096000 f709c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70a5000 f7175000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7176000 f71aa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71b3000 f71ef000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71f7000 f71fa000 r-xp /usr/lib/libbundle.so.0.1.22
f7202000 f7208000 r-xp /usr/lib/libappsvc.so.0.1.0
f7210000 f7251000 r-xp /usr/lib/libeina.so.1.7.99
f725a000 f7271000 r-xp /usr/lib/libecore.so.1.7.99
f7288000 f7291000 r-xp /usr/lib/libvconf.so.0.2.45
f7299000 f72ad000 r-xp /lib/libpthread-2.13.so
f72b8000 f72c5000 r-xp /usr/lib/libaul.so.0.1.0
f72cf000 f72d1000 r-xp /lib/libdl-2.13.so
f72da000 f72e5000 r-xp /lib/libunwind.so.8.0.1
f7312000 f731a000 r-xp /lib/libgcc_s-4.6.so.1
f731b000 f743f000 r-xp /lib/libc-2.13.so
f744d000 f744f000 r-xp /usr/lib/libdlog.so.0.0.0
f7457000 f7463000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f746c000 f7471000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7479000 f7488000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7490000 f7494000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f749d000 f74a0000 r-xp /usr/lib/libappcore-agent.so.1.1
f74a8000 f74aa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74b2000 f74b6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74be000 f74db000 r-xp /lib/ld-2.13.so
f74e4000 f74e7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74e7000 f74eb000 r-xp /usr/lib/libsys-assert.so
f7c8c000 f7d14000 rw-p [heap]
ff93e000 ff95f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30334)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74e52b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf747c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71833f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7181c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf718de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7193be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7193dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71c875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71c31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7181c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf718de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7193be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7193dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71c5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71c6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71cdf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b651fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b58171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c2b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70d8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70da7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf726aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7265b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72665a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7266879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf749e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf749e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74e56c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf733285c) [/lib/libc.so.6] + 0x1785c
29: (0xf74e4fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ted[0xf748d8f8]
04-23 17:24:25.551+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:24:25.551+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:24:25.551+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:24:25.551+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:24:25.561+0200 W/LOCATION(30276): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:25.561+0200 W/LOCATION(30276): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:25.561+0200 W/LOCATION(30276): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:25.561+0200 W/LOCATION(30276): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:25.561+0200 W/LOCATION(30276): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:25.561+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:25.561+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:25.571+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.581+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.581+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:24:25.581+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:24:25.581+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:25.581+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:25.581+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:25.581+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:25.581+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:25.581+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:25.581+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:25.581+0200 W/LOCATION(30276): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:24:25.591+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.591+0200 W/LOCATION(30276): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:24:25.591+0200 W/LOCATION(30276): module-internal.c: module_new(311) > module (wps) open success
04-23 17:24:25.591+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.591+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:24:25.601+0200 W/LOCATION(30276): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:24:25.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:25.601+0200 W/LOCATION(30276): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:24:25.601+0200 W/LOCATION(30276): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:24:25.601+0200 W/LOCATION(30276): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:24:25.621+0200 W/LOCATION(30276): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:24:25.621+0200 I/LOCATION(30276): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf740fc18
04-23 17:24:25.621+0200 I/LOCATION(30276): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:24:25.621+0200 I/LOCATION(30276): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf740fc18
04-23 17:24:25.621+0200 I/LOCATION(30276): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:24:25.621+0200 I/location(30276): es.ugr.frailty.location: creado servicio de localización
04-23 17:24:25.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:25.641+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:24:25.641+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:24:25.641+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:24:25.641+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf748d8f8
04-23 17:24:25.681+0200 I/LOCATION(30276): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:24:25.721+0200 W/LOCATION(30276): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:25.721+0200 W/LOCATION(30276): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:25.721+0200 I/LOCATION(30276): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:24:25.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:24:25.781+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:24:25.781+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:24:25.781+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:25.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:25.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:24:25.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:24:25.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:24:25.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:24:25.791+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:24:25.791+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:24:25.791+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:24:25.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:24:25.831+0200 W/LOCATION(30276): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:24:25.831+0200 W/LOCATION(30276): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:24:25.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:25.971+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf748d980]
04-23 17:24:25.971+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:24:25.971+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:24:25.971+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:24:25.971+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:24:25.981+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:25.981+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:25.991+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.991+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:25.991+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:24:25.991+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:24:25.991+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:25.991+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:25.991+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:25.991+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:25.991+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:25.991+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:25.991+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:26.001+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.011+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.011+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:24:26.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.061+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:24:26.061+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(10961726), time2(10959001)
04-23 17:24:26.061+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 17:24:26.061+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:24:26.061+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:24:26.061+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:24:26.091+0200 W/LOCATION(30276): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:24:26.091+0200 I/LOCATION(30276): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:24:26.091+0200 I/LOCATION(30276): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:24:26.091+0200 I/location(30276): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:24:26.181+0200 I/LOCATION(30276): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:24:26.231+0200 E/location(30276): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:24:26.241+0200 W/AUL     (30276): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:24:26.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:26.241+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30276
04-23 17:24:26.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:24:26.251+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:26.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:24:26.251+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.251+0200 I/utils   (30105): specific action
04-23 17:24:26.251+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.251+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.251+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.251+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:24:26.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:24:26.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:24:26.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:24:26.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:24:26.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:24:26.271+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.271+0200 I/utils   (30110): specific action
04-23 17:24:26.271+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.271+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.271+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.271+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:24:26.271+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:24:26.271+0200 I/recorder(30110): guardando datos en local
04-23 17:24:26.271+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:24:26.271+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:24:26.271+0200 I/servicemanager(30105): requesting to save local data
04-23 17:24:26.271+0200 W/AUL     (30276): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:24:26.271+0200 I/location(30276): request sent to service es.ugr.frailty.servicemanager
04-23 17:24:26.271+0200 I/location(30276): stopping es.ugr.frailty.location service
04-23 17:24:26.271+0200 E/CAPI_APPFW_APP_CONTROL(30276): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:24:26.271+0200 E/location(30276): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:24:26.271+0200 I/CAPI_APPFW_APPLICATION(30276): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:24:26.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:24:26.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:24:26.311+0200 W/LOCATION(30276): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:24:26.311+0200 I/LOCATION(30276): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:24:26.311+0200 I/LOCATION(30276): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:24:26.381+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:24:26.381+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:24:26.381+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:24:26.381+0200 E/CAPI_LOCATION_MANAGER(30159): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:24:26.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.511+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:24:26.511+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:24:26.521+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:24:26.521+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf748d980
04-23 17:24:26.571+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf748bfa8]
04-23 17:24:26.571+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:24:26.571+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:24:26.571+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:24:26.571+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:24:26.571+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:26.571+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:26.581+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.591+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.591+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:24:26.591+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:24:26.591+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:26.591+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:26.591+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:26.591+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:26.591+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:26.591+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:26.591+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:26.601+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.601+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.601+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:24:26.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.711+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:24:26.711+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:24:26.711+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:24:26.711+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf748bfa8
04-23 17:24:26.791+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf749d090]
04-23 17:24:26.791+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:24:26.791+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:24:26.791+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:24:26.791+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:24:26.801+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:26.801+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:26.811+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.811+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.811+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:24:26.811+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:24:26.811+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:24:26.811+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:24:26.811+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:24:26.811+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:24:26.811+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:24:26.811+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:24:26.811+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:24:26.821+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.831+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:24:26.831+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:24:26.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:24:26.921+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:24:26.921+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:24:26.921+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:24:26.921+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf749d090
04-23 17:24:27.091+0200 W/AUL     (30290): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:24:27.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:24:27.091+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:24:27.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30181
04-23 17:24:27.091+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:24:27.091+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30181
04-23 17:24:27.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30181)
04-23 17:24:28.271+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:24:33.011+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 219 ms (from 10968456 to 10968675) (logOverhead=0,0,0,0,0,0,0), start: 17:24:32.801
04-23 17:24:33.011+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 219 ms (from 10968456 to 10968675) (logOverhead=0,0,0,0,0,0,0), start: 17:24:32.802
04-23 17:24:48.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 10983987 to 10984088) (logOverhead=0,0,0,0,0,0,0), start: 17:24:48.333
04-23 17:24:48.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 10983987 to 10984088) (logOverhead=0,0,0,0,0,0,0), start: 17:24:48.333
04-23 17:24:48.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:24:48.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:24:48.451+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:24:48.451+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 F8 4D 03 00 4C E0 01 01 04 03 A5 68)
04-23 17:24:48.451+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:25:25.501+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:25:25.501+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:25:25.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:25:25.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:25:25.521+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 30334
04-23 17:25:25.531+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:25:25.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 30334
04-23 17:25:25.581+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(30334) type(svcapp) bg(0)
04-23 17:25:25.591+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [30334]
04-23 17:25:25.611+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30334)
04-23 17:25:25.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:25:25.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30334
04-23 17:25:25.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:25:25.631+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:25:25.631+0200 E/CAPI_APPFW_APPLICATION(30334): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:25:25.631+0200 E/CAPI_APPFW_APPLICATION(30334): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:25:25.631+0200 I/servicemanager(30105): App control destroyed.
04-23 17:25:25.641+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (30334) was created
04-23 17:25:25.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:25:25.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 30334
04-23 17:25:25.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:25:25.661+0200 W/LOCATION(30334): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:25:25.661+0200 E/LOCATION(30334): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:25:25.661+0200 E/PKGMGR_INFO(30334): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:25:25.671+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:25:25.681+0200 I/LOCATION(30334): location.c: location_new(269) > method: 0
04-23 17:25:25.691+0200 W/LOCATION(30334): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:25:25.691+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:25:25.691+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:25:25.701+0200 W/LOCATION(30334): module-internal.c: module_new(311) > module (gps) open success
04-23 17:25:25.701+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:25:25.711+0200 W/LOCATION(30334): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:25:25.711+0200 W/LOCATION(30334): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:25:25.711+0200 W/LOCATION(30334): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:25:25.711+0200 W/LOCATION(30334): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:25:25.731+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:25:25.731+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:25:25.731+0200 W/LOCATION(30334): module-internal.c: module_new(311) > module (wps) open success
04-23 17:25:25.741+0200 W/LOCATION(30334): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:25:25.741+0200 W/LOCATION(30334): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:25:25.741+0200 W/LOCATION(30334): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:25:25.741+0200 W/LOCATION(30334): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:25:25.761+0200 W/LOCATION(30334): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:25:25.761+0200 I/LOCATION(30334): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7cbcc18
04-23 17:25:25.761+0200 I/LOCATION(30334): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:25:25.761+0200 I/LOCATION(30334): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7cbcc18
04-23 17:25:25.761+0200 I/LOCATION(30334): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:25:25.761+0200 I/location(30334): es.ugr.frailty.location: creado servicio de localización
04-23 17:25:25.801+0200 I/LOCATION(30334): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:25:25.841+0200 W/LOCATION(30334): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:25:25.841+0200 W/LOCATION(30334): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:25:25.841+0200 I/LOCATION(30334): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:25:25.901+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:25:25.901+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:25:25.901+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:25.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:25.901+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:25:25.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:25:25.901+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:25:25.901+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:25:25.911+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:25:25.921+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:25:25.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:25:25.921+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:25:25.921+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:25:25.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:25:25.931+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:25:25.941+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:25:25.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:25:25.941+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:25:25.941+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:25:25.951+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:25:25.951+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:25:25.951+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:25:25.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:25:25.951+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:25:25.951+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:25:25.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:25:25.951+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:25:25.951+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:25:25.981+0200 W/LOCATION(30334): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:25:25.981+0200 W/LOCATION(30334): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:25:26.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:25:26.081+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf74a2308]
04-23 17:25:26.081+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:25:26.081+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:25:26.081+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:25:26.081+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:25:26.091+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:25:26.091+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:25:26.101+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:25:26.101+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:25:26.101+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:25:26.101+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:25:26.101+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:25:26.101+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:25:26.101+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:25:26.101+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:25:26.101+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:25:26.101+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:25:26.101+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:25:26.111+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:25:26.121+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:25:26.121+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:25:26.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:25:26.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:25:26.181+0200 W/LOCATION(30334): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:25:26.181+0200 I/LOCATION(30334): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:25:26.181+0200 I/LOCATION(30334): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:25:26.181+0200 I/location(30334): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:25:26.251+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 11021617 to 11021918) (logOverhead=0,0,0,0,0,0,0), start: 17:25:25.963
04-23 17:25:26.261+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 305 ms (from 11021616 to 11021921) (logOverhead=0,0,0,0,0,0,0), start: 17:25:25.961
04-23 17:25:26.261+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 11021615 to 11021921) (logOverhead=0,0,0,0,0,0,0), start: 17:25:25.960
04-23 17:25:26.261+0200 I/LOCATION(30334): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:25:26.311+0200 E/location(30334): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:25:26.311+0200 W/AUL     (30334): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:25:26.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:25:26.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30334
04-23 17:25:26.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:25:26.321+0200 W/AUL     (30334): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:25:26.321+0200 I/location(30334): request sent to service es.ugr.frailty.servicemanager
04-23 17:25:26.321+0200 W/CAPI_APPFW_APP_CONTROL(30334): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.321+0200 I/utils   (30334): specific action
04-23 17:25:26.321+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:25:26.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:25:26.321+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.321+0200 I/utils   (30105): specific action
04-23 17:25:26.321+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.321+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.321+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.321+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:25:26.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:25:26.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:25:26.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:25:26.331+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.331+0200 I/utils   (30110): specific action
04-23 17:25:26.331+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.331+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.331+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.331+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:25:26.331+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:25:26.341+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:25:26.341+0200 I/recorder(30110): guardando datos en local
04-23 17:25:26.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:25:26.341+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:25:26.341+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:25:26.341+0200 I/servicemanager(30105): requesting to save local data
04-23 17:25:26.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:25:26.521+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11022189), time2(10959001)
04-23 17:25:26.531+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:25:26.531+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:25:26.531+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:25:26.531+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:25:27.061+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 133 ms (from 11022592 to 11022725) (logOverhead=0,0,0,0,0,0,0), start: 17:25:26.937
04-23 17:25:27.061+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 133 ms (from 11022592 to 11022725) (logOverhead=0,0,0,0,0,0,0), start: 17:25:26.938
04-23 17:25:27.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:25:27.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:27.121+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:25:27.221+0200 E/CAPI_TELEPHONY(30159): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:25:27.941+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:25:27.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:27.941+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:25:28.001+0200 W/LOCATION(30334): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:25:28.151+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:25:28.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:28.151+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:25:28.261+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:25:28.261+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:25:28.261+0200 E/CAPI_LOCATION_MANAGER(30159): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:25:28.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:25:28.271+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:25:28.311+0200 W/AUL     (30347): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:25:28.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:25:28.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:25:28.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30249
04-23 17:25:28.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:25:28.331+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:25:28.331+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:25:28.331+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:25:28.331+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf74a2308
04-23 17:25:28.361+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30249
04-23 17:25:28.361+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30249)
04-23 17:25:28.361+0200 W/CRASH_MANAGER(30346): worker.c: worker_job(1205) > 11303346c6f63152449712
