S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13099
Date: 2018-06-12 14:41:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf739e52d, r5   = 0xf7593150
r6   = 0xffbc0ec0, r7   = 0xffbc0d70
r8   = 0xf75a5c18, r9   = 0x00000000
r10  = 0xffbc0e4c, fp   = 0xffbc0ec0
ip   = 0x00000001, sp   = 0xffbc0d48
lr   = 0xf739e539, pc   = 0xf7407228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    167940 KB
Buffers:     34588 KB
Cached:     143876 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11776 KB
VmRSS:       11772 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13099 TID = 13099
13099 13114 

Maps Information
f4269000 f4a68000 rw-p [stack:13114]
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
f7575000 f75e3000 rw-p [heap]
ffba2000 ffbc3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13099)
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
27: main + 0xda (0xf74075c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
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
3.671+0200 W/LOCATION(13128): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 14:41:03.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:03.681+0200 I/AUL     (13128): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:41:03.681+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-12 14:41:03.681+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5715488), time2(5309030)
06-12 14:41:03.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-12 14:41:03.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-12 14:41:03.681+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-12 14:41:03.681+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:2, msg id:25
06-12 14:41:03.691+0200 I/AUL     (13128): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:41:03.691+0200 E/LOCATION(13128): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
06-12 14:41:03.691+0200 I/LOCATION(13128): location.c: location_new(269) > method: 1
06-12 14:41:03.691+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (13141) was created
06-12 14:41:03.701+0200 W/LOCATION(13128): module-internal.c: module_is_supported(340) > module name(gps) is found
06-12 14:41:03.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:03.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:03.711+0200 W/LOCATION(13128): module-internal.c: module_new(311) > module (gps) open success
06-12 14:41:03.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:03.721+0200 W/LOCATION(13128): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-12 14:41:03.721+0200 W/LOCATION(13128): module-internal.c: module_new(311) > module (remote_gps) open success
06-12 14:41:03.721+0200 W/LOCATION(13128): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-12 14:41:03.721+0200 W/LOCATION(13128): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-12 14:41:03.721+0200 W/LOCATION(13128): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-12 14:41:03.731+0200 I/AUL     (13128): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:41:03.741+0200 I/AUL     (13128): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-12 14:41:03.741+0200 E/LOCATION(13128): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
06-12 14:41:03.741+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:41:03.751+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:41:03.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:03.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13101
06-12 14:41:03.761+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:03.771+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:03.771+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:03.771+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:03:774,0.420000,-0.070000,-0.070000
06-12 14:41:03.771+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:03.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:03.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:03.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:03.811+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:03.811+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:03.811+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:03.811+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:03.811+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:03.811+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:03.821+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:41:03.821+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 13150
06-12 14:41:03.821+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:41:03.831+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:03.831+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:03.841+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:03.841+0200 I/accelerometer(13062): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:03.841+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer - capturing data
06-12 14:41:03.841+0200 I/utils   (13141): es.ugr.frailty.light listener started
06-12 14:41:03.871+0200 W/LOCATION(13099): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 14:41:03.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 13150
06-12 14:41:03.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(13150) type(svcapp) bg(0)
06-12 14:41:03.891+0200 E/CAPI_APPFW_APPLICATION(13150): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:41:03.891+0200 E/CAPI_APPFW_APPLICATION(13150): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:41:03.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:03.901+0200 I/utils   (13150): trying to start service: es.ugr.frailty.pedometer
06-12 14:41:03.911+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:03:822,-0.207294,9.764524,0.884007
06-12 14:41:03.911+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:03.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:03.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:03.921+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:03.921+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:03:926,46.000000
06-12 14:41:03.921+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:03.921+0200 I/utils   (13150): es.ugr.frailty.pedometer sensor supported
06-12 14:41:03.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:03.931+0200 I/utils   (13150): es.ugr.frailty.pedometer listener started
06-12 14:41:03.941+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13150)
06-12 14:41:03.941+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.pedometer
06-12 14:41:03.941+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:03.941+0200 I/utils   (13055): specific action
06-12 14:41:03.941+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:41:03.941+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:03.941+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:03.941+0200 I/linearacceleration(13101): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:03.941+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration - capturing data
06-12 14:41:03.941+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:41:03:949,0.338900,-0.154949,-0.154196
06-12 14:41:03.941+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:03.951+0200 I/LOCATION(13099): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 14:41:03.951+0200 I/LOCATION(13099): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 14:41:03.951+0200 I/location(13099): es.ugr.frailty.location:iniciado servicio de localización
06-12 14:41:03.951+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (13150) was created
06-12 14:41:03.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:03.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:03.961+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:41:03:846,0.131605,9.609575,0.729811
06-12 14:41:03.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:03.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:03.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(13055), cmd(0)
06-12 14:41:04.001+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [13150]
06-12 14:41:04.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:04.021+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.021+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.021+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:04.021+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:04:24,0.420000,-0.070000,-0.070000
06-12 14:41:04.021+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.021+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13101
06-12 14:41:04.041+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:04.051+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13113
06-12 14:41:04.061+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:04.061+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:04.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.081+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13113
06-12 14:41:04.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13141
06-12 14:41:04.131+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.131+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.131+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:04.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.131+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:04:135,-0.090037,9.765455,0.893404
06-12 14:41:04.131+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.151+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.151+0200 I/light   (13141): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.161+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:04.181+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:04:171,47.000000
06-12 14:41:04.181+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:04.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-12 14:41:04.221+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.221+0200 I/utils   (13058): specific action
06-12 14:41:04.221+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.221+0200 I/recorder(13058): saving local data for es.ugr.frailty.accelerometer
06-12 14:41:04.231+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-12 14:41:04.231+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.recorder
06-12 14:41:04.231+0200 I/servicemanager(13055): requesting to save local data
06-12 14:41:04.231+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.231+0200 I/utils   (13055): specific action
06-12 14:41:04.231+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.231+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:41:04.231+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:04.241+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:04.241+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:04.241+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:41:04.241+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:41:04.241+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:41:04.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.261+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:04.261+0200 I/recorder(13058): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:41:04.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.281+0200 I/LOCATION(13099): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:41:04.281+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.281+0200 I/linearacceleration(13101): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.281+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration - capturing data
06-12 14:41:04.291+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:41:04:291,-0.168388,0.014011,-0.003274
06-12 14:41:04.291+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.291+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:04.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(13055), cmd(0)
06-12 14:41:04.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:04.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(41) , send fd(21), pid(13058), cmd(0)
06-12 14:41:04.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:04.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.351+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.351+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.351+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:04.361+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:04:363,0.490000,-0.070000,-0.070000
06-12 14:41:04.361+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.371+0200 I/location(13099): es.ugr.frailty.location: waiting for rigth values
06-12 14:41:04.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:04.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:04.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:41:04.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:41:04.391+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:41:04.391+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:41:04.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13062
06-12 14:41:04.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.431+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.431+0200 I/accelerometer(13062): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.441+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:04.441+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:04.441+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer - capturing data
06-12 14:41:04.441+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:41:04:445,-0.258425,9.779467,0.890130
06-12 14:41:04.441+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13113
06-12 14:41:04.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.471+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.471+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.481+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:04.481+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:04:484,-0.145120,9.766160,0.878316
06-12 14:41:04.481+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13141
06-12 14:41:04.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.521+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.521+0200 I/light   (13141): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.521+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:04.531+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:04:530,48.000000
06-12 14:41:04.531+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:04.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-12 14:41:04.551+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.551+0200 I/utils   (13058): specific action
06-12 14:41:04.551+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.551+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.551+0200 I/recorder(13058): saving local data for es.ugr.frailty.gyroscope
06-12 14:41:04.551+0200 I/recorder(13058): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:41:04.561+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-12 14:41:04.561+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.recorder
06-12 14:41:04.561+0200 I/servicemanager(13055): requesting to save local data
06-12 14:41:04.561+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.561+0200 I/utils   (13055): specific action
06-12 14:41:04.561+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:41:04.561+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:04.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:04.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.631+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:04.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(13055), cmd(0)
06-12 14:41:04.651+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.651+0200 I/linearacceleration(13101): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:04.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(45) , send fd(21), pid(13058), cmd(0)
06-12 14:41:04.671+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:04.671+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:04.671+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration - capturing data
06-12 14:41:04.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:04.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.691+0200 E/CAPI_TELEPHONY(13128): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:41:04.701+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:41:04:682,-0.276016,0.097055,0.040528
06-12 14:41:04.701+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.701+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.701+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.701+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:04.701+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:04:709,0.420000,0.070000,-0.070000
06-12 14:41:04.701+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:04.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13113
06-12 14:41:04.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:04.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13127
06-12 14:41:04.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13062
06-12 14:41:04.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.811+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.821+0200 I/accelerometer(13062): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.821+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer - capturing data
06-12 14:41:04.821+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:41:04:826,-0.421137,9.863215,0.918844
06-12 14:41:04.821+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13113
06-12 14:41:04.841+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:04.841+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:04.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.861+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.861+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.861+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:04.861+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:04:866,-0.232464,9.763868,0.884996
06-12 14:41:04.861+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13141
06-12 14:41:04.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:04.911+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:04.911+0200 I/light   (13141): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:04.911+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:04.911+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:04:917,49.000000
06-12 14:41:04.911+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:04.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:04.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-12 14:41:04.941+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.941+0200 I/utils   (13058): specific action
06-12 14:41:04.941+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.941+0200 I/recorder(13058): saving local data for es.ugr.frailty.accelerometer
06-12 14:41:04.941+0200 I/recorder(13058): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:41:04.961+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-12 14:41:04.961+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.recorder
06-12 14:41:04.961+0200 I/servicemanager(13055): requesting to save local data
06-12 14:41:04.961+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:04.961+0200 I/utils   (13055): specific action
06-12 14:41:04.961+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:41:04.961+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:04.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:04.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:04.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.001+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.001+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.001+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:05.011+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:05:11,0.350000,0.070000,-0.070000
06-12 14:41:05.011+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(13055), cmd(0)
06-12 14:41:05.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(49) , send fd(21), pid(13058), cmd(0)
06-12 14:41:05.041+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:05.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.041+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:05.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:05.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.071+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.071+0200 I/linearacceleration(13101): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.071+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration - capturing data
06-12 14:41:05.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:05.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:05.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13062
06-12 14:41:05.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.131+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:41:05:80,0.041039,0.080204,0.079312
06-12 14:41:05.131+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.151+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:41:05.151+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:41:05.151+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:41:05.151+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.151+0200 I/accelerometer(13062): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.151+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer - capturing data
06-12 14:41:05.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.171+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:41:05:160,-0.191426,9.844072,0.964308
06-12 14:41:05.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13113
06-12 14:41:05.171+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.191+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.191+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.191+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:05.191+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:05:199,-0.218974,9.762388,0.904549
06-12 14:41:05.201+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13141
06-12 14:41:05.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.241+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:05.241+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:05.241+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.241+0200 I/light   (13141): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.241+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:05.251+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:05:251,48.000000
06-12 14:41:05.251+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:05.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-12 14:41:05.281+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.281+0200 I/utils   (13058): specific action
06-12 14:41:05.281+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.281+0200 I/recorder(13058): saving local data for es.ugr.frailty.accelerometer
06-12 14:41:05.281+0200 I/recorder(13058): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:41:05.301+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-12 14:41:05.301+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.recorder
06-12 14:41:05.301+0200 I/servicemanager(13055): requesting to save local data
06-12 14:41:05.301+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.301+0200 I/utils   (13055): specific action
06-12 14:41:05.301+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.301+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:41:05.301+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:05.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:05.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.351+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.351+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.351+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:05.351+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:05:355,0.350000,0.070000,-0.070000
06-12 14:41:05.351+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(13055), cmd(0)
06-12 14:41:05.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(53) , send fd(21), pid(13058), cmd(0)
06-12 14:41:05.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:05.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13141
06-12 14:41:05.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:41:05.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:41:05.401+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:41:05.401+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:41:05.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:05.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.441+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:05.441+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:05.441+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.441+0200 I/linearacceleration(13101): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.441+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration - capturing data
06-12 14:41:05.441+0200 I/linearacceleration(13101): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:41:05:447,0.010798,0.155861,0.045402
06-12 14:41:05.441+0200 W/AUL     (13101): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13062
06-12 14:41:05.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.481+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.481+0200 I/accelerometer(13062): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.481+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer - capturing data
06-12 14:41:05.481+0200 I/accelerometer(13062): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:41:05:487,-0.208176,9.918249,0.949951
06-12 14:41:05.481+0200 W/AUL     (13062): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:41:05.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13127
06-12 14:41:05.521+0200 W/LOCATION(13099): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:41:05.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13113
06-12 14:41:05.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13141
06-12 14:41:05.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.601+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.601+0200 I/gravity (13113): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.601+0200 I/gravity (13113): es.ugr.frailty.gravity - capturing data
06-12 14:41:05.611+0200 I/gravity (13113): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:41:05:610,-0.215427,9.761909,0.910550
06-12 14:41:05.611+0200 W/AUL     (13113): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13055
06-12 14:41:05.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13058
06-12 14:41:05.631+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.631+0200 I/utils   (13058): specific action
06-12 14:41:05.631+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.631+0200 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.631+0200 I/recorder(13058): saving local data for es.ugr.frailty.gyroscope
06-12 14:41:05.631+0200 I/recorder(13058): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:41:05.641+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.641+0200 I/light   (13141): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.641+0200 I/light   (13141): es.ugr.frailty.light - capturing data
06-12 14:41:05.641+0200 I/heartrate(13087): es.ugr.frailty.heartrate - capturing data
06-12 14:41:05.641+0200 I/heartrate(13087): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:41:05.641+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13058)
06-12 14:41:05.641+0200 I/servicemanager(13055): request sent to service es.ugr.frailty.recorder
06-12 14:41:05.641+0200 I/servicemanager(13055): requesting to save local data
06-12 14:41:05.641+0200 W/CAPI_APPFW_APP_CONTROL(13055): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:41:05.641+0200 I/utils   (13055): specific action
06-12 14:41:05.641+0200 I/servicemanager(13055): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:41:05.641+0200 W/AUL     (13055): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:41:05.651+0200 I/light   (13141): es.ugr.frailty.light: SM-R760,12/06/2018,14:41:05:644,48.000000
06-12 14:41:05.651+0200 W/AUL     (13141): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13075
06-12 14:41:05.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.691+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13055)
06-12 14:41:05.691+0200 I/gyroscope(13075): request sent to service es.ugr.frailty.servicemanager
06-12 14:41:05.691+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope - capturing data
06-12 14:41:05.701+0200 I/gyroscope(13075): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:41:05:701,0.350000,0.070000,-0.070000
06-12 14:41:05.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(13055), cmd(0)
06-12 14:41:05.701+0200 W/AUL     (13075): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:41:05.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:41:05.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(57) , send fd(21), pid(13058), cmd(0)
06-12 14:41:05.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:41:05.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:41:05.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 13101
06-12 14:41:05.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13055
06-12 14:41:05.831+0200 W/CRASH_MANAGER(13178): worker.c: worker_job(1205) > 11130996c6f63152880726
