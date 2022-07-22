S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4336
Date: 2018-04-23 18:18:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f8c52d, r5   = 0xf7372958
r6   = 0xffb84ee0, r7   = 0xffb84d90
r8   = 0xf7385c18, r9   = 0x00000000
r10  = 0xffb84e6c, fp   = 0xffb84ee0
ip   = 0x00000001, sp   = 0xffb84d68
lr   = 0xf6f8c539, pc   = 0xf6ff5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11392 KB
Buffers:     68668 KB
Cached:     216284 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11984 KB
VmRSS:       11980 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4336 TID = 4336
4336 4343 

Maps Information
f3e57000 f4656000 rw-p [stack:4343]
f465d000 f465f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4667000 f466b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4674000 f4676000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f467e000 f4681000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4690000 f4695000 r-xp /usr/lib/libsystem.so.0.0.0
f46a0000 f46a3000 r-xp /lib/libattr.so.1.1.0
f46ab000 f46bb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46c3000 f46cc000 r-xp /usr/lib/libedbus.so.1.7.99
f46d4000 f46d5000 r-xp /usr/lib/libresponse.so.0.2.96
f46de000 f46e3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f85000 f608b000 r-xp /usr/lib/libicuuc.so.57.1
f60a1000 f6229000 r-xp /usr/lib/libicui18n.so.57.1
f6239000 f6246000 r-xp /usr/lib/libail.so.0.1.0
f624f000 f6256000 r-xp /usr/lib/libminizip.so.1.0.0
f625f000 f6408000 r-xp /usr/lib/libcrypto.so.1.0.0
f6428000 f646f000 r-xp /usr/lib/libssl.so.1.0.0
f647b000 f647d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6485000 f648c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6495000 f649c000 r-xp /lib/libcrypt-2.13.so
f64cd000 f64d0000 r-xp /lib/libcap.so.2.21
f64d8000 f64da000 r-xp /usr/lib/libiri.so
f64e2000 f652b000 r-xp /usr/lib/libmdm.so.1.2.69
f6533000 f6539000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6541000 f6564000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f656e000 f6570000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6578000 f6595000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f659e000 f65a2000 r-xp /usr/lib/libsmack.so.1.0.0
f65ab000 f65c4000 r-xp /usr/lib/libnetwork.so.0.0.0
f65cd000 f65d5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65dd000 f65e3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65ec000 f65ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65f7000 f6607000 r-xp /lib/libresolv-2.13.so
f660b000 f6623000 r-xp /usr/lib/liblzma.so.5.0.3
f662c000 f662e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6636000 f6650000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6658000 f6687000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6690000 f669f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66a9000 f66b3000 r-xp /usr/lib/libsensord-shared.so
f66bc000 f678f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f679a000 f67b0000 r-xp /lib/libz.so.1.2.5
f67b8000 f67bd000 r-xp /usr/lib/libffi.so.5.0.10
f67c5000 f67c6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67ce000 f67de000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67e6000 f67ff000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6807000 f6809000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6811000 f6886000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6890000 f6896000 r-xp /lib/librt-2.13.so
f689f000 f68bd000 r-xp /usr/lib/libsystemd.so.0.4.0
f68c7000 f68c8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68d0000 f68f3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68fb000 f6900000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6908000 f6932000 r-xp /usr/lib/libdbus-1.so.3.8.12
f693b000 f6952000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f695a000 f69c3000 r-xp /lib/libm-2.13.so
f69cc000 f6a60000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a73000 f6a78000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a80000 f6a87000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a8f000 f6ab9000 r-xp /usr/lib/libsensor.so.1.9.6
f6ac2000 f6b8e000 r-xp /usr/lib/libxml2.so.2.7.8
f6b9b000 f6b9d000 r-xp /usr/lib/libiniparser.so.0
f6ba6000 f6bac000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bb5000 f6c85000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c86000 f6cba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cc3000 f6cff000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d07000 f6d0a000 r-xp /usr/lib/libbundle.so.0.1.22
f6d12000 f6d18000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d20000 f6d61000 r-xp /usr/lib/libeina.so.1.7.99
f6d6a000 f6d81000 r-xp /usr/lib/libecore.so.1.7.99
f6d98000 f6da1000 r-xp /usr/lib/libvconf.so.0.2.45
f6da9000 f6dbd000 r-xp /lib/libpthread-2.13.so
f6dc8000 f6dd5000 r-xp /usr/lib/libaul.so.0.1.0
f6ddf000 f6de1000 r-xp /lib/libdl-2.13.so
f6dea000 f6df5000 r-xp /lib/libunwind.so.8.0.1
f6e22000 f6e2a000 r-xp /lib/libgcc_s-4.6.so.1
f6e2b000 f6f4f000 r-xp /lib/libc-2.13.so
f6f5d000 f6f5f000 r-xp /usr/lib/libdlog.so.0.0.0
f6f67000 f6f73000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f7c000 f6f81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f89000 f6f98000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fa0000 f6fa4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fad000 f6fb0000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fb8000 f6fba000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fc2000 f6fc6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fce000 f6feb000 r-xp /lib/ld-2.13.so
f6ff4000 f6ff7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6ff7000 f6ffb000 r-xp /usr/lib/libsys-assert.so
f7355000 f73df000 rw-p [heap]
ffb66000 ffb87000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4336)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6ff5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f8c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c933f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ca3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ca3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cd875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cd31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c91c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c9de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ca3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ca3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cd5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cd6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cddf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46751fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4668171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf673b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6be8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bea7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d7aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d75b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d765a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d76879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fae183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fae7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6ff54f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e4285c) [/lib/libc.so.6] + 0x1785c
29: (0xf6ff4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
lientd, ret : 0
04-23 18:18:26.841+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:26.841+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:18:26.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:26.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:18:26.871+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(14202539), time2(14192444)
04-23 18:18:26.871+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:18:26.871+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:18:26.871+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:18:26.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:18:26.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:26.911+0200 W/LOCATION( 4336): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:18:26.911+0200 I/LOCATION( 4336): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:18:26.911+0200 I/LOCATION( 4336): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:18:26.911+0200 I/location( 4336): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:18:26.951+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:26.951+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:27.011+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.011+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.021+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:15,-13.230000,7.070000,-7.280000
04-23 18:18:27.021+0200 I/LOCATION( 4336): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:18:27.021+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:15,9.253045,-2.938386,2.596212
04-23 18:18:27.081+0200 E/location( 4336): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:18:27.081+0200 W/AUL     ( 4336): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:18:27.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:18:27.081+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4336
04-23 18:18:27.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4182
04-23 18:18:27.091+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.091+0200 I/utils   ( 4182): specific action
04-23 18:18:27.091+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.091+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.091+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.101+0200 W/AUL     ( 4182): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:18:27.101+0200 W/AUL     ( 4336): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4182)
04-23 18:18:27.101+0200 I/location( 4336): request sent to service es.ugr.frailty.servicemanager
04-23 18:18:27.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:18:27.101+0200 W/CAPI_APPFW_APP_CONTROL( 4336): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.101+0200 I/utils   ( 4336): specific action
04-23 18:18:27.101+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4182
04-23 18:18:27.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4186
04-23 18:18:27.111+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.111+0200 I/utils   ( 4186): specific action
04-23 18:18:27.111+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.111+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.111+0200 W/AUL     ( 4182): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4186)
04-23 18:18:27.111+0200 I/servicemanager( 4182): request sent to service es.ugr.frailty.recorder
04-23 18:18:27.111+0200 I/servicemanager( 4182): requesting to save local data
04-23 18:18:27.111+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:18:27.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4182), cmd(0)
04-23 18:18:27.111+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.111+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:27.111+0200 I/recorder( 4186): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:18:27.111+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:18:27.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(4186), cmd(0)
04-23 18:18:27.111+0200 I/recorder( 4186): guardando datos en local
04-23 18:18:27.151+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:27.151+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:27.211+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.211+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.211+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:216,5.880000,4.480000,-11.900000
04-23 18:18:27.221+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:216,9.200402,-2.603391,2.703890
04-23 18:18:27.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:18:27.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:18:27.281+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:18:27.291+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.291+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.301+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:296,9.466006,-2.895315,2.148755
04-23 18:18:27.301+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:296,5.040000,2.170000,-8.330000
04-23 18:18:27.311+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.311+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.311+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:315,9.332008,-2.323431,2.359323
04-23 18:18:27.311+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:315,10.360000,3.920000,-9.660000
04-23 18:18:27.331+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.331+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.341+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:336,4.340000,3.290000,-9.520000
04-23 18:18:27.341+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:337,9.174082,-1.883151,2.431108
04-23 18:18:27.351+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.351+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.351+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:27.351+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:27.351+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:357,9.253045,-2.072184,2.471786
04-23 18:18:27.351+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:357,-2.380000,0.280000,-7.210000
04-23 18:18:27.371+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.371+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.381+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:383,9.346365,-2.316252,2.287539
04-23 18:18:27.381+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:383,2.590000,-0.490000,-6.090000
04-23 18:18:27.391+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.391+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.391+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:396,9.660000,-0.700000,-4.410000
04-23 18:18:27.391+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:396,9.324830,-2.380858,2.222932
04-23 18:18:27.411+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.411+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.411+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:416,9.394222,-2.191825,2.143969
04-23 18:18:27.411+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:417,11.480000,-0.840000,-3.710000
04-23 18:18:27.431+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.431+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.431+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:438,9.439686,-1.916651,1.978864
04-23 18:18:27.441+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:438,-0.490000,-1.050000,-2.870000
04-23 18:18:27.451+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.451+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.451+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:458,9.446864,-2.428715,2.277967
04-23 18:18:27.451+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:458,-1.120000,3.080000,-2.170000
04-23 18:18:27.471+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.471+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.481+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:483,9.341579,-2.378466,2.615355
04-23 18:18:27.481+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:483,12.810000,4.410000,-3.920000
04-23 18:18:27.491+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.491+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.501+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:498,9.279366,-2.055435,2.634498
04-23 18:18:27.511+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.511+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:498,9.660000,2.240000,-5.670000
04-23 18:18:27.511+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.521+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:515,9.250652,-2.057827,2.763710
04-23 18:18:27.521+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:517,-3.920000,1.120000,-3.150000
04-23 18:18:27.531+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.531+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.531+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:536,-2.030000,-0.070000,-2.100000
04-23 18:18:27.531+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:536,9.320045,-2.146362,2.163112
04-23 18:18:27.551+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.551+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.551+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:27.551+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:27.561+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:558,2.030000,1.050000,-1.680000
04-23 18:18:27.561+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:558,9.473185,-2.184647,2.199004
04-23 18:18:27.571+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.571+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.581+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:583,9.730000,3.500000,-1.610000
04-23 18:18:27.581+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:583,9.396614,-2.306681,2.402394
04-23 18:18:27.591+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.591+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.591+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:596,9.100000,2.730000,-3.570000
04-23 18:18:27.591+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:596,9.332008,-1.823331,2.376073
04-23 18:18:27.611+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.611+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.611+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:616,2.450000,3.080000,-2.450000
04-23 18:18:27.611+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:616,9.288938,-2.062613,2.471786
04-23 18:18:27.631+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.631+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.631+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:637,9.296116,-2.359323,2.644069
04-23 18:18:27.631+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:637,8.050000,0.420000,-2.380000
04-23 18:18:27.651+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.651+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.651+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:657,13.090000,0.280000,-2.170000
04-23 18:18:27.661+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:660,9.377472,-2.234896,2.455036
04-23 18:18:27.671+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.671+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.681+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:683,10.640000,0.980000,-1.960000
04-23 18:18:27.691+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:683,9.370294,-1.974079,2.316252
04-23 18:18:27.701+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.721+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:708,9.315259,-1.976472,2.196611
04-23 18:18:27.721+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.731+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.751+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:741,6.230000,0.770000,-1.960000
04-23 18:18:27.761+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:27.761+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:18:27.761+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.771+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:767,2.450000,0.490000,-3.010000
04-23 18:18:27.771+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.781+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:780,10.710000,1.890000,-6.720000
04-23 18:18:27.781+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.791+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:791,16.240000,4.130000,-7.840000
04-23 18:18:27.791+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.811+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:731,9.415757,-2.577070,2.349752
04-23 18:18:27.811+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.821+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:804,11.130000,2.240000,-6.300000
04-23 18:18:27.821+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.821+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:824,9.463614,-2.634498,2.435893
04-23 18:18:27.821+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.831+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:829,7.210000,2.730000,-4.270000
04-23 18:18:27.831+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.831+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:834,9.257831,-2.110470,2.608176
04-23 18:18:27.841+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.841+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:841,7.210000,1.470000,-1.470000
04-23 18:18:27.851+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.851+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:849,9.262616,-2.005185,2.675175
04-23 18:18:27.851+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.851+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:855,13.860000,2.170000,-1.120000
04-23 18:18:27.851+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.861+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:864,16.799999,1.820000,-2.170000
04-23 18:18:27.861+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:858,9.298509,-1.586441,2.490928
04-23 18:18:27.861+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.871+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:874,9.399008,-1.596013,2.383251
04-23 18:18:27.871+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.871+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.881+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:881,9.358330,-1.840081,2.787638
04-23 18:18:27.881+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.881+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:882,11.550000,-3.570000,-0.560000
04-23 18:18:27.881+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:885,9.279366,-1.818545,3.062813
04-23 18:18:27.881+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.891+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:890,9.229117,-1.550549,3.024528
04-23 18:18:27.891+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.891+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:896,1.820000,-6.440000,2.800000
04-23 18:18:27.891+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.911+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.911+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:915,7.490000,-5.390000,3.990000
04-23 18:18:27.911+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:901,9.293723,-1.667797,2.840281
04-23 18:18:27.911+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.921+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:923,9.365508,-1.797010,2.467000
04-23 18:18:27.931+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.931+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:936,14.140000,-3.500000,3.430000
04-23 18:18:27.931+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.931+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:941,9.418150,-1.947758,2.237289
04-23 18:18:27.951+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.951+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:18:27.951+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:956,9.442079,-1.794617,2.352145
04-23 18:18:27.951+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.951+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:27.961+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:961,19.250000,-0.980000,2.380000
04-23 18:18:27.961+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:27:964,77
04-23 18:18:27.971+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.971+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.981+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:980,16.450001,-3.780000,2.450000
04-23 18:18:27.981+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:980,9.394222,-1.674976,2.428715
04-23 18:18:27.991+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:27.991+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:27.991+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:27:995,9.267403,-2.012364,2.184647
04-23 18:18:27.991+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:27:995,3.920000,-4.550000,4.130000
04-23 18:18:28.011+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.011+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.011+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:16,-0.280000,-3.220000,4.690000
04-23 18:18:28.011+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:16,9.504292,-2.045863,2.206182
04-23 18:18:28.031+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.031+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.041+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:38,2.100000,-0.630000,2.660000
04-23 18:18:28.041+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:39,9.454042,-2.230111,1.823331
04-23 18:18:28.051+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.051+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.061+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:59,9.487542,-1.923829,2.352145
04-23 18:18:28.061+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:59,5.180000,3.850000,1.750000
04-23 18:18:28.071+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.071+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.081+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:82,9.296116,-1.840081,2.555535
04-23 18:18:28.081+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:82,5.390000,3.640000,0.560000
04-23 18:18:28.091+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.091+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.101+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:97,9.284152,-2.050649,2.699104
04-23 18:18:28.101+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:96,-1.400000,0.560000,0.840000
04-23 18:18:28.111+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.111+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.111+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:117,9.382257,-2.086541,2.505285
04-23 18:18:28.121+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:116,1.050000,-0.980000,0.490000
04-23 18:18:28.131+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.131+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.141+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:139,9.284152,-1.938186,2.282753
04-23 18:18:28.141+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:139,7.980000,-1.610000,1.470000
04-23 18:18:28.151+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.151+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.151+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:156,6.090000,-1.540000,1.330000
04-23 18:18:28.161+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:28.161+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:28:165,77
04-23 18:18:28.161+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:157,9.437292,-2.084148,2.383251
04-23 18:18:28.171+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.171+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.181+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:182,9.406186,-1.940579,2.505285
04-23 18:18:28.181+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:182,3.920000,1.400000,0.840000
04-23 18:18:28.191+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.191+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.201+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:197,5.040000,1.190000,1.680000
04-23 18:18:28.201+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:197,9.243474,-1.753939,2.790031
04-23 18:18:28.211+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.211+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.211+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:216,9.240000,-2.100000,0.980000
04-23 18:18:28.231+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.241+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:216,9.394222,-2.031506,2.744568
04-23 18:18:28.251+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:241,13.650000,-1.960000,0.840000
04-23 18:18:28.251+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.261+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:259,9.660000,-3.570000,0.350000
04-23 18:18:28.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:18:28.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:18:28.271+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:18:28.271+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.281+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:277,9.346365,-1.950150,2.608176
04-23 18:18:28.281+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.281+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.291+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:289,9.332008,-2.115255,2.057827
04-23 18:18:28.291+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.301+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:299,9.322437,-2.163112,2.507678
04-23 18:18:28.301+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.301+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:307,9.394222,-1.718047,2.959922
04-23 18:18:28.311+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.311+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:289,5.250000,-2.520000,0.420000
04-23 18:18:28.311+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.321+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:317,9.396614,-1.627119,2.550749
04-23 18:18:28.321+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:323,8.120000,-2.730000,0.350000
04-23 18:18:28.321+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.331+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.331+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:336,9.351151,-1.727618,2.273181
04-23 18:18:28.341+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:334,10.710000,-2.800000,1.050000
04-23 18:18:28.341+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.341+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:349,7.840000,-3.710000,2.310000
04-23 18:18:28.351+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.351+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:356,9.463614,-2.227718,2.100898
04-23 18:18:28.361+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.361+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:365,5.600000,-5.320000,1.890000
04-23 18:18:28.361+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:28.371+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:28:371,77
04-23 18:18:28.371+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.381+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:381,9.475577,-2.244468,2.478964
04-23 18:18:28.381+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.381+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:387,7.140000,0.280000,-0.630000
04-23 18:18:28.391+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.391+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:396,9.217153,-2.050649,2.660819
04-23 18:18:28.391+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.401+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:402,9.450000,-1.330000,-2.240000
04-23 18:18:28.411+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.411+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.411+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:417,9.320045,-1.847259,2.794817
04-23 18:18:28.411+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:418,4.620000,-6.090000,-2.870000
04-23 18:18:28.431+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.431+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.431+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:439,9.296116,-1.954936,2.622534
04-23 18:18:28.431+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:439,2.520000,-8.820000,-1.610000
04-23 18:18:28.451+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.451+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.451+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:457,9.387043,-2.065006,2.411965
04-23 18:18:28.451+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:457,6.650000,-8.400000,-0.980000
04-23 18:18:28.471+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.471+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.481+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:480,9.468399,-1.871187,2.462214
04-23 18:18:28.481+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:482,13.650000,-5.320000,-1.190000
04-23 18:18:28.491+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.491+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.491+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:496,17.430000,-6.020000,-1.960000
04-23 18:18:28.491+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:496,9.406186,-1.938186,2.378466
04-23 18:18:28.511+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.511+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.511+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:517,11.480000,-5.810000,-1.960000
04-23 18:18:28.511+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:517,9.477970,-1.631905,2.263610
04-23 18:18:28.531+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.531+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.541+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:539,7.070000,-5.740000,-1.120000
04-23 18:18:28.541+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:539,9.403792,-1.832902,2.244468
04-23 18:18:28.551+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.551+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.551+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:558,12.810000,-5.810000,-1.330000
04-23 18:18:28.561+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:28.561+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:557,9.437292,-2.151148,2.603391
04-23 18:18:28.571+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:28:564,77
04-23 18:18:28.571+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.571+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.581+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:581,27.160000,-5.670000,-2.030000
04-23 18:18:28.581+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:580,9.454042,-1.627119,2.093720
04-23 18:18:28.591+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.591+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.591+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:596,9.473185,-1.227518,2.069792
04-23 18:18:28.601+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:597,22.469999,-5.250000,-1.050000
04-23 18:18:28.611+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.611+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.621+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:616,13.230000,-3.710000,1.260000
04-23 18:18:28.631+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:616,9.511470,-1.241875,2.579463
04-23 18:18:28.631+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.631+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.641+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:638,12.670000,-3.360000,2.730000
04-23 18:18:28.641+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:639,9.348758,-1.828116,2.486143
04-23 18:18:28.651+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.651+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.661+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:658,24.290001,-6.160000,3.430000
04-23 18:18:28.661+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:658,9.535398,-1.808974,2.213361
04-23 18:18:28.671+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.671+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.681+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:681,9.511470,-1.002593,2.055435
04-23 18:18:28.681+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:681,19.460001,-2.800000,3.150000
04-23 18:18:28.691+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.691+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.691+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:697,9.375079,-1.270589,2.024328
04-23 18:18:28.691+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:697,-1.120000,-3.920000,5.250000
04-23 18:18:28.711+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.711+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.711+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:716,9.485149,-1.792224,1.560120
04-23 18:18:28.711+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:716,-10.500000,-4.270000,6.160000
04-23 18:18:28.731+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.731+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.751+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:742,9.714860,-1.545763,2.170290
04-23 18:18:28.751+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.761+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:28.761+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:739,-9.520000,0.490000,4.760000
04-23 18:18:28.761+0200 W/LOCATION( 4336): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:18:28.761+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.781+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:760,9.384650,-2.021935,2.287539
04-23 18:18:28.781+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.781+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:772,-0.630000,1.400000,3.780000
04-23 18:18:28.781+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:28:766,77
04-23 18:18:28.781+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.801+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:787,9.466006,-1.899901,2.143969
04-23 18:18:28.801+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.801+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:790,7.700000,-0.490000,3.220000
04-23 18:18:28.801+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.811+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:807,9.554541,-1.533799,1.993221
04-23 18:18:28.811+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.821+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:810,1.470000,0.630000,3.150000
04-23 18:18:28.821+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.831+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:821,9.336794,-1.665405,1.861616
04-23 18:18:28.831+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.831+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:839,9.451650,-2.062613,2.086541
04-23 18:18:28.841+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:827,-6.930000,1.750000,4.480000
04-23 18:18:28.841+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.841+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:846,-5.250000,2.800000,5.180000
04-23 18:18:28.851+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.851+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.861+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:857,6.300000,6.090000,5.250000
04-23 18:18:28.861+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:857,9.365508,-1.885544,2.849852
04-23 18:18:28.871+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.871+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.881+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:881,13.160000,1.960000,5.670000
04-23 18:18:28.881+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:883,9.360723,-1.572084,2.926422
04-23 18:18:28.891+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.891+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.891+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:896,21.139999,-1.680000,7.980000
04-23 18:18:28.901+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:896,9.382257,-1.301696,3.093920
04-23 18:18:28.911+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.911+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:917,25.480000,-1.820000,12.320000
04-23 18:18:28.911+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.921+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:922,9.274581,-1.344766,2.837888
04-23 18:18:28.931+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.931+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.931+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:937,32.130001,-4.410000,16.799999
04-23 18:18:28.941+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:941,9.241080,-1.435694,2.785245
04-23 18:18:28.951+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.951+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:957,35.560001,-8.400000,22.540001
04-23 18:18:28.951+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.951+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:28.961+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:962,9.181261,-1.203590,3.091527
04-23 18:18:28.961+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:28:963,77
04-23 18:18:28.971+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.981+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:981,22.469999,-12.880000,30.450001
04-23 18:18:28.981+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:28.981+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:28:986,8.987441,-0.844666,3.261417
04-23 18:18:28.991+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:28.991+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:28:996,9.870000,-22.960001,42.420002
04-23 18:18:28.991+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:29.001+0200 I/accelerometer( 4301): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:29:2,9.004191,-1.292124,3.244668
04-23 18:18:29.011+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:29.011+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:29:16,22.260000,-26.250000,54.250000
04-23 18:18:29.021+0200 I/accelerometer( 4301): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:29.031+0200 I/gyroscope( 4322): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:29.041+0200 I/gyroscope( 4322): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:29:42,43.750000,-23.940001,68.809998
04-23 18:18:29.051+0200 W/CRASH_MANAGER( 4246): worker.c: worker_job(1205) > 11043366c6f63152450030
