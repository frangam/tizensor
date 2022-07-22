S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12859
Date: 2018-04-23 20:42:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70be52d, r5   = 0xf72caf98
r6   = 0xfffcbf80, r7   = 0xfffcbe30
r8   = 0xf72c7c18, r9   = 0x00000000
r10  = 0xfffcbf0c, fp   = 0xfffcbf80
ip   = 0x00000001, sp   = 0xfffcbe08
lr   = 0xf70be539, pc   = 0xf7127228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    127588 KB
Buffers:     40776 KB
Cached:     161180 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11908 KB
VmRSS:       11904 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12859 TID = 12859
12859 12862 

Maps Information
f3f89000 f4788000 rw-p [stack:12862]
f478f000 f4791000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4799000 f479d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47a6000 f47a8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47b0000 f47b3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47c2000 f47c7000 r-xp /usr/lib/libsystem.so.0.0.0
f47d2000 f47d5000 r-xp /lib/libattr.so.1.1.0
f47dd000 f47ed000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47f5000 f47fe000 r-xp /usr/lib/libedbus.so.1.7.99
f4806000 f4807000 r-xp /usr/lib/libresponse.so.0.2.96
f4810000 f4815000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60b7000 f61bd000 r-xp /usr/lib/libicuuc.so.57.1
f61d3000 f635b000 r-xp /usr/lib/libicui18n.so.57.1
f636b000 f6378000 r-xp /usr/lib/libail.so.0.1.0
f6381000 f6388000 r-xp /usr/lib/libminizip.so.1.0.0
f6391000 f653a000 r-xp /usr/lib/libcrypto.so.1.0.0
f655a000 f65a1000 r-xp /usr/lib/libssl.so.1.0.0
f65ad000 f65af000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65b7000 f65be000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65c7000 f65ce000 r-xp /lib/libcrypt-2.13.so
f65ff000 f6602000 r-xp /lib/libcap.so.2.21
f660a000 f660c000 r-xp /usr/lib/libiri.so
f6614000 f665d000 r-xp /usr/lib/libmdm.so.1.2.69
f6665000 f666b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6673000 f6696000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66a0000 f66a2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66aa000 f66c7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66d0000 f66d4000 r-xp /usr/lib/libsmack.so.1.0.0
f66dd000 f66f6000 r-xp /usr/lib/libnetwork.so.0.0.0
f66ff000 f6707000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f670f000 f6715000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f671e000 f6720000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6729000 f6739000 r-xp /lib/libresolv-2.13.so
f673d000 f6755000 r-xp /usr/lib/liblzma.so.5.0.3
f675e000 f6760000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6768000 f6782000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f678a000 f67b9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67c2000 f67d1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67db000 f67e5000 r-xp /usr/lib/libsensord-shared.so
f67ee000 f68c1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68cc000 f68e2000 r-xp /lib/libz.so.1.2.5
f68ea000 f68ef000 r-xp /usr/lib/libffi.so.5.0.10
f68f7000 f68f8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6900000 f6910000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6918000 f6931000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6939000 f693b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6943000 f69b8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69c2000 f69c8000 r-xp /lib/librt-2.13.so
f69d1000 f69ef000 r-xp /usr/lib/libsystemd.so.0.4.0
f69f9000 f69fa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a02000 f6a25000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a2d000 f6a32000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a3a000 f6a64000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a6d000 f6a84000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a8c000 f6af5000 r-xp /lib/libm-2.13.so
f6afe000 f6b92000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ba5000 f6baa000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bb2000 f6bb9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bc1000 f6beb000 r-xp /usr/lib/libsensor.so.1.9.6
f6bf4000 f6cc0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ccd000 f6ccf000 r-xp /usr/lib/libiniparser.so.0
f6cd8000 f6cde000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ce7000 f6db7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6db8000 f6dec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6df5000 f6e31000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e39000 f6e3c000 r-xp /usr/lib/libbundle.so.0.1.22
f6e44000 f6e4a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e52000 f6e93000 r-xp /usr/lib/libeina.so.1.7.99
f6e9c000 f6eb3000 r-xp /usr/lib/libecore.so.1.7.99
f6eca000 f6ed3000 r-xp /usr/lib/libvconf.so.0.2.45
f6edb000 f6eef000 r-xp /lib/libpthread-2.13.so
f6efa000 f6f07000 r-xp /usr/lib/libaul.so.0.1.0
f6f11000 f6f13000 r-xp /lib/libdl-2.13.so
f6f1c000 f6f27000 r-xp /lib/libunwind.so.8.0.1
f6f54000 f6f5c000 r-xp /lib/libgcc_s-4.6.so.1
f6f5d000 f7081000 r-xp /lib/libc-2.13.so
f708f000 f7091000 r-xp /usr/lib/libdlog.so.0.0.0
f7099000 f70a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70ae000 f70b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70bb000 f70ca000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70d2000 f70d6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70df000 f70e2000 r-xp /usr/lib/libappcore-agent.so.1.1
f70ea000 f70ec000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70f4000 f70f8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7100000 f711d000 r-xp /lib/ld-2.13.so
f7126000 f7129000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7129000 f712d000 r-xp /usr/lib/libsys-assert.so
f7297000 f7305000 rw-p [heap]
fffad000 fffce000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12859)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7127228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70be539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dc53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dc3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dcfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dd5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dd5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e0a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e051f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dc3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dcfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dd5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dd5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e07e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e08017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e0ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47a71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf479a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf686d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d1afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d1c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eacca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ea7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ea85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ea8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70e0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70e07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71275c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f7485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7126f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
name(gps) is found
04-23 20:42:28.629+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.639+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.639+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:28.639+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:28.639+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:28.639+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:28.639+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:28.639+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:28.639+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:28.639+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:28.639+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:28.649+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.659+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.659+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:28.669+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:28.739+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:28.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:28.799+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:28.799+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:28.799+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:28.799+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf794fe08
04-23 20:42:28.829+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:28.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:28:834,0.030756,9.772658,0.815222
04-23 20:42:28.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:28.839+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:28:846,0.031387,9.772606,0.815828
04-23 20:42:28.849+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:28.869+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf7967ba8]
04-23 20:42:28.869+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:28.869+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:28.879+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:28.879+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:28.879+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:28.879+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:28.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:28:874,0.032098,9.772460,0.817543
04-23 20:42:28.899+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.909+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.909+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:28.909+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:28.909+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:28.909+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:28.909+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:28.909+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:28.909+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:28.909+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:28.909+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:28.919+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.929+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:28.929+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:28.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:28.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:28.979+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:28.979+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:28.979+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:28.979+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf7967ba8
04-23 20:42:29.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:44,0.032320,9.772377,0.818525
04-23 20:42:29.049+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:55,0.033783,9.772411,0.818057
04-23 20:42:29.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:72,0.033176,9.772554,0.816377
04-23 20:42:29.069+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:82,0.032708,9.772774,0.813756
04-23 20:42:29.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.099+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:103,0.032032,9.773055,0.810400
04-23 20:42:29.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:113,0.032306,9.773446,0.805662
04-23 20:42:29.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:118,0.030848,9.773644,0.803315
04-23 20:42:29.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:123,0.031290,9.773953,0.799528
04-23 20:42:29.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:131,0.030337,9.774160,0.797028
04-23 20:42:29.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.139+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:140,0.031420,9.773888,0.800326
04-23 20:42:29.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.139+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:145,0.032598,9.773965,0.799330
04-23 20:42:29.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.169+0200 W/AUL     (12823): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:42:29.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:42:29.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:42:29.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12774
04-23 20:42:29.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:42:29.169+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12774
04-23 20:42:29.169+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12774)
04-23 20:42:29.179+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:184,0.033575,9.773821,0.801046
04-23 20:42:29.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:190,0.032025,9.773590,0.803923
04-23 20:42:29.189+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:201,0.032697,9.773484,0.805180
04-23 20:42:29.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:206,0.031866,9.773545,0.804480
04-23 20:42:29.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:212,0.017581,9.775934,0.775364
04-23 20:42:29.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:331,0.015930,9.773052,0.810909
04-23 20:42:29.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:530,0.016402,9.771244,0.832414
04-23 20:42:29.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:730,0.039071,9.772511,0.816628
04-23 20:42:29.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:29.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:29:933,0.039113,9.773234,0.807931
04-23 20:42:29.959+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:42:30.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:30.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:30:130,0.035947,9.772429,0.817754
04-23 20:42:30.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:30.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:30:330,0.035346,9.771570,0.827975
04-23 20:42:30.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:30.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:30:531,0.035755,9.771797,0.825284
04-23 20:42:30.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:30.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:30:730,0.040014,9.771585,0.827584
04-23 20:42:30.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:30.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:30:930,0.032469,9.770684,0.838485
04-23 20:42:31.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:31.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:31:131,0.030015,9.769504,0.852219
04-23 20:42:31.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:31.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:31:332,0.041926,9.769934,0.846774
04-23 20:42:31.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:31.569+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:31:530,0.051196,9.771087,0.832838
04-23 20:42:31.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:31.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:31:730,0.034321,9.769543,0.851616
04-23 20:42:31.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:31.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:31:931,0.031077,9.769345,0.854003
04-23 20:42:32.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:32.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:32:131,0.018489,9.765652,0.895598
04-23 20:42:32.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:32.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:32:330,0.033443,9.772333,0.819007
04-23 20:42:32.439+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][1][a][0][0][0][0][0][0][0][0][0][0]
04-23 20:42:32.439+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][0][9][0][0][0][0][0][0][0][0][0][0]
04-23 20:42:32.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:32.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:32:530,0.012146,9.762655,0.927792
04-23 20:42:32.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:32.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:32:729,0.010726,9.757438,0.981162
04-23 20:42:32.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:32.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:32:930,0.008961,9.750944,1.043738
04-23 20:42:33.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:33.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:33:129,0.023629,9.766633,0.884707
04-23 20:42:33.329+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:33.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:33:333,0.043266,9.771556,0.827774
04-23 20:42:33.529+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:33.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:33:533,0.036999,9.771355,0.830447
04-23 20:42:33.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:33.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:33:729,0.047237,9.772828,0.812392
04-23 20:42:33.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:33.999+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:33:929,0.046024,9.772309,0.818675
04-23 20:42:34.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:34.139+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:34:130,0.047610,9.772621,0.814853
04-23 20:42:34.329+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:34.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:34:333,0.043916,9.771589,0.827342
04-23 20:42:34.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:34.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:34:529,0.043176,9.771299,0.830796
04-23 20:42:34.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:34.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:34:730,0.032158,9.771269,0.831660
04-23 20:42:34.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:34.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:34:933,0.040094,9.772175,0.820595
04-23 20:42:35.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:35.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:35:131,0.039801,9.772238,0.819862
04-23 20:42:35.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:35.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:35:330,0.040343,9.772372,0.818231
04-23 20:42:35.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:35.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:35:529,0.052806,9.773684,0.801684
04-23 20:42:35.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:35.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:35:729,0.044899,9.773551,0.803784
04-23 20:42:35.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:35.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:35:929,0.032551,9.772392,0.818335
04-23 20:42:36.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:36.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:36:129,0.031456,9.771407,0.830063
04-23 20:42:36.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:36.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:36:329,0.030000,9.771177,0.832817
04-23 20:42:36.509+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:42:36.509+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:42:36.509+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:42:36.509+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:42:36.519+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12859
04-23 20:42:36.519+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:42:36.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:36.539+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:36:531,0.030575,9.771927,0.823950
04-23 20:42:36.569+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12859
04-23 20:42:36.569+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12859) type(svcapp) bg(0)
04-23 20:42:36.569+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12859]
04-23 20:42:36.579+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12859)
04-23 20:42:36.579+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:42:36.579+0200 I/servicemanager(12059): App control destroyed.
04-23 20:42:36.589+0200 E/CAPI_APPFW_APPLICATION(12859): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:36.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:36.599+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12859
04-23 20:42:36.599+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:36.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:36.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12859
04-23 20:42:36.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:36.619+0200 E/CAPI_APPFW_APPLICATION(12859): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:36.619+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12859) was created
04-23 20:42:36.639+0200 W/LOCATION(12859): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:42:36.639+0200 E/LOCATION(12859): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:42:36.649+0200 E/PKGMGR_INFO(12859): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:42:36.649+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:36.669+0200 I/LOCATION(12859): location.c: location_new(269) > method: 0
04-23 20:42:36.669+0200 W/LOCATION(12859): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:36.669+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:36.679+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:36.699+0200 W/LOCATION(12859): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:36.699+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:36.699+0200 W/LOCATION(12859): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:36.699+0200 W/LOCATION(12859): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:36.709+0200 W/LOCATION(12859): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:36.709+0200 W/LOCATION(12859): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:36.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:36.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:36:729,0.030163,9.770936,0.835630
04-23 20:42:36.739+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:36.739+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:36.749+0200 W/LOCATION(12859): module-internal.c: module_new(311) > module (wps) open success
04-23 20:42:36.749+0200 W/LOCATION(12859): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:42:36.749+0200 W/LOCATION(12859): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:42:36.749+0200 W/LOCATION(12859): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:36.749+0200 W/LOCATION(12859): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:36.769+0200 W/LOCATION(12859): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:42:36.769+0200 I/LOCATION(12859): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72c7c18
04-23 20:42:36.769+0200 I/LOCATION(12859): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:42:36.769+0200 I/LOCATION(12859): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72c7c18
04-23 20:42:36.769+0200 I/LOCATION(12859): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:42:36.779+0200 I/location(12859): es.ugr.frailty.location: creado servicio de localización
04-23 20:42:36.819+0200 I/LOCATION(12859): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:42:36.859+0200 W/LOCATION(12859): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:36.859+0200 W/LOCATION(12859): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:36.859+0200 I/LOCATION(12859): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:36.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:36.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:36:929,0.031457,9.769592,0.851148
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:42:36.949+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:42:36.949+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:36.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:36.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:42:36.949+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:42:36.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:42:36.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:42:36.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:42:36.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:42:36.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:42:36.949+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:42:36.949+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:42:36.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:42:36.999+0200 W/LOCATION(12859): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:36.999+0200 W/LOCATION(12859): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:37.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:37.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.129+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79ce960]
04-23 20:42:37.129+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:37.129+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:37.129+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:37.129+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:37.139+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:37.139+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:37.149+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:37.159+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:37.159+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:37.159+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:37.159+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:37.159+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:37.159+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:37.159+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:37.159+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:37.159+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:37.159+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:37.169+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:37.179+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:37.179+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:37.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:37.189+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:42:37.189+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3032455), time2(3019113)
04-23 20:42:37.189+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:42:37.189+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:42:37.189+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:42:37.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:42:37.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:130,0.036668,9.770171,0.844270
04-23 20:42:37.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:37.259+0200 W/LOCATION(12859): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:37.259+0200 I/LOCATION(12859): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:37.259+0200 I/LOCATION(12859): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:37.259+0200 I/location(12859): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:42:37.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:330,0.031854,9.769781,0.848970
04-23 20:42:37.359+0200 I/LOCATION(12859): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:37.409+0200 I/location(12859): es.ugr.frailty.location: waiting for rigth values
04-23 20:42:37.409+0200 W/CAPI_APPFW_APP_CONTROL(12859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:42:37.409+0200 I/utils   (12859): specific action
04-23 20:42:37.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:529,0.028884,9.767547,0.874402
04-23 20:42:37.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:37.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:37.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:37.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:729,0.021966,9.764901,0.903663
04-23 20:42:37.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:750,0.023148,9.765647,0.895543
04-23 20:42:37.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:770,0.022643,9.765695,0.895030
04-23 20:42:37.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:792,0.023522,9.766383,0.887461
04-23 20:42:37.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:810,0.024018,9.766766,0.883227
04-23 20:42:37.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:830,0.023481,9.766546,0.885671
04-23 20:42:37.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:850,0.024320,9.767220,0.878188
04-23 20:42:37.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.869+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:870,0.022419,9.766351,0.887844
04-23 20:42:37.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:891,0.024092,9.767169,0.878760
04-23 20:42:37.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:910,0.025131,9.767681,0.873022
04-23 20:42:37.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:930,0.026450,9.768191,0.867248
04-23 20:42:37.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:950,0.027043,9.768538,0.863315
04-23 20:42:37.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:971,0.029648,9.769456,0.852777
04-23 20:42:37.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:37.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:37:991,0.029898,9.769990,0.846627
04-23 20:42:37.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:10,0.031966,9.770891,0.836092
04-23 20:42:38.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:123,0.031652,9.771245,0.831963
04-23 20:42:38.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:131,0.030104,9.771422,0.829924
04-23 20:42:38.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:135,0.029867,9.771847,0.824925
04-23 20:42:38.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.139+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:144,0.028502,9.772158,0.821282
04-23 20:42:38.149+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.159+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:162,0.028914,9.772516,0.816996
04-23 20:42:38.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:172,0.029086,9.772771,0.813933
04-23 20:42:38.169+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:183,0.029252,9.773035,0.810744
04-23 20:42:38.229+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.239+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:42:38.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:250,0.029067,9.773410,0.806230
04-23 20:42:38.249+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:256,0.029559,9.773651,0.803276
04-23 20:42:38.249+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.259+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:262,0.029022,9.773696,0.802755
04-23 20:42:38.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:267,0.028733,9.774012,0.798906
04-23 20:42:38.269+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:275,0.029028,9.774363,0.794592
04-23 20:42:38.269+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.279+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:281,0.031019,9.774726,0.790040
04-23 20:42:38.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:292,0.031645,9.774875,0.788164
04-23 20:42:38.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:310,0.033514,9.775064,0.785749
04-23 20:42:38.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:330,0.034620,9.775389,0.781642
04-23 20:42:38.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:350,0.034979,9.775480,0.780483
04-23 20:42:38.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:369,0.034524,9.775608,0.778898
04-23 20:42:38.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:391,0.034090,9.775734,0.777335
04-23 20:42:38.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:409,0.033643,9.775516,0.780097
04-23 20:42:38.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:429,0.034423,9.775434,0.781072
04-23 20:42:38.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:449,0.033404,9.775165,0.784485
04-23 20:42:38.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.459+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:468,0.032408,9.775048,0.785983
04-23 20:42:38.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:490,0.032042,9.774797,0.789111
04-23 20:42:38.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.499+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:509,0.031012,9.774575,0.791898
04-23 20:42:38.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:529,0.032283,9.774288,0.795387
04-23 20:42:38.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.559+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:563,0.031029,9.773993,0.799046
04-23 20:42:38.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.639+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:647,0.029455,9.773856,0.800786
04-23 20:42:38.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:652,0.030364,9.773875,0.800515
04-23 20:42:38.649+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:656,0.030306,9.773929,0.799867
04-23 20:42:38.649+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.659+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:663,0.031061,9.773895,0.800249
04-23 20:42:38.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.669+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:670,0.030167,9.773863,0.800680
04-23 20:42:38.669+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.669+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:675,0.030008,9.773764,0.801893
04-23 20:42:38.679+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:38.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:38.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:38.699+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:692,0.030202,9.773632,0.803487
04-23 20:42:38.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:715,0.030620,9.773632,0.803465
04-23 20:42:38.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:730,0.030541,9.773569,0.804232
04-23 20:42:38.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.739+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:749,0.031963,9.773566,0.804222
04-23 20:42:38.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:769,0.032977,9.773581,0.804003
04-23 20:42:38.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:790,0.033258,9.773487,0.805123
04-23 20:42:38.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:809,0.033402,9.773386,0.806350
04-23 20:42:38.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.819+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:829,0.034926,9.773508,0.804806
04-23 20:42:38.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.839+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:849,0.034075,9.773472,0.805278
04-23 20:42:38.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.859+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:869,0.033165,9.773307,0.807316
04-23 20:42:38.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.899+0200 W/LOCATION(12859): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:42:38.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:890,0.031753,9.773552,0.804396
04-23 20:42:38.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:929,0.031786,9.773724,0.802313
04-23 20:42:38.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:941,0.031890,9.773674,0.802908
04-23 20:42:38.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:949,0.033354,9.773673,0.802860
04-23 20:42:38.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.959+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:969,0.033722,9.773611,0.803602
04-23 20:42:38.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:38:990,0.033403,9.773429,0.805827
04-23 20:42:38.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:38.999+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:9,0.032860,9.773427,0.805872
04-23 20:42:39.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.019+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:28,0.033492,9.773525,0.804657
04-23 20:42:39.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.039+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:49,0.034411,9.773443,0.805609
04-23 20:42:39.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.059+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:68,0.035064,9.773249,0.807934
04-23 20:42:39.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:90,0.035347,9.773130,0.809357
04-23 20:42:39.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.099+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:109,0.035209,9.773439,0.805617
04-23 20:42:39.129+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:136,0.034733,9.773565,0.804113
04-23 20:42:39.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:165,0.035284,9.773498,0.804907
04-23 20:42:39.169+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:39.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:39:175,0.034474,9.773618,0.803487
04-23 20:42:39.169+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11128596c6f63152450895
