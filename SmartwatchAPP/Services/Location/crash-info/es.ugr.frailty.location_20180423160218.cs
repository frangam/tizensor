S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23059
Date: 2018-04-23 16:02:18+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf731052d, r5   = 0xf77f1f98
r6   = 0xff9be728, r7   = 0xff9be5d8
r8   = 0xf77eec18, r9   = 0x00000000
r10  = 0xff9be6b4, fp   = 0xff9be728
ip   = 0x00000001, sp   = 0xff9bd458
lr   = 0xf7310539, pc   = 0xf73792b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9500 KB
Buffers:     60812 KB
Cached:     225292 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11948 KB
VmRSS:       11948 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23059 TID = 23059
23059 23063 

Maps Information
f41db000 f49da000 rw-p [stack:23063]
f49e1000 f49e3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49eb000 f49ef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49f8000 f49fa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a02000 f4a05000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a14000 f4a19000 r-xp /usr/lib/libsystem.so.0.0.0
f4a24000 f4a27000 r-xp /lib/libattr.so.1.1.0
f4a2f000 f4a3f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a47000 f4a50000 r-xp /usr/lib/libedbus.so.1.7.99
f4a58000 f4a59000 r-xp /usr/lib/libresponse.so.0.2.96
f4a62000 f4a67000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6309000 f640f000 r-xp /usr/lib/libicuuc.so.57.1
f6425000 f65ad000 r-xp /usr/lib/libicui18n.so.57.1
f65bd000 f65ca000 r-xp /usr/lib/libail.so.0.1.0
f65d3000 f65da000 r-xp /usr/lib/libminizip.so.1.0.0
f65e3000 f678c000 r-xp /usr/lib/libcrypto.so.1.0.0
f67ac000 f67f3000 r-xp /usr/lib/libssl.so.1.0.0
f67ff000 f6801000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6809000 f6810000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6819000 f6820000 r-xp /lib/libcrypt-2.13.so
f6851000 f6854000 r-xp /lib/libcap.so.2.21
f685c000 f685e000 r-xp /usr/lib/libiri.so
f6866000 f68af000 r-xp /usr/lib/libmdm.so.1.2.69
f68b7000 f68bd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68c5000 f68e8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68f2000 f68f4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68fc000 f6919000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6922000 f6926000 r-xp /usr/lib/libsmack.so.1.0.0
f692f000 f6948000 r-xp /usr/lib/libnetwork.so.0.0.0
f6951000 f6959000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6961000 f6967000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6970000 f6972000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f697b000 f698b000 r-xp /lib/libresolv-2.13.so
f698f000 f69a7000 r-xp /usr/lib/liblzma.so.5.0.3
f69b0000 f69b2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69ba000 f69d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69dc000 f6a0b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a14000 f6a23000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a2d000 f6a37000 r-xp /usr/lib/libsensord-shared.so
f6a40000 f6b13000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b1e000 f6b34000 r-xp /lib/libz.so.1.2.5
f6b3c000 f6b41000 r-xp /usr/lib/libffi.so.5.0.10
f6b49000 f6b4a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b52000 f6b62000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b6a000 f6b83000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b8b000 f6b8d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b95000 f6c0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c14000 f6c1a000 r-xp /lib/librt-2.13.so
f6c23000 f6c41000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c4b000 f6c4c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c54000 f6c77000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c7f000 f6c84000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c8c000 f6cb6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cbf000 f6cd6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cde000 f6d47000 r-xp /lib/libm-2.13.so
f6d50000 f6de4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6df7000 f6dfc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e04000 f6e0b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e13000 f6e3d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e46000 f6f12000 r-xp /usr/lib/libxml2.so.2.7.8
f6f1f000 f6f21000 r-xp /usr/lib/libiniparser.so.0
f6f2a000 f6f30000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f39000 f7009000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f700a000 f703e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7047000 f7083000 r-xp /usr/lib/libSLP-location.so.0.9.24
f708b000 f708e000 r-xp /usr/lib/libbundle.so.0.1.22
f7096000 f709c000 r-xp /usr/lib/libappsvc.so.0.1.0
f70a4000 f70e5000 r-xp /usr/lib/libeina.so.1.7.99
f70ee000 f7105000 r-xp /usr/lib/libecore.so.1.7.99
f711c000 f7125000 r-xp /usr/lib/libvconf.so.0.2.45
f712d000 f7141000 r-xp /lib/libpthread-2.13.so
f714c000 f7159000 r-xp /usr/lib/libaul.so.0.1.0
f7163000 f7165000 r-xp /lib/libdl-2.13.so
f716e000 f7179000 r-xp /lib/libunwind.so.8.0.1
f71a6000 f71ae000 r-xp /lib/libgcc_s-4.6.so.1
f71af000 f72d3000 r-xp /lib/libc-2.13.so
f72e1000 f72e3000 r-xp /usr/lib/libdlog.so.0.0.0
f72eb000 f72f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7300000 f7305000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f730d000 f731c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7324000 f7328000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7331000 f7334000 r-xp /usr/lib/libappcore-agent.so.1.1
f733c000 f733e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7346000 f734a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7352000 f736f000 r-xp /lib/ld-2.13.so
f7378000 f737b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f737b000 f737f000 r-xp /usr/lib/libsys-assert.so
f77be000 f784c000 rw-p [heap]
ff99f000 ff9c0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23059)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf73792b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7310539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70173f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7015c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7021e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7027be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7027dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf705c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70571f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7015c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7021e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7027be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7027dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7059e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf705a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf705e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf73480bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf49ec171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6abf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f6cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f6e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70feca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70f9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70fa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70fa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7332183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73327fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73796a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf71c685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7378fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
02:19.811+0200 W/LOCATION(23109): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:19.861+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:19.861+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:19.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:19.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf736ee00]
04-23 16:02:19.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:19.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:19.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:19.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:19.951+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:19.951+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:19.961+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:19.971+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:19.971+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:19.971+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:19.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:19.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:19.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:19.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:19.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:19.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:19.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:19.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:19.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:19.991+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:20.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.011+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:20.011+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6035672), time2(6029254)
04-23 16:02:20.011+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:20.011+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:20.011+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:20.011+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:20.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.061+0200 W/LOCATION(23109): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:20.061+0200 I/LOCATION(23109): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:20.061+0200 I/LOCATION(23109): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:20.061+0200 I/location(23109): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:20.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:20.061+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:20.161+0200 I/LOCATION(23109): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:20.211+0200 W/AUL     (23109): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:20.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:20.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23109
04-23 16:02:20.221+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:20.221+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:20.221+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:20.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.221+0200 I/utils   (19708): specific action
04-23 16:02:20.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.221+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.221+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:20.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:20.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:20.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:20.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:20.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:20.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.241+0200 I/utils   (22624): specific action
04-23 16:02:20.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.241+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:20.241+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:20.241+0200 I/recorder(22624): guardando datos en local
04-23 16:02:20.241+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:20.241+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:20.241+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:20.241+0200 W/AUL     (23109): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:20.241+0200 I/location(23109): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:20.241+0200 I/location(23109): stopping es.ugr.frailty.location service
04-23 16:02:20.241+0200 E/CAPI_APPFW_APP_CONTROL(23109): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:20.241+0200 E/location(23109): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:20.241+0200 I/CAPI_APPFW_APPLICATION(23109): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:20.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:20.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:20.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:20.261+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:20.281+0200 W/LOCATION(23109): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:20.281+0200 I/LOCATION(23109): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:20.281+0200 I/LOCATION(23109): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:20.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:20.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:20.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:20.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:20.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:20.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:20.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:20.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:20.441+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:20.441+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:20.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:20.441+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:20.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:20.461+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:20.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:20.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:20.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:20.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf736ee00
04-23 16:02:20.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:20.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:20.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a2a0]
04-23 16:02:20.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:20.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:20.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:20.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:20.721+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:20.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:20.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.731+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:20.731+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:20.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:20.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:20.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:20.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:20.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:20.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:20.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:20.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.751+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:20.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:20.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:20.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:20.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a2a0
04-23 16:02:20.881+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:20.881+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:20.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7381a38]
04-23 16:02:20.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:20.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:20.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:20.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:20.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:20.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:20.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.911+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:20.911+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:20.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:20.911+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:20.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:20.911+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:20.911+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:20.911+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:20.911+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:20.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:20.931+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:20.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:20.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:20.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:20.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:20.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7381a38
04-23 16:02:21.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:21.061+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:21.181+0200 W/AUL     (23125): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:21.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:21.181+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:21.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23059
04-23 16:02:21.181+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:21.181+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23059
04-23 16:02:21.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23059)
04-23 16:02:21.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:21.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:21.301+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:21.301+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:21.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:21.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:21.321+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23126
04-23 16:02:21.321+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:21.371+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23126
04-23 16:02:21.371+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23126) type(svcapp) bg(0)
04-23 16:02:21.371+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23126]
04-23 16:02:21.381+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23126)
04-23 16:02:21.381+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:21.381+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:21.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:21.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23126
04-23 16:02:21.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:21.401+0200 E/CAPI_APPFW_APPLICATION(23126): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:21.401+0200 E/CAPI_APPFW_APPLICATION(23126): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:21.411+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23126) was created
04-23 16:02:21.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:21.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23126
04-23 16:02:21.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:21.461+0200 W/LOCATION(23126): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:21.461+0200 E/LOCATION(23126): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:21.461+0200 E/PKGMGR_INFO(23126): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:21.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:21.461+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:21.461+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:21.491+0200 I/LOCATION(23126): location.c: location_new(269) > method: 0
04-23 16:02:21.501+0200 W/LOCATION(23126): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:21.501+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:21.511+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:21.511+0200 W/LOCATION(23126): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:21.521+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:21.531+0200 W/LOCATION(23126): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:21.531+0200 W/LOCATION(23126): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:21.531+0200 W/LOCATION(23126): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:21.531+0200 W/LOCATION(23126): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:21.551+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:21.551+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:21.561+0200 W/LOCATION(23126): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:21.561+0200 W/LOCATION(23126): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:21.561+0200 W/LOCATION(23126): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:21.561+0200 W/LOCATION(23126): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:21.561+0200 W/LOCATION(23126): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:21.581+0200 W/LOCATION(23126): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:21.581+0200 I/LOCATION(23126): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf775ec18
04-23 16:02:21.581+0200 I/LOCATION(23126): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:21.581+0200 I/LOCATION(23126): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf775ec18
04-23 16:02:21.581+0200 I/LOCATION(23126): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:21.591+0200 I/location(23126): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:21.641+0200 I/LOCATION(23126): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:21.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:21.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:21.681+0200 W/LOCATION(23126): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:21.681+0200 W/LOCATION(23126): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:21.681+0200 I/LOCATION(23126): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:21.761+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:21.761+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:21.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:21.761+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:21.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:21.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:21.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:21.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:21.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:21.761+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:21.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:21.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:21.831+0200 W/LOCATION(23126): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:21.831+0200 W/LOCATION(23126): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:21.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:21.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:21.911+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:21.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf738cae8]
04-23 16:02:21.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:21.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:21.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:21.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:21.961+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:21.961+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:21.971+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:21.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:21.981+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:21.981+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:21.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:21.981+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:21.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:21.981+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:21.981+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:21.981+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:21.981+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:21.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:22.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:22.001+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:22.001+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:22.001+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6037664), time2(6029254)
04-23 16:02:22.001+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:22.001+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:22.001+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:22.001+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:22.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:22.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:22.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:22.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:22.091+0200 W/LOCATION(23126): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:22.091+0200 I/LOCATION(23126): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:22.091+0200 I/LOCATION(23126): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:22.091+0200 I/location(23126): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:22.191+0200 I/LOCATION(23126): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:22.241+0200 W/AUL     (23126): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:22.241+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:22.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:22.241+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23126
04-23 16:02:22.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:22.251+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:22.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:22.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.251+0200 I/utils   (19708): specific action
04-23 16:02:22.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.251+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.251+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:22.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:22.251+0200 W/AUL     (23126): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:22.251+0200 I/location(23126): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:22.251+0200 W/CAPI_APPFW_APP_CONTROL(23126): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.251+0200 I/utils   (23126): specific action
04-23 16:02:22.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:22.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:22.261+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.261+0200 I/utils   (22624): specific action
04-23 16:02:22.261+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.261+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.261+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.261+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:22.261+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:22.261+0200 I/recorder(22624): guardando datos en local
04-23 16:02:22.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:22.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:22.261+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:22.261+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:22.261+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:22.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:22.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:22.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:22.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:22.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:22.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:22.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:22.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:22.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:22.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:22.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:22.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:22.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:22.461+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:22.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:22.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:22.891+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:22.891+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.031+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:02:23.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:23.061+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:23.261+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:23.381+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:02:23.381+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:23.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 16:02:23.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:23.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:23.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:23.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:23.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23126
04-23 16:02:23.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.411+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23126)
04-23 16:02:23.411+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:02:23.411+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:23.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:23.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:23.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:23.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:23.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.471+0200 I/LOCATION(23126): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:23.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:02:23.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:23.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23126), cmd(0)
04-23 16:02:23.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:23.661+0200 W/AUL     (23142): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:23.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:23.671+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:23.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23109
04-23 16:02:23.671+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:23.671+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23109
04-23 16:02:23.671+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23109)
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:23.671+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:23.671+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:23.671+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:23.671+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:23.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:23.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:23.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:23.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:23.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf738cae8
04-23 16:02:23.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:23.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:23.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf738c5c8]
04-23 16:02:23.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:23.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:23.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:23.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:23.911+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:23.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:23.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.931+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:23.931+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:23.931+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:23.931+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:23.931+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:23.931+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:23.931+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:23.931+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:23.931+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:23.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.951+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:23.951+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:23.961+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:24.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:24.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:24.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:24.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:24.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:24.061+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf738c5c8
04-23 16:02:24.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:24.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:24.121+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11230596c6f63152449213
