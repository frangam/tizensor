S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9833
Date: 2018-04-23 20:31:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73fc52d, r5   = 0xf7b76f98
r6   = 0xffe229b0, r7   = 0xffe22860
r8   = 0xf7b73c18, r9   = 0x00000000
r10  = 0xffe2293c, fp   = 0xffe229b0
ip   = 0x00000001, sp   = 0xffe22838
lr   = 0xf73fc539, pc   = 0xf7465228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    133344 KB
Buffers:     35824 KB
Cached:     154720 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11984 KB
VmRSS:       11984 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9833 TID = 9833
9833 9836 

Maps Information
f42c7000 f4ac6000 rw-p [stack:9836]
f4acd000 f4acf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ad7000 f4adb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ae4000 f4ae6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4aee000 f4af1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b00000 f4b05000 r-xp /usr/lib/libsystem.so.0.0.0
f4b10000 f4b13000 r-xp /lib/libattr.so.1.1.0
f4b1b000 f4b2b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b33000 f4b3c000 r-xp /usr/lib/libedbus.so.1.7.99
f4b44000 f4b45000 r-xp /usr/lib/libresponse.so.0.2.96
f4b4e000 f4b53000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63f5000 f64fb000 r-xp /usr/lib/libicuuc.so.57.1
f6511000 f6699000 r-xp /usr/lib/libicui18n.so.57.1
f66a9000 f66b6000 r-xp /usr/lib/libail.so.0.1.0
f66bf000 f66c6000 r-xp /usr/lib/libminizip.so.1.0.0
f66cf000 f6878000 r-xp /usr/lib/libcrypto.so.1.0.0
f6898000 f68df000 r-xp /usr/lib/libssl.so.1.0.0
f68eb000 f68ed000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68f5000 f68fc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6905000 f690c000 r-xp /lib/libcrypt-2.13.so
f693d000 f6940000 r-xp /lib/libcap.so.2.21
f6948000 f694a000 r-xp /usr/lib/libiri.so
f6952000 f699b000 r-xp /usr/lib/libmdm.so.1.2.69
f69a3000 f69a9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69b1000 f69d4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69de000 f69e0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69e8000 f6a05000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a0e000 f6a12000 r-xp /usr/lib/libsmack.so.1.0.0
f6a1b000 f6a34000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a3d000 f6a45000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a4d000 f6a53000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a5c000 f6a5e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a67000 f6a77000 r-xp /lib/libresolv-2.13.so
f6a7b000 f6a93000 r-xp /usr/lib/liblzma.so.5.0.3
f6a9c000 f6a9e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aa6000 f6ac0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ac8000 f6af7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b00000 f6b0f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b19000 f6b23000 r-xp /usr/lib/libsensord-shared.so
f6b2c000 f6bff000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c0a000 f6c20000 r-xp /lib/libz.so.1.2.5
f6c28000 f6c2d000 r-xp /usr/lib/libffi.so.5.0.10
f6c35000 f6c36000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c3e000 f6c4e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c56000 f6c6f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c77000 f6c79000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c81000 f6cf6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d00000 f6d06000 r-xp /lib/librt-2.13.so
f6d0f000 f6d2d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d37000 f6d38000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d40000 f6d63000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d6b000 f6d70000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d78000 f6da2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dab000 f6dc2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dca000 f6e33000 r-xp /lib/libm-2.13.so
f6e3c000 f6ed0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ee3000 f6ee8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ef0000 f6ef7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6eff000 f6f29000 r-xp /usr/lib/libsensor.so.1.9.6
f6f32000 f6ffe000 r-xp /usr/lib/libxml2.so.2.7.8
f700b000 f700d000 r-xp /usr/lib/libiniparser.so.0
f7016000 f701c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7025000 f70f5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70f6000 f712a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7133000 f716f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7177000 f717a000 r-xp /usr/lib/libbundle.so.0.1.22
f7182000 f7188000 r-xp /usr/lib/libappsvc.so.0.1.0
f7190000 f71d1000 r-xp /usr/lib/libeina.so.1.7.99
f71da000 f71f1000 r-xp /usr/lib/libecore.so.1.7.99
f7208000 f7211000 r-xp /usr/lib/libvconf.so.0.2.45
f7219000 f722d000 r-xp /lib/libpthread-2.13.so
f7238000 f7245000 r-xp /usr/lib/libaul.so.0.1.0
f724f000 f7251000 r-xp /lib/libdl-2.13.so
f725a000 f7265000 r-xp /lib/libunwind.so.8.0.1
f7292000 f729a000 r-xp /lib/libgcc_s-4.6.so.1
f729b000 f73bf000 r-xp /lib/libc-2.13.so
f73cd000 f73cf000 r-xp /usr/lib/libdlog.so.0.0.0
f73d7000 f73e3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ec000 f73f1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73f9000 f7408000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7410000 f7414000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f741d000 f7420000 r-xp /usr/lib/libappcore-agent.so.1.1
f7428000 f742a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7432000 f7436000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f743e000 f745b000 r-xp /lib/ld-2.13.so
f7464000 f7467000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7467000 f746b000 r-xp /usr/lib/libsys-assert.so
f7b43000 f7bd1000 rw-p [heap]
ffe04000 ffe25000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9833)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7465228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73fc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71033f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7101c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf710de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7113be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7113dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf714875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71431f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7101c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf710de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7113be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7113dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7145e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7146017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf714df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ae51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ad8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bab663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7058fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf705a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71eaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71e5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71e65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71e6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf741e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf741e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74654f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72b285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7464f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
remote_gps) open success
04-23 20:31:38.109+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:38.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:38.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:38.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:38.129+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:38.129+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:38.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:38.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:38.189+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:31:38.189+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:31:38.189+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:31:38.189+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4005920
04-23 20:31:38.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:37:603,0.025517,9.778208,0.745916
04-23 20:31:38.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.249+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:249,0.024943,9.778273,0.745078
04-23 20:31:38.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:306,0.024161,9.778427,0.743081
04-23 20:31:38.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:324,0.024516,9.778087,0.747534
04-23 20:31:38.329+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.329+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:333,0.023715,9.777915,0.749798
04-23 20:31:38.329+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:341,0.025567,9.777357,0.756979
04-23 20:31:38.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:355,0.025410,9.777015,0.761389
04-23 20:31:38.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:372,0.025266,9.776781,0.764388
04-23 20:31:38.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:386,0.024331,9.776533,0.767584
04-23 20:31:38.389+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:401,0.024964,9.776706,0.765370
04-23 20:31:38.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.409+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:411,0.023254,9.776984,0.761855
04-23 20:31:38.409+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:416,0.024935,9.776977,0.761904
04-23 20:31:38.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.439+0200 W/AUL     ( 9791): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:31:38.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:31:38.439+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:31:38.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9751
04-23 20:31:38.439+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:31:38.439+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9751
04-23 20:31:38.449+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9751)
04-23 20:31:38.449+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:429,0.023013,9.777205,0.759032
04-23 20:31:38.449+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:463,0.022972,9.776902,0.762912
04-23 20:31:38.469+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.469+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:474,0.023922,9.777085,0.760530
04-23 20:31:38.469+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:481,0.023074,9.777319,0.757553
04-23 20:31:38.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:486,0.022173,9.777369,0.756937
04-23 20:31:38.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:490,0.020831,9.777636,0.753517
04-23 20:31:38.489+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:497,0.023325,9.777432,0.756074
04-23 20:31:38.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:504,0.024864,9.777088,0.760472
04-23 20:31:38.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:508,0.024735,9.776892,0.762999
04-23 20:31:38.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:514,0.024385,9.776664,0.765920
04-23 20:31:38.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:520,0.025304,9.776317,0.770306
04-23 20:31:38.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.529+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:529,0.024345,9.776189,0.771958
04-23 20:31:38.529+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.529+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:535,0.025178,9.776173,0.772137
04-23 20:31:38.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:543,0.026349,9.776468,0.768344
04-23 20:31:38.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.549+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:548,0.025169,9.776600,0.766707
04-23 20:31:38.549+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.549+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:555,0.024511,9.776770,0.764561
04-23 20:31:38.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:564,0.024656,9.776781,0.764416
04-23 20:31:38.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:569,0.023994,9.776901,0.762891
04-23 20:31:38.569+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.569+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:573,0.023897,9.776843,0.763650
04-23 20:31:38.569+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:582,0.023507,9.776956,0.762220
04-23 20:31:38.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:587,0.023029,9.776952,0.762273
04-23 20:31:38.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.589+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:591,0.023445,9.776624,0.766465
04-23 20:31:38.589+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.589+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:595,0.024455,9.776743,0.764908
04-23 20:31:38.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:604,0.024841,9.776318,0.770313
04-23 20:31:38.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:608,0.024939,9.776194,0.771875
04-23 20:31:38.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.609+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:614,0.008001,9.771049,0.834812
04-23 20:31:38.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:705,0.029581,9.771156,0.833077
04-23 20:31:38.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:38.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:38:911,0.047946,9.772919,0.811266
04-23 20:31:39.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:39.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:39:104,0.044930,9.773320,0.806583
04-23 20:31:39.169+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:31:39.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:39.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:39:305,0.032591,9.772003,0.822964
04-23 20:31:39.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:39.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:39:504,0.028265,9.772167,0.821178
04-23 20:31:39.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:39.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:39:704,0.021339,9.770423,0.841883
04-23 20:31:39.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:39.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:39:905,0.035835,9.773355,0.806625
04-23 20:31:40.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:40.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:40:104,0.038607,9.774570,0.791639
04-23 20:31:40.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:40.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:40:304,0.039621,9.774363,0.794134
04-23 20:31:40.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:40.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:40:504,0.033959,9.773389,0.806288
04-23 20:31:40.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:40.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:40:705,0.053358,9.775434,0.780010
04-23 20:31:40.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:40.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:40:910,0.062679,9.777316,0.755343
04-23 20:31:41.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:41.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:41:104,0.047717,9.778358,0.742853
04-23 20:31:41.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:41.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:41:304,0.037046,9.778970,0.735367
04-23 20:31:41.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:41.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:41:504,0.021047,9.781498,0.701600
04-23 20:31:41.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:41.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:41:705,0.023899,9.780588,0.714082
04-23 20:31:41.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:41.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:41:913,0.015402,9.783409,0.674576
04-23 20:31:42.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:42.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:42:104,0.018656,9.784138,0.663846
04-23 20:31:42.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:42.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:42:313,0.015260,9.780024,0.722003
04-23 20:31:42.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:42.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:42:504,0.012830,9.776329,0.770464
04-23 20:31:42.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:42.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:42:704,0.008731,9.772253,0.820602
04-23 20:31:42.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:42.939+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:42:904,0.013136,9.769585,0.851723
04-23 20:31:43.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:43.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:43:103,0.008103,9.760698,0.948205
04-23 20:31:43.289+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:43.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:43:302,0.015983,9.770356,0.842773
04-23 20:31:43.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:43.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:43:504,0.014065,9.767573,0.874469
04-23 20:31:43.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:43.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:43:703,0.039057,9.773186,0.808522
04-23 20:31:43.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:43.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:43:903,0.022953,9.771012,0.834974
04-23 20:31:44.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:44.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:44:104,0.034647,9.774290,0.795254
04-23 20:31:44.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:44.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:44:303,0.037657,9.773958,0.799188
04-23 20:31:44.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:44.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:44:503,0.039579,9.774325,0.794589
04-23 20:31:44.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:44.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:44:704,0.033723,9.772902,0.812184
04-23 20:31:44.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:44.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:44:903,0.028249,9.771751,0.826113
04-23 20:31:45.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:45.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:45:103,0.023008,9.770158,0.844912
04-23 20:31:45.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:45.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:45:304,0.035359,9.771387,0.830137
04-23 20:31:45.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:45.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:45:504,0.031758,9.771694,0.826656
04-23 20:31:45.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:45.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:45:704,0.049996,9.772758,0.813072
04-23 20:31:45.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:45.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:45:904,0.062406,9.773458,0.803742
04-23 20:31:45.929+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:31:45.929+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:31:45.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:45.939+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:45.949+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9833
04-23 20:31:45.949+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:31:45.999+0200 E/CAPI_APPFW_APPLICATION( 9833): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:45.999+0200 E/CAPI_APPFW_APPLICATION( 9833): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:45.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9833
04-23 20:31:45.999+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9833) type(svcapp) bg(0)
04-23 20:31:45.999+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9833)
04-23 20:31:45.999+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:31:45.999+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:31:45.999+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9833]
04-23 20:31:45.999+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9833) was created
04-23 20:31:46.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:46.029+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9833
04-23 20:31:46.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:46.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:46.039+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9833
04-23 20:31:46.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:46.069+0200 W/LOCATION( 9833): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:31:46.069+0200 E/LOCATION( 9833): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:31:46.069+0200 E/PKGMGR_INFO( 9833): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:31:46.069+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:46.089+0200 I/LOCATION( 9833): location.c: location_new(269) > method: 0
04-23 20:31:46.089+0200 W/LOCATION( 9833): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:46.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:46.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:46:103,0.045199,9.771767,0.825175
04-23 20:31:46.099+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:46.109+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:46.109+0200 W/LOCATION( 9833): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:46.119+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:46.119+0200 W/LOCATION( 9833): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:46.119+0200 W/LOCATION( 9833): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:46.119+0200 W/LOCATION( 9833): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:46.119+0200 W/LOCATION( 9833): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:46.139+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:46.139+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:46.139+0200 W/LOCATION( 9833): module-internal.c: module_new(311) > module (wps) open success
04-23 20:31:46.149+0200 W/LOCATION( 9833): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:31:46.149+0200 W/LOCATION( 9833): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:31:46.149+0200 W/LOCATION( 9833): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:46.149+0200 W/LOCATION( 9833): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:46.169+0200 W/LOCATION( 9833): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:31:46.169+0200 I/LOCATION( 9833): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7b73c18
04-23 20:31:46.169+0200 I/LOCATION( 9833): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:31:46.169+0200 I/LOCATION( 9833): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7b73c18
04-23 20:31:46.169+0200 I/LOCATION( 9833): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:31:46.169+0200 I/location( 9833): es.ugr.frailty.location: creado servicio de localización
04-23 20:31:46.219+0200 I/LOCATION( 9833): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:31:46.259+0200 W/LOCATION( 9833): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:46.259+0200 W/LOCATION( 9833): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:46.259+0200 I/LOCATION( 9833): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:46.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:46.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:46:307,0.038292,9.772269,0.819553
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:31:46.339+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:31:46.339+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:46.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:31:46.339+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:31:46.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:31:46.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:31:46.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:31:46.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:31:46.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:31:46.339+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:31:46.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:31:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:31:46.389+0200 W/LOCATION( 9833): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:46.389+0200 W/LOCATION( 9833): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:46.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:46.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400b7e0]
04-23 20:31:46.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:31:46.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:31:46.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:31:46.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:31:46.519+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:46.519+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:46.529+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:46.529+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:46.539+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:46.539+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:31:46.539+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:31:46.539+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:46.539+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:46.539+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:46.539+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:46.539+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:46.539+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:46.539+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:46.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:46.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:46.549+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:46.559+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:46.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:46:542,0.041763,9.772527,0.816312
04-23 20:31:46.569+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:31:46.569+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2381836), time2(2368675)
04-23 20:31:46.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:31:46.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:31:46.569+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:31:46.569+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:31:46.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:46.639+0200 W/LOCATION( 9833): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:31:46.639+0200 I/LOCATION( 9833): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:46.639+0200 I/LOCATION( 9833): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:46.639+0200 I/location( 9833): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:31:46.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:46.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:46:703,0.045855,9.772383,0.817808
04-23 20:31:46.719+0200 I/LOCATION( 9833): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:46.769+0200 E/location( 9833): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:31:46.769+0200 W/AUL     ( 9833): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:31:46.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:46.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9833
04-23 20:31:46.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:31:46.779+0200 W/AUL     ( 9833): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:31:46.779+0200 I/location( 9833): request sent to service es.ugr.frailty.servicemanager
04-23 20:31:46.779+0200 W/CAPI_APPFW_APP_CONTROL( 9833): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.779+0200 I/utils   ( 9833): specific action
04-23 20:31:46.779+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:46.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:31:46.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.779+0200 I/utils   ( 8242): specific action
04-23 20:31:46.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.779+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:31:46.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:46.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:46.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:31:46.789+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:31:46.789+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:31:46.789+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:31:46.789+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:46.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:31:46.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.799+0200 I/utils   ( 8247): specific action
04-23 20:31:46.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:46.799+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:31:46.799+0200 I/recorder( 8247): guardando datos en local
04-23 20:31:46.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:46.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:46:904,0.050170,9.770661,0.837880
04-23 20:31:47.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:104,0.045446,9.765136,0.900241
04-23 20:31:47.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:47.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:47.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:47.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:309,0.053995,9.768883,0.858132
04-23 20:31:47.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:324,0.052761,9.768803,0.859130
04-23 20:31:47.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:345,0.049830,9.768563,0.862012
04-23 20:31:47.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:364,0.048758,9.768622,0.861406
04-23 20:31:47.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:384,0.045696,9.768666,0.861075
04-23 20:31:47.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:404,0.045278,9.768840,0.859128
04-23 20:31:47.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.469+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:469,0.044849,9.769303,0.853860
04-23 20:31:47.469+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:477,0.044107,9.769332,0.853578
04-23 20:31:47.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:492,0.043836,9.768854,0.859042
04-23 20:31:47.489+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:504,0.041487,9.768874,0.858927
04-23 20:31:47.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.529+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:523,0.041625,9.768938,0.858199
04-23 20:31:47.529+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.589+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:31:47.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:540,0.042069,9.769315,0.853880
04-23 20:31:47.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:609,0.043630,9.769728,0.849058
04-23 20:31:47.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.609+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:613,0.043893,9.769645,0.850001
04-23 20:31:47.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.609+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:618,0.044265,9.769614,0.850332
04-23 20:31:47.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:622,0.042863,9.769596,0.850616
04-23 20:31:47.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:627,0.041983,9.769638,0.850169
04-23 20:31:47.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.649+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:649,0.040795,9.769658,0.850004
04-23 20:31:47.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:664,0.040503,9.769781,0.848596
04-23 20:31:47.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:684,0.039422,9.769567,0.851102
04-23 20:31:47.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:704,0.038032,9.769454,0.852466
04-23 20:31:47.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:724,0.039559,9.769995,0.846183
04-23 20:31:47.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:745,0.036778,9.770158,0.844420
04-23 20:31:47.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:764,0.035548,9.770474,0.840804
04-23 20:31:47.779+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.779+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:784,0.037320,9.770486,0.840599
04-23 20:31:47.789+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:803,0.036663,9.770313,0.842631
04-23 20:31:47.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:823,0.036527,9.770510,0.840353
04-23 20:31:47.839+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.839+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:843,0.038802,9.771052,0.833912
04-23 20:31:47.849+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.859+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:862,0.035997,9.770681,0.838378
04-23 20:31:47.879+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:883,0.034630,9.770677,0.838491
04-23 20:31:47.889+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:902,0.034636,9.770494,0.840612
04-23 20:31:47.969+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.969+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:974,0.034317,9.770357,0.842213
04-23 20:31:47.969+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.969+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:978,0.033780,9.770099,0.845228
04-23 20:31:47.969+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:982,0.032525,9.770082,0.845481
04-23 20:31:47.979+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:47:987,0.032715,9.770038,0.845975
04-23 20:31:47.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:47.999+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:3,0.032097,9.770081,0.845506
04-23 20:31:48.009+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:23,0.030597,9.769855,0.848168
04-23 20:31:48.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:44,0.030541,9.770021,0.846242
04-23 20:31:48.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:63,0.030603,9.770256,0.843526
04-23 20:31:48.069+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.079+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:82,0.029183,9.770073,0.845702
04-23 20:31:48.089+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:102,0.028049,9.770020,0.846343
04-23 20:31:48.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:123,0.029750,9.770280,0.843286
04-23 20:31:48.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:144,0.029077,9.770061,0.845830
04-23 20:31:48.149+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.159+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:163,0.029658,9.770196,0.844255
04-23 20:31:48.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.179+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:183,0.030319,9.770411,0.841751
04-23 20:31:48.189+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:202,0.031289,9.770685,0.838516
04-23 20:31:48.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.229+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:229,0.032392,9.770978,0.835061
04-23 20:31:48.229+0200 W/LOCATION( 9833): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:31:48.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.249+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:245,0.033428,9.771002,0.834740
04-23 20:31:48.259+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:264,0.032372,9.770697,0.838349
04-23 20:31:48.269+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.279+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:282,0.033175,9.770859,0.836421
04-23 20:31:48.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:48.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:48.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:48.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:314,0.036013,9.771135,0.833070
04-23 20:31:48.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:323,0.035928,9.771039,0.834203
04-23 20:31:48.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:343,0.035279,9.770942,0.835371
04-23 20:31:48.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:363,0.036128,9.771075,0.833767
04-23 20:31:48.369+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:382,0.036261,9.770959,0.835125
04-23 20:31:48.389+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:402,0.037490,9.771052,0.833976
04-23 20:31:48.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:423,0.036995,9.771078,0.833694
04-23 20:31:48.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:443,0.037197,9.771132,0.833061
04-23 20:31:48.449+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:48.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:48:462,0.037168,9.771259,0.831564
04-23 20:31:48.499+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11098336c6f63152450830
