S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8926
Date: 2018-04-23 20:29:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf759052d, r5   = 0xf7c29f98
r6   = 0xff807790, r7   = 0xff807640
r8   = 0xf7c26c18, r9   = 0x00000000
r10  = 0xff80771c, fp   = 0xff807790
ip   = 0x00000001, sp   = 0xff807618
lr   = 0xf7590539, pc   = 0xf75f9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146316 KB
Buffers:     33804 KB
Cached:     152736 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11824 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8926 TID = 8926
8926 8929 

Maps Information
f445b000 f4c5a000 rw-p [stack:8929]
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
f7bf6000 f7c67000 rw-p [heap]
ff7e8000 ff809000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8926)
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
27: main + 0xda (0xf75f94f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
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
29+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:58.029+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:58.029+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:58.029+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:58.029+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:58.039+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.039+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:28:58.039+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2213306), time2(2210211)
04-23 20:28:58.039+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:28:58.039+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:28:58.039+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:28:58.039+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:28:58.049+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.049+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:58.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.119+0200 W/LOCATION( 8877): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:58.119+0200 I/LOCATION( 8877): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:58.119+0200 I/LOCATION( 8877): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:28:58.119+0200 I/location( 8877): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:28:58.259+0200 I/LOCATION( 8877): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:28:58.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:28:58.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:58.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:28:58.379+0200 E/location( 8877): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:28:58.379+0200 W/AUL     ( 8877): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:28:58.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:58.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8877
04-23 20:28:58.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:28:58.399+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:58.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:28:58.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.399+0200 I/utils   ( 8242): specific action
04-23 20:28:58.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.399+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:28:58.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:28:58.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:28:58.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:28:58.409+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:28:58.409+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:28:58.409+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:28:58.409+0200 W/AUL     ( 8877): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:28:58.409+0200 I/location( 8877): request sent to service es.ugr.frailty.servicemanager
04-23 20:28:58.409+0200 I/location( 8877): stopping es.ugr.frailty.location service
04-23 20:28:58.409+0200 E/CAPI_APPFW_APP_CONTROL( 8877): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:28:58.409+0200 E/location( 8877): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:28:58.409+0200 I/CAPI_APPFW_APPLICATION( 8877): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:28:58.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:28:58.409+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:28:58.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.409+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:28:58.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:28:58.409+0200 I/utils   ( 8247): specific action
04-23 20:28:58.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:28:58.419+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:28:58.429+0200 I/recorder( 8247): guardando datos en local
04-23 20:28:58.469+0200 W/LOCATION( 8877): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:28:58.469+0200 I/LOCATION( 8877): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:58.469+0200 I/LOCATION( 8877): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:28:58.559+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:28:58.559+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:28:58.569+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:28:58.569+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:28:58.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.729+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:58.729+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:58.729+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:58.729+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76bc640
04-23 20:28:58.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76cc620]
04-23 20:28:58.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:58.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:58.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:58.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:58.789+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:58.799+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:58.799+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.809+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.809+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:58.809+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:58.809+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:58.809+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:58.809+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:58.809+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:58.809+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:58.809+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:58.809+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:58.819+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.829+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:58.829+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:58.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.879+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.879+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:58.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:58.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:58.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:58.929+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76cc620
04-23 20:28:59.009+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40320f0]
04-23 20:28:59.009+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:28:59.009+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:28:59.009+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:28:59.009+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:28:59.019+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:59.019+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:59.029+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:59.039+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:59.039+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:28:59.039+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:28:59.039+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:28:59.039+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:28:59.039+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:28:59.039+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:28:59.039+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:28:59.039+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:28:59.039+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:28:59.049+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:59.059+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:28:59.059+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:28:59.059+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:59.109+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:28:59.119+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:28:59.119+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:28:59.119+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:28:59.119+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf40320f0
04-23 20:28:59.329+0200 W/AUL     ( 8889): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:28:59.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:28:59.329+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:28:59.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8855
04-23 20:28:59.329+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:28:59.329+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8855
04-23 20:28:59.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8855)
04-23 20:29:00.409+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:29:07.519+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:29:07.519+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:29:07.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:07.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:07.529+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:29:07.529+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8926
04-23 20:29:07.579+0200 E/CAPI_APPFW_APPLICATION( 8926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:07.579+0200 E/CAPI_APPFW_APPLICATION( 8926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:07.579+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8926
04-23 20:29:07.579+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(8926) type(svcapp) bg(0)
04-23 20:29:07.579+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8926)
04-23 20:29:07.579+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8926]
04-23 20:29:07.579+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:29:07.579+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:29:07.589+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8926) was created
04-23 20:29:07.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:07.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8926
04-23 20:29:07.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:07.639+0200 W/LOCATION( 8926): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:29:07.639+0200 E/LOCATION( 8926): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:29:07.639+0200 E/PKGMGR_INFO( 8926): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:29:07.639+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:07.659+0200 I/LOCATION( 8926): location.c: location_new(269) > method: 0
04-23 20:29:07.659+0200 W/LOCATION( 8926): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:07.669+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:07.679+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:07.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:07.689+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8926
04-23 20:29:07.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:07.689+0200 W/LOCATION( 8926): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:07.699+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:07.699+0200 W/LOCATION( 8926): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:07.699+0200 W/LOCATION( 8926): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:07.699+0200 W/LOCATION( 8926): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:07.699+0200 W/LOCATION( 8926): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:07.719+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:07.729+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:07.729+0200 W/LOCATION( 8926): module-internal.c: module_new(311) > module (wps) open success
04-23 20:29:07.729+0200 W/LOCATION( 8926): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:29:07.739+0200 W/LOCATION( 8926): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:29:07.739+0200 W/LOCATION( 8926): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:07.739+0200 W/LOCATION( 8926): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:07.749+0200 W/LOCATION( 8926): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:29:07.749+0200 I/LOCATION( 8926): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7c26c18
04-23 20:29:07.759+0200 I/LOCATION( 8926): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:29:07.759+0200 I/LOCATION( 8926): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7c26c18
04-23 20:29:07.759+0200 I/LOCATION( 8926): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:29:07.759+0200 I/location( 8926): es.ugr.frailty.location: creado servicio de localización
04-23 20:29:07.809+0200 I/LOCATION( 8926): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:29:07.839+0200 W/LOCATION( 8926): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:07.849+0200 W/LOCATION( 8926): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:07.849+0200 I/LOCATION( 8926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:29:07.919+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:29:07.919+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:07.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:29:07.919+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:29:07.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:29:07.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:29:07.919+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:29:07.919+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:29:07.919+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:29:07.919+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:29:07.919+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:29:07.919+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:29:07.979+0200 W/LOCATION( 8926): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:07.979+0200 W/LOCATION( 8926): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:08.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:08.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76c59f0]
04-23 20:29:08.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:08.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:08.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:08.099+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:08.099+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:08.099+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:08.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:08.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:08.119+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:08.119+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:08.119+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:08.119+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:08.119+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:08.119+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:08.119+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:08.119+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:08.119+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:08.129+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:08.139+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:08.139+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:08.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:08.159+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:29:08.159+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2223423), time2(2210211)
04-23 20:29:08.159+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:29:08.159+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:29:08.159+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:29:08.159+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:29:08.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:08.209+0200 W/LOCATION( 8926): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:29:08.209+0200 I/LOCATION( 8926): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:08.209+0200 I/LOCATION( 8926): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:08.219+0200 I/location( 8926): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:29:08.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:08.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:08.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:08.339+0200 I/LOCATION( 8926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:08.389+0200 E/location( 8926): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:29:08.389+0200 W/AUL     ( 8926): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:29:08.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:08.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8926
04-23 20:29:08.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:29:08.399+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:08.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:29:08.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.399+0200 I/utils   ( 8242): specific action
04-23 20:29:08.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.399+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.399+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:29:08.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:08.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:08.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:29:08.409+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:08.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 I/utils   ( 8247): specific action
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:29:08.419+0200 I/recorder( 8247): guardando datos en local
04-23 20:29:08.419+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:29:08.419+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:29:08.419+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:29:08.419+0200 W/AUL     ( 8926): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:29:08.419+0200 I/location( 8926): request sent to service es.ugr.frailty.servicemanager
04-23 20:29:08.419+0200 W/CAPI_APPFW_APP_CONTROL( 8926): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.419+0200 I/utils   ( 8926): specific action
04-23 20:29:08.839+0200 I/servicemanager( 8242): es.ugr.frailty.gravity alive timeout
04-23 20:29:08.839+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:29:08.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:08.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:08.849+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:29:08.849+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 8932
04-23 20:29:08.899+0200 E/CAPI_APPFW_APPLICATION( 8932): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:08.899+0200 E/CAPI_APPFW_APPLICATION( 8932): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:08.899+0200 I/utils   ( 8932): trying to start service: es.ugr.frailty.gravity
04-23 20:29:08.899+0200 I/utils   ( 8932): es.ugr.frailty.gravity sensor supported
04-23 20:29:08.899+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8932
04-23 20:29:08.899+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(8932) type(svcapp) bg(0)
04-23 20:29:08.899+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (8932) was created
04-23 20:29:08.899+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8932]
04-23 20:29:08.919+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:08.929+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8932
04-23 20:29:08.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:08.929+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8932)
04-23 20:29:08.929+0200 I/servicemanager( 8242): es.ugr.frailty.gravity launch request sent!
04-23 20:29:08.929+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:29:08.939+0200 I/utils   ( 8932): es.ugr.frailty.gravity listener started
04-23 20:29:08.939+0200 W/CAPI_APPFW_APP_CONTROL( 8932): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:08.939+0200 I/utils   ( 8932): specific action
04-23 20:29:08.959+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:08.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:08:971,9.775698,-0.057335,0.776418
04-23 20:29:08.979+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:08.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:08:985,9.775677,-0.057477,0.776675
04-23 20:29:08.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:08.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:0,0.056861,9.775540,0.778441
04-23 20:29:08.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8932
04-23 20:29:09.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:09.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.019+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:20,0.054872,9.775442,0.779807
04-23 20:29:09.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.049+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:58,0.053064,9.775441,0.779948
04-23 20:29:09.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.059+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:63,0.052732,9.775577,0.778267
04-23 20:29:09.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.079+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:80,0.052646,9.775501,0.779224
04-23 20:29:09.099+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:111,0.052676,9.775207,0.782905
04-23 20:29:09.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:119,0.050907,9.775000,0.785602
04-23 20:29:09.139+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.189+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:29:09.199+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:146,0.048831,9.774966,0.786158
04-23 20:29:09.199+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.199+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:206,0.048233,9.774956,0.786320
04-23 20:29:09.199+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.209+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:212,0.046759,9.774881,0.787328
04-23 20:29:09.209+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.219+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:217,0.046502,9.774768,0.788758
04-23 20:29:09.219+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.219+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:223,0.046146,9.774694,0.789684
04-23 20:29:09.229+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.239+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:240,0.045343,9.774621,0.790638
04-23 20:29:09.249+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.259+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:261,0.045056,9.774516,0.791950
04-23 20:29:09.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.279+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:280,0.044442,9.774279,0.794917
04-23 20:29:09.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:09.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:09.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:09.299+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:305,0.044750,9.774280,0.794879
04-23 20:29:09.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:319,0.044110,9.774469,0.792585
04-23 20:29:09.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:339,0.043106,9.774315,0.794543
04-23 20:29:09.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.359+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:362,0.043632,9.774201,0.795911
04-23 20:29:09.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.379+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:381,0.044000,9.774355,0.793993
04-23 20:29:09.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.399+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:400,0.044444,9.774289,0.794786
04-23 20:29:09.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.419+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:420,0.045087,9.774292,0.794708
04-23 20:29:09.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.439+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:441,0.045361,9.774224,0.795525
04-23 20:29:09.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:462,0.047092,9.774084,0.797154
04-23 20:29:09.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:481,0.046597,9.773922,0.799161
04-23 20:29:09.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:501,0.044181,9.773782,0.801018
04-23 20:29:09.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:520,0.044034,9.773777,0.801076
04-23 20:29:09.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:574,0.043556,9.773739,0.801566
04-23 20:29:09.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:578,0.045439,9.773741,0.801446
04-23 20:29:09.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:595,0.044914,9.773740,0.801487
04-23 20:29:09.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.599+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:601,0.043744,9.773528,0.804127
04-23 20:29:09.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:622,0.043174,9.773384,0.805908
04-23 20:29:09.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.639+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:641,0.043653,9.773397,0.805717
04-23 20:29:09.649+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.659+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:663,0.041089,9.773358,0.806324
04-23 20:29:09.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.679+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:682,0.040878,9.773417,0.805635
04-23 20:29:09.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:701,0.040106,9.773333,0.806691
04-23 20:29:09.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:720,0.040276,9.773468,0.805039
04-23 20:29:09.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:741,0.041296,9.773242,0.807723
04-23 20:29:09.749+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.759+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:762,0.042136,9.773077,0.809676
04-23 20:29:09.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:781,0.039967,9.773623,0.803170
04-23 20:29:09.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.799+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:801,0.040032,9.773197,0.808325
04-23 20:29:09.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:820,0.041047,9.773229,0.807897
04-23 20:29:09.839+0200 W/LOCATION( 8926): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:29:09.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.849+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:853,0.040087,9.773298,0.807110
04-23 20:29:09.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.859+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:862,0.040668,9.772890,0.812002
04-23 20:29:09.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.879+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:880,0.041013,9.773021,0.810410
04-23 20:29:09.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:900,0.043259,9.772453,0.817105
04-23 20:29:09.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:921,0.044937,9.773358,0.806122
04-23 20:29:09.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.939+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:940,0.043785,9.773738,0.801574
04-23 20:29:09.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:961,0.044502,9.773201,0.808055
04-23 20:29:09.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:09:981,0.041212,9.773483,0.804810
04-23 20:29:09.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:09.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:0,0.040305,9.773780,0.801237
04-23 20:29:10.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:10.019+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:20,0.041445,9.773938,0.799247
04-23 20:29:10.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:10.039+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:41,0.039632,9.774199,0.796155
04-23 20:29:10.079+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:10.079+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:83,0.040169,9.773777,0.801287
04-23 20:29:10.079+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:10.089+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:92,0.041047,9.774000,0.798517
04-23 20:29:10.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:10.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:10:101,0.041313,9.774036,0.798055
04-23 20:29:10.099+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11089266c6f63152450814
