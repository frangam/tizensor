S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10856
Date: 2018-04-23 20:35:53+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a052d, r5   = 0xf72aa958
r6   = 0xffc18eb0, r7   = 0xffc18d60
r8   = 0xf72bdc18, r9   = 0x00000000
r10  = 0xffc18e3c, fp   = 0xffc18eb0
ip   = 0x00000001, sp   = 0xffc18d38
lr   = 0xf70a0539, pc   = 0xf7109228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    138088 KB
Buffers:     37740 KB
Cached:     157524 KB
VmPeak:      53456 KB
VmSize:      53452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12160 KB
VmRSS:       12156 KB
VmData:      11180 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10856 TID = 10856
10856 10859 

Maps Information
f3f6b000 f476a000 rw-p [stack:10859]
f4771000 f4773000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f477b000 f477f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4788000 f478a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4792000 f4795000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47a4000 f47a9000 r-xp /usr/lib/libsystem.so.0.0.0
f47b4000 f47b7000 r-xp /lib/libattr.so.1.1.0
f47bf000 f47cf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47d7000 f47e0000 r-xp /usr/lib/libedbus.so.1.7.99
f47e8000 f47e9000 r-xp /usr/lib/libresponse.so.0.2.96
f47f2000 f47f7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6099000 f619f000 r-xp /usr/lib/libicuuc.so.57.1
f61b5000 f633d000 r-xp /usr/lib/libicui18n.so.57.1
f634d000 f635a000 r-xp /usr/lib/libail.so.0.1.0
f6363000 f636a000 r-xp /usr/lib/libminizip.so.1.0.0
f6373000 f651c000 r-xp /usr/lib/libcrypto.so.1.0.0
f653c000 f6583000 r-xp /usr/lib/libssl.so.1.0.0
f658f000 f6591000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6599000 f65a0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65a9000 f65b0000 r-xp /lib/libcrypt-2.13.so
f65e1000 f65e4000 r-xp /lib/libcap.so.2.21
f65ec000 f65ee000 r-xp /usr/lib/libiri.so
f65f6000 f663f000 r-xp /usr/lib/libmdm.so.1.2.69
f6647000 f664d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6655000 f6678000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6682000 f6684000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f668c000 f66a9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66b2000 f66b6000 r-xp /usr/lib/libsmack.so.1.0.0
f66bf000 f66d8000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e1000 f66e9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f1000 f66f7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6700000 f6702000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f670b000 f671b000 r-xp /lib/libresolv-2.13.so
f671f000 f6737000 r-xp /usr/lib/liblzma.so.5.0.3
f6740000 f6742000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f674a000 f6764000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f676c000 f679b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67a4000 f67b3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67bd000 f67c7000 r-xp /usr/lib/libsensord-shared.so
f67d0000 f68a3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68ae000 f68c4000 r-xp /lib/libz.so.1.2.5
f68cc000 f68d1000 r-xp /usr/lib/libffi.so.5.0.10
f68d9000 f68da000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68e2000 f68f2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68fa000 f6913000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f691b000 f691d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6925000 f699a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69a4000 f69aa000 r-xp /lib/librt-2.13.so
f69b3000 f69d1000 r-xp /usr/lib/libsystemd.so.0.4.0
f69db000 f69dc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69e4000 f6a07000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a0f000 f6a14000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a1c000 f6a46000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a4f000 f6a66000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a6e000 f6ad7000 r-xp /lib/libm-2.13.so
f6ae0000 f6b74000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b87000 f6b8c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b94000 f6b9b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ba3000 f6bcd000 r-xp /usr/lib/libsensor.so.1.9.6
f6bd6000 f6ca2000 r-xp /usr/lib/libxml2.so.2.7.8
f6caf000 f6cb1000 r-xp /usr/lib/libiniparser.so.0
f6cba000 f6cc0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cc9000 f6d99000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d9a000 f6dce000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dd7000 f6e13000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e1b000 f6e1e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e26000 f6e2c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e34000 f6e75000 r-xp /usr/lib/libeina.so.1.7.99
f6e7e000 f6e95000 r-xp /usr/lib/libecore.so.1.7.99
f6eac000 f6eb5000 r-xp /usr/lib/libvconf.so.0.2.45
f6ebd000 f6ed1000 r-xp /lib/libpthread-2.13.so
f6edc000 f6ee9000 r-xp /usr/lib/libaul.so.0.1.0
f6ef3000 f6ef5000 r-xp /lib/libdl-2.13.so
f6efe000 f6f09000 r-xp /lib/libunwind.so.8.0.1
f6f36000 f6f3e000 r-xp /lib/libgcc_s-4.6.so.1
f6f3f000 f7063000 r-xp /lib/libc-2.13.so
f7071000 f7073000 r-xp /usr/lib/libdlog.so.0.0.0
f707b000 f7087000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7090000 f7095000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f709d000 f70ac000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70b4000 f70b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c1000 f70c4000 r-xp /usr/lib/libappcore-agent.so.1.1
f70cc000 f70ce000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70d6000 f70da000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70e2000 f70ff000 r-xp /lib/ld-2.13.so
f7108000 f710b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f710b000 f710f000 r-xp /usr/lib/libsys-assert.so
f728d000 f72fd000 rw-p [heap]
ffbfa000 ffc1b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10856)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7109228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6da73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6da5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6db7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6db7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dec75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6de71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6da5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6db7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6db7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6de9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dea017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47891fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf477c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf684f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cfcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cfe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e8eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e89b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e8a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e8a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70c2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70c27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf710953f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf6f5685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7108f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
til.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:41.569+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:41.579+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:41.579+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:41.579+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:41.579+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:41.579+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:41.579+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:41.579+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:41.579+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:41.589+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:41.589+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:41.589+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:41.599+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:41.599+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:41.599+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:41.609+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:41.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:41.679+0200 W/LOCATION(10806): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:41.679+0200 I/LOCATION(10806): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:41.679+0200 I/LOCATION(10806): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:41.689+0200 I/location(10806): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:41.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:41.699+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2616962), time2(2613773)
04-23 20:35:41.699+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:35:41.699+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:41.699+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:41.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:41.769+0200 I/LOCATION(10806): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:41.819+0200 W/AUL     (10806): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:41.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:41.829+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10806
04-23 20:35:41.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:41.839+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:41.839+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:41.839+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.839+0200 I/utils   (10115): specific action
04-23 20:35:41.839+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.839+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.839+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.839+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:41.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:41.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:41.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:41.849+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:41.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:41.849+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.849+0200 I/utils   (10120): specific action
04-23 20:35:41.849+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.849+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.849+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.849+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:41.849+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:41.849+0200 I/recorder(10120): guardando datos en local
04-23 20:35:41.849+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:41.849+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:41.849+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:41.849+0200 W/AUL     (10806): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:41.849+0200 I/location(10806): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:41.849+0200 I/location(10806): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:41:827,nan,37.171667,-3.594158,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:35:41.849+0200 I/location(10806): stopping es.ugr.frailty.location service
04-23 20:35:41.849+0200 E/CAPI_APPFW_APP_CONTROL(10806): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:35:41.849+0200 E/location(10806): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:35:41.849+0200 I/CAPI_APPFW_APPLICATION(10806): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:35:41.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:35:41.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:35:41.899+0200 W/LOCATION(10806): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:41.899+0200 I/LOCATION(10806): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:41.899+0200 I/LOCATION(10806): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:35:41.969+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:35:41.969+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:35:41.969+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:35:41.969+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:35:42.069+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:42.119+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:42.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:42.129+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf730cad8
04-23 20:35:42.179+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1bc20]
04-23 20:35:42.179+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:42.179+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:42.179+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:42.179+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:42.189+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:42.189+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:42.199+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.199+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.199+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:42.199+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:42.199+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:42.199+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:42.199+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:42.199+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:42.199+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:42.199+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:42.199+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:42.209+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.219+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.219+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:42.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:42.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:42.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:42.329+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1bc20
04-23 20:35:42.399+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf7329518]
04-23 20:35:42.399+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:42.399+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:42.399+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:42.399+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:42.409+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:42.409+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:42.419+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.419+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.419+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:42.419+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:42.419+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:42.419+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:42.419+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:42.419+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:42.419+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:42.419+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:42.419+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:42.429+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.439+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:42.439+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:42.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:42.509+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:42.509+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:42.509+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:42.509+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf7329518
04-23 20:35:42.699+0200 W/AUL     (10820): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:35:42.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:35:42.699+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:35:42.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10783
04-23 20:35:42.699+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:35:42.699+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10783
04-23 20:35:42.699+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10783)
04-23 20:35:43.859+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:35:51.039+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:35:51.039+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:51.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:51.039+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:51.069+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10856
04-23 20:35:51.079+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:51.119+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10856
04-23 20:35:51.119+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10856) type(svcapp) bg(0)
04-23 20:35:51.129+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10856]
04-23 20:35:51.149+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10856)
04-23 20:35:51.149+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:35:51.149+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:51.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10856
04-23 20:35:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:51.179+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10856
04-23 20:35:51.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:51.209+0200 E/CAPI_APPFW_APPLICATION(10856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:51.209+0200 E/CAPI_APPFW_APPLICATION(10856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:51.209+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10856) was created
04-23 20:35:51.239+0200 W/LOCATION(10856): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:51.239+0200 E/LOCATION(10856): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:51.239+0200 E/PKGMGR_INFO(10856): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:51.239+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:51.259+0200 I/LOCATION(10856): location.c: location_new(269) > method: 0
04-23 20:35:51.259+0200 W/LOCATION(10856): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:51.269+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:51.269+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:51.279+0200 W/LOCATION(10856): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:51.279+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:51.279+0200 W/LOCATION(10856): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:51.279+0200 W/LOCATION(10856): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:51.279+0200 W/LOCATION(10856): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:51.279+0200 W/LOCATION(10856): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:51.309+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:51.309+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:51.319+0200 W/LOCATION(10856): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:51.319+0200 W/LOCATION(10856): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:51.329+0200 W/LOCATION(10856): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:51.329+0200 W/LOCATION(10856): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:51.329+0200 W/LOCATION(10856): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:51.339+0200 W/LOCATION(10856): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:51.349+0200 I/LOCATION(10856): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72bdc18
04-23 20:35:51.349+0200 I/LOCATION(10856): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:51.349+0200 I/LOCATION(10856): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72bdc18
04-23 20:35:51.349+0200 I/LOCATION(10856): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:51.349+0200 I/location(10856): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:51.389+0200 I/LOCATION(10856): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:51.429+0200 W/LOCATION(10856): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:51.429+0200 W/LOCATION(10856): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:51.429+0200 I/LOCATION(10856): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:51.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:51.499+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:51.499+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:51.499+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:51.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:51.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:51.499+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:51.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:51.499+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:51.499+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:51.499+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:51.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:51.569+0200 W/LOCATION(10856): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:51.569+0200 W/LOCATION(10856): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:51.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:51.709+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c19828]
04-23 20:35:51.709+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:51.709+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:51.709+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:51.719+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:51.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:51.729+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2626991), time2(2613773)
04-23 20:35:51.729+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:51.729+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:51.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:35:51.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:51.729+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:51.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:51.739+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:51.749+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:51.749+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:51.749+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:51.749+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:51.749+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:51.749+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:51.749+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:51.749+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:51.749+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:51.749+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:51.759+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:51.769+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:51.769+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:51.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:51.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:51.849+0200 W/LOCATION(10856): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:51.849+0200 I/LOCATION(10856): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:51.849+0200 I/LOCATION(10856): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:51.849+0200 I/location(10856): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:51.949+0200 I/LOCATION(10856): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:51.999+0200 W/AUL     (10856): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:51.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:51.999+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10856
04-23 20:35:52.009+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:52.019+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.019+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:52.019+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:52.019+0200 I/utils   (10115): specific action
04-23 20:35:52.019+0200 W/AUL     (10856): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:52.019+0200 I/location(10856): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:52.019+0200 I/location(10856): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:52:6,nan,37.171667,-3.594158,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:35:52.019+0200 W/CAPI_APPFW_APP_CONTROL(10856): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.019+0200 I/utils   (10856): specific action
04-23 20:35:52.019+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.019+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.019+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.019+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:52.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:52.019+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:52.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:52.029+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.029+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:52.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:52.029+0200 I/utils   (10120): specific action
04-23 20:35:52.029+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.029+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.029+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.029+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.029+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:52.029+0200 I/recorder(10120): guardando datos en local
04-23 20:35:52.029+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:52.029+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:52.029+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:52.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:52.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:52.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:52.569+0200 I/servicemanager(10115): es.ugr.frailty.gravity alive timeout
04-23 20:35:52.569+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:35:52.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:52.569+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:52.589+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10862
04-23 20:35:52.599+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:52.639+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10862
04-23 20:35:52.639+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(10862) type(svcapp) bg(0)
04-23 20:35:52.669+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10862]
04-23 20:35:52.699+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:52.709+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10862
04-23 20:35:52.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:52.719+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10862)
04-23 20:35:52.719+0200 I/servicemanager(10115): es.ugr.frailty.gravity launch request sent!
04-23 20:35:52.719+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:52.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:52.739+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10862
04-23 20:35:52.749+0200 E/CAPI_APPFW_APPLICATION(10862): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:52.749+0200 E/CAPI_APPFW_APPLICATION(10862): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:52.749+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10862) was created
04-23 20:35:52.749+0200 I/utils   (10862): trying to start service: es.ugr.frailty.gravity
04-23 20:35:52.759+0200 I/utils   (10862): es.ugr.frailty.gravity sensor supported
04-23 20:35:52.769+0200 I/utils   (10862): es.ugr.frailty.gravity listener started
04-23 20:35:52.769+0200 W/CAPI_APPFW_APP_CONTROL(10862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:52.769+0200 I/utils   (10862): specific action
04-23 20:35:52.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:52.789+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.789+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:795,9.773937,-0.042941,0.799187
04-23 20:35:52.809+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.809+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:817,9.773723,-0.042296,0.801839
04-23 20:35:52.829+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.829+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:838,0.043977,9.773711,0.801886
04-23 20:35:52.849+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.849+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:856,0.043505,9.773659,0.802545
04-23 20:35:52.869+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.869+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:35:52.869+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:876,0.045459,9.773254,0.807349
04-23 20:35:52.889+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.889+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:897,0.046631,9.773129,0.808793
04-23 20:35:52.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:915,0.046492,9.773198,0.807974
04-23 20:35:52.929+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:938,0.045231,9.773025,0.810138
04-23 20:35:52.949+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:959,0.045711,9.772784,0.813008
04-23 20:35:52.969+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:978,0.043897,9.772704,0.814076
04-23 20:35:52.989+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:52.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:52:998,0.042866,9.772582,0.815589
04-23 20:35:53.009+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:18,0.042567,9.772427,0.817463
04-23 20:35:53.029+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.029+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:36,0.043560,9.772087,0.821463
04-23 20:35:53.049+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.059+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:57,0.042418,9.772009,0.822452
04-23 20:35:53.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:53.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:53.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:53.069+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:81,0.042489,9.771804,0.824886
04-23 20:35:53.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:97,0.043113,9.771712,0.825932
04-23 20:35:53.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:118,0.044735,9.771680,0.826229
04-23 20:35:53.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:136,0.044806,9.771637,0.826734
04-23 20:35:53.149+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:157,0.043838,9.771572,0.827550
04-23 20:35:53.169+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:178,0.043375,9.771516,0.828242
04-23 20:35:53.189+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:198,0.043037,9.771659,0.826564
04-23 20:35:53.209+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:217,0.042075,9.771417,0.829480
04-23 20:35:53.229+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:237,0.041140,9.771340,0.830425
04-23 20:35:53.249+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.259+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:257,0.041504,9.771269,0.831246
04-23 20:35:53.269+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:276,0.042190,9.771181,0.832245
04-23 20:35:53.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:297,0.042949,9.771193,0.832063
04-23 20:35:53.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:316,0.041851,9.771067,0.833599
04-23 20:35:53.329+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.329+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:335,0.041817,9.770885,0.835720
04-23 20:35:53.349+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.349+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:358,0.041564,9.770860,0.836037
04-23 20:35:53.369+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.369+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:377,0.041333,9.770535,0.839826
04-23 20:35:53.389+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:398,0.039964,9.770391,0.841572
04-23 20:35:53.409+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.419+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:419,0.040244,9.770405,0.841397
04-23 20:35:53.429+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.439+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:438,0.040183,9.770362,0.841905
04-23 20:35:53.449+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.459+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:459,0.040585,9.770399,0.841445
04-23 20:35:53.469+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:476,0.039143,9.770247,0.843293
04-23 20:35:53.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:497,0.039252,9.770373,0.841809
04-23 20:35:53.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:518,0.039574,9.770447,0.840940
04-23 20:35:53.529+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:536,0.041787,9.770485,0.840393
04-23 20:35:53.549+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:557,0.043596,9.770744,0.837283
04-23 20:35:53.569+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.569+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:576,0.042111,9.770688,0.838017
04-23 20:35:53.589+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.589+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:596,0.040033,9.770493,0.840393
04-23 20:35:53.609+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:619,0.041317,9.770118,0.844671
04-23 20:35:53.629+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:635,0.039715,9.770015,0.845941
04-23 20:35:53.649+0200 W/LOCATION(10856): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:35:53.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:663,0.038788,9.769864,0.847727
04-23 20:35:53.669+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.669+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:676,0.038790,9.769909,0.847212
04-23 20:35:53.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:696,0.037664,9.769733,0.849279
04-23 20:35:53.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:716,0.037619,9.769813,0.848373
04-23 20:35:53.729+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.729+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:736,0.037683,9.769869,0.847720
04-23 20:35:53.749+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.749+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:756,0.036947,9.769739,0.849243
04-23 20:35:53.769+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.769+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:776,0.036927,9.769739,0.849246
04-23 20:35:53.789+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.789+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:795,0.036119,9.769575,0.851163
04-23 20:35:53.809+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.809+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:815,0.036578,9.769488,0.852143
04-23 20:35:53.829+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.829+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:835,0.039533,9.769791,0.848539
04-23 20:35:53.849+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.849+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:53:856,0.038489,9.769753,0.849021
04-23 20:35:53.869+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:53.889+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11108566c6f63152450855
