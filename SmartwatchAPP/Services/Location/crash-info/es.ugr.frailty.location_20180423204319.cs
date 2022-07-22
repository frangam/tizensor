S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13079
Date: 2018-04-23 20:43:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf700052d, r5   = 0xf7114f98
r6   = 0xffe8dda0, r7   = 0xffe8dc50
r8   = 0xf7111c18, r9   = 0x00000000
r10  = 0xffe8dd2c, fp   = 0xffe8dda0
ip   = 0x00000001, sp   = 0xffe8dc28
lr   = 0xf7000539, pc   = 0xf7069228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    101332 KB
Buffers:     41116 KB
Cached:     161876 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11852 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13079 TID = 13079
13079 13082 

Maps Information
f3ecb000 f46ca000 rw-p [stack:13082]
f46d1000 f46d3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46db000 f46df000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46e8000 f46ea000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46f2000 f46f5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4704000 f4709000 r-xp /usr/lib/libsystem.so.0.0.0
f4714000 f4717000 r-xp /lib/libattr.so.1.1.0
f471f000 f472f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4737000 f4740000 r-xp /usr/lib/libedbus.so.1.7.99
f4748000 f4749000 r-xp /usr/lib/libresponse.so.0.2.96
f4752000 f4757000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5ff9000 f60ff000 r-xp /usr/lib/libicuuc.so.57.1
f6115000 f629d000 r-xp /usr/lib/libicui18n.so.57.1
f62ad000 f62ba000 r-xp /usr/lib/libail.so.0.1.0
f62c3000 f62ca000 r-xp /usr/lib/libminizip.so.1.0.0
f62d3000 f647c000 r-xp /usr/lib/libcrypto.so.1.0.0
f649c000 f64e3000 r-xp /usr/lib/libssl.so.1.0.0
f64ef000 f64f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64f9000 f6500000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6509000 f6510000 r-xp /lib/libcrypt-2.13.so
f6541000 f6544000 r-xp /lib/libcap.so.2.21
f654c000 f654e000 r-xp /usr/lib/libiri.so
f6556000 f659f000 r-xp /usr/lib/libmdm.so.1.2.69
f65a7000 f65ad000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65b5000 f65d8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65e2000 f65e4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65ec000 f6609000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6612000 f6616000 r-xp /usr/lib/libsmack.so.1.0.0
f661f000 f6638000 r-xp /usr/lib/libnetwork.so.0.0.0
f6641000 f6649000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6651000 f6657000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6660000 f6662000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f666b000 f667b000 r-xp /lib/libresolv-2.13.so
f667f000 f6697000 r-xp /usr/lib/liblzma.so.5.0.3
f66a0000 f66a2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66aa000 f66c4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66cc000 f66fb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6704000 f6713000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f671d000 f6727000 r-xp /usr/lib/libsensord-shared.so
f6730000 f6803000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f680e000 f6824000 r-xp /lib/libz.so.1.2.5
f682c000 f6831000 r-xp /usr/lib/libffi.so.5.0.10
f6839000 f683a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6842000 f6852000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f685a000 f6873000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f687b000 f687d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6885000 f68fa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6904000 f690a000 r-xp /lib/librt-2.13.so
f6913000 f6931000 r-xp /usr/lib/libsystemd.so.0.4.0
f693b000 f693c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6944000 f6967000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f696f000 f6974000 r-xp /usr/lib/libxdgmime.so.1.1.0
f697c000 f69a6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69af000 f69c6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69ce000 f6a37000 r-xp /lib/libm-2.13.so
f6a40000 f6ad4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ae7000 f6aec000 r-xp /usr/lib/libctx-client.so.0.8.3
f6af4000 f6afb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b03000 f6b2d000 r-xp /usr/lib/libsensor.so.1.9.6
f6b36000 f6c02000 r-xp /usr/lib/libxml2.so.2.7.8
f6c0f000 f6c11000 r-xp /usr/lib/libiniparser.so.0
f6c1a000 f6c20000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c29000 f6cf9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cfa000 f6d2e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d37000 f6d73000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d7b000 f6d7e000 r-xp /usr/lib/libbundle.so.0.1.22
f6d86000 f6d8c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d94000 f6dd5000 r-xp /usr/lib/libeina.so.1.7.99
f6dde000 f6df5000 r-xp /usr/lib/libecore.so.1.7.99
f6e0c000 f6e15000 r-xp /usr/lib/libvconf.so.0.2.45
f6e1d000 f6e31000 r-xp /lib/libpthread-2.13.so
f6e3c000 f6e49000 r-xp /usr/lib/libaul.so.0.1.0
f6e53000 f6e55000 r-xp /lib/libdl-2.13.so
f6e5e000 f6e69000 r-xp /lib/libunwind.so.8.0.1
f6e96000 f6e9e000 r-xp /lib/libgcc_s-4.6.so.1
f6e9f000 f6fc3000 r-xp /lib/libc-2.13.so
f6fd1000 f6fd3000 r-xp /usr/lib/libdlog.so.0.0.0
f6fdb000 f6fe7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6ff0000 f6ff5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6ffd000 f700c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7014000 f7018000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7021000 f7024000 r-xp /usr/lib/libappcore-agent.so.1.1
f702c000 f702e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7036000 f703a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7042000 f705f000 r-xp /lib/ld-2.13.so
f7068000 f706b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f706b000 f706f000 r-xp /usr/lib/libsys-assert.so
f70e1000 f714f000 rw-p [heap]
ffe6f000 ffe90000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13079)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7069228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7000539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d073f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d4c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d471f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d49e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d4a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d51f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46e91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46dc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67af663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c5cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c5e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6deeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6de9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dea5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dea879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7022183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70227fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70695c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6eb685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7068f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
99+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:08.959+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:43:08.959+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:43:08.959+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:43:08.959+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79cddd8
04-23 20:43:09.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf7962228]
04-23 20:43:09.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:43:09.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:43:09.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:43:09.039+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:43:09.049+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:09.049+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:09.069+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:09.079+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:09.079+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:43:09.079+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:43:09.079+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:09.079+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:09.079+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:09.079+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:09.079+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:09.079+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:09.079+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:09.079+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:09.089+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:09.089+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:43:09.099+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:09.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:09.149+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:43:09.149+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:43:09.149+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:43:09.149+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf7962228
04-23 20:43:09.199+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:08:685,0.036661,9.772916,0.811882
04-23 20:43:09.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.219+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:211,0.037114,9.772807,0.813169
04-23 20:43:09.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:231,0.036072,9.772726,0.814196
04-23 20:43:09.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:248,0.034881,9.772466,0.817364
04-23 20:43:09.249+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:266,0.035066,9.772368,0.818518
04-23 20:43:09.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.279+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:285,0.030820,9.771012,0.834718
04-23 20:43:09.289+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:295,0.024784,9.769228,0.855546
04-23 20:43:09.329+0200 W/AUL     (13041): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:43:09.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:43:09.329+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:43:09.329+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 13005
04-23 20:43:09.329+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:43:09.339+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 13005
04-23 20:43:09.339+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(13005)
04-23 20:43:09.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:353,0.027250,9.771617,0.827737
04-23 20:43:09.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:513,0.038222,9.771074,0.833687
04-23 20:43:09.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:712,0.035593,9.773032,0.810526
04-23 20:43:09.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:09.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:09:914,0.028899,9.771194,0.832667
04-23 20:43:10.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:10.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:10:113,0.036245,9.770859,0.836291
04-23 20:43:10.139+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:43:10.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:10.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:10:313,0.027511,9.769912,0.847615
04-23 20:43:10.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:10.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:10:514,0.033734,9.771143,0.833073
04-23 20:43:10.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:10.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:10:714,0.033023,9.771040,0.834312
04-23 20:43:10.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:10.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:10:913,0.041402,9.772178,0.820495
04-23 20:43:11.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:11.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:11:117,0.027796,9.770429,0.841621
04-23 20:43:11.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:11.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:11:314,0.024308,9.769980,0.846925
04-23 20:43:11.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:11.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:11:516,0.035816,9.773334,0.806880
04-23 20:43:11.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:11.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:11:723,0.029920,9.775142,0.784914
04-23 20:43:11.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:11.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:11:916,0.033928,9.775401,0.781515
04-23 20:43:12.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:12.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:12:116,0.031892,9.776072,0.773175
04-23 20:43:12.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:12.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:12:316,0.025004,9.776135,0.772617
04-23 20:43:12.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:12.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:12:514,0.027528,9.776747,0.764759
04-23 20:43:12.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:12.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:12:712,0.020424,9.777833,0.750960
04-23 20:43:12.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:12.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:12:914,0.034144,9.775541,0.779745
04-23 20:43:13.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:13.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:13:114,0.036502,9.775232,0.783508
04-23 20:43:13.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:13.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:13:314,0.030210,9.773267,0.807916
04-23 20:43:13.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:13.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:13:514,0.035443,9.772862,0.812580
04-23 20:43:13.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:13.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:13:713,0.038128,9.772824,0.812918
04-23 20:43:13.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:13.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:13:914,0.037847,9.771517,0.828503
04-23 20:43:14.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:14.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:14:114,0.045376,9.771616,0.826946
04-23 20:43:14.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:14.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:14:314,0.047975,9.772165,0.820291
04-23 20:43:14.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:14.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:14:513,0.032148,9.771229,0.832125
04-23 20:43:14.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:14.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:14:713,0.030397,9.770238,0.843751
04-23 20:43:14.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:14.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:14:913,0.031580,9.770994,0.834902
04-23 20:43:15.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:15.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:15:113,0.041122,9.771919,0.823581
04-23 20:43:15.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:15.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:15:314,0.029936,9.770885,0.836243
04-23 20:43:15.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:15.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:15:513,0.041619,9.772232,0.819836
04-23 20:43:15.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:15.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:15:711,0.043076,9.773331,0.806553
04-23 20:43:15.909+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:15.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:15:913,0.047178,9.772940,0.811054
04-23 20:43:16.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:16.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:16:112,0.038919,9.771173,0.832495
04-23 20:43:16.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:16.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:16:312,0.030105,9.770684,0.838579
04-23 20:43:16.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:16.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:16:513,0.026636,9.769957,0.847121
04-23 20:43:16.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:16.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:16:712,0.022682,9.769628,0.851028
04-23 20:43:16.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:16.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:16:912,0.033480,9.770310,0.842793
04-23 20:43:16.959+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:43:16.959+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:43:16.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:43:16.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:43:16.969+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 13079
04-23 20:43:16.969+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:43:17.019+0200 E/CAPI_APPFW_APPLICATION(13079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:17.019+0200 E/CAPI_APPFW_APPLICATION(13079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:43:17.019+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 13079
04-23 20:43:17.019+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(13079) type(svcapp) bg(0)
04-23 20:43:17.019+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13079)
04-23 20:43:17.019+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:43:17.019+0200 I/servicemanager(12059): App control destroyed.
04-23 20:43:17.019+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [13079]
04-23 20:43:17.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:43:17.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13079
04-23 20:43:17.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:43:17.059+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 13079
04-23 20:43:17.059+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (13079) was created
04-23 20:43:17.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:17.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:43:17.059+0200 W/LOCATION(13079): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:43:17.059+0200 E/LOCATION(13079): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:43:17.059+0200 E/PKGMGR_INFO(13079): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:43:17.069+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:17.089+0200 I/LOCATION(13079): location.c: location_new(269) > method: 0
04-23 20:43:17.089+0200 W/LOCATION(13079): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:17.089+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:17.099+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:17.099+0200 W/LOCATION(13079): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:17.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.109+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:17.109+0200 W/LOCATION(13079): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:17.109+0200 W/LOCATION(13079): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:17.109+0200 W/LOCATION(13079): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:17.109+0200 W/LOCATION(13079): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:17.129+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:17.139+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:43:17.139+0200 W/LOCATION(13079): module-internal.c: module_new(311) > module (wps) open success
04-23 20:43:17.139+0200 W/LOCATION(13079): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:43:17.149+0200 W/LOCATION(13079): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:43:17.149+0200 W/LOCATION(13079): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:17.149+0200 W/LOCATION(13079): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:17.169+0200 W/LOCATION(13079): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:43:17.169+0200 I/LOCATION(13079): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7111c18
04-23 20:43:17.169+0200 I/LOCATION(13079): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:43:17.169+0200 I/LOCATION(13079): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7111c18
04-23 20:43:17.169+0200 I/LOCATION(13079): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:43:17.169+0200 I/location(13079): es.ugr.frailty.location: creado servicio de localización
04-23 20:43:17.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:120,0.050637,9.773432,0.804890
04-23 20:43:17.219+0200 I/LOCATION(13079): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:43:17.259+0200 W/LOCATION(13079): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:17.259+0200 W/LOCATION(13079): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:17.259+0200 I/LOCATION(13079): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:17.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:312,0.035055,9.774433,0.793487
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:43:17.339+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:43:17.339+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:17.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:43:17.339+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:43:17.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:43:17.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:43:17.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:43:17.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:43:17.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:43:17.339+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:43:17.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:43:17.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:43:17.389+0200 W/LOCATION(13079): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:43:17.389+0200 W/LOCATION(13079): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:43:17.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:17.509+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf7964d70]
04-23 20:43:17.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:43:17.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:43:17.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:43:17.509+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:43:17.519+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:17.519+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:17.519+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:17.529+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:17.529+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:43:17.529+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:43:17.529+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:43:17.529+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:43:17.529+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:43:17.529+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:43:17.529+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:43:17.529+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:43:17.529+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:43:17.539+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:17.549+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:43:17.549+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:43:17.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:17.579+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:515,0.031803,9.775746,0.777280
04-23 20:43:17.579+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:43:17.579+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3072846), time2(3059494)
04-23 20:43:17.579+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:43:17.579+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:43:17.579+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:43:17.579+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:43:17.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:43:17.619+0200 W/LOCATION(13079): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:43:17.619+0200 I/LOCATION(13079): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:17.629+0200 I/LOCATION(13079): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:43:17.629+0200 I/location(13079): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:43:17.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:17.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:17.709+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:17.709+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:719,0.023870,9.773728,0.802521
04-23 20:43:17.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:732,0.024466,9.773552,0.804659
04-23 20:43:17.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:751,0.025951,9.773374,0.806776
04-23 20:43:17.759+0200 I/LOCATION(13079): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:43:17.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:772,0.026907,9.773284,0.807820
04-23 20:43:17.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:791,0.027475,9.773175,0.809118
04-23 20:43:17.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:812,0.028494,9.773207,0.808702
04-23 20:43:17.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:832,0.028648,9.773147,0.809427
04-23 20:43:17.829+0200 I/location(13079): es.ugr.frailty.location: waiting for rigth values
04-23 20:43:17.829+0200 W/CAPI_APPFW_APP_CONTROL(13079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:43:17.829+0200 I/utils   (13079): specific action
04-23 20:43:17.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:851,0.027996,9.773016,0.811028
04-23 20:43:17.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.869+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:871,0.028174,9.772771,0.813962
04-23 20:43:17.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:892,0.029374,9.772674,0.815094
04-23 20:43:17.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:912,0.029607,9.772661,0.815236
04-23 20:43:17.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:932,0.029492,9.772668,0.815150
04-23 20:43:17.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:952,0.027487,9.772732,0.814457
04-23 20:43:17.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:972,0.027958,9.773037,0.810774
04-23 20:43:17.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:17.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:17:991,0.028996,9.773471,0.805485
04-23 20:43:18.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:13,0.030862,9.773523,0.804778
04-23 20:43:18.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:31,0.029980,9.773398,0.806334
04-23 20:43:18.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:51,0.029388,9.773171,0.809101
04-23 20:43:18.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:72,0.030070,9.773130,0.809570
04-23 20:43:18.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:91,0.030375,9.773076,0.810211
04-23 20:43:18.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:112,0.030090,9.773125,0.809636
04-23 20:43:18.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:132,0.029253,9.773004,0.811131
04-23 20:43:18.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:151,0.029943,9.772923,0.812076
04-23 20:43:18.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:171,0.029465,9.772724,0.814479
04-23 20:43:18.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:192,0.029459,9.772613,0.815816
04-23 20:43:18.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:212,0.029569,9.772538,0.816701
04-23 20:43:18.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:231,0.032653,9.772770,0.813813
04-23 20:43:18.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:251,0.034198,9.772788,0.813527
04-23 20:43:18.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:271,0.035666,9.772745,0.813982
04-23 20:43:18.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:291,0.035479,9.772762,0.813779
04-23 20:43:18.309+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:313,0.034724,9.772734,0.814153
04-23 20:43:18.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:332,0.035266,9.772726,0.814228
04-23 20:43:18.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:351,0.034007,9.772840,0.812921
04-23 20:43:18.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:372,0.033485,9.773041,0.810514
04-23 20:43:18.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:391,0.033763,9.773149,0.809196
04-23 20:43:18.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:412,0.032916,9.773213,0.808452
04-23 20:43:18.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:432,0.031744,9.773464,0.805467
04-23 20:43:18.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:451,0.031095,9.773737,0.802171
04-23 20:43:18.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.499+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:503,0.031957,9.773843,0.800852
04-23 20:43:18.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.539+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:545,0.030738,9.773974,0.799288
04-23 20:43:18.549+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.559+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:556,0.030712,9.774178,0.796805
04-23 20:43:18.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.579+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:584,0.030915,9.774483,0.793044
04-23 20:43:18.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:593,0.030204,9.774564,0.792075
04-23 20:43:18.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.609+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:605,0.031098,9.774647,0.791007
04-23 20:43:18.609+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.619+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:620,0.029577,9.774780,0.789420
04-23 20:43:18.619+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.629+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:632,0.030059,9.774851,0.788523
04-23 20:43:18.629+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:43:18.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:43:18.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:43:18.709+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:43:18.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:642,0.028580,9.775025,0.786411
04-23 20:43:18.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:727,0.029559,9.775082,0.785682
04-23 20:43:18.729+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:733,0.029096,9.774840,0.788694
04-23 20:43:18.729+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:739,0.030256,9.774775,0.789460
04-23 20:43:18.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.739+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:744,0.030560,9.774780,0.789380
04-23 20:43:18.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:749,0.031190,9.774721,0.790090
04-23 20:43:18.749+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.749+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:755,0.031322,9.774636,0.791134
04-23 20:43:18.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:771,0.031038,9.774901,0.787861
04-23 20:43:18.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:792,0.030883,9.775126,0.785072
04-23 20:43:18.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:812,0.030400,9.775103,0.785385
04-23 20:43:18.819+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:831,0.030037,9.775096,0.785478
04-23 20:43:18.839+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.849+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:851,0.031036,9.774977,0.786931
04-23 20:43:18.859+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.869+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:871,0.030530,9.775167,0.784588
04-23 20:43:18.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:891,0.030001,9.775105,0.785373
04-23 20:43:18.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:913,0.030077,9.774887,0.788077
04-23 20:43:18.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:931,0.029807,9.774741,0.789892
04-23 20:43:18.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:951,0.029212,9.774568,0.792059
04-23 20:43:18.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:18.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:18:972,0.029785,9.774427,0.793766
04-23 20:43:18.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.039+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:3,0.030794,9.774406,0.793990
04-23 20:43:19.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:88,0.031273,9.774153,0.797085
04-23 20:43:19.089+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:94,0.031173,9.774076,0.798027
04-23 20:43:19.089+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.099+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:99,0.031759,9.773920,0.799917
04-23 20:43:19.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.099+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:104,0.033562,9.773869,0.800464
04-23 20:43:19.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:109,0.031780,9.773650,0.803203
04-23 20:43:19.109+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:115,0.032005,9.773413,0.806075
04-23 20:43:19.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:131,0.031434,9.773279,0.807715
04-23 20:43:19.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:152,0.032029,9.773295,0.807494
04-23 20:43:19.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:171,0.029955,9.773154,0.809284
04-23 20:43:19.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:191,0.031967,9.773136,0.809433
04-23 20:43:19.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:212,0.033773,9.773116,0.809591
04-23 20:43:19.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:231,0.034807,9.773097,0.809779
04-23 20:43:19.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:251,0.034213,9.772873,0.812510
04-23 20:43:19.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:272,0.033293,9.772764,0.813853
04-23 20:43:19.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:291,0.033473,9.772932,0.811825
04-23 20:43:19.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:312,0.032152,9.772788,0.813607
04-23 20:43:19.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:332,0.032818,9.772770,0.813799
04-23 20:43:19.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:351,0.032086,9.772616,0.815669
04-23 20:43:19.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.379+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:371,0.034104,9.772680,0.814821
04-23 20:43:19.379+0200 W/LOCATION(13079): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:43:19.389+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.399+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:402,0.033758,9.772739,0.814135
04-23 20:43:19.409+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:413,0.031825,9.772533,0.816681
04-23 20:43:19.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:431,0.032506,9.772497,0.817088
04-23 20:43:19.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:451,0.031759,9.772425,0.817984
04-23 20:43:19.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.469+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:471,0.030845,9.772304,0.819464
04-23 20:43:19.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:491,0.030892,9.772350,0.818901
04-23 20:43:19.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:513,0.033398,9.772301,0.819399
04-23 20:43:19.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:531,0.033992,9.772160,0.821056
04-23 20:43:19.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.549+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:551,0.033312,9.772105,0.821731
04-23 20:43:19.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.569+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:572,0.034600,9.772221,0.820304
04-23 20:43:19.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:591,0.032404,9.772002,0.822991
04-23 20:43:19.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:43:19.609+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:43:19:612,0.030889,9.771814,0.825275
04-23 20:43:19.619+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11130796c6f63152450899
