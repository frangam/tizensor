S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9511
Date: 2018-06-12 14:09:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf767252d, r5   = 0xf78f9150
r6   = 0xffc89700, r7   = 0xffc895b0
r8   = 0xf790bc18, r9   = 0x00000000
r10  = 0xffc8968c, fp   = 0xffc89700
ip   = 0x00000001, sp   = 0xffc89588
lr   = 0xf7672539, pc   = 0xf76db228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    177284 KB
Buffers:     31088 KB
Cached:     140304 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11656 KB
VmRSS:       11656 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9511 TID = 9511
9511 9526 

Maps Information
f453d000 f4d3c000 rw-p [stack:9526]
f4d43000 f4d45000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d4d000 f4d51000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d5a000 f4d5c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d64000 f4d67000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d76000 f4d7b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d86000 f4d89000 r-xp /lib/libattr.so.1.1.0
f4d91000 f4da1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4da9000 f4db2000 r-xp /usr/lib/libedbus.so.1.7.99
f4dba000 f4dbb000 r-xp /usr/lib/libresponse.so.0.2.96
f4dc4000 f4dc9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f666b000 f6771000 r-xp /usr/lib/libicuuc.so.57.1
f6787000 f690f000 r-xp /usr/lib/libicui18n.so.57.1
f691f000 f692c000 r-xp /usr/lib/libail.so.0.1.0
f6935000 f693c000 r-xp /usr/lib/libminizip.so.1.0.0
f6945000 f6aee000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b0e000 f6b55000 r-xp /usr/lib/libssl.so.1.0.0
f6b61000 f6b63000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b6b000 f6b72000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b7b000 f6b82000 r-xp /lib/libcrypt-2.13.so
f6bb3000 f6bb6000 r-xp /lib/libcap.so.2.21
f6bbe000 f6bc0000 r-xp /usr/lib/libiri.so
f6bc8000 f6c11000 r-xp /usr/lib/libmdm.so.1.2.69
f6c19000 f6c1f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c27000 f6c4a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c54000 f6c56000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c5e000 f6c7b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c84000 f6c88000 r-xp /usr/lib/libsmack.so.1.0.0
f6c91000 f6caa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cb3000 f6cbb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cc3000 f6cc9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cd2000 f6cd4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cdd000 f6ced000 r-xp /lib/libresolv-2.13.so
f6cf1000 f6d09000 r-xp /usr/lib/liblzma.so.5.0.3
f6d12000 f6d14000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d1c000 f6d36000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d3e000 f6d6d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d76000 f6d85000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d8f000 f6d99000 r-xp /usr/lib/libsensord-shared.so
f6da2000 f6e75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e80000 f6e96000 r-xp /lib/libz.so.1.2.5
f6e9e000 f6ea3000 r-xp /usr/lib/libffi.so.5.0.10
f6eab000 f6eac000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eb4000 f6ec4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ecc000 f6ee5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6eed000 f6eef000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ef7000 f6f6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f76000 f6f7c000 r-xp /lib/librt-2.13.so
f6f85000 f6fa3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fad000 f6fae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fb6000 f6fd9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fe1000 f6fe6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fee000 f7018000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7021000 f7038000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7040000 f70a9000 r-xp /lib/libm-2.13.so
f70b2000 f7146000 r-xp /usr/lib/libstdc++.so.6.0.16
f7159000 f715e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7166000 f716d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7175000 f719f000 r-xp /usr/lib/libsensor.so.1.9.6
f71a8000 f7274000 r-xp /usr/lib/libxml2.so.2.7.8
f7281000 f7283000 r-xp /usr/lib/libiniparser.so.0
f728c000 f7292000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f729b000 f736b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f736c000 f73a0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73a9000 f73e5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73ed000 f73f0000 r-xp /usr/lib/libbundle.so.0.1.22
f73f8000 f73fe000 r-xp /usr/lib/libappsvc.so.0.1.0
f7406000 f7447000 r-xp /usr/lib/libeina.so.1.7.99
f7450000 f7467000 r-xp /usr/lib/libecore.so.1.7.99
f747e000 f7487000 r-xp /usr/lib/libvconf.so.0.2.45
f748f000 f74a3000 r-xp /lib/libpthread-2.13.so
f74ae000 f74bb000 r-xp /usr/lib/libaul.so.0.1.0
f74c5000 f74c7000 r-xp /lib/libdl-2.13.so
f74d0000 f74db000 r-xp /lib/libunwind.so.8.0.1
f7508000 f7510000 r-xp /lib/libgcc_s-4.6.so.1
f7511000 f7635000 r-xp /lib/libc-2.13.so
f7643000 f7645000 r-xp /usr/lib/libdlog.so.0.0.0
f764d000 f7659000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7662000 f7667000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f766f000 f767e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7686000 f768a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7693000 f7696000 r-xp /usr/lib/libappcore-agent.so.1.1
f769e000 f76a0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76a8000 f76ac000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76b4000 f76d1000 r-xp /lib/ld-2.13.so
f76da000 f76dd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76dd000 f76e1000 r-xp /usr/lib/libsys-assert.so
f78db000 f7949000 rw-p [heap]
ffc6a000 ffc8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9511)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76db228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7672539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73793f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7377c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7383e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7389be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7389dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73be75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73b91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7377c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7383e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7389be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7389dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73bbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73bc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73c3f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d5b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d4e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e21663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72cefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72d07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7460ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf745bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf745c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf745c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7694183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76947fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76db5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf752885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76daf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ager)
06-12 14:09:09.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:09.751+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:09.751+0200 I/utils   ( 9470): specific action
06-12 14:09:09.751+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:09.751+0200 I/recorder( 9470): saving local data for es.ugr.frailty.accelerometer
06-12 14:09:09.761+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:09.761+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:09.761+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:09.771+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:09.771+0200 I/utils   ( 9467): specific action
06-12 14:09:09.771+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:09.771+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:09:09.771+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:09.781+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:09.781+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:09.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:09.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:09.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:09.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9538
06-12 14:09:09.801+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:09.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(9467), cmd(0)
06-12 14:09:09.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:09.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(46) , send fd(15), pid(9470), cmd(0)
06-12 14:09:09.811+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:09:09.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:09.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:09.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:09.851+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:09.851+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:09.851+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:09.851+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:09:855,0.123837,0.033915,9.805809
06-12 14:09:09.851+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:09.851+0200 I/utils   ( 9565): es.ugr.frailty.pedometer listener started
06-12 14:09:09.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:09.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:09.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:09.901+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:09.901+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:09.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:09.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:09:907,0.153141,-0.078963,9.891929
06-12 14:09:09.901+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:09.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:09.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:09.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:09.951+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:09.951+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:09.961+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:09.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:09.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:09.981+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:09.981+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:09.981+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:09:964,45.000000
06-12 14:09:09.981+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:09.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:09.991+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:09.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:09.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:09.991+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:09.991+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:10.001+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:10:1,-0.050361,0.059232,0.064955
06-12 14:09:10.001+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:10.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.021+0200 I/LOCATION( 9511): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:09:10.031+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.031+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.031+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:10.031+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:10:38,-0.070000,-0.280000,-0.140000
06-12 14:09:10.031+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:10.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:10.071+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.071+0200 I/utils   ( 9470): specific action
06-12 14:09:10.071+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.071+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.071+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:09:10.071+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:09:10.081+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:10.081+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:10.081+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:10.081+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.081+0200 I/utils   ( 9467): specific action
06-12 14:09:10.081+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:09:10.081+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:10.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:10.101+0200 I/location( 9511): es.ugr.frailty.location: waiting for rigth values
06-12 14:09:10.101+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9525
06-12 14:09:10.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(9467), cmd(0)
06-12 14:09:10.121+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(50) , send fd(15), pid(9470), cmd(0)
06-12 14:09:10.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:10.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:10.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.181+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:10.181+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:10.181+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.181+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.181+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:10.181+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:10:188,0.117536,0.022017,9.805921
06-12 14:09:10.181+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:10.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:10.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:10.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.231+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.231+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.231+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:10.231+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:10:235,0.167498,-0.026321,9.877571
06-12 14:09:10.231+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:09:10.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:09:10.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:09:10.251+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:09:10.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:10.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.281+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.281+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.281+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:10.281+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:10:287,45.000000
06-12 14:09:10.281+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:10.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.321+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.321+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.321+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:10.321+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:10:327,-0.215466,0.217158,0.081704
06-12 14:09:10.321+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:10.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.371+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.371+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.371+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:10.371+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:10.381+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:10.381+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:10:376,-0.070000,-0.210000,-0.140000
06-12 14:09:10.381+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:10.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:10.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:10.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:10.401+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.401+0200 I/utils   ( 9470): specific action
06-12 14:09:10.401+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.401+0200 I/recorder( 9470): saving local data for es.ugr.frailty.accelerometer
06-12 14:09:10.401+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:09:10.411+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:10.411+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:10.411+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:10.411+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.411+0200 I/utils   ( 9467): specific action
06-12 14:09:10.411+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.411+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:09:10.411+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:10.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:10.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(9467), cmd(0)
06-12 14:09:10.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(54) , send fd(15), pid(9470), cmd(0)
06-12 14:09:10.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:10.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9552
06-12 14:09:10.491+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:09:10.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:09:10.491+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:09:10.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:10.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.531+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.541+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.541+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:10.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.551+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:10.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.581+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:10:544,0.115687,0.018642,9.805950
06-12 14:09:10.581+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.581+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:10.581+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:10.581+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.581+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.581+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:10.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:10.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:10.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:10.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.621+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:10:593,0.227318,0.095713,9.858429
06-12 14:09:10.621+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.631+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.631+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.631+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:10.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:10.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.681+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:10:635,46.000000
06-12 14:09:10.681+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.681+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:10.701+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:09:10.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.721+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.721+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.721+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.721+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:10.721+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:10.731+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:10:728,-0.070000,-0.280000,-0.140000
06-12 14:09:10.731+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:10:734,0.128220,-0.057621,0.002223
06-12 14:09:10.731+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.731+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:10.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:10.751+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.761+0200 I/utils   ( 9470): specific action
06-12 14:09:10.761+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.761+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.761+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:09:10.761+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:09:10.771+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:10.771+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:10.771+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:10.771+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:10.771+0200 I/utils   ( 9467): specific action
06-12 14:09:10.771+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:09:10.771+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:10.781+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:10.781+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:10.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:10.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(9467), cmd(0)
06-12 14:09:10.791+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:10.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(58) , send fd(15), pid(9470), cmd(0)
06-12 14:09:10.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:10.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:10.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:10.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9538
06-12 14:09:10.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:10.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.861+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.861+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.861+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:10.871+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:10:869,0.142589,0.026727,9.805577
06-12 14:09:10.871+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.881+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:10.891+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.901+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.901+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:10.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:10:909,0.102891,0.043071,9.870394
06-12 14:09:10.911+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:10.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.941+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:10.941+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:10.941+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:10.951+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:10:956,45.000000
06-12 14:09:10.951+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:10.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:10.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:10.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:10.991+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:10.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:10.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:11.001+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:11.001+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.001+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.001+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:11.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:11.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.041+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.041+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.041+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:11.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:11.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:11.081+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:11.091+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:11.101+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:11.111+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9565
06-12 14:09:11.111+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:11.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(62) , send fd(15), pid(9470), cmd(0)
06-12 14:09:11.111+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:11.111+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.121+0200 I/utils   ( 9470): specific action
06-12 14:09:11.121+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.121+0200 I/recorder( 9470): saving local data for es.ugr.frailty.accelerometer
06-12 14:09:11.121+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:09:11.121+0200 I/utils   ( 9467): specific action
06-12 14:09:11.121+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.121+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:09:11.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:11.121+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:11.131+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:11.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(9467), cmd(0)
06-12 14:09:11.141+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:11:7,-0.070000,-0.210000,-0.070000
06-12 14:09:11.141+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:11:52,0.063614,-0.045657,0.176900
06-12 14:09:11.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:11.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.161+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.161+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.171+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.171+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.171+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:11.171+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:11:176,0.144652,0.028031,9.805543
06-12 14:09:11.171+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.181+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:11.181+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:11.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:11.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:11.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:11.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.211+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.221+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.221+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:11.221+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:11:225,-0.062213,0.200997,9.887143
06-12 14:09:11.221+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:11.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:09:11.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:09:11.251+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:09:11.251+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:09:11.251+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.251+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.251+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:11.261+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:11:260,45.000000
06-12 14:09:11.261+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:09:11.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:11.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:11.311+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.311+0200 I/utils   ( 9470): specific action
06-12 14:09:11.311+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.311+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.311+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:09:11.311+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:09:11.321+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:11.321+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:11.321+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:11.321+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.321+0200 I/utils   ( 9467): specific action
06-12 14:09:11.321+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:09:11.321+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:09:11.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:11.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.361+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.361+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.361+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:09:11.361+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:09:11:366,-0.070000,-0.280000,-0.070000
06-12 14:09:11.361+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:11.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(9467), cmd(0)
06-12 14:09:11.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:11.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(64) , send fd(15), pid(9470), cmd(0)
06-12 14:09:11.381+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:11.381+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:11.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:11.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:11.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:11.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.411+0200 W/LOCATION( 9511): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:09:11.431+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.431+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.431+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:11.431+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:09:11:438,-0.030517,0.049833,0.361295
06-12 14:09:11.431+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:11.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:09:11.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:09:11.501+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:09:11.511+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.511+0200 I/gravity ( 9525): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.511+0200 I/gravity ( 9525): es.ugr.frailty.gravity - capturing data
06-12 14:09:11.521+0200 I/gravity ( 9525): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:09:11:516,0.144990,0.025673,9.805545
06-12 14:09:11.521+0200 W/AUL     ( 9525): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:09:11.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9552
06-12 14:09:11.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.571+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:11.571+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:11.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:09:11.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:11.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:11.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.621+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9552
06-12 14:09:11.631+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.631+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:09:11.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.661+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.661+0200 I/light   ( 9552): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.661+0200 I/light   ( 9552): es.ugr.frailty.light - capturing data
06-12 14:09:11.671+0200 I/light   ( 9552): es.ugr.frailty.light: SM-R760,12/06/2018,14:09:11:671,46.000000
06-12 14:09:11.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:09:11.681+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:09:11:638,0.234497,-0.009571,9.808180
06-12 14:09:11.681+0200 W/AUL     ( 9552): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:09:11.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:09:11.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.721+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:09:11.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:09:11.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.751+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:09:11.761+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:09:11.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:09:11.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:09:11.791+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:09:11.791+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:09:11.801+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:09:11.801+0200 I/heartrate( 9497): es.ugr.frailty.heartrate - capturing data
06-12 14:09:11.801+0200 I/heartrate( 9497): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:09:11.801+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:09:11.801+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:09:11.811+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:09:11.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:09:11.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(68) , send fd(15), pid(9470), cmd(0)
06-12 14:09:11.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:09:11.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9525
06-12 14:09:11.831+0200 W/CRASH_MANAGER( 9591): worker.c: worker_job(1205) > 11095116c6f63152880535
