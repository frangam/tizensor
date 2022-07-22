S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18566
Date: 2018-06-12 17:54:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73d052d, r5   = 0xf7940150
r6   = 0xffe59c80, r7   = 0xffe59b30
r8   = 0xf7952c18, r9   = 0x00000000
r10  = 0xffe59c0c, fp   = 0xffe59c80
ip   = 0x00000001, sp   = 0xffe59b08
lr   = 0xf73d0539, pc   = 0xf7439228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    128068 KB
Buffers:     45440 KB
Cached:     168008 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11716 KB
VmRSS:       11712 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18566 TID = 18566
18566 18579 

Maps Information
f429b000 f4a9a000 rw-p [stack:18579]
f4aa1000 f4aa3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4aab000 f4aaf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ab8000 f4aba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ac2000 f4ac5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ad4000 f4ad9000 r-xp /usr/lib/libsystem.so.0.0.0
f4ae4000 f4ae7000 r-xp /lib/libattr.so.1.1.0
f4aef000 f4aff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b07000 f4b10000 r-xp /usr/lib/libedbus.so.1.7.99
f4b18000 f4b19000 r-xp /usr/lib/libresponse.so.0.2.96
f4b22000 f4b27000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63c9000 f64cf000 r-xp /usr/lib/libicuuc.so.57.1
f64e5000 f666d000 r-xp /usr/lib/libicui18n.so.57.1
f667d000 f668a000 r-xp /usr/lib/libail.so.0.1.0
f6693000 f669a000 r-xp /usr/lib/libminizip.so.1.0.0
f66a3000 f684c000 r-xp /usr/lib/libcrypto.so.1.0.0
f686c000 f68b3000 r-xp /usr/lib/libssl.so.1.0.0
f68bf000 f68c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68c9000 f68d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68d9000 f68e0000 r-xp /lib/libcrypt-2.13.so
f6911000 f6914000 r-xp /lib/libcap.so.2.21
f691c000 f691e000 r-xp /usr/lib/libiri.so
f6926000 f696f000 r-xp /usr/lib/libmdm.so.1.2.69
f6977000 f697d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6985000 f69a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69b2000 f69b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69bc000 f69d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69e2000 f69e6000 r-xp /usr/lib/libsmack.so.1.0.0
f69ef000 f6a08000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a11000 f6a19000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a21000 f6a27000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a30000 f6a32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a3b000 f6a4b000 r-xp /lib/libresolv-2.13.so
f6a4f000 f6a67000 r-xp /usr/lib/liblzma.so.5.0.3
f6a70000 f6a72000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a7a000 f6a94000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a9c000 f6acb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ad4000 f6ae3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6aed000 f6af7000 r-xp /usr/lib/libsensord-shared.so
f6b00000 f6bd3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bde000 f6bf4000 r-xp /lib/libz.so.1.2.5
f6bfc000 f6c01000 r-xp /usr/lib/libffi.so.5.0.10
f6c09000 f6c0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c12000 f6c22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c2a000 f6c43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c4b000 f6c4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c55000 f6cca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cd4000 f6cda000 r-xp /lib/librt-2.13.so
f6ce3000 f6d01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d0b000 f6d0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d14000 f6d37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d3f000 f6d44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d4c000 f6d76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d7f000 f6d96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d9e000 f6e07000 r-xp /lib/libm-2.13.so
f6e10000 f6ea4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6eb7000 f6ebc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ec4000 f6ecb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ed3000 f6efd000 r-xp /usr/lib/libsensor.so.1.9.6
f6f06000 f6fd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6fdf000 f6fe1000 r-xp /usr/lib/libiniparser.so.0
f6fea000 f6ff0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ff9000 f70c9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70ca000 f70fe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7107000 f7143000 r-xp /usr/lib/libSLP-location.so.0.9.24
f714b000 f714e000 r-xp /usr/lib/libbundle.so.0.1.22
f7156000 f715c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7164000 f71a5000 r-xp /usr/lib/libeina.so.1.7.99
f71ae000 f71c5000 r-xp /usr/lib/libecore.so.1.7.99
f71dc000 f71e5000 r-xp /usr/lib/libvconf.so.0.2.45
f71ed000 f7201000 r-xp /lib/libpthread-2.13.so
f720c000 f7219000 r-xp /usr/lib/libaul.so.0.1.0
f7223000 f7225000 r-xp /lib/libdl-2.13.so
f722e000 f7239000 r-xp /lib/libunwind.so.8.0.1
f7266000 f726e000 r-xp /lib/libgcc_s-4.6.so.1
f726f000 f7393000 r-xp /lib/libc-2.13.so
f73a1000 f73a3000 r-xp /usr/lib/libdlog.so.0.0.0
f73ab000 f73b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73c0000 f73c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73cd000 f73dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73e4000 f73e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73f1000 f73f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f73fc000 f73fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7406000 f740a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7412000 f742f000 r-xp /lib/ld-2.13.so
f7438000 f743b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f743b000 f743f000 r-xp /usr/lib/libsys-assert.so
f7922000 f7990000 rw-p [heap]
ffe3b000 ffe5c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18566)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7439228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70d73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf711c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7119e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf711a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7121f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ab91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4aac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b7f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf702cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf702e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71beca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71b9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71ba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71ba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74395c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf728685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7438f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
logOverhead=0,0,0,0,0,0,0), start: 17:54:08.938
06-12 17:54:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:09.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:09.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 17:54:09.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 17:54:09.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 17:54:09.271+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 17:54:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:09.331+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18596
06-12 17:54:09.341+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 17:54:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18596
06-12 17:54:09.381+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(18596) type(svcapp) bg(0)
06-12 17:54:09.381+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18596]
06-12 17:54:09.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:09.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:09.391+0200 E/CAPI_APPFW_APPLICATION(18596): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:09.391+0200 E/CAPI_APPFW_APPLICATION(18596): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:09.401+0200 I/utils   (18596): trying to start service: es.ugr.frailty.pressure
06-12 17:54:09.401+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:09.401+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:09.401+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18596)
06-12 17:54:09.411+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 17:54:09.411+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:09.411+0200 I/gravity (18581): es.ugr.frailty.gravity - capturing data
06-12 17:54:09.411+0200 I/accelerometer(18529): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:09.411+0200 I/servicemanager(18522): request sent to service es.ugr.frailty.pressure
06-12 17:54:09.411+0200 I/gyroscope(18542): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:09.411+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:09.411+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope - capturing data
06-12 17:54:09.411+0200 I/servicemanager(18522): es.ugr.frailty.light alive timeout
06-12 17:54:09.411+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer - capturing data
06-12 17:54:09.411+0200 I/servicemanager(18522): launch service es.ugr.frailty.light
06-12 17:54:09.411+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 17:54:09.421+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:54:09:426,-1.680000,3.920000,-4.060000
06-12 17:54:09.421+0200 I/gravity (18581): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:54:09:416,3.056125,1.101634,9.252939
06-12 17:54:09.421+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:54:09:422,3.180061,0.334995,9.420543
06-12 17:54:09.421+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.421+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.421+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.431+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.431+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:09.431+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:09.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:09.441+0200 I/utils   (18596): es.ugr.frailty.pressure sensor supported
06-12 17:54:09.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18566
06-12 17:54:09.451+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18596) was created
06-12 17:54:09.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:09.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18566
06-12 17:54:09.511+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-12 17:54:09.511+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(16973250), time2(16270116)
06-12 17:54:09.511+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-12 17:54:09.511+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-12 17:54:09.511+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-12 17:54:09.511+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:25
06-12 17:54:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:09.531+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18602
06-12 17:54:09.531+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 17:54:09.531+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: connection_create(453) > New handle created[0xf72abb50]
06-12 17:54:09.541+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
06-12 17:54:09.541+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
06-12 17:54:09.541+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
06-12 17:54:09.541+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: connection_get_type(507) > Connected Network = 2
06-12 17:54:09.571+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18602
06-12 17:54:09.581+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(18602) type(svcapp) bg(0)
06-12 17:54:09.581+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18602]
06-12 17:54:09.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:09.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:09.601+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.601+0200 E/LOCATION(18594): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
06-12 17:54:09.601+0200 E/PKGMGR_INFO(18594): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-12 17:54:09.611+0200 W/LOCATION(18594): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 17:54:09.621+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18602)
06-12 17:54:09.621+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:09.621+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:09.641+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:09.641+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.641+0200 E/LOCATION(18594): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
06-12 17:54:09.641+0200 I/LOCATION(18594): location.c: location_new(269) > method: 1
06-12 17:54:09.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:09.641+0200 I/servicemanager(18522): request sent to service es.ugr.frailty.light
06-12 17:54:09.641+0200 I/servicemanager(18522): es.ugr.frailty.pedometer alive timeout
06-12 17:54:09.651+0200 I/servicemanager(18522): launch service es.ugr.frailty.pedometer
06-12 17:54:09.661+0200 W/LOCATION(18594): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 17:54:09.671+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 17:54:09.681+0200 W/LOCATION(18594): module-internal.c: module_new(311) > module (gps) open success
06-12 17:54:09.681+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:09.681+0200 W/LOCATION(18594): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 17:54:09.691+0200 I/accelerometer(18529): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:09.691+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer - capturing data
06-12 17:54:09.701+0200 W/LOCATION(18594): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 17:54:09.701+0200 W/LOCATION(18594): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 17:54:09.701+0200 W/LOCATION(18594): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 17:54:09.701+0200 W/LOCATION(18594): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 17:54:09.711+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18542
06-12 17:54:09.731+0200 I/AUL     (18594): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 17:54:09.731+0200 E/LOCATION(18594): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 17:54:09.731+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 17:54:09.731+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 17:54:09.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:09.781+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:09.781+0200 I/gyroscope(18542): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:09.781+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope - capturing data
06-12 17:54:09.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:09.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:09.811+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 17:54:09.811+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:54:09:696,3.184847,0.256032,9.552148
06-12 17:54:09.811+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:09.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:09.821+0200 I/utils   (18596): es.ugr.frailty.pressure listener started
06-12 17:54:09.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18581
06-12 17:54:09.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:09.841+0200 E/CAPI_APPFW_APPLICATION(18602): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:09.841+0200 E/CAPI_APPFW_APPLICATION(18602): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:09.841+0200 I/utils   (18602): trying to start service: es.ugr.frailty.light
06-12 17:54:09.881+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:09.881+0200 I/gravity (18581): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:09.881+0200 I/gravity (18581): es.ugr.frailty.gravity - capturing data
06-12 17:54:09.891+0200 I/gravity (18581): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:54:09:892,3.079022,1.160136,9.238187
06-12 17:54:09.891+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.891+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:54:09:794,1.330000,1.120000,0.350000
06-12 17:54:09.891+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:09.891+0200 I/utils   (18602): es.ugr.frailty.light sensor supported
06-12 17:54:09.901+0200 I/utils   (18602): es.ugr.frailty.light listener started
06-12 17:54:09.911+0200 W/LOCATION(18566): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 17:54:09.911+0200 I/LOCATION(18566): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 17:54:09.911+0200 I/LOCATION(18566): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 17:54:09.911+0200 I/location(18566): es.ugr.frailty.location:iniciado servicio de localización
06-12 17:54:09.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:09.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18569
06-12 17:54:09.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:09.981+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 17:54:09.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 17:54:09.991+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 17:54:09.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:09.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:10.001+0200 I/light   (18602): es.ugr.frailty.light - capturing data
06-12 17:54:10.011+0200 I/light   (18602): es.ugr.frailty.light: SM-R760,12/06/2018,17:54:10:15,182.000000
06-12 17:54:10.011+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.021+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:10.021+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:10.021+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.021+0200 I/linearacceleration(18569): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.021+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration - capturing data
06-12 17:54:10.031+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:54:10:34,-0.115540,0.090804,0.143317
06-12 17:54:10.031+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.051+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18602) was created
06-12 17:54:10.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 17:54:10.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 17:54:10.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:10.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:10.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:10.191+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 17:54:10.191+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18625
06-12 17:54:10.221+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:10.221+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:10.241+0200 E/CAPI_APPFW_APPLICATION(18625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:10.241+0200 E/CAPI_APPFW_APPLICATION(18625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 17:54:10.241+0200 I/utils   (18625): trying to start service: es.ugr.frailty.pedometer
06-12 17:54:10.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18625
06-12 17:54:10.241+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(18625) type(svcapp) bg(0)
06-12 17:54:10.251+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18625]
06-12 17:54:10.251+0200 I/utils   (18625): es.ugr.frailty.pedometer sensor supported
06-12 17:54:10.261+0200 I/utils   (18625): es.ugr.frailty.pedometer listener started
06-12 17:54:10.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 17:54:10.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 17:54:10.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 17:54:10.271+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 17:54:10.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.291+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18625)
06-12 17:54:10.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:10.291+0200 I/servicemanager(18522): request sent to service es.ugr.frailty.pedometer
06-12 17:54:10.291+0200 W/CAPI_APPFW_APP_CONTROL(18522): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:10.291+0200 I/utils   (18522): specific action
06-12 17:54:10.291+0200 I/servicemanager(18522): requesting to save local data for es.ugr.frailty.accelerometer
06-12 17:54:10.291+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 17:54:10.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.311+0200 I/LOCATION(18566): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 17:54:10.331+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.331+0200 I/accelerometer(18529): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.331+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer - capturing data
06-12 17:54:10.331+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:54:10:341,3.019742,0.758525,9.559326
06-12 17:54:10.331+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.361+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18625) was created
06-12 17:54:10.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18581
06-12 17:54:10.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:10.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:10.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.401+0200 I/location(18566): es.ugr.frailty.location: waiting for rigth values
06-12 17:54:10.421+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:10.421+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:10.421+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.421+0200 I/gravity (18581): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.421+0200 I/gravity (18581): es.ugr.frailty.gravity - capturing data
06-12 17:54:10.431+0200 I/gravity (18581): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:54:10:434,3.002645,1.136839,9.266181
06-12 17:54:10.431+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 17:54:10.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(18522), cmd(0)
06-12 17:54:10.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18542
06-12 17:54:10.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.521+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.531+0200 I/gyroscope(18542): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.531+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope - capturing data
06-12 17:54:10.531+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:54:10:536,1.400000,1.820000,-1.890000
06-12 17:54:10.531+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18602
06-12 17:54:10.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:10.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:10.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.621+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:10.621+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:10.621+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.621+0200 I/light   (18602): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.621+0200 I/light   (18602): es.ugr.frailty.light - capturing data
06-12 17:54:10.631+0200 I/light   (18602): es.ugr.frailty.light: SM-R760,12/06/2018,17:54:10:637,187.000000
06-12 17:54:10.631+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18569
06-12 17:54:10.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.711+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:10.711+0200 I/linearacceleration(18569): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:10.711+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration - capturing data
06-12 17:54:10.721+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:54:10:722,0.079025,-0.054638,0.254726
06-12 17:54:10.721+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:10.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:10.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18569
06-12 17:54:10.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:10.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:10.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:10.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18569
06-12 17:54:10.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:10.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:10.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:10.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18525
06-12 17:54:10.871+0200 W/CAPI_APPFW_APP_CONTROL(18525): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:10.871+0200 I/utils   (18525): specific action
06-12 17:54:10.871+0200 W/CAPI_APPFW_APP_CONTROL(18525): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:10.871+0200 I/recorder(18525): saving local data for es.ugr.frailty.accelerometer
06-12 17:54:10.911+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 17:54:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 17:54:10.911+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 17:54:10.931+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18525)
06-12 17:54:10.931+0200 I/servicemanager(18522): request sent to service es.ugr.frailty.recorder
06-12 17:54:10.931+0200 I/servicemanager(18522): requesting to save local data
06-12 17:54:10.931+0200 W/CAPI_APPFW_APP_CONTROL(18522): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:10.931+0200 I/utils   (18522): specific action
06-12 17:54:10.931+0200 W/CAPI_APPFW_APP_CONTROL(18522): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:10.931+0200 I/servicemanager(18522): requesting to save local data for es.ugr.frailty.gyroscope
06-12 17:54:10.931+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 17:54:10.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:10.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:10.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:10.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:10.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:11.011+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.021+0200 I/accelerometer(18529): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 17:54:11.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(21), pid(18525), cmd(0)
06-12 17:54:11.031+0200 E/CAPI_TELEPHONY(18594): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 17:54:11.041+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:11.041+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:11.041+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer - capturing data
06-12 17:54:11.041+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:54:11:48,2.959922,1.040878,9.339187
06-12 17:54:11.041+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.061+0200 I/recorder(18525): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 17:54:11.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18581
06-12 17:54:11.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.101+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.101+0200 I/gravity (18581): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.101+0200 I/gravity (18581): es.ugr.frailty.gravity - capturing data
06-12 17:54:11.111+0200 I/gravity (18581): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:54:11:115,2.959403,1.018666,9.293796
06-12 17:54:11.111+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.121+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 17:54:11.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(18522), cmd(0)
06-12 17:54:11.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18542
06-12 17:54:11.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:11.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:11.191+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.191+0200 I/gyroscope(18542): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.191+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope - capturing data
06-12 17:54:11.201+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:54:11:203,7.840000,1.890000,-0.980000
06-12 17:54:11.201+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.221+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:11.221+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:11.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18602
06-12 17:54:11.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 17:54:11.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 17:54:11.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 17:54:11.271+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 17:54:11.281+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.281+0200 I/light   (18602): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.291+0200 I/light   (18602): es.ugr.frailty.light - capturing data
06-12 17:54:11.291+0200 I/light   (18602): es.ugr.frailty.light: SM-R760,12/06/2018,17:54:11:296,198.000000
06-12 17:54:11.291+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18569
06-12 17:54:11.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:11.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:11.401+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.411+0200 I/linearacceleration(18569): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.411+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration - capturing data
06-12 17:54:11.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 17:54:11.441+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:11.441+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:11.461+0200 I/linearacceleration(18569): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,17:54:11:417,-0.129151,-0.061816,0.053729
06-12 17:54:11.461+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 17:54:11.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:11.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18525
06-12 17:54:11.521+0200 W/CAPI_APPFW_APP_CONTROL(18525): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:11.521+0200 I/utils   (18525): specific action
06-12 17:54:11.521+0200 W/CAPI_APPFW_APP_CONTROL(18525): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:11.521+0200 W/CAPI_APPFW_APP_CONTROL(18525): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:11.521+0200 I/recorder(18525): saving local data for es.ugr.frailty.gyroscope
06-12 17:54:11.521+0200 I/recorder(18525): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 17:54:11.551+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18525)
06-12 17:54:11.551+0200 I/servicemanager(18522): request sent to service es.ugr.frailty.recorder
06-12 17:54:11.561+0200 I/servicemanager(18522): requesting to save local data
06-12 17:54:11.561+0200 W/CAPI_APPFW_APP_CONTROL(18522): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 17:54:11.561+0200 I/utils   (18522): specific action
06-12 17:54:11.561+0200 I/servicemanager(18522): requesting to save local data for es.ugr.frailty.accelerometer
06-12 17:54:11.561+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 17:54:11.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:11.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:11.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:11.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.621+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:11.621+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:11.621+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.621+0200 I/accelerometer(18529): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.621+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer - capturing data
06-12 17:54:11.631+0200 I/accelerometer(18529): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,17:54:11:634,3.215954,0.698704,9.052048
06-12 17:54:11.631+0200 W/AUL     (18529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.641+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 17:54:11.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(18522), cmd(0)
06-12 17:54:11.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 17:54:11.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(44) , send fd(21), pid(18525), cmd(0)
06-12 17:54:11.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18581
06-12 17:54:11.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.761+0200 W/LOCATION(18566): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 17:54:11.761+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.761+0200 I/gravity (18581): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.761+0200 I/gravity (18581): es.ugr.frailty.gravity - capturing data
06-12 17:54:11.771+0200 I/gravity (18581): es.ugr.frailty.gravity: SM-R760,12/06/2018,17:54:11:773,3.062770,0.994077,9.262918
06-12 17:54:11.781+0200 W/AUL     (18581): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:11.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:11.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18542
06-12 17:54:11.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:11.821+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:11.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.861+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.861+0200 I/gyroscope(18542): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.861+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope - capturing data
06-12 17:54:11.861+0200 I/gyroscope(18542): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,17:54:11:870,1.890000,1.470000,-1.050000
06-12 17:54:11.861+0200 W/AUL     (18542): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.911+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 17:54:11.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 17:54:11.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:11.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18602
06-12 17:54:11.921+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 17:54:11.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:11.961+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:11.961+0200 I/light   (18602): request sent to service es.ugr.frailty.servicemanager
06-12 17:54:11.961+0200 I/light   (18602): es.ugr.frailty.light - capturing data
06-12 17:54:11.961+0200 I/light   (18602): es.ugr.frailty.light: SM-R760,12/06/2018,17:54:11:969,206.000000
06-12 17:54:11.961+0200 W/AUL     (18602): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 17:54:11.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:11.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:12.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:12.021+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18581
06-12 17:54:12.031+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:12.031+0200 I/heartrate(18555): es.ugr.frailty.heartrate: waiting for rigth values
06-12 17:54:12.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:12.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18569
06-12 17:54:12.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:12.081+0200 W/AUL     (18643): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 17:54:12.081+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 17:54:12.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 17:54:12.091+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 17:54:12.091+0200 E/CAPI_LOCATION_MANAGER(18594): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 17:54:12.101+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 17:54:12.121+0200 W/AUL     (18569): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18522)
06-12 17:54:12.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 17:54:12.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18581
06-12 17:54:12.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 17:54:12.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 17:54:12.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:12.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18522
06-12 17:54:12.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18525
06-12 17:54:12.281+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 17:54:12.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 17:54:12.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 18529
06-12 17:54:12.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 17:54:12.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 17:54:12.291+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 17:54:12.291+0200 W/AUL     (18522): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18525)
06-12 17:54:12.291+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 17:54:12.291+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 17:54:12.291+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 17:54:12.291+0200 I/CAPI_NETWORK_CONNECTION(18594): connection.c: connection_destroy(471) > Destroy handle: 0xf72abb50
06-12 17:54:12.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18522
06-12 17:54:12.311+0200 I/heartrate(18555): es.ugr.frailty.heartrate - capturing data
06-12 17:54:12.351+0200 W/CRASH_MANAGER(18644): worker.c: worker_job(1205) > 11185666c6f63152881885
