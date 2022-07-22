S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10939
Date: 2018-04-23 20:36:06+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72ae52d, r5   = 0xf7784f98
r6   = 0xffc5ace0, r7   = 0xffc5ab90
r8   = 0xf7781c18, r9   = 0x00000000
r10  = 0xffc5ac6c, fp   = 0xffc5ace0
ip   = 0x00000001, sp   = 0xffc5ab68
lr   = 0xf72ae539, pc   = 0xf7317228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    136172 KB
Buffers:     37884 KB
Cached:     157880 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12180 KB
VmRSS:       12176 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10939 TID = 10939
10939 10942 

Maps Information
f4179000 f4978000 rw-p [stack:10942]
f497f000 f4981000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4989000 f498d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4996000 f4998000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49a0000 f49a3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49b2000 f49b7000 r-xp /usr/lib/libsystem.so.0.0.0
f49c2000 f49c5000 r-xp /lib/libattr.so.1.1.0
f49cd000 f49dd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49e5000 f49ee000 r-xp /usr/lib/libedbus.so.1.7.99
f49f6000 f49f7000 r-xp /usr/lib/libresponse.so.0.2.96
f4a00000 f4a05000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62a7000 f63ad000 r-xp /usr/lib/libicuuc.so.57.1
f63c3000 f654b000 r-xp /usr/lib/libicui18n.so.57.1
f655b000 f6568000 r-xp /usr/lib/libail.so.0.1.0
f6571000 f6578000 r-xp /usr/lib/libminizip.so.1.0.0
f6581000 f672a000 r-xp /usr/lib/libcrypto.so.1.0.0
f674a000 f6791000 r-xp /usr/lib/libssl.so.1.0.0
f679d000 f679f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67a7000 f67ae000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67b7000 f67be000 r-xp /lib/libcrypt-2.13.so
f67ef000 f67f2000 r-xp /lib/libcap.so.2.21
f67fa000 f67fc000 r-xp /usr/lib/libiri.so
f6804000 f684d000 r-xp /usr/lib/libmdm.so.1.2.69
f6855000 f685b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6863000 f6886000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6890000 f6892000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f689a000 f68b7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68c0000 f68c4000 r-xp /usr/lib/libsmack.so.1.0.0
f68cd000 f68e6000 r-xp /usr/lib/libnetwork.so.0.0.0
f68ef000 f68f7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68ff000 f6905000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f690e000 f6910000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6919000 f6929000 r-xp /lib/libresolv-2.13.so
f692d000 f6945000 r-xp /usr/lib/liblzma.so.5.0.3
f694e000 f6950000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6958000 f6972000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f697a000 f69a9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69b2000 f69c1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69cb000 f69d5000 r-xp /usr/lib/libsensord-shared.so
f69de000 f6ab1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6abc000 f6ad2000 r-xp /lib/libz.so.1.2.5
f6ada000 f6adf000 r-xp /usr/lib/libffi.so.5.0.10
f6ae7000 f6ae8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6af0000 f6b00000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b08000 f6b21000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b29000 f6b2b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b33000 f6ba8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bb2000 f6bb8000 r-xp /lib/librt-2.13.so
f6bc1000 f6bdf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6be9000 f6bea000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bf2000 f6c15000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c1d000 f6c22000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c2a000 f6c54000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c5d000 f6c74000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c7c000 f6ce5000 r-xp /lib/libm-2.13.so
f6cee000 f6d82000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d95000 f6d9a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6da2000 f6da9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6db1000 f6ddb000 r-xp /usr/lib/libsensor.so.1.9.6
f6de4000 f6eb0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ebd000 f6ebf000 r-xp /usr/lib/libiniparser.so.0
f6ec8000 f6ece000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ed7000 f6fa7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fa8000 f6fdc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fe5000 f7021000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7029000 f702c000 r-xp /usr/lib/libbundle.so.0.1.22
f7034000 f703a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7042000 f7083000 r-xp /usr/lib/libeina.so.1.7.99
f708c000 f70a3000 r-xp /usr/lib/libecore.so.1.7.99
f70ba000 f70c3000 r-xp /usr/lib/libvconf.so.0.2.45
f70cb000 f70df000 r-xp /lib/libpthread-2.13.so
f70ea000 f70f7000 r-xp /usr/lib/libaul.so.0.1.0
f7101000 f7103000 r-xp /lib/libdl-2.13.so
f710c000 f7117000 r-xp /lib/libunwind.so.8.0.1
f7144000 f714c000 r-xp /lib/libgcc_s-4.6.so.1
f714d000 f7271000 r-xp /lib/libc-2.13.so
f727f000 f7281000 r-xp /usr/lib/libdlog.so.0.0.0
f7289000 f7295000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f729e000 f72a3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72ab000 f72ba000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72c2000 f72c6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72cf000 f72d2000 r-xp /usr/lib/libappcore-agent.so.1.1
f72da000 f72dc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72e4000 f72e8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72f0000 f730d000 r-xp /lib/ld-2.13.so
f7316000 f7319000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7319000 f731d000 r-xp /usr/lib/libsys-assert.so
f7751000 f77b3000 rw-p [heap]
ffc3c000 ffc5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10939)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7317228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72ae539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fb53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fb3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fbfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fc5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fc5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ffa75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ff51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fb3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fbfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fc5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fc5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ff7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ff8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ffff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49971fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf498a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a5d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f0afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f0c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf709cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7097b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70985a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7098879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72d0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72d07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf731753f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf716485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7316f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
gravity: SM-R760,23/04/2018,20:35:56:113,0.039519,9.770316,0.842465
04-23 20:35:56.129+0200 W/AUL     (10903): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:35:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:35:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:35:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10856
04-23 20:35:56.129+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:35:56.129+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10856
04-23 20:35:56.129+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10856)
04-23 20:35:56.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:56.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:56:314,0.043279,9.771617,0.827046
04-23 20:35:56.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:56.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:56:515,0.042687,9.772044,0.822015
04-23 20:35:56.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:56.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:56:717,0.047159,9.772966,0.810735
04-23 20:35:56.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:56.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:56:923,0.052464,9.773450,0.804556
04-23 20:35:57.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:57.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:57:116,0.055966,9.772190,0.819489
04-23 20:35:57.219+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:35:57.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:57.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:57:316,0.051949,9.772565,0.815269
04-23 20:35:57.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:57.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:57:516,0.043165,9.771182,0.832174
04-23 20:35:57.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:57.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:57:717,0.031309,9.769797,0.848798
04-23 20:35:57.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:57.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:57:917,0.045714,9.771467,0.828685
04-23 20:35:58.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:58.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:58:117,0.046671,9.772161,0.820408
04-23 20:35:58.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:58.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:58:316,0.044110,9.772309,0.818787
04-23 20:35:58.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:58.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:58:517,0.043212,9.771173,0.832277
04-23 20:35:58.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:58.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:58:716,0.044573,9.774749,0.789109
04-23 20:35:58.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:58.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:58:916,0.038946,9.775133,0.784632
04-23 20:35:59.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:59.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:59:117,0.033415,9.773451,0.805561
04-23 20:35:59.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:59.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:59:317,0.030464,9.772297,0.819559
04-23 20:35:59.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:59.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:59:517,0.026069,9.771474,0.829456
04-23 20:35:59.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:59.709+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:59:718,0.022399,9.769935,0.847504
04-23 20:35:59.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:35:59.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:35:59:917,0.016816,9.766288,0.888663
04-23 20:36:00.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:00.109+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:00:118,0.038660,9.770778,0.837138
04-23 20:36:00.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:00.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:00:319,0.052162,9.770719,0.837097
04-23 20:36:00.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:00.509+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:00:518,0.056424,9.770726,0.836725
04-23 20:36:00.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:00.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:00:720,0.049789,9.770341,0.841633
04-23 20:36:00.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:00.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:00:920,0.037292,9.770163,0.844344
04-23 20:36:01.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:01.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:01:122,0.045021,9.771416,0.829334
04-23 20:36:01.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:01.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:01:321,0.039051,9.770282,0.842879
04-23 20:36:01.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:01.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:01:519,0.049311,9.770637,0.838216
04-23 20:36:01.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:01.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:01:720,0.055358,9.771066,0.832819
04-23 20:36:01.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:01.929+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:01:921,0.045880,9.770643,0.838341
04-23 20:36:02.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:02.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:02:119,0.052326,9.771927,0.822855
04-23 20:36:02.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:02.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:02:319,0.046938,9.772205,0.819867
04-23 20:36:02.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:02.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:02:520,0.047370,9.772608,0.815031
04-23 20:36:02.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:02.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:02:721,0.048451,9.772555,0.815595
04-23 20:36:02.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:02.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:02:921,0.037341,9.771292,0.831171
04-23 20:36:03.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:03.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:03:120,0.040261,9.771875,0.824148
04-23 20:36:03.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:03.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:03:321,0.032575,9.771976,0.823286
04-23 20:36:03.509+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:03.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:03:520,0.048856,9.772366,0.817849
04-23 20:36:03.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:03.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:03:721,0.052677,9.772252,0.818958
04-23 20:36:03.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:03.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:03:922,0.044953,9.771407,0.829433
04-23 20:36:04.109+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:04.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:04:121,0.044607,9.772174,0.820372
04-23 20:36:04.309+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:04.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:04:322,0.041184,9.771977,0.822892
04-23 20:36:04.389+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:36:04.389+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:36:04.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:04.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:04.419+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:36:04.419+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10939
04-23 20:36:04.469+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10939
04-23 20:36:04.469+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10939) type(svcapp) bg(0)
04-23 20:36:04.479+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10939]
04-23 20:36:04.509+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:04.519+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10939
04-23 20:36:04.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:04.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:04.519+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10939)
04-23 20:36:04.519+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:36:04.519+0200 I/servicemanager(10115): App control destroyed.
04-23 20:36:04.529+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:04:530,0.032565,9.771018,0.834582
04-23 20:36:04.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:36:04.539+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10939
04-23 20:36:04.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:36:04.559+0200 E/CAPI_APPFW_APPLICATION(10939): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:04.559+0200 E/CAPI_APPFW_APPLICATION(10939): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:36:04.559+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10939) was created
04-23 20:36:04.589+0200 W/LOCATION(10939): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:36:04.589+0200 E/LOCATION(10939): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:36:04.589+0200 E/PKGMGR_INFO(10939): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:36:04.589+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:04.609+0200 I/LOCATION(10939): location.c: location_new(269) > method: 0
04-23 20:36:04.609+0200 W/LOCATION(10939): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:04.609+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:04.619+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:04.619+0200 W/LOCATION(10939): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:04.619+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:04.629+0200 W/LOCATION(10939): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:04.629+0200 W/LOCATION(10939): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:04.629+0200 W/LOCATION(10939): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:04.629+0200 W/LOCATION(10939): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:04.649+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:04.649+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:36:04.649+0200 W/LOCATION(10939): module-internal.c: module_new(311) > module (wps) open success
04-23 20:36:04.659+0200 W/LOCATION(10939): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:36:04.659+0200 W/LOCATION(10939): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:36:04.659+0200 W/LOCATION(10939): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:04.659+0200 W/LOCATION(10939): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:04.679+0200 W/LOCATION(10939): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:36:04.679+0200 I/LOCATION(10939): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7781c18
04-23 20:36:04.679+0200 I/LOCATION(10939): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:36:04.679+0200 I/LOCATION(10939): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7781c18
04-23 20:36:04.679+0200 I/LOCATION(10939): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:36:04.679+0200 I/location(10939): es.ugr.frailty.location: creado servicio de localización
04-23 20:36:04.709+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:04.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:04:722,0.038666,9.771047,0.833989
04-23 20:36:04.729+0200 I/LOCATION(10939): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:36:04.759+0200 W/LOCATION(10939): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:04.759+0200 W/LOCATION(10939): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:04.759+0200 I/LOCATION(10939): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:04.819+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:36:04.829+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:36:04.829+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:36:04.829+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:04.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:36:04.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:36:04.829+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:36:04.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:36:04.829+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:36:04.829+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:36:04.829+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:36:04.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:36:04.869+0200 W/LOCATION(10939): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:36:04.869+0200 W/LOCATION(10939): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:36:04.909+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:04.919+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:04:922,0.031550,9.770289,0.843105
04-23 20:36:04.939+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:04.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf72e54e8]
04-23 20:36:04.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:36:04.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:36:04.979+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:36:04.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:36:04.999+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:04.999+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:05.009+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:05.019+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:05.019+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:36:05.019+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:36:05.019+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:36:05.019+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:36:05.019+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:36:05.019+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:36:05.019+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:36:05.019+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:36:05.019+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:36:05.029+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:05.039+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:36:05.039+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:36:05.039+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:05.059+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:36:05.059+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2640323), time2(2626993)
04-23 20:36:05.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:36:05.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:36:05.059+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:36:05.059+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:36:05.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:05.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:05.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:05.119+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.119+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:36:05.129+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:124,0.041968,9.770779,0.836963
04-23 20:36:05.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:144,0.042296,9.770733,0.837484
04-23 20:36:05.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.169+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:166,0.042258,9.770788,0.836839
04-23 20:36:05.169+0200 W/LOCATION(10939): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:36:05.169+0200 I/LOCATION(10939): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:05.169+0200 I/LOCATION(10939): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:36:05.169+0200 I/location(10939): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:36:05.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.189+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:192,0.042902,9.770765,0.837075
04-23 20:36:05.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.209+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:213,0.042377,9.770785,0.836861
04-23 20:36:05.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:224,0.041896,9.770598,0.839063
04-23 20:36:05.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.239+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:244,0.041428,9.770502,0.840212
04-23 20:36:05.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:268,0.040976,9.770636,0.838682
04-23 20:36:05.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:286,0.040460,9.770406,0.841375
04-23 20:36:05.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.299+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:305,0.040613,9.770451,0.840852
04-23 20:36:05.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.319+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:324,0.039261,9.770462,0.840783
04-23 20:36:05.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.339+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:343,0.039588,9.770350,0.842070
04-23 20:36:05.339+0200 I/LOCATION(10939): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:36:05.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.359+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:365,0.040727,9.770623,0.838836
04-23 20:36:05.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:385,0.039166,9.770461,0.840794
04-23 20:36:05.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.399+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:403,0.040075,9.770628,0.838814
04-23 20:36:05.399+0200 W/AUL     (10939): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:36:05.399+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:05.409+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10939
04-23 20:36:05.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:36:05.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.419+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:05.419+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:36:05.419+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.419+0200 I/utils   (10115): specific action
04-23 20:36:05.419+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.419+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.419+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.419+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:36:05.419+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:36:05.419+0200 W/AUL     (10939): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:36:05.419+0200 I/location(10939): request sent to service es.ugr.frailty.servicemanager
04-23 20:36:05.419+0200 I/location(10939): es.ugr.frailty.location: SM-R760,23/04/2018,20:36:05:407,nan,37.171668,-3.594166,0.000000,0,0.000000,44.000000,-1.000000
04-23 20:36:05.419+0200 W/CAPI_APPFW_APP_CONTROL(10939): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.419+0200 I/utils   (10939): specific action
04-23 20:36:05.419+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:36:05.429+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:425,0.041508,9.770869,0.835933
04-23 20:36:05.429+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:36:05.429+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.429+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:36:05.429+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:36:05.429+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:36:05.429+0200 I/utils   (10120): specific action
04-23 20:36:05.429+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.429+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.429+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.429+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:36:05.429+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:36:05.429+0200 I/recorder(10120): guardando datos en local
04-23 20:36:05.429+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:36:05.429+0200 I/servicemanager(10115): requesting to save local data
04-23 20:36:05.439+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.439+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:443,0.040589,9.770695,0.838005
04-23 20:36:05.459+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.459+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:465,0.040511,9.770572,0.839442
04-23 20:36:05.479+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:484,0.037061,9.770092,0.845171
04-23 20:36:05.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:504,0.036587,9.769917,0.847215
04-23 20:36:05.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:524,0.036472,9.769934,0.847018
04-23 20:36:05.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:544,0.035444,9.769858,0.847941
04-23 20:36:05.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.569+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:568,0.037317,9.770032,0.845848
04-23 20:36:05.579+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:583,0.038127,9.770145,0.844509
04-23 20:36:05.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.609+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:607,0.038952,9.770066,0.845383
04-23 20:36:05.619+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.619+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:624,0.037445,9.770061,0.845521
04-23 20:36:05.639+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:644,0.036028,9.769920,0.847197
04-23 20:36:05.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.669+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:667,0.037405,9.770014,0.846063
04-23 20:36:05.679+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:684,0.038026,9.769818,0.848285
04-23 20:36:05.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:705,0.037963,9.769902,0.847320
04-23 20:36:05.719+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.729+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:727,0.037779,9.769905,0.847298
04-23 20:36:05.739+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.739+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:744,0.038527,9.769915,0.847150
04-23 20:36:05.759+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.769+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:766,0.039808,9.770135,0.844548
04-23 20:36:05.779+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:784,0.039537,9.770224,0.843531
04-23 20:36:05.799+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.799+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:803,0.038828,9.770107,0.844909
04-23 20:36:05.819+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:824,0.039548,9.769976,0.846397
04-23 20:36:05.839+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.839+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:846,0.038617,9.769814,0.848318
04-23 20:36:05.859+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.869+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:867,0.037818,9.769854,0.847889
04-23 20:36:05.879+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.879+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:884,0.038779,9.770056,0.845513
04-23 20:36:05.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.909+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:907,0.039257,9.770177,0.844093
04-23 20:36:05.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.929+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:927,0.039747,9.770025,0.845824
04-23 20:36:05.939+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.949+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:945,0.040849,9.770072,0.845229
04-23 20:36:05.989+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:05.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:05:999,0.041680,9.770312,0.842404
04-23 20:36:05.999+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.009+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:9,0.043025,9.770380,0.841551
04-23 20:36:06.009+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.029+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:21,0.042250,9.770413,0.841204
04-23 20:36:06.029+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.039+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:37,0.041322,9.770266,0.842968
04-23 20:36:06.039+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.059+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:54,0.041578,9.770092,0.844964
04-23 20:36:06.059+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:06.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:06.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:06.089+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:67,0.043623,9.770478,0.840381
04-23 20:36:06.089+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.089+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:95,0.041466,9.770289,0.842677
04-23 20:36:06.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:105,0.041919,9.770470,0.840564
04-23 20:36:06.129+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.129+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:133,0.042225,9.770538,0.839747
04-23 20:36:06.139+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.139+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:145,0.043542,9.770610,0.838851
04-23 20:36:06.159+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.159+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:165,0.044903,9.770589,0.839023
04-23 20:36:06.169+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:36:06.179+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.179+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:186,0.045071,9.770638,0.838433
04-23 20:36:06.199+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.199+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:204,0.044331,9.770513,0.839946
04-23 20:36:06.219+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.219+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:226,0.043394,9.770296,0.842502
04-23 20:36:06.239+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.249+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:247,0.044315,9.770323,0.842146
04-23 20:36:06.259+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.269+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:267,0.045315,9.770465,0.840447
04-23 20:36:06.279+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.289+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:289,0.046753,9.770371,0.841456
04-23 20:36:06.299+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.309+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:307,0.046373,9.770441,0.840665
04-23 20:36:06.319+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.329+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:326,0.045113,9.770316,0.842184
04-23 20:36:06.339+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.339+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:345,0.045718,9.770355,0.841698
04-23 20:36:06.359+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.369+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:368,0.045287,9.770309,0.842246
04-23 20:36:06.379+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.379+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:385,0.046100,9.770216,0.843287
04-23 20:36:06.399+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.409+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:406,0.045201,9.770065,0.845085
04-23 20:36:06.419+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.429+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:425,0.044545,9.770106,0.844645
04-23 20:36:06.439+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.449+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:445,0.042656,9.770082,0.845033
04-23 20:36:06.459+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.469+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:465,0.042474,9.770083,0.845013
04-23 20:36:06.479+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.479+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:485,0.041842,9.770088,0.844988
04-23 20:36:06.499+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.499+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:504,0.043825,9.770089,0.844879
04-23 20:36:06.519+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.519+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:524,0.042474,9.769956,0.846496
04-23 20:36:06.539+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.539+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:544,0.043688,9.770095,0.844826
04-23 20:36:06.559+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.559+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:566,0.043368,9.770099,0.844790
04-23 20:36:06.579+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.579+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:584,0.044426,9.770359,0.841727
04-23 20:36:06.599+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.599+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:604,0.045310,9.770460,0.840501
04-23 20:36:06.619+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.629+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:627,0.044782,9.770373,0.841532
04-23 20:36:06.639+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.639+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:644,0.046110,9.770485,0.840169
04-23 20:36:06.659+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.659+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:666,0.046218,9.770375,0.841438
04-23 20:36:06.679+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.679+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:685,0.045871,9.770277,0.842592
04-23 20:36:06.699+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.699+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:704,0.045891,9.770512,0.839875
04-23 20:36:06.719+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.719+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:725,0.044310,9.770396,0.841296
04-23 20:36:06.739+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.739+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:745,0.042812,9.770227,0.843328
04-23 20:36:06.759+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.769+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:767,0.042279,9.770277,0.842787
04-23 20:36:06.779+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.779+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:785,0.041230,9.770026,0.845739
04-23 20:36:06.799+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.809+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:807,0.040542,9.770054,0.845449
04-23 20:36:06.819+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.819+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:825,0.040575,9.770127,0.844598
04-23 20:36:06.839+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.839+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:844,0.039252,9.769897,0.847325
04-23 20:36:06.859+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.869+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:869,0.039350,9.769867,0.847663
04-23 20:36:06.879+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.879+0200 W/LOCATION(10939): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:36:06.889+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:885,0.040008,9.769865,0.847657
04-23 20:36:06.899+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.899+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:904,0.041581,9.769729,0.849149
04-23 20:36:06.919+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.929+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:925,0.041341,9.769807,0.848260
04-23 20:36:06.939+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.949+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:947,0.042722,9.770081,0.845037
04-23 20:36:06.959+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.959+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:966,0.042980,9.770058,0.845286
04-23 20:36:06.979+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.979+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:06:984,0.044750,9.770448,0.840668
04-23 20:36:06.999+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:06.999+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:4,0.043437,9.770373,0.841609
04-23 20:36:07.019+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.019+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:25,0.042419,9.770329,0.842172
04-23 20:36:07.049+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.049+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:53,0.042255,9.770167,0.844059
04-23 20:36:07.059+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:36:07.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:36:07.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:36:07.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:78,0.041295,9.770130,0.844527
04-23 20:36:07.079+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.079+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:85,0.040959,9.769987,0.846199
04-23 20:36:07.099+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.099+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:105,0.041419,9.769981,0.846242
04-23 20:36:07.119+0200 I/gravity (10862): capturing data from es.ugr.frailty.gravity
04-23 20:36:07.119+0200 I/gravity (10862): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:36:07:124,0.041206,9.769916,0.847012
04-23 20:36:07.129+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11109396c6f63152450856
