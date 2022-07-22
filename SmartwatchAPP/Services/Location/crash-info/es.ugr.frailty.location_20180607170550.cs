S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15766
Date: 2018-06-07 17:05:50+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf714452d, r5   = 0xf721af98
r6   = 0xffc7ef40, r7   = 0xffc7edf0
r8   = 0xf7217c18, r9   = 0x00000000
r10  = 0xffc7eecc, fp   = 0xffc7ef40
ip   = 0x00000001, sp   = 0xffc7edc8
lr   = 0xf7144539, pc   = 0xf71ad228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    208060 KB
Buffers:     10864 KB
Cached:      63116 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11440 KB
VmRSS:       11436 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15766 TID = 15766
15766 15770 

Maps Information
f400f000 f480e000 rw-p [stack:15770]
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
f71e7000 f7275000 rw-p [heap]
ffc60000 ffc81000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15766)
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
:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:50.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391150353,000000, pattern:[H:mm][0;m
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:50.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:50.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:50.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:50.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:353,0.980000,-0.070000,-0.140000
06-07 17:05:50.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:358,0.910000,0.140000,-0.140000
06-07 17:05:50.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.351+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:341,1.785046,-0.942772,9.686146
06-07 17:05:50.361+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:363,0.140000,0.140000,0.140000
06-07 17:05:50.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:368,-0.280000,-0.140000,0.350000
06-07 17:05:50.361+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.361+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:373,0.350000,-0.140000,0.280000
06-07 17:05:50.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:377,0.420000,-0.070000,0.210000
06-07 17:05:50.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.371+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:366,1.685846,-0.901045,9.618546
06-07 17:05:50.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:382,0.490000,-0.140000,0.070000
06-07 17:05:50.381+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.381+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:386,0.280000,0.280000,0.070000
06-07 17:05:50.381+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.381+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.381+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:375,1.713261,-0.873380,9.645468
06-07 17:05:50.381+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:376,0.076119,-0.062121,0.122540
06-07 17:05:50.381+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:390,-0.070000,0.280000,0.070000
06-07 17:05:50.381+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.391+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.391+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:395,0.140000,0.070000,0.210000
06-07 17:05:50.391+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.391+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.401+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:393,1.687329,-0.898453,9.618528
06-07 17:05:50.401+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:404,0.350000,-0.140000,0.210000
06-07 17:05:50.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:400,0.063393,-0.051869,0.080310
06-07 17:05:50.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.401+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:409,0.001832,-0.045634,0.073572
06-07 17:05:50.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.411+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:403,1.682154,-0.870987,9.698111
06-07 17:05:50.411+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.411+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.411+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:419,0.420000,-0.140000,0.140000
06-07 17:05:50.411+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:415,0.065313,0.000866,0.027983
06-07 17:05:50.411+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.421+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:414,1.686522,-0.895871,9.618911
06-07 17:05:50.421+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.421+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:425,0.041718,0.052374,0.049775
06-07 17:05:50.421+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.421+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:420,1.694118,-0.957129,9.714860
06-07 17:05:50.421+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:429,0.000692,-0.013280,0.087802
06-07 17:05:50.421+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.431+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.431+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:433,0.032969,-0.046516,0.113940
06-07 17:05:50.431+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.431+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:431,1.685331,-0.895279,9.619175
06-07 17:05:50.431+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:439,0.490000,0.140000,0.280000
06-07 17:05:50.431+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:50.441+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:50:444,520.000000
06-07 17:05:50.441+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.441+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.441+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:448,0.044864,0.007512,0.035119
06-07 17:05:50.441+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:438,1.698904,-0.964308,9.669396
06-07 17:05:50.441+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.451+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:453,0.005291,-0.005593,0.030454
06-07 17:05:50.451+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.451+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.451+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:449,1.688953,-0.896830,9.618395
06-07 17:05:50.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:459,-0.070000,0.140000,0.210000
06-07 17:05:50.461+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:458,0.015445,0.077514,0.035078
06-07 17:05:50.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:468,0.035475,0.067845,0.082325
06-07 17:05:50.461+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:461,1.718047,-0.909273,9.683753
06-07 17:05:50.471+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.471+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:468,1.689926,-0.899432,9.617981
06-07 17:05:50.471+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.471+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:481,1.689973,-0.898659,9.618045
06-07 17:05:50.481+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.481+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:476,1.696511,-0.957129,9.669396
06-07 17:05:50.481+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:50.481+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.481+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.481+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:50:487,77
06-07 17:05:50.481+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:490,1.718047,-0.918844,9.719646
06-07 17:05:50.481+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:485,-0.280000,0.140000,0.210000
06-07 17:05:50.481+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.491+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:494,1.693316,-0.898454,9.617476
06-07 17:05:50.491+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.491+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.491+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.501+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:494,0.008412,-0.014573,0.134779
06-07 17:05:50.501+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.501+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:507,0.032884,-0.023467,0.079711
06-07 17:05:50.501+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:504,0.350000,0.140000,0.210000
06-07 17:05:50.511+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:501,1.663012,-0.978664,9.652647
06-07 17:05:50.511+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:503,1.691641,-0.896308,9.617971
06-07 17:05:50.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.511+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:520,0.490000,0.210000,0.070000
06-07 17:05:50.511+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:521,-0.002787,0.017194,0.050957
06-07 17:05:50.521+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.521+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.531+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.531+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.531+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:529,1.722832,-0.892523,9.676575
06-07 17:05:50.531+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:529,1.689255,-0.893203,9.618679
06-07 17:05:50.541+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.541+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:540,-0.420000,0.140000,0.070000
06-07 17:05:50.541+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:542,0.020708,0.005469,0.012128
06-07 17:05:50.541+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.551+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.551+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.551+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:561,0.024152,-0.070601,0.057874
06-07 17:05:50.551+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:551,1.689784,-0.892615,9.618641
06-07 17:05:50.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:560,-0.420000,0.210000,-0.070000
06-07 17:05:50.561+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.561+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:555,1.703690,-0.899701,9.671788
06-07 17:05:50.561+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.571+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.571+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.571+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:580,0.013537,-0.035699,0.079943
06-07 17:05:50.571+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:571,1.692939,-0.895689,9.617801
06-07 17:05:50.581+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:574,1.696511,-0.894916,9.621540
06-07 17:05:50.581+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.581+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:588,1.694679,-0.897138,9.617359
06-07 17:05:50.581+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.581+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:580,-0.420000,0.280000,-0.210000
06-07 17:05:50.591+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.591+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:594,1.684547,-0.942772,9.729217
06-07 17:05:50.591+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.591+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.601+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:604,0.630000,0.070000,-0.070000
06-07 17:05:50.601+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.601+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:604,0.032400,-0.033692,0.125640
06-07 17:05:50.601+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:610,1.710868,-0.914058,9.681360
06-07 17:05:50.601+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:600,1.693412,-0.898175,9.617485
06-07 17:05:50.611+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.611+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.611+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.611+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:620,0.040464,0.054484,0.015382
06-07 17:05:50.611+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:620,0.070000,0.070000,0.070000
06-07 17:05:50.611+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.621+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:617,1.695471,-0.897040,9.617229
06-07 17:05:50.621+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:628,1.756332,-0.904487,9.686146
06-07 17:05:50.621+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.631+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.631+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:50.631+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.631+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:639,-0.630000,0.280000,0.140000
06-07 17:05:50.631+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:50:639,520.000000
06-07 17:05:50.631+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:633,1.695820,-0.893600,9.617487
06-07 17:05:50.641+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:637,1.739582,-0.878166,9.678967
06-07 17:05:50.641+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.641+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.641+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:649,1.694649,-0.893863,9.617669
06-07 17:05:50.641+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.651+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:649,0.024671,0.001398,0.082373
06-07 17:05:50.651+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.651+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.651+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:659,0.700000,0.140000,-0.070000
06-07 17:05:50.651+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.661+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:665,1.694718,-0.895249,9.617528
06-07 17:05:50.661+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:660,0.047559,0.011748,0.063485
06-07 17:05:50.661+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:654,1.703690,-0.878166,9.690931
06-07 17:05:50.661+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.661+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:671,1.646262,-0.870987,9.657433
06-07 17:05:50.671+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.671+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.671+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.671+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:681,0.035571,0.059585,-0.001340
06-07 17:05:50.671+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:681,0.280000,0.140000,0.070000
06-07 17:05:50.681+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.681+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:687,1.730011,-0.887737,9.705289
06-07 17:05:50.681+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:50.681+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:676,1.696006,-0.894109,9.617407
06-07 17:05:50.681+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.681+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:50:691,77
06-07 17:05:50.691+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.691+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:692,1.695423,-0.893466,9.617569
06-07 17:05:50.691+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:698,1.730011,-0.966700,9.659825
06-07 17:05:50.691+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.691+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.691+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.701+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:704,0.022813,-0.056365,0.048730
06-07 17:05:50.701+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:704,-0.910000,0.140000,0.140000
06-07 17:05:50.701+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.751+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.761+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:757,-0.630000,0.140000,0.210000
06-07 17:05:50.761+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.771+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:703,1.694536,-0.888583,9.618178
06-07 17:05:50.771+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.771+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.781+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:786,0.059027,-0.114286,0.059061
06-07 17:05:50.781+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:774,-1.330000,0.350000,0.210000
06-07 17:05:50.791+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.791+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:798,-1.050000,0.350000,0.070000
06-07 17:05:50.791+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.801+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:805,0.350000,0.630000,0.070000
06-07 17:05:50.801+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.801+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:779,1.761117,-0.942772,9.688539
06-07 17:05:50.801+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.801+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:810,0.070000,0.630000,0.140000
06-07 17:05:50.811+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.811+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.821+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:823,-2.030000,-0.140000,0.210000
06-07 17:05:50.821+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:828,0.012853,-0.076861,0.074551
06-07 17:05:50.831+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:785,1.695278,-0.885128,9.618366
06-07 17:05:50.831+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:50.831+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:50:839,520.000000
06-07 17:05:50.841+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.841+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.851+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.861+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:836,1.801795,-0.933201,9.712467
06-07 17:05:50.861+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:846,-1.260000,0.210000,0.210000
06-07 17:05:50.861+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.861+0200 W/LOCATION(15766): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:05:50.871+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:872,0.037454,-0.020691,0.068228
06-07 17:05:50.881+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:854,1.694733,-0.885806,9.618400
06-07 17:05:50.881+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:50.881+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:50:887,77
06-07 17:05:50.881+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.891+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.901+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:895,1.703690,-0.902094,9.676575
06-07 17:05:50.901+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:904,1.694513,-0.885788,9.618440
06-07 17:05:50.911+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:886,-2.800000,-0.280000,-0.210000
06-07 17:05:50.911+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.911+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.911+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.921+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.921+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:920,0.027857,0.056172,0.047374
06-07 17:05:50.931+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.931+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:927,1.691726,-0.878166,9.669396
06-07 17:05:50.931+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:927,-2.030000,-0.350000,-0.140000
06-07 17:05:50.931+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.931+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.931+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:932,1.692553,-0.883635,9.618983
06-07 17:05:50.941+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.941+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:938,-0.083507,0.068996,0.039634
06-07 17:05:50.941+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:943,-1.330000,0.840000,-0.210000
06-07 17:05:50.951+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.951+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.951+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:947,1.722832,-0.892523,9.664611
06-07 17:05:50.951+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.961+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:957,-0.046789,-0.025761,0.040676
06-07 17:05:50.961+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:953,1.693895,-0.884135,9.618701
06-07 17:05:50.961+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.961+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:968,1.765903,-0.954736,9.741181
06-07 17:05:50.961+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:964,-1.120000,0.560000,0.280000
06-07 17:05:50.971+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.971+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.981+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:976,1.694938,-0.887931,9.618168
06-07 17:05:50.981+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:50.981+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:976,-0.005342,-0.080101,0.091722
06-07 17:05:50.981+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:50.981+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:50.991+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:50:984,-1.960000,0.700000,0.280000
06-07 17:05:50.991+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:50.991+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:50:992,0.024901,-0.057420,0.070896
06-07 17:05:51.001+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:50:990,1.756332,-0.947558,9.698111
06-07 17:05:51.001+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.001+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:50:995,1.695218,-0.889938,9.617933
06-07 17:05:51.001+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.001+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.001+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:0,-0.280000,0.770000,0.280000
06-07 17:05:51.011+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.011+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:8,0.070903,-0.003625,0.036969
06-07 17:05:51.011+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.021+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:15,1.696511,-0.942772,9.690931
06-07 17:05:51.021+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:14,1.694333,-0.889579,9.618122
06-07 17:05:51.021+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.021+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:27,-0.018131,-0.063846,0.036363
06-07 17:05:51.021+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:20,-0.140000,0.420000,-0.350000
06-07 17:05:51.031+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.031+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.031+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:51.041+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.041+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:51:44,519.000000
06-07 17:05:51.041+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:39,1.260000,0.210000,-0.350000
06-07 17:05:51.041+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.051+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:46,-0.060864,0.027418,0.063113
06-07 17:05:51.051+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:57,0.840000,0.210000,-0.350000
06-07 17:05:51.061+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:05:51.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:05:51.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:05:51.061+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.061+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:66,0.039717,-0.055724,0.041195
06-07 17:05:51.071+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.071+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:36,1.695769,-0.886743,9.618131
06-07 17:05:51.071+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.071+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:49,1.758725,-0.897308,9.645468
06-07 17:05:51.081+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:75,-0.420000,-0.070000,0.140000
06-07 17:05:51.081+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:51.081+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.091+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:51:88,77
06-07 17:05:51.091+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:82,0.043298,0.029418,0.107038
06-07 17:05:51.091+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.091+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.101+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:97,-0.700000,-0.070000,0.140000
06-07 17:05:51.101+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:101,-0.004492,-0.067923,0.080548
06-07 17:05:51.101+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.101+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:101,1.737189,-0.844666,9.667004
06-07 17:05:51.101+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:111,0.420000,0.070000,0.140000
06-07 17:05:51.101+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:85,1.696809,-0.887521,9.617875
06-07 17:05:51.111+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.111+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.111+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.121+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:119,-0.038966,0.004249,0.070992
06-07 17:05:51.121+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.121+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:129,0.350000,-0.420000,-0.210000
06-07 17:05:51.131+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:126,1.696511,-0.906880,9.705289
06-07 17:05:51.131+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:117,1.696832,-0.885108,9.618093
06-07 17:05:51.131+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.131+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.131+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.141+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.141+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:137,-0.036265,0.010499,-0.013986
06-07 17:05:51.141+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:137,1.697626,-0.881621,9.618274
06-07 17:05:51.141+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.151+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:146,1.727618,-0.940379,9.731609
06-07 17:05:51.151+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.151+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:158,-0.016047,0.032058,0.066525
06-07 17:05:51.151+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:148,0.210000,0.070000,-0.070000
06-07 17:05:51.161+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.161+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.161+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.161+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:159,1.699697,-0.885914,9.617514
06-07 17:05:51.161+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:166,-0.630000,0.350000,-0.140000
06-07 17:05:51.171+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.171+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.181+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:172,0.020191,-0.054914,0.104670
06-07 17:05:51.181+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:169,1.739582,-0.887737,9.652647
06-07 17:05:51.181+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.181+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.191+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:179,1.702801,-0.892232,9.616381
06-07 17:05:51.191+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:183,-0.840000,0.420000,-0.280000
06-07 17:05:51.191+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.191+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.191+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:190,0.052244,-0.068047,0.095703
06-07 17:05:51.201+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:192,1.701297,-0.899701,9.647861
06-07 17:05:51.201+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.211+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.211+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:203,-0.840000,0.280000,-0.210000
06-07 17:05:51.211+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.211+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:201,1.704520,-0.898152,9.615525
06-07 17:05:51.211+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.211+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:215,-0.027287,-0.032746,0.079228
06-07 17:05:51.211+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.221+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:222,-0.700000,0.280000,-0.210000
06-07 17:05:51.221+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:216,1.710868,-0.815953,9.652647
06-07 17:05:51.231+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.231+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:230,0.017424,0.020549,-0.011928
06-07 17:05:51.231+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:05:51.231+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.231+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:241,-0.560000,0.490000,-0.140000
06-07 17:05:51.241+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.241+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:05:51:240,519.000000
06-07 17:05:51.241+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:249,-0.030843,-0.002412,0.095685
06-07 17:05:51.251+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.251+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:225,1.706940,-0.900838,9.614844
06-07 17:05:51.251+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.251+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:258,-1.260000,0.770000,0.070000
06-07 17:05:51.251+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:237,1.730011,-0.820738,9.700503
06-07 17:05:51.261+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.261+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.261+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:258,1.705841,-0.896912,9.615406
06-07 17:05:51.261+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:266,-0.010003,-0.013559,0.116998
06-07 17:05:51.271+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.271+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.271+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:272,1.703690,-0.899701,9.753145
06-07 17:05:51.271+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.281+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:05:51.291+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:05:51:293,77
06-07 17:05:51.301+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.311+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:280,1.700229,-0.893083,9.616756
06-07 17:05:51.311+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.321+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:313,1.727618,-0.909273,9.698111
06-07 17:05:51.321+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:277,-2.030000,0.560000,-0.070000
06-07 17:05:51.321+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.321+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.331+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:282,0.000172,0.031104,0.076366
06-07 17:05:51.331+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.331+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:324,1.701854,-0.898563,9.615959
06-07 17:05:51.331+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.341+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:336,0.014000,-0.002634,0.093187
06-07 17:05:51.341+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.341+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:05:51:335,1.691726,-0.868595,9.669396
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:51.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391151352,000000, pattern:[H:mm][0;m
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:05:51.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:05:51.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:05:51.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:05][0;m
06-07 17:05:51.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:331,-1.610000,0.210000,-0.420000
06-07 17:05:51.351+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.351+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:05:51.351+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:05:51:348,1.702717,-0.904494,9.615250
06-07 17:05:51.361+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:05:51.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:05:51:361,-0.770000,0.560000,-0.420000
06-07 17:05:51.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:05:51.361+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:05:51:348,-0.010643,-0.011238,0.062302
06-07 17:05:51.361+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:05:51.371+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11157666c6f63152838395
