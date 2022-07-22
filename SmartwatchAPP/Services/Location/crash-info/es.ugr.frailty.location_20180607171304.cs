S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18043
Date: 2018-06-07 17:13:04+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf766e52d, r5   = 0xf7ce6f98
r6   = 0xff8777a0, r7   = 0xff877650
r8   = 0xf7ce3c18, r9   = 0x00000000
r10  = 0xff87772c, fp   = 0xff8777a0
ip   = 0x00000001, sp   = 0xff877628
lr   = 0xf766e539, pc   = 0xf76d7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    290588 KB
Buffers:     13820 KB
Cached:      80136 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11616 KB
VmRSS:       11616 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18043 TID = 18043
18043 18131 

Maps Information
f4539000 f4d38000 rw-p [stack:18131]
f4d3f000 f4d41000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d49000 f4d4d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d56000 f4d58000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d60000 f4d63000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d72000 f4d77000 r-xp /usr/lib/libsystem.so.0.0.0
f4d82000 f4d85000 r-xp /lib/libattr.so.1.1.0
f4d8d000 f4d9d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4da5000 f4dae000 r-xp /usr/lib/libedbus.so.1.7.99
f4db6000 f4db7000 r-xp /usr/lib/libresponse.so.0.2.96
f4dc0000 f4dc5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6667000 f676d000 r-xp /usr/lib/libicuuc.so.57.1
f6783000 f690b000 r-xp /usr/lib/libicui18n.so.57.1
f691b000 f6928000 r-xp /usr/lib/libail.so.0.1.0
f6931000 f6938000 r-xp /usr/lib/libminizip.so.1.0.0
f6941000 f6aea000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b0a000 f6b51000 r-xp /usr/lib/libssl.so.1.0.0
f6b5d000 f6b5f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b67000 f6b6e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b77000 f6b7e000 r-xp /lib/libcrypt-2.13.so
f6baf000 f6bb2000 r-xp /lib/libcap.so.2.21
f6bba000 f6bbc000 r-xp /usr/lib/libiri.so
f6bc4000 f6c0d000 r-xp /usr/lib/libmdm.so.1.2.69
f6c15000 f6c1b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c23000 f6c46000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c50000 f6c52000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c5a000 f6c77000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c80000 f6c84000 r-xp /usr/lib/libsmack.so.1.0.0
f6c8d000 f6ca6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6caf000 f6cb7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cbf000 f6cc5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cce000 f6cd0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cd9000 f6ce9000 r-xp /lib/libresolv-2.13.so
f6ced000 f6d05000 r-xp /usr/lib/liblzma.so.5.0.3
f6d0e000 f6d10000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d18000 f6d32000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d3a000 f6d69000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d72000 f6d81000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d8b000 f6d95000 r-xp /usr/lib/libsensord-shared.so
f6d9e000 f6e71000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e7c000 f6e92000 r-xp /lib/libz.so.1.2.5
f6e9a000 f6e9f000 r-xp /usr/lib/libffi.so.5.0.10
f6ea7000 f6ea8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eb0000 f6ec0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ec8000 f6ee1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ee9000 f6eeb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ef3000 f6f68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f72000 f6f78000 r-xp /lib/librt-2.13.so
f6f81000 f6f9f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fa9000 f6faa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fb2000 f6fd5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fdd000 f6fe2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fea000 f7014000 r-xp /usr/lib/libdbus-1.so.3.8.12
f701d000 f7034000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f703c000 f70a5000 r-xp /lib/libm-2.13.so
f70ae000 f7142000 r-xp /usr/lib/libstdc++.so.6.0.16
f7155000 f715a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7162000 f7169000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7171000 f719b000 r-xp /usr/lib/libsensor.so.1.9.6
f71a4000 f7270000 r-xp /usr/lib/libxml2.so.2.7.8
f727d000 f727f000 r-xp /usr/lib/libiniparser.so.0
f7288000 f728e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7297000 f7367000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7368000 f739c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73a5000 f73e1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73e9000 f73ec000 r-xp /usr/lib/libbundle.so.0.1.22
f73f4000 f73fa000 r-xp /usr/lib/libappsvc.so.0.1.0
f7402000 f7443000 r-xp /usr/lib/libeina.so.1.7.99
f744c000 f7463000 r-xp /usr/lib/libecore.so.1.7.99
f747a000 f7483000 r-xp /usr/lib/libvconf.so.0.2.45
f748b000 f749f000 r-xp /lib/libpthread-2.13.so
f74aa000 f74b7000 r-xp /usr/lib/libaul.so.0.1.0
f74c1000 f74c3000 r-xp /lib/libdl-2.13.so
f74cc000 f74d7000 r-xp /lib/libunwind.so.8.0.1
f7504000 f750c000 r-xp /lib/libgcc_s-4.6.so.1
f750d000 f7631000 r-xp /lib/libc-2.13.so
f763f000 f7641000 r-xp /usr/lib/libdlog.so.0.0.0
f7649000 f7655000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f765e000 f7663000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f766b000 f767a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7682000 f7686000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f768f000 f7692000 r-xp /usr/lib/libappcore-agent.so.1.1
f769a000 f769c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76a4000 f76a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76b0000 f76cd000 r-xp /lib/ld-2.13.so
f76d6000 f76d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76d9000 f76dd000 r-xp /usr/lib/libsys-assert.so
f7cb3000 f7d21000 rw-p [heap]
ff858000 ff879000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18043)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76d7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf766e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7373c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf737fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7385be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7385dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73ba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73b51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7373c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf737fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7385be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7385dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73b7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73b8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73bff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d4a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e1d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72cafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72cc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf745cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7457b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7458879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7690183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76d75c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf752485c) [/lib/libc.so.6] + 0x1785c
29: (0xf76d6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
es.ugr.frailty.pedometer launch request sent!
06-07 17:13:04.321+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.321+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:284,4.036692,-8.159525,-0.669990
06-07 17:13:04.331+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:284,0.258927,1.096318,0.172846
06-07 17:13:04.331+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:317,3.031553,-9.315682,0.445110
06-07 17:13:04.331+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.331+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:04.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391584353,000000, pattern:[H:mm][0;m
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:13:04.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:13:04.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:13:04.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:13][0;m
06-07 17:13:04.351+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.351+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:345,2.178951,0.469815,-3.743530
06-07 17:13:04.351+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:332,-112.840004,-47.110001,-31.780001
06-07 17:13:04.351+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:361,2.691180,-9.429180,0.136008
06-07 17:13:04.361+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.361+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:345,3.857230,-8.324631,-0.445065
06-07 17:13:04.371+0200 W/CAPI_APPFW_APP_CONTROL(18050): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.371+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:04.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18050), cmd(0)
06-07 17:13:04.371+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 17:13:04.371+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.371+0200 I/utils   (18050): specific action
06-07 17:13:04.371+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.381+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.381+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:373,-101.220001,-45.009998,-35.980000
06-07 17:13:04.381+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.391+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:385,2.956952,2.061926,-2.023565
06-07 17:13:04.391+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:381,3.847659,-8.683553,-1.131805
06-07 17:13:04.401+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.401+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.401+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:390,2.263108,-9.540589,-0.160882
06-07 17:13:04.411+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.411+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:397,-87.080002,-43.750000,-34.369999
06-07 17:13:04.411+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.421+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:408,3.866802,-8.499306,-1.761117
06-07 17:13:04.421+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.421+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:420,1.740492,-9.641504,-0.427160
06-07 17:13:04.421+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:413,3.066399,2.859393,-2.570668
06-07 17:13:04.431+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.441+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.441+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:428,-62.720001,-38.709999,-32.689999
06-07 17:13:04.441+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.451+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:433,3.637090,-8.554340,-2.665605
06-07 17:13:04.451+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.451+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:440,3.600235,0.755515,-3.810388
06-07 17:13:04.461+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.461+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:446,1.551126,-9.668710,-0.529576
06-07 17:13:04.471+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.471+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:453,-50.540001,-35.279999,-41.299999
06-07 17:13:04.471+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.471+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:461,2.522035,-8.444271,0.011964
06-07 17:13:04.471+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:482,-34.580002,-44.939999,-30.660000
06-07 17:13:04.481+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:470,3.941373,0.099978,-3.099703
06-07 17:13:04.481+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.481+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:04.491+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:04:492,292.000000
06-07 17:13:04.491+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:475,1.149754,-9.714829,-0.685964
06-07 17:13:04.491+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.491+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.491+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:488,3.919443,-9.171689,-4.170690
06-07 17:13:04.501+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.501+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:501,3.740765,1.917743,-3.165333
06-07 17:13:04.501+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:503,0.654203,-9.747743,-0.850830
06-07 17:13:04.501+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.511+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:04.511+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:04.511+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.511+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:509,-42.630001,-66.080002,-29.960001
06-07 17:13:04.511+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.521+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.521+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:524,0.423136,-9.745446,-1.008773
06-07 17:13:04.521+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:513,4.508078,-7.606783,-2.553142
06-07 17:13:04.531+0200 W/CAPI_APPFW_APP_CONTROL(18010): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.531+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:04.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18010), cmd(0)
06-07 17:13:04.531+0200 I/utils   (18010): specific action
06-07 17:13:04.531+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:533,-62.930000,-50.610001,-32.619999
06-07 17:13:04.531+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.531+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:523,-2.215574,-1.292786,-4.675783
06-07 17:13:04.531+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.531+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.541+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.541+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:547,0.343783,-9.737488,-1.110641
06-07 17:13:04.551+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:542,4.216154,-6.855437,-3.256632
06-07 17:13:04.551+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:544,-2.466806,-0.853316,-4.022925
06-07 17:13:04.551+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.551+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:555,-35.000000,-51.520000,-31.990000
06-07 17:13:04.561+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.561+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.561+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.571+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:575,-8.260000,-40.810001,-36.610001
06-07 17:13:04.571+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:568,-2.361287,-0.573723,-3.235815
06-07 17:13:04.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:563,4.254438,-8.992228,-4.661219
06-07 17:13:04.571+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.571+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:569,7.537211,-6.225462,-0.777460
06-07 17:13:04.581+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.581+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.591+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.591+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:584,4.364508,-9.645468,-4.108476
06-07 17:13:04.591+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:591,7.218952,-6.559649,-1.013967
06-07 17:13:04.591+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:588,-1.701685,-0.767971,-3.037875
06-07 17:13:04.591+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:600,3.360000,-27.370001,-32.060001
06-07 17:13:04.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.601+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:606,4.084548,-7.819745,-4.275974
06-07 17:13:04.601+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.601+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.611+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.611+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:613,6.989006,-6.769849,-1.222013
06-07 17:13:04.621+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.621+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:612,-1.440342,-1.022513,-2.824492
06-07 17:13:04.621+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.621+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.631+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:619,11.550000,-19.389999,-28.980000
06-07 17:13:04.631+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:634,6.791219,-6.936918,-1.388847
06-07 17:13:04.631+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.641+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:630,-0.546911,0.069048,-3.111938
06-07 17:13:04.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:626,5.321638,-7.518249,-5.453243
06-07 17:13:04.641+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.641+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.651+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:643,21.840000,-10.570000,-30.450001
06-07 17:13:04.651+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.651+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:657,6.594482,-7.098726,-1.513696
06-07 17:13:04.651+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:650,4.752146,-7.412964,-5.036892
06-07 17:13:04.651+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.661+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.661+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:665,39.270000,-15.540000,-31.780001
06-07 17:13:04.661+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.671+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:670,6.394970,-7.264266,-1.582779
06-07 17:13:04.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:674,70.840004,-20.790001,-41.509998
06-07 17:13:04.671+0200 W/CAPI_APPFW_APP_CONTROL(18054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.671+0200 I/utils   (18054): specific action
06-07 17:13:04.671+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.671+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:04.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18054), cmd(0)
06-07 17:13:04.671+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.681+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:682,6.220308,-7.405900,-1.621978
06-07 17:13:04.681+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:04.681+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.691+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:04:693,297.000000
06-07 17:13:04.691+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.691+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:685,77.139999,-17.290001,-52.779999
06-07 17:13:04.691+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:654,-0.578032,0.009685,-3.405343
06-07 17:13:04.691+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.701+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:703,75.180000,-5.670000,-35.349998
06-07 17:13:04.701+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:699,6.111020,-7.488618,-1.657235
06-07 17:13:04.701+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.701+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:705,-1.803939,1.102174,-2.422528
06-07 17:13:04.711+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.711+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:693,4.627719,-7.343572,-4.457829
06-07 17:13:04.711+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.711+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:709,6.070523,-7.502218,-1.742369
06-07 17:13:04.711+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:04.711+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:04.711+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.721+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:722,6.041420,-7.518596,-1.772665
06-07 17:13:04.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:712,32.200001,7.700000,-19.950001
06-07 17:13:04.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.721+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.721+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:727,28.280001,2.800000,-25.480000
06-07 17:13:04.731+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.731+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:738,31.010000,49.980000,-10.150000
06-07 17:13:04.731+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:732,6.088588,-7.484612,-1.755009
06-07 17:13:04.731+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.731+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:717,-0.119574,0.323750,-1.645868
06-07 17:13:04.741+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.741+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:719,5.089533,-7.704889,-4.426722
06-07 17:13:04.741+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.741+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:746,53.270000,45.779999,-25.200001
06-07 17:13:04.741+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.741+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:744,6.071260,-7.503052,-1.736200
06-07 17:13:04.741+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.751+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.751+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:758,63.980000,66.080002,-15.190001
06-07 17:13:04.751+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:755,6.076416,-7.526175,-1.613762
06-07 17:13:04.751+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.751+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:746,5.154140,-8.121240,-4.338188
06-07 17:13:04.761+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:754,-1.124169,0.340128,-1.926639
06-07 17:13:04.761+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.761+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:765,6.178012,-7.452859,-1.567621
06-07 17:13:04.761+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.771+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.771+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:769,24.360001,94.430000,16.660000
06-07 17:13:04.771+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.771+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.781+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:776,6.254730,-7.401575,-1.505134
06-07 17:13:04.781+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.781+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:776,5.848059,-7.195218,-4.694718
06-07 17:13:04.781+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.781+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:780,8.470000,82.739998,30.450001
06-07 17:13:04.781+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.791+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:788,6.394313,-7.268702,-1.564967
06-07 17:13:04.791+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:794,-33.459999,79.029999,42.000000
06-07 17:13:04.791+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.791+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:801,6.317935,-7.342598,-1.529811
06-07 17:13:04.791+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:781,-0.235744,-1.009908,-1.508801
06-07 17:13:04.801+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.801+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.801+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.801+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:809,-0.306950,0.712222,-1.532395
06-07 17:13:04.801+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:806,39.060001,35.279999,42.349998
06-07 17:13:04.811+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.811+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:810,6.167173,-7.493641,-1.407728
06-07 17:13:04.811+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.821+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:816,80.010002,51.939999,41.580002
06-07 17:13:04.821+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.821+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:827,59.290001,43.889999,38.849998
06-07 17:13:04.821+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:822,6.070275,-7.588254,-1.319296
06-07 17:13:04.821+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:13:04.821+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:13:04.821+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.821+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.831+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:833,6.052386,-7.625122,-1.181748
06-07 17:13:04.831+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.831+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:837,48.369999,47.459999,28.700001
06-07 17:13:04.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18010
06-07 17:13:04.841+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.841+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:843,5.980994,-7.688072,-1.136509
06-07 17:13:04.841+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18010)
06-07 17:13:04.841+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:13:04.841+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.841+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:13:04.841+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:13:04.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.841+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.851+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:850,44.240002,42.560001,31.080000
06-07 17:13:04.851+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:855,5.909588,-7.749033,-1.095277
06-07 17:13:04.851+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.851+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18020
06-07 17:13:04.861+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:862,33.599998,46.200001,35.980000
06-07 17:13:04.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18020)
06-07 17:13:04.861+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:13:04.861+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.861+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:13:04.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:13:04.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.861+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.871+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:865,5.938167,-7.726000,-1.103394
06-07 17:13:04.871+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.871+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:873,-5.600000,41.020000,33.529999
06-07 17:13:04.871+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:13:04.881+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.881+0200 I/utils   (18034): specific action
06-07 17:13:04.881+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:04.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(18034), cmd(0)
06-07 17:13:04.881+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:878,6.019354,-7.659066,-1.129810
06-07 17:13:04.881+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:13:04.881+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:13:04.881+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.881+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:13:04.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:13:04.881+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:04.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.891+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:04:894,321.000000
06-07 17:13:04.891+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:884,-28.980000,25.200001,26.950001
06-07 17:13:04.891+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18043
06-07 17:13:04.901+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:892,6.101101,-7.592327,-1.141717
06-07 17:13:04.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18043)
06-07 17:13:04.901+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:13:04.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.901+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:13:04.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:13:04.901+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.911+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:914,6.112277,-7.588087,-1.109682
06-07 17:13:04.911+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:903,-38.709999,7.840000,3.220000
06-07 17:13:04.911+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.911+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:04.911+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:04.911+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:920,0.560000,5.810000,-7.210000
06-07 17:13:04.921+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18050
06-07 17:13:04.921+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:926,6.053121,-7.638685,-1.086554
06-07 17:13:04.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18050)
06-07 17:13:04.921+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:13:04.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.921+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:13:04.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:13:04.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.921+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.931+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.931+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:936,5.921424,-7.744171,-1.065335
06-07 17:13:04.931+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:932,13.020000,9.030000,7.630000
06-07 17:13:04.931+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18054
06-07 17:13:04.941+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:942,18.059999,3.640000,19.320000
06-07 17:13:04.941+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18054)
06-07 17:13:04.941+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:13:04.941+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.941+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:13:04.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:13:04.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.941+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:04.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.951+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:791,5.642276,-7.396214,-5.027320
06-07 17:13:04.951+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:04.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:13:04.961+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:04.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:04.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18075), cmd(0)
06-07 17:13:04.961+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:949,5.746460,-7.887311,-0.968974
06-07 17:13:04.961+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.961+0200 I/utils   (18075): specific action
06-07 17:13:04.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:13:04.961+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:13:04.961+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.961+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:13:04.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:13:04.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.971+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:04.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:13:04.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:13:04.991+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:13:04.991+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:04.991+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:13:04.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:13:04.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:13:04.991+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:04.991+0200 I/utils   (18079): specific action
06-07 17:13:04.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:13:04.991+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:04:982,5.539691,-8.051473,-0.809941
06-07 17:13:05.001+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:04:955,44.170002,0.420000,11.060000
06-07 17:13:05.001+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:05.001+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:04:964,-1.259665,0.850200,-1.013557
06-07 17:13:05.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:13:05.001+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:05.001+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:05.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18079), cmd(0)
06-07 17:13:05.011+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:04:976,4.307081,-6.386444,-4.079762
06-07 17:13:05.011+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:05.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(18111), cmd(0)
06-07 17:13:05.011+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:05.011+0200 I/utils   (18111): specific action
06-07 17:13:05.011+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:13:05.011+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:13:05.011+0200 I/servicemanager(17973): App control destroyed.
06-07 17:13:05.011+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.011+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:05:12,0.052898,0.472995,-2.303966
06-07 17:13:05.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:22,5.950950,-7.178468,-3.388237
06-07 17:13:05.021+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:05.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:28,4.917251,-7.178468,-3.699304
06-07 17:13:05.021+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.021+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:05:9,66.430000,5.950000,3.780000
06-07 17:13:05.041+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:33,5.852845,-8.494520,-3.263810
06-07 17:13:05.041+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.041+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:48,5.764310,-6.790830,-3.268596
06-07 17:13:05.041+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.051+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:05.051+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:05.051+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:05:28,5.397268,-8.152021,-0.764483
06-07 17:13:05.061+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:53,4.816752,-6.675975,-2.627320
06-07 17:13:05.061+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.071+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:05.081+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:13:05.091+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:13:05.091+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:13:05.091+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:13:05.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:74,6.230910,-6.979864,-3.871587
06-07 17:13:05.091+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:13:05:96,274.000000
06-07 17:13:05.091+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:104,5.056034,-5.876772,-3.172883
06-07 17:13:05.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:109,5.596812,-9.229117,-3.349952
06-07 17:13:05.101+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.111+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:05:56,26.950001,3.710000,10.850000
06-07 17:13:05.111+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:05.111+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:05:60,-1.198696,1.524803,-1.667749
06-07 17:13:05.111+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:13:05.111+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:13:05.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:115,6.156733,-7.640282,-2.187040
06-07 17:13:05.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.111+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:05.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:121,6.324231,-7.300502,-0.763310
06-07 17:13:05.111+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:125,5.469993,-7.054041,-2.237289
06-07 17:13:05.121+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.121+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:05:95,5.383868,-8.156014,-0.814723
06-07 17:13:05.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:130,5.735595,-8.518449,-2.321038
06-07 17:13:05.131+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:05.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:139,5.424529,-8.068598,-1.959722
06-07 17:13:05.131+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.131+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:05:119,-9.310000,1.260000,15.400000
06-07 17:13:05.141+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:05.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:144,5.414958,-7.391429,-1.301696
06-07 17:13:05.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.141+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:05:131,-0.797501,-1.960416,-1.784985
06-07 17:13:05.141+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:149,5.228317,-8.822337,-0.492921
06-07 17:13:05.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.151+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration - capturing data
06-07 17:13:05.151+0200 I/gravity (18054): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:13:05:138,5.498548,-8.064097,-0.952197
06-07 17:13:05.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:156,4.874180,-9.954143,-0.169890
06-07 17:13:05.151+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.151+0200 W/CAPI_APPFW_APP_CONTROL(18054): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:05.151+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:05.151+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18054), cmd(0)
06-07 17:13:05.161+0200 I/utils   (18054): specific action
06-07 17:13:05.161+0200 I/gravity (18054): es.ugr.frailty.gravity - capturing data
06-07 17:13:05.161+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:163,5.005785,-9.485149,-1.237089
06-07 17:13:05.161+0200 I/linearacceleration(18050): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:13:05:161,-0.161202,-0.297684,-0.657228
06-07 17:13:05.161+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:13:05.161+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(18010), cmd(0)
06-07 17:13:05.171+0200 W/CAPI_APPFW_APP_CONTROL(18010): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:13:05.171+0200 I/utils   (18010): specific action
06-07 17:13:05.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.171+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:13:05:149,-38.849998,5.320000,20.860001
06-07 17:13:05.171+0200 I/gyroscope(18020): es.ugr.frailty.gyroscope - capturing data
06-07 17:13:05.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:13:05:177,4.426722,-7.826923,-1.052842
06-07 17:13:05.171+0200 I/accelerometer(18010): es.ugr.frailty.accelerometer - capturing data
06-07 17:13:05.181+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11180436c6f63152838438
