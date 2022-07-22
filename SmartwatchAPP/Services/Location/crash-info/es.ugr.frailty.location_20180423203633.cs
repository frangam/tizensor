S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11081
Date: 2018-04-23 20:36:33+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf717252d, r5   = 0xf7257f98
r6   = 0xffa8f810, r7   = 0xffa8f6c0
r8   = 0xf7254c18, r9   = 0x00000000
r10  = 0xffa8f79c, fp   = 0xffa8f810
ip   = 0x00000001, sp   = 0xffa8f698
lr   = 0xf7172539, pc   = 0xf71db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    124212 KB
Buffers:     38144 KB
Cached:     158320 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11800 KB
VmRSS:       11800 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11081 TID = 11081
11081 11084 

Maps Information
f403d000 f483c000 rw-p [stack:11084]
f4843000 f4845000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f484d000 f4851000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f485a000 f485c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4864000 f4867000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4876000 f487b000 r-xp /usr/lib/libsystem.so.0.0.0
f4886000 f4889000 r-xp /lib/libattr.so.1.1.0
f4891000 f48a1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48a9000 f48b2000 r-xp /usr/lib/libedbus.so.1.7.99
f48ba000 f48bb000 r-xp /usr/lib/libresponse.so.0.2.96
f48c4000 f48c9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f616b000 f6271000 r-xp /usr/lib/libicuuc.so.57.1
f6287000 f640f000 r-xp /usr/lib/libicui18n.so.57.1
f641f000 f642c000 r-xp /usr/lib/libail.so.0.1.0
f6435000 f643c000 r-xp /usr/lib/libminizip.so.1.0.0
f6445000 f65ee000 r-xp /usr/lib/libcrypto.so.1.0.0
f660e000 f6655000 r-xp /usr/lib/libssl.so.1.0.0
f6661000 f6663000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f666b000 f6672000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f667b000 f6682000 r-xp /lib/libcrypt-2.13.so
f66b3000 f66b6000 r-xp /lib/libcap.so.2.21
f66be000 f66c0000 r-xp /usr/lib/libiri.so
f66c8000 f6711000 r-xp /usr/lib/libmdm.so.1.2.69
f6719000 f671f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6727000 f674a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6754000 f6756000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f675e000 f677b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6784000 f6788000 r-xp /usr/lib/libsmack.so.1.0.0
f6791000 f67aa000 r-xp /usr/lib/libnetwork.so.0.0.0
f67b3000 f67bb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67c3000 f67c9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67d2000 f67d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67dd000 f67ed000 r-xp /lib/libresolv-2.13.so
f67f1000 f6809000 r-xp /usr/lib/liblzma.so.5.0.3
f6812000 f6814000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f681c000 f6836000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f683e000 f686d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6876000 f6885000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f688f000 f6899000 r-xp /usr/lib/libsensord-shared.so
f68a2000 f6975000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6980000 f6996000 r-xp /lib/libz.so.1.2.5
f699e000 f69a3000 r-xp /usr/lib/libffi.so.5.0.10
f69ab000 f69ac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69b4000 f69c4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69cc000 f69e5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69ed000 f69ef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69f7000 f6a6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a76000 f6a7c000 r-xp /lib/librt-2.13.so
f6a85000 f6aa3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aad000 f6aae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ab6000 f6ad9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ae1000 f6ae6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aee000 f6b18000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b21000 f6b38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b40000 f6ba9000 r-xp /lib/libm-2.13.so
f6bb2000 f6c46000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c59000 f6c5e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c66000 f6c6d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c75000 f6c9f000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca8000 f6d74000 r-xp /usr/lib/libxml2.so.2.7.8
f6d81000 f6d83000 r-xp /usr/lib/libiniparser.so.0
f6d8c000 f6d92000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d9b000 f6e6b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e6c000 f6ea0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea9000 f6ee5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eed000 f6ef0000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef8000 f6efe000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f06000 f6f47000 r-xp /usr/lib/libeina.so.1.7.99
f6f50000 f6f67000 r-xp /usr/lib/libecore.so.1.7.99
f6f7e000 f6f87000 r-xp /usr/lib/libvconf.so.0.2.45
f6f8f000 f6fa3000 r-xp /lib/libpthread-2.13.so
f6fae000 f6fbb000 r-xp /usr/lib/libaul.so.0.1.0
f6fc5000 f6fc7000 r-xp /lib/libdl-2.13.so
f6fd0000 f6fdb000 r-xp /lib/libunwind.so.8.0.1
f7008000 f7010000 r-xp /lib/libgcc_s-4.6.so.1
f7011000 f7135000 r-xp /lib/libc-2.13.so
f7143000 f7145000 r-xp /usr/lib/libdlog.so.0.0.0
f714d000 f7159000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7162000 f7167000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f716f000 f717e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7186000 f718a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7193000 f7196000 r-xp /usr/lib/libappcore-agent.so.1.1
f719e000 f71a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71a8000 f71ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71b4000 f71d1000 r-xp /lib/ld-2.13.so
f71da000 f71dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71dd000 f71e1000 r-xp /usr/lib/libsys-assert.so
f7224000 f7295000 rw-p [heap]
ffa70000 ffa91000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11081)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7172539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e77c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e83e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e89be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e89dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ebe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eb91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e77c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e83e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e89be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e89dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ebbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ebc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ec3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf485b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf484e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6921663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dcefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dd07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f60ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f5bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f5c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f5c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7194183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71db53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf702885c) [/lib/libc.so.6] + 0x1785c
29: (0xf71daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:21.949+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:21.949+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:21.949+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:21.959+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:21.959+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:21.959+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:21.959+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:21.959+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:21.959+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:21.959+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:21.959+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:21.959+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:21.959+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:21.969+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:21.979+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:21.979+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:21.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:22.019+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:22.029+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:22.069+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:22.069+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:22.069+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:22.069+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c29080
04-23 20:36:22.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:22.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:22:98,0.029886,9.769327,0.854249
04-23 20:36:22.139+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c28690]
04-23 20:36:22.139+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:22.139+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:22.139+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:22.139+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:22.149+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:22.149+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:22.159+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:22.169+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:22.169+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:22.169+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:22.169+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:22.169+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:22.169+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:22.169+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:22.169+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:22.169+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:22.169+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:22.169+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:22.179+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:22.179+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:22.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:22.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:22.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:22.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:22.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:22.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c28690
04-23 20:36:22.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:22.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:22:304,0.029691,9.768882,0.859329
04-23 20:36:22.429+0200 W/AUL     (11045): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:36:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:36:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:36:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11012
04-23 20:36:22.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:36:22.429+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11012
04-23 20:36:22.429+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11012)
04-23 20:36:22.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:22.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:22:501,0.031956,9.768933,0.858670
04-23 20:36:22.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:22.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:22:701,0.037575,9.771015,0.834410
04-23 20:36:22.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:22.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:22:901,0.057052,9.771833,0.823649
04-23 20:36:23.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:23.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:23:99,0.060003,9.771667,0.825413
04-23 20:36:23.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:23.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:23:301,0.072097,9.771157,0.830470
04-23 20:36:23.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:23.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:23:500,0.045708,9.770535,0.839602
04-23 20:36:23.629+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:36:23.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:23.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:23:700,0.029346,9.766941,0.881130
04-23 20:36:23.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:23.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:23:901,0.033303,9.768606,0.862329
04-23 20:36:24.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:24.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:24:99,0.023934,9.767495,0.875132
04-23 20:36:24.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:24.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:24:300,0.018534,9.765896,0.892927
04-23 20:36:24.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:24.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:24:501,0.007124,9.734050,1.191051
04-23 20:36:24.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:24.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:24:700,0.016967,9.765352,0.898883
04-23 20:36:24.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:24.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:24:900,0.021029,9.767036,0.880306
04-23 20:36:25.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:25.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:25:99,0.035026,9.770927,0.835542
04-23 20:36:25.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:25.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:25:300,0.030152,9.773278,0.807785
04-23 20:36:25.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:25.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:25:503,0.034113,9.775516,0.780078
04-23 20:36:25.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:25.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:25:701,0.035070,9.775743,0.777188
04-23 20:36:25.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:25.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:25:901,0.023010,9.777307,0.757714
04-23 20:36:26.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:26.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:26:100,0.035680,9.776762,0.764228
04-23 20:36:26.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:26.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:26:301,0.032275,9.776855,0.763185
04-23 20:36:26.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:26.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:26:501,0.031647,9.777197,0.758819
04-23 20:36:26.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:26.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:26:702,0.032482,9.775822,0.776304
04-23 20:36:26.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:26.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:26:903,0.043284,9.774589,0.791161
04-23 20:36:27.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:27.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:27:102,0.037071,9.772762,0.813718
04-23 20:36:27.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:27.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:27:303,0.030576,9.770881,0.836262
04-23 20:36:27.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:27.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:27:503,0.037347,9.771460,0.829194
04-23 20:36:27.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:27.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:27:704,0.041071,9.771770,0.825351
04-23 20:36:27.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:27.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:27:902,0.041961,9.770204,0.843649
04-23 20:36:28.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:28.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:28:102,0.037662,9.770480,0.840642
04-23 20:36:28.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:28.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:28:302,0.030006,9.770782,0.837438
04-23 20:36:28.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:28.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:28:502,0.028993,9.770913,0.835941
04-23 20:36:28.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:28.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:28:703,0.042656,9.773099,0.809383
04-23 20:36:28.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:28.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:28:902,0.064659,9.774272,0.793608
04-23 20:36:29.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:29.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:29:102,0.057107,9.772926,0.810577
04-23 20:36:29.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:29.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:29:303,0.049721,9.771083,0.832977
04-23 20:36:29.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:29.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:29:503,0.053377,9.771839,0.823831
04-23 20:36:29.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:29.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:29:703,0.056058,9.773191,0.807447
04-23 20:36:29.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:29.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:29:903,0.037166,9.771454,0.829270
04-23 20:36:30.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:30.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:30:101,0.042677,9.772305,0.818924
04-23 20:36:30.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:30.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:30:303,0.043007,9.771963,0.822964
04-23 20:36:30.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:30.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:30:503,0.028092,9.769662,0.850476
04-23 20:36:30.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:30.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:30:702,0.030110,9.769772,0.849140
04-23 20:36:30.809+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:36:30.809+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:36:30.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:30.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:30.829+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:36:30.839+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11081
04-23 20:36:30.889+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11081
04-23 20:36:30.889+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11081) type(svcapp) bg(0)
04-23 20:36:30.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:30.899+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11081]
04-23 20:36:30.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:30:907,0.032317,9.769044,0.857391
04-23 20:36:30.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:30.939+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11081
04-23 20:36:30.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:30.939+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11081)
04-23 20:36:30.939+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:36:30.939+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:30.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:30.959+0200 E/CAPI_APPFW_APPLICATION(11081): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:30.959+0200 E/CAPI_APPFW_APPLICATION(11081): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:30.959+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11081
04-23 20:36:30.959+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11081) was created
04-23 20:36:30.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:30.989+0200 W/LOCATION(11081): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:36:30.989+0200 E/LOCATION(11081): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:36:30.989+0200 E/PKGMGR_INFO(11081): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:36:30.989+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:31.009+0200 I/LOCATION(11081): location.c: location_new(269) > method: 0
04-23 20:36:31.009+0200 W/LOCATION(11081): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:31.019+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:31.019+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:31.029+0200 W/LOCATION(11081): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:31.029+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:31.029+0200 W/LOCATION(11081): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:31.029+0200 W/LOCATION(11081): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:31.029+0200 W/LOCATION(11081): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:31.029+0200 W/LOCATION(11081): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:31.059+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:31.059+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:31.059+0200 W/LOCATION(11081): module-internal.c: module_new(311) > module (wps) open success
04-23 20:36:31.069+0200 W/LOCATION(11081): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:36:31.069+0200 W/LOCATION(11081): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:36:31.069+0200 W/LOCATION(11081): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:31.069+0200 W/LOCATION(11081): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:31.089+0200 W/LOCATION(11081): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:36:31.089+0200 I/LOCATION(11081): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7254c18
04-23 20:36:31.089+0200 I/LOCATION(11081): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:36:31.089+0200 I/LOCATION(11081): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7254c18
04-23 20:36:31.089+0200 I/LOCATION(11081): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:36:31.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:31.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:31:101,0.042340,9.769629,0.850253
04-23 20:36:31.099+0200 I/location(11081): es.ugr.frailty.location: creado servicio de localización
04-23 20:36:31.149+0200 I/LOCATION(11081): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:36:31.189+0200 W/LOCATION(11081): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:31.189+0200 W/LOCATION(11081): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:31.189+0200 I/LOCATION(11081): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:31.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:36:31.249+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:36:31.249+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:36:31.249+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:31.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:36:31.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:36:31.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:36:31.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:36:31.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:36:31.249+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:36:31.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:36:31.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:36:31.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:31.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:31:303,0.049171,9.769825,0.847641
04-23 20:36:31.309+0200 W/LOCATION(11081): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:31.309+0200 W/LOCATION(11081): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:31.389+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:31.419+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c24878]
04-23 20:36:31.419+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:31.419+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:31.419+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:31.419+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:31.429+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:31.429+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:31.439+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:31.449+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:31.449+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:31.449+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:31.449+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:31.449+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:31.449+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:31.449+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:31.449+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:31.449+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:31.449+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:31.459+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:31.469+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:31.469+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:31.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:31.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:36:31.479+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2666744), time2(2653557)
04-23 20:36:31.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:36:31.479+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:36:31.479+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:36:31.479+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:36:31.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:31.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:31:503,0.049709,9.769750,0.848467
04-23 20:36:31.509+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:31.529+0200 W/LOCATION(11081): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:31.529+0200 I/LOCATION(11081): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:31.529+0200 I/LOCATION(11081): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:31.529+0200 I/location(11081): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:36:31.619+0200 I/LOCATION(11081): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:31.669+0200 W/AUL     (11081): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:31.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:31.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11081
04-23 20:36:31.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:31.679+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:31.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:31.679+0200 W/AUL     (11081): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:31.679+0200 I/utils   (10115): specific action
04-23 20:36:31.679+0200 I/location(11081): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:31.679+0200 I/location(11081): es.ugr.frailty.location: SM-R760,23/04/2018,20:36:31:671,nan,37.171673,-3.594138,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:36:31.679+0200 W/CAPI_APPFW_APP_CONTROL(11081): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.679+0200 I/utils   (11081): specific action
04-23 20:36:31.679+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.679+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.679+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.679+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:31.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:31.679+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:31.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:31.689+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.689+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:31.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:31.689+0200 I/utils   (10120): specific action
04-23 20:36:31.689+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.689+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.689+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.689+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:31.689+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:36:31.689+0200 I/recorder(10120): guardando datos en local
04-23 20:36:31.689+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:31.689+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:31.689+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:31.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:31.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:31:704,0.028388,9.767900,0.870456
04-23 20:36:31.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:31.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:31:904,0.028713,9.768261,0.866396
04-23 20:36:32.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:32.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:32.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:32.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:110,0.038605,9.770400,0.841527
04-23 20:36:32.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.129+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:133,0.038389,9.770292,0.842798
04-23 20:36:32.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:145,0.038547,9.770307,0.842623
04-23 20:36:32.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:166,0.038926,9.770416,0.841331
04-23 20:36:32.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:185,0.038597,9.770315,0.842517
04-23 20:36:32.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:204,0.039569,9.770731,0.837641
04-23 20:36:32.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:224,0.039575,9.771073,0.833629
04-23 20:36:32.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:245,0.038901,9.771301,0.830985
04-23 20:36:32.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:267,0.037803,9.771488,0.828836
04-23 20:36:32.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.279+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:284,0.035937,9.771738,0.825966
04-23 20:36:32.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:304,0.035341,9.772058,0.822192
04-23 20:36:32.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.439+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:445,0.036542,9.772032,0.822462
04-23 20:36:32.439+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.449+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:454,0.037143,9.772171,0.820775
04-23 20:36:32.449+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.469+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:460,0.036811,9.772352,0.818629
04-23 20:36:32.469+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:478,0.036156,9.772445,0.817563
04-23 20:36:32.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.489+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:493,0.035756,9.772761,0.813785
04-23 20:36:32.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:498,0.036054,9.772759,0.813796
04-23 20:36:32.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:505,0.034259,9.772580,0.816020
04-23 20:36:32.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:510,0.035522,9.772449,0.817540
04-23 20:36:32.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:517,0.036032,9.772264,0.819714
04-23 20:36:32.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:522,0.035503,9.772088,0.821837
04-23 20:36:32.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.529+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:528,0.035892,9.771976,0.823151
04-23 20:36:32.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:543,0.035806,9.771732,0.826042
04-23 20:36:32.539+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:36:32.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:564,0.036399,9.771545,0.828230
04-23 20:36:32.569+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:582,0.035465,9.771570,0.827970
04-23 20:36:32.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.599+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:604,0.034150,9.771360,0.830506
04-23 20:36:32.609+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:623,0.035847,9.771270,0.831501
04-23 20:36:32.639+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:643,0.036324,9.770956,0.835156
04-23 20:36:32.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.669+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:667,0.039077,9.771097,0.833374
04-23 20:36:32.679+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:685,0.041088,9.771084,0.833435
04-23 20:36:32.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:705,0.040164,9.771191,0.832231
04-23 20:36:32.719+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.729+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:727,0.039767,9.771094,0.833373
04-23 20:36:32.739+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.739+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:745,0.040404,9.770983,0.834656
04-23 20:36:32.759+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.769+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:769,0.039991,9.770918,0.835428
04-23 20:36:32.779+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.789+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:787,0.039710,9.770858,0.836150
04-23 20:36:32.799+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.809+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:806,0.040469,9.770905,0.835558
04-23 20:36:32.819+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.829+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:824,0.041059,9.770782,0.836971
04-23 20:36:32.839+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.849+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:846,0.042567,9.770899,0.835529
04-23 20:36:32.859+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.869+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:866,0.044325,9.770930,0.835068
04-23 20:36:32.879+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:884,0.043946,9.770857,0.835946
04-23 20:36:32.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:904,0.042556,9.770763,0.837111
04-23 20:36:32.929+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.929+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:933,0.044301,9.770744,0.837239
04-23 20:36:32.939+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:946,0.044386,9.770672,0.838083
04-23 20:36:32.959+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:966,0.045607,9.770694,0.837759
04-23 20:36:32.979+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:32:984,0.045287,9.770605,0.838816
04-23 20:36:32.999+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:32.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:4,0.045098,9.770550,0.839470
04-23 20:36:33.019+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:26,0.044799,9.770452,0.840611
04-23 20:36:33.039+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.039+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:44,0.045204,9.770512,0.839905
04-23 20:36:33.059+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.069+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:67,0.045129,9.770459,0.840516
04-23 20:36:33.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:33.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:33.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:33.079+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:85,0.043910,9.770406,0.841208
04-23 20:36:33.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:104,0.043218,9.770188,0.843765
04-23 20:36:33.119+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:124,0.044490,9.770247,0.843028
04-23 20:36:33.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:145,0.043759,9.770223,0.843334
04-23 20:36:33.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.169+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:167,0.044654,9.770268,0.842755
04-23 20:36:33.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.189+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:185,0.045054,9.770115,0.844519
04-23 20:36:33.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.209+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:205,0.044071,9.770025,0.845603
04-23 20:36:33.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.219+0200 W/LOCATION(11081): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:36:33.229+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:228,0.044508,9.770198,0.843591
04-23 20:36:33.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:245,0.046512,9.770394,0.841204
04-23 20:36:33.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:268,0.046713,9.770336,0.841859
04-23 20:36:33.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.279+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:284,0.046911,9.770403,0.841080
04-23 20:36:33.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:304,0.045957,9.770366,0.841565
04-23 20:36:33.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:324,0.045624,9.770348,0.841792
04-23 20:36:33.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.339+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:343,0.046323,9.770456,0.840487
04-23 20:36:33.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.359+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:365,0.048116,9.770609,0.838615
04-23 20:36:33.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:384,0.048118,9.770741,0.837082
04-23 20:36:33.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:404,0.048471,9.770948,0.834623
04-23 20:36:33.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:33.419+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:33:423,0.047097,9.770885,0.835442
04-23 20:36:33.449+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11110816c6f63152450859
