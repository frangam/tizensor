S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9679
Date: 2018-04-23 20:31:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fde52d, r5   = 0xf7609f98
r6   = 0xffde77c0, r7   = 0xffde7670
r8   = 0xf7606c18, r9   = 0x00000000
r10  = 0xffde774c, fp   = 0xffde77c0
ip   = 0x00000001, sp   = 0xffde7648
lr   = 0xf6fde539, pc   = 0xf7047228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    143752 KB
Buffers:     35512 KB
Cached:     154136 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11948 KB
VmRSS:       11948 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9679 TID = 9679
9679 9682 

Maps Information
f3ea9000 f46a8000 rw-p [stack:9682]
f46af000 f46b1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46b9000 f46bd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46c6000 f46c8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46d0000 f46d3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46e2000 f46e7000 r-xp /usr/lib/libsystem.so.0.0.0
f46f2000 f46f5000 r-xp /lib/libattr.so.1.1.0
f46fd000 f470d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4715000 f471e000 r-xp /usr/lib/libedbus.so.1.7.99
f4726000 f4727000 r-xp /usr/lib/libresponse.so.0.2.96
f4730000 f4735000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fd7000 f60dd000 r-xp /usr/lib/libicuuc.so.57.1
f60f3000 f627b000 r-xp /usr/lib/libicui18n.so.57.1
f628b000 f6298000 r-xp /usr/lib/libail.so.0.1.0
f62a1000 f62a8000 r-xp /usr/lib/libminizip.so.1.0.0
f62b1000 f645a000 r-xp /usr/lib/libcrypto.so.1.0.0
f647a000 f64c1000 r-xp /usr/lib/libssl.so.1.0.0
f64cd000 f64cf000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64d7000 f64de000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64e7000 f64ee000 r-xp /lib/libcrypt-2.13.so
f651f000 f6522000 r-xp /lib/libcap.so.2.21
f652a000 f652c000 r-xp /usr/lib/libiri.so
f6534000 f657d000 r-xp /usr/lib/libmdm.so.1.2.69
f6585000 f658b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6593000 f65b6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65c0000 f65c2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65ca000 f65e7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65f0000 f65f4000 r-xp /usr/lib/libsmack.so.1.0.0
f65fd000 f6616000 r-xp /usr/lib/libnetwork.so.0.0.0
f661f000 f6627000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f662f000 f6635000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f663e000 f6640000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6649000 f6659000 r-xp /lib/libresolv-2.13.so
f665d000 f6675000 r-xp /usr/lib/liblzma.so.5.0.3
f667e000 f6680000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6688000 f66a2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66aa000 f66d9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66e2000 f66f1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66fb000 f6705000 r-xp /usr/lib/libsensord-shared.so
f670e000 f67e1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67ec000 f6802000 r-xp /lib/libz.so.1.2.5
f680a000 f680f000 r-xp /usr/lib/libffi.so.5.0.10
f6817000 f6818000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6820000 f6830000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6838000 f6851000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6859000 f685b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6863000 f68d8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68e2000 f68e8000 r-xp /lib/librt-2.13.so
f68f1000 f690f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6919000 f691a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6922000 f6945000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f694d000 f6952000 r-xp /usr/lib/libxdgmime.so.1.1.0
f695a000 f6984000 r-xp /usr/lib/libdbus-1.so.3.8.12
f698d000 f69a4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69ac000 f6a15000 r-xp /lib/libm-2.13.so
f6a1e000 f6ab2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ac5000 f6aca000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ad2000 f6ad9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ae1000 f6b0b000 r-xp /usr/lib/libsensor.so.1.9.6
f6b14000 f6be0000 r-xp /usr/lib/libxml2.so.2.7.8
f6bed000 f6bef000 r-xp /usr/lib/libiniparser.so.0
f6bf8000 f6bfe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c07000 f6cd7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cd8000 f6d0c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d15000 f6d51000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d59000 f6d5c000 r-xp /usr/lib/libbundle.so.0.1.22
f6d64000 f6d6a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d72000 f6db3000 r-xp /usr/lib/libeina.so.1.7.99
f6dbc000 f6dd3000 r-xp /usr/lib/libecore.so.1.7.99
f6dea000 f6df3000 r-xp /usr/lib/libvconf.so.0.2.45
f6dfb000 f6e0f000 r-xp /lib/libpthread-2.13.so
f6e1a000 f6e27000 r-xp /usr/lib/libaul.so.0.1.0
f6e31000 f6e33000 r-xp /lib/libdl-2.13.so
f6e3c000 f6e47000 r-xp /lib/libunwind.so.8.0.1
f6e74000 f6e7c000 r-xp /lib/libgcc_s-4.6.so.1
f6e7d000 f6fa1000 r-xp /lib/libc-2.13.so
f6faf000 f6fb1000 r-xp /usr/lib/libdlog.so.0.0.0
f6fb9000 f6fc5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fce000 f6fd3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fdb000 f6fea000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6ff2000 f6ff6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fff000 f7002000 r-xp /usr/lib/libappcore-agent.so.1.1
f700a000 f700c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7014000 f7018000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7020000 f703d000 r-xp /lib/ld-2.13.so
f7046000 f7049000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7049000 f704d000 r-xp /usr/lib/libsys-assert.so
f75d6000 f7660000 rw-p [heap]
ffdc8000 ffde9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9679)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7047228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fde539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ce53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ce3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cefe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cf5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cf5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d2a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d251f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ce3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cefe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cf5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cf5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d27e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d28017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d2ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46c71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46ba171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf678d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c3afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c3c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6dccca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dc7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dc85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dc8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7000183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70007fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70474f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e9485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7046f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
1:11.589+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.589+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:597,0.028214,9.769530,0.851977
04-23 20:31:11.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.619+0200 W/AUL     ( 9642): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:31:11.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:31:11.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:31:11.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9592
04-23 20:31:11.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:31:11.629+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9592
04-23 20:31:11.629+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9592)
04-23 20:31:11.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:604,0.028278,9.769657,0.850523
04-23 20:31:11.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:645,0.026958,9.769405,0.853447
04-23 20:31:11.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.649+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:653,0.025684,9.769174,0.856138
04-23 20:31:11.649+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.649+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:659,0.027458,9.769463,0.852773
04-23 20:31:11.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:666,0.027362,9.769391,0.853600
04-23 20:31:11.669+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.669+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:674,0.027262,9.769147,0.856391
04-23 20:31:11.669+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.669+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:678,0.029741,9.769524,0.852000
04-23 20:31:11.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:718,0.047387,9.772463,0.816764
04-23 20:31:11.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:11.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:11:918,0.047677,9.773784,0.800795
04-23 20:31:12.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:12.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:12:118,0.043145,9.774731,0.789405
04-23 20:31:12.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:12.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:12:318,0.042505,9.774482,0.792519
04-23 20:31:12.479+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:31:12.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:12.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:12:518,0.032586,9.773262,0.807883
04-23 20:31:12.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:12.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:12:718,0.037760,9.772465,0.817243
04-23 20:31:12.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:12.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:12:918,0.041375,9.773330,0.806654
04-23 20:31:13.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:13.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:13:118,0.044577,9.774576,0.791233
04-23 20:31:13.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:13.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:13:318,0.036326,9.774711,0.789995
04-23 20:31:13.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:13.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:13:518,0.030834,9.773912,0.800044
04-23 20:31:13.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:13.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:13:717,0.030334,9.772605,0.815873
04-23 20:31:13.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:13.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:13:918,0.036693,9.771762,0.825659
04-23 20:31:14.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:14.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:14:123,0.053702,9.773415,0.804899
04-23 20:31:14.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:14.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:14:317,0.048995,9.773419,0.805146
04-23 20:31:14.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:14.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:14:518,0.053158,9.774069,0.796957
04-23 20:31:14.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:14.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:14:719,0.045205,9.773843,0.800210
04-23 20:31:14.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:14.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:14:922,0.045794,9.772465,0.816833
04-23 20:31:15.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:15.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:15:121,0.045364,9.771037,0.833761
04-23 20:31:15.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:15.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:15:320,0.041882,9.769803,0.848279
04-23 20:31:15.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:15.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:15:520,0.033879,9.768980,0.858059
04-23 20:31:15.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:15.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:15:721,0.041442,9.770833,0.836350
04-23 20:31:15.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:15.969+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:15:921,0.031745,9.770700,0.838328
04-23 20:31:16.129+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:16.129+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:16:133,0.036432,9.770641,0.838829
04-23 20:31:16.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:16.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:16:322,0.034883,9.770336,0.842434
04-23 20:31:16.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:16.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:16:522,0.025978,9.768983,0.858307
04-23 20:31:16.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:16.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:16:723,0.036041,9.772064,0.822104
04-23 20:31:16.929+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:16.929+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:16:933,0.037368,9.774584,0.791511
04-23 20:31:17.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:17.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:17:123,0.034998,9.775744,0.777159
04-23 20:31:17.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:17.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:17:323,0.035761,9.775434,0.781026
04-23 20:31:17.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:17.549+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:17:530,0.027569,9.775363,0.782243
04-23 20:31:17.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:17.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:17:723,0.033807,9.771169,0.832768
04-23 20:31:17.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:17.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:17:922,0.049101,9.772896,0.811469
04-23 20:31:18.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:18.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:18:123,0.033844,9.775027,0.786187
04-23 20:31:18.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:18.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:18:323,0.030714,9.774066,0.798173
04-23 20:31:18.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:18.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:18:523,0.036349,9.773303,0.807228
04-23 20:31:18.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:18.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:18:724,0.042399,9.772863,0.812232
04-23 20:31:18.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:18.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:18:923,0.048280,9.773437,0.804981
04-23 20:31:19.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:19.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:19:123,0.056051,9.774431,0.792293
04-23 20:31:19.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:19.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:19:324,0.038530,9.772718,0.814172
04-23 20:31:19.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:19.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:19:523,0.054389,9.774245,0.794701
04-23 20:31:19.529+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:31:19.529+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:31:19.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:19.529+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:19.539+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:31:19.539+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9679
04-23 20:31:19.589+0200 E/CAPI_APPFW_APPLICATION( 9679): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:19.589+0200 E/CAPI_APPFW_APPLICATION( 9679): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:19.589+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9679
04-23 20:31:19.589+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9679) type(svcapp) bg(0)
04-23 20:31:19.589+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9679) was created
04-23 20:31:19.599+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9679]
04-23 20:31:19.599+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9679)
04-23 20:31:19.599+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:31:19.599+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:31:19.599+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:19.609+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9679
04-23 20:31:19.609+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:19.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:19.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9679
04-23 20:31:19.639+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:19.649+0200 W/LOCATION( 9679): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:31:19.649+0200 E/LOCATION( 9679): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:31:19.649+0200 E/PKGMGR_INFO( 9679): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:31:19.659+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:19.669+0200 I/LOCATION( 9679): location.c: location_new(269) > method: 0
04-23 20:31:19.679+0200 W/LOCATION( 9679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:19.679+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:19.689+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:19.689+0200 W/LOCATION( 9679): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:19.689+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:19.699+0200 W/LOCATION( 9679): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:19.699+0200 W/LOCATION( 9679): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:19.699+0200 W/LOCATION( 9679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:19.699+0200 W/LOCATION( 9679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:19.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:19.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:19:723,0.038439,9.771696,0.826352
04-23 20:31:19.719+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:19.719+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:19.729+0200 W/LOCATION( 9679): module-internal.c: module_new(311) > module (wps) open success
04-23 20:31:19.729+0200 W/LOCATION( 9679): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:31:19.729+0200 W/LOCATION( 9679): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:31:19.729+0200 W/LOCATION( 9679): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:19.729+0200 W/LOCATION( 9679): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:19.749+0200 W/LOCATION( 9679): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:31:19.749+0200 I/LOCATION( 9679): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7606c18
04-23 20:31:19.749+0200 I/LOCATION( 9679): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:31:19.749+0200 I/LOCATION( 9679): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7606c18
04-23 20:31:19.749+0200 I/LOCATION( 9679): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:31:19.759+0200 I/location( 9679): es.ugr.frailty.location: creado servicio de localización
04-23 20:31:19.799+0200 I/LOCATION( 9679): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:31:19.839+0200 W/LOCATION( 9679): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:19.839+0200 W/LOCATION( 9679): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:19.839+0200 I/LOCATION( 9679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:31:19.899+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:31:19.899+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:19.899+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:19.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:31:19.909+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:31:19.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:31:19.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:31:19.909+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:31:19.909+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:31:19.909+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:31:19.909+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:31:19.909+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:31:19.909+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:31:19.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:19.959+0200 W/LOCATION( 9679): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:19.959+0200 W/LOCATION( 9679): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:19.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:19:923,0.038610,9.771965,0.823158
04-23 20:31:20.039+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:20.079+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4004cb0]
04-23 20:31:20.079+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:31:20.079+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:31:20.079+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:31:20.079+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:31:20.089+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:20.089+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:20.099+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:20.109+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:20.109+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:31:20.109+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:31:20.109+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:20.109+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:20.109+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:20.109+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:20.109+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:20.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:20.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:20.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:20.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:124,0.021173,9.768622,0.862521
04-23 20:31:20.129+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:20.129+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:20.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:20.169+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:31:20.169+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2355430), time2(2342108)
04-23 20:31:20.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:31:20.169+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:31:20.169+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:31:20.169+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:31:20.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:20.199+0200 W/LOCATION( 9679): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:31:20.199+0200 I/LOCATION( 9679): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:20.199+0200 I/LOCATION( 9679): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:20.199+0200 I/location( 9679): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:31:20.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:20.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:20.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:20.309+0200 I/LOCATION( 9679): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:20.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:323,0.023008,9.769681,0.850402
04-23 20:31:20.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:344,0.021795,9.769400,0.853658
04-23 20:31:20.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:363,0.023390,9.769886,0.848037
04-23 20:31:20.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:383,0.023335,9.769958,0.847197
04-23 20:31:20.379+0200 E/location( 9679): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:31:20.379+0200 W/AUL     ( 9679): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:31:20.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:20.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9679
04-23 20:31:20.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:31:20.389+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:20.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:31:20.389+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.389+0200 I/utils   ( 8242): specific action
04-23 20:31:20.389+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.389+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.389+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.389+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:31:20.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:20.399+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:20.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:31:20.409+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:31:20.409+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:31:20.409+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:31:20.409+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.409+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:415,0.022227,9.769051,0.857639
04-23 20:31:20.409+0200 W/AUL     ( 9679): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:31:20.409+0200 I/location( 9679): request sent to service es.ugr.frailty.servicemanager
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 9679): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 I/utils   ( 9679): specific action
04-23 20:31:20.409+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:20.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 I/utils   ( 8247): specific action
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:20.409+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:31:20.409+0200 I/recorder( 8247): guardando datos en local
04-23 20:31:20.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:423,0.023617,9.769264,0.855166
04-23 20:31:20.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:444,0.024803,9.769831,0.848629
04-23 20:31:20.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:464,0.025051,9.769579,0.851517
04-23 20:31:20.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:483,0.025170,9.769241,0.855384
04-23 20:31:20.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:503,0.023244,9.768303,0.866081
04-23 20:31:20.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:524,0.023225,9.768069,0.868716
04-23 20:31:20.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:544,0.025027,9.769096,0.857040
04-23 20:31:20.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:563,0.027306,9.769897,0.847787
04-23 20:31:20.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:584,0.026493,9.769732,0.849706
04-23 20:31:20.589+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:603,0.027901,9.769894,0.847809
04-23 20:31:20.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:623,0.026401,9.769320,0.854447
04-23 20:31:20.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:645,0.026916,9.769343,0.854155
04-23 20:31:20.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:664,0.026957,9.769268,0.855019
04-23 20:31:20.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:683,0.026508,9.769060,0.857403
04-23 20:31:20.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:704,0.026895,9.768920,0.858991
04-23 20:31:20.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:723,0.024830,9.768263,0.866489
04-23 20:31:20.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:744,0.022389,9.767286,0.877499
04-23 20:31:20.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:764,0.022612,9.767588,0.874127
04-23 20:31:20.779+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.779+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:783,0.025843,9.768991,0.858208
04-23 20:31:20.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:803,0.027519,9.769331,0.854285
04-23 20:31:20.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:824,0.027611,9.769531,0.851986
04-23 20:31:20.839+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.839+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:844,0.025433,9.768909,0.859161
04-23 20:31:20.859+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.859+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:865,0.026431,9.768868,0.859593
04-23 20:31:20.879+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:884,0.026831,9.768610,0.862506
04-23 20:31:20.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:904,0.024588,9.767879,0.870808
04-23 20:31:20.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:923,0.024695,9.768081,0.868550
04-23 20:31:20.939+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.939+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:945,0.023405,9.767715,0.872677
04-23 20:31:20.959+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.959+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:963,0.024193,9.768126,0.868041
04-23 20:31:20.979+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:20:983,0.025728,9.768592,0.862746
04-23 20:31:20.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:20.999+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:4,0.024235,9.767789,0.871839
04-23 20:31:21.019+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:23,0.025037,9.768121,0.868087
04-23 20:31:21.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:44,0.024342,9.767840,0.871251
04-23 20:31:21.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:64,0.024003,9.767840,0.871263
04-23 20:31:21.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:128,0.023571,9.767683,0.873040
04-23 20:31:21.159+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.159+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:166,0.024077,9.768105,0.868294
04-23 20:31:21.169+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.189+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:174,0.022053,9.767310,0.877245
04-23 20:31:21.189+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:200,0.023184,9.767718,0.872660
04-23 20:31:21.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.209+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:210,0.024042,9.768153,0.867750
04-23 20:31:21.209+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:223,0.025226,9.768815,0.860237
04-23 20:31:21.229+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.239+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:234,0.025656,9.769157,0.856318
04-23 20:31:21.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.249+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:246,0.025377,9.769053,0.857531
04-23 20:31:21.249+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:258,0.026473,9.769580,0.851470
04-23 20:31:21.269+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:31:21.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:21.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:31:21.329+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:31:21.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:274,0.026717,9.769567,0.851609
04-23 20:31:21.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:346,0.026154,9.769452,0.852945
04-23 20:31:21.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.349+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:349,0.026201,9.769711,0.849976
04-23 20:31:21.349+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.349+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:353,0.026468,9.769866,0.848177
04-23 20:31:21.349+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.349+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:357,0.028520,9.770278,0.843350
04-23 20:31:21.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:364,0.028116,9.769842,0.848396
04-23 20:31:21.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:383,0.028056,9.769815,0.848702
04-23 20:31:21.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:403,0.026633,9.769532,0.852005
04-23 20:31:21.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:424,0.027887,9.769739,0.849591
04-23 20:31:21.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:444,0.029799,9.769842,0.848340
04-23 20:31:21.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:463,0.031023,9.770012,0.846343
04-23 20:31:21.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:484,0.031733,9.770195,0.844199
04-23 20:31:21.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:503,0.033247,9.770400,0.841757
04-23 20:31:21.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:523,0.037347,9.771382,0.830110
04-23 20:31:21.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:545,0.040675,9.771743,0.825692
04-23 20:31:21.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:563,0.040935,9.771715,0.826009
04-23 20:31:21.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:583,0.040159,9.771558,0.827902
04-23 20:31:21.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:604,0.041314,9.771431,0.829349
04-23 20:31:21.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:623,0.040399,9.771415,0.829580
04-23 20:31:21.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:644,0.039985,9.771581,0.827640
04-23 20:31:21.669+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.669+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:673,0.039014,9.771589,0.827594
04-23 20:31:21.729+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:739,0.039586,9.771492,0.828716
04-23 20:31:21.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:746,0.039482,9.771366,0.830197
04-23 20:31:21.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.749+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:750,0.041224,9.771652,0.826745
04-23 20:31:21.749+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.749+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:754,0.042031,9.771855,0.824299
04-23 20:31:21.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:763,0.041992,9.771865,0.824187
04-23 20:31:21.779+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.779+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:783,0.039815,9.771631,0.827061
04-23 20:31:21.789+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:803,0.040821,9.771523,0.828278
04-23 20:31:21.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:827,0.040770,9.771609,0.827265
04-23 20:31:21.839+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.839+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:845,0.039978,9.771653,0.826794
04-23 20:31:21.859+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.859+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:863,0.039234,9.771559,0.827943
04-23 20:31:21.869+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:883,0.039555,9.771529,0.828274
04-23 20:31:21.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:905,0.038776,9.771211,0.832059
04-23 20:31:21.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:923,0.039454,9.771150,0.832741
04-23 20:31:21.939+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.939+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:944,0.040592,9.771552,0.827953
04-23 20:31:21.959+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.959+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:963,0.041638,9.771596,0.827381
04-23 20:31:21.969+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:21.989+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:21:983,0.041623,9.771547,0.827959
04-23 20:31:21.999+0200 W/LOCATION( 9679): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:31:21.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.009+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:12,0.040227,9.771544,0.828068
04-23 20:31:22.019+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:24,0.040038,9.771575,0.827705
04-23 20:31:22.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:44,0.039979,9.771439,0.829326
04-23 20:31:22.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:64,0.038778,9.771428,0.829502
04-23 20:31:22.079+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.079+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:83,0.036514,9.771181,0.832511
04-23 20:31:22.089+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:103,0.035600,9.771110,0.833386
04-23 20:31:22.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:123,0.034290,9.770892,0.835990
04-23 20:31:22.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:145,0.033716,9.770793,0.837164
04-23 20:31:22.149+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.159+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:163,0.034968,9.770967,0.835082
04-23 20:31:22.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.179+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:184,0.033895,9.770848,0.836518
04-23 20:31:22.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:207,0.034938,9.771092,0.833612
04-23 20:31:22.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:22.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:22:223,0.034542,9.771285,0.831374
04-23 20:31:22.229+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11096796c6f63152450828
