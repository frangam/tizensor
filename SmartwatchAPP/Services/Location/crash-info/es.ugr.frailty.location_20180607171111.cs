S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17346
Date: 2018-06-07 17:11:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf768452d, r5   = 0xf7c73f98
r6   = 0xffc487b0, r7   = 0xffc48660
r8   = 0xf7c70c18, r9   = 0x00000000
r10  = 0xffc4873c, fp   = 0xffc487b0
ip   = 0x00000001, sp   = 0xffc48638
lr   = 0xf7684539, pc   = 0xf76ed228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     53268 KB
Buffers:     13560 KB
Cached:      61644 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11352 KB
VmRSS:       11352 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17346 TID = 17346
17346 17354 

Maps Information
f454f000 f4d4e000 rw-p [stack:17354]
f4d55000 f4d57000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d5f000 f4d63000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d6c000 f4d6e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d76000 f4d79000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d88000 f4d8d000 r-xp /usr/lib/libsystem.so.0.0.0
f4d98000 f4d9b000 r-xp /lib/libattr.so.1.1.0
f4da3000 f4db3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dbb000 f4dc4000 r-xp /usr/lib/libedbus.so.1.7.99
f4dcc000 f4dcd000 r-xp /usr/lib/libresponse.so.0.2.96
f4dd6000 f4ddb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f667d000 f6783000 r-xp /usr/lib/libicuuc.so.57.1
f6799000 f6921000 r-xp /usr/lib/libicui18n.so.57.1
f6931000 f693e000 r-xp /usr/lib/libail.so.0.1.0
f6947000 f694e000 r-xp /usr/lib/libminizip.so.1.0.0
f6957000 f6b00000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b20000 f6b67000 r-xp /usr/lib/libssl.so.1.0.0
f6b73000 f6b75000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b7d000 f6b84000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b8d000 f6b94000 r-xp /lib/libcrypt-2.13.so
f6bc5000 f6bc8000 r-xp /lib/libcap.so.2.21
f6bd0000 f6bd2000 r-xp /usr/lib/libiri.so
f6bda000 f6c23000 r-xp /usr/lib/libmdm.so.1.2.69
f6c2b000 f6c31000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c39000 f6c5c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c66000 f6c68000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c70000 f6c8d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c96000 f6c9a000 r-xp /usr/lib/libsmack.so.1.0.0
f6ca3000 f6cbc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cc5000 f6ccd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cd5000 f6cdb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ce4000 f6ce6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cef000 f6cff000 r-xp /lib/libresolv-2.13.so
f6d03000 f6d1b000 r-xp /usr/lib/liblzma.so.5.0.3
f6d24000 f6d26000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d2e000 f6d48000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d50000 f6d7f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d88000 f6d97000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6da1000 f6dab000 r-xp /usr/lib/libsensord-shared.so
f6db4000 f6e87000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e92000 f6ea8000 r-xp /lib/libz.so.1.2.5
f6eb0000 f6eb5000 r-xp /usr/lib/libffi.so.5.0.10
f6ebd000 f6ebe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ec6000 f6ed6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ede000 f6ef7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eff000 f6f01000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f09000 f6f7e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f88000 f6f8e000 r-xp /lib/librt-2.13.so
f6f97000 f6fb5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fbf000 f6fc0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fc8000 f6feb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ff3000 f6ff8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7000000 f702a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7033000 f704a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7052000 f70bb000 r-xp /lib/libm-2.13.so
f70c4000 f7158000 r-xp /usr/lib/libstdc++.so.6.0.16
f716b000 f7170000 r-xp /usr/lib/libctx-client.so.0.8.3
f7178000 f717f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7187000 f71b1000 r-xp /usr/lib/libsensor.so.1.9.6
f71ba000 f7286000 r-xp /usr/lib/libxml2.so.2.7.8
f7293000 f7295000 r-xp /usr/lib/libiniparser.so.0
f729e000 f72a4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72ad000 f737d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f737e000 f73b2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73bb000 f73f7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73ff000 f7402000 r-xp /usr/lib/libbundle.so.0.1.22
f740a000 f7410000 r-xp /usr/lib/libappsvc.so.0.1.0
f7418000 f7459000 r-xp /usr/lib/libeina.so.1.7.99
f7462000 f7479000 r-xp /usr/lib/libecore.so.1.7.99
f7490000 f7499000 r-xp /usr/lib/libvconf.so.0.2.45
f74a1000 f74b5000 r-xp /lib/libpthread-2.13.so
f74c0000 f74cd000 r-xp /usr/lib/libaul.so.0.1.0
f74d7000 f74d9000 r-xp /lib/libdl-2.13.so
f74e2000 f74ed000 r-xp /lib/libunwind.so.8.0.1
f751a000 f7522000 r-xp /lib/libgcc_s-4.6.so.1
f7523000 f7647000 r-xp /lib/libc-2.13.so
f7655000 f7657000 r-xp /usr/lib/libdlog.so.0.0.0
f765f000 f766b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7674000 f7679000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7681000 f7690000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7698000 f769c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76a5000 f76a8000 r-xp /usr/lib/libappcore-agent.so.1.1
f76b0000 f76b2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76ba000 f76be000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76c6000 f76e3000 r-xp /lib/ld-2.13.so
f76ec000 f76ef000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76ef000 f76f3000 r-xp /usr/lib/libsys-assert.so
f7c40000 f7cb1000 rw-p [heap]
ffc29000 ffc4a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17346)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76ed228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7684539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf738b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7389c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7395e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf739bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf739bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73d075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73cb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7389c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7395e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf739bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf739bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73cde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73ce017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73d5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d6d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d60171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e33663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72e0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72e27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7472ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf746db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf746e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf746e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76a6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76a67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76ed5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf753a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76ecf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
tem_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:10.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391470354,000000, pattern:[H:mm][0;m
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:10.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:10.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:11:10.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:11][0;m
06-07 17:11:10.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:350,0.272782,-0.557528,9.923036
06-07 17:11:10.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.351+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:359,0.296710,-0.543171,9.798609
06-07 17:11:10.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.361+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:366,0.287139,-0.605384,9.786645
06-07 17:11:10.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:372,0.306281,-0.531207,9.789038
06-07 17:11:10.371+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:352,0.280000,0.420000,-0.070000
06-07 17:11:10.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.371+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:361,0.015563,-0.018455,-0.003142
06-07 17:11:10.371+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:378,0.244068,-0.600598,9.765109
06-07 17:11:10.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.371+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:384,0.239282,-0.626920,9.772287
06-07 17:11:10.381+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:373,0.277810,-0.586746,9.785138
06-07 17:11:10.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.381+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:385,0.910000,-0.070000,0.070000
06-07 17:11:10.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:390,0.337388,-0.643669,9.824929
06-07 17:11:10.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.391+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.391+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:395,0.351745,-0.586242,9.856036
06-07 17:11:10.391+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.391+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:385,0.027397,-0.139053,0.018484
06-07 17:11:10.401+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:402,0.279960,-0.600598,9.798609
06-07 17:11:10.401+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.401+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.401+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.401+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:407,0.248854,-0.531207,9.834501
06-07 17:11:10.401+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:397,0.278634,-0.587775,9.785053
06-07 17:11:10.401+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:10.401+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17219), cmd(0)
06-07 17:11:10.411+0200 W/CAPI_APPFW_APP_CONTROL(17219): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:10.411+0200 I/utils   (17219): specific action
06-07 17:11:10.411+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.411+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.411+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:418,0.344566,-0.600598,9.808180
06-07 17:11:10.411+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.421+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:408,-0.070000,-0.140000,0.070000
06-07 17:11:10.421+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:411,0.039361,-0.024197,0.075912
06-07 17:11:10.421+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:425,0.301496,-0.658026,9.722038
06-07 17:11:10.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:432,0.272782,-0.607777,9.705289
06-07 17:11:10.431+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.431+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:433,-0.560000,0.420000,0.420000
06-07 17:11:10.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:440,0.303888,-0.602991,9.760324
06-07 17:11:10.441+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.441+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:424,0.276658,-0.582995,9.785396
06-07 17:11:10.441+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.441+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:447,0.284746,-0.557528,9.889536
06-07 17:11:10.441+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.441+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:438,0.030615,-0.046521,0.014132
06-07 17:11:10.451+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.451+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:10.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:453,0.251246,-0.602991,9.834501
06-07 17:11:10.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.451+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:10:458,605.000000
06-07 17:11:10.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:461,0.234497,-0.629312,9.793823
06-07 17:11:10.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:467,0.291924,-0.607777,9.824929
06-07 17:11:10.461+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:473,0.299103,-0.586242,9.812965
06-07 17:11:10.471+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:452,0.274164,-0.582090,9.785520
06-07 17:11:10.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.471+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.471+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:472,0.070000,0.140000,0.420000
06-07 17:11:10.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:479,0.270389,-0.617348,9.772287
06-07 17:11:10.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.481+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:485,0.270389,-0.669990,9.748360
06-07 17:11:10.481+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.481+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.481+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:476,0.011215,-0.051502,-0.016766
06-07 17:11:10.481+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.481+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:491,0.308674,-0.574277,9.848858
06-07 17:11:10.491+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.491+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:498,0.282353,-0.557528,9.822537
06-07 17:11:10.491+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:10.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:503,0.287139,-0.612563,9.760324
06-07 17:11:10.501+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:10:504,80
06-07 17:11:10.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.501+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:486,0.273109,-0.584241,9.785420
06-07 17:11:10.501+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:497,0.067064,0.002969,0.021676
06-07 17:11:10.501+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:509,0.287139,-0.617348,9.808180
06-07 17:11:10.501+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.511+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:494,0.490000,0.140000,0.210000
06-07 17:11:10.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:516,0.334995,-0.636491,9.820145
06-07 17:11:10.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.511+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:522,0.267996,-0.689133,9.817751
06-07 17:11:10.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.521+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:528,0.267996,-0.662812,9.786645
06-07 17:11:10.521+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.531+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:525,0.490000,0.210000,0.210000
06-07 17:11:10.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:534,0.277567,-0.571885,9.894321
06-07 17:11:10.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.531+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:520,0.273688,-0.584856,9.785368
06-07 17:11:10.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:540,0.291924,-0.535992,9.918249
06-07 17:11:10.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.541+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:546,0.265603,-0.564706,9.762716
06-07 17:11:10.541+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:546,0.273984,-0.586215,9.785278
06-07 17:11:10.541+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.541+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:529,0.012413,0.101149,0.074312
06-07 17:11:10.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.541+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:552,0.256032,-0.614955,9.753145
06-07 17:11:10.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:559,0.318245,-0.614955,9.741181
06-07 17:11:10.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.561+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:556,-0.021679,0.041875,0.047747
06-07 17:11:10.561+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:564,0.334995,-0.617348,9.793823
06-07 17:11:10.561+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:555,-0.350000,0.280000,0.210000
06-07 17:11:10.561+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.561+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.561+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.561+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.561+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:570,0.267996,-0.653241,9.844072
06-07 17:11:10.571+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.571+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:577,-0.000767,-0.038722,0.049552
06-07 17:11:10.571+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:577,0.267996,-0.605384,9.870394
06-07 17:11:10.571+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:582,0.282353,-0.662812,9.887143
06-07 17:11:10.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.581+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:569,0.274190,-0.587707,9.785183
06-07 17:11:10.581+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:588,0.282353,-0.612563,9.817751
06-07 17:11:10.581+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:576,-0.210000,0.210000,0.350000
06-07 17:11:10.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.591+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:594,0.313460,-0.581456,9.786645
06-07 17:11:10.591+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:601,0.327817,-0.626920,9.829715
06-07 17:11:10.601+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.601+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:594,0.273976,-0.589449,9.785084
06-07 17:11:10.601+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:606,0.236889,-0.555135,9.827322
06-07 17:11:10.601+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.601+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:599,0.042923,-0.023787,-0.029748
06-07 17:11:10.601+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:605,-0.280000,0.070000,0.420000
06-07 17:11:10.601+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:612,0.287139,-0.588634,9.839286
06-07 17:11:10.611+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.611+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:618,0.296710,-0.629312,9.769895
06-07 17:11:10.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.621+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:625,0.311067,-0.717847,9.786645
06-07 17:11:10.621+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.621+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:625,0.038388,-0.001099,-0.029830
06-07 17:11:10.621+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:630,0.325424,-0.619741,9.865608
06-07 17:11:10.631+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.631+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:625,-0.700000,0.070000,0.420000
06-07 17:11:10.631+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:621,0.274204,-0.586852,9.785233
06-07 17:11:10.631+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:637,0.294317,-0.591027,9.865608
06-07 17:11:10.631+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.631+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.641+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.641+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.641+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:643,0.272782,-0.586242,9.822537
06-07 17:11:10.641+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.651+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:651,0.279960,-0.605384,9.774680
06-07 17:11:10.651+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:10.651+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.661+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:10:659,605.000000
06-07 17:11:10.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:661,0.279960,-0.614955,9.846465
06-07 17:11:10.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.661+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:647,0.273187,-0.584569,9.785398
06-07 17:11:10.671+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:670,0.289532,-0.636491,9.839286
06-07 17:11:10.671+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.671+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:647,0.034179,-0.049934,0.006054
06-07 17:11:10.671+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.671+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:679,0.246461,-0.648455,9.822537
06-07 17:11:10.671+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:651,-0.630000,-0.280000,0.210000
06-07 17:11:10.681+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.681+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:688,0.296710,-0.550349,9.743573
06-07 17:11:10.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.691+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:693,0.284746,-0.593420,9.834501
06-07 17:11:10.691+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.691+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:686,0.275102,-0.587894,9.785146
06-07 17:11:10.691+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:689,0.036733,-0.096672,0.101895
06-07 17:11:10.691+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:700,0.265603,-0.650848,9.781858
06-07 17:11:10.691+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:10.701+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.701+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:706,0.308674,-0.631705,9.827322
06-07 17:11:10.701+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:10:705,80
06-07 17:11:10.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:712,0.277567,-0.643669,9.812965
06-07 17:11:10.711+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:691,-0.070000,-0.280000,0.210000
06-07 17:11:10.711+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.711+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.711+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:718,0.318245,-0.638884,9.868000
06-07 17:11:10.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:725,0.315853,-0.555135,9.848858
06-07 17:11:10.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.721+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:719,0.001321,0.029720,0.137749
06-07 17:11:10.731+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:731,0.284746,-0.612563,9.798609
06-07 17:11:10.731+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.731+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:738,0.279960,-0.629312,9.762716
06-07 17:11:10.731+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:723,0.276938,-0.591435,9.784881
06-07 17:11:10.731+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.731+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:726,0.280000,0.630000,0.210000
06-07 17:11:10.741+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:743,0.320638,-0.607777,9.841680
06-07 17:11:10.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.741+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:749,0.296710,-0.576670,9.836893
06-07 17:11:10.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.751+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:747,0.025481,0.045146,0.013380
06-07 17:11:10.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:755,0.224925,-0.595813,9.801002
06-07 17:11:10.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.751+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:755,0.210000,0.420000,0.210000
06-07 17:11:10.761+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:761,0.236889,-0.591027,9.851252
06-07 17:11:10.761+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:750,0.278986,-0.593368,9.784706
06-07 17:11:10.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.761+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.761+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.761+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:768,0.294317,-0.624527,9.801002
06-07 17:11:10.761+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.761+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:773,0.284746,-0.650848,9.882358
06-07 17:11:10.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.771+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:780,0.350000,-0.070000,-0.070000
06-07 17:11:10.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:780,0.334995,-0.672383,9.765109
06-07 17:11:10.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.781+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:769,0.016576,-0.019825,0.001232
06-07 17:11:10.781+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:785,0.272782,-0.610170,9.860823
06-07 17:11:10.781+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:774,0.278552,-0.597269,9.784481
06-07 17:11:10.781+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.781+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.781+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:791,0.277567,-0.550349,9.848858
06-07 17:11:10.791+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:799,0.284746,-0.514457,9.853643
06-07 17:11:10.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.801+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:804,0.296710,-0.591027,9.784252
06-07 17:11:10.801+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:794,0.034522,0.051521,0.003489
06-07 17:11:10.801+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:803,-0.770000,-0.420000,-0.070000
06-07 17:11:10.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.801+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:809,0.248854,-0.650848,9.829715
06-07 17:11:10.801+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:797,0.277017,-0.597636,9.784502
06-07 17:11:10.811+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.811+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:816,-0.027476,-0.018771,-0.020499
06-07 17:11:10.811+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:816,0.354138,-0.650848,9.801002
06-07 17:11:10.811+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.811+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.821+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.821+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:822,0.313460,-0.660419,9.839286
06-07 17:11:10.821+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.821+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:826,0.276457,-0.595181,9.784667
06-07 17:11:10.821+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:10.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(17305), cmd(0)
06-07 17:11:10.831+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:827,-0.350000,0.280000,0.210000
06-07 17:11:10.831+0200 W/CAPI_APPFW_APP_CONTROL(17305): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:10.841+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.841+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.851+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:10.851+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:10:857,605.000000
06-07 17:11:10.861+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:846,0.275590,-0.591130,9.784937
06-07 17:11:10.861+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:850,-0.490000,0.350000,0.140000
06-07 17:11:10.861+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.871+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.871+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:871,0.275942,-0.590457,9.784968
06-07 17:11:10.881+0200 I/utils   (17305): specific action
06-07 17:11:10.881+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.891+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:829,0.291924,-0.576670,9.891929
06-07 17:11:10.891+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:895,-0.033076,-0.048359,-0.013492
06-07 17:11:10.891+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:10.901+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:10:904,80
06-07 17:11:10.901+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:875,-0.070000,0.630000,0.210000
06-07 17:11:10.911+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.921+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.921+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.931+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.941+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:922,0.301496,-0.509671,9.796216
06-07 17:11:10.941+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:932,0.276086,-0.593263,9.784794
06-07 17:11:10.941+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:936,0.490000,0.350000,0.140000
06-07 17:11:10.951+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.961+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:942,0.064870,-0.061723,0.039355
06-07 17:11:10.971+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:10.971+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:10.971+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:10:978,0.277317,-0.594438,9.784688
06-07 17:11:10.971+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:10.981+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:10:967,0.282353,-0.607777,9.820145
06-07 17:11:10.991+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:10.991+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:10:990,0.079618,-0.001652,0.070609
06-07 17:11:11.001+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:10:979,0.210000,-0.210000,0.140000
06-07 17:11:11.001+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.001+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.011+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.021+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:8,0.308674,-0.650848,9.810574
06-07 17:11:11.021+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:30,0.006394,-0.015844,0.013231
06-07 17:11:11.031+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:19,-0.210000,0.420000,0.140000
06-07 17:11:11.031+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:15,0.278378,-0.593567,9.784711
06-07 17:11:11.031+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.041+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.041+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.051+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.061+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:53,0.267996,-0.646062,9.829715
06-07 17:11:11.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:11:11.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:11:11.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:11:11.061+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:11.071+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:11:72,606.000000
06-07 17:11:11.071+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:47,0.277870,-0.595832,9.784588
06-07 17:11:11.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:48,-0.070000,0.840000,0.140000
06-07 17:11:11.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.081+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:59,-0.026104,0.050724,0.048995
06-07 17:11:11.081+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.091+0200 W/LOCATION(17346): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:11:11.091+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.091+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:11.101+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:11:104,79
06-07 17:11:11.111+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.121+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:103,0.277533,-0.595589,9.784612
06-07 17:11:11.121+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:118,0.291924,-0.629312,9.846465
06-07 17:11:11.121+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:98,0.140000,-0.140000,0.280000
06-07 17:11:11.131+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.131+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.141+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:121,0.069965,-0.019162,0.022634
06-07 17:11:11.141+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.141+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:148,-0.490000,-0.210000,0.560000
06-07 17:11:11.151+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.161+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:164,0.028323,-0.079040,-0.063693
06-07 17:11:11.161+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:151,0.276844,-0.595709,9.784624
06-07 17:11:11.161+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.171+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.171+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:158,0.306281,-0.605384,9.822537
06-07 17:11:11.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:179,-1.610000,0.420000,0.840000
06-07 17:11:11.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.181+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.191+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.191+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:191,0.275175,-0.612563,9.853643
06-07 17:11:11.191+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:182,0.276714,-0.595298,9.784653
06-07 17:11:11.201+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.201+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:190,-0.002638,-0.027716,-0.080316
06-07 17:11:11.201+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.221+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:210,-1.610000,0.630000,1.050000
06-07 17:11:11.231+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:218,0.027347,-0.019534,-0.025047
06-07 17:11:11.231+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:212,0.277658,-0.593063,9.784762
06-07 17:11:11.241+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.241+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.241+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:246,-1.330000,-0.210000,1.120000
06-07 17:11:11.241+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.241+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:229,0.287139,-0.636491,9.805787
06-07 17:11:11.241+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.251+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:11.251+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:253,-0.560000,0.070000,1.190000
06-07 17:11:11.251+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:11:261,605.000000
06-07 17:11:11.261+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.261+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:249,0.278642,-0.592629,9.784760
06-07 17:11:11.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:266,-0.910000,0.420000,0.840000
06-07 17:11:11.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.281+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:282,0.490000,0.140000,0.420000
06-07 17:11:11.281+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.291+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:292,2.100000,0.840000,0.420000
06-07 17:11:11.291+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.291+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:11.301+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.311+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:11:304,79
06-07 17:11:11.311+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:314,0.313460,-0.617348,9.841680
06-07 17:11:11.311+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:253,0.006936,0.029219,0.104398
06-07 17:11:11.311+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.321+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:322,0.318245,-0.607777,9.836893
06-07 17:11:11.321+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.321+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.321+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:328,0.270389,-0.612563,9.805787
06-07 17:11:11.331+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.331+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.331+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:336,0.236889,-0.595813,9.894321
06-07 17:11:11.331+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.331+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:11:340,-0.027388,-0.015216,0.049448
06-07 17:11:11.331+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:11.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:343,0.325424,-0.583849,9.868000
06-07 17:11:11.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391471352,000000, pattern:[H:mm][0;m
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:11.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:11.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:11:11.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:11][0;m
06-07 17:11:11.351+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:11:301,2.100000,0.560000,0.070000
06-07 17:11:11.351+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:11:328,0.276372,-0.591593,9.784887
06-07 17:11:11.351+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:11.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:11:350,0.287139,-0.622134,9.805787
06-07 17:11:11.361+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:11.371+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11173466c6f63152838427
