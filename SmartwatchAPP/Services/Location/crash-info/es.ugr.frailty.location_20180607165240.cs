S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11639
Date: 2018-06-07 16:52:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf769c52d, r5   = 0xf7819f98
r6   = 0xfff909f0, r7   = 0xfff908a0
r8   = 0xf7816c18, r9   = 0x00000000
r10  = 0xfff9097c, fp   = 0xfff909f0
ip   = 0x00000001, sp   = 0xfff90878
lr   = 0xf769c539, pc   = 0xf7705228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    179584 KB
Buffers:     14004 KB
Cached:     126300 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11860 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11639 TID = 11639
11639 11729 

Maps Information
f4567000 f4d66000 rw-p [stack:11729]
f4d6d000 f4d6f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d77000 f4d7b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d84000 f4d86000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d8e000 f4d91000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4da0000 f4da5000 r-xp /usr/lib/libsystem.so.0.0.0
f4db0000 f4db3000 r-xp /lib/libattr.so.1.1.0
f4dbb000 f4dcb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4dd3000 f4ddc000 r-xp /usr/lib/libedbus.so.1.7.99
f4de4000 f4de5000 r-xp /usr/lib/libresponse.so.0.2.96
f4dee000 f4df3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6695000 f679b000 r-xp /usr/lib/libicuuc.so.57.1
f67b1000 f6939000 r-xp /usr/lib/libicui18n.so.57.1
f6949000 f6956000 r-xp /usr/lib/libail.so.0.1.0
f695f000 f6966000 r-xp /usr/lib/libminizip.so.1.0.0
f696f000 f6b18000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b38000 f6b7f000 r-xp /usr/lib/libssl.so.1.0.0
f6b8b000 f6b8d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b95000 f6b9c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ba5000 f6bac000 r-xp /lib/libcrypt-2.13.so
f6bdd000 f6be0000 r-xp /lib/libcap.so.2.21
f6be8000 f6bea000 r-xp /usr/lib/libiri.so
f6bf2000 f6c3b000 r-xp /usr/lib/libmdm.so.1.2.69
f6c43000 f6c49000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c51000 f6c74000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c7e000 f6c80000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c88000 f6ca5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cae000 f6cb2000 r-xp /usr/lib/libsmack.so.1.0.0
f6cbb000 f6cd4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cdd000 f6ce5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ced000 f6cf3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cfc000 f6cfe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d07000 f6d17000 r-xp /lib/libresolv-2.13.so
f6d1b000 f6d33000 r-xp /usr/lib/liblzma.so.5.0.3
f6d3c000 f6d3e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d46000 f6d60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d68000 f6d97000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6da0000 f6daf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db9000 f6dc3000 r-xp /usr/lib/libsensord-shared.so
f6dcc000 f6e9f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6eaa000 f6ec0000 r-xp /lib/libz.so.1.2.5
f6ec8000 f6ecd000 r-xp /usr/lib/libffi.so.5.0.10
f6ed5000 f6ed6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ede000 f6eee000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ef6000 f6f0f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f17000 f6f19000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f21000 f6f96000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fa0000 f6fa6000 r-xp /lib/librt-2.13.so
f6faf000 f6fcd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fd7000 f6fd8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fe0000 f7003000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f700b000 f7010000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7018000 f7042000 r-xp /usr/lib/libdbus-1.so.3.8.12
f704b000 f7062000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f706a000 f70d3000 r-xp /lib/libm-2.13.so
f70dc000 f7170000 r-xp /usr/lib/libstdc++.so.6.0.16
f7183000 f7188000 r-xp /usr/lib/libctx-client.so.0.8.3
f7190000 f7197000 r-xp /usr/lib/libctx-shared.so.0.8.3
f719f000 f71c9000 r-xp /usr/lib/libsensor.so.1.9.6
f71d2000 f729e000 r-xp /usr/lib/libxml2.so.2.7.8
f72ab000 f72ad000 r-xp /usr/lib/libiniparser.so.0
f72b6000 f72bc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72c5000 f7395000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7396000 f73ca000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73d3000 f740f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7417000 f741a000 r-xp /usr/lib/libbundle.so.0.1.22
f7422000 f7428000 r-xp /usr/lib/libappsvc.so.0.1.0
f7430000 f7471000 r-xp /usr/lib/libeina.so.1.7.99
f747a000 f7491000 r-xp /usr/lib/libecore.so.1.7.99
f74a8000 f74b1000 r-xp /usr/lib/libvconf.so.0.2.45
f74b9000 f74cd000 r-xp /lib/libpthread-2.13.so
f74d8000 f74e5000 r-xp /usr/lib/libaul.so.0.1.0
f74ef000 f74f1000 r-xp /lib/libdl-2.13.so
f74fa000 f7505000 r-xp /lib/libunwind.so.8.0.1
f7532000 f753a000 r-xp /lib/libgcc_s-4.6.so.1
f753b000 f765f000 r-xp /lib/libc-2.13.so
f766d000 f766f000 r-xp /usr/lib/libdlog.so.0.0.0
f7677000 f7683000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f768c000 f7691000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7699000 f76a8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76b0000 f76b4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76bd000 f76c0000 r-xp /usr/lib/libappcore-agent.so.1.1
f76c8000 f76ca000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76d2000 f76d6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76de000 f76fb000 r-xp /lib/ld-2.13.so
f7704000 f7707000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7707000 f770b000 r-xp /usr/lib/libsys-assert.so
f77e6000 f7874000 rw-p [heap]
fff72000 fff93000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11639)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7705228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf769c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73a33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73e875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73e31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73a1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73ade57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73b3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73b3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73e5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73e6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73edf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d851fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d78171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e4b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72f8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72fa7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf748aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7485b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74865a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7486879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76be183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76be7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77055c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf755285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7704f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.gravity - capturing data
06-07 16:52:40.211+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:192,0.560000,0.840000,-0.280000
06-07 16:52:40.221+0200 W/LOCATION(11639): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:52:40.221+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:40.221+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 16:52:40.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 16:52:40.231+0200 E/APP_CORE(11560): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
06-07 16:52:40.231+0200 I/APP_CORE(11560): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
06-07 16:52:40.231+0200 I/CAPI_APPFW_APPLICATION(11560): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
06-07 16:52:40.231+0200 I/efl-extension(11560): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf80ed118, obj: 0xf80ed118
06-07 16:52:40.231+0200 I/efl-extension(11560): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
06-07 16:52:40.231+0200 I/efl-extension(11560): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
06-07 16:52:40.231+0200 I/efl-extension(11560): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
06-07 16:52:40.231+0200 I/efl-extension(11560): efl_extension_rotary.c: _object_deleted_cb(618) > done
06-07 16:52:40.241+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.241+0200 E/EFL     (11560): elementary<11560> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf80ed118 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
06-07 16:52:40.241+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:40:232,68
06-07 16:52:40.241+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:52:40.251+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:229,-0.052596,-0.154489,0.075610
06-07 16:52:40.251+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:236,3.318845,2.531606,8.791230
06-07 16:52:40.251+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.251+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.261+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:40.261+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:40:268,703.000000
06-07 16:52:40.271+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:215,3.386207,2.660419,8.810571
06-07 16:52:40.271+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.271+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:281,3.385106,2.668454,8.808564
06-07 16:52:40.271+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.281+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:251,-2.380000,0.490000,-0.140000
06-07 16:52:40.291+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.291+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:266,-0.077110,-0.005430,0.018355
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0xf810b558
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0xf8128888 is freed
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf80ed118, elm_scroller, func : 0xf3d16419
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf810b558, elm_image, func : 0xf3d16419
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 16:52:40.291+0200 I/efl-extension(11560): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0xf80ed118 : elm_scroller] rotary callabck is deleted
06-07 16:52:40.301+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:281,3.483950,2.720639,8.726624
06-07 16:52:40.301+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.301+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.311+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:305,1.260000,0.490000,-0.420000
06-07 16:52:40.321+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.331+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:285,3.382885,2.675283,8.807345
06-07 16:52:40.331+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.341+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:316,-0.045168,-0.038437,-0.021858
06-07 16:52:40.341+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:317,3.474378,2.792424,8.717053
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:40.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390360346,000000, pattern:[H:mm][0;m
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:40.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:40.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:52:40.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:52][0;m
06-07 16:52:40.341+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.351+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.351+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:52:40.371+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:363,3.378306,2.687027,8.805528
06-07 16:52:40.371+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.381+0200 I/APP_CORE(11560): appcore-efl.c: __after_loop(1243) > [APP 11560] After terminate() callback
06-07 16:52:40.391+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:383,3.374145,2.687213,8.807066
06-07 16:52:40.391+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.411+0200 E/AUL     ( 2479): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-07 16:52:40.421+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:400,3.374171,2.688725,8.806595
06-07 16:52:40.421+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.421+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:40.431+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:40:434,68
06-07 16:52:40.461+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:40.461+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:432,3.379652,2.692856,8.803230
06-07 16:52:40.461+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.471+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:40:467,673.000000
06-07 16:52:40.471+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:474,3.379749,2.694164,8.802793
06-07 16:52:40.471+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.481+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:339,0.700000,0.560000,-0.420000
06-07 16:52:40.491+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:365,0.022318,-0.003140,0.043509
06-07 16:52:40.491+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.491+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:368,3.323631,2.780460,8.729016
06-07 16:52:40.501+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.501+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.511+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:487,3.371114,2.695659,8.805646
06-07 16:52:40.511+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.521+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:518,3.365307,2.693282,8.808594
06-07 16:52:40.521+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.521+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:513,0.099587,-0.055192,0.057423
06-07 16:52:40.541+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:504,-3.010000,0.070000,0.350000
06-07 16:52:40.541+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.541+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:511,3.326023,2.782853,8.769694
06-07 16:52:40.541+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.541+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:533,3.364529,2.688286,8.810417
06-07 16:52:40.541+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.551+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.551+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:558,0.560000,0.560000,0.210000
06-07 16:52:40.551+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:552,3.368094,2.688033,8.809132
06-07 16:52:40.551+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.561+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:564,3.368362,2.688123,8.809002
06-07 16:52:40.561+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.561+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:552,3.385844,2.711068,8.743374
06-07 16:52:40.571+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.571+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:549,0.066716,-0.036413,-0.018373
06-07 16:52:40.571+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.571+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.581+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:576,1.190000,-0.210000,0.420000
06-07 16:52:40.581+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.591+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:571,3.363537,2.689213,8.810513
06-07 16:52:40.591+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.591+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:579,-0.037478,0.051409,-0.053388
06-07 16:52:40.591+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.591+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:592,-1.120000,-0.700000,0.490000
06-07 16:52:40.591+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:582,3.440879,2.696711,8.796017
06-07 16:52:40.601+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.601+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.601+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:606,3.282953,2.845066,8.831908
06-07 16:52:40.611+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:602,-0.051267,-0.041409,-0.020083
06-07 16:52:40.611+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:608,0.280000,-0.140000,0.070000
06-07 16:52:40.611+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.611+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.621+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:598,3.357330,2.691305,8.812242
06-07 16:52:40.621+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.621+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.621+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:40.631+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:40:633,69
06-07 16:52:40.631+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:623,0.560000,-0.350000,0.280000
06-07 16:52:40.631+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.631+0200 I/UXT     (11560): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
06-07 16:52:40.631+0200 I/UXT     (11560): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
06-07 16:52:40.631+0200 I/UXT     (11560): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
06-07 16:52:40.641+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:632,3.218346,2.629712,8.908479
06-07 16:52:40.651+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.651+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:620,-0.055317,-0.050540,0.069532
06-07 16:52:40.651+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.651+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:630,3.354391,2.690362,8.813648
06-07 16:52:40.651+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.661+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:40.661+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:658,-0.034334,-0.017740,0.092254
06-07 16:52:40.661+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:664,3.355148,2.690110,8.813437
06-07 16:52:40.661+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.671+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:40:667,634.000000
06-07 16:52:40.671+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:655,3.256632,2.701497,8.896514
06-07 16:52:40.681+0200 I/servicemanager(11604): es.ugr.frailty.accelerometer alive timeout
06-07 16:52:40.681+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:52:40.681+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.681+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.691+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11613
06-07 16:52:40.691+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11613)
06-07 16:52:40.691+0200 I/servicemanager(11604): es.ugr.frailty.accelerometer launch request sent!
06-07 16:52:40.691+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.691+0200 I/servicemanager(11604): es.ugr.frailty.gyroscope alive timeout
06-07 16:52:40.691+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:52:40.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.691+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.701+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.701+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:675,3.355464,2.691659,8.812844
06-07 16:52:40.701+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11616
06-07 16:52:40.701+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11616)
06-07 16:52:40.701+0200 I/servicemanager(11604): es.ugr.frailty.gyroscope launch request sent!
06-07 16:52:40.701+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.701+0200 I/servicemanager(11604): es.ugr.frailty.heartrate alive timeout
06-07 16:52:40.701+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:52:40.701+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.711+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:706,3.323631,2.711068,8.805587
06-07 16:52:40.711+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.711+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:703,0.041533,0.034657,0.022301
06-07 16:52:40.711+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11627
06-07 16:52:40.721+0200 W/CAPI_APPFW_APP_CONTROL(11627): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:40.721+0200 I/utils   (11627): specific action
06-07 16:52:40.721+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11627)
06-07 16:52:40.721+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:40.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(11627), cmd(0)
06-07 16:52:40.721+0200 I/servicemanager(11604): es.ugr.frailty.heartrate launch request sent!
06-07 16:52:40.721+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.721+0200 I/servicemanager(11604): es.ugr.frailty.location alive timeout
06-07 16:52:40.721+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:52:40.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.721+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.731+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11639
06-07 16:52:40.731+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11639)
06-07 16:52:40.731+0200 I/servicemanager(11604): es.ugr.frailty.location launch request sent!
06-07 16:52:40.731+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.741+0200 I/APP_CORE(11356): appcore-efl.c: __do_app(453) > [APP 11356] Event: MEM_FLUSH State: PAUSED
06-07 16:52:40.741+0200 I/servicemanager(11604): es.ugr.frailty.linearacceleration alive timeout
06-07 16:52:40.741+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:52:40.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.741+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.741+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:723,0.027966,0.038139,-0.133861
06-07 16:52:40.741+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:719,3.349952,2.610569,8.901299
06-07 16:52:40.741+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.741+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:714,3.349692,2.699959,8.812501
06-07 16:52:40.741+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.751+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11651
06-07 16:52:40.751+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11651)
06-07 16:52:40.751+0200 I/servicemanager(11604): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:52:40.751+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.751+0200 I/servicemanager(11604): es.ugr.frailty.gravity alive timeout
06-07 16:52:40.751+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:52:40.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11663
06-07 16:52:40.771+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11663)
06-07 16:52:40.771+0200 I/servicemanager(11604): es.ugr.frailty.gravity launch request sent!
06-07 16:52:40.771+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.771+0200 I/servicemanager(11604): es.ugr.frailty.pressure alive timeout
06-07 16:52:40.771+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:52:40.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.771+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.771+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:760,-0.046188,0.051655,-0.105628
06-07 16:52:40.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11673
06-07 16:52:40.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:52:40.811+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11594
06-07 16:52:40.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:52:40.821+0200 W/CAPI_APPFW_APP_CONTROL(11673): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:40.821+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11594
06-07 16:52:40.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:52:40.821+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:40.821+0200 I/utils   (11673): specific action
06-07 16:52:40.821+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:40.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11673), cmd(0)
06-07 16:52:40.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:52:40.831+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11673)
06-07 16:52:40.831+0200 I/servicemanager(11604): es.ugr.frailty.pressure launch request sent!
06-07 16:52:40.831+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.831+0200 I/servicemanager(11604): es.ugr.frailty.light alive timeout
06-07 16:52:40.831+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:52:40.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.841+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:40:834,68
06-07 16:52:40.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11679
06-07 16:52:40.841+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11679)
06-07 16:52:40.841+0200 I/servicemanager(11604): es.ugr.frailty.light launch request sent!
06-07 16:52:40.841+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.841+0200 I/servicemanager(11604): es.ugr.frailty.pedometer alive timeout
06-07 16:52:40.841+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:52:40.841+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:40.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11679), cmd(0)
06-07 16:52:40.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:52:40.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11604
06-07 16:52:40.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11697
06-07 16:52:40.861+0200 W/CAPI_APPFW_APP_CONTROL(11679): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:40.861+0200 I/utils   (11679): specific action
06-07 16:52:40.861+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:40.861+0200 W/CAPI_APPFW_APP_CONTROL(11697): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:40.861+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:40.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11697), cmd(0)
06-07 16:52:40.861+0200 I/utils   (11697): specific action
06-07 16:52:40.861+0200 W/AUL     (11604): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11697)
06-07 16:52:40.861+0200 I/servicemanager(11604): es.ugr.frailty.pedometer launch request sent!
06-07 16:52:40.861+0200 I/servicemanager(11604): App control destroyed.
06-07 16:52:40.861+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:40:871,627.000000
06-07 16:52:40.871+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:641,1.050000,0.350000,-0.210000
06-07 16:52:40.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:52:40.871+0200 W/AUL_PAD (11560): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
06-07 16:52:40.881+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:758,3.290131,2.768496,8.793623
06-07 16:52:40.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11594
06-07 16:52:40.881+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:52:40.881+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:762,3.345972,2.703636,8.812787
06-07 16:52:40.891+0200 I/efl-extension(11560): efl_extension.c: eext_mod_shutdown(46) > Shutdown
06-07 16:52:40.891+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.901+0200 W/CAPI_APPFW_APP_CONTROL(11616): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:52:40.901+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:40.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(15), pid(11616), cmd(0)
06-07 16:52:40.901+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.911+0200 I/utils   (11616): specific action
06-07 16:52:40.911+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.921+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:901,3.275774,2.890530,8.953942
06-07 16:52:40.921+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:923,-0.700000,0.210000,-0.210000
06-07 16:52:40.931+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:898,-0.076188,0.021850,0.034012
06-07 16:52:40.931+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.931+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.931+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:911,3.343483,2.705055,8.813296
06-07 16:52:40.931+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.951+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:959,3.335207,2.708017,8.815522
06-07 16:52:40.951+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.961+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:948,3.323631,2.636890,8.874979
06-07 16:52:40.981+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:945,-0.001190,-0.012715,0.065903
06-07 16:52:40.981+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:40.981+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:40.981+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:40.991+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:40:993,-0.001772,-0.017084,0.025915
06-07 16:52:40.991+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:40:964,-1.820000,0.210000,0.210000
06-07 16:52:40.991+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:40.991+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:40:994,3.416951,2.632105,8.779266
06-07 16:52:41.001+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:40:995,3.328286,2.709081,8.817810
06-07 16:52:41.021+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:41.031+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:41:33,69
06-07 16:52:41.041+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.041+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.041+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.051+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11560 pgid = 11560
06-07 16:52:41.051+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
06-07 16:52:41.061+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:41.071+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:41:71,603.000000
06-07 16:52:41.091+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:52:41.091+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:52:41.091+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:52:41.091+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:10,-0.280000,-0.070000,-0.210000
06-07 16:52:41.091+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.111+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:57,3.324553,2.709889,8.818970
06-07 16:52:41.111+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.111+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:53,3.335595,2.699104,8.779266
06-07 16:52:41.111+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:104,1.400000,-0.140000,-0.420000
06-07 16:52:41.121+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:52,0.068204,-0.075900,0.018213
06-07 16:52:41.121+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.131+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.141+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.141+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:148,-0.070000,-1.050000,-0.140000
06-07 16:52:41.151+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:118,3.324242,2.711770,8.818509
06-07 16:52:41.151+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.161+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:138,0.049798,-0.064369,0.014952
06-07 16:52:41.161+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.161+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:127,3.292524,2.847459,8.812766
06-07 16:52:41.161+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.161+0200 W/AUL_PAD ( 3366): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-07 16:52:41.171+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11560
06-07 16:52:41.171+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11560)
06-07 16:52:41.191+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:167,0.038770,-0.100700,-0.000175
06-07 16:52:41.191+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.191+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.201+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:172,3.302095,2.744568,8.843873
06-07 16:52:41.201+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:159,3.321754,2.714588,8.818580
06-07 16:52:41.211+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.211+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:203,-1.540000,-0.140000,-0.140000
06-07 16:52:41.211+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.221+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.221+0200 I/heartrate(11627): es.ugr.frailty.heartrate - capturing data
06-07 16:52:41.231+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:202,0.072270,-0.170092,0.009398
06-07 16:52:41.231+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.241+0200 I/AUL_PAD (11745): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-07 16:52:41.241+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:219,-3.710000,0.210000,-0.140000
06-07 16:52:41.241+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.251+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:226,3.333202,2.667997,8.810372
06-07 16:52:41.251+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.251+0200 I/heartrate(11627): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:52:41:235,69
06-07 16:52:41.251+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:216,3.320747,2.714249,8.819063
06-07 16:52:41.251+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.261+0200 I/light   (11679): es.ugr.frailty.light - capturing data
06-07 16:52:41.271+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:254,-2.730000,0.070000,0.210000
06-07 16:52:41.271+0200 I/light   (11679): es.ugr.frailty.light: SM-R760,07/06/2018,16:52:41:269,580.000000
06-07 16:52:41.271+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:256,3.366701,2.644069,8.829515
06-07 16:52:41.271+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.281+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:241,-0.048191,-0.006059,0.070250
06-07 16:52:41.281+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.291+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:262,3.316285,2.711870,8.821474
06-07 16:52:41.291+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.291+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.301+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:302,-0.630000,0.070000,0.280000
06-07 16:52:41.301+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:290,-0.074636,0.035392,0.001745
06-07 16:52:41.301+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.301+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.301+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:283,3.282953,2.742175,8.769694
06-07 16:52:41.301+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.311+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:296,3.316201,2.711321,8.821674
06-07 16:52:41.311+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.311+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:311,0.280000,0.140000,0.210000
06-07 16:52:41.311+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:315,3.268596,2.732604,8.836694
06-07 16:52:41.321+0200 I/efl-extension(11740): efl_extension.c: eext_mod_init(40) > Init
06-07 16:52:41.321+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:318,3.323257,2.710333,8.819322
06-07 16:52:41.331+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:309,0.003254,0.010132,-0.002414
06-07 16:52:41.341+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.341+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.351+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:356,3.329670,2.707819,8.817675
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:41.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390361360,000000, pattern:[H:mm][0;m
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:52:41.351+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:52:41.351+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:52:41.351+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:52][0;m
06-07 16:52:41.351+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.361+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:347,-0.011592,-0.076981,0.012244
06-07 16:52:41.361+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.361+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:367,3.278167,2.624927,8.927622
06-07 16:52:41.361+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.361+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:371,3.330809,2.766103,8.843873
06-07 16:52:41.371+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.371+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.371+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:364,-0.420000,0.070000,0.210000
06-07 16:52:41.371+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.371+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:378,3.328749,2.708732,8.817742
06-07 16:52:41.371+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:379,0.070000,0.910000,0.210000
06-07 16:52:41.371+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.371+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.381+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:383,-0.630000,0.280000,0.070000
06-07 16:52:41.381+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.381+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:377,-0.012844,0.016944,0.058716
06-07 16:52:41.381+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.381+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:52:41:385,3.407379,2.672783,8.738588
06-07 16:52:41.381+0200 I/accelerometer(11613): es.ugr.frailty.accelerometer - capturing data
06-07 16:52:41.391+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.401+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:52:41:392,0.070000,-0.140000,-0.210000
06-07 16:52:41.401+0200 I/gyroscope(11616): es.ugr.frailty.gyroscope - capturing data
06-07 16:52:41.431+0200 E/EFL     (11594): ecore_x<11594> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6986205 button=1
06-07 16:52:41.441+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] mouse move
06-07 16:52:41.441+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:407,3.328008,2.711622,8.817134
06-07 16:52:41.441+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:407,-0.048773,0.151678,-0.026013
06-07 16:52:41.441+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.451+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] mouse move
06-07 16:52:41.451+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] hold(0), freeze(0)
06-07 16:52:41.451+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 16:52:41.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:52:41.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(11639), cmd(0)
06-07 16:52:41.461+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] mouse move
06-07 16:52:41.461+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] hold(0), freeze(0)
06-07 16:52:41.461+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:52:41:456,0.013937,-0.000893,0.007852
06-07 16:52:41.461+0200 I/gravity (11663): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:52:41:462,3.327942,2.714144,8.816383
06-07 16:52:41.471+0200 I/linearacceleration(11651): es.ugr.frailty.linearacceleration - capturing data
06-07 16:52:41.471+0200 W/AUL     (11755): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 16:52:41.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 16:52:41.471+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 16:52:41.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11639
06-07 16:52:41.471+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 16:52:41.481+0200 I/gravity (11663): es.ugr.frailty.gravity - capturing data
06-07 16:52:41.491+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] mouse move
06-07 16:52:41.491+0200 E/EFL     (11594): elementary<11594> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf731d238 : elm_list] hold(0), freeze(0)
06-07 16:52:41.491+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11116396c6f63152838316
