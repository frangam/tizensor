S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20588
Date: 2018-04-23 15:58:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf712052d, r5   = 0xf7526f98
r6   = 0xffc20b18, r7   = 0xffc209c8
r8   = 0xf7523c18, r9   = 0x00000000
r10  = 0xffc20aa4, fp   = 0xffc20b18
ip   = 0x00000001, sp   = 0xffc1f848
lr   = 0xf7120539, pc   = 0xf71892b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9744 KB
Buffers:     58584 KB
Cached:     233220 KB
VmPeak:      53564 KB
VmSize:      53560 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12200 KB
VmRSS:       12200 KB
VmData:      11288 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20588 TID = 20588
20588 20591 

Maps Information
f3feb000 f47ea000 rw-p [stack:20591]
f47f1000 f47f3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47fb000 f47ff000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4808000 f480a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4812000 f4815000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4824000 f4829000 r-xp /usr/lib/libsystem.so.0.0.0
f4834000 f4837000 r-xp /lib/libattr.so.1.1.0
f483f000 f484f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4857000 f4860000 r-xp /usr/lib/libedbus.so.1.7.99
f4868000 f4869000 r-xp /usr/lib/libresponse.so.0.2.96
f4872000 f4877000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6119000 f621f000 r-xp /usr/lib/libicuuc.so.57.1
f6235000 f63bd000 r-xp /usr/lib/libicui18n.so.57.1
f63cd000 f63da000 r-xp /usr/lib/libail.so.0.1.0
f63e3000 f63ea000 r-xp /usr/lib/libminizip.so.1.0.0
f63f3000 f659c000 r-xp /usr/lib/libcrypto.so.1.0.0
f65bc000 f6603000 r-xp /usr/lib/libssl.so.1.0.0
f660f000 f6611000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6619000 f6620000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6629000 f6630000 r-xp /lib/libcrypt-2.13.so
f6661000 f6664000 r-xp /lib/libcap.so.2.21
f666c000 f666e000 r-xp /usr/lib/libiri.so
f6676000 f66bf000 r-xp /usr/lib/libmdm.so.1.2.69
f66c7000 f66cd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66d5000 f66f8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6702000 f6704000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f670c000 f6729000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6732000 f6736000 r-xp /usr/lib/libsmack.so.1.0.0
f673f000 f6758000 r-xp /usr/lib/libnetwork.so.0.0.0
f6761000 f6769000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6771000 f6777000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6780000 f6782000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f678b000 f679b000 r-xp /lib/libresolv-2.13.so
f679f000 f67b7000 r-xp /usr/lib/liblzma.so.5.0.3
f67c0000 f67c2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67ca000 f67e4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67ec000 f681b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6824000 f6833000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f683d000 f6847000 r-xp /usr/lib/libsensord-shared.so
f6850000 f6923000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f692e000 f6944000 r-xp /lib/libz.so.1.2.5
f694c000 f6951000 r-xp /usr/lib/libffi.so.5.0.10
f6959000 f695a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6962000 f6972000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f697a000 f6993000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f699b000 f699d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69a5000 f6a1a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a24000 f6a2a000 r-xp /lib/librt-2.13.so
f6a33000 f6a51000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a5b000 f6a5c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a64000 f6a87000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a8f000 f6a94000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a9c000 f6ac6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6acf000 f6ae6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aee000 f6b57000 r-xp /lib/libm-2.13.so
f6b60000 f6bf4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c07000 f6c0c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c14000 f6c1b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c23000 f6c4d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c56000 f6d22000 r-xp /usr/lib/libxml2.so.2.7.8
f6d2f000 f6d31000 r-xp /usr/lib/libiniparser.so.0
f6d3a000 f6d40000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d49000 f6e19000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e1a000 f6e4e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e57000 f6e93000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e9b000 f6e9e000 r-xp /usr/lib/libbundle.so.0.1.22
f6ea6000 f6eac000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eb4000 f6ef5000 r-xp /usr/lib/libeina.so.1.7.99
f6efe000 f6f15000 r-xp /usr/lib/libecore.so.1.7.99
f6f2c000 f6f35000 r-xp /usr/lib/libvconf.so.0.2.45
f6f3d000 f6f51000 r-xp /lib/libpthread-2.13.so
f6f5c000 f6f69000 r-xp /usr/lib/libaul.so.0.1.0
f6f73000 f6f75000 r-xp /lib/libdl-2.13.so
f6f7e000 f6f89000 r-xp /lib/libunwind.so.8.0.1
f6fb6000 f6fbe000 r-xp /lib/libgcc_s-4.6.so.1
f6fbf000 f70e3000 r-xp /lib/libc-2.13.so
f70f1000 f70f3000 r-xp /usr/lib/libdlog.so.0.0.0
f70fb000 f7107000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7110000 f7115000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f711d000 f712c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7134000 f7138000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7141000 f7144000 r-xp /usr/lib/libappcore-agent.so.1.1
f714c000 f714e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7156000 f715a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7162000 f717f000 r-xp /lib/ld-2.13.so
f7188000 f718b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f718b000 f718f000 r-xp /usr/lib/libsys-assert.so
f74f3000 f757e000 rw-p [heap]
ffc02000 ffc23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20588)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71892b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7120539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e273f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e25c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e31e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e37be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e37dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e6c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e671f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e25c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e31e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e37be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e37dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e69e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e6a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e6e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71580bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47fc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68cf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d7cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d7e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f0eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f09b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f0a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f0a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7142183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71427fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71896a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6fd685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7188fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.491+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.491+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.491+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:37.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:37.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:37.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:37.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:37.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:37.501+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.501+0200 I/utils   (19713): specific action
04-23 15:58:37.501+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.501+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.501+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.501+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:37.501+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:37.501+0200 I/recorder(19713): guardando datos en local
04-23 15:58:37.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:37.501+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:37.501+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:37.501+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:37.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:37.501+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:37.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19713), cmd(0)
04-23 15:58:37.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:37.551+0200 W/LOCATION(20694): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:37.551+0200 I/LOCATION(20694): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:37.551+0200 I/LOCATION(20694): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:37.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:37:561,79
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:37.661+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:37.661+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:37.661+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:37.661+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:37.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:37.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:37:760,80
04-23 15:58:37.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:37.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:37.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:37.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:37.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e37d60
04-23 15:58:37.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361180]
04-23 15:58:37.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:37.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:37.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:37.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:37.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:37.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:37.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:37.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:37.911+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:37.911+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:37.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:37.911+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:37.911+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:37.911+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:37.911+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:37.911+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:37.911+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:37.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:37.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:37.931+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:37.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:37.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:37.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:37:960,79
04-23 15:58:38.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:38.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:38.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:38.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:38.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:38.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7361180
04-23 15:58:38.161+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:38.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73709b0]
04-23 15:58:38.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:38.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:38.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:38.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:38.171+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:38.171+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:38.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:38.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:38.181+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:38.181+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:38.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:38.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:38.181+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:38.181+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:38.181+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:38.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:38.181+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:38.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:38.191+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:38:167,80
04-23 15:58:38.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:38.201+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:38.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:38.241+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:38.241+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:38.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:38.241+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:38.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20694
04-23 15:58:38.251+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20694)
04-23 15:58:38.251+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:38.251+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:38.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:38.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:38.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:38.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:38.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73709b0
04-23 15:58:38.391+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:38.391+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:38:395,80
04-23 15:58:38.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:58:38.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:38.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20694), cmd(0)
04-23 15:58:38.441+0200 W/AUL     (20713): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20651
04-23 15:58:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:38.451+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20651
04-23 15:58:38.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20651)
04-23 15:58:38.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:38.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:38:560,81
04-23 15:58:38.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:38.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:38:760,81
04-23 15:58:38.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:38.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:38:960,81
04-23 15:58:39.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:39.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:39:160,81
04-23 15:58:39.361+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:39.361+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:39:366,82
04-23 15:58:39.491+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:39.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:39.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:39:561,82
04-23 15:58:39.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:39.761+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:39:760,82
04-23 15:58:39.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:39.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:39:961,82
04-23 15:58:40.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:40.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:40:161,83
04-23 15:58:40.261+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:40.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:40.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:40.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:40.281+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20721
04-23 15:58:40.281+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:40.331+0200 E/CAPI_APPFW_APPLICATION(20721): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:40.331+0200 E/CAPI_APPFW_APPLICATION(20721): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:40.351+0200 W/LOCATION(20721): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:40.351+0200 E/LOCATION(20721): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:40.351+0200 E/PKGMGR_INFO(20721): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:40.361+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:40.371+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20721
04-23 15:58:40.371+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20721) type(svcapp) bg(0)
04-23 15:58:40.371+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20721) was created
04-23 15:58:40.371+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20721)
04-23 15:58:40.371+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:40.371+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:40.371+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:40.371+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:40:379,83
04-23 15:58:40.371+0200 I/LOCATION(20721): location.c: location_new(269) > method: 0
04-23 15:58:40.381+0200 W/LOCATION(20721): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:40.381+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:40.381+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:40.391+0200 W/LOCATION(20721): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:40.391+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:40.391+0200 W/LOCATION(20721): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:40.391+0200 W/LOCATION(20721): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:40.391+0200 W/LOCATION(20721): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:40.391+0200 W/LOCATION(20721): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:40.411+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:40.421+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:40.421+0200 W/LOCATION(20721): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:40.421+0200 W/LOCATION(20721): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:40.431+0200 W/LOCATION(20721): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:40.431+0200 W/LOCATION(20721): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:40.431+0200 W/LOCATION(20721): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:40.441+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20721]
04-23 15:58:40.451+0200 W/LOCATION(20721): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:40.451+0200 I/LOCATION(20721): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf783bc18
04-23 15:58:40.451+0200 I/LOCATION(20721): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:40.451+0200 I/LOCATION(20721): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf783bc18
04-23 15:58:40.451+0200 I/LOCATION(20721): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:40.461+0200 I/location(20721): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:40.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:40.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20721
04-23 15:58:40.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:40.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20721
04-23 15:58:40.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:40.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:40.531+0200 I/LOCATION(20721): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:40.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:40.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:40:561,83
04-23 15:58:40.561+0200 W/LOCATION(20721): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:40.561+0200 W/LOCATION(20721): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:40.561+0200 I/LOCATION(20721): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:40.641+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:40.641+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:40.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:40.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:40.651+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:40.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:40.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:40.651+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:40.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:40.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:40.651+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:40.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:40.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:40.721+0200 W/LOCATION(20721): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:40.721+0200 W/LOCATION(20721): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:40.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:40.761+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:40:762,83
04-23 15:58:40.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:40.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73762e8]
04-23 15:58:40.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:40.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:40.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:40.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:40.881+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:40.881+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:40.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:40.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:40.901+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:40.901+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:40.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:40.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:40.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:40.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:40.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:40.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:40.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:40.911+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:40.911+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5816570), time2(5810320)
04-23 15:58:40.911+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:40.911+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:40.911+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:40.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:40.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:40.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:40.911+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:40.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:40.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:40.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:40:961,83
04-23 15:58:40.961+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:40.991+0200 W/LOCATION(20721): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:40.991+0200 I/LOCATION(20721): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:40.991+0200 I/LOCATION(20721): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:40.991+0200 I/location(20721): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:41.071+0200 I/LOCATION(20721): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:41.121+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:41.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:41.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20721
04-23 15:58:41.131+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:41.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.131+0200 I/utils   (19708): specific action
04-23 15:58:41.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.131+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:41.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:41.131+0200 W/AUL     (20721): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:41.131+0200 I/location(20721): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:41.131+0200 I/location(20721): stopping es.ugr.frailty.location service
04-23 15:58:41.131+0200 E/CAPI_APPFW_APP_CONTROL(20721): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:41.131+0200 E/location(20721): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:41.131+0200 I/CAPI_APPFW_APPLICATION(20721): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:41.131+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:41.141+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:41.141+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.141+0200 I/utils   (19713): specific action
04-23 15:58:41.141+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.141+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.141+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.141+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:41.141+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:41.141+0200 I/recorder(19713): guardando datos en local
04-23 15:58:41.141+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:41.141+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:41.151+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:41.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19713), cmd(0)
04-23 15:58:41.151+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:41.151+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:41.151+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:41.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:41.161+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:41:162,83
04-23 15:58:41.181+0200 W/LOCATION(20721): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:41.181+0200 I/LOCATION(20721): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:41.181+0200 I/LOCATION(20721): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:58:41.311+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:41.311+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:41.311+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:41.311+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:41.351+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:41.381+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:41:360,83
04-23 15:58:41.481+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:41.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:41.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:41.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73762e8
04-23 15:58:41.561+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:41.571+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:41:572,83
04-23 15:58:41.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733ee60]
04-23 15:58:41.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:41.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:41.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:41.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:41.611+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:41.611+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:41.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.631+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:41.631+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:41.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:41.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:41.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:41.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:41.631+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:41.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:41.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:41.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:41.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.711+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:41.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:41.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:41.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:41.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733ee60
04-23 15:58:41.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e04028]
04-23 15:58:41.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:41.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:41.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:41.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:41.801+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:41.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:41.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.821+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:41.821+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:41.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:41.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:41.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:41.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:41.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:41.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:41.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:41.821+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:41:762,83
04-23 15:58:41.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:41.831+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:41.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:41.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:41.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:41.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:41.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e04028
04-23 15:58:41.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:41.961+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:41:962,83
04-23 15:58:42.101+0200 W/AUL     (20734): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:42.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:42.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:42.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20694
04-23 15:58:42.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:42.101+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20694
04-23 15:58:42.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20694)
04-23 15:58:42.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:42.161+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:42:163,83
04-23 15:58:42.371+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:42.371+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:42.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:42.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:42.391+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20735
04-23 15:58:42.391+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:42.391+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:42.401+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:42:395,83
04-23 15:58:42.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20735
04-23 15:58:42.441+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20735) type(svcapp) bg(0)
04-23 15:58:42.441+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20735)
04-23 15:58:42.441+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:42.441+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:42.441+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20735]
04-23 15:58:42.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:42.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20735
04-23 15:58:42.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:42.471+0200 E/CAPI_APPFW_APPLICATION(20735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:42.471+0200 E/CAPI_APPFW_APPLICATION(20735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:42.471+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20735
04-23 15:58:42.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:42.481+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20735) was created
04-23 15:58:42.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:42.511+0200 W/LOCATION(20735): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:42.511+0200 E/LOCATION(20735): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:42.511+0200 E/PKGMGR_INFO(20735): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:42.521+0200 W/LOCATION(20735): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:42.531+0200 I/LOCATION(20735): location.c: location_new(269) > method: 0
04-23 15:58:42.541+0200 W/LOCATION(20735): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:42.541+0200 W/LOCATION(20735): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:42.551+0200 W/LOCATION(20735): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:42.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:42.561+0200 W/LOCATION(20735): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:42.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:42:563,83
04-23 15:58:42.561+0200 W/LOCATION(20735): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:42.571+0200 W/LOCATION(20735): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:42.571+0200 W/LOCATION(20735): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:42.571+0200 W/LOCATION(20735): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:42.571+0200 W/LOCATION(20735): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:42.581+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11205886c6f63152449191
