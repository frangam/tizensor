S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22873
Date: 2018-04-23 16:02:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f8652d, r5   = 0xf7232f98
r6   = 0xffd2bd68, r7   = 0xffd2bc18
r8   = 0xf722fc18, r9   = 0x00000000
r10  = 0xffd2bcf4, fp   = 0xffd2bd68
ip   = 0x00000001, sp   = 0xffd2aa98
lr   = 0xf6f86539, pc   = 0xf6fef2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10620 KB
Buffers:     60648 KB
Cached:     224732 KB
VmPeak:      52516 KB
VmSize:      52512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11756 KB
VmData:      10240 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22873 TID = 22873
22873 22876 

Maps Information
f3e51000 f4650000 rw-p [stack:22876]
f4657000 f4659000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4661000 f4665000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f466e000 f4670000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4678000 f467b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f468a000 f468f000 r-xp /usr/lib/libsystem.so.0.0.0
f469a000 f469d000 r-xp /lib/libattr.so.1.1.0
f46a5000 f46b5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46bd000 f46c6000 r-xp /usr/lib/libedbus.so.1.7.99
f46ce000 f46cf000 r-xp /usr/lib/libresponse.so.0.2.96
f46d8000 f46dd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f7f000 f6085000 r-xp /usr/lib/libicuuc.so.57.1
f609b000 f6223000 r-xp /usr/lib/libicui18n.so.57.1
f6233000 f6240000 r-xp /usr/lib/libail.so.0.1.0
f6249000 f6250000 r-xp /usr/lib/libminizip.so.1.0.0
f6259000 f6402000 r-xp /usr/lib/libcrypto.so.1.0.0
f6422000 f6469000 r-xp /usr/lib/libssl.so.1.0.0
f6475000 f6477000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f647f000 f6486000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f648f000 f6496000 r-xp /lib/libcrypt-2.13.so
f64c7000 f64ca000 r-xp /lib/libcap.so.2.21
f64d2000 f64d4000 r-xp /usr/lib/libiri.so
f64dc000 f6525000 r-xp /usr/lib/libmdm.so.1.2.69
f652d000 f6533000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f653b000 f655e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6568000 f656a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6572000 f658f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6598000 f659c000 r-xp /usr/lib/libsmack.so.1.0.0
f65a5000 f65be000 r-xp /usr/lib/libnetwork.so.0.0.0
f65c7000 f65cf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65d7000 f65dd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65e6000 f65e8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65f1000 f6601000 r-xp /lib/libresolv-2.13.so
f6605000 f661d000 r-xp /usr/lib/liblzma.so.5.0.3
f6626000 f6628000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6630000 f664a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6652000 f6681000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f668a000 f6699000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66a3000 f66ad000 r-xp /usr/lib/libsensord-shared.so
f66b6000 f6789000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6794000 f67aa000 r-xp /lib/libz.so.1.2.5
f67b2000 f67b7000 r-xp /usr/lib/libffi.so.5.0.10
f67bf000 f67c0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67c8000 f67d8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67e0000 f67f9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6801000 f6803000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f680b000 f6880000 r-xp /usr/lib/libsqlite3.so.0.8.6
f688a000 f6890000 r-xp /lib/librt-2.13.so
f6899000 f68b7000 r-xp /usr/lib/libsystemd.so.0.4.0
f68c1000 f68c2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68ca000 f68ed000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68f5000 f68fa000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6902000 f692c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6935000 f694c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6954000 f69bd000 r-xp /lib/libm-2.13.so
f69c6000 f6a5a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a6d000 f6a72000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a7a000 f6a81000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a89000 f6ab3000 r-xp /usr/lib/libsensor.so.1.9.6
f6abc000 f6b88000 r-xp /usr/lib/libxml2.so.2.7.8
f6b95000 f6b97000 r-xp /usr/lib/libiniparser.so.0
f6ba0000 f6ba6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6baf000 f6c7f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c80000 f6cb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cbd000 f6cf9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d01000 f6d04000 r-xp /usr/lib/libbundle.so.0.1.22
f6d0c000 f6d12000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d1a000 f6d5b000 r-xp /usr/lib/libeina.so.1.7.99
f6d64000 f6d7b000 r-xp /usr/lib/libecore.so.1.7.99
f6d92000 f6d9b000 r-xp /usr/lib/libvconf.so.0.2.45
f6da3000 f6db7000 r-xp /lib/libpthread-2.13.so
f6dc2000 f6dcf000 r-xp /usr/lib/libaul.so.0.1.0
f6dd9000 f6ddb000 r-xp /lib/libdl-2.13.so
f6de4000 f6def000 r-xp /lib/libunwind.so.8.0.1
f6e1c000 f6e24000 r-xp /lib/libgcc_s-4.6.so.1
f6e25000 f6f49000 r-xp /lib/libc-2.13.so
f6f57000 f6f59000 r-xp /usr/lib/libdlog.so.0.0.0
f6f61000 f6f6d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f76000 f6f7b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f83000 f6f92000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f9a000 f6f9e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fa7000 f6faa000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fb2000 f6fb4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fbc000 f6fc0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fc8000 f6fe5000 r-xp /lib/ld-2.13.so
f6fee000 f6ff1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6ff1000 f6ff5000 r-xp /usr/lib/libsys-assert.so
f71ff000 f728a000 rw-p [heap]
ffd0d000 ffd2e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22873)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf6fef2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf6f86539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c8d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c8bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c97e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6c9dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6c9ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cd275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ccd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c8bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c97e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6c9dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6c9ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ccfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cd0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cd48d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf6fbe0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4662171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6735663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6be2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6be47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d74ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d6fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d705a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d70879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fa8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fa87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6fef6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6e3c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf6feefa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
R760,23/04/2018,16:01:13:503,-3.706482,-6.039484,6.879365
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:507,-3.354738,-7.367501,7.448857
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:512,-3.072384,-7.992027,7.733603
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:537,-2.947958,-8.566305,7.556533
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:560,-2.787638,-7.556533,6.805188
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:622,-2.694318,-7.216753,6.675975
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/0
04-23 16:02:09.971+0200 I/httppostreq(19711): HTTP POST data service=es.ugr.frailty.accelerometer&data=SM-R760,23/04/2018,16:01:12:388,-5.412565,-10.468598,5.958128
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:12:630,-8.219346,-4.613362,7.604390
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:12:775,-9.066404,-8.532805,0.457029
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:12:970,-4.656433,-3.962514,2.227718
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:170,-11.519048,-2.770889,5.773881
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:374,-5.383851,-3.940979,5.544170
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:407,-4.476971,-6.252446,7.671390
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:427,-4.297509,-6.185446,8.087741
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:486,-4.046263,-5.242674,7.290931
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:503,-3.706482,-6.039484,6.879365
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:507,-3.354738,-7.367501,7.448857
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:512,-3.072384,-7.992027,7.733603
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:537,-2.947958,-8.566305,7.556533
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:560,-2.787638,-7.556533,6.805188
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:622,-2.694318,-7.216753,6.675975
04-23 16:02:09.971+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:632,-2.572284,-6.7669
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:34:647,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:34:848,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:48,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:248,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:448,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:650,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:850,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:55,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:255,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:449,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:649,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:849,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:49,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:249,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:449,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:650,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:850,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:50,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:250,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:466,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:675,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:850,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:75,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:252,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:452,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:651,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:851,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:51,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:255,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:453,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:654,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:852,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:41:52,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:41:252,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:41:452,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:41:652,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:41:853,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:42:52,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:42:253,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:42:454,70
04-23 16:02:09.981+0200 I/recorder(22624): obteniendo datos locales es.ugr.frailty.heartrate
04-23 16:02:09.981+0200 I/recorder(22624): obteniendo datos locales, DATA: SM-R760,23/04/2018,16:01:34:647,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:34:848,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:48,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:248,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:448,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:650,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:35:850,68
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:55,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:255,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:449,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:649,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:849,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:49,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:249,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:449,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:650,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:37:850,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:50,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:250,70
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:466,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:675,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:850,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:75,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:252,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:452,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:651,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:39:851,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:51,69
04-23 16:02:09.981+0200 I/recorder(22624): SM-R760,23/04/201
04-23 16:02:09.981+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:09.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:09.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22624
04-23 16:02:09.981+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:09.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:09.991+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:09.991+0200 I/recorder(22624): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:09.991+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:11:183,751.078998,37.171459,-3.593218,0.000000,0,0.412171,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:13:932,751.033223,37.171459,-3.593235,0.000000,0,0.003224,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:15:816,750.976958,37.171468,-3.593228,0.000000,0,0.508147,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:19:747,750.899950,37.171471,-3.593238,0.000000,0,0.431851,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:24:311,750.899950,37.171471,-3.593238,0.000000,0,0.431851,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:28:622,750.702947,37.171499,-3.593219,0.000000,215.876,0.032866,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:32:314,750.702947,37.171499,-3.593219,0.000000,215.876,0.032866,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:65,750.684748,37.171483,-3.593228,0.000000,215.876,0.839587,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:272,750.684748,37.171483,-3.593228,0.000000,215.876,0.839587,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:261,750.738910,37.171479,-3.593240,0.000000,197.813,0.319164,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:42:471,750.781819,37.171537,-3.593208,0.000000,225.565,1.270417,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:44:721,751.077799,37.171550,-3.593194,0.000000,227.513,1.301637,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:49:13,751.077799,37.171550,-3.593194,0.000000,227.513,1.301637,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:53:283,751.077799,37.171550,-3.593194,0.000000,227.513,1.301637,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:57:15,751.356346,37.171572,-3.593207,0.000000,246.604,0.055941,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:59:157,751.356346,37.171572,-3.593207,0.000000,246.604,0.055941,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:02:01:220,751.061908,37.171586,-3.593222,0.000000,356.695,1.332726,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:02:03:434,751.061908,37.171586,-3.593222,0.000000,356.695,1.332726,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:02:05:486,750.397064,37.171607,-3.593210,0.000000,22.1722,0.272636,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:02:07:658,750.374147,37.171608,-3.593209,0.000000,22.1722,0.002956,32.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): obteniendo datos locales es.ugr.frailty.location
04-23 16:02:09.991+0200 I/recorder(22624): obteniendo datos locales, DATA: SM-R760,23/04/2018,16:01:11:183,751.078998,37.171459,-3.593218,0.000000,0,0.412171,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:13:932,751.033223,37.171459,-3.593235,0.000000,0,0.003224,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:15:816,750.976958,37.171468,-3.593228,0.000000,0,0.508147,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:19:747,750.899950,37.171471,-3.593238,0.000000,0,0.431851,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:24:311,750.899950,37.171471,-3.593238,0.000000,0,0.431851,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:28:622,750.702947,37.171499,-3.593219,0.000000,215.876,0.032866,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:32:314,750.702947,37.171499,-3.593219,0.000000,215.876,0.032866,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:36:65,750.684748,37.171483,-3.593228,0.000000,215.876,0.839587,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:38:272,750.684748,37.171483,-3.593228,0.000000,215.876,0.839587,16.000000,-1.000000
04-23 16:02:09.991+0200 I/recorder(22624): SM-R760,23/04/2018,16:01:40:261,750.73891
04-23 16:02:09.991+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.001+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:10.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22624
04-23 16:02:10.001+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19711)
04-23 16:02:10.011+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.httppostreq
04-23 16:02:10.011+0200 I/servicemanager(19708): obteniendo datos locales. Datos recibidos
04-23 16:02:10.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.011+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:10.011+0200 I/recorder(22624): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:10.021+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:10.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22917
04-23 16:02:10.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:10.051+0200 I/utils   (19708): specific action
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.051+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 16:02:10.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.051+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:10.051+0200 I/gyroscope(22902): es.ugr.frailty.gyroscope listener destroyed
04-23 16:02:10.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19711
04-23 16:02:10.061+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19711)
04-23 16:02:10.061+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.httppostreq
04-23 16:02:10.061+0200 I/servicemanager(19708): obteniendo datos locales. Datos recibidos
04-23 16:02:10.061+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 I/utils   (19708): specific action
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.061+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 16:02:10.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.061+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:10.071+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:10.071+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19711
04-23 16:02:10.071+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19711)
04-23 16:02:10.071+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.httppostreq
04-23 16:02:10.071+0200 I/servicemanager(19708): obteniendo datos locales. Datos recibidos
04-23 16:02:10.071+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.071+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.081+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 I/utils   (19708): specific action
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 16:02:10.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.091+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:10.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19711
04-23 16:02:10.101+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19711)
04-23 16:02:10.101+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.httppostreq
04-23 16:02:10.101+0200 I/servicemanager(19708): obteniendo datos locales. Datos recibidos
04-23 16:02:10.111+0200 I/heartrate(22917): es.ugr.frailty.heartrate listener destroyed
04-23 16:02:10.181+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:10.191+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:10.211+0200 I/accelerometer(22898): es.ugr.frailty.accelerometer listener destroyed
04-23 16:02:10.211+0200 W/AUL     (22942): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:02:10.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:10.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:10.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22902
04-23 16:02:10.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:10.221+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22902
04-23 16:02:10.221+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22902)
04-23 16:02:10.241+0200 W/AUL     (22943): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:02:10.251+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22917
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19711
04-23 16:02:10.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.261+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22917
04-23 16:02:10.261+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22917)
04-23 16:02:10.261+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:10.261+0200 I/httppostreq(19711): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:10.261+0200 I/httppostreq(19711): requesting HTTP POST Request Service
04-23 16:02:10.261+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19711), cmd(0)
04-23 16:02:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.261+0200 I/utils   (19711): specific action
04-23 16:02:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.261+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.261+0200 I/httppostreq(19711): requesting HTTP POST Request Service. Service ID: es.ugr.frailty.gyroscope Data received: SM-R760,23/04/2018,16:01:12:767,115.779999,-104.300003,-135.240005
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:12:966,147.350006,-25.549999,-165.550003
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:166,98.419998,42.910000,-46.900002
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:369,-104.790001,-28.840000,17.290001
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:406,-82.250000,-32.480000,13.790000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:427,-58.310001,-20.370001,9.940000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:452,-69.019997,-10.780000,4.690000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:470,-96.040001,-11.900000,-7.630000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:491,-114.940002,-19.740000,-13.580000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:515,-108.080002,-21.280001,-22.540001
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:526,-80.709999,-17.500000,-33.529999
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:552,-40.599998,-15.050000,-47.180000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:599,-32.900002,-17.990000,-53.340000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:625,-16.520000,-24.010000,-57.750000
04-23 16:02:10.261+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:1
04-23 16:02:10.271+0200 I/httppostreq(19711): HTTP POST data service=es.ugr.frailty.gyroscope&data=SM-R760,23/04/2018,16:01:12:767,115.779999,-104.300003,-135.240005
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:12:966,147.350006,-25.549999,-165.550003
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:166,98.419998,42.910000,-46.900002
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:369,-104.790001,-28.840000,17.290001
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:406,-82.250000,-32.480000,13.790000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:427,-58.310001,-20.370001,9.940000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:452,-69.019997,-10.780000,4.690000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:470,-96.040001,-11.900000,-7.630000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:491,-114.940002,-19.740000,-13.580000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:515,-108.080002,-21.280001,-22.540001
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:526,-80.709999,-17.500000,-33.529999
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:552,-40.599998,-15.050000,-47.180000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:599,-32.900002,-17.990000,-53.340000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:625,-16.520000,-24.010000,-57.750000
04-23 16:02:10.271+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:13:634,0.280000,-17.360001,-61.320000
04-23 16:02:10.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 I/utils   (19708): specific action
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:10.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:10.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:10.281+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(22624), cmd(0)
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 I/utils   (22624): specific action
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.281+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:02:10.281+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.281+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22624
04-23 16:02:10.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.301+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:10.301+0200 I/recorder(22624): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:10.301+0200 I/recorder(22624): eliminando datos en local
04-23 16:02:10.301+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:10.301+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:10.301+0200 I/servicemanager(19708): eliminar datos locales
04-23 16:02:10.301+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 I/utils   (19708): specific action
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.301+0200 I/servicemanager(19708): launch es.ugr.frailty.accelerometer
04-23 16:02:10.301+0200 I/servicemanager(19708): re launch service
04-23 16:02:10.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:02:10.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 16:02:10.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:02:10.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:02:10.401+0200 I/LOCATION(22893): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:10.401+0200 W/AUL     (22944): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:02:10.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:10.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:10.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22898
04-23 16:02:10.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:10.411+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22898
04-23 16:02:10.411+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22898)
04-23 16:02:10.461+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19711
04-23 16:02:10.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 16:02:10.481+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:10.481+0200 I/httppostreq(19711): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:10.481+0200 I/httppostreq(19711): requesting HTTP POST Request Service
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(19711), cmd(0)
04-23 16:02:10.481+0200 I/utils   (19711): specific action
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19711): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 I/utils   (19708): specific action
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 I/httppostreq(19711): requesting HTTP POST Request Service. Service ID: es.ugr.frailty.heartrate Data received: SM-R760,23/04/2018,16:01:34:647,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:34:848,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:48,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:248,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:448,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:650,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:850,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:55,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:255,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:449,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:649,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:849,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:49,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:249,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:449,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:650,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:850,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:50,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:250,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:466,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:675,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:850,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:75,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:252,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:452,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:651,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:
04-23 16:02:10.481+0200 I/httppostreq(19711): HTTP POST data service=es.ugr.frailty.heartrate&data=SM-R760,23/04/2018,16:01:34:647,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:34:848,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:48,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:248,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:448,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:650,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:35:850,68
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:55,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:255,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:449,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:649,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:36:849,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:49,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:249,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:449,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:650,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:37:850,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:50,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:250,70
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:466,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:675,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:38:850,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:75,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:252,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:452,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:651,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:39:851,69
04-23 16:02:10.481+0200 I/httppostreq(19711): SM-R760,23/04/2018,16:01:40:51
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:10.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:10.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:10.501+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:10.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(22624), cmd(0)
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 I/utils   (22624): specific action
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:10.501+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:02:10.501+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.511+0200 W/AUL     (19711): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:10.511+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22624
04-23 16:02:10.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:10.521+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:10.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:10.521+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:02:10.521+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:02:10.521+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:10.531+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19711
04-23 16:02:10.541+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:10.541+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:10.541+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11228736c6f63152449212
