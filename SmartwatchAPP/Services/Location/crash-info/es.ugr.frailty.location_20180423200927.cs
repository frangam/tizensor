S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7145
Date: 2018-04-23 20:09:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72bc52d, r5   = 0xf7b21f98
r6   = 0xff965f30, r7   = 0xff965de0
r8   = 0xf7b1ec18, r9   = 0x00000000
r10  = 0xff965ebc, fp   = 0xff965f30
ip   = 0x00000001, sp   = 0xff965db8
lr   = 0xf72bc539, pc   = 0xf7325228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     97040 KB
Buffers:     39944 KB
Cached:     186164 KB
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
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7145 TID = 7145
7145 7148 

Maps Information
f4187000 f4986000 rw-p [stack:7148]
f498d000 f498f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4997000 f499b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49a4000 f49a6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49ae000 f49b1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49c0000 f49c5000 r-xp /usr/lib/libsystem.so.0.0.0
f49d0000 f49d3000 r-xp /lib/libattr.so.1.1.0
f49db000 f49eb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49f3000 f49fc000 r-xp /usr/lib/libedbus.so.1.7.99
f4a04000 f4a05000 r-xp /usr/lib/libresponse.so.0.2.96
f4a0e000 f4a13000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62b5000 f63bb000 r-xp /usr/lib/libicuuc.so.57.1
f63d1000 f6559000 r-xp /usr/lib/libicui18n.so.57.1
f6569000 f6576000 r-xp /usr/lib/libail.so.0.1.0
f657f000 f6586000 r-xp /usr/lib/libminizip.so.1.0.0
f658f000 f6738000 r-xp /usr/lib/libcrypto.so.1.0.0
f6758000 f679f000 r-xp /usr/lib/libssl.so.1.0.0
f67ab000 f67ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67b5000 f67bc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67c5000 f67cc000 r-xp /lib/libcrypt-2.13.so
f67fd000 f6800000 r-xp /lib/libcap.so.2.21
f6808000 f680a000 r-xp /usr/lib/libiri.so
f6812000 f685b000 r-xp /usr/lib/libmdm.so.1.2.69
f6863000 f6869000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6871000 f6894000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f689e000 f68a0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68a8000 f68c5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68ce000 f68d2000 r-xp /usr/lib/libsmack.so.1.0.0
f68db000 f68f4000 r-xp /usr/lib/libnetwork.so.0.0.0
f68fd000 f6905000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f690d000 f6913000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f691c000 f691e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6927000 f6937000 r-xp /lib/libresolv-2.13.so
f693b000 f6953000 r-xp /usr/lib/liblzma.so.5.0.3
f695c000 f695e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6966000 f6980000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6988000 f69b7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69c0000 f69cf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69d9000 f69e3000 r-xp /usr/lib/libsensord-shared.so
f69ec000 f6abf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aca000 f6ae0000 r-xp /lib/libz.so.1.2.5
f6ae8000 f6aed000 r-xp /usr/lib/libffi.so.5.0.10
f6af5000 f6af6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6afe000 f6b0e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b16000 f6b2f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b37000 f6b39000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b41000 f6bb6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bc0000 f6bc6000 r-xp /lib/librt-2.13.so
f6bcf000 f6bed000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bf7000 f6bf8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c00000 f6c23000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c2b000 f6c30000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c38000 f6c62000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c6b000 f6c82000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c8a000 f6cf3000 r-xp /lib/libm-2.13.so
f6cfc000 f6d90000 r-xp /usr/lib/libstdc++.so.6.0.16
f6da3000 f6da8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6db0000 f6db7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dbf000 f6de9000 r-xp /usr/lib/libsensor.so.1.9.6
f6df2000 f6ebe000 r-xp /usr/lib/libxml2.so.2.7.8
f6ecb000 f6ecd000 r-xp /usr/lib/libiniparser.so.0
f6ed6000 f6edc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ee5000 f6fb5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fb6000 f6fea000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ff3000 f702f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7037000 f703a000 r-xp /usr/lib/libbundle.so.0.1.22
f7042000 f7048000 r-xp /usr/lib/libappsvc.so.0.1.0
f7050000 f7091000 r-xp /usr/lib/libeina.so.1.7.99
f709a000 f70b1000 r-xp /usr/lib/libecore.so.1.7.99
f70c8000 f70d1000 r-xp /usr/lib/libvconf.so.0.2.45
f70d9000 f70ed000 r-xp /lib/libpthread-2.13.so
f70f8000 f7105000 r-xp /usr/lib/libaul.so.0.1.0
f710f000 f7111000 r-xp /lib/libdl-2.13.so
f711a000 f7125000 r-xp /lib/libunwind.so.8.0.1
f7152000 f715a000 r-xp /lib/libgcc_s-4.6.so.1
f715b000 f727f000 r-xp /lib/libc-2.13.so
f728d000 f728f000 r-xp /usr/lib/libdlog.so.0.0.0
f7297000 f72a3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72ac000 f72b1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72b9000 f72c8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72d0000 f72d4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72dd000 f72e0000 r-xp /usr/lib/libappcore-agent.so.1.1
f72e8000 f72ea000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72f2000 f72f6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72fe000 f731b000 r-xp /lib/ld-2.13.so
f7324000 f7327000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7327000 f732b000 r-xp /usr/lib/libsys-assert.so
f7aee000 f7b7c000 rw-p [heap]
ff947000 ff968000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7145)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7325228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72bc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fc33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fc1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fcde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fd3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fd3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf700875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70031f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fc1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fcde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fd3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fd3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7005e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7006017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf700df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49a51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4998171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a6b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f18fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f1a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70aaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70a5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70a65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70a6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72de183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72de7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73254f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf717285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7324f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
5) > Fail to get app_id. Err[-1]
04-23 20:09:17.259+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:17.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:17.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:17.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:17.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:17.259+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:17.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:17.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:17.269+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:17.279+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:17.279+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:17.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:17.319+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.319+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:324,0.044571,9.772943,0.811171
04-23 20:09:17.339+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:17.349+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:09:17.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:09:17.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:09:17.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e7788
04-23 20:09:17.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.479+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:487,0.043149,9.772866,0.812158
04-23 20:09:17.489+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.499+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:503,0.043183,9.772834,0.812545
04-23 20:09:17.509+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:515,0.043102,9.772824,0.812674
04-23 20:09:17.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.519+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:528,0.043241,9.772768,0.813334
04-23 20:09:17.529+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.539+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:544,0.048316,9.773007,0.810168
04-23 20:09:17.549+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.559+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:560,0.043693,9.772781,0.813156
04-23 20:09:17.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:572,0.044019,9.772773,0.813241
04-23 20:09:17.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:590,0.044232,9.772681,0.814323
04-23 20:09:17.609+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.609+0200 W/AUL     ( 7108): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:09:17.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:09:17.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:09:17.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7073
04-23 20:09:17.619+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:09:17.619+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7073
04-23 20:09:17.619+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7073)
04-23 20:09:17.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:629,0.043057,9.772763,0.813404
04-23 20:09:17.629+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:637,0.045906,9.772663,0.814452
04-23 20:09:17.629+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.639+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:642,0.045135,9.772640,0.814771
04-23 20:09:17.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:648,0.045179,9.772725,0.813747
04-23 20:09:17.649+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:658,0.046955,9.773028,0.809995
04-23 20:09:17.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.659+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:666,0.049421,9.773226,0.807464
04-23 20:09:17.659+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.669+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:672,0.050189,9.773263,0.806967
04-23 20:09:17.669+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:681,0.049771,9.773252,0.807125
04-23 20:09:17.679+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.679+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:686,0.049822,9.773298,0.806565
04-23 20:09:17.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.689+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:694,0.050789,9.773389,0.805407
04-23 20:09:17.689+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.699+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:699,0.049420,9.773442,0.804845
04-23 20:09:17.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.699+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:706,0.051856,9.773396,0.805241
04-23 20:09:17.699+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:713,0.052386,9.773507,0.803864
04-23 20:09:17.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.719+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:721,0.052542,9.773570,0.803085
04-23 20:09:17.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:732,0.052946,9.773681,0.801715
04-23 20:09:17.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:736,0.053188,9.773626,0.802364
04-23 20:09:17.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.739+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:741,0.052520,9.773523,0.803658
04-23 20:09:17.739+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.739+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:746,0.051648,9.773506,0.803926
04-23 20:09:17.739+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:753,0.050696,9.773547,0.803490
04-23 20:09:17.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.749+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:757,0.050028,9.773535,0.803682
04-23 20:09:17.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:764,0.057446,9.773952,0.798100
04-23 20:09:17.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:772,0.053705,9.774858,0.787173
04-23 20:09:17.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:17.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:17:972,0.054363,9.774286,0.794202
04-23 20:09:18.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:18.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:18:172,0.058813,9.774886,0.786463
04-23 20:09:18.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:18.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:18:372,0.052964,9.774570,0.790799
04-23 20:09:18.379+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:09:18.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:18.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:18:572,0.060335,9.775240,0.781936
04-23 20:09:18.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:18.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:18:772,0.060337,9.774873,0.786514
04-23 20:09:18.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:18.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:18:972,0.056425,9.774571,0.790544
04-23 20:09:19.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:19.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:19:171,0.051329,9.774333,0.793830
04-23 20:09:19.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:19.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:19:372,0.060731,9.774467,0.791504
04-23 20:09:19.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:19.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:19:573,0.061524,9.774155,0.795300
04-23 20:09:19.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:19.779+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:19:772,0.049978,9.773768,0.800834
04-23 20:09:19.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:19.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:19:972,0.058980,9.773853,0.799181
04-23 20:09:20.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:20.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:20:173,0.065807,9.773874,0.798393
04-23 20:09:20.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:20.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:20:372,0.064893,9.772642,0.813416
04-23 20:09:20.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:20.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:20:573,0.065058,9.774244,0.793911
04-23 20:09:20.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:20.809+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:20:771,0.051044,9.772905,0.811228
04-23 20:09:20.969+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:20.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:20:973,0.045507,9.772703,0.813991
04-23 20:09:21.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:21.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:21:171,0.051310,9.771667,0.825998
04-23 20:09:21.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:21.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:21:370,0.060695,9.772102,0.820193
04-23 20:09:21.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:21.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:21:571,0.059855,9.772691,0.813210
04-23 20:09:21.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:21.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:21:772,0.055243,9.773108,0.808518
04-23 20:09:21.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:21.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:21:971,0.061054,9.773257,0.806286
04-23 20:09:22.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:22.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:22:171,0.055961,9.773612,0.802346
04-23 20:09:22.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:22.419+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:22:370,0.051102,9.772310,0.818363
04-23 20:09:22.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:22.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:22:571,0.053540,9.772460,0.816416
04-23 20:09:22.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:22.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:22:770,0.061376,9.772769,0.812158
04-23 20:09:22.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:22.999+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:22:971,0.056194,9.773048,0.809170
04-23 20:09:23.169+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:23.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:23:173,0.060064,9.773936,0.798090
04-23 20:09:23.369+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:23.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:23:373,0.047410,9.773314,0.806525
04-23 20:09:23.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:23.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:23:571,0.042991,9.772577,0.815639
04-23 20:09:23.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:23.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:23:770,0.048085,9.773347,0.806084
04-23 20:09:23.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:23.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:23:970,0.053330,9.773368,0.805498
04-23 20:09:24.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:24.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:24:171,0.044574,9.773294,0.806920
04-23 20:09:24.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:24.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:24:369,0.051554,9.774750,0.788660
04-23 20:09:24.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:24.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:24:570,0.052215,9.775757,0.776042
04-23 20:09:24.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:24.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:24:771,0.050269,9.774920,0.786632
04-23 20:09:24.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:24.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:24:970,0.036995,9.773660,0.802859
04-23 20:09:25.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:25.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:25:170,0.047090,9.773748,0.801255
04-23 20:09:25.179+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:09:25.179+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:09:25.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:25.179+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:25.189+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7145
04-23 20:09:25.189+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:09:25.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7145
04-23 20:09:25.239+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7145) type(svcapp) bg(0)
04-23 20:09:25.239+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7145)
04-23 20:09:25.239+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:09:25.239+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:09:25.239+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7145]
04-23 20:09:25.239+0200 E/CAPI_APPFW_APPLICATION( 7145): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:25.239+0200 E/CAPI_APPFW_APPLICATION( 7145): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:09:25.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:25.279+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7145
04-23 20:09:25.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:09:25.279+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7145
04-23 20:09:25.279+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7145) was created
04-23 20:09:25.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:25.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:09:25.309+0200 W/LOCATION( 7145): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:09:25.309+0200 E/LOCATION( 7145): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:09:25.309+0200 E/PKGMGR_INFO( 7145): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:09:25.309+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:25.329+0200 I/LOCATION( 7145): location.c: location_new(269) > method: 0
04-23 20:09:25.329+0200 W/LOCATION( 7145): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:25.339+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:25.339+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:25.349+0200 W/LOCATION( 7145): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:25.349+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:25.359+0200 W/LOCATION( 7145): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:25.359+0200 W/LOCATION( 7145): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:25.359+0200 W/LOCATION( 7145): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:25.359+0200 W/LOCATION( 7145): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:25.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:25.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:25:371,0.055447,9.773672,0.801650
04-23 20:09:25.389+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:25.389+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:09:25.399+0200 W/LOCATION( 7145): module-internal.c: module_new(311) > module (wps) open success
04-23 20:09:25.399+0200 W/LOCATION( 7145): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:09:25.409+0200 W/LOCATION( 7145): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:09:25.409+0200 W/LOCATION( 7145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:25.409+0200 W/LOCATION( 7145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:25.419+0200 W/LOCATION( 7145): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:09:25.419+0200 I/LOCATION( 7145): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b1ec18
04-23 20:09:25.419+0200 I/LOCATION( 7145): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:09:25.429+0200 I/LOCATION( 7145): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b1ec18
04-23 20:09:25.429+0200 I/LOCATION( 7145): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:09:25.429+0200 I/location( 7145): es.ugr.frailty.location: creado servicio de localización
04-23 20:09:25.469+0200 I/LOCATION( 7145): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:09:25.509+0200 W/LOCATION( 7145): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:25.509+0200 W/LOCATION( 7145): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:25.509+0200 I/LOCATION( 7145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:25.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:25.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:25:570,0.049580,9.774340,0.793863
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:09:25.589+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:09:25.589+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:25.589+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:25.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:09:25.599+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:09:25.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:09:25.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:09:25.599+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:09:25.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:09:25.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:09:25.599+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:09:25.599+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:09:25.599+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:09:25.649+0200 W/LOCATION( 7145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:09:25.649+0200 W/LOCATION( 7145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:09:25.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:25.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e7228]
04-23 20:09:25.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:09:25.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:09:25.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:09:25.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:09:25.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:25.769+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:25.769+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:25.779+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:25.789+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:25.789+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:09:25.789+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:09:25.789+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:09:25.789+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:09:25.789+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:09:25.789+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:09:25.789+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:09:25.789+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:09:25.789+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:09:25.799+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:25.809+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:09:25.809+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:09:25.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:25.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:25:778,0.044010,9.776050,0.772857
04-23 20:09:25.839+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:09:25.839+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1041101), time2(1027852)
04-23 20:09:25.839+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:09:25.839+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:09:25.839+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:09:25.839+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:09:25.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:09:25.889+0200 W/LOCATION( 7145): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:09:25.889+0200 I/LOCATION( 7145): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:25.889+0200 I/LOCATION( 7145): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:09:25.889+0200 I/location( 7145): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:09:25.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:25.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:25:970,0.036302,9.777472,0.755047
04-23 20:09:25.979+0200 I/LOCATION( 7145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:09:26.029+0200 E/location( 7145): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:09:26.029+0200 W/AUL     ( 7145): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:09:26.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:26.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7145
04-23 20:09:26.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:09:26.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.039+0200 I/utils   ( 5532): specific action
04-23 20:09:26.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.039+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:09:26.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:09:26.049+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:09:26.049+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:09:26.049+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:26.049+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:09:26.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:09:26.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5538), cmd(0)
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 I/utils   ( 5538): specific action
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:09:26.059+0200 I/recorder( 5538): guardando datos en local
04-23 20:09:26.059+0200 W/AUL     ( 7145): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:09:26.059+0200 I/location( 7145): request sent to service es.ugr.frailty.servicemanager
04-23 20:09:26.059+0200 W/CAPI_APPFW_APP_CONTROL( 7145): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:09:26.059+0200 I/utils   ( 7145): specific action
04-23 20:09:26.059+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:09:26.059+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:09:26.059+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:09:26.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:170,0.040776,9.778388,0.742860
04-23 20:09:26.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:26.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:26.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:26.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:372,0.051533,9.777295,0.756458
04-23 20:09:26.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:391,0.051658,9.777419,0.754841
04-23 20:09:26.399+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:410,0.051550,9.777332,0.755979
04-23 20:09:26.419+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:430,0.051342,9.777385,0.755310
04-23 20:09:26.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:452,0.052039,9.777265,0.756820
04-23 20:09:26.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:470,0.052118,9.777201,0.757633
04-23 20:09:26.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:490,0.053306,9.776977,0.760436
04-23 20:09:26.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:511,0.052054,9.776857,0.762064
04-23 20:09:26.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:530,0.052351,9.776800,0.762771
04-23 20:09:26.539+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.549+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:552,0.051262,9.776644,0.764851
04-23 20:09:26.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:571,0.052945,9.776469,0.766957
04-23 20:09:26.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:590,0.053076,9.776586,0.765474
04-23 20:09:26.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:610,0.051413,9.776339,0.768732
04-23 20:09:26.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.629+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:631,0.051270,9.776238,0.770008
04-23 20:09:26.639+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.649+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:653,0.049689,9.776173,0.770956
04-23 20:09:26.709+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:719,0.049056,9.776137,0.771433
04-23 20:09:26.719+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.729+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:729,0.049267,9.776053,0.772487
04-23 20:09:26.729+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.739+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:743,0.048090,9.775969,0.773631
04-23 20:09:26.749+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.759+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:759,0.048690,9.775739,0.776496
04-23 20:09:26.759+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:767,0.047515,9.775757,0.776342
04-23 20:09:26.769+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.769+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:776,0.046995,9.775549,0.778985
04-23 20:09:26.789+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.819+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:823,0.047850,9.775412,0.780661
04-23 20:09:26.839+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:09:26.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.849+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:858,0.047660,9.775186,0.783497
04-23 20:09:26.849+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.859+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:862,0.048390,9.775132,0.784119
04-23 20:09:26.859+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.859+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:866,0.048396,9.775132,0.784108
04-23 20:09:26.869+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.869+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:874,0.049072,9.774954,0.786297
04-23 20:09:26.879+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.889+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:891,0.047350,9.774817,0.788098
04-23 20:09:26.899+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.909+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:911,0.049312,9.774698,0.789450
04-23 20:09:26.919+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.929+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:931,0.048925,9.774650,0.790077
04-23 20:09:26.949+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.949+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:953,0.048908,9.774445,0.792608
04-23 20:09:26.959+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.969+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:972,0.048777,9.774398,0.793186
04-23 20:09:26.979+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:26.989+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:26:991,0.048184,9.774364,0.793642
04-23 20:09:26.999+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.009+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:11,0.047854,9.774270,0.794817
04-23 20:09:27.019+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.029+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:31,0.045472,9.774178,0.796095
04-23 20:09:27.049+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.049+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:53,0.045270,9.774123,0.796778
04-23 20:09:27.059+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.069+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:71,0.043874,9.773865,0.800013
04-23 20:09:27.079+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.089+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:91,0.045268,9.773833,0.800330
04-23 20:09:27.099+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.109+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:112,0.045796,9.773690,0.802038
04-23 20:09:27.119+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.129+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:131,0.047421,9.773782,0.800831
04-23 20:09:27.139+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.149+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:152,0.046896,9.773729,0.801500
04-23 20:09:27.159+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.169+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:171,0.048676,9.773722,0.801481
04-23 20:09:27.179+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.189+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:191,0.046759,9.773540,0.803820
04-23 20:09:27.199+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.259+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:211,0.046168,9.773560,0.803609
04-23 20:09:27.259+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.279+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:272,0.045929,9.773582,0.803349
04-23 20:09:27.279+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.279+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:284,0.045258,9.773471,0.804740
04-23 20:09:27.279+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.289+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:288,0.046877,9.773436,0.805078
04-23 20:09:27.289+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.289+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:294,0.045360,9.773347,0.806232
04-23 20:09:27.299+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.309+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:311,0.045052,9.773361,0.806075
04-23 20:09:27.319+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.329+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:331,0.045245,9.773252,0.807399
04-23 20:09:27.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:09:27.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:09:27.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:09:27.349+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.349+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:357,0.044285,9.772999,0.810508
04-23 20:09:27.359+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.369+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:370,0.042876,9.772957,0.811086
04-23 20:09:27.379+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.389+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:391,0.042691,9.772980,0.810818
04-23 20:09:27.399+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.409+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:411,0.043989,9.773138,0.808842
04-23 20:09:27.419+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.429+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:431,0.044882,9.773209,0.807941
04-23 20:09:27.439+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.449+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:452,0.044374,9.773130,0.808909
04-23 20:09:27.459+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.469+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:471,0.044922,9.773252,0.807405
04-23 20:09:27.479+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.489+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:491,0.045877,9.773134,0.808782
04-23 20:09:27.499+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.509+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:511,0.047371,9.773178,0.808168
04-23 20:09:27.519+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.529+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:531,0.045971,9.772947,0.811032
04-23 20:09:27.549+0200 W/LOCATION( 7145): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:09:27.559+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.569+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:571,0.047221,9.773002,0.810305
04-23 20:09:27.569+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.579+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:581,0.047059,9.772904,0.811490
04-23 20:09:27.579+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.589+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:592,0.046354,9.772898,0.811604
04-23 20:09:27.599+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.609+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:611,0.046113,9.772776,0.813086
04-23 20:09:27.619+0200 I/gravity ( 6942): capturing data from es.ugr.frailty.gravity
04-23 20:09:27.709+0200 I/gravity ( 6942): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:09:27:631,0.046112,9.772779,0.813054
04-23 20:09:27.739+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11071456c6f63152450696
