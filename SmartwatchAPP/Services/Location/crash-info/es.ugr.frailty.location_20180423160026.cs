S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21617
Date: 2018-04-23 16:00:26+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72b852d, r5   = 0xf7992f98
r6   = 0xffb8ef78, r7   = 0xffb8ee28
r8   = 0xf798fc18, r9   = 0x00000000
r10  = 0xffb8ef04, fp   = 0xffb8ef78
ip   = 0x00000001, sp   = 0xffb8dca8
lr   = 0xf72b8539, pc   = 0xf73212b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10956 KB
Buffers:     59512 KB
Cached:     232852 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11912 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21617 TID = 21617
21617 21620 

Maps Information
f4183000 f4982000 rw-p [stack:21620]
f4989000 f498b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4993000 f4997000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49a0000 f49a2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49aa000 f49ad000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49bc000 f49c1000 r-xp /usr/lib/libsystem.so.0.0.0
f49cc000 f49cf000 r-xp /lib/libattr.so.1.1.0
f49d7000 f49e7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49ef000 f49f8000 r-xp /usr/lib/libedbus.so.1.7.99
f4a00000 f4a01000 r-xp /usr/lib/libresponse.so.0.2.96
f4a0a000 f4a0f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62b1000 f63b7000 r-xp /usr/lib/libicuuc.so.57.1
f63cd000 f6555000 r-xp /usr/lib/libicui18n.so.57.1
f6565000 f6572000 r-xp /usr/lib/libail.so.0.1.0
f657b000 f6582000 r-xp /usr/lib/libminizip.so.1.0.0
f658b000 f6734000 r-xp /usr/lib/libcrypto.so.1.0.0
f6754000 f679b000 r-xp /usr/lib/libssl.so.1.0.0
f67a7000 f67a9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67b1000 f67b8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67c1000 f67c8000 r-xp /lib/libcrypt-2.13.so
f67f9000 f67fc000 r-xp /lib/libcap.so.2.21
f6804000 f6806000 r-xp /usr/lib/libiri.so
f680e000 f6857000 r-xp /usr/lib/libmdm.so.1.2.69
f685f000 f6865000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f686d000 f6890000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f689a000 f689c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68a4000 f68c1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68ca000 f68ce000 r-xp /usr/lib/libsmack.so.1.0.0
f68d7000 f68f0000 r-xp /usr/lib/libnetwork.so.0.0.0
f68f9000 f6901000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6909000 f690f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6918000 f691a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6923000 f6933000 r-xp /lib/libresolv-2.13.so
f6937000 f694f000 r-xp /usr/lib/liblzma.so.5.0.3
f6958000 f695a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6962000 f697c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6984000 f69b3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69bc000 f69cb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69d5000 f69df000 r-xp /usr/lib/libsensord-shared.so
f69e8000 f6abb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ac6000 f6adc000 r-xp /lib/libz.so.1.2.5
f6ae4000 f6ae9000 r-xp /usr/lib/libffi.so.5.0.10
f6af1000 f6af2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6afa000 f6b0a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b12000 f6b2b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b33000 f6b35000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b3d000 f6bb2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bbc000 f6bc2000 r-xp /lib/librt-2.13.so
f6bcb000 f6be9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bf3000 f6bf4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bfc000 f6c1f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c27000 f6c2c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c34000 f6c5e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c67000 f6c7e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c86000 f6cef000 r-xp /lib/libm-2.13.so
f6cf8000 f6d8c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d9f000 f6da4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dac000 f6db3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dbb000 f6de5000 r-xp /usr/lib/libsensor.so.1.9.6
f6dee000 f6eba000 r-xp /usr/lib/libxml2.so.2.7.8
f6ec7000 f6ec9000 r-xp /usr/lib/libiniparser.so.0
f6ed2000 f6ed8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ee1000 f6fb1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fb2000 f6fe6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fef000 f702b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7033000 f7036000 r-xp /usr/lib/libbundle.so.0.1.22
f703e000 f7044000 r-xp /usr/lib/libappsvc.so.0.1.0
f704c000 f708d000 r-xp /usr/lib/libeina.so.1.7.99
f7096000 f70ad000 r-xp /usr/lib/libecore.so.1.7.99
f70c4000 f70cd000 r-xp /usr/lib/libvconf.so.0.2.45
f70d5000 f70e9000 r-xp /lib/libpthread-2.13.so
f70f4000 f7101000 r-xp /usr/lib/libaul.so.0.1.0
f710b000 f710d000 r-xp /lib/libdl-2.13.so
f7116000 f7121000 r-xp /lib/libunwind.so.8.0.1
f714e000 f7156000 r-xp /lib/libgcc_s-4.6.so.1
f7157000 f727b000 r-xp /lib/libc-2.13.so
f7289000 f728b000 r-xp /usr/lib/libdlog.so.0.0.0
f7293000 f729f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72a8000 f72ad000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72b5000 f72c4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72cc000 f72d0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72d9000 f72dc000 r-xp /usr/lib/libappcore-agent.so.1.1
f72e4000 f72e6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72ee000 f72f2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72fa000 f7317000 r-xp /lib/ld-2.13.so
f7320000 f7323000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7323000 f7327000 r-xp /usr/lib/libsys-assert.so
f795f000 f79e8000 rw-p [heap]
ffb70000 ffb91000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21617)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf73212b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf72b8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fbf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fbdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fc9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fcfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fcfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf700475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fff1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fbdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fc9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fcfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fcfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7001e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7002017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70068d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72f00bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4994171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a67663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f14fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f167a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70a6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70a1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70a25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70a2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72da183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72da7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73216a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf716e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7320fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
_request_handler(669) > __request_handler: 14
04-23 16:00:21.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21596
04-23 16:00:21.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:21.151+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21596
04-23 16:00:21.151+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21596) was created
04-23 16:00:21.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:21.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:21.161+0200 W/LOCATION(21596): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:21.161+0200 E/LOCATION(21596): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:21.161+0200 E/PKGMGR_INFO(21596): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:21.161+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:21.181+0200 I/LOCATION(21596): location.c: location_new(269) > method: 0
04-23 16:00:21.181+0200 W/LOCATION(21596): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:21.191+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:21.191+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:21.191+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:21.191+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:21.201+0200 W/LOCATION(21596): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:21.201+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:21.201+0200 W/LOCATION(21596): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:21.201+0200 W/LOCATION(21596): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:21.201+0200 W/LOCATION(21596): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:21.201+0200 W/LOCATION(21596): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:21.231+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:21.231+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:21.231+0200 W/LOCATION(21596): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:21.241+0200 W/LOCATION(21596): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:21.241+0200 W/LOCATION(21596): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:21.241+0200 W/LOCATION(21596): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:21.241+0200 W/LOCATION(21596): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:21.261+0200 W/LOCATION(21596): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:21.261+0200 I/LOCATION(21596): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7414c18
04-23 16:00:21.261+0200 I/LOCATION(21596): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:21.261+0200 I/LOCATION(21596): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7414c18
04-23 16:00:21.261+0200 I/LOCATION(21596): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:21.271+0200 I/location(21596): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:21.311+0200 I/LOCATION(21596): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:21.351+0200 W/LOCATION(21596): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:21.351+0200 W/LOCATION(21596): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:21.361+0200 I/LOCATION(21596): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:21.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:21.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:21.431+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:21.431+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:21.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:21.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:21.431+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:21.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:21.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:21.431+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:21.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:21.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:21.441+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:21.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:21.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:21.501+0200 W/LOCATION(21596): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:21.501+0200 W/LOCATION(21596): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:21.591+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:21.611+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:21.631+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:21.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:21.631+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:21.681+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:21.681+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5917344), time2(5908847)
04-23 16:00:21.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:21.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:21.681+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:21.681+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:21.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:21.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2c360]
04-23 16:00:21.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:21.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:21.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:21.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:21.741+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:21.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:21.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:21.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:21.761+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:21.761+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:21.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:21.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:21.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:21.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:21.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:21.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:21.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:21.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:21.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:21.781+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:21.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:21.791+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:21.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:21.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:21.961+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:22.011+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:22.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:22.011+0200 W/LOCATION(21596): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:22.011+0200 I/LOCATION(21596): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:22.011+0200 I/LOCATION(21596): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:22.011+0200 I/location(21596): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:22.211+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:22.211+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:22.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:22.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:22.541+0200 I/LOCATION(21596): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:22.611+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:22.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:22.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:22.621+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:22.621+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:22.651+0200 W/AUL     (21596): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:22.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:22.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21596
04-23 16:00:22.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:22.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:22.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:22.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.671+0200 I/utils   (19708): specific action
04-23 16:00:22.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.671+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.671+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:22.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:22.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:22.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:22.681+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:22.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 I/utils   (21185): specific action
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:22.681+0200 I/recorder(21185): guardando datos en local
04-23 16:00:22.681+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:22.681+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:22.681+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:22.681+0200 W/AUL     (21596): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:22.681+0200 I/location(21596): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:22.681+0200 W/CAPI_APPFW_APP_CONTROL(21596): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:22.681+0200 I/utils   (21596): specific action
04-23 16:00:22.791+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:22.791+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.011+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:23.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.101+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:00:23.111+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:00:23.111+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:23.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:23.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:23.121+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21596
04-23 16:00:23.121+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:23.121+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21596), cmd(0)
04-23 16:00:23.121+0200 I/location(21596): stopping es.ugr.frailty.location service
04-23 16:00:23.121+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21596)
04-23 16:00:23.121+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:00:23.121+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:23.131+0200 E/CAPI_APPFW_APP_CONTROL(21596): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:23.131+0200 E/location(21596): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:23.131+0200 I/CAPI_APPFW_APPLICATION(21596): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:23.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:23.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:23.181+0200 W/LOCATION(21596): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:23.181+0200 I/LOCATION(21596): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:23.181+0200 I/LOCATION(21596): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:23.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:23.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:00:23.281+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:23.281+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:23.281+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:23.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:23.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:23.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.641+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:23.641+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:23.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:23.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:23.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:23.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:23.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:23.821+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2c360
04-23 16:00:23.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d598]
04-23 16:00:23.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:23.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:23.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:23.891+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:23.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:23.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:23.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:23.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:23.921+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:23.921+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:23.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:23.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:23.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:23.921+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:23.921+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:23.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:23.921+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:23.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:23.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:23.941+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:23.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:23.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:24.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:24.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:24.011+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:24.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:24.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:24.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:24.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d598
04-23 16:00:24.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01ec8]
04-23 16:00:24.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:24.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:24.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:24.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:24.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:24.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:24.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:24.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:24.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:24.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:24.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:24.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:24.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:24.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:24.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:24.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:24.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:24.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:24.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:24.191+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:24.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:24.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:24.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:24.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:24.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:24.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:24.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:24.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01ec8
04-23 16:00:24.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:24.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:24.431+0200 W/AUL     (21615): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:24.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:24.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:24.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21579
04-23 16:00:24.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:24.431+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21579
04-23 16:00:24.431+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21579)
04-23 16:00:24.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:24.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:24.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:24.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:25.001+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.131+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:25.141+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:25.141+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:25.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:25.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:25.161+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21617
04-23 16:00:25.161+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:25.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:25.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21617
04-23 16:00:25.211+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21617) type(svcapp) bg(0)
04-23 16:00:25.211+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21617]
04-23 16:00:25.221+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21617)
04-23 16:00:25.221+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:25.221+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:25.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:25.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21617
04-23 16:00:25.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:25.241+0200 E/CAPI_APPFW_APPLICATION(21617): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:25.241+0200 E/CAPI_APPFW_APPLICATION(21617): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:25.241+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21617) was created
04-23 16:00:25.261+0200 W/LOCATION(21617): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:25.261+0200 E/LOCATION(21617): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:25.261+0200 E/PKGMGR_INFO(21617): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:25.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:25.261+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:25.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21617
04-23 16:00:25.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:25.291+0200 I/LOCATION(21617): location.c: location_new(269) > method: 0
04-23 16:00:25.291+0200 W/LOCATION(21617): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:25.291+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:25.301+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:25.301+0200 W/LOCATION(21617): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:25.311+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:25.311+0200 W/LOCATION(21617): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:25.311+0200 W/LOCATION(21617): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:25.311+0200 W/LOCATION(21617): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:25.311+0200 W/LOCATION(21617): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:25.331+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:25.341+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:25.341+0200 W/LOCATION(21617): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:25.341+0200 W/LOCATION(21617): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:25.351+0200 W/LOCATION(21617): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:25.351+0200 W/LOCATION(21617): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:25.351+0200 W/LOCATION(21617): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:25.371+0200 W/LOCATION(21617): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:25.371+0200 I/LOCATION(21617): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf798fc18
04-23 16:00:25.371+0200 I/LOCATION(21617): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:25.371+0200 I/LOCATION(21617): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf798fc18
04-23 16:00:25.371+0200 I/LOCATION(21617): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:25.371+0200 I/location(21617): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:25.401+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:25.401+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.421+0200 I/LOCATION(21617): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:25.461+0200 W/LOCATION(21617): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:25.461+0200 W/LOCATION(21617): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:25.461+0200 I/LOCATION(21617): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:25.571+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:25.571+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:25.571+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:25.571+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:25.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:25.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:25.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:25.581+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:25.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:25.581+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:25.581+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:25.581+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:25.581+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:25.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:25.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.631+0200 W/LOCATION(21617): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:25.631+0200 W/LOCATION(21617): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:25.711+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:25.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e17e78]
04-23 16:00:25.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:25.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:25.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:25.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:25.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:25.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:25.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:25.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:25.771+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:25.771+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:25.771+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:25.771+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:25.771+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:25.771+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:25.771+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:25.771+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:25.771+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:25.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:25.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:25.791+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:25.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:25.801+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:25.801+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:25.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:25.811+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5921477), time2(5908847)
04-23 16:00:25.811+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:00:25.811+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:25.811+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:25.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:25.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:25.861+0200 W/LOCATION(21617): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:25.861+0200 I/LOCATION(21617): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:25.861+0200 I/LOCATION(21617): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:25.861+0200 I/location(21617): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:25.951+0200 I/LOCATION(21617): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:26.001+0200 W/AUL     (21617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:26.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:26.001+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:26.001+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:26.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21617
04-23 16:00:26.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:26.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:26.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:26.011+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.011+0200 I/utils   (19708): specific action
04-23 16:00:26.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.021+0200 W/AUL     (21617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:26.021+0200 I/location(21617): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:26.021+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:26.021+0200 W/CAPI_APPFW_APP_CONTROL(21617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.021+0200 I/utils   (21617): specific action
04-23 16:00:26.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:26.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:26.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:26.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:26.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:26.031+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.031+0200 I/utils   (21185): specific action
04-23 16:00:26.031+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.031+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.031+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.031+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:26.031+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:26.031+0200 I/recorder(21185): guardando datos en local
04-23 16:00:26.031+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:26.031+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:26.031+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:26.201+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:26.201+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:26.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:26.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:26.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:26.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:26.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:26.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:26.411+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:26.411+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:26.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:26.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:26.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:26.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:26.491+0200 I/LOCATION(21617): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:26.601+0200 I/heartrate(21513): capturing data from es.ugr.frailty.heartrate
04-23 16:00:26.601+0200 I/heartrate(21513): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:00:26.641+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11216176c6f63152449202
