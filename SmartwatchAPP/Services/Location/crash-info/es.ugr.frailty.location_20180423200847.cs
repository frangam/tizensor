S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6913
Date: 2018-04-23 20:08:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a452d, r5   = 0xf71bcf98
r6   = 0xffc32110, r7   = 0xffc31fc0
r8   = 0xf71b9c18, r9   = 0x00000000
r10  = 0xffc3209c, fp   = 0xffc32110
ip   = 0x00000001, sp   = 0xffc31f98
lr   = 0xf70a4539, pc   = 0xf710d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    110204 KB
Buffers:     39396 KB
Cached:     185420 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11584 KB
VmRSS:       11584 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6913 TID = 6913
6913 6916 

Maps Information
f3f6f000 f476e000 rw-p [stack:6916]
f4775000 f4777000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f477f000 f4783000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f478c000 f478e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4796000 f4799000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47a8000 f47ad000 r-xp /usr/lib/libsystem.so.0.0.0
f47b8000 f47bb000 r-xp /lib/libattr.so.1.1.0
f47c3000 f47d3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47db000 f47e4000 r-xp /usr/lib/libedbus.so.1.7.99
f47ec000 f47ed000 r-xp /usr/lib/libresponse.so.0.2.96
f47f6000 f47fb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f609d000 f61a3000 r-xp /usr/lib/libicuuc.so.57.1
f61b9000 f6341000 r-xp /usr/lib/libicui18n.so.57.1
f6351000 f635e000 r-xp /usr/lib/libail.so.0.1.0
f6367000 f636e000 r-xp /usr/lib/libminizip.so.1.0.0
f6377000 f6520000 r-xp /usr/lib/libcrypto.so.1.0.0
f6540000 f6587000 r-xp /usr/lib/libssl.so.1.0.0
f6593000 f6595000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f659d000 f65a4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65ad000 f65b4000 r-xp /lib/libcrypt-2.13.so
f65e5000 f65e8000 r-xp /lib/libcap.so.2.21
f65f0000 f65f2000 r-xp /usr/lib/libiri.so
f65fa000 f6643000 r-xp /usr/lib/libmdm.so.1.2.69
f664b000 f6651000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6659000 f667c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6686000 f6688000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6690000 f66ad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b6000 f66ba000 r-xp /usr/lib/libsmack.so.1.0.0
f66c3000 f66dc000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e5000 f66ed000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f5000 f66fb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6704000 f6706000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f670f000 f671f000 r-xp /lib/libresolv-2.13.so
f6723000 f673b000 r-xp /usr/lib/liblzma.so.5.0.3
f6744000 f6746000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f674e000 f6768000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6770000 f679f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67a8000 f67b7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c1000 f67cb000 r-xp /usr/lib/libsensord-shared.so
f67d4000 f68a7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b2000 f68c8000 r-xp /lib/libz.so.1.2.5
f68d0000 f68d5000 r-xp /usr/lib/libffi.so.5.0.10
f68dd000 f68de000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e6000 f68f6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68fe000 f6917000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f691f000 f6921000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6929000 f699e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69a8000 f69ae000 r-xp /lib/librt-2.13.so
f69b7000 f69d5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69df000 f69e0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69e8000 f6a0b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a13000 f6a18000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a20000 f6a4a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a53000 f6a6a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a72000 f6adb000 r-xp /lib/libm-2.13.so
f6ae4000 f6b78000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b8b000 f6b90000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b98000 f6b9f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba7000 f6bd1000 r-xp /usr/lib/libsensor.so.1.9.6
f6bda000 f6ca6000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb3000 f6cb5000 r-xp /usr/lib/libiniparser.so.0
f6cbe000 f6cc4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ccd000 f6d9d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d9e000 f6dd2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ddb000 f6e17000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e1f000 f6e22000 r-xp /usr/lib/libbundle.so.0.1.22
f6e2a000 f6e30000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e38000 f6e79000 r-xp /usr/lib/libeina.so.1.7.99
f6e82000 f6e99000 r-xp /usr/lib/libecore.so.1.7.99
f6eb0000 f6eb9000 r-xp /usr/lib/libvconf.so.0.2.45
f6ec1000 f6ed5000 r-xp /lib/libpthread-2.13.so
f6ee0000 f6eed000 r-xp /usr/lib/libaul.so.0.1.0
f6ef7000 f6ef9000 r-xp /lib/libdl-2.13.so
f6f02000 f6f0d000 r-xp /lib/libunwind.so.8.0.1
f6f3a000 f6f42000 r-xp /lib/libgcc_s-4.6.so.1
f6f43000 f7067000 r-xp /lib/libc-2.13.so
f7075000 f7077000 r-xp /usr/lib/libdlog.so.0.0.0
f707f000 f708b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7094000 f7099000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a1000 f70b0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70b8000 f70bc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c5000 f70c8000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d0000 f70d2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70da000 f70de000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e6000 f7103000 r-xp /lib/ld-2.13.so
f710c000 f710f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f710f000 f7113000 r-xp /usr/lib/libsys-assert.so
f7189000 f71fa000 rw-p [heap]
ffc13000 ffc34000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6913)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf710d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dab3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6da9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dbbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dbbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6deb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6da9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dbbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dbbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dede5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dee017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf478d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4780171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6853663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d00fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d027a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e92ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e8db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e8e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e8e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf710d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f5a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf710cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.029+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:35.029+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:35.029+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:35.029+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:35.029+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:35.029+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:35.039+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.049+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.049+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:35.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:35.089+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:35.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:35.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:35.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:35.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:35.149+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f18a90
04-23 20:08:35.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f16178]
04-23 20:08:35.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:35.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:35.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:35.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:35.199+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:35.199+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.209+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.219+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.219+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:35.219+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:35.219+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.219+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:35.219+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:35.219+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:35.219+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:35.219+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:35.219+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:35.219+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.229+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:35.229+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:35.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:35.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:35.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:35.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:35.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:35.279+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f16178
04-23 20:08:35.469+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:08:35.469+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:35.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:35.469+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:35.489+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6863
04-23 20:08:35.489+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:35.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6863
04-23 20:08:35.539+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6863) type(svcapp) bg(0)
04-23 20:08:35.539+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6863)
04-23 20:08:35.539+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6863]
04-23 20:08:35.549+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:08:35.549+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:35.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:35.589+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6863
04-23 20:08:35.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:35.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:35.599+0200 E/CAPI_APPFW_APPLICATION( 6863): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:35.599+0200 E/CAPI_APPFW_APPLICATION( 6863): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:35.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6863
04-23 20:08:35.609+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6863) was created
04-23 20:08:35.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:35.639+0200 W/LOCATION( 6863): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:35.639+0200 E/LOCATION( 6863): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:35.639+0200 E/PKGMGR_INFO( 6863): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:35.649+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.669+0200 I/LOCATION( 6863): location.c: location_new(269) > method: 0
04-23 20:08:35.669+0200 W/LOCATION( 6863): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:35.669+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.679+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:35.689+0200 W/LOCATION( 6863): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:35.689+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:35.699+0200 W/LOCATION( 6863): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:35.699+0200 W/LOCATION( 6863): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:35.699+0200 W/LOCATION( 6863): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:35.699+0200 W/LOCATION( 6863): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:35.729+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:35.729+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:35.739+0200 W/LOCATION( 6863): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:35.749+0200 W/LOCATION( 6863): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:35.749+0200 W/LOCATION( 6863): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:35.749+0200 W/LOCATION( 6863): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:35.749+0200 W/LOCATION( 6863): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:35.769+0200 W/LOCATION( 6863): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:35.769+0200 I/LOCATION( 6863): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7934c18
04-23 20:08:35.769+0200 I/LOCATION( 6863): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:35.769+0200 I/LOCATION( 6863): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7934c18
04-23 20:08:35.769+0200 I/LOCATION( 6863): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:35.769+0200 I/location( 6863): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:35.819+0200 I/LOCATION( 6863): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:35.859+0200 W/LOCATION( 6863): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:35.859+0200 W/LOCATION( 6863): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:35.859+0200 I/LOCATION( 6863): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:35.929+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:35.929+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:35.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:35.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:35.929+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:35.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:35.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:35.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:35.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:35.939+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:35.939+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:35.939+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:35.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:35.979+0200 W/LOCATION( 6863): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:35.979+0200 W/LOCATION( 6863): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:36.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f26c08]
04-23 20:08:36.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:36.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:36.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:36.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:36.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.119+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:36.119+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:36.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:36.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:36.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:36.119+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:36.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:36.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.129+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:36.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.199+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:36.199+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(991465), time2(988268)
04-23 20:08:36.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:08:36.199+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:36.199+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:36.199+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:36.209+0200 W/LOCATION( 6863): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:36.209+0200 I/LOCATION( 6863): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:36.209+0200 I/LOCATION( 6863): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:36.209+0200 I/location( 6863): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:36.289+0200 I/LOCATION( 6863): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:36.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:36.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:36.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:36.359+0200 E/location( 6863): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:36.359+0200 W/AUL     ( 6863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:36.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:36.359+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6863
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:36.369+0200 W/AUL     ( 6863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:36.369+0200 I/location( 6863): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:36.369+0200 I/location( 6863): stopping es.ugr.frailty.location service
04-23 20:08:36.369+0200 E/CAPI_APPFW_APP_CONTROL( 6863): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:08:36.369+0200 E/location( 6863): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:08:36.369+0200 I/CAPI_APPFW_APPLICATION( 6863): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:08:36.369+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:36.369+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.369+0200 I/utils   ( 5532): specific action
04-23 20:08:36.369+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.369+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.369+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.369+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:36.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:36.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:36.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.389+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:36.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:36.389+0200 I/utils   ( 5538): specific action
04-23 20:08:36.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:36.389+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:36.389+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:36.389+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:36.389+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:36.389+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:36.429+0200 W/LOCATION( 6863): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:36.429+0200 I/LOCATION( 6863): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:36.429+0200 I/LOCATION( 6863): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:08:36.499+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:08:36.499+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:08:36.499+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:08:36.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:08:36.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:36.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:36.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:36.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f26c08
04-23 20:08:36.719+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79dca88]
04-23 20:08:36.719+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:36.719+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:36.719+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:36.719+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:36.719+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.719+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.739+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:36.739+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:36.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:36.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:36.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:36.739+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:36.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:36.749+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.759+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.759+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:36.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:36.859+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:36.859+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:36.859+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:36.859+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79dca88
04-23 20:08:36.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d88b0]
04-23 20:08:36.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:36.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:36.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:36.939+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:36.939+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.939+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.949+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.959+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:36.959+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:36.959+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:36.959+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:36.959+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:36.959+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:36.959+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:36.959+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:36.959+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:36.959+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:36.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:37.009+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:37.009+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:37.009+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:37.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:37.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:08:37.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:08:37.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:08:37.059+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d88b0
04-23 20:08:37.229+0200 W/AUL     ( 6875): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:08:37.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:08:37.229+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:08:37.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6839
04-23 20:08:37.229+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:08:37.239+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6839
04-23 20:08:37.239+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6839)
04-23 20:08:38.369+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:08:45.559+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:08:45.559+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:08:45.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:45.559+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:45.569+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6913
04-23 20:08:45.569+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:08:45.619+0200 E/CAPI_APPFW_APPLICATION( 6913): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:45.619+0200 E/CAPI_APPFW_APPLICATION( 6913): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:08:45.619+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6913
04-23 20:08:45.619+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6913) type(svcapp) bg(0)
04-23 20:08:45.619+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6913) was created
04-23 20:08:45.619+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6913)
04-23 20:08:45.619+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:08:45.619+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:08:45.629+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6913]
04-23 20:08:45.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:45.649+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6913
04-23 20:08:45.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:45.659+0200 W/LOCATION( 6913): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:08:45.659+0200 E/LOCATION( 6913): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:08:45.659+0200 E/PKGMGR_INFO( 6913): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:08:45.669+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:45.679+0200 I/LOCATION( 6913): location.c: location_new(269) > method: 0
04-23 20:08:45.689+0200 W/LOCATION( 6913): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:45.699+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:45.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:08:45.709+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:45.709+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6913
04-23 20:08:45.709+0200 W/LOCATION( 6913): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:45.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:08:45.719+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:45.719+0200 W/LOCATION( 6913): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:45.719+0200 W/LOCATION( 6913): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:45.719+0200 W/LOCATION( 6913): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:45.719+0200 W/LOCATION( 6913): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:45.739+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:45.739+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:08:45.749+0200 W/LOCATION( 6913): module-internal.c: module_new(311) > module (wps) open success
04-23 20:08:45.749+0200 W/LOCATION( 6913): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:08:45.759+0200 W/LOCATION( 6913): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:08:45.759+0200 W/LOCATION( 6913): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:45.759+0200 W/LOCATION( 6913): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:45.769+0200 W/LOCATION( 6913): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:08:45.769+0200 I/LOCATION( 6913): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf71b9c18
04-23 20:08:45.769+0200 I/LOCATION( 6913): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:08:45.769+0200 I/LOCATION( 6913): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf71b9c18
04-23 20:08:45.769+0200 I/LOCATION( 6913): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:08:45.779+0200 I/location( 6913): es.ugr.frailty.location: creado servicio de localización
04-23 20:08:45.819+0200 I/LOCATION( 6913): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:08:45.859+0200 W/LOCATION( 6913): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:45.859+0200 W/LOCATION( 6913): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:45.859+0200 I/LOCATION( 6913): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:08:45.919+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:08:45.919+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:45.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:45.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:08:45.919+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:08:45.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:08:45.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:08:45.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:08:45.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:08:45.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:08:45.929+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:08:45.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:08:45.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:08:45.979+0200 W/LOCATION( 6913): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:08:45.989+0200 W/LOCATION( 6913): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:08:46.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:46.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d3548]
04-23 20:08:46.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:08:46.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:08:46.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:08:46.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:08:46.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:46.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:46.109+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:46.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:46.119+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:08:46.119+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:08:46.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:08:46.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:08:46.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:08:46.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:08:46.119+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:08:46.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:08:46.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:08:46.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:46.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:08:46.129+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:08:46.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:46.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:08:46.199+0200 W/LOCATION( 6913): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:08:46.199+0200 I/LOCATION( 6913): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:46.199+0200 I/LOCATION( 6913): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:08:46.199+0200 I/location( 6913): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:08:46.229+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:08:46.229+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1001498), time2(988268)
04-23 20:08:46.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:08:46.229+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:08:46.229+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:08:46.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:08:46.299+0200 I/LOCATION( 6913): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:08:46.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:46.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:46.359+0200 E/location( 6913): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:08:46.369+0200 W/AUL     ( 6913): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:08:46.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:46.369+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6913
04-23 20:08:46.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:08:46.379+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:46.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:08:46.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.379+0200 I/utils   ( 5532): specific action
04-23 20:08:46.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:08:46.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:08:46.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:08:46.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:08:46.389+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:08:46.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:08:46.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.389+0200 I/utils   ( 5538): specific action
04-23 20:08:46.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.389+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.389+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:08:46.399+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:08:46.399+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:08:46.399+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:08:46.399+0200 W/AUL     ( 6913): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:08:46.399+0200 I/location( 6913): request sent to service es.ugr.frailty.servicemanager
04-23 20:08:46.399+0200 W/CAPI_APPFW_APP_CONTROL( 6913): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:08:46.399+0200 I/utils   ( 6913): specific action
04-23 20:08:46.399+0200 I/recorder( 5538): guardando datos en local
04-23 20:08:47.149+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:08:47.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:08:47.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:08:47.329+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:08:47.909+0200 W/LOCATION( 6913): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:08:48.089+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11069136c6f63152450692
