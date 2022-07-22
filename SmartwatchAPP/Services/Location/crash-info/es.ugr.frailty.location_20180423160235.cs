S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23278
Date: 2018-04-23 16:02:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fbc52d, r5   = 0xf784df98
r6   = 0xffd8bae8, r7   = 0xffd8b998
r8   = 0xf784ac18, r9   = 0x00000000
r10  = 0xffd8ba74, fp   = 0xffd8bae8
ip   = 0x00000001, sp   = 0xffd8a818
lr   = 0xf6fbc539, pc   = 0xf70252b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10416 KB
Buffers:     60952 KB
Cached:     226256 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11992 KB
VmRSS:       11992 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23278 TID = 23278
23278 23281 

Maps Information
f3e87000 f4686000 rw-p [stack:23281]
f468d000 f468f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4697000 f469b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46a4000 f46a6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46ae000 f46b1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46c0000 f46c5000 r-xp /usr/lib/libsystem.so.0.0.0
f46d0000 f46d3000 r-xp /lib/libattr.so.1.1.0
f46db000 f46eb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46f3000 f46fc000 r-xp /usr/lib/libedbus.so.1.7.99
f4704000 f4705000 r-xp /usr/lib/libresponse.so.0.2.96
f470e000 f4713000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fb5000 f60bb000 r-xp /usr/lib/libicuuc.so.57.1
f60d1000 f6259000 r-xp /usr/lib/libicui18n.so.57.1
f6269000 f6276000 r-xp /usr/lib/libail.so.0.1.0
f627f000 f6286000 r-xp /usr/lib/libminizip.so.1.0.0
f628f000 f6438000 r-xp /usr/lib/libcrypto.so.1.0.0
f6458000 f649f000 r-xp /usr/lib/libssl.so.1.0.0
f64ab000 f64ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64b5000 f64bc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64c5000 f64cc000 r-xp /lib/libcrypt-2.13.so
f64fd000 f6500000 r-xp /lib/libcap.so.2.21
f6508000 f650a000 r-xp /usr/lib/libiri.so
f6512000 f655b000 r-xp /usr/lib/libmdm.so.1.2.69
f6563000 f6569000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6571000 f6594000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f659e000 f65a0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65a8000 f65c5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65ce000 f65d2000 r-xp /usr/lib/libsmack.so.1.0.0
f65db000 f65f4000 r-xp /usr/lib/libnetwork.so.0.0.0
f65fd000 f6605000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f660d000 f6613000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f661c000 f661e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6627000 f6637000 r-xp /lib/libresolv-2.13.so
f663b000 f6653000 r-xp /usr/lib/liblzma.so.5.0.3
f665c000 f665e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6666000 f6680000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6688000 f66b7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66c0000 f66cf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66d9000 f66e3000 r-xp /usr/lib/libsensord-shared.so
f66ec000 f67bf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67ca000 f67e0000 r-xp /lib/libz.so.1.2.5
f67e8000 f67ed000 r-xp /usr/lib/libffi.so.5.0.10
f67f5000 f67f6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67fe000 f680e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6816000 f682f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6837000 f6839000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6841000 f68b6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68c0000 f68c6000 r-xp /lib/librt-2.13.so
f68cf000 f68ed000 r-xp /usr/lib/libsystemd.so.0.4.0
f68f7000 f68f8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6900000 f6923000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f692b000 f6930000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6938000 f6962000 r-xp /usr/lib/libdbus-1.so.3.8.12
f696b000 f6982000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f698a000 f69f3000 r-xp /lib/libm-2.13.so
f69fc000 f6a90000 r-xp /usr/lib/libstdc++.so.6.0.16
f6aa3000 f6aa8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ab0000 f6ab7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6abf000 f6ae9000 r-xp /usr/lib/libsensor.so.1.9.6
f6af2000 f6bbe000 r-xp /usr/lib/libxml2.so.2.7.8
f6bcb000 f6bcd000 r-xp /usr/lib/libiniparser.so.0
f6bd6000 f6bdc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6be5000 f6cb5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cb6000 f6cea000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cf3000 f6d2f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d37000 f6d3a000 r-xp /usr/lib/libbundle.so.0.1.22
f6d42000 f6d48000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d50000 f6d91000 r-xp /usr/lib/libeina.so.1.7.99
f6d9a000 f6db1000 r-xp /usr/lib/libecore.so.1.7.99
f6dc8000 f6dd1000 r-xp /usr/lib/libvconf.so.0.2.45
f6dd9000 f6ded000 r-xp /lib/libpthread-2.13.so
f6df8000 f6e05000 r-xp /usr/lib/libaul.so.0.1.0
f6e0f000 f6e11000 r-xp /lib/libdl-2.13.so
f6e1a000 f6e25000 r-xp /lib/libunwind.so.8.0.1
f6e52000 f6e5a000 r-xp /lib/libgcc_s-4.6.so.1
f6e5b000 f6f7f000 r-xp /lib/libc-2.13.so
f6f8d000 f6f8f000 r-xp /usr/lib/libdlog.so.0.0.0
f6f97000 f6fa3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fac000 f6fb1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fb9000 f6fc8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fd0000 f6fd4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fdd000 f6fe0000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fe8000 f6fea000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6ff2000 f6ff6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6ffe000 f701b000 r-xp /lib/ld-2.13.so
f7024000 f7027000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7027000 f702b000 r-xp /usr/lib/libsys-assert.so
f781a000 f78a4000 rw-p [heap]
ffd6d000 ffd8e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23278)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf70252b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf6fbc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cc33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cc1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ccde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cd3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cd3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d0875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d031f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cc1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ccde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cd3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cd3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d05e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d06017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d0a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf6ff40bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4698171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf676b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c18fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c1a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6daaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6da5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6da65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6da6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fde183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fde7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70256a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6e7285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7024fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:45.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:45.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:45.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e183c0
04-23 16:02:45.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375fc0]
04-23 16:02:45.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:45.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:45.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:45.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:45.771+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:45.771+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:45.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:45.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:45.791+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:45.791+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:45.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:45.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:45.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:45.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:45.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:45.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:45.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:45.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:45.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:45.801+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:45.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:45.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:45.861+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:45.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:45.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:45.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:45.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375fc0
04-23 16:02:46.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7370938]
04-23 16:02:46.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:46.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:46.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:46.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:46.031+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:46.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:46.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:46.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:46.061+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:46.061+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:46.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:46.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:46.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:46.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:46.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:46.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:46.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:46.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:46.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:46.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:46.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:46.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:46.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:46.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:46.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:46.141+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7370938
04-23 16:02:46.341+0200 W/AUL     (23432): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:46.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:46.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:46.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23393
04-23 16:02:46.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:46.381+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23393
04-23 16:02:46.381+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23393)
04-23 16:02:46.471+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:46.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:46.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:46.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:46.481+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23433
04-23 16:02:46.481+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:46.531+0200 E/CAPI_APPFW_APPLICATION(23433): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:46.531+0200 E/CAPI_APPFW_APPLICATION(23433): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:46.551+0200 W/LOCATION(23433): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:46.551+0200 E/LOCATION(23433): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:46.551+0200 E/PKGMGR_INFO(23433): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:46.551+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:46.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23433
04-23 16:02:46.571+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23433) type(svcapp) bg(0)
04-23 16:02:46.571+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23433) was created
04-23 16:02:46.571+0200 I/LOCATION(23433): location.c: location_new(269) > method: 0
04-23 16:02:46.571+0200 W/LOCATION(23433): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:46.571+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:46.581+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:46.581+0200 W/LOCATION(23433): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:46.581+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:46.591+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23433]
04-23 16:02:46.591+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23433)
04-23 16:02:46.591+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:46.591+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:46.591+0200 W/LOCATION(23433): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:46.591+0200 W/LOCATION(23433): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:46.601+0200 W/LOCATION(23433): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:46.601+0200 W/LOCATION(23433): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:46.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:46.611+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23433
04-23 16:02:46.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:46.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:46.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23433
04-23 16:02:46.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:46.641+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:46.641+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:46.651+0200 W/LOCATION(23433): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:46.651+0200 W/LOCATION(23433): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:46.661+0200 W/LOCATION(23433): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:46.661+0200 W/LOCATION(23433): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:46.661+0200 W/LOCATION(23433): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:46.681+0200 W/LOCATION(23433): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:46.681+0200 I/LOCATION(23433): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77aac18
04-23 16:02:46.681+0200 I/LOCATION(23433): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:46.681+0200 I/LOCATION(23433): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77aac18
04-23 16:02:46.681+0200 I/LOCATION(23433): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:46.691+0200 I/location(23433): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:46.751+0200 I/LOCATION(23433): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:46.791+0200 W/LOCATION(23433): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:46.791+0200 W/LOCATION(23433): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:46.791+0200 I/LOCATION(23433): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:46.861+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:46.861+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:46.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:46.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:46.861+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:46.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:46.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:46.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:46.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:46.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:46.871+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:46.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:46.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:46.921+0200 W/LOCATION(23433): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:46.921+0200 W/LOCATION(23433): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:47.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:47.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361870]
04-23 16:02:47.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:47.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:47.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:47.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:47.051+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:47.051+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:47.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:47.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:47.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:47.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:47.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:47.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:47.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:47.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:47.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:47.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:47.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:47.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:47.101+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6062769), time2(6056574)
04-23 16:02:47.101+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:47.101+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:47.101+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:47.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:47.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:47.161+0200 W/LOCATION(23433): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:47.161+0200 I/LOCATION(23433): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:47.161+0200 I/LOCATION(23433): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:47.161+0200 I/location(23433): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:47.281+0200 I/LOCATION(23433): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:47.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:47.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:47.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:47.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:47.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:47.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:47.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:47.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:47.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:47.411+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:47.441+0200 W/AUL     (23433): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:47.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:47.441+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23433
04-23 16:02:47.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:47.451+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:47.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:47.451+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.461+0200 I/utils   (19708): specific action
04-23 16:02:47.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.461+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:47.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:47.461+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:47.471+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:47.471+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:47.471+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:47.471+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.471+0200 I/utils   (22624): specific action
04-23 16:02:47.471+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.471+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.471+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.471+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.471+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:47.471+0200 I/recorder(22624): guardando datos en local
04-23 16:02:47.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:47.471+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:47.471+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:47.471+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer alive timeout
04-23 16:02:47.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:02:47.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:47.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:47.491+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23441
04-23 16:02:47.491+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:47.521+0200 E/CAPI_APPFW_APPLICATION(23441): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:47.521+0200 E/CAPI_APPFW_APPLICATION(23441): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:47.521+0200 I/utils   (23441): trying to start service: es.ugr.frailty.accelerometer
04-23 16:02:47.521+0200 W/AUL     (23433): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:47.531+0200 I/location(23433): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:47.531+0200 W/CAPI_APPFW_APP_CONTROL(23433): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.531+0200 I/utils   (23433): specific action
04-23 16:02:47.531+0200 I/utils   (23441): es.ugr.frailty.accelerometer sensor supported
04-23 16:02:47.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23441
04-23 16:02:47.541+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23441) type(svcapp) bg(0)
04-23 16:02:47.541+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23441) was created
04-23 16:02:47.551+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23441]
04-23 16:02:47.551+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23441)
04-23 16:02:47.551+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer launch request sent!
04-23 16:02:47.551+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:47.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:47.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23441
04-23 16:02:47.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:47.611+0200 I/utils   (23441): es.ugr.frailty.accelerometer listener started
04-23 16:02:47.611+0200 W/CAPI_APPFW_APP_CONTROL(23441): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.611+0200 I/utils   (23441): specific action
04-23 16:02:47.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:47.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23441
04-23 16:02:47.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:47.641+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.661+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:653,-1.923829,-3.199204,9.092726
04-23 16:02:47.661+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.661+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:668,-1.880759,-3.225525,9.068797
04-23 16:02:47.661+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.671+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:672,-1.871187,-3.199204,9.018548
04-23 16:02:47.681+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.681+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:689,-1.842474,-3.256632,9.030513
04-23 16:02:47.701+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.701+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:706,-1.806581,-3.261417,9.056834
04-23 16:02:47.711+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope alive timeout
04-23 16:02:47.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:02:47.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:47.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:47.721+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.721+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23454
04-23 16:02:47.721+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:47.741+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:727,-1.866402,-3.244668,9.018548
04-23 16:02:47.741+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.741+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:747,-1.861616,-3.232704,9.075976
04-23 16:02:47.761+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.761+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:767,-1.885544,-3.225525,9.147761
04-23 16:02:47.761+0200 E/CAPI_APPFW_APPLICATION(23454): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:47.761+0200 E/CAPI_APPFW_APPLICATION(23454): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:47.771+0200 I/utils   (23454): trying to start service: es.ugr.frailty.gyroscope
04-23 16:02:47.771+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23454
04-23 16:02:47.771+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(23454) type(svcapp) bg(0)
04-23 16:02:47.771+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23454) was created
04-23 16:02:47.771+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23454]
04-23 16:02:47.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23454)
04-23 16:02:47.781+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope launch request sent!
04-23 16:02:47.781+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:47.791+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.791+0200 I/utils   (23454): es.ugr.frailty.gyroscope sensor supported
04-23 16:02:47.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:47.801+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23454
04-23 16:02:47.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:47.801+0200 I/LOCATION(23433): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:47.811+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:797,-1.902294,-3.242275,9.092726
04-23 16:02:47.811+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.811+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:818,-1.919044,-3.227918,9.092726
04-23 16:02:47.821+0200 I/utils   (23454): es.ugr.frailty.gyroscope listener started
04-23 16:02:47.821+0200 W/CAPI_APPFW_APP_CONTROL(23454): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:47.821+0200 I/utils   (23454): specific action
04-23 16:02:47.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:47.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23454
04-23 16:02:47.831+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.831+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:47.841+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:841,-0.700000,0.490000,-0.560000
04-23 16:02:47.841+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.841+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:844,-1.923829,-3.127419,9.095119
04-23 16:02:47.841+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.851+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:852,-0.630000,0.560000,-0.140000
04-23 16:02:47.851+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:854,-1.945365,-3.165704,9.047262
04-23 16:02:47.891+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.901+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:904,-0.210000,0.490000,0.070000
04-23 16:02:47.901+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.901+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:909,0.700000,0.770000,0.140000
04-23 16:02:47.901+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.911+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.911+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:915,-1.947758,-3.194418,9.006584
04-23 16:02:47.911+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.911+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:919,-1.954936,-3.225525,9.064013
04-23 16:02:47.911+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:47.931+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:912,0.980000,0.840000,0.210000
04-23 16:02:47.931+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.941+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:941,0.560000,0.910000,0.280000
04-23 16:02:47.941+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:47.991+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:47:947,-0.140000,0.980000,0.350000
04-23 16:02:47.991+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.001+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:47:922,-1.887937,-3.184847,9.056834
04-23 16:02:48.011+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.011+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:15,-1.880759,-3.177669,9.056834
04-23 16:02:48.011+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.011+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:0,-0.490000,0.770000,0.070000
04-23 16:02:48.011+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.031+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:19,-1.914258,-3.201597,9.109475
04-23 16:02:48.031+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.031+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:39,-1.890330,-3.251846,9.116654
04-23 16:02:48.031+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.041+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:24,-0.210000,0.630000,-0.140000
04-23 16:02:48.041+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.061+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:50,0.350000,0.630000,-0.350000
04-23 16:02:48.061+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.101+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:43,-1.907080,-3.247060,9.080762
04-23 16:02:48.101+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.151+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:02:48.151+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:71,0.210000,0.560000,-0.210000
04-23 16:02:48.151+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.171+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:109,-1.890330,-3.223132,9.078369
04-23 16:02:48.171+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.171+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:162,-0.350000,0.420000,-0.070000
04-23 16:02:48.171+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.171+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:180,-0.490000,0.210000,-0.070000
04-23 16:02:48.171+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.181+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:177,-1.923829,-3.172883,9.111869
04-23 16:02:48.181+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.191+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:193,-1.931008,-3.192025,9.073583
04-23 16:02:48.191+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.191+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:197,-1.928615,-3.189633,9.032906
04-23 16:02:48.191+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:48.221+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:48.221+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:48.221+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:48.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:48.221+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:183,0.210000,0.140000,-0.070000
04-23 16:02:48.221+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.231+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:231,0.350000,0.210000,-0.140000
04-23 16:02:48.231+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.231+0200 W/AUL     (23474): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:48.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:48.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:48.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23420
04-23 16:02:48.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:48.231+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23420
04-23 16:02:48.231+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23420)
04-23 16:02:48.241+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:200,-1.923829,-3.227918,9.083155
04-23 16:02:48.241+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.241+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:249,-1.907080,-3.208775,9.104690
04-23 16:02:48.251+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:238,0.140000,0.140000,-0.140000
04-23 16:02:48.251+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.261+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.261+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:265,-1.921437,-3.208775,9.087940
04-23 16:02:48.261+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.271+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:261,-0.210000,0.140000,-0.210000
04-23 16:02:48.271+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.271+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:276,-0.350000,-0.070000,-0.280000
04-23 16:02:48.271+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.271+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:280,-0.350000,0.070000,-0.280000
04-23 16:02:48.271+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.291+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:273,-1.897508,-3.199204,9.047262
04-23 16:02:48.291+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.291+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:297,-1.902294,-3.242275,9.066404
04-23 16:02:48.291+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.291+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:300,-1.902294,-3.259024,9.032906
04-23 16:02:48.291+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.301+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:283,0.070000,0.210000,-0.280000
04-23 16:02:48.301+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.301+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:307,-0.070000,0.140000,-0.210000
04-23 16:02:48.301+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.311+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:304,-1.907080,-3.237489,9.061620
04-23 16:02:48.311+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.321+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:311,0.140000,0.140000,-0.140000
04-23 16:02:48.321+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.321+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:322,-1.940579,-3.194418,9.135797
04-23 16:02:48.331+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.331+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:326,0.210000,-0.070000,0.070000
04-23 16:02:48.331+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.341+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:343,0.210000,-0.210000,0.350000
04-23 16:02:48.341+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.361+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:337,-1.950150,-3.175276,9.150154
04-23 16:02:48.361+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.361+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:366,-1.914258,-3.203990,9.114261
04-23 16:02:48.361+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.361+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:352,-0.280000,-0.280000,0.700000
04-23 16:02:48.371+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.371+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:371,-1.928615,-3.180061,9.090333
04-23 16:02:48.371+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.381+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:374,-0.280000,-0.490000,0.560000
04-23 16:02:48.381+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.381+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:388,0.490000,-0.280000,0.350000
04-23 16:02:48.391+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:384,-1.880759,-3.201597,9.073583
04-23 16:02:48.391+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.391+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:396,-1.852045,-3.261417,9.073583
04-23 16:02:48.381+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.391+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.411+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:392,0.980000,-0.420000,0.070000
04-23 16:02:48.411+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:48.421+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:400,-1.844866,-3.235096,9.073583
04-23 16:02:48.421+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:48:416,0.770000,-0.630000,-0.070000
04-23 16:02:48.421+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.421+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:429,-1.914258,-3.266203,9.032906
04-23 16:02:48.421+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:48.431+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:48:433,-1.962115,-3.263810,9.078369
04-23 16:02:48.471+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11232786c6f63152449215
