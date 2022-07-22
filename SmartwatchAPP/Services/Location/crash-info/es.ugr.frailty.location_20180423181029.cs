S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 2428
Date: 2018-04-23 18:10:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f7e52d, r5   = 0xf7253f98
r6   = 0xffde6658, r7   = 0xffde6508
r8   = 0xf7250c18, r9   = 0x00000000
r10  = 0xffde65e4, fp   = 0xffde6658
ip   = 0x00000001, sp   = 0xffde64e0
lr   = 0xf6f7e539, pc   = 0xf6fe7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10604 KB
Buffers:     68380 KB
Cached:     217972 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12152 KB
VmRSS:       12152 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2428 TID = 2428
2428 2448 

Maps Information
f3e49000 f4648000 rw-p [stack:2448]
f464f000 f4651000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4659000 f465d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4666000 f4668000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4670000 f4673000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4682000 f4687000 r-xp /usr/lib/libsystem.so.0.0.0
f4692000 f4695000 r-xp /lib/libattr.so.1.1.0
f469d000 f46ad000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46b5000 f46be000 r-xp /usr/lib/libedbus.so.1.7.99
f46c6000 f46c7000 r-xp /usr/lib/libresponse.so.0.2.96
f46d0000 f46d5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f77000 f607d000 r-xp /usr/lib/libicuuc.so.57.1
f6093000 f621b000 r-xp /usr/lib/libicui18n.so.57.1
f622b000 f6238000 r-xp /usr/lib/libail.so.0.1.0
f6241000 f6248000 r-xp /usr/lib/libminizip.so.1.0.0
f6251000 f63fa000 r-xp /usr/lib/libcrypto.so.1.0.0
f641a000 f6461000 r-xp /usr/lib/libssl.so.1.0.0
f646d000 f646f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6477000 f647e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6487000 f648e000 r-xp /lib/libcrypt-2.13.so
f64bf000 f64c2000 r-xp /lib/libcap.so.2.21
f64ca000 f64cc000 r-xp /usr/lib/libiri.so
f64d4000 f651d000 r-xp /usr/lib/libmdm.so.1.2.69
f6525000 f652b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6533000 f6556000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6560000 f6562000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f656a000 f6587000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6590000 f6594000 r-xp /usr/lib/libsmack.so.1.0.0
f659d000 f65b6000 r-xp /usr/lib/libnetwork.so.0.0.0
f65bf000 f65c7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65cf000 f65d5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65de000 f65e0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65e9000 f65f9000 r-xp /lib/libresolv-2.13.so
f65fd000 f6615000 r-xp /usr/lib/liblzma.so.5.0.3
f661e000 f6620000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6628000 f6642000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f664a000 f6679000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6682000 f6691000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f669b000 f66a5000 r-xp /usr/lib/libsensord-shared.so
f66ae000 f6781000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f678c000 f67a2000 r-xp /lib/libz.so.1.2.5
f67aa000 f67af000 r-xp /usr/lib/libffi.so.5.0.10
f67b7000 f67b8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67c0000 f67d0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67d8000 f67f1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f67f9000 f67fb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6803000 f6878000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6882000 f6888000 r-xp /lib/librt-2.13.so
f6891000 f68af000 r-xp /usr/lib/libsystemd.so.0.4.0
f68b9000 f68ba000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68c2000 f68e5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68ed000 f68f2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f68fa000 f6924000 r-xp /usr/lib/libdbus-1.so.3.8.12
f692d000 f6944000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f694c000 f69b5000 r-xp /lib/libm-2.13.so
f69be000 f6a52000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a65000 f6a6a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a72000 f6a79000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a81000 f6aab000 r-xp /usr/lib/libsensor.so.1.9.6
f6ab4000 f6b80000 r-xp /usr/lib/libxml2.so.2.7.8
f6b8d000 f6b8f000 r-xp /usr/lib/libiniparser.so.0
f6b98000 f6b9e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ba7000 f6c77000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c78000 f6cac000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cb5000 f6cf1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6cf9000 f6cfc000 r-xp /usr/lib/libbundle.so.0.1.22
f6d04000 f6d0a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d12000 f6d53000 r-xp /usr/lib/libeina.so.1.7.99
f6d5c000 f6d73000 r-xp /usr/lib/libecore.so.1.7.99
f6d8a000 f6d93000 r-xp /usr/lib/libvconf.so.0.2.45
f6d9b000 f6daf000 r-xp /lib/libpthread-2.13.so
f6dba000 f6dc7000 r-xp /usr/lib/libaul.so.0.1.0
f6dd1000 f6dd3000 r-xp /lib/libdl-2.13.so
f6ddc000 f6de7000 r-xp /lib/libunwind.so.8.0.1
f6e14000 f6e1c000 r-xp /lib/libgcc_s-4.6.so.1
f6e1d000 f6f41000 r-xp /lib/libc-2.13.so
f6f4f000 f6f51000 r-xp /usr/lib/libdlog.so.0.0.0
f6f59000 f6f65000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f6e000 f6f73000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f7b000 f6f8a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f92000 f6f96000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6f9f000 f6fa2000 r-xp /usr/lib/libappcore-agent.so.1.1
f6faa000 f6fac000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fb4000 f6fb8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fc0000 f6fdd000 r-xp /lib/ld-2.13.so
f6fe6000 f6fe9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6fe9000 f6fed000 r-xp /usr/lib/libsys-assert.so
f7220000 f7291000 rw-p [heap]
ffdc7000 ffde8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2428)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6fe7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f7e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c853f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c83c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c8fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6c95be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6c95dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cca75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cc51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c83c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c8fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6c95be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6c95dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cc7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cc8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ccc8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf6fb60bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf465a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf672d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6bdafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bdc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d6cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d67b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d685a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d68879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fa0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fa07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6fe74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e3485c) [/lib/libc.so.6] + 0x1785c
29: (0xf6fe6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ta from es.ugr.frailty.heartrate
04-23 18:10:27.821+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:27.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:10:27.851+0200 W/LOCATION( 2428): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 18:10:27.851+0200 E/LOCATION( 2428): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 18:10:27.851+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2428
04-23 18:10:27.851+0200 E/PKGMGR_INFO( 2428): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 18:10:27.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:10:27.861+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:27.881+0200 I/LOCATION( 2428): location.c: location_new(269) > method: 0
04-23 18:10:27.881+0200 W/LOCATION( 2428): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:27.881+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:27.881+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:27.891+0200 W/LOCATION( 2428): module-internal.c: module_new(311) > module (gps) open success
04-23 18:10:27.891+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:10:27.891+0200 W/LOCATION( 2428): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:10:27.891+0200 W/LOCATION( 2428): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:27.891+0200 W/LOCATION( 2428): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:10:27.891+0200 W/LOCATION( 2428): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:10:27.921+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:10:27.921+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:10:27.921+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:27.921+0200 W/LOCATION( 2428): module-internal.c: module_new(311) > module (wps) open success
04-23 18:10:27.931+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:27.931+0200 W/LOCATION( 2428): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 18:10:27.931+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:27:933,10.640000,8.050000,8.890000
04-23 18:10:27.931+0200 W/LOCATION( 2428): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 18:10:27.931+0200 W/LOCATION( 2428): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:10:27.931+0200 W/LOCATION( 2428): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:10:27.931+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:27:937,9.537791,1.127020,2.361716
04-23 18:10:27.951+0200 W/LOCATION( 2428): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 18:10:27.951+0200 I/LOCATION( 2428): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7250c18
04-23 18:10:27.951+0200 I/LOCATION( 2428): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 18:10:27.951+0200 I/LOCATION( 2428): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7250c18
04-23 18:10:27.951+0200 I/LOCATION( 2428): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 18:10:27.961+0200 I/location( 2428): es.ugr.frailty.location: creado servicio de localización
04-23 18:10:28.001+0200 I/LOCATION( 2428): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 18:10:28.021+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:28.021+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:28.041+0200 W/LOCATION( 2428): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:10:28.041+0200 W/LOCATION( 2428): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:10:28.041+0200 I/LOCATION( 2428): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:28.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:10:28.101+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:10:28.101+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:10:28.101+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:28.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:10:28.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:10:28.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:10:28.101+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:10:28.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:10:28.101+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:10:28.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:10:28.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:10:28.121+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.141+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.151+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:133,2.100000,8.050000,-8.260000
04-23 18:10:28.151+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:148,9.329616,1.129412,3.261417
04-23 18:10:28.161+0200 W/LOCATION( 2428): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:10:28.161+0200 W/LOCATION( 2428): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:10:28.221+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:28.221+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:28.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:28.271+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf3c02340]
04-23 18:10:28.271+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:10:28.271+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:10:28.271+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:10:28.271+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:10:28.281+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:28.281+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:28.291+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:28.301+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:28.301+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:10:28.301+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:10:28.301+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:28.301+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:10:28.301+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:10:28.301+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:10:28.301+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:28.301+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:10:28.301+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:10:28.311+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:28.321+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.331+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:28.331+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:10:28.331+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:10:28.331+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(13723993), time2(13713848)
04-23 18:10:28.331+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:10:28.331+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:10:28.331+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:10:28.331+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:10:28.331+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.331+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:28.371+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:342,12.740000,-4.830000,-3.850000
04-23 18:10:28.371+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:334,9.360723,1.493121,2.366502
04-23 18:10:28.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:28.421+0200 W/LOCATION( 2428): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:10:28.421+0200 I/LOCATION( 2428): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:28.421+0200 I/LOCATION( 2428): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:28.421+0200 I/location( 2428): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:10:28.421+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:28.421+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:28.521+0200 I/LOCATION( 2428): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:28.521+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.521+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.531+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:533,9.437292,1.378266,1.667797
04-23 18:10:28.531+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:534,1.750000,-4.900000,-1.400000
04-23 18:10:28.571+0200 E/location( 2428): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:10:28.571+0200 W/AUL     ( 2428): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:10:28.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:28.571+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2428
04-23 18:10:28.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2259
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 I/utils   ( 2259): specific action
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:10:28.581+0200 W/AUL     ( 2428): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2259)
04-23 18:10:28.581+0200 I/location( 2428): request sent to service es.ugr.frailty.servicemanager
04-23 18:10:28.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2428): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 I/utils   ( 2428): specific action
04-23 18:10:28.581+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2259
04-23 18:10:28.581+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2264
04-23 18:10:28.581+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.581+0200 I/utils   ( 2264): specific action
04-23 18:10:28.591+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.591+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.591+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:28.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2259), cmd(0)
04-23 18:10:28.591+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2264)
04-23 18:10:28.591+0200 I/servicemanager( 2259): request sent to service es.ugr.frailty.recorder
04-23 18:10:28.591+0200 I/servicemanager( 2259): requesting to save local data
04-23 18:10:28.591+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.591+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:28.591+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:28.591+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(2264), cmd(0)
04-23 18:10:28.591+0200 I/recorder( 2264): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:10:28.591+0200 I/recorder( 2264): guardando datos en local
04-23 18:10:28.621+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:28.621+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:28.731+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.731+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.741+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:735,-5.390000,-5.320000,-4.970000
04-23 18:10:28.741+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:735,9.530612,1.136591,1.852045
04-23 18:10:28.801+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:28.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:28.801+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:28.821+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.821+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.821+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:825,9.523434,1.395016,1.832902
04-23 18:10:28.821+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:826,-2.660000,1.190000,-8.890000
04-23 18:10:28.831+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:28.831+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:28.841+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.841+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.851+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:853,9.303294,1.615155,1.990828
04-23 18:10:28.851+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:853,-0.840000,1.050000,-10.080000
04-23 18:10:28.861+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.861+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.871+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:871,-2.660000,1.190000,-9.940000
04-23 18:10:28.871+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:867,9.341579,1.674976,2.189433
04-23 18:10:28.881+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.881+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.891+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:889,-10.080000,2.590000,-11.270000
04-23 18:10:28.891+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:889,9.341579,2.060220,2.139183
04-23 18:10:28.901+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.901+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.901+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:907,9.391829,1.902294,2.098505
04-23 18:10:28.901+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:907,-21.559999,1.960000,-9.310000
04-23 18:10:28.921+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.921+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.931+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:930,-14.490000,2.240000,-10.080000
04-23 18:10:28.931+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:930,9.504292,1.969293,1.983650
04-23 18:10:28.941+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.941+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.951+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:953,-5.320000,6.930000,-9.170000
04-23 18:10:28.951+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:953,9.399008,2.074577,2.285146
04-23 18:10:28.961+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.961+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.971+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:967,-0.560000,3.010000,-10.010000
04-23 18:10:28.971+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:968,9.346365,1.818545,2.165504
04-23 18:10:28.981+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:28.981+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:28.991+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:28:989,9.509077,2.256432,2.132005
04-23 18:10:28.991+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:28:989,-13.230000,3.920000,-9.170000
04-23 18:10:29.001+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.001+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.001+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:8,9.351151,2.390430,2.304288
04-23 18:10:29.011+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:7,-25.830000,4.340000,-5.600000
04-23 18:10:29.021+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.021+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.021+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:29.021+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:29.031+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:30,9.281759,2.639283,2.151148
04-23 18:10:29.031+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:30,-28.350000,3.570000,-3.430000
04-23 18:10:29.041+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.041+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.051+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:53,-37.310001,5.600000,-1.540000
04-23 18:10:29.051+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:53,9.408579,2.627320,2.421536
04-23 18:10:29.061+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.061+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.061+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:68,-44.029999,1.190000,1.750000
04-23 18:10:29.071+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:70,9.198010,2.189433,2.397608
04-23 18:10:29.081+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.081+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.081+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:87,9.413363,2.093720,2.184647
04-23 18:10:29.081+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:87,-44.660000,-0.910000,2.310000
04-23 18:10:29.101+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.101+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.101+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:107,-61.180000,3.290000,1.680000
04-23 18:10:29.101+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:108,9.616754,2.505285,2.524428
04-23 18:10:29.121+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.121+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.131+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:130,-98.489998,4.270000,6.160000
04-23 18:10:29.131+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:130,9.152546,3.098706,2.732604
04-23 18:10:29.141+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.141+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.151+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:153,8.812766,2.060220,1.660619
04-23 18:10:29.151+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:153,-129.430008,-7.840000,11.480000
04-23 18:10:29.161+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.161+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.171+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:170,10.135997,0.648455,2.105684
04-23 18:10:29.171+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:170,-115.220001,-11.620000,14.350000
04-23 18:10:29.181+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.181+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.181+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:187,9.655040,1.586441,2.792424
04-23 18:10:29.181+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:187,-77.840004,8.610000,6.020000
04-23 18:10:29.201+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.201+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.201+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:207,-88.059998,5.390000,7.350000
04-23 18:10:29.201+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:207,8.848659,1.945365,2.727818
04-23 18:10:29.221+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.221+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.221+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:29.221+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:29.231+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:230,9.198010,1.294517,2.785245
04-23 18:10:29.231+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:230,-103.040001,-8.050000,12.320000
04-23 18:10:29.251+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.271+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:256,-92.750000,-5.390000,10.150000
04-23 18:10:29.281+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.291+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:290,-81.690002,-1.400000,6.720000
04-23 18:10:29.291+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.301+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:304,-79.870003,2.800000,7.210000
04-23 18:10:29.311+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.311+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.321+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:317,9.698111,0.808774,2.797210
04-23 18:10:29.321+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.331+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:330,9.611969,0.681954,1.890330
04-23 18:10:29.331+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.331+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:336,9.475577,0.626920,2.426322
04-23 18:10:29.331+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.341+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:341,9.444471,0.203390,3.180061
04-23 18:10:29.341+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.361+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:347,9.332008,0.337388,3.337988
04-23 18:10:29.361+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.361+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:319,-62.510002,0.980000,7.350000
04-23 18:10:29.361+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:368,9.324830,0.646062,2.868994
04-23 18:10:29.361+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.371+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.381+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:373,9.470792,0.275175,2.373680
04-23 18:10:29.381+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:377,-31.920000,-0.770000,4.130000
04-23 18:10:29.381+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.391+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.391+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:395,-24.500000,-3.150000,4.550000
04-23 18:10:29.391+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:393,9.652647,0.244068,2.246860
04-23 18:10:29.401+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.401+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.411+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:405,-5.320000,-4.340000,5.040000
04-23 18:10:29.411+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:406,9.609575,0.430708,2.490928
04-23 18:10:29.411+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.421+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.421+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:427,9.279366,0.662812,2.581856
04-23 18:10:29.421+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:420,21.700001,-0.840000,1.610000
04-23 18:10:29.421+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.431+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:29.431+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:29.431+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:434,27.020000,2.310000,-1.260000
04-23 18:10:29.431+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.441+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:444,13.230000,1.890000,-1.750000
04-23 18:10:29.441+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.441+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.451+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:452,3.570000,0.700000,-1.610000
04-23 18:10:29.451+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:452,9.477970,0.725025,2.699104
04-23 18:10:29.461+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.461+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:468,2.940000,2.380000,-0.350000
04-23 18:10:29.461+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.471+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:474,9.372685,0.528814,2.634498
04-23 18:10:29.481+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.481+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:487,9.430114,0.547956,2.991028
04-23 18:10:29.481+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.491+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:10:29.491+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:487,15.750000,1.470000,-1.610000
04-23 18:10:29.501+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.501+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.501+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:507,9.561719,0.966700,2.868994
04-23 18:10:29.501+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:507,23.940001,1.470000,-4.480000
04-23 18:10:29.521+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.531+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:530,14.420000,1.750000,-3.500000
04-23 18:10:29.531+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.531+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:536,9.207582,1.105484,2.790031
04-23 18:10:29.541+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.541+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.551+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:553,7.210000,-1.890000,-2.450000
04-23 18:10:29.551+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:553,9.305687,0.564706,3.014957
04-23 18:10:29.561+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.561+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.571+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:570,19.110001,-2.170000,-1.820000
04-23 18:10:29.571+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:570,9.482756,0.638884,2.916851
04-23 18:10:29.581+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.581+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.591+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:589,9.506684,0.978664,2.696711
04-23 18:10:29.591+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:588,26.250000,-0.980000,-2.450000
04-23 18:10:29.601+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.601+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.611+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:607,9.870000,-0.070000,-1.330000
04-23 18:10:29.611+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:607,9.415757,1.217947,2.694318
04-23 18:10:29.621+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.621+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.621+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:29.621+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:29.631+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:629,9.243474,1.100698,2.725425
04-23 18:10:29.631+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:629,-5.250000,-2.170000,0.210000
04-23 18:10:29.641+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.651+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.651+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:652,0.350000,-4.200000,0.490000
04-23 18:10:29.651+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:654,9.521042,0.519243,2.790031
04-23 18:10:29.661+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.661+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.671+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:668,9.492328,0.519243,2.885744
04-23 18:10:29.671+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:669,19.879999,-1.610000,-2.240000
04-23 18:10:29.681+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.691+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:689,9.516255,1.055235,2.615355
04-23 18:10:29.691+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.701+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:699,25.270000,-2.100000,-2.450000
04-23 18:10:29.701+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.711+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:711,9.391829,1.438086,2.589034
04-23 18:10:29.711+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.781+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.821+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:29.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 18:10:29.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:10:29.831+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:29.831+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:10:29.831+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:29.831+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:29.851+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:785,9.449257,1.074377,2.622534
04-23 18:10:29.851+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.861+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:860,9.446864,0.222532,2.115255
04-23 18:10:29.861+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:29.861+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.871+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:875,9.801002,0.473779,2.514857
04-23 18:10:29.881+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.881+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:888,9.662218,1.524228,2.646462
04-23 18:10:29.881+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:29.881+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:10:29.881+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:10:29.881+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:29.901+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.911+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:907,9.066404,1.311267,2.493321
04-23 18:10:29.911+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.921+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:924,9.516255,0.875773,2.766103
04-23 18:10:29.921+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:721,14.490000,-1.050000,-1.050000
04-23 18:10:29.921+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.921+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.931+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:932,-2.170000,-3.920000,0.700000
04-23 18:10:29.931+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.931+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:932,9.576077,0.299103,2.569891
04-23 18:10:29.931+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.931+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:937,0.140000,-5.880000,2.100000
04-23 18:10:29.931+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.941+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:942,24.430000,-3.640000,-1.330000
04-23 18:10:29.941+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.941+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:947,28.139999,0.350000,-3.290000
04-23 18:10:29.941+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.941+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:941,9.643075,0.617348,2.072184
04-23 18:10:29.951+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.951+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:954,7.700000,0.980000,-0.630000
04-23 18:10:29.951+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.951+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:958,-2.730000,-5.740000,0.630000
04-23 18:10:29.951+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.951+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:955,9.717253,1.261017,2.380858
04-23 18:10:29.951+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.961+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:962,10.150000,-2.940000,1.260000
04-23 18:10:29.961+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.961+0200 I/LOCATION( 2428): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:29.961+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:966,31.570000,1.890000,-1.330000
04-23 18:10:29.961+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.961+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:964,9.324830,1.655833,2.904887
04-23 18:10:29.961+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.971+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:972,27.440001,3.990000,-0.350000
04-23 18:10:29.971+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.971+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:976,14.840000,4.620000,0.840000
04-23 18:10:29.971+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.971+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:974,9.269794,1.289732,2.306681
04-23 18:10:29.971+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:980,9.730000,-2.590000,0.700000
04-23 18:10:29.971+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.971+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.981+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:983,26.320000,-3.150000,1.680000
04-23 18:10:29.981+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.981+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:988,73.919998,2.800000,1.680000
04-23 18:10:29.981+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:29.981+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:984,9.588040,0.059821,2.304288
04-23 18:10:29.981+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:29.991+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:29:992,78.260002,7.840000,-10.640000
04-23 18:10:29.991+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:29:994,9.609575,-0.009571,2.572284
04-23 18:10:29.991+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.001+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:30.001+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:30:3,9.504292,1.852045,2.921637
04-23 18:10:30.001+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:30:7,30.380001,2.310000,0.630000
04-23 18:10:30.001+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.001+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:30:11,8.738588,2.553142,2.237289
04-23 18:10:30.021+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:30.021+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:30:28,34.790001,-5.810000,9.520000
04-23 18:10:30.021+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.021+0200 I/heartrate( 2405): capturing data from es.ugr.frailty.heartrate
04-23 18:10:30.021+0200 I/heartrate( 2405): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:30.031+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:30:32,9.650253,0.380459,2.488536
04-23 18:10:30.041+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:30.051+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:30:52,95.340004,2.100000,4.060000
04-23 18:10:30.051+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.051+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:30:56,9.497113,0.964308,2.254039
04-23 18:10:30.061+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:30.061+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:30:67,173.460007,3.710000,1.260000
04-23 18:10:30.061+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.071+0200 I/accelerometer( 2378): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:30:72,9.408579,0.382852,2.337788
04-23 18:10:30.091+0200 I/accelerometer( 2378): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:30.091+0200 I/gyroscope( 2391): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:30.091+0200 I/gyroscope( 2391): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:30:99,233.029999,5.320000,-8.540000
04-23 18:10:30.101+0200 W/CRASH_MANAGER( 2332): worker.c: worker_job(1205) > 11024286c6f63152449982
