S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23965
Date: 2018-04-23 16:03:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf712252d, r5   = 0xf72a2958
r6   = 0xffae3d68, r7   = 0xffae3c18
r8   = 0xf72b5c18, r9   = 0x00000000
r10  = 0xffae3cf4, fp   = 0xffae3d68
ip   = 0x00000001, sp   = 0xffae2a98
lr   = 0xf7122539, pc   = 0xf718b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11336 KB
Buffers:     61520 KB
Cached:     224996 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11852 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23965 TID = 23965
23965 23972 

Maps Information
f3fed000 f47ec000 rw-p [stack:23972]
f47f3000 f47f5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47fd000 f4801000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f480a000 f480c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4814000 f4817000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4826000 f482b000 r-xp /usr/lib/libsystem.so.0.0.0
f4836000 f4839000 r-xp /lib/libattr.so.1.1.0
f4841000 f4851000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4859000 f4862000 r-xp /usr/lib/libedbus.so.1.7.99
f486a000 f486b000 r-xp /usr/lib/libresponse.so.0.2.96
f4874000 f4879000 r-xp /usr/lib/libproc-stat.so.0.2.96
f611b000 f6221000 r-xp /usr/lib/libicuuc.so.57.1
f6237000 f63bf000 r-xp /usr/lib/libicui18n.so.57.1
f63cf000 f63dc000 r-xp /usr/lib/libail.so.0.1.0
f63e5000 f63ec000 r-xp /usr/lib/libminizip.so.1.0.0
f63f5000 f659e000 r-xp /usr/lib/libcrypto.so.1.0.0
f65be000 f6605000 r-xp /usr/lib/libssl.so.1.0.0
f6611000 f6613000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f661b000 f6622000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f662b000 f6632000 r-xp /lib/libcrypt-2.13.so
f6663000 f6666000 r-xp /lib/libcap.so.2.21
f666e000 f6670000 r-xp /usr/lib/libiri.so
f6678000 f66c1000 r-xp /usr/lib/libmdm.so.1.2.69
f66c9000 f66cf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66d7000 f66fa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6704000 f6706000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f670e000 f672b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6734000 f6738000 r-xp /usr/lib/libsmack.so.1.0.0
f6741000 f675a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6763000 f676b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6773000 f6779000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6782000 f6784000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f678d000 f679d000 r-xp /lib/libresolv-2.13.so
f67a1000 f67b9000 r-xp /usr/lib/liblzma.so.5.0.3
f67c2000 f67c4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67cc000 f67e6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67ee000 f681d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6826000 f6835000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f683f000 f6849000 r-xp /usr/lib/libsensord-shared.so
f6852000 f6925000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6930000 f6946000 r-xp /lib/libz.so.1.2.5
f694e000 f6953000 r-xp /usr/lib/libffi.so.5.0.10
f695b000 f695c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6964000 f6974000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f697c000 f6995000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f699d000 f699f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69a7000 f6a1c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a26000 f6a2c000 r-xp /lib/librt-2.13.so
f6a35000 f6a53000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a5d000 f6a5e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a66000 f6a89000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a91000 f6a96000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a9e000 f6ac8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ad1000 f6ae8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6af0000 f6b59000 r-xp /lib/libm-2.13.so
f6b62000 f6bf6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c09000 f6c0e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c16000 f6c1d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c25000 f6c4f000 r-xp /usr/lib/libsensor.so.1.9.6
f6c58000 f6d24000 r-xp /usr/lib/libxml2.so.2.7.8
f6d31000 f6d33000 r-xp /usr/lib/libiniparser.so.0
f6d3c000 f6d42000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d4b000 f6e1b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e1c000 f6e50000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e59000 f6e95000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e9d000 f6ea0000 r-xp /usr/lib/libbundle.so.0.1.22
f6ea8000 f6eae000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eb6000 f6ef7000 r-xp /usr/lib/libeina.so.1.7.99
f6f00000 f6f17000 r-xp /usr/lib/libecore.so.1.7.99
f6f2e000 f6f37000 r-xp /usr/lib/libvconf.so.0.2.45
f6f3f000 f6f53000 r-xp /lib/libpthread-2.13.so
f6f5e000 f6f6b000 r-xp /usr/lib/libaul.so.0.1.0
f6f75000 f6f77000 r-xp /lib/libdl-2.13.so
f6f80000 f6f8b000 r-xp /lib/libunwind.so.8.0.1
f6fb8000 f6fc0000 r-xp /lib/libgcc_s-4.6.so.1
f6fc1000 f70e5000 r-xp /lib/libc-2.13.so
f70f3000 f70f5000 r-xp /usr/lib/libdlog.so.0.0.0
f70fd000 f7109000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7112000 f7117000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f711f000 f712e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7136000 f713a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7143000 f7146000 r-xp /usr/lib/libappcore-agent.so.1.1
f714e000 f7150000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7158000 f715c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7164000 f7181000 r-xp /lib/ld-2.13.so
f718a000 f718d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f718d000 f7191000 r-xp /usr/lib/libsys-assert.so
f7285000 f730e000 rw-p [heap]
ffac5000 ffae6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23965)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf718b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7122539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e293f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e27c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e33e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e39be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e39dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e6e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e691f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e27c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e33e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e39be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e39dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e6be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e6c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e708d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf715a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47fe171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68d1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d7efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d807a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f10ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f0bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f0c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f0c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7144183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71447fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf718b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6fd885c) [/lib/libc.so.6] + 0x1785c
29: (0xf718afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
rvicio de localización
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
04-23 16:03:29.441+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11238486c6f631524492193
04-23 16:03:29.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:29.521+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:29:525,74
04-23 16:03:29.711+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:29.721+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:29:724,74
04-23 16:03:29.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:29.921+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:29:925,74
04-23 16:03:30.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:30.121+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:30:125,74
04-23 16:03:30.311+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:30.331+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:30:324,73
04-23 16:03:30.481+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:30.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:30.521+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:30:525,74
04-23 16:03:30.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:30.721+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:30:725,73
04-23 16:03:30.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:30.921+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:30:925,73
04-23 16:03:31.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:31.121+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:31:126,73
04-23 16:03:31.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:31.321+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:31:325,73
04-23 16:03:31.381+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11239656c6f63152449220
