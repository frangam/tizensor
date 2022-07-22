S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18514
Date: 2018-06-07 17:14:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf714452d, r5   = 0xf77a3f98
r6   = 0xffc88430, r7   = 0xffc882e0
r8   = 0xf77a0c18, r9   = 0x00000000
r10  = 0xffc883bc, fp   = 0xffc88430
ip   = 0x00000001, sp   = 0xffc882b8
lr   = 0xf7144539, pc   = 0xf71ad228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    257224 KB
Buffers:      3472 KB
Cached:      53340 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10808 KB
VmRSS:       10808 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18514 TID = 18514
18514 18518 

Maps Information
f400f000 f480e000 rw-p [stack:18518]
f4815000 f4817000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f481f000 f4823000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f482c000 f482e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4836000 f4839000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4848000 f484d000 r-xp /usr/lib/libsystem.so.0.0.0
f4858000 f485b000 r-xp /lib/libattr.so.1.1.0
f4863000 f4873000 r-xp /usr/lib/libmdm-common.so.1.1.24
f487b000 f4884000 r-xp /usr/lib/libedbus.so.1.7.99
f488c000 f488d000 r-xp /usr/lib/libresponse.so.0.2.96
f4896000 f489b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f613d000 f6243000 r-xp /usr/lib/libicuuc.so.57.1
f6259000 f63e1000 r-xp /usr/lib/libicui18n.so.57.1
f63f1000 f63fe000 r-xp /usr/lib/libail.so.0.1.0
f6407000 f640e000 r-xp /usr/lib/libminizip.so.1.0.0
f6417000 f65c0000 r-xp /usr/lib/libcrypto.so.1.0.0
f65e0000 f6627000 r-xp /usr/lib/libssl.so.1.0.0
f6633000 f6635000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f663d000 f6644000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f664d000 f6654000 r-xp /lib/libcrypt-2.13.so
f6685000 f6688000 r-xp /lib/libcap.so.2.21
f6690000 f6692000 r-xp /usr/lib/libiri.so
f669a000 f66e3000 r-xp /usr/lib/libmdm.so.1.2.69
f66eb000 f66f1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66f9000 f671c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6726000 f6728000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6730000 f674d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6756000 f675a000 r-xp /usr/lib/libsmack.so.1.0.0
f6763000 f677c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6785000 f678d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6795000 f679b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67a4000 f67a6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67af000 f67bf000 r-xp /lib/libresolv-2.13.so
f67c3000 f67db000 r-xp /usr/lib/liblzma.so.5.0.3
f67e4000 f67e6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67ee000 f6808000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6810000 f683f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6848000 f6857000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6861000 f686b000 r-xp /usr/lib/libsensord-shared.so
f6874000 f6947000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6952000 f6968000 r-xp /lib/libz.so.1.2.5
f6970000 f6975000 r-xp /usr/lib/libffi.so.5.0.10
f697d000 f697e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6986000 f6996000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f699e000 f69b7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69bf000 f69c1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69c9000 f6a3e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a48000 f6a4e000 r-xp /lib/librt-2.13.so
f6a57000 f6a75000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a7f000 f6a80000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a88000 f6aab000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ab3000 f6ab8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ac0000 f6aea000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6af3000 f6b0a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b12000 f6b7b000 r-xp /lib/libm-2.13.so
f6b84000 f6c18000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c2b000 f6c30000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c38000 f6c3f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c47000 f6c71000 r-xp /usr/lib/libsensor.so.1.9.6
f6c7a000 f6d46000 r-xp /usr/lib/libxml2.so.2.7.8
f6d53000 f6d55000 r-xp /usr/lib/libiniparser.so.0
f6d5e000 f6d64000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d6d000 f6e3d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e3e000 f6e72000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e7b000 f6eb7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ebf000 f6ec2000 r-xp /usr/lib/libbundle.so.0.1.22
f6eca000 f6ed0000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ed8000 f6f19000 r-xp /usr/lib/libeina.so.1.7.99
f6f22000 f6f39000 r-xp /usr/lib/libecore.so.1.7.99
f6f50000 f6f59000 r-xp /usr/lib/libvconf.so.0.2.45
f6f61000 f6f75000 r-xp /lib/libpthread-2.13.so
f6f80000 f6f8d000 r-xp /usr/lib/libaul.so.0.1.0
f6f97000 f6f99000 r-xp /lib/libdl-2.13.so
f6fa2000 f6fad000 r-xp /lib/libunwind.so.8.0.1
f6fda000 f6fe2000 r-xp /lib/libgcc_s-4.6.so.1
f6fe3000 f7107000 r-xp /lib/libc-2.13.so
f7115000 f7117000 r-xp /usr/lib/libdlog.so.0.0.0
f711f000 f712b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7134000 f7139000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7141000 f7150000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7158000 f715c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7165000 f7168000 r-xp /usr/lib/libappcore-agent.so.1.1
f7170000 f7172000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f717a000 f717e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7186000 f71a3000 r-xp /lib/ld-2.13.so
f71ac000 f71af000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71af000 f71b3000 r-xp /usr/lib/libsys-assert.so
f7770000 f77e1000 rw-p [heap]
ffc69000 ffc8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18514)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71ad228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7144539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e4b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e49c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e55e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e5bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e5bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e9075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e8b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e49c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e55e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e5bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e5bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e8de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e8e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e95f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf482d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4820171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68f3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6da0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6da27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f32ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f2db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f2e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f2e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7166183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71667fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71ad5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6ffa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71acf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
inearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.931+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:939,0.009089,-0.009494,0.037828
06-07 17:14:39.931+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:945,0.078476,0.030653,0.061776
06-07 17:14:39.941+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:39:934,0.070000,0.070000,-0.070000
06-07 17:14:39.941+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:39.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.941+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:39:951,0.070000,0.070000,-0.070000
06-07 17:14:39.941+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:951,0.042128,-0.002373,0.033081
06-07 17:14:39.951+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.951+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:39.951+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:957,0.044473,-0.037564,0.059463
06-07 17:14:39.951+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.951+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:39:958,647.000000
06-07 17:14:39.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:963,-0.014085,0.014943,0.064281
06-07 17:14:39.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.961+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:39.961+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:969,-0.022754,-0.007592,0.090663
06-07 17:14:39.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:976,-0.019145,0.017737,0.052330
06-07 17:14:39.971+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.971+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:39.971+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:39.981+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:39:970,0.070000,0.070000,0.070000
06-07 17:14:39.981+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:39.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:982,-0.010388,0.049054,0.035532
06-07 17:14:39.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:989,-0.000016,0.067432,0.035500
06-07 17:14:39.981+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.991+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:39:987,0.070000,-0.070000,0.070000
06-07 17:14:39.991+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:39:994,0.019147,0.000633,0.080942
06-07 17:14:39.991+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:39.991+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:39.991+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:1,0.024282,-0.036318,0.033042
06-07 17:14:40.001+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.001+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:0,0.070000,0.070000,0.140000
06-07 17:14:40.001+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:14:40.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18360), cmd(0)
06-07 17:14:40.011+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:8,0.028646,-0.041283,0.088088
06-07 17:14:40.011+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.011+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:14,0.070000,0.070000,0.070000
06-07 17:14:40.021+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.021+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:24,0.034682,-0.061260,0.037889
06-07 17:14:40.031+0200 W/AUL     (18570): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
06-07 17:14:40.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:14:40.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:14:40.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18360
06-07 17:14:40.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:14:40.031+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18360
06-07 17:14:40.031+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18360)
06-07 17:14:40.041+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.041+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:27,0.070000,0.070000,0.070000
06-07 17:14:40.041+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.051+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:53,-0.035653,-0.009386,0.047505
06-07 17:14:40.051+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:52,0.070000,0.070000,0.070000
06-07 17:14:40.051+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.051+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.061+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:65,0.003516,0.043413,0.042792
06-07 17:14:40.061+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:62,0.070000,0.070000,0.070000
06-07 17:14:40.061+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:14:40.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:14:40.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:14:40.071+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:72,0.070000,0.070000,0.070000
06-07 17:14:40.071+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:80,0.013241,0.005140,0.064248
06-07 17:14:40.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.081+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:85,0.210000,0.140000,0.070000
06-07 17:14:40.081+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:97,0.070000,0.140000,0.070000
06-07 17:14:40.091+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:92,0.032586,0.026792,0.071398
06-07 17:14:40.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.091+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.101+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:105,-0.005810,0.012099,0.045076
06-07 17:14:40.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:105,0.070000,0.070000,0.070000
06-07 17:14:40.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.111+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.111+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:114,0.140000,0.070000,0.070000
06-07 17:14:40.111+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.111+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:120,0.007394,0.005933,0.080993
06-07 17:14:40.111+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:121,0.070000,0.070000,0.070000
06-07 17:14:40.121+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.121+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:128,0.010289,-0.009087,0.061829
06-07 17:14:40.131+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.141+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:144,0.070000,0.070000,0.070000
06-07 17:14:40.141+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.141+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:149,0.019735,-0.031035,0.035506
06-07 17:14:40.141+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.151+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.151+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:157,0.070000,0.070000,0.070000
06-07 17:14:40.151+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:40.161+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:40:161,646.000000
06-07 17:14:40.161+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:154,0.011756,-0.032828,0.064252
06-07 17:14:40.161+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.161+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:170,0.010155,-0.026310,0.071497
06-07 17:14:40.171+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.171+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:176,0.070000,0.070000,0.070000
06-07 17:14:40.171+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.171+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:40.171+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:40.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:181,-0.000532,-0.010195,0.035656
06-07 17:14:40.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:188,0.018147,0.005414,0.062005
06-07 17:14:40.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.191+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.191+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:196,0.070000,0.070000,0.070000
06-07 17:14:40.191+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:194,0.027730,0.060989,0.014153
06-07 17:14:40.191+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.201+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:205,0.017340,0.060815,0.047677
06-07 17:14:40.201+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.201+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:211,0.001807,0.019798,0.023760
06-07 17:14:40.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:216,0.070000,0.070000,0.070000
06-07 17:14:40.211+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:222,0.004767,-0.006270,0.090797
06-07 17:14:40.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:228,-0.009972,-0.004555,0.054911
06-07 17:14:40.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.231+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.231+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:236,0.210000,0.070000,0.070000
06-07 17:14:40.231+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:234,-0.020021,-0.059126,0.054931
06-07 17:14:40.231+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.241+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:245,0.039463,-0.027365,0.040591
06-07 17:14:40.241+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.251+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.291+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:256,0.070000,0.070000,0.070000
06-07 17:14:40.301+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.321+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:322,0.070000,0.070000,0.070000
06-07 17:14:40.321+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:252,0.028157,-0.050767,0.066918
06-07 17:14:40.321+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.341+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.341+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:346,0.070000,-0.070000,0.070000
06-07 17:14:40.351+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:40.361+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:40:358,646.000000
06-07 17:14:40.361+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:343,0.035422,-0.037508,0.031114
06-07 17:14:40.371+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.371+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.381+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:40.381+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:40.391+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:380,0.070000,-0.070000,0.070000
06-07 17:14:40.391+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.391+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:383,0.005491,-0.013856,0.004853
06-07 17:14:40.401+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.411+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:414,-0.050845,-0.010015,0.045588
06-07 17:14:40.411+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:402,0.070000,0.070000,0.070000
06-07 17:14:40.411+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.431+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:425,-0.070000,0.070000,0.070000
06-07 17:14:40.431+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.441+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.441+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:442,0.002009,-0.004815,0.036014
06-07 17:14:40.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:446,0.070000,0.070000,0.070000
06-07 17:14:40.451+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:458,-0.140000,-0.070000,0.070000
06-07 17:14:40.461+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:463,-0.037995,0.019433,0.050276
06-07 17:14:40.461+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.471+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.471+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:471,0.070000,-0.070000,0.070000
06-07 17:14:40.471+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:480,-0.001890,0.045776,0.045483
06-07 17:14:40.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.501+0200 W/LOCATION(18514): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:14:40.511+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:516,0.070000,-0.070000,0.070000
06-07 17:14:40.511+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.521+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:528,-0.004459,0.003961,0.083685
06-07 17:14:40.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:532,0.070000,-0.070000,0.070000
06-07 17:14:40.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.531+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.541+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:544,0.070000,-0.070000,0.070000
06-07 17:14:40.541+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:547,-0.001989,-0.010294,0.052552
06-07 17:14:40.541+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.541+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.551+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:40.551+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:40:557,621.000000
06-07 17:14:40.551+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:561,0.028816,-0.012474,0.086063
06-07 17:14:40.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:553,0.070000,0.070000,0.070000
06-07 17:14:40.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:566,0.070000,0.070000,0.070000
06-07 17:14:40.561+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.571+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:576,0.028678,-0.023702,0.052576
06-07 17:14:40.571+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.571+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:40.571+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:40.581+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:581,0.070000,0.070000,0.140000
06-07 17:14:40.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.591+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:594,0.029510,-0.027695,0.057420
06-07 17:14:40.591+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:595,0.140000,0.070000,0.140000
06-07 17:14:40.591+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.591+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.601+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:605,0.140000,0.070000,0.140000
06-07 17:14:40.601+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:609,0.023393,-0.007378,0.028761
06-07 17:14:40.611+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:14:40.611+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:14:40.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.611+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.611+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:619,0.070000,0.070000,0.070000
06-07 17:14:40.621+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.621+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 18571
06-07 17:14:40.621+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:14:40.621+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.641+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:629,0.070000,0.070000,0.840000
06-07 17:14:40.641+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.651+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:652,0.070000,0.070000,0.070000
06-07 17:14:40.651+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.651+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:658,0.070000,0.070000,0.070000
06-07 17:14:40.661+0200 E/CAPI_APPFW_APPLICATION(18571): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:14:40.661+0200 E/CAPI_APPFW_APPLICATION(18571): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:14:40.661+0200 I/utils   (18571): trying to start service: es.ugr.frailty.accelerometer
06-07 17:14:40.661+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:632,-0.013895,-0.013224,0.076676
06-07 17:14:40.671+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.671+0200 I/utils   (18571): es.ugr.frailty.accelerometer sensor supported
06-07 17:14:40.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18571
06-07 17:14:40.671+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18571) type(svcapp) bg(0)
06-07 17:14:40.671+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (18571) was created
06-07 17:14:40.681+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18571]
06-07 17:14:40.691+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18571)
06-07 17:14:40.691+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:14:40.691+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.691+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:14:40.691+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:14:40.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.701+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:677,0.070000,0.140000,2.310000
06-07 17:14:40.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18556
06-07 17:14:40.711+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:14:40.711+0200 W/CAPI_APPFW_APP_CONTROL(18556): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.711+0200 I/utils   (18556): specific action
06-07 17:14:40.711+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.721+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18571
06-07 17:14:40.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:14:40.721+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:716,-0.027178,0.013653,0.031262
06-07 17:14:40.731+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:723,0.070000,0.140000,4.200000
06-07 17:14:40.731+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.731+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18571
06-07 17:14:40.741+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18556), cmd(0)
06-07 17:14:40.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18556)
06-07 17:14:40.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:14:40.741+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:14:40.741+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.741+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:14:40.741+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:14:40.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:14:40.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.751+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:40.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:14:40.761+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.761+0200 I/utils   (18034): specific action
06-07 17:14:40.761+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:40:765,646.000000
06-07 17:14:40.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18034), cmd(0)
06-07 17:14:40.761+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:14:40.761+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:14:40.761+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.761+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:14:40.761+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:14:40.761+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.771+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18514
06-07 17:14:40.781+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:737,0.070000,0.140000,7.980000
06-07 17:14:40.781+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:40.781+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:40.781+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18514)
06-07 17:14:40.781+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:14:40.781+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.781+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:14:40.781+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:14:40.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.791+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.791+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:745,-0.000595,0.074375,0.062370
06-07 17:14:40.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18398
06-07 17:14:40.801+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18398)
06-07 17:14:40.801+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:14:40.801+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.801+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:14:40.801+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:14:40.801+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.811+0200 I/utils   (18571): es.ugr.frailty.accelerometer listener started
06-07 17:14:40.811+0200 W/CAPI_APPFW_APP_CONTROL(18571): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.811+0200 I/utils   (18571): specific action
06-07 17:14:40.811+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:40.821+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 18583
06-07 17:14:40.821+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:14:40.841+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:800,0.350000,0.140000,10.290000
06-07 17:14:40.841+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:40:817,0.016830,0.047671,0.069523
06-07 17:14:40.841+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:40.851+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:40:825,0.071785,-0.275175,9.927821
06-07 17:14:40.851+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:40.861+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:40.861+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:40:853,0.140000,0.070000,7.980000
06-07 17:14:40.861+0200 E/CAPI_APPFW_APPLICATION(18583): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:14:40.861+0200 E/CAPI_APPFW_APPLICATION(18583): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 17:14:40.861+0200 I/utils   (18583): trying to start service: es.ugr.frailty.gravity
06-07 17:14:40.861+0200 I/utils   (18583): es.ugr.frailty.gravity sensor supported
06-07 17:14:40.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18583
06-07 17:14:40.871+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(18583) type(svcapp) bg(0)
06-07 17:14:40.871+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (18583) was created
06-07 17:14:40.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18583)
06-07 17:14:40.871+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:14:40.871+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.871+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:14:40.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:14:40.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.881+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:40:863,0.363709,-0.021535,9.860823
06-07 17:14:40.881+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:40.881+0200 I/utils   (18583): es.ugr.frailty.gravity listener started
06-07 17:14:40.881+0200 W/CAPI_APPFW_APP_CONTROL(18583): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.881+0200 I/utils   (18583): specific action
06-07 17:14:40.891+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:14:40.891+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:898,0.262510,-0.074940,9.802850
06-07 17:14:40.891+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.891+0200 I/utils   (18075): specific action
06-07 17:14:40.891+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18075), cmd(0)
06-07 17:14:40.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:14:40.901+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:14:40.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.901+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:14:40.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:14:40.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.911+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:14:40.911+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:917,0.262785,-0.076663,9.802829
06-07 17:14:40.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18079), cmd(0)
06-07 17:14:40.921+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.921+0200 I/utils   (18079): specific action
06-07 17:14:40.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:14:40.921+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:14:40.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.921+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:14:40.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:14:40.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:14:40.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:14:40.931+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.931+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:939,0.264603,-0.078654,9.802764
06-07 17:14:40.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:14:40.941+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18583]
06-07 17:14:40.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:14:40.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18111), cmd(0)
06-07 17:14:40.951+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:14:40.951+0200 I/utils   (18111): specific action
06-07 17:14:40.951+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:40.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:14:40.961+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:14:40.961+0200 I/servicemanager(17973): App control destroyed.
06-07 17:14:40.961+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:40:962,660.000000
06-07 17:14:40.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:14:40.971+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.971+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:40.971+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:40.981+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:981,0.268875,-0.078417,9.802649
06-07 17:14:40.981+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.981+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:988,0.271791,-0.078815,9.802567
06-07 17:14:40.991+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:40.991+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:40:997,0.274118,-0.080650,9.802486
06-07 17:14:41.011+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.011+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:17,0.275713,-0.082826,9.802423
06-07 17:14:41.021+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18583
06-07 17:14:41.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:14:41.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18583
06-07 17:14:41.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:14:41.031+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:14:41.031+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:40:904,0.550349,0.153141,9.896714
06-07 17:14:41.041+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.041+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:41:36,0.011248,0.032455,0.007301
06-07 17:14:41.041+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:47,0.275993,-0.084908,9.802398
06-07 17:14:41.041+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:40,-0.070000,0.140000,11.060000
06-07 17:14:41.041+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:41.051+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.051+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:57,0.273127,-0.084367,9.802483
06-07 17:14:41.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:14:41.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:14:41.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:14:41.071+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.071+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:77,0.272570,-0.081062,9.802526
06-07 17:14:41.091+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.091+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.091+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:97,0.274862,-0.081406,9.802460
06-07 17:14:41.091+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:41:82,0.019797,-0.048345,0.067137
06-07 17:14:41.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:87,0.070000,0.140000,7.770000
06-07 17:14:41.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.101+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:98,0.196211,-0.131605,9.887143
06-07 17:14:41.111+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.111+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.111+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:41.111+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:117,0.276459,-0.082426,9.802406
06-07 17:14:41.111+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:41:121,-0.005032,-0.023299,0.040833
06-07 17:14:41.121+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:113,0.280000,0.350000,11.830000
06-07 17:14:41.131+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.131+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.131+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:116,-0.327817,-0.198604,9.860823
06-07 17:14:41.131+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:137,0.279546,-0.083968,9.802305
06-07 17:14:41.131+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.131+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:41.151+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:14:41.151+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.161+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:138,0.210000,0.210000,13.860000
06-07 17:14:41.161+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.161+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:159,0.282066,-0.083934,9.802234
06-07 17:14:41.161+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:14:41:161,614.000000
06-07 17:14:41.161+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:141,0.256032,-0.064606,9.851252
06-07 17:14:41.161+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:169,0.070000,0.210000,0.210000
06-07 17:14:41.161+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.171+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.171+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:41:154,0.047085,-0.049935,0.048049
06-07 17:14:41.171+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:176,0.279960,-0.119641,9.913465
06-07 17:14:41.171+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:14:41.171+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:14:41.181+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:41.181+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:178,0.283289,-0.083261,9.802204
06-07 17:14:41.181+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.181+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.191+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.201+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:199,0.283493,-0.082730,9.802202
06-07 17:14:41.211+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:14:41.211+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:14:41:187,-0.005293,0.003822,0.045659
06-07 17:14:41.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:14:41:192,0.070000,0.070000,0.210000
06-07 17:14:41.221+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:195,0.306281,-0.124427,9.951750
06-07 17:14:41.221+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:14:41.221+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:14:41.221+0200 I/linearacceleration(18398): es.ugr.frailty.linearacceleration - capturing data
06-07 17:14:41.231+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:14:41:226,0.283699,-0.082931,9.802195
06-07 17:14:41.231+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:14:41:231,0.387637,-0.074178,9.884750
06-07 17:14:41.231+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11185146c6f63152838448
