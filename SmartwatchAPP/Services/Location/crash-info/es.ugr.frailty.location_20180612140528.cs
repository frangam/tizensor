S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9221
Date: 2018-06-12 14:05:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf744852d, r5   = 0xf7ad6150
r6   = 0xff881610, r7   = 0xff8814c0
r8   = 0xf7ae8c18, r9   = 0x00000000
r10  = 0xff88159c, fp   = 0xff881610
ip   = 0x00000001, sp   = 0xff881498
lr   = 0xf7448539, pc   = 0xf74b1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    182744 KB
Buffers:     30600 KB
Cached:     138800 KB
VmPeak:      53520 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11692 KB
VmRSS:       11692 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9221 TID = 9221
9221 9224 

Maps Information
f4313000 f4b12000 rw-p [stack:9224]
f4b19000 f4b1b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b23000 f4b27000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b30000 f4b32000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b3a000 f4b3d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b4c000 f4b51000 r-xp /usr/lib/libsystem.so.0.0.0
f4b5c000 f4b5f000 r-xp /lib/libattr.so.1.1.0
f4b67000 f4b77000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b7f000 f4b88000 r-xp /usr/lib/libedbus.so.1.7.99
f4b90000 f4b91000 r-xp /usr/lib/libresponse.so.0.2.96
f4b9a000 f4b9f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6441000 f6547000 r-xp /usr/lib/libicuuc.so.57.1
f655d000 f66e5000 r-xp /usr/lib/libicui18n.so.57.1
f66f5000 f6702000 r-xp /usr/lib/libail.so.0.1.0
f670b000 f6712000 r-xp /usr/lib/libminizip.so.1.0.0
f671b000 f68c4000 r-xp /usr/lib/libcrypto.so.1.0.0
f68e4000 f692b000 r-xp /usr/lib/libssl.so.1.0.0
f6937000 f6939000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6941000 f6948000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6951000 f6958000 r-xp /lib/libcrypt-2.13.so
f6989000 f698c000 r-xp /lib/libcap.so.2.21
f6994000 f6996000 r-xp /usr/lib/libiri.so
f699e000 f69e7000 r-xp /usr/lib/libmdm.so.1.2.69
f69ef000 f69f5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69fd000 f6a20000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a2a000 f6a2c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a34000 f6a51000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a5a000 f6a5e000 r-xp /usr/lib/libsmack.so.1.0.0
f6a67000 f6a80000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a89000 f6a91000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a99000 f6a9f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6aa8000 f6aaa000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ab3000 f6ac3000 r-xp /lib/libresolv-2.13.so
f6ac7000 f6adf000 r-xp /usr/lib/liblzma.so.5.0.3
f6ae8000 f6aea000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6af2000 f6b0c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b14000 f6b43000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b4c000 f6b5b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b65000 f6b6f000 r-xp /usr/lib/libsensord-shared.so
f6b78000 f6c4b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c56000 f6c6c000 r-xp /lib/libz.so.1.2.5
f6c74000 f6c79000 r-xp /usr/lib/libffi.so.5.0.10
f6c81000 f6c82000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c8a000 f6c9a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ca2000 f6cbb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cc3000 f6cc5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ccd000 f6d42000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d4c000 f6d52000 r-xp /lib/librt-2.13.so
f6d5b000 f6d79000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d83000 f6d84000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d8c000 f6daf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6db7000 f6dbc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dc4000 f6dee000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6df7000 f6e0e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e16000 f6e7f000 r-xp /lib/libm-2.13.so
f6e88000 f6f1c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f2f000 f6f34000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f3c000 f6f43000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f4b000 f6f75000 r-xp /usr/lib/libsensor.so.1.9.6
f6f7e000 f704a000 r-xp /usr/lib/libxml2.so.2.7.8
f7057000 f7059000 r-xp /usr/lib/libiniparser.so.0
f7062000 f7068000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7071000 f7141000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7142000 f7176000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f717f000 f71bb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71c3000 f71c6000 r-xp /usr/lib/libbundle.so.0.1.22
f71ce000 f71d4000 r-xp /usr/lib/libappsvc.so.0.1.0
f71dc000 f721d000 r-xp /usr/lib/libeina.so.1.7.99
f7226000 f723d000 r-xp /usr/lib/libecore.so.1.7.99
f7254000 f725d000 r-xp /usr/lib/libvconf.so.0.2.45
f7265000 f7279000 r-xp /lib/libpthread-2.13.so
f7284000 f7291000 r-xp /usr/lib/libaul.so.0.1.0
f729b000 f729d000 r-xp /lib/libdl-2.13.so
f72a6000 f72b1000 r-xp /lib/libunwind.so.8.0.1
f72de000 f72e6000 r-xp /lib/libgcc_s-4.6.so.1
f72e7000 f740b000 r-xp /lib/libc-2.13.so
f7419000 f741b000 r-xp /usr/lib/libdlog.so.0.0.0
f7423000 f742f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7438000 f743d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7445000 f7454000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f745c000 f7460000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7469000 f746c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7474000 f7476000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f747e000 f7482000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f748a000 f74a7000 r-xp /lib/ld-2.13.so
f74b0000 f74b3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74b3000 f74b7000 r-xp /usr/lib/libsys-assert.so
f7ab8000 f7b29000 rw-p [heap]
ff862000 ff883000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9221)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74b1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7448539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf714f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf714dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7159e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf715fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf715fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf719475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf718f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf714dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7159e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf715fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf715fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7191e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7192017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7199f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b311fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b24171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bf7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70a4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70a67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7236ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7231b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72325a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7232879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf746a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf746a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74b15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72fe85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74b0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:27.121+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(8866) cmd(0)
06-12 14:05:27.121+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:27:123,1.241875,1.122234,9.934999
06-12 14:05:27.121+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:27.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 14:05:27.151+0200 E/AUL_AMD ( 2478): amd_request.c: __release_srv(386) > Not releasable
06-12 14:05:27.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-12 14:05:27.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7204
06-12 14:05:27.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 14:05:27.151+0200 E/AUL     ( 9222): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-12 14:05:27.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:27.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 I/utils   ( 8862): specific action
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.171+0200 I/recorder( 8862): saving local data for es.ugr.frailty.light
06-12 14:05:27.171+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:05:27.181+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:27.181+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:27.181+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:27.181+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.181+0200 I/utils   ( 9223): specific action
06-12 14:05:27.181+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.181+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:05:27.181+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:27.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9139
06-12 14:05:27.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.211+0200 W/AUL     ( 9139): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.211+0200 I/light   ( 9139): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.211+0200 I/light   ( 9139): es.ugr.frailty.light - capturing data
06-12 14:05:27.211+0200 I/light   ( 9139): es.ugr.frailty.light: SM-R760,12/06/2018,14:05:27:220,42.000000
06-12 14:05:27.221+0200 W/AUL     ( 9139): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.221+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7204
06-12 14:05:27.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7204)
06-12 14:05:27.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(9223), cmd(0)
06-12 14:05:27.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(21), pid(8862), cmd(0)
06-12 14:05:27.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:27.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.261+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.261+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.261+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:27.271+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:27:272,2.940000,4.200000,6.510000
06-12 14:05:27.271+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:27.291+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:27.291+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:27.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.311+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.311+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.311+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:27.311+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:27:314,0.418352,-0.536115,9.783044
06-12 14:05:27.311+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:27.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.361+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.361+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.361+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:27.361+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:27:364,0.041391,0.289184,-0.074882
06-12 14:05:27.361+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:27.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9221
06-12 14:05:27.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:27.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.421+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.421+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.421+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:27.431+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:27:432,1.328017,0.983450,10.025927
06-12 14:05:27.431+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:27.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9221
06-12 14:05:27.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:27.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:27.481+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.481+0200 I/utils   ( 8862): specific action
06-12 14:05:27.481+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.481+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.481+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gyroscope
06-12 14:05:27.481+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:05:27.491+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:27.491+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:27.491+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:27.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.491+0200 I/utils   ( 9223): specific action
06-12 14:05:27.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.491+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:27.491+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:27.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.491+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 14:05:27.491+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:27.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9139
06-12 14:05:27.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.521+0200 W/AUL     ( 9139): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.521+0200 I/light   ( 9139): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.521+0200 I/light   ( 9139): stopping es.ugr.frailty.light service
06-12 14:05:27.521+0200 I/light   ( 9139): stopped es.ugr.frailty.light service
06-12 14:05:27.521+0200 I/CAPI_APPFW_APPLICATION( 9139): service_app_main.c: service_app_exit(441) > service_app_exit
06-12 14:05:27.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(9223), cmd(0)
06-12 14:05:27.531+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(21), pid(8862), cmd(0)
06-12 14:05:27.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.551+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:27.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.571+0200 E/PKGMGR_INFO( 2961): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-12 14:05:27.581+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9139), cmd(0)
06-12 14:05:27.581+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.581+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.591+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:27.591+0200 E/PKGMGR_INFO( 2961): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-12 14:05:27.591+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-12 14:05:27.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:27.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.631+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.631+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.641+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:27.651+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:27:648,0.427172,-0.539784,9.782461
06-12 14:05:27.651+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:27.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.671+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.671+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.671+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:27.671+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(8869) cmd(0)
06-12 14:05:27.671+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:27:677,0.020974,0.010360,-0.027859
06-12 14:05:27.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:27.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:27.691+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:27.691+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:27.701+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.701+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:27:594,1.050000,5.460000,5.040000
06-12 14:05:27.701+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.711+0200 I/light   ( 9139): es.ugr.frailty.light listener destroyed
06-12 14:05:27.711+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.711+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.711+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:27.721+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:27:722,1.332802,1.019342,9.978070
06-12 14:05:27.721+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:27.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:27.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 I/utils   ( 8862): specific action
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.751+0200 I/recorder( 8862): saving local data for es.ugr.frailty.linearacceleration
06-12 14:05:27.751+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 14:05:27.761+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:27.761+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:27.761+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:27.761+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.761+0200 I/utils   ( 9223): specific action
06-12 14:05:27.771+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.771+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.771+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.771+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.771+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:27.771+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.gravity
06-12 14:05:27.771+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:27.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
06-12 14:05:27.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
06-12 14:05:27.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(9223), cmd(0)
06-12 14:05:27.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:27.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(36) , send fd(21), pid(8862), cmd(0)
06-12 14:05:27.811+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:05:27.811+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:05:27.811+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:05:27.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.821+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:27.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.841+0200 E/CAPI_TELEPHONY( 8933): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:05:27.851+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.851+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.851+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:27.851+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:27:856,0.427726,-0.525934,9.783191
06-12 14:05:27.861+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:27.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9223
06-12 14:05:27.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.881+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:27.891+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.901+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:27.901+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:27.901+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.901+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.901+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:27.921+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:27:911,-0.139557,-0.051883,0.533372
06-12 14:05:27.921+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:27.921+0200 W/AUL     ( 9235): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.light]
06-12 14:05:27.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.941+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.941+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.941+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:27.941+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:27:948,-2.870000,-3.150000,-0.280000
06-12 14:05:27.951+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:27.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:27.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:27.971+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:27.981+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:27.981+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:27.981+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:27:984,1.399801,0.976272,9.678967
06-12 14:05:27.981+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:27.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:05:28.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9223
06-12 14:05:28.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:28.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 I/utils   ( 8862): specific action
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 I/recorder( 8862): saving local data for es.ugr.frailty.gravity
06-12 14:05:28.031+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 14:05:28.031+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:28.031+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:28.031+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:28.031+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.031+0200 I/utils   ( 9223): specific action
06-12 14:05:28.031+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.accelerometer
06-12 14:05:28.031+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:28.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:28.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.071+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.071+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.071+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:28.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(21), pid(9223), cmd(0)
06-12 14:05:28.081+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:28:80,0.422691,-0.514723,9.784006
06-12 14:05:28.081+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(39) , send fd(21), pid(8862), cmd(0)
06-12 14:05:28.091+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:28.091+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:28.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:28.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:28.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 14:05:28.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 14:05:28.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9139
06-12 14:05:28.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 14:05:28.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:28.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.201+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:28.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.221+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.221+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.221+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.221+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:28.221+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:28.221+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:28:225,-2.380000,-4.550000,-1.330000
06-12 14:05:28.221+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.221+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.221+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:28.221+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9139
06-12 14:05:28.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9139)
06-12 14:05:28.221+0200 E/RESOURCED( 2582): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'es.ugr.frailty.light': Not a directory
06-12 14:05:28.231+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:28:234,-0.141504,-0.074882,0.529478
06-12 14:05:28.231+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:28:230,1.457229,1.038485,9.501899
06-12 14:05:28.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:05:28.231+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.231+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.231+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:28.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:28.251+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.261+0200 I/utils   ( 8862): specific action
06-12 14:05:28.261+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.261+0200 I/recorder( 8862): saving local data for es.ugr.frailty.accelerometer
06-12 14:05:28.261+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 14:05:28.261+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:28.261+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:28.261+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 I/utils   ( 9223): specific action
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.271+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.light
06-12 14:05:28.271+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:28.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:28.291+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:28.291+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:28.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.301+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.301+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.301+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:28.311+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:28:313,0.420038,-0.522856,9.783689
06-12 14:05:28.311+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(21), pid(9223), cmd(0)
06-12 14:05:28.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(42) , send fd(21), pid(8862), cmd(0)
06-12 14:05:28.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:28.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.371+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.371+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.371+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:28.371+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:28:375,1.680000,1.260000,-1.050000
06-12 14:05:28.371+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:28.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.411+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.411+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.411+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:28.411+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:28:415,0.046200,0.147281,0.266334
06-12 14:05:28.411+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:28.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.451+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.451+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.451+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:28.451+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:05:28:455,1.426122,1.143769,9.592826
06-12 14:05:28.451+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9223
06-12 14:05:28.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8862
06-12 14:05:28.491+0200 W/LOCATION( 9221): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:05:28.491+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8862)
06-12 14:05:28.491+0200 I/servicemanager( 9223): request sent to service es.ugr.frailty.recorder
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 I/servicemanager( 9223): requesting to save local data
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 I/utils   ( 8862): specific action
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 I/utils   ( 9223): specific action
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.491+0200 W/CAPI_APPFW_APP_CONTROL( 9223): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.501+0200 I/servicemanager( 9223): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:05:28.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.501+0200 W/AUL     ( 9223): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:05:28.501+0200 W/CAPI_APPFW_APP_CONTROL( 8862): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:05:28.501+0200 I/recorder( 8862): saving local data for es.ugr.frailty.light
06-12 14:05:28.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.501+0200 I/recorder( 8862): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:05:28.501+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:28.501+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:28.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:28.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.521+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.521+0200 I/gravity ( 9103): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.521+0200 I/gravity ( 9103): es.ugr.frailty.gravity - capturing data
06-12 14:05:28.531+0200 I/gravity ( 9103): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:05:28:530,0.425184,-0.532711,9.782935
06-12 14:05:28.531+0200 W/AUL     ( 9103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.541+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(9223), cmd(0)
06-12 14:05:28.541+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:05:28.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(45) , send fd(21), pid(8862), cmd(0)
06-12 14:05:28.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8869
06-12 14:05:28.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.591+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.591+0200 I/gyroscope( 8869): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.591+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope - capturing data
06-12 14:05:28.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.611+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8904
06-12 14:05:28.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.641+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.641+0200 I/linearacceleration( 8904): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.641+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration - capturing data
06-12 14:05:28.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 8866
06-12 14:05:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.691+0200 W/AUL     ( 8866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9223)
06-12 14:05:28.691+0200 I/accelerometer( 8866): request sent to service es.ugr.frailty.servicemanager
06-12 14:05:28.691+0200 I/accelerometer( 8866): es.ugr.frailty.accelerometer - capturing data
06-12 14:05:28.701+0200 I/heartrate( 9206): es.ugr.frailty.heartrate - capturing data
06-12 14:05:28.701+0200 I/heartrate( 9206): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:05:28.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:05:28.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9103
06-12 14:05:28.711+0200 I/linearacceleration( 8904): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:05:28:650,0.151184,0.263875,-0.049690
06-12 14:05:28.711+0200 W/AUL     ( 8904): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.711+0200 I/gyroscope( 8869): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:05:28:601,1.470000,5.250000,-0.630000
06-12 14:05:28.711+0200 W/AUL     ( 8869): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:05:28.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9223
06-12 14:05:28.711+0200 W/CRASH_MANAGER( 8981): worker.c: worker_job(1205) > 11092216c6f63152880512
