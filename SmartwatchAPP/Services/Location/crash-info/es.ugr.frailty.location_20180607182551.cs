S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27780
Date: 2018-06-07 18:25:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf770252d, r5   = 0xf7863f98
r6   = 0xffea9638, r7   = 0xffea94e8
r8   = 0xf7860c18, r9   = 0x00000000
r10  = 0xffea95c4, fp   = 0xffea9638
ip   = 0x00000001, sp   = 0xffea94c0
lr   = 0xf7702539, pc   = 0xf776b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    289344 KB
Buffers:      5720 KB
Cached:      99332 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11848 KB
VmRSS:       11848 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27780 TID = 27780
27780 27849 

Maps Information
f45cd000 f4dcc000 rw-p [stack:27849]
f4dd3000 f4dd5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ddd000 f4de1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dea000 f4dec000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4df4000 f4df7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e06000 f4e0b000 r-xp /usr/lib/libsystem.so.0.0.0
f4e16000 f4e19000 r-xp /lib/libattr.so.1.1.0
f4e21000 f4e31000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e39000 f4e42000 r-xp /usr/lib/libedbus.so.1.7.99
f4e4a000 f4e4b000 r-xp /usr/lib/libresponse.so.0.2.96
f4e54000 f4e59000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66fb000 f6801000 r-xp /usr/lib/libicuuc.so.57.1
f6817000 f699f000 r-xp /usr/lib/libicui18n.so.57.1
f69af000 f69bc000 r-xp /usr/lib/libail.so.0.1.0
f69c5000 f69cc000 r-xp /usr/lib/libminizip.so.1.0.0
f69d5000 f6b7e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b9e000 f6be5000 r-xp /usr/lib/libssl.so.1.0.0
f6bf1000 f6bf3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bfb000 f6c02000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c0b000 f6c12000 r-xp /lib/libcrypt-2.13.so
f6c43000 f6c46000 r-xp /lib/libcap.so.2.21
f6c4e000 f6c50000 r-xp /usr/lib/libiri.so
f6c58000 f6ca1000 r-xp /usr/lib/libmdm.so.1.2.69
f6ca9000 f6caf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cb7000 f6cda000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ce4000 f6ce6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cee000 f6d0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d14000 f6d18000 r-xp /usr/lib/libsmack.so.1.0.0
f6d21000 f6d3a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d43000 f6d4b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d53000 f6d59000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d62000 f6d64000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d6d000 f6d7d000 r-xp /lib/libresolv-2.13.so
f6d81000 f6d99000 r-xp /usr/lib/liblzma.so.5.0.3
f6da2000 f6da4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dac000 f6dc6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dce000 f6dfd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e06000 f6e15000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e1f000 f6e29000 r-xp /usr/lib/libsensord-shared.so
f6e32000 f6f05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f10000 f6f26000 r-xp /lib/libz.so.1.2.5
f6f2e000 f6f33000 r-xp /usr/lib/libffi.so.5.0.10
f6f3b000 f6f3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f44000 f6f54000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f5c000 f6f75000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f7d000 f6f7f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f87000 f6ffc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7006000 f700c000 r-xp /lib/librt-2.13.so
f7015000 f7033000 r-xp /usr/lib/libsystemd.so.0.4.0
f703d000 f703e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7046000 f7069000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7071000 f7076000 r-xp /usr/lib/libxdgmime.so.1.1.0
f707e000 f70a8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70b1000 f70c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70d0000 f7139000 r-xp /lib/libm-2.13.so
f7142000 f71d6000 r-xp /usr/lib/libstdc++.so.6.0.16
f71e9000 f71ee000 r-xp /usr/lib/libctx-client.so.0.8.3
f71f6000 f71fd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7205000 f722f000 r-xp /usr/lib/libsensor.so.1.9.6
f7238000 f7304000 r-xp /usr/lib/libxml2.so.2.7.8
f7311000 f7313000 r-xp /usr/lib/libiniparser.so.0
f731c000 f7322000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f732b000 f73fb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73fc000 f7430000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7439000 f7475000 r-xp /usr/lib/libSLP-location.so.0.9.24
f747d000 f7480000 r-xp /usr/lib/libbundle.so.0.1.22
f7488000 f748e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7496000 f74d7000 r-xp /usr/lib/libeina.so.1.7.99
f74e0000 f74f7000 r-xp /usr/lib/libecore.so.1.7.99
f750e000 f7517000 r-xp /usr/lib/libvconf.so.0.2.45
f751f000 f7533000 r-xp /lib/libpthread-2.13.so
f753e000 f754b000 r-xp /usr/lib/libaul.so.0.1.0
f7555000 f7557000 r-xp /lib/libdl-2.13.so
f7560000 f756b000 r-xp /lib/libunwind.so.8.0.1
f7598000 f75a0000 r-xp /lib/libgcc_s-4.6.so.1
f75a1000 f76c5000 r-xp /lib/libc-2.13.so
f76d3000 f76d5000 r-xp /usr/lib/libdlog.so.0.0.0
f76dd000 f76e9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f2000 f76f7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76ff000 f770e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7716000 f771a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7723000 f7726000 r-xp /usr/lib/libappcore-agent.so.1.1
f772e000 f7730000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7738000 f773c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7744000 f7761000 r-xp /lib/ld-2.13.so
f776a000 f776d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f776d000 f7771000 r-xp /usr/lib/libsys-assert.so
f7830000 f789e000 rw-p [heap]
ffe8a000 ffeab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27780)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf776b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7702539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74093f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7407c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7413e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7419be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7419dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74491f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7407c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7413e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7419be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7419dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf744be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf744c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74508d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf773a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4dde171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6eb1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf735efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73607a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74f0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74ebb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74ec5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74ec879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7724183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77247fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf776b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75b885c) [/lib/libc.so.6] + 0x1785c
29: (0xf776af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
scope listener started
06-07 18:25:49.511+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27758)
06-07 18:25:49.511+0200 I/servicemanager(27732): es.ugr.frailty.heartrate launch request sent!
06-07 18:25:49.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27753
06-07 18:25:49.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.511+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:49.511+0200 I/servicemanager(27732): es.ugr.frailty.location alive timeout
06-07 18:25:49.511+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 18:25:49.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:49.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:49.531+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27758]
06-07 18:25:49.541+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27780
06-07 18:25:49.541+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:49.551+0200 W/CAPI_APPFW_APP_CONTROL(27753): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:49.551+0200 I/utils   (27753): specific action
06-07 18:25:49.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27780
06-07 18:25:49.591+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(27780) type(svcapp) bg(0)
06-07 18:25:49.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27758
06-07 18:25:49.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.611+0200 E/CAPI_APPFW_APPLICATION(27780): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.611+0200 E/CAPI_APPFW_APPLICATION(27780): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.611+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27780]
06-07 18:25:49.621+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:49.621+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:49.621+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27758
06-07 18:25:49.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.631+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27780) was created
06-07 18:25:49.631+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:49:626,-0.070000,0.070000,0.070000
06-07 18:25:49.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.631+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27780)
06-07 18:25:49.631+0200 I/servicemanager(27732): es.ugr.frailty.location launch request sent!
06-07 18:25:49.631+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:49.631+0200 I/servicemanager(27732): es.ugr.frailty.linearacceleration alive timeout
06-07 18:25:49.631+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 18:25:49.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:49.641+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:49.651+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:49:627,0.315853,-0.071785,9.846465
06-07 18:25:49.651+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27784
06-07 18:25:49.651+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:49.671+0200 W/LOCATION(27780): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
06-07 18:25:49.671+0200 E/LOCATION(27780): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
06-07 18:25:49.671+0200 E/PKGMGR_INFO(27780): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
06-07 18:25:49.671+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 18:25:49.691+0200 E/CAPI_APPFW_APPLICATION(27784): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.691+0200 E/CAPI_APPFW_APPLICATION(27784): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.691+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:49.691+0200 I/utils   (27784): trying to start service: es.ugr.frailty.linearacceleration
06-07 18:25:49.691+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:49.701+0200 I/utils   (27784): es.ugr.frailty.linearacceleration sensor supported
06-07 18:25:49.701+0200 I/LOCATION(27780): location.c: location_new(269) > method: 0
06-07 18:25:49.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27784
06-07 18:25:49.701+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.linearacceleration) pid(27784) type(svcapp) bg(0)
06-07 18:25:49.701+0200 W/LOCATION(27780): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-07 18:25:49.711+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 18:25:49.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.711+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(gps) is found
06-07 18:25:49.721+0200 W/LOCATION(27780): module-internal.c: module_new(311) > module (gps) open success
06-07 18:25:49.721+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27780
06-07 18:25:49.721+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27784) was created
06-07 18:25:49.721+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
06-07 18:25:49.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.731+0200 W/LOCATION(27780): module-internal.c: module_new(311) > module (remote_gps) open success
06-07 18:25:49.731+0200 W/LOCATION(27780): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
06-07 18:25:49.731+0200 W/LOCATION(27780): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-07 18:25:49.731+0200 W/LOCATION(27780): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-07 18:25:49.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27780
06-07 18:25:49.741+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27784]
06-07 18:25:49.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.761+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.761+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27784)
06-07 18:25:49.761+0200 I/servicemanager(27732): es.ugr.frailty.linearacceleration launch request sent!
06-07 18:25:49.761+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:49.761+0200 I/servicemanager(27732): es.ugr.frailty.gravity alive timeout
06-07 18:25:49.761+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 18:25:49.771+0200 I/utils   (27784): es.ugr.frailty.linearacceleration listener started
06-07 18:25:49.771+0200 W/CAPI_APPFW_APP_CONTROL(27784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:49.771+0200 I/utils   (27784): specific action
06-07 18:25:49.771+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27784
06-07 18:25:49.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.781+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27784
06-07 18:25:49.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:49.791+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:49.801+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27797
06-07 18:25:49.801+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:49.811+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:49.811+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:49.821+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:49:826,-0.070000,0.070000,0.070000
06-07 18:25:49.821+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:49.831+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:49:832,-0.001391,-0.012968,0.033179
06-07 18:25:49.841+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(wps) is found
06-07 18:25:49.851+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(wps) is found
06-07 18:25:49.851+0200 E/CAPI_APPFW_APPLICATION(27797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.851+0200 E/CAPI_APPFW_APPLICATION(27797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27797
06-07 18:25:49.851+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(27797) type(svcapp) bg(0)
06-07 18:25:49.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.851+0200 W/LOCATION(27780): module-internal.c: module_new(311) > module (wps) open success
06-07 18:25:49.861+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27797]
06-07 18:25:49.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27797
06-07 18:25:49.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:49.881+0200 W/LOCATION(27780): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
06-07 18:25:49.891+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27797)
06-07 18:25:49.891+0200 I/servicemanager(27732): es.ugr.frailty.gravity launch request sent!
06-07 18:25:49.891+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:49.891+0200 I/servicemanager(27732): es.ugr.frailty.pressure alive timeout
06-07 18:25:49.891+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 18:25:49.891+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:49:809,0.311067,-0.095713,9.834501
06-07 18:25:49.891+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27797
06-07 18:25:49.891+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:49.891+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:49.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.901+0200 I/utils   (27797): trying to start service: es.ugr.frailty.gravity
06-07 18:25:49.901+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27797) was created
06-07 18:25:49.901+0200 W/LOCATION(27780): module-internal.c: module_new(311) > module (remote_wps) open success
06-07 18:25:49.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:49.901+0200 W/LOCATION(27780): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 18:25:49.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:49.901+0200 W/LOCATION(27780): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 18:25:49.911+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27802
06-07 18:25:49.921+0200 I/utils   (27797): es.ugr.frailty.gravity sensor supported
06-07 18:25:49.921+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:49.931+0200 W/LOCATION(27780): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
06-07 18:25:49.931+0200 I/LOCATION(27780): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7860c18
06-07 18:25:49.931+0200 I/LOCATION(27780): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
06-07 18:25:49.931+0200 I/LOCATION(27780): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7860c18
06-07 18:25:49.931+0200 I/LOCATION(27780): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
06-07 18:25:49.941+0200 I/location(27780): es.ugr.frailty.location: creado servicio de localización
06-07 18:25:49.961+0200 E/CAPI_APPFW_APPLICATION(27802): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.961+0200 E/CAPI_APPFW_APPLICATION(27802): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:49.961+0200 I/utils   (27802): trying to start service: es.ugr.frailty.pressure
06-07 18:25:49.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27802
06-07 18:25:49.961+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(27802) type(svcapp) bg(0)
06-07 18:25:49.961+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27802)
06-07 18:25:49.961+0200 I/servicemanager(27732): es.ugr.frailty.pressure launch request sent!
06-07 18:25:49.961+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:49.961+0200 I/servicemanager(27732): es.ugr.frailty.light alive timeout
06-07 18:25:49.961+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 18:25:49.971+0200 I/utils   (27797): es.ugr.frailty.gravity listener started
06-07 18:25:49.971+0200 W/CAPI_APPFW_APP_CONTROL(27797): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:49.971+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27802]
06-07 18:25:49.971+0200 I/utils   (27797): specific action
06-07 18:25:49.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:49.971+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27802) was created
06-07 18:25:49.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:49.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:49.991+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27814
06-07 18:25:49.991+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:50.001+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.001+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:50.001+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:50.031+0200 I/utils   (27802): es.ugr.frailty.pressure sensor supported
06-07 18:25:50.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27814
06-07 18:25:50.041+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(27814) type(svcapp) bg(0)
06-07 18:25:50.051+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27814)
06-07 18:25:50.051+0200 I/servicemanager(27732): es.ugr.frailty.light launch request sent!
06-07 18:25:50.051+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:50.051+0200 I/servicemanager(27732): es.ugr.frailty.pedometer alive timeout
06-07 18:25:50.051+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 18:25:50.051+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:50:8,0.320638,-0.093320,9.810574
06-07 18:25:50.051+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:50:10,0.070000,0.070000,0.070000
06-07 18:25:50.061+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:50.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.071+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27814]
06-07 18:25:50.071+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:50:73,0.309312,-0.089714,9.801360
06-07 18:25:50.071+0200 I/utils   (27802): es.ugr.frailty.pressure listener started
06-07 18:25:50.071+0200 W/CAPI_APPFW_APP_CONTROL(27802): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:50.071+0200 I/utils   (27802): specific action
06-07 18:25:50.091+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:50.091+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:50.101+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27802
06-07 18:25:50.101+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.111+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:50:10,0.007160,-0.004640,0.009336
06-07 18:25:50.111+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27802
06-07 18:25:50.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 18:25:50.111+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 27732
06-07 18:25:50.131+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 27823
06-07 18:25:50.131+0200 E/CAPI_APPFW_APPLICATION(27814): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:50.131+0200 E/CAPI_APPFW_APPLICATION(27814): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:50.131+0200 I/utils   (27814): trying to start service: es.ugr.frailty.light
06-07 18:25:50.131+0200 I/utils   (27814): es.ugr.frailty.light sensor supported
06-07 18:25:50.151+0200 I/utils   (27814): es.ugr.frailty.light listener started
06-07 18:25:50.151+0200 W/CAPI_APPFW_APP_CONTROL(27814): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:50.151+0200 I/utils   (27814): specific action
06-07 18:25:50.161+0200 I/LOCATION(27780): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
06-07 18:25:50.161+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 18:25:50.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27823
06-07 18:25:50.181+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(27823) type(svcapp) bg(0)
06-07 18:25:50.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.181+0200 W/AUL     (27732): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27823)
06-07 18:25:50.181+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27814) was created
06-07 18:25:50.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.201+0200 E/CAPI_APPFW_APPLICATION(27823): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:50.201+0200 E/CAPI_APPFW_APPLICATION(27823): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 18:25:50.201+0200 I/utils   (27823): trying to start service: es.ugr.frailty.pedometer
06-07 18:25:50.201+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (27823) was created
06-07 18:25:50.201+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:50.201+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:50.201+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:50.211+0200 I/utils   (27823): es.ugr.frailty.pedometer sensor supported
06-07 18:25:50.211+0200 I/servicemanager(27732): es.ugr.frailty.pedometer launch request sent!
06-07 18:25:50.211+0200 I/servicemanager(27732): App control destroyed.
06-07 18:25:50.211+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:50.221+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:50:225,0.313692,-0.091813,9.801202
06-07 18:25:50.221+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:50:215,0.351745,-0.066999,9.839286
06-07 18:25:50.231+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:50:215,0.042433,0.022715,0.037926
06-07 18:25:50.231+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:50:217,10013.000000
06-07 18:25:50.231+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.241+0200 I/utils   (27823): es.ugr.frailty.pedometer listener started
06-07 18:25:50.241+0200 W/CAPI_APPFW_APP_CONTROL(27823): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:50.241+0200 I/utils   (27823): specific action
06-07 18:25:50.241+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27814
06-07 18:25:50.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:50:242,-0.070000,0.070000,0.070000
06-07 18:25:50.251+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27814
06-07 18:25:50.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.291+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27823]
06-07 18:25:50.301+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:50.301+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:50.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.321+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27823
06-07 18:25:50.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 18:25:50.351+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27823
06-07 18:25:50.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 18:25:50.371+0200 W/LOCATION(27780): location-gps.c: __update_remote_connection_status(362) > update FALSE
06-07 18:25:50.371+0200 W/LOCATION(27780): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
06-07 18:25:50.371+0200 I/LOCATION(27780): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:25:50.401+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:50.401+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.401+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:50.401+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:50:408,0.326160,-0.084631,9.800859
06-07 18:25:50.411+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:50:412,9944.000000
06-07 18:25:50.411+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:50:411,-0.070000,0.070000,0.070000
06-07 18:25:50.451+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:26
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
06-07 18:25:50.451+0200 W/libgps  ( 3131): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
06-07 18:25:50.451+0200 D/gpsd_d  ( 3111): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHookStateIdle             : EXIT
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHookStateGps              : ENTRY
06-07 18:25:50.451+0200 W/libgps  ( 3131): [proxy__gps_start][line = 1022]: called.
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:25:50.451+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:27
06-07 18:25:50.451+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:8
06-07 18:25:50.451+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:1
06-07 18:25:50.451+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:25:50.451+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
06-07 18:25:50.451+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(11), data(0xf7cebb38), size(4)
06-07 18:25:50.451+0200 W/libgps_d( 3131): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
06-07 18:25:50.451+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
06-07 18:25:50.451+0200 W/libgps_d( 3131): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
06-07 18:25:50.491+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:50.491+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:50.501+0200 W/LOCATION(27780): location-wps.c: __update_remote_connection_status(215) > update FALSE
06-07 18:25:50.501+0200 W/LOCATION(27780): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
06-07 18:25:50.541+0200 W/LOCATION(27780): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-07 18:25:50.541+0200 I/LOCATION(27780): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-07 18:25:50.541+0200 I/LOCATION(27780): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-07 18:25:50.541+0200 I/location(27780): es.ugr.frailty.location:iniciado servicio de localización
06-07 18:25:50.591+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:50.591+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.591+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:50.591+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:50.591+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:50.601+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:50:605,0.315853,-0.083749,9.887143
06-07 18:25:50.611+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:50:603,-0.010307,0.000882,0.086284
06-07 18:25:50.611+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:50:600,-0.070000,0.070000,0.070000
06-07 18:25:50.611+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:50:605,0.313110,-0.083022,9.801298
06-07 18:25:50.611+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:50:609,9916.000000
06-07 18:25:50.631+0200 I/LOCATION(27780): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:25:50.681+0200 I/location(27780): es.ugr.frailty.location: waiting for rigth values
06-07 18:25:50.681+0200 W/CAPI_APPFW_APP_CONTROL(27780): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 18:25:50.681+0200 I/utils   (27780): specific action
06-07 18:25:50.691+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:50.691+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:50.791+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:50.791+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:50.791+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.801+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:50.801+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:50:799,9910.000000
06-07 18:25:50.811+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:50.821+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:50:816,0.320415,-0.088892,9.801011
06-07 18:25:50.821+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:50:815,-0.070000,0.070000,0.070000
06-07 18:25:50.821+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:50:806,0.019492,-0.015084,0.014060
06-07 18:25:50.831+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:50:810,0.332602,-0.098106,9.815358
06-07 18:25:50.901+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:50.901+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:50.971+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
06-07 18:25:50.971+0200 W/libgps  ( 3131): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(12575746), time2(12564548)
06-07 18:25:50.971+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
06-07 18:25:50.971+0200 W/libgps  ( 3131): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
06-07 18:25:50.971+0200 I/libgps_d( 3131): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
06-07 18:25:50.971+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:2, msg id:25
06-07 18:25:50.991+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:50.991+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:50.991+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:50.991+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.001+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.021+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:2,0.036115,0.021893,0.064597
06-07 18:25:51.021+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:5,-0.070000,0.070000,0.070000
06-07 18:25:51.031+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:4,0.356531,-0.066999,9.865608
06-07 18:25:51.031+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:51:4,9893.000000
06-07 18:25:51.041+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:12,0.332105,-0.082589,9.800677
06-07 18:25:51.081+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:25:51.081+0200 W/libgps_d( 3131): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-07 18:25:51.101+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:51.101+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:51.101+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-07 18:25:51.101+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:25:51.101+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:25:51.121+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:25:51.131+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.131+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.131+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:138,0.339781,-0.112463,9.805787
06-07 18:25:51.131+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.141+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:25:51.141+0200 E/LOCATION( 3823): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-07 18:25:51.141+0200 I/LOCATION( 3823): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-07 18:25:51.141+0200 I/LOCATION( 3823): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:25:51.151+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:136,-0.070000,0.070000,0.070000
06-07 18:25:51.151+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.161+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:144,0.007675,-0.029874,0.005110
06-07 18:25:51.161+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.161+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.171+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.171+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:163,0.315853,-0.100499,9.870394
06-07 18:25:51.171+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.181+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:178,0.140000,0.140000,0.070000
06-07 18:25:51.181+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.191+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:173,0.334575,-0.090029,9.800528
06-07 18:25:51.191+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.191+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:51.191+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:166,-0.018723,-0.010470,0.069866
06-07 18:25:51.191+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.191+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:51:200,9841.000000
06-07 18:25:51.201+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:184,0.323031,-0.047856,9.829715
06-07 18:25:51.201+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.201+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:208,0.318245,-0.078963,9.860823
06-07 18:25:51.201+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.221+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:200,-0.009586,0.042305,0.029122
06-07 18:25:51.221+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.221+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:228,-0.013450,0.008961,0.060178
06-07 18:25:51.221+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.231+0200 I/LOCATION(27780): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:25:51.231+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:189,0.070000,0.140000,0.070000
06-07 18:25:51.231+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.241+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:197,0.332617,-0.090161,9.800592
06-07 18:25:51.241+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.241+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:247,0.331695,-0.087924,9.800645
06-07 18:25:51.241+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:242,-0.070000,0.140000,0.070000
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:257,-0.070000,0.140000,0.070000
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:261,0.280000,0.070000,0.070000
06-07 18:25:51.251+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.261+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:213,0.327817,-0.052642,9.884750
06-07 18:25:51.261+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.261+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:269,0.332602,-0.093320,9.827322
06-07 18:25:51.261+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:233,-0.003141,0.034944,0.084078
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:278,0.001820,-0.007317,0.026629
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:281,0.000734,-0.007608,-0.002131
06-07 18:25:51.271+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:252,0.330958,-0.087586,9.800673
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:286,0.330782,-0.086003,9.800693
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:290,0.329475,-0.085712,9.800739
06-07 18:25:51.281+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.291+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:273,0.330210,-0.093320,9.798609
06-07 18:25:51.291+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.291+0200 I/heartrate(27758): es.ugr.frailty.heartrate - capturing data
06-07 18:25:51.291+0200 I/heartrate(27758): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:25:51.291+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:265,0.070000,0.070000,0.070000
06-07 18:25:51.291+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.301+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:305,0.070000,0.070000,0.070000
06-07 18:25:51.301+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.301+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:309,0.140000,0.070000,0.070000
06-07 18:25:51.301+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.311+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:285,0.020300,0.002155,0.028963
06-07 18:25:51.311+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.311+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:319,0.015068,0.018627,0.060083
06-07 18:25:51.311+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:301,0.349352,-0.083749,9.829715
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:327,0.344566,-0.066999,9.860823
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:331,0.315853,-0.088534,9.827322
06-07 18:25:51.321+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:293,0.329052,-0.085904,9.800752
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:338,0.329498,-0.085626,9.800739
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:342,0.329343,-0.084409,9.800755
06-07 18:25:51.331+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.341+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:323,-0.013491,-0.004126,0.026567
06-07 18:25:51.341+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.341+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:312,0.140000,0.070000,0.070000
06-07 18:25:51.341+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.361+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:334,0.306281,-0.112463,9.817751
06-07 18:25:51.371+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:347,-0.021600,-0.028185,0.016946
06-07 18:25:51.371+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.381+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:345,0.327881,-0.084277,9.800805
06-07 18:25:51.381+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.381+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.391+0200 I/light   (27814): es.ugr.frailty.light - capturing data
06-07 18:25:51.391+0200 I/light   (27814): es.ugr.frailty.light: SM-R760,07/06/2018,18:25:51:400,9824.000000
06-07 18:25:51.401+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:356,0.140000,0.070000,0.070000
06-07 18:25:51.401+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.411+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:387,0.325992,-0.085308,9.800858
06-07 18:25:51.411+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.411+0200 I/gravity (27797): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:25:51:421,0.325422,-0.084452,9.800885
06-07 18:25:51.411+0200 I/gravity (27797): es.ugr.frailty.gravity - capturing data
06-07 18:25:51.421+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:379,0.004217,0.011131,0.014500
06-07 18:25:51.421+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:395,0.330210,-0.074178,9.815358
06-07 18:25:51.421+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.421+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:25:51:430,0.334995,-0.088534,9.853643
06-07 18:25:51.421+0200 I/accelerometer(27742): es.ugr.frailty.accelerometer - capturing data
06-07 18:25:51.431+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.431+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:436,0.009573,-0.004082,0.052758
06-07 18:25:51.431+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.431+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:25:51:441,-0.006802,0.000554,0.055138
06-07 18:25:51.431+0200 I/linearacceleration(27784): es.ugr.frailty.linearacceleration - capturing data
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:409,0.140000,0.070000,0.070000
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:446,0.140000,0.070000,0.070000
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:25:51:450,0.070000,0.070000,0.070000
06-07 18:25:51.441+0200 I/gyroscope(27753): es.ugr.frailty.gyroscope - capturing data
06-07 18:25:51.461+0200 W/CRASH_MANAGER(27853): worker.c: worker_job(1205) > 11277806c6f63152838875
