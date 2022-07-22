S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23393
Date: 2018-04-23 16:02:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf777452d, r5   = 0xf7ca1f98
r6   = 0xffdb8448, r7   = 0xffdb82f8
r8   = 0xf7c9ec18, r9   = 0x00000000
r10  = 0xffdb83d4, fp   = 0xffdb8448
ip   = 0x00000001, sp   = 0xffdb7178
lr   = 0xf7774539, pc   = 0xf77dd2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10532 KB
Buffers:     61104 KB
Cached:     226744 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11548 KB
VmRSS:       11548 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23393 TID = 23393
23393 23405 

Maps Information
f463f000 f4e3e000 rw-p [stack:23405]
f4e45000 f4e47000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e4f000 f4e53000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e5c000 f4e5e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e66000 f4e69000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e78000 f4e7d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e88000 f4e8b000 r-xp /lib/libattr.so.1.1.0
f4e93000 f4ea3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4eab000 f4eb4000 r-xp /usr/lib/libedbus.so.1.7.99
f4ebc000 f4ebd000 r-xp /usr/lib/libresponse.so.0.2.96
f4ec6000 f4ecb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f676d000 f6873000 r-xp /usr/lib/libicuuc.so.57.1
f6889000 f6a11000 r-xp /usr/lib/libicui18n.so.57.1
f6a21000 f6a2e000 r-xp /usr/lib/libail.so.0.1.0
f6a37000 f6a3e000 r-xp /usr/lib/libminizip.so.1.0.0
f6a47000 f6bf0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6c10000 f6c57000 r-xp /usr/lib/libssl.so.1.0.0
f6c63000 f6c65000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c6d000 f6c74000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c7d000 f6c84000 r-xp /lib/libcrypt-2.13.so
f6cb5000 f6cb8000 r-xp /lib/libcap.so.2.21
f6cc0000 f6cc2000 r-xp /usr/lib/libiri.so
f6cca000 f6d13000 r-xp /usr/lib/libmdm.so.1.2.69
f6d1b000 f6d21000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d29000 f6d4c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d56000 f6d58000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d60000 f6d7d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d86000 f6d8a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d93000 f6dac000 r-xp /usr/lib/libnetwork.so.0.0.0
f6db5000 f6dbd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6dc5000 f6dcb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dd4000 f6dd6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ddf000 f6def000 r-xp /lib/libresolv-2.13.so
f6df3000 f6e0b000 r-xp /usr/lib/liblzma.so.5.0.3
f6e14000 f6e16000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e1e000 f6e38000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e40000 f6e6f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e78000 f6e87000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e91000 f6e9b000 r-xp /usr/lib/libsensord-shared.so
f6ea4000 f6f77000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f82000 f6f98000 r-xp /lib/libz.so.1.2.5
f6fa0000 f6fa5000 r-xp /usr/lib/libffi.so.5.0.10
f6fad000 f6fae000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6fb6000 f6fc6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fce000 f6fe7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fef000 f6ff1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ff9000 f706e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7078000 f707e000 r-xp /lib/librt-2.13.so
f7087000 f70a5000 r-xp /usr/lib/libsystemd.so.0.4.0
f70af000 f70b0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70b8000 f70db000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70e3000 f70e8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70f0000 f711a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7123000 f713a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7142000 f71ab000 r-xp /lib/libm-2.13.so
f71b4000 f7248000 r-xp /usr/lib/libstdc++.so.6.0.16
f725b000 f7260000 r-xp /usr/lib/libctx-client.so.0.8.3
f7268000 f726f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7277000 f72a1000 r-xp /usr/lib/libsensor.so.1.9.6
f72aa000 f7376000 r-xp /usr/lib/libxml2.so.2.7.8
f7383000 f7385000 r-xp /usr/lib/libiniparser.so.0
f738e000 f7394000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f739d000 f746d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f746e000 f74a2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f74ab000 f74e7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74ef000 f74f2000 r-xp /usr/lib/libbundle.so.0.1.22
f74fa000 f7500000 r-xp /usr/lib/libappsvc.so.0.1.0
f7508000 f7549000 r-xp /usr/lib/libeina.so.1.7.99
f7552000 f7569000 r-xp /usr/lib/libecore.so.1.7.99
f7580000 f7589000 r-xp /usr/lib/libvconf.so.0.2.45
f7591000 f75a5000 r-xp /lib/libpthread-2.13.so
f75b0000 f75bd000 r-xp /usr/lib/libaul.so.0.1.0
f75c7000 f75c9000 r-xp /lib/libdl-2.13.so
f75d2000 f75dd000 r-xp /lib/libunwind.so.8.0.1
f760a000 f7612000 r-xp /lib/libgcc_s-4.6.so.1
f7613000 f7737000 r-xp /lib/libc-2.13.so
f7745000 f7747000 r-xp /usr/lib/libdlog.so.0.0.0
f774f000 f775b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7764000 f7769000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7771000 f7780000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7788000 f778c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7795000 f7798000 r-xp /usr/lib/libappcore-agent.so.1.1
f77a0000 f77a2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f77aa000 f77ae000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f77b6000 f77d3000 r-xp /lib/ld-2.13.so
f77dc000 f77df000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77df000 f77e3000 r-xp /usr/lib/libsys-assert.so
f7c6e000 f7cdf000 rw-p [heap]
ffd99000 ffdba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23393)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf77dd2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7774539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf747b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7479c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7485e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf748bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf748bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74c075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74bb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7479c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7485e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf748bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf748bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74bde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74be017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74c28d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf77ac0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4e50171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f23663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73d0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73d27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7562ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf755db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf755e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf755e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7796183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77967fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77dd6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf762a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77dcfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
+0200 I/CAPI_APPFW_APPLICATION(23496): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:49.951+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:49.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:49.961+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:49.961+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:49.961+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:49.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:49.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:49.961+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:49.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:49.971+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:49.971+0200 I/utils   (22624): specific action
04-23 16:02:49.971+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:49.971+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:49.981+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:49.981+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:49.981+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:49.981+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:49.981+0200 I/recorder(22624): guardando datos en local
04-23 16:02:49.981+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:49.981+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:49:987,-1.854438,-3.170490,9.123833
04-23 16:02:49.981+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:49:985,-0.070000,0.280000,0.140000
04-23 16:02:50.011+0200 W/LOCATION(23496): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:50.011+0200 I/LOCATION(23496): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:50.011+0200 I/LOCATION(23496): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:50.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:02:50.091+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:50.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:50.091+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:50.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:02:50.101+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:50.101+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:50.101+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:50.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:50.171+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:50.181+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:50.181+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:50:185,-1.830509,-3.211168,9.083155
04-23 16:02:50.191+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:50:184,0.700000,0.560000,0.350000
04-23 16:02:50.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:50.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:50.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:50.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375618
04-23 16:02:50.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7345e00]
04-23 16:02:50.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:50.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:50.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:50.381+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:50.381+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:50.381+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:50.391+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:50.391+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:50.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.401+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:50:389,0.420000,0.490000,0.280000
04-23 16:02:50.401+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:50:385,-1.875973,-3.115455,9.126225
04-23 16:02:50.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.401+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:50.401+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:50.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:50.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:50.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:50.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:50.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:50.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:50.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:50.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.421+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:50.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:50.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:50.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:50.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7345e00
04-23 16:02:50.581+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:50.601+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:50.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332c70]
04-23 16:02:50.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:50.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:50.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:50.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:50.611+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:50.611+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:50.621+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:50:586,-1.835295,-3.184847,9.102298
04-23 16:02:50.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.641+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:50.641+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:50.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:50.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:50.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:50.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:50.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:50.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:50.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:50.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:50.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:50.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.671+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:50:607,0.420000,0.490000,0.210000
04-23 16:02:50.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:50.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:50.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:50.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:50.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332c70
04-23 16:02:50.771+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:50.771+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:50.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:50.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:50.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23496
04-23 16:02:50.791+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23496)
04-23 16:02:50.791+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:50.791+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:50.791+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:50.791+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:50.801+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:50:799,-1.830509,-3.168097,9.078369
04-23 16:02:50.801+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:50:802,-0.910000,-0.770000,0.070000
04-23 16:02:50.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:02:50.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:50.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23496), cmd(0)
04-23 16:02:50.911+0200 W/AUL     (23527): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:50.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:50.911+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:50.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23433
04-23 16:02:50.911+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:50.911+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23433
04-23 16:02:50.911+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23433)
04-23 16:02:50.981+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:50.981+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:50:985,-1.811367,-3.153740,9.145369
04-23 16:02:50.981+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:50.991+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:50:994,0.770000,0.560000,0.630000
04-23 16:02:51.171+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:51.181+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:51:184,-1.892723,-3.168097,9.133404
04-23 16:02:51.181+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:51.191+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:51:194,0.770000,0.840000,-0.420000
04-23 16:02:51.371+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:51.381+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:51:384,-1.919044,-3.160919,9.107083
04-23 16:02:51.381+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:51.391+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:51:391,0.840000,0.840000,-0.210000
04-23 16:02:51.571+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:51.581+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:51:584,-1.880759,-3.108276,9.135797
04-23 16:02:51.581+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:51.591+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:51:593,0.140000,0.840000,-0.210000
04-23 16:02:51.771+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:51.781+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:51:784,-1.837688,-3.194418,9.095119
04-23 16:02:51.781+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:51.791+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:51:793,-1.190000,0.840000,-0.070000
04-23 16:02:51.961+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:51.971+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:51.981+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:51:984,-1.895115,-3.151347,9.059227
04-23 16:02:51.981+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:51.991+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:51:993,-1.260000,0.630000,-0.210000
04-23 16:02:52.171+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:52.181+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:52:184,-2.081756,-3.108276,9.379865
04-23 16:02:52.181+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:52.191+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:52:193,-5.040000,-0.280000,0.840000
04-23 16:02:52.371+0200 I/accelerometer(23441): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:52.381+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:52:384,0.782453,-8.475377,7.592427
04-23 16:02:52.381+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:52.391+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:52:388,-248.779999,-80.639999,-57.330002
04-23 16:02:52.571+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:02:52.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:02:52.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:52.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23441
04-23 16:02:52.581+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23441), cmd(0)
04-23 16:02:52.581+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23441)
04-23 16:02:52.581+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:02:52.581+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:52.591+0200 I/accelerometer(23441): stopping es.ugr.frailty.accelerometer service
04-23 16:02:52.591+0200 W/AUL     (23441): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:52.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.591+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23441
04-23 16:02:52.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:52.601+0200 W/AUL     (23441): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:52.601+0200 I/accelerometer(23441): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:52.601+0200 I/CAPI_APPFW_APPLICATION(23441): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:52.601+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.601+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:52.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:52.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:52.611+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.611+0200 I/utils   (19708): specific action
04-23 16:02:52.611+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:52.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:52.621+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:52.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:52.621+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:52.621+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:52.621+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.621+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:52.631+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.631+0200 I/utils   (22624): specific action
04-23 16:02:52.631+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.631+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:02:52.631+0200 I/recorder(22624): guardando datos en local
04-23 16:02:52.631+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:52.631+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:52:639,32.689999,-32.830002,-144.410004
04-23 16:02:52.681+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:52.691+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:52.721+0200 I/accelerometer(23441): es.ugr.frailty.accelerometer listener destroyed
04-23 16:02:52.781+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:02:52.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:02:52.781+0200 I/gyroscope(23454): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:52.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:52.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23454
04-23 16:02:52.801+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23454)
04-23 16:02:52.801+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:02:52.801+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:52.801+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:52:785,-36.049999,46.060001,-127.330002
04-23 16:02:52.801+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23454), cmd(0)
04-23 16:02:52.801+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:02:52.801+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:52.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.801+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:52.821+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:52.821+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23533
04-23 16:02:52.821+0200 I/gyroscope(23454): stopping es.ugr.frailty.gyroscope service
04-23 16:02:52.821+0200 W/AUL     (23454): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:52.861+0200 W/AUL     (23534): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:02:52.861+0200 E/CAPI_APPFW_APPLICATION(23533): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:52.861+0200 E/CAPI_APPFW_APPLICATION(23533): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:52.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23533
04-23 16:02:52.871+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23533) type(svcapp) bg(0)
04-23 16:02:52.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.871+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23533)
04-23 16:02:52.871+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:02:52.871+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:52.871+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23533]
04-23 16:02:52.871+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23454
04-23 16:02:52.881+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:52.891+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.891+0200 I/utils   (19708): specific action
04-23 16:02:52.891+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.891+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23441
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:52.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:52.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:52.901+0200 W/AUL     (23454): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:52.901+0200 I/gyroscope(23454): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:52.901+0200 I/CAPI_APPFW_APPLICATION(23454): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:52.901+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23533
04-23 16:02:52.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:52.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:52.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:52.911+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23533) was created
04-23 16:02:52.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:52.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:52.911+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23441
04-23 16:02:52.921+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23441)
04-23 16:02:52.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:52.921+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:52.921+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:52.921+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:52.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:52.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:52.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.921+0200 I/utils   (22624): specific action
04-23 16:02:52.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:52.921+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:02:52.921+0200 I/recorder(22624): guardando datos en local
04-23 16:02:52.931+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:52.941+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23533
04-23 16:02:52.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:52.961+0200 W/LOCATION(23533): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:52.961+0200 E/LOCATION(23533): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:52.961+0200 E/PKGMGR_INFO(23533): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:52.971+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:52.991+0200 I/LOCATION(23533): location.c: location_new(269) > method: 0
04-23 16:02:52.991+0200 W/LOCATION(23533): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:52.991+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:53.001+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:53.001+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:53.011+0200 W/LOCATION(23533): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:53.011+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:53.011+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:53.011+0200 W/LOCATION(23533): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:53.021+0200 W/LOCATION(23533): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:53.021+0200 W/LOCATION(23533): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:53.021+0200 W/LOCATION(23533): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:53.031+0200 I/gyroscope(23454): es.ugr.frailty.gyroscope listener destroyed
04-23 16:02:53.041+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:53.051+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:53.051+0200 W/LOCATION(23533): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:53.051+0200 W/LOCATION(23533): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:53.051+0200 W/LOCATION(23533): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:53.061+0200 W/LOCATION(23533): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:53.061+0200 W/LOCATION(23533): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:53.071+0200 W/LOCATION(23533): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:53.071+0200 I/LOCATION(23533): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7539c18
04-23 16:02:53.071+0200 I/LOCATION(23533): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:53.071+0200 I/LOCATION(23533): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7539c18
04-23 16:02:53.071+0200 I/LOCATION(23533): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:53.081+0200 I/location(23533): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:53.121+0200 I/LOCATION(23533): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:53.161+0200 W/AUL     (23538): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:02:53.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:53.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:53.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23454
04-23 16:02:53.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:53.171+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23454
04-23 16:02:53.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23454)
04-23 16:02:53.181+0200 W/LOCATION(23533): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:53.181+0200 W/LOCATION(23533): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:53.181+0200 I/LOCATION(23533): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:53.251+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:53.251+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:53.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:53.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:53.251+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:53.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:53.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:53.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:53.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:53.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:53.261+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:53.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:53.261+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:53.331+0200 W/LOCATION(23533): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:53.331+0200 W/LOCATION(23533): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:53.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:53.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:53.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:53.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:53.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:53.511+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:53.511+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6069172), time2(6056574)
04-23 16:02:53.511+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:02:53.511+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:53.511+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:53.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:53.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7370960]
04-23 16:02:53.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:53.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:53.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:53.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:53.521+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:53.521+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:53.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.541+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:53.541+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:53.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:53.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:53.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:53.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:53.541+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:53.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:53.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:53.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.551+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:53.561+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:53.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:53.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:53.621+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:53.621+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:53.621+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:53.641+0200 W/LOCATION(23533): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:53.641+0200 I/LOCATION(23533): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:53.641+0200 I/LOCATION(23533): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:53.641+0200 I/location(23533): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:53.731+0200 I/LOCATION(23533): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:53.781+0200 W/AUL     (23533): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:53.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:53.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23533
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:53.791+0200 W/AUL     (23533): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:53.791+0200 I/location(23533): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:53.791+0200 I/location(23533): stopping es.ugr.frailty.location service
04-23 16:02:53.791+0200 E/CAPI_APPFW_APP_CONTROL(23533): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:53.791+0200 E/location(23533): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:53.791+0200 I/CAPI_APPFW_APPLICATION(23533): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:53.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.791+0200 I/utils   (19708): specific action
04-23 16:02:53.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.791+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:53.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.791+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:53.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:53.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:53.831+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:53.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:53.831+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:53.831+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:53.831+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:53.831+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.831+0200 I/utils   (22624): specific action
04-23 16:02:53.831+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.831+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.831+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.831+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:53.831+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:53.831+0200 I/recorder(22624): guardando datos en local
04-23 16:02:53.861+0200 W/LOCATION(23533): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:53.861+0200 I/LOCATION(23533): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:53.861+0200 I/LOCATION(23533): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:53.941+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:53.941+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:53.941+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:53.941+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:54.001+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11233936c6f63152449216
