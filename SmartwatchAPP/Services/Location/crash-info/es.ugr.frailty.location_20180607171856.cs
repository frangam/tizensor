S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19865
Date: 2018-06-07 17:18:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf763652d, r5   = 0xf7d8af98
r6   = 0xffc892b0, r7   = 0xffc89160
r8   = 0xf7d87c18, r9   = 0x00000000
r10  = 0xffc8923c, fp   = 0xffc892b0
ip   = 0x00000001, sp   = 0xffc89138
lr   = 0xf7636539, pc   = 0xf769f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5144 KB
Buffers:      4232 KB
Cached:      76360 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11692 KB
VmRSS:       11692 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19865 TID = 19865
19865 19877 

Maps Information
f4501000 f4d00000 rw-p [stack:19877]
f4d07000 f4d09000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d11000 f4d15000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d1e000 f4d20000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d28000 f4d2b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d3a000 f4d3f000 r-xp /usr/lib/libsystem.so.0.0.0
f4d4a000 f4d4d000 r-xp /lib/libattr.so.1.1.0
f4d55000 f4d65000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d6d000 f4d76000 r-xp /usr/lib/libedbus.so.1.7.99
f4d7e000 f4d7f000 r-xp /usr/lib/libresponse.so.0.2.96
f4d88000 f4d8d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f662f000 f6735000 r-xp /usr/lib/libicuuc.so.57.1
f674b000 f68d3000 r-xp /usr/lib/libicui18n.so.57.1
f68e3000 f68f0000 r-xp /usr/lib/libail.so.0.1.0
f68f9000 f6900000 r-xp /usr/lib/libminizip.so.1.0.0
f6909000 f6ab2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ad2000 f6b19000 r-xp /usr/lib/libssl.so.1.0.0
f6b25000 f6b27000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b2f000 f6b36000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b3f000 f6b46000 r-xp /lib/libcrypt-2.13.so
f6b77000 f6b7a000 r-xp /lib/libcap.so.2.21
f6b82000 f6b84000 r-xp /usr/lib/libiri.so
f6b8c000 f6bd5000 r-xp /usr/lib/libmdm.so.1.2.69
f6bdd000 f6be3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6beb000 f6c0e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c18000 f6c1a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c22000 f6c3f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c48000 f6c4c000 r-xp /usr/lib/libsmack.so.1.0.0
f6c55000 f6c6e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c77000 f6c7f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c87000 f6c8d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c96000 f6c98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ca1000 f6cb1000 r-xp /lib/libresolv-2.13.so
f6cb5000 f6ccd000 r-xp /usr/lib/liblzma.so.5.0.3
f6cd6000 f6cd8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ce0000 f6cfa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d02000 f6d31000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d3a000 f6d49000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d53000 f6d5d000 r-xp /usr/lib/libsensord-shared.so
f6d66000 f6e39000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e44000 f6e5a000 r-xp /lib/libz.so.1.2.5
f6e62000 f6e67000 r-xp /usr/lib/libffi.so.5.0.10
f6e6f000 f6e70000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e78000 f6e88000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e90000 f6ea9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eb1000 f6eb3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ebb000 f6f30000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f3a000 f6f40000 r-xp /lib/librt-2.13.so
f6f49000 f6f67000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f71000 f6f72000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f7a000 f6f9d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fa5000 f6faa000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fb2000 f6fdc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fe5000 f6ffc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7004000 f706d000 r-xp /lib/libm-2.13.so
f7076000 f710a000 r-xp /usr/lib/libstdc++.so.6.0.16
f711d000 f7122000 r-xp /usr/lib/libctx-client.so.0.8.3
f712a000 f7131000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7139000 f7163000 r-xp /usr/lib/libsensor.so.1.9.6
f716c000 f7238000 r-xp /usr/lib/libxml2.so.2.7.8
f7245000 f7247000 r-xp /usr/lib/libiniparser.so.0
f7250000 f7256000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f725f000 f732f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7330000 f7364000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f736d000 f73a9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73b1000 f73b4000 r-xp /usr/lib/libbundle.so.0.1.22
f73bc000 f73c2000 r-xp /usr/lib/libappsvc.so.0.1.0
f73ca000 f740b000 r-xp /usr/lib/libeina.so.1.7.99
f7414000 f742b000 r-xp /usr/lib/libecore.so.1.7.99
f7442000 f744b000 r-xp /usr/lib/libvconf.so.0.2.45
f7453000 f7467000 r-xp /lib/libpthread-2.13.so
f7472000 f747f000 r-xp /usr/lib/libaul.so.0.1.0
f7489000 f748b000 r-xp /lib/libdl-2.13.so
f7494000 f749f000 r-xp /lib/libunwind.so.8.0.1
f74cc000 f74d4000 r-xp /lib/libgcc_s-4.6.so.1
f74d5000 f75f9000 r-xp /lib/libc-2.13.so
f7607000 f7609000 r-xp /usr/lib/libdlog.so.0.0.0
f7611000 f761d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7626000 f762b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7633000 f7642000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f764a000 f764e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7657000 f765a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7662000 f7664000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f766c000 f7670000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7678000 f7695000 r-xp /lib/ld-2.13.so
f769e000 f76a1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76a1000 f76a5000 r-xp /usr/lib/libsys-assert.so
f7d57000 f7de5000 rw-p [heap]
ffc6a000 ffc8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19865)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf769f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7636539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf733d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf733bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7347e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf734dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf734ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf738275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf737d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf733bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7347e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf734dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf734ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf737fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7380017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7387f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d1f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d12171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6de5663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7292fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72947a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7424ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf741fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74205a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7420879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7658183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76587fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf769f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf74ec85c) [/lib/libc.so.6] + 0x1785c
29: (0xf769ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ty.gyroscope - capturing data
06-07 17:18:56.051+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:60,0.070000,0.070000,0.070000
06-07 17:18:56.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:68,0.070000,0.070000,0.070000
06-07 17:18:56.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:74,0.070000,-0.070000,0.070000
06-07 17:18:56.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:79,-0.140000,-0.140000,0.140000
06-07 17:18:56.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:86,-0.140000,-0.140000,0.140000
06-07 17:18:56.081+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:92,-0.140000,-0.140000,0.070000
06-07 17:18:56.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:98,-0.140000,-0.140000,0.070000
06-07 17:18:56.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:104,-0.140000,-0.070000,0.140000
06-07 17:18:56.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:56.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:56.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:56.131+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.141+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:141,0.306372,-0.102186,9.801331
06-07 17:18:56.141+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.141+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:150,0.307312,-0.101698,9.801306
06-07 17:18:56.151+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.151+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:156,0.308030,-0.100397,9.801297
06-07 17:18:56.151+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.161+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:164,0.305697,-0.101901,9.801354
06-07 17:18:56.161+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.161+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:170,0.306396,-0.101214,9.801340
06-07 17:18:56.171+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:109,0.070000,0.070000,0.070000
06-07 17:18:56.171+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:175,0.306961,-0.101109,9.801323
06-07 17:18:56.171+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.181+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:181,0.307219,-0.099983,9.801327
06-07 17:18:56.181+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.181+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:188,0.307381,-0.099436,9.801327
06-07 17:18:56.181+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.211+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.211+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:56.221+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:56:224,836.000000
06-07 17:18:56.221+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:229,-0.070000,-0.070000,0.070000
06-07 17:18:56.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:236,-0.070000,-0.070000,0.070000
06-07 17:18:56.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:242,0.070000,-0.070000,0.070000
06-07 17:18:56.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.241+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:249,0.070000,-0.070000,0.070000
06-07 17:18:56.251+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.251+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:257,0.070000,-0.070000,0.070000
06-07 17:18:56.251+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:264,0.070000,-0.070000,0.140000
06-07 17:18:56.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.271+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:271,0.070000,0.070000,0.070000
06-07 17:18:56.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:287,0.070000,0.070000,0.070000
06-07 17:18:56.281+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:295,0.070000,-0.070000,0.070000
06-07 17:18:56.291+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:303,0.070000,-0.070000,0.070000
06-07 17:18:56.301+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.311+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:311,0.140000,0.070000,0.070000
06-07 17:18:56.311+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.311+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:318,0.070000,0.070000,0.070000
06-07 17:18:56.321+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:56.321+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:56.331+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.331+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.341+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:348,0.272782,-0.064606,9.815358
06-07 17:18:56.341+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:194,0.308233,-0.098681,9.801308
06-07 17:18:56.341+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19600) cmd(0)
06-07 17:18:56.351+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.351+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:41,0.015544,0.007205,0.093109
06-07 17:18:56.361+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:340,0.070000,0.070000,0.070000
06-07 17:18:56.361+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19605) cmd(0)
06-07 17:18:56.361+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.361+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:356,0.307767,-0.098564,9.801324
06-07 17:18:56.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.371+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.371+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:378,0.284746,-0.122034,9.870394
06-07 17:18:56.381+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.401+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:56.401+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:56.411+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:56.441+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:56:424,833.000000
06-07 17:18:56.461+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:466,0.305910,-0.099885,9.801369
06-07 17:18:56.471+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:387,0.004808,-0.009471,0.078789
06-07 17:18:56.471+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:386,-0.070000,-0.070000,0.070000
06-07 17:18:56.481+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.481+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.481+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.501+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.511+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:494,0.140000,-0.070000,0.070000
06-07 17:18:56.511+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:490,0.287139,-0.090927,9.839286
06-07 17:18:56.521+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:510,0.303404,-0.099873,9.801447
06-07 17:18:56.521+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:499,0.026343,0.021636,0.062040
06-07 17:18:56.521+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.521+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.531+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:536,0.332602,-0.102891,9.834501
06-07 17:18:56.531+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.531+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:541,0.070000,0.070000,0.070000
06-07 17:18:56.541+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:551,-0.009280,0.014690,0.057248
06-07 17:18:56.551+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:555,0.304375,-0.101989,9.801394
06-07 17:18:56.561+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.561+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.561+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.581+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(19651) cmd(0)
06-07 17:18:56.581+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:582,0.022771,-0.010105,0.081214
06-07 17:18:56.601+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:56.601+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:56.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:575,0.311067,-0.133998,9.820145
06-07 17:18:56.601+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.611+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:584,0.070000,0.070000,0.070000
06-07 17:18:56.611+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.621+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:56.621+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:56:626,831.000000
06-07 17:18:56.641+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:595,0.304842,-0.102477,9.801375
06-07 17:18:56.641+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.641+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.641+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:636,0.344566,-0.081356,9.899107
06-07 17:18:56.661+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:660,0.070000,0.140000,-0.070000
06-07 17:18:56.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:648,-0.007442,-0.018252,0.081175
06-07 17:18:56.671+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.691+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:664,0.305404,-0.102574,9.801356
06-07 17:18:56.691+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.701+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.711+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:710,0.306700,-0.103104,9.801311
06-07 17:18:56.721+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:686,0.337388,-0.095713,9.846465
06-07 17:18:56.721+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.731+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:696,0.006302,-0.046659,0.050092
06-07 17:18:56.731+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:707,0.070000,0.070000,0.070000
06-07 17:18:56.781+0200 W/LOCATION(19865): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:18:56.801+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:56.801+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:56.801+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.821+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:56.861+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:56:856,830.000000
06-07 17:18:56.861+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.881+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:877,0.306798,-0.102390,9.801315
06-07 17:18:56.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:776,0.337388,-0.071785,9.829715
06-07 17:18:56.891+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:879,-0.055022,-0.024484,0.069212
06-07 17:18:56.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.911+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.911+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:881,0.070000,0.070000,0.070000
06-07 17:18:56.921+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.931+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:909,0.311067,-0.136391,9.774680
06-07 17:18:56.941+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:56.951+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:931,-0.007058,0.008539,-0.004949
06-07 17:18:56.951+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:927,0.306278,-0.100663,9.801349
06-07 17:18:56.951+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:56.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:938,-0.140000,0.070000,-0.070000
06-07 17:18:56.961+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:56.961+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:56.971+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:56:955,0.289532,-0.107677,9.808180
06-07 17:18:56.991+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:56:974,0.306841,-0.098500,9.801353
06-07 17:18:56.991+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.001+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:56:975,0.046515,0.059747,0.076312
06-07 17:18:56.981+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:56:985,0.070000,0.140000,-0.070000
06-07 17:18:57.011+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.011+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.031+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:57.031+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:57.041+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.041+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:45,0.307125,-0.098351,9.801346
06-07 17:18:57.051+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:57.061+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:57:64,828.000000
06-07 17:18:57.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:1,0.301496,-0.076570,9.865608
06-07 17:18:57.061+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.071+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:41,0.013566,0.006475,0.059540
06-07 17:18:57.081+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:70,0.140000,0.140000,-0.070000
06-07 17:18:57.091+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.091+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:99,0.009092,-0.019925,0.073936
06-07 17:18:57.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:76,0.291924,-0.098106,9.870394
06-07 17:18:57.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:57.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:57.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:57.121+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:103,0.306972,-0.098250,9.801352
06-07 17:18:57.131+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.141+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:115,0.140000,0.070000,0.070000
06-07 17:18:57.141+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.141+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:132,0.301496,-0.098106,9.784252
06-07 17:18:57.151+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.171+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:18:57.171+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:18:57.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.171+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.181+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19600
06-07 17:18:57.181+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19600)
06-07 17:18:57.181+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:18:57.181+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.181+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:18:57.181+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:18:57.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.191+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.201+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19605
06-07 17:18:57.201+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19605)
06-07 17:18:57.211+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:18:57.211+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.211+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:18:57.211+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:18:57.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.211+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.221+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:57.221+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:57.221+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:18:57.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:18:57.231+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:18:57.231+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.231+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:18:57.231+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:18:57.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.231+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.241+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19865
06-07 17:18:57.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19865)
06-07 17:18:57.251+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:18:57.251+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.251+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:18:57.251+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:18:57.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.251+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:57.261+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19639
06-07 17:18:57.271+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19639)
06-07 17:18:57.271+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:18:57.271+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.271+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:18:57.271+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:18:57.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.281+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19651
06-07 17:18:57.281+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19651)
06-07 17:18:57.291+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:18:57.291+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.291+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:18:57.291+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:18:57.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.301+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:18:57.311+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:57.311+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19663), cmd(0)
06-07 17:18:57.311+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:57.311+0200 I/utils   (19663): specific action
06-07 17:18:57.311+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:18:57.311+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:18:57.311+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.311+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:18:57.311+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:18:57.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.331+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:18:57.331+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:18:57.331+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:18:57.331+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.331+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:18:57.331+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:18:57.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:18:57.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:18:57.341+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:18:57.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:57.351+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(19682), cmd(0)
06-07 17:18:57.351+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:57.351+0200 I/utils   (19682): specific action
06-07 17:18:57.351+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:18:57.351+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:18:57.351+0200 I/servicemanager(19582): App control destroyed.
06-07 17:18:57.361+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.361+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:370,0.323031,-0.138784,9.829715
06-07 17:18:57.361+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:154,0.033107,-0.020348,0.078712
06-07 17:18:57.371+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.371+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:158,0.307390,-0.097158,9.801350
06-07 17:18:57.371+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:164,0.070000,0.070000,0.070000
06-07 17:18:57.381+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.391+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:399,0.307468,-0.097564,9.801343
06-07 17:18:57.391+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.401+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:57.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19621), cmd(0)
06-07 17:18:57.401+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:57.401+0200 I/utils   (19621): specific action
06-07 17:18:57.401+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:57.401+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:57.401+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:57:263,827.000000
06-07 17:18:57.411+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:18:57.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(15), pid(19670), cmd(0)
06-07 17:18:57.411+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:18:57.411+0200 I/utils   (19670): specific action
06-07 17:18:57.431+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.431+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:390,0.040674,-0.029358,0.078707
06-07 17:18:57.431+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:57.441+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:57:445,824.000000
06-07 17:18:57.441+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.451+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.451+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:425,0.070000,0.070000,0.070000
06-07 17:18:57.451+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:460,-0.010464,-0.012050,0.083527
06-07 17:18:57.461+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:440,0.313460,-0.114855,9.860823
06-07 17:18:57.471+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.471+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.501+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:506,0.140000,0.070000,0.070000
06-07 17:18:57.511+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:469,0.308425,-0.096219,9.801327
06-07 17:18:57.511+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.511+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.521+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:516,0.299103,-0.102891,9.834501
06-07 17:18:57.541+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.531+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:527,-0.059783,0.013001,0.050086
06-07 17:18:57.551+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.561+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:530,0.308663,-0.097663,9.801305
06-07 17:18:57.561+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.561+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.571+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:575,0.310863,-0.097387,9.801238
06-07 17:18:57.571+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:560,0.366102,-0.112463,9.812965
06-07 17:18:57.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:557,-0.070000,0.140000,0.070000
06-07 17:18:57.581+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.591+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.591+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:569,-0.001274,0.025273,0.057233
06-07 17:18:57.601+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.601+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:57.611+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:57.621+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:606,0.318245,-0.143569,9.863215
06-07 17:18:57.621+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:596,0.070000,0.070000,0.070000
06-07 17:18:57.631+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:616,0.030954,0.007562,0.047541
06-07 17:18:57.631+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.631+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.641+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:57.641+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:57:647,821.000000
06-07 17:18:57.661+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:619,0.309646,-0.097773,9.801272
06-07 17:18:57.661+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.661+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.671+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:656,0.315853,-0.047856,9.832108
06-07 17:18:57.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:645,-0.070000,0.070000,0.070000
06-07 17:18:57.681+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.691+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:697,0.070000,0.140000,0.070000
06-07 17:18:57.691+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:675,0.308775,-0.098049,9.801297
06-07 17:18:57.691+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.691+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:675,0.016659,0.030401,0.028384
06-07 17:18:57.701+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.701+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.741+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:717,-0.032137,-0.034693,0.095408
06-07 17:18:57.741+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:710,0.301496,-0.102891,9.848858
06-07 17:18:57.741+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:720,0.305142,-0.094646,9.801444
06-07 17:18:57.751+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.771+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.771+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.771+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:780,0.070000,0.070000,0.070000
06-07 17:18:57.781+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.781+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:788,0.299103,-0.086142,9.844072
06-07 17:18:57.781+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:791,0.022180,0.009470,0.009276
06-07 17:18:57.791+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:795,0.300924,-0.103120,9.801490
06-07 17:18:57.801+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.801+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.801+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.801+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:57.801+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:57.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:815,0.022120,-0.000991,0.028360
06-07 17:18:57.811+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.811+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:57.821+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:57:825,818.000000
06-07 17:18:57.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:821,0.016635,0.019858,0.042732
06-07 17:18:57.821+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:833,0.018463,0.007789,0.081035
06-07 17:18:57.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.831+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:838,0.020598,0.018628,0.085816
06-07 17:18:57.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:846,0.001294,-0.001062,0.061889
06-07 17:18:57.841+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:852,-0.021095,-0.035317,0.057121
06-07 17:18:57.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.851+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:859,-0.042164,-0.004328,-0.024251
06-07 17:18:57.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:867,0.017121,-0.043684,0.033133
06-07 17:18:57.861+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:873,0.010055,-0.010196,0.035446
06-07 17:18:57.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.871+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:879,0.013870,-0.000903,0.097713
06-07 17:18:57.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:886,0.030153,-0.009986,0.119267
06-07 17:18:57.881+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:892,0.003270,0.016432,0.059466
06-07 17:18:57.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.891+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:900,0.006759,0.028927,0.059512
06-07 17:18:57.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:907,0.030590,0.040177,0.112149
06-07 17:18:57.901+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.911+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:914,0.021539,-0.002229,0.057080
06-07 17:18:57.911+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.911+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:920,0.009012,-0.001999,0.011612
06-07 17:18:57.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:927,0.018299,0.019388,0.014012
06-07 17:18:57.921+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.951+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:57.961+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:57:965,0.300076,-0.088891,9.801655
06-07 17:18:57.961+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:814,0.294317,-0.100499,9.858429
06-07 17:18:57.961+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:933,0.011274,-0.011820,0.049900
06-07 17:18:57.971+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:57:819,0.070000,0.070000,0.070000
06-07 17:18:57.971+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:57.971+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:57.981+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:57:983,0.022820,0.030159,0.090579
06-07 17:18:57.981+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:57.991+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:58.001+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:58.001+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:58.011+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:58.011+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:58:7,0.301691,-0.104331,9.801453
06-07 17:18:58.011+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:57:998,0.267996,-0.131605,9.853643
06-07 17:18:58.011+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:58.021+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:58:26,816.000000
06-07 17:18:58.031+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:58:3,0.070000,0.070000,0.070000
06-07 17:18:58.031+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:58.061+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:58.061+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:58.071+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:58:71,0.070000,0.140000,0.070000
06-07 17:18:58.071+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:58:41,0.003599,-0.026863,0.023586
06-07 17:18:58.081+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:58:79,0.293737,-0.098869,9.801751
06-07 17:18:58.081+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:58.081+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:58:63,0.332602,-0.074178,9.817751
06-07 17:18:58.101+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:58.101+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:58.121+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:18:58.121+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:18:58.121+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:18:58.141+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:58:150,0.265603,-0.117248,9.791430
06-07 17:18:58.171+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:58:179,-0.070000,0.070000,0.070000
06-07 17:18:58.171+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:58:98,0.048106,0.007685,0.018818
06-07 17:18:58.181+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:58.181+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:58:187,0.299337,-0.103243,9.801537
06-07 17:18:58.181+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:58.191+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:58.201+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:58.201+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:18:58.201+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:18:58.211+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:58.211+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:18:58:204,-0.011953,-0.012407,0.093017
06-07 17:18:58.221+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:18:58.221+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:18:58:228,816.000000
06-07 17:18:58.231+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:18:58:220,0.070000,0.070000,0.070000
06-07 17:18:58.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:58:215,0.334995,-0.110070,9.836893
06-07 17:18:58.241+0200 I/gravity (19651): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:18:58:233,0.288520,-0.088864,9.802002
06-07 17:18:58.241+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer - capturing data
06-07 17:18:58.251+0200 I/linearacceleration(19639): es.ugr.frailty.linearacceleration - capturing data
06-07 17:18:58.261+0200 I/gyroscope(19605): es.ugr.frailty.gyroscope - capturing data
06-07 17:18:58.261+0200 I/accelerometer(19600): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:18:58:269,0.342174,-0.107677,9.851252
06-07 17:18:58.271+0200 I/gravity (19651): es.ugr.frailty.gravity - capturing data
06-07 17:18:58.281+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11198656c6f63152838473
