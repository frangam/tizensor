S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9158
Date: 2018-04-23 20:29:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf724e52d, r5   = 0xf75a3f98
r6   = 0xff87d1f0, r7   = 0xff87d0a0
r8   = 0xf75a0c18, r9   = 0x00000000
r10  = 0xff87d17c, fp   = 0xff87d1f0
ip   = 0x00000001, sp   = 0xff87d078
lr   = 0xf724e539, pc   = 0xf72b7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    135492 KB
Buffers:     34336 KB
Cached:     152988 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12012 KB
VmRSS:       12012 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9158 TID = 9158
9158 9161 

Maps Information
f4119000 f4918000 rw-p [stack:9161]
f491f000 f4921000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4929000 f492d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4936000 f4938000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4940000 f4943000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4952000 f4957000 r-xp /usr/lib/libsystem.so.0.0.0
f4962000 f4965000 r-xp /lib/libattr.so.1.1.0
f496d000 f497d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4985000 f498e000 r-xp /usr/lib/libedbus.so.1.7.99
f4996000 f4997000 r-xp /usr/lib/libresponse.so.0.2.96
f49a0000 f49a5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6247000 f634d000 r-xp /usr/lib/libicuuc.so.57.1
f6363000 f64eb000 r-xp /usr/lib/libicui18n.so.57.1
f64fb000 f6508000 r-xp /usr/lib/libail.so.0.1.0
f6511000 f6518000 r-xp /usr/lib/libminizip.so.1.0.0
f6521000 f66ca000 r-xp /usr/lib/libcrypto.so.1.0.0
f66ea000 f6731000 r-xp /usr/lib/libssl.so.1.0.0
f673d000 f673f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6747000 f674e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6757000 f675e000 r-xp /lib/libcrypt-2.13.so
f678f000 f6792000 r-xp /lib/libcap.so.2.21
f679a000 f679c000 r-xp /usr/lib/libiri.so
f67a4000 f67ed000 r-xp /usr/lib/libmdm.so.1.2.69
f67f5000 f67fb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6803000 f6826000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6830000 f6832000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f683a000 f6857000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6860000 f6864000 r-xp /usr/lib/libsmack.so.1.0.0
f686d000 f6886000 r-xp /usr/lib/libnetwork.so.0.0.0
f688f000 f6897000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f689f000 f68a5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68ae000 f68b0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68b9000 f68c9000 r-xp /lib/libresolv-2.13.so
f68cd000 f68e5000 r-xp /usr/lib/liblzma.so.5.0.3
f68ee000 f68f0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68f8000 f6912000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f691a000 f6949000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6952000 f6961000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f696b000 f6975000 r-xp /usr/lib/libsensord-shared.so
f697e000 f6a51000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a5c000 f6a72000 r-xp /lib/libz.so.1.2.5
f6a7a000 f6a7f000 r-xp /usr/lib/libffi.so.5.0.10
f6a87000 f6a88000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a90000 f6aa0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6aa8000 f6ac1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ac9000 f6acb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ad3000 f6b48000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b52000 f6b58000 r-xp /lib/librt-2.13.so
f6b61000 f6b7f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b89000 f6b8a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b92000 f6bb5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bbd000 f6bc2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bca000 f6bf4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bfd000 f6c14000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c1c000 f6c85000 r-xp /lib/libm-2.13.so
f6c8e000 f6d22000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d35000 f6d3a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d42000 f6d49000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d51000 f6d7b000 r-xp /usr/lib/libsensor.so.1.9.6
f6d84000 f6e50000 r-xp /usr/lib/libxml2.so.2.7.8
f6e5d000 f6e5f000 r-xp /usr/lib/libiniparser.so.0
f6e68000 f6e6e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e77000 f6f47000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f48000 f6f7c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f85000 f6fc1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fc9000 f6fcc000 r-xp /usr/lib/libbundle.so.0.1.22
f6fd4000 f6fda000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fe2000 f7023000 r-xp /usr/lib/libeina.so.1.7.99
f702c000 f7043000 r-xp /usr/lib/libecore.so.1.7.99
f705a000 f7063000 r-xp /usr/lib/libvconf.so.0.2.45
f706b000 f707f000 r-xp /lib/libpthread-2.13.so
f708a000 f7097000 r-xp /usr/lib/libaul.so.0.1.0
f70a1000 f70a3000 r-xp /lib/libdl-2.13.so
f70ac000 f70b7000 r-xp /lib/libunwind.so.8.0.1
f70e4000 f70ec000 r-xp /lib/libgcc_s-4.6.so.1
f70ed000 f7211000 r-xp /lib/libc-2.13.so
f721f000 f7221000 r-xp /usr/lib/libdlog.so.0.0.0
f7229000 f7235000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f723e000 f7243000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f724b000 f725a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7262000 f7266000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f726f000 f7272000 r-xp /usr/lib/libappcore-agent.so.1.1
f727a000 f727c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7284000 f7288000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7290000 f72ad000 r-xp /lib/ld-2.13.so
f72b6000 f72b9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72b9000 f72bd000 r-xp /usr/lib/libsys-assert.so
f7570000 f75f9000 rw-p [heap]
ff85e000 ff87f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9158)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72b7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf724e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f553f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f53c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f5fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f65be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f65dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f9a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f951f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f53c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f5fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f65be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f65dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f97e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f98017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f9ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49371fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf492a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69fd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6eaafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6eac7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf703cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7037b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70385a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7038879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7270183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72707fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72b74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf710485c) [/lib/libc.so.6] + 0x1785c
29: (0xf72b6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
L     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:39.249+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:39.249+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:39.259+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:39.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:39.329+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:29:39.329+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:29:39.329+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:39.329+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76ce098
04-23 20:29:39.379+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:38:871,0.034322,9.772913,0.812020
04-23 20:29:39.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.399+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:400,0.032952,9.772722,0.814369
04-23 20:29:39.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.419+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:421,0.031866,9.772617,0.815673
04-23 20:29:39.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:434,0.030728,9.772421,0.818064
04-23 20:29:39.439+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.449+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:445,0.028637,9.772033,0.822760
04-23 20:29:39.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:462,0.029365,9.772193,0.820832
04-23 20:29:39.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:475,0.030848,9.772465,0.817535
04-23 20:29:39.479+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:493,0.030431,9.772517,0.816928
04-23 20:29:39.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:499,0.030385,9.772565,0.816354
04-23 20:29:39.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:512,0.031382,9.772330,0.819127
04-23 20:29:39.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:516,0.031987,9.772471,0.817413
04-23 20:29:39.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.539+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:523,0.032370,9.772503,0.817026
04-23 20:29:39.549+0200 W/AUL     ( 9120): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:29:39.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:29:39.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:29:39.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9084
04-23 20:29:39.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:29:39.549+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9084
04-23 20:29:39.549+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9084)
04-23 20:29:39.559+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.559+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:564,0.033833,9.772791,0.813514
04-23 20:29:39.559+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.559+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:569,0.034413,9.772849,0.812782
04-23 20:29:39.559+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:573,0.034103,9.772550,0.816388
04-23 20:29:39.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.579+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:582,0.034999,9.772465,0.817370
04-23 20:29:39.579+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.579+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:588,0.034731,9.772607,0.815685
04-23 20:29:39.579+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:592,0.036199,9.772600,0.815700
04-23 20:29:39.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:597,0.035201,9.772526,0.816630
04-23 20:29:39.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.599+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:608,0.035721,9.772561,0.816180
04-23 20:29:39.599+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:612,0.035763,9.772279,0.819559
04-23 20:29:39.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:617,0.036260,9.772420,0.817851
04-23 20:29:39.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:621,0.037194,9.772587,0.815811
04-23 20:29:39.619+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:631,0.036816,9.772712,0.814325
04-23 20:29:39.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:635,0.035771,9.772649,0.815130
04-23 20:29:39.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:639,0.034817,9.772478,0.817217
04-23 20:29:39.639+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.639+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:644,0.034545,9.771616,0.827477
04-23 20:29:39.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:718,0.035215,9.773579,0.803928
04-23 20:29:39.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:39.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:39:918,0.028359,9.772783,0.813807
04-23 20:29:40.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:40.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:40:118,0.042999,9.773309,0.806824
04-23 20:29:40.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:40.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:40:316,0.035998,9.773405,0.806006
04-23 20:29:40.389+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:29:40.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:40.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:40:519,0.044141,9.774722,0.789453
04-23 20:29:40.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:40.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:40:718,0.049532,9.773844,0.799944
04-23 20:29:40.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:40.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:40:919,0.044452,9.773140,0.808792
04-23 20:29:41.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:41.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:41:119,0.045732,9.772676,0.814306
04-23 20:29:41.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:41.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:41:323,0.042638,9.772506,0.816512
04-23 20:29:41.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:41.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:41:519,0.040695,9.772480,0.816926
04-23 20:29:41.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:41.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:41:723,0.049019,9.773178,0.808063
04-23 20:29:41.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:41.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:41:919,0.053727,9.774326,0.793754
04-23 20:29:42.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:42.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:42:119,0.055135,9.773235,0.806984
04-23 20:29:42.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:42.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:42:323,0.041041,9.771681,0.826407
04-23 20:29:42.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:42.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:42:518,0.024682,9.772764,0.814163
04-23 20:29:42.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:42.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:42:718,0.020076,9.777110,0.760330
04-23 20:29:42.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:42.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:42:923,0.018398,9.775270,0.783683
04-23 20:29:43.119+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:43.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:43:123,0.025570,9.774338,0.795016
04-23 20:29:43.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:43.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:43:318,0.033146,9.774117,0.797456
04-23 20:29:43.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:43.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:43:523,0.052153,9.773928,0.798750
04-23 20:29:43.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:43.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:43:720,0.044888,9.772157,0.820564
04-23 20:29:43.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:43.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:43:918,0.037509,9.771554,0.828077
04-23 20:29:44.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:44.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:44:118,0.032422,9.771219,0.832227
04-23 20:29:44.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:44.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:44:317,0.032480,9.770746,0.837760
04-23 20:29:44.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:44.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:44:517,0.031450,9.771212,0.832360
04-23 20:29:44.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:44.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:44:718,0.035015,9.771751,0.825848
04-23 20:29:44.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:44.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:44:917,0.037416,9.770422,0.841329
04-23 20:29:45.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:45.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:45:117,0.031068,9.767598,0.873749
04-23 20:29:45.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:45.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:45:323,0.032851,9.768737,0.860864
04-23 20:29:45.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:45.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:45:517,0.028495,9.769415,0.853294
04-23 20:29:45.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:45.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:45:717,0.023546,9.772689,0.815093
04-23 20:29:45.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:45.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:45:918,0.026612,9.776611,0.766521
04-23 20:29:46.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:46.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:46:117,0.037164,9.776611,0.766082
04-23 20:29:46.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:46.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:46:317,0.034819,9.777001,0.761191
04-23 20:29:46.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:46.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:46:518,0.028435,9.777878,0.750120
04-23 20:29:46.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:46.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:46:717,0.010041,9.781167,0.706437
04-23 20:29:46.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:46.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:46:917,0.018367,9.779684,0.726514
04-23 20:29:47.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:47.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:47:118,0.023765,9.777529,0.754816
04-23 20:29:47.129+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:29:47.129+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:29:47.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:47.129+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:47.139+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9158
04-23 20:29:47.139+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:29:47.189+0200 E/CAPI_APPFW_APPLICATION( 9158): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:47.189+0200 E/CAPI_APPFW_APPLICATION( 9158): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:47.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9158
04-23 20:29:47.189+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9158) type(svcapp) bg(0)
04-23 20:29:47.189+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9158)
04-23 20:29:47.189+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:29:47.189+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:29:47.189+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9158]
04-23 20:29:47.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:47.219+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9158
04-23 20:29:47.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:47.219+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9158
04-23 20:29:47.219+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9158) was created
04-23 20:29:47.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:47.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:47.229+0200 W/LOCATION( 9158): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:29:47.229+0200 E/LOCATION( 9158): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:29:47.229+0200 E/PKGMGR_INFO( 9158): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:29:47.229+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:47.249+0200 I/LOCATION( 9158): location.c: location_new(269) > method: 0
04-23 20:29:47.249+0200 W/LOCATION( 9158): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:47.259+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:47.259+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:47.259+0200 W/LOCATION( 9158): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:47.269+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:47.269+0200 W/LOCATION( 9158): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:47.269+0200 W/LOCATION( 9158): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:47.269+0200 W/LOCATION( 9158): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:47.269+0200 W/LOCATION( 9158): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:47.299+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:47.299+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:47.309+0200 W/LOCATION( 9158): module-internal.c: module_new(311) > module (wps) open success
04-23 20:29:47.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:47.309+0200 W/LOCATION( 9158): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:29:47.319+0200 W/LOCATION( 9158): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:29:47.319+0200 W/LOCATION( 9158): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:47.319+0200 W/LOCATION( 9158): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:47.339+0200 W/LOCATION( 9158): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:29:47.339+0200 I/LOCATION( 9158): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf75a0c18
04-23 20:29:47.339+0200 I/LOCATION( 9158): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:29:47.339+0200 I/LOCATION( 9158): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf75a0c18
04-23 20:29:47.339+0200 I/LOCATION( 9158): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:29:47.339+0200 I/location( 9158): es.ugr.frailty.location: creado servicio de localización
04-23 20:29:47.359+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:47:319,0.032284,9.777333,0.757032
04-23 20:29:47.389+0200 I/LOCATION( 9158): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:29:47.429+0200 W/LOCATION( 9158): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:47.429+0200 W/LOCATION( 9158): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:47.429+0200 I/LOCATION( 9158): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:29:47.499+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:29:47.499+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:47.499+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:47.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:29:47.499+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:29:47.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:29:47.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:29:47.499+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:29:47.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:29:47.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:29:47.509+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:29:47.509+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:29:47.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:29:47.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:47.539+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:47:523,0.037166,9.777503,0.754609
04-23 20:29:47.559+0200 W/LOCATION( 9158): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:47.559+0200 W/LOCATION( 9158): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:47.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:47.679+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76d31b0]
04-23 20:29:47.679+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:47.679+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:47.679+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:47.679+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:47.689+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:47.689+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:47.699+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:47.709+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:47.709+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:47.709+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:47.709+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:47.709+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:47.709+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:47.709+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:47.709+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:47.709+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:47.709+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:47.719+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:47.719+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:47.719+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:47.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:47.729+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:47.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:29:47.729+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2262995), time2(2249835)
04-23 20:29:47.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:29:47.729+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:29:47.729+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:29:47.729+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:29:47.759+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:47:732,0.036818,9.776036,0.773398
04-23 20:29:47.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:47.809+0200 W/LOCATION( 9158): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:29:47.809+0200 I/LOCATION( 9158): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:47.809+0200 I/LOCATION( 9158): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:47.809+0200 I/location( 9158): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:29:47.889+0200 I/LOCATION( 9158): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:47.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:47.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:47:918,0.035926,9.775589,0.779072
04-23 20:29:47.949+0200 E/location( 9158): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:29:47.949+0200 W/AUL     ( 9158): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:29:47.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:47.949+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9158
04-23 20:29:47.959+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:29:47.959+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.959+0200 I/utils   ( 8242): specific action
04-23 20:29:47.959+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.959+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.959+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.959+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:29:47.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:47.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:47.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:29:47.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:47.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:29:47.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:47.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8247), cmd(0)
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 I/utils   ( 8247): specific action
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:29:47.969+0200 I/recorder( 8247): guardando datos en local
04-23 20:29:47.969+0200 W/AUL     ( 9158): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:29:47.969+0200 I/location( 9158): request sent to service es.ugr.frailty.servicemanager
04-23 20:29:47.969+0200 W/CAPI_APPFW_APP_CONTROL( 9158): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:47.969+0200 I/utils   ( 9158): specific action
04-23 20:29:47.969+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:29:47.969+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:29:47.969+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:29:48.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:118,0.040213,9.774915,0.787284
04-23 20:29:48.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:48.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:48.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:48.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:320,0.037346,9.774422,0.793523
04-23 20:29:48.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:338,0.035937,9.774369,0.794224
04-23 20:29:48.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:359,0.035975,9.774233,0.795907
04-23 20:29:48.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.369+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:379,0.037584,9.774143,0.796927
04-23 20:29:48.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.389+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:398,0.035866,9.773913,0.799817
04-23 20:29:48.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.409+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:418,0.037114,9.773682,0.802594
04-23 20:29:48.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.439+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:439,0.035714,9.773572,0.803985
04-23 20:29:48.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.449+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:459,0.036433,9.773573,0.803952
04-23 20:29:48.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:480,0.037429,9.773374,0.806320
04-23 20:29:48.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:500,0.036933,9.773326,0.806926
04-23 20:29:48.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:519,0.034550,9.773050,0.810359
04-23 20:29:48.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:538,0.034101,9.772947,0.811613
04-23 20:29:48.549+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.559+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:560,0.034104,9.772751,0.813980
04-23 20:29:48.619+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:627,0.035807,9.772857,0.812638
04-23 20:29:48.659+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.659+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:664,0.036620,9.772652,0.815062
04-23 20:29:48.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.669+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:673,0.034538,9.772495,0.817027
04-23 20:29:48.679+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:683,0.035356,9.772408,0.818028
04-23 20:29:48.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:718,0.034620,9.772380,0.818403
04-23 20:29:48.719+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:728,0.034027,9.772345,0.818842
04-23 20:29:48.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:737,0.033353,9.772207,0.820507
04-23 20:29:48.739+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:747,0.033386,9.772313,0.819242
04-23 20:29:48.799+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:29:48.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.809+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:816,0.030720,9.771929,0.823924
04-23 20:29:48.819+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:823,0.030543,9.772050,0.822488
04-23 20:29:48.819+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.829+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:828,0.030023,9.772017,0.822903
04-23 20:29:48.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.829+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:834,0.032483,9.772362,0.818707
04-23 20:29:48.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.839+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:841,0.031476,9.771273,0.831636
04-23 20:29:48.839+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.839+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:847,0.032265,9.771885,0.824380
04-23 20:29:48.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.859+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:859,0.031002,9.773287,0.807642
04-23 20:29:48.869+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.869+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:877,0.036827,9.772718,0.814246
04-23 20:29:48.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:897,0.033972,9.773896,0.800117
04-23 20:29:48.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:919,0.033814,9.773095,0.809847
04-23 20:29:48.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:937,0.034354,9.772313,0.819210
04-23 20:29:48.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:959,0.034278,9.772296,0.819412
04-23 20:29:48.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.969+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:978,0.034314,9.772289,0.819499
04-23 20:29:48.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:48.989+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:48:997,0.035473,9.772010,0.822766
04-23 20:29:49.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.009+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:17,0.036000,9.772483,0.817111
04-23 20:29:49.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.029+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:38,0.035944,9.772537,0.816460
04-23 20:29:49.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.069+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:58,0.036980,9.772606,0.815587
04-23 20:29:49.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.139+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:143,0.039371,9.773166,0.808740
04-23 20:29:49.149+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.149+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:154,0.037219,9.773275,0.807516
04-23 20:29:49.149+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:160,0.035824,9.773073,0.810022
04-23 20:29:49.159+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:164,0.034499,9.772840,0.812882
04-23 20:29:49.159+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:169,0.036417,9.772510,0.816772
04-23 20:29:49.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.169+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:177,0.035551,9.772633,0.815334
04-23 20:29:49.189+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.189+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:197,0.036164,9.772658,0.815006
04-23 20:29:49.209+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.209+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:218,0.037092,9.772730,0.814096
04-23 20:29:49.229+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.239+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:237,0.037749,9.772727,0.814103
04-23 20:29:49.249+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.249+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:258,0.038318,9.772602,0.815572
04-23 20:29:49.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.279+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:278,0.039780,9.772658,0.814829
04-23 20:29:49.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:49.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:49.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:49.299+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:306,0.039629,9.772792,0.813241
04-23 20:29:49.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:317,0.038454,9.772804,0.813139
04-23 20:29:49.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:338,0.037606,9.772638,0.815178
04-23 20:29:49.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:358,0.038701,9.772831,0.812809
04-23 20:29:49.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.369+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:377,0.036660,9.772647,0.815119
04-23 20:29:49.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.389+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:398,0.037672,9.772635,0.815215
04-23 20:29:49.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.409+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:417,0.038182,9.772582,0.815819
04-23 20:29:49.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.429+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:437,0.038947,9.772676,0.814657
04-23 20:29:49.469+0200 W/LOCATION( 9158): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:29:49.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.489+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:493,0.038302,9.772429,0.817658
04-23 20:29:49.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:499,0.039012,9.772434,0.817547
04-23 20:29:49.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:514,0.037408,9.772317,0.819031
04-23 20:29:49.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:520,0.036574,9.772195,0.820522
04-23 20:29:49.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.529+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:537,0.037137,9.772288,0.819379
04-23 20:29:49.549+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.549+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:558,0.037231,9.772397,0.818075
04-23 20:29:49.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:577,0.035477,9.772346,0.818761
04-23 20:29:49.589+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.589+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:598,0.035414,9.772332,0.818933
04-23 20:29:49.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:617,0.036502,9.772532,0.816510
04-23 20:29:49.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:637,0.034318,9.772347,0.818794
04-23 20:29:49.649+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.649+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:658,0.032497,9.772092,0.821913
04-23 20:29:49.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.669+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:677,0.033255,9.772061,0.822254
04-23 20:29:49.699+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:709,0.034334,9.772176,0.820839
04-23 20:29:49.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:738,0.034339,9.772174,0.820865
04-23 20:29:49.739+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:49.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:49:748,0.035678,9.772120,0.821461
04-23 20:29:49.749+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11091586c6f63152450818
