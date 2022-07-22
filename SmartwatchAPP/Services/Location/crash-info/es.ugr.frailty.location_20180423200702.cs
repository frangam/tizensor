S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6329
Date: 2018-04-23 20:07:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf748852d, r5   = 0xf7966f98
r6   = 0xffc37b60, r7   = 0xffc37a10
r8   = 0xf7963c18, r9   = 0x00000000
r10  = 0xffc37aec, fp   = 0xffc37b60
ip   = 0x00000001, sp   = 0xffc379e8
lr   = 0xf7488539, pc   = 0xf74f1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111720 KB
Buffers:     37764 KB
Cached:     183400 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11904 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6329 TID = 6329
6329 6332 

Maps Information
f4353000 f4b52000 rw-p [stack:6332]
f4b59000 f4b5b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b63000 f4b67000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b70000 f4b72000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b7a000 f4b7d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b8c000 f4b91000 r-xp /usr/lib/libsystem.so.0.0.0
f4b9c000 f4b9f000 r-xp /lib/libattr.so.1.1.0
f4ba7000 f4bb7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bbf000 f4bc8000 r-xp /usr/lib/libedbus.so.1.7.99
f4bd0000 f4bd1000 r-xp /usr/lib/libresponse.so.0.2.96
f4bda000 f4bdf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6481000 f6587000 r-xp /usr/lib/libicuuc.so.57.1
f659d000 f6725000 r-xp /usr/lib/libicui18n.so.57.1
f6735000 f6742000 r-xp /usr/lib/libail.so.0.1.0
f674b000 f6752000 r-xp /usr/lib/libminizip.so.1.0.0
f675b000 f6904000 r-xp /usr/lib/libcrypto.so.1.0.0
f6924000 f696b000 r-xp /usr/lib/libssl.so.1.0.0
f6977000 f6979000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6981000 f6988000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6991000 f6998000 r-xp /lib/libcrypt-2.13.so
f69c9000 f69cc000 r-xp /lib/libcap.so.2.21
f69d4000 f69d6000 r-xp /usr/lib/libiri.so
f69de000 f6a27000 r-xp /usr/lib/libmdm.so.1.2.69
f6a2f000 f6a35000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a3d000 f6a60000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a6a000 f6a6c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a74000 f6a91000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a9a000 f6a9e000 r-xp /usr/lib/libsmack.so.1.0.0
f6aa7000 f6ac0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ac9000 f6ad1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ad9000 f6adf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ae8000 f6aea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6af3000 f6b03000 r-xp /lib/libresolv-2.13.so
f6b07000 f6b1f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b28000 f6b2a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b32000 f6b4c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b54000 f6b83000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b8c000 f6b9b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ba5000 f6baf000 r-xp /usr/lib/libsensord-shared.so
f6bb8000 f6c8b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c96000 f6cac000 r-xp /lib/libz.so.1.2.5
f6cb4000 f6cb9000 r-xp /usr/lib/libffi.so.5.0.10
f6cc1000 f6cc2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cca000 f6cda000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ce2000 f6cfb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d03000 f6d05000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d0d000 f6d82000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d8c000 f6d92000 r-xp /lib/librt-2.13.so
f6d9b000 f6db9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dc3000 f6dc4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dcc000 f6def000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6df7000 f6dfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e04000 f6e2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e37000 f6e4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e56000 f6ebf000 r-xp /lib/libm-2.13.so
f6ec8000 f6f5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f6f000 f6f74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f7c000 f6f83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f8b000 f6fb5000 r-xp /usr/lib/libsensor.so.1.9.6
f6fbe000 f708a000 r-xp /usr/lib/libxml2.so.2.7.8
f7097000 f7099000 r-xp /usr/lib/libiniparser.so.0
f70a2000 f70a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70b1000 f7181000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7182000 f71b6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71bf000 f71fb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7203000 f7206000 r-xp /usr/lib/libbundle.so.0.1.22
f720e000 f7214000 r-xp /usr/lib/libappsvc.so.0.1.0
f721c000 f725d000 r-xp /usr/lib/libeina.so.1.7.99
f7266000 f727d000 r-xp /usr/lib/libecore.so.1.7.99
f7294000 f729d000 r-xp /usr/lib/libvconf.so.0.2.45
f72a5000 f72b9000 r-xp /lib/libpthread-2.13.so
f72c4000 f72d1000 r-xp /usr/lib/libaul.so.0.1.0
f72db000 f72dd000 r-xp /lib/libdl-2.13.so
f72e6000 f72f1000 r-xp /lib/libunwind.so.8.0.1
f731e000 f7326000 r-xp /lib/libgcc_s-4.6.so.1
f7327000 f744b000 r-xp /lib/libc-2.13.so
f7459000 f745b000 r-xp /usr/lib/libdlog.so.0.0.0
f7463000 f746f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7478000 f747d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7485000 f7494000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f749c000 f74a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74a9000 f74ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f74b4000 f74b6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74be000 f74c2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74ca000 f74e7000 r-xp /lib/ld-2.13.so
f74f0000 f74f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74f3000 f74f7000 r-xp /usr/lib/libsys-assert.so
f7933000 f79bd000 rw-p [heap]
ffc19000 ffc3a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6329)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74f1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7488539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf718f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf718dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7199e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf719fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf719fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71d475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71cf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf718dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7199e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf719fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf719fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71d1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71d2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71d9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b711fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b64171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c37663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70e4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70e67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7276ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7271b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72725a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7272879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74aa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74aa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74f14f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf733e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74f0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:52.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.179+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:172,0.048336,9.771139,0.832397
04-23 20:06:52.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:189,0.047887,9.771165,0.832117
04-23 20:06:52.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.219+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:223,0.047577,9.771158,0.832222
04-23 20:06:52.219+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.239+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:228,0.048407,9.771116,0.832661
04-23 20:06:52.239+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.279+0200 W/AUL     ( 6292): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:06:52.279+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:250,0.045910,9.770955,0.834694
04-23 20:06:52.279+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:06:52.279+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:06:52.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6244
04-23 20:06:52.279+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:06:52.279+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6244
04-23 20:06:52.279+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6244)
04-23 20:06:52.299+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:289,0.045932,9.770987,0.834327
04-23 20:06:52.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.299+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:303,0.046051,9.771049,0.833587
04-23 20:06:52.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.299+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:307,0.047334,9.771450,0.828797
04-23 20:06:52.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:310,0.046473,9.771387,0.829587
04-23 20:06:52.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:319,0.047039,9.771392,0.829497
04-23 20:06:52.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.319+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:323,0.046979,9.771488,0.828369
04-23 20:06:52.319+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.329+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:330,0.046808,9.771468,0.828611
04-23 20:06:52.329+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:335,0.047692,9.771672,0.826152
04-23 20:06:52.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:359,0.047042,9.771700,0.825866
04-23 20:06:52.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:364,0.046999,9.771670,0.826221
04-23 20:06:52.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:369,0.047294,9.771690,0.825959
04-23 20:06:52.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:374,0.048040,9.771719,0.825582
04-23 20:06:52.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:378,0.049324,9.771849,0.823967
04-23 20:06:52.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:382,0.049630,9.772032,0.821778
04-23 20:06:52.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:392,0.047847,9.772038,0.821817
04-23 20:06:52.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:396,0.047429,9.772064,0.821519
04-23 20:06:52.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.399+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:399,0.047358,9.772113,0.820940
04-23 20:06:52.399+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:409,0.048200,9.772216,0.819665
04-23 20:06:52.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:414,0.049490,9.772548,0.815628
04-23 20:06:52.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:418,0.048866,9.772554,0.815578
04-23 20:06:52.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.419+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:421,0.050457,9.772664,0.814169
04-23 20:06:52.419+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.419+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:429,0.049881,9.772672,0.814111
04-23 20:06:52.419+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:436,0.051506,9.772756,0.813012
04-23 20:06:52.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.439+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:440,0.051586,9.772869,0.811640
04-23 20:06:52.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.439+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:444,0.051327,9.772866,0.811682
04-23 20:06:52.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:563,0.059953,9.774421,0.792142
04-23 20:06:52.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.759+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:763,0.048249,9.773596,0.803049
04-23 20:06:52.959+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:52.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:52:963,0.039544,9.773762,0.801502
04-23 20:06:53.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:53.159+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:53:163,0.043251,9.773488,0.804645
04-23 20:06:53.209+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:06:53.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:53.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:53:361,0.050434,9.772929,0.810979
04-23 20:06:53.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:53.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:53:563,0.056952,9.773152,0.807863
04-23 20:06:53.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:53.759+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:53:763,0.055667,9.773096,0.808625
04-23 20:06:53.959+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:53.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:53:963,0.052357,9.773719,0.801285
04-23 20:06:54.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:54.159+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:54:164,0.043823,9.773752,0.801394
04-23 20:06:54.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:54.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:54:359,0.039810,9.773146,0.808968
04-23 20:06:54.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:54.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:54:573,0.042140,9.772120,0.821144
04-23 20:06:54.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:54.759+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:54:763,0.028433,9.769297,0.854648
04-23 20:06:54.959+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:54.959+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:54:965,0.031223,9.771283,0.831527
04-23 20:06:55.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:55.159+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:55:165,0.037184,9.774042,0.798186
04-23 20:06:55.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:55.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:55:361,0.033901,9.772993,0.811071
04-23 20:06:55.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:55.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:55:557,0.037170,9.773200,0.808428
04-23 20:06:55.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:55.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:55:757,0.032916,9.772457,0.817551
04-23 20:06:55.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:55.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:55:958,0.038935,9.774439,0.793229
04-23 20:06:56.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:56.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:56:157,0.015011,9.768201,0.867418
04-23 20:06:56.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:56.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:56:357,0.028339,9.772192,0.820876
04-23 20:06:56.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:56.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:56:557,0.022606,9.774118,0.797798
04-23 20:06:56.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:56.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:56:756,0.017137,9.776429,0.769110
04-23 20:06:56.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:56.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:56:957,0.025989,9.775193,0.784420
04-23 20:06:57.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:57.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:57:157,0.046162,9.774493,0.792174
04-23 20:06:57.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:57.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:57:357,0.046447,9.775092,0.784728
04-23 20:06:57.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:57.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:57:558,0.045035,9.775065,0.785139
04-23 20:06:57.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:57.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:57:757,0.041420,9.773710,0.802031
04-23 20:06:57.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:57.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:57:957,0.044023,9.772013,0.822321
04-23 20:06:58.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:58.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:58:158,0.034318,9.772275,0.819661
04-23 20:06:58.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:58.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:58:359,0.036999,9.771727,0.826055
04-23 20:06:58.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:58.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:58:557,0.047489,9.771820,0.824414
04-23 20:06:58.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:58.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:58:757,0.043929,9.771759,0.825336
04-23 20:06:58.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:58.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:58:957,0.047898,9.772698,0.813913
04-23 20:06:59.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:59.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:59:157,0.052011,9.772455,0.816581
04-23 20:06:59.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:59.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:59:358,0.066830,9.773025,0.808648
04-23 20:06:59.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:59.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:59:557,0.062250,9.774270,0.793821
04-23 20:06:59.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:59.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:59:756,0.063250,9.773601,0.801945
04-23 20:06:59.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:06:59.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:06:59:956,0.055093,9.773866,0.799315
04-23 20:07:00.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:00.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:00:156,0.054487,9.774035,0.797285
04-23 20:07:00.189+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:07:00.189+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:00.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:00.189+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:00.199+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6329
04-23 20:07:00.199+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:00.249+0200 E/CAPI_APPFW_APPLICATION( 6329): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:00.249+0200 E/CAPI_APPFW_APPLICATION( 6329): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:00.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6329
04-23 20:07:00.249+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6329) type(svcapp) bg(0)
04-23 20:07:00.249+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6329)
04-23 20:07:00.249+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:07:00.249+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:00.259+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6329]
04-23 20:07:00.269+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6329) was created
04-23 20:07:00.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:00.279+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6329
04-23 20:07:00.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:00.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6329
04-23 20:07:00.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:00.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:00.319+0200 W/LOCATION( 6329): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:00.319+0200 E/LOCATION( 6329): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:00.319+0200 E/PKGMGR_INFO( 6329): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:00.319+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:00.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:00.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:00:356,0.046254,9.772245,0.819427
04-23 20:07:00.359+0200 I/LOCATION( 6329): location.c: location_new(269) > method: 0
04-23 20:07:00.359+0200 W/LOCATION( 6329): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:00.369+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:00.369+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:00.379+0200 W/LOCATION( 6329): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:00.379+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:00.389+0200 W/LOCATION( 6329): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:00.389+0200 W/LOCATION( 6329): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:00.389+0200 W/LOCATION( 6329): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:00.389+0200 W/LOCATION( 6329): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:00.409+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:00.409+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:00.409+0200 W/LOCATION( 6329): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:00.419+0200 W/LOCATION( 6329): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:00.419+0200 W/LOCATION( 6329): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:00.419+0200 W/LOCATION( 6329): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:00.419+0200 W/LOCATION( 6329): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:00.439+0200 W/LOCATION( 6329): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:00.439+0200 I/LOCATION( 6329): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7963c18
04-23 20:07:00.439+0200 I/LOCATION( 6329): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:00.439+0200 I/LOCATION( 6329): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7963c18
04-23 20:07:00.439+0200 I/LOCATION( 6329): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:00.449+0200 I/location( 6329): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:00.489+0200 I/LOCATION( 6329): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:00.529+0200 W/LOCATION( 6329): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:00.529+0200 W/LOCATION( 6329): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:00.529+0200 I/LOCATION( 6329): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:00.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:00.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:00:563,0.046982,9.772368,0.817918
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:00.609+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:00.609+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:00.609+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:00.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:00.609+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:00.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:00.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:00.609+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:00.609+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:00.619+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:00.619+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:00.619+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:00.619+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:00.669+0200 W/LOCATION( 6329): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:00.669+0200 W/LOCATION( 6329): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:00.739+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:00.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:00.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8d18]
04-23 20:07:00.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:00.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:00.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:00.779+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:00.779+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:00.779+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:00.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:00:755,0.046006,9.772569,0.815573
04-23 20:07:00.789+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:00.799+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:00.799+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:00.799+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:00.799+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:00.799+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:00.799+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:00.799+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:00.799+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:00.799+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:00.799+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:00.819+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:00.819+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:00.819+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:00.829+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:00.849+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:00.849+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(896118), time2(882901)
04-23 20:07:00.849+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:07:00.849+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:00.849+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:00.849+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:00.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:00.889+0200 W/LOCATION( 6329): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:00.889+0200 I/LOCATION( 6329): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:00.889+0200 I/LOCATION( 6329): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:00.889+0200 I/location( 6329): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:00.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:00.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:00:955,0.045294,9.774124,0.796762
04-23 20:07:00.989+0200 I/LOCATION( 6329): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:01.029+0200 E/location( 6329): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:01.029+0200 W/AUL     ( 6329): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:01.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:01.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6329
04-23 20:07:01.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:01.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.039+0200 I/utils   ( 5532): specific action
04-23 20:07:01.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.039+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.039+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:01.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:01.049+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:01.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:01.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:01.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:01.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:01.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(5538), cmd(0)
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 I/utils   ( 5538): specific action
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:01.059+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:01.059+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:01.059+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:01.059+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:01.059+0200 W/AUL     ( 6329): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:01.059+0200 I/location( 6329): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:01.059+0200 W/CAPI_APPFW_APP_CONTROL( 6329): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:01.059+0200 I/utils   ( 6329): specific action
04-23 20:07:01.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:156,0.057475,9.774109,0.796159
04-23 20:07:01.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:01.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:01.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:01.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:367,0.057610,9.773681,0.801391
04-23 20:07:01.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:377,0.057861,9.773740,0.800648
04-23 20:07:01.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:396,0.055976,9.773532,0.803327
04-23 20:07:01.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:416,0.055156,9.773503,0.803720
04-23 20:07:01.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:436,0.055419,9.773655,0.801860
04-23 20:07:01.449+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:456,0.054518,9.773597,0.802636
04-23 20:07:01.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:477,0.053889,9.773651,0.802011
04-23 20:07:01.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:496,0.052492,9.773556,0.803262
04-23 20:07:01.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:516,0.051958,9.773412,0.805051
04-23 20:07:01.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:536,0.052249,9.773370,0.805539
04-23 20:07:01.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:556,0.053681,9.773675,0.801735
04-23 20:07:01.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:578,0.054350,9.773769,0.800542
04-23 20:07:01.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:596,0.053154,9.773726,0.801149
04-23 20:07:01.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:616,0.051203,9.773711,0.801452
04-23 20:07:01.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:636,0.049586,9.773656,0.802231
04-23 20:07:01.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:656,0.047809,9.773624,0.802725
04-23 20:07:01.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:677,0.047380,9.773593,0.803128
04-23 20:07:01.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:696,0.048353,9.773882,0.799549
04-23 20:07:01.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:716,0.048114,9.773996,0.798161
04-23 20:07:01.779+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:791,0.047452,9.773911,0.799249
04-23 20:07:01.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:831,0.046035,9.773764,0.801133
04-23 20:07:01.849+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:858,0.043562,9.773547,0.803904
04-23 20:07:01.859+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:868,0.044653,9.773625,0.802895
04-23 20:07:01.869+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:879,0.045761,9.773753,0.801271
04-23 20:07:01.879+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.889+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:888,0.045680,9.773646,0.802581
04-23 20:07:01.889+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.899+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:900,0.043595,9.773431,0.805312
04-23 20:07:01.899+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:912,0.046539,9.773468,0.804705
04-23 20:07:01.909+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.929+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:923,0.047537,9.773515,0.804068
04-23 20:07:01.929+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.939+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:940,0.046904,9.773569,0.803450
04-23 20:07:01.939+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:948,0.047002,9.773464,0.804718
04-23 20:07:01.949+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:957,0.045271,9.773342,0.806295
04-23 20:07:01.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.989+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:07:01.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:01:983,0.047315,9.773176,0.808186
04-23 20:07:01.989+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:01.999+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:2,0.048282,9.773255,0.807175
04-23 20:07:02.009+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:16,0.048168,9.773251,0.807238
04-23 20:07:02.029+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:39,0.046701,9.773170,0.808312
04-23 20:07:02.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:57,0.046325,9.773181,0.808189
04-23 20:07:02.069+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.069+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:79,0.046536,9.773132,0.808767
04-23 20:07:02.089+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.089+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:96,0.045826,9.773205,0.807930
04-23 20:07:02.109+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.109+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:117,0.046639,9.773199,0.807950
04-23 20:07:02.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:137,0.046172,9.773144,0.808653
04-23 20:07:02.149+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:156,0.046161,9.773169,0.808355
04-23 20:07:02.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:178,0.045137,9.773104,0.809193
04-23 20:07:02.189+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.189+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:197,0.045184,9.773170,0.808394
04-23 20:07:02.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.209+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:216,0.044215,9.773113,0.809125
04-23 20:07:02.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:236,0.043575,9.773416,0.805498
04-23 20:07:02.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.299+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:303,0.044069,9.773643,0.802716
04-23 20:07:02.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:309,0.044278,9.773589,0.803350
04-23 20:07:02.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:314,0.043680,9.773556,0.803796
04-23 20:07:02.309+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.319+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:320,0.042316,9.773450,0.805153
04-23 20:07:02.329+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.329+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:336,0.042948,9.773503,0.804469
04-23 20:07:02.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:02.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:02.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:02.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:357,0.043544,9.773565,0.803683
04-23 20:07:02.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:378,0.043103,9.773615,0.803100
04-23 20:07:02.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:395,0.042909,9.773665,0.802500
04-23 20:07:02.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:416,0.043756,9.773823,0.800534
04-23 20:07:02.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:436,0.043308,9.773824,0.800548
04-23 20:07:02.449+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:455,0.044906,9.773666,0.802381
04-23 20:07:02.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:477,0.043822,9.773683,0.802239
04-23 20:07:02.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:495,0.043475,9.773725,0.801751
04-23 20:07:02.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:515,0.044054,9.773429,0.805319
04-23 20:07:02.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:535,0.045270,9.773830,0.800357
04-23 20:07:02.559+0200 W/LOCATION( 6329): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:07:02.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:583,0.046484,9.774186,0.795932
04-23 20:07:02.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:588,0.046339,9.774077,0.797280
04-23 20:07:02.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.599+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:601,0.046660,9.774195,0.795821
04-23 20:07:02.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:614,0.045080,9.773982,0.798510
04-23 20:07:02.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:634,0.042990,9.773838,0.800388
04-23 20:07:02.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:656,0.043258,9.773790,0.800958
04-23 20:07:02.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:676,0.042734,9.773575,0.803613
04-23 20:07:02.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:694,0.041058,9.773587,0.803545
04-23 20:07:02.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:715,0.040163,9.773594,0.803508
04-23 20:07:02.729+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:735,0.041736,9.773821,0.800666
04-23 20:07:02.749+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:754,0.043312,9.773978,0.798660
04-23 20:07:02.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:778,0.043896,9.773921,0.799330
04-23 20:07:02.789+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:02.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:02:794,0.041296,9.773704,0.802115
04-23 20:07:02.799+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11063296c6f63152450682
