S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14941
Date: 2018-06-07 17:02:54+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf742e52d, r5   = 0xf771bf98
r6   = 0xffab2bb0, r7   = 0xffab2a60
r8   = 0xf7718c18, r9   = 0x00000000
r10  = 0xffab2b3c, fp   = 0xffab2bb0
ip   = 0x00000001, sp   = 0xffab2a38
lr   = 0xf742e539, pc   = 0xf7497228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    216776 KB
Buffers:      9068 KB
Cached:      51156 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11540 KB
VmRSS:       11540 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14941 TID = 14941
14941 14959 

Maps Information
f42f9000 f4af8000 rw-p [stack:14959]
f4aff000 f4b01000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b09000 f4b0d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b16000 f4b18000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b20000 f4b23000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b32000 f4b37000 r-xp /usr/lib/libsystem.so.0.0.0
f4b42000 f4b45000 r-xp /lib/libattr.so.1.1.0
f4b4d000 f4b5d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b65000 f4b6e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b76000 f4b77000 r-xp /usr/lib/libresponse.so.0.2.96
f4b80000 f4b85000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6427000 f652d000 r-xp /usr/lib/libicuuc.so.57.1
f6543000 f66cb000 r-xp /usr/lib/libicui18n.so.57.1
f66db000 f66e8000 r-xp /usr/lib/libail.so.0.1.0
f66f1000 f66f8000 r-xp /usr/lib/libminizip.so.1.0.0
f6701000 f68aa000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ca000 f6911000 r-xp /usr/lib/libssl.so.1.0.0
f691d000 f691f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6927000 f692e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6937000 f693e000 r-xp /lib/libcrypt-2.13.so
f696f000 f6972000 r-xp /lib/libcap.so.2.21
f697a000 f697c000 r-xp /usr/lib/libiri.so
f6984000 f69cd000 r-xp /usr/lib/libmdm.so.1.2.69
f69d5000 f69db000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69e3000 f6a06000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a10000 f6a12000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a1a000 f6a37000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a40000 f6a44000 r-xp /usr/lib/libsmack.so.1.0.0
f6a4d000 f6a66000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a6f000 f6a77000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a7f000 f6a85000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a8e000 f6a90000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a99000 f6aa9000 r-xp /lib/libresolv-2.13.so
f6aad000 f6ac5000 r-xp /usr/lib/liblzma.so.5.0.3
f6ace000 f6ad0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ad8000 f6af2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6afa000 f6b29000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b32000 f6b41000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b4b000 f6b55000 r-xp /usr/lib/libsensord-shared.so
f6b5e000 f6c31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c3c000 f6c52000 r-xp /lib/libz.so.1.2.5
f6c5a000 f6c5f000 r-xp /usr/lib/libffi.so.5.0.10
f6c67000 f6c68000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c70000 f6c80000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c88000 f6ca1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ca9000 f6cab000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cb3000 f6d28000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d32000 f6d38000 r-xp /lib/librt-2.13.so
f6d41000 f6d5f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d69000 f6d6a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d72000 f6d95000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d9d000 f6da2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6daa000 f6dd4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ddd000 f6df4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dfc000 f6e65000 r-xp /lib/libm-2.13.so
f6e6e000 f6f02000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f15000 f6f1a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f22000 f6f29000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f31000 f6f5b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f64000 f7030000 r-xp /usr/lib/libxml2.so.2.7.8
f703d000 f703f000 r-xp /usr/lib/libiniparser.so.0
f7048000 f704e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7057000 f7127000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7128000 f715c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7165000 f71a1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71a9000 f71ac000 r-xp /usr/lib/libbundle.so.0.1.22
f71b4000 f71ba000 r-xp /usr/lib/libappsvc.so.0.1.0
f71c2000 f7203000 r-xp /usr/lib/libeina.so.1.7.99
f720c000 f7223000 r-xp /usr/lib/libecore.so.1.7.99
f723a000 f7243000 r-xp /usr/lib/libvconf.so.0.2.45
f724b000 f725f000 r-xp /lib/libpthread-2.13.so
f726a000 f7277000 r-xp /usr/lib/libaul.so.0.1.0
f7281000 f7283000 r-xp /lib/libdl-2.13.so
f728c000 f7297000 r-xp /lib/libunwind.so.8.0.1
f72c4000 f72cc000 r-xp /lib/libgcc_s-4.6.so.1
f72cd000 f73f1000 r-xp /lib/libc-2.13.so
f73ff000 f7401000 r-xp /usr/lib/libdlog.so.0.0.0
f7409000 f7415000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f741e000 f7423000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f742b000 f743a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7442000 f7446000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f744f000 f7452000 r-xp /usr/lib/libappcore-agent.so.1.1
f745a000 f745c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7464000 f7468000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7470000 f748d000 r-xp /lib/ld-2.13.so
f7496000 f7499000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7499000 f749d000 r-xp /usr/lib/libsys-assert.so
f76e8000 f7756000 rw-p [heap]
ffa94000 ffab5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14941)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7497228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf742e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71353f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7133c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf713fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7145be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7145dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf717a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71751f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7133c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf713fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7145be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7145dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7177e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7178017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf717ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b171fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b0a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bdd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf708afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf708c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf721cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7217b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72185a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7218879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7450183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74507fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74975c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72e485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7496f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ter: SM-R760,07/06/2018,17:02:54:239,2.617748,-0.311067,9.528220
06-07 17:02:54.231+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.241+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.241+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:243,-0.700000,0.210000,0.210000
06-07 17:02:54.241+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:246,2.631946,-0.384377,9.439041
06-07 17:02:54.241+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.241+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:251,2.629231,-0.382277,9.439883
06-07 17:02:54.241+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.251+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:255,2.631893,-0.380212,9.439224
06-07 17:02:54.251+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.251+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.251+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.251+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.251+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:262,2.624927,-0.404387,9.535398
06-07 17:02:54.261+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:262,2.635051,-0.382770,9.438240
06-07 17:02:54.261+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:261,-0.006966,-0.024175,0.096174
06-07 17:02:54.261+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:267,-0.770000,0.070000,0.140000
06-07 17:02:54.271+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.271+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.271+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:280,2.612962,-0.406780,9.542577
06-07 17:02:54.271+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:280,2.637096,-0.385325,9.437565
06-07 17:02:54.271+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.281+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.281+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:286,-0.022089,-0.024010,0.104337
06-07 17:02:54.281+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:285,-0.770000,0.140000,0.210000
06-07 17:02:54.291+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.291+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.291+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:300,2.629712,-0.390030,9.473185
06-07 17:02:54.291+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:301,2.638466,-0.386133,9.437149
06-07 17:02:54.291+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.301+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.301+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:54.301+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:306,-0.007384,-0.004705,0.035620
06-07 17:02:54.301+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:54:307,81
06-07 17:02:54.311+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:305,-0.280000,-0.280000,0.140000
06-07 17:02:54.311+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.311+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.311+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:54.321+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:54:324,697.000000
06-07 17:02:54.321+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:323,2.617748,-0.385244,9.506684
06-07 17:02:54.321+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.321+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:329,2.634686,-0.385579,9.438228
06-07 17:02:54.331+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:331,-0.020718,0.000889,0.069535
06-07 17:02:54.331+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.331+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:337,0.210000,0.140000,0.140000
06-07 17:02:54.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:339,2.598605,-0.313460,9.511470
06-07 17:02:54.331+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.341+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:54.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390974351,000000, pattern:[H:mm][0;m
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:54.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:54.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:02:54.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:02][0;m
06-07 17:02:54.341+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:346,-0.420000,0.140000,0.210000
06-07 17:02:54.351+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:345,-0.036080,0.072120,0.073242
06-07 17:02:54.351+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.351+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.351+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.361+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.361+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:360,-1.120000,0.070000,-0.070000
06-07 17:02:54.361+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:360,-0.016977,-0.054943,0.101860
06-07 17:02:54.371+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:366,2.617748,-0.437887,9.540184
06-07 17:02:54.371+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:359,2.634725,-0.382943,9.438324
06-07 17:02:54.371+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.371+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.371+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:379,-0.038908,-0.043128,0.058034
06-07 17:02:54.371+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:379,0.210000,0.280000,-0.140000
06-07 17:02:54.381+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.381+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.381+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:386,2.600998,-0.430708,9.494720
06-07 17:02:54.381+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:388,2.639906,-0.387580,9.436687
06-07 17:02:54.391+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.391+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.391+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.391+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:399,-0.034451,0.044464,0.073597
06-07 17:02:54.391+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:398,0.280000,0.210000,-0.070000
06-07 17:02:54.391+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.401+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:395,2.635449,-0.389031,9.437873
06-07 17:02:54.401+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.401+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:405,2.600998,-0.344566,9.511470
06-07 17:02:54.401+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:409,2.631080,-0.386197,9.439208
06-07 17:02:54.411+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.411+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.421+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:425,-0.022904,0.008131,0.048334
06-07 17:02:54.421+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:424,-0.560000,0.070000,0.140000
06-07 17:02:54.421+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.421+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.421+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:430,2.632802,-0.386899,9.438700
06-07 17:02:54.431+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:431,2.608176,-0.378066,9.487542
06-07 17:02:54.431+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.431+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.431+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:439,-0.010268,-0.043809,0.125412
06-07 17:02:54.431+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:439,-0.910000,0.070000,0.210000
06-07 17:02:54.431+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.431+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.441+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:445,2.636043,-0.390627,9.437641
06-07 17:02:54.441+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:445,2.622534,-0.430708,9.564112
06-07 17:02:54.451+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.451+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.461+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:462,-0.085294,-0.083152,0.102543
06-07 17:02:54.461+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:462,-0.280000,0.070000,0.350000
06-07 17:02:54.461+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.461+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.461+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:467,2.631278,-0.395099,9.438785
06-07 17:02:54.461+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:468,2.550749,-0.473779,9.540184
06-07 17:02:54.471+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.471+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.471+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:479,0.280000,-0.070000,0.350000
06-07 17:02:54.471+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:479,0.053469,-0.014073,0.065507
06-07 17:02:54.481+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.481+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.481+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:486,2.630432,-0.395167,9.439017
06-07 17:02:54.481+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:486,2.684747,-0.409173,9.504292
06-07 17:02:54.491+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.491+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.491+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:499,-0.420000,0.210000,0.210000
06-07 17:02:54.491+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:499,0.004065,0.033851,0.031775
06-07 17:02:54.501+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.501+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.501+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:54.501+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:507,2.634498,-0.361316,9.470792
06-07 17:02:54.501+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:54:507,81
06-07 17:02:54.511+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:505,2.632245,-0.394389,9.438545
06-07 17:02:54.511+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.511+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.521+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:54.521+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:524,-0.059960,-0.007606,0.123174
06-07 17:02:54.521+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:54:526,695.000000
06-07 17:02:54.521+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.531+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:524,-0.700000,0.140000,-0.070000
06-07 17:02:54.531+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.531+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.531+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.531+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:539,0.560000,0.070000,0.140000
06-07 17:02:54.531+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:540,-0.031394,-0.015637,0.147207
06-07 17:02:54.541+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:532,2.572284,-0.401994,9.561719
06-07 17:02:54.541+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.541+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:536,2.632392,-0.395928,9.438439
06-07 17:02:54.541+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.551+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:550,2.600998,-0.411566,9.585647
06-07 17:02:54.551+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.561+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:561,0.014267,-0.004282,0.047024
06-07 17:02:54.581+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.581+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:586,0.140000,0.070000,0.210000
06-07 17:02:54.581+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.591+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:551,2.625016,-0.395319,9.440518
06-07 17:02:54.591+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.601+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:595,-0.840000,-0.210000,0.350000
06-07 17:02:54.601+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.611+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:604,2.623589,-0.395201,9.440921
06-07 17:02:54.611+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.631+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:614,-0.070000,0.210000,0.210000
06-07 17:02:54.631+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.631+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.631+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:621,2.629330,-0.397901,9.439210
06-07 17:02:54.631+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.631+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.641+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:636,0.140000,0.070000,0.210000
06-07 17:02:54.641+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.641+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:640,2.639283,-0.399601,9.487542
06-07 17:02:54.641+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:642,2.628552,-0.396857,9.439470
06-07 17:02:54.641+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:641,0.030051,-0.021150,0.060978
06-07 17:02:54.651+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.651+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:647,-0.630000,-0.070000,0.140000
06-07 17:02:54.651+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.651+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.661+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.661+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:656,2.624967,-0.394643,9.440561
06-07 17:02:54.661+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.661+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:664,-0.070000,0.280000,0.140000
06-07 17:02:54.671+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.671+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:678,0.560000,0.210000,0.140000
06-07 17:02:54.671+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:671,2.630381,-0.396555,9.438973
06-07 17:02:54.681+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.691+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.701+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:686,2.628165,-0.394930,9.439659
06-07 17:02:54.701+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:54.701+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:667,2.653640,-0.416351,9.501899
06-07 17:02:54.701+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:669,0.014739,0.022228,0.091402
06-07 17:02:54.701+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.701+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:54:708,81
06-07 17:02:54.701+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.711+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:704,-0.420000,0.070000,0.420000
06-07 17:02:54.711+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.711+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:54.721+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:715,-0.020376,0.037934,0.115070
06-07 17:02:54.721+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:54:724,694.000000
06-07 17:02:54.721+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.721+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:718,2.644069,-0.375673,9.530612
06-07 17:02:54.721+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:729,-1.120000,-0.140000,0.280000
06-07 17:02:54.721+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.731+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:718,2.622010,-0.392885,9.441456
06-07 17:02:54.731+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.731+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.731+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.731+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:736,2.624280,-0.393469,9.440801
06-07 17:02:54.741+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:739,-0.490000,-0.140000,0.350000
06-07 17:02:54.741+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.741+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:740,2.608176,-0.358923,9.554541
06-07 17:02:54.741+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:736,0.059780,-0.016923,0.094837
06-07 17:02:54.741+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:747,2.629147,-0.400398,9.439156
06-07 17:02:54.741+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.741+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.751+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:753,2.630834,-0.400250,9.438692
06-07 17:02:54.751+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.751+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.751+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.751+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:760,0.280000,0.140000,-0.070000
06-07 17:02:54.761+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:755,-0.026990,0.035239,0.062925
06-07 17:02:54.761+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.761+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:760,2.627140,-0.399826,9.439738
06-07 17:02:54.771+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:759,2.684747,-0.411566,9.535398
06-07 17:02:54.771+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.771+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.771+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:780,0.280000,0.140000,-0.140000
06-07 17:02:54.771+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.781+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:773,-0.019989,0.016864,0.078989
06-07 17:02:54.781+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.781+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:780,2.623150,-0.397937,9.440928
06-07 17:02:54.791+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.791+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:798,0.280000,0.140000,-0.140000
06-07 17:02:54.801+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:793,0.029237,0.005247,0.067621
06-07 17:02:54.801+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.801+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:807,-0.018497,-0.099452,0.075455
06-07 17:02:54.801+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.801+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.811+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:785,2.603391,-0.361316,9.501899
06-07 17:02:54.811+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:811,-0.011399,0.024725,0.055565
06-07 17:02:54.811+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.811+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.821+0200 W/LOCATION(14941): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:02:54.821+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:813,2.619880,-0.397926,9.441836
06-07 17:02:54.821+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.821+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:823,-0.140000,-0.140000,0.070000
06-07 17:02:54.821+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.831+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:820,-0.017871,-0.006530,0.072778
06-07 17:02:54.831+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.831+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:830,2.608176,-0.378066,9.518648
06-07 17:02:54.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.831+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:835,2.621429,-0.398596,9.441378
06-07 17:02:54.831+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.831+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:840,-0.490000,-0.280000,0.350000
06-07 17:02:54.841+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.841+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:844,2.651247,-0.387637,9.509077
06-07 17:02:54.841+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:837,-0.030927,0.024153,0.071732
06-07 17:02:54.841+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.851+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.851+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:850,2.624085,-0.401368,9.440522
06-07 17:02:54.851+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.851+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.851+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:857,2.605784,-0.492921,9.516255
06-07 17:02:54.851+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:861,-0.420000,-0.140000,0.210000
06-07 17:02:54.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.861+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:854,-0.024545,-0.013628,0.022686
06-07 17:02:54.861+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:861,2.625902,-0.402972,9.439949
06-07 17:02:54.861+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:870,2.617748,-0.375673,9.494720
06-07 17:02:54.871+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.871+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.871+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.871+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:879,0.070000,-0.070000,0.210000
06-07 17:02:54.871+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:879,2.623230,-0.405108,9.440600
06-07 17:02:54.871+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:870,0.036153,-0.011247,0.088776
06-07 17:02:54.871+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.881+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:877,2.612962,-0.406780,9.511470
06-07 17:02:54.881+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.881+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:885,0.008283,-0.036897,0.055736
06-07 17:02:54.881+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:889,2.596212,-0.375673,9.511470
06-07 17:02:54.881+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.891+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.891+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.891+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.891+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:899,0.420000,-0.070000,0.210000
06-07 17:02:54.891+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:899,2.619038,-0.404313,9.441798
06-07 17:02:54.901+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:54.901+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:895,2.598605,-0.411566,9.463614
06-07 17:02:54.901+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.901+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:54:907,82
06-07 17:02:54.901+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:909,2.656033,-0.409173,9.530612
06-07 17:02:54.901+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.911+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:897,0.005627,-0.017376,0.078126
06-07 17:02:54.911+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.911+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:914,2.629712,-0.435494,9.497113
06-07 17:02:54.911+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.911+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.911+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.911+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:54.921+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:924,0.140000,-0.140000,-0.140000
06-07 17:02:54.921+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:925,2.617273,-0.404118,9.442296
06-07 17:02:54.921+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:54:924,694.000000
06-07 17:02:54.931+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:917,-0.020118,-0.049271,0.073914
06-07 17:02:54.931+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.931+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:920,2.629712,-0.418744,9.518648
06-07 17:02:54.931+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.931+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.931+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:939,0.560000,-0.140000,0.210000
06-07 17:02:54.931+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:939,2.613553,-0.402104,9.443413
06-07 17:02:54.941+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.941+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:937,-0.012660,-0.001672,0.058905
06-07 17:02:54.941+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.941+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:946,2.605784,-0.452243,9.513863
06-07 17:02:54.941+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.951+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:952,2.610569,-0.406780,9.499505
06-07 17:02:54.951+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.951+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:950,-0.013254,-0.004860,0.067279
06-07 17:02:54.951+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.951+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.951+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.951+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:960,0.070000,-0.070000,0.210000
06-07 17:02:54.951+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:960,2.611998,-0.402306,9.443834
06-07 17:02:54.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:958,2.605784,-0.409173,9.509077
06-07 17:02:54.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:970,2.641676,-0.387637,9.540184
06-07 17:02:54.961+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:959,0.024404,0.016480,0.097888
06-07 17:02:54.971+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.971+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.971+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.971+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.971+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:979,-0.420000,-0.140000,0.280000
06-07 17:02:54.971+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:979,2.614949,-0.402674,9.443002
06-07 17:02:54.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:977,2.620141,-0.411566,9.537791
06-07 17:02:54.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.981+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:977,0.006588,-0.009462,0.094378
06-07 17:02:54.981+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:54.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:54:989,2.639283,-0.392423,9.501899
06-07 17:02:54.991+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:54:990,0.027285,0.009883,0.058064
06-07 17:02:54.991+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:54.991+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:54.991+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:54:998,-0.350000,-0.140000,0.280000
06-07 17:02:54.991+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:54.991+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:54:999,2.615222,-0.405519,9.442804
06-07 17:02:54.991+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.001+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:6,-0.006773,-0.047176,0.106753
06-07 17:02:55.011+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:2,2.608176,-0.449851,9.549755
06-07 17:02:55.011+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.011+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.011+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.021+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:25,-0.019010,-0.027582,0.118915
06-07 17:02:55.021+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:24,2.607377,-0.405022,9.444995
06-07 17:02:55.021+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:24,0.840000,-0.140000,0.280000
06-07 17:02:55.021+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.031+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.031+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.031+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:39,2.603405,-0.402251,9.446209
06-07 17:02:55.031+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:34,2.596212,-0.433101,9.561719
06-07 17:02:55.031+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.031+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:39,0.630000,-0.350000,0.280000
06-07 17:02:55.031+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.041+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:43,-0.003985,0.034134,0.009048
06-07 17:02:55.041+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:45,2.603391,-0.370888,9.454042
06-07 17:02:55.051+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.061+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.061+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:66,-0.028728,0.007435,0.048512
06-07 17:02:55.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:02:55.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:02:55.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:02:55.061+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.061+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:64,2.598006,-0.400548,9.447767
06-07 17:02:55.071+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:71,0.630000,-0.140000,-0.070000
06-07 17:02:55.071+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.071+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.071+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.071+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:80,2.592144,-0.398199,9.449477
06-07 17:02:55.071+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.081+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:78,-0.004187,0.015303,0.073275
06-07 17:02:55.081+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:81,0.770000,-0.140000,0.140000
06-07 17:02:55.081+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:84,2.574677,-0.394816,9.494720
06-07 17:02:55.081+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.091+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:93,2.593820,-0.385244,9.521042
06-07 17:02:55.091+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.091+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.091+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:99,2.591756,-0.396519,9.449654
06-07 17:02:55.091+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:99,0.140000,0.070000,0.210000
06-07 17:02:55.091+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.091+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.101+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:55.101+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:104,2.636890,-0.370888,9.525827
06-07 17:02:55.101+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:55:107,81
06-07 17:02:55.101+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:103,0.044747,0.027311,0.076350
06-07 17:02:55.111+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:55.111+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.111+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.121+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:55:124,693.000000
06-07 17:02:55.121+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.121+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.121+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:124,2.632105,-0.390030,9.554541
06-07 17:02:55.121+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:124,-0.560000,-0.070000,0.210000
06-07 17:02:55.131+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:130,2.595585,-0.397210,9.448574
06-07 17:02:55.131+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.131+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:131,0.040349,0.006489,0.104887
06-07 17:02:55.131+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.131+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.131+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.141+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:139,0.490000,-0.070000,0.210000
06-07 17:02:55.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:142,2.610569,-0.449851,9.547362
06-07 17:02:55.141+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:143,2.591716,-0.398587,9.449577
06-07 17:02:55.141+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:142,0.014984,-0.052640,0.098788
06-07 17:02:55.151+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.151+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.151+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.161+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:160,0.052353,0.034878,0.069071
06-07 17:02:55.161+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:160,1.330000,-0.070000,0.070000
06-07 17:02:55.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:162,2.644069,-0.363709,9.518648
06-07 17:02:55.161+0200 I/gravity (14945): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:55:163,2.584717,-0.394131,9.451681
06-07 17:02:55.171+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.171+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.171+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:55:179,0.350000,-0.140000,0.070000
06-07 17:02:55.171+0200 I/gravity (14945): es.ugr.frailty.gravity - capturing data
06-07 17:02:55.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:55.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:55:186,2.627320,-0.313460,9.497113
06-07 17:02:55.181+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:180,0.042602,0.080672,0.045432
06-07 17:02:55.191+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:55.191+0200 I/gyroscope(14975): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:55.201+0200 I/linearacceleration(14989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:55:202,0.021941,0.042584,0.064145
06-07 17:02:55.211+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11149416c6f63152838377
