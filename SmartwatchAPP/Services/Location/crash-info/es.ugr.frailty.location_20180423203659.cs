S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11227
Date: 2018-04-23 20:36:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf759052d, r5   = 0xf7b44f98
r6   = 0xfffac0b0, r7   = 0xfffabf60
r8   = 0xf7b41c18, r9   = 0x00000000
r10  = 0xfffac03c, fp   = 0xfffac0b0
ip   = 0x00000001, sp   = 0xfffabf38
lr   = 0xf7590539, pc   = 0xf75f9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    137500 KB
Buffers:     38388 KB
Cached:     158824 KB
VmPeak:      53460 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11852 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11227 TID = 11227
11227 11230 

Maps Information
f445b000 f4c5a000 rw-p [stack:11230]
f4c61000 f4c63000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c6b000 f4c6f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c78000 f4c7a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c82000 f4c85000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c94000 f4c99000 r-xp /usr/lib/libsystem.so.0.0.0
f4ca4000 f4ca7000 r-xp /lib/libattr.so.1.1.0
f4caf000 f4cbf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cc7000 f4cd0000 r-xp /usr/lib/libedbus.so.1.7.99
f4cd8000 f4cd9000 r-xp /usr/lib/libresponse.so.0.2.96
f4ce2000 f4ce7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6589000 f668f000 r-xp /usr/lib/libicuuc.so.57.1
f66a5000 f682d000 r-xp /usr/lib/libicui18n.so.57.1
f683d000 f684a000 r-xp /usr/lib/libail.so.0.1.0
f6853000 f685a000 r-xp /usr/lib/libminizip.so.1.0.0
f6863000 f6a0c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a2c000 f6a73000 r-xp /usr/lib/libssl.so.1.0.0
f6a7f000 f6a81000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a89000 f6a90000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a99000 f6aa0000 r-xp /lib/libcrypt-2.13.so
f6ad1000 f6ad4000 r-xp /lib/libcap.so.2.21
f6adc000 f6ade000 r-xp /usr/lib/libiri.so
f6ae6000 f6b2f000 r-xp /usr/lib/libmdm.so.1.2.69
f6b37000 f6b3d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b45000 f6b68000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b72000 f6b74000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b7c000 f6b99000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ba2000 f6ba6000 r-xp /usr/lib/libsmack.so.1.0.0
f6baf000 f6bc8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bd1000 f6bd9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6be1000 f6be7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bf0000 f6bf2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bfb000 f6c0b000 r-xp /lib/libresolv-2.13.so
f6c0f000 f6c27000 r-xp /usr/lib/liblzma.so.5.0.3
f6c30000 f6c32000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c3a000 f6c54000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c5c000 f6c8b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c94000 f6ca3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cad000 f6cb7000 r-xp /usr/lib/libsensord-shared.so
f6cc0000 f6d93000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d9e000 f6db4000 r-xp /lib/libz.so.1.2.5
f6dbc000 f6dc1000 r-xp /usr/lib/libffi.so.5.0.10
f6dc9000 f6dca000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dd2000 f6de2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dea000 f6e03000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e0b000 f6e0d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e15000 f6e8a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e94000 f6e9a000 r-xp /lib/librt-2.13.so
f6ea3000 f6ec1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ecb000 f6ecc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ed4000 f6ef7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6eff000 f6f04000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f0c000 f6f36000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f3f000 f6f56000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f5e000 f6fc7000 r-xp /lib/libm-2.13.so
f6fd0000 f7064000 r-xp /usr/lib/libstdc++.so.6.0.16
f7077000 f707c000 r-xp /usr/lib/libctx-client.so.0.8.3
f7084000 f708b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7093000 f70bd000 r-xp /usr/lib/libsensor.so.1.9.6
f70c6000 f7192000 r-xp /usr/lib/libxml2.so.2.7.8
f719f000 f71a1000 r-xp /usr/lib/libiniparser.so.0
f71aa000 f71b0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71b9000 f7289000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f728a000 f72be000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72c7000 f7303000 r-xp /usr/lib/libSLP-location.so.0.9.24
f730b000 f730e000 r-xp /usr/lib/libbundle.so.0.1.22
f7316000 f731c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7324000 f7365000 r-xp /usr/lib/libeina.so.1.7.99
f736e000 f7385000 r-xp /usr/lib/libecore.so.1.7.99
f739c000 f73a5000 r-xp /usr/lib/libvconf.so.0.2.45
f73ad000 f73c1000 r-xp /lib/libpthread-2.13.so
f73cc000 f73d9000 r-xp /usr/lib/libaul.so.0.1.0
f73e3000 f73e5000 r-xp /lib/libdl-2.13.so
f73ee000 f73f9000 r-xp /lib/libunwind.so.8.0.1
f7426000 f742e000 r-xp /lib/libgcc_s-4.6.so.1
f742f000 f7553000 r-xp /lib/libc-2.13.so
f7561000 f7563000 r-xp /usr/lib/libdlog.so.0.0.0
f756b000 f7577000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7580000 f7585000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f758d000 f759c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75a4000 f75a8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75b1000 f75b4000 r-xp /usr/lib/libappcore-agent.so.1.1
f75bc000 f75be000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75c6000 f75ca000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75d2000 f75ef000 r-xp /lib/ld-2.13.so
f75f8000 f75fb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75fb000 f75ff000 r-xp /usr/lib/libsys-assert.so
f7b11000 f7b80000 rw-p [heap]
fff8d000 fffae000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11227)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75f9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7590539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72973f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7295c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72a1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72a7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72a7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72dc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72d71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7295c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72a1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72a7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72a7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72d9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72da017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72e1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c791fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c6c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d3f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71ecfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71ee7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf737eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7379b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf737a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf737a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75b2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75b27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75f953f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf744685c) [/lib/libc.so.6] + 0x1785c
29: (0xf75f8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
200 E/location(11176): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:36:47.979+0200 I/CAPI_APPFW_APPLICATION(11176): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:36:47.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:36:47.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:36:48.019+0200 W/LOCATION(11176): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:48.019+0200 I/LOCATION(11176): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:36:48.019+0200 I/LOCATION(11176): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:36:48.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:48.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:48.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:36:48.099+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:36:48.099+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:36:48.099+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:36:48.099+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:36:48.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:108,0.062322,9.771030,0.832745
04-23 20:36:48.119+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:125,0.061100,9.770955,0.833716
04-23 20:36:48.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:145,0.062317,9.770938,0.833825
04-23 20:36:48.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:166,0.061442,9.770949,0.833759
04-23 20:36:48.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:185,0.060251,9.771075,0.832369
04-23 20:36:48.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:205,0.058295,9.771089,0.832357
04-23 20:36:48.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:226,0.056176,9.770804,0.835827
04-23 20:36:48.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:245,0.055235,9.770853,0.835328
04-23 20:36:48.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.269+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:48.269+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:48.269+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:48.269+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c25100
04-23 20:36:48.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:266,0.055369,9.770893,0.834843
04-23 20:36:48.289+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:297,0.055277,9.770881,0.834995
04-23 20:36:48.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:309,0.055310,9.770869,0.835128
04-23 20:36:48.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:325,0.055890,9.770885,0.834897
04-23 20:36:48.319+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1a438]
04-23 20:36:48.319+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:48.319+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:48.319+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:48.319+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:48.329+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:48.329+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:48.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.339+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.349+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.349+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:48.349+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:48.349+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:48.349+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:48.349+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:48.349+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:48.349+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:48.349+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:48.349+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:48.349+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:345,0.057800,9.770940,0.834133
04-23 20:36:48.349+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.359+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.359+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:48.359+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.359+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:366,0.056190,9.771050,0.832952
04-23 20:36:48.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:386,0.055587,9.771037,0.833148
04-23 20:36:48.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.409+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:406,0.053834,9.771163,0.831787
04-23 20:36:48.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.429+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.459+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:433,0.051868,9.771043,0.833317
04-23 20:36:48.459+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:48.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:48.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:48.469+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1a438
04-23 20:36:48.469+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:471,0.052376,9.771124,0.832330
04-23 20:36:48.469+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:483,0.052185,9.770953,0.834351
04-23 20:36:48.479+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:488,0.051440,9.770863,0.835448
04-23 20:36:48.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:505,0.051791,9.770838,0.835721
04-23 20:36:48.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:525,0.051641,9.770639,0.838049
04-23 20:36:48.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c1a608]
04-23 20:36:48.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:48.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:48.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:48.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:48.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:545,0.051377,9.770530,0.839337
04-23 20:36:48.539+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:48.549+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:48.549+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.559+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.559+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:48.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:566,0.050434,9.770532,0.839376
04-23 20:36:48.559+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:48.559+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:48.559+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:48.559+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:48.559+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:48.559+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:48.559+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:48.559+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:48.569+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.579+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.579+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:48.579+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:48.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.589+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:585,0.052748,9.770840,0.835643
04-23 20:36:48.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:48.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:48.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:48.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:48.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c1a608
04-23 20:36:48.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:606,0.050483,9.770752,0.836803
04-23 20:36:48.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:668,0.049826,9.770608,0.838525
04-23 20:36:48.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:672,0.050380,9.770692,0.837515
04-23 20:36:48.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:706,0.051078,9.770666,0.837767
04-23 20:36:48.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:711,0.051289,9.770555,0.839052
04-23 20:36:48.719+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:727,0.053007,9.770498,0.839601
04-23 20:36:48.729+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.749+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:739,0.051963,9.770392,0.840906
04-23 20:36:48.749+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.759+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:760,0.049996,9.770319,0.841871
04-23 20:36:48.759+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.759+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:766,0.047552,9.770213,0.843240
04-23 20:36:48.779+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:784,0.048063,9.770379,0.841288
04-23 20:36:48.799+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.799+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:804,0.047392,9.770301,0.842232
04-23 20:36:48.819+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:824,0.046189,9.770197,0.843504
04-23 20:36:48.839+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.849+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:849,0.044474,9.770075,0.845010
04-23 20:36:48.849+0200 W/AUL     (11188): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:36:48.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:36:48.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:36:48.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11152
04-23 20:36:48.849+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:36:48.849+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11152
04-23 20:36:48.849+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11152)
04-23 20:36:48.859+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.859+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:865,0.045233,9.770049,0.845265
04-23 20:36:48.879+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:884,0.043788,9.769965,0.846319
04-23 20:36:48.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:904,0.043097,9.769898,0.847117
04-23 20:36:48.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:925,0.042778,9.769935,0.846714
04-23 20:36:48.939+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:944,0.043415,9.770163,0.844053
04-23 20:36:48.959+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:964,0.043315,9.770243,0.843125
04-23 20:36:48.979+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:48:984,0.042761,9.770314,0.842330
04-23 20:36:48.999+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:48.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:4,0.042116,9.770321,0.842285
04-23 20:36:49.019+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:24,0.040814,9.770298,0.842616
04-23 20:36:49.039+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.039+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:44,0.039924,9.770249,0.843215
04-23 20:36:49.059+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:80,0.040437,9.770189,0.843893
04-23 20:36:49.079+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.089+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:93,0.041596,9.770018,0.845814
04-23 20:36:49.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:106,0.040791,9.769899,0.847227
04-23 20:36:49.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:303,0.048826,9.769464,0.851816
04-23 20:36:49.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:503,0.031963,9.767891,0.870445
04-23 20:36:49.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:704,0.043842,9.769503,0.851638
04-23 20:36:49.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:49.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:49:903,0.038222,9.768835,0.859530
04-23 20:36:49.979+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:36:50.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:50.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:50:103,0.024023,9.766716,0.883776
04-23 20:36:50.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:50.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:50:304,0.019759,9.771642,0.827649
04-23 20:36:50.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:50.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:50:503,0.020902,9.774766,0.789869
04-23 20:36:50.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:50.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:50:703,0.027172,9.776303,0.770414
04-23 20:36:50.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:50.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:50:904,0.036778,9.775840,0.775873
04-23 20:36:51.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:51.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:51:103,0.043273,9.775848,0.775436
04-23 20:36:51.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:51.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:51:303,0.045039,9.774784,0.788644
04-23 20:36:51.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:51.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:51:504,0.032715,9.773019,0.810817
04-23 20:36:51.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:51.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:51:704,0.027573,9.771973,0.823518
04-23 20:36:51.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:51.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:51:904,0.024944,9.771314,0.831376
04-23 20:36:52.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:52.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:52:104,0.036748,9.772042,0.822324
04-23 20:36:52.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:52.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:52:304,0.035098,9.772563,0.816192
04-23 20:36:52.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:52.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:52:504,0.040343,9.772511,0.816577
04-23 20:36:52.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:52.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:52:704,0.031888,9.771717,0.826383
04-23 20:36:52.729+0200 I/servicemanager(10115): es.ugr.frailty.gravity sleep timeout
04-23 20:36:52.729+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:36:52.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:52.729+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:52.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10862
04-23 20:36:52.739+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10862)
04-23 20:36:52.739+0200 I/servicemanager(10115): es.ugr.frailty.gravity stop request sent!
04-23 20:36:52.739+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:52.739+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:52.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10862), cmd(0)
04-23 20:36:52.739+0200 I/gravity (10862): stopping es.ugr.frailty.gravity service
04-23 20:36:52.739+0200 W/AUL     (10862): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:52.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:52.749+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10862
04-23 20:36:52.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:52.759+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:52.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 I/utils   (10115): specific action
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.759+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:52.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:52.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:52.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:52.779+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:52.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 I/utils   (10120): specific action
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:52.779+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:36:52.779+0200 I/recorder(10120): guardando datos en local
04-23 20:36:52.779+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:52.779+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:52.779+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:52.779+0200 W/AUL     (10862): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:52.789+0200 I/gravity (10862): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:52.789+0200 I/CAPI_APPFW_APPLICATION(10862): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:36:52.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:36:52.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:36:52.829+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:36:52.839+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:36:52.879+0200 I/gravity (10862): es.ugr.frailty.gravity listener destroyed
04-23 20:36:53.019+0200 W/AUL     (11199): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:36:53.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:36:53.019+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:36:53.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10862
04-23 20:36:53.019+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:36:53.019+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10862
04-23 20:36:53.019+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10862)
04-23 20:36:54.789+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:36:57.249+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:36:57.249+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:36:57.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:57.249+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:57.269+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11227
04-23 20:36:57.269+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:36:57.319+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11227
04-23 20:36:57.319+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11227) type(svcapp) bg(0)
04-23 20:36:57.329+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11227]
04-23 20:36:57.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:57.359+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11227
04-23 20:36:57.369+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:57.369+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11227)
04-23 20:36:57.369+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:36:57.369+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:57.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:57.389+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11227
04-23 20:36:57.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:57.399+0200 E/CAPI_APPFW_APPLICATION(11227): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:57.399+0200 E/CAPI_APPFW_APPLICATION(11227): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:57.399+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11227) was created
04-23 20:36:57.429+0200 W/LOCATION(11227): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:36:57.429+0200 E/LOCATION(11227): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:36:57.429+0200 E/PKGMGR_INFO(11227): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:36:57.429+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:57.449+0200 I/LOCATION(11227): location.c: location_new(269) > method: 0
04-23 20:36:57.449+0200 W/LOCATION(11227): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:57.459+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:57.459+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:57.469+0200 W/LOCATION(11227): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:57.469+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:57.479+0200 W/LOCATION(11227): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:57.479+0200 W/LOCATION(11227): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:57.479+0200 W/LOCATION(11227): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:57.479+0200 W/LOCATION(11227): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:57.499+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:57.509+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:57.509+0200 W/LOCATION(11227): module-internal.c: module_new(311) > module (wps) open success
04-23 20:36:57.519+0200 W/LOCATION(11227): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:36:57.519+0200 W/LOCATION(11227): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:36:57.519+0200 W/LOCATION(11227): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:57.519+0200 W/LOCATION(11227): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:57.539+0200 W/LOCATION(11227): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:36:57.539+0200 I/LOCATION(11227): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b41c18
04-23 20:36:57.539+0200 I/LOCATION(11227): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:36:57.539+0200 I/LOCATION(11227): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b41c18
04-23 20:36:57.539+0200 I/LOCATION(11227): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:36:57.549+0200 I/location(11227): es.ugr.frailty.location: creado servicio de localización
04-23 20:36:57.599+0200 I/LOCATION(11227): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:36:57.639+0200 W/LOCATION(11227): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:57.639+0200 W/LOCATION(11227): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:57.639+0200 I/LOCATION(11227): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:57.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:36:57.699+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:36:57.699+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:36:57.699+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:57.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:36:57.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:36:57.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:36:57.699+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:36:57.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:36:57.699+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:36:57.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:36:57.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:36:57.739+0200 W/LOCATION(11227): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:57.739+0200 W/LOCATION(11227): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:57.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:57.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c02188]
04-23 20:36:57.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:57.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:57.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:57.849+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:57.859+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:57.859+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:57.869+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:57.879+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:57.879+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:57.879+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:57.879+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:57.879+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:57.879+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:57.879+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:57.879+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:57.879+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:57.879+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:57.889+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:57.899+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:57.899+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:57.899+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:57.929+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:36:57.929+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2693195), time2(2680006)
04-23 20:36:57.929+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:36:57.929+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:36:57.929+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:36:57.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:36:57.959+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:57.999+0200 W/LOCATION(11227): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:57.999+0200 I/LOCATION(11227): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:57.999+0200 I/LOCATION(11227): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:57.999+0200 I/location(11227): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:36:58.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:58.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:58.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:58.159+0200 I/LOCATION(11227): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:58.219+0200 W/AUL     (11227): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:58.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:58.219+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11227
04-23 20:36:58.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:58.229+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.229+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:58.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:58.229+0200 W/AUL     (11227): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:58.229+0200 I/utils   (10115): specific action
04-23 20:36:58.229+0200 I/location(11227): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:58.229+0200 I/location(11227): es.ugr.frailty.location: SM-R760,23/04/2018,20:36:58:222,nan,37.171761,-3.592979,0.000000,0,0.000000,59.000000,-1.000000
04-23 20:36:58.229+0200 W/CAPI_APPFW_APP_CONTROL(11227): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.229+0200 I/utils   (11227): specific action
04-23 20:36:58.229+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.229+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.229+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.229+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:58.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:58.229+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:58.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:58.239+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.239+0200 I/utils   (10120): specific action
04-23 20:36:58.239+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:58.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:58.239+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.239+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:58.239+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:58.239+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:58.239+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.239+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:58.249+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:36:58.249+0200 I/recorder(10120): guardando datos en local
04-23 20:36:59.009+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:36:59.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:59.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:59.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:59.799+0200 W/LOCATION(11227): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:36:59.989+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11112276c6f63152450861
