S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12651
Date: 2018-06-12 14:34:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf751252d, r5   = 0xf779f150
r6   = 0xff8c0e00, r7   = 0xff8c0cb0
r8   = 0xf77b1c18, r9   = 0x00000000
r10  = 0xff8c0d8c, fp   = 0xff8c0e00
ip   = 0x00000001, sp   = 0xff8c0c88
lr   = 0xf7512539, pc   = 0xf757b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    171672 KB
Buffers:     33460 KB
Cached:     143276 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11660 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12651 TID = 12651
12651 12677 

Maps Information
f43dd000 f4bdc000 rw-p [stack:12677]
f4be3000 f4be5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bed000 f4bf1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bfa000 f4bfc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c04000 f4c07000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c16000 f4c1b000 r-xp /usr/lib/libsystem.so.0.0.0
f4c26000 f4c29000 r-xp /lib/libattr.so.1.1.0
f4c31000 f4c41000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c49000 f4c52000 r-xp /usr/lib/libedbus.so.1.7.99
f4c5a000 f4c5b000 r-xp /usr/lib/libresponse.so.0.2.96
f4c64000 f4c69000 r-xp /usr/lib/libproc-stat.so.0.2.96
f650b000 f6611000 r-xp /usr/lib/libicuuc.so.57.1
f6627000 f67af000 r-xp /usr/lib/libicui18n.so.57.1
f67bf000 f67cc000 r-xp /usr/lib/libail.so.0.1.0
f67d5000 f67dc000 r-xp /usr/lib/libminizip.so.1.0.0
f67e5000 f698e000 r-xp /usr/lib/libcrypto.so.1.0.0
f69ae000 f69f5000 r-xp /usr/lib/libssl.so.1.0.0
f6a01000 f6a03000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a0b000 f6a12000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a1b000 f6a22000 r-xp /lib/libcrypt-2.13.so
f6a53000 f6a56000 r-xp /lib/libcap.so.2.21
f6a5e000 f6a60000 r-xp /usr/lib/libiri.so
f6a68000 f6ab1000 r-xp /usr/lib/libmdm.so.1.2.69
f6ab9000 f6abf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ac7000 f6aea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6af4000 f6af6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6afe000 f6b1b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b24000 f6b28000 r-xp /usr/lib/libsmack.so.1.0.0
f6b31000 f6b4a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b53000 f6b5b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b63000 f6b69000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b72000 f6b74000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b7d000 f6b8d000 r-xp /lib/libresolv-2.13.so
f6b91000 f6ba9000 r-xp /usr/lib/liblzma.so.5.0.3
f6bb2000 f6bb4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bbc000 f6bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bde000 f6c0d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c16000 f6c25000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c2f000 f6c39000 r-xp /usr/lib/libsensord-shared.so
f6c42000 f6d15000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d20000 f6d36000 r-xp /lib/libz.so.1.2.5
f6d3e000 f6d43000 r-xp /usr/lib/libffi.so.5.0.10
f6d4b000 f6d4c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d54000 f6d64000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d6c000 f6d85000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d8d000 f6d8f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d97000 f6e0c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e16000 f6e1c000 r-xp /lib/librt-2.13.so
f6e25000 f6e43000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e4d000 f6e4e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e56000 f6e79000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e81000 f6e86000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e8e000 f6eb8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ec1000 f6ed8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ee0000 f6f49000 r-xp /lib/libm-2.13.so
f6f52000 f6fe6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ff9000 f6ffe000 r-xp /usr/lib/libctx-client.so.0.8.3
f7006000 f700d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7015000 f703f000 r-xp /usr/lib/libsensor.so.1.9.6
f7048000 f7114000 r-xp /usr/lib/libxml2.so.2.7.8
f7121000 f7123000 r-xp /usr/lib/libiniparser.so.0
f712c000 f7132000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f713b000 f720b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f720c000 f7240000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7249000 f7285000 r-xp /usr/lib/libSLP-location.so.0.9.24
f728d000 f7290000 r-xp /usr/lib/libbundle.so.0.1.22
f7298000 f729e000 r-xp /usr/lib/libappsvc.so.0.1.0
f72a6000 f72e7000 r-xp /usr/lib/libeina.so.1.7.99
f72f0000 f7307000 r-xp /usr/lib/libecore.so.1.7.99
f731e000 f7327000 r-xp /usr/lib/libvconf.so.0.2.45
f732f000 f7343000 r-xp /lib/libpthread-2.13.so
f734e000 f735b000 r-xp /usr/lib/libaul.so.0.1.0
f7365000 f7367000 r-xp /lib/libdl-2.13.so
f7370000 f737b000 r-xp /lib/libunwind.so.8.0.1
f73a8000 f73b0000 r-xp /lib/libgcc_s-4.6.so.1
f73b1000 f74d5000 r-xp /lib/libc-2.13.so
f74e3000 f74e5000 r-xp /usr/lib/libdlog.so.0.0.0
f74ed000 f74f9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7502000 f7507000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f750f000 f751e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7526000 f752a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7533000 f7536000 r-xp /usr/lib/libappcore-agent.so.1.1
f753e000 f7540000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7548000 f754c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7554000 f7571000 r-xp /lib/ld-2.13.so
f757a000 f757d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f757d000 f7581000 r-xp /usr/lib/libsys-assert.so
f7781000 f77ef000 rw-p [heap]
ff8a2000 ff8c3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12651)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf757b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7512539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7217c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7223e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7229be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7229dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf725e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7217c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7223e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7229be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7229dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf725be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf725c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7263f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bfb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cc1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf716efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7300ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72fbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72fc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72fc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7534183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf757b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73c885c) [/lib/libc.so.6] + 0x1785c
29: (0xf757af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
t.c: __request_handler(669) > __request_handler: 0
06-12 14:34:17.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:17.691+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:17:678,57.000000
06-12 14:34:17.691+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:17.701+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:17.701+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:17.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:17.701+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:17:521,0.220145,0.088665,9.803778
06-12 14:34:17.701+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:17.771+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:17.781+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:17.781+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:17.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:17.801+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:34:17.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:34:17.801+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:34:17.801+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:17.801+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:17.801+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:17.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:17.811+0200 W/LOCATION(12651): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-12 14:34:17.811+0200 I/utils   (12606): specific action
06-12 14:34:17.811+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:34:17.811+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:17.811+0200 I/LOCATION(12651): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
06-12 14:34:17.811+0200 I/LOCATION(12651): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
06-12 14:34:17.811+0200 I/location(12651): es.ugr.frailty.location:iniciado servicio de localización
06-12 14:34:17.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:17.831+0200 I/utils   (12703): es.ugr.frailty.pedometer listener started
06-12 14:34:17.851+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:17.851+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:17.851+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:17.861+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:17:855,-0.056259,0.020161,0.250699
06-12 14:34:17.861+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:17.861+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:34:17.861+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:17.861+0200 I/utils   (12609): specific action
06-12 14:34:17.861+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:17.861+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:17.861+0200 I/recorder(12609): saving local data for es.ugr.frailty.gyroscope
06-12 14:34:17.861+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:34:17.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:34:17.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:17.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(12606), cmd(0)
06-12 14:34:17.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:17.911+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:17.911+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:17.911+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:17.921+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 14:34:17.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:17.951+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:17.951+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:17.951+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:17.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:17.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(42) , send fd(21), pid(12609), cmd(0)
06-12 14:34:17.971+0200 W/SHealthService( 6349): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-12 14:34:17.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:17.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:17.991+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:17:959,58.000000
06-12 14:34:17.991+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:17.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:17.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:17.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.011+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.011+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.011+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:18.021+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:18:20,0.198104,0.104237,9.804094
06-12 14:34:18.021+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:18.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.071+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.071+0200 I/gyroscope(12616): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.071+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope - capturing data
06-12 14:34:18.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12613
06-12 14:34:18.091+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:34:18:77,-0.140000,-0.630000,-0.140000
06-12 14:34:18.091+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.091+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:18.091+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:18.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.111+0200 I/LOCATION(12651): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:34:18.111+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.111+0200 I/accelerometer(12613): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.111+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer - capturing data
06-12 14:34:18.121+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:34:18:122,0.117248,-0.002393,9.970891
06-12 14:34:18.121+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:18.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:18.151+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.151+0200 I/utils   (12609): specific action
06-12 14:34:18.151+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.151+0200 I/recorder(12609): saving local data for es.ugr.frailty.accelerometer
06-12 14:34:18.151+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:34:18.171+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:18.171+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:18.171+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:18.171+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.171+0200 I/utils   (12606): specific action
06-12 14:34:18.171+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.171+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:34:18.171+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:18.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:18.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:18.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.201+0200 I/location(12651): es.ugr.frailty.location: waiting for rigth values
06-12 14:34:18.211+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.211+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.211+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:18.211+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(12606), cmd(0)
06-12 14:34:18.221+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:18:218,-0.068223,0.063231,0.138237
06-12 14:34:18.221+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(46) , send fd(21), pid(12609), cmd(0)
06-12 14:34:18.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:34:18.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12689
06-12 14:34:18.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:18.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:34:18.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:34:18.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:34:18.291+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:34:18.291+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:18.291+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:18.301+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.301+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.301+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:18.301+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:18:308,57.000000
06-12 14:34:18.301+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:18.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.351+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.351+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.351+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:18.361+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:18:363,0.204002,0.098646,9.804031
06-12 14:34:18.361+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:34:18.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12652
06-12 14:34:18.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:18.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:18.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.431+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.431+0200 I/gyroscope(12616): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.431+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope - capturing data
06-12 14:34:18.441+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:34:18:442,-0.070000,-0.700000,-0.140000
06-12 14:34:18.441+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12613
06-12 14:34:18.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.501+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.501+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:18.501+0200 I/accelerometer(12613): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.501+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:18.501+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer - capturing data
06-12 14:34:18.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:18.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:18.541+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.541+0200 I/utils   (12609): specific action
06-12 14:34:18.541+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.541+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.541+0200 I/recorder(12609): saving local data for es.ugr.frailty.gyroscope
06-12 14:34:18.551+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:34:18.551+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:18.551+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:18.551+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:18.551+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.551+0200 I/utils   (12606): specific action
06-12 14:34:18.551+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:34:18.551+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:18.561+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:34:18:509,0.172283,0.050249,9.894321
06-12 14:34:18.561+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:18.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:18.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.611+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(12606), cmd(0)
06-12 14:34:18.621+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.621+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.621+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:18.631+0200 E/CAPI_TELEPHONY(12700): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:34:18.631+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(50) , send fd(21), pid(12609), cmd(0)
06-12 14:34:18.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:34:18.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:18.671+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:18:629,0.071604,0.071143,0.059064
06-12 14:34:18.671+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.691+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:18.691+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:18.701+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.701+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.701+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:18.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:34:18.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:34:18.711+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:34:18.721+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:18:729,57.000000
06-12 14:34:18.721+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.731+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:18.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.761+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.761+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.761+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:18.761+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:18:764,0.223125,0.107371,9.803523
06-12 14:34:18.761+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:34:18.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:18.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.801+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:18.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.831+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.831+0200 I/gyroscope(12616): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.831+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope - capturing data
06-12 14:34:18.841+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:34:18:836,-0.070000,-0.560000,-0.140000
06-12 14:34:18.841+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:18.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:18.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:18.861+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.861+0200 I/utils   (12609): specific action
06-12 14:34:18.861+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.861+0200 I/recorder(12609): saving local data for es.ugr.frailty.accelerometer
06-12 14:34:18.861+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:34:18.871+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:18.871+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:18.871+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:18.871+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.871+0200 I/utils   (12606): specific action
06-12 14:34:18.871+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:18.871+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:34:18.871+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:18.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12613
06-12 14:34:18.891+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:18.891+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:18.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:18.911+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:18.911+0200 I/accelerometer(12613): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:18.911+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer - capturing data
06-12 14:34:18.921+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(12606), cmd(0)
06-12 14:34:18.931+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:18.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(53) , send fd(21), pid(12609), cmd(0)
06-12 14:34:18.941+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:34:18:918,0.119641,0.026321,9.710074
06-12 14:34:18.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:34:18.961+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12703
06-12 14:34:18.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:18.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:18.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:18.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:18.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.001+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.011+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.011+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.011+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:19.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:19.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.061+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:19:18,-0.004967,0.059179,-0.043828
06-12 14:34:19.061+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.061+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.061+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.061+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:19.071+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:19:70,56.000000
06-12 14:34:19.071+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:19.101+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:19.101+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:19.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.111+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.111+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.111+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:19.121+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:19:123,0.207273,0.112060,9.803819
06-12 14:34:19.121+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:34:19.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 12665
06-12 14:34:19.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:19.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:19.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:19.191+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.191+0200 I/gyroscope(12616): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.191+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope - capturing data
06-12 14:34:19.201+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:34:19:203,-0.140000,-0.630000,-0.140000
06-12 14:34:19.201+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:19.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:19.231+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.231+0200 I/utils   (12609): specific action
06-12 14:34:19.231+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.231+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.231+0200 I/recorder(12609): saving local data for es.ugr.frailty.gyroscope
06-12 14:34:19.231+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:34:19.241+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:19.241+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:19.241+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:19.241+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.241+0200 I/utils   (12606): specific action
06-12 14:34:19.241+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:34:19.241+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:19.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:34:19.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:19.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(21), pid(12606), cmd(0)
06-12 14:34:19.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:19.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(57) , send fd(21), pid(12609), cmd(0)
06-12 14:34:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12613
06-12 14:34:19.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:34:19.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:34:19.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:34:19.291+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:34:19.291+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:19.291+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:19.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.311+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.311+0200 I/accelerometer(12613): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.311+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer - capturing data
06-12 14:34:19.311+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:34:19:318,0.275175,-0.014357,9.796216
06-12 14:34:19.321+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:19.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.361+0200 W/LOCATION(12651): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:34:19.371+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.371+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.371+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:19.381+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:19:381,-0.031112,-0.100630,0.052258
06-12 14:34:19.381+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:19.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:19.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:19.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.421+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.421+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.421+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:19.431+0200 I/light   (12689): es.ugr.frailty.light: SM-R760,12/06/2018,14:34:19:431,56.000000
06-12 14:34:19.431+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:19.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.471+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.481+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.481+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:19.481+0200 I/gravity (12665): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:34:19:486,0.209885,0.104549,9.803846
06-12 14:34:19.481+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.501+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:19.501+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:19.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:34:19.511+0200 W/SHealthCommon( 6349): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528761600000,000000[0;m
06-12 14:34:19.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:19.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.551+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.551+0200 I/gyroscope(12616): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.551+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope - capturing data
06-12 14:34:19.561+0200 I/gyroscope(12616): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:34:19:563,-0.070000,-0.630000,-0.140000
06-12 14:34:19.561+0200 W/AUL     (12616): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12606
06-12 14:34:19.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12609
06-12 14:34:19.591+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.591+0200 I/utils   (12609): specific action
06-12 14:34:19.591+0200 W/CAPI_APPFW_APP_CONTROL(12609): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.591+0200 I/recorder(12609): saving local data for es.ugr.frailty.accelerometer
06-12 14:34:19.591+0200 I/recorder(12609): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:34:19.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:19.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:19.601+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12609)
06-12 14:34:19.601+0200 I/servicemanager(12606): request sent to service es.ugr.frailty.recorder
06-12 14:34:19.601+0200 I/servicemanager(12606): requesting to save local data
06-12 14:34:19.601+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.601+0200 I/utils   (12606): specific action
06-12 14:34:19.601+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.601+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.601+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.601+0200 W/CAPI_APPFW_APP_CONTROL(12606): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:34:19.601+0200 I/servicemanager(12606): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:34:19.601+0200 W/AUL     (12606): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:34:19.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12613
06-12 14:34:19.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.651+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.651+0200 I/accelerometer(12613): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.651+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer - capturing data
06-12 14:34:19.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:19.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(12606), cmd(0)
06-12 14:34:19.661+0200 I/accelerometer(12613): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:34:19:663,0.169890,0.064606,10.054641
06-12 14:34:19.661+0200 W/AUL     (12613): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:34:19.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(61) , send fd(21), pid(12609), cmd(0)
06-12 14:34:19.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12652
06-12 14:34:19.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:34:19.721+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:34:19.721+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:34:19.721+0200 I/heartrate(12638): es.ugr.frailty.heartrate - capturing data
06-12 14:34:19.731+0200 I/heartrate(12638): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:34:19.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.741+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.761+0200 I/linearacceleration(12652): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.761+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration - capturing data
06-12 14:34:19.771+0200 I/linearacceleration(12652): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:34:19:770,-0.083755,0.040547,0.198220
06-12 14:34:19.771+0200 W/AUL     (12652): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:34:19.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12689
06-12 14:34:19.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:34:19.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:34:19.821+0200 W/AUL     (12689): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12665
06-12 14:34:19.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.851+0200 I/light   (12689): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.861+0200 W/AUL     (12665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12606)
06-12 14:34:19.861+0200 I/gravity (12665): request sent to service es.ugr.frailty.servicemanager
06-12 14:34:19.861+0200 I/gravity (12665): es.ugr.frailty.gravity - capturing data
06-12 14:34:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.881+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 12616
06-12 14:34:19.881+0200 I/light   (12689): es.ugr.frailty.light - capturing data
06-12 14:34:19.891+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12606
06-12 14:34:19.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:34:19.931+0200 W/CRASH_MANAGER(12731): worker.c: worker_job(1205) > 11126516c6f63152880685
