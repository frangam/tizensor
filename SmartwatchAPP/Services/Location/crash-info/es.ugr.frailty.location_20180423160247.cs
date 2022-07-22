S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23433
Date: 2018-04-23 16:02:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf749c52d, r5   = 0xf77adf98
r6   = 0xffaff938, r7   = 0xffaff7e8
r8   = 0xf77aac18, r9   = 0x00000000
r10  = 0xffaff8c4, fp   = 0xffaff938
ip   = 0x00000001, sp   = 0xffafe668
lr   = 0xf749c539, pc   = 0xf75052b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8204 KB
Buffers:     61120 KB
Cached:     227620 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11932 KB
VmRSS:       11932 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23433 TID = 23433
23433 23438 

Maps Information
f4367000 f4b66000 rw-p [stack:23438]
f4b6d000 f4b6f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b77000 f4b7b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b84000 f4b86000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b8e000 f4b91000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ba0000 f4ba5000 r-xp /usr/lib/libsystem.so.0.0.0
f4bb0000 f4bb3000 r-xp /lib/libattr.so.1.1.0
f4bbb000 f4bcb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bd3000 f4bdc000 r-xp /usr/lib/libedbus.so.1.7.99
f4be4000 f4be5000 r-xp /usr/lib/libresponse.so.0.2.96
f4bee000 f4bf3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6495000 f659b000 r-xp /usr/lib/libicuuc.so.57.1
f65b1000 f6739000 r-xp /usr/lib/libicui18n.so.57.1
f6749000 f6756000 r-xp /usr/lib/libail.so.0.1.0
f675f000 f6766000 r-xp /usr/lib/libminizip.so.1.0.0
f676f000 f6918000 r-xp /usr/lib/libcrypto.so.1.0.0
f6938000 f697f000 r-xp /usr/lib/libssl.so.1.0.0
f698b000 f698d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6995000 f699c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69a5000 f69ac000 r-xp /lib/libcrypt-2.13.so
f69dd000 f69e0000 r-xp /lib/libcap.so.2.21
f69e8000 f69ea000 r-xp /usr/lib/libiri.so
f69f2000 f6a3b000 r-xp /usr/lib/libmdm.so.1.2.69
f6a43000 f6a49000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a51000 f6a74000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a7e000 f6a80000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a88000 f6aa5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6aae000 f6ab2000 r-xp /usr/lib/libsmack.so.1.0.0
f6abb000 f6ad4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6add000 f6ae5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aed000 f6af3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6afc000 f6afe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b07000 f6b17000 r-xp /lib/libresolv-2.13.so
f6b1b000 f6b33000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3c000 f6b3e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b46000 f6b60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b68000 f6b97000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ba0000 f6baf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bb9000 f6bc3000 r-xp /usr/lib/libsensord-shared.so
f6bcc000 f6c9f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6caa000 f6cc0000 r-xp /lib/libz.so.1.2.5
f6cc8000 f6ccd000 r-xp /usr/lib/libffi.so.5.0.10
f6cd5000 f6cd6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cde000 f6cee000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cf6000 f6d0f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d17000 f6d19000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d21000 f6d96000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6da0000 f6da6000 r-xp /lib/librt-2.13.so
f6daf000 f6dcd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dd7000 f6dd8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6de0000 f6e03000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e0b000 f6e10000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e18000 f6e42000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e4b000 f6e62000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e6a000 f6ed3000 r-xp /lib/libm-2.13.so
f6edc000 f6f70000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f83000 f6f88000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f90000 f6f97000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f9f000 f6fc9000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd2000 f709e000 r-xp /usr/lib/libxml2.so.2.7.8
f70ab000 f70ad000 r-xp /usr/lib/libiniparser.so.0
f70b6000 f70bc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70c5000 f7195000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7196000 f71ca000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71d3000 f720f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7217000 f721a000 r-xp /usr/lib/libbundle.so.0.1.22
f7222000 f7228000 r-xp /usr/lib/libappsvc.so.0.1.0
f7230000 f7271000 r-xp /usr/lib/libeina.so.1.7.99
f727a000 f7291000 r-xp /usr/lib/libecore.so.1.7.99
f72a8000 f72b1000 r-xp /usr/lib/libvconf.so.0.2.45
f72b9000 f72cd000 r-xp /lib/libpthread-2.13.so
f72d8000 f72e5000 r-xp /usr/lib/libaul.so.0.1.0
f72ef000 f72f1000 r-xp /lib/libdl-2.13.so
f72fa000 f7305000 r-xp /lib/libunwind.so.8.0.1
f7332000 f733a000 r-xp /lib/libgcc_s-4.6.so.1
f733b000 f745f000 r-xp /lib/libc-2.13.so
f746d000 f746f000 r-xp /usr/lib/libdlog.so.0.0.0
f7477000 f7483000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f748c000 f7491000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7499000 f74a8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74b0000 f74b4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74bd000 f74c0000 r-xp /usr/lib/libappcore-agent.so.1.1
f74c8000 f74ca000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74d2000 f74d6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74de000 f74fb000 r-xp /lib/ld-2.13.so
f7504000 f7507000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7507000 f750b000 r-xp /usr/lib/libsys-assert.so
f777a000 f7804000 rw-p [heap]
ffae1000 ffb02000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23433)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75052b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf749c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71a33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71e875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71e31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71e5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71e6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71ea8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74d40bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b78171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c4b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70f8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70fa7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf728aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7285b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72865a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7286879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74be183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74be7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75056a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf735285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7504fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
1+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:58.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:58.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:58.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:58.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:58.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:58.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:58.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:58.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:58.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:58.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.151+0200 W/LOCATION(23599): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:58.151+0200 I/LOCATION(23599): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:58.151+0200 I/LOCATION(23599): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:58.151+0200 I/location(23599): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:58.261+0200 I/LOCATION(23599): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:58.311+0200 W/AUL     (23599): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:58.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23599
04-23 16:02:58.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:58.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.341+0200 I/utils   (19708): specific action
04-23 16:02:58.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.341+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:58.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:58.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:58.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:58.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:58.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:58.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:58.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:58.391+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.391+0200 I/utils   (22624): specific action
04-23 16:02:58.391+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.391+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.391+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.391+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:58.391+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:58.391+0200 I/recorder(22624): guardando datos en local
04-23 16:02:58.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:58.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:58.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:58.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(22624), cmd(0)
04-23 16:02:58.391+0200 W/AUL     (23599): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:58.391+0200 I/location(23599): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:58.391+0200 I/location(23599): stopping es.ugr.frailty.location service
04-23 16:02:58.391+0200 E/CAPI_APPFW_APP_CONTROL(23599): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:58.391+0200 E/location(23599): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:58.391+0200 I/CAPI_APPFW_APPLICATION(23599): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:58.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:58.391+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:58.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:58.391+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:58.391+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:58.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:58.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:58.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:58.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:58.451+0200 W/LOCATION(23599): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:58.451+0200 I/LOCATION(23599): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:58.451+0200 I/LOCATION(23599): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:58.531+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:58.531+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:58.531+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:58.531+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:58.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:58.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:58.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:58.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73817d0
04-23 16:02:58.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73758e8]
04-23 16:02:58.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:58.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:58.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:58.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:58.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:58.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:58.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.781+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:58.781+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:58.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:58.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:58.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:58.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:58.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:58.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:58.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:58.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:58.801+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:58.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:58.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:58.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:58.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:58.901+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73758e8
04-23 16:02:58.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361790]
04-23 16:02:58.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:58.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:58.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:58.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:59.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:59.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:59.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:59.031+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:59.031+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:59.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:59.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:59.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:59.031+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:59.031+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:59.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:59.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:59.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:59.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:59.031+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:59.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:59.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:59.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23599
04-23 16:02:59.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:59.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23599)
04-23 16:02:59.041+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:59.041+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:59.051+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:59.051+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:59.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:59.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:59.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:59.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:59.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:59.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7361790
04-23 16:02:59.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:02:59.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:59.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23599), cmd(0)
04-23 16:02:59.281+0200 W/AUL     (23616): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:59.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:59.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:59.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23577
04-23 16:02:59.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:59.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23577
04-23 16:02:59.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23577)
04-23 16:02:59.371+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-23 16:02:59.371+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 16:02:59.371+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [6075.039361] dpms[3 -> 0]sync[0]
04-23 16:02:59.371+0200 I/TDM     ( 1785): 
04-23 16:02:59.371+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [6075.039487] dpms[0 -> 0]done
04-23 16:02:59.371+0200 I/TDM     ( 1785): 
04-23 16:02:59.371+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [86231]ms
04-23 16:02:59.371+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): gesture.c: _apps_status_get(128) > apps status:0
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:1 info->offtime:86231
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:02:59.381+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: RESUME State: PAUSED
04-23 16:02:59.381+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): main.c: _appcore_resume_cb(479) > appcore resume
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): main.c: home_resume(531) > clock/widget resumed
04-23 16:02:59.381+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:02:59.381+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-23 16:02:59.381+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 16:02:59.381+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.381+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:02:59.381+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 16:02:59.381+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-23 16:02:59.381+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-23 16:02:59.381+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.381+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:02:59.381+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 16:02:59.381+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-23 16:02:59.401+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -136540160[0;m
04-23 16:02:59.401+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-23 16:02:59.401+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 16:02:59.401+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 16:02:59.401+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(fg) type(watchapp)
04-23 16:02:59.401+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppResume(560) > 
04-23 16:02:59.401+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.401+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:02:59.401+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 16:02:59.401+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 16:02:59.401+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(55), length(2)
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 55%
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 55, isCharging: 0
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_55
04-23 16:02:59.411+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 16:02:59.421+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:02:59.421+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:02:59.431+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:02:59.431+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 16:02:59.441+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 16:02:59.441+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [6075.102527] layer(0x5ac2c0) not usable
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [6075.102558] layer(0x5ac2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [6075.102575] layer[0x5abe10]zpos[1]
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [6075.102634] layer(0x5ac250) not usable
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [6075.102646] layer(0x5ac250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [6075.102661] layer[0x5abcf0]zpos[0]
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [6075.102685] layer(0x5ac310) not usable
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [6075.102696] layer(0x5ac310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:02:59.441+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [6075.102710] layer[0x5abf30]zpos[2]
04-23 16:02:59.441+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 16:02:59.441+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:02:59.441+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 16:02:59.441+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 16:02:59.441+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -145282292[0;m
04-23 16:02:59.441+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 16:02:59.441+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 16:02:59.441+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 16:02:59.441+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 16:02:59.451+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:02:59.451+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:02:59.451+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:02:59.451+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 16:02:59.451+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 16:02:59.451+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:02:59.451+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 16:02:59.451+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 16:02:59.501+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 16:02:59.581+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 16:02:59.581+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 0
04-23 16:02:59.581+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 16:02:59.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:02:59.641+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 16:02:59.641+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 16:02:59.651+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 16:02:59.651+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 16:02:59.671+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:02:59.681+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:02:59.701+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 16:02:59.701+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 16:02:59.701+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 16:02:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-23 16:02:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-23 16:02:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_period error
04-23 16:02:59.721+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
04-23 16:02:59.721+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
04-23 16:02:59.721+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : inactive_test_mode_on error
04-23 16:02:59.751+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:02:59.771+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:02:59.781+0200 W/SHealthCommon( 3091): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 16:02:59.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:02:59.801+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 16:02:59.811+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 16:02:59.831+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 16:02:59.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:02:59.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:00.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:00.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:03:00.381+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:03:00.391+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.391+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 16:03:00.391+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 16:03:00.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:00.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 16:03:00.391+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:00.401+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:03:00.401+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:03:00.401+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 16:03:00.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 16:03:00.411+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 16:03:00.411+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 16:03:00.411+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 16:03:00.411+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.411+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 16:03:00.411+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 16:03:00.411+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 16:03:00.411+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 16:03:00.411+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 16:03:00.411+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 16:03:00.411+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.411+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.421+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 16:03:00.421+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 16:03:00.421+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 16:03:00.421+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:03:00.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:03:00.491+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11234336c6f63152449216
