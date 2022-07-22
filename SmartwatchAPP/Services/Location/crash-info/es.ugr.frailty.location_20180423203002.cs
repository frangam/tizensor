S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9230
Date: 2018-04-23 20:30:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71cc52d, r5   = 0xf74c3f98
r6   = 0xffbbbef0, r7   = 0xffbbbda0
r8   = 0xf74c0c18, r9   = 0x00000000
r10  = 0xffbbbe7c, fp   = 0xffbbbef0
ip   = 0x00000001, sp   = 0xffbbbd78
lr   = 0xf71cc539, pc   = 0xf7235228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    125912 KB
Buffers:     34496 KB
Cached:     153208 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11988 KB
VmRSS:       11984 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9230 TID = 9230
9230 9233 

Maps Information
f4097000 f4896000 rw-p [stack:9233]
f489d000 f489f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48a7000 f48ab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48b4000 f48b6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48be000 f48c1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48d0000 f48d5000 r-xp /usr/lib/libsystem.so.0.0.0
f48e0000 f48e3000 r-xp /lib/libattr.so.1.1.0
f48eb000 f48fb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4903000 f490c000 r-xp /usr/lib/libedbus.so.1.7.99
f4914000 f4915000 r-xp /usr/lib/libresponse.so.0.2.96
f491e000 f4923000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61c5000 f62cb000 r-xp /usr/lib/libicuuc.so.57.1
f62e1000 f6469000 r-xp /usr/lib/libicui18n.so.57.1
f6479000 f6486000 r-xp /usr/lib/libail.so.0.1.0
f648f000 f6496000 r-xp /usr/lib/libminizip.so.1.0.0
f649f000 f6648000 r-xp /usr/lib/libcrypto.so.1.0.0
f6668000 f66af000 r-xp /usr/lib/libssl.so.1.0.0
f66bb000 f66bd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66c5000 f66cc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66d5000 f66dc000 r-xp /lib/libcrypt-2.13.so
f670d000 f6710000 r-xp /lib/libcap.so.2.21
f6718000 f671a000 r-xp /usr/lib/libiri.so
f6722000 f676b000 r-xp /usr/lib/libmdm.so.1.2.69
f6773000 f6779000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6781000 f67a4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67ae000 f67b0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67b8000 f67d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67de000 f67e2000 r-xp /usr/lib/libsmack.so.1.0.0
f67eb000 f6804000 r-xp /usr/lib/libnetwork.so.0.0.0
f680d000 f6815000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f681d000 f6823000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f682c000 f682e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6837000 f6847000 r-xp /lib/libresolv-2.13.so
f684b000 f6863000 r-xp /usr/lib/liblzma.so.5.0.3
f686c000 f686e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6876000 f6890000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6898000 f68c7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68d0000 f68df000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68e9000 f68f3000 r-xp /usr/lib/libsensord-shared.so
f68fc000 f69cf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69da000 f69f0000 r-xp /lib/libz.so.1.2.5
f69f8000 f69fd000 r-xp /usr/lib/libffi.so.5.0.10
f6a05000 f6a06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a0e000 f6a1e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a26000 f6a3f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a47000 f6a49000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a51000 f6ac6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ad0000 f6ad6000 r-xp /lib/librt-2.13.so
f6adf000 f6afd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b07000 f6b08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b10000 f6b33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b3b000 f6b40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b48000 f6b72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b7b000 f6b92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b9a000 f6c03000 r-xp /lib/libm-2.13.so
f6c0c000 f6ca0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cb3000 f6cb8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cc0000 f6cc7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ccf000 f6cf9000 r-xp /usr/lib/libsensor.so.1.9.6
f6d02000 f6dce000 r-xp /usr/lib/libxml2.so.2.7.8
f6ddb000 f6ddd000 r-xp /usr/lib/libiniparser.so.0
f6de6000 f6dec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6df5000 f6ec5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ec6000 f6efa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f03000 f6f3f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f47000 f6f4a000 r-xp /usr/lib/libbundle.so.0.1.22
f6f52000 f6f58000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f60000 f6fa1000 r-xp /usr/lib/libeina.so.1.7.99
f6faa000 f6fc1000 r-xp /usr/lib/libecore.so.1.7.99
f6fd8000 f6fe1000 r-xp /usr/lib/libvconf.so.0.2.45
f6fe9000 f6ffd000 r-xp /lib/libpthread-2.13.so
f7008000 f7015000 r-xp /usr/lib/libaul.so.0.1.0
f701f000 f7021000 r-xp /lib/libdl-2.13.so
f702a000 f7035000 r-xp /lib/libunwind.so.8.0.1
f7062000 f706a000 r-xp /lib/libgcc_s-4.6.so.1
f706b000 f718f000 r-xp /lib/libc-2.13.so
f719d000 f719f000 r-xp /usr/lib/libdlog.so.0.0.0
f71a7000 f71b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71bc000 f71c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71c9000 f71d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71e0000 f71e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71ed000 f71f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f71f8000 f71fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7202000 f7206000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f720e000 f722b000 r-xp /lib/ld-2.13.so
f7234000 f7237000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7237000 f723b000 r-xp /usr/lib/libsys-assert.so
f7490000 f751e000 rw-p [heap]
ffb9d000 ffbbe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9230)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7235228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ed33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ed1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6edde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ee3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ee3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f1875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ed1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6edde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ee3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ee3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f15e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f16017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f1df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48b51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48a8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf697b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e28fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e2a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fbaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fb5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fb65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fb6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72354f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf708285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7234f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
295) > Successfully de-registered(0)
04-23 20:29:52.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:52.619+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76c2198
04-23 20:29:52.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76c2278]
04-23 20:29:52.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:52.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:52.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:52.689+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:52.699+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:52.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:52.709+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:52.719+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:52.719+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:52.719+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:52.719+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:52.719+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:52.719+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:52.719+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:52.719+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:52.719+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:52.719+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:52.729+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:52.739+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:52.739+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:52.739+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:52.789+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:52.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:29:52.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:29:52.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:52.789+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76c2278
04-23 20:29:52.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.859+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:861,0.036101,9.772307,0.819202
04-23 20:29:52.859+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.869+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:870,0.035792,9.772275,0.819599
04-23 20:29:52.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.879+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:883,0.035384,9.772325,0.819026
04-23 20:29:52.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:898,0.025562,9.770528,0.840544
04-23 20:29:52.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:902,0.035454,9.771083,0.833706
04-23 20:29:52.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:52.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:52:914,0.041360,9.771518,0.828315
04-23 20:29:52.989+0200 W/AUL     ( 9194): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:29:52.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:29:52.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:29:52.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9158
04-23 20:29:52.989+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:29:52.989+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9158
04-23 20:29:52.989+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9158)
04-23 20:29:53.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:53.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:53:114,0.030162,9.770427,0.841570
04-23 20:29:53.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:53.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:53:314,0.017047,9.766267,0.888895
04-23 20:29:53.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:53.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:53:514,0.029829,9.770215,0.844034
04-23 20:29:53.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:53.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:53:715,0.031300,9.771480,0.829211
04-23 20:29:53.799+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:29:53.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:53.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:53:914,0.035444,9.771811,0.825126
04-23 20:29:54.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:54.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:54:114,0.046154,9.772919,0.811366
04-23 20:29:54.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:54.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:54:314,0.046126,9.772972,0.810725
04-23 20:29:54.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:54.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:54:514,0.038205,9.772879,0.812264
04-23 20:29:54.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:54.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:54:714,0.040150,9.772786,0.813278
04-23 20:29:54.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:54.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:54:915,0.041418,9.773059,0.809929
04-23 20:29:55.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:55.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:55:115,0.038305,9.772697,0.814438
04-23 20:29:55.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:55.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:55:315,0.032982,9.772707,0.814554
04-23 20:29:55.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:55.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:55:524,0.036919,9.771773,0.825509
04-23 20:29:55.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:55.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:55:719,0.028415,9.768850,0.859737
04-23 20:29:55.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:55.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:55:924,0.023862,9.770409,0.841983
04-23 20:29:56.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:56.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:56:118,0.024869,9.772593,0.816206
04-23 20:29:56.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:56.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:56:315,0.031402,9.772009,0.822950
04-23 20:29:56.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:56.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:56:516,0.032276,9.771310,0.831169
04-23 20:29:56.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:56.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:56:716,0.035309,9.772111,0.821572
04-23 20:29:56.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:56.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:56:916,0.037424,9.774350,0.794399
04-23 20:29:57.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:57.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:57:116,0.041106,9.774318,0.794609
04-23 20:29:57.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:57.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:57:316,0.039573,9.774822,0.788462
04-23 20:29:57.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:57.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:57:515,0.037231,9.773022,0.810584
04-23 20:29:57.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:57.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:57:717,0.040470,9.772152,0.820846
04-23 20:29:57.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:57.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:57:916,0.026723,9.772925,0.812161
04-23 20:29:58.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:58.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:58:115,0.028661,9.775315,0.782801
04-23 20:29:58.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:58.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:58:314,0.041748,9.775620,0.778397
04-23 20:29:58.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:58.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:58:516,0.037002,9.773561,0.804058
04-23 20:29:58.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:58.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:58:715,0.039226,9.772882,0.812166
04-23 20:29:58.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:58.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:58:915,0.043147,9.773510,0.804375
04-23 20:29:59.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:59.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:59:116,0.032952,9.772711,0.814513
04-23 20:29:59.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:59.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:59:314,0.031039,9.772513,0.816945
04-23 20:29:59.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:59.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:59:515,0.029010,9.771295,0.831473
04-23 20:29:59.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:59.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:59:716,0.037111,9.771597,0.827582
04-23 20:29:59.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:59.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:59:915,0.035353,9.771070,0.833858
04-23 20:30:00.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:00.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:00:115,0.042835,9.771603,0.827239
04-23 20:30:00.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:00.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:00:314,0.034294,9.771260,0.831676
04-23 20:30:00.389+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:30:00.389+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:00.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:00.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:00.399+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9230
04-23 20:30:00.399+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:00.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9230
04-23 20:30:00.449+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9230) type(svcapp) bg(0)
04-23 20:30:00.449+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9230]
04-23 20:30:00.459+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9230)
04-23 20:30:00.459+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:30:00.459+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:00.469+0200 E/CAPI_APPFW_APPLICATION( 9230): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:00.469+0200 E/CAPI_APPFW_APPLICATION( 9230): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:00.469+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9230) was created
04-23 20:30:00.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:00.479+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9230
04-23 20:30:00.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:00.489+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:00.499+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9230
04-23 20:30:00.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:00.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:00.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:00:515,0.024577,9.770337,0.842790
04-23 20:30:00.529+0200 W/LOCATION( 9230): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:00.529+0200 E/LOCATION( 9230): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:00.529+0200 E/PKGMGR_INFO( 9230): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:00.529+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:00.549+0200 I/LOCATION( 9230): location.c: location_new(269) > method: 0
04-23 20:30:00.549+0200 W/LOCATION( 9230): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:00.559+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:00.559+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:00.569+0200 W/LOCATION( 9230): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:00.569+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:00.569+0200 W/LOCATION( 9230): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:00.569+0200 W/LOCATION( 9230): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:00.569+0200 W/LOCATION( 9230): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:00.569+0200 W/LOCATION( 9230): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:00.599+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:00.599+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:00.599+0200 W/LOCATION( 9230): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:00.609+0200 W/LOCATION( 9230): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:00.609+0200 W/LOCATION( 9230): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:00.609+0200 W/LOCATION( 9230): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:00.609+0200 W/LOCATION( 9230): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:00.629+0200 W/LOCATION( 9230): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:00.629+0200 I/LOCATION( 9230): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf74c0c18
04-23 20:30:00.629+0200 I/LOCATION( 9230): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:00.629+0200 I/LOCATION( 9230): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf74c0c18
04-23 20:30:00.629+0200 I/LOCATION( 9230): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:00.629+0200 I/location( 9230): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:00.679+0200 I/LOCATION( 9230): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:00.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:00.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:00:715,0.019735,9.769594,0.851481
04-23 20:30:00.739+0200 W/LOCATION( 9230): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:00.739+0200 W/LOCATION( 9230): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:00.739+0200 I/LOCATION( 9230): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:00.809+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:00.809+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:00.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:00.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:00.819+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:00.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:00.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:00.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:00.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:00.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:00.819+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:00.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:00.819+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:00.869+0200 W/LOCATION( 9230): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:00.869+0200 W/LOCATION( 9230): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:00.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:00.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:00:920,0.036390,9.773066,0.810096
04-23 20:30:00.949+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:00.989+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76c5aa8]
04-23 20:30:00.989+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:00.989+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:00.989+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:00.989+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:00.989+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:00.989+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:00.999+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:01.009+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:01.009+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:01.009+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:01.009+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:01.009+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:01.009+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:01.009+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:01.009+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:01.009+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:01.009+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:01.019+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:01.029+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:01.029+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:01.029+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:01.049+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:01.049+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2276310), time2(2262995)
04-23 20:30:01.049+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:30:01.049+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:01.049+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:01.049+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:01.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:01.099+0200 W/LOCATION( 9230): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:01.099+0200 I/LOCATION( 9230): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:01.099+0200 I/LOCATION( 9230): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:01.099+0200 I/location( 9230): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:01.119+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:123,0.041221,9.772735,0.813839
04-23 20:30:01.189+0200 I/LOCATION( 9230): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:01.239+0200 E/location( 9230): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:01.239+0200 W/AUL     ( 9230): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:01.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:01.239+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9230
04-23 20:30:01.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:01.249+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:01.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:01.249+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.249+0200 I/utils   ( 8242): specific action
04-23 20:30:01.249+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.249+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.249+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.249+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:01.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:01.249+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:01.259+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:01.259+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:01.259+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:01.259+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:01.259+0200 W/AUL     ( 9230): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:01.259+0200 I/location( 9230): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 9230): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 I/utils   ( 9230): specific action
04-23 20:30:01.259+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:01.259+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 I/utils   ( 8247): specific action
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:01.259+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:01.269+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:01.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:01.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:01.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:01.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:319,0.034910,9.772079,0.821978
04-23 20:30:01.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:336,0.033518,9.771867,0.824543
04-23 20:30:01.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:356,0.032975,9.771812,0.825209
04-23 20:30:01.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.369+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:375,0.032803,9.771796,0.825409
04-23 20:30:01.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.389+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:396,0.032654,9.771818,0.825156
04-23 20:30:01.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.409+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:415,0.031711,9.771732,0.826211
04-23 20:30:01.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:435,0.032165,9.771771,0.825732
04-23 20:30:01.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.449+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:457,0.032938,9.771861,0.824644
04-23 20:30:01.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.469+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:475,0.031977,9.771683,0.826787
04-23 20:30:01.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:495,0.030701,9.771577,0.828085
04-23 20:30:01.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:515,0.029726,9.771411,0.830080
04-23 20:30:01.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:535,0.030053,9.771618,0.827630
04-23 20:30:01.549+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.549+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:556,0.030486,9.771788,0.825608
04-23 20:30:01.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:575,0.030551,9.771951,0.823669
04-23 20:30:01.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:595,0.029863,9.771494,0.829095
04-23 20:30:01.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:615,0.030636,9.771649,0.827235
04-23 20:30:01.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:636,0.030812,9.771546,0.828446
04-23 20:30:01.649+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.649+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:656,0.030048,9.771560,0.828311
04-23 20:30:01.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.669+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:676,0.028942,9.771235,0.832175
04-23 20:30:01.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.689+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:696,0.029761,9.771444,0.829682
04-23 20:30:01.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:716,0.028726,9.771211,0.832472
04-23 20:30:01.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:736,0.028642,9.771300,0.831421
04-23 20:30:01.749+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.749+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:757,0.030616,9.771757,0.825954
04-23 20:30:01.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:776,0.031124,9.771764,0.825860
04-23 20:30:01.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.789+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:796,0.030472,9.771674,0.826947
04-23 20:30:01.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.809+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:816,0.029397,9.771486,0.829197
04-23 20:30:01.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.829+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:836,0.028039,9.771200,0.832617
04-23 20:30:01.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.849+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:857,0.028219,9.771368,0.830632
04-23 20:30:01.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:877,0.027364,9.771202,0.832615
04-23 20:30:01.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:898,0.027694,9.771181,0.832851
04-23 20:30:01.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:917,0.027204,9.771099,0.833830
04-23 20:30:01.939+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.939+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:945,0.028202,9.771115,0.833600
04-23 20:30:01.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:957,0.026874,9.770944,0.835655
04-23 20:30:01.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.969+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:976,0.025841,9.770814,0.837206
04-23 20:30:01.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:01.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:01:999,0.026806,9.771051,0.834397
04-23 20:30:02.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.049+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:30:02.049+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:33,0.027157,9.771049,0.834411
04-23 20:30:02.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.059+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:61,0.027477,9.771173,0.832960
04-23 20:30:02.059+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.069+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:66,0.028133,9.771240,0.832145
04-23 20:30:02.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.069+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:77,0.028662,9.771569,0.828247
04-23 20:30:02.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.089+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:95,0.027891,9.771527,0.828770
04-23 20:30:02.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:116,0.028411,9.771585,0.828076
04-23 20:30:02.129+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.129+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:135,0.025449,9.770945,0.835694
04-23 20:30:02.149+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.149+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:156,0.027330,9.771152,0.833203
04-23 20:30:02.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.169+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:175,0.027192,9.771213,0.832499
04-23 20:30:02.189+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.189+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:194,0.026953,9.771186,0.832822
04-23 20:30:02.209+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.209+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:215,0.026951,9.771173,0.832974
04-23 20:30:02.229+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.229+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:236,0.027529,9.771400,0.830275
04-23 20:30:02.249+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.249+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:256,0.027502,9.771416,0.830104
04-23 20:30:02.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.269+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:275,0.027814,9.771351,0.830853
04-23 20:30:02.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:02.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:02.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:02.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:294,0.027896,9.771245,0.832088
04-23 20:30:02.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:314,0.028320,9.771487,0.829229
04-23 20:30:02.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:335,0.027943,9.771245,0.832095
04-23 20:30:02.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:357,0.029203,9.771425,0.829931
04-23 20:30:02.379+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.379+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:383,0.030353,9.771678,0.826908
04-23 20:30:02.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.449+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:458,0.029734,9.771604,0.827805
04-23 20:30:02.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:463,0.029949,9.771544,0.828492
04-23 20:30:02.459+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:468,0.030265,9.771614,0.827663
04-23 20:30:02.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.469+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:474,0.029993,9.771672,0.826985
04-23 20:30:02.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:482,0.031236,9.772061,0.822325
04-23 20:30:02.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:494,0.030129,9.771864,0.824717
04-23 20:30:02.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:514,0.029539,9.771865,0.824718
04-23 20:30:02.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:538,0.030792,9.771972,0.823409
04-23 20:30:02.549+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.549+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:556,0.031764,9.772204,0.820603
04-23 20:30:02.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:575,0.031548,9.772143,0.821343
04-23 20:30:02.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:595,0.033874,9.772680,0.814838
04-23 20:30:02.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:615,0.033668,9.772719,0.814378
04-23 20:30:02.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:635,0.034033,9.772759,0.813878
04-23 20:30:02.649+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.649+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:656,0.035052,9.772773,0.813677
04-23 20:30:02.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.669+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:675,0.033985,9.772600,0.815794
04-23 20:30:02.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.689+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:694,0.031354,9.772281,0.819719
04-23 20:30:02.709+0200 W/LOCATION( 9230): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:30:02.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:723,0.032750,9.772378,0.818499
04-23 20:30:02.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:734,0.034152,9.772330,0.819008
04-23 20:30:02.749+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.749+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:755,0.034614,9.772500,0.816967
04-23 20:30:02.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:776,0.033223,9.772303,0.819376
04-23 20:30:02.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.789+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:794,0.032819,9.772232,0.820240
04-23 20:30:02.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.809+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:814,0.032420,9.772188,0.820769
04-23 20:30:02.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.829+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:835,0.032740,9.772430,0.817874
04-23 20:30:02.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.849+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:855,0.033147,9.772523,0.816748
04-23 20:30:02.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.869+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:875,0.032856,9.772591,0.815956
04-23 20:30:02.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:895,0.033710,9.772630,0.815450
04-23 20:30:02.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:929,0.032470,9.772526,0.816738
04-23 20:30:02.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:02:937,0.034516,9.772975,0.811261
04-23 20:30:02.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:02.949+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11092306c6f63152450820
