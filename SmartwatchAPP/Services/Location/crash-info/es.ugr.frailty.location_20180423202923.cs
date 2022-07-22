S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9013
Date: 2018-04-23 20:29:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf731052d, r5   = 0xf7ab6f98
r6   = 0xffbb64b0, r7   = 0xffbb6360
r8   = 0xf7ab3c18, r9   = 0x00000000
r10  = 0xffbb643c, fp   = 0xffbb64b0
ip   = 0x00000001, sp   = 0xffbb6338
lr   = 0xf7310539, pc   = 0xf7379228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    145984 KB
Buffers:     34004 KB
Cached:     152568 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11864 KB
VmRSS:       11864 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9013 TID = 9013
9013 9016 

Maps Information
f41db000 f49da000 rw-p [stack:9016]
f49e1000 f49e3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49eb000 f49ef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49f8000 f49fa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a02000 f4a05000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a14000 f4a19000 r-xp /usr/lib/libsystem.so.0.0.0
f4a24000 f4a27000 r-xp /lib/libattr.so.1.1.0
f4a2f000 f4a3f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a47000 f4a50000 r-xp /usr/lib/libedbus.so.1.7.99
f4a58000 f4a59000 r-xp /usr/lib/libresponse.so.0.2.96
f4a62000 f4a67000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6309000 f640f000 r-xp /usr/lib/libicuuc.so.57.1
f6425000 f65ad000 r-xp /usr/lib/libicui18n.so.57.1
f65bd000 f65ca000 r-xp /usr/lib/libail.so.0.1.0
f65d3000 f65da000 r-xp /usr/lib/libminizip.so.1.0.0
f65e3000 f678c000 r-xp /usr/lib/libcrypto.so.1.0.0
f67ac000 f67f3000 r-xp /usr/lib/libssl.so.1.0.0
f67ff000 f6801000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6809000 f6810000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6819000 f6820000 r-xp /lib/libcrypt-2.13.so
f6851000 f6854000 r-xp /lib/libcap.so.2.21
f685c000 f685e000 r-xp /usr/lib/libiri.so
f6866000 f68af000 r-xp /usr/lib/libmdm.so.1.2.69
f68b7000 f68bd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68c5000 f68e8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68f2000 f68f4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68fc000 f6919000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6922000 f6926000 r-xp /usr/lib/libsmack.so.1.0.0
f692f000 f6948000 r-xp /usr/lib/libnetwork.so.0.0.0
f6951000 f6959000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6961000 f6967000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6970000 f6972000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f697b000 f698b000 r-xp /lib/libresolv-2.13.so
f698f000 f69a7000 r-xp /usr/lib/liblzma.so.5.0.3
f69b0000 f69b2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69ba000 f69d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69dc000 f6a0b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a14000 f6a23000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a2d000 f6a37000 r-xp /usr/lib/libsensord-shared.so
f6a40000 f6b13000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b1e000 f6b34000 r-xp /lib/libz.so.1.2.5
f6b3c000 f6b41000 r-xp /usr/lib/libffi.so.5.0.10
f6b49000 f6b4a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b52000 f6b62000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b6a000 f6b83000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b8b000 f6b8d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b95000 f6c0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c14000 f6c1a000 r-xp /lib/librt-2.13.so
f6c23000 f6c41000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c4b000 f6c4c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c54000 f6c77000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c7f000 f6c84000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c8c000 f6cb6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cbf000 f6cd6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cde000 f6d47000 r-xp /lib/libm-2.13.so
f6d50000 f6de4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6df7000 f6dfc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e04000 f6e0b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e13000 f6e3d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e46000 f6f12000 r-xp /usr/lib/libxml2.so.2.7.8
f6f1f000 f6f21000 r-xp /usr/lib/libiniparser.so.0
f6f2a000 f6f30000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f39000 f7009000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f700a000 f703e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7047000 f7083000 r-xp /usr/lib/libSLP-location.so.0.9.24
f708b000 f708e000 r-xp /usr/lib/libbundle.so.0.1.22
f7096000 f709c000 r-xp /usr/lib/libappsvc.so.0.1.0
f70a4000 f70e5000 r-xp /usr/lib/libeina.so.1.7.99
f70ee000 f7105000 r-xp /usr/lib/libecore.so.1.7.99
f711c000 f7125000 r-xp /usr/lib/libvconf.so.0.2.45
f712d000 f7141000 r-xp /lib/libpthread-2.13.so
f714c000 f7159000 r-xp /usr/lib/libaul.so.0.1.0
f7163000 f7165000 r-xp /lib/libdl-2.13.so
f716e000 f7179000 r-xp /lib/libunwind.so.8.0.1
f71a6000 f71ae000 r-xp /lib/libgcc_s-4.6.so.1
f71af000 f72d3000 r-xp /lib/libc-2.13.so
f72e1000 f72e3000 r-xp /usr/lib/libdlog.so.0.0.0
f72eb000 f72f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7300000 f7305000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f730d000 f731c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7324000 f7328000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7331000 f7334000 r-xp /usr/lib/libappcore-agent.so.1.1
f733c000 f733e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7346000 f734a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7352000 f736f000 r-xp /lib/ld-2.13.so
f7378000 f737b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f737b000 f737f000 r-xp /usr/lib/libsys-assert.so
f7a83000 f7af4000 rw-p [heap]
ffb97000 ffbb8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9013)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7379228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7310539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70173f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7015c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7021e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7027be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7027dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf705c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70571f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7015c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7021e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7027be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7027dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7059e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf705a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7061f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49f91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49ec171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6abf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f6cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f6e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70feca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70f9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70fa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70fa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7332183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73327fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73794f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf71c685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7378f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
00c398
04-23 20:29:12.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:687,0.040783,9.771869,0.824200
04-23 20:29:12.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:12.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:718,0.039465,9.771670,0.826611
04-23 20:29:12.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:12.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:729,0.040015,9.771867,0.824264
04-23 20:29:12.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:12.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:734,0.034860,9.772482,0.817168
04-23 20:29:12.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:12.759+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:745,0.040959,9.773678,0.802457
04-23 20:29:12.839+0200 W/AUL     ( 8976): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:29:12.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:29:12.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:29:12.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8926
04-23 20:29:12.839+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:29:12.839+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8926
04-23 20:29:12.839+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8926)
04-23 20:29:12.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:12.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:12:920,0.032186,9.774089,0.797832
04-23 20:29:13.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:13.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:13:119,0.021713,9.771740,0.826450
04-23 20:29:13.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:13.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:13:319,0.027465,9.773078,0.810297
04-23 20:29:13.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:13.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:13:523,0.036017,9.774374,0.794170
04-23 20:29:13.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:13.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:13:723,0.039214,9.772645,0.815022
04-23 20:29:13.789+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:29:13.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:13.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:13:923,0.031868,9.772475,0.817367
04-23 20:29:14.119+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:14.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:14:123,0.034230,9.772355,0.818712
04-23 20:29:14.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:14.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:14:323,0.038956,9.773275,0.807439
04-23 20:29:14.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:14.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:14:520,0.027815,9.771651,0.827308
04-23 20:29:14.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:14.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:14:720,0.040916,9.773490,0.804740
04-23 20:29:14.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:14.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:14:923,0.048873,9.773104,0.808979
04-23 20:29:15.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:15.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:15:120,0.050266,9.773602,0.802849
04-23 20:29:15.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:15.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:15:319,0.044923,9.772794,0.812942
04-23 20:29:15.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:15.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:15:519,0.042980,9.773265,0.807363
04-23 20:29:15.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:15.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:15:723,0.045542,9.774138,0.796572
04-23 20:29:15.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:15.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:15:920,0.048017,9.774460,0.792475
04-23 20:29:16.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:16.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:16:118,0.044191,9.773540,0.803962
04-23 20:29:16.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:16.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:16:318,0.031344,9.771679,0.826853
04-23 20:29:16.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:16.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:16:520,0.041324,9.772684,0.814450
04-23 20:29:16.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:16.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:16:719,0.048996,9.772538,0.815775
04-23 20:29:16.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:16.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:16:920,0.040949,9.772896,0.811920
04-23 20:29:17.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:17.129+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:17:120,0.035475,9.771771,0.825593
04-23 20:29:17.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:17.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:17:318,0.037363,9.771522,0.828461
04-23 20:29:17.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:17.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:17:519,0.056876,9.773122,0.808228
04-23 20:29:17.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:17.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:17:723,0.044172,9.773181,0.808306
04-23 20:29:17.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:17.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:17:923,0.030729,9.775070,0.785770
04-23 20:29:18.119+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:18.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:18:123,0.020897,9.777137,0.759963
04-23 20:29:18.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:18.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:18:319,0.020792,9.778145,0.746884
04-23 20:29:18.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:18.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:18:520,0.028537,9.776693,0.765397
04-23 20:29:18.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:18.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:18:720,0.036047,9.775848,0.775803
04-23 20:29:18.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:18.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:18:922,0.047324,9.775225,0.783021
04-23 20:29:19.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:19.129+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:19:121,0.049276,9.774967,0.786115
04-23 20:29:19.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:19.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:19:320,0.044248,9.774716,0.789523
04-23 20:29:19.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:19.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:19:522,0.027497,9.772496,0.817284
04-23 20:29:19.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:19.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:19:721,0.028903,9.772802,0.813561
04-23 20:29:19.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:19.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:19:921,0.046462,9.773780,0.800903
04-23 20:29:20.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:20.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:20:122,0.040055,9.773438,0.805418
04-23 20:29:20.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:20.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:20:322,0.045335,9.773379,0.805847
04-23 20:29:20.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:20.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:20:521,0.045666,9.773758,0.801215
04-23 20:29:20.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:20.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:20:722,0.041101,9.773665,0.802592
04-23 20:29:20.769+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:29:20.769+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:29:20.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:20.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:20.789+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9013
04-23 20:29:20.789+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:29:20.829+0200 E/CAPI_APPFW_APPLICATION( 9013): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:20.829+0200 E/CAPI_APPFW_APPLICATION( 9013): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:20.839+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9013
04-23 20:29:20.839+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9013) type(svcapp) bg(0)
04-23 20:29:20.839+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9013) was created
04-23 20:29:20.839+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9013)
04-23 20:29:20.839+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:29:20.839+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:29:20.839+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9013]
04-23 20:29:20.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:20.859+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9013
04-23 20:29:20.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:20.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:20.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9013
04-23 20:29:20.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:20.879+0200 W/LOCATION( 9013): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:29:20.879+0200 E/LOCATION( 9013): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:29:20.879+0200 E/PKGMGR_INFO( 9013): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:29:20.889+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:20.899+0200 I/LOCATION( 9013): location.c: location_new(269) > method: 0
04-23 20:29:20.899+0200 W/LOCATION( 9013): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:20.909+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:20.909+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:20.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:20.919+0200 W/LOCATION( 9013): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:20.919+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:20.919+0200 W/LOCATION( 9013): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:20.919+0200 W/LOCATION( 9013): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:20.919+0200 W/LOCATION( 9013): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:20.919+0200 W/LOCATION( 9013): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:20.939+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:20.949+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:20.949+0200 W/LOCATION( 9013): module-internal.c: module_new(311) > module (wps) open success
04-23 20:29:20.949+0200 W/LOCATION( 9013): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:29:20.959+0200 W/LOCATION( 9013): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:29:20.959+0200 W/LOCATION( 9013): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:20.959+0200 W/LOCATION( 9013): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:20.969+0200 W/LOCATION( 9013): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:29:20.969+0200 I/LOCATION( 9013): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7ab3c18
04-23 20:29:20.969+0200 I/LOCATION( 9013): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:29:20.969+0200 I/LOCATION( 9013): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7ab3c18
04-23 20:29:20.969+0200 I/LOCATION( 9013): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:29:20.979+0200 I/location( 9013): es.ugr.frailty.location: creado servicio de localización
04-23 20:29:20.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:20:921,0.046077,9.772689,0.814136
04-23 20:29:21.029+0200 I/LOCATION( 9013): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:29:21.059+0200 W/LOCATION( 9013): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:21.059+0200 W/LOCATION( 9013): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:21.069+0200 I/LOCATION( 9013): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:21.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:121,0.042069,9.772315,0.818820
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:29:21.139+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:29:21.139+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:21.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:29:21.139+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:29:21.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:29:21.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:29:21.139+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:29:21.139+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:29:21.139+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:29:21.139+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:29:21.139+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:29:21.139+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:29:21.189+0200 W/LOCATION( 9013): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:21.189+0200 W/LOCATION( 9013): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:21.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:21.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:21.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:21.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:21.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4004f78]
04-23 20:29:21.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:21.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:21.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:21.319+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:21.329+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:21.329+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:21.339+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:21.349+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:21.349+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:21.349+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:21.349+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:21.349+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:21.349+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:21.349+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:21.349+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:21.349+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:21.349+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:21.359+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:21.359+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:21.359+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:21.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:21.369+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:29:21.369+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2236634), time2(2223423)
04-23 20:29:21.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:29:21.369+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:29:21.369+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:29:21.369+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:29:21.409+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:327,0.045024,9.773454,0.804962
04-23 20:29:21.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:21.439+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.449+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:446,0.045868,9.773492,0.804446
04-23 20:29:21.459+0200 W/LOCATION( 9013): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:29:21.459+0200 I/LOCATION( 9013): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:21.459+0200 I/LOCATION( 9013): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:21.459+0200 I/location( 9013): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:29:21.459+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:468,0.045651,9.773291,0.806900
04-23 20:29:21.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.469+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:477,0.046602,9.773517,0.804101
04-23 20:29:21.479+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:483,0.044972,9.773475,0.804702
04-23 20:29:21.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:493,0.045025,9.773464,0.804835
04-23 20:29:21.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:503,0.045070,9.773523,0.804111
04-23 20:29:21.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:513,0.044198,9.773429,0.805311
04-23 20:29:21.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:522,0.043940,9.773292,0.806983
04-23 20:29:21.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:532,0.044051,9.773220,0.807845
04-23 20:29:21.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:536,0.043809,9.773106,0.809243
04-23 20:29:21.539+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.549+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:546,0.042463,9.772879,0.812051
04-23 20:29:21.559+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.559+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:564,0.040826,9.772709,0.814176
04-23 20:29:21.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.579+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:582,0.041989,9.772774,0.813338
04-23 20:29:21.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.599+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:602,0.042414,9.772765,0.813416
04-23 20:29:21.599+0200 I/LOCATION( 9013): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:21.619+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:623,0.041241,9.772591,0.815573
04-23 20:29:21.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.639+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:643,0.040390,9.772210,0.820159
04-23 20:29:21.659+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.659+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:664,0.041819,9.772398,0.817849
04-23 20:29:21.659+0200 E/location( 9013): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:29:21.659+0200 W/AUL     ( 9013): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:29:21.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:21.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9013
04-23 20:29:21.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:29:21.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:21.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:29:21.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.679+0200 I/utils   ( 8242): specific action
04-23 20:29:21.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.679+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:29:21.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:21.679+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.679+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:21.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:29:21.689+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:687,0.041110,9.772417,0.817652
04-23 20:29:21.689+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:29:21.689+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:29:21.689+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:29:21.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.689+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:21.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:29:21.689+0200 W/AUL     ( 9013): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:29:21.689+0200 I/location( 9013): request sent to service es.ugr.frailty.servicemanager
04-23 20:29:21.689+0200 W/CAPI_APPFW_APP_CONTROL( 9013): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.689+0200 I/utils   ( 9013): specific action
04-23 20:29:21.689+0200 I/utils   ( 8247): specific action
04-23 20:29:21.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.699+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.699+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.699+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:21.699+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:29:21.699+0200 I/recorder( 8247): guardando datos en local
04-23 20:29:21.699+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:704,0.041124,9.772466,0.817074
04-23 20:29:21.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:722,0.040785,9.772695,0.814348
04-23 20:29:21.739+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:743,0.041365,9.772614,0.815291
04-23 20:29:21.759+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.759+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:764,0.041249,9.772488,0.816801
04-23 20:29:21.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:782,0.040102,9.772364,0.818348
04-23 20:29:21.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.799+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:803,0.041189,9.772374,0.818166
04-23 20:29:21.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:822,0.041432,9.772427,0.817523
04-23 20:29:21.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.839+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:842,0.040626,9.772438,0.817426
04-23 20:29:21.859+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.859+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:864,0.039870,9.772285,0.819298
04-23 20:29:21.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.879+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:882,0.039149,9.772157,0.820854
04-23 20:29:21.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:902,0.039704,9.772053,0.822063
04-23 20:29:21.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:923,0.038870,9.771958,0.823226
04-23 20:29:21.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.939+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:942,0.037613,9.771830,0.824818
04-23 20:29:21.959+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:963,0.036991,9.771793,0.825272
04-23 20:29:21.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:21:983,0.037988,9.771795,0.825203
04-23 20:29:21.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:21.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:2,0.039059,9.771860,0.824386
04-23 20:29:22.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.019+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:22,0.037911,9.771773,0.825465
04-23 20:29:22.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.039+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:43,0.039340,9.771982,0.822923
04-23 20:29:22.059+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.059+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:63,0.039210,9.772182,0.820545
04-23 20:29:22.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.079+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:82,0.039326,9.772258,0.819649
04-23 20:29:22.099+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:103,0.039769,9.772300,0.819118
04-23 20:29:22.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:122,0.040663,9.772589,0.815627
04-23 20:29:22.129+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.139+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:143,0.039799,9.772611,0.815398
04-23 20:29:22.159+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:164,0.041028,9.772613,0.815317
04-23 20:29:22.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.179+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:182,0.038564,9.772429,0.817639
04-23 20:29:22.189+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.199+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:203,0.037727,9.772198,0.820431
04-23 20:29:22.259+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.259+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:265,0.039705,9.772267,0.819514
04-23 20:29:22.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:22.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:22.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:22.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:295,0.038533,9.772223,0.820095
04-23 20:29:22.299+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:309,0.037870,9.772257,0.819725
04-23 20:29:22.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:318,0.037361,9.772270,0.819582
04-23 20:29:22.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.339+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:327,0.036740,9.772367,0.818460
04-23 20:29:22.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:357,0.036154,9.772432,0.817710
04-23 20:29:22.359+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.389+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:373,0.038182,9.772526,0.816493
04-23 20:29:22.409+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:29:22.419+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.419+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:425,0.036434,9.772287,0.819420
04-23 20:29:22.419+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:429,0.035991,9.772305,0.819223
04-23 20:29:22.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:434,0.034872,9.772229,0.820188
04-23 20:29:22.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:438,0.033476,9.772130,0.821430
04-23 20:29:22.439+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.439+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:443,0.032485,9.772125,0.821518
04-23 20:29:22.459+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:464,0.030886,9.771869,0.824630
04-23 20:29:22.479+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:483,0.030369,9.771857,0.824783
04-23 20:29:22.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:502,0.030319,9.771805,0.825405
04-23 20:29:22.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:524,0.030738,9.771962,0.823530
04-23 20:29:22.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.539+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:542,0.030694,9.772090,0.822012
04-23 20:29:22.559+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.559+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:563,0.031112,9.772246,0.820128
04-23 20:29:22.579+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.579+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:583,0.030596,9.772174,0.821014
04-23 20:29:22.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.599+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:602,0.031927,9.772439,0.817801
04-23 20:29:22.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:622,0.033631,9.772680,0.814844
04-23 20:29:22.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.639+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:643,0.035224,9.772591,0.815851
04-23 20:29:22.659+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.659+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:663,0.035187,9.772503,0.816902
04-23 20:29:22.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.689+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:693,0.035606,9.772658,0.815028
04-23 20:29:22.759+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:770,0.035669,9.772631,0.815355
04-23 20:29:22.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:774,0.034598,9.772505,0.816907
04-23 20:29:22.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:779,0.033555,9.772468,0.817394
04-23 20:29:22.779+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:784,0.033938,9.772452,0.817558
04-23 20:29:22.779+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:788,0.033506,9.772420,0.817962
04-23 20:29:22.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.799+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:802,0.034575,9.772517,0.816756
04-23 20:29:22.819+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:823,0.033982,9.772460,0.817466
04-23 20:29:22.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.839+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:842,0.034678,9.772438,0.817706
04-23 20:29:22.859+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.859+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:863,0.034548,9.772442,0.817665
04-23 20:29:22.879+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.879+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:883,0.035912,9.772586,0.815879
04-23 20:29:22.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:902,0.037899,9.772861,0.812487
04-23 20:29:22.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:922,0.038184,9.772766,0.813609
04-23 20:29:22.939+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.939+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:943,0.037779,9.772626,0.815316
04-23 20:29:22.959+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:963,0.038751,9.772557,0.816094
04-23 20:29:22.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:22:982,0.038300,9.772491,0.816898
04-23 20:29:22.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:22.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:2,0.038451,9.772698,0.814412
04-23 20:29:23.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.019+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:22,0.038349,9.772717,0.814201
04-23 20:29:23.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.039+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:42,0.038256,9.772601,0.815589
04-23 20:29:23.059+0200 W/LOCATION( 9013): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:29:23.059+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.069+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:73,0.038726,9.772470,0.817137
04-23 20:29:23.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.079+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:82,0.036111,9.772218,0.820270
04-23 20:29:23.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:102,0.036695,9.772131,0.821274
04-23 20:29:23.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:122,0.035397,9.772227,0.820191
04-23 20:29:23.129+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.139+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:142,0.035449,9.772305,0.819254
04-23 20:29:23.159+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:163,0.034697,9.772318,0.819141
04-23 20:29:23.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.179+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:182,0.034673,9.772371,0.818503
04-23 20:29:23.189+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.199+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:202,0.034531,9.772333,0.818962
04-23 20:29:23.209+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.219+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:222,0.033937,9.772326,0.819079
04-23 20:29:23.229+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.239+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:242,0.035416,9.772326,0.819016
04-23 20:29:23.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.269+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:277,0.035586,9.772228,0.820162
04-23 20:29:23.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:23.279+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:23:283,0.034269,9.772065,0.822163
04-23 20:29:23.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:23.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:23.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:23.289+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11090136c6f63152450816
