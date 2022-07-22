S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23671
Date: 2018-04-23 16:03:04+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73f652d, r5   = 0xf7a05f98
r6   = 0xffe361f8, r7   = 0xffe360a8
r8   = 0xf7a02c18, r9   = 0x00000000
r10  = 0xffe36184, fp   = 0xffe361f8
ip   = 0x00000001, sp   = 0xffe34f28
lr   = 0xf73f6539, pc   = 0xf745f2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12612 KB
Buffers:     61324 KB
Cached:     224920 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11764 KB
VmRSS:       11764 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23671 TID = 23671
23671 23674 

Maps Information
f42c1000 f4ac0000 rw-p [stack:23674]
f4ac7000 f4ac9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad1000 f4ad5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ade000 f4ae0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ae8000 f4aeb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4afa000 f4aff000 r-xp /usr/lib/libsystem.so.0.0.0
f4b0a000 f4b0d000 r-xp /lib/libattr.so.1.1.0
f4b15000 f4b25000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b2d000 f4b36000 r-xp /usr/lib/libedbus.so.1.7.99
f4b3e000 f4b3f000 r-xp /usr/lib/libresponse.so.0.2.96
f4b48000 f4b4d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63ef000 f64f5000 r-xp /usr/lib/libicuuc.so.57.1
f650b000 f6693000 r-xp /usr/lib/libicui18n.so.57.1
f66a3000 f66b0000 r-xp /usr/lib/libail.so.0.1.0
f66b9000 f66c0000 r-xp /usr/lib/libminizip.so.1.0.0
f66c9000 f6872000 r-xp /usr/lib/libcrypto.so.1.0.0
f6892000 f68d9000 r-xp /usr/lib/libssl.so.1.0.0
f68e5000 f68e7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68ef000 f68f6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68ff000 f6906000 r-xp /lib/libcrypt-2.13.so
f6937000 f693a000 r-xp /lib/libcap.so.2.21
f6942000 f6944000 r-xp /usr/lib/libiri.so
f694c000 f6995000 r-xp /usr/lib/libmdm.so.1.2.69
f699d000 f69a3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69ab000 f69ce000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69d8000 f69da000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e2000 f69ff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a08000 f6a0c000 r-xp /usr/lib/libsmack.so.1.0.0
f6a15000 f6a2e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a37000 f6a3f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a47000 f6a4d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a56000 f6a58000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a61000 f6a71000 r-xp /lib/libresolv-2.13.so
f6a75000 f6a8d000 r-xp /usr/lib/liblzma.so.5.0.3
f6a96000 f6a98000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa0000 f6aba000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac2000 f6af1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6afa000 f6b09000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b13000 f6b1d000 r-xp /usr/lib/libsensord-shared.so
f6b26000 f6bf9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c04000 f6c1a000 r-xp /lib/libz.so.1.2.5
f6c22000 f6c27000 r-xp /usr/lib/libffi.so.5.0.10
f6c2f000 f6c30000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c38000 f6c48000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c50000 f6c69000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c71000 f6c73000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c7b000 f6cf0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cfa000 f6d00000 r-xp /lib/librt-2.13.so
f6d09000 f6d27000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d31000 f6d32000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3a000 f6d5d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d65000 f6d6a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d72000 f6d9c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da5000 f6dbc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc4000 f6e2d000 r-xp /lib/libm-2.13.so
f6e36000 f6eca000 r-xp /usr/lib/libstdc++.so.6.0.16
f6edd000 f6ee2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6eea000 f6ef1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ef9000 f6f23000 r-xp /usr/lib/libsensor.so.1.9.6
f6f2c000 f6ff8000 r-xp /usr/lib/libxml2.so.2.7.8
f7005000 f7007000 r-xp /usr/lib/libiniparser.so.0
f7010000 f7016000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f701f000 f70ef000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f0000 f7124000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f712d000 f7169000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7171000 f7174000 r-xp /usr/lib/libbundle.so.0.1.22
f717c000 f7182000 r-xp /usr/lib/libappsvc.so.0.1.0
f718a000 f71cb000 r-xp /usr/lib/libeina.so.1.7.99
f71d4000 f71eb000 r-xp /usr/lib/libecore.so.1.7.99
f7202000 f720b000 r-xp /usr/lib/libvconf.so.0.2.45
f7213000 f7227000 r-xp /lib/libpthread-2.13.so
f7232000 f723f000 r-xp /usr/lib/libaul.so.0.1.0
f7249000 f724b000 r-xp /lib/libdl-2.13.so
f7254000 f725f000 r-xp /lib/libunwind.so.8.0.1
f728c000 f7294000 r-xp /lib/libgcc_s-4.6.so.1
f7295000 f73b9000 r-xp /lib/libc-2.13.so
f73c7000 f73c9000 r-xp /usr/lib/libdlog.so.0.0.0
f73d1000 f73dd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73e6000 f73eb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f3000 f7402000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f740a000 f740e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7417000 f741a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7422000 f7424000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f742c000 f7430000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7438000 f7455000 r-xp /lib/ld-2.13.so
f745e000 f7461000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7461000 f7465000 r-xp /usr/lib/libsys-assert.so
f79d2000 f7a5c000 rw-p [heap]
ffe17000 ffe38000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23671)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf745f2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf73f6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70fd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7107e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf710dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf710ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf713d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70fbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7107e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf710dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf710ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf713fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7140017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71448d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf742e0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4ad2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ba5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7052fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70547a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71e4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71dfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7418183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74187fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf745f6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf72ac85c) [/lib/libc.so.6] + 0x1785c
29: (0xf745efa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
04-23 16:03:15.091+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:95,-0.980000,0.280000,0.700000
04-23 16:03:15.091+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.091+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:99,-2.175076,-2.581856,9.138189
04-23 16:03:15.101+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:15.101+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:15.121+0200 W/LOCATION(23866): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:15.121+0200 W/LOCATION(23866): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:15.121+0200 I/LOCATION(23866): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:15.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:15.221+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:15.221+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:15.221+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:15.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:15.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:15.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:15.221+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:15.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:15.231+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:15.231+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:15.231+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:15.231+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:15.281+0200 W/LOCATION(23866): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:15.281+0200 W/LOCATION(23866): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:15.281+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.291+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.291+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:296,-2.218147,-2.596212,9.162118
04-23 16:03:15.291+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:291,0.700000,0.910000,-0.280000
04-23 16:03:15.311+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:15.311+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:15.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:15.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:15.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:15.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:15.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:15.391+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.401+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.401+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:406,-2.120041,-2.622534,9.157332
04-23 16:03:15.421+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7386428]
04-23 16:03:15.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:15.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:15.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:15.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:15.431+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:428,-2.122434,-2.591427,9.164511
04-23 16:03:15.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:15.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:15.441+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.441+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:446,-2.170290,-2.636890,9.207582
04-23 16:03:15.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.451+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:15.451+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:15.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:15.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:15.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:15.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:15.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:15.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:15.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:15.451+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:389,0.140000,0.490000,0.420000
04-23 16:03:15.451+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.461+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.471+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:15.471+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6091130), time2(6079657)
04-23 16:03:15.471+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:03:15.471+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:15.471+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:15.471+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:15.471+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.471+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:15.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:15.471+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:466,-2.167897,-2.644069,9.205189
04-23 16:03:15.481+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:463,0.280000,0.560000,0.490000
04-23 16:03:15.481+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.481+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:487,0.210000,0.560000,0.420000
04-23 16:03:15.481+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.491+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:490,0.350000,0.490000,0.350000
04-23 16:03:15.491+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.491+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.491+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:498,-2.189433,-2.632105,9.198010
04-23 16:03:15.501+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:495,0.420000,0.490000,0.350000
04-23 16:03:15.501+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.501+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:506,0.280000,0.350000,-0.140000
04-23 16:03:15.501+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.511+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:512,-0.140000,0.070000,-0.280000
04-23 16:03:15.511+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:15.511+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:15.511+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.511+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:517,-2.201397,-2.600998,9.183653
04-23 16:03:15.521+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.521+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:15.521+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:528,-2.230111,-2.553142,9.209974
04-23 16:03:15.521+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.541+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.541+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:546,-2.189433,-2.622534,9.166903
04-23 16:03:15.541+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:533,-0.420000,0.070000,-0.210000
04-23 16:03:15.541+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:15.551+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:15.551+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:15.551+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:15.551+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:551,-0.210000,0.070000,-0.140000
04-23 16:03:15.561+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.561+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.571+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:568,0.350000,0.140000,0.140000
04-23 16:03:15.571+0200 W/LOCATION(23866): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:15.571+0200 I/LOCATION(23866): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:15.571+0200 I/LOCATION(23866): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:15.571+0200 I/location(23866): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:15.571+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:566,-2.261217,-2.569891,9.157332
04-23 16:03:15.581+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.591+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.591+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:593,0.700000,0.350000,0.420000
04-23 16:03:15.591+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:595,-2.246860,-2.593820,9.157332
04-23 16:03:15.601+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.601+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.601+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:606,-2.184647,-2.620141,9.169296
04-23 16:03:15.601+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:606,0.490000,0.280000,0.700000
04-23 16:03:15.621+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.621+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.621+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:629,-2.220540,-2.600998,9.217153
04-23 16:03:15.621+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:629,0.280000,0.280000,0.700000
04-23 16:03:15.641+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.641+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.661+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:646,-2.208575,-2.644069,9.217153
04-23 16:03:15.661+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.661+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:647,0.350000,0.140000,0.560000
04-23 16:03:15.661+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:669,-2.158326,-2.584249,9.224331
04-23 16:03:15.661+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.671+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:674,0.490000,0.070000,0.420000
04-23 16:03:15.681+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.681+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.681+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:687,-2.129612,-2.591427,9.231510
04-23 16:03:15.681+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:687,0.490000,-0.070000,0.280000
04-23 16:03:15.701+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.701+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.701+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:706,-2.103291,-2.615355,9.245867
04-23 16:03:15.701+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:706,-0.350000,-0.070000,0.140000
04-23 16:03:15.701+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:15.701+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:15.711+0200 I/LOCATION(23866): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:15.721+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.721+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.721+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:728,-0.140000,-0.070000,0.070000
04-23 16:03:15.721+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:728,-2.160719,-2.634498,9.190832
04-23 16:03:15.741+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.741+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.741+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:746,-2.148755,-2.593820,9.195618
04-23 16:03:15.741+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:747,0.140000,-0.070000,0.070000
04-23 16:03:15.761+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.761+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.761+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:766,-2.160719,-2.598605,9.138189
04-23 16:03:15.761+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:766,0.210000,-0.070000,0.070000
04-23 16:03:15.781+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.781+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.781+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:787,0.210000,-0.070000,0.210000
04-23 16:03:15.781+0200 W/AUL     (23866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:15.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:15.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23866
04-23 16:03:15.791+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:787,-2.196611,-2.610569,9.241080
04-23 16:03:15.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:15.801+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.801+0200 I/utils   (19708): specific action
04-23 16:03:15.801+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:15.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:15.801+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.801+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.801+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.801+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:15.801+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:15.801+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:15.801+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:807,-2.225325,-2.636890,9.202796
04-23 16:03:15.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:15.811+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:15.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:15.811+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:15.811+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:15.811+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:15.811+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.821+0200 I/utils   (22624): specific action
04-23 16:03:15.821+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.821+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.821+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.821+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:15.821+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:15.811+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.811+0200 W/AUL     (23866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:15.821+0200 I/recorder(22624): guardando datos en local
04-23 16:03:15.821+0200 I/location(23866): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:15.821+0200 I/location(23866): stopping es.ugr.frailty.location service
04-23 16:03:15.821+0200 E/CAPI_APPFW_APP_CONTROL(23866): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:15.821+0200 E/location(23866): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:15.821+0200 I/CAPI_APPFW_APPLICATION(23866): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:15.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:15.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:15.821+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:820,0.210000,-0.140000,0.280000
04-23 16:03:15.821+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.831+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.831+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:837,-2.208575,-2.603391,9.178867
04-23 16:03:15.831+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:831,0.210000,-0.140000,0.280000
04-23 16:03:15.841+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.841+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.851+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:852,-0.140000,-0.210000,0.140000
04-23 16:03:15.851+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:847,-2.225325,-2.627320,9.178867
04-23 16:03:15.861+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.861+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.861+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:869,-0.070000,-0.210000,0.210000
04-23 16:03:15.871+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:866,-2.158326,-2.600998,9.193225
04-23 16:03:15.891+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.891+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:895,-0.070000,0.210000,0.140000
04-23 16:03:15.891+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.891+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:899,-2.165504,-2.646462,9.119047
04-23 16:03:15.901+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.901+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.901+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:15.901+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:15.911+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:906,0.560000,0.560000,0.140000
04-23 16:03:15.911+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:907,-2.172683,-2.639283,9.162118
04-23 16:03:15.921+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.921+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.921+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:929,0.560000,0.490000,0.070000
04-23 16:03:15.921+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:929,-2.160719,-2.617748,9.159724
04-23 16:03:15.941+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.941+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.941+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:946,0.350000,0.420000,0.070000
04-23 16:03:15.941+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:946,-2.143969,-2.600998,9.248260
04-23 16:03:15.941+0200 W/LOCATION(23866): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:15.941+0200 I/LOCATION(23866): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:15.941+0200 I/LOCATION(23866): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:15.961+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.961+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:966,0.140000,0.420000,-0.070000
04-23 16:03:15.961+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.961+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:970,-2.184647,-2.627320,9.178867
04-23 16:03:15.981+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:15.981+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:15.981+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:15:987,-0.280000,0.210000,-0.070000
04-23 16:03:15.981+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:15:987,-2.194218,-2.581856,9.207582
04-23 16:03:16.001+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.001+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:7,-0.420000,0.210000,0.070000
04-23 16:03:16.001+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.001+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:11,-2.179861,-2.586641,9.221939
04-23 16:03:16.021+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.021+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.021+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:30,-0.350000,0.490000,0.140000
04-23 16:03:16.031+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:30,-2.155933,-2.589034,9.229117
04-23 16:03:16.041+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.041+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:46,-2.124826,-2.589034,9.214760
04-23 16:03:16.051+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.051+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:56,0.140000,0.630000,0.140000
04-23 16:03:16.061+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.061+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.071+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:66,-2.158326,-2.581856,9.233903
04-23 16:03:16.071+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:72,0.910000,0.840000,0.140000
04-23 16:03:16.081+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.081+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.081+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:88,0.630000,0.700000,0.140000
04-23 16:03:16.091+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:89,-2.163112,-2.550749,9.212367
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:16.091+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:16.091+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:16.091+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:16.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:16.101+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.101+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.111+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:16.111+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:16.111+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:107,0.140000,0.490000,0.140000
04-23 16:03:16.121+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:115,-2.191825,-2.600998,9.166903
04-23 16:03:16.121+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.121+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.121+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:129,0.140000,0.280000,0.140000
04-23 16:03:16.131+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:130,-2.189433,-2.667997,9.145369
04-23 16:03:16.141+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.141+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.141+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:146,0.070000,0.280000,0.140000
04-23 16:03:16.151+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:146,-2.208575,-2.624927,9.214760
04-23 16:03:16.161+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.161+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.161+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:166,-2.184647,-2.622534,9.193225
04-23 16:03:16.161+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:166,-0.070000,0.280000,0.140000
04-23 16:03:16.181+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.181+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.181+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:187,-2.222932,-2.608176,9.128618
04-23 16:03:16.191+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:187,-0.140000,0.420000,0.140000
04-23 16:03:16.201+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.201+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:206,-2.158326,-2.577070,9.181261
04-23 16:03:16.201+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.211+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:211,0.070000,0.560000,0.350000
04-23 16:03:16.221+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.221+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.221+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:228,-2.227718,-2.581856,9.186047
04-23 16:03:16.221+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:230,0.070000,0.770000,0.280000
04-23 16:03:16.241+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.241+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:247,-2.179861,-2.610569,9.195618
04-23 16:03:16.261+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.261+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.261+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:266,-2.158326,-2.565106,9.236296
04-23 16:03:16.281+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:16.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:16.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:16.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7386428
04-23 16:03:16.291+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:287,-2.182254,-2.605784,9.188439
04-23 16:03:16.291+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:265,0.560000,0.840000,0.210000
04-23 16:03:16.291+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.301+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.301+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:307,-2.139183,-2.624927,9.248260
04-23 16:03:16.321+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:16.331+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:302,0.420000,0.700000,0.210000
04-23 16:03:16.341+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.361+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:16.371+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:329,-2.155933,-2.596212,9.176475
04-23 16:03:16.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73881c8]
04-23 16:03:16.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:16.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:16.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:16.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:16.391+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:16.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:16.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.411+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:348,0.140000,0.490000,0.280000
04-23 16:03:16.411+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.411+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:417,0.070000,0.560000,0.280000
04-23 16:03:16.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.411+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.411+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:16.411+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:16.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:16.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:16.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:16.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:16.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:16.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:16.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:16.411+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:421,-0.070000,0.350000,0.350000
04-23 16:03:16.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.421+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:400,-2.175076,-2.629712,9.205189
04-23 16:03:16.421+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.431+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:434,-2.148755,-2.605784,9.162118
04-23 16:03:16.431+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:16.431+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.461+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.461+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:469,-0.070000,0.490000,0.350000
04-23 16:03:16.461+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.481+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:473,0.070000,0.490000,0.280000
04-23 16:03:16.491+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.491+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.501+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:497,-2.244468,-2.651247,9.198010
04-23 16:03:16.501+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.511+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:16.521+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:514,-0.770000,0.490000,0.350000
04-23 16:03:16.541+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73881c8
04-23 16:03:16.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e11680]
04-23 16:03:16.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:16.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:16.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:16.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:16.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:16.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:16.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.641+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:16.641+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:16.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:16.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:16.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:16.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:16.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:16.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:16.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:16.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:16.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:16.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.681+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.681+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:687,0.980000,0.280000,0.770000
04-23 16:03:16.681+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.701+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:691,-2.187040,-2.541178,9.205189
04-23 16:03:16.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:16.711+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:16.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e11680
04-23 16:03:16.721+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:16.781+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:16.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:16.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:16.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:16.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23866
04-23 16:03:16.791+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23866)
04-23 16:03:16.791+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:16.791+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:16.851+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:03:16.851+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:16.851+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23866), cmd(0)
04-23 16:03:16.861+0200 W/AUL     (23881): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:16.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:16.861+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:16.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23848
04-23 16:03:16.861+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:16.861+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23848
04-23 16:03:16.861+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23848)
04-23 16:03:16.881+0200 I/gyroscope(23822): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:16.881+0200 I/gyroscope(23822): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:16:887,0.490000,0.350000,0.490000
04-23 16:03:16.881+0200 I/accelerometer(23809): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:16.881+0200 I/accelerometer(23809): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:16:891,-2.136791,-2.632105,9.176475
04-23 16:03:16.911+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:16.921+0200 I/heartrate(23824): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:03:16.931+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11236716c6f63152449218
