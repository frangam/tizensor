S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13497
Date: 2018-06-07 16:58:06+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76e652d, r5   = 0xf7854f98
r6   = 0xfffdbcd0, r7   = 0xfffdbb80
r8   = 0xf7851c18, r9   = 0x00000000
r10  = 0xfffdbc5c, fp   = 0xfffdbcd0
ip   = 0x00000001, sp   = 0xfffdbb58
lr   = 0xf76e6539, pc   = 0xf774f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    224048 KB
Buffers:      6800 KB
Cached:      51848 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11508 KB
VmRSS:       11504 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13497 TID = 13497
13497 13518 

Maps Information
f45b1000 f4db0000 rw-p [stack:13518]
f4db7000 f4db9000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dc1000 f4dc5000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dce000 f4dd0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dd8000 f4ddb000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dea000 f4def000 r-xp /usr/lib/libsystem.so.0.0.0
f4dfa000 f4dfd000 r-xp /lib/libattr.so.1.1.0
f4e05000 f4e15000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e1d000 f4e26000 r-xp /usr/lib/libedbus.so.1.7.99
f4e2e000 f4e2f000 r-xp /usr/lib/libresponse.so.0.2.96
f4e38000 f4e3d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66df000 f67e5000 r-xp /usr/lib/libicuuc.so.57.1
f67fb000 f6983000 r-xp /usr/lib/libicui18n.so.57.1
f6993000 f69a0000 r-xp /usr/lib/libail.so.0.1.0
f69a9000 f69b0000 r-xp /usr/lib/libminizip.so.1.0.0
f69b9000 f6b62000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b82000 f6bc9000 r-xp /usr/lib/libssl.so.1.0.0
f6bd5000 f6bd7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bdf000 f6be6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bef000 f6bf6000 r-xp /lib/libcrypt-2.13.so
f6c27000 f6c2a000 r-xp /lib/libcap.so.2.21
f6c32000 f6c34000 r-xp /usr/lib/libiri.so
f6c3c000 f6c85000 r-xp /usr/lib/libmdm.so.1.2.69
f6c8d000 f6c93000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c9b000 f6cbe000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cc8000 f6cca000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cd2000 f6cef000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cf8000 f6cfc000 r-xp /usr/lib/libsmack.so.1.0.0
f6d05000 f6d1e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d27000 f6d2f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d37000 f6d3d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d46000 f6d48000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d51000 f6d61000 r-xp /lib/libresolv-2.13.so
f6d65000 f6d7d000 r-xp /usr/lib/liblzma.so.5.0.3
f6d86000 f6d88000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d90000 f6daa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6db2000 f6de1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dea000 f6df9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e03000 f6e0d000 r-xp /usr/lib/libsensord-shared.so
f6e16000 f6ee9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ef4000 f6f0a000 r-xp /lib/libz.so.1.2.5
f6f12000 f6f17000 r-xp /usr/lib/libffi.so.5.0.10
f6f1f000 f6f20000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f28000 f6f38000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f40000 f6f59000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f61000 f6f63000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f6b000 f6fe0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fea000 f6ff0000 r-xp /lib/librt-2.13.so
f6ff9000 f7017000 r-xp /usr/lib/libsystemd.so.0.4.0
f7021000 f7022000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f702a000 f704d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7055000 f705a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7062000 f708c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7095000 f70ac000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b4000 f711d000 r-xp /lib/libm-2.13.so
f7126000 f71ba000 r-xp /usr/lib/libstdc++.so.6.0.16
f71cd000 f71d2000 r-xp /usr/lib/libctx-client.so.0.8.3
f71da000 f71e1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71e9000 f7213000 r-xp /usr/lib/libsensor.so.1.9.6
f721c000 f72e8000 r-xp /usr/lib/libxml2.so.2.7.8
f72f5000 f72f7000 r-xp /usr/lib/libiniparser.so.0
f7300000 f7306000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f730f000 f73df000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73e0000 f7414000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f741d000 f7459000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7461000 f7464000 r-xp /usr/lib/libbundle.so.0.1.22
f746c000 f7472000 r-xp /usr/lib/libappsvc.so.0.1.0
f747a000 f74bb000 r-xp /usr/lib/libeina.so.1.7.99
f74c4000 f74db000 r-xp /usr/lib/libecore.so.1.7.99
f74f2000 f74fb000 r-xp /usr/lib/libvconf.so.0.2.45
f7503000 f7517000 r-xp /lib/libpthread-2.13.so
f7522000 f752f000 r-xp /usr/lib/libaul.so.0.1.0
f7539000 f753b000 r-xp /lib/libdl-2.13.so
f7544000 f754f000 r-xp /lib/libunwind.so.8.0.1
f757c000 f7584000 r-xp /lib/libgcc_s-4.6.so.1
f7585000 f76a9000 r-xp /lib/libc-2.13.so
f76b7000 f76b9000 r-xp /usr/lib/libdlog.so.0.0.0
f76c1000 f76cd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76d6000 f76db000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76e3000 f76f2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76fa000 f76fe000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7707000 f770a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7712000 f7714000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f771c000 f7720000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7728000 f7745000 r-xp /lib/ld-2.13.so
f774e000 f7751000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7751000 f7755000 r-xp /usr/lib/libsys-assert.so
f7821000 f78af000 rw-p [heap]
fffbd000 fffde000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13497)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf774f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76e6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73ed3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73ebc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73f7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73fdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73fddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf743275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf742d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73ebc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73f7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73fdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73fddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf742fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7430017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7437f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dcf1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dc2171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e95663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7342fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73447a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74d4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74cfb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74d05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74d0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7708183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77087fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf774f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf759c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf774ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 launch.c: app_request_to_launchpad(298) > request cmd(0) result(13455)
06-07 16:58:05.941+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:58:05.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:05.941+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:58:05.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:58:05.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:05.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:05.941+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:05:925,2.275574,-0.545564,9.628718
06-07 16:58:05.941+0200 W/CAPI_APPFW_APP_CONTROL(13455): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:05.951+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:05.951+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:05.951+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:05:956,0.840000,0.490000,-0.140000
06-07 16:58:05.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:58:05.951+0200 I/utils   (13455): specific action
06-07 16:58:05.951+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:05.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:05.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13455), cmd(0)
06-07 16:58:05.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:05.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12603), cmd(0)
06-07 16:58:05.951+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:05.961+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:05:962,2.222758,-0.470081,9.539851
06-07 16:58:05.961+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:05:965,2.254039,-0.531207,9.595219
06-07 16:58:05.961+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:05:960,0.052705,-0.078313,0.088755
06-07 16:58:05.971+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:05.971+0200 I/utils   (12603): specific action
06-07 16:58:05.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:58:05.971+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:58:05.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:05.971+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:58:05.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:58:05.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:05.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:05.971+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:05.971+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:05.971+0200 W/CAPI_APPFW_APP_CONTROL(13501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:05.971+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:05.971+0200 I/utils   (13501): specific action
06-07 16:58:05.981+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:58:05.981+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:05.981+0200 I/utils   (12614): specific action
06-07 16:58:05.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13501), cmd(0)
06-07 16:58:05.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(12614), cmd(0)
06-07 16:58:05.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:58:05.981+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:58:05.981+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:05.981+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:58:05.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:58:05.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:58:05.981+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:58:05.981+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:05:985,2.224046,-0.469778,9.539566
06-07 16:58:05.991+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:05:986,0.024556,-0.063743,0.056808
06-07 16:58:05.991+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:05:980,-0.210000,0.490000,0.070000
06-07 16:58:05.991+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:05.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:58:05.991+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:05.991+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:58:05.991+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:58:05.991+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:58:05.991+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:05:987,2.256432,-0.457029,9.547362
06-07 16:58:05.991+0200 I/utils   (12618): specific action
06-07 16:58:05.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:58:05.991+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:58:05.991+0200 I/servicemanager(12566): App control destroyed.
06-07 16:58:06.001+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:2,-0.280000,0.630000,0.280000
06-07 16:58:06.001+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.001+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:9,2.226047,-0.469659,9.539104
06-07 16:58:06.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.011+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:16,2.277967,-0.457029,9.544970
06-07 16:58:06.011+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.021+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:13,0.029512,0.012139,0.008437
06-07 16:58:06.021+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.021+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.021+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.031+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:30,2.224588,-0.468736,9.539491
06-07 16:58:06.031+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:23,0.140000,0.210000,0.560000
06-07 16:58:06.041+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.041+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.041+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:32,0.055209,0.013052,0.005118
06-07 16:58:06.041+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:48,-0.210000,-0.280000,0.420000
06-07 16:58:06.041+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.041+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:35,2.246860,-0.457029,9.600004
06-07 16:58:06.051+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:51,2.225034,-0.470154,9.539317
06-07 16:58:06.051+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.051+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.061+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:58:06.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:58:06.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:58:06.061+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:58,2.221199,-0.471514,9.540143
06-07 16:58:06.061+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.061+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:69,0.022815,0.012748,0.060438
06-07 16:58:06.071+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:62,2.232504,-0.490529,9.635897
06-07 16:58:06.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.071+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:76,0.006457,-0.020870,0.096792
06-07 16:58:06.071+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:78,2.218147,-0.524028,9.633504
06-07 16:58:06.071+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:67,0.560000,-0.280000,0.420000
06-07 16:58:06.081+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:80,-0.006442,-0.055293,0.094013
06-07 16:58:06.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.081+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:86,0.700000,0.630000,-0.350000
06-07 16:58:06.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.081+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:87,-0.002101,-0.037124,0.034367
06-07 16:58:06.081+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.081+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:90,0.700000,0.980000,-0.350000
06-07 16:58:06.091+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:92,0.001733,0.112591,-0.052601
06-07 16:58:06.091+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.091+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:70,2.216724,-0.471462,9.541186
06-07 16:58:06.091+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.091+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:97,-0.041648,0.091003,0.058818
06-07 16:58:06.091+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:98,2.212539,-0.464431,9.542502
06-07 16:58:06.091+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.091+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.101+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:104,-0.770000,0.840000,-0.070000
06-07 16:58:06.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:82,2.222932,-0.507278,9.573684
06-07 16:58:06.101+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.101+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:06.101+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.101+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:104,-0.008749,0.093543,0.091002
06-07 16:58:06.111+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:109,2.212372,-0.461703,9.542674
06-07 16:58:06.111+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:06:112,80
06-07 16:58:06.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:115,2.222932,-0.358923,9.487542
06-07 16:58:06.111+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.121+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:122,2.175076,-0.380459,9.600004
06-07 16:58:06.121+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.121+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:06.121+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.121+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:06:130,851.000000
06-07 16:58:06.121+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.121+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.131+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:134,2.215415,-0.459559,9.542071
06-07 16:58:06.131+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:130,0.051238,-0.014469,0.121937
06-07 16:58:06.131+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:135,-1.190000,0.630000,0.140000
06-07 16:58:06.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:127,2.203789,-0.370888,9.633504
06-07 16:58:06.131+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.131+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:142,2.263610,-0.476172,9.664611
06-07 16:58:06.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.141+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.141+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.141+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:147,2.289931,-0.595813,9.628718
06-07 16:58:06.141+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:148,0.074516,-0.136254,0.086647
06-07 16:58:06.141+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:144,-0.560000,0.210000,0.140000
06-07 16:58:06.151+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:152,2.218388,-0.461200,9.541302
06-07 16:58:06.151+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.161+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:165,0.052401,-0.139399,0.041953
06-07 16:58:06.161+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.161+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.161+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:169,2.219010,-0.466450,9.540901
06-07 16:58:06.171+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.171+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:173,0.420000,-0.140000,0.140000
06-07 16:58:06.171+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:175,2.270789,-0.600598,9.583255
06-07 16:58:06.171+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.181+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:185,0.061350,-0.134148,0.061496
06-07 16:58:06.181+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.181+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:189,2.217588,-0.470683,9.541024
06-07 16:58:06.181+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.191+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.191+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:193,0.980000,-0.490000,-0.070000
06-07 16:58:06.191+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:195,2.280360,-0.600598,9.602397
06-07 16:58:06.191+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.191+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.201+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:204,0.980000,-0.350000,-0.560000
06-07 16:58:06.201+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.201+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:208,0.005345,-0.110773,-0.053482
06-07 16:58:06.201+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:208,2.222932,-0.581456,9.487542
06-07 16:58:06.201+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:205,2.216793,-0.474497,9.541020
06-07 16:58:06.241+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.251+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:254,1.610000,-0.490000,-0.770000
06-07 16:58:06.251+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.261+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:262,2.310000,0.140000,-0.280000
06-07 16:58:06.261+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.261+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.261+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.271+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:273,0.350000,0.140000,0.070000
06-07 16:58:06.271+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:269,2.201397,-0.485743,9.604790
06-07 16:58:06.271+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:276,2.212226,-0.476277,9.541991
06-07 16:58:06.281+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.281+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.281+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.281+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.281+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:286,-0.770000,-0.070000,0.490000
06-07 16:58:06.291+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:286,2.239682,-0.327817,9.583255
06-07 16:58:06.291+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.301+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:293,2.200413,-0.471716,9.544950
06-07 16:58:06.301+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.301+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:291,-0.015397,-0.011246,0.063769
06-07 16:58:06.301+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.301+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:06.311+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:06:314,80
06-07 16:58:06.311+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.321+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:06.321+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:304,-0.490000,0.140000,0.910000
06-07 16:58:06.321+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.341+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:312,2.220540,-0.301496,9.580862
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:06.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390686347,000000, pattern:[H:mm][0;m
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:58:06.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:58:06.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:58:06.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:58][0;m
06-07 16:58:06.341+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.351+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:352,2.246860,-0.452243,9.657433
06-07 16:58:06.351+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:06:331,850.000000
06-07 16:58:06.351+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.361+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:329,0.027456,0.148460,0.041264
06-07 16:58:06.361+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.361+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:364,2.287539,-0.459422,9.621540
06-07 16:58:06.371+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.371+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:376,2.199558,-0.464038,9.545523
06-07 16:58:06.371+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.381+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:377,2.273181,-0.547956,9.604790
06-07 16:58:06.381+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.381+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:335,-0.770000,-0.070000,0.700000
06-07 16:58:06.381+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.391+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:388,2.246860,-0.538385,9.592826
06-07 16:58:06.391+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:369,0.020127,0.170220,0.035913
06-07 16:58:06.401+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.401+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:389,-0.770000,-0.070000,0.350000
06-07 16:58:06.401+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:407,2.222932,-0.504886,9.609575
06-07 16:58:06.411+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.441+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.441+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:380,2.203279,-0.457934,9.544959
06-07 16:58:06.441+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.451+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:450,2.205051,-0.458631,9.544517
06-07 16:58:06.451+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.451+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:427,2.225325,-0.368495,9.578469
06-07 16:58:06.451+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.451+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:458,2.210925,-0.460261,9.543078
06-07 16:58:06.451+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.461+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:413,0.047302,0.011794,0.111910
06-07 16:58:06.461+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.461+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:446,0.700000,0.210000,0.210000
06-07 16:58:06.461+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.471+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:461,2.206182,-0.416351,9.588040
06-07 16:58:06.471+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:466,0.084260,-0.001488,0.076581
06-07 16:58:06.471+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.471+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.471+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:471,0.840000,-0.210000,0.210000
06-07 16:58:06.471+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.491+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:480,2.230111,-0.459422,9.549755
06-07 16:58:06.491+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:478,0.068130,-0.089325,0.060273
06-07 16:58:06.491+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:462,2.216643,-0.465912,9.541478
06-07 16:58:06.501+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:481,0.210000,-0.070000,0.210000
06-07 16:58:06.501+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.511+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:06.521+0200 W/LOCATION(13497): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:58:06.521+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:06:523,80
06-07 16:58:06.531+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:06.531+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:06:536,850.000000
06-07 16:58:06.541+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:506,-0.420000,-0.070000,0.210000
06-07 16:58:06.541+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.541+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:549,-0.140000,0.070000,0.210000
06-07 16:58:06.541+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.551+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:554,0.035935,-0.078124,0.049747
06-07 16:58:06.551+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.561+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:562,0.006290,-0.038974,0.068097
06-07 16:58:06.561+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.561+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:568,0.011770,0.099274,0.036365
06-07 16:58:06.571+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.571+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.581+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.591+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:588,-0.003362,0.051388,0.045006
06-07 16:58:06.591+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.601+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:604,0.021351,0.003145,0.006287
06-07 16:58:06.601+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.611+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:581,2.206182,-0.526421,9.600004
06-07 16:58:06.611+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:612,-0.003907,-0.065213,0.056777
06-07 16:58:06.611+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.611+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.611+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:579,2.213554,-0.467769,9.542105
06-07 16:58:06.611+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:617,0.045239,-0.041063,0.066615
06-07 16:58:06.611+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.621+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.621+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:626,0.039389,-0.048943,0.073013
06-07 16:58:06.621+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.631+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:631,0.026867,0.023899,-0.003375
06-07 16:58:06.631+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.631+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.631+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:638,0.039413,0.087386,0.068336
06-07 16:58:06.631+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.641+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:645,0.041198,0.017716,0.019937
06-07 16:58:06.641+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.641+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:623,0.630000,-0.070000,0.070000
06-07 16:58:06.641+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.651+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:650,0.056179,-0.088340,0.078794
06-07 16:58:06.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:617,2.256432,-0.502493,9.609575
06-07 16:58:06.651+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.651+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.651+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:659,0.066810,-0.021006,0.050956
06-07 16:58:06.661+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:641,2.209545,-0.467739,9.543035
06-07 16:58:06.661+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.661+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:667,0.037889,-0.021351,0.018271
06-07 16:58:06.661+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.671+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:672,-0.002976,-0.027674,0.030875
06-07 16:58:06.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.671+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:655,0.350000,-0.350000,0.070000
06-07 16:58:06.671+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:678,0.021774,0.013302,0.047449
06-07 16:58:06.671+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:658,2.246860,-0.512064,9.616754
06-07 16:58:06.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.681+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:676,2.208759,-0.462567,9.543468
06-07 16:58:06.681+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.681+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:683,0.024681,0.085377,0.077897
06-07 16:58:06.681+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:689,2.234896,-0.440279,9.540184
06-07 16:58:06.681+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.691+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:695,2.246860,-0.378066,9.611969
06-07 16:58:06.691+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:682,0.420000,-0.210000,0.070000
06-07 16:58:06.691+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.691+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:700,2.246860,-0.445065,9.564112
06-07 16:58:06.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.701+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:706,2.258825,-0.545564,9.623933
06-07 16:58:06.701+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.701+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:06.701+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:693,2.210089,-0.461208,9.543227
06-07 16:58:06.701+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:695,0.022858,0.010097,0.039427
06-07 16:58:06.711+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:06:713,80
06-07 16:58:06.711+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.711+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.711+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:712,2.273181,-0.478565,9.595219
06-07 16:58:06.711+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:724,2.246860,-0.483350,9.561719
06-07 16:58:06.721+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:719,2.211193,-0.461430,9.542960
06-07 16:58:06.721+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.721+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:06.721+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:721,0.044675,-0.024228,0.008653
06-07 16:58:06.721+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:711,0.700000,-0.070000,-0.140000
06-07 16:58:06.721+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:06:730,850.000000
06-07 16:58:06.721+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.731+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:729,2.208575,-0.490529,9.573684
06-07 16:58:06.731+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.731+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.731+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:739,2.232504,-0.449851,9.590433
06-07 16:58:06.741+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.741+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:742,2.207471,-0.463121,9.543740
06-07 16:58:06.751+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.751+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:758,2.232504,-0.378066,9.621540
06-07 16:58:06.751+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.761+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:738,0.700000,0.140000,0.350000
06-07 16:58:06.761+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:765,2.230111,-0.452243,9.583255
06-07 16:58:06.761+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.761+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.761+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:750,0.054029,-0.018548,0.057157
06-07 16:58:06.761+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.761+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:770,2.254039,-0.483350,9.552148
06-07 16:58:06.771+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.771+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:776,2.266003,-0.478565,9.600004
06-07 16:58:06.771+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.771+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:781,2.289931,-0.480957,9.611969
06-07 16:58:06.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.781+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:772,-0.420000,-0.140000,0.280000
06-07 16:58:06.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:787,2.234896,-0.461815,9.602397
06-07 16:58:06.781+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.781+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.791+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:774,2.208030,-0.464178,9.543559
06-07 16:58:06.791+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:792,2.254039,-0.497707,9.580862
06-07 16:58:06.791+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.791+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:796,-0.210000,-0.070000,0.210000
06-07 16:58:06.791+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:782,0.076385,-0.019571,0.069552
06-07 16:58:06.791+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.801+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.801+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:805,2.275574,-0.485743,9.552148
06-07 16:58:06.801+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:809,0.022688,-0.000800,0.059651
06-07 16:58:06.811+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:803,2.207447,-0.465452,9.543633
06-07 16:58:06.811+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.811+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:817,-0.070000,-0.070000,0.210000
06-07 16:58:06.811+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.811+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.821+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.821+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:824,2.205662,-0.462781,9.544175
06-07 16:58:06.821+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:829,2.237289,-0.519243,9.590433
06-07 16:58:06.821+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.831+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.831+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:828,0.040608,-0.036595,0.038405
06-07 16:58:06.831+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.831+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.841+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:844,2.222932,-0.483350,9.566505
06-07 16:58:06.841+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:835,0.280000,0.350000,0.140000
06-07 16:58:06.841+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:841,2.202645,-0.457224,9.545139
06-07 16:58:06.841+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.851+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.851+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:845,0.063362,-0.025342,0.009375
06-07 16:58:06.851+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.851+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.861+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:865,2.239682,-0.457029,9.600004
06-07 16:58:06.861+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:853,0.420000,0.280000,-0.070000
06-07 16:58:06.861+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:858,2.206371,-0.457558,9.544263
06-07 16:58:06.871+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.871+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:860,0.022432,-0.056380,0.048392
06-07 16:58:06.871+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.871+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.881+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:886,2.297110,-0.476172,9.566505
06-07 16:58:06.891+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:884,0.004747,-0.018751,0.025322
06-07 16:58:06.891+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:877,0.210000,-0.070000,0.280000
06-07 16:58:06.891+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:882,2.208971,-0.462000,9.543447
06-07 16:58:06.891+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.891+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.901+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:905,2.232504,-0.502493,9.631111
06-07 16:58:06.901+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.901+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:58:06.901+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.911+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:902,-0.420000,-0.070000,0.280000
06-07 16:58:06.911+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:58:06:913,80
06-07 16:58:06.911+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope - capturing data
06-07 16:58:06.921+0200 I/gravity (13455): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:58:06:915,2.211551,-0.462855,9.542809
06-07 16:58:06.921+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:58:06:918,0.020747,0.010762,0.059151
06-07 16:58:06.921+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:58:06.921+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.921+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:58:06:930,849.000000
06-07 16:58:06.931+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:931,2.275574,-0.423530,9.552148
06-07 16:58:06.931+0200 I/linearacceleration(13501): es.ugr.frailty.linearacceleration - capturing data
06-07 16:58:06.931+0200 I/gyroscope(13483): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:58:06:925,-0.630000,0.280000,0.280000
06-07 16:58:06.931+0200 I/gravity (13455): es.ugr.frailty.gravity - capturing data
06-07 16:58:06.951+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer - capturing data
06-07 16:58:06.971+0200 I/accelerometer(13437): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:58:06:978,2.251646,-0.483350,9.573684
06-07 16:58:06.981+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11134976c6f63152838348
