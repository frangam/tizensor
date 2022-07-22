S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12933
Date: 2018-04-23 20:42:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf770652d, r5   = 0xf7f75958
r6   = 0xffb6a3d0, r7   = 0xffb6a280
r8   = 0xf7f88c18, r9   = 0x00000000
r10  = 0xffb6a35c, fp   = 0xffb6a3d0
ip   = 0x00000001, sp   = 0xffb6a258
lr   = 0xf7706539, pc   = 0xf776f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    121768 KB
Buffers:     40896 KB
Cached:     161404 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11664 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12933 TID = 12933
12933 12936 

Maps Information
f45d1000 f4dd0000 rw-p [stack:12936]
f4dd7000 f4dd9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4de1000 f4de5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dee000 f4df0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4df8000 f4dfb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e0a000 f4e0f000 r-xp /usr/lib/libsystem.so.0.0.0
f4e1a000 f4e1d000 r-xp /lib/libattr.so.1.1.0
f4e25000 f4e35000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e3d000 f4e46000 r-xp /usr/lib/libedbus.so.1.7.99
f4e4e000 f4e4f000 r-xp /usr/lib/libresponse.so.0.2.96
f4e58000 f4e5d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66ff000 f6805000 r-xp /usr/lib/libicuuc.so.57.1
f681b000 f69a3000 r-xp /usr/lib/libicui18n.so.57.1
f69b3000 f69c0000 r-xp /usr/lib/libail.so.0.1.0
f69c9000 f69d0000 r-xp /usr/lib/libminizip.so.1.0.0
f69d9000 f6b82000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ba2000 f6be9000 r-xp /usr/lib/libssl.so.1.0.0
f6bf5000 f6bf7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bff000 f6c06000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c0f000 f6c16000 r-xp /lib/libcrypt-2.13.so
f6c47000 f6c4a000 r-xp /lib/libcap.so.2.21
f6c52000 f6c54000 r-xp /usr/lib/libiri.so
f6c5c000 f6ca5000 r-xp /usr/lib/libmdm.so.1.2.69
f6cad000 f6cb3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cbb000 f6cde000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ce8000 f6cea000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cf2000 f6d0f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d18000 f6d1c000 r-xp /usr/lib/libsmack.so.1.0.0
f6d25000 f6d3e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d47000 f6d4f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d57000 f6d5d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d66000 f6d68000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d71000 f6d81000 r-xp /lib/libresolv-2.13.so
f6d85000 f6d9d000 r-xp /usr/lib/liblzma.so.5.0.3
f6da6000 f6da8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6db0000 f6dca000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dd2000 f6e01000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e0a000 f6e19000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e23000 f6e2d000 r-xp /usr/lib/libsensord-shared.so
f6e36000 f6f09000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f14000 f6f2a000 r-xp /lib/libz.so.1.2.5
f6f32000 f6f37000 r-xp /usr/lib/libffi.so.5.0.10
f6f3f000 f6f40000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f48000 f6f58000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f60000 f6f79000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f81000 f6f83000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f8b000 f7000000 r-xp /usr/lib/libsqlite3.so.0.8.6
f700a000 f7010000 r-xp /lib/librt-2.13.so
f7019000 f7037000 r-xp /usr/lib/libsystemd.so.0.4.0
f7041000 f7042000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f704a000 f706d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7075000 f707a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7082000 f70ac000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70b5000 f70cc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70d4000 f713d000 r-xp /lib/libm-2.13.so
f7146000 f71da000 r-xp /usr/lib/libstdc++.so.6.0.16
f71ed000 f71f2000 r-xp /usr/lib/libctx-client.so.0.8.3
f71fa000 f7201000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7209000 f7233000 r-xp /usr/lib/libsensor.so.1.9.6
f723c000 f7308000 r-xp /usr/lib/libxml2.so.2.7.8
f7315000 f7317000 r-xp /usr/lib/libiniparser.so.0
f7320000 f7326000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f732f000 f73ff000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7400000 f7434000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f743d000 f7479000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7481000 f7484000 r-xp /usr/lib/libbundle.so.0.1.22
f748c000 f7492000 r-xp /usr/lib/libappsvc.so.0.1.0
f749a000 f74db000 r-xp /usr/lib/libeina.so.1.7.99
f74e4000 f74fb000 r-xp /usr/lib/libecore.so.1.7.99
f7512000 f751b000 r-xp /usr/lib/libvconf.so.0.2.45
f7523000 f7537000 r-xp /lib/libpthread-2.13.so
f7542000 f754f000 r-xp /usr/lib/libaul.so.0.1.0
f7559000 f755b000 r-xp /lib/libdl-2.13.so
f7564000 f756f000 r-xp /lib/libunwind.so.8.0.1
f759c000 f75a4000 r-xp /lib/libgcc_s-4.6.so.1
f75a5000 f76c9000 r-xp /lib/libc-2.13.so
f76d7000 f76d9000 r-xp /usr/lib/libdlog.so.0.0.0
f76e1000 f76ed000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f6000 f76fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7703000 f7712000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f771a000 f771e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7727000 f772a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7732000 f7734000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f773c000 f7740000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7748000 f7765000 r-xp /lib/ld-2.13.so
f776e000 f7771000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7771000 f7775000 r-xp /usr/lib/libsys-assert.so
f7f58000 f7fc6000 rw-p [heap]
ffb4b000 ffb6c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12933)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf776f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7706539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf740d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf740bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7417e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf741dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf741ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf745275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf744d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf740bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7417e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf741dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf741ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf744fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7450017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7457f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4def1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4de2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6eb5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7362fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73647a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74f4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74efb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74f05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74f0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7728183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77287fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf776f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75bc85c) [/lib/libc.so.6] + 0x1785c
29: (0xf776ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
nection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:42.179+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:42.189+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:42.189+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:42.199+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:42.209+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:42.209+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:42.209+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:42.209+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:42.209+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:42.209+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:42.209+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:42.209+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:42.209+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:42.209+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:42.219+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:42.229+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:42.229+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:42.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:42.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:42.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:42:42.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:42:42.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:42:42.279+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_destroy(471) > Destroy handle: 0xf79571f8
04-23 20:42:42.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:106,0.027649,9.771955,0.823710
04-23 20:42:42.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:42.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:364,0.042550,9.772872,0.812127
04-23 20:42:42.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:42.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:371,0.040506,9.772656,0.814823
04-23 20:42:42.469+0200 W/AUL     (12897): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:42:42.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:42:42.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:42:42.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12859
04-23 20:42:42.469+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:42:42.479+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12859
04-23 20:42:42.479+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12859)
04-23 20:42:42.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:42.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:530,0.033571,9.772280,0.819638
04-23 20:42:42.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:42.719+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:729,0.041105,9.770001,0.846025
04-23 20:42:42.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:42.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:42:929,0.051601,9.771450,0.828546
04-23 20:42:43.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:43.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:43:130,0.052263,9.771645,0.826201
04-23 20:42:43.249+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:42:43.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:43.319+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:43:329,0.047298,9.771239,0.831282
04-23 20:42:43.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:43.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:43:529,0.050997,9.772305,0.818436
04-23 20:42:43.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:43.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:43:729,0.043266,9.770429,0.840975
04-23 20:42:43.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:43.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:43:929,0.033779,9.770183,0.844261
04-23 20:42:44.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:44.119+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:44:129,0.029868,9.770560,0.840027
04-23 20:42:44.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:44.379+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:44:329,0.033621,9.770745,0.837734
04-23 20:42:44.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:44.519+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:44:529,0.042464,9.771560,0.827771
04-23 20:42:44.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:44.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:44:730,0.040498,9.771036,0.834021
04-23 20:42:44.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:44.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:44:932,0.041545,9.771133,0.832833
04-23 20:42:45.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:45.179+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:45:130,0.039883,9.772468,0.817115
04-23 20:42:45.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:45.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:45:330,0.047424,9.773118,0.808890
04-23 20:42:45.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:45.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:45:530,0.045425,9.773028,0.810080
04-23 20:42:45.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:45.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:45:730,0.044026,9.772974,0.810821
04-23 20:42:45.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:45.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:45:930,0.031251,9.771224,0.832214
04-23 20:42:46.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:46.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:46:131,0.053225,9.772896,0.811209
04-23 20:42:46.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:46.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:46:331,0.047705,9.772284,0.818895
04-23 20:42:46.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:46.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:46:531,0.042674,9.770512,0.840039
04-23 20:42:46.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:46.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:46:730,0.041522,9.771613,0.827188
04-23 20:42:46.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:46.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:46:933,0.052793,9.773195,0.807626
04-23 20:42:47.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:47.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:47:130,0.051368,9.773957,0.798438
04-23 20:42:47.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:47.359+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:47:331,0.042731,9.775478,0.780112
04-23 20:42:47.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:47.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:47:530,0.036881,9.776870,0.762786
04-23 20:42:47.729+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:47.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:47:733,0.047323,9.777255,0.757251
04-23 20:42:47.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:47.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:47:931,0.033798,9.776919,0.762289
04-23 20:42:48.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:48.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:48:130,0.040542,9.777200,0.758355
04-23 20:42:48.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:48.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:48:330,0.048086,9.776291,0.769554
04-23 20:42:48.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:48.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:48:530,0.040433,9.774806,0.788622
04-23 20:42:48.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:48.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:48:731,0.034309,9.774361,0.794407
04-23 20:42:48.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:48.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:48:931,0.038152,9.773134,0.809183
04-23 20:42:49.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:49.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:49:131,0.046336,9.773774,0.800985
04-23 20:42:49.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:49.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:49:331,0.060481,9.774161,0.795302
04-23 20:42:49.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:49.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:49:531,0.046409,9.772532,0.815985
04-23 20:42:49.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:49.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:49:731,0.057429,9.772104,0.820400
04-23 20:42:49.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:49.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:49:931,0.048834,9.772347,0.818064
04-23 20:42:50.079+0200 I/servicemanager(12059): es.ugr.frailty.location alive timeout
04-23 20:42:50.079+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:42:50.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:42:50.089+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:42:50.099+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:42:50.099+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 12933
04-23 20:42:50.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.149+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 12933
04-23 20:42:50.149+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(12933) type(svcapp) bg(0)
04-23 20:42:50.159+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [12933]
04-23 20:42:50.159+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12933)
04-23 20:42:50.159+0200 I/servicemanager(12059): es.ugr.frailty.location launch request sent!
04-23 20:42:50.159+0200 I/servicemanager(12059): App control destroyed.
04-23 20:42:50.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:131,0.036951,9.770311,0.842640
04-23 20:42:50.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:50.179+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12933
04-23 20:42:50.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:42:50.189+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12933
04-23 20:42:50.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:50.199+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:42:50.199+0200 E/CAPI_APPFW_APPLICATION(12933): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:50.199+0200 E/CAPI_APPFW_APPLICATION(12933): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:42:50.199+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (12933) was created
04-23 20:42:50.229+0200 W/LOCATION(12933): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:42:50.229+0200 E/LOCATION(12933): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:42:50.229+0200 E/PKGMGR_INFO(12933): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:42:50.229+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:50.249+0200 I/LOCATION(12933): location.c: location_new(269) > method: 0
04-23 20:42:50.249+0200 W/LOCATION(12933): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:50.249+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:50.259+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:50.259+0200 W/LOCATION(12933): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:50.259+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:50.269+0200 W/LOCATION(12933): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:50.269+0200 W/LOCATION(12933): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:50.269+0200 W/LOCATION(12933): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:50.269+0200 W/LOCATION(12933): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:50.289+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:50.299+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:42:50.299+0200 W/LOCATION(12933): module-internal.c: module_new(311) > module (wps) open success
04-23 20:42:50.299+0200 W/LOCATION(12933): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:42:50.309+0200 W/LOCATION(12933): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:42:50.309+0200 W/LOCATION(12933): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:50.309+0200 W/LOCATION(12933): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:50.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:331,0.029865,9.768017,0.869098
04-23 20:42:50.329+0200 W/LOCATION(12933): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:42:50.329+0200 I/LOCATION(12933): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7f88c18
04-23 20:42:50.329+0200 I/LOCATION(12933): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:42:50.339+0200 I/LOCATION(12933): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7f88c18
04-23 20:42:50.339+0200 I/LOCATION(12933): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:42:50.339+0200 I/location(12933): es.ugr.frailty.location: creado servicio de localización
04-23 20:42:50.389+0200 I/LOCATION(12933): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:42:50.429+0200 W/LOCATION(12933): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:50.429+0200 W/LOCATION(12933): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:50.429+0200 I/LOCATION(12933): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:42:50.499+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:42:50.499+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:50.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:50.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:42:50.509+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:42:50.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:42:50.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:42:50.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:42:50.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:42:50.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:42:50.509+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:42:50.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:42:50.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:42:50.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:531,0.035338,9.769841,0.848137
04-23 20:42:50.569+0200 W/LOCATION(12933): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:42:50.569+0200 W/LOCATION(12933): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:42:50.659+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:50.699+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:50.699+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:50.699+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:50.729+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_create(453) > New handle created[0xf79cde00]
04-23 20:42:50.729+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:42:50.729+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:42:50.729+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:42:50.729+0200 I/CAPI_NETWORK_CONNECTION(12139): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:42:50.739+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:50.739+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:50.749+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:42:50.749+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3046014), time2(3032455)
04-23 20:42:50.749+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:42:50.749+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:42:50.749+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:42:50.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:42:50.759+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:50.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:773,0.038989,9.770527,0.840036
04-23 20:42:50.769+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:50.769+0200 E/LOCATION(12139): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:42:50.769+0200 I/LOCATION(12139): location.c: location_new(269) > method: 1
04-23 20:42:50.769+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:42:50.769+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (gps) open success
04-23 20:42:50.769+0200 W/LOCATION(12139): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:42:50.769+0200 W/LOCATION(12139): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:42:50.769+0200 W/LOCATION(12139): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:42:50.769+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:42:50.769+0200 W/LOCATION(12139): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:42:50.779+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:50.789+0200 I/AUL     (12139): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:42:50.789+0200 E/LOCATION(12139): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:42:50.789+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:50.839+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:42:50.869+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.879+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:874,0.038429,9.770498,0.840403
04-23 20:42:50.879+0200 W/LOCATION(12933): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:42:50.879+0200 I/LOCATION(12933): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:50.879+0200 I/LOCATION(12933): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:42:50.879+0200 I/location(12933): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:42:50.889+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.899+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:900,0.038735,9.770313,0.842535
04-23 20:42:50.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.899+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:904,0.038173,9.770550,0.839807
04-23 20:42:50.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:923,0.038334,9.770621,0.838977
04-23 20:42:50.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.919+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:928,0.037832,9.770571,0.839582
04-23 20:42:50.929+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:933,0.037375,9.770258,0.843238
04-23 20:42:50.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.939+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:943,0.036892,9.770280,0.842998
04-23 20:42:50.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:952,0.036005,9.770127,0.844813
04-23 20:42:50.949+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.959+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:960,0.035813,9.770195,0.844033
04-23 20:42:50.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:973,0.035618,9.770346,0.842294
04-23 20:42:50.969+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.979+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:982,0.035198,9.770365,0.842095
04-23 20:42:50.989+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:50.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:50:993,0.034735,9.770143,0.844686
04-23 20:42:50.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:5,0.035065,9.770417,0.841490
04-23 20:42:51.009+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:14,0.036421,9.770904,0.835768
04-23 20:42:51.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:31,0.037365,9.771252,0.831642
04-23 20:42:51.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:51,0.035847,9.771177,0.832587
04-23 20:42:51.059+0200 I/LOCATION(12933): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:42:51.059+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:71,0.035243,9.771007,0.834613
04-23 20:42:51.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:92,0.035122,9.770941,0.835380
04-23 20:42:51.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:111,0.036355,9.771270,0.831475
04-23 20:42:51.119+0200 I/location(12933): es.ugr.frailty.location: waiting for rigth values
04-23 20:42:51.119+0200 W/CAPI_APPFW_APP_CONTROL(12933): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:42:51.119+0200 I/utils   (12933): specific action
04-23 20:42:51.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:131,0.035468,9.771184,0.832521
04-23 20:42:51.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.149+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:151,0.037338,9.771317,0.830879
04-23 20:42:51.159+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.169+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:171,0.037087,9.771248,0.831703
04-23 20:42:51.179+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.189+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:192,0.036318,9.771006,0.834576
04-23 20:42:51.199+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.209+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:211,0.036906,9.771005,0.834564
04-23 20:42:51.219+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:231,0.038496,9.771195,0.832254
04-23 20:42:51.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:251,0.038404,9.771478,0.828936
04-23 20:42:51.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:270,0.038313,9.771646,0.826959
04-23 20:42:51.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:292,0.038228,9.771629,0.827152
04-23 20:42:51.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:311,0.037735,9.771311,0.830926
04-23 20:42:51.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:331,0.036471,9.770965,0.835045
04-23 20:42:51.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:351,0.036624,9.771008,0.834528
04-23 20:42:51.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:370,0.036884,9.770719,0.837901
04-23 20:42:51.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:392,0.036523,9.770656,0.838657
04-23 20:42:51.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:411,0.035388,9.770452,0.841062
04-23 20:42:51.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:430,0.035916,9.770573,0.839641
04-23 20:42:51.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:450,0.034708,9.770433,0.841319
04-23 20:42:51.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.469+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:471,0.035267,9.770802,0.836996
04-23 20:42:51.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:492,0.035207,9.771020,0.834451
04-23 20:42:51.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:510,0.036725,9.771049,0.834059
04-23 20:42:51.519+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.529+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:531,0.035916,9.770947,0.835267
04-23 20:42:51.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.549+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:551,0.035605,9.770893,0.835920
04-23 20:42:51.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.569+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:571,0.033592,9.770669,0.838616
04-23 20:42:51.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:592,0.032818,9.770627,0.839140
04-23 20:42:51.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.609+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:611,0.033686,9.770840,0.836629
04-23 20:42:51.619+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.629+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:631,0.032917,9.770676,0.838566
04-23 20:42:51.669+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.669+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:677,0.032047,9.770754,0.837692
04-23 20:42:51.669+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.679+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:682,0.031591,9.770803,0.837128
04-23 20:42:51.679+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.689+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:51.689+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:51.689+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:51.699+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:701,0.031382,9.770776,0.837466
04-23 20:42:51.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:711,0.030378,9.770593,0.839631
04-23 20:42:51.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:731,0.032262,9.770879,0.836228
04-23 20:42:51.759+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.759+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:767,0.034413,9.771244,0.831856
04-23 20:42:51.769+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.779+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:775,0.035106,9.771580,0.827877
04-23 20:42:51.779+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.789+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:791,0.033931,9.771376,0.830331
04-23 20:42:51.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:810,0.034391,9.771580,0.827907
04-23 20:42:51.829+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.829+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:837,0.034378,9.771691,0.826595
04-23 20:42:51.869+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.879+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:42:51.879+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:882,0.033449,9.771630,0.827351
04-23 20:42:51.879+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.879+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:886,0.033595,9.771625,0.827411
04-23 20:42:51.889+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.889+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:893,0.033540,9.772005,0.822904
04-23 20:42:51.899+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.909+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:911,0.033904,9.771900,0.824138
04-23 20:42:51.919+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.929+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:932,0.034250,9.771867,0.824513
04-23 20:42:51.939+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.949+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:952,0.032311,9.771620,0.827519
04-23 20:42:51.959+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.969+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:971,0.031830,9.771454,0.829496
04-23 20:42:51.979+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:51.989+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:51:992,0.031943,9.771318,0.831086
04-23 20:42:51.999+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.009+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:12,0.033170,9.771396,0.830122
04-23 20:42:52.019+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.029+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:31,0.032194,9.771234,0.832073
04-23 20:42:52.039+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.049+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:52,0.032286,9.771308,0.831190
04-23 20:42:52.069+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.069+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:73,0.032144,9.771410,0.830001
04-23 20:42:52.079+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.089+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:92,0.033147,9.771524,0.828610
04-23 20:42:52.099+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.109+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:111,0.034579,9.771917,0.823901
04-23 20:42:52.119+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.129+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:132,0.033631,9.771914,0.823981
04-23 20:42:52.139+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.219+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:151,0.033310,9.771771,0.825689
04-23 20:42:52.229+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.229+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:237,0.033456,9.771588,0.827840
04-23 20:42:52.229+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.239+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:242,0.032683,9.771536,0.828495
04-23 20:42:52.239+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:249,0.034951,9.772223,0.820252
04-23 20:42:52.249+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.249+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:255,0.034149,9.772508,0.816895
04-23 20:42:52.249+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.259+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:260,0.035284,9.772637,0.815293
04-23 20:42:52.259+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.269+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:271,0.034456,9.773042,0.810465
04-23 20:42:52.279+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.289+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:292,0.033912,9.773210,0.808465
04-23 20:42:52.299+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.309+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:312,0.033824,9.773471,0.805305
04-23 20:42:52.319+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.329+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:331,0.032853,9.773601,0.803766
04-23 20:42:52.339+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.349+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:351,0.031357,9.773726,0.802302
04-23 20:42:52.359+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.369+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:372,0.030053,9.773868,0.800620
04-23 20:42:52.379+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.389+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:392,0.029719,9.773982,0.799232
04-23 20:42:52.399+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.409+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:411,0.031166,9.773755,0.801946
04-23 20:42:52.419+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.429+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:432,0.030609,9.773804,0.801380
04-23 20:42:52.439+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.449+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:451,0.030675,9.773733,0.802239
04-23 20:42:52.459+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.469+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:471,0.031971,9.773755,0.801915
04-23 20:42:52.479+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.489+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:492,0.032288,9.773598,0.803816
04-23 20:42:52.499+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.509+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:511,0.032366,9.773618,0.803575
04-23 20:42:52.529+0200 W/LOCATION(12933): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:42:52.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.539+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:543,0.033007,9.773460,0.805465
04-23 20:42:52.539+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.559+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:555,0.031439,9.773346,0.806912
04-23 20:42:52.559+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.569+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:571,0.030439,9.773049,0.810529
04-23 20:42:52.579+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.589+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:592,0.031064,9.772965,0.811520
04-23 20:42:52.599+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.609+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:612,0.029544,9.773076,0.810239
04-23 20:42:52.619+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.629+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:631,0.027300,9.773189,0.808965
04-23 20:42:52.639+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.649+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:651,0.027660,9.773284,0.807796
04-23 20:42:52.659+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.669+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:672,0.027893,9.773441,0.805891
04-23 20:42:52.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:42:52.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:42:52.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:42:52.689+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.689+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:694,0.027766,9.773631,0.803588
04-23 20:42:52.699+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.709+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:713,0.026962,9.773834,0.801139
04-23 20:42:52.719+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.729+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:732,0.027339,9.774103,0.797840
04-23 20:42:52.739+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.769+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:752,0.026684,9.774155,0.797227
04-23 20:42:52.769+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.799+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:787,0.028202,9.774277,0.795683
04-23 20:42:52.799+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.809+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:807,0.029004,9.774725,0.790120
04-23 20:42:52.809+0200 I/gravity (12777): capturing data from es.ugr.frailty.gravity
04-23 20:42:52.819+0200 I/gravity (12777): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:42:52:820,0.028140,9.775002,0.786717
04-23 20:42:52.819+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11129336c6f63152450897
