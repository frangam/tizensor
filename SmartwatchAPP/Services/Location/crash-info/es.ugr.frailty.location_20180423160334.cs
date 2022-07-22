S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24117
Date: 2018-04-23 16:03:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf771252d, r5   = 0xf7a00f98
r6   = 0xff8d7c18, r7   = 0xff8d7ac8
r8   = 0xf79fdc18, r9   = 0x00000000
r10  = 0xff8d7ba4, fp   = 0xff8d7c18
ip   = 0x00000001, sp   = 0xff8d6948
lr   = 0xf7712539, pc   = 0xf777b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10548 KB
Buffers:     61652 KB
Cached:     225340 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11888 KB
VmRSS:       11888 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24117 TID = 24117
24117 24120 

Maps Information
f45dd000 f4ddc000 rw-p [stack:24120]
f4de3000 f4de5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ded000 f4df1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dfa000 f4dfc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e04000 f4e07000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e16000 f4e1b000 r-xp /usr/lib/libsystem.so.0.0.0
f4e26000 f4e29000 r-xp /lib/libattr.so.1.1.0
f4e31000 f4e41000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e49000 f4e52000 r-xp /usr/lib/libedbus.so.1.7.99
f4e5a000 f4e5b000 r-xp /usr/lib/libresponse.so.0.2.96
f4e64000 f4e69000 r-xp /usr/lib/libproc-stat.so.0.2.96
f670b000 f6811000 r-xp /usr/lib/libicuuc.so.57.1
f6827000 f69af000 r-xp /usr/lib/libicui18n.so.57.1
f69bf000 f69cc000 r-xp /usr/lib/libail.so.0.1.0
f69d5000 f69dc000 r-xp /usr/lib/libminizip.so.1.0.0
f69e5000 f6b8e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bae000 f6bf5000 r-xp /usr/lib/libssl.so.1.0.0
f6c01000 f6c03000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c0b000 f6c12000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c1b000 f6c22000 r-xp /lib/libcrypt-2.13.so
f6c53000 f6c56000 r-xp /lib/libcap.so.2.21
f6c5e000 f6c60000 r-xp /usr/lib/libiri.so
f6c68000 f6cb1000 r-xp /usr/lib/libmdm.so.1.2.69
f6cb9000 f6cbf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cc7000 f6cea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cf4000 f6cf6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cfe000 f6d1b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d24000 f6d28000 r-xp /usr/lib/libsmack.so.1.0.0
f6d31000 f6d4a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d53000 f6d5b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d63000 f6d69000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d72000 f6d74000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d7d000 f6d8d000 r-xp /lib/libresolv-2.13.so
f6d91000 f6da9000 r-xp /usr/lib/liblzma.so.5.0.3
f6db2000 f6db4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dbc000 f6dd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dde000 f6e0d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e16000 f6e25000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e2f000 f6e39000 r-xp /usr/lib/libsensord-shared.so
f6e42000 f6f15000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f20000 f6f36000 r-xp /lib/libz.so.1.2.5
f6f3e000 f6f43000 r-xp /usr/lib/libffi.so.5.0.10
f6f4b000 f6f4c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f54000 f6f64000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f6c000 f6f85000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f8d000 f6f8f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f97000 f700c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7016000 f701c000 r-xp /lib/librt-2.13.so
f7025000 f7043000 r-xp /usr/lib/libsystemd.so.0.4.0
f704d000 f704e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7056000 f7079000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7081000 f7086000 r-xp /usr/lib/libxdgmime.so.1.1.0
f708e000 f70b8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70c1000 f70d8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70e0000 f7149000 r-xp /lib/libm-2.13.so
f7152000 f71e6000 r-xp /usr/lib/libstdc++.so.6.0.16
f71f9000 f71fe000 r-xp /usr/lib/libctx-client.so.0.8.3
f7206000 f720d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7215000 f723f000 r-xp /usr/lib/libsensor.so.1.9.6
f7248000 f7314000 r-xp /usr/lib/libxml2.so.2.7.8
f7321000 f7323000 r-xp /usr/lib/libiniparser.so.0
f732c000 f7332000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f733b000 f740b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f740c000 f7440000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7449000 f7485000 r-xp /usr/lib/libSLP-location.so.0.9.24
f748d000 f7490000 r-xp /usr/lib/libbundle.so.0.1.22
f7498000 f749e000 r-xp /usr/lib/libappsvc.so.0.1.0
f74a6000 f74e7000 r-xp /usr/lib/libeina.so.1.7.99
f74f0000 f7507000 r-xp /usr/lib/libecore.so.1.7.99
f751e000 f7527000 r-xp /usr/lib/libvconf.so.0.2.45
f752f000 f7543000 r-xp /lib/libpthread-2.13.so
f754e000 f755b000 r-xp /usr/lib/libaul.so.0.1.0
f7565000 f7567000 r-xp /lib/libdl-2.13.so
f7570000 f757b000 r-xp /lib/libunwind.so.8.0.1
f75a8000 f75b0000 r-xp /lib/libgcc_s-4.6.so.1
f75b1000 f76d5000 r-xp /lib/libc-2.13.so
f76e3000 f76e5000 r-xp /usr/lib/libdlog.so.0.0.0
f76ed000 f76f9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7702000 f7707000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f770f000 f771e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7726000 f772a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7733000 f7736000 r-xp /usr/lib/libappcore-agent.so.1.1
f773e000 f7740000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7748000 f774c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7754000 f7771000 r-xp /lib/ld-2.13.so
f777a000 f777d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f777d000 f7781000 r-xp /usr/lib/libsys-assert.so
f79cd000 f7a56000 rw-p [heap]
ff8b9000 ff8da000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24117)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf777b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7712539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7417c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7423e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7429be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7429dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf745e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7417c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7423e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7429be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7429dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf745be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf745c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74608d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf774a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4dee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ec1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf736efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7500ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74fbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74fc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74fc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7734183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf777b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf75c885c) [/lib/libc.so.6] + 0x1785c
29: (0xf777afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:40.491+0200 W/LOCATION(24168): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:40.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.531+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:532,74
04-23 16:03:40.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d528]
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:40.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:40.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.641+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:40.641+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:40.641+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:40.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:40.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:40.641+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:40.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:40.661+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:40.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:40.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.731+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:734,74
04-23 16:03:40.731+0200 W/LOCATION(24168): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:40.731+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:40.731+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:40.731+0200 I/location(24168): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:40.851+0200 I/LOCATION(24168): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:40.901+0200 W/AUL     (24168): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:40.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:40.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24168
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:40.911+0200 W/AUL     (24168): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:40.911+0200 I/location(24168): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:40.911+0200 I/location(24168): stopping es.ugr.frailty.location service
04-23 16:03:40.911+0200 E/CAPI_APPFW_APP_CONTROL(24168): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:40.911+0200 E/location(24168): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:40.911+0200 I/CAPI_APPFW_APPLICATION(24168): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 I/utils   (19708): specific action
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:40.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.911+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:40.921+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:40.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:40.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:40.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:40.931+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:40.931+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:40.931+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:40.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:40.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 I/utils   (22624): specific action
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:40.931+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:40.931+0200 I/recorder(22624): guardando datos en local
04-23 16:03:40.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:40:932,75
04-23 16:03:40.981+0200 W/LOCATION(24168): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:40.981+0200 I/LOCATION(24168): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:40.981+0200 I/LOCATION(24168): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:03:41.081+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:41.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:41.081+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:41.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:41.121+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.131+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:133,75
04-23 16:03:41.131+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11240006c6f631524492206
04-23 16:03:41.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:41.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:41.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:41.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d528
04-23 16:03:41.321+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.331+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:332,76
04-23 16:03:41.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01ae0]
04-23 16:03:41.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:41.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:41.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:41.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:41.421+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:41.421+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:41.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.441+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:41.441+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:41.441+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:41.441+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:41.441+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:41.441+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:41.441+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:41.441+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:41.441+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:41.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.461+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:41.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.521+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.531+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.551+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:532,76
04-23 16:03:41.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:41.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:41.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:41.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01ae0
04-23 16:03:41.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e232b0]
04-23 16:03:41.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:41.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:41.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:41.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:41.661+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:41.661+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:41.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.691+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.691+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:41.691+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:41.691+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:41.691+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:41.691+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:41.691+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:41.691+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:41.691+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:41.691+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:41.691+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.701+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:41.701+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:41.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.721+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:41.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:41.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:41.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:41.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e232b0
04-23 16:03:41.791+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:733,76
04-23 16:03:41.921+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:41.931+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:41:933,76
04-23 16:03:41.941+0200 W/AUL     (24208): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:41.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:41.941+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:41.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24150
04-23 16:03:41.941+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:41.951+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24150
04-23 16:03:41.951+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24150)
04-23 16:03:41.971+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:41.971+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:41.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:41.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:41.981+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24209
04-23 16:03:41.981+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:42.031+0200 E/CAPI_APPFW_APPLICATION(24209): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:42.031+0200 E/CAPI_APPFW_APPLICATION(24209): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:42.051+0200 W/LOCATION(24209): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:42.051+0200 E/LOCATION(24209): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:42.051+0200 E/PKGMGR_INFO(24209): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:42.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24209
04-23 16:03:42.061+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:42.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24209) type(svcapp) bg(0)
04-23 16:03:42.061+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24209) was created
04-23 16:03:42.071+0200 I/LOCATION(24209): location.c: location_new(269) > method: 0
04-23 16:03:42.071+0200 W/LOCATION(24209): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:42.081+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:42.081+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:42.091+0200 W/LOCATION(24209): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:42.091+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:42.091+0200 W/LOCATION(24209): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:42.091+0200 W/LOCATION(24209): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:42.091+0200 W/LOCATION(24209): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:42.091+0200 W/LOCATION(24209): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:42.111+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:42.121+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:42.121+0200 W/LOCATION(24209): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:42.121+0200 W/LOCATION(24209): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:42.121+0200 W/LOCATION(24209): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:42.121+0200 W/LOCATION(24209): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:42.121+0200 W/LOCATION(24209): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:42.131+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24209]
04-23 16:03:42.141+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24209)
04-23 16:03:42.141+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:42.141+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:42.141+0200 W/LOCATION(24209): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:42.141+0200 I/LOCATION(24209): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf721dc18
04-23 16:03:42.141+0200 I/LOCATION(24209): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:42.141+0200 I/LOCATION(24209): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf721dc18
04-23 16:03:42.141+0200 I/LOCATION(24209): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:42.141+0200 I/location(24209): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:42.191+0200 I/LOCATION(24209): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:42.201+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:42.211+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:42:209,76
04-23 16:03:42.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:42.241+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24209
04-23 16:03:42.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:42.251+0200 W/LOCATION(24209): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:42.251+0200 W/LOCATION(24209): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:42.251+0200 I/LOCATION(24209): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:42.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:42.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24209
04-23 16:03:42.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:42.371+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:42.371+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:42:377,76
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:42.461+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:42.461+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:42.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:42.461+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:42.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:42.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:42.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:42.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:42.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:42.461+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:42.461+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:42.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:42.531+0200 I/heartrate(23824): capturing data from es.ugr.frailty.heartrate
04-23 16:03:42.531+0200 I/heartrate(23824): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:03:42:535,76
04-23 16:03:42.531+0200 W/LOCATION(24209): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:42.531+0200 W/LOCATION(24209): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:42.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:42.651+0200 I/servicemanager(19708): es.ugr.frailty.heartrate sleep timeout
04-23 16:03:42.651+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 16:03:42.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:42.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:42.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23824
04-23 16:03:42.661+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23824)
04-23 16:03:42.661+0200 I/servicemanager(19708): es.ugr.frailty.heartrate stop request sent!
04-23 16:03:42.661+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:42.681+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:42.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23824), cmd(0)
04-23 16:03:42.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e10470]
04-23 16:03:42.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:42.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:42.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:42.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:42.681+0200 I/heartrate(23824): stopping es.ugr.frailty.heartrate service
04-23 16:03:42.681+0200 W/AUL     (23824): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:42.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:42.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23824
04-23 16:03:42.681+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:42.681+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:42.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:42.691+0200 W/AUL     (23824): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:42.691+0200 I/heartrate(23824): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:42.691+0200 I/CAPI_APPFW_APPLICATION(23824): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:42.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:42.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:42.701+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.701+0200 I/utils   (19708): specific action
04-23 16:03:42.701+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.701+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.701+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:42.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:42.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:42.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:42.701+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:42.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:42.711+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:42.721+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.721+0200 I/utils   (22624): specific action
04-23 16:03:42.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:42.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:42.721+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.721+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.721+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:42.721+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 16:03:42.721+0200 I/recorder(22624): guardando datos en local
04-23 16:03:42.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:42.721+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:42.721+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:42.721+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:42.721+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6118383), time2(6112138)
04-23 16:03:42.721+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:42.721+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:42.721+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:42.721+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:42.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:42.721+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:42.721+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:42.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:42.721+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:42.721+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:42.721+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:42.721+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:42.721+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:42.721+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:42.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:42.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:42.731+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:42.741+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:42.781+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:42.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:42.791+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:42.811+0200 W/LOCATION(24209): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:42.811+0200 I/LOCATION(24209): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:42.811+0200 I/LOCATION(24209): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:42.811+0200 I/location(24209): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:42.841+0200 I/heartrate(23824): es.ugr.frailty.heartrate listener destroyed
04-23 16:03:42.921+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:42.921+0200 I/LOCATION(24209): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:42.991+0200 W/AUL     (24209): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:42.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:43.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24209
04-23 16:03:43.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:43.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:43.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:43.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.021+0200 W/AUL     (24222): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23824
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:43.021+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23824
04-23 16:03:43.021+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23824)
04-23 16:03:43.021+0200 I/utils   (19708): specific action
04-23 16:03:43.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.021+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:43.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:43.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 I/utils   (22624): specific action
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:43.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:43.041+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:43.041+0200 I/recorder(22624): guardando datos en local
04-23 16:03:43.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:43.041+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:43.041+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:43.041+0200 W/AUL     (24209): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:43.041+0200 I/location(24209): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:43.041+0200 W/CAPI_APPFW_APP_CONTROL(24209): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:43.041+0200 I/utils   (24209): specific action
04-23 16:03:43.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:43.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:43.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:43.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:43.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:43.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:43.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:43.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:43.461+0200 I/LOCATION(24209): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:43.671+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:43.671+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:43.671+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:43.671+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:43.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:43.691+0200 W/AUL     (24226): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:43.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:43.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:43.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24168
04-23 16:03:43.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:43.691+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24168
04-23 16:03:43.691+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24168)
04-23 16:03:43.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:43.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:43.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:43.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e10470
04-23 16:03:43.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e19220]
04-23 16:03:43.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:43.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:43.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:43.801+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:43.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:43.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:43.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.821+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:43.821+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:43.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:43.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:43.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:43.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:43.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:43.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:43.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:43.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:43.841+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:43.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:43.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:43.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:43.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:43.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:43.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:43.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e19220
04-23 16:03:43.961+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11241176c6f63152449221
