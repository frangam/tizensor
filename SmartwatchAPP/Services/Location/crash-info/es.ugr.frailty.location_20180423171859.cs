S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 29763
Date: 2018-04-23 17:18:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74c052d, r5   = 0xf7a02f98
r6   = 0xff90fb90, r7   = 0xff90fa40
r8   = 0xf79ffc18, r9   = 0x00000000
r10  = 0xff90fb1c, fp   = 0xff90fb90
ip   = 0x00000001, sp   = 0xff90e8c0
lr   = 0xf74c0539, pc   = 0xf75292b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10796 KB
Buffers:     65752 KB
Cached:     224624 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12200 KB
VmRSS:       12200 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29763 TID = 29763
29763 29766 

Maps Information
f438b000 f4b8a000 rw-p [stack:29766]
f4b91000 f4b93000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b9b000 f4b9f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ba8000 f4baa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bb2000 f4bb5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bc4000 f4bc9000 r-xp /usr/lib/libsystem.so.0.0.0
f4bd4000 f4bd7000 r-xp /lib/libattr.so.1.1.0
f4bdf000 f4bef000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bf7000 f4c00000 r-xp /usr/lib/libedbus.so.1.7.99
f4c08000 f4c09000 r-xp /usr/lib/libresponse.so.0.2.96
f4c12000 f4c17000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64b9000 f65bf000 r-xp /usr/lib/libicuuc.so.57.1
f65d5000 f675d000 r-xp /usr/lib/libicui18n.so.57.1
f676d000 f677a000 r-xp /usr/lib/libail.so.0.1.0
f6783000 f678a000 r-xp /usr/lib/libminizip.so.1.0.0
f6793000 f693c000 r-xp /usr/lib/libcrypto.so.1.0.0
f695c000 f69a3000 r-xp /usr/lib/libssl.so.1.0.0
f69af000 f69b1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69b9000 f69c0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69c9000 f69d0000 r-xp /lib/libcrypt-2.13.so
f6a01000 f6a04000 r-xp /lib/libcap.so.2.21
f6a0c000 f6a0e000 r-xp /usr/lib/libiri.so
f6a16000 f6a5f000 r-xp /usr/lib/libmdm.so.1.2.69
f6a67000 f6a6d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a75000 f6a98000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aa2000 f6aa4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6aac000 f6ac9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ad2000 f6ad6000 r-xp /usr/lib/libsmack.so.1.0.0
f6adf000 f6af8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b01000 f6b09000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b11000 f6b17000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b20000 f6b22000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b2b000 f6b3b000 r-xp /lib/libresolv-2.13.so
f6b3f000 f6b57000 r-xp /usr/lib/liblzma.so.5.0.3
f6b60000 f6b62000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b6a000 f6b84000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b8c000 f6bbb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bc4000 f6bd3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bdd000 f6be7000 r-xp /usr/lib/libsensord-shared.so
f6bf0000 f6cc3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cce000 f6ce4000 r-xp /lib/libz.so.1.2.5
f6cec000 f6cf1000 r-xp /usr/lib/libffi.so.5.0.10
f6cf9000 f6cfa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d02000 f6d12000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d1a000 f6d33000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d3b000 f6d3d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d45000 f6dba000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dc4000 f6dca000 r-xp /lib/librt-2.13.so
f6dd3000 f6df1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dfb000 f6dfc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e04000 f6e27000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e2f000 f6e34000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e3c000 f6e66000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e6f000 f6e86000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e8e000 f6ef7000 r-xp /lib/libm-2.13.so
f6f00000 f6f94000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fa7000 f6fac000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fb4000 f6fbb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fc3000 f6fed000 r-xp /usr/lib/libsensor.so.1.9.6
f6ff6000 f70c2000 r-xp /usr/lib/libxml2.so.2.7.8
f70cf000 f70d1000 r-xp /usr/lib/libiniparser.so.0
f70da000 f70e0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70e9000 f71b9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ba000 f71ee000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71f7000 f7233000 r-xp /usr/lib/libSLP-location.so.0.9.24
f723b000 f723e000 r-xp /usr/lib/libbundle.so.0.1.22
f7246000 f724c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7254000 f7295000 r-xp /usr/lib/libeina.so.1.7.99
f729e000 f72b5000 r-xp /usr/lib/libecore.so.1.7.99
f72cc000 f72d5000 r-xp /usr/lib/libvconf.so.0.2.45
f72dd000 f72f1000 r-xp /lib/libpthread-2.13.so
f72fc000 f7309000 r-xp /usr/lib/libaul.so.0.1.0
f7313000 f7315000 r-xp /lib/libdl-2.13.so
f731e000 f7329000 r-xp /lib/libunwind.so.8.0.1
f7356000 f735e000 r-xp /lib/libgcc_s-4.6.so.1
f735f000 f7483000 r-xp /lib/libc-2.13.so
f7491000 f7493000 r-xp /usr/lib/libdlog.so.0.0.0
f749b000 f74a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74b0000 f74b5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74bd000 f74cc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74d4000 f74d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74e1000 f74e4000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ec000 f74ee000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74f6000 f74fa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7502000 f751f000 r-xp /lib/ld-2.13.so
f7528000 f752b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f752b000 f752f000 r-xp /usr/lib/libsys-assert.so
f79cf000 f7a58000 rw-p [heap]
ff8f1000 ff912000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29763)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75292b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74c0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71c73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71c5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71d1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71d7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71d7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf720c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72071f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71c5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71d1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71d7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71d7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7209e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf720a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7211f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ba91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b9c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c6f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf711cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf711e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72aeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72a9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72aa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72aa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74e2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74e27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75296c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf737685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7528fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 I/utils   (29506): specific action
04-23 17:18:55.071+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.071+0200 I/recorder(29506): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:18:55.071+0200 W/AUL     (29506): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:18:55.081+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29506)
04-23 17:18:55.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:55.081+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:18:55.081+0200 I/servicemanager(26979): eliminar datos locales
04-23 17:18:55.081+0200 W/AUL     (29736): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:18:55.081+0200 I/httppostreq(29736): request sent to service es.ugr.frailty.servicemanager
04-23 17:18:55.081+0200 I/httppostreq(29736): requesting HTTP POST Request Service
04-23 17:18:55.081+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 29506
04-23 17:18:55.081+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:18:55.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:18:55.091+0200 W/AUL     (29506): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:18:55.091+0200 I/recorder(29506): request sent to service es.ugr.frailty.servicemanager
04-23 17:18:55.091+0200 I/recorder(29506): eliminando datos en local
04-23 17:18:55.091+0200 I/utils   (26979): specific action
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.091+0200 I/servicemanager(26979): launch es.ugr.frailty.location
04-23 17:18:55.091+0200 I/servicemanager(26979): re launch service
04-23 17:18:55.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:55.251+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_create(453) > New handle created[0xf732d6d0]
04-23 17:18:55.251+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:18:55.251+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:18:55.251+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:18:55.251+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:18:55.261+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 10630625 to 10630926) (logOverhead=0,0,0,0,0,0,0), start: 17:18:54.970
04-23 17:18:55.261+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 304 ms (from 10630624 to 10630928) (logOverhead=0,0,0,0,0,0,0), start: 17:18:54.969
04-23 17:18:55.261+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 304 ms (from 10630624 to 10630928) (logOverhead=0,0,0,0,0,0,0), start: 17:18:54.969
04-23 17:18:55.281+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.281+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.281+0200 E/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
04-23 17:18:55.291+0200 E/PKGMGR_INFO(29741): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:18:55.301+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:55.311+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.321+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.321+0200 E/LOCATION(29741): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:18:55.321+0200 I/LOCATION(29741): location.c: location_new(269) > method: 1
04-23 17:18:55.331+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:55.341+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (gps) open success
04-23 17:18:55.341+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:18:55.351+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:18:55.351+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:55.351+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:55.351+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:55.361+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.361+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.361+0200 E/LOCATION(29741): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:18:55.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:55.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:55.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:55.441+0200 W/LOCATION(29723): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:18:55.441+0200 I/LOCATION(29723): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:18:55.441+0200 I/LOCATION(29723): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:18:55.441+0200 I/location(29723): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:18:55.521+0200 I/LOCATION(29723): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:18:55.571+0200 E/location(29723): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:18:55.571+0200 W/AUL     (29723): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:18:55.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:55.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 29723
04-23 17:18:55.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:18:55.581+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.581+0200 I/utils   (26979): specific action
04-23 17:18:55.581+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.581+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.581+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.581+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:18:55.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:18:55.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:18:55.581+0200 W/AUL     (29723): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:18:55.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:55.581+0200 I/location(29723): request sent to service es.ugr.frailty.servicemanager
04-23 17:18:55.581+0200 I/location(29723): stopping es.ugr.frailty.location service
04-23 17:18:55.581+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:18:55.581+0200 E/CAPI_APPFW_APP_CONTROL(29723): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:18:55.581+0200 E/location(29723): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:18:55.581+0200 I/CAPI_APPFW_APPLICATION(29723): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:18:55.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29506
04-23 17:18:55.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:18:55.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:18:55.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:18:55.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(29506), cmd(0)
04-23 17:18:55.601+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.601+0200 I/utils   (29506): specific action
04-23 17:18:55.601+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.601+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.601+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.601+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:55.601+0200 I/recorder(29506): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:18:55.601+0200 I/recorder(29506): guardando datos en local
04-23 17:18:55.601+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29506)
04-23 17:18:55.601+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:18:55.601+0200 I/servicemanager(26979): requesting to save local data
04-23 17:18:55.651+0200 W/LOCATION(29723): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:18:55.651+0200 I/LOCATION(29723): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:18:55.651+0200 I/LOCATION(29723): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:18:55.721+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:18:55.721+0200 E/CAPI_LOCATION_MANAGER(29741): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:18:55.721+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:18:55.721+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:18:55.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:55.861+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:18:55.861+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:18:55.861+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:18:55.861+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_destroy(471) > Destroy handle: 0xf732d6d0
04-23 17:18:55.911+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_create(453) > New handle created[0xf732d620]
04-23 17:18:55.911+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:18:55.911+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:18:55.911+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:18:55.911+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:18:55.921+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:55.921+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:55.931+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.941+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.941+0200 E/LOCATION(29741): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:18:55.941+0200 I/LOCATION(29741): location.c: location_new(269) > method: 1
04-23 17:18:55.941+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:55.941+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (gps) open success
04-23 17:18:55.941+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:18:55.941+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:18:55.941+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:55.941+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:55.941+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:55.951+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.971+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:55.971+0200 E/LOCATION(29741): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:18:55.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:56.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:56.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:56.051+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:18:56.101+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:18:56.101+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:18:56.101+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:18:56.101+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_destroy(471) > Destroy handle: 0xf732d620
04-23 17:18:56.141+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:18:56.161+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_create(453) > New handle created[0xf73342b0]
04-23 17:18:56.161+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:18:56.161+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:18:56.161+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:18:56.161+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:18:56.171+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:56.171+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:56.171+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:56.181+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:56.181+0200 E/LOCATION(29741): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:18:56.181+0200 I/LOCATION(29741): location.c: location_new(269) > method: 1
04-23 17:18:56.181+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:56.181+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (gps) open success
04-23 17:18:56.181+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:18:56.181+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:18:56.181+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:56.181+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:56.181+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:56.191+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:56.201+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:56.201+0200 E/LOCATION(29741): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:18:56.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:56.231+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:18:56.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:56.261+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:18:56.261+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:18:56.261+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:18:56.261+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_destroy(471) > Destroy handle: 0xf73342b0
04-23 17:18:56.441+0200 W/AUL     (29749): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:18:56.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:18:56.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:18:56.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29251
04-23 17:18:56.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:18:56.461+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29251
04-23 17:18:56.461+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29251)
04-23 17:18:57.011+0200 I/servicemanager(26979): es.ugr.frailty.heartrate alive timeout
04-23 17:18:57.011+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 17:18:57.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:57.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:18:57.041+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 29750
04-23 17:18:57.041+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:18:57.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 29750
04-23 17:18:57.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(29750) type(svcapp) bg(0)
04-23 17:18:57.101+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29750)
04-23 17:18:57.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [29750]
04-23 17:18:57.131+0200 E/CAPI_APPFW_APPLICATION(29750): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:18:57.131+0200 E/CAPI_APPFW_APPLICATION(29750): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:18:57.131+0200 I/utils   (29750): trying to start service: es.ugr.frailty.heartrate
04-23 17:18:57.131+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (29750) was created
04-23 17:18:57.141+0200 I/utils   (29750): es.ugr.frailty.heartrate sensor supported
04-23 17:18:57.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:18:57.161+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29750
04-23 17:18:57.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:18:57.161+0200 I/servicemanager(26979): es.ugr.frailty.heartrate launch request sent!
04-23 17:18:57.161+0200 I/servicemanager(26979): App control destroyed.
04-23 17:18:57.161+0200 I/utils   (29750): es.ugr.frailty.heartrate listener started
04-23 17:18:57.161+0200 W/CAPI_APPFW_APP_CONTROL(29750): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:57.161+0200 I/utils   (29750): specific action
04-23 17:18:57.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:18:57.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29750
04-23 17:18:57.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:18:57.241+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 17:18:57.241+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:18:57.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:57.241+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:18:57.261+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 29763
04-23 17:18:57.261+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:18:57.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 29763
04-23 17:18:57.311+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(29763) type(svcapp) bg(0)
04-23 17:18:57.321+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29763)
04-23 17:18:57.321+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 17:18:57.321+0200 I/servicemanager(26979): App control destroyed.
04-23 17:18:57.321+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [29763]
04-23 17:18:57.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:18:57.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29763
04-23 17:18:57.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:18:57.371+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:57.371+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:57.371+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29763
04-23 17:18:57.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:18:57.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:18:57.391+0200 E/CAPI_APPFW_APPLICATION(29763): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:18:57.391+0200 E/CAPI_APPFW_APPLICATION(29763): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:18:57.391+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (29763) was created
04-23 17:18:57.421+0200 W/LOCATION(29763): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:18:57.421+0200 E/LOCATION(29763): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:18:57.421+0200 E/PKGMGR_INFO(29763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:18:57.431+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:57.451+0200 I/LOCATION(29763): location.c: location_new(269) > method: 0
04-23 17:18:57.451+0200 W/LOCATION(29763): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:57.461+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:57.461+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:57.471+0200 W/LOCATION(29763): module-internal.c: module_new(311) > module (gps) open success
04-23 17:18:57.471+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:18:57.481+0200 W/LOCATION(29763): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:18:57.481+0200 W/LOCATION(29763): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:57.481+0200 W/LOCATION(29763): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:57.481+0200 W/LOCATION(29763): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:57.501+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:18:57.511+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:18:57.511+0200 W/LOCATION(29763): module-internal.c: module_new(311) > module (wps) open success
04-23 17:18:57.511+0200 W/LOCATION(29763): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:18:57.521+0200 W/LOCATION(29763): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:18:57.521+0200 W/LOCATION(29763): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:18:57.521+0200 W/LOCATION(29763): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:18:57.541+0200 W/LOCATION(29763): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:18:57.541+0200 I/LOCATION(29763): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf79ffc18
04-23 17:18:57.541+0200 I/LOCATION(29763): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:18:57.541+0200 I/LOCATION(29763): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf79ffc18
04-23 17:18:57.541+0200 I/LOCATION(29763): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:18:57.541+0200 I/location(29763): es.ugr.frailty.location: creado servicio de localización
04-23 17:18:57.571+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:57.571+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:57.591+0200 I/LOCATION(29763): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:18:57.601+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:18:57.631+0200 W/LOCATION(29763): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:57.631+0200 W/LOCATION(29763): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:57.631+0200 I/LOCATION(29763): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:18:57.701+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:18:57.701+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:18:57.701+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:18:57.701+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:57.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:57.701+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:18:57.701+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:18:57.701+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:18:57.701+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:18:57.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:18:57.711+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:18:57.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:18:57.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:18:57.761+0200 W/LOCATION(29763): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:18:57.761+0200 W/LOCATION(29763): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:18:57.771+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:57.771+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:57.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:57.881+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_create(453) > New handle created[0xf3e010c8]
04-23 17:18:57.881+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:18:57.881+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:18:57.881+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:18:57.881+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:18:57.891+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:57.891+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:57.901+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:57.921+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:57.921+0200 E/LOCATION(29741): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:18:57.921+0200 I/LOCATION(29741): location.c: location_new(269) > method: 1
04-23 17:18:57.921+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:18:57.921+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (gps) open success
04-23 17:18:57.921+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:18:57.921+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:18:57.921+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:18:57.921+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:18:57.921+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:18:57.931+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:57.951+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:18:57.951+0200 E/LOCATION(29741): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:18:57.961+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:18:57.971+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:57.971+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:57.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:57.971+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:18:57.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:18:57.971+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(10633639), time2(10331775)
04-23 17:18:57.971+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:18:57.971+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:18:57.981+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:18:57.981+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:18:57.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:58.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:18:58.071+0200 W/LOCATION(29763): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:18:58.071+0200 I/LOCATION(29763): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:18:58.071+0200 I/LOCATION(29763): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:18:58.071+0200 I/location(29763): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:18:58.171+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:58.171+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:58.191+0200 I/LOCATION(29763): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:18:58.241+0200 E/location(29763): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:18:58.241+0200 W/AUL     (29763): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:18:58.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:58.241+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 29763
04-23 17:18:58.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:18:58.251+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.251+0200 I/utils   (26979): specific action
04-23 17:18:58.251+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.251+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.251+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.251+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:18:58.251+0200 W/AUL     (29763): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:18:58.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:18:58.251+0200 I/location(29763): request sent to service es.ugr.frailty.servicemanager
04-23 17:18:58.251+0200 W/CAPI_APPFW_APP_CONTROL(29763): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:18:58.251+0200 I/utils   (29763): specific action
04-23 17:18:58.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29506
04-23 17:18:58.261+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.261+0200 I/utils   (29506): specific action
04-23 17:18:58.261+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.261+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.261+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29506)
04-23 17:18:58.261+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:18:58.261+0200 I/servicemanager(26979): requesting to save local data
04-23 17:18:58.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:18:58.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:18:58.261+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.261+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:18:58.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:18:58.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(29506), cmd(0)
04-23 17:18:58.261+0200 I/recorder(29506): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:18:58.261+0200 I/recorder(29506): guardando datos en local
04-23 17:18:58.371+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:58.371+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:58.571+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:58.571+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:58.771+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:58.771+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:58.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:18:58.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:58.981+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:18:58.981+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:58.991+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.081+0200 E/CAPI_TELEPHONY(29741): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:18:59.171+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:59.171+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.371+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:59.371+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.571+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:59.571+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.771+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:59.771+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.831+0200 W/LOCATION(29763): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:18:59.971+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:18:59.971+0200 I/heartrate(29750): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:18:59.981+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:18:59.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:18:59.981+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:19:00.071+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:19:00.071+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:19:00.071+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:19:00.071+0200 E/CAPI_LOCATION_MANAGER(29741): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:19:00.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:19:00.091+0200 W/AUL     (29774): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:19:00.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:19:00.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:19:00.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29466
04-23 17:19:00.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:19:00.101+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29466
04-23 17:19:00.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29466)
04-23 17:19:00.141+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:19:00.141+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:19:00.141+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:19:00.141+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_destroy(471) > Destroy handle: 0xf3e010c8
04-23 17:19:00.161+0200 W/CRASH_MANAGER(29775): worker.c: worker_job(1205) > 11297636c6f63152449673
