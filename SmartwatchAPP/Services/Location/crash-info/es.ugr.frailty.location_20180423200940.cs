S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7217
Date: 2018-04-23 20:09:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf775452d, r5   = 0xf7d70f98
r6   = 0xfff1f760, r7   = 0xfff1f610
r8   = 0xf7d6dc18, r9   = 0x00000000
r10  = 0xfff1f6ec, fp   = 0xfff1f760
ip   = 0x00000001, sp   = 0xfff1f5e8
lr   = 0xf7754539, pc   = 0xf77bd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     87756 KB
Buffers:     40140 KB
Cached:     186408 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11648 KB
VmRSS:       11648 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7217 TID = 7217
7217 7220 

Maps Information
f461f000 f4e1e000 rw-p [stack:7220]
f4e25000 f4e27000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e2f000 f4e33000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e3c000 f4e3e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e46000 f4e49000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e58000 f4e5d000 r-xp /usr/lib/libsystem.so.0.0.0
f4e68000 f4e6b000 r-xp /lib/libattr.so.1.1.0
f4e73000 f4e83000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e8b000 f4e94000 r-xp /usr/lib/libedbus.so.1.7.99
f4e9c000 f4e9d000 r-xp /usr/lib/libresponse.so.0.2.96
f4ea6000 f4eab000 r-xp /usr/lib/libproc-stat.so.0.2.96
f674d000 f6853000 r-xp /usr/lib/libicuuc.so.57.1
f6869000 f69f1000 r-xp /usr/lib/libicui18n.so.57.1
f6a01000 f6a0e000 r-xp /usr/lib/libail.so.0.1.0
f6a17000 f6a1e000 r-xp /usr/lib/libminizip.so.1.0.0
f6a27000 f6bd0000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bf0000 f6c37000 r-xp /usr/lib/libssl.so.1.0.0
f6c43000 f6c45000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c4d000 f6c54000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c5d000 f6c64000 r-xp /lib/libcrypt-2.13.so
f6c95000 f6c98000 r-xp /lib/libcap.so.2.21
f6ca0000 f6ca2000 r-xp /usr/lib/libiri.so
f6caa000 f6cf3000 r-xp /usr/lib/libmdm.so.1.2.69
f6cfb000 f6d01000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d09000 f6d2c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d36000 f6d38000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d40000 f6d5d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d66000 f6d6a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d73000 f6d8c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d95000 f6d9d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6da5000 f6dab000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6db4000 f6db6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6dbf000 f6dcf000 r-xp /lib/libresolv-2.13.so
f6dd3000 f6deb000 r-xp /usr/lib/liblzma.so.5.0.3
f6df4000 f6df6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dfe000 f6e18000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e20000 f6e4f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e58000 f6e67000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e71000 f6e7b000 r-xp /usr/lib/libsensord-shared.so
f6e84000 f6f57000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f62000 f6f78000 r-xp /lib/libz.so.1.2.5
f6f80000 f6f85000 r-xp /usr/lib/libffi.so.5.0.10
f6f8d000 f6f8e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f96000 f6fa6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fae000 f6fc7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fcf000 f6fd1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fd9000 f704e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7058000 f705e000 r-xp /lib/librt-2.13.so
f7067000 f7085000 r-xp /usr/lib/libsystemd.so.0.4.0
f708f000 f7090000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7098000 f70bb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70c3000 f70c8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70d0000 f70fa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7103000 f711a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7122000 f718b000 r-xp /lib/libm-2.13.so
f7194000 f7228000 r-xp /usr/lib/libstdc++.so.6.0.16
f723b000 f7240000 r-xp /usr/lib/libctx-client.so.0.8.3
f7248000 f724f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7257000 f7281000 r-xp /usr/lib/libsensor.so.1.9.6
f728a000 f7356000 r-xp /usr/lib/libxml2.so.2.7.8
f7363000 f7365000 r-xp /usr/lib/libiniparser.so.0
f736e000 f7374000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f737d000 f744d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f744e000 f7482000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f748b000 f74c7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74cf000 f74d2000 r-xp /usr/lib/libbundle.so.0.1.22
f74da000 f74e0000 r-xp /usr/lib/libappsvc.so.0.1.0
f74e8000 f7529000 r-xp /usr/lib/libeina.so.1.7.99
f7532000 f7549000 r-xp /usr/lib/libecore.so.1.7.99
f7560000 f7569000 r-xp /usr/lib/libvconf.so.0.2.45
f7571000 f7585000 r-xp /lib/libpthread-2.13.so
f7590000 f759d000 r-xp /usr/lib/libaul.so.0.1.0
f75a7000 f75a9000 r-xp /lib/libdl-2.13.so
f75b2000 f75bd000 r-xp /lib/libunwind.so.8.0.1
f75ea000 f75f2000 r-xp /lib/libgcc_s-4.6.so.1
f75f3000 f7717000 r-xp /lib/libc-2.13.so
f7725000 f7727000 r-xp /usr/lib/libdlog.so.0.0.0
f772f000 f773b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7744000 f7749000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7751000 f7760000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7768000 f776c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7775000 f7778000 r-xp /usr/lib/libappcore-agent.so.1.1
f7780000 f7782000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f778a000 f778e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7796000 f77b3000 r-xp /lib/ld-2.13.so
f77bc000 f77bf000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77bf000 f77c3000 r-xp /usr/lib/libsys-assert.so
f7d3d000 f7dc7000 rw-p [heap]
fff00000 fff21000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7217)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77bd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7754539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf745b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7459c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7465e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf746bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf746bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74a075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf749b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7459c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7465e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf746bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf746bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf749de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf749e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74a5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e3d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e30171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f03663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73b0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73b27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7542ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf753db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf753e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf753e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7776183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77767fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77bd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf760a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf77bcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:30.519+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:30.519+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:30.519+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:30.519+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:30.529+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:30.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:30.539+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:30.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:30.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:121,0.052811,9.773363,0.805583
04-23 20:09:30.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:30.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:30.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:30.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:30.599+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d55e8
04-23 20:09:30.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:575,0.052837,9.773322,0.806080
04-23 20:09:30.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:664,0.052065,9.773285,0.806579
04-23 20:09:30.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:669,0.052243,9.773378,0.805434
04-23 20:09:30.679+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:685,0.052996,9.773565,0.803116
04-23 20:09:30.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:699,0.052089,9.773530,0.803601
04-23 20:09:30.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.699+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:704,0.052375,9.773602,0.802703
04-23 20:09:30.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:713,0.053117,9.773722,0.801203
04-23 20:09:30.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:718,0.053239,9.773872,0.799359
04-23 20:09:30.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.719+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:728,0.053811,9.773875,0.799282
04-23 20:09:30.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:732,0.055841,9.774014,0.797440
04-23 20:09:30.759+0200 W/AUL     ( 7180): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:09:30.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:30.759+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:30.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7145
04-23 20:09:30.759+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:30.759+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7145
04-23 20:09:30.759+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7145)
04-23 20:09:30.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:775,0.056851,9.774056,0.796848
04-23 20:09:30.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.789+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:788,0.056456,9.773996,0.797622
04-23 20:09:30.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.789+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:795,0.057125,9.774236,0.794626
04-23 20:09:30.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.799+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:800,0.044097,9.772962,0.810966
04-23 20:09:30.799+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.809+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:810,0.058205,9.773712,0.800962
04-23 20:09:30.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:30.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:30:969,0.051787,9.773178,0.807891
04-23 20:09:31.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:31.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:31:169,0.047549,9.773433,0.805067
04-23 20:09:31.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:31.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:31:369,0.046312,9.772755,0.813335
04-23 20:09:31.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:31.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:31:573,0.051065,9.773746,0.801039
04-23 20:09:31.659+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:09:31.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:31.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:31:773,0.047005,9.774037,0.797731
04-23 20:09:31.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:31.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:31:973,0.047482,9.773699,0.801836
04-23 20:09:32.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:32.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:32:173,0.035865,9.772834,0.812905
04-23 20:09:32.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:32.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:32:373,0.040930,9.773679,0.802443
04-23 20:09:32.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:32.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:32:569,0.051402,9.773508,0.803916
04-23 20:09:32.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:32.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:32:768,0.046451,9.772906,0.811498
04-23 20:09:32.869+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][4][3][6][0][0][0][0][0][0][0][0][0][0]
04-23 20:09:32.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:32.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:32:968,0.049600,9.774691,0.789524
04-23 20:09:33.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:33.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:33:168,0.068203,9.774752,0.787379
04-23 20:09:33.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:33.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:33:368,0.060781,9.775544,0.778087
04-23 20:09:33.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:33.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:33:568,0.056013,9.774126,0.796051
04-23 20:09:33.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:33.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:33:769,0.061520,9.774612,0.789653
04-23 20:09:33.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:33.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:33:971,0.065259,9.774836,0.786585
04-23 20:09:34.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:34.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:34:169,0.059743,9.774655,0.789263
04-23 20:09:34.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:34.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:34:368,0.059472,9.773957,0.797871
04-23 20:09:34.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:34.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:34:569,0.050275,9.773380,0.805540
04-23 20:09:34.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:34.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:34:769,0.044233,9.773484,0.804636
04-23 20:09:34.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:34.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:34:969,0.052857,9.773310,0.806225
04-23 20:09:35.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:35.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:35:169,0.045807,9.772901,0.811608
04-23 20:09:35.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:35.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:35:367,0.034742,9.772026,0.822605
04-23 20:09:35.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:35.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:35:569,0.033735,9.772449,0.817600
04-23 20:09:35.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:35.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:35:773,0.035442,9.771644,0.827114
04-23 20:09:35.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:35.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:35:969,0.035777,9.771279,0.831385
04-23 20:09:36.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:36.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:36:170,0.036826,9.770607,0.839209
04-23 20:09:36.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:36.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:36:370,0.044066,9.773631,0.802853
04-23 20:09:36.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:36.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:36:569,0.050394,9.773417,0.805094
04-23 20:09:36.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:36.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:36:770,0.060191,9.774604,0.789857
04-23 20:09:36.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:36.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:36:970,0.040348,9.773440,0.805367
04-23 20:09:37.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:37.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:37:169,0.040635,9.772486,0.816859
04-23 20:09:37.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:37.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:37:369,0.035244,9.772228,0.820180
04-23 20:09:37.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:37.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:37:570,0.035829,9.773503,0.804814
04-23 20:09:37.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:37.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:37:769,0.048998,9.775463,0.779941
04-23 20:09:37.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:37.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:37:970,0.044987,9.775642,0.777937
04-23 20:09:38.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:38.159+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:38:169,0.053249,9.774891,0.786800
04-23 20:09:38.349+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:09:38.349+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:09:38.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:38.349+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:38.359+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7217
04-23 20:09:38.359+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:09:38.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:38.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:38:376,0.049333,9.774308,0.794261
04-23 20:09:38.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7217
04-23 20:09:38.409+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7217) type(svcapp) bg(0)
04-23 20:09:38.419+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7217)
04-23 20:09:38.419+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:09:38.419+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:38.419+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7217]
04-23 20:09:38.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:38.449+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7217
04-23 20:09:38.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:38.459+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7217
04-23 20:09:38.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:38.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:38.469+0200 E/CAPI_APPFW_APPLICATION( 7217): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:38.469+0200 E/CAPI_APPFW_APPLICATION( 7217): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:38.469+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7217) was created
04-23 20:09:38.489+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:09:38.489+0200 E/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:09:38.489+0200 E/PKGMGR_INFO( 7217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:09:38.489+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:38.509+0200 I/LOCATION( 7217): location.c: location_new(269) > method: 0
04-23 20:09:38.509+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:38.519+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:38.519+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:38.529+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:38.529+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:38.529+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:38.529+0200 W/LOCATION( 7217): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:38.539+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:38.539+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:38.559+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:38.559+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:38.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:38.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:38:569,0.051388,9.774673,0.789630
04-23 20:09:38.569+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (wps) open success
04-23 20:09:38.569+0200 W/LOCATION( 7217): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:09:38.579+0200 W/LOCATION( 7217): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:09:38.579+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:38.579+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:38.599+0200 W/LOCATION( 7217): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:09:38.599+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d6dc18
04-23 20:09:38.599+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:09:38.599+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d6dc18
04-23 20:09:38.599+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:09:38.609+0200 I/location( 7217): es.ugr.frailty.location: creado servicio de localización
04-23 20:09:38.649+0200 I/LOCATION( 7217): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:09:38.699+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:38.699+0200 W/LOCATION( 7217): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:38.709+0200 I/LOCATION( 7217): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:38.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:09:38.769+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:09:38.769+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:38.769+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:38.769+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:09:38.769+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:09:38.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:09:38.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:09:38.779+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:09:38.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:09:38.779+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:09:38.779+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:09:38.779+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:09:38.779+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:09:38.799+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:38:774,0.066445,9.775082,0.783416
04-23 20:09:38.829+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:38.829+0200 W/LOCATION( 7217): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:38.909+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:38.949+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e7788]
04-23 20:09:38.949+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:38.949+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:38.949+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:38.949+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:38.949+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:38.949+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:38.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:38.959+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:38.969+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:38.969+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:38.969+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:38.969+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:38.969+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:38.969+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:38.979+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:38.979+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:38.979+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:38.979+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:38.979+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:38.999+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:38.999+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:38.999+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:39.019+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:38:972,0.060455,9.775237,0.781960
04-23 20:09:39.029+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:09:39.029+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1054298), time2(1041102)
04-23 20:09:39.029+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:09:39.029+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:09:39.029+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:09:39.029+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:09:39.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:39.079+0200 W/LOCATION( 7217): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:39.079+0200 I/LOCATION( 7217): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:39.079+0200 I/LOCATION( 7217): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:39.079+0200 I/location( 7217): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:09:39.159+0200 I/LOCATION( 7217): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:39.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.209+0200 E/location( 7217): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:09:39.209+0200 W/AUL     ( 7217): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:39.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:39.209+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7217
04-23 20:09:39.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:39.219+0200 W/AUL     ( 7217): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:39.219+0200 I/location( 7217): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:39.219+0200 W/CAPI_APPFW_APP_CONTROL( 7217): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.219+0200 I/utils   ( 7217): specific action
04-23 20:09:39.219+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:39.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:39.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.219+0200 I/utils   ( 5532): specific action
04-23 20:09:39.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.219+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.219+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:39.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:39.219+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:39.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:39.229+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:39.229+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:09:39.229+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.229+0200 I/utils   ( 5538): specific action
04-23 20:09:39.229+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.229+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.229+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:173,0.067742,9.775202,0.781815
04-23 20:09:39.229+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.229+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:39.229+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:09:39.239+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:39.239+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:39.239+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:39.239+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:39.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:39.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:39.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:39.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:369,0.057308,9.775496,0.778955
04-23 20:09:39.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.379+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:389,0.055096,9.775396,0.780372
04-23 20:09:39.399+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:410,0.054656,9.775359,0.780864
04-23 20:09:39.419+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.419+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:429,0.054920,9.775501,0.779071
04-23 20:09:39.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:450,0.055957,9.775428,0.779910
04-23 20:09:39.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:470,0.057413,9.775471,0.779268
04-23 20:09:39.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:489,0.056521,9.775456,0.779512
04-23 20:09:39.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:509,0.055786,9.775436,0.779818
04-23 20:09:39.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:529,0.056233,9.775382,0.780470
04-23 20:09:39.539+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:550,0.055544,9.775253,0.782122
04-23 20:09:39.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:569,0.056146,9.775336,0.781047
04-23 20:09:39.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:589,0.054777,9.775234,0.782417
04-23 20:09:39.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:609,0.054707,9.775168,0.783249
04-23 20:09:39.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:629,0.054656,9.775086,0.784271
04-23 20:09:39.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:650,0.054818,9.775091,0.784199
04-23 20:09:39.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:669,0.054742,9.775149,0.783480
04-23 20:09:39.679+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:689,0.056160,9.775267,0.781913
04-23 20:09:39.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:710,0.055330,9.775293,0.781639
04-23 20:09:39.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:729,0.052656,9.775104,0.784193
04-23 20:09:39.739+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:750,0.053018,9.775091,0.784324
04-23 20:09:39.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:769,0.051901,9.774924,0.786471
04-23 20:09:39.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:789,0.049780,9.774910,0.786795
04-23 20:09:39.799+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.799+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:809,0.050654,9.774712,0.789196
04-23 20:09:39.819+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.829+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:829,0.051481,9.774641,0.790023
04-23 20:09:39.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.849+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:854,0.050889,9.774672,0.789683
04-23 20:09:39.859+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.869+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:872,0.049287,9.774739,0.788938
04-23 20:09:39.879+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.879+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:889,0.050598,9.774604,0.790538
04-23 20:09:39.919+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.929+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:925,0.051408,9.774650,0.789913
04-23 20:09:39.929+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.939+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:938,0.052870,9.774721,0.788933
04-23 20:09:39.939+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:953,0.054259,9.774837,0.787408
04-23 20:09:39.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.979+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:983,0.053988,9.774710,0.788995
04-23 20:09:39.989+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:39.989+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:39:993,0.053961,9.774700,0.789122
04-23 20:09:40.009+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.009+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:13,0.053131,9.774583,0.790622
04-23 20:09:40.059+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:09:40.059+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:71,0.052567,9.774465,0.792123
04-23 20:09:40.069+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:77,0.053083,9.774260,0.794618
04-23 20:09:40.069+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.079+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:81,0.052120,9.773969,0.798250
04-23 20:09:40.079+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.079+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:89,0.050273,9.773779,0.800684
04-23 20:09:40.099+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.109+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:109,0.051560,9.773648,0.802203
04-23 20:09:40.119+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.129+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:129,0.051644,9.773684,0.801761
04-23 20:09:40.139+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:150,0.051269,9.773772,0.800706
04-23 20:09:40.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:169,0.051949,9.774069,0.797037
04-23 20:09:40.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.179+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:189,0.051663,9.774037,0.797442
04-23 20:09:40.199+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.199+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:209,0.051049,9.773978,0.798208
04-23 20:09:40.219+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.219+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:229,0.051941,9.774050,0.797272
04-23 20:09:40.239+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.249+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:250,0.050536,9.773903,0.799158
04-23 20:09:40.259+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.259+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:269,0.049162,9.773901,0.799270
04-23 20:09:40.279+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.279+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:289,0.050936,9.774063,0.797172
04-23 20:09:40.299+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.309+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:309,0.052617,9.773956,0.798368
04-23 20:09:40.319+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.329+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:329,0.052987,9.773921,0.798773
04-23 20:09:40.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:40.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:40.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:40.359+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:361,0.051505,9.773968,0.798299
04-23 20:09:40.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:388,0.051352,9.773918,0.798914
04-23 20:09:40.429+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:439,0.051103,9.773806,0.800315
04-23 20:09:40.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.439+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:444,0.051212,9.773837,0.799920
04-23 20:09:40.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.439+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:448,0.049366,9.773777,0.800765
04-23 20:09:40.449+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:454,0.049423,9.773932,0.798866
04-23 20:09:40.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.459+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:469,0.049051,9.773791,0.800619
04-23 20:09:40.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:489,0.048555,9.773747,0.801173
04-23 20:09:40.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:509,0.048086,9.773818,0.800343
04-23 20:09:40.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:530,0.049929,9.774096,0.796834
04-23 20:09:40.539+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:550,0.049513,9.774033,0.797638
04-23 20:09:40.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:569,0.050731,9.774322,0.794007
04-23 20:09:40.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:589,0.050395,9.774167,0.795930
04-23 20:09:40.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.599+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:609,0.051853,9.774496,0.791779
04-23 20:09:40.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.619+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:628,0.050339,9.774351,0.793675
04-23 20:09:40.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.639+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:649,0.049443,9.774406,0.793048
04-23 20:09:40.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:668,0.050340,9.774324,0.793993
04-23 20:09:40.689+0200 W/LOCATION( 7217): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:09:40.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:713,0.049002,9.774217,0.795403
04-23 20:09:40.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:718,0.051528,9.774576,0.790820
04-23 20:09:40.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:730,0.051718,9.774465,0.792182
04-23 20:09:40.739+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.739+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:749,0.050645,9.774456,0.792354
04-23 20:09:40.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:768,0.052550,9.774378,0.793195
04-23 20:09:40.779+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:788,0.053147,9.774523,0.791364
04-23 20:09:40.799+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.799+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:808,0.053030,9.774565,0.790863
04-23 20:09:40.819+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:827,0.051790,9.774479,0.792002
04-23 20:09:40.839+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.839+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:849,0.053647,9.774438,0.792384
04-23 20:09:40.859+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.859+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:868,0.053059,9.774292,0.794215
04-23 20:09:40.879+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.879+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:887,0.049968,9.774252,0.794909
04-23 20:09:40.899+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.899+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:908,0.049201,9.774279,0.794634
04-23 20:09:40.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:956,0.052520,9.774374,0.793240
04-23 20:09:40.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.959+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:40:962,0.052328,9.774131,0.796255
04-23 20:09:40.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:40.969+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11072176c6f63152450698
