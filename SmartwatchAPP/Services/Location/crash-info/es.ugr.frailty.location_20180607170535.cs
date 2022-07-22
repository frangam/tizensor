S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15683
Date: 2018-06-07 17:05:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76d452d, r5   = 0xf7c6cf98
r6   = 0xff819af0, r7   = 0xff8199a0
r8   = 0xf7c69c18, r9   = 0x00000000
r10  = 0xff819a7c, fp   = 0xff819af0
ip   = 0x00000001, sp   = 0xff819978
lr   = 0xf76d4539, pc   = 0xf773d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    107960 KB
Buffers:     10092 KB
Cached:      61580 KB
VmPeak:      53576 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11676 KB
VmRSS:       11676 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15683 TID = 15683
15683 15687 

Maps Information
f459f000 f4d9e000 rw-p [stack:15687]
f4da5000 f4da7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4daf000 f4db3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dbc000 f4dbe000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dc6000 f4dc9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dd8000 f4ddd000 r-xp /usr/lib/libsystem.so.0.0.0
f4de8000 f4deb000 r-xp /lib/libattr.so.1.1.0
f4df3000 f4e03000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e0b000 f4e14000 r-xp /usr/lib/libedbus.so.1.7.99
f4e1c000 f4e1d000 r-xp /usr/lib/libresponse.so.0.2.96
f4e26000 f4e2b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66cd000 f67d3000 r-xp /usr/lib/libicuuc.so.57.1
f67e9000 f6971000 r-xp /usr/lib/libicui18n.so.57.1
f6981000 f698e000 r-xp /usr/lib/libail.so.0.1.0
f6997000 f699e000 r-xp /usr/lib/libminizip.so.1.0.0
f69a7000 f6b50000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b70000 f6bb7000 r-xp /usr/lib/libssl.so.1.0.0
f6bc3000 f6bc5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bcd000 f6bd4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bdd000 f6be4000 r-xp /lib/libcrypt-2.13.so
f6c15000 f6c18000 r-xp /lib/libcap.so.2.21
f6c20000 f6c22000 r-xp /usr/lib/libiri.so
f6c2a000 f6c73000 r-xp /usr/lib/libmdm.so.1.2.69
f6c7b000 f6c81000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c89000 f6cac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cb6000 f6cb8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cc0000 f6cdd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ce6000 f6cea000 r-xp /usr/lib/libsmack.so.1.0.0
f6cf3000 f6d0c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d15000 f6d1d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d25000 f6d2b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d34000 f6d36000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d3f000 f6d4f000 r-xp /lib/libresolv-2.13.so
f6d53000 f6d6b000 r-xp /usr/lib/liblzma.so.5.0.3
f6d74000 f6d76000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d7e000 f6d98000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6da0000 f6dcf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dd8000 f6de7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6df1000 f6dfb000 r-xp /usr/lib/libsensord-shared.so
f6e04000 f6ed7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ee2000 f6ef8000 r-xp /lib/libz.so.1.2.5
f6f00000 f6f05000 r-xp /usr/lib/libffi.so.5.0.10
f6f0d000 f6f0e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f16000 f6f26000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f2e000 f6f47000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f4f000 f6f51000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f59000 f6fce000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fd8000 f6fde000 r-xp /lib/librt-2.13.so
f6fe7000 f7005000 r-xp /usr/lib/libsystemd.so.0.4.0
f700f000 f7010000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7018000 f703b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7043000 f7048000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7050000 f707a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7083000 f709a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70a2000 f710b000 r-xp /lib/libm-2.13.so
f7114000 f71a8000 r-xp /usr/lib/libstdc++.so.6.0.16
f71bb000 f71c0000 r-xp /usr/lib/libctx-client.so.0.8.3
f71c8000 f71cf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71d7000 f7201000 r-xp /usr/lib/libsensor.so.1.9.6
f720a000 f72d6000 r-xp /usr/lib/libxml2.so.2.7.8
f72e3000 f72e5000 r-xp /usr/lib/libiniparser.so.0
f72ee000 f72f4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72fd000 f73cd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73ce000 f7402000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f740b000 f7447000 r-xp /usr/lib/libSLP-location.so.0.9.24
f744f000 f7452000 r-xp /usr/lib/libbundle.so.0.1.22
f745a000 f7460000 r-xp /usr/lib/libappsvc.so.0.1.0
f7468000 f74a9000 r-xp /usr/lib/libeina.so.1.7.99
f74b2000 f74c9000 r-xp /usr/lib/libecore.so.1.7.99
f74e0000 f74e9000 r-xp /usr/lib/libvconf.so.0.2.45
f74f1000 f7505000 r-xp /lib/libpthread-2.13.so
f7510000 f751d000 r-xp /usr/lib/libaul.so.0.1.0
f7527000 f7529000 r-xp /lib/libdl-2.13.so
f7532000 f753d000 r-xp /lib/libunwind.so.8.0.1
f756a000 f7572000 r-xp /lib/libgcc_s-4.6.so.1
f7573000 f7697000 r-xp /lib/libc-2.13.so
f76a5000 f76a7000 r-xp /usr/lib/libdlog.so.0.0.0
f76af000 f76bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76c4000 f76c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76d1000 f76e0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76e8000 f76ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76f5000 f76f8000 r-xp /usr/lib/libappcore-agent.so.1.1
f7700000 f7702000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f770a000 f770e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7716000 f7733000 r-xp /lib/ld-2.13.so
f773c000 f773f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f773f000 f7743000 r-xp /usr/lib/libsys-assert.so
f7c39000 f7cc7000 rw-p [heap]
ff7fb000 ff81c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15683)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf773d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76d4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73db3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73d9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73e5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73ebbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73ebdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf742075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf741b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73d9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73e5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73ebbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73ebdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf741de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf741e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7425f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dbd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4db0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e83663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7330fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73327a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74c2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74bdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74be5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74be879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76f6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76f67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf773d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf758a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf773cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
5740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:302,0.037928,-0.048884,0.076451
06-07 17:05:34.301+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:294,1.622334,-0.983450,9.698111
06-07 17:05:34.301+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:309,0.036366,-0.003727,0.060193
06-07 17:05:34.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.311+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:290,-0.280000,-0.140000,0.140000
06-07 17:05:34.311+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:315,0.030960,0.000641,0.057859
06-07 17:05:34.311+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.311+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.311+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:303,1.624408,-1.042464,9.614830
06-07 17:05:34.311+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.311+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:321,-0.005594,0.062138,0.084215
06-07 17:05:34.321+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.321+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:315,1.634298,-1.055235,9.671788
06-07 17:05:34.321+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:328,0.007021,-0.012571,0.057466
06-07 17:05:34.321+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.321+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.331+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:333,1.625283,-1.043835,9.614533
06-07 17:05:34.331+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:334,0.006273,0.000805,0.050568
06-07 17:05:34.331+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:340,1.634298,-1.043271,9.664611
06-07 17:05:34.341+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:323,-1.680000,0.140000,0.420000
06-07 17:05:34.341+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.341+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.341+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.341+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:349,0.024620,-0.079899,0.036416
06-07 17:05:34.341+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:34.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391134354,000000, pattern:[H:mm][0;m
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:34.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:34.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:34.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:34.351+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:354,1.653440,-1.124627,9.650253
06-07 17:05:34.351+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:346,1.625084,-1.044636,9.614480
06-07 17:05:34.351+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.351+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:351,-1.120000,0.070000,0.350000
06-07 17:05:34.361+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:363,1.626646,-1.046722,9.613989
06-07 17:05:34.361+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.361+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.361+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.371+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:369,0.052221,-0.030527,0.101637
06-07 17:05:34.371+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:372,1.682154,-1.079163,9.714860
06-07 17:05:34.371+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.371+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:372,1.120000,0.140000,-0.140000
06-07 17:05:34.371+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.371+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:381,1.627266,-1.046304,9.613929
06-07 17:05:34.381+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.381+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:386,1.627928,-1.045588,9.613895
06-07 17:05:34.381+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.381+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.391+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.391+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:385,2.100000,-0.490000,-0.140000
06-07 17:05:34.391+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:396,1.639083,-1.088734,9.674182
06-07 17:05:34.391+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.391+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:393,0.007990,-0.039526,0.061217
06-07 17:05:34.401+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:390,1.627277,-1.042664,9.614323
06-07 17:05:34.401+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.401+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.401+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.401+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:401,0.700000,-0.070000,-0.210000
06-07 17:05:34.401+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:409,1.631905,-1.069592,9.695717
06-07 17:05:34.401+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.411+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:408,0.000927,-0.018566,0.082932
06-07 17:05:34.411+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:418,1.628025,-1.044075,9.614043
06-07 17:05:34.411+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:415,-0.840000,0.070000,0.280000
06-07 17:05:34.411+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.421+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.421+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:34.421+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.421+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:428,1.615155,-1.086342,9.650253
06-07 17:05:34.421+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.431+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:34:428,524.000000
06-07 17:05:34.431+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:432,-0.015339,-0.034429,0.037483
06-07 17:05:34.431+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:426,1.628820,-1.044728,9.613837
06-07 17:05:34.431+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.431+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:437,-1.120000,0.070000,0.700000
06-07 17:05:34.441+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.441+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:448,0.052453,-0.037416,0.087795
06-07 17:05:34.441+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.441+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.451+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:453,1.682154,-1.091127,9.700503
06-07 17:05:34.451+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:452,-1.120000,0.210000,0.560000
06-07 17:05:34.451+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:443,1.629933,-1.048636,9.613223
06-07 17:05:34.451+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.451+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.451+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:461,1.631093,-1.049209,9.612965
06-07 17:05:34.451+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.461+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:465,1.630978,-1.051026,9.612785
06-07 17:05:34.461+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.461+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.461+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:462,0.350000,0.210000,0.140000
06-07 17:05:34.461+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:34.471+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:471,1.619941,-1.050449,9.674182
06-07 17:05:34.471+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:470,-0.011481,0.004589,0.061912
06-07 17:05:34.471+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.471+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:34:476,81
06-07 17:05:34.481+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:482,1.630494,-1.051912,9.612770
06-07 17:05:34.481+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.481+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:475,0.560000,0.490000,-0.140000
06-07 17:05:34.481+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:487,1.629701,-1.053711,9.612708
06-07 17:05:34.481+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.481+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.481+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.481+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.491+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:493,0.006154,-0.014553,0.095262
06-07 17:05:34.491+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:495,1.636691,-1.069592,9.707682
06-07 17:05:34.491+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:496,-0.840000,0.140000,-0.280000
06-07 17:05:34.501+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.501+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.501+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.501+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:509,1.648655,-1.033699,9.640682
06-07 17:05:34.511+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:512,-0.490000,0.910000,-0.350000
06-07 17:05:34.511+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:508,0.018435,0.022255,0.028309
06-07 17:05:34.511+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:492,1.631422,-1.055038,9.612270
06-07 17:05:34.511+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.511+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.521+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.521+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:529,1.627119,-1.016950,9.683753
06-07 17:05:34.521+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:520,0.490000,0.980000,-0.280000
06-07 17:05:34.521+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.521+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.531+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:533,-0.003227,0.037499,0.071236
06-07 17:05:34.531+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:524,1.630537,-1.055039,9.612420
06-07 17:05:34.531+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.531+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:539,1.630220,-1.055954,9.612373
06-07 17:05:34.531+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:535,-0.070000,0.210000,-0.140000
06-07 17:05:34.541+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.541+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.541+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.541+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:549,0.000509,-0.017672,0.025268
06-07 17:05:34.541+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.541+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:546,-0.630000,-0.070000,-0.070000
06-07 17:05:34.551+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.551+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:554,1.629512,-1.069592,9.638289
06-07 17:05:34.551+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:546,1.630347,-1.054448,9.612517
06-07 17:05:34.551+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.561+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:562,1.629003,-1.051920,9.613022
06-07 17:05:34.561+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:561,0.140000,-0.210000,0.070000
06-07 17:05:34.561+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.561+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.561+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.561+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.561+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:571,0.007495,-0.011477,0.046990
06-07 17:05:34.571+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:569,1.636691,-1.064806,9.659825
06-07 17:05:34.571+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:574,0.770000,-0.070000,0.070000
06-07 17:05:34.571+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.571+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:581,0.980000,-0.070000,-0.140000
06-07 17:05:34.581+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.581+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:567,1.629195,-1.053329,9.612835
06-07 17:05:34.581+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.581+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:588,1.630196,-1.055602,9.612416
06-07 17:05:34.581+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.581+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.591+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:594,-0.000684,-0.045097,0.083301
06-07 17:05:34.591+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:594,1.629512,-1.100698,9.695717
06-07 17:05:34.591+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:586,0.490000,-0.140000,-0.070000
06-07 17:05:34.591+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.601+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.601+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:602,-0.070000,0.070000,-0.070000
06-07 17:05:34.601+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.601+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.601+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:608,0.010815,-0.084094,0.081436
06-07 17:05:34.601+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:608,1.641476,-1.143769,9.693325
06-07 17:05:34.601+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.611+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:614,-0.210000,0.070000,-0.070000
06-07 17:05:34.611+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:606,1.630662,-1.059675,9.611889
06-07 17:05:34.611+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.611+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.611+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:620,0.630000,0.070000,0.070000
06-07 17:05:34.621+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.621+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.621+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:34.621+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.621+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:628,0.023644,0.057667,0.069653
06-07 17:05:34.631+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:621,1.629797,-1.062653,9.611708
06-07 17:05:34.631+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.641+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:639,1.629366,-1.058372,9.612252
06-07 17:05:34.671+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.671+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:676,0.064752,-0.013612,0.059536
06-07 17:05:34.681+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.691+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:688,-0.007490,0.016122,0.103204
06-07 17:05:34.691+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:34.701+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.701+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:704,-0.037467,-0.013771,0.016740
06-07 17:05:34.711+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.731+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:34:715,81
06-07 17:05:34.731+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:34:629,523.000000
06-07 17:05:34.731+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:632,1.653440,-1.004985,9.681360
06-07 17:05:34.731+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:713,1.632216,-1.059392,9.611656
06-07 17:05:34.731+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.731+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:725,-0.018144,-0.037449,0.021117
06-07 17:05:34.731+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.741+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.751+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:749,0.050462,0.024051,0.040173
06-07 17:05:34.751+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:626,1.050000,0.140000,-0.140000
06-07 17:05:34.751+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:743,1.631086,-1.058214,9.611979
06-07 17:05:34.761+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:746,1.694118,-1.071985,9.671788
06-07 17:05:34.761+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.761+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.761+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:773,0.014698,-0.034306,0.095489
06-07 17:05:34.781+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.781+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.791+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:801,0.002698,-0.011829,0.066884
06-07 17:05:34.801+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:773,1.628514,-1.058464,9.612387
06-07 17:05:34.801+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.801+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:786,1.624727,-1.043271,9.714860
06-07 17:05:34.811+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.811+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.811+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:801,1.190000,0.210000,-0.210000
06-07 17:05:34.811+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.821+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:824,0.000422,0.019888,0.064539
06-07 17:05:34.821+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:34.821+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:34:829,523.000000
06-07 17:05:34.821+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:811,1.626906,-1.060143,9.612474
06-07 17:05:34.831+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.831+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:816,1.593620,-1.071985,9.628718
06-07 17:05:34.831+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.831+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.841+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:825,0.630000,0.350000,-0.070000
06-07 17:05:34.851+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:845,1.610370,-1.095913,9.633504
06-07 17:05:34.851+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:843,0.048159,0.071844,0.097983
06-07 17:05:34.851+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:836,1.629171,-1.059214,9.612193
06-07 17:05:34.851+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.851+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.851+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.861+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:34.871+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:865,-0.009490,0.040015,0.075879
06-07 17:05:34.871+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:34:877,81
06-07 17:05:34.871+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.881+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:860,0.630000,0.140000,0.070000
06-07 17:05:34.881+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.881+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:865,1.629207,-1.060155,9.612083
06-07 17:05:34.881+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.881+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:873,1.677369,-1.036092,9.652647
06-07 17:05:34.891+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.891+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:885,0.000131,0.004992,0.005646
06-07 17:05:34.891+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.901+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:900,1.643869,-1.093520,9.707682
06-07 17:05:34.901+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:892,1.629091,-1.060766,9.612036
06-07 17:05:34.901+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.901+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:895,-0.350000,0.140000,0.070000
06-07 17:05:34.911+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:905,0.059085,-0.065961,0.068096
06-07 17:05:34.911+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.911+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.911+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.921+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:913,1.629209,-1.060079,9.612091
06-07 17:05:34.931+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.931+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:923,1.631905,-1.071985,9.678967
06-07 17:05:34.931+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:930,0.022242,-0.030238,0.097883
06-07 17:05:34.931+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:932,-0.350000,0.420000,-0.210000
06-07 17:05:34.941+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.941+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.941+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.951+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:950,0.019615,-0.029035,0.093269
06-07 17:05:34.961+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:34.971+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:34:967,0.013174,0.078637,0.007003
06-07 17:05:34.971+0200 W/LOCATION(15683): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:05:34.981+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:940,1.629431,-1.054571,9.612659
06-07 17:05:34.981+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:947,1.629512,-1.040878,9.676575
06-07 17:05:34.981+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:34.991+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:34.991+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:34:988,1.626989,-1.050656,9.613502
06-07 17:05:34.991+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:34:998,1.677369,-0.988236,9.710074
06-07 17:05:34.991+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:34:983,0.560000,0.280000,-0.210000
06-07 17:05:34.991+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:34.991+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.001+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.001+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:6,1.627855,-1.051487,9.613264
06-07 17:05:35.001+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.011+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:5,0.770000,0.350000,-0.280000
06-07 17:05:35.011+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.011+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.021+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:14,1.619941,-1.014557,9.688539
06-07 17:05:35.021+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:35.021+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:7,-0.003476,0.011691,0.073464
06-07 17:05:35.021+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:35:29,522.000000
06-07 17:05:35.031+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.031+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.041+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:23,1.631198,-1.056104,9.612191
06-07 17:05:35.041+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.051+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:40,0.002117,-0.017565,0.078053
06-07 17:05:35.051+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:05:35.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:05:35.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:05:35.061+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:26,1.050000,0.280000,-0.350000
06-07 17:05:35.061+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.061+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:39,1.627119,-1.045663,9.619147
06-07 17:05:35.061+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.071+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:35.071+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:35:77,81
06-07 17:05:35.081+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:72,0.026289,-0.023605,0.087709
06-07 17:05:35.081+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:50,1.631432,-1.057307,9.612020
06-07 17:05:35.081+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.081+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:84,1.050000,0.280000,-0.490000
06-07 17:05:35.091+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.091+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:85,1.686940,-1.117448,9.681360
06-07 17:05:35.091+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.091+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.091+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:93,1.630695,-1.057301,9.612144
06-07 17:05:35.101+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.101+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:97,0.013709,-0.077548,0.008970
06-07 17:05:35.101+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:110,1.630596,-1.052569,9.612681
06-07 17:05:35.101+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:99,1.653440,-1.086342,9.710074
06-07 17:05:35.111+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:105,0.630000,0.420000,-0.210000
06-07 17:05:35.111+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.111+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:118,1.651048,-1.086342,9.705289
06-07 17:05:35.111+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.111+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.121+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.121+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:125,1.629789,-1.052026,9.612878
06-07 17:05:35.121+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:125,-0.420000,0.560000,-0.210000
06-07 17:05:35.131+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.131+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:128,-0.008296,-0.014501,0.047689
06-07 17:05:35.131+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:136,1.643869,-0.978664,9.619147
06-07 17:05:35.131+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.131+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.131+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.141+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:143,1.629544,-1.053165,9.612794
06-07 17:05:35.141+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.151+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.151+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:145,-0.840000,0.840000,-0.070000
06-07 17:05:35.151+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:150,0.045546,0.023561,0.064211
06-07 17:05:35.151+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.151+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:153,1.627119,-1.040878,9.686146
06-07 17:05:35.151+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.161+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:156,1.630160,-1.054257,9.612570
06-07 17:05:35.161+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.161+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.171+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:164,-0.210000,0.350000,0.070000
06-07 17:05:35.171+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:167,1.631905,-1.069592,9.690931
06-07 17:05:35.171+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.171+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:173,1.630630,-1.057483,9.612136
06-07 17:05:35.171+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.181+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.191+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:178,0.028235,0.023440,0.114279
06-07 17:05:35.191+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:184,1.655833,-1.076770,9.700503
06-07 17:05:35.191+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:185,0.140000,0.350000,0.070000
06-07 17:05:35.191+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.191+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.191+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:193,1.629430,-1.057260,9.612364
06-07 17:05:35.191+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.201+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.201+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:202,0.016708,-0.002984,0.039754
06-07 17:05:35.201+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:202,1.643869,-1.131805,9.621540
06-07 17:05:35.211+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:205,-0.070000,0.350000,-0.420000
06-07 17:05:35.211+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.211+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:209,1.629991,-1.054746,9.612545
06-07 17:05:35.211+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.221+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.221+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:35.221+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:35:228,522.000000
06-07 17:05:35.221+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.241+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:218,1.622334,-1.071985,9.659825
06-07 17:05:35.241+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.241+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:222,1.629554,-1.052251,9.612893
06-07 17:05:35.241+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:241,0.037244,-0.052634,0.071095
06-07 17:05:35.241+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.251+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:253,1.674976,-1.033699,9.676575
06-07 17:05:35.261+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:236,0.980000,-0.070000,-0.630000
06-07 17:05:35.261+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.261+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:260,1.630553,-1.052850,9.612658
06-07 17:05:35.271+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:35.271+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:35:277,81
06-07 17:05:35.271+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.281+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.281+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:275,1.190000,0.210000,-0.490000
06-07 17:05:35.291+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.291+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:297,1.632169,-1.055622,9.612080
06-07 17:05:35.291+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:296,1.658226,-1.031307,9.726824
06-07 17:05:35.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:282,0.023664,-0.035505,0.057317
06-07 17:05:35.301+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.311+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.311+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.311+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.321+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:330,1.632609,-1.056797,9.611876
06-07 17:05:35.331+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:35:318,0.070000,0.070000,-0.280000
06-07 17:05:35.331+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:35:325,0.028010,-0.043902,0.071877
06-07 17:05:35.341+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:322,1.646262,-1.055235,9.652647
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:35.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391135352,000000, pattern:[H:mm][0;m
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:35.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:35.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:35.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:35.351+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:35.351+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:35.351+0200 I/linearacceleration(15595): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:35.361+0200 I/gyroscope(15581): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:35.381+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:35:366,1.632586,-1.057245,9.611830
06-07 17:05:35.381+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:35:365,1.667797,-1.105484,9.683753
06-07 17:05:35.381+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11156836c6f63152838393
