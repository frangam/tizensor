S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12774
Date: 2018-04-23 20:42:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf737e52d, r5   = 0xf78d4958
r6   = 0xffa7ac00, r7   = 0xffa7aab0
r8   = 0xf78e7c18, r9   = 0x00000000
r10  = 0xffa7ab8c, fp   = 0xffa7ac00
ip   = 0x00000001, sp   = 0xffa7aa88
lr   = 0xf737e539, pc   = 0xf73e7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    130596 KB
Buffers:     40668 KB
Cached:     160960 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11868 KB
VmRSS:       11864 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12774 TID = 12774
12774 12790 

Maps Information
f4249000 f4a48000 rw-p [stack:12790]
f4a4f000 f4a51000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a59000 f4a5d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a66000 f4a68000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a70000 f4a73000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a82000 f4a87000 r-xp /usr/lib/libsystem.so.0.0.0
f4a92000 f4a95000 r-xp /lib/libattr.so.1.1.0
f4a9d000 f4aad000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ab5000 f4abe000 r-xp /usr/lib/libedbus.so.1.7.99
f4ac6000 f4ac7000 r-xp /usr/lib/libresponse.so.0.2.96
f4ad0000 f4ad5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6377000 f647d000 r-xp /usr/lib/libicuuc.so.57.1
f6493000 f661b000 r-xp /usr/lib/libicui18n.so.57.1
f662b000 f6638000 r-xp /usr/lib/libail.so.0.1.0
f6641000 f6648000 r-xp /usr/lib/libminizip.so.1.0.0
f6651000 f67fa000 r-xp /usr/lib/libcrypto.so.1.0.0
f681a000 f6861000 r-xp /usr/lib/libssl.so.1.0.0
f686d000 f686f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6877000 f687e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6887000 f688e000 r-xp /lib/libcrypt-2.13.so
f68bf000 f68c2000 r-xp /lib/libcap.so.2.21
f68ca000 f68cc000 r-xp /usr/lib/libiri.so
f68d4000 f691d000 r-xp /usr/lib/libmdm.so.1.2.69
f6925000 f692b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6933000 f6956000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6960000 f6962000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f696a000 f6987000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6990000 f6994000 r-xp /usr/lib/libsmack.so.1.0.0
f699d000 f69b6000 r-xp /usr/lib/libnetwork.so.0.0.0
f69bf000 f69c7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69cf000 f69d5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69de000 f69e0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69e9000 f69f9000 r-xp /lib/libresolv-2.13.so
f69fd000 f6a15000 r-xp /usr/lib/liblzma.so.5.0.3
f6a1e000 f6a20000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a28000 f6a42000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a4a000 f6a79000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a82000 f6a91000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a9b000 f6aa5000 r-xp /usr/lib/libsensord-shared.so
f6aae000 f6b81000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b8c000 f6ba2000 r-xp /lib/libz.so.1.2.5
f6baa000 f6baf000 r-xp /usr/lib/libffi.so.5.0.10
f6bb7000 f6bb8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bc0000 f6bd0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bd8000 f6bf1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bf9000 f6bfb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c03000 f6c78000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c82000 f6c88000 r-xp /lib/librt-2.13.so
f6c91000 f6caf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cb9000 f6cba000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cc2000 f6ce5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ced000 f6cf2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cfa000 f6d24000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d2d000 f6d44000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d4c000 f6db5000 r-xp /lib/libm-2.13.so
f6dbe000 f6e52000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e65000 f6e6a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e72000 f6e79000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e81000 f6eab000 r-xp /usr/lib/libsensor.so.1.9.6
f6eb4000 f6f80000 r-xp /usr/lib/libxml2.so.2.7.8
f6f8d000 f6f8f000 r-xp /usr/lib/libiniparser.so.0
f6f98000 f6f9e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fa7000 f7077000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7078000 f70ac000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70b5000 f70f1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70f9000 f70fc000 r-xp /usr/lib/libbundle.so.0.1.22
f7104000 f710a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7112000 f7153000 r-xp /usr/lib/libeina.so.1.7.99
f715c000 f7173000 r-xp /usr/lib/libecore.so.1.7.99
f718a000 f7193000 r-xp /usr/lib/libvconf.so.0.2.45
f719b000 f71af000 r-xp /lib/libpthread-2.13.so
f71ba000 f71c7000 r-xp /usr/lib/libaul.so.0.1.0
f71d1000 f71d3000 r-xp /lib/libdl-2.13.so
f71dc000 f71e7000 r-xp /lib/libunwind.so.8.0.1
f7214000 f721c000 r-xp /lib/libgcc_s-4.6.so.1
f721d000 f7341000 r-xp /lib/libc-2.13.so
f734f000 f7351000 r-xp /usr/lib/libdlog.so.0.0.0
f7359000 f7365000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f736e000 f7373000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f737b000 f738a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7392000 f7396000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f739f000 f73a2000 r-xp /usr/lib/libappcore-agent.so.1.1
f73aa000 f73ac000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73b4000 f73b8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73c0000 f73dd000 r-xp /lib/ld-2.13.so
f73e6000 f73e9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73e9000 f73ed000 r-xp /usr/lib/libsys-assert.so
f78b7000 f7928000 rw-p [heap]
ffa5c000 ffa7d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12774)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73e7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf737e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70853f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7083c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf708fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7095be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7095dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ca75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70c51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7083c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf708fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7095be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7095dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70c7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70c8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70cff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a671fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a5a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b2d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6fdafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fdc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf716cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7167b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71685a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7168879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73a0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73a07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73e75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf723485c) [/lib/libc.so.6] + 0x1785c
29: (0xf73e6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
uccessfully de-registered(0)
04-23 20:42:14.399+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf421a868
04-23 20:42:14.459+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf4203b28]
04-23 20:42:14.459+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:14.459+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:14.459+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:14.459+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:14.469+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:14.469+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:14.479+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.479+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.479+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:14.479+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:14.479+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:14.479+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:14.479+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:14.479+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:14.479+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:14.479+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:14.479+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:14.489+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.499+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.499+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:14.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:14.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:14.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:14.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:14.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:14.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:14.599+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf4203b28
04-23 20:42:14.649+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf794e3c8]
04-23 20:42:14.649+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:14.649+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:14.649+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:14.649+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:14.659+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:14.659+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:14.669+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.679+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.679+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:14.679+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:14.679+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:14.679+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:14.699+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:14.699+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:14.699+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:14.699+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:14.699+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:14.709+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.719+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:14.719+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:14.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:14.819+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:14.829+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:14.829+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:14.829+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:14.829+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf794e3c8
04-23 20:42:15.049+0200 W/AUL     (12736): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:42:15.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:42:15.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:42:15.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12700
04-23 20:42:15.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:42:15.049+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12700
04-23 20:42:15.049+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12700)
04-23 20:42:15.049+0200 E/RESOURCED( 2560): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'es.ugr.frailty.location': Not a directory
04-23 20:42:16.139+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:42:22.389+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][4][1][9][0][0][0][0][0][0][0][0][0][0]
04-23 20:42:22.659+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][4][2][a][0][0][0][0][0][0][0][0][0][0]
04-23 20:42:23.019+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:42:23.019+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:42:23.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:42:23.019+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:42:23.029+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:42:23.039+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12774
04-23 20:42:23.089+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12774
04-23 20:42:23.089+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12774) type(svcapp) bg(0)
04-23 20:42:23.089+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12774)
04-23 20:42:23.089+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:42:23.089+0200 I/servicemanager(12059): App control destroyed.
04-23 20:42:23.089+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12774]
04-23 20:42:23.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:23.109+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12774
04-23 20:42:23.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:23.119+0200 E/CAPI_APPFW_APPLICATION(12774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:23.119+0200 E/CAPI_APPFW_APPLICATION(12774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:23.119+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12774) was created
04-23 20:42:23.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:23.139+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12774
04-23 20:42:23.139+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:23.159+0200 W/LOCATION(12774): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:42:23.159+0200 E/LOCATION(12774): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:42:23.159+0200 E/PKGMGR_INFO(12774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:42:23.169+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:23.179+0200 I/LOCATION(12774): location.c: location_new(269) > method: 0
04-23 20:42:23.189+0200 W/LOCATION(12774): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:23.189+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:23.189+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:23.199+0200 W/LOCATION(12774): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:23.199+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:23.209+0200 W/LOCATION(12774): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:23.209+0200 W/LOCATION(12774): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:23.209+0200 W/LOCATION(12774): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:23.209+0200 W/LOCATION(12774): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:23.229+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:23.229+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:23.239+0200 W/LOCATION(12774): module-internal.c: module_new(311) > module (wps) open success
04-23 20:42:23.239+0200 W/LOCATION(12774): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:42:23.239+0200 W/LOCATION(12774): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:42:23.239+0200 W/LOCATION(12774): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:23.249+0200 W/LOCATION(12774): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:23.259+0200 W/LOCATION(12774): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:42:23.259+0200 I/LOCATION(12774): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf78e7c18
04-23 20:42:23.259+0200 I/LOCATION(12774): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:42:23.269+0200 I/LOCATION(12774): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf78e7c18
04-23 20:42:23.269+0200 I/LOCATION(12774): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:42:23.269+0200 I/location(12774): es.ugr.frailty.location: creado servicio de localización
04-23 20:42:23.319+0200 I/LOCATION(12774): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:42:23.339+0200 I/servicemanager(12059): es.ugr.frailty.gravity alive timeout
04-23 20:42:23.339+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:42:23.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:42:23.339+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:42:23.349+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12777
04-23 20:42:23.349+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:42:23.389+0200 E/CAPI_APPFW_APPLICATION(12777): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:23.389+0200 E/CAPI_APPFW_APPLICATION(12777): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:23.389+0200 I/utils   (12777): trying to start service: es.ugr.frailty.gravity
04-23 20:42:23.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12777
04-23 20:42:23.399+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(12777) type(svcapp) bg(0)
04-23 20:42:23.399+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12777) was created
04-23 20:42:23.399+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12777]
04-23 20:42:23.409+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12777)
04-23 20:42:23.409+0200 I/servicemanager(12059): es.ugr.frailty.gravity launch request sent!
04-23 20:42:23.409+0200 I/servicemanager(12059): App control destroyed.
04-23 20:42:23.409+0200 I/utils   (12777): es.ugr.frailty.gravity sensor supported
04-23 20:42:23.419+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:23.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12777
04-23 20:42:23.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:23.449+0200 I/utils   (12777): es.ugr.frailty.gravity listener started
04-23 20:42:23.449+0200 W/CAPI_APPFW_APP_CONTROL(12777): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:42:23.449+0200 I/utils   (12777): specific action
04-23 20:42:23.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:23.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12777
04-23 20:42:23.469+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.479+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:479,9.782258,-0.031062,0.690540
04-23 20:42:23.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:23.509+0200 W/LOCATION(12774): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:23.529+0200 W/LOCATION(12774): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:23.529+0200 I/LOCATION(12774): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:42:23.599+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:42:23.599+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:23.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:23.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:42:23.599+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:42:23.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:42:23.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:42:23.609+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:42:23.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:42:23.609+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:42:23.609+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:42:23.609+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:42:23.609+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:42:23.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.659+0200 W/LOCATION(12774): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:23.659+0200 W/LOCATION(12774): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:23.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:23.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:23.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:23.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:669,1.661476,7.359663,6.264603
04-23 20:42:23.769+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:23.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:775,1.880319,6.054451,7.481872
04-23 20:42:23.809+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.809+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79ce478]
04-23 20:42:23.809+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:23.809+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:23.809+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:23.809+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:23.819+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:23.819+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:23.829+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:23.839+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:23.839+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:23.839+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:23.839+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:23.839+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:23.839+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:23.839+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:23.839+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:23.839+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:23.839+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:23.849+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:23.849+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:42:23.849+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3019113), time2(3005551)
04-23 20:42:23.849+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:42:23.849+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:42:23.849+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:42:23.849+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:42:23.859+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:23.859+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:23.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:23.899+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:815,1.799147,6.136204,7.435083
04-23 20:42:23.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.909+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:23.929+0200 W/LOCATION(12774): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:23.929+0200 I/LOCATION(12774): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:23.939+0200 I/LOCATION(12774): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:23.939+0200 I/location(12774): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:42:23.959+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:914,1.718120,6.194968,7.405458
04-23 20:42:23.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:969,1.649487,6.316150,7.318184
04-23 20:42:23.969+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:973,1.583447,6.435601,7.228148
04-23 20:42:23.969+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:977,1.517606,6.535712,7.152043
04-23 20:42:23.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.979+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:986,1.455303,6.641835,7.066719
04-23 20:42:23.989+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:23:996,1.383539,6.645048,7.078103
04-23 20:42:23.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.999+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:5,1.331739,6.794442,6.944956
04-23 20:42:23.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:23.999+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:9,0.458915,9.472170,2.497556
04-23 20:42:24.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:19,0.438864,9.471212,2.504780
04-23 20:42:24.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.019+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:28,0.421157,9.476719,2.486929
04-23 20:42:24.029+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:37,0.402935,9.477149,2.488307
04-23 20:42:24.029+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.039+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:41,0.387608,9.486816,2.453664
04-23 20:42:24.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:50,0.370894,9.488041,2.451510
04-23 20:42:24.049+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.059+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:61,0.356794,9.497829,2.415433
04-23 20:42:24.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:71,0.341933,9.501911,2.401490
04-23 20:42:24.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.079+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:84,0.328825,9.511764,2.364026
04-23 20:42:24.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:91,0.316597,9.523392,2.318439
04-23 20:42:24.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:110,0.304648,9.533360,2.278732
04-23 20:42:24.109+0200 I/LOCATION(12774): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:24.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:129,0.293789,9.545901,2.227071
04-23 20:42:24.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.139+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:149,0.280987,9.546067,2.228012
04-23 20:42:24.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:169,0.268626,9.545859,2.230425
04-23 20:42:24.169+0200 I/location(12774): es.ugr.frailty.location: waiting for rigth values
04-23 20:42:24.169+0200 W/CAPI_APPFW_APP_CONTROL(12774): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:42:24.169+0200 I/utils   (12774): specific action
04-23 20:42:24.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:190,0.258225,9.553545,2.198520
04-23 20:42:24.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:209,0.248683,9.563327,2.156692
04-23 20:42:24.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:229,0.237494,9.562330,2.162367
04-23 20:42:24.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.239+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:249,0.228221,9.569439,2.131698
04-23 20:42:24.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.259+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:269,0.218017,9.570436,2.128284
04-23 20:42:24.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:290,0.209730,9.577860,2.095472
04-23 20:42:24.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.299+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:309,0.202182,9.587591,2.051242
04-23 20:42:24.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:329,0.194048,9.591651,2.032969
04-23 20:42:24.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:350,0.187678,9.603216,1.978234
04-23 20:42:24.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:369,0.182188,9.617661,1.907297
04-23 20:42:24.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:390,0.174435,9.618420,1.904196
04-23 20:42:24.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:409,0.167919,9.624195,1.875383
04-23 20:42:24.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.419+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:429,0.159052,9.618354,1.905876
04-23 20:42:24.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.439+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:449,0.151339,9.616975,1.913444
04-23 20:42:24.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.469+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:469,0.145769,9.623201,1.882322
04-23 20:42:24.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:490,0.141663,9.636031,1.815824
04-23 20:42:24.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.499+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:509,0.137713,9.647928,1.751825
04-23 20:42:24.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:530,0.133081,9.654457,1.715849
04-23 20:42:24.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.539+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:549,0.129128,9.662934,1.667756
04-23 20:42:24.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.559+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:569,0.125449,9.670682,1.622517
04-23 20:42:24.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:590,0.119940,9.670957,1.621293
04-23 20:42:24.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.599+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:609,0.116653,9.678160,1.577971
04-23 20:42:24.619+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.619+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:629,0.113169,9.683813,1.543160
04-23 20:42:24.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:650,0.108801,9.685695,1.531623
04-23 20:42:24.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.659+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:669,0.105891,9.691752,1.493018
04-23 20:42:24.679+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.689+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:690,0.103587,9.698941,1.445751
04-23 20:42:24.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:24.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:24.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:24.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:709,0.099228,9.699256,1.443941
04-23 20:42:24.729+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.739+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:738,0.095959,9.702009,1.425547
04-23 20:42:24.749+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:753,0.092285,9.703050,1.418695
04-23 20:42:24.769+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:779,0.088883,9.704870,1.406407
04-23 20:42:24.789+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.799+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:803,0.087554,9.711394,1.360711
04-23 20:42:24.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:816,0.083688,9.711324,1.361463
04-23 20:42:24.829+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:837,0.080927,9.713370,1.346950
04-23 20:42:24.849+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:853,0.079533,9.718410,1.310172
04-23 20:42:24.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.859+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:869,0.078090,9.722829,1.277058
04-23 20:42:24.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:892,0.076582,9.726354,1.250023
04-23 20:42:24.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:923,0.076405,9.732203,1.203657
04-23 20:42:24.939+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:42:24.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:950,0.074010,9.734065,1.188647
04-23 20:42:24.949+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:955,0.072404,9.737260,1.162288
04-23 20:42:24.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.959+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:969,0.067703,9.734553,1.185018
04-23 20:42:24.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:24.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:24:990,0.066911,9.737409,1.161373
04-23 20:42:24.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:9,0.065033,9.738960,1.148395
04-23 20:42:25.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:29,0.062324,9.738961,1.148536
04-23 20:42:25.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:49,0.060094,9.739351,1.145339
04-23 20:42:25.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:69,0.060681,9.743735,1.107392
04-23 20:42:25.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:90,0.058548,9.743739,1.107473
04-23 20:42:25.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:109,0.056612,9.744115,1.104266
04-23 20:42:25.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:129,0.055250,9.746017,1.087416
04-23 20:42:25.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:149,0.052371,9.745944,1.088213
04-23 20:42:25.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.159+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:169,0.050872,9.747383,1.075322
04-23 20:42:25.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:191,0.050007,9.749402,1.056903
04-23 20:42:25.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:209,0.050763,9.752782,1.025213
04-23 20:42:25.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.219+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:229,0.048429,9.753105,1.022244
04-23 20:42:25.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:249,0.047762,9.754131,1.012437
04-23 20:42:25.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:273,0.045938,9.754654,1.007470
04-23 20:42:25.349+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:357,0.044646,9.755852,0.995863
04-23 20:42:25.349+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:361,0.044332,9.757847,0.976134
04-23 20:42:25.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:367,0.043543,9.759001,0.964565
04-23 20:42:25.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:372,0.043482,9.760603,0.948226
04-23 20:42:25.369+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:377,0.043186,9.761782,0.936027
04-23 20:42:25.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:390,0.043902,9.762993,0.923266
04-23 20:42:25.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.399+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:409,0.045067,9.764595,0.906114
04-23 20:42:25.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:429,0.043909,9.764944,0.902402
04-23 20:42:25.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.439+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:449,0.043936,9.765740,0.893733
04-23 20:42:25.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.459+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:469,0.044080,9.766685,0.883359
04-23 20:42:25.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:490,0.043763,9.767406,0.875360
04-23 20:42:25.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:509,0.043013,9.767852,0.870405
04-23 20:42:25.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:529,0.039709,9.767640,0.872930
04-23 20:42:25.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.549+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:550,0.039817,9.768193,0.866722
04-23 20:42:25.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.559+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:569,0.039358,9.768588,0.862275
04-23 20:42:25.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:590,0.038943,9.769234,0.854953
04-23 20:42:25.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.609+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:609,0.037640,9.769594,0.850884
04-23 20:42:25.619+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.619+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:629,0.036862,9.769912,0.847255
04-23 20:42:25.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.639+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:649,0.036104,9.770234,0.843567
04-23 20:42:25.659+0200 W/LOCATION(12774): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:42:25.669+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:25.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:25.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:25.689+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:679,0.036358,9.770294,0.842859
04-23 20:42:25.689+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.689+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:694,0.034728,9.770416,0.841511
04-23 20:42:25.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.699+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:709,0.033923,9.770286,0.843056
04-23 20:42:25.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:730,0.034167,9.770276,0.843160
04-23 20:42:25.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.739+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:749,0.033724,9.770252,0.843453
04-23 20:42:25.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:769,0.033855,9.770201,0.844045
04-23 20:42:25.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:790,0.034202,9.770154,0.844576
04-23 20:42:25.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.799+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:809,0.033740,9.770124,0.844932
04-23 20:42:25.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.819+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:828,0.035224,9.770308,0.842747
04-23 20:42:25.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:849,0.035177,9.770438,0.841244
04-23 20:42:25.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.859+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:869,0.035126,9.770512,0.840385
04-23 20:42:25.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:920,0.035179,9.770539,0.840066
04-23 20:42:25.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:927,0.033995,9.770367,0.842118
04-23 20:42:25.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:25.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:25:938,0.034375,9.770709,0.838122
04-23 20:42:25.939+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11127746c6f63152450894
