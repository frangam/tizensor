S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 32743
Date: 2018-04-23 17:58:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf707c52d, r5   = 0xf7715958
r6   = 0xff9a03b0, r7   = 0xff9a0260
r8   = 0xf7728c18, r9   = 0x00000000
r10  = 0xff9a033c, fp   = 0xff9a03b0
ip   = 0x00000001, sp   = 0xff99f0e0
lr   = 0xf707c539, pc   = 0xf70e527a
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     14576 KB
Buffers:     67684 KB
Cached:     217228 KB
VmPeak:      53632 KB
VmSize:      53628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11968 KB
VmRSS:       11968 KB
VmData:      11356 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 32743 TID = 32743
32743 32746 

Maps Information
f3f47000 f4746000 rw-p [stack:32746]
f474d000 f474f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4757000 f475b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4764000 f4766000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f476e000 f4771000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4780000 f4785000 r-xp /usr/lib/libsystem.so.0.0.0
f4790000 f4793000 r-xp /lib/libattr.so.1.1.0
f479b000 f47ab000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47b3000 f47bc000 r-xp /usr/lib/libedbus.so.1.7.99
f47c4000 f47c5000 r-xp /usr/lib/libresponse.so.0.2.96
f47ce000 f47d3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6075000 f617b000 r-xp /usr/lib/libicuuc.so.57.1
f6191000 f6319000 r-xp /usr/lib/libicui18n.so.57.1
f6329000 f6336000 r-xp /usr/lib/libail.so.0.1.0
f633f000 f6346000 r-xp /usr/lib/libminizip.so.1.0.0
f634f000 f64f8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6518000 f655f000 r-xp /usr/lib/libssl.so.1.0.0
f656b000 f656d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6575000 f657c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6585000 f658c000 r-xp /lib/libcrypt-2.13.so
f65bd000 f65c0000 r-xp /lib/libcap.so.2.21
f65c8000 f65ca000 r-xp /usr/lib/libiri.so
f65d2000 f661b000 r-xp /usr/lib/libmdm.so.1.2.69
f6623000 f6629000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6631000 f6654000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f665e000 f6660000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6668000 f6685000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f668e000 f6692000 r-xp /usr/lib/libsmack.so.1.0.0
f669b000 f66b4000 r-xp /usr/lib/libnetwork.so.0.0.0
f66bd000 f66c5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66cd000 f66d3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66dc000 f66de000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66e7000 f66f7000 r-xp /lib/libresolv-2.13.so
f66fb000 f6713000 r-xp /usr/lib/liblzma.so.5.0.3
f671c000 f671e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6726000 f6740000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6748000 f6777000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6780000 f678f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6799000 f67a3000 r-xp /usr/lib/libsensord-shared.so
f67ac000 f687f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f688a000 f68a0000 r-xp /lib/libz.so.1.2.5
f68a8000 f68ad000 r-xp /usr/lib/libffi.so.5.0.10
f68b5000 f68b6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68be000 f68ce000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68d6000 f68ef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68f7000 f68f9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6901000 f6976000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6980000 f6986000 r-xp /lib/librt-2.13.so
f698f000 f69ad000 r-xp /usr/lib/libsystemd.so.0.4.0
f69b7000 f69b8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69c0000 f69e3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69eb000 f69f0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69f8000 f6a22000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a2b000 f6a42000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a4a000 f6ab3000 r-xp /lib/libm-2.13.so
f6abc000 f6b50000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b63000 f6b68000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b70000 f6b77000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b7f000 f6ba9000 r-xp /usr/lib/libsensor.so.1.9.6
f6bb2000 f6c7e000 r-xp /usr/lib/libxml2.so.2.7.8
f6c8b000 f6c8d000 r-xp /usr/lib/libiniparser.so.0
f6c96000 f6c9c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ca5000 f6d75000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d76000 f6daa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6db3000 f6def000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6df7000 f6dfa000 r-xp /usr/lib/libbundle.so.0.1.22
f6e02000 f6e08000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e10000 f6e51000 r-xp /usr/lib/libeina.so.1.7.99
f6e5a000 f6e71000 r-xp /usr/lib/libecore.so.1.7.99
f6e88000 f6e91000 r-xp /usr/lib/libvconf.so.0.2.45
f6e99000 f6ead000 r-xp /lib/libpthread-2.13.so
f6eb8000 f6ec5000 r-xp /usr/lib/libaul.so.0.1.0
f6ecf000 f6ed1000 r-xp /lib/libdl-2.13.so
f6eda000 f6ee5000 r-xp /lib/libunwind.so.8.0.1
f6f12000 f6f1a000 r-xp /lib/libgcc_s-4.6.so.1
f6f1b000 f703f000 r-xp /lib/libc-2.13.so
f704d000 f704f000 r-xp /usr/lib/libdlog.so.0.0.0
f7057000 f7063000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f706c000 f7071000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7079000 f7088000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7090000 f7094000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f709d000 f70a0000 r-xp /usr/lib/libappcore-agent.so.1.1
f70a8000 f70aa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70b2000 f70b6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70be000 f70db000 r-xp /lib/ld-2.13.so
f70e4000 f70e7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70e7000 f70eb000 r-xp /usr/lib/libsys-assert.so
f76f8000 f7796000 rw-p [heap]
ff981000 ff9a2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:32743)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf70e527a) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x127a
 1: (0xf707c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d833f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dc875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6dc31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6dc5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dc6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dcdf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47651fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4758171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf682b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cd8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cda7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e6aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e65b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e665a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e66879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf709e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf709e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70e568b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x168b
28: __libc_start_main + 0x114 (0xf6f3285c) [/lib/libc.so.6] + 0x1785c
29: (0xf70e4f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
id. Err[-1]
04-23 17:58:44.681+0200 I/LOCATION(32679): location.c: location_new(269) > method: 1
04-23 17:58:44.681+0200 W/LOCATION(32679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:58:44.681+0200 W/LOCATION(32679): module-internal.c: module_new(311) > module (gps) open success
04-23 17:58:44.681+0200 W/LOCATION(32679): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:58:44.681+0200 W/LOCATION(32679): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:58:44.681+0200 W/LOCATION(32679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:58:44.681+0200 W/LOCATION(32679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:58:44.681+0200 W/LOCATION(32679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:58:44.691+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:44.701+0200 I/AUL     (32679): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:58:44.701+0200 E/LOCATION(32679): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:58:44.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:44.731+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:44.731+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:44.741+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:44:738,42.000000,0.980000,-19.950001
04-23 17:58:44.741+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:44:740,9.729217,0.031107,1.292124
04-23 17:58:44.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:58:44.751+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(13020413), time2(13010205)
04-23 17:58:44.751+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:58:44.751+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:58:44.751+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:58:44.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:58:44.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:44.781+0200 W/LOCATION(32743): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:58:44.781+0200 I/LOCATION(32743): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:58:44.781+0200 I/LOCATION(32743): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:58:44.781+0200 I/location(32743): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:58:44.781+0200 W/CAPI_APPFW_APP_CONTROL(32743): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:58:44.781+0200 I/utils   (32743): specific action
04-23 17:58:44.861+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:44.861+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:44.931+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:44.931+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:44.941+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:44:939,19.530001,0.210000,2.590000
04-23 17:58:44.941+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:44:939,9.671788,0.921237,1.179662
04-23 17:58:45.051+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:58:45.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:58:45.051+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:58:45.061+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:45.061+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:45.071+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.071+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.081+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:79,17.080000,-1.050000,5.880000
04-23 17:58:45.081+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:79,9.903893,-0.105284,0.909273
04-23 17:58:45.091+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.091+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.101+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:102,28.630001,1.400000,4.060000
04-23 17:58:45.101+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:102,9.915856,-0.057428,0.906880
04-23 17:58:45.111+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.121+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.121+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:121,9.717253,0.057428,0.993021
04-23 17:58:45.131+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:125,31.430000,1.750000,2.240000
04-23 17:58:45.131+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.131+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.141+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:139,25.830000,0.350000,2.170000
04-23 17:58:45.141+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:139,9.767502,0.189033,1.086342
04-23 17:58:45.151+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.151+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.161+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:160,9.875179,0.169890,1.155733
04-23 17:58:45.161+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:161,16.660000,-0.840000,1.890000
04-23 17:58:45.171+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.171+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.181+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:179,15.050000,-0.070000,2.520000
04-23 17:58:45.181+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:179,9.810574,0.119641,0.830309
04-23 17:58:45.191+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.191+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.201+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:202,21.629999,-0.070000,1.750000
04-23 17:58:45.201+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:202,9.872787,-0.160319,0.832702
04-23 17:58:45.211+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.211+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.221+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:222,25.340000,0.910000,2.380000
04-23 17:58:45.221+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:222,9.868000,-0.035892,0.777667
04-23 17:58:45.231+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.231+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.241+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:240,17.010000,2.940000,3.710000
04-23 17:58:45.241+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:240,9.695717,0.153141,0.734596
04-23 17:58:45.251+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.251+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.261+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:262,9.801002,0.129212,0.830309
04-23 17:58:45.261+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:45.261+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:45.261+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:262,9.100000,0.350000,5.950000
04-23 17:58:45.271+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.271+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.281+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:279,9.942179,-0.035892,0.803988
04-23 17:58:45.281+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:279,-2.660000,1.470000,6.300000
04-23 17:58:45.291+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.291+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.301+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:302,9.839286,-0.533599,0.863809
04-23 17:58:45.301+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:302,-2.450000,4.970000,3.570000
04-23 17:58:45.311+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.311+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.321+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:322,9.841680,-0.196211,1.091127
04-23 17:58:45.321+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:322,9.730000,5.810000,1.190000
04-23 17:58:45.331+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.331+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.341+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:341,9.717253,0.040678,1.196411
04-23 17:58:45.341+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:341,1.890000,6.020000,-1.960000
04-23 17:58:45.351+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.351+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.361+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:360,9.616754,-0.052642,1.208375
04-23 17:58:45.361+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:360,-4.340000,3.640000,-2.240000
04-23 17:58:45.371+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.371+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.381+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:380,9.767502,-0.177069,1.237089
04-23 17:58:45.381+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:380,6.580000,0.420000,-3.640000
04-23 17:58:45.391+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.391+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.401+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:401,9.865608,0.119641,1.050449
04-23 17:58:45.401+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:401,17.500000,1.610000,-3.780000
04-23 17:58:45.411+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.411+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.421+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:422,10.021141,0.210568,0.854238
04-23 17:58:45.421+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:422,18.620001,3.640000,-3.080000
04-23 17:58:45.431+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.431+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.441+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:441,9.789038,0.098106,0.993021
04-23 17:58:45.441+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:441,21.629999,8.890000,-4.690000
04-23 17:58:45.451+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.451+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.461+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:45.461+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:459,9.734003,0.325424,1.222732
04-23 17:58:45.461+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:45.461+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:460,26.530001,6.720000,-3.710000
04-23 17:58:45.471+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.471+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.481+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:482,9.686146,0.258425,1.335195
04-23 17:58:45.481+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:482,31.430000,6.860000,-3.290000
04-23 17:58:45.491+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.491+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.501+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:500,9.561719,0.205783,0.923629
04-23 17:58:45.501+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:500,47.810001,5.110000,-2.660000
04-23 17:58:45.511+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.511+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.521+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:523,10.088140,0.320638,0.815953
04-23 17:58:45.521+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:523,62.510002,2.940000,-4.830000
04-23 17:58:45.531+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.531+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.541+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:542,10.114462,1.012164,0.839881
04-23 17:58:45.541+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:542,51.799999,9.940000,-6.230000
04-23 17:58:45.551+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.551+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.561+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:560,9.494720,1.117448,0.856631
04-23 17:58:45.591+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.601+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:597,9.410972,0.433101,1.208375
04-23 17:58:45.601+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.621+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:560,20.020000,14.630000,-1.540000
04-23 17:58:45.621+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.631+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:614,9.822537,-0.133998,1.641476
04-23 17:58:45.631+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.631+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:633,-5.180000,5.530000,4.760000
04-23 17:58:45.641+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.641+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:645,11.900000,1.960000,5.600000
04-23 17:58:45.641+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.651+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:637,9.848858,-0.342174,1.691726
04-23 17:58:45.651+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.661+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:45.661+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:45.661+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:661,9.638289,-0.179462,1.674976
04-23 17:58:45.661+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.691+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:651,39.830002,5.810000,1.960000
04-23 17:58:45.691+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.691+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:672,9.745967,0.540778,1.205983
04-23 17:58:45.701+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:697,62.369999,6.090000,-1.190000
04-23 17:58:45.701+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.701+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.711+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:714,9.741181,0.911665,1.021735
04-23 17:58:45.711+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.721+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:721,9.542577,0.265603,1.631905
04-23 17:58:45.721+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.721+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:727,9.628718,-0.294317,1.703690
04-23 17:58:45.731+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:708,60.480000,5.600000,-3.290000
04-23 17:58:45.731+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.731+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.741+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:740,9.889536,-0.354138,1.646262
04-23 17:58:45.741+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:736,30.590000,7.000000,-1.330000
04-23 17:58:45.741+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.751+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:750,2.800000,4.690000,2.030000
04-23 17:58:45.751+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.751+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.751+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:759,9.963714,0.174676,1.435694
04-23 17:58:45.761+0200 E/CAPI_TELEPHONY(32679): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:58:45.761+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:756,2.800000,-3.500000,0.700000
04-23 17:58:45.761+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.771+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:773,33.040001,-4.480000,-4.060000
04-23 17:58:45.771+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.771+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.771+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:779,56.349998,0.770000,-9.450000
04-23 17:58:45.781+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.781+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:780,9.442079,0.236889,1.222732
04-23 17:58:45.781+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:785,53.830002,4.340000,-7.210000
04-23 17:58:45.791+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.791+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.791+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:799,9.616754,0.337388,1.234696
04-23 17:58:45.791+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:799,47.459999,-2.030000,-4.410000
04-23 17:58:45.811+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.811+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.821+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:821,9.762716,0.693919,1.371087
04-23 17:58:45.821+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:821,42.700001,-1.820000,-3.640000
04-23 17:58:45.831+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.831+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.831+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:840,33.180000,-2.170000,-2.520000
04-23 17:58:45.831+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:839,9.667004,0.483350,1.433301
04-23 17:58:45.851+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.851+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.861+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:45.861+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:45.861+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:860,9.786645,0.378066,1.423729
04-23 17:58:45.861+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:861,40.670002,-4.900000,-4.620000
04-23 17:58:45.871+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.871+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.881+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:882,61.320000,-2.450000,-6.230000
04-23 17:58:45.881+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:882,9.726824,0.437887,1.481157
04-23 17:58:45.891+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.891+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.901+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:902,90.650002,-4.830000,-7.980000
04-23 17:58:45.901+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:902,9.602397,0.200997,1.447658
04-23 17:58:45.911+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.911+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.921+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:921,9.686146,0.172283,1.048056
04-23 17:58:45.921+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:921,125.160004,-6.720000,-10.640000
04-23 17:58:45.931+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.931+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.941+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:941,9.765109,0.191426,0.768096
04-23 17:58:45.941+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:941,162.960007,-6.510000,-12.320000
04-23 17:58:45.951+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.951+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.961+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:960,9.705289,0.153141,0.641276
04-23 17:58:45.961+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:960,203.139999,-6.020000,-14.910000
04-23 17:58:45.971+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:45.971+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.981+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:45:983,229.740005,-3.990000,-18.270000
04-23 17:58:45.981+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:45:983,9.772287,0.698704,0.574277
04-23 17:58:45.991+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:45.991+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.001+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:1,9.681360,1.069592,0.308674
04-23 17:58:46.011+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:1,234.430008,-1.610000,-20.440001
04-23 17:58:46.011+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.011+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.021+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:20,220.500000,0.420000,-21.910000
04-23 17:58:46.021+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:21,9.695717,1.268196,-0.021535
04-23 17:58:46.031+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.041+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.051+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:41,9.820145,1.797010,-0.007178
04-23 17:58:46.051+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.061+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:46,192.570007,2.100000,-20.860001
04-23 17:58:46.061+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:46.061+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:46.061+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.071+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:60,9.698111,2.108077,0.069392
04-23 17:58:46.131+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.151+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 129 ms (from 13021689 to 13021818) (logOverhead=0,0,0,0,0,0,0), start: 17:58:46.034
04-23 17:58:46.151+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 129 ms (from 13021689 to 13021818) (logOverhead=0,0,0,0,0,0,0), start: 17:58:46.034
04-23 17:58:46.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:58:46.161+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:58:46.161+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:58:46.161+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:135,9.645468,1.993221,0.234497
04-23 17:58:46.161+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.171+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:173,9.743573,1.899901,0.392423
04-23 17:58:46.171+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.181+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:179,9.678967,2.170290,0.366102
04-23 17:58:46.181+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.181+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:187,9.559326,2.321038,0.354138
04-23 17:58:46.181+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.191+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:192,9.621540,2.311467,0.370888
04-23 17:58:46.191+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.191+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:197,9.834501,2.249253,0.232104
04-23 17:58:46.191+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.201+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:203,9.592826,2.048256,0.131605
04-23 17:58:46.201+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:69,157.570007,4.270000,-19.670000
04-23 17:58:46.201+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.201+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:209,126.209999,0.980000,-16.520000
04-23 17:58:46.201+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.211+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:214,96.599998,-0.140000,-15.960000
04-23 17:58:46.211+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.211+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.211+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:219,67.199997,-0.140000,-11.480000
04-23 17:58:46.211+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.221+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:220,9.604790,1.813759,0.083749
04-23 17:58:46.221+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:224,37.310001,-0.840000,-5.670000
04-23 17:58:46.221+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.221+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:229,23.730000,-3.990000,-2.450000
04-23 17:58:46.221+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.231+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:234,16.870001,-2.870000,-2.100000
04-23 17:58:46.231+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.231+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.231+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:239,10.360000,-1.330000,-0.420000
04-23 17:58:46.231+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.231+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:240,9.769895,1.708475,0.291924
04-23 17:58:46.241+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:244,5.810000,-2.800000,0.280000
04-23 17:58:46.241+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.241+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:249,7.560000,-1.190000,1.540000
04-23 17:58:46.251+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.251+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.251+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:259,9.655040,1.701297,0.083749
04-23 17:58:46.251+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:259,12.600000,-1.330000,0.700000
04-23 17:58:46.261+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:46.261+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:46.271+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.271+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.281+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:282,15.610000,-1.890000,0.280000
04-23 17:58:46.281+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:282,9.671788,1.622334,0.210568
04-23 17:58:46.291+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.291+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.301+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:302,13.230000,-1.960000,-0.560000
04-23 17:58:46.301+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:302,9.633504,1.591227,0.093320
04-23 17:58:46.311+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.311+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.321+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:322,9.745967,1.701297,-0.064606
04-23 17:58:46.321+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:321,9.170000,-2.100000,-1.330000
04-23 17:58:46.331+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.331+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.341+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:340,6.020000,-2.240000,-1.540000
04-23 17:58:46.341+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:340,9.805787,1.615155,-0.011964
04-23 17:58:46.351+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.351+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.361+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:361,9.717253,1.500300,-0.064606
04-23 17:58:46.361+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:360,4.900000,-1.680000,-2.240000
04-23 17:58:46.371+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.371+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.381+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:383,9.753145,1.603191,0.007178
04-23 17:58:46.381+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:383,6.090000,-0.980000,-3.220000
04-23 17:58:46.391+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.391+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.401+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:400,7.490000,-0.280000,-3.990000
04-23 17:58:46.401+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:401,9.714860,1.634298,0.157926
04-23 17:58:46.411+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.411+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.421+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:421,9.604790,1.471586,0.224925
04-23 17:58:46.421+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:421,9.450000,-1.400000,-4.480000
04-23 17:58:46.431+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.431+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.441+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:440,9.683753,1.672583,0.138784
04-23 17:58:46.441+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:440,12.740000,-1.470000,-4.410000
04-23 17:58:46.451+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.451+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.461+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:46.461+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:46.461+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:461,9.650253,1.725225,0.088534
04-23 17:58:46.461+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:461,12.810000,-2.100000,-4.690000
04-23 17:58:46.471+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.481+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:483,9.755538,1.976472,-0.014357
04-23 17:58:46.481+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.501+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.501+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:482,7.210000,-1.750000,-5.180000
04-23 17:58:46.511+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:507,9.523434,2.112862,0.095713
04-23 17:58:46.511+0200 W/LOCATION(32743): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:58:46.511+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.511+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.521+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:518,-2.800000,-2.660000,-2.800000
04-23 17:58:46.531+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:523,9.784252,1.641476,0.212961
04-23 17:58:46.531+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.531+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.541+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:535,0.210000,-7.280000,-4.550000
04-23 17:58:46.541+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.551+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:541,9.722038,1.694118,0.189033
04-23 17:58:46.551+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.561+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:561,9.690931,1.895115,0.021535
04-23 17:58:46.561+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:551,9.030000,-4.970000,-5.250000
04-23 17:58:46.571+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.571+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.581+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:582,9.671788,1.866402,-0.160319
04-23 17:58:46.581+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:575,10.500000,-5.600000,-2.870000
04-23 17:58:46.581+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.591+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.601+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:600,9.633504,1.940579,-0.066999
04-23 17:58:46.601+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:593,8.680000,-4.760000,-2.450000
04-23 17:58:46.601+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.601+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:608,2.520000,-5.250000,-1.540000
04-23 17:58:46.611+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.611+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.621+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:621,9.578469,2.120041,-0.098106
04-23 17:58:46.631+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:621,-5.740000,-5.180000,-0.280000
04-23 17:58:46.631+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.631+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.641+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:640,9.647861,1.758725,-0.275175
04-23 17:58:46.641+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:640,-13.930000,-7.070000,0.070000
04-23 17:58:46.651+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.651+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.651+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:660,-13.790000,-6.020000,0.140000
04-23 17:58:46.661+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:660,9.729217,1.844866,-0.382852
04-23 17:58:46.661+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:46.661+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:46.671+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.671+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.681+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:681,-13.020000,-5.460000,-0.630000
04-23 17:58:46.681+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:681,9.611969,1.770689,-0.205783
04-23 17:58:46.691+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.691+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.691+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:700,-25.480000,-4.270000,-0.420000
04-23 17:58:46.691+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:700,9.607183,2.124826,-0.193819
04-23 17:58:46.711+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.711+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.721+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:721,-48.720001,-6.790000,2.940000
04-23 17:58:46.721+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:721,9.590433,2.163112,-0.112463
04-23 17:58:46.731+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.731+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.741+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:739,-57.750000,-8.610000,2.730000
04-23 17:58:46.751+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:743,9.549755,1.923829,-0.136391
04-23 17:58:46.751+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.761+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:762,-45.779999,-6.790000,2.800000
04-23 17:58:46.761+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.761+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:771,9.700503,1.392623,-0.150748
04-23 17:58:46.771+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:58:46.781+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:58:46.781+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:58:46.781+0200 E/CAPI_LOCATION_MANAGER(32679): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:58:46.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:58:46.781+0200 W/AUL     (32754): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:58:46.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:58:46.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:58:46.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32102
04-23 17:58:46.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:58:46.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:58:46.791+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:782,-30.590000,-1.400000,1.330000
04-23 17:58:46.791+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.791+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:800,-37.869999,1.820000,1.330000
04-23 17:58:46.801+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32102
04-23 17:58:46.801+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32102)
04-23 17:58:46.801+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.811+0200 I/accelerometer(32704): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:58:46:809,9.710074,1.418944,-0.157926
04-23 17:58:46.861+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:58:46.861+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:58:46.871+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:58:46.871+0200 I/CAPI_NETWORK_CONNECTION(32679): connection.c: connection_destroy(471) > Destroy handle: 0xf4122cd0
04-23 17:58:46.871+0200 I/heartrate(32724): capturing data from es.ugr.frailty.heartrate
04-23 17:58:46.871+0200 I/heartrate(32724): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:58:46.871+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.871+0200 I/accelerometer(32704): capturing data from es.ugr.frailty.accelerometer
04-23 17:58:46.881+0200 I/gyroscope(32717): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:58:46:884,-72.099998,1.470000,3.220000
04-23 17:58:46.891+0200 I/gyroscope(32717): capturing data from es.ugr.frailty.gyroscope
04-23 17:58:46.891+0200 W/CRASH_MANAGER(32756): worker.c: worker_job(1205) > 11327436c6f63152449912
