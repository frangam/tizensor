S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7441
Date: 2018-04-23 20:10:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf714e52d, r5   = 0xf7854f98
r6   = 0xffa51700, r7   = 0xffa515b0
r8   = 0xf7851c18, r9   = 0x00000000
r10  = 0xffa5168c, fp   = 0xffa51700
ip   = 0x00000001, sp   = 0xffa51588
lr   = 0xf714e539, pc   = 0xf71b7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    106828 KB
Buffers:     40708 KB
Cached:     187164 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11856 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7441 TID = 7441
7441 7444 

Maps Information
f4019000 f4818000 rw-p [stack:7444]
f481f000 f4821000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4829000 f482d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4836000 f4838000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4840000 f4843000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4852000 f4857000 r-xp /usr/lib/libsystem.so.0.0.0
f4862000 f4865000 r-xp /lib/libattr.so.1.1.0
f486d000 f487d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4885000 f488e000 r-xp /usr/lib/libedbus.so.1.7.99
f4896000 f4897000 r-xp /usr/lib/libresponse.so.0.2.96
f48a0000 f48a5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6147000 f624d000 r-xp /usr/lib/libicuuc.so.57.1
f6263000 f63eb000 r-xp /usr/lib/libicui18n.so.57.1
f63fb000 f6408000 r-xp /usr/lib/libail.so.0.1.0
f6411000 f6418000 r-xp /usr/lib/libminizip.so.1.0.0
f6421000 f65ca000 r-xp /usr/lib/libcrypto.so.1.0.0
f65ea000 f6631000 r-xp /usr/lib/libssl.so.1.0.0
f663d000 f663f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6647000 f664e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6657000 f665e000 r-xp /lib/libcrypt-2.13.so
f668f000 f6692000 r-xp /lib/libcap.so.2.21
f669a000 f669c000 r-xp /usr/lib/libiri.so
f66a4000 f66ed000 r-xp /usr/lib/libmdm.so.1.2.69
f66f5000 f66fb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6703000 f6726000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6730000 f6732000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f673a000 f6757000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6760000 f6764000 r-xp /usr/lib/libsmack.so.1.0.0
f676d000 f6786000 r-xp /usr/lib/libnetwork.so.0.0.0
f678f000 f6797000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f679f000 f67a5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67ae000 f67b0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67b9000 f67c9000 r-xp /lib/libresolv-2.13.so
f67cd000 f67e5000 r-xp /usr/lib/liblzma.so.5.0.3
f67ee000 f67f0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67f8000 f6812000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f681a000 f6849000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6852000 f6861000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f686b000 f6875000 r-xp /usr/lib/libsensord-shared.so
f687e000 f6951000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f695c000 f6972000 r-xp /lib/libz.so.1.2.5
f697a000 f697f000 r-xp /usr/lib/libffi.so.5.0.10
f6987000 f6988000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6990000 f69a0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69a8000 f69c1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69c9000 f69cb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69d3000 f6a48000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a52000 f6a58000 r-xp /lib/librt-2.13.so
f6a61000 f6a7f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a89000 f6a8a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a92000 f6ab5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6abd000 f6ac2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aca000 f6af4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6afd000 f6b14000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b1c000 f6b85000 r-xp /lib/libm-2.13.so
f6b8e000 f6c22000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c35000 f6c3a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c42000 f6c49000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c51000 f6c7b000 r-xp /usr/lib/libsensor.so.1.9.6
f6c84000 f6d50000 r-xp /usr/lib/libxml2.so.2.7.8
f6d5d000 f6d5f000 r-xp /usr/lib/libiniparser.so.0
f6d68000 f6d6e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d77000 f6e47000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e48000 f6e7c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e85000 f6ec1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ec9000 f6ecc000 r-xp /usr/lib/libbundle.so.0.1.22
f6ed4000 f6eda000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ee2000 f6f23000 r-xp /usr/lib/libeina.so.1.7.99
f6f2c000 f6f43000 r-xp /usr/lib/libecore.so.1.7.99
f6f5a000 f6f63000 r-xp /usr/lib/libvconf.so.0.2.45
f6f6b000 f6f7f000 r-xp /lib/libpthread-2.13.so
f6f8a000 f6f97000 r-xp /usr/lib/libaul.so.0.1.0
f6fa1000 f6fa3000 r-xp /lib/libdl-2.13.so
f6fac000 f6fb7000 r-xp /lib/libunwind.so.8.0.1
f6fe4000 f6fec000 r-xp /lib/libgcc_s-4.6.so.1
f6fed000 f7111000 r-xp /lib/libc-2.13.so
f711f000 f7121000 r-xp /usr/lib/libdlog.so.0.0.0
f7129000 f7135000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f713e000 f7143000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f714b000 f715a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7162000 f7166000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f716f000 f7172000 r-xp /usr/lib/libappcore-agent.so.1.1
f717a000 f717c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7184000 f7188000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7190000 f71ad000 r-xp /lib/ld-2.13.so
f71b6000 f71b9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71b9000 f71bd000 r-xp /usr/lib/libsys-assert.so
f7821000 f7892000 rw-p [heap]
ffa32000 ffa53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7441)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71b7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf714e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e553f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e53c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e5fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e65be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e65dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e9a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e951f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e53c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e5fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e65be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e65dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e97e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e98017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e9ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48371fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf482a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68fd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6daafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dac7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f3cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f37b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f385a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f38879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7170183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71707fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71b74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf700485c) [/lib/libc.so.6] + 0x1785c
29: (0xf71b6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.409+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:07.409+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:07.409+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:07.409+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:07.409+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:07.409+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:07.419+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.419+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.419+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:07.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:07.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:07.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:07.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:07.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:07.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:07.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79de990
04-23 20:10:07.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e6ee8]
04-23 20:10:07.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:07.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:07.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:07.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:07.599+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:07.599+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.609+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.619+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.619+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:07.619+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:07.619+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.619+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:07.619+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:07.619+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:07.619+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:07.619+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:07.619+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:07.629+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.639+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:07.639+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:07.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:07.689+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:07.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:07.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:07.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:07.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e6ee8
04-23 20:10:07.769+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:10:07.769+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:07.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:07.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:07.779+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7390
04-23 20:10:07.779+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:07.819+0200 E/CAPI_APPFW_APPLICATION( 7390): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:07.829+0200 E/CAPI_APPFW_APPLICATION( 7390): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:07.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7390
04-23 20:10:07.829+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7390) type(svcapp) bg(0)
04-23 20:10:07.829+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7390)
04-23 20:10:07.829+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:10:07.829+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:07.829+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7390) was created
04-23 20:10:07.829+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7390]
04-23 20:10:07.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:07.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7390
04-23 20:10:07.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:07.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:07.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7390
04-23 20:10:07.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:07.879+0200 W/LOCATION( 7390): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:07.879+0200 E/LOCATION( 7390): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:07.879+0200 E/PKGMGR_INFO( 7390): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:07.879+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.899+0200 I/LOCATION( 7390): location.c: location_new(269) > method: 0
04-23 20:10:07.899+0200 W/LOCATION( 7390): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:07.899+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.909+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:07.909+0200 W/LOCATION( 7390): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:07.919+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:07.919+0200 W/LOCATION( 7390): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:07.919+0200 W/LOCATION( 7390): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:07.919+0200 W/LOCATION( 7390): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:07.919+0200 W/LOCATION( 7390): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:07.939+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:07.939+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:07.949+0200 W/LOCATION( 7390): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:07.949+0200 W/LOCATION( 7390): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:07.949+0200 W/LOCATION( 7390): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:07.949+0200 W/LOCATION( 7390): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:07.949+0200 W/LOCATION( 7390): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:07.969+0200 W/LOCATION( 7390): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:07.969+0200 I/LOCATION( 7390): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73b9c18
04-23 20:10:07.969+0200 I/LOCATION( 7390): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:07.969+0200 I/LOCATION( 7390): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73b9c18
04-23 20:10:07.969+0200 I/LOCATION( 7390): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:07.969+0200 I/location( 7390): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:08.019+0200 I/LOCATION( 7390): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:08.049+0200 W/LOCATION( 7390): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:08.059+0200 W/LOCATION( 7390): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:08.059+0200 I/LOCATION( 7390): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:08.119+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:08.119+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:08.119+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:08.119+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:08.119+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:08.119+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:08.119+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:08.119+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:08.119+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:08.129+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:08.129+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:08.129+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:08.129+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:08.179+0200 W/LOCATION( 7390): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:08.179+0200 W/LOCATION( 7390): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:08.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:08.289+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a145f8]
04-23 20:10:08.289+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:08.289+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:08.289+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:08.289+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:08.299+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:08.299+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:08.299+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:08.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:08.319+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:08.319+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:08.319+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:08.319+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:08.319+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:08.319+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:08.319+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:08.319+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:08.319+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:08.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:08.329+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:08.329+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:08.329+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:08.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:08.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:08.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:08.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:08.359+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(1083626), time2(1080576)
04-23 20:10:08.359+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:10:08.359+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:08.359+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:08.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:08.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:08.419+0200 W/LOCATION( 7390): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:08.419+0200 I/LOCATION( 7390): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:08.419+0200 I/LOCATION( 7390): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:08.419+0200 I/location( 7390): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:08.549+0200 I/LOCATION( 7390): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:08.619+0200 E/location( 7390): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:08.619+0200 W/AUL     ( 7390): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:08.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:08.619+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7390
04-23 20:10:08.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:08.629+0200 W/AUL     ( 7390): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:08.629+0200 I/location( 7390): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:08.629+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:08.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:08.629+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.629+0200 I/utils   ( 5532): specific action
04-23 20:10:08.629+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.629+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.629+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.629+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:08.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:08.629+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:08.639+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:08.649+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:08.649+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:08.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.649+0200 I/utils   ( 5538): specific action
04-23 20:10:08.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.649+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:08.649+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:08.649+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:08.649+0200 I/location( 7390): stopping es.ugr.frailty.location service
04-23 20:10:08.649+0200 E/CAPI_APPFW_APP_CONTROL( 7390): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:10:08.649+0200 E/location( 7390): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:10:08.649+0200 I/CAPI_APPFW_APPLICATION( 7390): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:10:08.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:10:08.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:10:08.649+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:08.649+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:08.649+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:08.719+0200 W/LOCATION( 7390): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:08.719+0200 I/LOCATION( 7390): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:08.719+0200 I/LOCATION( 7390): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:10:08.849+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:10:08.849+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:10:08.849+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:10:08.849+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:10:08.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:09.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:09.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:09.009+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a145f8
04-23 20:10:09.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e4480]
04-23 20:10:09.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:09.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:09.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:09.069+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:09.079+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:09.079+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:09.089+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.099+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.099+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:09.099+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:09.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:09.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:09.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:09.099+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:09.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:09.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:09.099+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:09.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.109+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:09.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.159+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:09.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:09.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:09.209+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e4480
04-23 20:10:09.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8890]
04-23 20:10:09.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:09.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:09.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:09.299+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:09.309+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:09.309+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:09.319+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.329+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.329+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:09.329+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:09.329+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:09.329+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:09.329+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:09.329+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:09.329+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:09.329+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:09.329+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:09.359+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.369+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:09.369+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:09.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:09.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:09.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:09.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:09.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d8890
04-23 20:10:09.659+0200 W/AUL     ( 7403): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:10:09.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:10:09.659+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:10:09.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7366
04-23 20:10:09.659+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:10:09.659+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7366
04-23 20:10:09.659+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7366)
04-23 20:10:10.649+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:10:17.839+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:10:17.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:17.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:17.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:17.849+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:17.849+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7441
04-23 20:10:17.899+0200 E/CAPI_APPFW_APPLICATION( 7441): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:17.899+0200 E/CAPI_APPFW_APPLICATION( 7441): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:17.899+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7441
04-23 20:10:17.899+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7441) type(svcapp) bg(0)
04-23 20:10:17.899+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7441) was created
04-23 20:10:17.899+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7441)
04-23 20:10:17.899+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:10:17.899+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:17.899+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7441]
04-23 20:10:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:17.929+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7441
04-23 20:10:17.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:17.949+0200 W/LOCATION( 7441): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:17.949+0200 E/LOCATION( 7441): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:17.949+0200 E/PKGMGR_INFO( 7441): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:17.949+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:17.969+0200 I/LOCATION( 7441): location.c: location_new(269) > method: 0
04-23 20:10:17.969+0200 W/LOCATION( 7441): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:17.969+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:17.979+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:17.979+0200 W/LOCATION( 7441): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:17.979+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:17.989+0200 W/LOCATION( 7441): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:17.989+0200 W/LOCATION( 7441): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:17.989+0200 W/LOCATION( 7441): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:17.989+0200 W/LOCATION( 7441): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:18.009+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:18.009+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:18.009+0200 W/LOCATION( 7441): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:18.009+0200 W/LOCATION( 7441): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:18.019+0200 W/LOCATION( 7441): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:18.019+0200 W/LOCATION( 7441): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:18.019+0200 W/LOCATION( 7441): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:18.029+0200 W/LOCATION( 7441): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:18.029+0200 I/LOCATION( 7441): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7851c18
04-23 20:10:18.029+0200 I/LOCATION( 7441): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:18.039+0200 I/LOCATION( 7441): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7851c18
04-23 20:10:18.039+0200 I/LOCATION( 7441): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:18.039+0200 I/location( 7441): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:18.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:18.069+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7441
04-23 20:10:18.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:18.099+0200 I/LOCATION( 7441): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:18.139+0200 W/LOCATION( 7441): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:18.139+0200 W/LOCATION( 7441): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:18.139+0200 I/LOCATION( 7441): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:18.209+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:18.209+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:18.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:18.209+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:18.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:18.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:18.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:18.209+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:18.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:18.209+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:18.209+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:18.209+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:18.259+0200 W/LOCATION( 7441): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:18.259+0200 W/LOCATION( 7441): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:18.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:18.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:18.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:18.359+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:18.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8858]
04-23 20:10:18.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:18.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:18.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:18.409+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:18.409+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:18.409+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:18.419+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:18.429+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:18.429+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:18.429+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:18.429+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:18.429+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:18.429+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:18.429+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:18.429+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:18.429+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:18.429+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:18.439+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:18.449+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:18.449+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:18.449+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:18.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:18.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:18.509+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1093776), time2(1080576)
04-23 20:10:18.509+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:10:18.509+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:18.509+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:18.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:18.529+0200 W/LOCATION( 7441): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:18.529+0200 I/LOCATION( 7441): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:18.529+0200 I/LOCATION( 7441): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:18.529+0200 I/location( 7441): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:18.609+0200 I/LOCATION( 7441): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:18.669+0200 E/location( 7441): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:18.669+0200 W/AUL     ( 7441): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:18.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:18.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7441
04-23 20:10:18.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:18.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:18.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:18.679+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.679+0200 I/utils   ( 5532): specific action
04-23 20:10:18.679+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.679+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.679+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.679+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:18.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:18.679+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:18.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:18.689+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:18.689+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:18.689+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:18.689+0200 W/AUL     ( 7441): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:18.689+0200 I/location( 7441): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:18.689+0200 W/CAPI_APPFW_APP_CONTROL( 7441): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.689+0200 I/utils   ( 7441): specific action
04-23 20:10:18.689+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.689+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:18.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:18.699+0200 I/utils   ( 5538): specific action
04-23 20:10:18.699+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.699+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.699+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.699+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:18.699+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:18.699+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:19.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:19.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:19.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:19.439+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:10:20.119+0200 W/LOCATION( 7441): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:10:20.279+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11074416c6f63152450702
