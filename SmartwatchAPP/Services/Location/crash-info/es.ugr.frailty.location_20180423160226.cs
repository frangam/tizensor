S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23187
Date: 2018-04-23 16:02:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf711c52d, r5   = 0xf76d0f98
r6   = 0xff829af8, r7   = 0xff8299a8
r8   = 0xf76cdc18, r9   = 0x00000000
r10  = 0xff829a84, fp   = 0xff829af8
ip   = 0x00000001, sp   = 0xff828828
lr   = 0xf711c539, pc   = 0xf71852b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9112 KB
Buffers:     60892 KB
Cached:     226088 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12196 KB
VmRSS:       12196 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23187 TID = 23187
23187 23190 

Maps Information
f3fe7000 f47e6000 rw-p [stack:23190]
f47ed000 f47ef000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47f7000 f47fb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4804000 f4806000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f480e000 f4811000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4820000 f4825000 r-xp /usr/lib/libsystem.so.0.0.0
f4830000 f4833000 r-xp /lib/libattr.so.1.1.0
f483b000 f484b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4853000 f485c000 r-xp /usr/lib/libedbus.so.1.7.99
f4864000 f4865000 r-xp /usr/lib/libresponse.so.0.2.96
f486e000 f4873000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6115000 f621b000 r-xp /usr/lib/libicuuc.so.57.1
f6231000 f63b9000 r-xp /usr/lib/libicui18n.so.57.1
f63c9000 f63d6000 r-xp /usr/lib/libail.so.0.1.0
f63df000 f63e6000 r-xp /usr/lib/libminizip.so.1.0.0
f63ef000 f6598000 r-xp /usr/lib/libcrypto.so.1.0.0
f65b8000 f65ff000 r-xp /usr/lib/libssl.so.1.0.0
f660b000 f660d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6615000 f661c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6625000 f662c000 r-xp /lib/libcrypt-2.13.so
f665d000 f6660000 r-xp /lib/libcap.so.2.21
f6668000 f666a000 r-xp /usr/lib/libiri.so
f6672000 f66bb000 r-xp /usr/lib/libmdm.so.1.2.69
f66c3000 f66c9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66d1000 f66f4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66fe000 f6700000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6708000 f6725000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f672e000 f6732000 r-xp /usr/lib/libsmack.so.1.0.0
f673b000 f6754000 r-xp /usr/lib/libnetwork.so.0.0.0
f675d000 f6765000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f676d000 f6773000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f677c000 f677e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6787000 f6797000 r-xp /lib/libresolv-2.13.so
f679b000 f67b3000 r-xp /usr/lib/liblzma.so.5.0.3
f67bc000 f67be000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67c6000 f67e0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67e8000 f6817000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6820000 f682f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6839000 f6843000 r-xp /usr/lib/libsensord-shared.so
f684c000 f691f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f692a000 f6940000 r-xp /lib/libz.so.1.2.5
f6948000 f694d000 r-xp /usr/lib/libffi.so.5.0.10
f6955000 f6956000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f695e000 f696e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6976000 f698f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6997000 f6999000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69a1000 f6a16000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a20000 f6a26000 r-xp /lib/librt-2.13.so
f6a2f000 f6a4d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a57000 f6a58000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a60000 f6a83000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a8b000 f6a90000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a98000 f6ac2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6acb000 f6ae2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aea000 f6b53000 r-xp /lib/libm-2.13.so
f6b5c000 f6bf0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c03000 f6c08000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c10000 f6c17000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c1f000 f6c49000 r-xp /usr/lib/libsensor.so.1.9.6
f6c52000 f6d1e000 r-xp /usr/lib/libxml2.so.2.7.8
f6d2b000 f6d2d000 r-xp /usr/lib/libiniparser.so.0
f6d36000 f6d3c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d45000 f6e15000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e16000 f6e4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e53000 f6e8f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e97000 f6e9a000 r-xp /usr/lib/libbundle.so.0.1.22
f6ea2000 f6ea8000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eb0000 f6ef1000 r-xp /usr/lib/libeina.so.1.7.99
f6efa000 f6f11000 r-xp /usr/lib/libecore.so.1.7.99
f6f28000 f6f31000 r-xp /usr/lib/libvconf.so.0.2.45
f6f39000 f6f4d000 r-xp /lib/libpthread-2.13.so
f6f58000 f6f65000 r-xp /usr/lib/libaul.so.0.1.0
f6f6f000 f6f71000 r-xp /lib/libdl-2.13.so
f6f7a000 f6f85000 r-xp /lib/libunwind.so.8.0.1
f6fb2000 f6fba000 r-xp /lib/libgcc_s-4.6.so.1
f6fbb000 f70df000 r-xp /lib/libc-2.13.so
f70ed000 f70ef000 r-xp /usr/lib/libdlog.so.0.0.0
f70f7000 f7103000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f710c000 f7111000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7119000 f7128000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7130000 f7134000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f713d000 f7140000 r-xp /usr/lib/libappcore-agent.so.1.1
f7148000 f714a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7152000 f7156000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f715e000 f717b000 r-xp /lib/ld-2.13.so
f7184000 f7187000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7187000 f718b000 r-xp /usr/lib/libsys-assert.so
f769d000 f770e000 rw-p [heap]
ff80b000 ff82c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23187)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71852b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf711c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e233f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e21c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e2de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e33be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e33dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e6875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e631f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e21c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e2de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e33be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e33dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e65e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e66017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e6a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71540bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47f8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68cb663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d78fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d7a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f0aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f05b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f065a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f06879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf713e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf713e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71856a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6fd285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7184fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
:02:31.881+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23265) type(svcapp) bg(0)
04-23 16:02:31.881+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23265) was created
04-23 16:02:31.881+0200 W/LOCATION(23265): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:31.881+0200 W/LOCATION(23265): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:31.891+0200 W/LOCATION(23265): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:31.891+0200 W/LOCATION(23265): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:31.891+0200 W/LOCATION(23265): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:31.891+0200 W/LOCATION(23265): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:31.891+0200 W/LOCATION(23265): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:31.911+0200 W/LOCATION(23265): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:31.911+0200 W/LOCATION(23265): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:31.921+0200 W/LOCATION(23265): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:31.921+0200 W/LOCATION(23265): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:31.921+0200 W/LOCATION(23265): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:31.921+0200 W/LOCATION(23265): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:31.921+0200 W/LOCATION(23265): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:31.941+0200 W/LOCATION(23265): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:31.941+0200 I/LOCATION(23265): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf783fc18
04-23 16:02:31.941+0200 I/LOCATION(23265): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:31.941+0200 I/LOCATION(23265): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf783fc18
04-23 16:02:31.941+0200 I/LOCATION(23265): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:31.941+0200 I/location(23265): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:31.951+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23265)
04-23 16:02:31.951+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:02:31.951+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:31.961+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23265]
04-23 16:02:31.961+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:31.961+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:31.991+0200 I/LOCATION(23265): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:32.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:32.041+0200 W/LOCATION(23265): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:32.041+0200 W/LOCATION(23265): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:32.041+0200 I/LOCATION(23265): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:32.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23265
04-23 16:02:32.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:32.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:32.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23265
04-23 16:02:32.081+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:32.081+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:32.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:32.111+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:32.111+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:32.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:32.111+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:32.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:32.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:32.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:32.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:32.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:32.111+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:32.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:32.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:32.161+0200 W/LOCATION(23265): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:32.161+0200 W/LOCATION(23265): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:32.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:32.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:32.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:32.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e0f700]
04-23 16:02:32.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:32.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:32.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:32.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:32.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:32.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:32.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.311+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:32.311+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:32.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:32.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:32.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:32.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:32.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:32.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:32.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:32.331+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.361+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.361+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:32.381+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:32.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:32.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:32.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:32.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:32.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:32.401+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6048064), time2(6043936)
04-23 16:02:32.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:32.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:32.401+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:32.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:32.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:32.441+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:32.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:32.461+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:32.461+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:32.461+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:32.481+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:32.481+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:32.511+0200 W/LOCATION(23265): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:32.511+0200 I/LOCATION(23265): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:32.511+0200 I/LOCATION(23265): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:32.511+0200 I/location(23265): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:32.611+0200 I/LOCATION(23265): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:32.661+0200 W/AUL     (23265): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:32.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:32.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23265
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:32.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.681+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:32.681+0200 I/utils   (19708): specific action
04-23 16:02:32.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.681+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.681+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:32.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:32.681+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:32.681+0200 W/AUL     (23265): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:32.681+0200 I/location(23265): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:32.681+0200 I/location(23265): stopping es.ugr.frailty.location service
04-23 16:02:32.681+0200 E/CAPI_APPFW_APP_CONTROL(23265): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:32.681+0200 E/location(23265): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:32.681+0200 I/CAPI_APPFW_APPLICATION(23265): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:32.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:32.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:32.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:32.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:32.701+0200 I/utils   (22624): specific action
04-23 16:02:32.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.701+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:32.701+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:32.701+0200 I/recorder(22624): guardando datos en local
04-23 16:02:32.701+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:32.701+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:32.701+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:32.741+0200 W/LOCATION(23265): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:32.741+0200 I/LOCATION(23265): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:32.741+0200 I/LOCATION(23265): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:32.821+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:32.821+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:32.821+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:32.821+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:32.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:32.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:32.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:32.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:32.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:32.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:32.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e0f700
04-23 16:02:33.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e10ba0]
04-23 16:02:33.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:33.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:33.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:33.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:33.051+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:33.051+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:33.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:33.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:33.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:33.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:33.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:33.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:33.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:33.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:33.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:33.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:33.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:33.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:33.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:33.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:33.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:33.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:33.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:33.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:33.181+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e10ba0
04-23 16:02:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e199e0]
04-23 16:02:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:33.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:33.261+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:33.261+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:33.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:33.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:33.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.311+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:33.311+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:33.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:33.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:33.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:33.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:33.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:33.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:33.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:33.331+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:33.381+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:33.381+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:33.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:33.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:33.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:33.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:33.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e199e0
04-23 16:02:33.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:33.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:33.621+0200 W/AUL     (23276): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:33.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:33.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:33.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23217
04-23 16:02:33.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:33.631+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23217
04-23 16:02:33.631+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23217)
04-23 16:02:33.671+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:33.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:33.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:33.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:33.971+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:33.971+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:33.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:33.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:33.981+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23278
04-23 16:02:33.981+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:34.031+0200 E/CAPI_APPFW_APPLICATION(23278): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:34.031+0200 E/CAPI_APPFW_APPLICATION(23278): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:34.051+0200 W/LOCATION(23278): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:34.051+0200 E/LOCATION(23278): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:34.051+0200 E/PKGMGR_INFO(23278): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:34.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23278
04-23 16:02:34.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23278) type(svcapp) bg(0)
04-23 16:02:34.061+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23278) was created
04-23 16:02:34.061+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23278]
04-23 16:02:34.061+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:34.061+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23278)
04-23 16:02:34.071+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:34.071+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:34.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:34.081+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:34.081+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23278
04-23 16:02:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:34.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:34.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23278
04-23 16:02:34.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:34.111+0200 I/LOCATION(23278): location.c: location_new(269) > method: 0
04-23 16:02:34.111+0200 W/LOCATION(23278): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:34.121+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:34.131+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:34.131+0200 W/LOCATION(23278): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:34.141+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:34.151+0200 W/LOCATION(23278): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:34.151+0200 W/LOCATION(23278): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:34.151+0200 W/LOCATION(23278): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:34.151+0200 W/LOCATION(23278): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:34.181+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:34.181+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:34.191+0200 W/LOCATION(23278): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:34.191+0200 W/LOCATION(23278): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:34.191+0200 W/LOCATION(23278): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:34.201+0200 W/LOCATION(23278): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:34.201+0200 W/LOCATION(23278): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:34.231+0200 W/LOCATION(23278): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:34.231+0200 I/LOCATION(23278): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf784ac18
04-23 16:02:34.231+0200 I/LOCATION(23278): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:34.231+0200 I/LOCATION(23278): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf784ac18
04-23 16:02:34.231+0200 I/LOCATION(23278): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:34.241+0200 I/location(23278): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:34.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:34.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:34.281+0200 I/LOCATION(23278): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:34.331+0200 W/LOCATION(23278): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:34.331+0200 W/LOCATION(23278): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:34.331+0200 I/LOCATION(23278): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:34.401+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:34.401+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:34.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:34.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:34.401+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:34.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:34.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:34.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:34.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:34.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:34.401+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:34.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:34.411+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:34.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:34.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:34.471+0200 W/LOCATION(23278): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:34.471+0200 W/LOCATION(23278): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:34.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:34.591+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e103d0]
04-23 16:02:34.591+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:34.591+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:34.591+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:34.601+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:34.601+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:34.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:34.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:34.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:34.621+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:34.621+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:34.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:34.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:34.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:34.621+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:34.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:34.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:34.621+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:34.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:34.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:34.641+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:34.641+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:34.641+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6050303), time2(6043936)
04-23 16:02:34.641+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:34.641+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:34.641+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:34.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:34.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:34.671+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:34.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:34.681+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:34.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:34.711+0200 W/LOCATION(23278): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:34.711+0200 I/LOCATION(23278): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:34.711+0200 I/LOCATION(23278): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:34.711+0200 I/location(23278): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:34.841+0200 I/LOCATION(23278): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:34.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:34.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:34:880,76
04-23 16:02:34.891+0200 W/AUL     (23278): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:34.891+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:34.891+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23278
04-23 16:02:34.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:34.901+0200 W/AUL     (23278): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:34.901+0200 I/location(23278): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:34.901+0200 W/CAPI_APPFW_APP_CONTROL(23278): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.901+0200 I/utils   (23278): specific action
04-23 16:02:34.901+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:34.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:34.901+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.901+0200 I/utils   (19708): specific action
04-23 16:02:34.901+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.901+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.901+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.901+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:34.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:34.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:34.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:34.911+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.911+0200 I/utils   (22624): specific action
04-23 16:02:34.911+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:34.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:34.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.921+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:34.921+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:34.921+0200 I/recorder(22624): guardando datos en local
04-23 16:02:34.921+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:34.921+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:34.921+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:35.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:35.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:35:79,76
04-23 16:02:35.271+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:35.271+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:35:279,76
04-23 16:02:35.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:35.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:02:35.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:35.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:35.371+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:35.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:35.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:35.391+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:35.391+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:35.391+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:35.461+0200 I/LOCATION(23278): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:35.471+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:35.471+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:35:479,76
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:02:35.671+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:35.671+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:35.681+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:35.681+0200 W/AUL     (23291): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:35.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:35.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:35.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23265
04-23 16:02:35.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:35.691+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23265
04-23 16:02:35.691+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23265)
04-23 16:02:35.711+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:35.721+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:35.731+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:02:35.731+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:35:723,76
04-23 16:02:35.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:35.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:35:879,76
04-23 16:02:36.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:36.081+0200 I/heartrate(23016): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:02:36:81,76
04-23 16:02:36.081+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:02:36.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:36.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:36.081+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11231876c6f63152449214
