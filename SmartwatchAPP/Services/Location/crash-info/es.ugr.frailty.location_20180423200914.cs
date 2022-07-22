S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7073
Date: 2018-04-23 20:09:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf720052d, r5   = 0xf793c958
r6   = 0xffb01a40, r7   = 0xffb018f0
r8   = 0xf794fc18, r9   = 0x00000000
r10  = 0xffb019cc, fp   = 0xffb01a40
ip   = 0x00000001, sp   = 0xffb018c8
lr   = 0xf7200539, pc   = 0xf7269228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    103676 KB
Buffers:     39768 KB
Cached:     185944 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11952 KB
VmRSS:       11952 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7073 TID = 7073
7073 7076 

Maps Information
f40cb000 f48ca000 rw-p [stack:7076]
f48d1000 f48d3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48db000 f48df000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48e8000 f48ea000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48f2000 f48f5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4904000 f4909000 r-xp /usr/lib/libsystem.so.0.0.0
f4914000 f4917000 r-xp /lib/libattr.so.1.1.0
f491f000 f492f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4937000 f4940000 r-xp /usr/lib/libedbus.so.1.7.99
f4948000 f4949000 r-xp /usr/lib/libresponse.so.0.2.96
f4952000 f4957000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61f9000 f62ff000 r-xp /usr/lib/libicuuc.so.57.1
f6315000 f649d000 r-xp /usr/lib/libicui18n.so.57.1
f64ad000 f64ba000 r-xp /usr/lib/libail.so.0.1.0
f64c3000 f64ca000 r-xp /usr/lib/libminizip.so.1.0.0
f64d3000 f667c000 r-xp /usr/lib/libcrypto.so.1.0.0
f669c000 f66e3000 r-xp /usr/lib/libssl.so.1.0.0
f66ef000 f66f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66f9000 f6700000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6709000 f6710000 r-xp /lib/libcrypt-2.13.so
f6741000 f6744000 r-xp /lib/libcap.so.2.21
f674c000 f674e000 r-xp /usr/lib/libiri.so
f6756000 f679f000 r-xp /usr/lib/libmdm.so.1.2.69
f67a7000 f67ad000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67b5000 f67d8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67e2000 f67e4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67ec000 f6809000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6812000 f6816000 r-xp /usr/lib/libsmack.so.1.0.0
f681f000 f6838000 r-xp /usr/lib/libnetwork.so.0.0.0
f6841000 f6849000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6851000 f6857000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6860000 f6862000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f686b000 f687b000 r-xp /lib/libresolv-2.13.so
f687f000 f6897000 r-xp /usr/lib/liblzma.so.5.0.3
f68a0000 f68a2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68aa000 f68c4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68cc000 f68fb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6904000 f6913000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f691d000 f6927000 r-xp /usr/lib/libsensord-shared.so
f6930000 f6a03000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a0e000 f6a24000 r-xp /lib/libz.so.1.2.5
f6a2c000 f6a31000 r-xp /usr/lib/libffi.so.5.0.10
f6a39000 f6a3a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a42000 f6a52000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a5a000 f6a73000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a7b000 f6a7d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a85000 f6afa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b04000 f6b0a000 r-xp /lib/librt-2.13.so
f6b13000 f6b31000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b3b000 f6b3c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b44000 f6b67000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b6f000 f6b74000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b7c000 f6ba6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6baf000 f6bc6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bce000 f6c37000 r-xp /lib/libm-2.13.so
f6c40000 f6cd4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ce7000 f6cec000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cf4000 f6cfb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d03000 f6d2d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d36000 f6e02000 r-xp /usr/lib/libxml2.so.2.7.8
f6e0f000 f6e11000 r-xp /usr/lib/libiniparser.so.0
f6e1a000 f6e20000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e29000 f6ef9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6efa000 f6f2e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f37000 f6f73000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f7b000 f6f7e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f86000 f6f8c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f94000 f6fd5000 r-xp /usr/lib/libeina.so.1.7.99
f6fde000 f6ff5000 r-xp /usr/lib/libecore.so.1.7.99
f700c000 f7015000 r-xp /usr/lib/libvconf.so.0.2.45
f701d000 f7031000 r-xp /lib/libpthread-2.13.so
f703c000 f7049000 r-xp /usr/lib/libaul.so.0.1.0
f7053000 f7055000 r-xp /lib/libdl-2.13.so
f705e000 f7069000 r-xp /lib/libunwind.so.8.0.1
f7096000 f709e000 r-xp /lib/libgcc_s-4.6.so.1
f709f000 f71c3000 r-xp /lib/libc-2.13.so
f71d1000 f71d3000 r-xp /usr/lib/libdlog.so.0.0.0
f71db000 f71e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71f0000 f71f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71fd000 f720c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7214000 f7218000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7221000 f7224000 r-xp /usr/lib/libappcore-agent.so.1.1
f722c000 f722e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7236000 f723a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7242000 f725f000 r-xp /lib/ld-2.13.so
f7268000 f726b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f726b000 f726f000 r-xp /usr/lib/libsys-assert.so
f791f000 f79a9000 rw-p [heap]
ffae3000 ffb04000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7073)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7269228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7200539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f073f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f4c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f471f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f49e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f4a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f51f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48e91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48dc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69af663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e5cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e5e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6feeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fe9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fea5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fea879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7222183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72227fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72694f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf70b685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7268f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
65) > Fail to get app_id. Err[-1]
04-23 20:09:04.119+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:04.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:04.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:04.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:04.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:04.119+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:04.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:04.119+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:04.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:04.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:04.139+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:04.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:04.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:04.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:04.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:04.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:04.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79ea1c0
04-23 20:09:04.249+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.249+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:254,0.050296,9.772886,0.811511
04-23 20:09:04.249+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.259+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:263,0.049996,9.773082,0.809175
04-23 20:09:04.259+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.269+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:272,0.049139,9.773064,0.809438
04-23 20:09:04.289+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.299+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:309,0.048900,9.773036,0.809785
04-23 20:09:04.309+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.319+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:321,0.047860,9.773087,0.809248
04-23 20:09:04.339+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.379+0200 W/AUL     ( 7034): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:09:04.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:04.379+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:04.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6999
04-23 20:09:04.379+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:04.379+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6999
04-23 20:09:04.379+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6999)
04-23 20:09:04.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:351,0.048128,9.773103,0.809030
04-23 20:09:04.389+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:407,0.048944,9.772989,0.810351
04-23 20:09:04.409+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:416,0.048937,9.773123,0.808736
04-23 20:09:04.419+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.419+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:428,0.047903,9.772999,0.810295
04-23 20:09:04.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.439+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:446,0.047707,9.772933,0.811098
04-23 20:09:04.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:451,0.046383,9.772844,0.812249
04-23 20:09:04.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:458,0.045354,9.772737,0.813596
04-23 20:09:04.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.459+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:468,0.046977,9.772910,0.811423
04-23 20:09:04.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:472,0.050110,9.773070,0.809303
04-23 20:09:04.469+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:476,0.051302,9.773221,0.807401
04-23 20:09:04.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:483,0.051172,9.773270,0.806824
04-23 20:09:04.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:489,0.050706,9.773262,0.806951
04-23 20:09:04.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:498,0.051303,9.773352,0.805826
04-23 20:09:04.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:503,0.053416,9.773355,0.805633
04-23 20:09:04.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:508,0.053653,9.773419,0.804852
04-23 20:09:04.509+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:517,0.056136,9.773524,0.803408
04-23 20:09:04.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:524,0.056249,9.773580,0.802725
04-23 20:09:04.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:533,0.057012,9.773669,0.801574
04-23 20:09:04.529+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.539+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:539,0.056711,9.773715,0.801041
04-23 20:09:04.539+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.539+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:548,0.056896,9.773815,0.799804
04-23 20:09:04.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:559,0.058087,9.773767,0.800315
04-23 20:09:04.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:564,0.058770,9.773682,0.801296
04-23 20:09:04.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:569,0.061150,9.773805,0.799619
04-23 20:09:04.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:576,0.060209,9.773805,0.799692
04-23 20:09:04.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:586,0.059542,9.773858,0.799087
04-23 20:09:04.589+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:594,0.060543,9.774307,0.793497
04-23 20:09:04.589+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:599,0.057953,9.774215,0.794828
04-23 20:09:04.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:606,0.056845,9.774110,0.796199
04-23 20:09:04.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:613,0.055528,9.774039,0.797150
04-23 20:09:04.609+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:619,0.053976,9.775012,0.785246
04-23 20:09:04.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:775,0.046503,9.774671,0.789965
04-23 20:09:04.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:04.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:04:975,0.055897,9.774357,0.793226
04-23 20:09:05.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:05.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:05:175,0.056681,9.772928,0.810579
04-23 20:09:05.259+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:09:05.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:05.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:05:374,0.050029,9.773303,0.806490
04-23 20:09:05.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:05.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:05:574,0.060913,9.774836,0.786936
04-23 20:09:05.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:05.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:05:774,0.070244,9.774079,0.795501
04-23 20:09:05.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:05.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:05:974,0.059019,9.774675,0.789067
04-23 20:09:06.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:06.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:06:174,0.042726,9.774498,0.792309
04-23 20:09:06.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:06.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:06:374,0.035194,9.773811,0.801096
04-23 20:09:06.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:06.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:06:576,0.039590,9.773170,0.808672
04-23 20:09:06.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:06.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:06:776,0.051214,9.772916,0.811092
04-23 20:09:06.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:06.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:06:974,0.067960,9.771235,0.829908
04-23 20:09:07.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:07.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:07:173,0.067379,9.771530,0.826467
04-23 20:09:07.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:07.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:07:376,0.066700,9.772919,0.809941
04-23 20:09:07.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:07.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:07:585,0.048676,9.772231,0.819454
04-23 20:09:07.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:07.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:07:774,0.054838,9.771621,0.826318
04-23 20:09:07.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:07.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:07:974,0.058363,9.772853,0.811370
04-23 20:09:08.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:08.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:08:174,0.052687,9.772304,0.818347
04-23 20:09:08.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:08.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:08:374,0.046478,9.772953,0.810931
04-23 20:09:08.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:08.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:08:575,0.044767,9.773079,0.809509
04-23 20:09:08.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:08.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:08:773,0.052393,9.772985,0.810197
04-23 20:09:08.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:08.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:08:973,0.049519,9.772629,0.814654
04-23 20:09:09.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:09.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:09:183,0.058000,9.773633,0.801947
04-23 20:09:09.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:09.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:09:373,0.048364,9.773827,0.800220
04-23 20:09:09.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:09.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:09:573,0.035626,9.772750,0.813923
04-23 20:09:09.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:09.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:09:773,0.033491,9.772346,0.818846
04-23 20:09:09.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:09.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:09:973,0.044131,9.773792,0.800893
04-23 20:09:10.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:10.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:10:173,0.050428,9.774264,0.794726
04-23 20:09:10.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:10.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:10:373,0.065678,9.774295,0.793242
04-23 20:09:10.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:10.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:10:573,0.061500,9.773859,0.798922
04-23 20:09:10.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:10.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:10:772,0.065031,9.774256,0.793781
04-23 20:09:10.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:10.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:10:973,0.058636,9.773785,0.800049
04-23 20:09:11.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:11.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:11:173,0.049798,9.772349,0.817977
04-23 20:09:11.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:11.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:11:372,0.060866,9.771922,0.822326
04-23 20:09:11.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:11.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:11:573,0.056759,9.771392,0.828896
04-23 20:09:11.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:11.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:11:772,0.060696,9.771707,0.824895
04-23 20:09:11.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:11.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:11:972,0.059834,9.771768,0.824236
04-23 20:09:12.009+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:09:12.009+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:09:12.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:12.009+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:12.019+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:09:12.019+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7073
04-23 20:09:12.069+0200 E/CAPI_APPFW_APPLICATION( 7073): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:12.069+0200 E/CAPI_APPFW_APPLICATION( 7073): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:12.069+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7073
04-23 20:09:12.069+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7073) type(svcapp) bg(0)
04-23 20:09:12.069+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7073) was created
04-23 20:09:12.069+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7073)
04-23 20:09:12.069+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:09:12.069+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:12.079+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7073]
04-23 20:09:12.099+0200 W/LOCATION( 7073): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:09:12.099+0200 E/LOCATION( 7073): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:09:12.099+0200 E/PKGMGR_INFO( 7073): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:09:12.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:12.109+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:12.109+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7073
04-23 20:09:12.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:12.119+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7073
04-23 20:09:12.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:12.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:12.119+0200 I/LOCATION( 7073): location.c: location_new(269) > method: 0
04-23 20:09:12.129+0200 W/LOCATION( 7073): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:12.129+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:12.129+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:12.139+0200 W/LOCATION( 7073): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:12.139+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:12.139+0200 W/LOCATION( 7073): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:12.139+0200 W/LOCATION( 7073): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:12.139+0200 W/LOCATION( 7073): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:12.139+0200 W/LOCATION( 7073): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:12.159+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:12.169+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:12.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:12.169+0200 W/LOCATION( 7073): module-internal.c: module_new(311) > module (wps) open success
04-23 20:09:12.169+0200 W/LOCATION( 7073): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:09:12.169+0200 W/LOCATION( 7073): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:09:12.169+0200 W/LOCATION( 7073): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:12.169+0200 W/LOCATION( 7073): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:12.189+0200 W/LOCATION( 7073): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:09:12.189+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:12:176,0.055213,9.772060,0.821074
04-23 20:09:12.189+0200 I/LOCATION( 7073): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf794fc18
04-23 20:09:12.189+0200 I/LOCATION( 7073): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:09:12.189+0200 I/LOCATION( 7073): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf794fc18
04-23 20:09:12.189+0200 I/LOCATION( 7073): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:09:12.199+0200 I/location( 7073): es.ugr.frailty.location: creado servicio de localización
04-23 20:09:12.239+0200 I/LOCATION( 7073): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:09:12.279+0200 W/LOCATION( 7073): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:12.279+0200 W/LOCATION( 7073): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:12.279+0200 I/LOCATION( 7073): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:09:12.339+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:09:12.339+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:12.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:12.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:09:12.339+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:09:12.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:09:12.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:09:12.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:09:12.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:09:12.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:09:12.349+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:09:12.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:09:12.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:09:12.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:12.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:12:373,0.046881,9.773452,0.804877
04-23 20:09:12.399+0200 W/LOCATION( 7073): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:12.399+0200 W/LOCATION( 7073): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:12.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:12.519+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a0e728]
04-23 20:09:12.519+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:12.519+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:12.519+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:12.519+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:12.519+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:12.519+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:12.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:12.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:12.539+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:12.539+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:12.549+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:12.549+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:12.549+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:12.549+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:12.549+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:12.549+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:12.549+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:12.559+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:12.559+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:12.559+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:12.569+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:12.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:12.589+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:09:12.589+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1027852), time2(1014722)
04-23 20:09:12.589+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:09:12.589+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:09:12.589+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:09:12.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:09:12.609+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:12.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:12:573,0.053316,9.774837,0.787476
04-23 20:09:12.639+0200 W/LOCATION( 7073): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:12.639+0200 I/LOCATION( 7073): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:12.639+0200 I/LOCATION( 7073): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:12.639+0200 I/location( 7073): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:09:12.729+0200 I/LOCATION( 7073): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:12.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:12.779+0200 E/location( 7073): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:09:12.779+0200 W/AUL     ( 7073): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:12.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:12.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7073
04-23 20:09:12.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:12.789+0200 W/AUL     ( 7073): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:12.789+0200 I/location( 7073): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:12.789+0200 W/CAPI_APPFW_APP_CONTROL( 7073): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.789+0200 I/utils   ( 7073): specific action
04-23 20:09:12.789+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:12.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:12.789+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.789+0200 I/utils   ( 5532): specific action
04-23 20:09:12.789+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.789+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.789+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.789+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:12.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:12.799+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:12.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:12.809+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:12.809+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:12.809+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:12.809+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:12.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:09:12.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.809+0200 I/utils   ( 5538): specific action
04-23 20:09:12.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.809+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:12.809+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:09:12.809+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:12.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:12:774,0.055211,9.775502,0.779035
04-23 20:09:12.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:12.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:12:973,0.059802,9.776298,0.768638
04-23 20:09:13.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:173,0.065661,9.775679,0.776008
04-23 20:09:13.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:13.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:13.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:13.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:374,0.058275,9.775553,0.778178
04-23 20:09:13.389+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:393,0.056433,9.775551,0.778330
04-23 20:09:13.409+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:413,0.055278,9.775423,0.780016
04-23 20:09:13.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:434,0.056681,9.775171,0.783069
04-23 20:09:13.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:454,0.057081,9.775105,0.783877
04-23 20:09:13.509+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:523,0.054640,9.775009,0.785240
04-23 20:09:13.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:531,0.053893,9.774950,0.786026
04-23 20:09:13.529+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:542,0.054891,9.775022,0.785063
04-23 20:09:13.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:558,0.055603,9.774981,0.785518
04-23 20:09:13.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:586,0.056407,9.775045,0.784664
04-23 20:09:13.599+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:09:13.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:609,0.056378,9.775243,0.782196
04-23 20:09:13.609+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:614,0.054073,9.775139,0.783664
04-23 20:09:13.609+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:618,0.054023,9.775112,0.783997
04-23 20:09:13.629+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:633,0.056035,9.775073,0.784339
04-23 20:09:13.649+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:654,0.056806,9.774929,0.786074
04-23 20:09:13.669+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.669+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:673,0.057596,9.774945,0.785823
04-23 20:09:13.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:693,0.058869,9.774867,0.786702
04-23 20:09:13.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:717,0.056902,9.774772,0.788029
04-23 20:09:13.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:734,0.056150,9.774799,0.787736
04-23 20:09:13.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:756,0.054875,9.774681,0.789298
04-23 20:09:13.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:773,0.052680,9.774446,0.792336
04-23 20:09:13.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.789+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:794,0.053166,9.774564,0.790857
04-23 20:09:13.809+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:822,0.053176,9.774522,0.791383
04-23 20:09:13.819+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.829+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:833,0.052606,9.774517,0.791470
04-23 20:09:13.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.849+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:855,0.050783,9.774573,0.790894
04-23 20:09:13.869+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.869+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:873,0.052383,9.774647,0.789888
04-23 20:09:13.879+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.889+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:893,0.052990,9.774588,0.790580
04-23 20:09:13.909+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.909+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:913,0.051988,9.774483,0.791934
04-23 20:09:13.929+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.929+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:934,0.052721,9.774476,0.791974
04-23 20:09:13.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:13.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:954,0.051969,9.774295,0.794252
04-23 20:09:13.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.009+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:13:982,0.051576,9.774274,0.794542
04-23 20:09:14.039+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.039+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:43,0.050857,9.774311,0.794124
04-23 20:09:14.039+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.039+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:47,0.051879,9.774292,0.794294
04-23 20:09:14.039+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.049+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:51,0.050364,9.774151,0.796132
04-23 20:09:14.049+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.049+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:55,0.051188,9.774243,0.794944
04-23 20:09:14.069+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:73,0.053864,9.774108,0.796423
04-23 20:09:14.089+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.089+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:93,0.053826,9.774140,0.796029
04-23 20:09:14.109+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.109+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:113,0.053795,9.774046,0.797193
04-23 20:09:14.119+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.129+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:133,0.052971,9.774094,0.796660
04-23 20:09:14.149+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:154,0.051837,9.774117,0.796449
04-23 20:09:14.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:173,0.052927,9.774088,0.796737
04-23 20:09:14.189+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.189+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:193,0.053173,9.774160,0.795829
04-23 20:09:14.209+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.209+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:214,0.053637,9.774227,0.794978
04-23 20:09:14.229+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.229+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:233,0.051812,9.774155,0.795994
04-23 20:09:14.249+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.249+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:254,0.051770,9.774091,0.796782
04-23 20:09:14.269+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.269+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:273,0.054213,9.774131,0.796119
04-23 20:09:14.289+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.309+0200 W/LOCATION( 7073): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:09:14.329+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:302,0.056658,9.774296,0.793927
04-23 20:09:14.329+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.329+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:338,0.055576,9.774221,0.794915
04-23 20:09:14.329+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:14.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:14.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:14.339+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:342,0.054783,9.774188,0.795376
04-23 20:09:14.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:355,0.054821,9.774158,0.795755
04-23 20:09:14.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:374,0.056635,9.774108,0.796238
04-23 20:09:14.389+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:394,0.056366,9.773978,0.797844
04-23 20:09:14.409+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:414,0.057147,9.773867,0.799159
04-23 20:09:14.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:434,0.057305,9.773892,0.798835
04-23 20:09:14.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:455,0.057238,9.773725,0.800888
04-23 20:09:14.469+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:474,0.057392,9.773743,0.800655
04-23 20:09:14.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:494,0.056724,9.773841,0.799504
04-23 20:09:14.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:526,0.055992,9.773701,0.801260
04-23 20:09:14.529+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:14.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:14:535,0.055636,9.773650,0.801902
04-23 20:09:14.539+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11070736c6f63152450695
