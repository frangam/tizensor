S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9751
Date: 2018-04-23 20:31:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf713e52d, r5   = 0xf7377f98
r6   = 0xff927e90, r7   = 0xff927d40
r8   = 0xf7374c18, r9   = 0x00000000
r10  = 0xff927e1c, fp   = 0xff927e90
ip   = 0x00000001, sp   = 0xff927d18
lr   = 0xf713e539, pc   = 0xf71a7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    139668 KB
Buffers:     35680 KB
Cached:     154500 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11928 KB
VmRSS:       11924 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9751 TID = 9751
9751 9754 

Maps Information
f4009000 f4808000 rw-p [stack:9754]
f480f000 f4811000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4819000 f481d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4826000 f4828000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4830000 f4833000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4842000 f4847000 r-xp /usr/lib/libsystem.so.0.0.0
f4852000 f4855000 r-xp /lib/libattr.so.1.1.0
f485d000 f486d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4875000 f487e000 r-xp /usr/lib/libedbus.so.1.7.99
f4886000 f4887000 r-xp /usr/lib/libresponse.so.0.2.96
f4890000 f4895000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6137000 f623d000 r-xp /usr/lib/libicuuc.so.57.1
f6253000 f63db000 r-xp /usr/lib/libicui18n.so.57.1
f63eb000 f63f8000 r-xp /usr/lib/libail.so.0.1.0
f6401000 f6408000 r-xp /usr/lib/libminizip.so.1.0.0
f6411000 f65ba000 r-xp /usr/lib/libcrypto.so.1.0.0
f65da000 f6621000 r-xp /usr/lib/libssl.so.1.0.0
f662d000 f662f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6637000 f663e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6647000 f664e000 r-xp /lib/libcrypt-2.13.so
f667f000 f6682000 r-xp /lib/libcap.so.2.21
f668a000 f668c000 r-xp /usr/lib/libiri.so
f6694000 f66dd000 r-xp /usr/lib/libmdm.so.1.2.69
f66e5000 f66eb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66f3000 f6716000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6720000 f6722000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f672a000 f6747000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6750000 f6754000 r-xp /usr/lib/libsmack.so.1.0.0
f675d000 f6776000 r-xp /usr/lib/libnetwork.so.0.0.0
f677f000 f6787000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f678f000 f6795000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f679e000 f67a0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67a9000 f67b9000 r-xp /lib/libresolv-2.13.so
f67bd000 f67d5000 r-xp /usr/lib/liblzma.so.5.0.3
f67de000 f67e0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67e8000 f6802000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f680a000 f6839000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6842000 f6851000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f685b000 f6865000 r-xp /usr/lib/libsensord-shared.so
f686e000 f6941000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f694c000 f6962000 r-xp /lib/libz.so.1.2.5
f696a000 f696f000 r-xp /usr/lib/libffi.so.5.0.10
f6977000 f6978000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6980000 f6990000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6998000 f69b1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69b9000 f69bb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69c3000 f6a38000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a42000 f6a48000 r-xp /lib/librt-2.13.so
f6a51000 f6a6f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a79000 f6a7a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a82000 f6aa5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6aad000 f6ab2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aba000 f6ae4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aed000 f6b04000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b0c000 f6b75000 r-xp /lib/libm-2.13.so
f6b7e000 f6c12000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c25000 f6c2a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c32000 f6c39000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c41000 f6c6b000 r-xp /usr/lib/libsensor.so.1.9.6
f6c74000 f6d40000 r-xp /usr/lib/libxml2.so.2.7.8
f6d4d000 f6d4f000 r-xp /usr/lib/libiniparser.so.0
f6d58000 f6d5e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d67000 f6e37000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e38000 f6e6c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e75000 f6eb1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6eb9000 f6ebc000 r-xp /usr/lib/libbundle.so.0.1.22
f6ec4000 f6eca000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ed2000 f6f13000 r-xp /usr/lib/libeina.so.1.7.99
f6f1c000 f6f33000 r-xp /usr/lib/libecore.so.1.7.99
f6f4a000 f6f53000 r-xp /usr/lib/libvconf.so.0.2.45
f6f5b000 f6f6f000 r-xp /lib/libpthread-2.13.so
f6f7a000 f6f87000 r-xp /usr/lib/libaul.so.0.1.0
f6f91000 f6f93000 r-xp /lib/libdl-2.13.so
f6f9c000 f6fa7000 r-xp /lib/libunwind.so.8.0.1
f6fd4000 f6fdc000 r-xp /lib/libgcc_s-4.6.so.1
f6fdd000 f7101000 r-xp /lib/libc-2.13.so
f710f000 f7111000 r-xp /usr/lib/libdlog.so.0.0.0
f7119000 f7125000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f712e000 f7133000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f713b000 f714a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7152000 f7156000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f715f000 f7162000 r-xp /usr/lib/libappcore-agent.so.1.1
f716a000 f716c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7174000 f7178000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7180000 f719d000 r-xp /lib/ld-2.13.so
f71a6000 f71a9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71a9000 f71ad000 r-xp /usr/lib/libsys-assert.so
f7344000 f73b5000 rw-p [heap]
ff909000 ff92a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9751)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71a7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf713e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e453f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e43c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e4fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e55be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e55dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e8a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e851f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e43c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e4fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e55be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e55dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e87e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e88017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e8ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48271fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf481a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68ed663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d9afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d9c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f2cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f27b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f285a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f28879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7160183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71607fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71a74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6ff485c) [/lib/libc.so.6] + 0x1785c
29: (0xf71a6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:31:25.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:31:25.079+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:31:25.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9679
04-23 20:31:25.079+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:31:25.079+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9679
04-23 20:31:25.079+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9679)
04-23 20:31:25.089+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:25.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:25:103,0.033220,9.775742,0.777275
04-23 20:31:25.289+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:25.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:25:303,0.041728,9.776502,0.767236
04-23 20:31:25.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:25.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:25:503,0.017933,9.777816,0.751258
04-23 20:31:25.689+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:25.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:25:702,0.023533,9.777106,0.760280
04-23 20:31:25.879+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:31:25.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:25.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:25:904,0.033488,9.775329,0.782441
04-23 20:31:26.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:26.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:26:105,0.014566,9.768786,0.860808
04-23 20:31:26.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:26.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:26:303,0.017344,9.767263,0.877862
04-23 20:31:26.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:26.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:26:504,0.031045,9.770344,0.842496
04-23 20:31:26.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:26.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:26:705,0.020836,9.768175,0.867584
04-23 20:31:26.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:26.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:26:906,0.032342,9.772093,0.821908
04-23 20:31:27.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:27.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:27:106,0.037889,9.774187,0.796376
04-23 20:31:27.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:27.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:27:305,0.028043,9.776470,0.768262
04-23 20:31:27.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:27.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:27:505,0.024793,9.776360,0.769779
04-23 20:31:27.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:27.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:27:706,0.020204,9.777557,0.754554
04-23 20:31:27.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:27.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:27:905,0.018733,9.777999,0.748842
04-23 20:31:28.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:28.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:28:113,0.020397,9.773228,0.808696
04-23 20:31:28.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:28.329+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:28:304,0.025512,9.769691,0.850227
04-23 20:31:28.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:28.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:28:505,0.031136,9.775443,0.781103
04-23 20:31:28.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:28.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:28:704,0.042569,9.775002,0.786079
04-23 20:31:28.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:28.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:28:904,0.036508,9.774455,0.793140
04-23 20:31:29.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:29.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:29:104,0.031231,9.774482,0.793044
04-23 20:31:29.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:29.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:29:303,0.016894,9.772456,0.818044
04-23 20:31:29.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:29.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:29:503,0.007558,9.762137,0.933277
04-23 20:31:29.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:29.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:29:704,0.004457,9.780065,0.721593
04-23 20:31:29.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:29.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:29:903,0.015301,9.778371,0.744056
04-23 20:31:30.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:30.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:30:103,0.016296,9.778869,0.737461
04-23 20:31:30.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:30.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:30:304,0.008897,9.782096,0.693470
04-23 20:31:30.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:30.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:30:503,0.010420,9.782776,0.683793
04-23 20:31:30.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:30.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:30:704,0.011416,9.781150,0.706654
04-23 20:31:30.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:30.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:30:904,0.012090,9.780396,0.717004
04-23 20:31:31.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:31.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:31:103,0.011746,9.780417,0.716716
04-23 20:31:31.289+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:31.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:31:302,0.013940,9.780712,0.712644
04-23 20:31:31.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:31.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:31:504,0.011363,9.782123,0.693063
04-23 20:31:31.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:31.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:31:703,0.018114,9.781535,0.701160
04-23 20:31:31.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:31.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:31:903,0.023503,9.781246,0.705027
04-23 20:31:32.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:32.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:32:103,0.006483,9.783225,0.677391
04-23 20:31:32.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:32.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:32:303,0.013267,9.776438,0.769071
04-23 20:31:32.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:32.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:32:503,0.024910,9.773302,0.807670
04-23 20:31:32.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:32.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:32:703,0.005852,9.780541,0.715096
04-23 20:31:32.769+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:31:32.769+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:31:32.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:32.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:32.789+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9751
04-23 20:31:32.789+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:31:32.839+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9751
04-23 20:31:32.839+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9751) type(svcapp) bg(0)
04-23 20:31:32.839+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9751)
04-23 20:31:32.839+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:31:32.839+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:31:32.839+0200 E/CAPI_APPFW_APPLICATION( 9751): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:32.839+0200 E/CAPI_APPFW_APPLICATION( 9751): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:32.839+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9751) was created
04-23 20:31:32.849+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9751]
04-23 20:31:32.859+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:32.869+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9751
04-23 20:31:32.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:32.889+0200 W/LOCATION( 9751): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:31:32.889+0200 E/LOCATION( 9751): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:31:32.889+0200 E/PKGMGR_INFO( 9751): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:31:32.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:32.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:32:903,0.018421,9.778819,0.738072
04-23 20:31:32.899+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:32.919+0200 I/LOCATION( 9751): location.c: location_new(269) > method: 0
04-23 20:31:32.919+0200 W/LOCATION( 9751): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:32.929+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:32.929+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:32.929+0200 W/LOCATION( 9751): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:32.939+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:32.939+0200 W/LOCATION( 9751): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:32.939+0200 W/LOCATION( 9751): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:32.939+0200 W/LOCATION( 9751): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:32.939+0200 W/LOCATION( 9751): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:32.959+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:32.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:32.969+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9751
04-23 20:31:32.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:32.979+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:32.979+0200 W/LOCATION( 9751): module-internal.c: module_new(311) > module (wps) open success
04-23 20:31:32.979+0200 W/LOCATION( 9751): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:31:32.989+0200 W/LOCATION( 9751): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:31:32.989+0200 W/LOCATION( 9751): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:32.989+0200 W/LOCATION( 9751): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:32.999+0200 W/LOCATION( 9751): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:31:32.999+0200 I/LOCATION( 9751): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7374c18
04-23 20:31:33.009+0200 I/LOCATION( 9751): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:31:33.009+0200 I/LOCATION( 9751): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7374c18
04-23 20:31:33.009+0200 I/LOCATION( 9751): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:31:33.009+0200 I/location( 9751): es.ugr.frailty.location: creado servicio de localización
04-23 20:31:33.049+0200 I/LOCATION( 9751): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:31:33.089+0200 W/LOCATION( 9751): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:33.089+0200 W/LOCATION( 9751): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:33.089+0200 I/LOCATION( 9751): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:33.089+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:103,0.021535,9.779300,0.731586
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:31:33.159+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:31:33.159+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:33.159+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:33.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:31:33.169+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:31:33.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:31:33.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:31:33.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:31:33.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:31:33.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:31:33.169+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:31:33.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:31:33.169+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:31:33.219+0200 W/LOCATION( 9751): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:33.219+0200 W/LOCATION( 9751): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:33.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.309+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:33.309+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:33.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:33.309+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:33.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40031f8]
04-23 20:31:33.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:31:33.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:31:33.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:31:33.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:31:33.359+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:33.359+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:33.369+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:33.379+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:33.379+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:31:33.379+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:31:33.379+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:33.379+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:33.379+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:33.379+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:33.379+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:33.379+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:33.379+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:33.389+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:33.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:33.399+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:33.399+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:33.409+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:31:33.409+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2368674), time2(2355431)
04-23 20:31:33.409+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:31:33.409+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:31:33.409+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:31:33.409+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:31:33.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:33.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:303,0.030015,9.776782,0.764210
04-23 20:31:33.469+0200 W/LOCATION( 9751): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:31:33.469+0200 I/LOCATION( 9751): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:33.469+0200 I/LOCATION( 9751): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:33.469+0200 I/location( 9751): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:31:33.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:514,0.028324,9.777057,0.760758
04-23 20:31:33.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.529+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:522,0.025925,9.777169,0.759394
04-23 20:31:33.529+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:537,0.026566,9.777124,0.759943
04-23 20:31:33.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.549+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:544,0.026051,9.777347,0.757095
04-23 20:31:33.549+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.549+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:556,0.027269,9.777344,0.757090
04-23 20:31:33.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.569+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:564,0.029968,9.776962,0.761901
04-23 20:31:33.569+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.569+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:574,0.031174,9.776682,0.765441
04-23 20:31:33.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:584,0.030204,9.776922,0.762409
04-23 20:31:33.589+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.589+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:594,0.028895,9.777025,0.761140
04-23 20:31:33.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:604,0.028944,9.777063,0.760647
04-23 20:31:33.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.609+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:614,0.029223,9.777056,0.760731
04-23 20:31:33.609+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:618,0.029491,9.777164,0.759326
04-23 20:31:33.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.629+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:632,0.026331,9.777748,0.751882
04-23 20:31:33.629+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:636,0.025966,9.777336,0.757239
04-23 20:31:33.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.639+0200 I/LOCATION( 9751): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:33.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:646,0.027134,9.776914,0.762637
04-23 20:31:33.649+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.649+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:659,0.025192,9.776306,0.770446
04-23 20:31:33.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:666,0.028622,9.776073,0.773289
04-23 20:31:33.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:685,0.028391,9.776615,0.766401
04-23 20:31:33.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:706,0.028142,9.776575,0.766922
04-23 20:31:33.709+0200 E/location( 9751): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:31:33.709+0200 W/AUL     ( 9751): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:31:33.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:33.719+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9751
04-23 20:31:33.719+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:31:33.729+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.729+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:734,0.029369,9.776654,0.765869
04-23 20:31:33.729+0200 W/AUL     ( 9751): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:31:33.729+0200 I/location( 9751): request sent to service es.ugr.frailty.servicemanager
04-23 20:31:33.729+0200 W/CAPI_APPFW_APP_CONTROL( 9751): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.729+0200 I/utils   ( 9751): specific action
04-23 20:31:33.739+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:33.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:31:33.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.739+0200 I/utils   ( 8242): specific action
04-23 20:31:33.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.739+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.739+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:31:33.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:33.739+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:33.749+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:31:33.749+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:33.749+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:31:33.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.749+0200 I/utils   ( 8247): specific action
04-23 20:31:33.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.749+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:33.749+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:31:33.749+0200 I/recorder( 8247): guardando datos en local
04-23 20:31:33.749+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:31:33.749+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:31:33.749+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:31:33.749+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.749+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:758,0.029335,9.777118,0.759931
04-23 20:31:33.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:765,0.031081,9.776747,0.764619
04-23 20:31:33.779+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.779+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:786,0.031600,9.776970,0.761742
04-23 20:31:33.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:805,0.031835,9.776843,0.763349
04-23 20:31:33.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:825,0.033870,9.776560,0.766886
04-23 20:31:33.839+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.839+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:847,0.033594,9.776588,0.766540
04-23 20:31:33.859+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.859+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:865,0.033634,9.776326,0.769871
04-23 20:31:33.879+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:884,0.034132,9.776365,0.769353
04-23 20:31:33.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:906,0.032020,9.776120,0.772547
04-23 20:31:33.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:925,0.031472,9.775824,0.776314
04-23 20:31:33.939+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.939+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:946,0.031636,9.776003,0.774050
04-23 20:31:33.959+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.959+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:966,0.030940,9.776017,0.773896
04-23 20:31:33.979+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:33:985,0.030627,9.775982,0.774360
04-23 20:31:33.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:33.999+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:5,0.030035,9.776065,0.773325
04-23 20:31:34.019+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:26,0.030825,9.776126,0.772524
04-23 20:31:34.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:46,0.030001,9.776356,0.769648
04-23 20:31:34.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:65,0.030095,9.776338,0.769876
04-23 20:31:34.079+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.079+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:86,0.030521,9.776204,0.771542
04-23 20:31:34.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:105,0.029609,9.776213,0.771473
04-23 20:31:34.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.129+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:132,0.028798,9.776057,0.773475
04-23 20:31:34.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:146,0.028593,9.775972,0.774550
04-23 20:31:34.159+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.159+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:165,0.028745,9.775927,0.775129
04-23 20:31:34.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.179+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:185,0.031508,9.775974,0.774416
04-23 20:31:34.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:205,0.031457,9.776108,0.772728
04-23 20:31:34.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:225,0.030043,9.776181,0.771852
04-23 20:31:34.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.239+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:246,0.029941,9.776299,0.770356
04-23 20:31:34.259+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:265,0.028447,9.776572,0.766951
04-23 20:31:34.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:34.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:34.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:34.279+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.279+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:287,0.027281,9.776700,0.765363
04-23 20:31:34.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:346,0.026968,9.776736,0.764909
04-23 20:31:34.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.369+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:349,0.026889,9.776722,0.765088
04-23 20:31:34.369+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:383,0.026599,9.776893,0.762919
04-23 20:31:34.389+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.389+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:393,0.024925,9.777143,0.759760
04-23 20:31:34.389+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:400,0.024152,9.777279,0.758036
04-23 20:31:34.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.429+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:426,0.024656,9.777246,0.758449
04-23 20:31:34.429+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.429+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:434,0.025261,9.777350,0.757082
04-23 20:31:34.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:446,0.023972,9.777174,0.759387
04-23 20:31:34.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.509+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:31:34.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:468,0.021926,9.777102,0.760390
04-23 20:31:34.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:519,0.019584,9.777418,0.756365
04-23 20:31:34.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:525,0.019867,9.777636,0.753545
04-23 20:31:34.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:529,0.021541,9.777128,0.760054
04-23 20:31:34.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:546,0.021720,9.777172,0.759486
04-23 20:31:34.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:565,0.023454,9.776899,0.762937
04-23 20:31:34.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:585,0.021565,9.776703,0.765508
04-23 20:31:34.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:605,0.023968,9.776182,0.772061
04-23 20:31:34.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:625,0.027461,9.775694,0.778095
04-23 20:31:34.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:646,0.026302,9.775933,0.775125
04-23 20:31:34.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:665,0.027795,9.776205,0.771638
04-23 20:31:34.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:685,0.027328,9.775952,0.774852
04-23 20:31:34.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:704,0.027225,9.775551,0.779903
04-23 20:31:34.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:725,0.027606,9.775407,0.781695
04-23 20:31:34.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:746,0.028367,9.775229,0.783877
04-23 20:31:34.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:766,0.027396,9.775281,0.783270
04-23 20:31:34.779+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.779+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:786,0.025477,9.774857,0.788612
04-23 20:31:34.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:806,0.025701,9.775013,0.786662
04-23 20:31:34.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:831,0.024773,9.775097,0.785653
04-23 20:31:34.889+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:900,0.024234,9.775281,0.783378
04-23 20:31:34.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:904,0.025077,9.775388,0.782011
04-23 20:31:34.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:909,0.025886,9.774934,0.787646
04-23 20:31:34.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:914,0.026554,9.775200,0.784316
04-23 20:31:34.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:926,0.025363,9.775365,0.782297
04-23 20:31:34.939+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.939+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:947,0.027753,9.775612,0.779113
04-23 20:31:34.959+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.959+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:966,0.027292,9.775739,0.777547
04-23 20:31:34.979+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.989+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:34:986,0.027386,9.775616,0.779085
04-23 20:31:34.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:34.999+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:5,0.028717,9.775378,0.782014
04-23 20:31:35.019+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:26,0.029071,9.775052,0.786063
04-23 20:31:35.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:47,0.030431,9.774875,0.788210
04-23 20:31:35.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:66,0.029511,9.775012,0.786550
04-23 20:31:35.079+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.079+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:86,0.029955,9.774814,0.788992
04-23 20:31:35.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:106,0.030738,9.774877,0.788182
04-23 20:31:35.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:126,0.030671,9.774791,0.789247
04-23 20:31:35.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:147,0.031291,9.774618,0.791359
04-23 20:31:35.159+0200 W/LOCATION( 9751): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:31:35.169+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.179+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:181,0.031423,9.774322,0.795012
04-23 20:31:35.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.189+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:192,0.032569,9.774174,0.796779
04-23 20:31:35.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:204,0.033183,9.774183,0.796633
04-23 20:31:35.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:226,0.033574,9.774159,0.796914
04-23 20:31:35.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.239+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:246,0.034279,9.773998,0.798849
04-23 20:31:35.259+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:266,0.034881,9.773974,0.799119
04-23 20:31:35.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:35.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:35.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:35.279+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.289+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:290,0.034849,9.773857,0.800548
04-23 20:31:35.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:305,0.035037,9.773733,0.802059
04-23 20:31:35.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:326,0.034314,9.773589,0.803843
04-23 20:31:35.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:347,0.032059,9.773705,0.802535
04-23 20:31:35.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:365,0.030733,9.773876,0.800493
04-23 20:31:35.389+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:399,0.031268,9.774084,0.797931
04-23 20:31:35.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:35.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:35:406,0.030303,9.774200,0.796539
04-23 20:31:35.399+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11097516c6f63152450829
