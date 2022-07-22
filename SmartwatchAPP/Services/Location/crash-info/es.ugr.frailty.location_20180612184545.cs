S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19416
Date: 2018-06-12 18:45:45+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf748852d, r5   = 0xf76c4150
r6   = 0xff8ada20, r7   = 0xff8ad8d0
r8   = 0xf76d6c18, r9   = 0x00000000
r10  = 0xff8ad9ac, fp   = 0xff8ada20
ip   = 0x00000001, sp   = 0xff8ad8a8
lr   = 0xf7488539, pc   = 0xf74f1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    125832 KB
Buffers:     46392 KB
Cached:     169060 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11684 KB
VmRSS:       11684 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19416 TID = 19416
19416 19426 

Maps Information
f4353000 f4b52000 rw-p [stack:19426]
f4b59000 f4b5b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b63000 f4b67000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b70000 f4b72000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b7a000 f4b7d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b8c000 f4b91000 r-xp /usr/lib/libsystem.so.0.0.0
f4b9c000 f4b9f000 r-xp /lib/libattr.so.1.1.0
f4ba7000 f4bb7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bbf000 f4bc8000 r-xp /usr/lib/libedbus.so.1.7.99
f4bd0000 f4bd1000 r-xp /usr/lib/libresponse.so.0.2.96
f4bda000 f4bdf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6481000 f6587000 r-xp /usr/lib/libicuuc.so.57.1
f659d000 f6725000 r-xp /usr/lib/libicui18n.so.57.1
f6735000 f6742000 r-xp /usr/lib/libail.so.0.1.0
f674b000 f6752000 r-xp /usr/lib/libminizip.so.1.0.0
f675b000 f6904000 r-xp /usr/lib/libcrypto.so.1.0.0
f6924000 f696b000 r-xp /usr/lib/libssl.so.1.0.0
f6977000 f6979000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6981000 f6988000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6991000 f6998000 r-xp /lib/libcrypt-2.13.so
f69c9000 f69cc000 r-xp /lib/libcap.so.2.21
f69d4000 f69d6000 r-xp /usr/lib/libiri.so
f69de000 f6a27000 r-xp /usr/lib/libmdm.so.1.2.69
f6a2f000 f6a35000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a3d000 f6a60000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a6a000 f6a6c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a74000 f6a91000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a9a000 f6a9e000 r-xp /usr/lib/libsmack.so.1.0.0
f6aa7000 f6ac0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ac9000 f6ad1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ad9000 f6adf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ae8000 f6aea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6af3000 f6b03000 r-xp /lib/libresolv-2.13.so
f6b07000 f6b1f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b28000 f6b2a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b32000 f6b4c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b54000 f6b83000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b8c000 f6b9b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ba5000 f6baf000 r-xp /usr/lib/libsensord-shared.so
f6bb8000 f6c8b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c96000 f6cac000 r-xp /lib/libz.so.1.2.5
f6cb4000 f6cb9000 r-xp /usr/lib/libffi.so.5.0.10
f6cc1000 f6cc2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cca000 f6cda000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ce2000 f6cfb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d03000 f6d05000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d0d000 f6d82000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d8c000 f6d92000 r-xp /lib/librt-2.13.so
f6d9b000 f6db9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dc3000 f6dc4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dcc000 f6def000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6df7000 f6dfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e04000 f6e2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e37000 f6e4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e56000 f6ebf000 r-xp /lib/libm-2.13.so
f6ec8000 f6f5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f6f000 f6f74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f7c000 f6f83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f8b000 f6fb5000 r-xp /usr/lib/libsensor.so.1.9.6
f6fbe000 f708a000 r-xp /usr/lib/libxml2.so.2.7.8
f7097000 f7099000 r-xp /usr/lib/libiniparser.so.0
f70a2000 f70a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70b1000 f7181000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7182000 f71b6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71bf000 f71fb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7203000 f7206000 r-xp /usr/lib/libbundle.so.0.1.22
f720e000 f7214000 r-xp /usr/lib/libappsvc.so.0.1.0
f721c000 f725d000 r-xp /usr/lib/libeina.so.1.7.99
f7266000 f727d000 r-xp /usr/lib/libecore.so.1.7.99
f7294000 f729d000 r-xp /usr/lib/libvconf.so.0.2.45
f72a5000 f72b9000 r-xp /lib/libpthread-2.13.so
f72c4000 f72d1000 r-xp /usr/lib/libaul.so.0.1.0
f72db000 f72dd000 r-xp /lib/libdl-2.13.so
f72e6000 f72f1000 r-xp /lib/libunwind.so.8.0.1
f731e000 f7326000 r-xp /lib/libgcc_s-4.6.so.1
f7327000 f744b000 r-xp /lib/libc-2.13.so
f7459000 f745b000 r-xp /usr/lib/libdlog.so.0.0.0
f7463000 f746f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7478000 f747d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7485000 f7494000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f749c000 f74a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74a9000 f74ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f74b4000 f74b6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74be000 f74c2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74ca000 f74e7000 r-xp /lib/ld-2.13.so
f74f0000 f74f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74f3000 f74f7000 r-xp /usr/lib/libsys-assert.so
f76a6000 f7717000 rw-p [heap]
ff88f000 ff8b0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19416)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74f1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7488539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf718f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf718dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7199e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf719fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf719fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71d475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71cf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf718dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7199e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf719fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf719fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71d1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71d2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71d9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b711fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b64171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c37663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70e4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70e67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7276ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7271b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72725a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7272879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74aa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74aa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74f15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf733e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74f0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
waiting for rigth values
06-12 18:45:42.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19431
06-12 18:45:42.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(19431) type(svcapp) bg(0)
06-12 18:45:42.871+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19431]
06-12 18:45:42.911+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19431)
06-12 18:45:42.911+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.gravity
06-12 18:45:42.911+0200 I/servicemanager(19372): es.ugr.frailty.pressure alive timeout
06-12 18:45:42.911+0200 I/servicemanager(19372): launch service es.ugr.frailty.pressure
06-12 18:45:42.911+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-12 18:45:42.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:42.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19379
06-12 18:45:42.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:42.961+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19431) was created
06-12 18:45:42.981+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:42.991+0200 I/accelerometer(19379): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:42.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:42.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:42.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:43.001+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 20066439 to 20066740) (logOverhead=0,0,0,0,0,0,0), start: 18:45:42.705
06-12 18:45:43.001+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): marshal_gps_start took 305 ms (from 20066437 to 20066742) (logOverhead=0,0,0,0,0,0,0), start: 18:45:42.703
06-12 18:45:43.001+0200 W/gpsd    ( 3103): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 20066437 to 20066742) (logOverhead=0,0,0,0,0,0,0), start: 18:45:42.703
06-12 18:45:43.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19403
06-12 18:45:43.011+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer - capturing data
06-12 18:45:43.021+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:45:43:28,9.650253,-1.481157,1.045663
06-12 18:45:43.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19417
06-12 18:45:43.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:43.081+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:43.081+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:43.081+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:43.091+0200 I/linearacceleration(19417): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:43.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19384
06-12 18:45:43.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:43.151+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 18:45:43.171+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:43.171+0200 I/gyroscope(19384): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:43.171+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope - capturing data
06-12 18:45:43.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:43.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:43.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:43.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19403
06-12 18:45:43.241+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: connection_create(453) > New handle created[0xf7a58c18]
06-12 18:45:43.241+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
06-12 18:45:43.241+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
06-12 18:45:43.241+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
06-12 18:45:43.241+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: connection_get_type(507) > Connected Network = 2
06-12 18:45:43.251+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-12 18:45:43.251+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(20066990), time2(16973250)
06-12 18:45:43.251+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-12 18:45:43.251+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-12 18:45:43.251+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-12 18:45:43.251+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:25
06-12 18:45:43.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19372
06-12 18:45:43.261+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19443
06-12 18:45:43.261+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration - capturing data
06-12 18:45:43.271+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:45:43:272,0.069623,0.026441,-0.041829
06-12 18:45:43.271+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.281+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 18:45:43.291+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.301+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.301+0200 E/LOCATION(19436): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
06-12 18:45:43.301+0200 E/PKGMGR_INFO(19436): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-12 18:45:43.301+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:43.311+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:43.311+0200 W/LOCATION(19436): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 18:45:43.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19443
06-12 18:45:43.311+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(19443) type(svcapp) bg(0)
06-12 18:45:43.311+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19443]
06-12 18:45:43.321+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.331+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.331+0200 E/LOCATION(19436): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
06-12 18:45:43.331+0200 I/LOCATION(19436): location.c: location_new(269) > method: 1
06-12 18:45:43.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:43.371+0200 W/LOCATION(19436): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 18:45:43.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:43.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:43.401+0200 W/LOCATION(19436): module-internal.c: module_new(311) > module (gps) open success
06-12 18:45:43.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:43.401+0200 W/LOCATION(19436): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 18:45:43.421+0200 W/LOCATION(19436): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 18:45:43.421+0200 W/LOCATION(19436): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 18:45:43.421+0200 W/LOCATION(19436): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 18:45:43.421+0200 W/LOCATION(19436): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 18:45:43.431+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19417
06-12 18:45:43.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:43.461+0200 I/AUL     (19436): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 18:45:43.461+0200 E/LOCATION(19436): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 18:45:43.461+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 18:45:43.461+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 18:45:43.501+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19443)
06-12 18:45:43.501+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.pressure
06-12 18:45:43.511+0200 I/servicemanager(19372): es.ugr.frailty.light alive timeout
06-12 18:45:43.521+0200 I/servicemanager(19372): launch service es.ugr.frailty.light
06-12 18:45:43.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:43.521+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:43.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19416
06-12 18:45:43.541+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 18:45:43.541+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:43.541+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:43.541+0200 I/linearacceleration(19417): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:43.541+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration - capturing data
06-12 18:45:43.551+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 18:45:43.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:43.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:43.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:43.611+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:45:43:269,-0.070000,-0.140000,-0.210000
06-12 18:45:43.611+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.611+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.611+0200 I/utils   (19431): es.ugr.frailty.gravity listener started
06-12 18:45:43.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19372
06-12 18:45:43.641+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19450
06-12 18:45:43.641+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 18:45:43.651+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:45:43:554,0.050480,-0.033380,-0.092079
06-12 18:45:43.651+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.681+0200 E/CAPI_APPFW_APPLICATION(19450): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:43.681+0200 E/CAPI_APPFW_APPLICATION(19450): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:43.691+0200 I/utils   (19450): trying to start service: es.ugr.frailty.light
06-12 18:45:43.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19450
06-12 18:45:43.691+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(19450) type(svcapp) bg(0)
06-12 18:45:43.691+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:43.691+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:43.711+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19450]
06-12 18:45:43.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:43.741+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19417
06-12 18:45:43.741+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19450)
06-12 18:45:43.741+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.light
06-12 18:45:43.741+0200 I/servicemanager(19372): es.ugr.frailty.pedometer alive timeout
06-12 18:45:43.741+0200 I/servicemanager(19372): launch service es.ugr.frailty.pedometer
06-12 18:45:43.741+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 18:45:43.741+0200 I/gravity (19431): es.ugr.frailty.gravity - capturing data
06-12 18:45:43.741+0200 I/gravity (19431): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:45:43:752,9.639827,-1.476126,1.032075
06-12 18:45:43.751+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.751+0200 I/utils   (19450): es.ugr.frailty.light sensor supported
06-12 18:45:43.791+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 18:45:43.791+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 18:45:43.791+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 18:45:43.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:43.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:43.791+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19450) was created
06-12 18:45:43.801+0200 I/utils   (19450): es.ugr.frailty.light listener started
06-12 18:45:43.801+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 18:45:43.801+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 18:45:43.801+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 18:45:43.801+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 18:45:43.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19379
06-12 18:45:43.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:43.871+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:43.871+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:43.881+0200 W/LOCATION(19416): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 18:45:43.881+0200 I/LOCATION(19416): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 18:45:43.881+0200 I/LOCATION(19416): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 18:45:43.881+0200 I/location(19416): es.ugr.frailty.location:iniciado servicio de localización
06-12 18:45:43.881+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:43.881+0200 I/accelerometer(19379): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:43.881+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer - capturing data
06-12 18:45:43.881+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:45:43:888,9.635897,-1.440479,0.983450
06-12 18:45:43.881+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.891+0200 I/light   (19450): es.ugr.frailty.light - capturing data
06-12 18:45:43.901+0200 I/light   (19450): es.ugr.frailty.light: SM-R760,12/06/2018,18:45:43:904,84.000000
06-12 18:45:43.901+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:43.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19384
06-12 18:45:43.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:43.971+0200 E/CAPI_APPFW_APPLICATION(19443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:43.971+0200 E/CAPI_APPFW_APPLICATION(19443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:43.971+0200 I/utils   (19443): trying to start service: es.ugr.frailty.pressure
06-12 18:45:43.981+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:43.981+0200 I/gyroscope(19384): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:43.981+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope - capturing data
06-12 18:45:43.981+0200 I/utils   (19443): es.ugr.frailty.pressure sensor supported
06-12 18:45:43.981+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:45:43:988,-0.070000,-0.350000,-0.210000
06-12 18:45:43.981+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:43.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:43.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:44.001+0200 I/utils   (19443): es.ugr.frailty.pressure listener started
06-12 18:45:44.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:44.021+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19416
06-12 18:45:44.031+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19443) was created
06-12 18:45:44.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19417
06-12 18:45:44.071+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:44.071+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:44.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.121+0200 I/LOCATION(19416): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 18:45:44.151+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.151+0200 I/linearacceleration(19417): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.151+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration - capturing data
06-12 18:45:44.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:44.181+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:45:44:156,0.084623,0.020812,-0.017954
06-12 18:45:44.181+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:44.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:44.191+0200 I/location(19416): es.ugr.frailty.location: waiting for rigth values
06-12 18:45:44.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19372
06-12 18:45:44.211+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 18:45:44.221+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19475
06-12 18:45:44.261+0200 E/CAPI_APPFW_APPLICATION(19475): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:44.261+0200 E/CAPI_APPFW_APPLICATION(19475): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 18:45:44.261+0200 I/utils   (19475): trying to start service: es.ugr.frailty.pedometer
06-12 18:45:44.261+0200 I/utils   (19475): es.ugr.frailty.pedometer sensor supported
06-12 18:45:44.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19475
06-12 18:45:44.271+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(19475) type(svcapp) bg(0)
06-12 18:45:44.271+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19475]
06-12 18:45:44.271+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:44.271+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19475)
06-12 18:45:44.271+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:44.271+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.pedometer
06-12 18:45:44.281+0200 W/CAPI_APPFW_APP_CONTROL(19372): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:44.281+0200 I/utils   (19372): specific action
06-12 18:45:44.281+0200 I/servicemanager(19372): requesting to save local data for es.ugr.frailty.accelerometer
06-12 18:45:44.281+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 18:45:44.281+0200 I/utils   (19475): es.ugr.frailty.pedometer listener started
06-12 18:45:44.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19431
06-12 18:45:44.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 18:45:44.381+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19372), cmd(0)
06-12 18:45:44.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:44.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:44.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19475) was created
06-12 18:45:44.441+0200 I/gravity (19431): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19379
06-12 18:45:44.441+0200 I/gravity (19431): es.ugr.frailty.gravity - capturing data
06-12 18:45:44.451+0200 I/gravity (19431): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:45:44:452,9.644495,-1.456445,1.016303
06-12 18:45:44.451+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.511+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.511+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:44.511+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:44.511+0200 I/accelerometer(19379): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.511+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer - capturing data
06-12 18:45:44.521+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:45:44:524,9.745967,-1.440479,1.000200
06-12 18:45:44.521+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19450
06-12 18:45:44.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.591+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:44.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:44.591+0200 I/light   (19450): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.601+0200 I/light   (19450): es.ugr.frailty.light - capturing data
06-12 18:45:44.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:44.651+0200 E/CAPI_TELEPHONY(19436): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 18:45:44.671+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:44.671+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:44.671+0200 I/light   (19450): es.ugr.frailty.light: SM-R760,12/06/2018,18:45:44:607,86.000000
06-12 18:45:44.681+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19384
06-12 18:45:44.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.701+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 18:45:44.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 18:45:44.701+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 18:45:44.721+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.721+0200 I/gyroscope(19384): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.721+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope - capturing data
06-12 18:45:44.741+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:45:44:735,-0.070000,0.350000,-0.280000
06-12 18:45:44.741+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:44.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19431
06-12 18:45:44.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 18:45:44.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 18:45:44.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 18:45:44.791+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 18:45:44.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:44.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:44.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19417
06-12 18:45:44.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:44.851+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:44.851+0200 I/linearacceleration(19417): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:44.851+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration - capturing data
06-12 18:45:44.851+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:45:44:861,0.087016,-0.000723,0.010760
06-12 18:45:44.851+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:44.881+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:44.881+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:44.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:44.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19372
06-12 18:45:44.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19375
06-12 18:45:44.901+0200 W/CAPI_APPFW_APP_CONTROL(19375): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:44.901+0200 I/utils   (19375): specific action
06-12 18:45:44.901+0200 W/CAPI_APPFW_APP_CONTROL(19375): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:44.911+0200 I/recorder(19375): saving local data for es.ugr.frailty.accelerometer
06-12 18:45:44.941+0200 I/recorder(19375): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 18:45:44.951+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19375)
06-12 18:45:44.951+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.recorder
06-12 18:45:44.951+0200 I/servicemanager(19372): requesting to save local data
06-12 18:45:44.951+0200 W/CAPI_APPFW_APP_CONTROL(19372): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:44.951+0200 I/utils   (19372): specific action
06-12 18:45:44.951+0200 W/CAPI_APPFW_APP_CONTROL(19372): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:44.951+0200 I/servicemanager(19372): requesting to save local data for es.ugr.frailty.gyroscope
06-12 18:45:44.951+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 18:45:45.011+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:45.011+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:45.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19431
06-12 18:45:45.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.051+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.051+0200 I/gravity (19431): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.051+0200 I/gravity (19431): es.ugr.frailty.gravity - capturing data
06-12 18:45:45.051+0200 I/gravity (19431): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:45:45:61,9.644127,-1.458286,1.017152
06-12 18:45:45.051+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.061+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 18:45:45.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19372), cmd(0)
06-12 18:45:45.071+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:45.071+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:45.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 18:45:45.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(39) , send fd(21), pid(19375), cmd(0)
06-12 18:45:45.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19379
06-12 18:45:45.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.171+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.181+0200 I/accelerometer(19379): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.181+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer - capturing data
06-12 18:45:45.181+0200 I/accelerometer(19379): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,18:45:45:187,9.705289,-1.457229,1.012164
06-12 18:45:45.181+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:45.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:45.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19450
06-12 18:45:45.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.251+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.251+0200 I/light   (19450): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.251+0200 I/light   (19450): es.ugr.frailty.light - capturing data
06-12 18:45:45.261+0200 I/light   (19450): es.ugr.frailty.light: SM-R760,12/06/2018,18:45:45:256,89.000000
06-12 18:45:45.261+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.271+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:45.271+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:45.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 18:45:45.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19417
06-12 18:45:45.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19384
06-12 18:45:45.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.371+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.371+0200 I/gyroscope(19384): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.371+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope - capturing data
06-12 18:45:45.381+0200 I/gyroscope(19384): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,18:45:45:385,-0.140000,-0.420000,-0.070000
06-12 18:45:45.381+0200 W/AUL     (19384): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:45.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:45.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 18:45:45.441+0200 W/LOCATION(19416): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 18:45:45.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19417
06-12 18:45:45.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.471+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:45.471+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:45.521+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.531+0200 I/linearacceleration(19417): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.531+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration - capturing data
06-12 18:45:45.531+0200 I/linearacceleration(19417): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,18:45:45:537,0.053814,-0.041092,-0.006920
06-12 18:45:45.531+0200 W/AUL     (19417): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19372
06-12 18:45:45.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19375
06-12 18:45:45.581+0200 W/CAPI_APPFW_APP_CONTROL(19375): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:45.591+0200 I/utils   (19375): specific action
06-12 18:45:45.591+0200 W/CAPI_APPFW_APP_CONTROL(19375): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:45.591+0200 W/CAPI_APPFW_APP_CONTROL(19375): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:45.591+0200 I/recorder(19375): saving local data for es.ugr.frailty.gyroscope
06-12 18:45:45.591+0200 I/recorder(19375): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 18:45:45.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:45.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:45.611+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19375)
06-12 18:45:45.611+0200 I/servicemanager(19372): request sent to service es.ugr.frailty.recorder
06-12 18:45:45.611+0200 I/servicemanager(19372): requesting to save local data
06-12 18:45:45.611+0200 W/CAPI_APPFW_APP_CONTROL(19372): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 18:45:45.611+0200 I/utils   (19372): specific action
06-12 18:45:45.611+0200 I/servicemanager(19372): requesting to save local data for es.ugr.frailty.accelerometer
06-12 18:45:45.611+0200 W/AUL     (19372): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 18:45:45.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19431
06-12 18:45:45.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.681+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:45.681+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:45.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 18:45:45.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 18:45:45.711+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 18:45:45.711+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.711+0200 I/gravity (19431): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.711+0200 I/gravity (19431): es.ugr.frailty.gravity - capturing data
06-12 18:45:45.721+0200 I/gravity (19431): es.ugr.frailty.gravity: SM-R760,12/06/2018,18:45:45:724,9.643573,-1.459777,1.020260
06-12 18:45:45.721+0200 W/AUL     (19431): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 18:45:45.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(19372), cmd(0)
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 18:45:45.741+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 18:45:45.741+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 18:45:45.741+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 18:45:45.741+0200 E/CAPI_LOCATION_MANAGER(19436): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 18:45:45.761+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 18:45:45.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 18:45:45.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(43) , send fd(21), pid(19375), cmd(0)
06-12 18:45:45.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 18:45:45.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 18:45:45.791+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 18:45:45.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 18:45:45.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 18:45:45.791+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 18:45:45.811+0200 W/AUL     (19495): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 18:45:45.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19379
06-12 18:45:45.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.861+0200 W/AUL     (19379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.871+0200 I/accelerometer(19379): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 18:45:45.911+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19450
06-12 18:45:45.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19372
06-12 18:45:45.941+0200 I/heartrate(19403): es.ugr.frailty.heartrate - capturing data
06-12 18:45:45.941+0200 I/heartrate(19403): es.ugr.frailty.heartrate: waiting for rigth values
06-12 18:45:45.951+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19372)
06-12 18:45:45.951+0200 I/light   (19450): request sent to service es.ugr.frailty.servicemanager
06-12 18:45:45.951+0200 I/light   (19450): es.ugr.frailty.light - capturing data
06-12 18:45:45.951+0200 I/light   (19450): es.ugr.frailty.light: SM-R760,12/06/2018,18:45:45:958,80.000000
06-12 18:45:45.951+0200 W/AUL     (19450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 18:45:45.961+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 18:45:45.981+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 18:45:45.981+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 18:45:45.981+0200 I/CAPI_NETWORK_CONNECTION(19436): connection.c: connection_destroy(471) > Destroy handle: 0xf7a58c18
06-12 18:45:45.991+0200 W/CRASH_MANAGER(19494): worker.c: worker_job(1205) > 11194166c6f63152882194
