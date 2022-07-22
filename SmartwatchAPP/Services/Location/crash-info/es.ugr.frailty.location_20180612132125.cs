S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4650
Date: 2018-06-12 13:21:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf745652d, r5   = 0xf79a9150
r6   = 0xffc4bd30, r7   = 0xffc4bbe0
r8   = 0xf79bbc18, r9   = 0x00000000
r10  = 0xffc4bcbc, fp   = 0xffc4bd30
ip   = 0x00000001, sp   = 0xffc4bbb8
lr   = 0xf7456539, pc   = 0xf74bf228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10120 KB
Buffers:     37460 KB
Cached:     217660 KB
VmPeak:      53452 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11696 KB
VmRSS:       11692 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4650 TID = 4650
4650 4722 

Maps Information
f4321000 f4b20000 rw-p [stack:4722]
f4b27000 f4b29000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b31000 f4b35000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b3e000 f4b40000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b48000 f4b4b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b5a000 f4b5f000 r-xp /usr/lib/libsystem.so.0.0.0
f4b6a000 f4b6d000 r-xp /lib/libattr.so.1.1.0
f4b75000 f4b85000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b8d000 f4b96000 r-xp /usr/lib/libedbus.so.1.7.99
f4b9e000 f4b9f000 r-xp /usr/lib/libresponse.so.0.2.96
f4ba8000 f4bad000 r-xp /usr/lib/libproc-stat.so.0.2.96
f644f000 f6555000 r-xp /usr/lib/libicuuc.so.57.1
f656b000 f66f3000 r-xp /usr/lib/libicui18n.so.57.1
f6703000 f6710000 r-xp /usr/lib/libail.so.0.1.0
f6719000 f6720000 r-xp /usr/lib/libminizip.so.1.0.0
f6729000 f68d2000 r-xp /usr/lib/libcrypto.so.1.0.0
f68f2000 f6939000 r-xp /usr/lib/libssl.so.1.0.0
f6945000 f6947000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f694f000 f6956000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f695f000 f6966000 r-xp /lib/libcrypt-2.13.so
f6997000 f699a000 r-xp /lib/libcap.so.2.21
f69a2000 f69a4000 r-xp /usr/lib/libiri.so
f69ac000 f69f5000 r-xp /usr/lib/libmdm.so.1.2.69
f69fd000 f6a03000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a0b000 f6a2e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a38000 f6a3a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a42000 f6a5f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a68000 f6a6c000 r-xp /usr/lib/libsmack.so.1.0.0
f6a75000 f6a8e000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a97000 f6a9f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6aa7000 f6aad000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ab6000 f6ab8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ac1000 f6ad1000 r-xp /lib/libresolv-2.13.so
f6ad5000 f6aed000 r-xp /usr/lib/liblzma.so.5.0.3
f6af6000 f6af8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b00000 f6b1a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b22000 f6b51000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b5a000 f6b69000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b73000 f6b7d000 r-xp /usr/lib/libsensord-shared.so
f6b86000 f6c59000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c64000 f6c7a000 r-xp /lib/libz.so.1.2.5
f6c82000 f6c87000 r-xp /usr/lib/libffi.so.5.0.10
f6c8f000 f6c90000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c98000 f6ca8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cb0000 f6cc9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cd1000 f6cd3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cdb000 f6d50000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d5a000 f6d60000 r-xp /lib/librt-2.13.so
f6d69000 f6d87000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d91000 f6d92000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d9a000 f6dbd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dc5000 f6dca000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dd2000 f6dfc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e05000 f6e1c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e24000 f6e8d000 r-xp /lib/libm-2.13.so
f6e96000 f6f2a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f3d000 f6f42000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f4a000 f6f51000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f59000 f6f83000 r-xp /usr/lib/libsensor.so.1.9.6
f6f8c000 f7058000 r-xp /usr/lib/libxml2.so.2.7.8
f7065000 f7067000 r-xp /usr/lib/libiniparser.so.0
f7070000 f7076000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f707f000 f714f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7150000 f7184000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f718d000 f71c9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71d1000 f71d4000 r-xp /usr/lib/libbundle.so.0.1.22
f71dc000 f71e2000 r-xp /usr/lib/libappsvc.so.0.1.0
f71ea000 f722b000 r-xp /usr/lib/libeina.so.1.7.99
f7234000 f724b000 r-xp /usr/lib/libecore.so.1.7.99
f7262000 f726b000 r-xp /usr/lib/libvconf.so.0.2.45
f7273000 f7287000 r-xp /lib/libpthread-2.13.so
f7292000 f729f000 r-xp /usr/lib/libaul.so.0.1.0
f72a9000 f72ab000 r-xp /lib/libdl-2.13.so
f72b4000 f72bf000 r-xp /lib/libunwind.so.8.0.1
f72ec000 f72f4000 r-xp /lib/libgcc_s-4.6.so.1
f72f5000 f7419000 r-xp /lib/libc-2.13.so
f7427000 f7429000 r-xp /usr/lib/libdlog.so.0.0.0
f7431000 f743d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7446000 f744b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7453000 f7462000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f746a000 f746e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7477000 f747a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7482000 f7484000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f748c000 f7490000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7498000 f74b5000 r-xp /lib/ld-2.13.so
f74be000 f74c1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74c1000 f74c5000 r-xp /usr/lib/libsys-assert.so
f798b000 f79fc000 rw-p [heap]
ffc2d000 ffc4e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4650)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74bf228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7456539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf715d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf715bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7167e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf716dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf716ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71a275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf719d1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf715bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7167e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf716dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf716ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf719fe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71a0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71a7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b3f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b32171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c05663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70b2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70b47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7244ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf723fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72405a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7240879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7478183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74787fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74bf5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf730c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74bef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ls   ( 4611): specific action
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 I/recorder( 4611): saving local data for es.ugr.frailty.accelerometer
06-12 13:21:25.221+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:21:25.221+0200 I/utils   ( 4608): specific action
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.221+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.light
06-12 13:21:25.221+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.221+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.221+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.221+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.231+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:233,0.910000,1.120000,0.560000
06-12 13:21:25.231+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.231+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.231+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.231+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:237,-0.080259,-0.096451,0.140563
06-12 13:21:25.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(92) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.231+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.231+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.231+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.241+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4683
06-12 13:21:25.241+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:225,2.608176,0.468993,9.554541
06-12 13:21:25.241+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.251+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.251+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.251+0200 I/light   ( 4683): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.251+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:242,2.687429,0.550180,9.415170
06-12 13:21:25.251+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.251+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.261+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.261+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.261+0200 I/utils   ( 4611): specific action
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 I/recorder( 4611): saving local data for es.ugr.frailty.light
06-12 13:21:25.261+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:21:25.261+0200 I/utils   ( 4608): specific action
06-12 13:21:25.261+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.261+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.gyroscope
06-12 13:21:25.261+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.271+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.271+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.271+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(92) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.271+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.271+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.271+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.281+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:279,2.615355,0.543171,9.456435
06-12 13:21:25.281+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.281+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.281+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.281+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.291+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:292,2.240000,0.840000,0.140000
06-12 13:21:25.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.291+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4655
06-12 13:21:25.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.301+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.301+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.301+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.311+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:310,-0.068022,-0.025630,0.041217
06-12 13:21:25.311+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.311+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.311+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.311+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.321+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:322,2.692410,0.545661,9.414009
06-12 13:21:25.321+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.331+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.331+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 I/utils   ( 4611): specific action
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.331+0200 I/recorder( 4611): saving local data for es.ugr.frailty.gyroscope
06-12 13:21:25.331+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 13:21:25.331+0200 I/utils   ( 4608): specific action
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.331+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.gravity
06-12 13:21:25.331+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.341+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.341+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.341+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(98) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.341+0200 I/light   ( 4683): es.ugr.frailty.light - capturing data
06-12 13:21:25.351+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.351+0200 I/light   ( 4683): es.ugr.frailty.light: SM-R760,12/06/2018,13:21:25:353,76.000000
06-12 13:21:25.351+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:354,2.734996,0.504886,9.473185
06-12 13:21:25.351+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.351+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.361+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 13:21:25.361+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:21:25.361+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 13:21:25.361+0200 I/heartrate( 4621): es.ugr.frailty.heartrate - capturing data
06-12 13:21:25.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.361+0200 I/heartrate( 4621): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:21:25.361+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.361+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.361+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.361+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.371+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:374,1.470000,0.630000,0.070000
06-12 13:21:25.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4655
06-12 13:21:25.381+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.391+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.391+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.391+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.391+0200 I/CAPI_WATCH_APPLICATION( 2852): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 13:21:25.391+0200 E/watchface-loader( 2852): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 13:21:25.391+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:394,0.049400,-0.062236,0.058497
06-12 13:21:25.391+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.401+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.401+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.401+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.401+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:407,2.686405,0.542496,9.415907
06-12 13:21:25.401+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.411+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.411+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.411+0200 I/utils   ( 4611): specific action
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 I/recorder( 4611): saving local data for es.ugr.frailty.gravity
06-12 13:21:25.411+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 I/utils   ( 4608): specific action
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.411+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.linearacceleration
06-12 13:21:25.411+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.421+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.421+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.421+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.431+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:433,2.711068,0.466600,9.494720
06-12 13:21:25.431+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.431+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(101) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4683
06-12 13:21:25.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.441+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.441+0200 I/light   ( 4683): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.451+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.451+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.451+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4655
06-12 13:21:25.461+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:463,-0.770000,-0.070000,0.140000
06-12 13:21:25.461+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.471+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.471+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.471+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.471+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:475,0.034670,-0.096552,0.077176
06-12 13:21:25.471+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.481+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.481+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.481+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.481+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:489,2.685655,0.540972,9.416209
06-12 13:21:25.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.491+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.491+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.491+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.491+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.501+0200 I/utils   ( 4611): specific action
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.501+0200 I/recorder( 4611): saving local data for es.ugr.frailty.linearacceleration
06-12 13:21:25.501+0200 I/utils   ( 4608): specific action
06-12 13:21:25.501+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.accelerometer
06-12 13:21:25.501+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
06-12 13:21:25.501+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(105) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.511+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.511+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.511+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.521+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:520,2.691926,0.363709,9.628718
06-12 13:21:25.521+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.521+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(34) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.521+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4655
06-12 13:21:25.521+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.521+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.531+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:532,0.350000,0.280000,0.560000
06-12 13:21:25.531+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.531+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.531+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.531+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.541+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:541,0.017061,-0.194732,0.210458
06-12 13:21:25.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.551+0200 I/light   ( 4683): es.ugr.frailty.light - capturing data
06-12 13:21:25.551+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.551+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.551+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.561+0200 I/light   ( 4683): es.ugr.frailty.light: SM-R760,12/06/2018,13:21:25:555,77.000000
06-12 13:21:25.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.561+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.561+0200 I/heartrate( 4621): es.ugr.frailty.heartrate - capturing data
06-12 13:21:25.561+0200 I/heartrate( 4621): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:21:25.561+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.561+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:561,2.690327,0.544949,9.414646
06-12 13:21:25.561+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.571+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.581+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.581+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(108) , send fd(21), pid(4611), cmd(0)
06-12 13:21:25.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.581+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.591+0200 I/CAPI_WATCH_APPLICATION( 2852): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 13:21:25.591+0200 E/watchface-loader( 2852): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 13:21:25.591+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.601+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.601+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.601+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4655
06-12 13:21:25.611+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.591+0200 I/utils   ( 4611): specific action
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4683
06-12 13:21:25.621+0200 I/recorder( 4611): saving local data for es.ugr.frailty.accelerometer
06-12 13:21:25.621+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
06-12 13:21:25.621+0200 I/utils   ( 4608): specific action
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.621+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.light
06-12 13:21:25.621+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.631+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.631+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.631+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.631+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,13:21:25:634,1.680000,0.350000,-0.210000
06-12 13:21:25.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.631+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:629,2.670390,0.399601,9.521042
06-12 13:21:25.631+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.631+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.631+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.631+0200 I/linearacceleration( 4655): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.631+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration - capturing data
06-12 13:21:25.631+0200 I/light   ( 4683): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.641+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.641+0200 I/linearacceleration( 4655): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,13:21:25:642,-0.008407,-0.155750,0.103717
06-12 13:21:25.651+0200 W/AUL     ( 4655): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4665
06-12 13:21:25.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.661+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(44) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.661+0200 I/gravity ( 4665): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.661+0200 I/gravity ( 4665): es.ugr.frailty.gravity - capturing data
06-12 13:21:25.671+0200 I/gravity ( 4665): es.ugr.frailty.gravity: SM-R760,12/06/2018,13:21:25:668,2.697565,0.544481,9.412601
06-12 13:21:25.671+0200 W/AUL     ( 4665): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4608
06-12 13:21:25.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4611
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 13:21:25.701+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 13:21:25.701+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 13:21:25.701+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 13:21:25.701+0200 E/CAPI_LOCATION_MANAGER( 4723): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 13:21:25.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.711+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4615
06-12 13:21:25.721+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 13:21:25.721+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.761+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4611)
06-12 13:21:25.771+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.771+0200 I/accelerometer( 4615): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.771+0200 I/servicemanager( 4608): request sent to service es.ugr.frailty.recorder
06-12 13:21:25.781+0200 I/servicemanager( 4608): requesting to save local data
06-12 13:21:25.781+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer - capturing data
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 I/utils   ( 4611): specific action
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4611): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 I/recorder( 4611): saving local data for es.ugr.frailty.light
06-12 13:21:25.781+0200 I/utils   ( 4608): specific action
06-12 13:21:25.781+0200 I/recorder( 4611): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.781+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.791+0200 W/CAPI_APPFW_APP_CONTROL( 4608): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 13:21:25.791+0200 I/servicemanager( 4608): requesting to save local data for es.ugr.frailty.gravity
06-12 13:21:25.791+0200 W/AUL     ( 4608): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 13:21:25.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 13:21:25.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 4618
06-12 13:21:25.791+0200 I/CAPI_WATCH_APPLICATION( 2852): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-12 13:21:25.791+0200 E/watchface-loader( 2852): watchface-loader.cpp: OnAppTimeTick(579) > 
06-12 13:21:25.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4608
06-12 13:21:25.801+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 13:21:25.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(35) , send fd(21), pid(4608), cmd(0)
06-12 13:21:25.811+0200 W/AUL     ( 4618): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4608)
06-12 13:21:25.811+0200 I/CAPI_NETWORK_CONNECTION( 4723): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 13:21:25.811+0200 I/CAPI_NETWORK_CONNECTION( 4723): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 13:21:25.811+0200 I/CAPI_NETWORK_CONNECTION( 4723): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 13:21:25.811+0200 I/CAPI_NETWORK_CONNECTION( 4723): connection.c: connection_destroy(471) > Destroy handle: 0xf72059b0
06-12 13:21:25.821+0200 I/light   ( 4683): es.ugr.frailty.light - capturing data
06-12 13:21:25.831+0200 I/heartrate( 4621): es.ugr.frailty.heartrate - capturing data
06-12 13:21:25.831+0200 I/heartrate( 4621): es.ugr.frailty.heartrate: waiting for rigth values
06-12 13:21:25.831+0200 I/light   ( 4683): es.ugr.frailty.light: SM-R760,12/06/2018,13:21:25:831,76.000000
06-12 13:21:25.831+0200 W/AUL     ( 4683): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.831+0200 I/accelerometer( 4615): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,13:21:25:788,2.648855,0.514457,9.475577
06-12 13:21:25.841+0200 W/AUL     ( 4615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 13:21:25.841+0200 I/gyroscope( 4618): request sent to service es.ugr.frailty.servicemanager
06-12 13:21:25.851+0200 W/AUL     ( 4742): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 13:21:25.851+0200 I/gyroscope( 4618): es.ugr.frailty.gyroscope - capturing data
06-12 13:21:25.861+0200 W/CRASH_MANAGER( 4737): worker.c: worker_job(1205) > 11046506c6f63152880248
