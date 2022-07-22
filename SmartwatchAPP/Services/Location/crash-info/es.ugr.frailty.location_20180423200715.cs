S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6403
Date: 2018-04-23 20:07:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf720052d, r5   = 0xf78e2f98
r6   = 0xff809030, r7   = 0xff808ee0
r8   = 0xf78dfc18, r9   = 0x00000000
r10  = 0xff808fbc, fp   = 0xff809030
ip   = 0x00000001, sp   = 0xff808eb8
lr   = 0xf7200539, pc   = 0xf7269228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    106660 KB
Buffers:     37968 KB
Cached:     183652 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11952 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6403 TID = 6403
6403 6406 

Maps Information
f40cb000 f48ca000 rw-p [stack:6406]
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
f78af000 f793d000 rw-p [heap]
ff7ea000 ff80b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6403)
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
PI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:05.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:05.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:05.539+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79dbc48
04-23 20:07:05.599+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.639+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:611,0.043358,9.771641,0.826761
04-23 20:07:05.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:652,0.043145,9.771717,0.825872
04-23 20:07:05.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:663,0.043523,9.771916,0.823495
04-23 20:07:05.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:679,0.042719,9.772038,0.822080
04-23 20:07:05.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:694,0.042872,9.771837,0.824469
04-23 20:07:05.699+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:704,0.041793,9.771715,0.825970
04-23 20:07:05.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.719+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:719,0.040074,9.771601,0.827406
04-23 20:07:05.719+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:732,0.041834,9.771760,0.825429
04-23 20:07:05.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.759+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:745,0.040668,9.771687,0.826362
04-23 20:07:05.769+0200 W/AUL     ( 6364): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:07:05.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:05.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:05.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6329
04-23 20:07:05.769+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:05.769+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6329
04-23 20:07:05.769+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6329)
04-23 20:07:05.789+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:797,0.040816,9.771744,0.825681
04-23 20:07:05.799+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.799+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:804,0.039925,9.771677,0.826508
04-23 20:07:05.799+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.799+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:808,0.038863,9.771626,0.827162
04-23 20:07:05.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:814,0.038988,9.771660,0.826755
04-23 20:07:05.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.819+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:821,0.041052,9.771960,0.823102
04-23 20:07:05.819+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.819+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:828,0.043023,9.772280,0.819194
04-23 20:07:05.829+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:834,0.043165,9.772189,0.820269
04-23 20:07:05.839+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.839+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:844,0.044856,9.771500,0.828352
04-23 20:07:05.839+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:851,0.026734,9.769900,0.847777
04-23 20:07:05.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:05.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:05:955,0.032386,9.770851,0.836539
04-23 20:07:06.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:06.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:06:154,0.031403,9.770894,0.836083
04-23 20:07:06.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:06.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:06:354,0.038819,9.772708,0.814281
04-23 20:07:06.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:06.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:06:555,0.046105,9.773351,0.806151
04-23 20:07:06.599+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:07:06.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:06.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:06:754,0.054221,9.774505,0.791523
04-23 20:07:06.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:06.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:06:955,0.061931,9.775925,0.773204
04-23 20:07:07.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:07.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:07:156,0.059057,9.774602,0.789975
04-23 20:07:07.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:07.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:07:354,0.051582,9.774348,0.793627
04-23 20:07:07.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:07.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:07:555,0.039568,9.773076,0.809822
04-23 20:07:07.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:07.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:07:756,0.028983,9.771782,0.825731
04-23 20:07:07.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:07.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:07:955,0.037104,9.772859,0.812549
04-23 20:07:08.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:08.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:08:155,0.046608,9.773408,0.805429
04-23 20:07:08.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:08.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:08:355,0.045609,9.773559,0.803655
04-23 20:07:08.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:08.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:08:556,0.049812,9.773334,0.806137
04-23 20:07:08.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:08.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:08:755,0.044530,9.773700,0.801993
04-23 20:07:08.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:08.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:08:955,0.040219,9.774289,0.795008
04-23 20:07:09.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:09.159+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:09:163,0.045232,9.773268,0.807198
04-23 20:07:09.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:09.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:09:355,0.045539,9.774646,0.790318
04-23 20:07:09.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:09.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:09:563,0.042578,9.773202,0.808140
04-23 20:07:09.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:09.759+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:09:763,0.035846,9.771811,0.825120
04-23 20:07:09.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:09.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:09:954,0.012841,9.762605,0.928315
04-23 20:07:10.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:10.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:10:156,0.026232,9.770054,0.846015
04-23 20:07:10.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:10.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:10:355,0.033713,9.770944,0.835413
04-23 20:07:10.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:10.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:10:562,0.052397,9.772931,0.810831
04-23 20:07:10.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:10.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:10:755,0.039154,9.772602,0.815538
04-23 20:07:10.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:10.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:10:954,0.038259,9.771882,0.824161
04-23 20:07:11.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:11.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:11:154,0.039207,9.772985,0.810927
04-23 20:07:11.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:11.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:11:354,0.046927,9.773121,0.808882
04-23 20:07:11.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:11.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:11:554,0.042564,9.772954,0.811135
04-23 20:07:11.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:11.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:11:756,0.045286,9.774611,0.790770
04-23 20:07:11.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:11.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:11:954,0.054137,9.773847,0.799607
04-23 20:07:12.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:12.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:12:155,0.050586,9.774337,0.793825
04-23 20:07:12.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:12.419+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:12:354,0.051396,9.773578,0.803073
04-23 20:07:12.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:12.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:12:555,0.042430,9.773591,0.803436
04-23 20:07:12.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:12.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:12:755,0.038131,9.772297,0.819238
04-23 20:07:12.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:12.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:12:955,0.037719,9.772728,0.814098
04-23 20:07:13.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:13.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:13:155,0.038907,9.771479,0.828902
04-23 20:07:13.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:13.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:13:354,0.058385,9.774524,0.790988
04-23 20:07:13.379+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:07:13.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:13.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:13.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:13.399+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:13.399+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6403
04-23 20:07:13.449+0200 E/CAPI_APPFW_APPLICATION( 6403): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:13.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6403
04-23 20:07:13.449+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6403) type(svcapp) bg(0)
04-23 20:07:13.449+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6403)
04-23 20:07:13.449+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:07:13.449+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:13.449+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6403]
04-23 20:07:13.449+0200 E/CAPI_APPFW_APPLICATION( 6403): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:13.459+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6403) was created
04-23 20:07:13.469+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:13.479+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6403
04-23 20:07:13.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:13.499+0200 W/LOCATION( 6403): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:13.499+0200 E/LOCATION( 6403): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:13.499+0200 E/PKGMGR_INFO( 6403): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:13.499+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:13.519+0200 I/LOCATION( 6403): location.c: location_new(269) > method: 0
04-23 20:07:13.519+0200 W/LOCATION( 6403): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:13.519+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:13.529+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:13.529+0200 W/LOCATION( 6403): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:13.539+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:13.539+0200 W/LOCATION( 6403): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:13.539+0200 W/LOCATION( 6403): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:13.539+0200 W/LOCATION( 6403): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:13.539+0200 W/LOCATION( 6403): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:13.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:13.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:13:554,0.060801,9.775448,0.779297
04-23 20:07:13.569+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:13.569+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:13.569+0200 W/LOCATION( 6403): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:13.569+0200 W/LOCATION( 6403): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:13.579+0200 W/LOCATION( 6403): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:13.579+0200 W/LOCATION( 6403): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:13.579+0200 W/LOCATION( 6403): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:13.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:13.589+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6403
04-23 20:07:13.589+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:13.609+0200 W/LOCATION( 6403): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:13.609+0200 I/LOCATION( 6403): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf78dfc18
04-23 20:07:13.609+0200 I/LOCATION( 6403): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:13.609+0200 I/LOCATION( 6403): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf78dfc18
04-23 20:07:13.609+0200 I/LOCATION( 6403): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:13.619+0200 I/location( 6403): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:13.659+0200 I/LOCATION( 6403): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:13.699+0200 W/LOCATION( 6403): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:13.699+0200 W/LOCATION( 6403): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:13.699+0200 I/LOCATION( 6403): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:13.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:13.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:13:755,0.048898,9.774910,0.786843
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:13.779+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:13.779+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:13.779+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:13.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:13.779+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:13.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:13.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:13.779+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:13.779+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:13.789+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:13.789+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:13.789+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:13.789+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:13.839+0200 W/LOCATION( 6403): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:13.839+0200 W/LOCATION( 6403): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:13.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:13.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a01358]
04-23 20:07:13.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:13.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:13.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:13.959+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:13.969+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:13.969+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:13.979+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:13.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:13.989+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:13.989+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:13.989+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:13.989+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:13.989+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:13.989+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:13.989+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:13.989+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:13.989+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:13.989+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:13.999+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:13.999+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:13.999+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:14.009+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:14.029+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:14.029+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(909298), time2(896118)
04-23 20:07:14.029+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:07:14.029+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:14.029+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:14.029+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:14.049+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:14.059+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:13:993,0.052950,9.775086,0.784383
04-23 20:07:14.089+0200 W/LOCATION( 6403): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:14.089+0200 I/LOCATION( 6403): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:14.089+0200 I/LOCATION( 6403): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:14.089+0200 I/location( 6403): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:14.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:154,0.056207,9.774088,0.796512
04-23 20:07:14.189+0200 I/LOCATION( 6403): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:14.239+0200 E/location( 6403): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:14.239+0200 W/AUL     ( 6403): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:14.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:14.249+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6403
04-23 20:07:14.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:14.259+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:14.259+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:14.259+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.259+0200 I/utils   ( 5532): specific action
04-23 20:07:14.259+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.259+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.259+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.259+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:14.259+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:14.259+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:14.269+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:14.269+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:14.269+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 I/utils   ( 5538): specific action
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:14.269+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:14.269+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:14.269+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:14.269+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:14.269+0200 W/AUL     ( 6403): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:14.269+0200 I/location( 6403): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:14.269+0200 W/CAPI_APPFW_APP_CONTROL( 6403): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:14.269+0200 I/utils   ( 6403): specific action
04-23 20:07:14.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:14.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:14.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:14.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:364,0.046587,9.773071,0.809503
04-23 20:07:14.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:379,0.045757,9.773092,0.809290
04-23 20:07:14.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:395,0.044725,9.773146,0.808703
04-23 20:07:14.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:415,0.045118,9.773113,0.809075
04-23 20:07:14.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:435,0.045722,9.773097,0.809234
04-23 20:07:14.449+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:454,0.044043,9.772936,0.811278
04-23 20:07:14.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:476,0.044479,9.772886,0.811845
04-23 20:07:14.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:495,0.044083,9.772917,0.811509
04-23 20:07:14.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:514,0.044965,9.772803,0.812825
04-23 20:07:14.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:536,0.046750,9.772944,0.811019
04-23 20:07:14.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:555,0.047062,9.772893,0.811619
04-23 20:07:14.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:575,0.045752,9.772850,0.812219
04-23 20:07:14.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:595,0.044383,9.772886,0.811852
04-23 20:07:14.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:615,0.044915,9.772781,0.813085
04-23 20:07:14.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:635,0.045318,9.772828,0.812500
04-23 20:07:14.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:655,0.044337,9.772669,0.814467
04-23 20:07:14.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:676,0.042715,9.772627,0.815056
04-23 20:07:14.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:695,0.040932,9.772527,0.816350
04-23 20:07:14.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:715,0.040153,9.772472,0.817036
04-23 20:07:14.729+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:735,0.040898,9.772527,0.816353
04-23 20:07:14.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:755,0.040231,9.772467,0.817109
04-23 20:07:14.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:776,0.041907,9.772771,0.813373
04-23 20:07:14.789+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:795,0.044478,9.772908,0.811581
04-23 20:07:14.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:814,0.043761,9.772798,0.812953
04-23 20:07:14.829+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:835,0.044546,9.772803,0.812842
04-23 20:07:14.849+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:854,0.044151,9.772771,0.813261
04-23 20:07:14.909+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:915,0.045049,9.772934,0.811244
04-23 20:07:14.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:958,0.045769,9.772960,0.810898
04-23 20:07:14.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:990,0.046009,9.772958,0.810898
04-23 20:07:14.989+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:14.999+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:14:999,0.045437,9.773075,0.809525
04-23 20:07:14.999+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:11,0.044665,9.772993,0.810551
04-23 20:07:15.009+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:19,0.046533,9.773024,0.810084
04-23 20:07:15.019+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:30,0.044574,9.772916,0.811486
04-23 20:07:15.029+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.039+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:41,0.044650,9.772879,0.811929
04-23 20:07:15.039+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:50,0.043472,9.772752,0.813520
04-23 20:07:15.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.069+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:73,0.043594,9.772801,0.812914
04-23 20:07:15.069+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.099+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:82,0.043485,9.772743,0.813626
04-23 20:07:15.119+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:07:15.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:137,0.043483,9.772623,0.815060
04-23 20:07:15.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.139+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:142,0.042701,9.772509,0.816473
04-23 20:07:15.139+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.139+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:148,0.044013,9.772635,0.814896
04-23 20:07:15.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:155,0.043767,9.772655,0.814676
04-23 20:07:15.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:176,0.043419,9.772614,0.815174
04-23 20:07:15.189+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.189+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:195,0.043094,9.772477,0.816833
04-23 20:07:15.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:215,0.042553,9.772539,0.816116
04-23 20:07:15.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:234,0.042709,9.772511,0.816441
04-23 20:07:15.249+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:255,0.041850,9.772379,0.818068
04-23 20:07:15.269+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.269+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:276,0.041478,9.772449,0.817251
04-23 20:07:15.289+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.289+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:294,0.042971,9.772665,0.814588
04-23 20:07:15.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:315,0.042659,9.772723,0.813903
04-23 20:07:15.329+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:15.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:15.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:15.339+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:335,0.043616,9.772885,0.811904
04-23 20:07:15.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:354,0.044079,9.772931,0.811332
04-23 20:07:15.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:376,0.045311,9.772994,0.810508
04-23 20:07:15.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:394,0.045919,9.773054,0.809743
04-23 20:07:15.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:414,0.045020,9.772934,0.811245
04-23 20:07:15.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:434,0.045818,9.772867,0.812001
04-23 20:07:15.449+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:453,0.045371,9.772839,0.812372
04-23 20:07:15.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:474,0.047123,9.773077,0.809402
04-23 20:07:15.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:494,0.048097,9.773205,0.807804
04-23 20:07:15.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:513,0.050311,9.773458,0.804585
04-23 20:07:15.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:534,0.049640,9.773537,0.803680
04-23 20:07:15.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:554,0.049810,9.773453,0.804689
04-23 20:07:15.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:615,0.048943,9.773458,0.804668
04-23 20:07:15.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.619+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:619,0.049480,9.773426,0.805038
04-23 20:07:15.619+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.619+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:624,0.050344,9.773446,0.804736
04-23 20:07:15.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:634,0.050363,9.773461,0.804545
04-23 20:07:15.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:653,0.050727,9.773478,0.804330
04-23 20:07:15.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:675,0.050626,9.773455,0.804611
04-23 20:07:15.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:695,0.049063,9.773289,0.806724
04-23 20:07:15.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:713,0.049033,9.773102,0.808986
04-23 20:07:15.729+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:734,0.049568,9.773053,0.809547
04-23 20:07:15.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:753,0.049286,9.773096,0.809042
04-23 20:07:15.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.779+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:774,0.049584,9.773070,0.809337
04-23 20:07:15.789+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:794,0.048842,9.773082,0.809247
04-23 20:07:15.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:813,0.049177,9.773248,0.807216
04-23 20:07:15.829+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:833,0.047644,9.773244,0.807354
04-23 20:07:15.849+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:854,0.049160,9.773242,0.807289
04-23 20:07:15.859+0200 W/LOCATION( 6403): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:07:15.869+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.939+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:880,0.048554,9.773266,0.807028
04-23 20:07:15.939+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:944,0.049692,9.773347,0.805979
04-23 20:07:15.959+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:964,0.048390,9.773222,0.807578
04-23 20:07:15.959+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:969,0.050009,9.773000,0.810164
04-23 20:07:15.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.979+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:973,0.050284,9.773242,0.807217
04-23 20:07:15.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.979+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:986,0.049962,9.773196,0.807790
04-23 20:07:15.989+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:15.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:15:993,0.049543,9.773162,0.808228
04-23 20:07:16.009+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:16.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:16:13,0.049494,9.773374,0.805673
04-23 20:07:16.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:16.049+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11064036c6f63152450683
