S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6244
Date: 2018-04-23 20:06:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf739e52d, r5   = 0xf7450f98
r6   = 0xffc29d20, r7   = 0xffc29bd0
r8   = 0xf744dc18, r9   = 0x00000000
r10  = 0xffc29cac, fp   = 0xffc29d20
ip   = 0x00000001, sp   = 0xffc29ba8
lr   = 0xf739e539, pc   = 0xf7407228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111064 KB
Buffers:     37540 KB
Cached:     183108 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12000 KB
VmRSS:       11996 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6244 TID = 6244
6244 6247 

Maps Information
f4269000 f4a68000 rw-p [stack:6247]
f4a6f000 f4a71000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a79000 f4a7d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a86000 f4a88000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a90000 f4a93000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aa2000 f4aa7000 r-xp /usr/lib/libsystem.so.0.0.0
f4ab2000 f4ab5000 r-xp /lib/libattr.so.1.1.0
f4abd000 f4acd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ad5000 f4ade000 r-xp /usr/lib/libedbus.so.1.7.99
f4ae6000 f4ae7000 r-xp /usr/lib/libresponse.so.0.2.96
f4af0000 f4af5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6397000 f649d000 r-xp /usr/lib/libicuuc.so.57.1
f64b3000 f663b000 r-xp /usr/lib/libicui18n.so.57.1
f664b000 f6658000 r-xp /usr/lib/libail.so.0.1.0
f6661000 f6668000 r-xp /usr/lib/libminizip.so.1.0.0
f6671000 f681a000 r-xp /usr/lib/libcrypto.so.1.0.0
f683a000 f6881000 r-xp /usr/lib/libssl.so.1.0.0
f688d000 f688f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6897000 f689e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68a7000 f68ae000 r-xp /lib/libcrypt-2.13.so
f68df000 f68e2000 r-xp /lib/libcap.so.2.21
f68ea000 f68ec000 r-xp /usr/lib/libiri.so
f68f4000 f693d000 r-xp /usr/lib/libmdm.so.1.2.69
f6945000 f694b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6953000 f6976000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6980000 f6982000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f698a000 f69a7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69b0000 f69b4000 r-xp /usr/lib/libsmack.so.1.0.0
f69bd000 f69d6000 r-xp /usr/lib/libnetwork.so.0.0.0
f69df000 f69e7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69ef000 f69f5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69fe000 f6a00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a09000 f6a19000 r-xp /lib/libresolv-2.13.so
f6a1d000 f6a35000 r-xp /usr/lib/liblzma.so.5.0.3
f6a3e000 f6a40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a48000 f6a62000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a6a000 f6a99000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aa2000 f6ab1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6abb000 f6ac5000 r-xp /usr/lib/libsensord-shared.so
f6ace000 f6ba1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bac000 f6bc2000 r-xp /lib/libz.so.1.2.5
f6bca000 f6bcf000 r-xp /usr/lib/libffi.so.5.0.10
f6bd7000 f6bd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be0000 f6bf0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bf8000 f6c11000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c19000 f6c1b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c23000 f6c98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ca2000 f6ca8000 r-xp /lib/librt-2.13.so
f6cb1000 f6ccf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cd9000 f6cda000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ce2000 f6d05000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d0d000 f6d12000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d1a000 f6d44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d4d000 f6d64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d6c000 f6dd5000 r-xp /lib/libm-2.13.so
f6dde000 f6e72000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e85000 f6e8a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e92000 f6e99000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ea1000 f6ecb000 r-xp /usr/lib/libsensor.so.1.9.6
f6ed4000 f6fa0000 r-xp /usr/lib/libxml2.so.2.7.8
f6fad000 f6faf000 r-xp /usr/lib/libiniparser.so.0
f6fb8000 f6fbe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fc7000 f7097000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7098000 f70cc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70d5000 f7111000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7119000 f711c000 r-xp /usr/lib/libbundle.so.0.1.22
f7124000 f712a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7132000 f7173000 r-xp /usr/lib/libeina.so.1.7.99
f717c000 f7193000 r-xp /usr/lib/libecore.so.1.7.99
f71aa000 f71b3000 r-xp /usr/lib/libvconf.so.0.2.45
f71bb000 f71cf000 r-xp /lib/libpthread-2.13.so
f71da000 f71e7000 r-xp /usr/lib/libaul.so.0.1.0
f71f1000 f71f3000 r-xp /lib/libdl-2.13.so
f71fc000 f7207000 r-xp /lib/libunwind.so.8.0.1
f7234000 f723c000 r-xp /lib/libgcc_s-4.6.so.1
f723d000 f7361000 r-xp /lib/libc-2.13.so
f736f000 f7371000 r-xp /usr/lib/libdlog.so.0.0.0
f7379000 f7385000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f738e000 f7393000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f739b000 f73aa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73b2000 f73b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73bf000 f73c2000 r-xp /usr/lib/libappcore-agent.so.1.1
f73ca000 f73cc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73d4000 f73d8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73e0000 f73fd000 r-xp /lib/ld-2.13.so
f7406000 f7409000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7409000 f740d000 r-xp /usr/lib/libsys-assert.so
f741d000 f74ab000 rw-p [heap]
ffc0b000 ffc2c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6244)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7407228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf739e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70a53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ea75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70e51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70e7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70e8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70eff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a871fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a7a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b4d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ffafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ffc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf718cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7187b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71885a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7188879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73c0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73c07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74074f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf725485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7406f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 20:06:36.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:36.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6194
04-23 20:06:36.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:37.009+0200 W/LOCATION( 6194): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:37.009+0200 E/LOCATION( 6194): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:37.009+0200 E/PKGMGR_INFO( 6194): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:37.009+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:37.029+0200 I/LOCATION( 6194): location.c: location_new(269) > method: 0
04-23 20:06:37.029+0200 W/LOCATION( 6194): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:37.029+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:37.039+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:37.039+0200 W/LOCATION( 6194): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:37.039+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:37.049+0200 W/LOCATION( 6194): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:37.049+0200 W/LOCATION( 6194): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:37.049+0200 W/LOCATION( 6194): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:37.049+0200 W/LOCATION( 6194): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:37.069+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:37.069+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:37.079+0200 W/LOCATION( 6194): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:37.079+0200 W/LOCATION( 6194): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:37.079+0200 W/LOCATION( 6194): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:37.079+0200 W/LOCATION( 6194): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:37.079+0200 W/LOCATION( 6194): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:37.099+0200 W/LOCATION( 6194): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:37.099+0200 I/LOCATION( 6194): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75d0c18
04-23 20:06:37.099+0200 I/LOCATION( 6194): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:37.099+0200 I/LOCATION( 6194): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75d0c18
04-23 20:06:37.099+0200 I/LOCATION( 6194): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:37.099+0200 I/location( 6194): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:37.149+0200 I/LOCATION( 6194): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:37.189+0200 W/LOCATION( 6194): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:37.189+0200 W/LOCATION( 6194): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:37.189+0200 I/LOCATION( 6194): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:37.249+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:37.249+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:37.249+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:37.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:37.249+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:37.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:37.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:37.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:37.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:37.259+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:37.259+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:37.259+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:37.259+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:37.309+0200 W/LOCATION( 6194): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:37.309+0200 W/LOCATION( 6194): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:37.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:37.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:37.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:37.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:37.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d1b40]
04-23 20:06:37.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:37.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:37.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:37.449+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:37.459+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:37.459+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:37.469+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:37.479+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:37.479+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:37.479+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:37.479+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:37.479+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:37.479+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:37.479+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:37.479+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:37.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:37.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:37.489+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:37.489+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(872757), time2(869738)
04-23 20:06:37.489+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:06:37.489+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:37.489+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:37.489+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:37.489+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:37.499+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:37.499+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:37.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:37.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:37.589+0200 W/LOCATION( 6194): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:37.599+0200 I/LOCATION( 6194): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:37.599+0200 I/LOCATION( 6194): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:37.599+0200 I/location( 6194): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:37.699+0200 I/LOCATION( 6194): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:37.759+0200 E/location( 6194): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:37.759+0200 W/AUL     ( 6194): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:37.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:37.759+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6194
04-23 20:06:37.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:37.769+0200 W/AUL     ( 6194): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:37.769+0200 I/location( 6194): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:37.769+0200 I/location( 6194): stopping es.ugr.frailty.location service
04-23 20:06:37.769+0200 E/CAPI_APPFW_APP_CONTROL( 6194): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:06:37.769+0200 E/location( 6194): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:06:37.769+0200 I/CAPI_APPFW_APPLICATION( 6194): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:06:37.779+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.779+0200 I/utils   ( 5532): specific action
04-23 20:06:37.779+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.779+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.779+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.779+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:37.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:06:37.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:06:37.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:37.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:37.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:37.789+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:37.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:37.789+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:37.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5538), cmd(0)
04-23 20:06:37.789+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.789+0200 I/utils   ( 5538): specific action
04-23 20:06:37.789+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.789+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.789+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.789+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:37.789+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:37.789+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:37.809+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:37.809+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:37.809+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:37.839+0200 W/LOCATION( 6194): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:37.849+0200 I/LOCATION( 6194): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:37.849+0200 I/LOCATION( 6194): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:06:37.949+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:06:37.949+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:06:37.949+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:06:37.949+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:06:38.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.139+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:38.139+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:38.139+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:38.139+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d1b40
04-23 20:06:38.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d0a98]
04-23 20:06:38.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:38.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:38.189+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:38.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:38.199+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:38.199+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:38.209+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.219+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.219+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:38.219+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:38.219+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:38.219+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:38.219+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:38.219+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:38.219+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:38.219+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:38.219+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:38.229+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.249+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.249+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:38.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.309+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:38.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:38.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:38.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d0a98
04-23 20:06:38.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e71f0]
04-23 20:06:38.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:38.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:38.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:38.439+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:38.449+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:38.449+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:38.459+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.469+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.469+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:38.469+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:38.469+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:38.469+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:38.469+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:38.469+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:38.469+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:38.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:38.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:38.489+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.499+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:38.499+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:38.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:38.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:06:38.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:06:38.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:06:38.549+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e71f0
04-23 20:06:38.749+0200 W/AUL     ( 6206): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:06:38.749+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:06:38.749+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:06:38.749+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6170
04-23 20:06:38.749+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:06:38.749+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6170
04-23 20:06:38.749+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6170)
04-23 20:06:39.779+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:06:46.949+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:06:46.949+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:06:46.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:46.949+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:46.959+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6244
04-23 20:06:46.959+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:47.009+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6244
04-23 20:06:47.009+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6244) type(svcapp) bg(0)
04-23 20:06:47.019+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6244)
04-23 20:06:47.019+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:06:47.019+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:47.019+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6244]
04-23 20:06:47.019+0200 E/CAPI_APPFW_APPLICATION( 6244): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:47.019+0200 E/CAPI_APPFW_APPLICATION( 6244): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:47.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:47.039+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6244
04-23 20:06:47.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:47.049+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6244) was created
04-23 20:06:47.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:47.069+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6244
04-23 20:06:47.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:47.089+0200 W/LOCATION( 6244): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:06:47.089+0200 E/LOCATION( 6244): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:06:47.089+0200 E/PKGMGR_INFO( 6244): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:06:47.099+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:47.109+0200 I/LOCATION( 6244): location.c: location_new(269) > method: 0
04-23 20:06:47.109+0200 W/LOCATION( 6244): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:47.119+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:47.129+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:47.129+0200 W/LOCATION( 6244): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:47.129+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:47.139+0200 W/LOCATION( 6244): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:47.139+0200 W/LOCATION( 6244): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:47.139+0200 W/LOCATION( 6244): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:47.139+0200 W/LOCATION( 6244): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:47.159+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:47.159+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:06:47.169+0200 W/LOCATION( 6244): module-internal.c: module_new(311) > module (wps) open success
04-23 20:06:47.169+0200 W/LOCATION( 6244): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:06:47.169+0200 W/LOCATION( 6244): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:06:47.169+0200 W/LOCATION( 6244): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:47.169+0200 W/LOCATION( 6244): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:47.189+0200 W/LOCATION( 6244): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:06:47.189+0200 I/LOCATION( 6244): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf744dc18
04-23 20:06:47.189+0200 I/LOCATION( 6244): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:06:47.189+0200 I/LOCATION( 6244): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf744dc18
04-23 20:06:47.189+0200 I/LOCATION( 6244): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:06:47.189+0200 I/location( 6244): es.ugr.frailty.location: creado servicio de localización
04-23 20:06:47.239+0200 I/LOCATION( 6244): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:06:47.279+0200 W/LOCATION( 6244): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:47.279+0200 W/LOCATION( 6244): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:47.279+0200 I/LOCATION( 6244): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:06:47.349+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:06:47.349+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:47.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:47.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:06:47.359+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:06:47.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:06:47.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:06:47.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:06:47.359+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:06:47.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:06:47.359+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:06:47.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:06:47.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:06:47.409+0200 W/LOCATION( 6244): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:06:47.409+0200 W/LOCATION( 6244): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:06:47.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:47.529+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f257e8]
04-23 20:06:47.529+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:06:47.529+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:06:47.529+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:06:47.529+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:06:47.539+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:47.539+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:47.549+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:47.559+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:47.559+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:06:47.559+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:06:47.559+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:06:47.559+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:06:47.559+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:06:47.559+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:06:47.559+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:06:47.559+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:06:47.559+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:06:47.569+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:47.579+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:06:47.579+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:06:47.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:47.619+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:06:47.639+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:06:47.639+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(882900), time2(869738)
04-23 20:06:47.639+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:06:47.639+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:06:47.639+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:06:47.639+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:06:47.659+0200 W/LOCATION( 6244): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:06:47.659+0200 I/LOCATION( 6244): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:47.659+0200 I/LOCATION( 6244): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:06:47.659+0200 I/location( 6244): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:06:47.739+0200 I/LOCATION( 6244): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:06:47.789+0200 E/location( 6244): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:06:47.789+0200 W/AUL     ( 6244): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:06:47.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:47.789+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6244
04-23 20:06:47.799+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:06:47.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.799+0200 I/utils   ( 5532): specific action
04-23 20:06:47.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.799+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.799+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:06:47.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:47.799+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:47.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:06:47.809+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:47.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:06:47.809+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:06:47.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5538), cmd(0)
04-23 20:06:47.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.809+0200 I/utils   ( 5538): specific action
04-23 20:06:47.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.809+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:06:47.819+0200 I/recorder( 5538): guardando datos en local
04-23 20:06:47.819+0200 W/AUL     ( 6244): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:06:47.819+0200 I/location( 6244): request sent to service es.ugr.frailty.servicemanager
04-23 20:06:47.819+0200 W/CAPI_APPFW_APP_CONTROL( 6244): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:47.819+0200 I/utils   ( 6244): specific action
04-23 20:06:47.819+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:06:47.819+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:06:47.819+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:06:48.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:48.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:48.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:48.579+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:06:48.869+0200 I/servicemanager( 5532): es.ugr.frailty.gravity alive timeout
04-23 20:06:48.869+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:06:48.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:06:48.869+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:06:48.879+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6253
04-23 20:06:48.879+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:06:48.929+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6253
04-23 20:06:48.929+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(6253) type(svcapp) bg(0)
04-23 20:06:48.929+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6253)
04-23 20:06:48.929+0200 I/servicemanager( 5532): es.ugr.frailty.gravity launch request sent!
04-23 20:06:48.929+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:06:48.939+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6253]
04-23 20:06:48.949+0200 E/CAPI_APPFW_APPLICATION( 6253): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:48.949+0200 E/CAPI_APPFW_APPLICATION( 6253): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:06:48.949+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6253) was created
04-23 20:06:48.949+0200 I/utils   ( 6253): trying to start service: es.ugr.frailty.gravity
04-23 20:06:48.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:48.959+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6253
04-23 20:06:48.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:48.969+0200 I/utils   ( 6253): es.ugr.frailty.gravity sensor supported
04-23 20:06:48.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:06:48.979+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6253
04-23 20:06:48.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:06:48.989+0200 I/utils   ( 6253): es.ugr.frailty.gravity listener started
04-23 20:06:48.989+0200 W/CAPI_APPFW_APP_CONTROL( 6253): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:06:48.999+0200 I/utils   ( 6253): specific action
04-23 20:06:49.019+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.019+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:29,9.776762,-0.052473,0.763250
04-23 20:06:49.039+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.039+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:47,9.776770,-0.051799,0.763201
04-23 20:06:49.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.059+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:59,9.776716,-0.050265,0.763992
04-23 20:06:49.069+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.069+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:78,0.050296,9.776652,0.764808
04-23 20:06:49.089+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.089+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:97,0.051458,9.776513,0.766501
04-23 20:06:49.109+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.109+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:117,0.050523,9.776386,0.768180
04-23 20:06:49.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:137,0.050999,9.776224,0.770209
04-23 20:06:49.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.159+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:160,0.050228,9.776033,0.772677
04-23 20:06:49.159+0200 W/LOCATION( 6244): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:06:49.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:178,0.049609,9.775819,0.775423
04-23 20:06:49.189+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.189+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:197,0.049463,9.775640,0.777680
04-23 20:06:49.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:217,0.048859,9.775481,0.779726
04-23 20:06:49.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:237,0.050286,9.775186,0.783330
04-23 20:06:49.249+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:257,0.050765,9.775179,0.783384
04-23 20:06:49.269+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.269+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:278,0.048864,9.774986,0.785904
04-23 20:06:49.289+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.289+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:297,0.049415,9.774821,0.787921
04-23 20:06:49.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:317,0.050152,9.774614,0.790428
04-23 20:06:49.329+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.329+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:336,0.049647,9.774425,0.792803
04-23 20:06:49.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:06:49.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:06:49.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:06:49.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:356,0.048416,9.774522,0.791684
04-23 20:06:49.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:376,0.047371,9.774510,0.791886
04-23 20:06:49.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:401,0.046839,9.774601,0.790798
04-23 20:06:49.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.419+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:423,0.047029,9.774672,0.789912
04-23 20:06:49.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:49.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:49:436,0.047105,9.774530,0.791653
04-23 20:06:49.429+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11062446c6f63152450680
