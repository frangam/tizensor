S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11598
Date: 2018-04-23 20:38:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf769652d, r5   = 0xf7e7ff98
r6   = 0xffa574b0, r7   = 0xffa57360
r8   = 0xf7e7cc18, r9   = 0x00000000
r10  = 0xffa5743c, fp   = 0xffa574b0
ip   = 0x00000001, sp   = 0xffa57338
lr   = 0xf7696539, pc   = 0xf76ff228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    133048 KB
Buffers:     39044 KB
Cached:     159976 KB
VmPeak:      53572 KB
VmSize:      53568 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11968 KB
VmRSS:       11968 KB
VmData:      11296 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11598 TID = 11598
11598 11601 

Maps Information
f4561000 f4d60000 rw-p [stack:11601]
f4d67000 f4d69000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d71000 f4d75000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d7e000 f4d80000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d88000 f4d8b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d9a000 f4d9f000 r-xp /usr/lib/libsystem.so.0.0.0
f4daa000 f4dad000 r-xp /lib/libattr.so.1.1.0
f4db5000 f4dc5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dcd000 f4dd6000 r-xp /usr/lib/libedbus.so.1.7.99
f4dde000 f4ddf000 r-xp /usr/lib/libresponse.so.0.2.96
f4de8000 f4ded000 r-xp /usr/lib/libproc-stat.so.0.2.96
f668f000 f6795000 r-xp /usr/lib/libicuuc.so.57.1
f67ab000 f6933000 r-xp /usr/lib/libicui18n.so.57.1
f6943000 f6950000 r-xp /usr/lib/libail.so.0.1.0
f6959000 f6960000 r-xp /usr/lib/libminizip.so.1.0.0
f6969000 f6b12000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b32000 f6b79000 r-xp /usr/lib/libssl.so.1.0.0
f6b85000 f6b87000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b8f000 f6b96000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b9f000 f6ba6000 r-xp /lib/libcrypt-2.13.so
f6bd7000 f6bda000 r-xp /lib/libcap.so.2.21
f6be2000 f6be4000 r-xp /usr/lib/libiri.so
f6bec000 f6c35000 r-xp /usr/lib/libmdm.so.1.2.69
f6c3d000 f6c43000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c4b000 f6c6e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c78000 f6c7a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c82000 f6c9f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ca8000 f6cac000 r-xp /usr/lib/libsmack.so.1.0.0
f6cb5000 f6cce000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cd7000 f6cdf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ce7000 f6ced000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cf6000 f6cf8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d01000 f6d11000 r-xp /lib/libresolv-2.13.so
f6d15000 f6d2d000 r-xp /usr/lib/liblzma.so.5.0.3
f6d36000 f6d38000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d40000 f6d5a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d62000 f6d91000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d9a000 f6da9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db3000 f6dbd000 r-xp /usr/lib/libsensord-shared.so
f6dc6000 f6e99000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ea4000 f6eba000 r-xp /lib/libz.so.1.2.5
f6ec2000 f6ec7000 r-xp /usr/lib/libffi.so.5.0.10
f6ecf000 f6ed0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ed8000 f6ee8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ef0000 f6f09000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f11000 f6f13000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f1b000 f6f90000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f9a000 f6fa0000 r-xp /lib/librt-2.13.so
f6fa9000 f6fc7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fd1000 f6fd2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fda000 f6ffd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7005000 f700a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7012000 f703c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7045000 f705c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7064000 f70cd000 r-xp /lib/libm-2.13.so
f70d6000 f716a000 r-xp /usr/lib/libstdc++.so.6.0.16
f717d000 f7182000 r-xp /usr/lib/libctx-client.so.0.8.3
f718a000 f7191000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7199000 f71c3000 r-xp /usr/lib/libsensor.so.1.9.6
f71cc000 f7298000 r-xp /usr/lib/libxml2.so.2.7.8
f72a5000 f72a7000 r-xp /usr/lib/libiniparser.so.0
f72b0000 f72b6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72bf000 f738f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7390000 f73c4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73cd000 f7409000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7411000 f7414000 r-xp /usr/lib/libbundle.so.0.1.22
f741c000 f7422000 r-xp /usr/lib/libappsvc.so.0.1.0
f742a000 f746b000 r-xp /usr/lib/libeina.so.1.7.99
f7474000 f748b000 r-xp /usr/lib/libecore.so.1.7.99
f74a2000 f74ab000 r-xp /usr/lib/libvconf.so.0.2.45
f74b3000 f74c7000 r-xp /lib/libpthread-2.13.so
f74d2000 f74df000 r-xp /usr/lib/libaul.so.0.1.0
f74e9000 f74eb000 r-xp /lib/libdl-2.13.so
f74f4000 f74ff000 r-xp /lib/libunwind.so.8.0.1
f752c000 f7534000 r-xp /lib/libgcc_s-4.6.so.1
f7535000 f7659000 r-xp /lib/libc-2.13.so
f7667000 f7669000 r-xp /usr/lib/libdlog.so.0.0.0
f7671000 f767d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7686000 f768b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7693000 f76a2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76aa000 f76ae000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76b7000 f76ba000 r-xp /usr/lib/libappcore-agent.so.1.1
f76c2000 f76c4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76cc000 f76d0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76d8000 f76f5000 r-xp /lib/ld-2.13.so
f76fe000 f7701000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7701000 f7705000 r-xp /usr/lib/libsys-assert.so
f7e4c000 f7ed9000 rw-p [heap]
ffa38000 ffa59000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11598)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76ff228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7696539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf739d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf739bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73a7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73adbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73addc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73e275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73dd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf739bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73a7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73adbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73addc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73dfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73e0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73e7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d7f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d72171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e45663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72f2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72f47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7484ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf747fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74805a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7480879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76b8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76b87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76ff53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf754c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76fef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
y: SM-R760,23/04/2018,20:37:55:14,0.035633,9.769129,0.856290
04-23 20:37:55.029+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.029+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:35,0.036487,9.769389,0.853278
04-23 20:37:55.049+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.049+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:55,0.036150,9.769322,0.854065
04-23 20:37:55.069+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.079+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:76,0.036436,9.769312,0.854163
04-23 20:37:55.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:95,0.037961,9.769440,0.852643
04-23 20:37:55.109+0200 W/AUL     (11562): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:37:55.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:37:55.109+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:37:55.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11513
04-23 20:37:55.109+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:37:55.109+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11513
04-23 20:37:55.109+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11513)
04-23 20:37:55.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:294,0.039048,9.769301,0.854171
04-23 20:37:55.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:494,0.039400,9.773258,0.807623
04-23 20:37:55.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:694,0.039220,9.773885,0.800012
04-23 20:37:55.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:55.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:55:893,0.025853,9.771985,0.823421
04-23 20:37:56.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:56.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:56:94,0.025817,9.769246,0.855302
04-23 20:37:56.169+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:37:56.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:56.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:56:294,0.031884,9.770137,0.844863
04-23 20:37:56.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:56.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:56:493,0.032683,9.771220,0.832212
04-23 20:37:56.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:56.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:56:693,0.027651,9.770218,0.844077
04-23 20:37:56.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:56.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:56:894,0.034264,9.767097,0.879215
04-23 20:37:57.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:57.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:57:93,0.044157,9.769712,0.849203
04-23 20:37:57.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:57.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:57:293,0.034868,9.767145,0.878663
04-23 20:37:57.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:57.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:57:494,0.046762,9.770702,0.837601
04-23 20:37:57.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:57.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:57:693,0.040581,9.769310,0.854004
04-23 20:37:57.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:57.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:57:893,0.051580,9.771652,0.826158
04-23 20:37:58.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:58.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:58:94,0.047941,9.771184,0.831890
04-23 20:37:58.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:58.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:58:293,0.054424,9.771895,0.823097
04-23 20:37:58.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:58.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:58:493,0.037889,9.771976,0.823057
04-23 20:37:58.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:58.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:58:693,0.034142,9.768409,0.864523
04-23 20:37:58.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:58.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:58:893,0.031961,9.767022,0.880141
04-23 20:37:59.079+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:59.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:59:93,0.031075,9.769365,0.853767
04-23 20:37:59.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:59.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:59:294,0.047495,9.773927,0.799048
04-23 20:37:59.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:59.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:59:494,0.050946,9.770725,0.837087
04-23 20:37:59.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:59.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:59:695,0.053228,9.769131,0.855361
04-23 20:37:59.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:37:59.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:37:59:895,0.049306,9.768727,0.860187
04-23 20:38:00.079+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:00.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:00:93,0.025326,9.763947,0.913831
04-23 20:38:00.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:00.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:00:294,0.047868,9.769574,0.850597
04-23 20:38:00.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:00.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:00:494,0.043019,9.767701,0.872095
04-23 20:38:00.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:00.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:00:696,0.037629,9.770220,0.843666
04-23 20:38:00.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:00.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:00:895,0.033341,9.770530,0.840247
04-23 20:38:01.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:01.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:01:96,0.031101,9.769730,0.849584
04-23 20:38:01.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:01.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:01:294,0.034501,9.771435,0.829614
04-23 20:38:01.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:01.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:01:494,0.028744,9.771342,0.830922
04-23 20:38:01.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:01.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:01:694,0.016187,9.766326,0.888255
04-23 20:38:01.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:01.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:01:894,0.033047,9.771158,0.832921
04-23 20:38:02.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:02.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:02:94,0.051700,9.773940,0.798628
04-23 20:38:02.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:02.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:02:294,0.041809,9.773036,0.810182
04-23 20:38:02.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:02.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:02:494,0.036031,9.771574,0.827901
04-23 20:38:02.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:02.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:02:694,0.036840,9.771877,0.824287
04-23 20:38:02.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:02.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:02:894,0.032971,9.769834,0.848318
04-23 20:38:03.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:03.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:03:95,0.035953,9.769833,0.848213
04-23 20:38:03.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:03.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:03:293,0.038382,9.768934,0.858388
04-23 20:38:03.399+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:38:03.399+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:38:03.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:03.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:38:03.429+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11598
04-23 20:38:03.429+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:38:03.479+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11598
04-23 20:38:03.479+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11598) type(svcapp) bg(0)
04-23 20:38:03.489+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11598]
04-23 20:38:03.499+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:03.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:03:505,0.033999,9.771548,0.828299
04-23 20:38:03.509+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11598)
04-23 20:38:03.509+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:38:03.509+0200 I/servicemanager(10115): App control destroyed.
04-23 20:38:03.509+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:38:03.519+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11598
04-23 20:38:03.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:38:03.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:38:03.539+0200 E/CAPI_APPFW_APPLICATION(11598): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:38:03.539+0200 E/CAPI_APPFW_APPLICATION(11598): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:38:03.549+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11598
04-23 20:38:03.549+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11598) was created
04-23 20:38:03.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:38:03.569+0200 W/LOCATION(11598): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:38:03.569+0200 E/LOCATION(11598): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:38:03.569+0200 E/PKGMGR_INFO(11598): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:38:03.569+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:03.589+0200 I/LOCATION(11598): location.c: location_new(269) > method: 0
04-23 20:38:03.589+0200 W/LOCATION(11598): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:03.599+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:03.599+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:03.609+0200 W/LOCATION(11598): module-internal.c: module_new(311) > module (gps) open success
04-23 20:38:03.609+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:38:03.609+0200 W/LOCATION(11598): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:38:03.609+0200 W/LOCATION(11598): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:03.609+0200 W/LOCATION(11598): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:03.609+0200 W/LOCATION(11598): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:03.629+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:38:03.639+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:38:03.639+0200 W/LOCATION(11598): module-internal.c: module_new(311) > module (wps) open success
04-23 20:38:03.639+0200 W/LOCATION(11598): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:38:03.649+0200 W/LOCATION(11598): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:38:03.649+0200 W/LOCATION(11598): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:38:03.649+0200 W/LOCATION(11598): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:38:03.659+0200 W/LOCATION(11598): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:38:03.659+0200 I/LOCATION(11598): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7e7cc18
04-23 20:38:03.659+0200 I/LOCATION(11598): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:38:03.659+0200 I/LOCATION(11598): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7e7cc18
04-23 20:38:03.659+0200 I/LOCATION(11598): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:38:03.669+0200 I/location(11598): es.ugr.frailty.location: creado servicio de localización
04-23 20:38:03.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:03.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:03:694,0.027870,9.773381,0.806617
04-23 20:38:03.709+0200 I/LOCATION(11598): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:38:03.749+0200 W/LOCATION(11598): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:03.749+0200 W/LOCATION(11598): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:03.749+0200 I/LOCATION(11598): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:38:03.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:38:03.809+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:38:03.809+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:38:03.809+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:03.809+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:03.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:38:03.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:38:03.809+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:38:03.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:38:03.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:38:03.819+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:38:03.819+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:38:03.819+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:38:03.859+0200 W/LOCATION(11598): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:38:03.859+0200 W/LOCATION(11598): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:38:03.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:03.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:03:895,0.038207,9.774766,0.789223
04-23 20:38:03.929+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:03.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c24810]
04-23 20:38:03.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:38:03.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:38:03.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:38:03.969+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:38:03.969+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:03.969+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:03.989+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:03.999+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:03.999+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:38:03.999+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:38:03.999+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:03.999+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:38:03.999+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:38:03.999+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:38:03.999+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:03.999+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:03.999+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:04.009+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:04.019+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:04.019+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:38:04.019+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:04.059+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:38:04.059+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2759320), time2(2746081)
04-23 20:38:04.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:38:04.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:38:04.059+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:38:04.059+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:38:04.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:04.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:38:04.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:04.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:38:04.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.109+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:102,0.047120,9.774204,0.795671
04-23 20:38:04.109+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.119+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:118,0.046741,9.773963,0.798648
04-23 20:38:04.119+0200 W/LOCATION(11598): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:38:04.119+0200 I/LOCATION(11598): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:38:04.119+0200 I/LOCATION(11598): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:38:04.119+0200 I/location(11598): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:38:04.129+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.129+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:135,0.044344,9.773832,0.800392
04-23 20:38:04.149+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.149+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:155,0.043212,9.773558,0.803792
04-23 20:38:04.169+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.169+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:174,0.042309,9.773572,0.803671
04-23 20:38:04.189+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.189+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:194,0.040538,9.773498,0.804668
04-23 20:38:04.209+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.209+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:215,0.041588,9.773448,0.805212
04-23 20:38:04.229+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.229+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:234,0.041792,9.773455,0.805118
04-23 20:38:04.229+0200 I/LOCATION(11598): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:38:04.249+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.249+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:255,0.043104,9.773278,0.807191
04-23 20:38:04.269+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.269+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:275,0.041069,9.772837,0.812628
04-23 20:38:04.279+0200 W/AUL     (11598): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:38:04.279+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:04.279+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11598
04-23 20:38:04.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:294,0.041243,9.773063,0.809889
04-23 20:38:04.289+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:38:04.289+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.289+0200 I/utils   (10115): specific action
04-23 20:38:04.289+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:38:04.289+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:38:04.289+0200 W/AUL     (11598): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:38:04.289+0200 I/location(11598): request sent to service es.ugr.frailty.servicemanager
04-23 20:38:04.289+0200 I/location(11598): es.ugr.frailty.location: SM-R760,23/04/2018,20:38:04:285,nan,37.171668,-3.594166,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:38:04.289+0200 W/CAPI_APPFW_APP_CONTROL(11598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.289+0200 I/utils   (11598): specific action
04-23 20:38:04.289+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.289+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.289+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.289+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:38:04.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:04.289+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:38:04.299+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:38:04.299+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:38:04.299+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:38:04.299+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.299+0200 I/utils   (10120): specific action
04-23 20:38:04.299+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.299+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.299+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.299+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:04.299+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:38:04.299+0200 I/recorder(10120): guardando datos en local
04-23 20:38:04.299+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:38:04.299+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:38:04.299+0200 I/servicemanager(10115): requesting to save local data
04-23 20:38:04.309+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.309+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:314,0.040037,9.772779,0.813372
04-23 20:38:04.329+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.329+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:335,0.039417,9.772628,0.815217
04-23 20:38:04.349+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.359+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:358,0.039610,9.772469,0.817111
04-23 20:38:04.369+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.369+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:374,0.041068,9.772240,0.819777
04-23 20:38:04.389+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.389+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:396,0.043167,9.772264,0.819384
04-23 20:38:04.409+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.409+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:415,0.044369,9.772252,0.819457
04-23 20:38:04.429+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.439+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:436,0.044568,9.772132,0.820870
04-23 20:38:04.449+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.459+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:458,0.042169,9.771962,0.823023
04-23 20:38:04.469+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.479+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:477,0.042389,9.771898,0.823761
04-23 20:38:04.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:495,0.040204,9.771606,0.827334
04-23 20:38:04.509+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.509+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:515,0.037528,9.771093,0.833492
04-23 20:38:04.529+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.539+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:537,0.037157,9.770948,0.835212
04-23 20:38:04.549+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.559+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:557,0.037520,9.770760,0.837397
04-23 20:38:04.569+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.569+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:575,0.036473,9.770613,0.839154
04-23 20:38:04.589+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.599+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:597,0.034804,9.770247,0.843467
04-23 20:38:04.609+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.609+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:616,0.036071,9.770470,0.840832
04-23 20:38:04.629+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.639+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:636,0.036986,9.770526,0.840139
04-23 20:38:04.649+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.659+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:659,0.037805,9.770429,0.841237
04-23 20:38:04.669+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.679+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:677,0.038740,9.770324,0.842416
04-23 20:38:04.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:698,0.036843,9.770499,0.840455
04-23 20:38:04.709+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.719+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:716,0.038308,9.770232,0.843488
04-23 20:38:04.729+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.739+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:738,0.037453,9.769960,0.846675
04-23 20:38:04.749+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.759+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:759,0.036645,9.769861,0.847857
04-23 20:38:04.769+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.779+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:778,0.037183,9.769711,0.849567
04-23 20:38:04.789+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.799+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:798,0.037569,9.769563,0.851240
04-23 20:38:04.809+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.819+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:818,0.036547,9.769279,0.854544
04-23 20:38:04.829+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.839+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:838,0.036587,9.769217,0.855241
04-23 20:38:04.849+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.859+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:857,0.035143,9.769423,0.852956
04-23 20:38:04.869+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.879+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:878,0.034225,9.769074,0.856971
04-23 20:38:04.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:897,0.033221,9.768838,0.859696
04-23 20:38:04.929+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.949+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:939,0.033987,9.768934,0.858574
04-23 20:38:04.949+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.959+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:955,0.035382,9.769008,0.857681
04-23 20:38:04.959+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.969+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:969,0.037180,9.769193,0.855496
04-23 20:38:04.969+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:04.989+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:04:978,0.036615,9.768981,0.857931
04-23 20:38:04.999+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.009+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:8,0.036750,9.768929,0.858523
04-23 20:38:05.009+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.019+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:17,0.037630,9.769049,0.857122
04-23 20:38:05.029+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.029+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:35,0.039025,9.769127,0.856166
04-23 20:38:05.049+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.059+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:57,0.037425,9.768970,0.858029
04-23 20:38:05.069+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:38:05.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:05.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:38:05.079+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:76,0.036807,9.768964,0.858123
04-23 20:38:05.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:95,0.035535,9.768867,0.859278
04-23 20:38:05.109+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.109+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:115,0.036014,9.768895,0.858937
04-23 20:38:05.129+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.129+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:135,0.036950,9.769157,0.855915
04-23 20:38:05.139+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:38:05.149+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.149+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:156,0.038804,9.769410,0.852935
04-23 20:38:05.169+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.169+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:178,0.037783,9.769316,0.854061
04-23 20:38:05.189+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.189+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:195,0.036708,9.769264,0.854701
04-23 20:38:05.209+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.209+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:216,0.035899,9.769175,0.855754
04-23 20:38:05.229+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.239+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:236,0.033251,9.768703,0.861233
04-23 20:38:05.249+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.259+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:257,0.032540,9.768340,0.865371
04-23 20:38:05.269+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.269+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:276,0.031511,9.767998,0.869260
04-23 20:38:05.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:298,0.032779,9.767771,0.871762
04-23 20:38:05.309+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.309+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:315,0.034262,9.768097,0.868037
04-23 20:38:05.329+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.339+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:338,0.034947,9.768357,0.865073
04-23 20:38:05.349+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.359+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:359,0.035619,9.768670,0.861509
04-23 20:38:05.369+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.389+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:378,0.034911,9.768550,0.862904
04-23 20:38:05.389+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.399+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:398,0.034918,9.768340,0.865274
04-23 20:38:05.409+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.409+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:416,0.034002,9.768062,0.868442
04-23 20:38:05.429+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.429+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:435,0.035572,9.768270,0.866046
04-23 20:38:05.449+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.459+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:456,0.034628,9.768647,0.861812
04-23 20:38:05.469+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.479+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:477,0.035467,9.768668,0.861537
04-23 20:38:05.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:496,0.035087,9.768485,0.863627
04-23 20:38:05.509+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.509+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:516,0.034688,9.768582,0.862540
04-23 20:38:05.529+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.539+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:539,0.035792,9.768751,0.860583
04-23 20:38:05.549+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.549+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:557,0.036984,9.769049,0.857154
04-23 20:38:05.569+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.569+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:576,0.036083,9.768854,0.859404
04-23 20:38:05.589+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.599+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:598,0.036790,9.769117,0.856374
04-23 20:38:05.609+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.619+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:616,0.036305,9.769208,0.855364
04-23 20:38:05.629+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.639+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:638,0.036768,9.769211,0.855313
04-23 20:38:05.649+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.659+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:658,0.036439,9.769193,0.855531
04-23 20:38:05.669+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.669+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:676,0.038020,9.769593,0.850873
04-23 20:38:05.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:696,0.037612,9.769611,0.850683
04-23 20:38:05.709+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.719+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:717,0.037826,9.769519,0.851737
04-23 20:38:05.729+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.739+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:738,0.035801,9.769069,0.856972
04-23 20:38:05.749+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.759+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:757,0.037254,9.769115,0.856375
04-23 20:38:05.769+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.779+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:779,0.037502,9.768971,0.858009
04-23 20:38:05.789+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.799+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:796,0.035795,9.768654,0.861682
04-23 20:38:05.809+0200 W/LOCATION(11598): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:38:05.819+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.829+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:828,0.037560,9.768766,0.860337
04-23 20:38:05.829+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.839+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:837,0.036781,9.768233,0.866404
04-23 20:38:05.849+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.859+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:857,0.038247,9.768739,0.860624
04-23 20:38:05.869+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.869+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:876,0.038385,9.768977,0.857897
04-23 20:38:05.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:897,0.039455,9.769350,0.853595
04-23 20:38:05.909+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.909+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:916,0.038333,9.769154,0.855896
04-23 20:38:05.929+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.929+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:936,0.037356,9.769021,0.857451
04-23 20:38:05.949+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.959+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:958,0.036974,9.768992,0.857789
04-23 20:38:05.969+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.979+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:976,0.036726,9.769044,0.857214
04-23 20:38:05.989+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:05.989+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:05:996,0.036864,9.769498,0.852019
04-23 20:38:06.009+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:06.009+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:06:16,0.039120,9.769513,0.851740
04-23 20:38:06.029+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:06.039+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:06:36,0.038553,9.769407,0.852978
04-23 20:38:06.049+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:06.069+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11115986c6f63152450868
