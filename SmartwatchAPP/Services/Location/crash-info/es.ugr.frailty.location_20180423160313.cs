S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23848
Date: 2018-04-23 16:03:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70f052d, r5   = 0xf781df98
r6   = 0xff86b528, r7   = 0xff86b3d8
r8   = 0xf781ac18, r9   = 0x00000000
r10  = 0xff86b4b4, fp   = 0xff86b528
ip   = 0x00000001, sp   = 0xff86a258
lr   = 0xf70f0539, pc   = 0xf71592b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9672 KB
Buffers:     61412 KB
Cached:     224660 KB
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
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23848 TID = 23848
23848 23854 

Maps Information
f3fbb000 f47ba000 rw-p [stack:23854]
f47c1000 f47c3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47cb000 f47cf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47d8000 f47da000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47e2000 f47e5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47f4000 f47f9000 r-xp /usr/lib/libsystem.so.0.0.0
f4804000 f4807000 r-xp /lib/libattr.so.1.1.0
f480f000 f481f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4827000 f4830000 r-xp /usr/lib/libedbus.so.1.7.99
f4838000 f4839000 r-xp /usr/lib/libresponse.so.0.2.96
f4842000 f4847000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60e9000 f61ef000 r-xp /usr/lib/libicuuc.so.57.1
f6205000 f638d000 r-xp /usr/lib/libicui18n.so.57.1
f639d000 f63aa000 r-xp /usr/lib/libail.so.0.1.0
f63b3000 f63ba000 r-xp /usr/lib/libminizip.so.1.0.0
f63c3000 f656c000 r-xp /usr/lib/libcrypto.so.1.0.0
f658c000 f65d3000 r-xp /usr/lib/libssl.so.1.0.0
f65df000 f65e1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65e9000 f65f0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65f9000 f6600000 r-xp /lib/libcrypt-2.13.so
f6631000 f6634000 r-xp /lib/libcap.so.2.21
f663c000 f663e000 r-xp /usr/lib/libiri.so
f6646000 f668f000 r-xp /usr/lib/libmdm.so.1.2.69
f6697000 f669d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66a5000 f66c8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66d2000 f66d4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66dc000 f66f9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6702000 f6706000 r-xp /usr/lib/libsmack.so.1.0.0
f670f000 f6728000 r-xp /usr/lib/libnetwork.so.0.0.0
f6731000 f6739000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6741000 f6747000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6750000 f6752000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f675b000 f676b000 r-xp /lib/libresolv-2.13.so
f676f000 f6787000 r-xp /usr/lib/liblzma.so.5.0.3
f6790000 f6792000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f679a000 f67b4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67bc000 f67eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67f4000 f6803000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f680d000 f6817000 r-xp /usr/lib/libsensord-shared.so
f6820000 f68f3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68fe000 f6914000 r-xp /lib/libz.so.1.2.5
f691c000 f6921000 r-xp /usr/lib/libffi.so.5.0.10
f6929000 f692a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6932000 f6942000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f694a000 f6963000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f696b000 f696d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6975000 f69ea000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69f4000 f69fa000 r-xp /lib/librt-2.13.so
f6a03000 f6a21000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a2b000 f6a2c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a34000 f6a57000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a5f000 f6a64000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a6c000 f6a96000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a9f000 f6ab6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6abe000 f6b27000 r-xp /lib/libm-2.13.so
f6b30000 f6bc4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bd7000 f6bdc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6be4000 f6beb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bf3000 f6c1d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c26000 f6cf2000 r-xp /usr/lib/libxml2.so.2.7.8
f6cff000 f6d01000 r-xp /usr/lib/libiniparser.so.0
f6d0a000 f6d10000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d19000 f6de9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dea000 f6e1e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e27000 f6e63000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e6b000 f6e6e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e76000 f6e7c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e84000 f6ec5000 r-xp /usr/lib/libeina.so.1.7.99
f6ece000 f6ee5000 r-xp /usr/lib/libecore.so.1.7.99
f6efc000 f6f05000 r-xp /usr/lib/libvconf.so.0.2.45
f6f0d000 f6f21000 r-xp /lib/libpthread-2.13.so
f6f2c000 f6f39000 r-xp /usr/lib/libaul.so.0.1.0
f6f43000 f6f45000 r-xp /lib/libdl-2.13.so
f6f4e000 f6f59000 r-xp /lib/libunwind.so.8.0.1
f6f86000 f6f8e000 r-xp /lib/libgcc_s-4.6.so.1
f6f8f000 f70b3000 r-xp /lib/libc-2.13.so
f70c1000 f70c3000 r-xp /usr/lib/libdlog.so.0.0.0
f70cb000 f70d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70e0000 f70e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70ed000 f70fc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7104000 f7108000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7111000 f7114000 r-xp /usr/lib/libappcore-agent.so.1.1
f711c000 f711e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7126000 f712a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7132000 f714f000 r-xp /lib/ld-2.13.so
f7158000 f715b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f715b000 f715f000 r-xp /usr/lib/libsys-assert.so
f77ea000 f785b000 rw-p [heap]
ff84c000 ff86d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23848)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71592b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70f0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6df73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6df5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e3c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e371f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6df5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e39e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e3a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e3e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71280bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47cc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf689f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d4cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d4e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6edeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ed9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eda5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eda879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7112183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71127fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71596a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6fa685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7158fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
et_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:25.971+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:25.971+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:25.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:25.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:25.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:25.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:25.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:25.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:25.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:25.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:25.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:25.991+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:25.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.051+0200 W/LOCATION(24000): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:26.051+0200 I/LOCATION(24000): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:26.061+0200 I/LOCATION(24000): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:26.061+0200 I/location(24000): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:26.061+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:26.111+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:26.111+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:26.151+0200 I/LOCATION(24000): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:26.171+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:26.171+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6101836), time2(6091130)
04-23 16:03:26.171+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:03:26.171+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:26.171+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:26.171+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:26.201+0200 W/AUL     (24000): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:26.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:26.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24000
04-23 16:03:26.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:26.211+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:26.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:26.211+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.211+0200 I/utils   (19708): specific action
04-23 16:03:26.211+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.211+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.211+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.211+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:26.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:26.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:26.221+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 I/utils   (22624): specific action
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:26.231+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:26.231+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:26.231+0200 I/recorder(22624): guardando datos en local
04-23 16:03:26.231+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:26.231+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:26.231+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:26.231+0200 W/AUL     (24000): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:26.231+0200 I/location(24000): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:26.231+0200 W/CAPI_APPFW_APP_CONTROL(24000): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:26.231+0200 I/utils   (24000): specific action
04-23 16:03:26.311+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:26.311+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:26.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:26.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:26.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:26.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:26.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:26.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:26.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:26.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:26.461+0200 I/LOCATION(24000): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:26.511+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:26.511+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:26.621+0200 W/AUL     (24010): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:26.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:26.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:26.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23985
04-23 16:03:26.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:26.621+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23985
04-23 16:03:26.621+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23985)
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:26.631+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:26.631+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:26.631+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:26.631+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:26.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:26.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:26.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:26.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2c3b8
04-23 16:03:26.711+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:26.711+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:26.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01a60]
04-23 16:03:26.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:26.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:26.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:26.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:26.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:26.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:26.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.791+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:26.791+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:26.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:26.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:26.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:26.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:26.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:26.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:26.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:26.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:26.811+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:26.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.911+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:26.911+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:26.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:26.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:26.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:26.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:26.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01a60
04-23 16:03:27.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03f70]
04-23 16:03:27.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:27.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:27.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:27.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:27.041+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:27.041+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:27.051+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:27.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:27.061+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:27.061+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:27.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:27.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:27.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:27.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:27.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:27.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:27.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:27.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:27.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:27.071+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:27.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:27.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:27.121+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:27.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:27.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:27.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:27.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:27.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03f70
04-23 16:03:27.311+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:03:27.311+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:27.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:27.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:27.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:27.321+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:27.321+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24021
04-23 16:03:27.321+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:27.371+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24021
04-23 16:03:27.371+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24021) type(svcapp) bg(0)
04-23 16:03:27.381+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24021]
04-23 16:03:27.391+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24021)
04-23 16:03:27.391+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:27.391+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:27.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:27.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24021
04-23 16:03:27.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:27.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24021
04-23 16:03:27.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:27.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:27.461+0200 E/CAPI_APPFW_APPLICATION(24021): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:27.461+0200 E/CAPI_APPFW_APPLICATION(24021): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:27.471+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24021) was created
04-23 16:03:27.511+0200 W/LOCATION(24021): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:27.511+0200 E/LOCATION(24021): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:27.511+0200 E/PKGMGR_INFO(24021): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:27.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:27.521+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:27.521+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:27.551+0200 I/LOCATION(24021): location.c: location_new(269) > method: 0
04-23 16:03:27.551+0200 W/LOCATION(24021): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:27.561+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:27.561+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:27.561+0200 W/LOCATION(24021): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:27.571+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:27.571+0200 W/LOCATION(24021): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:27.571+0200 W/LOCATION(24021): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:27.571+0200 W/LOCATION(24021): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:27.571+0200 W/LOCATION(24021): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:27.601+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:27.601+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:27.611+0200 W/LOCATION(24021): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:27.611+0200 W/LOCATION(24021): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:27.611+0200 W/LOCATION(24021): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:27.611+0200 W/LOCATION(24021): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:27.611+0200 W/LOCATION(24021): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:27.631+0200 W/LOCATION(24021): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:27.631+0200 I/LOCATION(24021): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b24c18
04-23 16:03:27.631+0200 I/LOCATION(24021): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:27.631+0200 I/LOCATION(24021): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b24c18
04-23 16:03:27.631+0200 I/LOCATION(24021): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:27.641+0200 I/location(24021): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:27.681+0200 I/LOCATION(24021): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:27.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:27.721+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:27.731+0200 W/LOCATION(24021): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:27.731+0200 W/LOCATION(24021): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:27.731+0200 I/LOCATION(24021): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:27.831+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:27.831+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:27.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:27.831+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:27.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:27.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:27.831+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:27.831+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:27.831+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:27.831+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:27.831+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:27.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:27.911+0200 W/LOCATION(24021): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:27.911+0200 W/LOCATION(24021): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:27.911+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:27.911+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:28.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01310]
04-23 16:03:28.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:28.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:28.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:28.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:28.051+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:28.051+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:28.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.061+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:28.061+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:28.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:28.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:28.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:28.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:28.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:28.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:28.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:28.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:28.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:28.111+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:28.111+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:28.161+0200 W/LOCATION(24021): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:28.161+0200 I/LOCATION(24021): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:28.161+0200 I/LOCATION(24021): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:28.161+0200 I/location(24021): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:28.251+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:28.251+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6103912), time2(6101836)
04-23 16:03:28.251+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:28.251+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:28.251+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:28.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:28.261+0200 I/LOCATION(24021): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:28.331+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:28.331+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:28.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:28.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:28.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:28.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:28.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:28.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:28.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:28.431+0200 W/AUL     (24021): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:28.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:28.441+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24021
04-23 16:03:28.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:28.451+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:28.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:28.451+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.451+0200 I/utils   (19708): specific action
04-23 16:03:28.451+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.451+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.451+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.451+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:28.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:28.451+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:28.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:28.461+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:28.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:28.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.461+0200 I/utils   (22624): specific action
04-23 16:03:28.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.461+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:28.461+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:28.471+0200 I/recorder(22624): guardando datos en local
04-23 16:03:28.471+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:28.471+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:28.471+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:28.471+0200 W/AUL     (24021): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:28.471+0200 I/location(24021): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:28.471+0200 I/location(24021): stopping es.ugr.frailty.location service
04-23 16:03:28.471+0200 E/CAPI_APPFW_APP_CONTROL(24021): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:28.471+0200 E/location(24021): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:28.471+0200 I/CAPI_APPFW_APPLICATION(24021): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:28.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:28.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:28.511+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:28.511+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.551+0200 W/LOCATION(24021): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:28.551+0200 I/LOCATION(24021): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:28.551+0200 I/LOCATION(24021): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:28.631+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:28.631+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:28.631+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:28.631+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:28.711+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:28.711+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.741+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:28.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:28.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:28.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:28.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01310
04-23 16:03:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03690]
04-23 16:03:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:28.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:28.871+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:28.871+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:28.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.901+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:28.901+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:28.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:28.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:28.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:28.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:28.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:28.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:28.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:28.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:28.911+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:28.911+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:28.911+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:28.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:28.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:29.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03690
04-23 16:03:29.111+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:29.111+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:29.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18800]
04-23 16:03:29.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:29.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:29.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:29.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:29.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:29.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:29.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:29.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:29.181+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:29.181+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:29.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:29.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:29.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:29.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:29.181+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:29.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:29.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:29.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:29.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:29.201+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:29.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:29.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:29.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:29.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:29.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:29.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18800
04-23 16:03:29.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:29.331+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:29:324,74
04-23 16:03:29.391+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:29.391+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:29.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:29.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:29.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24021
04-23 16:03:29.401+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24021)
04-23 16:03:29.401+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:29.401+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:29.411+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:03:29.411+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:29.411+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24021), cmd(0)
04-23 16:03:29.431+0200 W/AUL     (24031): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:29.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:29.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:29.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24000
04-23 16:03:29.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:29.441+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24000
04-23 16:03:29.441+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24000)
04-23 16:03:29.441+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11238486c6f63152449219
