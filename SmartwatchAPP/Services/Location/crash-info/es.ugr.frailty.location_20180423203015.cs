S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9307
Date: 2018-04-23 20:30:15+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73a652d, r5   = 0xf78ebf98
r6   = 0xffb685d0, r7   = 0xffb68480
r8   = 0xf78e8c18, r9   = 0x00000000
r10  = 0xffb6855c, fp   = 0xffb685d0
ip   = 0x00000001, sp   = 0xffb68458
lr   = 0xf73a6539, pc   = 0xf740f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146948 KB
Buffers:     34680 KB
Cached:     153600 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11760 KB
VmRSS:       11760 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9307 TID = 9307
9307 9310 

Maps Information
f4271000 f4a70000 rw-p [stack:9310]
f4a77000 f4a79000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a81000 f4a85000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a8e000 f4a90000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a98000 f4a9b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aaa000 f4aaf000 r-xp /usr/lib/libsystem.so.0.0.0
f4aba000 f4abd000 r-xp /lib/libattr.so.1.1.0
f4ac5000 f4ad5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4add000 f4ae6000 r-xp /usr/lib/libedbus.so.1.7.99
f4aee000 f4aef000 r-xp /usr/lib/libresponse.so.0.2.96
f4af8000 f4afd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f639f000 f64a5000 r-xp /usr/lib/libicuuc.so.57.1
f64bb000 f6643000 r-xp /usr/lib/libicui18n.so.57.1
f6653000 f6660000 r-xp /usr/lib/libail.so.0.1.0
f6669000 f6670000 r-xp /usr/lib/libminizip.so.1.0.0
f6679000 f6822000 r-xp /usr/lib/libcrypto.so.1.0.0
f6842000 f6889000 r-xp /usr/lib/libssl.so.1.0.0
f6895000 f6897000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f689f000 f68a6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68af000 f68b6000 r-xp /lib/libcrypt-2.13.so
f68e7000 f68ea000 r-xp /lib/libcap.so.2.21
f68f2000 f68f4000 r-xp /usr/lib/libiri.so
f68fc000 f6945000 r-xp /usr/lib/libmdm.so.1.2.69
f694d000 f6953000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f695b000 f697e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6988000 f698a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6992000 f69af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69b8000 f69bc000 r-xp /usr/lib/libsmack.so.1.0.0
f69c5000 f69de000 r-xp /usr/lib/libnetwork.so.0.0.0
f69e7000 f69ef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69f7000 f69fd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a06000 f6a08000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a11000 f6a21000 r-xp /lib/libresolv-2.13.so
f6a25000 f6a3d000 r-xp /usr/lib/liblzma.so.5.0.3
f6a46000 f6a48000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a50000 f6a6a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a72000 f6aa1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aaa000 f6ab9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ac3000 f6acd000 r-xp /usr/lib/libsensord-shared.so
f6ad6000 f6ba9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bb4000 f6bca000 r-xp /lib/libz.so.1.2.5
f6bd2000 f6bd7000 r-xp /usr/lib/libffi.so.5.0.10
f6bdf000 f6be0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be8000 f6bf8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c00000 f6c19000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c21000 f6c23000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c2b000 f6ca0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6caa000 f6cb0000 r-xp /lib/librt-2.13.so
f6cb9000 f6cd7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ce1000 f6ce2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cea000 f6d0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d15000 f6d1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d22000 f6d4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d55000 f6d6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d74000 f6ddd000 r-xp /lib/libm-2.13.so
f6de6000 f6e7a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e8d000 f6e92000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e9a000 f6ea1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ea9000 f6ed3000 r-xp /usr/lib/libsensor.so.1.9.6
f6edc000 f6fa8000 r-xp /usr/lib/libxml2.so.2.7.8
f6fb5000 f6fb7000 r-xp /usr/lib/libiniparser.so.0
f6fc0000 f6fc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fcf000 f709f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70a0000 f70d4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70dd000 f7119000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7121000 f7124000 r-xp /usr/lib/libbundle.so.0.1.22
f712c000 f7132000 r-xp /usr/lib/libappsvc.so.0.1.0
f713a000 f717b000 r-xp /usr/lib/libeina.so.1.7.99
f7184000 f719b000 r-xp /usr/lib/libecore.so.1.7.99
f71b2000 f71bb000 r-xp /usr/lib/libvconf.so.0.2.45
f71c3000 f71d7000 r-xp /lib/libpthread-2.13.so
f71e2000 f71ef000 r-xp /usr/lib/libaul.so.0.1.0
f71f9000 f71fb000 r-xp /lib/libdl-2.13.so
f7204000 f720f000 r-xp /lib/libunwind.so.8.0.1
f723c000 f7244000 r-xp /lib/libgcc_s-4.6.so.1
f7245000 f7369000 r-xp /lib/libc-2.13.so
f7377000 f7379000 r-xp /usr/lib/libdlog.so.0.0.0
f7381000 f738d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7396000 f739b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73a3000 f73b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73ba000 f73be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73c7000 f73ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f73d2000 f73d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73dc000 f73e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73e8000 f7405000 r-xp /lib/ld-2.13.so
f740e000 f7411000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7411000 f7415000 r-xp /usr/lib/libsys-assert.so
f78b8000 f7946000 rw-p [heap]
ffb49000 ffb6a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9307)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf740f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70ad3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70f275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70ed1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70abc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70b7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70bdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70bddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70efe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70f0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70f7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a8f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a82171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b55663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7002fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7194ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf718fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7190879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf740f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf725c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf740ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 capturing data from es.ugr.frailty.gravity
04-23 20:30:04.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:04.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:04.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:04.679+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:685,0.034980,9.772202,0.820500
04-23 20:30:04.689+0200 W/AUL     ( 9253): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:04.689+0200 I/location( 9253): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:04.689+0200 I/location( 9253): stopping es.ugr.frailty.location service
04-23 20:30:04.689+0200 E/CAPI_APPFW_APP_CONTROL( 9253): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:30:04.689+0200 E/location( 9253): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:30:04.689+0200 I/CAPI_APPFW_APPLICATION( 9253): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:04.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.689+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:696,0.035640,9.772238,0.820056
04-23 20:30:04.709+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.709+0200 I/utils   ( 8242): specific action
04-23 20:30:04.709+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.709+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.709+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.709+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:04.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:04.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:04.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:04.719+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:04.719+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:04.729+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:715,0.034442,9.772130,0.821388
04-23 20:30:04.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.739+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:04.739+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:04.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:743,0.035192,9.772097,0.821746
04-23 20:30:04.739+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.739+0200 I/utils   ( 8247): specific action
04-23 20:30:04.739+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.739+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.739+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.739+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:04.739+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:04.739+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:04.749+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.749+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:758,0.035844,9.772338,0.818852
04-23 20:30:04.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.769+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:773,0.036691,9.772522,0.816606
04-23 20:30:04.779+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:04.779+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:04.779+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:04.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.789+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:796,0.036586,9.772534,0.816468
04-23 20:30:04.819+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:823,0.036828,9.772454,0.817409
04-23 20:30:04.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.829+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:833,0.038065,9.772630,0.815256
04-23 20:30:04.839+0200 W/LOCATION( 9253): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:04.839+0200 I/LOCATION( 9253): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:04.839+0200 I/LOCATION( 9253): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:04.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.849+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:854,0.038454,9.772667,0.814791
04-23 20:30:04.879+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.879+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:883,0.037441,9.772760,0.813716
04-23 20:30:04.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:893,0.036499,9.772581,0.815911
04-23 20:30:04.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:923,0.036733,9.772679,0.814723
04-23 20:30:04.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:934,0.037904,9.772558,0.816118
04-23 20:30:04.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.949+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:954,0.037423,9.772297,0.819271
04-23 20:30:04.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.969+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:974,0.036240,9.772193,0.820560
04-23 20:30:04.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:30:04.989+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:30:04.989+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:30:04.989+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:30:04.989+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:30:05.009+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:04:994,0.036407,9.772116,0.821471
04-23 20:30:05.019+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.029+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:33,0.035534,9.771866,0.824471
04-23 20:30:05.039+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.039+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:43,0.035052,9.771535,0.828413
04-23 20:30:05.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.059+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:56,0.033285,9.771378,0.830335
04-23 20:30:05.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.069+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:76,0.030668,9.771039,0.834412
04-23 20:30:05.099+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:103,0.030269,9.770835,0.836809
04-23 20:30:05.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:113,0.029999,9.770924,0.835790
04-23 20:30:05.129+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.129+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:133,0.028116,9.770666,0.838853
04-23 20:30:05.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.179+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:183,0.028064,9.770600,0.839617
04-23 20:30:05.179+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.219+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:188,0.028467,9.770753,0.837834
04-23 20:30:05.229+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.249+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.259+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:240,0.026815,9.770367,0.842374
04-23 20:30:05.259+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.269+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:269,0.026247,9.770356,0.842523
04-23 20:30:05.269+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.289+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:282,0.025250,9.770175,0.844644
04-23 20:30:05.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:302,0.025937,9.770122,0.845244
04-23 20:30:05.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:318,0.025186,9.769991,0.846773
04-23 20:30:05.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:332,0.026420,9.770393,0.842076
04-23 20:30:05.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.339+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:340,0.025987,9.770512,0.840724
04-23 20:30:05.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:05.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:05.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:05.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4002398
04-23 20:30:05.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400ba10]
04-23 20:30:05.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:05.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:05.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:05.369+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:05.379+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:05.379+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:05.389+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.399+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:05.399+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:05.399+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:05.399+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:05.399+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:05.399+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:05.399+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:05.399+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:05.399+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:05.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.409+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.409+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:05.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.509+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.549+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:513,0.023105,9.770198,0.844442
04-23 20:30:05.559+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:05.559+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:05.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:05.569+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400ba10
04-23 20:30:05.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf77126e0]
04-23 20:30:05.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:05.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:05.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:05.629+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:05.639+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:05.639+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:05.649+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.659+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.659+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:05.659+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:05.659+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:05.659+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:05.659+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:05.659+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:05.659+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:05.659+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:05.659+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:05.669+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.679+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:05.679+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:05.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:713,0.025253,9.770578,0.839968
04-23 20:30:05.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:05.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:05.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:05.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:05.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf77126e0
04-23 20:30:05.899+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:05.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:05:913,0.029043,9.770454,0.841285
04-23 20:30:05.949+0200 W/AUL     ( 9266): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:30:05.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:05.949+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:05.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9230
04-23 20:30:05.949+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:05.959+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9230
04-23 20:30:05.959+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9230)
04-23 20:30:06.099+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:06.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:06:112,0.027555,9.771009,0.834869
04-23 20:30:06.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:06.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:06:313,0.027361,9.769767,0.849291
04-23 20:30:06.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:06.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:06:512,0.032820,9.771148,0.833055
04-23 20:30:06.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:06.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:06:713,0.036472,9.771333,0.830731
04-23 20:30:06.719+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:30:06.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:06.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:06:914,0.045377,9.773153,0.808575
04-23 20:30:07.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:07.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:07:113,0.052834,9.774030,0.797450
04-23 20:30:07.299+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:07.349+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:07:312,0.034418,9.777074,0.760281
04-23 20:30:07.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:07.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:07:514,0.030405,9.780297,0.717809
04-23 20:30:07.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:07.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:07:715,0.032518,9.777061,0.760519
04-23 20:30:07.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:07.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:07:913,0.034630,9.776176,0.771731
04-23 20:30:08.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:08.109+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:08:113,0.021649,9.774554,0.792472
04-23 20:30:08.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:08.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:08:313,0.023357,9.773577,0.804388
04-23 20:30:08.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:08.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:08:513,0.044441,9.772513,0.816327
04-23 20:30:08.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:08.709+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:08:716,0.029924,9.770634,0.839168
04-23 20:30:08.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:30:08.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:30:08:913,0.030543,9.771935,0.823850
04-23 20:30:08.929+0200 I/servicemanager( 8242): es.ugr.frailty.gravity sleep timeout
04-23 20:30:08.929+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:30:08.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:08.939+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:08.949+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8932
04-23 20:30:08.949+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8932)
04-23 20:30:08.949+0200 I/servicemanager( 8242): es.ugr.frailty.gravity stop request sent!
04-23 20:30:08.949+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:08.949+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:08.949+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8932), cmd(0)
04-23 20:30:08.949+0200 I/gravity ( 8932): stopping es.ugr.frailty.gravity service
04-23 20:30:08.949+0200 W/AUL     ( 8932): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:08.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:08.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8932
04-23 20:30:08.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:08.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:08.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 I/utils   ( 8242): specific action
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.969+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:08.969+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:08.979+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:08.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:08.989+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:08.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:08.989+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 I/utils   ( 8247): specific action
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:08.999+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:30:08.999+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:08.999+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:08.999+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:08.999+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:08.999+0200 W/AUL     ( 8932): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:08.999+0200 I/gravity ( 8932): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:08.999+0200 I/CAPI_APPFW_APPLICATION( 8932): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:08.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:08.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:09.049+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:30:09.059+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:30:09.089+0200 I/gravity ( 8932): es.ugr.frailty.gravity listener destroyed
04-23 20:30:09.239+0200 W/AUL     ( 9275): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:30:09.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:09.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:09.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8932
04-23 20:30:09.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:09.239+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8932
04-23 20:30:09.239+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8932)
04-23 20:30:10.749+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 3
04-23 20:30:10.749+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524508030, curr_wall_time = 1524508210
04-23 20:30:10.749+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 180 seconds
04-23 20:30:10.749+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 102 seconds
04-23 20:30:10.749+0200 E/RESOURCED( 2560): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 19, charging remaining time = 122 minutes
04-23 20:30:10.999+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:30:13.559+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:30:13.559+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:13.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:13.569+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:13.579+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9307
04-23 20:30:13.579+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:13.629+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9307
04-23 20:30:13.629+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9307) type(svcapp) bg(0)
04-23 20:30:13.629+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9307)
04-23 20:30:13.629+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:30:13.629+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:13.629+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9307]
04-23 20:30:13.629+0200 E/CAPI_APPFW_APPLICATION( 9307): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:13.639+0200 E/CAPI_APPFW_APPLICATION( 9307): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:13.649+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:13.659+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9307
04-23 20:30:13.659+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:13.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9307
04-23 20:30:13.669+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9307) was created
04-23 20:30:13.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:13.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:13.689+0200 W/LOCATION( 9307): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:13.689+0200 E/LOCATION( 9307): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:13.689+0200 E/PKGMGR_INFO( 9307): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:13.689+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:13.709+0200 I/LOCATION( 9307): location.c: location_new(269) > method: 0
04-23 20:30:13.709+0200 W/LOCATION( 9307): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:13.719+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:13.729+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:13.729+0200 W/LOCATION( 9307): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:13.739+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:13.739+0200 W/LOCATION( 9307): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:13.739+0200 W/LOCATION( 9307): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:13.739+0200 W/LOCATION( 9307): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:13.739+0200 W/LOCATION( 9307): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:13.759+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:13.769+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:13.769+0200 W/LOCATION( 9307): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:13.769+0200 W/LOCATION( 9307): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:13.779+0200 W/LOCATION( 9307): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:13.779+0200 W/LOCATION( 9307): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:13.779+0200 W/LOCATION( 9307): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:13.799+0200 W/LOCATION( 9307): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:13.799+0200 I/LOCATION( 9307): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf78e8c18
04-23 20:30:13.799+0200 I/LOCATION( 9307): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:13.799+0200 I/LOCATION( 9307): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf78e8c18
04-23 20:30:13.799+0200 I/LOCATION( 9307): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:13.799+0200 I/location( 9307): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:13.849+0200 I/LOCATION( 9307): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:13.889+0200 W/LOCATION( 9307): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:13.889+0200 W/LOCATION( 9307): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:13.889+0200 I/LOCATION( 9307): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:13.959+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:13.959+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:13.959+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:13.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:13.959+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:13.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:13.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:13.959+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:13.959+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:13.969+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:13.969+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:13.969+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:13.969+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:14.019+0200 W/LOCATION( 9307): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:14.019+0200 W/LOCATION( 9307): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:14.089+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:14.129+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4006588]
04-23 20:30:14.129+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:14.129+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:14.129+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:14.129+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:14.139+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:14.139+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:14.149+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:14.149+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:14.149+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:14.149+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:14.149+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:14.149+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:14.149+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:14.149+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:14.149+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:14.159+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:14.159+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:14.159+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:14.169+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:14.169+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:14.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:14.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:14.219+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:14.219+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2289481), time2(2276310)
04-23 20:30:14.219+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:30:14.219+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:14.219+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:14.219+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:14.249+0200 W/LOCATION( 9307): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:14.249+0200 I/LOCATION( 9307): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:14.249+0200 I/LOCATION( 9307): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:14.259+0200 I/location( 9307): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:14.299+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:14.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:14.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:14.379+0200 I/LOCATION( 9307): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:14.429+0200 E/location( 9307): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:14.429+0200 W/AUL     ( 9307): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:14.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:14.429+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9307
04-23 20:30:14.439+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:14.439+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:14.439+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:14.439+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.439+0200 I/utils   ( 8242): specific action
04-23 20:30:14.439+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.439+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.439+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.439+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:14.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:14.439+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:14.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:14.449+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:14.449+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 I/utils   ( 8247): specific action
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:14.449+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:14.449+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:14.449+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:14.449+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:14.449+0200 W/AUL     ( 9307): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:14.449+0200 I/location( 9307): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:14.449+0200 W/CAPI_APPFW_APP_CONTROL( 9307): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:14.449+0200 I/utils   ( 9307): specific action
04-23 20:30:15.169+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:30:15.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:15.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:15.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:15.799+0200 W/LOCATION( 9307): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:30:15.959+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11093076c6f63152450821
