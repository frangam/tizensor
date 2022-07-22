S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24209
Date: 2018-04-23 16:03:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d052d, r5   = 0xf7220f98
r6   = 0xffa7b7a8, r7   = 0xffa7b658
r8   = 0xf721dc18, r9   = 0x00000000
r10  = 0xffa7b734, fp   = 0xffa7b7a8
ip   = 0x00000001, sp   = 0xffa7a4d8
lr   = 0xf70d0539, pc   = 0xf71392b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10824 KB
Buffers:     61724 KB
Cached:     226384 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11872 KB
VmRSS:       11872 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24209 TID = 24209
24209 24216 

Maps Information
f3f9b000 f479a000 rw-p [stack:24216]
f47a1000 f47a3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47ab000 f47af000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47b8000 f47ba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47c2000 f47c5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47d4000 f47d9000 r-xp /usr/lib/libsystem.so.0.0.0
f47e4000 f47e7000 r-xp /lib/libattr.so.1.1.0
f47ef000 f47ff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4807000 f4810000 r-xp /usr/lib/libedbus.so.1.7.99
f4818000 f4819000 r-xp /usr/lib/libresponse.so.0.2.96
f4822000 f4827000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60c9000 f61cf000 r-xp /usr/lib/libicuuc.so.57.1
f61e5000 f636d000 r-xp /usr/lib/libicui18n.so.57.1
f637d000 f638a000 r-xp /usr/lib/libail.so.0.1.0
f6393000 f639a000 r-xp /usr/lib/libminizip.so.1.0.0
f63a3000 f654c000 r-xp /usr/lib/libcrypto.so.1.0.0
f656c000 f65b3000 r-xp /usr/lib/libssl.so.1.0.0
f65bf000 f65c1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65c9000 f65d0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65d9000 f65e0000 r-xp /lib/libcrypt-2.13.so
f6611000 f6614000 r-xp /lib/libcap.so.2.21
f661c000 f661e000 r-xp /usr/lib/libiri.so
f6626000 f666f000 r-xp /usr/lib/libmdm.so.1.2.69
f6677000 f667d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6685000 f66a8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66b2000 f66b4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66bc000 f66d9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66e2000 f66e6000 r-xp /usr/lib/libsmack.so.1.0.0
f66ef000 f6708000 r-xp /usr/lib/libnetwork.so.0.0.0
f6711000 f6719000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6721000 f6727000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6730000 f6732000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f673b000 f674b000 r-xp /lib/libresolv-2.13.so
f674f000 f6767000 r-xp /usr/lib/liblzma.so.5.0.3
f6770000 f6772000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f677a000 f6794000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f679c000 f67cb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d4000 f67e3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67ed000 f67f7000 r-xp /usr/lib/libsensord-shared.so
f6800000 f68d3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68de000 f68f4000 r-xp /lib/libz.so.1.2.5
f68fc000 f6901000 r-xp /usr/lib/libffi.so.5.0.10
f6909000 f690a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6912000 f6922000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f692a000 f6943000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f694b000 f694d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6955000 f69ca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d4000 f69da000 r-xp /lib/librt-2.13.so
f69e3000 f6a01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a0b000 f6a0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a14000 f6a37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a3f000 f6a44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4c000 f6a76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a7f000 f6a96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a9e000 f6b07000 r-xp /lib/libm-2.13.so
f6b10000 f6ba4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bb7000 f6bbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bc4000 f6bcb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bd3000 f6bfd000 r-xp /usr/lib/libsensor.so.1.9.6
f6c06000 f6cd2000 r-xp /usr/lib/libxml2.so.2.7.8
f6cdf000 f6ce1000 r-xp /usr/lib/libiniparser.so.0
f6cea000 f6cf0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf9000 f6dc9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dca000 f6dfe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e07000 f6e43000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e4b000 f6e4e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e56000 f6e5c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e64000 f6ea5000 r-xp /usr/lib/libeina.so.1.7.99
f6eae000 f6ec5000 r-xp /usr/lib/libecore.so.1.7.99
f6edc000 f6ee5000 r-xp /usr/lib/libvconf.so.0.2.45
f6eed000 f6f01000 r-xp /lib/libpthread-2.13.so
f6f0c000 f6f19000 r-xp /usr/lib/libaul.so.0.1.0
f6f23000 f6f25000 r-xp /lib/libdl-2.13.so
f6f2e000 f6f39000 r-xp /lib/libunwind.so.8.0.1
f6f66000 f6f6e000 r-xp /lib/libgcc_s-4.6.so.1
f6f6f000 f7093000 r-xp /lib/libc-2.13.so
f70a1000 f70a3000 r-xp /usr/lib/libdlog.so.0.0.0
f70ab000 f70b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c0000 f70c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70cd000 f70dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70e4000 f70e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f1000 f70f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f70fc000 f70fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7106000 f710a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7112000 f712f000 r-xp /lib/ld-2.13.so
f7138000 f713b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f713b000 f713f000 r-xp /usr/lib/libsys-assert.so
f71ed000 f725e000 rw-p [heap]
ffa5c000 ffa7d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24209)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71392b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dd73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6de7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6de7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e1c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dd5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6de7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6de7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e19e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e1a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e1e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71080bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47ac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf687f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d2cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d2e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ebeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6eb9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71396a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6f8685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7138fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.521+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.521+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.521+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.521+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:526,-7.200003,-6.692725,-0.023928
04-23 16:03:52.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.521+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:526,18.059999,19.180000,-8.890000
04-23 16:03:52.531+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.541+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:52.541+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:52.541+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:52.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:52.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.551+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.551+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:52.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:52.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24350
04-23 16:03:52.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24350) type(svcapp) bg(0)
04-23 16:03:52.571+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24350]
04-23 16:03:52.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24350)
04-23 16:03:52.581+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:52.581+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:52.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24350
04-23 16:03:52.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:52.601+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:03:52.601+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:03:52.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.601+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.611+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24285
04-23 16:03:52.611+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24285)
04-23 16:03:52.611+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:03:52.611+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:52.621+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:535,-6.967900,-6.740582,-0.162712
04-23 16:03:52.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24350
04-23 16:03:52.631+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:555,34.509998,21.000000,-10.290000
04-23 16:03:52.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:52.631+0200 I/accelerometer(24285): stopping es.ugr.frailty.accelerometer service
04-23 16:03:52.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24285), cmd(0)
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:52.631+0200 W/AUL     (24285): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24285
04-23 16:03:52.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:52.641+0200 W/AUL     (24285): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:52.641+0200 I/accelerometer(24285): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:52.641+0200 I/CAPI_APPFW_APPLICATION(24285): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:52.641+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.641+0200 I/utils   (19708): specific action
04-23 16:03:52.651+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf736d4d0
04-23 16:03:52.661+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.661+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:670,-15.890000,11.270000,1.050000
04-23 16:03:52.671+0200 E/CAPI_APPFW_APPLICATION(24350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:52.691+0200 E/CAPI_APPFW_APPLICATION(24350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:52.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:52.691+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:52.691+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.691+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:52.691+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:03:52.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24292
04-23 16:03:52.701+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24292)
04-23 16:03:52.701+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:03:52.701+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24350) was created
04-23 16:03:52.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(22624), cmd(0)
04-23 16:03:52.711+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24292), cmd(0)
04-23 16:03:52.711+0200 I/gyroscope(24292): stopping es.ugr.frailty.gyroscope service
04-23 16:03:52.711+0200 W/AUL     (24292): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24292
04-23 16:03:52.711+0200 I/utils   (22624): specific action
04-23 16:03:52.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.711+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:03:52.711+0200 I/recorder(22624): guardando datos en local
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:52.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:52.721+0200 I/utils   (19708): specific action
04-23 16:03:52.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:52.721+0200 W/AUL     (24292): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:52.721+0200 I/gyroscope(24292): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:52.721+0200 I/CAPI_APPFW_APPLICATION(24292): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.731+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:52.741+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:52.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:52.741+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:52.741+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 I/utils   (22624): specific action
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:03:52.741+0200 I/recorder(22624): guardando datos en local
04-23 16:03:52.751+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:52.761+0200 E/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:52.761+0200 E/PKGMGR_INFO(24350): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:52.761+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.811+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.821+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.841+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.851+0200 I/LOCATION(24350): location.c: location_new(269) > method: 0
04-23 16:03:52.851+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.851+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.871+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope listener destroyed
04-23 16:03:52.871+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.881+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.881+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer listener destroyed
04-23 16:03:52.891+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:52.901+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:52.901+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:52.901+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.901+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:52.901+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:52.931+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:52.951+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:52.951+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:52.951+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:52.981+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:52.981+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a15c18
04-23 16:03:52.981+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:52.991+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a15c18
04-23 16:03:52.991+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:52.991+0200 I/location(24350): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:53.031+0200 W/AUL     (24356): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24292
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:53.051+0200 W/AUL     (24357): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24285
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:53.061+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24292
04-23 16:03:53.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24292)
04-23 16:03:53.061+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24285
04-23 16:03:53.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24285)
04-23 16:03:53.081+0200 I/LOCATION(24350): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:53.131+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:53.131+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:53.131+0200 I/LOCATION(24350): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:53.201+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:53.201+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:53.201+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:53.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:53.211+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:53.211+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:53.211+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:53.211+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.261+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:53.261+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:53.361+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:53.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:53.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e1a358]
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:53.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:53.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:53.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6129105), time2(6122691)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:53.441+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:53.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:53.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.451+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:53.451+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:53.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:53.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:53.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:53.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.461+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:53.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.541+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:53.541+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:53.541+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.571+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:53.571+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:53.571+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:53.571+0200 I/location(24350): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:53.661+0200 I/LOCATION(24350): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.711+0200 W/AUL     (24350): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:53.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:53.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24350
04-23 16:03:53.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:53.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:53.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 I/utils   (19708): specific action
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:53.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:53.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:53.741+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 I/utils   (22624): specific action
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:53.741+0200 I/recorder(22624): guardando datos en local
04-23 16:03:53.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:53.741+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:53.741+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:53.741+0200 W/AUL     (24350): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:53.741+0200 I/location(24350): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:53.741+0200 I/location(24350): stopping es.ugr.frailty.location service
04-23 16:03:53.741+0200 E/CAPI_APPFW_APP_CONTROL(24350): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:53.741+0200 E/location(24350): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:53.741+0200 I/CAPI_APPFW_APPLICATION(24350): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:53.791+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:53.791+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:53.791+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:53.861+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:53.861+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:53.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:53.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a358
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01a60]
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:54.121+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.121+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.141+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:54.141+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:54.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:54.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.161+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:54.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01a60
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7345e00]
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:54.371+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.371+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.411+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:54.411+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:54.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:54.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:54.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.421+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:54.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7345e00
04-23 16:03:54.611+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:54.611+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:54.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:54.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:54.621+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24350
04-23 16:03:54.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24350)
04-23 16:03:54.621+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:54.621+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:54.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:03:54.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:54.631+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24350), cmd(0)
04-23 16:03:54.651+0200 W/AUL     (24369): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24318
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:54.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24318
04-23 16:03:54.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24318)
04-23 16:03:54.671+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:54.721+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:55.451+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11241506c6f631524492218
04-23 16:03:55.741+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:56.641+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:03:56.641+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:56.641+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:56.651+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24407
04-23 16:03:56.711+0200 E/CAPI_APPFW_APPLICATION(24407): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:56.711+0200 E/CAPI_APPFW_APPLICATION(24407): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:56.731+0200 W/LOCATION(24407): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:56.731+0200 E/LOCATION(24407): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:56.731+0200 E/PKGMGR_INFO(24407): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:56.731+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:56.751+0200 I/LOCATION(24407): location.c: location_new(269) > method: 0
04-23 16:03:56.751+0200 W/LOCATION(24407): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:56.751+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:56.761+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:56.761+0200 W/LOCATION(24407): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:56.761+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:56.771+0200 W/LOCATION(24407): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:56.771+0200 W/LOCATION(24407): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:56.771+0200 W/LOCATION(24407): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:56.771+0200 W/LOCATION(24407): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:56.781+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24407
04-23 16:03:56.781+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24407) type(svcapp) bg(0)
04-23 16:03:56.781+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24407) was created
04-23 16:03:56.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24407)
04-23 16:03:56.781+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:56.781+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:56.791+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:56.791+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:56.791+0200 W/LOCATION(24407): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:56.801+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24407]
04-23 16:03:56.801+0200 W/LOCATION(24407): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:56.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:56.821+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24407
04-23 16:03:56.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:56.821+0200 W/LOCATION(24407): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:56.831+0200 W/LOCATION(24407): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:56.831+0200 W/LOCATION(24407): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:56.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:56.851+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24407
04-23 16:03:56.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:56.871+0200 W/LOCATION(24407): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:56.871+0200 I/LOCATION(24407): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7878c18
04-23 16:03:56.871+0200 I/LOCATION(24407): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:56.871+0200 I/LOCATION(24407): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7878c18
04-23 16:03:56.871+0200 I/LOCATION(24407): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:56.871+0200 I/location(24407): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:56.921+0200 I/LOCATION(24407): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:56.951+0200 W/LOCATION(24407): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:56.951+0200 W/LOCATION(24407): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:56.951+0200 I/LOCATION(24407): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:57.051+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11242096c6f63152449222
