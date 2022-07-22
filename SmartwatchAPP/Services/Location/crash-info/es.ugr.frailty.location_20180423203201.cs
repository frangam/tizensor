S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9901
Date: 2018-04-23 20:32:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70a852d, r5   = 0xf788bf98
r6   = 0xffd22620, r7   = 0xffd224d0
r8   = 0xf7888c18, r9   = 0x00000000
r10  = 0xffd225ac, fp   = 0xffd22620
ip   = 0x00000001, sp   = 0xffd224a8
lr   = 0xf70a8539, pc   = 0xf7111228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    123952 KB
Buffers:     35960 KB
Cached:     154944 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11912 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9901 TID = 9901
9901 9904 

Maps Information
f3f73000 f4772000 rw-p [stack:9904]
f4779000 f477b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4783000 f4787000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4790000 f4792000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f479a000 f479d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47ac000 f47b1000 r-xp /usr/lib/libsystem.so.0.0.0
f47bc000 f47bf000 r-xp /lib/libattr.so.1.1.0
f47c7000 f47d7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47df000 f47e8000 r-xp /usr/lib/libedbus.so.1.7.99
f47f0000 f47f1000 r-xp /usr/lib/libresponse.so.0.2.96
f47fa000 f47ff000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60a1000 f61a7000 r-xp /usr/lib/libicuuc.so.57.1
f61bd000 f6345000 r-xp /usr/lib/libicui18n.so.57.1
f6355000 f6362000 r-xp /usr/lib/libail.so.0.1.0
f636b000 f6372000 r-xp /usr/lib/libminizip.so.1.0.0
f637b000 f6524000 r-xp /usr/lib/libcrypto.so.1.0.0
f6544000 f658b000 r-xp /usr/lib/libssl.so.1.0.0
f6597000 f6599000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65a1000 f65a8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65b1000 f65b8000 r-xp /lib/libcrypt-2.13.so
f65e9000 f65ec000 r-xp /lib/libcap.so.2.21
f65f4000 f65f6000 r-xp /usr/lib/libiri.so
f65fe000 f6647000 r-xp /usr/lib/libmdm.so.1.2.69
f664f000 f6655000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f665d000 f6680000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f668a000 f668c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6694000 f66b1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66ba000 f66be000 r-xp /usr/lib/libsmack.so.1.0.0
f66c7000 f66e0000 r-xp /usr/lib/libnetwork.so.0.0.0
f66e9000 f66f1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66f9000 f66ff000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6708000 f670a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6713000 f6723000 r-xp /lib/libresolv-2.13.so
f6727000 f673f000 r-xp /usr/lib/liblzma.so.5.0.3
f6748000 f674a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6752000 f676c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6774000 f67a3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67ac000 f67bb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67c5000 f67cf000 r-xp /usr/lib/libsensord-shared.so
f67d8000 f68ab000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b6000 f68cc000 r-xp /lib/libz.so.1.2.5
f68d4000 f68d9000 r-xp /usr/lib/libffi.so.5.0.10
f68e1000 f68e2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68ea000 f68fa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6902000 f691b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6923000 f6925000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f692d000 f69a2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ac000 f69b2000 r-xp /lib/librt-2.13.so
f69bb000 f69d9000 r-xp /usr/lib/libsystemd.so.0.4.0
f69e3000 f69e4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69ec000 f6a0f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a17000 f6a1c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a24000 f6a4e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a57000 f6a6e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a76000 f6adf000 r-xp /lib/libm-2.13.so
f6ae8000 f6b7c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b8f000 f6b94000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b9c000 f6ba3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bab000 f6bd5000 r-xp /usr/lib/libsensor.so.1.9.6
f6bde000 f6caa000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb7000 f6cb9000 r-xp /usr/lib/libiniparser.so.0
f6cc2000 f6cc8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cd1000 f6da1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6da2000 f6dd6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ddf000 f6e1b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e23000 f6e26000 r-xp /usr/lib/libbundle.so.0.1.22
f6e2e000 f6e34000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e3c000 f6e7d000 r-xp /usr/lib/libeina.so.1.7.99
f6e86000 f6e9d000 r-xp /usr/lib/libecore.so.1.7.99
f6eb4000 f6ebd000 r-xp /usr/lib/libvconf.so.0.2.45
f6ec5000 f6ed9000 r-xp /lib/libpthread-2.13.so
f6ee4000 f6ef1000 r-xp /usr/lib/libaul.so.0.1.0
f6efb000 f6efd000 r-xp /lib/libdl-2.13.so
f6f06000 f6f11000 r-xp /lib/libunwind.so.8.0.1
f6f3e000 f6f46000 r-xp /lib/libgcc_s-4.6.so.1
f6f47000 f706b000 r-xp /lib/libc-2.13.so
f7079000 f707b000 r-xp /usr/lib/libdlog.so.0.0.0
f7083000 f708f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7098000 f709d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70a5000 f70b4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70bc000 f70c0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70c9000 f70cc000 r-xp /usr/lib/libappcore-agent.so.1.1
f70d4000 f70d6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70de000 f70e2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70ea000 f7107000 r-xp /lib/ld-2.13.so
f7110000 f7113000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7113000 f7117000 r-xp /usr/lib/libsys-assert.so
f7858000 f78e2000 rw-p [heap]
ffd03000 ffd24000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9901)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7111228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70a8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6daf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dadc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6db9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dbfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dbfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6df475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6def1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dadc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6db9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dbfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dbfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6df1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6df2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6df9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47911fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4784171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6857663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d04fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d067a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e96ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e91b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e925a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e92879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70ca183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70ca7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71114f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f5e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7110f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
29+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.129+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:134,0.027540,9.768020,0.869147
04-23 20:31:51.129+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.129+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:138,0.028462,9.768089,0.868336
04-23 20:31:51.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:149,0.029540,9.768758,0.860742
04-23 20:31:51.149+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.169+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:154,0.029884,9.769180,0.855926
04-23 20:31:51.169+0200 W/AUL     ( 9868): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:31:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:31:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:31:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9833
04-23 20:31:51.169+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:31:51.169+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9833
04-23 20:31:51.169+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9833)
04-23 20:31:51.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.189+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:189,0.033042,9.769799,0.848719
04-23 20:31:51.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:203,0.031111,9.769912,0.847485
04-23 20:31:51.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.209+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:209,0.031533,9.770540,0.840202
04-23 20:31:51.209+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.209+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:215,0.029634,9.770807,0.837156
04-23 20:31:51.209+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:222,0.029670,9.770790,0.837356
04-23 20:31:51.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.219+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:228,0.028942,9.770321,0.842841
04-23 20:31:51.229+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.229+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:233,0.029200,9.770310,0.842956
04-23 20:31:51.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.239+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:245,0.028537,9.770342,0.842613
04-23 20:31:51.239+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.249+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:250,0.029032,9.770475,0.841047
04-23 20:31:51.249+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.249+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:254,0.029321,9.770088,0.845521
04-23 20:31:51.249+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:261,0.029802,9.770459,0.841205
04-23 20:31:51.259+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.259+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:267,0.029369,9.770299,0.843079
04-23 20:31:51.269+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.269+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:273,0.031421,9.770323,0.842732
04-23 20:31:51.269+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:280,0.033317,9.770174,0.844382
04-23 20:31:51.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:349,0.033437,9.769853,0.848085
04-23 20:31:51.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:442,0.034296,9.770360,0.842183
04-23 20:31:51.489+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:494,0.033152,9.770336,0.842510
04-23 20:31:51.489+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.489+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:498,0.031708,9.769673,0.850216
04-23 20:31:51.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:510,0.031194,9.769408,0.853268
04-23 20:31:51.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:514,0.030931,9.769129,0.856476
04-23 20:31:51.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:518,0.031823,9.769379,0.853586
04-23 20:31:51.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:522,0.029931,9.768842,0.859784
04-23 20:31:51.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.529+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:532,0.026620,9.769088,0.857089
04-23 20:31:51.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:713,0.035885,9.770057,0.845624
04-23 20:31:51.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:51.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:51:913,0.040968,9.772631,0.815103
04-23 20:31:52.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:52.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:52:113,0.041975,9.774137,0.796784
04-23 20:31:52.139+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:31:52.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:52.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:52:303,0.033043,9.772704,0.814588
04-23 20:31:52.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:52.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:52:513,0.015230,9.773397,0.806755
04-23 20:31:52.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:52.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:52:703,0.023122,9.774076,0.798302
04-23 20:31:52.909+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:52.909+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:52:913,0.026170,9.776431,0.768827
04-23 20:31:53.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:53.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:53:113,0.020059,9.774659,0.791214
04-23 20:31:53.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:53.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:53:316,0.023110,9.771597,0.828092
04-23 20:31:53.509+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:53.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:53:516,0.040873,9.771538,0.828106
04-23 20:31:53.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:53.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:53:716,0.031599,9.774189,0.796625
04-23 20:31:53.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:53.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:53:906,0.035207,9.776321,0.769863
04-23 20:31:54.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:54.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:54:106,0.021452,9.778197,0.746177
04-23 20:31:54.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:54.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:54:313,0.015548,9.779762,0.725532
04-23 20:31:54.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:54.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:54:504,0.020320,9.777093,0.760542
04-23 20:31:54.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:54.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:54:704,0.023691,9.778042,0.748146
04-23 20:31:54.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:54.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:54:904,0.017055,9.779670,0.726746
04-23 20:31:55.109+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:55.109+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:55:113,0.030660,9.775797,0.776682
04-23 20:31:55.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:55.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:55:304,0.031490,9.773125,0.809579
04-23 20:31:55.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:55.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:55:504,0.036826,9.769974,0.846550
04-23 20:31:55.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:55.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:55:703,0.037338,9.768487,0.863511
04-23 20:31:55.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:55.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:55:903,0.036295,9.770739,0.837699
04-23 20:31:56.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:56.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:56:104,0.027654,9.769208,0.855680
04-23 20:31:56.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:56.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:56:303,0.022726,9.766939,0.881343
04-23 20:31:56.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:56.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:56:503,0.018502,9.767002,0.880749
04-23 20:31:56.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:56.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:56:704,0.023667,9.768184,0.867412
04-23 20:31:56.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:56.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:56:903,0.026541,9.771627,0.827636
04-23 20:31:57.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:57.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:57:103,0.015021,9.773439,0.806247
04-23 20:31:57.289+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:57.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:57:302,0.016115,9.776568,0.767359
04-23 20:31:57.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:57.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:57:503,0.014430,9.777819,0.751294
04-23 20:31:57.689+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:57.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:57:702,0.014200,9.778692,0.739835
04-23 20:31:57.889+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:57.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:57:902,0.019474,9.777493,0.755407
04-23 20:31:58.089+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:58.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:58:102,-0.001671,9.801197,-0.326996
04-23 20:31:58.289+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:58.299+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:58:303,0.020110,9.778122,0.747202
04-23 20:31:58.489+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:58.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:58:502,0.019992,9.775718,0.778034
04-23 20:31:58.689+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:58.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:58:702,0.026237,9.773698,0.802821
04-23 20:31:58.889+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:58.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:58:902,0.031233,9.772821,0.813249
04-23 20:31:59.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:59.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:59:103,0.023267,9.772502,0.817339
04-23 20:31:59.129+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:31:59.129+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:31:59.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:59.129+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:59.139+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9901
04-23 20:31:59.139+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:31:59.189+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9901
04-23 20:31:59.189+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9901) type(svcapp) bg(0)
04-23 20:31:59.189+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9901)
04-23 20:31:59.189+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:31:59.189+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:31:59.189+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9901]
04-23 20:31:59.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:59.209+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9901
04-23 20:31:59.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:59.219+0200 E/CAPI_APPFW_APPLICATION( 9901): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:59.219+0200 E/CAPI_APPFW_APPLICATION( 9901): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:31:59.219+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9901) was created
04-23 20:31:59.239+0200 W/LOCATION( 9901): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:31:59.239+0200 E/LOCATION( 9901): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:31:59.249+0200 E/PKGMGR_INFO( 9901): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:31:59.249+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:59.269+0200 I/LOCATION( 9901): location.c: location_new(269) > method: 0
04-23 20:31:59.269+0200 W/LOCATION( 9901): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:59.269+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:59.279+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:59.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:31:59.299+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9901
04-23 20:31:59.299+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:59.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:59:309,0.031558,9.772369,0.818647
04-23 20:31:59.309+0200 W/LOCATION( 9901): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:59.319+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:59.319+0200 W/LOCATION( 9901): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:59.319+0200 W/LOCATION( 9901): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:59.319+0200 W/LOCATION( 9901): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:59.319+0200 W/LOCATION( 9901): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:59.349+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:59.349+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:31:59.349+0200 W/LOCATION( 9901): module-internal.c: module_new(311) > module (wps) open success
04-23 20:31:59.359+0200 W/LOCATION( 9901): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:31:59.359+0200 W/LOCATION( 9901): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:31:59.359+0200 W/LOCATION( 9901): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:59.359+0200 W/LOCATION( 9901): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:59.379+0200 W/LOCATION( 9901): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:31:59.379+0200 I/LOCATION( 9901): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7888c18
04-23 20:31:59.379+0200 I/LOCATION( 9901): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:31:59.379+0200 I/LOCATION( 9901): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7888c18
04-23 20:31:59.379+0200 I/LOCATION( 9901): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:31:59.379+0200 I/location( 9901): es.ugr.frailty.location: creado servicio de localización
04-23 20:31:59.429+0200 I/LOCATION( 9901): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:31:59.459+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:31:59.469+0200 W/LOCATION( 9901): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:59.469+0200 W/LOCATION( 9901): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:59.469+0200 I/LOCATION( 9901): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:59.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:59.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:59:504,0.017999,9.768953,0.858842
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:31:59.539+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:31:59.539+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:59.539+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:31:59.549+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:31:59.549+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:31:59.549+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:31:59.549+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:31:59.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:31:59.549+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:31:59.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:31:59.549+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:31:59.549+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:31:59.549+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:31:59.599+0200 W/LOCATION( 9901): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:31:59.599+0200 W/LOCATION( 9901): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:31:59.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:59.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:59.719+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400b818]
04-23 20:31:59.719+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:31:59.719+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:31:59.719+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:31:59.719+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:31:59.729+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:59.729+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:59.739+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:59.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:59.749+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:31:59.749+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:31:59.749+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:31:59.749+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:31:59.749+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:31:59.749+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:31:59.749+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:31:59.749+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:31:59.749+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:31:59.759+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:59.769+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:31:59.769+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:31:59.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:59.809+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:59:705,0.018569,9.768138,0.868059
04-23 20:31:59.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:31:59.809+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:31:59.809+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2395079), time2(2381837)
04-23 20:31:59.809+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:31:59.809+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:31:59.809+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:31:59.809+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:31:59.849+0200 W/LOCATION( 9901): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:31:59.849+0200 I/LOCATION( 9901): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:59.849+0200 I/LOCATION( 9901): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:31:59.849+0200 I/location( 9901): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:31:59.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:31:59.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:31:59:904,0.018972,9.768234,0.866963
04-23 20:31:59.929+0200 I/LOCATION( 9901): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:31:59.979+0200 E/location( 9901): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:31:59.979+0200 W/AUL     ( 9901): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:31:59.979+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:59.979+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9901
04-23 20:31:59.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:31:59.989+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.989+0200 I/utils   ( 8242): specific action
04-23 20:31:59.989+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.989+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.989+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.989+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:31:59.989+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:31:59.989+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:31:59.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:31:59.999+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:59.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:31:59.999+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:31:59.999+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8247), cmd(0)
04-23 20:31:59.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.999+0200 I/utils   ( 8247): specific action
04-23 20:31:59.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:31:59.999+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:32:00.009+0200 I/recorder( 8247): guardando datos en local
04-23 20:32:00.009+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:32:00.009+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:32:00.009+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:32:00.009+0200 W/AUL     ( 9901): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:32:00.009+0200 I/location( 9901): request sent to service es.ugr.frailty.servicemanager
04-23 20:32:00.009+0200 W/CAPI_APPFW_APP_CONTROL( 9901): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:32:00.009+0200 I/utils   ( 9901): specific action
04-23 20:32:00.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:103,0.011301,9.762033,0.934327
04-23 20:32:00.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:32:00.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:32:00.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:32:00.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:315,0.015867,9.768741,0.861298
04-23 20:32:00.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:323,0.016283,9.768968,0.858719
04-23 20:32:00.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:345,0.016108,9.768814,0.860461
04-23 20:32:00.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:364,0.017178,9.769151,0.856616
04-23 20:32:00.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:383,0.018207,9.769499,0.852614
04-23 20:32:00.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:403,0.017715,9.769053,0.857708
04-23 20:32:00.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:424,0.018535,9.769073,0.857466
04-23 20:32:00.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:445,0.018696,9.769072,0.857479
04-23 20:32:00.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:464,0.019552,9.769742,0.849791
04-23 20:32:00.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:484,0.021260,9.770402,0.842126
04-23 20:32:00.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.499+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:503,0.023329,9.770779,0.837693
04-23 20:32:00.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:524,0.024852,9.771074,0.834188
04-23 20:32:00.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:545,0.024492,9.771085,0.834073
04-23 20:32:00.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:563,0.022786,9.770621,0.839537
04-23 20:32:00.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.579+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:585,0.023918,9.770461,0.841373
04-23 20:32:00.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:604,0.026217,9.770972,0.835347
04-23 20:32:00.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:672,0.026022,9.770822,0.837107
04-23 20:32:00.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:685,0.027530,9.771024,0.834696
04-23 20:32:00.689+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:695,0.026483,9.770782,0.837565
04-23 20:32:00.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.709+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:713,0.026730,9.770684,0.838688
04-23 20:32:00.709+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:723,0.027123,9.770711,0.838365
04-23 20:32:00.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:752,0.026885,9.770646,0.839128
04-23 20:32:00.789+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:32:00.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:805,0.026200,9.770579,0.839932
04-23 20:32:00.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.809+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:810,0.024119,9.769682,0.850360
04-23 20:32:00.809+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.809+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:816,0.025734,9.770185,0.844525
04-23 20:32:00.809+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:822,0.027278,9.770772,0.837653
04-23 20:32:00.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:828,0.027382,9.770809,0.837206
04-23 20:32:00.839+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.839+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:845,0.026805,9.770516,0.840642
04-23 20:32:00.859+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.859+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:863,0.027037,9.770504,0.840777
04-23 20:32:00.879+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.879+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:883,0.028067,9.770870,0.836480
04-23 20:32:00.899+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.899+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:904,0.028361,9.771093,0.833857
04-23 20:32:00.919+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.919+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:923,0.029095,9.771255,0.831941
04-23 20:32:00.939+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.949+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:947,0.029458,9.771288,0.831539
04-23 20:32:00.959+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.959+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:965,0.028723,9.771367,0.830626
04-23 20:32:00.979+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.979+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:00:984,0.028768,9.771367,0.830622
04-23 20:32:00.999+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:00.999+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:4,0.030710,9.771639,0.827354
04-23 20:32:01.019+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.019+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:25,0.029155,9.771430,0.829878
04-23 20:32:01.039+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.039+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:46,0.027454,9.771086,0.833975
04-23 20:32:01.059+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.059+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:65,0.026156,9.770929,0.835849
04-23 20:32:01.079+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.079+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:85,0.026769,9.771111,0.833708
04-23 20:32:01.099+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.099+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:105,0.027717,9.770917,0.835945
04-23 20:32:01.119+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.119+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:125,0.028470,9.770979,0.835187
04-23 20:32:01.139+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.139+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:146,0.028741,9.771190,0.832718
04-23 20:32:01.159+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.159+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:164,0.029008,9.771251,0.831990
04-23 20:32:01.179+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.179+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:184,0.029249,9.771236,0.832145
04-23 20:32:01.199+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.199+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:205,0.028570,9.771065,0.834178
04-23 20:32:01.219+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:32:01.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:32:01.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:32:01.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:224,0.028644,9.770870,0.836455
04-23 20:32:01.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.309+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:316,0.029809,9.771108,0.833636
04-23 20:32:01.309+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:320,0.030400,9.771038,0.834430
04-23 20:32:01.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.319+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:325,0.030238,9.771061,0.834172
04-23 20:32:01.319+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.329+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:330,0.031138,9.771093,0.833760
04-23 20:32:01.329+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.329+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:334,0.030708,9.771097,0.833731
04-23 20:32:01.339+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.339+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:345,0.029511,9.770869,0.836437
04-23 20:32:01.359+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.359+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:364,0.029617,9.770966,0.835307
04-23 20:32:01.379+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.379+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:385,0.030832,9.770986,0.835035
04-23 20:32:01.399+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.399+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:405,0.030906,9.770816,0.837009
04-23 20:32:01.419+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.419+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:424,0.032770,9.771311,0.831137
04-23 20:32:01.439+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.439+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:446,0.031957,9.771064,0.834067
04-23 20:32:01.459+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.459+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:464,0.031715,9.771207,0.832404
04-23 20:32:01.479+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.479+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:484,0.032058,9.771326,0.830988
04-23 20:32:01.499+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.509+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:505,0.032260,9.771154,0.833000
04-23 20:32:01.519+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.519+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:524,0.032236,9.771100,0.833633
04-23 20:32:01.539+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.539+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:546,0.031524,9.771089,0.833795
04-23 20:32:01.559+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.559+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:565,0.032106,9.771171,0.832812
04-23 20:32:01.569+0200 W/LOCATION( 9901): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:32:01.579+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.589+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:591,0.032200,9.771282,0.831500
04-23 20:32:01.599+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.599+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:604,0.031493,9.771142,0.833170
04-23 20:32:01.619+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.619+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:625,0.032311,9.771459,0.829421
04-23 20:32:01.639+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.639+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:645,0.031059,9.771665,0.827034
04-23 20:32:01.659+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.659+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:664,0.029057,9.771828,0.825184
04-23 20:32:01.679+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.679+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:685,0.029118,9.772342,0.819065
04-23 20:32:01.699+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.699+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:704,0.028597,9.772696,0.814846
04-23 20:32:01.719+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.719+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:724,0.028330,9.772964,0.811649
04-23 20:32:01.739+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.739+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:746,0.027952,9.773305,0.807536
04-23 20:32:01.759+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.759+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:764,0.025874,9.773444,0.805918
04-23 20:32:01.789+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:802,0.026979,9.773756,0.802091
04-23 20:32:01.799+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.799+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:809,0.025778,9.773866,0.800795
04-23 20:32:01.819+0200 I/gravity ( 9607): capturing data from es.ugr.frailty.gravity
04-23 20:32:01.819+0200 I/gravity ( 9607): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:32:01:824,0.025882,9.774248,0.796113
04-23 20:32:01.829+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11099016c6f63152450832
