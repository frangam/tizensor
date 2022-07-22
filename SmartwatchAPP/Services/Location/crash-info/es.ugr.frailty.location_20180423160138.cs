S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22526
Date: 2018-04-23 16:01:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75a852d, r5   = 0xf784bf98
r6   = 0xffc11d08, r7   = 0xffc11bb8
r8   = 0xf7848c18, r9   = 0x00000000
r10  = 0xffc11c94, fp   = 0xffc11d08
ip   = 0x00000001, sp   = 0xffc10a38
lr   = 0xf75a8539, pc   = 0xf76112b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10556 KB
Buffers:     60352 KB
Cached:     224428 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12084 KB
VmRSS:       12084 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22526 TID = 22526
22526 22533 

Maps Information
f4473000 f4c72000 rw-p [stack:22533]
f4c79000 f4c7b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c83000 f4c87000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c90000 f4c92000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c9a000 f4c9d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cac000 f4cb1000 r-xp /usr/lib/libsystem.so.0.0.0
f4cbc000 f4cbf000 r-xp /lib/libattr.so.1.1.0
f4cc7000 f4cd7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cdf000 f4ce8000 r-xp /usr/lib/libedbus.so.1.7.99
f4cf0000 f4cf1000 r-xp /usr/lib/libresponse.so.0.2.96
f4cfa000 f4cff000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65a1000 f66a7000 r-xp /usr/lib/libicuuc.so.57.1
f66bd000 f6845000 r-xp /usr/lib/libicui18n.so.57.1
f6855000 f6862000 r-xp /usr/lib/libail.so.0.1.0
f686b000 f6872000 r-xp /usr/lib/libminizip.so.1.0.0
f687b000 f6a24000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a44000 f6a8b000 r-xp /usr/lib/libssl.so.1.0.0
f6a97000 f6a99000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aa1000 f6aa8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ab1000 f6ab8000 r-xp /lib/libcrypt-2.13.so
f6ae9000 f6aec000 r-xp /lib/libcap.so.2.21
f6af4000 f6af6000 r-xp /usr/lib/libiri.so
f6afe000 f6b47000 r-xp /usr/lib/libmdm.so.1.2.69
f6b4f000 f6b55000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b5d000 f6b80000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b8a000 f6b8c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b94000 f6bb1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bba000 f6bbe000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc7000 f6be0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6be9000 f6bf1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bf9000 f6bff000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c08000 f6c0a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c13000 f6c23000 r-xp /lib/libresolv-2.13.so
f6c27000 f6c3f000 r-xp /usr/lib/liblzma.so.5.0.3
f6c48000 f6c4a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c52000 f6c6c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c74000 f6ca3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cac000 f6cbb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cc5000 f6ccf000 r-xp /usr/lib/libsensord-shared.so
f6cd8000 f6dab000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db6000 f6dcc000 r-xp /lib/libz.so.1.2.5
f6dd4000 f6dd9000 r-xp /usr/lib/libffi.so.5.0.10
f6de1000 f6de2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dea000 f6dfa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e02000 f6e1b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e23000 f6e25000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e2d000 f6ea2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eac000 f6eb2000 r-xp /lib/librt-2.13.so
f6ebb000 f6ed9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ee3000 f6ee4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eec000 f6f0f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f17000 f6f1c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f24000 f6f4e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f57000 f6f6e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f76000 f6fdf000 r-xp /lib/libm-2.13.so
f6fe8000 f707c000 r-xp /usr/lib/libstdc++.so.6.0.16
f708f000 f7094000 r-xp /usr/lib/libctx-client.so.0.8.3
f709c000 f70a3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70ab000 f70d5000 r-xp /usr/lib/libsensor.so.1.9.6
f70de000 f71aa000 r-xp /usr/lib/libxml2.so.2.7.8
f71b7000 f71b9000 r-xp /usr/lib/libiniparser.so.0
f71c2000 f71c8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71d1000 f72a1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72a2000 f72d6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72df000 f731b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7323000 f7326000 r-xp /usr/lib/libbundle.so.0.1.22
f732e000 f7334000 r-xp /usr/lib/libappsvc.so.0.1.0
f733c000 f737d000 r-xp /usr/lib/libeina.so.1.7.99
f7386000 f739d000 r-xp /usr/lib/libecore.so.1.7.99
f73b4000 f73bd000 r-xp /usr/lib/libvconf.so.0.2.45
f73c5000 f73d9000 r-xp /lib/libpthread-2.13.so
f73e4000 f73f1000 r-xp /usr/lib/libaul.so.0.1.0
f73fb000 f73fd000 r-xp /lib/libdl-2.13.so
f7406000 f7411000 r-xp /lib/libunwind.so.8.0.1
f743e000 f7446000 r-xp /lib/libgcc_s-4.6.so.1
f7447000 f756b000 r-xp /lib/libc-2.13.so
f7579000 f757b000 r-xp /usr/lib/libdlog.so.0.0.0
f7583000 f758f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7598000 f759d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75a5000 f75b4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75bc000 f75c0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75c9000 f75cc000 r-xp /usr/lib/libappcore-agent.so.1.1
f75d4000 f75d6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75de000 f75e2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75ea000 f7607000 r-xp /lib/ld-2.13.so
f7610000 f7613000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7613000 f7617000 r-xp /usr/lib/libsys-assert.so
f7818000 f787a000 rw-p [heap]
ffbf3000 ffc14000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22526)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf76112b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf75a8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72af3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72adc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72b9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72bfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72bfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72f475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72ef1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72adc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72b9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72bfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72bfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72f1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72f2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72f68d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf75e00bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4c84171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d57663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7204fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72067a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7396ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7391b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73925a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7392879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ca183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ca7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76116a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf745e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7610fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
md(0)
04-23 16:01:34.081+0200 W/AUL     (22504): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22433
04-23 16:01:34.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:34.091+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22433
04-23 16:01:34.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22433)
04-23 16:01:34.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:34.241+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:34.411+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:34.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:34.441+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:34.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:34.641+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:34:647,68
04-23 16:01:34.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:34.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:34:848,69
04-23 16:01:35.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:35.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:35:48,68
04-23 16:01:35.211+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:01:35.211+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:35.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:35.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:35.231+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22512
04-23 16:01:35.231+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:35.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:35.241+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:35:248,69
04-23 16:01:35.281+0200 E/CAPI_APPFW_APPLICATION(22512): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:35.281+0200 E/CAPI_APPFW_APPLICATION(22512): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:35.301+0200 W/LOCATION(22512): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:35.301+0200 E/LOCATION(22512): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:35.301+0200 E/PKGMGR_INFO(22512): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:35.301+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:35.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22512
04-23 16:01:35.311+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22512) type(svcapp) bg(0)
04-23 16:01:35.311+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22512) was created
04-23 16:01:35.321+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22512)
04-23 16:01:35.321+0200 I/LOCATION(22512): location.c: location_new(269) > method: 0
04-23 16:01:35.321+0200 W/LOCATION(22512): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:35.331+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:35.331+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:35.331+0200 W/LOCATION(22512): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:35.341+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:35.341+0200 W/LOCATION(22512): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:35.341+0200 W/LOCATION(22512): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:35.341+0200 W/LOCATION(22512): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:35.341+0200 W/LOCATION(22512): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:35.351+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22512]
04-23 16:01:35.351+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:01:35.351+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:35.371+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:35.371+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:35.371+0200 W/LOCATION(22512): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:35.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:35.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22512
04-23 16:01:35.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:35.401+0200 W/LOCATION(22512): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:35.401+0200 W/LOCATION(22512): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:35.401+0200 W/LOCATION(22512): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:35.401+0200 W/LOCATION(22512): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:35.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:35.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22512
04-23 16:01:35.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:35.431+0200 W/LOCATION(22512): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:35.431+0200 I/LOCATION(22512): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7e58c18
04-23 16:01:35.431+0200 I/LOCATION(22512): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:35.431+0200 I/LOCATION(22512): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7e58c18
04-23 16:01:35.431+0200 I/LOCATION(22512): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:35.441+0200 I/location(22512): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:35.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:35.441+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:35:448,68
04-23 16:01:35.501+0200 I/LOCATION(22512): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:35.541+0200 W/LOCATION(22512): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:35.541+0200 W/LOCATION(22512): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:35.541+0200 I/LOCATION(22512): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:35.621+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:35.621+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:35.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:35.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:35.621+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:35.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:35.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:35.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:35.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:35.631+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:35.631+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:35.631+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:35.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:35.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:35.641+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:35:650,68
04-23 16:01:35.691+0200 W/LOCATION(22512): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:35.691+0200 W/LOCATION(22512): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:35.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:35.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7374110]
04-23 16:01:35.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:35.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:35.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:35.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:35.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:35.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:35.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:35.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:35.831+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:35.831+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:35.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:35.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:35.831+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:35.831+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:35.831+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:35.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:35.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:35.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:35.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:35.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:35:850,68
04-23 16:01:35.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:35.851+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:35.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:35.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:35.871+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5991530), time2(5987497)
04-23 16:01:35.871+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:35.871+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:35.871+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:35.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:35.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:35.921+0200 W/LOCATION(22512): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:35.921+0200 I/LOCATION(22512): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:35.921+0200 I/LOCATION(22512): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:35.921+0200 I/location(22512): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:36.011+0200 I/LOCATION(22512): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:36.051+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:36.051+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:36:55,69
04-23 16:01:36.061+0200 W/AUL     (22512): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:36.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:36.061+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22512
04-23 16:01:36.071+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:36.071+0200 W/AUL     (22512): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:36.071+0200 I/location(22512): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:36.071+0200 I/location(22512): stopping es.ugr.frailty.location service
04-23 16:01:36.071+0200 E/CAPI_APPFW_APP_CONTROL(22512): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:36.071+0200 E/location(22512): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:36.071+0200 I/CAPI_APPFW_APPLICATION(22512): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:36.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:36.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:36.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.081+0200 I/utils   (19708): specific action
04-23 16:01:36.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.081+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:36.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.081+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:36.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:36.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:36.081+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:36.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:36.091+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:36.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:36.091+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.091+0200 I/utils   (21185): specific action
04-23 16:01:36.091+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.091+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.091+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.091+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:36.091+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:36.091+0200 I/recorder(21185): guardando datos en local
04-23 16:01:36.091+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:36.091+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:36.091+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:36.121+0200 W/LOCATION(22512): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:36.121+0200 I/LOCATION(22512): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:36.121+0200 I/LOCATION(22512): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:01:36.191+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:36.191+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:36.191+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:36.191+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:36.251+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:36.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:36:255,69
04-23 16:01:36.291+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:36.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:36.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:36.351+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7374110
04-23 16:01:36.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7346038]
04-23 16:01:36.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:36.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:36.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:36.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:36.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:36.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:36.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.431+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:36.431+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:36.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:36.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:36.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:36.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:36.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:36.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:36.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:36.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:36.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.441+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:36.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.451+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:36:449,69
04-23 16:01:36.481+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.491+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:36.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:36.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:36.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7346038
04-23 16:01:36.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734a2f0]
04-23 16:01:36.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:36.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:36.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:36.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:36.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:36.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:36.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.631+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:36.631+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:36.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:36.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:36.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:36.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:36.631+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:36.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:36.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:36.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:36.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:36.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:36.651+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:36:649,69
04-23 16:01:36.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:36.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:36.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:36.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:36.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734a2f0
04-23 16:01:36.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:36.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:36:849,70
04-23 16:01:36.911+0200 W/AUL     (22523): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:36.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:36.921+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:36.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22465
04-23 16:01:36.921+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:36.921+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22465
04-23 16:01:36.921+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22465)
04-23 16:01:37.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:37.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:37:49,70
04-23 16:01:37.181+0200 I/APP_CORE(19704): appcore-efl.c: __do_app(453) > [APP 19704] Event: MEM_FLUSH State: PAUSED
04-23 16:01:37.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:37.241+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:37:249,70
04-23 16:01:37.391+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:37.391+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:37.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:37.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:37.401+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22526
04-23 16:01:37.401+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:37.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:37.451+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:37:449,70
04-23 16:01:37.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22526
04-23 16:01:37.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22526) type(svcapp) bg(0)
04-23 16:01:37.461+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22526]
04-23 16:01:37.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22526)
04-23 16:01:37.461+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:37.461+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:37.461+0200 E/CAPI_APPFW_APPLICATION(22526): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:37.461+0200 E/CAPI_APPFW_APPLICATION(22526): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:37.461+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22526) was created
04-23 16:01:37.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:37.491+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22526
04-23 16:01:37.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:37.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:37.501+0200 W/LOCATION(22526): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:37.501+0200 E/LOCATION(22526): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:37.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22526
04-23 16:01:37.501+0200 E/PKGMGR_INFO(22526): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:37.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:37.511+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:37.531+0200 I/LOCATION(22526): location.c: location_new(269) > method: 0
04-23 16:01:37.531+0200 W/LOCATION(22526): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:37.531+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:37.541+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:37.551+0200 W/LOCATION(22526): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:37.551+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:37.551+0200 W/LOCATION(22526): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:37.551+0200 W/LOCATION(22526): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:37.551+0200 W/LOCATION(22526): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:37.551+0200 W/LOCATION(22526): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:37.581+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:37.581+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:37.581+0200 W/LOCATION(22526): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:37.591+0200 W/LOCATION(22526): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:37.601+0200 W/LOCATION(22526): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:37.601+0200 W/LOCATION(22526): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:37.601+0200 W/LOCATION(22526): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:37.611+0200 W/LOCATION(22526): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:37.611+0200 I/LOCATION(22526): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7848c18
04-23 16:01:37.611+0200 I/LOCATION(22526): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:37.611+0200 I/LOCATION(22526): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7848c18
04-23 16:01:37.611+0200 I/LOCATION(22526): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:37.621+0200 I/location(22526): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:37.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:37.651+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:37:650,70
04-23 16:01:37.661+0200 I/LOCATION(22526): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:37.721+0200 W/LOCATION(22526): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:37.721+0200 W/LOCATION(22526): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:37.721+0200 I/LOCATION(22526): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:37.801+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:37.801+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:37.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:37.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:37.811+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:37.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:37.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:37.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:37.811+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:37.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:37.811+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:37.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:37.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:37.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:37.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:37:850,70
04-23 16:01:37.861+0200 W/LOCATION(22526): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:37.861+0200 W/LOCATION(22526): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:37.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:37.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733aeb8]
04-23 16:01:37.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:37.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:37.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:37.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:37.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:37.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:38.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.011+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:38.011+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:38.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:38.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:38.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:38.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:38.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:38.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:38.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:38.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:38.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:38.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:38.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:38:50,70
04-23 16:01:38.051+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:38.051+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5993710), time2(5987497)
04-23 16:01:38.051+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:38.051+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:38.051+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:38.051+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:38.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:38.081+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:38.091+0200 W/LOCATION(22526): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:38.101+0200 I/LOCATION(22526): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:38.101+0200 I/LOCATION(22526): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:38.101+0200 I/location(22526): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:38.191+0200 I/LOCATION(22526): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:38.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:38.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:38:250,70
04-23 16:01:38.271+0200 W/AUL     (22526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:38.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:38.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22526
04-23 16:01:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:38.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.291+0200 I/utils   (19708): specific action
04-23 16:01:38.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.291+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.291+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:38.291+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:38.291+0200 W/AUL     (22526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:38.291+0200 I/location(22526): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:38.291+0200 W/CAPI_APPFW_APP_CONTROL(22526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.291+0200 I/utils   (22526): specific action
04-23 16:01:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:38.301+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 16:01:38.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:38.311+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:38.311+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:38.311+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:38.321+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:38.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:38.321+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.321+0200 I/utils   (21185): specific action
04-23 16:01:38.321+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.321+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.321+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.321+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:38.321+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:38.321+0200 I/recorder(21185): guardando datos en local
04-23 16:01:38.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:38.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:38.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:38.421+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:38.421+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:38.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:38.451+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:38.451+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:38.451+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:38.461+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:38.461+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:38:466,69
04-23 16:01:38.501+0200 I/LOCATION(22526): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:38.621+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11225266c6f63152449209
