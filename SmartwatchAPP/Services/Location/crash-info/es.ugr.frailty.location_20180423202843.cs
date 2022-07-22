S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8783
Date: 2018-04-23 20:28:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf744452d, r5   = 0xf762bf98
r6   = 0xffae66a0, r7   = 0xffae6550
r8   = 0xf7628c18, r9   = 0x00000000
r10  = 0xffae662c, fp   = 0xffae66a0
ip   = 0x00000001, sp   = 0xffae6528
lr   = 0xf7444539, pc   = 0xf74ad228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    148644 KB
Buffers:     33424 KB
Cached:     152272 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11596 KB
VmRSS:       11596 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8783 TID = 8783
8783 8786 

Maps Information
f430f000 f4b0e000 rw-p [stack:8786]
f4b15000 f4b17000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b1f000 f4b23000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b2c000 f4b2e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b36000 f4b39000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b48000 f4b4d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b58000 f4b5b000 r-xp /lib/libattr.so.1.1.0
f4b63000 f4b73000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b7b000 f4b84000 r-xp /usr/lib/libedbus.so.1.7.99
f4b8c000 f4b8d000 r-xp /usr/lib/libresponse.so.0.2.96
f4b96000 f4b9b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f643d000 f6543000 r-xp /usr/lib/libicuuc.so.57.1
f6559000 f66e1000 r-xp /usr/lib/libicui18n.so.57.1
f66f1000 f66fe000 r-xp /usr/lib/libail.so.0.1.0
f6707000 f670e000 r-xp /usr/lib/libminizip.so.1.0.0
f6717000 f68c0000 r-xp /usr/lib/libcrypto.so.1.0.0
f68e0000 f6927000 r-xp /usr/lib/libssl.so.1.0.0
f6933000 f6935000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f693d000 f6944000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f694d000 f6954000 r-xp /lib/libcrypt-2.13.so
f6985000 f6988000 r-xp /lib/libcap.so.2.21
f6990000 f6992000 r-xp /usr/lib/libiri.so
f699a000 f69e3000 r-xp /usr/lib/libmdm.so.1.2.69
f69eb000 f69f1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69f9000 f6a1c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a26000 f6a28000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a30000 f6a4d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a56000 f6a5a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a63000 f6a7c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a85000 f6a8d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a95000 f6a9b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6aa4000 f6aa6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aaf000 f6abf000 r-xp /lib/libresolv-2.13.so
f6ac3000 f6adb000 r-xp /usr/lib/liblzma.so.5.0.3
f6ae4000 f6ae6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aee000 f6b08000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b10000 f6b3f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b48000 f6b57000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b61000 f6b6b000 r-xp /usr/lib/libsensord-shared.so
f6b74000 f6c47000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c52000 f6c68000 r-xp /lib/libz.so.1.2.5
f6c70000 f6c75000 r-xp /usr/lib/libffi.so.5.0.10
f6c7d000 f6c7e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c86000 f6c96000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c9e000 f6cb7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cbf000 f6cc1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cc9000 f6d3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d48000 f6d4e000 r-xp /lib/librt-2.13.so
f6d57000 f6d75000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d7f000 f6d80000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d88000 f6dab000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6db3000 f6db8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dc0000 f6dea000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6df3000 f6e0a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e12000 f6e7b000 r-xp /lib/libm-2.13.so
f6e84000 f6f18000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f2b000 f6f30000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f38000 f6f3f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f47000 f6f71000 r-xp /usr/lib/libsensor.so.1.9.6
f6f7a000 f7046000 r-xp /usr/lib/libxml2.so.2.7.8
f7053000 f7055000 r-xp /usr/lib/libiniparser.so.0
f705e000 f7064000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f706d000 f713d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f713e000 f7172000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f717b000 f71b7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71bf000 f71c2000 r-xp /usr/lib/libbundle.so.0.1.22
f71ca000 f71d0000 r-xp /usr/lib/libappsvc.so.0.1.0
f71d8000 f7219000 r-xp /usr/lib/libeina.so.1.7.99
f7222000 f7239000 r-xp /usr/lib/libecore.so.1.7.99
f7250000 f7259000 r-xp /usr/lib/libvconf.so.0.2.45
f7261000 f7275000 r-xp /lib/libpthread-2.13.so
f7280000 f728d000 r-xp /usr/lib/libaul.so.0.1.0
f7297000 f7299000 r-xp /lib/libdl-2.13.so
f72a2000 f72ad000 r-xp /lib/libunwind.so.8.0.1
f72da000 f72e2000 r-xp /lib/libgcc_s-4.6.so.1
f72e3000 f7407000 r-xp /lib/libc-2.13.so
f7415000 f7417000 r-xp /usr/lib/libdlog.so.0.0.0
f741f000 f742b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7434000 f7439000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7441000 f7450000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7458000 f745c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7465000 f7468000 r-xp /usr/lib/libappcore-agent.so.1.1
f7470000 f7472000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f747a000 f747e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7486000 f74a3000 r-xp /lib/ld-2.13.so
f74ac000 f74af000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74af000 f74b3000 r-xp /usr/lib/libsys-assert.so
f75f8000 f7681000 rw-p [heap]
ffac7000 ffae8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8783)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74ad228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7444539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf714b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7149c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7155e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf715bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf715bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf718b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7149c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7155e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf715bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf715bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf718de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf718e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7195f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b2d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b20171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bf3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70a0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70a27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7232ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf722db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf722e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf722e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7466183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74667fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74ad4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72fa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74acf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3 20:28:30.619+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:30.619+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:30.619+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:30.619+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:30.619+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:30.619+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:30.619+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:30.619+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:30.619+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:30.639+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.649+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.649+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:30.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:30.699+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:30.709+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:30.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:30.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:30.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:30.759+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76fc160
04-23 20:28:30.819+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76ce270]
04-23 20:28:30.819+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:30.819+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:30.819+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:30.819+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:30.829+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:30.829+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:30.839+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.849+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.849+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:30.849+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:30.849+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:30.849+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:30.849+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:30.849+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:30.849+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:30.849+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:30.849+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:30.859+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.869+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:30.869+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:30.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:30.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:30.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:30.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:30.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:30.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76ce270
04-23 20:28:31.039+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:28:31.039+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:31.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:31.039+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:31.049+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8734
04-23 20:28:31.049+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:28:31.099+0200 E/CAPI_APPFW_APPLICATION( 8734): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:31.099+0200 E/CAPI_APPFW_APPLICATION( 8734): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:31.119+0200 W/LOCATION( 8734): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:28:31.119+0200 E/LOCATION( 8734): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:28:31.119+0200 E/PKGMGR_INFO( 8734): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:28:31.119+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:31.139+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8734
04-23 20:28:31.139+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8734) type(svcapp) bg(0)
04-23 20:28:31.139+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8734) was created
04-23 20:28:31.139+0200 I/LOCATION( 8734): location.c: location_new(269) > method: 0
04-23 20:28:31.139+0200 W/LOCATION( 8734): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:31.139+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:31.149+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:31.149+0200 W/LOCATION( 8734): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:31.149+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:31.159+0200 W/LOCATION( 8734): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:31.159+0200 W/LOCATION( 8734): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:31.159+0200 W/LOCATION( 8734): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:31.159+0200 W/LOCATION( 8734): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:31.169+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:31.179+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:31.179+0200 W/LOCATION( 8734): module-internal.c: module_new(311) > module (wps) open success
04-23 20:28:31.179+0200 W/LOCATION( 8734): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:28:31.189+0200 W/LOCATION( 8734): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:28:31.189+0200 W/LOCATION( 8734): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:31.189+0200 W/LOCATION( 8734): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:31.199+0200 W/LOCATION( 8734): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:28:31.199+0200 I/LOCATION( 8734): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf76bcc18
04-23 20:28:31.199+0200 I/LOCATION( 8734): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:28:31.199+0200 I/LOCATION( 8734): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf76bcc18
04-23 20:28:31.199+0200 I/LOCATION( 8734): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:28:31.209+0200 I/location( 8734): es.ugr.frailty.location: creado servicio de localización
04-23 20:28:31.209+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8734)
04-23 20:28:31.209+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:28:31.209+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:31.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:31.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8734
04-23 20:28:31.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:31.249+0200 I/LOCATION( 8734): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:28:31.289+0200 W/LOCATION( 8734): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:31.289+0200 W/LOCATION( 8734): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:31.289+0200 I/LOCATION( 8734): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:31.289+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8734]
04-23 20:28:31.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:31.399+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8734
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:28:31.399+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:28:31.399+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:31.399+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:31.399+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:28:31.399+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:28:31.399+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:28:31.399+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:28:31.399+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:28:31.399+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:28:31.409+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:28:31.409+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:28:31.409+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:28:31.409+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:28:31.419+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:31.469+0200 W/LOCATION( 8734): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:31.469+0200 W/LOCATION( 8734): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:31.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:31.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400c448]
04-23 20:28:31.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:31.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:31.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:31.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:31.589+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:31.589+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:31.599+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:31.599+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:31.599+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:31.599+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:31.599+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:31.599+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:31.599+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:31.599+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:31.599+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:31.599+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:31.599+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:31.609+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:31.619+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:31.619+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:31.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:31.649+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:31.649+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2186911), time2(2183707)
04-23 20:28:31.649+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:28:31.649+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:31.649+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:31.649+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:31.669+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:31.709+0200 W/LOCATION( 8734): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:31.709+0200 I/LOCATION( 8734): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:31.709+0200 I/LOCATION( 8734): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:31.709+0200 I/location( 8734): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:31.789+0200 I/LOCATION( 8734): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:31.829+0200 E/location( 8734): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:31.829+0200 W/AUL     ( 8734): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:31.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:31.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8734
04-23 20:28:31.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:31.849+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:31.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:31.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.849+0200 I/utils   ( 8242): specific action
04-23 20:28:31.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.849+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.849+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:31.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:31.849+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:31.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:31.859+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:31.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:31.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.859+0200 I/utils   ( 8247): specific action
04-23 20:28:31.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.859+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:31.859+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:31.859+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:31.859+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:31.859+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:31.859+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:31.859+0200 W/AUL     ( 8734): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:31.859+0200 I/location( 8734): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:31.859+0200 I/location( 8734): stopping es.ugr.frailty.location service
04-23 20:28:31.859+0200 E/CAPI_APPFW_APP_CONTROL( 8734): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:28:31.859+0200 E/location( 8734): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:28:31.859+0200 I/CAPI_APPFW_APPLICATION( 8734): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:31.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:31.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:31.909+0200 W/LOCATION( 8734): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:31.909+0200 I/LOCATION( 8734): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:31.909+0200 I/LOCATION( 8734): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:28:31.999+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:28:31.999+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:28:31.999+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:28:31.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:28:32.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.159+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:32.159+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:32.159+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:32.159+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400c448
04-23 20:28:32.219+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76ce120]
04-23 20:28:32.219+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:32.219+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:32.219+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:32.219+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:32.229+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:32.229+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:32.239+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.239+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.239+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:32.239+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:32.239+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:32.239+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:32.239+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:32.249+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:32.249+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:32.249+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:32.249+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:32.249+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.259+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.259+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:32.259+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:32.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:32.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:32.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76ce120
04-23 20:28:32.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76d4680]
04-23 20:28:32.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:32.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:32.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:32.429+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:32.439+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:32.439+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:32.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.459+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:32.459+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:32.459+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:32.459+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:32.459+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:32.459+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:32.459+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:32.459+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:32.459+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:32.459+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.499+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:32.509+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:32.509+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:32.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:32.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:32.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:32.579+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76d4680
04-23 20:28:32.769+0200 W/AUL     ( 8744): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:28:32.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:32.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:32.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8710
04-23 20:28:32.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:32.769+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8710
04-23 20:28:32.769+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8710)
04-23 20:28:33.859+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:28:41.219+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:28:41.219+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:28:41.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:41.219+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:41.229+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8783
04-23 20:28:41.229+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:28:41.279+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8783
04-23 20:28:41.279+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8783) type(svcapp) bg(0)
04-23 20:28:41.289+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8783)
04-23 20:28:41.289+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:28:41.289+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:28:41.299+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8783]
04-23 20:28:41.319+0200 E/CAPI_APPFW_APPLICATION( 8783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:41.319+0200 E/CAPI_APPFW_APPLICATION( 8783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:28:41.319+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:41.329+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8783
04-23 20:28:41.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:28:41.339+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8783
04-23 20:28:41.339+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:41.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:28:41.349+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8783) was created
04-23 20:28:41.359+0200 W/LOCATION( 8783): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:28:41.359+0200 E/LOCATION( 8783): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:28:41.359+0200 E/PKGMGR_INFO( 8783): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:28:41.369+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:41.379+0200 I/LOCATION( 8783): location.c: location_new(269) > method: 0
04-23 20:28:41.389+0200 W/LOCATION( 8783): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:41.389+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:41.389+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:41.399+0200 W/LOCATION( 8783): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:41.399+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:41.409+0200 W/LOCATION( 8783): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:41.409+0200 W/LOCATION( 8783): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:41.409+0200 W/LOCATION( 8783): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:41.409+0200 W/LOCATION( 8783): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:41.429+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:41.429+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:28:41.429+0200 W/LOCATION( 8783): module-internal.c: module_new(311) > module (wps) open success
04-23 20:28:41.439+0200 W/LOCATION( 8783): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:28:41.439+0200 W/LOCATION( 8783): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:28:41.439+0200 W/LOCATION( 8783): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:41.439+0200 W/LOCATION( 8783): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:41.459+0200 W/LOCATION( 8783): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:28:41.459+0200 I/LOCATION( 8783): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7628c18
04-23 20:28:41.459+0200 I/LOCATION( 8783): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:28:41.459+0200 I/LOCATION( 8783): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7628c18
04-23 20:28:41.459+0200 I/LOCATION( 8783): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:28:41.459+0200 I/location( 8783): es.ugr.frailty.location: creado servicio de localización
04-23 20:28:41.509+0200 I/LOCATION( 8783): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:28:41.549+0200 W/LOCATION( 8783): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:41.549+0200 W/LOCATION( 8783): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:41.549+0200 I/LOCATION( 8783): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:28:41.619+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:28:41.619+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:41.619+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:28:41.619+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:28:41.619+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:28:41.619+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:28:41.619+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:28:41.619+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:28:41.619+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:28:41.619+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:28:41.619+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:28:41.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:28:41.669+0200 W/LOCATION( 8783): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:28:41.669+0200 W/LOCATION( 8783): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:28:41.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:41.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4003bc8]
04-23 20:28:41.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:41.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:41.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:41.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:41.799+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:41.799+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:41.799+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:41.809+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:41.809+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:41.809+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:41.809+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:41.809+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:41.809+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:41.809+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:41.809+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:41.809+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:41.809+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:41.819+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:41.829+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:41.829+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:41.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:41.859+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:41.859+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2197121), time2(2183707)
04-23 20:28:41.859+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:28:41.859+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:41.859+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:41.859+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:41.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:41.909+0200 W/LOCATION( 8783): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:41.909+0200 I/LOCATION( 8783): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:41.909+0200 I/LOCATION( 8783): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:41.909+0200 I/location( 8783): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:41.989+0200 I/LOCATION( 8783): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:42.039+0200 E/location( 8783): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:42.039+0200 W/AUL     ( 8783): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:42.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:42.049+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8783
04-23 20:28:42.049+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:42.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:42.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:42.059+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.059+0200 I/utils   ( 8242): specific action
04-23 20:28:42.059+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.059+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.059+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.059+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:42.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:42.059+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:42.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:42.069+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:42.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 I/utils   ( 8247): specific action
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:42.069+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:42.069+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:42.069+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:42.069+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:42.069+0200 W/AUL     ( 8783): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:42.069+0200 I/location( 8783): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:42.069+0200 W/CAPI_APPFW_APP_CONTROL( 8783): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:42.069+0200 I/utils   ( 8783): specific action
04-23 20:28:42.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:42.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:42.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:42.819+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:28:43.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:43.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:43.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:43.499+0200 W/LOCATION( 8783): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:28:43.649+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11087836c6f63152450812
