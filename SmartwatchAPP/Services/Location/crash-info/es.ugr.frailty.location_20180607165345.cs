S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12075
Date: 2018-06-07 16:53:45+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fae52d, r5   = 0xf76c1f98
r6   = 0xffdcb620, r7   = 0xffdcb4d0
r8   = 0xf76bec18, r9   = 0x00000000
r10  = 0xffdcb5ac, fp   = 0xffdcb620
ip   = 0x00000001, sp   = 0xffdcb4a8
lr   = 0xf6fae539, pc   = 0xf7017228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4984 KB
Buffers:     11948 KB
Cached:     116892 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11816 KB
VmRSS:       11816 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          4 KB

Threads Information
Threads: 2
PID = 12075 TID = 12075
12075 12120 

Maps Information
f3e79000 f4678000 rw-p [stack:12120]
f467f000 f4681000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4689000 f468d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4696000 f4698000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46a0000 f46a3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46b2000 f46b7000 r-xp /usr/lib/libsystem.so.0.0.0
f46c2000 f46c5000 r-xp /lib/libattr.so.1.1.0
f46cd000 f46dd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46e5000 f46ee000 r-xp /usr/lib/libedbus.so.1.7.99
f46f6000 f46f7000 r-xp /usr/lib/libresponse.so.0.2.96
f4700000 f4705000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fa7000 f60ad000 r-xp /usr/lib/libicuuc.so.57.1
f60c3000 f624b000 r-xp /usr/lib/libicui18n.so.57.1
f625b000 f6268000 r-xp /usr/lib/libail.so.0.1.0
f6271000 f6278000 r-xp /usr/lib/libminizip.so.1.0.0
f6281000 f642a000 r-xp /usr/lib/libcrypto.so.1.0.0
f644a000 f6491000 r-xp /usr/lib/libssl.so.1.0.0
f649d000 f649f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64a7000 f64ae000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64b7000 f64be000 r-xp /lib/libcrypt-2.13.so
f64ef000 f64f2000 r-xp /lib/libcap.so.2.21
f64fa000 f64fc000 r-xp /usr/lib/libiri.so
f6504000 f654d000 r-xp /usr/lib/libmdm.so.1.2.69
f6555000 f655b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6563000 f6586000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6590000 f6592000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f659a000 f65b7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65c0000 f65c4000 r-xp /usr/lib/libsmack.so.1.0.0
f65cd000 f65e6000 r-xp /usr/lib/libnetwork.so.0.0.0
f65ef000 f65f7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65ff000 f6605000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f660e000 f6610000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6619000 f6629000 r-xp /lib/libresolv-2.13.so
f662d000 f6645000 r-xp /usr/lib/liblzma.so.5.0.3
f664e000 f6650000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6658000 f6672000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f667a000 f66a9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66b2000 f66c1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66cb000 f66d5000 r-xp /usr/lib/libsensord-shared.so
f66de000 f67b1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67bc000 f67d2000 r-xp /lib/libz.so.1.2.5
f67da000 f67df000 r-xp /usr/lib/libffi.so.5.0.10
f67e7000 f67e8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67f0000 f6800000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6808000 f6821000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6829000 f682b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6833000 f68a8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68b2000 f68b8000 r-xp /lib/librt-2.13.so
f68c1000 f68df000 r-xp /usr/lib/libsystemd.so.0.4.0
f68e9000 f68ea000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68f2000 f6915000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f691d000 f6922000 r-xp /usr/lib/libxdgmime.so.1.1.0
f692a000 f6954000 r-xp /usr/lib/libdbus-1.so.3.8.12
f695d000 f6974000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f697c000 f69e5000 r-xp /lib/libm-2.13.so
f69ee000 f6a82000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a95000 f6a9a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6aa2000 f6aa9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ab1000 f6adb000 r-xp /usr/lib/libsensor.so.1.9.6
f6ae4000 f6bb0000 r-xp /usr/lib/libxml2.so.2.7.8
f6bbd000 f6bbf000 r-xp /usr/lib/libiniparser.so.0
f6bc8000 f6bce000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bd7000 f6ca7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ca8000 f6cdc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ce5000 f6d21000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d29000 f6d2c000 r-xp /usr/lib/libbundle.so.0.1.22
f6d34000 f6d3a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d42000 f6d83000 r-xp /usr/lib/libeina.so.1.7.99
f6d8c000 f6da3000 r-xp /usr/lib/libecore.so.1.7.99
f6dba000 f6dc3000 r-xp /usr/lib/libvconf.so.0.2.45
f6dcb000 f6ddf000 r-xp /lib/libpthread-2.13.so
f6dea000 f6df7000 r-xp /usr/lib/libaul.so.0.1.0
f6e01000 f6e03000 r-xp /lib/libdl-2.13.so
f6e0c000 f6e17000 r-xp /lib/libunwind.so.8.0.1
f6e44000 f6e4c000 r-xp /lib/libgcc_s-4.6.so.1
f6e4d000 f6f71000 r-xp /lib/libc-2.13.so
f6f7f000 f6f81000 r-xp /usr/lib/libdlog.so.0.0.0
f6f89000 f6f95000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f9e000 f6fa3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fab000 f6fba000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fc2000 f6fc6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fcf000 f6fd2000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fda000 f6fdc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fe4000 f6fe8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6ff0000 f700d000 r-xp /lib/ld-2.13.so
f7016000 f7019000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7019000 f701d000 r-xp /usr/lib/libsys-assert.so
f768e000 f76ff000 rw-p [heap]
ffdac000 ffdcd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12075)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7017228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6fae539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cb53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cb3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cbfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cc5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cc5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cfa75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cf51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cb3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cbfe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cc5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cc5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cf7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cf8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cfff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46971fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf468a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf675d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c0afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c0c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d9cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d97b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d985a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d98879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fd0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fd07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70175c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e6485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7016f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
__gps_sv_status_cb : called
06-07 16:53:45.081+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:29,2.744050,-0.252588,9.411524
06-07 16:53:45.081+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.081+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:32,0.280000,2.100000,2.380000
06-07 16:53:45.081+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.091+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:65,0.491475,0.043209,-0.156112
06-07 16:53:45.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.111+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:117,2.684747,-0.184247,9.482756
06-07 16:53:45.111+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:121,0.479566,-0.117963,-0.165920
06-07 16:53:45.121+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:95,2.731774,-0.261012,9.414865
06-07 16:53:45.121+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.141+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:100,-0.910000,1.680000,2.380000
06-07 16:53:45.141+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.141+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.151+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:157,-0.700000,0.700000,2.660000
06-07 16:53:45.151+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:145,2.711631,-0.265177,9.420569
06-07 16:53:45.161+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.161+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:152,2.682354,-0.272782,9.473185
06-07 16:53:45.161+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.171+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:175,2.693127,-0.263223,9.425931
06-07 16:53:45.181+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:163,0.388373,0.003305,-0.173115
06-07 16:53:45.181+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:190,2.682354,-0.210568,9.487542
06-07 16:53:45.191+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.191+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:196,-0.700000,0.210000,2.030000
06-07 16:53:45.191+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.201+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.201+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:205,0.380152,0.155180,-0.147475
06-07 16:53:45.211+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:218,2.686337,-0.263767,9.427853
06-07 16:53:45.221+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.221+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:229,2.675175,-0.279960,9.485149
06-07 16:53:45.221+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:45.231+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:45:233,87
06-07 16:53:45.231+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.261+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:45.261+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:270,0.422196,0.235424,-0.099912
06-07 16:53:45.271+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:244,1.820000,0.490000,1.120000
06-07 16:53:45.271+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.271+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.311+0200 W/LOCATION(12075): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:45.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390425348,000000, pattern:[H:mm][0;m
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:45.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:45.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:45.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:45.351+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:357,2.696711,-0.203390,9.458827
06-07 16:53:45.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.351+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:375,0.434849,0.211973,-0.002567
06-07 16:53:45.371+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:45:364,1004.000000
06-07 16:53:45.401+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:356,2.679329,-0.266618,9.429767
06-07 16:53:45.401+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.401+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.401+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:381,1.400000,1.120000,0.980000
06-07 16:53:45.411+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.411+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:417,2.676441,-0.270266,9.430483
06-07 16:53:45.411+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.421+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:427,-0.350000,2.380000,0.630000
06-07 16:53:45.421+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:45.431+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:45:433,87
06-07 16:53:45.431+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:414,2.701497,-0.191426,9.434900
06-07 16:53:45.441+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:45.451+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:45:451,1004.000000
06-07 16:53:45.451+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.471+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:423,0.458805,0.045342,-0.083517
06-07 16:53:45.481+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.481+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:53:45.491+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:497,2.654671,-0.266509,9.436741
06-07 16:53:45.491+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.491+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.501+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11823) cmd(0)
06-07 16:53:45.571+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11827) cmd(0)
06-07 16:53:45.591+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.591+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:501,2.677568,-0.138784,9.473185
06-07 16:53:45.591+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.601+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:522,0.346423,-0.070438,-0.084178
06-07 16:53:45.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:525,-0.350000,2.450000,0.420000
06-07 16:53:45.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.611+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:610,2.665605,-0.241675,9.485149
06-07 16:53:45.621+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:45.631+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:45:633,88
06-07 16:53:45.631+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:627,0.313365,-0.090680,-0.097937
06-07 16:53:45.641+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:45.641+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:45:651,1005.000000
06-07 16:53:45.651+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.651+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:612,2.637030,-0.258979,9.441895
06-07 16:53:45.651+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.661+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:631,-0.350000,1.470000,0.140000
06-07 16:53:45.661+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.661+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:665,2.679961,-0.282353,9.475577
06-07 16:53:45.671+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.671+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:668,2.633440,-0.256687,9.442960
06-07 16:53:45.681+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:686,0.138958,-0.095960,-0.051777
06-07 16:53:45.691+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.691+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:688,-0.280000,1.680000,0.420000
06-07 16:53:45.691+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.701+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.701+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:704,2.699104,-0.246461,9.470792
06-07 16:53:45.721+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:727,-1.260000,0.490000,0.420000
06-07 16:53:45.731+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:709,2.629763,-0.258923,9.443923
06-07 16:53:45.741+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:723,0.014766,-0.032889,-0.032904
06-07 16:53:45.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.771+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:781,0.069085,-0.103606,0.054869
06-07 16:53:45.781+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11854) cmd(0)
06-07 16:53:45.791+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:767,2.633192,-0.260951,9.442912
06-07 16:53:45.791+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:764,2.687140,-0.229711,9.473185
06-07 16:53:45.791+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:788,-0.560000,-0.490000,0.280000
06-07 16:53:45.791+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.811+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.811+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:816,2.631078,-0.263094,9.443441
06-07 16:53:45.811+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:806,2.701497,-0.282353,9.461221
06-07 16:53:45.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:828,0.036936,-0.269826,0.133936
06-07 16:53:45.821+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:45.831+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:45:835,88
06-07 16:53:45.831+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.831+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:840,1.050000,-0.140000,-0.280000
06-07 16:53:45.841+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.841+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:45.851+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(11864) cmd(0)
06-07 16:53:45.851+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:45:855,1004.000000
06-07 16:53:45.851+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.861+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:864,2.667997,-0.224925,9.439686
06-07 16:53:45.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.871+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.871+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:875,2.637130,-0.269919,9.441561
06-07 16:53:45.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:885,0.043340,-0.153818,0.134641
06-07 16:53:45.901+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:45.881+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:891,1.680000,-0.350000,-0.770000
06-07 16:53:45.911+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.941+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:45.941+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:916,2.620141,-0.222532,9.494720
06-07 16:53:45.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:45.951+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:45:919,2.639292,-0.279467,9.440679
06-07 16:53:45.951+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:45:954,2.170000,0.280000,-0.490000
06-07 16:53:45.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:45:954,0.167670,-0.054324,0.050676
06-07 16:53:45.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:45.991+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.001+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.021+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:45:977,2.706282,-0.186640,9.394222
06-07 16:53:46.021+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:10,2.629873,-0.279713,9.443300
06-07 16:53:46.021+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:46.031+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:46:34,88
06-07 16:53:46.051+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:46.051+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:46:59,1002.000000
06-07 16:53:46.081+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:46.081+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:46.081+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:46.081+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:16,0.910000,0.560000,-0.630000
06-07 16:53:46.091+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:14,0.000235,0.199328,-0.232779
06-07 16:53:46.091+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.091+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.101+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:106,2.660819,-0.169890,9.410972
06-07 16:53:46.111+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.131+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:104,2.614527,-0.279012,9.447581
06-07 16:53:46.131+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.131+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:115,-0.089991,0.218407,0.021843
06-07 16:53:46.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.131+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:116,0.420000,0.210000,-0.560000
06-07 16:53:46.141+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.151+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:155,1.470000,0.140000,-0.700000
06-07 16:53:46.151+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:142,2.596212,-0.184247,9.494720
06-07 16:53:46.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:153,-0.134924,-0.027917,0.236507
06-07 16:53:46.171+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:145,2.592628,-0.273894,9.453763
06-07 16:53:46.171+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.171+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.191+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.201+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:209,2.100000,-0.070000,-0.560000
06-07 16:53:46.211+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:201,2.582725,-0.268909,9.456617
06-07 16:53:46.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:205,-0.067938,-0.063154,0.235993
06-07 16:53:46.211+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:181,2.706282,-0.220140,9.504292
06-07 16:53:46.211+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.211+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.221+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:46.231+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:46:234,88
06-07 16:53:46.231+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:241,2.579954,-0.269918,9.457344
06-07 16:53:46.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:245,0.015311,-0.061783,0.066877
06-07 16:53:46.241+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.241+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:46.251+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:46:255,1002.000000
06-07 16:53:46.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:249,1.470000,-0.630000,-0.630000
06-07 16:53:46.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:228,2.665605,-0.239282,9.437292
06-07 16:53:46.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.291+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.301+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.311+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:318,-0.007317,-0.100627,-0.055463
06-07 16:53:46.321+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:306,2.672783,-0.234497,9.485149
06-07 16:53:46.331+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:315,2.571752,-0.269944,9.459578
06-07 16:53:46.331+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.331+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.341+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.341+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:326,1.190000,0.490000,-0.840000
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:46.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390426349,000000, pattern:[H:mm][0;m
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:46.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:46.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:46.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:46.351+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:349,2.553976,-0.265746,9.464511
06-07 16:53:46.361+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:365,-0.069660,-0.114599,0.038849
06-07 16:53:46.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:347,2.675175,-0.181855,9.463614
06-07 16:53:46.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.391+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.391+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:385,0.210000,0.910000,-0.700000
06-07 16:53:46.391+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.391+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer alive timeout
06-07 16:53:46.391+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:53:46.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.391+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11823
06-07 16:53:46.411+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11823)
06-07 16:53:46.411+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer launch request sent!
06-07 16:53:46.411+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.411+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope alive timeout
06-07 16:53:46.411+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:53:46.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11827
06-07 16:53:46.421+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:46.431+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11827)
06-07 16:53:46.431+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope launch request sent!
06-07 16:53:46.431+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.431+0200 I/servicemanager(11799): es.ugr.frailty.heartrate alive timeout
06-07 16:53:46.431+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:53:46.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.431+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.441+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:46:434,88
06-07 16:53:46.441+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11839
06-07 16:53:46.441+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:46.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11839)
06-07 16:53:46.451+0200 I/servicemanager(11799): es.ugr.frailty.heartrate launch request sent!
06-07 16:53:46.451+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.451+0200 I/servicemanager(11799): es.ugr.frailty.location alive timeout
06-07 16:53:46.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:53:46.451+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:46:454,994.000000
06-07 16:53:46.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12075
06-07 16:53:46.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12075)
06-07 16:53:46.461+0200 I/servicemanager(11799): es.ugr.frailty.location launch request sent!
06-07 16:53:46.461+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.461+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration alive timeout
06-07 16:53:46.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:53:46.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11854
06-07 16:53:46.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11854)
06-07 16:53:46.481+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:53:46.481+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.481+0200 I/servicemanager(11799): es.ugr.frailty.gravity alive timeout
06-07 16:53:46.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:53:46.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11864
06-07 16:53:46.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11864)
06-07 16:53:46.491+0200 I/servicemanager(11799): es.ugr.frailty.gravity launch request sent!
06-07 16:53:46.491+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.491+0200 I/servicemanager(11799): es.ugr.frailty.pressure alive timeout
06-07 16:53:46.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:53:46.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11875
06-07 16:53:46.511+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:46.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(11875), cmd(0)
06-07 16:53:46.531+0200 W/CAPI_APPFW_APP_CONTROL(11875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:46.531+0200 I/utils   (11875): specific action
06-07 16:53:46.531+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11875)
06-07 16:53:46.531+0200 I/servicemanager(11799): es.ugr.frailty.pressure launch request sent!
06-07 16:53:46.531+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.531+0200 I/servicemanager(11799): es.ugr.frailty.light alive timeout
06-07 16:53:46.531+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:53:46.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11887
06-07 16:53:46.551+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11887)
06-07 16:53:46.551+0200 I/servicemanager(11799): es.ugr.frailty.light launch request sent!
06-07 16:53:46.551+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.551+0200 I/servicemanager(11799): es.ugr.frailty.pedometer alive timeout
06-07 16:53:46.551+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:53:46.551+0200 W/CAPI_APPFW_APP_CONTROL(11887): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:46.551+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:46.551+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:46.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11894
06-07 16:53:46.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:46.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(15), pid(11887), cmd(0)
06-07 16:53:46.561+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:46.561+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(37) , send fd(15), pid(11894), cmd(0)
06-07 16:53:46.561+0200 W/CAPI_APPFW_APP_CONTROL(11894): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:46.561+0200 I/utils   (11894): specific action
06-07 16:53:46.571+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11894)
06-07 16:53:46.571+0200 I/servicemanager(11799): es.ugr.frailty.pedometer launch request sent!
06-07 16:53:46.571+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:46.571+0200 I/utils   (11887): specific action
06-07 16:53:46.571+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:46.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(11839), cmd(0)
06-07 16:53:46.571+0200 W/CAPI_APPFW_APP_CONTROL(11839): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:46.571+0200 I/utils   (11839): specific action
06-07 16:53:46.571+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.571+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:581,0.140000,1.120000,-0.700000
06-07 16:53:46.581+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.581+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:589,1.470000,0.630000,-0.210000
06-07 16:53:46.581+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.591+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:595,0.770000,0.560000,-0.350000
06-07 16:53:46.591+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.601+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:605,-0.560000,0.560000,-0.420000
06-07 16:53:46.601+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:613,-0.280000,0.280000,-0.140000
06-07 16:53:46.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:620,-0.350000,-0.420000,0.210000
06-07 16:53:46.621+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.621+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:626,0.070000,-0.350000,0.140000
06-07 16:53:46.621+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.621+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:46.631+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:46:634,88
06-07 16:53:46.631+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:633,0.280000,0.210000,-0.070000
06-07 16:53:46.631+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:448,-0.040160,-0.137442,0.073626
06-07 16:53:46.641+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:46.651+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:46:652,993.000000
06-07 16:53:46.661+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:403,2.708675,-0.232104,9.422935
06-07 16:53:46.671+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:644,0.210000,0.210000,-0.560000
06-07 16:53:46.671+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.671+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.671+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:611,2.546024,-0.265209,9.466668
06-07 16:53:46.671+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.681+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:688,0.350000,0.210000,-0.910000
06-07 16:53:46.681+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.701+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:707,2.543721,-0.265974,9.467266
06-07 16:53:46.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:684,2.701497,-0.184247,9.458827
06-07 16:53:46.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:683,-0.023098,-0.095518,0.075070
06-07 16:53:46.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.711+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.711+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.731+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.731+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:738,1.190000,0.350000,-1.050000
06-07 16:53:46.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:723,-0.081919,0.040252,0.066973
06-07 16:53:46.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:725,2.660819,-0.222532,9.456435
06-07 16:53:46.751+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.751+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.761+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:745,2.546853,-0.265852,9.466427
06-07 16:53:46.761+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.791+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:799,0.840000,0.140000,-0.770000
06-07 16:53:46.801+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:809,2.543181,-0.266716,9.467390
06-07 16:53:46.801+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:767,-0.130414,0.040691,-0.014959
06-07 16:53:46.811+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:769,2.656033,-0.246461,9.499505
06-07 16:53:46.821+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.821+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.821+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.821+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:46.831+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:46:835,88
06-07 16:53:46.841+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.841+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:46.851+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:46:852,991.000000
06-07 16:53:46.861+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:867,2.528422,-0.262768,9.471453
06-07 16:53:46.861+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:847,-0.140000,0.630000,-0.350000
06-07 16:53:46.871+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:830,2.687140,-0.263210,9.427721
06-07 16:53:46.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:844,-0.044661,-0.018586,0.188901
06-07 16:53:46.871+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.871+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.891+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:897,-0.011332,-0.039663,0.198952
06-07 16:53:46.891+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:901,-0.420000,0.420000,0.420000
06-07 16:53:46.901+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:888,2.689533,-0.177069,9.432507
06-07 16:53:46.911+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.911+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.921+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:905,2.524285,-0.259938,9.472634
06-07 16:53:46.931+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.931+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.931+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:937,-0.770000,0.070000,0.630000
06-07 16:53:46.931+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:932,2.723032,-0.155533,9.454042
06-07 16:53:46.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:934,0.017877,0.007056,0.052273
06-07 16:53:46.941+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:46.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:46.951+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:946,2.532278,-0.260787,9.470477
06-07 16:53:46.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:46:967,2.684747,-0.236889,9.513863
06-07 16:53:46.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:46.971+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:46.971+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:46:977,-1.120000,-0.700000,0.420000
06-07 16:53:46.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:46:972,0.020504,0.103797,-0.016198
06-07 16:53:47.001+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:47.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:47.001+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:47.011+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:46:986,2.536369,-0.262791,9.469327
06-07 16:53:47.011+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:47.041+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:47.041+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:47:46,88
06-07 16:53:47.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:47.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:47.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:47.071+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:47.081+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:47:81,998.000000
06-07 16:53:47.081+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:47:12,2.684747,-0.287139,9.544970
06-07 16:53:47.091+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:47:18,0.140000,-0.700000,0.210000
06-07 16:53:47.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:47:15,-0.014496,0.062767,-0.014174
06-07 16:53:47.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:47.101+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:47.101+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:47.121+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:47:95,2.539805,-0.264972,9.468346
06-07 16:53:47.121+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:47:114,2.756532,-0.260818,9.482756
06-07 16:53:47.121+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:47:131,0.700000,0.210000,-0.070000
06-07 16:53:47.131+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:47.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:47:116,-0.006120,-0.035237,0.037404
06-07 16:53:47.151+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:47.151+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:47.151+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:47.151+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:47:159,2.751746,-0.205783,9.533006
06-07 16:53:47.171+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:47:142,2.544197,-0.266746,9.467116
06-07 16:53:47.171+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:47.181+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:47:176,0.420000,0.210000,-0.280000
06-07 16:53:47.181+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:47.181+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:47:162,0.121983,-0.035394,0.156081
06-07 16:53:47.191+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:47:183,2.547493,-0.266367,9.466241
06-07 16:53:47.201+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:47.201+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11120756c6f63152838322
