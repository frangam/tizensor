S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6547
Date: 2018-04-23 20:07:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72c852d, r5   = 0xf79d4f98
r6   = 0xffb0fde0, r7   = 0xffb0fc90
r8   = 0xf79d1c18, r9   = 0x00000000
r10  = 0xffb0fd6c, fp   = 0xffb0fde0
ip   = 0x00000001, sp   = 0xffb0fc68
lr   = 0xf72c8539, pc   = 0xf7331228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     89732 KB
Buffers:     38352 KB
Cached:     184240 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11832 KB
VmRSS:       11828 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6547 TID = 6547
6547 6552 

Maps Information
f4193000 f4992000 rw-p [stack:6552]
f4999000 f499b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49a3000 f49a7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49b0000 f49b2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49ba000 f49bd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49cc000 f49d1000 r-xp /usr/lib/libsystem.so.0.0.0
f49dc000 f49df000 r-xp /lib/libattr.so.1.1.0
f49e7000 f49f7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49ff000 f4a08000 r-xp /usr/lib/libedbus.so.1.7.99
f4a10000 f4a11000 r-xp /usr/lib/libresponse.so.0.2.96
f4a1a000 f4a1f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62c1000 f63c7000 r-xp /usr/lib/libicuuc.so.57.1
f63dd000 f6565000 r-xp /usr/lib/libicui18n.so.57.1
f6575000 f6582000 r-xp /usr/lib/libail.so.0.1.0
f658b000 f6592000 r-xp /usr/lib/libminizip.so.1.0.0
f659b000 f6744000 r-xp /usr/lib/libcrypto.so.1.0.0
f6764000 f67ab000 r-xp /usr/lib/libssl.so.1.0.0
f67b7000 f67b9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67c1000 f67c8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67d1000 f67d8000 r-xp /lib/libcrypt-2.13.so
f6809000 f680c000 r-xp /lib/libcap.so.2.21
f6814000 f6816000 r-xp /usr/lib/libiri.so
f681e000 f6867000 r-xp /usr/lib/libmdm.so.1.2.69
f686f000 f6875000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f687d000 f68a0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68aa000 f68ac000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68b4000 f68d1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68da000 f68de000 r-xp /usr/lib/libsmack.so.1.0.0
f68e7000 f6900000 r-xp /usr/lib/libnetwork.so.0.0.0
f6909000 f6911000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6919000 f691f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6928000 f692a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6933000 f6943000 r-xp /lib/libresolv-2.13.so
f6947000 f695f000 r-xp /usr/lib/liblzma.so.5.0.3
f6968000 f696a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6972000 f698c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6994000 f69c3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69cc000 f69db000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69e5000 f69ef000 r-xp /usr/lib/libsensord-shared.so
f69f8000 f6acb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ad6000 f6aec000 r-xp /lib/libz.so.1.2.5
f6af4000 f6af9000 r-xp /usr/lib/libffi.so.5.0.10
f6b01000 f6b02000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b0a000 f6b1a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b22000 f6b3b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b43000 f6b45000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b4d000 f6bc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bcc000 f6bd2000 r-xp /lib/librt-2.13.so
f6bdb000 f6bf9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c03000 f6c04000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c0c000 f6c2f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c37000 f6c3c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c44000 f6c6e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c77000 f6c8e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c96000 f6cff000 r-xp /lib/libm-2.13.so
f6d08000 f6d9c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6daf000 f6db4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dbc000 f6dc3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dcb000 f6df5000 r-xp /usr/lib/libsensor.so.1.9.6
f6dfe000 f6eca000 r-xp /usr/lib/libxml2.so.2.7.8
f6ed7000 f6ed9000 r-xp /usr/lib/libiniparser.so.0
f6ee2000 f6ee8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ef1000 f6fc1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fc2000 f6ff6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fff000 f703b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7043000 f7046000 r-xp /usr/lib/libbundle.so.0.1.22
f704e000 f7054000 r-xp /usr/lib/libappsvc.so.0.1.0
f705c000 f709d000 r-xp /usr/lib/libeina.so.1.7.99
f70a6000 f70bd000 r-xp /usr/lib/libecore.so.1.7.99
f70d4000 f70dd000 r-xp /usr/lib/libvconf.so.0.2.45
f70e5000 f70f9000 r-xp /lib/libpthread-2.13.so
f7104000 f7111000 r-xp /usr/lib/libaul.so.0.1.0
f711b000 f711d000 r-xp /lib/libdl-2.13.so
f7126000 f7131000 r-xp /lib/libunwind.so.8.0.1
f715e000 f7166000 r-xp /lib/libgcc_s-4.6.so.1
f7167000 f728b000 r-xp /lib/libc-2.13.so
f7299000 f729b000 r-xp /usr/lib/libdlog.so.0.0.0
f72a3000 f72af000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72b8000 f72bd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72c5000 f72d4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72dc000 f72e0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72e9000 f72ec000 r-xp /usr/lib/libappcore-agent.so.1.1
f72f4000 f72f6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72fe000 f7302000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f730a000 f7327000 r-xp /lib/ld-2.13.so
f7330000 f7333000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7333000 f7337000 r-xp /usr/lib/libsys-assert.so
f79a1000 f7a12000 rw-p [heap]
ffaf1000 ffb12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6547)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7331228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72c8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fcf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fcdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fd9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fdfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fdfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf701475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf700f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fcdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fd9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fdfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fdfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7011e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7012017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7019f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49b11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49a4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a77663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f24fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f267a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70b6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70b1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70b25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70b2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72ea183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72ea7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73314f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf717e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7330f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
lty.gravity
04-23 20:07:31.999+0200 W/AUL     ( 6510): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:07:31.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:31.999+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:31.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6475
04-23 20:07:31.999+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:31.999+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6475
04-23 20:07:31.999+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6475)
04-23 20:07:32.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:31:982,0.057837,9.772917,0.810643
04-23 20:07:32.009+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.019+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:21,0.056749,9.773017,0.809509
04-23 20:07:32.019+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:33,0.057754,9.773289,0.806144
04-23 20:07:32.029+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.039+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:40,0.063472,9.773913,0.798107
04-23 20:07:32.039+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:50,0.069542,9.773334,0.804678
04-23 20:07:32.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:55,0.069052,9.772860,0.810454
04-23 20:07:32.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:174,0.065405,9.772855,0.810814
04-23 20:07:32.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:374,0.048573,9.772403,0.817413
04-23 20:07:32.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:573,0.059743,9.773977,0.797605
04-23 20:07:32.739+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:07:32.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:774,0.058356,9.773582,0.802542
04-23 20:07:32.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:32.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:32:973,0.055865,9.773678,0.801550
04-23 20:07:33.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:33.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:33:173,0.046959,9.774148,0.796368
04-23 20:07:33.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:33.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:33:374,0.063261,9.773311,0.805467
04-23 20:07:33.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:33.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:33:573,0.061562,9.773077,0.808433
04-23 20:07:33.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:33.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:33:773,0.061204,9.774131,0.795616
04-23 20:07:33.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:33.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:33:973,0.059351,9.773227,0.806786
04-23 20:07:34.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:34.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:34:173,0.054126,9.773639,0.802152
04-23 20:07:34.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:34.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:34:373,0.049834,9.773303,0.806509
04-23 20:07:34.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:34.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:34:574,0.055878,9.774474,0.791777
04-23 20:07:34.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:34.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:34:773,0.054939,9.774098,0.796472
04-23 20:07:34.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:34.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:34:973,0.059294,9.772879,0.810997
04-23 20:07:35.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:35.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:35:176,0.060368,9.773153,0.807594
04-23 20:07:35.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:35.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:35:374,0.044417,9.772600,0.815292
04-23 20:07:35.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:35.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:35:575,0.042601,9.771700,0.826103
04-23 20:07:35.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:35.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:35:774,0.049466,9.773751,0.801079
04-23 20:07:35.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:35.979+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:35:983,0.054697,9.773101,0.808639
04-23 20:07:36.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:36.179+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:36:183,0.048678,9.773167,0.808231
04-23 20:07:36.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:36.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:36:383,0.055117,9.773997,0.797693
04-23 20:07:36.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:36.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:36:583,0.055278,9.773372,0.805316
04-23 20:07:36.779+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:36.779+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:36:783,0.048211,9.773500,0.804202
04-23 20:07:36.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:36.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:36:974,0.054611,9.774499,0.791558
04-23 20:07:37.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:37.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:37:173,0.052553,9.773674,0.801822
04-23 20:07:37.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:37.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:37:373,0.051992,9.773881,0.799329
04-23 20:07:37.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:37.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:37:573,0.046048,9.773216,0.807780
04-23 20:07:37.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:37.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:37:773,0.051629,9.773425,0.804905
04-23 20:07:37.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:37.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:37:973,0.038708,9.772815,0.813009
04-23 20:07:38.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:38.199+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:38:174,0.048217,9.772336,0.818236
04-23 20:07:38.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:38.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:38:373,0.049072,9.772704,0.813773
04-23 20:07:38.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:38.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:38:573,0.049722,9.773069,0.809332
04-23 20:07:38.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:38.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:38:773,0.058865,9.773252,0.806502
04-23 20:07:38.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:38.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:38:973,0.057793,9.773793,0.800008
04-23 20:07:39.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:39.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:39:173,0.057851,9.774489,0.791453
04-23 20:07:39.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:39.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:39:374,0.058782,9.774528,0.790906
04-23 20:07:39.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:39.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:39:574,0.056915,9.774839,0.787185
04-23 20:07:39.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:39.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:39:774,0.055660,9.775521,0.778759
04-23 20:07:39.769+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:07:39.769+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:39.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:39.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:39.779+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6547
04-23 20:07:39.789+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:39.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6547
04-23 20:07:39.829+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6547) type(svcapp) bg(0)
04-23 20:07:39.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6547)
04-23 20:07:39.839+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:07:39.839+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:39.839+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6547]
04-23 20:07:39.839+0200 E/CAPI_APPFW_APPLICATION( 6547): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:39.849+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:39.859+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6547
04-23 20:07:39.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:39.869+0200 E/CAPI_APPFW_APPLICATION( 6547): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:39.869+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6547) was created
04-23 20:07:39.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:39.879+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6547
04-23 20:07:39.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:39.909+0200 W/LOCATION( 6547): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:39.909+0200 E/LOCATION( 6547): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:39.909+0200 E/PKGMGR_INFO( 6547): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:39.909+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:39.929+0200 I/LOCATION( 6547): location.c: location_new(269) > method: 0
04-23 20:07:39.929+0200 W/LOCATION( 6547): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:39.939+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:39.939+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:39.949+0200 W/LOCATION( 6547): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:39.949+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:39.949+0200 W/LOCATION( 6547): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:39.949+0200 W/LOCATION( 6547): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:39.949+0200 W/LOCATION( 6547): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:39.949+0200 W/LOCATION( 6547): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:39.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:39.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:39:974,0.066889,9.776413,0.766590
04-23 20:07:39.979+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:39.989+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:39.989+0200 W/LOCATION( 6547): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:39.999+0200 W/LOCATION( 6547): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:39.999+0200 W/LOCATION( 6547): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:39.999+0200 W/LOCATION( 6547): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:39.999+0200 W/LOCATION( 6547): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:40.019+0200 W/LOCATION( 6547): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:40.019+0200 I/LOCATION( 6547): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf79d1c18
04-23 20:07:40.019+0200 I/LOCATION( 6547): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:40.019+0200 I/LOCATION( 6547): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf79d1c18
04-23 20:07:40.019+0200 I/LOCATION( 6547): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:40.019+0200 I/location( 6547): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:40.069+0200 I/LOCATION( 6547): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:40.109+0200 W/LOCATION( 6547): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:40.109+0200 W/LOCATION( 6547): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:40.109+0200 I/LOCATION( 6547): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:40.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:172,0.043231,9.775853,0.775375
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:40.189+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:40.189+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:40.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:40.189+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:40.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:40.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:40.189+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:40.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:40.189+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:40.189+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:40.189+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:40.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:40.249+0200 W/LOCATION( 6547): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:40.249+0200 W/LOCATION( 6547): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:40.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:40.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:40.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:40.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:40.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:373,0.045703,9.774532,0.791712
04-23 20:07:40.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f276f8]
04-23 20:07:40.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:40.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:40.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:40.399+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:40.409+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:40.409+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:40.419+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:40.429+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:40.429+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:40.429+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:40.429+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:40.429+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:40.429+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:40.429+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:40.429+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:40.429+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:40.429+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:40.429+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:40.429+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:40.429+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(935699), time2(922443)
04-23 20:07:40.439+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:07:40.439+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:40.439+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:40.439+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:40.439+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:40.439+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:40.449+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:40.489+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:40.519+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:526,0.047419,9.774652,0.790136
04-23 20:07:40.539+0200 W/LOCATION( 6547): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:40.539+0200 I/LOCATION( 6547): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:40.539+0200 I/LOCATION( 6547): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:40.539+0200 I/location( 6547): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:40.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:549,0.048048,9.774761,0.788744
04-23 20:07:40.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:562,0.049786,9.774942,0.786391
04-23 20:07:40.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:572,0.050736,9.774934,0.786431
04-23 20:07:40.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:583,0.050167,9.775043,0.785115
04-23 20:07:40.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:592,0.050652,9.774932,0.786459
04-23 20:07:40.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.599+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:603,0.050546,9.774958,0.786150
04-23 20:07:40.599+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:612,0.051006,9.774884,0.787036
04-23 20:07:40.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.619+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:622,0.051223,9.774838,0.787582
04-23 20:07:40.619+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:631,0.050401,9.774785,0.788299
04-23 20:07:40.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.639+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:642,0.050299,9.774923,0.786590
04-23 20:07:40.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:656,0.050876,9.774974,0.785931
04-23 20:07:40.659+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:669,0.051083,9.774864,0.787281
04-23 20:07:40.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:680,0.053149,9.775195,0.783014
04-23 20:07:40.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:695,0.051461,9.775059,0.784827
04-23 20:07:40.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.699+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:703,0.053469,9.774910,0.786551
04-23 20:07:40.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:713,0.053352,9.774843,0.787390
04-23 20:07:40.719+0200 I/LOCATION( 6547): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:40.719+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:733,0.052105,9.774814,0.787840
04-23 20:07:40.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:753,0.052944,9.774779,0.788212
04-23 20:07:40.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:774,0.051478,9.774726,0.788967
04-23 20:07:40.779+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:793,0.052244,9.774590,0.790604
04-23 20:07:40.789+0200 E/location( 6547): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:40.799+0200 W/AUL     ( 6547): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:40.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:40.799+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6547
04-23 20:07:40.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:40.809+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:40.809+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:40.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:816,0.053352,9.774599,0.790415
04-23 20:07:40.809+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.809+0200 I/utils   ( 5532): specific action
04-23 20:07:40.809+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.809+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.809+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.809+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:40.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:40.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:40.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:40.829+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:40.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 I/utils   ( 5538): specific action
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:40.829+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:40.829+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:40.829+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:40.829+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:40.829+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:838,0.053138,9.774582,0.790639
04-23 20:07:40.829+0200 W/AUL     ( 6547): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:40.829+0200 I/location( 6547): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:40.829+0200 W/CAPI_APPFW_APP_CONTROL( 6547): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:40.829+0200 I/utils   ( 6547): specific action
04-23 20:07:40.849+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:853,0.052926,9.774789,0.788095
04-23 20:07:40.869+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:875,0.052472,9.774827,0.787645
04-23 20:07:40.889+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.889+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:893,0.051822,9.774820,0.787774
04-23 20:07:40.909+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:913,0.051546,9.774900,0.786796
04-23 20:07:40.929+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.929+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:934,0.050032,9.774813,0.787988
04-23 20:07:40.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:953,0.049498,9.774883,0.787143
04-23 20:07:40.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:975,0.048438,9.774815,0.788061
04-23 20:07:40.989+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:40.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:40:994,0.048103,9.774720,0.789248
04-23 20:07:41.009+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:13,0.047783,9.774655,0.790070
04-23 20:07:41.029+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:33,0.047697,9.774522,0.791728
04-23 20:07:41.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:54,0.048303,9.774425,0.792893
04-23 20:07:41.069+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.069+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:75,0.047865,9.774260,0.794952
04-23 20:07:41.089+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.089+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:93,0.049687,9.773978,0.798289
04-23 20:07:41.109+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.109+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:114,0.048723,9.773900,0.799304
04-23 20:07:41.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:133,0.048710,9.773684,0.801953
04-23 20:07:41.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:153,0.048592,9.773683,0.801970
04-23 20:07:41.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:175,0.048828,9.773562,0.803413
04-23 20:07:41.189+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.189+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:193,0.049610,9.773437,0.804897
04-23 20:07:41.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:213,0.050251,9.773450,0.804699
04-23 20:07:41.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:234,0.048930,9.773409,0.805281
04-23 20:07:41.249+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:253,0.048466,9.773402,0.805388
04-23 20:07:41.269+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.269+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:274,0.049625,9.773487,0.804287
04-23 20:07:41.289+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:41.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:41.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:41.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:294,0.049114,9.773529,0.803809
04-23 20:07:41.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:379,0.049403,9.773526,0.803826
04-23 20:07:41.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:388,0.050026,9.773547,0.803529
04-23 20:07:41.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:397,0.050300,9.773599,0.802880
04-23 20:07:41.399+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:410,0.050364,9.773449,0.804704
04-23 20:07:41.419+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.419+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:426,0.051299,9.773539,0.803548
04-23 20:07:41.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.439+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:447,0.051404,9.773539,0.803541
04-23 20:07:41.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.459+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:463,0.052186,9.773561,0.803223
04-23 20:07:41.489+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:07:41.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.499+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:505,0.051560,9.773473,0.804339
04-23 20:07:41.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:510,0.051873,9.773472,0.804329
04-23 20:07:41.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:517,0.052901,9.773479,0.804178
04-23 20:07:41.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.519+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:523,0.050883,9.773315,0.806283
04-23 20:07:41.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:533,0.051347,9.773252,0.807036
04-23 20:07:41.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:552,0.051932,9.773181,0.807853
04-23 20:07:41.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:573,0.051672,9.773069,0.809221
04-23 20:07:41.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:593,0.052673,9.773247,0.807000
04-23 20:07:41.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:614,0.052262,9.773297,0.806423
04-23 20:07:41.619+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:632,0.051293,9.773308,0.806357
04-23 20:07:41.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:652,0.052209,9.773488,0.804113
04-23 20:07:41.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:673,0.051919,9.773506,0.803910
04-23 20:07:41.679+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:692,0.053019,9.773708,0.801376
04-23 20:07:41.699+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:712,0.052927,9.773657,0.802005
04-23 20:07:41.719+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:732,0.052711,9.773660,0.801987
04-23 20:07:41.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:752,0.053313,9.773662,0.801919
04-23 20:07:41.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.839+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:780,0.052525,9.773589,0.802852
04-23 20:07:41.839+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:851,0.051643,9.773635,0.802353
04-23 20:07:41.849+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:858,0.052403,9.773659,0.802014
04-23 20:07:41.859+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.859+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:864,0.051425,9.773634,0.802382
04-23 20:07:41.859+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:870,0.049903,9.773643,0.802358
04-23 20:07:41.869+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:878,0.052470,9.773917,0.798858
04-23 20:07:41.879+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.889+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:893,0.051609,9.773929,0.798771
04-23 20:07:41.899+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:912,0.051471,9.774026,0.797589
04-23 20:07:41.919+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.929+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:933,0.051555,9.774035,0.797466
04-23 20:07:41.939+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:952,0.052237,9.774229,0.795052
04-23 20:07:41.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:973,0.053034,9.774364,0.793345
04-23 20:07:41.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:41.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:41:992,0.051568,9.774372,0.793326
04-23 20:07:41.999+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:12,0.052116,9.774470,0.792079
04-23 20:07:42.019+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:32,0.053077,9.774345,0.793560
04-23 20:07:42.039+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:52,0.054458,9.774325,0.793710
04-23 20:07:42.069+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.069+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:74,0.053592,9.774315,0.793907
04-23 20:07:42.079+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.099+0200 W/LOCATION( 6547): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:07:42.119+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:93,0.053241,9.774332,0.793710
04-23 20:07:42.119+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.119+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:128,0.054139,9.774233,0.794871
04-23 20:07:42.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:139,0.053200,9.774062,0.797029
04-23 20:07:42.139+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:152,0.054848,9.773808,0.800024
04-23 20:07:42.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:174,0.055496,9.773678,0.801582
04-23 20:07:42.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.189+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:192,0.056077,9.773747,0.800682
04-23 20:07:42.199+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:212,0.055825,9.773767,0.800458
04-23 20:07:42.219+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:232,0.055365,9.773752,0.800684
04-23 20:07:42.239+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:252,0.054242,9.773678,0.801666
04-23 20:07:42.269+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.269+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:273,0.053187,9.773542,0.803381
04-23 20:07:42.279+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.289+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:292,0.054969,9.773386,0.805169
04-23 20:07:42.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.319+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:316,0.056151,9.773454,0.804259
04-23 20:07:42.319+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:42.329+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:42.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:42.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:42.339+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:42:334,0.056461,9.773464,0.804109
04-23 20:07:42.349+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11065476c6f63152450686
