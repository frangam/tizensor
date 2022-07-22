S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5756
Date: 2018-04-23 18:25:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70ec52d, r5   = 0xf7254f98
r6   = 0xff9beaf0, r7   = 0xff9be9a0
r8   = 0xf7251c18, r9   = 0x00000000
r10  = 0xff9bea7c, fp   = 0xff9beaf0
ip   = 0x00000001, sp   = 0xff9be978
lr   = 0xf70ec539, pc   = 0xf7155228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      6880 KB
Buffers:     68992 KB
Cached:     220012 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11936 KB
VmRSS:       11936 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5756 TID = 5756
5756 5759 

Maps Information
f3fb7000 f47b6000 rw-p [stack:5759]
f47bd000 f47bf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47c7000 f47cb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47d4000 f47d6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47de000 f47e1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47f0000 f47f5000 r-xp /usr/lib/libsystem.so.0.0.0
f4800000 f4803000 r-xp /lib/libattr.so.1.1.0
f480b000 f481b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4823000 f482c000 r-xp /usr/lib/libedbus.so.1.7.99
f4834000 f4835000 r-xp /usr/lib/libresponse.so.0.2.96
f483e000 f4843000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60e5000 f61eb000 r-xp /usr/lib/libicuuc.so.57.1
f6201000 f6389000 r-xp /usr/lib/libicui18n.so.57.1
f6399000 f63a6000 r-xp /usr/lib/libail.so.0.1.0
f63af000 f63b6000 r-xp /usr/lib/libminizip.so.1.0.0
f63bf000 f6568000 r-xp /usr/lib/libcrypto.so.1.0.0
f6588000 f65cf000 r-xp /usr/lib/libssl.so.1.0.0
f65db000 f65dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65e5000 f65ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65f5000 f65fc000 r-xp /lib/libcrypt-2.13.so
f662d000 f6630000 r-xp /lib/libcap.so.2.21
f6638000 f663a000 r-xp /usr/lib/libiri.so
f6642000 f668b000 r-xp /usr/lib/libmdm.so.1.2.69
f6693000 f6699000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66a1000 f66c4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66ce000 f66d0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66d8000 f66f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66fe000 f6702000 r-xp /usr/lib/libsmack.so.1.0.0
f670b000 f6724000 r-xp /usr/lib/libnetwork.so.0.0.0
f672d000 f6735000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f673d000 f6743000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f674c000 f674e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6757000 f6767000 r-xp /lib/libresolv-2.13.so
f676b000 f6783000 r-xp /usr/lib/liblzma.so.5.0.3
f678c000 f678e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6796000 f67b0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67b8000 f67e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67f0000 f67ff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6809000 f6813000 r-xp /usr/lib/libsensord-shared.so
f681c000 f68ef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68fa000 f6910000 r-xp /lib/libz.so.1.2.5
f6918000 f691d000 r-xp /usr/lib/libffi.so.5.0.10
f6925000 f6926000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f692e000 f693e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6946000 f695f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6967000 f6969000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6971000 f69e6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69f0000 f69f6000 r-xp /lib/librt-2.13.so
f69ff000 f6a1d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a27000 f6a28000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a30000 f6a53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a5b000 f6a60000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a68000 f6a92000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a9b000 f6ab2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aba000 f6b23000 r-xp /lib/libm-2.13.so
f6b2c000 f6bc0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bd3000 f6bd8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6be0000 f6be7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bef000 f6c19000 r-xp /usr/lib/libsensor.so.1.9.6
f6c22000 f6cee000 r-xp /usr/lib/libxml2.so.2.7.8
f6cfb000 f6cfd000 r-xp /usr/lib/libiniparser.so.0
f6d06000 f6d0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d15000 f6de5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6de6000 f6e1a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e23000 f6e5f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e67000 f6e6a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e72000 f6e78000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e80000 f6ec1000 r-xp /usr/lib/libeina.so.1.7.99
f6eca000 f6ee1000 r-xp /usr/lib/libecore.so.1.7.99
f6ef8000 f6f01000 r-xp /usr/lib/libvconf.so.0.2.45
f6f09000 f6f1d000 r-xp /lib/libpthread-2.13.so
f6f28000 f6f35000 r-xp /usr/lib/libaul.so.0.1.0
f6f3f000 f6f41000 r-xp /lib/libdl-2.13.so
f6f4a000 f6f55000 r-xp /lib/libunwind.so.8.0.1
f6f82000 f6f8a000 r-xp /lib/libgcc_s-4.6.so.1
f6f8b000 f70af000 r-xp /lib/libc-2.13.so
f70bd000 f70bf000 r-xp /usr/lib/libdlog.so.0.0.0
f70c7000 f70d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70dc000 f70e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70e9000 f70f8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7100000 f7104000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f710d000 f7110000 r-xp /usr/lib/libappcore-agent.so.1.1
f7118000 f711a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7122000 f7126000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f712e000 f714b000 r-xp /lib/ld-2.13.so
f7154000 f7157000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7157000 f715b000 r-xp /usr/lib/libsys-assert.so
f7221000 f7292000 rw-p [heap]
ff9a0000 ff9c1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5756)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7155228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70ec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6df33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6df1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e3875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6df1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e35e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e36017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e3df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47d51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47c8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf689b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d48fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d4a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6edaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ed5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ed65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ed6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf710e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf710e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71554f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6fa285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7154f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
17): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:41.441+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:41:442,-8.330000,-4.340000,-2.030000
04-23 18:25:41.441+0200 I/LOCATION( 5756): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 18:25:41.481+0200 W/LOCATION( 5756): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:25:41.481+0200 W/LOCATION( 5756): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:25:41.481+0200 I/LOCATION( 5756): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:41.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:25:41.541+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:25:41.541+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:25:41.541+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:41.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:25:41.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:25:41.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:25:41.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:25:41.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:25:41.541+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:25:41.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:25:41.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:25:41.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:41.581+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:41.611+0200 W/LOCATION( 5756): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:25:41.611+0200 W/LOCATION( 5756): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:25:41.631+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:41.631+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:41.641+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:41:639,-42.420002,-0.140000,2.590000
04-23 18:25:41.641+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:41:639,3.589234,-6.216553,6.817152
04-23 18:25:41.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:41.731+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf3c29f68]
04-23 18:25:41.731+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:25:41.731+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:25:41.731+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:25:41.731+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:25:41.741+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:41.741+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:41.751+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:41.761+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:41.761+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:25:41.761+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:25:41.761+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:41.761+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:25:41.761+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:25:41.761+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:25:41.761+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:41.761+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:25:41.761+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:25:41.771+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:41.771+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:41.771+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:25:41.781+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:41.781+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:41.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:41.781+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:25:41.781+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(14637448), time2(14627515)
04-23 18:25:41.781+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 18:25:41.781+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:25:41.781+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:25:41.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:25:41.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:41.831+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:41.831+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:41.841+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:41:839,3.620341,-7.561320,5.568098
04-23 18:25:41.851+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:41:839,-5.320000,16.870001,-0.210000
04-23 18:25:41.851+0200 W/LOCATION( 5756): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:25:41.851+0200 I/LOCATION( 5756): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:41.851+0200 I/LOCATION( 5756): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:41.851+0200 I/location( 5756): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:25:41.931+0200 I/LOCATION( 5756): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:41.971+0200 E/location( 5756): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:25:41.971+0200 W/AUL     ( 5756): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:25:41.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:41.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5756
04-23 18:25:41.981+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:41.981+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:41.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5575
04-23 18:25:41.981+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:41.981+0200 I/utils   ( 5575): specific action
04-23 18:25:41.981+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:41.981+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:41.981+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:41.981+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:25:41.991+0200 W/AUL     ( 5756): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5575)
04-23 18:25:41.991+0200 I/location( 5756): request sent to service es.ugr.frailty.servicemanager
04-23 18:25:41.991+0200 W/CAPI_APPFW_APP_CONTROL( 5756): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:41.991+0200 I/utils   ( 5756): specific action
04-23 18:25:41.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:41.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:25:42.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5582
04-23 18:25:42.001+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:42.001+0200 I/utils   ( 5582): specific action
04-23 18:25:42.001+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:42.001+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:42.001+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:42.001+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:42.001+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5582)
04-23 18:25:42.001+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.recorder
04-23 18:25:42.001+0200 I/servicemanager( 5575): requesting to save local data
04-23 18:25:42.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:42.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:25:42.001+0200 I/recorder( 5582): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:25:42.001+0200 I/recorder( 5582): guardando datos en local
04-23 18:25:42.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:42.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(5582), cmd(0)
04-23 18:25:42.031+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.041+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.041+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:41,-15.540000,2.240000,-4.690000
04-23 18:25:42.041+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:45,3.402594,-6.262017,6.175875
04-23 18:25:42.181+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:42.181+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:42.231+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.231+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.241+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:240,71.750000,8.470000,-2.240000
04-23 18:25:42.251+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:241,3.984050,-6.774081,7.113862
04-23 18:25:42.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:42.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:42.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:42.411+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:42.411+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:42.431+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.431+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.441+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:440,3.431308,-5.572884,7.429714
04-23 18:25:42.441+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:440,4.760000,0.210000,1.330000
04-23 18:25:42.451+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.451+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.461+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:460,3.430000,-0.210000,1.120000
04-23 18:25:42.461+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:460,3.416951,-5.764310,7.353144
04-23 18:25:42.471+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.481+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.481+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:485,3.558127,-5.642276,7.484749
04-23 18:25:42.481+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:479,9.450000,-0.700000,0.770000
04-23 18:25:42.491+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.491+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.501+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:504,3.462414,-5.721239,7.154540
04-23 18:25:42.501+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:504,12.250000,0.980000,-0.210000
04-23 18:25:42.511+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.511+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.521+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:522,3.565305,-5.740381,7.594819
04-23 18:25:42.521+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:522,31.570000,0.490000,1.400000
04-23 18:25:42.531+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.531+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.541+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:540,29.610001,2.940000,3.360000
04-23 18:25:42.541+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:540,3.641876,-5.000999,7.814958
04-23 18:25:42.551+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.551+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.561+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:562,13.720000,-2.520000,3.500000
04-23 18:25:42.561+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:562,3.053242,-5.120641,7.728817
04-23 18:25:42.571+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.571+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.581+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:581,3.369094,-4.981857,7.810174
04-23 18:25:42.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:42.581+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:42.581+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:581,-1.050000,-6.230000,3.220000
04-23 18:25:42.601+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.601+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.601+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:606,3.464807,-5.321638,7.680960
04-23 18:25:42.601+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:605,-12.040000,-6.440000,0.280000
04-23 18:25:42.611+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.611+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.621+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:621,-9.310000,-6.650000,0.420000
04-23 18:25:42.631+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:620,3.500700,-5.570491,7.484749
04-23 18:25:42.641+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.651+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.671+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:649,-1.190000,-8.120000,1.330000
04-23 18:25:42.671+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:658,3.445665,-5.364708,7.592427
04-23 18:25:42.671+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.671+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.681+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:683,3.531806,-5.113462,7.668997
04-23 18:25:42.681+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.701+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:683,-1.120000,-10.360000,1.890000
04-23 18:25:42.711+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:692,3.534199,-5.434100,7.551748
04-23 18:25:42.711+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.721+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:717,3.680161,-5.551349,7.441679
04-23 18:25:42.721+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.721+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.721+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:722,-10.220000,-10.360000,-1.260000
04-23 18:25:42.721+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.721+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:726,3.773481,-5.486742,7.377072
04-23 18:25:42.731+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:731,-12.950000,-10.360000,-1.050000
04-23 18:25:42.731+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.731+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.731+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:737,-10.570000,-9.100000,-1.050000
04-23 18:25:42.731+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.731+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:739,3.797409,-5.582455,7.283752
04-23 18:25:42.741+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:743,-8.610000,-8.050000,0.700000
04-23 18:25:42.751+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.751+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.761+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:760,-6.230000,-6.510000,1.050000
04-23 18:25:42.761+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:760,3.821337,-5.661418,7.345965
04-23 18:25:42.771+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.771+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:779,3.816552,-5.577669,7.307681
04-23 18:25:42.781+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.781+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:42.781+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:42:786,87
04-23 18:25:42.791+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.801+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:785,-2.660000,-4.060000,1.400000
04-23 18:25:42.801+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:803,3.751946,-5.630312,7.295716
04-23 18:25:42.801+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.801+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:809,0.140000,-1.400000,0.840000
04-23 18:25:42.811+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.811+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:819,3.687340,-5.568098,7.278966
04-23 18:25:42.811+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.821+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:824,2.100000,-0.140000,0.070000
04-23 18:25:42.831+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.831+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:839,3.704089,-5.489135,7.326823
04-23 18:25:42.831+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.841+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:25:42.841+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:844,2.240000,0.770000,-0.560000
04-23 18:25:42.851+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.851+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.861+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:861,4.480000,1.260000,-1.120000
04-23 18:25:42.861+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:861,3.682554,-5.642276,7.314859
04-23 18:25:42.871+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.871+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.871+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:880,1.890000,1.050000,-0.140000
04-23 18:25:42.871+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:880,3.732803,-5.297709,7.525427
04-23 18:25:42.901+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.901+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.901+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:904,3.656233,-5.369494,7.429714
04-23 18:25:42.901+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:904,-3.080000,-0.350000,0.140000
04-23 18:25:42.911+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.911+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.921+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:919,3.816552,-5.532206,7.456036
04-23 18:25:42.921+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:919,-3.850000,-1.190000,1.120000
04-23 18:25:42.931+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.931+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.941+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:940,-2.590000,-1.750000,1.120000
04-23 18:25:42.941+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:940,3.682554,-5.592027,7.269395
04-23 18:25:42.951+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.951+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.961+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:960,0.350000,-2.100000,0.350000
04-23 18:25:42.961+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:961,3.783052,-5.716454,7.355537
04-23 18:25:42.971+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:42.971+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:42.981+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:42.981+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:42:980,3.761517,-5.417351,7.408179
04-23 18:25:42.991+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:42:987,87
04-23 18:25:42.991+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:42:980,1.260000,-1.330000,0.560000
04-23 18:25:43.001+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.001+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.001+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:5,-2.310000,-2.030000,0.420000
04-23 18:25:43.001+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:5,3.682554,-5.386244,7.396214
04-23 18:25:43.011+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.011+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.021+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:22,3.818945,-5.560920,7.355537
04-23 18:25:43.021+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:22,-3.920000,-3.080000,0.280000
04-23 18:25:43.031+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.031+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.041+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:41,-2.940000,-2.240000,1.120000
04-23 18:25:43.041+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:41,3.809374,-5.517848,7.322037
04-23 18:25:43.051+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.051+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.061+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:60,-3.010000,-1.400000,0.770000
04-23 18:25:43.061+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:61,3.797409,-5.572884,7.264609
04-23 18:25:43.071+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.071+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.081+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:80,3.730411,-5.639884,7.343572
04-23 18:25:43.081+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:80,-1.050000,-0.560000,0.350000
04-23 18:25:43.091+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.091+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.101+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:104,-0.700000,-0.490000,0.070000
04-23 18:25:43.111+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:104,3.728018,-5.577669,7.381857
04-23 18:25:43.111+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.111+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.121+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:119,-0.700000,-0.910000,-0.560000
04-23 18:25:43.121+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:119,3.723232,-5.592027,7.286145
04-23 18:25:43.131+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.131+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.141+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:141,0.630000,-0.840000,-0.350000
04-23 18:25:43.141+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:141,3.761517,-5.601598,7.326823
04-23 18:25:43.161+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.161+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.171+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:165,2.030000,-0.840000,-0.210000
04-23 18:25:43.171+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.171+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:172,3.742374,-5.592027,7.298109
04-23 18:25:43.181+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:43.191+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:43:187,87
04-23 18:25:43.191+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.211+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:182,2.730000,-1.960000,-0.420000
04-23 18:25:43.211+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.211+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:186,3.778267,-5.577669,7.424929
04-23 18:25:43.211+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.231+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:216,1.890000,-1.890000,0.140000
04-23 18:25:43.231+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.231+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:221,3.732803,-5.551349,7.389036
04-23 18:25:43.231+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.241+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:237,-0.420000,-2.450000,0.490000
04-23 18:25:43.241+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.251+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:243,3.806981,-5.446064,7.405786
04-23 18:25:43.251+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.261+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:252,-2.240000,-2.590000,0.350000
04-23 18:25:43.261+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.261+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:258,3.795017,-5.580062,7.338787
04-23 18:25:43.261+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.281+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:269,-0.280000,-2.380000,1.120000
04-23 18:25:43.281+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.281+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:273,3.833302,-5.587241,7.312466
04-23 18:25:43.291+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.291+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:288,1.330000,-2.310000,1.050000
04-23 18:25:43.301+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:296,3.897908,-5.563312,7.305287
04-23 18:25:43.301+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.301+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:307,3.873980,-5.546563,7.379465
04-23 18:25:43.311+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.341+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:319,1.050000,-1.400000,1.120000
04-23 18:25:43.341+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.351+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:353,3.783052,-5.503492,7.324430
04-23 18:25:43.351+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:43.361+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:359,3.759124,-5.625526,7.262216
04-23 18:25:43.361+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.371+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:369,3.864408,-5.615955,7.345965
04-23 18:25:43.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:43.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:43.371+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.371+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.371+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:376,-2.240000,-0.700000,1.610000
04-23 18:25:43.371+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.381+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:43.381+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:382,-2.590000,-1.470000,2.100000
04-23 18:25:43.381+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.381+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:43:386,88
04-23 18:25:43.381+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:387,-2.310000,-0.350000,3.150000
04-23 18:25:43.381+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:380,3.747160,-5.625526,7.211967
04-23 18:25:43.381+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.391+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:392,0.700000,-0.420000,3.080000
04-23 18:25:43.391+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.391+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.401+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:403,2.870000,-1.330000,1.820000
04-23 18:25:43.401+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:404,3.730411,-5.575277,7.334002
04-23 18:25:43.411+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.411+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.411+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:419,-2.940000,-0.980000,1.050000
04-23 18:25:43.421+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:420,3.828516,-5.417351,7.412964
04-23 18:25:43.431+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.431+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.441+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:440,-10.360000,-1.190000,-1.400000
04-23 18:25:43.441+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:440,3.747160,-5.606383,7.269395
04-23 18:25:43.451+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.451+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.461+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:460,3.785445,-5.735595,7.317252
04-23 18:25:43.461+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:460,-6.090000,-0.840000,0.280000
04-23 18:25:43.471+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.471+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.471+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:479,-0.210000,-0.210000,4.480000
04-23 18:25:43.471+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:480,3.897908,-5.465207,7.302894
04-23 18:25:43.501+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.501+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.501+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:505,3.759124,-5.723632,7.109076
04-23 18:25:43.511+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.521+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:506,-7.350000,-0.490000,-0.140000
04-23 18:25:43.521+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.521+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:521,3.797409,-5.903094,7.197611
04-23 18:25:43.521+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:526,-2.800000,-0.840000,-1.750000
04-23 18:25:43.531+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.531+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.541+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:541,1.190000,-0.840000,1.050000
04-23 18:25:43.541+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:541,3.878766,-5.469993,7.329216
04-23 18:25:43.551+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.551+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.561+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:561,-1.540000,-1.330000,0.980000
04-23 18:25:43.561+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:561,3.806981,-5.572884,7.219146
04-23 18:25:43.571+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.571+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:43.581+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:579,2.590000,-1.330000,1.260000
04-23 18:25:43.581+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:580,3.862016,-5.764310,7.274181
04-23 18:25:43.591+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:43:587,88
04-23 18:25:43.591+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.591+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.601+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:604,3.823731,-5.659025,7.087541
04-23 18:25:43.611+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:604,1.050000,1.470000,-0.840000
04-23 18:25:43.611+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.621+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.631+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:625,2.590000,2.100000,-3.010000
04-23 18:25:43.631+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.631+0200 W/LOCATION( 5756): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:25:43.631+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:620,3.783052,-5.807381,7.200003
04-23 18:25:43.641+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.651+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:640,4.830000,2.170000,-0.420000
04-23 18:25:43.651+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.661+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:651,3.929015,-5.407779,7.384251
04-23 18:25:43.661+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.671+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:660,2.520000,1.540000,-1.190000
04-23 18:25:43.671+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.681+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:671,3.783052,-5.625526,7.245467
04-23 18:25:43.681+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.691+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:683,6.720000,1.750000,-0.070000
04-23 18:25:43.691+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.701+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:693,3.816552,-5.692525,7.408179
04-23 18:25:43.701+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.711+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:704,5.040000,7.070000,0.910000
04-23 18:25:43.711+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.721+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:712,3.895515,-5.670990,7.310073
04-23 18:25:43.721+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.731+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:722,-2.380000,9.450000,-0.490000
04-23 18:25:43.731+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.741+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:732,3.708875,-5.771489,7.341179
04-23 18:25:43.741+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.751+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:742,3.150000,6.860000,1.050000
04-23 18:25:43.751+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.751+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:751,3.763910,-5.510671,7.286145
04-23 18:25:43.761+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.761+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:760,4.130000,4.270000,1.750000
04-23 18:25:43.761+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:765,3.658626,-5.395815,7.336394
04-23 18:25:43.771+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.771+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.771+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:780,3.620341,-5.766702,7.396214
04-23 18:25:43.781+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:780,2.730000,0.980000,-1.330000
04-23 18:25:43.781+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:43.781+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:25:43:787,88
04-23 18:25:43.791+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.791+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.801+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:804,5.040000,2.730000,0.910000
04-23 18:25:43.801+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:804,3.859623,-5.300103,7.465607
04-23 18:25:43.811+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.811+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.811+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:819,-4.270000,4.690000,-1.120000
04-23 18:25:43.811+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:819,3.730411,-5.517848,7.274181
04-23 18:25:43.831+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.831+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.831+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:840,-3.080000,2.730000,-1.260000
04-23 18:25:43.831+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:840,3.742374,-5.718846,7.204789
04-23 18:25:43.851+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.851+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.851+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:860,2.940000,1.750000,0.140000
04-23 18:25:43.851+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:860,3.871587,-5.448457,7.489535
04-23 18:25:43.871+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.871+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.881+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:879,3.739982,-5.369494,7.305287
04-23 18:25:43.891+0200 I/gyroscope( 5717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:43:879,-1.470000,1.960000,-0.910000
04-23 18:25:43.891+0200 I/accelerometer( 5694): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:43.901+0200 I/accelerometer( 5694): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:43:904,3.828516,-5.551349,7.491928
04-23 18:25:43.901+0200 I/gyroscope( 5717): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:43.901+0200 W/CRASH_MANAGER( 5651): worker.c: worker_job(1205) > 11057566c6f63152450074
