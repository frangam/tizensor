S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19196
Date: 2018-06-07 17:16:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf733e52d, r5   = 0xf7551f98
r6   = 0xff94ba50, r7   = 0xff94b900
r8   = 0xf754ec18, r9   = 0x00000000
r10  = 0xff94b9dc, fp   = 0xff94ba50
ip   = 0x00000001, sp   = 0xff94b8d8
lr   = 0xf733e539, pc   = 0xf73a7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    149572 KB
Buffers:      8740 KB
Cached:      54556 KB
VmPeak:      53488 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11308 KB
VmRSS:       11308 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19196 TID = 19196
19196 19235 

Maps Information
f4209000 f4a08000 rw-p [stack:19235]
f4a0f000 f4a11000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a19000 f4a1d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a26000 f4a28000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a30000 f4a33000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a42000 f4a47000 r-xp /usr/lib/libsystem.so.0.0.0
f4a52000 f4a55000 r-xp /lib/libattr.so.1.1.0
f4a5d000 f4a6d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a75000 f4a7e000 r-xp /usr/lib/libedbus.so.1.7.99
f4a86000 f4a87000 r-xp /usr/lib/libresponse.so.0.2.96
f4a90000 f4a95000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6337000 f643d000 r-xp /usr/lib/libicuuc.so.57.1
f6453000 f65db000 r-xp /usr/lib/libicui18n.so.57.1
f65eb000 f65f8000 r-xp /usr/lib/libail.so.0.1.0
f6601000 f6608000 r-xp /usr/lib/libminizip.so.1.0.0
f6611000 f67ba000 r-xp /usr/lib/libcrypto.so.1.0.0
f67da000 f6821000 r-xp /usr/lib/libssl.so.1.0.0
f682d000 f682f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6837000 f683e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6847000 f684e000 r-xp /lib/libcrypt-2.13.so
f687f000 f6882000 r-xp /lib/libcap.so.2.21
f688a000 f688c000 r-xp /usr/lib/libiri.so
f6894000 f68dd000 r-xp /usr/lib/libmdm.so.1.2.69
f68e5000 f68eb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68f3000 f6916000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6920000 f6922000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f692a000 f6947000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6950000 f6954000 r-xp /usr/lib/libsmack.so.1.0.0
f695d000 f6976000 r-xp /usr/lib/libnetwork.so.0.0.0
f697f000 f6987000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f698f000 f6995000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f699e000 f69a0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69a9000 f69b9000 r-xp /lib/libresolv-2.13.so
f69bd000 f69d5000 r-xp /usr/lib/liblzma.so.5.0.3
f69de000 f69e0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69e8000 f6a02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a0a000 f6a39000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a42000 f6a51000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a5b000 f6a65000 r-xp /usr/lib/libsensord-shared.so
f6a6e000 f6b41000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b4c000 f6b62000 r-xp /lib/libz.so.1.2.5
f6b6a000 f6b6f000 r-xp /usr/lib/libffi.so.5.0.10
f6b77000 f6b78000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b80000 f6b90000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b98000 f6bb1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bb9000 f6bbb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bc3000 f6c38000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c42000 f6c48000 r-xp /lib/librt-2.13.so
f6c51000 f6c6f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c79000 f6c7a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c82000 f6ca5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cad000 f6cb2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cba000 f6ce4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ced000 f6d04000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d0c000 f6d75000 r-xp /lib/libm-2.13.so
f6d7e000 f6e12000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e25000 f6e2a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e32000 f6e39000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e41000 f6e6b000 r-xp /usr/lib/libsensor.so.1.9.6
f6e74000 f6f40000 r-xp /usr/lib/libxml2.so.2.7.8
f6f4d000 f6f4f000 r-xp /usr/lib/libiniparser.so.0
f6f58000 f6f5e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f67000 f7037000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7038000 f706c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7075000 f70b1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70b9000 f70bc000 r-xp /usr/lib/libbundle.so.0.1.22
f70c4000 f70ca000 r-xp /usr/lib/libappsvc.so.0.1.0
f70d2000 f7113000 r-xp /usr/lib/libeina.so.1.7.99
f711c000 f7133000 r-xp /usr/lib/libecore.so.1.7.99
f714a000 f7153000 r-xp /usr/lib/libvconf.so.0.2.45
f715b000 f716f000 r-xp /lib/libpthread-2.13.so
f717a000 f7187000 r-xp /usr/lib/libaul.so.0.1.0
f7191000 f7193000 r-xp /lib/libdl-2.13.so
f719c000 f71a7000 r-xp /lib/libunwind.so.8.0.1
f71d4000 f71dc000 r-xp /lib/libgcc_s-4.6.so.1
f71dd000 f7301000 r-xp /lib/libc-2.13.so
f730f000 f7311000 r-xp /usr/lib/libdlog.so.0.0.0
f7319000 f7325000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f732e000 f7333000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f733b000 f734a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7352000 f7356000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f735f000 f7362000 r-xp /usr/lib/libappcore-agent.so.1.1
f736a000 f736c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7374000 f7378000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7380000 f739d000 r-xp /lib/ld-2.13.so
f73a6000 f73a9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73a9000 f73ad000 r-xp /usr/lib/libsys-assert.so
f751e000 f7587000 rw-p [heap]
ff92d000 ff94e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19196)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73a7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf733e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70453f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7043c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf704fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7055be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7055dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf708a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70851f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7043c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf704fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7055be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7055dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7087e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7088017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf708ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a271fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a1a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6aed663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f9afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f9c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf712cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7127b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71285a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7128879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7360183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73607fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73a75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71f485c) [/lib/libc.so.6] + 0x1785c
29: (0xf73a6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ring data
06-07 17:16:47.481+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:486,0.082875,0.086765,0.078478
06-07 17:16:47.481+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.481+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:488,0.303475,-0.092744,9.801515
06-07 17:16:47.481+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.481+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:491,-0.069635,-0.063401,0.052175
06-07 17:16:47.491+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:494,0.303354,-0.091521,9.801530
06-07 17:16:47.491+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.501+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:503,0.304762,-0.091551,9.801486
06-07 17:16:47.501+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.511+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:511,0.306524,-0.087346,9.801469
06-07 17:16:47.511+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:47.531+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:47.531+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:518,0.301541,-0.090019,9.801600
06-07 17:16:47.531+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.541+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:545,-0.012009,-0.032015,0.056829
06-07 17:16:47.541+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.541+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.551+0200 W/AUL     (19267): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
06-07 17:16:47.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:16:47.561+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:16:47.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 18781
06-07 17:16:47.561+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:16:47.561+0200 E/AUL     (19267): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:16:47.561+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18781
06-07 17:16:47.561+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18781)
06-07 17:16:47.571+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:551,-0.003441,-0.035640,0.040048
06-07 17:16:47.571+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.571+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:555,0.300151,-0.091179,9.801632
06-07 17:16:47.571+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:578,0.018997,0.027898,0.066354
06-07 17:16:47.581+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.581+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:590,0.045205,0.009606,0.102236
06-07 17:16:47.581+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.591+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.591+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:595,0.223714,0.121268,0.047222
06-07 17:16:47.591+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:596,0.299249,-0.092504,9.801646
06-07 17:16:47.591+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.591+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.591+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:600,-0.152484,-0.189985,0.042556
06-07 17:16:47.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.601+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:603,0.299361,-0.090962,9.801658
06-07 17:16:47.601+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:606,-0.025360,-0.070972,0.037621
06-07 17:16:47.601+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:609,0.300314,-0.090161,9.801636
06-07 17:16:47.601+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.611+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:615,0.305625,-0.085189,9.801517
06-07 17:16:47.611+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.611+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:620,0.298142,-0.094133,9.801665
06-07 17:16:47.621+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:623,0.012411,0.032608,0.035201
06-07 17:16:47.621+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:627,0.296263,-0.097215,9.801692
06-07 17:16:47.621+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.631+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:632,0.295834,-0.095302,9.801723
06-07 17:16:47.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:47.631+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:47.641+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:47.641+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.641+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:47:646,1238.000000
06-07 17:16:47.641+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.641+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:649,0.027197,0.006768,0.063885
06-07 17:16:47.651+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:652,0.296123,-0.094617,9.801722
06-07 17:16:47.651+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.651+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.661+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:663,-0.001806,-0.025024,0.051922
06-07 17:16:47.661+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:663,0.295411,-0.095467,9.801735
06-07 17:16:47.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:47.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:47.671+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.671+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:682,0.034798,-0.016995,0.008839
06-07 17:16:47.681+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:682,0.296639,-0.096111,9.801691
06-07 17:16:47.691+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.691+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.701+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:704,0.000071,0.002790,0.044774
06-07 17:16:47.701+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:704,0.296125,-0.095797,9.801710
06-07 17:16:47.711+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.711+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.721+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:724,0.022120,0.012048,0.023219
06-07 17:16:47.721+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:724,0.296040,-0.094866,9.801722
06-07 17:16:47.731+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.731+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:47.741+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:744,0.297716,-0.090359,9.801713
06-07 17:16:47.751+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:744,0.079634,0.092473,0.025600
06-07 17:16:47.751+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.761+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:47.761+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:764,0.015744,0.018574,0.066287
06-07 17:16:47.771+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:770,0.297616,-0.089112,9.801728
06-07 17:16:47.771+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.771+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.781+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:785,0.025415,0.010149,0.039951
06-07 17:16:47.791+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:784,0.297999,-0.088288,9.801723
06-07 17:16:47.791+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.791+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.801+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:803,0.298028,-0.088864,9.801718
06-07 17:16:47.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:809,0.013068,-0.019389,0.023206
06-07 17:16:47.811+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.821+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:823,0.298633,-0.087369,9.801713
06-07 17:16:47.821+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:826,0.036968,0.024258,0.044747
06-07 17:16:47.831+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.831+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.831+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:47.841+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:47:844,1240.000000
06-07 17:16:47.841+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:844,0.024398,0.001228,0.051930
06-07 17:16:47.851+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:852,0.298736,-0.086812,9.801714
06-07 17:16:47.851+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.851+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:47.861+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:864,0.298647,-0.087209,9.801714
06-07 17:16:47.871+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:47.871+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:47.871+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:47.881+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:864,0.014723,-0.016079,0.028001
06-07 17:16:47.881+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:883,0.297896,-0.087879,9.801730
06-07 17:16:47.891+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.891+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.901+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:898,0.005242,-0.025254,0.047144
06-07 17:16:47.901+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.901+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:903,0.299732,-0.088262,9.801671
06-07 17:16:47.911+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:911,0.053849,-0.015012,0.020807
06-07 17:16:47.911+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.911+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.921+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:924,0.032871,0.052369,0.061544
06-07 17:16:47.921+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:924,0.299971,-0.085427,9.801689
06-07 17:16:47.931+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.931+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.941+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:945,0.298913,-0.085355,9.801722
06-07 17:16:47.941+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:943,-0.008047,-0.005500,0.020848
06-07 17:16:47.951+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.951+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.961+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:964,0.040867,0.025534,0.056707
06-07 17:16:47.961+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:964,0.299614,-0.083806,9.801714
06-07 17:16:47.971+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:47.971+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:47.981+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:47:983,0.030596,0.014414,0.016037
06-07 17:16:47.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:47.991+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:47:983,0.299754,-0.082627,9.801720
06-07 17:16:47.991+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.001+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.001+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.001+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:4,-0.000651,0.006057,0.083031
06-07 17:16:48.011+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:11,0.298746,-0.081950,9.801756
06-07 17:16:48.011+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.011+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.021+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:23,0.298972,-0.083994,9.801732
06-07 17:16:48.021+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:24,0.019499,-0.054441,0.006424
06-07 17:16:48.031+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:48.031+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.041+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:48:44,1243.000000
06-07 17:16:48.041+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.041+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:45,0.297468,-0.082675,9.801788
06-07 17:16:48.051+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.061+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:48.061+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:48.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:16:48.071+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:52,-0.011833,0.019387,0.063876
06-07 17:16:48.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:16:48.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:16:48.071+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:64,0.297557,-0.083450,9.801780
06-07 17:16:48.081+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.081+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.081+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:86,0.296933,-0.084189,9.801792
06-07 17:16:48.081+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:86,0.023170,-0.027395,0.035105
06-07 17:16:48.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.091+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.091+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:97,0.008724,-0.026620,0.049472
06-07 17:16:48.101+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.101+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.111+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:109,-0.002616,-0.013917,0.030316
06-07 17:16:48.121+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:103,0.296133,-0.084521,9.801813
06-07 17:16:48.121+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.121+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.131+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:132,0.007756,-0.008799,0.027902
06-07 17:16:48.131+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.141+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:137,0.295652,-0.084581,9.801827
06-07 17:16:48.141+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.141+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:144,0.060878,0.003225,0.066173
06-07 17:16:48.151+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.161+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:165,0.025689,-0.016400,0.042292
06-07 17:16:48.161+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:156,0.297342,-0.084099,9.801781
06-07 17:16:48.171+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.181+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:178,0.297971,-0.084661,9.801757
06-07 17:16:48.181+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.181+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:189,0.039417,-0.008659,0.013601
06-07 17:16:48.191+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:189,0.298835,-0.084598,9.801731
06-07 17:16:48.191+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.201+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.201+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:202,0.299220,-0.082161,9.801740
06-07 17:16:48.201+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:206,0.043339,0.041528,0.059092
06-07 17:16:48.211+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.211+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.221+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:224,-0.014474,0.012769,0.066260
06-07 17:16:48.221+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:224,0.297584,-0.081167,9.801798
06-07 17:16:48.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.231+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:48.241+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.241+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.251+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.251+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:252,0.294889,-0.080535,9.801885
06-07 17:16:48.251+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:48:245,1243.000000
06-07 17:16:48.251+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.261+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:256,-0.046337,0.009382,0.047060
06-07 17:16:48.261+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:48.261+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:48.261+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:264,0.295387,-0.082775,9.801851
06-07 17:16:48.261+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:273,0.018571,-0.053463,0.116364
06-07 17:16:48.271+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.271+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.281+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:284,0.018073,-0.017724,0.058971
06-07 17:16:48.281+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:283,0.295537,-0.083262,9.801842
06-07 17:16:48.291+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.291+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.301+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:303,0.003566,-0.038772,0.082909
06-07 17:16:48.311+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.311+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:303,0.295096,-0.084733,9.801843
06-07 17:16:48.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.361+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.431+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:48.461+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:48.461+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:48.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.471+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.481+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.491+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:324,0.015971,0.000984,0.035050
06-07 17:16:48.501+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:48:471,1246.000000
06-07 17:16:48.501+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.501+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:493,0.294827,-0.084197,9.801855
06-07 17:16:48.511+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.521+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:514,0.001883,-0.009123,0.037431
06-07 17:16:48.521+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.531+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:522,0.294211,-0.084293,9.801873
06-07 17:16:48.531+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.551+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:539,0.047963,-0.001849,0.046985
06-07 17:16:48.551+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.551+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:548,0.295595,-0.084059,9.801833
06-07 17:16:48.561+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.571+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:561,0.013079,0.026631,-0.008010
06-07 17:16:48.571+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:572,0.294979,-0.082287,9.801867
06-07 17:16:48.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.581+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.591+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.591+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.591+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:590,0.295129,-0.082781,9.801859
06-07 17:16:48.591+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.591+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:598,0.020873,-0.018211,0.046990
06-07 17:16:48.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:606,-0.039097,-0.012932,0.058964
06-07 17:16:48.601+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.601+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:604,0.291632,-0.082755,9.801964
06-07 17:16:48.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:611,0.026614,0.008577,0.034929
06-07 17:16:48.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.611+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:618,0.045512,-0.011323,0.039717
06-07 17:16:48.611+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:625,0.025152,-0.008748,0.078039
06-07 17:16:48.621+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.631+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:621,0.291876,-0.081997,9.801963
06-07 17:16:48.631+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:48.641+0200 W/LOCATION(19196): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:16:48.641+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.641+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:649,0.293093,-0.082179,9.801925
06-07 17:16:48.641+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:48:645,1248.000000
06-07 17:16:48.651+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.651+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:656,0.293324,-0.082217,9.801917
06-07 17:16:48.651+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.651+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:631,0.036886,0.010432,0.046941
06-07 17:16:48.651+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.661+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:663,0.293966,-0.081379,9.801906
06-07 17:16:48.661+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:665,0.031458,-0.043047,0.046952
06-07 17:16:48.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:48.661+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:48.661+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.671+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:672,0.294845,-0.083015,9.801865
06-07 17:16:48.671+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.671+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.671+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:677,0.018615,-0.060554,0.085279
06-07 17:16:48.671+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:678,0.295208,-0.085438,9.801833
06-07 17:16:48.671+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.681+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.681+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:686,0.295400,-0.085131,9.801830
06-07 17:16:48.681+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:16:48.681+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:16:48.681+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.681+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.681+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.691+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.691+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.691+0200 E/servicemanager(17973): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:16:48.691+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.691+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:16:48.691+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:16:48.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.691+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:693,0.293101,-0.085423,9.801897
06-07 17:16:48.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.691+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.701+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:702,0.292060,-0.085580,9.801927
06-07 17:16:48.701+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.701+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.711+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:709,0.291954,-0.087488,9.801912
06-07 17:16:48.711+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.711+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.711+0200 E/servicemanager(17973): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:16:48.711+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.711+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:16:48.711+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:16:48.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.711+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.711+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.721+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.721+0200 E/servicemanager(17973): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:16:48.721+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.721+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:16:48.721+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:16:48.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.721+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.721+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:721,0.292351,-0.087110,9.801905
06-07 17:16:48.721+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.721+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.721+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.721+0200 E/servicemanager(17973): es.ugr.frailty.location launch request sending failed!
06-07 17:16:48.721+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.721+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:16:48.721+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:16:48.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.721+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.731+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.731+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.731+0200 E/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:16:48.731+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.731+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:16:48.731+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:16:48.731+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:731,0.294322,-0.087033,9.801846
06-07 17:16:48.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.731+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.731+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.731+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.731+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.731+0200 E/servicemanager(17973): es.ugr.frailty.gravity launch request sending failed!
06-07 17:16:48.731+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.731+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:16:48.731+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:16:48.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.741+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:740,0.295382,-0.087982,9.801805
06-07 17:16:48.741+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.741+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.741+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.741+0200 E/servicemanager(17973): es.ugr.frailty.pressure launch request sending failed!
06-07 17:16:48.741+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.741+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:16:48.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:16:48.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.741+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.741+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.741+0200 E/servicemanager(17973): es.ugr.frailty.light launch request sending failed!
06-07 17:16:48.741+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.741+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:16:48.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:16:48.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:48.741+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:749,0.295993,-0.087473,9.801792
06-07 17:16:48.741+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:48.751+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.751+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:16:48.751+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:16:48.751+0200 E/servicemanager(17973): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:16:48.751+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:48.751+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:757,0.295916,-0.089120,9.801779
06-07 17:16:48.751+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:687,0.020645,-0.000704,0.047025
06-07 17:16:48.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.761+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:763,0.296568,-0.089126,9.801760
06-07 17:16:48.761+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:767,-0.029796,-0.012975,0.032671
06-07 17:16:48.761+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.761+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:770,0.296793,-0.090995,9.801736
06-07 17:16:48.771+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:772,-0.008355,-0.007897,0.068497
06-07 17:16:48.771+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.781+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:783,0.295233,-0.089705,9.801794
06-07 17:16:48.781+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.781+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:790,0.019007,-0.055597,0.051717
06-07 17:16:48.791+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.791+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.801+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:803,0.295604,-0.090010,9.801781
06-07 17:16:48.801+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:796,0.035862,-0.003440,0.116337
06-07 17:16:48.801+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:813,0.068966,-0.008603,0.044560
06-07 17:16:48.811+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.811+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.821+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.821+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:824,0.295891,-0.089954,9.801772
06-07 17:16:48.821+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:819,0.023923,-0.018251,0.044620
06-07 17:16:48.821+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.831+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:834,0.027649,0.006626,0.020732
06-07 17:16:48.831+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.831+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:48.841+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.841+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:48:844,1248.000000
06-07 17:16:48.841+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:845,0.297823,-0.091037,9.801703
06-07 17:16:48.841+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:840,0.005503,-0.039346,0.073387
06-07 17:16:48.851+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.851+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:856,0.024722,-0.004200,0.054257
06-07 17:16:48.851+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.851+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.861+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:864,0.300718,-0.091879,9.801607
06-07 17:16:48.861+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:48.861+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:48.871+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:862,0.002535,-0.037694,0.085383
06-07 17:16:48.871+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.871+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:879,-0.019226,0.021603,0.094978
06-07 17:16:48.871+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.881+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:884,0.300503,-0.092186,9.801611
06-07 17:16:48.881+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.891+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:894,0.018227,-0.010794,0.070992
06-07 17:16:48.891+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.891+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.901+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:904,0.301618,-0.092629,9.801573
06-07 17:16:48.911+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:901,0.017856,-0.003310,0.092541
06-07 17:16:48.911+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.911+0200 I/gravity (19031): es.ugr.frailty.gravity - capturing data
06-07 17:16:48.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:16:48.921+0200 I/gravity (19031): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:48:923,0.300543,-0.092576,9.801606
06-07 17:16:48.931+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:919,0.048675,-0.027294,0.042300
06-07 17:16:48.931+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:48.941+0200 I/linearacceleration(19049): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:48:942,0.070671,-0.021426,0.020834
06-07 17:16:48.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19031
06-07 17:16:48.961+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11191966c6f63152838460
