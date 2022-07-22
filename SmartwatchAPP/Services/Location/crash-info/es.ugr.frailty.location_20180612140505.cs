S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8902
Date: 2018-06-12 14:05:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70ec52d, r5   = 0xf71e4fe0
r6   = 0xff9e9a70, r7   = 0xff9e9920
r8   = 0xf71b6c18, r9   = 0x00000000
r10  = 0xff9e99fc, fp   = 0xff9e9a70
ip   = 0x00000001, sp   = 0xff9e98f8
lr   = 0xf70ec539, pc   = 0xf7155228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    179308 KB
Buffers:     30372 KB
Cached:     140976 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11756 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8902 TID = 8902
8902 8925 

Maps Information
f3fb7000 f47b6000 rw-p [stack:8925]
f47bd000 f47bf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47c7000 f47cb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47d4000 f47d6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47de000 f47e1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47f0000 f47f5000 r-xp /usr/lib/libsystem.so.0.0.0
f4800000 f4803000 r-xp /lib/libattr.so.1.1.0
f480b000 f481b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4823000 f482c000 r-xp /usr/lib/libedbus.so.1.7.99
f4834000 f4835000 r-xp /usr/lib/libresponse.so.0.2.96
f483e000 f4843000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60e5000 f61eb000 r-xp /usr/lib/libicuuc.so.57.1
f6201000 f6389000 r-xp /usr/lib/libicui18n.so.57.1
f6399000 f63a6000 r-xp /usr/lib/libail.so.0.1.0
f63af000 f63b6000 r-xp /usr/lib/libminizip.so.1.0.0
f63bf000 f6568000 r-xp /usr/lib/libcrypto.so.1.0.0
f6588000 f65cf000 r-xp /usr/lib/libssl.so.1.0.0
f65db000 f65dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65e5000 f65ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65f5000 f65fc000 r-xp /lib/libcrypt-2.13.so
f662d000 f6630000 r-xp /lib/libcap.so.2.21
f6638000 f663a000 r-xp /usr/lib/libiri.so
f6642000 f668b000 r-xp /usr/lib/libmdm.so.1.2.69
f6693000 f6699000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66a1000 f66c4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66ce000 f66d0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66d8000 f66f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66fe000 f6702000 r-xp /usr/lib/libsmack.so.1.0.0
f670b000 f6724000 r-xp /usr/lib/libnetwork.so.0.0.0
f672d000 f6735000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f673d000 f6743000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f674c000 f674e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6757000 f6767000 r-xp /lib/libresolv-2.13.so
f676b000 f6783000 r-xp /usr/lib/liblzma.so.5.0.3
f678c000 f678e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6796000 f67b0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67b8000 f67e7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67f0000 f67ff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6809000 f6813000 r-xp /usr/lib/libsensord-shared.so
f681c000 f68ef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68fa000 f6910000 r-xp /lib/libz.so.1.2.5
f6918000 f691d000 r-xp /usr/lib/libffi.so.5.0.10
f6925000 f6926000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f692e000 f693e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6946000 f695f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6967000 f6969000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6971000 f69e6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69f0000 f69f6000 r-xp /lib/librt-2.13.so
f69ff000 f6a1d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a27000 f6a28000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a30000 f6a53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a5b000 f6a60000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a68000 f6a92000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a9b000 f6ab2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aba000 f6b23000 r-xp /lib/libm-2.13.so
f6b2c000 f6bc0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bd3000 f6bd8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6be0000 f6be7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bef000 f6c19000 r-xp /usr/lib/libsensor.so.1.9.6
f6c22000 f6cee000 r-xp /usr/lib/libxml2.so.2.7.8
f6cfb000 f6cfd000 r-xp /usr/lib/libiniparser.so.0
f6d06000 f6d0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d15000 f6de5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6de6000 f6e1a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e23000 f6e5f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e67000 f6e6a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e72000 f6e78000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e80000 f6ec1000 r-xp /usr/lib/libeina.so.1.7.99
f6eca000 f6ee1000 r-xp /usr/lib/libecore.so.1.7.99
f6ef8000 f6f01000 r-xp /usr/lib/libvconf.so.0.2.45
f6f09000 f6f1d000 r-xp /lib/libpthread-2.13.so
f6f28000 f6f35000 r-xp /usr/lib/libaul.so.0.1.0
f6f3f000 f6f41000 r-xp /lib/libdl-2.13.so
f6f4a000 f6f55000 r-xp /lib/libunwind.so.8.0.1
f6f82000 f6f8a000 r-xp /lib/libgcc_s-4.6.so.1
f6f8b000 f70af000 r-xp /lib/libc-2.13.so
f70bd000 f70bf000 r-xp /usr/lib/libdlog.so.0.0.0
f70c7000 f70d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70dc000 f70e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70e9000 f70f8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7100000 f7104000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f710d000 f7110000 r-xp /usr/lib/libappcore-agent.so.1.1
f7118000 f711a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7122000 f7126000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f712e000 f714b000 r-xp /lib/ld-2.13.so
f7154000 f7157000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7157000 f715b000 r-xp /usr/lib/libsys-assert.so
f71b0000 f721e000 rw-p [heap]
ff9cb000 ff9ec000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8902)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7155228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70ec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6df33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6df1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6dfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e3875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6df1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6dfde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e03be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e03dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e35e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e36017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e3df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47d51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47c8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf689b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d48fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d4a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6edaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ed5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ed65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ed6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf710e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf710e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71555c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6fa285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7154f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:04.181+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:04:180,0.366222,-0.394224,-0.009935
06-12 14:05:04.181+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.191+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.191+0200 I/utils   ( 8862): specific action
06-12 14:05:04.191+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.191+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.191+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gyroscope
06-12 14:05:04.191+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:05:04.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:04.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:04.191+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.201+0200 I/utils   ( 8862): specific action
06-12 14:05:04.201+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.201+0200 I/recorder( 8862): saving local data for es.ugr.frailty.accelerometer
06-12 14:05:04.201+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:05:04.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:04.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8940
06-12 14:05:04.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(8862), cmd(0)
06-12 14:05:04.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.231+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:04.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.261+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.261+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(8862), cmd(0)
06-12 14:05:04.261+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:04.261+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:04:264,4.480000,0.630000,5.810000
06-12 14:05:04.261+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:04.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.301+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.301+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.311+0200 I/LOCATION( 8902): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:05:04.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:04.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:04.321+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.321+0200 I/utils   ( 8862): specific action
06-12 14:05:04.321+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.321+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.321+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gyroscope
06-12 14:05:04.321+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:05:04.331+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:04.331+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:04.331+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:04.331+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:04.331+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.331+0200 I/utils   ( 8859): specific action
06-12 14:05:04.331+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:05:04.331+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:04.341+0200 I/light   ( 8936): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:04:336,62.000000
06-12 14:05:04.341+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:04.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.371+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.371+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.371+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:04.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(8859), cmd(0)
06-12 14:05:04.381+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:04:379,1.584049,0.868595,9.477970
06-12 14:05:04.381+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.381+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:04.381+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:04.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(40) , send fd(21), pid(8862), cmd(0)
06-12 14:05:04.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:04.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:04.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:04.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.421+0200 I/location( 8902): es.ugr.frailty.location: waiting for rigth values
06-12 14:05:04.421+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.421+0200 I/gravity ( 8916): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.421+0200 I/gravity ( 8916): es.ugr.frailty.gravity - capturing data
06-12 14:05:04.431+0200 I/gravity ( 8916): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:04:434,1.449130,0.609106,9.679845
06-12 14:05:04.431+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:04.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.461+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.461+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.461+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:04.461+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:04:468,-0.155414,-0.042479,0.069028
06-12 14:05:04.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:04.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8902
06-12 14:05:04.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:04.521+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:04.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.551+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.551+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.551+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:04.561+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:04:562,2.940000,6.370000,-6.160000
06-12 14:05:04.561+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:04.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:04.581+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.581+0200 I/utils   ( 8862): specific action
06-12 14:05:04.581+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.581+0200 I/recorder( 8862): saving local data for es.ugr.frailty.accelerometer
06-12 14:05:04.581+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:05:04.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:04.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:04.601+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:04.601+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:04.601+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:04.601+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:04.601+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:04.601+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.611+0200 I/utils   ( 8859): specific action
06-12 14:05:04.611+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.611+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:05:04.611+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:04.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.631+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:04.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(21), pid(8859), cmd(0)
06-12 14:05:04.671+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.671+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.671+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:04.671+0200 I/light   ( 8936): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:04:675,62.000000
06-12 14:05:04.671+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(43) , send fd(21), pid(8862), cmd(0)
06-12 14:05:04.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:04.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.711+0200 E/CAPI_TELEPHONY( 8933): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:05:04.711+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.711+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.711+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:04.731+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:04:722,1.720440,0.105284,9.592826
06-12 14:05:04.731+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:04.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.761+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:04.761+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:04.761+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.761+0200 I/gravity ( 8916): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.761+0200 I/gravity ( 8916): es.ugr.frailty.gravity - capturing data
06-12 14:05:04.771+0200 I/gravity ( 8916): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:04:773,1.330574,0.642865,9.694673
06-12 14:05:04.771+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:04.801+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:04.801+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:04.801+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:05:04.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:05:04.801+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:05:04.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:04.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.831+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.831+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.831+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:04.851+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:04:843,-0.100392,-0.005370,0.664689
06-12 14:05:04.851+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:04.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.891+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.891+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.891+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:04.891+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:04:894,3.500000,-4.130000,0.560000
06-12 14:05:04.891+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:04.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:04.921+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.921+0200 I/utils   ( 8862): specific action
06-12 14:05:04.921+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.921+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.921+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gyroscope
06-12 14:05:04.921+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:05:04.921+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:04.921+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:04.921+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:04.921+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:04.921+0200 I/utils   ( 8859): specific action
06-12 14:05:04.921+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:05:04.921+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:04.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:04.941+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:04.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:04.961+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:04.961+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:04.961+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:04.961+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:04.961+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:04.971+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(21), pid(8859), cmd(0)
06-12 14:05:04.971+0200 I/light   ( 8936): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:04:972,62.000000
06-12 14:05:04.971+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:04.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:04.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(47) , send fd(21), pid(8862), cmd(0)
06-12 14:05:04.991+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:04.991+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:05.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:05.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.031+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.031+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.031+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:05.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:05.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.071+0200 E/WMS     ( 2465): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
06-12 14:05:05.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:05.101+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8904
06-12 14:05:05.101+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.101+0200 I/gravity ( 8916): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.101+0200 I/gravity ( 8916): es.ugr.frailty.gravity - capturing data
06-12 14:05:05.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:05.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:05.151+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 14:05:05.151+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 14:05:05.151+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 14:05:05.151+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 14:05:05.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.161+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:05.161+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:05.171+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.171+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.171+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:05.171+0200 I/gravity ( 8916): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:05:113,1.355335,0.831935,9.676846
06-12 14:05:05.171+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:05:45,1.868794,0.107677,10.698310
06-12 14:05:05.171+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.171+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.171+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.171+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.171+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:05.181+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:05:176,-3.150000,-1.050000,10.570000
06-12 14:05:05.181+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.181+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:05:183,0.308780,-0.347544,-0.038801
06-12 14:05:05.191+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.191+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:05.191+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:05.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:05.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:05.201+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.211+0200 I/utils   ( 8862): specific action
06-12 14:05:05.211+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.221+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:05.221+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:05.221+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:05.221+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.221+0200 I/recorder( 8862): saving local data for es.ugr.frailty.accelerometer
06-12 14:05:05.221+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:05:05.221+0200 I/utils   ( 8859): specific action
06-12 14:05:05.221+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.221+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:05:05.221+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:05.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:05.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.261+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.261+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.261+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:05.271+0200 I/light   ( 8936): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:05:271,62.000000
06-12 14:05:05.271+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(8859), cmd(0)
06-12 14:05:05.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(51) , send fd(21), pid(8862), cmd(0)
06-12 14:05:05.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:05.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.311+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.311+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.311+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:05.321+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:05:320,1.887937,0.368495,9.647861
06-12 14:05:05.321+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:05.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.361+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:05.361+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:05.361+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.361+0200 I/gravity ( 8916): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.361+0200 I/gravity ( 8916): es.ugr.frailty.gravity - capturing data
06-12 14:05:05.371+0200 I/gravity ( 8916): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:05:371,1.274055,0.844019,9.686836
06-12 14:05:05.371+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:05.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.391+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:05.391+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:05.401+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.401+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.401+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:05.411+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:05:411,5.810000,1.960000,7.280000
06-12 14:05:05.411+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:05.421+0200 W/SHealthCommon( 6349): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528761600000,000000[0;m
06-12 14:05:05.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:05.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.461+0200 W/LOCATION( 8902): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:05:05.461+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.461+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.461+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:05.471+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:05:472,-0.164184,0.003456,0.305405
06-12 14:05:05.471+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:05.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:05.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.501+0200 I/utils   ( 8862): specific action
06-12 14:05:05.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.501+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gyroscope
06-12 14:05:05.501+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:05:05.511+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:05.511+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:05.511+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:05.511+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.511+0200 I/utils   ( 8859): specific action
06-12 14:05:05.511+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.511+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.511+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.521+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.521+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:05:05.521+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:05.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:05.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.551+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(21), pid(8859), cmd(0)
06-12 14:05:05.561+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:05.561+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:05.561+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.561+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:05.561+0200 I/light   ( 8936): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:05:566,62.000000
06-12 14:05:05.561+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.561+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(55) , send fd(21), pid(8862), cmd(0)
06-12 14:05:05.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:05.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.591+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:05.591+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:05.601+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.601+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.601+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:05.611+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:05:610,1.366302,0.720240,9.726824
06-12 14:05:05.611+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:05.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.641+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.641+0200 I/gravity ( 8916): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.641+0200 I/gravity ( 8916): es.ugr.frailty.gravity - capturing data
06-12 14:05:05.651+0200 I/gravity ( 8916): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:05:650,1.281954,0.849300,9.685332
06-12 14:05:05.651+0200 W/AUL     ( 8916): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:05.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.701+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.701+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.701+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:05.711+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:05:711,9.660000,3.500000,2.870000
06-12 14:05:05.711+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:05.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.731+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.741+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.741+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:05.741+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:05:747,-0.159398,0.015420,-0.067876
06-12 14:05:05.741+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:05.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8859
06-12 14:05:05.761+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:05.761+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:05.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 I/utils   ( 8862): specific action
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.761+0200 I/recorder( 8862): saving local data for es.ugr.frailty.linearacceleration
06-12 14:05:05.761+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:05:05.771+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:05.771+0200 I/servicemanager( 8859): request sent to service es.ugr.frailty.recorder
06-12 14:05:05.771+0200 I/servicemanager( 8859): requesting to save local data
06-12 14:05:05.781+0200 W/CAPI_APPFW_APP_CONTROL( 8859): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:05.781+0200 I/utils   ( 8859): specific action
06-12 14:05:05.781+0200 I/servicemanager( 8859): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:05:05.781+0200 W/AUL     ( 8859): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:05.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:05.801+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:05:05.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:05:05.801+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:05:05.801+0200 I/CAPI_WATCH_APPLICATION( 6251): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 14:05:05.801+0200 E/watchface-loader( 6251): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 14:05:05.811+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8916
06-12 14:05:05.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(21), pid(8859), cmd(0)
06-12 14:05:05.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:05.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(59) , send fd(21), pid(8862), cmd(0)
06-12 14:05:05.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8936
06-12 14:05:05.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 14:05:05.861+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 14:05:05.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:05:05.861+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 14:05:05.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 14:05:05.871+0200 E/CAPI_LOCATION_MANAGER( 8933): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 14:05:05.871+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 14:05:05.871+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 14:05:05.871+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 14:05:05.871+0200 W/AUL     ( 8936): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.871+0200 I/light   ( 8936): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:05.871+0200 I/light   ( 8936): es.ugr.frailty.light - capturing data
06-12 14:05:05.891+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:05:05.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.901+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:05.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.921+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8859)
06-12 14:05:05.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:05.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8916
06-12 14:05:05.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8859
06-12 14:05:05.961+0200 I/heartrate( 8890): es.ugr.frailty.heartrate - capturing data
06-12 14:05:05.971+0200 I/heartrate( 8890): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:05.981+0200 W/CRASH_MANAGER( 8981): worker.c: worker_job(1205) > 11089026c6f63152880510
