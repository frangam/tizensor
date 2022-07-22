S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11673
Date: 2018-04-23 20:38:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71b452d, r5   = 0xf753ff98
r6   = 0xffe95450, r7   = 0xffe95300
r8   = 0xf753cc18, r9   = 0x00000000
r10  = 0xffe953dc, fp   = 0xffe95450
ip   = 0x00000001, sp   = 0xffe952d8
lr   = 0xf71b4539, pc   = 0xf721d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    128012 KB
Buffers:     39156 KB
Cached:     160188 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11560 KB
VmRSS:       11560 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11673 TID = 11673
11673 11676 

Maps Information
f407f000 f487e000 rw-p [stack:11676]
f4885000 f4887000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f488f000 f4893000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f489c000 f489e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48a6000 f48a9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48b8000 f48bd000 r-xp /usr/lib/libsystem.so.0.0.0
f48c8000 f48cb000 r-xp /lib/libattr.so.1.1.0
f48d3000 f48e3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48eb000 f48f4000 r-xp /usr/lib/libedbus.so.1.7.99
f48fc000 f48fd000 r-xp /usr/lib/libresponse.so.0.2.96
f4906000 f490b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61ad000 f62b3000 r-xp /usr/lib/libicuuc.so.57.1
f62c9000 f6451000 r-xp /usr/lib/libicui18n.so.57.1
f6461000 f646e000 r-xp /usr/lib/libail.so.0.1.0
f6477000 f647e000 r-xp /usr/lib/libminizip.so.1.0.0
f6487000 f6630000 r-xp /usr/lib/libcrypto.so.1.0.0
f6650000 f6697000 r-xp /usr/lib/libssl.so.1.0.0
f66a3000 f66a5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66ad000 f66b4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66bd000 f66c4000 r-xp /lib/libcrypt-2.13.so
f66f5000 f66f8000 r-xp /lib/libcap.so.2.21
f6700000 f6702000 r-xp /usr/lib/libiri.so
f670a000 f6753000 r-xp /usr/lib/libmdm.so.1.2.69
f675b000 f6761000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6769000 f678c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6796000 f6798000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67a0000 f67bd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67c6000 f67ca000 r-xp /usr/lib/libsmack.so.1.0.0
f67d3000 f67ec000 r-xp /usr/lib/libnetwork.so.0.0.0
f67f5000 f67fd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6805000 f680b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6814000 f6816000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f681f000 f682f000 r-xp /lib/libresolv-2.13.so
f6833000 f684b000 r-xp /usr/lib/liblzma.so.5.0.3
f6854000 f6856000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f685e000 f6878000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6880000 f68af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68b8000 f68c7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68d1000 f68db000 r-xp /usr/lib/libsensord-shared.so
f68e4000 f69b7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69c2000 f69d8000 r-xp /lib/libz.so.1.2.5
f69e0000 f69e5000 r-xp /usr/lib/libffi.so.5.0.10
f69ed000 f69ee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69f6000 f6a06000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a0e000 f6a27000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a2f000 f6a31000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a39000 f6aae000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ab8000 f6abe000 r-xp /lib/librt-2.13.so
f6ac7000 f6ae5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aef000 f6af0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af8000 f6b1b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b23000 f6b28000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b30000 f6b5a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b63000 f6b7a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b82000 f6beb000 r-xp /lib/libm-2.13.so
f6bf4000 f6c88000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c9b000 f6ca0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ca8000 f6caf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cb7000 f6ce1000 r-xp /usr/lib/libsensor.so.1.9.6
f6cea000 f6db6000 r-xp /usr/lib/libxml2.so.2.7.8
f6dc3000 f6dc5000 r-xp /usr/lib/libiniparser.so.0
f6dce000 f6dd4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddd000 f6ead000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eae000 f6ee2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6eeb000 f6f27000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f2f000 f6f32000 r-xp /usr/lib/libbundle.so.0.1.22
f6f3a000 f6f40000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f48000 f6f89000 r-xp /usr/lib/libeina.so.1.7.99
f6f92000 f6fa9000 r-xp /usr/lib/libecore.so.1.7.99
f6fc0000 f6fc9000 r-xp /usr/lib/libvconf.so.0.2.45
f6fd1000 f6fe5000 r-xp /lib/libpthread-2.13.so
f6ff0000 f6ffd000 r-xp /usr/lib/libaul.so.0.1.0
f7007000 f7009000 r-xp /lib/libdl-2.13.so
f7012000 f701d000 r-xp /lib/libunwind.so.8.0.1
f704a000 f7052000 r-xp /lib/libgcc_s-4.6.so.1
f7053000 f7177000 r-xp /lib/libc-2.13.so
f7185000 f7187000 r-xp /usr/lib/libdlog.so.0.0.0
f718f000 f719b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71a4000 f71a9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71b1000 f71c0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71c8000 f71cc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71d5000 f71d8000 r-xp /usr/lib/libappcore-agent.so.1.1
f71e0000 f71e2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71ea000 f71ee000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71f6000 f7213000 r-xp /lib/ld-2.13.so
f721c000 f721f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f721f000 f7223000 r-xp /usr/lib/libsys-assert.so
f750c000 f757c000 rw-p [heap]
ffe76000 ffe97000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11673)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf721d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71b4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ebb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eb9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ec5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ecbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ecbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f0075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6efb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eb9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ec5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ecbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ecbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6efde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6efe017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f05f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf489d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4890171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6963663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e10fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e127a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fa2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f9db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f9e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f9e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71d6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71d67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf721d53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf706a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf721cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ty.gravity: SM-R760,23/04/2018,20:38:08:298,0.030727,9.770607,0.839454
04-23 20:38:08.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:08.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:08:498,0.028131,9.773517,0.804963
04-23 20:38:08.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:08.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:08:697,0.020847,9.774889,0.788350
04-23 20:38:08.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:08.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:08:898,0.016726,9.777423,0.756379
04-23 20:38:09.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:09.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:09:97,0.020317,9.777222,0.758888
04-23 20:38:09.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:09.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:09:297,0.030322,9.773775,0.801741
04-23 20:38:09.399+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:38:09.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:09.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:09:498,0.019524,9.772311,0.819712
04-23 20:38:09.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:09.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:09:697,0.028356,9.772238,0.820330
04-23 20:38:09.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:09.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:09:897,0.032592,9.773265,0.807845
04-23 20:38:10.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:10.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:10:97,0.041095,9.774635,0.790700
04-23 20:38:10.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:10.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:10:297,0.049814,9.773751,0.801053
04-23 20:38:10.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:10.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:10:497,0.045362,9.773554,0.803721
04-23 20:38:10.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:10.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:10:698,0.033074,9.772188,0.820749
04-23 20:38:10.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:10.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:10:897,0.033696,9.770495,0.840640
04-23 20:38:11.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:11.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:11:97,0.038790,9.768732,0.860673
04-23 20:38:11.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:11.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:11:297,0.053465,9.769479,0.851357
04-23 20:38:11.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:11.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:11:497,0.055857,9.771133,0.831992
04-23 20:38:11.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:11.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:11:697,0.064004,9.773453,0.803679
04-23 20:38:11.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:11.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:11:897,0.045045,9.773303,0.806786
04-23 20:38:12.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:12.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:12:97,0.044003,9.772828,0.812578
04-23 20:38:12.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:12.289+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:12:297,0.029957,9.770000,0.846509
04-23 20:38:12.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:12.489+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:12:497,0.044877,9.772032,0.822055
04-23 20:38:12.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:12.689+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:12:696,0.039001,9.771512,0.828499
04-23 20:38:12.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:12.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:12:897,0.040604,9.772215,0.820097
04-23 20:38:13.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:13.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:13:95,0.032950,9.771441,0.829598
04-23 20:38:13.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:13.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:13:297,0.027644,9.772148,0.821429
04-23 20:38:13.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:13.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:13:497,0.035937,9.772470,0.817260
04-23 20:38:13.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:13.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:13:698,0.040401,9.766679,0.883590
04-23 20:38:13.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:13.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:13:897,0.053646,9.767674,0.871799
04-23 20:38:14.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:14.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:14:98,0.040768,9.768089,0.867842
04-23 20:38:14.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:14.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:14:303,0.029925,9.766763,0.883087
04-23 20:38:14.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:14.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:14:498,0.039131,9.773513,0.804545
04-23 20:38:14.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:14.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:14:700,0.035796,9.775727,0.777341
04-23 20:38:14.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:14.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:14:897,0.032036,9.777743,0.751724
04-23 20:38:15.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:15.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:15:98,0.027928,9.776457,0.768437
04-23 20:38:15.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:15.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:15:297,0.037119,9.774154,0.796827
04-23 20:38:15.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:15.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:15:498,0.035300,9.773485,0.805060
04-23 20:38:15.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:15.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:15:699,0.036499,9.773623,0.803334
04-23 20:38:15.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:15.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:15:899,0.042886,9.772501,0.816560
04-23 20:38:16.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:16.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:16:100,0.047836,9.772006,0.822188
04-23 20:38:16.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:16.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:16:298,0.045617,9.771427,0.829169
04-23 20:38:16.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:16.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:16:501,0.044126,9.770745,0.837239
04-23 20:38:16.579+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:38:16.579+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:38:16.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:16.579+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:38:16.599+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:38:16.609+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 11673
04-23 20:38:16.659+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11673
04-23 20:38:16.659+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(11673) type(svcapp) bg(0)
04-23 20:38:16.669+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11673]
04-23 20:38:16.689+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:38:16.709+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11673
04-23 20:38:16.709+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:16.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:38:16.709+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11673)
04-23 20:38:16.709+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:38:16.709+0200 I/servicemanager(10115): App control destroyed.
04-23 20:38:16.709+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:16:717,0.046333,9.771449,0.828867
04-23 20:38:16.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:38:16.729+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11673
04-23 20:38:16.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:38:16.749+0200 E/CAPI_APPFW_APPLICATION(11673): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:38:16.749+0200 E/CAPI_APPFW_APPLICATION(11673): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:38:16.749+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (11673) was created
04-23 20:38:16.769+0200 W/LOCATION(11673): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:38:16.769+0200 E/LOCATION(11673): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:38:16.769+0200 E/PKGMGR_INFO(11673): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:38:16.779+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:16.799+0200 I/LOCATION(11673): location.c: location_new(269) > method: 0
04-23 20:38:16.799+0200 W/LOCATION(11673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:16.799+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:16.809+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:16.809+0200 W/LOCATION(11673): module-internal.c: module_new(311) > module (gps) open success
04-23 20:38:16.809+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:38:16.819+0200 W/LOCATION(11673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:38:16.819+0200 W/LOCATION(11673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:16.819+0200 W/LOCATION(11673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:16.819+0200 W/LOCATION(11673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:16.839+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:38:16.839+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:38:16.839+0200 W/LOCATION(11673): module-internal.c: module_new(311) > module (wps) open success
04-23 20:38:16.849+0200 W/LOCATION(11673): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:38:16.849+0200 W/LOCATION(11673): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:38:16.849+0200 W/LOCATION(11673): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:38:16.849+0200 W/LOCATION(11673): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:38:16.859+0200 W/LOCATION(11673): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:38:16.869+0200 I/LOCATION(11673): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf753cc18
04-23 20:38:16.869+0200 I/LOCATION(11673): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:38:16.869+0200 I/LOCATION(11673): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf753cc18
04-23 20:38:16.869+0200 I/LOCATION(11673): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:38:16.869+0200 I/location(11673): es.ugr.frailty.location: creado servicio de localización
04-23 20:38:16.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:16.889+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:16:899,0.039051,9.771041,0.834043
04-23 20:38:16.909+0200 I/LOCATION(11673): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:38:16.949+0200 W/LOCATION(11673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:16.949+0200 W/LOCATION(11673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:16.949+0200 I/LOCATION(11673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:38:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:38:17.009+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:38:17.009+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:38:17.009+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:38:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:38:17.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:38:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:38:17.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:38:17.009+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:38:17.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:38:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:38:17.059+0200 W/LOCATION(11673): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:38:17.059+0200 W/LOCATION(11673): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:38:17.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:38:17.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:17.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:38:17.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:99,0.040470,9.772480,0.816930
04-23 20:38:17.109+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.119+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:119,0.039474,9.772449,0.817362
04-23 20:38:17.129+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.139+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:139,0.038919,9.772126,0.821227
04-23 20:38:17.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:17.149+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.159+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:162,0.039485,9.771975,0.823007
04-23 20:38:17.169+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.179+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:179,0.040388,9.771708,0.826122
04-23 20:38:17.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72e22c8]
04-23 20:38:17.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:38:17.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:38:17.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:38:17.189+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:38:17.189+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.189+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:17.189+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:198,0.041481,9.771626,0.827027
04-23 20:38:17.199+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:17.199+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:17.209+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.209+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:17.209+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:38:17.209+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:38:17.209+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:38:17.209+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:38:17.209+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:38:17.209+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:38:17.209+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:38:17.209+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:38:17.209+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:38:17.219+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:219,0.042762,9.771745,0.825563
04-23 20:38:17.219+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:17.229+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:38:17.229+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:38:17.229+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:17.239+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:240,0.042468,9.771989,0.822690
04-23 20:38:17.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:38:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2772514), time2(2759320)
04-23 20:38:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:38:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:38:17.249+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:38:17.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:38:17.249+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.259+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:260,0.041498,9.771849,0.824400
04-23 20:38:17.269+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.279+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:279,0.042310,9.771721,0.825875
04-23 20:38:17.289+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:38:17.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:299,0.043044,9.771744,0.825564
04-23 20:38:17.309+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.309+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:318,0.042158,9.771748,0.825568
04-23 20:38:17.319+0200 W/LOCATION(11673): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:38:17.319+0200 I/LOCATION(11673): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:38:17.319+0200 I/LOCATION(11673): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:38:17.319+0200 I/location(11673): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:38:17.329+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.339+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:339,0.039073,9.771318,0.830779
04-23 20:38:17.349+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.359+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:361,0.038283,9.771111,0.833241
04-23 20:38:17.369+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.379+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:379,0.038087,9.771086,0.833555
04-23 20:38:17.389+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.399+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:399,0.040051,9.771162,0.832570
04-23 20:38:17.409+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.419+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:420,0.040257,9.771126,0.832980
04-23 20:38:17.429+0200 I/LOCATION(11673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:38:17.429+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.439+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:439,0.039524,9.770957,0.834995
04-23 20:38:17.449+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.459+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:460,0.040510,9.771011,0.834317
04-23 20:38:17.469+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.479+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:480,0.040435,9.770996,0.834501
04-23 20:38:17.479+0200 W/AUL     (11673): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:38:17.479+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:17.479+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 11673
04-23 20:38:17.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:38:17.489+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:38:17.489+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:38:17.489+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.489+0200 I/utils   (10115): specific action
04-23 20:38:17.489+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.489+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.489+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.489+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:38:17.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:38:17.499+0200 W/AUL     (11673): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:38:17.499+0200 I/location(11673): request sent to service es.ugr.frailty.servicemanager
04-23 20:38:17.499+0200 I/location(11673): es.ugr.frailty.location: SM-R760,23/04/2018,20:38:17:487,nan,37.171667,-3.594158,0.000000,0,0.000000,43.000000,-1.000000
04-23 20:38:17.499+0200 W/CAPI_APPFW_APP_CONTROL(11673): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.499+0200 I/utils   (11673): specific action
04-23 20:38:17.499+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:38:17.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:499,0.039722,9.770734,0.837600
04-23 20:38:17.499+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:38:17.509+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.509+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:38:17.509+0200 I/utils   (10120): specific action
04-23 20:38:17.509+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.509+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:38:17.509+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.509+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:38:17.509+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:38:17.509+0200 I/servicemanager(10115): requesting to save local data
04-23 20:38:17.509+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.509+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:38:17.509+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:38:17.509+0200 I/recorder(10120): guardando datos en local
04-23 20:38:17.509+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.509+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:519,0.037573,9.770302,0.842714
04-23 20:38:17.529+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.539+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:541,0.037066,9.770327,0.842452
04-23 20:38:17.549+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.559+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:561,0.037734,9.770072,0.845367
04-23 20:38:17.569+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.579+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:579,0.037566,9.770077,0.845323
04-23 20:38:17.589+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.599+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:601,0.037180,9.769893,0.847463
04-23 20:38:17.609+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.619+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:621,0.036372,9.769809,0.848470
04-23 20:38:17.629+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.639+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:640,0.035919,9.769997,0.846320
04-23 20:38:17.649+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.659+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:662,0.036451,9.770108,0.845009
04-23 20:38:17.669+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.679+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:679,0.038044,9.770383,0.841754
04-23 20:38:17.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:701,0.038991,9.770391,0.841628
04-23 20:38:17.709+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.719+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:721,0.040261,9.770171,0.844107
04-23 20:38:17.729+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.739+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:742,0.038732,9.769913,0.847163
04-23 20:38:17.749+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.759+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:761,0.038399,9.769879,0.847565
04-23 20:38:17.769+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.779+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:780,0.037782,9.769608,0.850714
04-23 20:38:17.789+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.799+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:799,0.037760,9.769650,0.850243
04-23 20:38:17.809+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.819+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:819,0.035675,9.769244,0.854974
04-23 20:38:17.829+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.839+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:841,0.036974,9.769566,0.851235
04-23 20:38:17.849+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.859+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:861,0.037311,9.769125,0.856265
04-23 20:38:17.869+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.879+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:879,0.036020,9.768889,0.858999
04-23 20:38:17.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:901,0.035585,9.768883,0.859097
04-23 20:38:17.909+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.919+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:920,0.035395,9.768948,0.858364
04-23 20:38:17.929+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.939+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:941,0.035446,9.768896,0.858956
04-23 20:38:17.949+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.959+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:961,0.035952,9.769000,0.857745
04-23 20:38:17.969+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.979+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:17:980,0.036775,9.769242,0.854952
04-23 20:38:17.989+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:17.999+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:1,0.038379,9.769709,0.849537
04-23 20:38:18.009+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.019+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:20,0.039015,9.769798,0.848477
04-23 20:38:18.029+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.039+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:41,0.037786,9.769576,0.851087
04-23 20:38:18.049+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.059+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:61,0.035884,9.769432,0.852819
04-23 20:38:18.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:38:18.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:18.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:38:18.079+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.089+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:89,0.035116,9.769354,0.853737
04-23 20:38:18.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:101,0.035183,9.769465,0.852465
04-23 20:38:18.109+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.119+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:120,0.035839,9.769335,0.853933
04-23 20:38:18.129+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.139+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:141,0.036786,9.769631,0.850492
04-23 20:38:18.149+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.169+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:163,0.035055,9.769472,0.852385
04-23 20:38:18.169+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.179+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:179,0.033983,9.769382,0.853477
04-23 20:38:18.189+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.199+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:200,0.032861,9.769166,0.855981
04-23 20:38:18.209+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.229+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:219,0.031225,9.768865,0.859469
04-23 20:38:18.229+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.239+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:242,0.033219,9.769574,0.851298
04-23 20:38:18.249+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.259+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:262,0.033822,9.769706,0.849756
04-23 20:38:18.269+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.279+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:279,0.032580,9.769582,0.851229
04-23 20:38:18.289+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:38:18.289+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.299+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:299,0.030761,9.769051,0.857372
04-23 20:38:18.309+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.319+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:320,0.032042,9.769101,0.856753
04-23 20:38:18.329+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.339+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:340,0.031914,9.769033,0.857529
04-23 20:38:18.349+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.359+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:361,0.032358,9.769092,0.856846
04-23 20:38:18.369+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.379+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:380,0.031913,9.769390,0.853456
04-23 20:38:18.389+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.399+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:400,0.031486,9.769714,0.849749
04-23 20:38:18.409+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.419+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:420,0.030744,9.769932,0.847274
04-23 20:38:18.429+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.439+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:440,0.032211,9.770570,0.839831
04-23 20:38:18.449+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.459+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:460,0.032335,9.770823,0.836869
04-23 20:38:18.469+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.479+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:480,0.032115,9.771176,0.832741
04-23 20:38:18.489+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.499+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:501,0.030871,9.771408,0.830075
04-23 20:38:18.509+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.519+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:519,0.029940,9.771507,0.828940
04-23 20:38:18.529+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.539+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:541,0.029097,9.771442,0.829730
04-23 20:38:18.549+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.559+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:560,0.027236,9.771511,0.828987
04-23 20:38:18.569+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.579+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:579,0.027687,9.771557,0.828425
04-23 20:38:18.589+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.599+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:599,0.029389,9.771852,0.824871
04-23 20:38:18.609+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.619+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:620,0.028735,9.772128,0.821628
04-23 20:38:18.629+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.639+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:639,0.029585,9.771595,0.827917
04-23 20:38:18.649+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.659+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:660,0.030066,9.771414,0.830029
04-23 20:38:18.669+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.679+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:679,0.032084,9.771558,0.828264
04-23 20:38:18.689+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.699+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:699,0.032987,9.771740,0.826075
04-23 20:38:18.709+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.719+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:720,0.033401,9.771950,0.823568
04-23 20:38:18.729+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.739+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:741,0.034474,9.771598,0.827686
04-23 20:38:18.749+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.759+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:760,0.034034,9.771742,0.826008
04-23 20:38:18.769+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.779+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:781,0.034641,9.771936,0.823680
04-23 20:38:18.789+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.799+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:800,0.035597,9.772440,0.817642
04-23 20:38:18.809+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.819+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:819,0.035928,9.772810,0.813192
04-23 20:38:18.829+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.839+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:839,0.035272,9.772610,0.815625
04-23 20:38:18.849+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.859+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:861,0.036243,9.772509,0.816792
04-23 20:38:18.869+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.879+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:880,0.037709,9.772244,0.819875
04-23 20:38:18.889+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.899+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:899,0.036521,9.772064,0.822075
04-23 20:38:18.909+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.919+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:920,0.035242,9.772069,0.822077
04-23 20:38:18.929+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.939+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:941,0.036095,9.772026,0.822544
04-23 20:38:18.949+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.959+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:961,0.039075,9.772020,0.822480
04-23 20:38:18.969+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.979+0200 W/LOCATION(11673): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:38:18.979+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:980,0.038401,9.771664,0.826741
04-23 20:38:18.989+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:18.999+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:18:999,0.038311,9.771580,0.827730
04-23 20:38:19.009+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.029+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:19,0.035719,9.771379,0.830219
04-23 20:38:19.029+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.039+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:42,0.036087,9.771129,0.833143
04-23 20:38:19.049+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.059+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:60,0.036562,9.771131,0.833101
04-23 20:38:19.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:38:19.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:38:19.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:38:19.069+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.079+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:79,0.037374,9.771418,0.829687
04-23 20:38:19.089+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.099+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:99,0.038830,9.771559,0.827962
04-23 20:38:19.109+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.119+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:119,0.039770,9.771778,0.825321
04-23 20:38:19.129+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.139+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:138,0.039723,9.771788,0.825214
04-23 20:38:19.149+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.159+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:160,0.039902,9.771574,0.827732
04-23 20:38:19.169+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.169+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:178,0.040418,9.771425,0.829456
04-23 20:38:19.189+0200 I/gravity (11522): capturing data from es.ugr.frailty.gravity
04-23 20:38:19.199+0200 I/gravity (11522): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:38:19:200,0.038404,9.771283,0.831227
04-23 20:38:19.219+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11116736c6f63152450869
