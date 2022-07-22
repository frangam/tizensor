S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 2308
Date: 2018-04-23 18:10:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74c652d, r5   = 0xf7c04f98
r6   = 0xff98c4a0, r7   = 0xff98c350
r8   = 0xf7c01c18, r9   = 0x00000000
r10  = 0xff98c42c, fp   = 0xff98c4a0
ip   = 0x00000001, sp   = 0xff98c328
lr   = 0xf74c6539, pc   = 0xf752f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13052 KB
Buffers:     68344 KB
Cached:     217640 KB
VmPeak:      53460 KB
VmSize:      53388 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12016 KB
VmRSS:       12016 KB
VmData:      11116 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2308 TID = 2308
2308 2315 

Maps Information
f4391000 f4b90000 rw-p [stack:2315]
f4b97000 f4b99000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ba1000 f4ba5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bae000 f4bb0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bb8000 f4bbb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bca000 f4bcf000 r-xp /usr/lib/libsystem.so.0.0.0
f4bda000 f4bdd000 r-xp /lib/libattr.so.1.1.0
f4be5000 f4bf5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bfd000 f4c06000 r-xp /usr/lib/libedbus.so.1.7.99
f4c0e000 f4c0f000 r-xp /usr/lib/libresponse.so.0.2.96
f4c18000 f4c1d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64bf000 f65c5000 r-xp /usr/lib/libicuuc.so.57.1
f65db000 f6763000 r-xp /usr/lib/libicui18n.so.57.1
f6773000 f6780000 r-xp /usr/lib/libail.so.0.1.0
f6789000 f6790000 r-xp /usr/lib/libminizip.so.1.0.0
f6799000 f6942000 r-xp /usr/lib/libcrypto.so.1.0.0
f6962000 f69a9000 r-xp /usr/lib/libssl.so.1.0.0
f69b5000 f69b7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69bf000 f69c6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69cf000 f69d6000 r-xp /lib/libcrypt-2.13.so
f6a07000 f6a0a000 r-xp /lib/libcap.so.2.21
f6a12000 f6a14000 r-xp /usr/lib/libiri.so
f6a1c000 f6a65000 r-xp /usr/lib/libmdm.so.1.2.69
f6a6d000 f6a73000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a7b000 f6a9e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aa8000 f6aaa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ab2000 f6acf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ad8000 f6adc000 r-xp /usr/lib/libsmack.so.1.0.0
f6ae5000 f6afe000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b07000 f6b0f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b17000 f6b1d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b26000 f6b28000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b31000 f6b41000 r-xp /lib/libresolv-2.13.so
f6b45000 f6b5d000 r-xp /usr/lib/liblzma.so.5.0.3
f6b66000 f6b68000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b70000 f6b8a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b92000 f6bc1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bca000 f6bd9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6be3000 f6bed000 r-xp /usr/lib/libsensord-shared.so
f6bf6000 f6cc9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cd4000 f6cea000 r-xp /lib/libz.so.1.2.5
f6cf2000 f6cf7000 r-xp /usr/lib/libffi.so.5.0.10
f6cff000 f6d00000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d08000 f6d18000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d20000 f6d39000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d41000 f6d43000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d4b000 f6dc0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dca000 f6dd0000 r-xp /lib/librt-2.13.so
f6dd9000 f6df7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e01000 f6e02000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e0a000 f6e2d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e35000 f6e3a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e42000 f6e6c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e75000 f6e8c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e94000 f6efd000 r-xp /lib/libm-2.13.so
f6f06000 f6f9a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fad000 f6fb2000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fba000 f6fc1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fc9000 f6ff3000 r-xp /usr/lib/libsensor.so.1.9.6
f6ffc000 f70c8000 r-xp /usr/lib/libxml2.so.2.7.8
f70d5000 f70d7000 r-xp /usr/lib/libiniparser.so.0
f70e0000 f70e6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70ef000 f71bf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71c0000 f71f4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71fd000 f7239000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7241000 f7244000 r-xp /usr/lib/libbundle.so.0.1.22
f724c000 f7252000 r-xp /usr/lib/libappsvc.so.0.1.0
f725a000 f729b000 r-xp /usr/lib/libeina.so.1.7.99
f72a4000 f72bb000 r-xp /usr/lib/libecore.so.1.7.99
f72d2000 f72db000 r-xp /usr/lib/libvconf.so.0.2.45
f72e3000 f72f7000 r-xp /lib/libpthread-2.13.so
f7302000 f730f000 r-xp /usr/lib/libaul.so.0.1.0
f7319000 f731b000 r-xp /lib/libdl-2.13.so
f7324000 f732f000 r-xp /lib/libunwind.so.8.0.1
f735c000 f7364000 r-xp /lib/libgcc_s-4.6.so.1
f7365000 f7489000 r-xp /lib/libc-2.13.so
f7497000 f7499000 r-xp /usr/lib/libdlog.so.0.0.0
f74a1000 f74ad000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74b6000 f74bb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74c3000 f74d2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74da000 f74de000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74e7000 f74ea000 r-xp /usr/lib/libappcore-agent.so.1.1
f74f2000 f74f4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74fc000 f7500000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7508000 f7525000 r-xp /lib/ld-2.13.so
f752e000 f7531000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7531000 f7535000 r-xp /usr/lib/libsys-assert.so
f7bd1000 f7c33000 rw-p [heap]
ff96d000 ff98e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2308)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf752f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74c6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71cd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71cbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71d7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71ddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71dddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf721275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf720d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71cbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71d7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71ddbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71dddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf720fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7210017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7217f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4baf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ba2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c75663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7122fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71247a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72b4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72afb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72b05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72b0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74e8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74e87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf752f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf737c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf752ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
__connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:10:18.021+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:10:18.041+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.051+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.051+0200 E/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
04-23 18:10:18.051+0200 E/PKGMGR_INFO( 2317): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 18:10:18.071+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:18.071+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.081+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.081+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:10:18.081+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:10:18.091+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.091+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:99,8.769694,1.974079,3.795017
04-23 18:10:18.101+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.101+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:18.101+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:105,-3.430000,1.190000,-0.490000
04-23 18:10:18.111+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:10:18.121+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:10:18.121+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:10:18.121+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:18.121+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:10:18.121+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:10:18.131+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.141+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:18.141+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:10:18.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:18.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:18.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:10:18.181+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(13713848), time2(13030879)
04-23 18:10:18.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:10:18.181+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:10:18.181+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:10:18.181+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:10:18.201+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:18.221+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:18.221+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:18.231+0200 W/LOCATION( 2308): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:10:18.231+0200 I/LOCATION( 2308): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:18.231+0200 I/LOCATION( 2308): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:18.231+0200 I/location( 2308): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:10:18.291+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.291+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.331+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:300,4.270000,-2.940000,1.610000
04-23 18:10:18.331+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:301,8.740981,2.383251,3.735196
04-23 18:10:18.341+0200 I/LOCATION( 2308): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:18.391+0200 E/location( 2308): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:10:18.391+0200 W/AUL     ( 2308): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:10:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:18.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2308
04-23 18:10:18.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2259
04-23 18:10:18.401+0200 W/AUL     ( 2308): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2259)
04-23 18:10:18.401+0200 I/location( 2308): request sent to service es.ugr.frailty.servicemanager
04-23 18:10:18.401+0200 W/CAPI_APPFW_APP_CONTROL( 2308): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.401+0200 I/utils   ( 2308): specific action
04-23 18:10:18.401+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:18.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2259), cmd(0)
04-23 18:10:18.401+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.401+0200 I/utils   ( 2259): specific action
04-23 18:10:18.401+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.401+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.401+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.401+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:10:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:18.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2259
04-23 18:10:18.411+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2264
04-23 18:10:18.411+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2264)
04-23 18:10:18.411+0200 I/servicemanager( 2259): request sent to service es.ugr.frailty.recorder
04-23 18:10:18.411+0200 I/servicemanager( 2259): requesting to save local data
04-23 18:10:18.411+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.411+0200 I/utils   ( 2264): specific action
04-23 18:10:18.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:18.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2264), cmd(0)
04-23 18:10:18.421+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:18.421+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:18.421+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.421+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.421+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.421+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:18.431+0200 I/recorder( 2264): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:10:18.431+0200 I/recorder( 2264): guardando datos en local
04-23 18:10:18.491+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.491+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.511+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:502,-7.280000,-2.310000,2.240000
04-23 18:10:18.521+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:503,8.774480,2.309074,3.802195
04-23 18:10:18.621+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:18.621+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:18.691+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.701+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.711+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:705,8.642875,2.354537,4.127619
04-23 18:10:18.721+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:704,-1.050000,1.820000,0.700000
04-23 18:10:18.791+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 125 ms (from 13714327 to 13714452) (logOverhead=0,0,0,0,0,0,0), start: 18:10:18.673
04-23 18:10:18.791+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 126 ms (from 13714327 to 13714453) (logOverhead=0,0,0,0,0,0,0), start: 18:10:18.672
04-23 18:10:18.821+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:18.821+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:18.821+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:18.821+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:18.821+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:18.831+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.831+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:839,2.730000,-2.870000,0.210000
04-23 18:10:18.851+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.851+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.861+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:861,-3.990000,-0.770000,0.280000
04-23 18:10:18.861+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:861,8.807980,2.074577,3.888337
04-23 18:10:18.871+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.871+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.871+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:879,-4.620000,-1.470000,0.070000
04-23 18:10:18.881+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:879,8.791230,1.897508,3.969693
04-23 18:10:18.891+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.891+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.901+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:902,-4.830000,-0.700000,-0.140000
04-23 18:10:18.901+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:902,8.951550,2.055435,4.137190
04-23 18:10:18.911+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.911+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.921+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:920,8.807980,1.658226,4.146761
04-23 18:10:18.921+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:920,-4.830000,-1.260000,-0.420000
04-23 18:10:18.931+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.931+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.941+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:942,8.970692,2.084148,3.895515
04-23 18:10:18.941+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:942,7.350000,-2.450000,-0.420000
04-23 18:10:18.951+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.951+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.961+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:963,8.719445,2.108077,3.713661
04-23 18:10:18.961+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:963,0.070000,0.420000,1.260000
04-23 18:10:18.971+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.971+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:18.981+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:18:982,8.817552,1.694118,3.869194
04-23 18:10:18.981+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:18:982,-2.870000,0.140000,1.610000
04-23 18:10:18.991+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:18.991+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.001+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:2,8.872586,1.897508,3.938586
04-23 18:10:19.011+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:2,0.490000,1.120000,1.190000
04-23 18:10:19.011+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.011+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.051+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:19.051+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:19.061+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:23,2.240000,0.560000,0.700000
04-23 18:10:19.061+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:22,8.889337,1.988436,3.986443
04-23 18:10:19.061+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.071+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.071+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:71,4.620000,0.140000,0.700000
04-23 18:10:19.071+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.081+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:79,11.830000,0.980000,-1.190000
04-23 18:10:19.081+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.081+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:75,8.836694,1.892723,3.723232
04-23 18:10:19.081+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:87,14.420000,4.130000,-1.610000
04-23 18:10:19.081+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.091+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.091+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:93,8.872586,2.036292,3.572484
04-23 18:10:19.101+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.101+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:102,14.420000,4.970000,-2.380000
04-23 18:10:19.101+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:105,8.831908,1.988436,3.538985
04-23 18:10:19.101+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.111+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.111+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:114,8.740981,1.749153,4.070191
04-23 18:10:19.111+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.121+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:122,8.784052,1.947758,4.127619
04-23 18:10:19.121+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:121,23.309999,2.660000,-3.990000
04-23 18:10:19.141+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.151+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:152,8.829515,2.510071,3.943372
04-23 18:10:19.151+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.161+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:161,8.925228,2.486143,3.981657
04-23 18:10:19.161+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.161+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:170,23.799999,0.980000,-4.060000
04-23 18:10:19.171+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.171+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.171+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:180,15.750000,1.190000,-3.010000
04-23 18:10:19.181+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:180,8.767302,2.514857,4.067799
04-23 18:10:19.181+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.191+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.191+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:200,8.855836,2.127219,4.072584
04-23 18:10:19.201+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:189,9.730000,2.170000,-1.540000
04-23 18:10:19.201+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.201+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:206,7.140000,0.560000,-0.910000
04-23 18:10:19.211+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.221+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:221,8.898908,2.213361,3.936193
04-23 18:10:19.221+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.221+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:227,3.780000,0.490000,-0.630000
04-23 18:10:19.221+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:19.231+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:19.231+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.231+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.241+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:243,0.420000,0.630000,-0.350000
04-23 18:10:19.241+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:10:19.241+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:242,8.913264,2.294717,3.854837
04-23 18:10:19.251+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.251+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.251+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:261,1.680000,1.820000,0.210000
04-23 18:10:19.261+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:261,8.767302,2.153540,4.034299
04-23 18:10:19.271+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.271+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.271+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:280,8.590233,2.218147,4.328616
04-23 18:10:19.281+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:280,5.600000,0.980000,0.840000
04-23 18:10:19.291+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.291+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.291+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:300,8.630912,2.277967,3.943372
04-23 18:10:19.301+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:301,4.550000,-0.630000,0.630000
04-23 18:10:19.311+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.311+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.321+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:323,8.812766,2.062613,3.967300
04-23 18:10:19.321+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:323,-0.560000,0.070000,1.120000
04-23 18:10:19.331+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.331+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.341+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:343,8.784052,2.330609,3.742374
04-23 18:10:19.341+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:343,-1.890000,0.560000,0.910000
04-23 18:10:19.351+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.351+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.361+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:362,-5.040000,-0.420000,1.890000
04-23 18:10:19.361+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:362,8.760124,2.210968,3.759124
04-23 18:10:19.371+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.371+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.381+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:382,8.865408,2.462214,3.907479
04-23 18:10:19.381+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:382,-7.980000,-0.770000,2.940000
04-23 18:10:19.391+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.391+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.401+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:402,-11.970000,-1.610000,2.590000
04-23 18:10:19.401+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:402,8.918050,2.237289,4.103691
04-23 18:10:19.411+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.411+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.421+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:19.421+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:19.421+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:422,8.750552,2.000400,4.000800
04-23 18:10:19.421+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:423,-9.450000,-1.120000,1.820000
04-23 18:10:19.431+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.431+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.441+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:442,8.738588,2.098505,3.620341
04-23 18:10:19.441+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:442,-5.040000,-1.680000,1.750000
04-23 18:10:19.451+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.451+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.461+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:462,8.810372,2.160719,3.515057
04-23 18:10:19.461+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:462,-6.510000,-0.770000,1.820000
04-23 18:10:19.471+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.471+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.481+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:482,8.714661,2.256432,4.034299
04-23 18:10:19.481+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:482,-8.400000,0.700000,2.030000
04-23 18:10:19.491+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.501+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:501,8.547162,2.196611,3.912265
04-23 18:10:19.501+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.511+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:510,-13.930000,-0.210000,2.870000
04-23 18:10:19.511+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.521+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.521+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:522,8.879765,1.885544,3.651447
04-23 18:10:19.531+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:525,-11.970000,-2.520000,3.220000
04-23 18:10:19.531+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.541+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.551+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:545,-11.830000,1.890000,3.010000
04-23 18:10:19.551+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:542,8.839087,2.153540,4.067799
04-23 18:10:19.551+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.561+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.571+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:562,8.769694,1.854438,3.888337
04-23 18:10:19.571+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:565,-14.280000,-1.260000,3.080000
04-23 18:10:19.571+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.581+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.581+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:581,8.956335,1.641476,4.086941
04-23 18:10:19.581+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:585,-5.530000,0.910000,2.590000
04-23 18:10:19.591+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.601+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.601+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:606,-6.440000,1.120000,2.660000
04-23 18:10:19.601+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:600,8.745767,2.246860,3.914658
04-23 18:10:19.611+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.621+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.621+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:19.621+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:19.621+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:621,9.188439,2.170290,3.570091
04-23 18:10:19.621+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:625,-6.090000,-1.820000,2.800000
04-23 18:10:19.631+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.641+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.641+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:645,8.937192,2.646462,3.651447
04-23 18:10:19.641+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:642,-9.940000,3.640000,3.430000
04-23 18:10:19.651+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.651+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.661+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:663,-15.470000,1.890000,4.270000
04-23 18:10:19.661+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:663,8.662018,2.258825,3.763910
04-23 18:10:19.681+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:19.681+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:19.681+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:19.681+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.681+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.691+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:694,-19.950001,-0.140000,4.130000
04-23 18:10:19.691+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.691+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:690,8.731410,2.428715,2.938386
04-23 18:10:19.701+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.701+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:703,-28.559999,-0.560000,4.060000
04-23 18:10:19.711+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:704,8.956335,3.062813,2.880959
04-23 18:10:19.711+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.711+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.721+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:721,8.573483,3.799802,3.682554
04-23 18:10:19.721+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:721,-52.570000,2.520000,5.880000
04-23 18:10:19.731+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.731+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.741+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:742,-87.430000,-8.120000,6.440000
04-23 18:10:19.741+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:742,8.688338,3.768696,3.495914
04-23 18:10:19.751+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.751+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.761+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:762,-110.669998,-16.170000,7.770000
04-23 18:10:19.761+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:762,8.755339,3.201597,3.897908
04-23 18:10:19.771+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.771+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.781+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:782,8.590233,1.780260,4.455436
04-23 18:10:19.781+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:782,-108.080002,-18.129999,6.440000
04-23 18:10:19.791+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.791+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.801+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:802,8.685946,0.586242,4.357330
04-23 18:10:19.801+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:802,-83.090004,-21.280001,1.540000
04-23 18:10:19.811+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.811+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.821+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:19.821+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:19.821+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:821,-51.310001,-20.930000,-6.790000
04-23 18:10:19.821+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:821,8.841480,0.315853,3.821337
04-23 18:10:19.831+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.831+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.841+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:842,8.731410,0.775275,3.354738
04-23 18:10:19.841+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:842,-52.779999,-19.180000,-8.890000
04-23 18:10:19.851+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.851+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.861+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:862,8.805587,0.574277,3.187240
04-23 18:10:19.861+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:862,-58.099998,-17.080000,-9.170000
04-23 18:10:19.871+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.871+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.881+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:882,-54.180000,-11.620000,-7.280000
04-23 18:10:19.881+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:883,8.997013,0.488136,3.842873
04-23 18:10:19.901+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.901+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.911+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:907,-52.220001,-8.890000,-4.760000
04-23 18:10:19.921+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.931+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:926,-38.290001,-14.840000,-4.550000
04-23 18:10:19.931+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.941+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:905,8.717053,0.346959,4.816752
04-23 18:10:19.951+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:943,-24.570000,-13.790000,-3.150000
04-23 18:10:19.951+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.951+0200 W/LOCATION( 2308): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:10:19.961+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:956,8.836694,-0.009571,3.759124
04-23 18:10:19.961+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.961+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.971+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:971,9.341579,0.327817,3.426522
04-23 18:10:19.971+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.971+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:969,-32.130001,-7.070000,-3.150000
04-23 18:10:19.971+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.981+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:980,9.128618,0.138784,3.967300
04-23 18:10:19.981+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:19.991+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:19:984,-16.309999,-5.530000,1.330000
04-23 18:10:19.991+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:19.991+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:19:992,9.104690,-0.282353,5.079963
04-23 18:10:19.991+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.001+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:4,8.939585,-0.339781,4.539185
04-23 18:10:20.001+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:1,-1.960000,-5.880000,0.560000
04-23 18:10:20.011+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.021+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.021+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:20.021+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:20.021+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:21,9.351151,0.169890,3.433701
04-23 18:10:20.021+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:25,4.200000,-10.430000,-0.280000
04-23 18:10:20.031+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.031+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.041+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:42,9.128618,0.428315,3.426522
04-23 18:10:20.041+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:42,-6.160000,-5.390000,2.660000
04-23 18:10:20.051+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.051+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.061+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:61,9.281759,0.468993,3.924229
04-23 18:10:20.061+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:61,-4.480000,-4.760000,4.130000
04-23 18:10:20.071+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.071+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.081+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:81,9.300901,0.461815,4.003192
04-23 18:10:20.081+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:81,5.040000,-2.800000,5.390000
04-23 18:10:20.091+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.091+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.101+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:101,9.477970,0.885344,3.890730
04-23 18:10:20.101+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:101,10.360000,-4.060000,3.570000
04-23 18:10:20.111+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.111+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.121+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:121,-4.200000,-4.200000,3.150000
04-23 18:10:20.121+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:121,9.083155,0.634098,3.187240
04-23 18:10:20.131+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.131+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.141+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:142,-1.470000,-3.850000,2.730000
04-23 18:10:20.141+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:142,9.231510,0.428315,3.450450
04-23 18:10:20.151+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.151+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.161+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:161,4.690000,-2.030000,2.030000
04-23 18:10:20.161+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:161,8.987441,0.535992,3.541377
04-23 18:10:20.171+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.171+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.181+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:180,22.469999,-3.290000,0.770000
04-23 18:10:20.181+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:180,9.358330,0.256032,3.768696
04-23 18:10:20.191+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.191+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.201+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:201,9.509077,0.272782,3.567699
04-23 18:10:20.201+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:201,37.310001,0.770000,-3.080000
04-23 18:10:20.211+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.211+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.221+0200 I/accelerometer( 2270): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:20:222,8.994620,1.071985,3.579663
04-23 18:10:20.221+0200 I/heartrate( 2294): capturing data from es.ugr.frailty.heartrate
04-23 18:10:20.221+0200 I/heartrate( 2294): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:10:20.221+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:221,19.879999,0.140000,-1.470000
04-23 18:10:20.231+0200 I/accelerometer( 2270): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:20.241+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.241+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:245,7.700000,-4.340000,-0.700000
04-23 18:10:20.261+0200 W/AUL     ( 2329): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 18:10:20.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:10:20.261+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:10:20.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 1769
04-23 18:10:20.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:10:20.271+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 18:10:20.271+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 18:10:20.271+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:10:20.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:10:20.271+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:272,14.280000,-0.420000,-1.680000
04-23 18:10:20.271+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.271+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1769
04-23 18:10:20.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(1769)
04-23 18:10:20.281+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:282,17.780001,-0.700000,-2.380000
04-23 18:10:20.281+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:20.291+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.291+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:300,21.490000,-1.400000,-3.500000
04-23 18:10:20.341+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:10:20.341+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:10:20.341+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 18:10:20.341+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_destroy(471) > Destroy handle: 0xf7261cc0
04-23 18:10:20.351+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.351+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:358,12.530000,1.680000,-3.290000
04-23 18:10:20.351+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.361+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:363,6.650000,-1.540000,-2.800000
04-23 18:10:20.361+0200 I/gyroscope( 2283): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:20.361+0200 I/gyroscope( 2283): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:20:367,17.360001,-4.480000,-2.100000
04-23 18:10:20.361+0200 I/servicemanager( 2259): es.ugr.frailty.location sleep timeout
04-23 18:10:20.361+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 18:10:20.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:20.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2259
04-23 18:10:20.381+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 2340
04-23 18:10:20.381+0200 W/CRASH_MANAGER( 2332): worker.c: worker_job(1205) > 11023086c6f63152449982
