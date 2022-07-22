S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11152
Date: 2018-04-23 20:36:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75b452d, r5   = 0xf7960958
r6   = 0xfff79100, r7   = 0xfff78fb0
r8   = 0xf7973c18, r9   = 0x00000000
r10  = 0xfff7908c, fp   = 0xfff79100
ip   = 0x00000001, sp   = 0xfff78f88
lr   = 0xf75b4539, pc   = 0xf761d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    116272 KB
Buffers:     38228 KB
Cached:     158540 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11660 KB
VmRSS:       11660 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11152 TID = 11152
11152 11155 

Maps Information
f447f000 f4c7e000 rw-p [stack:11155]
f4c85000 f4c87000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c8f000 f4c93000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c9c000 f4c9e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ca6000 f4ca9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cb8000 f4cbd000 r-xp /usr/lib/libsystem.so.0.0.0
f4cc8000 f4ccb000 r-xp /lib/libattr.so.1.1.0
f4cd3000 f4ce3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ceb000 f4cf4000 r-xp /usr/lib/libedbus.so.1.7.99
f4cfc000 f4cfd000 r-xp /usr/lib/libresponse.so.0.2.96
f4d06000 f4d0b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65ad000 f66b3000 r-xp /usr/lib/libicuuc.so.57.1
f66c9000 f6851000 r-xp /usr/lib/libicui18n.so.57.1
f6861000 f686e000 r-xp /usr/lib/libail.so.0.1.0
f6877000 f687e000 r-xp /usr/lib/libminizip.so.1.0.0
f6887000 f6a30000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a50000 f6a97000 r-xp /usr/lib/libssl.so.1.0.0
f6aa3000 f6aa5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aad000 f6ab4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6abd000 f6ac4000 r-xp /lib/libcrypt-2.13.so
f6af5000 f6af8000 r-xp /lib/libcap.so.2.21
f6b00000 f6b02000 r-xp /usr/lib/libiri.so
f6b0a000 f6b53000 r-xp /usr/lib/libmdm.so.1.2.69
f6b5b000 f6b61000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b69000 f6b8c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b96000 f6b98000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ba0000 f6bbd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bc6000 f6bca000 r-xp /usr/lib/libsmack.so.1.0.0
f6bd3000 f6bec000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bf5000 f6bfd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c05000 f6c0b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c14000 f6c16000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c1f000 f6c2f000 r-xp /lib/libresolv-2.13.so
f6c33000 f6c4b000 r-xp /usr/lib/liblzma.so.5.0.3
f6c54000 f6c56000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c5e000 f6c78000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c80000 f6caf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cb8000 f6cc7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cd1000 f6cdb000 r-xp /usr/lib/libsensord-shared.so
f6ce4000 f6db7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dc2000 f6dd8000 r-xp /lib/libz.so.1.2.5
f6de0000 f6de5000 r-xp /usr/lib/libffi.so.5.0.10
f6ded000 f6dee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6df6000 f6e06000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e0e000 f6e27000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e2f000 f6e31000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e39000 f6eae000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eb8000 f6ebe000 r-xp /lib/librt-2.13.so
f6ec7000 f6ee5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eef000 f6ef0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ef8000 f6f1b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f23000 f6f28000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f30000 f6f5a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f63000 f6f7a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f82000 f6feb000 r-xp /lib/libm-2.13.so
f6ff4000 f7088000 r-xp /usr/lib/libstdc++.so.6.0.16
f709b000 f70a0000 r-xp /usr/lib/libctx-client.so.0.8.3
f70a8000 f70af000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70b7000 f70e1000 r-xp /usr/lib/libsensor.so.1.9.6
f70ea000 f71b6000 r-xp /usr/lib/libxml2.so.2.7.8
f71c3000 f71c5000 r-xp /usr/lib/libiniparser.so.0
f71ce000 f71d4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71dd000 f72ad000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72ae000 f72e2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72eb000 f7327000 r-xp /usr/lib/libSLP-location.so.0.9.24
f732f000 f7332000 r-xp /usr/lib/libbundle.so.0.1.22
f733a000 f7340000 r-xp /usr/lib/libappsvc.so.0.1.0
f7348000 f7389000 r-xp /usr/lib/libeina.so.1.7.99
f7392000 f73a9000 r-xp /usr/lib/libecore.so.1.7.99
f73c0000 f73c9000 r-xp /usr/lib/libvconf.so.0.2.45
f73d1000 f73e5000 r-xp /lib/libpthread-2.13.so
f73f0000 f73fd000 r-xp /usr/lib/libaul.so.0.1.0
f7407000 f7409000 r-xp /lib/libdl-2.13.so
f7412000 f741d000 r-xp /lib/libunwind.so.8.0.1
f744a000 f7452000 r-xp /lib/libgcc_s-4.6.so.1
f7453000 f7577000 r-xp /lib/libc-2.13.so
f7585000 f7587000 r-xp /usr/lib/libdlog.so.0.0.0
f758f000 f759b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75a4000 f75a9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75b1000 f75c0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75c8000 f75cc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75d5000 f75d8000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e0000 f75e2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75ea000 f75ee000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75f6000 f7613000 r-xp /lib/ld-2.13.so
f761c000 f761f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f761f000 f7623000 r-xp /usr/lib/libsys-assert.so
f7943000 f79c6000 rw-p [heap]
fff5a000 fff7b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11152)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf761d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75b4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72bb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72b9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72c5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72cbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72cbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf730075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72fb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72b9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72c5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72cbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72cbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72fde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72fe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7305f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c9d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c90171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d63663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7210fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72127a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73a2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf739db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf739e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf739e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75d6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75d67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf761d53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf746a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf761cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:35.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:35.229+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c09cd8
04-23 20:36:35.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c246e8]
04-23 20:36:35.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:35.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:35.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:35.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:35.279+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:35.279+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:35.289+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:35.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:35.299+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:35.299+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:35.299+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:35.299+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:35.299+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:35.299+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:35.299+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:35.299+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:35.299+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:35.299+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:35.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:35:303,0.031748,9.765486,0.897031
04-23 20:36:35.309+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:35.309+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:35.309+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:35.309+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:35.359+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:35.369+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:36:35.369+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:36:35.369+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:36:35.369+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c246e8
04-23 20:36:35.489+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:35.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:35:502,0.035879,9.764549,0.907017
04-23 20:36:35.559+0200 W/AUL     (11114): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:36:35.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:36:35.569+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:36:35.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11081
04-23 20:36:35.569+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:36:35.569+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11081
04-23 20:36:35.569+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11081)
04-23 20:36:35.689+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:35.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:35:703,0.024239,9.759855,0.956563
04-23 20:36:35.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:35.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:35:903,0.026981,9.761855,0.935861
04-23 20:36:36.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:36.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:36:102,0.031719,9.767001,0.880383
04-23 20:36:36.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:36.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:36:303,0.041239,9.769357,0.853441
04-23 20:36:36.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:36.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:36:503,0.035686,9.769187,0.855631
04-23 20:36:36.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:36.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:36:703,0.046343,9.770315,0.842132
04-23 20:36:36.769+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:36:36.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:36.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:36:903,0.049716,9.772609,0.814882
04-23 20:36:37.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:37.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:37:103,0.053515,9.772986,0.810094
04-23 20:36:37.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:37.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:37:303,0.040087,9.773667,0.802627
04-23 20:36:37.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:37.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:37:503,0.032713,9.774981,0.786798
04-23 20:36:37.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:37.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:37:704,0.028609,9.776402,0.769111
04-23 20:36:37.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:37.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:37:904,0.033894,9.776538,0.767160
04-23 20:36:38.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:38.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:38:104,0.037958,9.774067,0.797847
04-23 20:36:38.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:38.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:38:305,0.033815,9.771238,0.831948
04-23 20:36:38.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:38.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:38:504,0.039478,9.771667,0.826642
04-23 20:36:38.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:38.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:38:704,0.031360,9.771132,0.833305
04-23 20:36:38.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:38.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:38:904,0.029913,9.770319,0.842828
04-23 20:36:39.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:39.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:39:103,0.031328,9.770774,0.837482
04-23 20:36:39.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:39.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:39:304,0.038650,9.771762,0.825565
04-23 20:36:39.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:39.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:39:504,0.038971,9.772829,0.812817
04-23 20:36:39.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:39.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:39:704,0.023415,9.773587,0.804260
04-23 20:36:39.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:39.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:39:903,0.018509,9.774798,0.789528
04-23 20:36:40.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:40.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:40:105,0.029505,9.774142,0.797279
04-23 20:36:40.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:40.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:40:308,0.024670,9.772462,0.817785
04-23 20:36:40.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:40.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:40:504,0.029483,9.771336,0.830976
04-23 20:36:40.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:40.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:40:709,0.041031,9.772190,0.820364
04-23 20:36:40.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:40.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:40:904,0.051615,9.773231,0.807275
04-23 20:36:41.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:41.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:41:103,0.050500,9.772668,0.814128
04-23 20:36:41.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:41.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:41:305,0.051523,9.773582,0.803021
04-23 20:36:41.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:41.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:41:505,0.043799,9.774799,0.788525
04-23 20:36:41.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:41.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:41:705,0.029839,9.776030,0.773786
04-23 20:36:41.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:41.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:41:905,0.028357,9.777207,0.758812
04-23 20:36:42.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:42.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:42:104,0.027368,9.778418,0.743096
04-23 20:36:42.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:42.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:42:305,0.016521,9.779778,0.725290
04-23 20:36:42.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:42.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:42:505,0.018373,9.776440,0.768938
04-23 20:36:42.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:42.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:42:705,0.028330,9.773755,0.802051
04-23 20:36:42.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:42.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:42:905,0.043130,9.773921,0.799374
04-23 20:36:43.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:43.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:43:104,0.050432,9.773353,0.805861
04-23 20:36:43.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:43.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:43:304,0.054805,9.771974,0.822136
04-23 20:36:43.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:43.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:43:504,0.056139,9.770949,0.834138
04-23 20:36:43.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:43.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:43:705,0.057517,9.772391,0.816973
04-23 20:36:43.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:43.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:43:904,0.055565,9.773871,0.799203
04-23 20:36:44.079+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:36:44.079+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:36:44.089+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:44.089+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:44.119+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11152
04-23 20:36:44.119+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:36:44.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:44.169+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11152
04-23 20:36:44.169+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11152) type(svcapp) bg(0)
04-23 20:36:44.169+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:44:152,0.039154,9.774682,0.790220
04-23 20:36:44.169+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11152)
04-23 20:36:44.169+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:36:44.169+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:44.179+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11152]
04-23 20:36:44.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:44.199+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11152
04-23 20:36:44.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:44.209+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11152
04-23 20:36:44.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:44.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:44.229+0200 E/CAPI_APPFW_APPLICATION(11152): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:44.229+0200 E/CAPI_APPFW_APPLICATION(11152): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:44.229+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11152) was created
04-23 20:36:44.249+0200 W/LOCATION(11152): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:36:44.249+0200 E/LOCATION(11152): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:36:44.249+0200 E/PKGMGR_INFO(11152): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:36:44.259+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:44.279+0200 I/LOCATION(11152): location.c: location_new(269) > method: 0
04-23 20:36:44.279+0200 W/LOCATION(11152): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:44.279+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:44.289+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:44.289+0200 W/LOCATION(11152): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:44.289+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:44.299+0200 W/LOCATION(11152): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:44.299+0200 W/LOCATION(11152): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:44.299+0200 W/LOCATION(11152): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:44.299+0200 W/LOCATION(11152): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:44.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:44.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:44:305,0.034577,9.775310,0.782632
04-23 20:36:44.319+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:44.319+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:44.319+0200 W/LOCATION(11152): module-internal.c: module_new(311) > module (wps) open success
04-23 20:36:44.329+0200 W/LOCATION(11152): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:36:44.329+0200 W/LOCATION(11152): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:36:44.329+0200 W/LOCATION(11152): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:44.329+0200 W/LOCATION(11152): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:44.349+0200 W/LOCATION(11152): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:36:44.349+0200 I/LOCATION(11152): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7973c18
04-23 20:36:44.349+0200 I/LOCATION(11152): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:36:44.349+0200 I/LOCATION(11152): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7973c18
04-23 20:36:44.349+0200 I/LOCATION(11152): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:36:44.349+0200 I/location(11152): es.ugr.frailty.location: creado servicio de localización
04-23 20:36:44.399+0200 I/LOCATION(11152): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:36:44.449+0200 W/LOCATION(11152): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:44.449+0200 W/LOCATION(11152): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:44.449+0200 I/LOCATION(11152): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:44.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:44.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:44:504,0.044191,9.775883,0.774947
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:36:44.509+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:36:44.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:36:44.509+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:36:44.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:36:44.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:36:44.509+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:44.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:44.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:36:44.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:36:44.509+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:36:44.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:36:44.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:36:44.559+0200 W/LOCATION(11152): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:44.559+0200 W/LOCATION(11152): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:44.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:44.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72d9a10]
04-23 20:36:44.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:44.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:44.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:44.659+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:44.669+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:44.669+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:44.679+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:44.689+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:44.689+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:44.689+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:44.689+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:44.689+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:44.689+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:44.689+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:44.689+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:44.689+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:44.689+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:44.689+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:44.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:44.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:44:705,0.028935,9.774048,0.798462
04-23 20:36:44.699+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:44.699+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:44.709+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:44.739+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:36:44.739+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2680006), time2(2666745)
04-23 20:36:44.739+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:36:44.739+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:36:44.739+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:36:44.739+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:36:44.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:44.779+0200 W/LOCATION(11152): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:44.779+0200 I/LOCATION(11152): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:44.779+0200 I/LOCATION(11152): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:44.779+0200 I/location(11152): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:36:44.869+0200 I/LOCATION(11152): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:44.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:44.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:44:905,0.024948,9.773253,0.808255
04-23 20:36:44.939+0200 W/AUL     (11152): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:44.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:44.939+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11152
04-23 20:36:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:44.959+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.959+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:44.959+0200 W/AUL     (11152): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:44.959+0200 I/utils   (10115): specific action
04-23 20:36:44.959+0200 I/location(11152): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:44.959+0200 I/location(11152): es.ugr.frailty.location: SM-R760,23/04/2018,20:36:44:944,nan,37.171445,-3.595179,0.000000,0,0.000000,53.000000,-1.000000
04-23 20:36:44.959+0200 W/CAPI_APPFW_APP_CONTROL(11152): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.959+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.959+0200 I/utils   (11152): specific action
04-23 20:36:44.959+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.959+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.959+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:44.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:44.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:44.979+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:44.979+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:44.979+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.979+0200 I/utils   (10120): specific action
04-23 20:36:44.979+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.979+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.979+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.979+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:44.979+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:36:44.979+0200 I/recorder(10120): guardando datos en local
04-23 20:36:44.979+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:44.979+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:44.979+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:45.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:45.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:45.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:45.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:112,0.030281,9.771801,0.825451
04-23 20:36:45.119+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.129+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:127,0.030233,9.771784,0.825662
04-23 20:36:45.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:145,0.029305,9.771612,0.827724
04-23 20:36:45.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:165,0.028884,9.771316,0.831229
04-23 20:36:45.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.189+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:186,0.028579,9.771076,0.834045
04-23 20:36:45.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.209+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:207,0.029472,9.771121,0.833493
04-23 20:36:45.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:224,0.027305,9.770855,0.836684
04-23 20:36:45.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:246,0.026616,9.770706,0.838435
04-23 20:36:45.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:268,0.027327,9.770832,0.836942
04-23 20:36:45.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.279+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:285,0.027699,9.770537,0.840372
04-23 20:36:45.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:307,0.028364,9.770712,0.838316
04-23 20:36:45.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.329+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:327,0.029435,9.770679,0.838659
04-23 20:36:45.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.339+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:345,0.029319,9.770610,0.839467
04-23 20:36:45.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.369+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:366,0.030608,9.770466,0.841101
04-23 20:36:45.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:385,0.031061,9.770526,0.840382
04-23 20:36:45.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:405,0.031794,9.770668,0.838699
04-23 20:36:45.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.429+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:427,0.031695,9.770669,0.838693
04-23 20:36:45.439+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.449+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:448,0.032199,9.770403,0.841763
04-23 20:36:45.459+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.469+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:467,0.032987,9.770558,0.839933
04-23 20:36:45.479+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:485,0.032811,9.770437,0.841352
04-23 20:36:45.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:507,0.033087,9.770312,0.842785
04-23 20:36:45.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:525,0.033397,9.770176,0.844347
04-23 20:36:45.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:545,0.034016,9.770257,0.843388
04-23 20:36:45.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:568,0.032231,9.769988,0.846572
04-23 20:36:45.579+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.589+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:591,0.034133,9.770092,0.845295
04-23 20:36:45.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.609+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:610,0.034258,9.770266,0.843283
04-23 20:36:45.619+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.629+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:625,0.034722,9.770412,0.841558
04-23 20:36:45.639+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.649+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:644,0.034705,9.770423,0.841441
04-23 20:36:45.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:668,0.036265,9.770599,0.839322
04-23 20:36:45.679+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:689,0.036605,9.770406,0.841554
04-23 20:36:45.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:710,0.036247,9.770379,0.841877
04-23 20:36:45.719+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:724,0.033766,9.770128,0.844889
04-23 20:36:45.739+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.749+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:744,0.033945,9.770577,0.839670
04-23 20:36:45.759+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.759+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:764,0.034334,9.770930,0.835543
04-23 20:36:45.779+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:784,0.035283,9.771344,0.830642
04-23 20:36:45.799+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.799+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:36:45.799+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:804,0.035267,9.771499,0.828824
04-23 20:36:45.819+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:824,0.036156,9.771721,0.826161
04-23 20:36:45.839+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.839+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:843,0.037376,9.772218,0.820216
04-23 20:36:45.859+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.869+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:868,0.036803,9.772445,0.817525
04-23 20:36:45.879+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:884,0.036372,9.772856,0.812623
04-23 20:36:45.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:904,0.035841,9.773045,0.810366
04-23 20:36:45.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.929+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:927,0.034778,9.773110,0.809625
04-23 20:36:45.939+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.939+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:946,0.033999,9.773073,0.810110
04-23 20:36:45.959+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.969+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:967,0.033821,9.773399,0.806168
04-23 20:36:45.979+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.989+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:45:988,0.035890,9.773514,0.804687
04-23 20:36:45.999+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:45.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:4,0.034568,9.773293,0.807421
04-23 20:36:46.019+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:25,0.035891,9.773038,0.810447
04-23 20:36:46.049+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.049+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:53,0.036594,9.772895,0.812135
04-23 20:36:46.059+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.069+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:67,0.036137,9.772750,0.813903
04-23 20:36:46.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:46.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:46.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:46.079+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.089+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:92,0.035127,9.772625,0.815442
04-23 20:36:46.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:106,0.033922,9.772559,0.816283
04-23 20:36:46.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.129+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:133,0.033126,9.772407,0.818147
04-23 20:36:46.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:144,0.033652,9.772520,0.816766
04-23 20:36:46.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:165,0.033145,9.772675,0.814932
04-23 20:36:46.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:184,0.033457,9.772954,0.811566
04-23 20:36:46.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:204,0.033710,9.772851,0.812794
04-23 20:36:46.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:225,0.032041,9.772607,0.815791
04-23 20:36:46.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:244,0.031356,9.772498,0.817117
04-23 20:36:46.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:265,0.031374,9.772400,0.818296
04-23 20:36:46.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:287,0.029701,9.772126,0.821612
04-23 20:36:46.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:304,0.029339,9.771998,0.823144
04-23 20:36:46.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:325,0.027998,9.771677,0.827004
04-23 20:36:46.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.349+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:346,0.029899,9.771762,0.825928
04-23 20:36:46.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.359+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:365,0.030338,9.771781,0.825688
04-23 20:36:46.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:384,0.030077,9.771546,0.828474
04-23 20:36:46.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:404,0.030841,9.771605,0.827742
04-23 20:36:46.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.419+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:424,0.031212,9.771425,0.829858
04-23 20:36:46.439+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.449+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:444,0.031339,9.771219,0.832277
04-23 20:36:46.449+0200 W/LOCATION(11152): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:36:46.459+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.469+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:466,0.031381,9.771517,0.828764
04-23 20:36:46.479+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.489+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:492,0.032698,9.771968,0.823384
04-23 20:36:46.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:508,0.032230,9.772122,0.821569
04-23 20:36:46.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:525,0.031788,9.772321,0.819217
04-23 20:36:46.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:544,0.031366,9.772555,0.816429
04-23 20:36:46.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:564,0.032437,9.772715,0.814480
04-23 20:36:46.579+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:584,0.032783,9.772978,0.811303
04-23 20:36:46.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.609+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:612,0.033809,9.773330,0.807013
04-23 20:36:46.619+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:623,0.034403,9.773018,0.810750
04-23 20:36:46.639+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:644,0.033277,9.772820,0.813173
04-23 20:36:46.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:664,0.032992,9.772625,0.815531
04-23 20:36:46.679+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:46.689+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:46:691,0.035054,9.773047,0.810365
04-23 20:36:46.689+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11111526c6f63152450860
